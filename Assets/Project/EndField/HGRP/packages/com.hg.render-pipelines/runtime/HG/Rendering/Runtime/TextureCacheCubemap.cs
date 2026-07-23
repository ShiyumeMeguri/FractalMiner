using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class TextureCacheCubemap : TextureCache // TypeDefIndex: 37526
	{
		// Fields
		private RenderTexture m_Cache; // 0x48
		private const int k_NbFace = 6; // Metadata: 0x02302EF5
		private Texture2DArray m_CacheNoCubeArray; // 0x50
		private RenderTexture[] m_StagingRTs; // 0x58
		private int m_NumPanoMipLevels; // 0x60
		private Material m_CubeBlitMaterial; // 0x68
		private int m_CubeMipLevelPropName; // 0x70
		private int m_cubeSrcTexPropName; // 0x74
		private Material m_BlitCubemapFaceMaterial; // 0x78
		private MaterialPropertyBlock m_BlitCubemapFaceProperties; // 0x80
	
		// Constructors
		public TextureCacheCubemap() {} // Dummy constructor
		public TextureCacheCubemap(string cacheName = "" /* Metadata: 0x02302EF3 */, int sliceSize = 1 /* Metadata: 0x02302EF4 */) {} // 0x0000000189C710F8-0x0000000189C711E8
		// TextureCacheCubemap(String, Int32)
		void HG::Rendering::Runtime::TextureCacheCubemap::TextureCacheCubemap(
		        TextureCacheCubemap *this,
		        String *cacheName,
		        int32_t sliceSize,
		        MethodInfo *method)
		{
		  HGRenderPipelineGlobalSettings *instance; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  HGRenderPipelineRuntimeResources *renderPipelineResources; // rax
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rbx
		  Shader *blitCubeTextureFacePS; // rbx
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  MaterialPropertyBlock *v16; // rbx
		  HGRuntimeGrassQuery_Node *v17; // rdx
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  MethodInfo *v20; // [rsp+20h] [rbp-8h]
		  MethodInfo *v21; // [rsp+50h] [rbp+28h]
		
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TextureCache);
		  HG::Rendering::Runtime::TextureCache::TextureCache((TextureCache *)this, cacheName, sliceSize, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  if ( HG::Rendering::Runtime::HGRenderPipeline::get_isReady(0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings);
		    instance = HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_instance(0LL);
		    if ( !instance
		      || (renderPipelineResources = HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_renderPipelineResources(
		                                      instance,
		                                      0LL)) == 0LL
		      || (shaders = renderPipelineResources->fields.shaders) == 0LL )
		    {
		LABEL_7:
		      sub_1800D8260(v9, v8);
		    }
		    blitCubeTextureFacePS = shaders->fields.blitCubeTextureFacePS;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    this->fields.m_BlitCubemapFaceMaterial = UnityEngine::Rendering::CoreUtils::CreateEngineMaterial(
		                                               blitCubeTextureFacePS,
		                                               0,
		                                               0LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_BlitCubemapFaceMaterial, v13, v14, v15, v20);
		  }
		  v16 = (MaterialPropertyBlock *)sub_18002C620(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v16 )
		    goto LABEL_7;
		  v16->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  this->fields.m_BlitCubemapFaceProperties = v16;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_BlitCubemapFaceProperties, v17, v18, v19, v21);
		}
		
	
		// Methods
		public override bool IsCreated() => default; // 0x0000000189C707EC-0x0000000189C70844
		// Boolean IsCreated()
		bool HG::Rendering::Runtime::TextureCacheCubemap::IsCreated(TextureCacheCubemap *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  RenderTexture *m_Cache; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(386, 0LL) )
		  {
		    m_Cache = this->fields.m_Cache;
		    if ( m_Cache )
		      return UnityEngine::RenderTexture::IsCreated(m_Cache, 0LL);
		LABEL_5:
		    sub_1800D8260(m_Cache, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(386, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		protected override bool TransferToSlice(CommandBuffer cmd, int sliceIndex, Texture[] textureArray) => default; // 0x0000000189C70BC8-0x0000000189C710F8
		// Boolean TransferToSlice(CommandBuffer, Int32, Texture[])
		bool HG::Rendering::Runtime::TextureCacheCubemap::TransferToSlice(
		        TextureCacheCubemap *this,
		        CommandBuffer *cmd,
		        int32_t sliceIndex,
		        Texture__Array *textureArray,
		        MethodInfo *method)
		{
		  unsigned int v9; // r14d
		  Texture *m_Cache; // rdx
		  unsigned __int64 v11; // rcx
		  bool v12; // r15
		  unsigned int i; // ebx
		  int v14; // r14d
		  int v15; // r14d
		  bool result; // al
		  int v17; // ebx
		  int v18; // ebx
		  GraphicsFormat__Enum graphicsFormat; // ebx
		  bool v20; // zf
		  int32_t v21; // ebx
		  RenderTargetIdentifier *v22; // rax
		  __int128 v23; // xmm6
		  __int128 v24; // xmm7
		  __int64 v25; // xmm8_8
		  RenderTargetIdentifier *v26; // rax
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  __int128 v29; // xmm1
		  __int64 v30; // xmm0_8
		  int v31; // eax
		  MaterialPropertyBlock *m_BlitCubemapFaceProperties; // rbx
		  MaterialPropertyBlock *v33; // rbx
		  RenderTargetIdentifier *v34; // rax
		  __int128 v35; // xmm8
		  __int128 v36; // xmm9
		  __int64 v37; // xmm7_8
		  MethodInfo *v38; // rdx
		  Quaternion *identity; // rax
		  int32_t m_SliceSize; // ebx
		  __m128i v41; // xmm6
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int j; // [rsp+48h] [rbp-C0h]
		  RenderTargetIdentifier v44; // [rsp+58h] [rbp-B0h] BYREF
		  __m128i v45; // [rsp+88h] [rbp-80h] BYREF
		  RenderTargetIdentifier v46; // [rsp+98h] [rbp-70h] BYREF
		  Quaternion v47; // [rsp+C8h] [rbp-40h] BYREF
		
		  v9 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(387, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(387, 0LL);
		    if ( !Patch )
		      goto LABEL_57;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_179(
		             Patch,
		             (Object *)this,
		             (Object *)cmd,
		             sliceIndex,
		             (Object *)textureArray,
		             0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TextureCache);
		    if ( HG::Rendering::Runtime::TextureCache::get_supportsCubemapArrayTextures(0LL) )
		    {
		      if ( textureArray && textureArray->max_length.value )
		      {
		        v12 = 1;
		        for ( i = 1; (signed int)i < textureArray->max_length.size; ++i )
		        {
		          if ( i >= textureArray->max_length.size )
		            goto LABEL_54;
		          m_Cache = textureArray->vector[i];
		          if ( !m_Cache )
		            goto LABEL_57;
		          v14 = sub_180002F70(5LL, m_Cache);
		          if ( !textureArray->max_length.size )
		            goto LABEL_54;
		          m_Cache = textureArray->vector[0];
		          if ( !m_Cache )
		            goto LABEL_57;
		          if ( v14 != (unsigned int)sub_180002F70(5LL, m_Cache) )
		            goto LABEL_18;
		          if ( i >= textureArray->max_length.size )
		            goto LABEL_54;
		          m_Cache = textureArray->vector[i];
		          if ( !m_Cache )
		            goto LABEL_57;
		          v15 = sub_180002F70(7LL, m_Cache);
		          if ( !textureArray->max_length.size )
		            goto LABEL_54;
		          m_Cache = textureArray->vector[0];
		          if ( !m_Cache )
		            goto LABEL_57;
		          if ( v15 != (unsigned int)sub_180002F70(7LL, m_Cache) )
		          {
		LABEL_18:
		            HG::Rendering::HGRPLogger::LogWarning(
		              (String *)"All the sub-textures should have the same dimensions to be handled by the texture cache.",
		              0LL);
		            return 0;
		          }
		          v9 = 0;
		        }
		        m_Cache = (Texture *)this->fields.m_Cache;
		        if ( !m_Cache )
		          goto LABEL_57;
		        v17 = sub_180002F70(5LL, m_Cache);
		        if ( !textureArray->max_length.size )
		          goto LABEL_54;
		        m_Cache = textureArray->vector[0];
		        if ( !m_Cache )
		          goto LABEL_57;
		        if ( v17 == (unsigned int)sub_180002F70(5LL, m_Cache) )
		        {
		          m_Cache = (Texture *)this->fields.m_Cache;
		          if ( !m_Cache )
		            goto LABEL_57;
		          v18 = sub_180002F70(7LL, m_Cache);
		          if ( !textureArray->max_length.size )
		            goto LABEL_54;
		          m_Cache = textureArray->vector[0];
		          if ( !m_Cache )
		            goto LABEL_57;
		          v12 = v18 != (unsigned int)sub_180002F70(7LL, m_Cache);
		        }
		        if ( !textureArray->max_length.size )
		          goto LABEL_54;
		        v11 = (unsigned __int64)textureArray->vector[0];
		        if ( !v11 || *(struct Cubemap__Class **)v11 != TypeInfo::UnityEngine::Cubemap )
		        {
		          result = 1;
		          goto LABEL_39;
		        }
		        v11 = (unsigned __int64)this->fields.m_Cache;
		        if ( v11 )
		        {
		          graphicsFormat = UnityEngine::RenderTexture::get_graphicsFormat((RenderTexture *)v11, 0LL);
		          if ( !textureArray->max_length.size )
		            goto LABEL_54;
		          m_Cache = textureArray->vector[0];
		          if ( m_Cache && (struct Cubemap__Class *)m_Cache->klass == TypeInfo::UnityEngine::Cubemap )
		          {
		            v20 = graphicsFormat == UnityEngine::Texture::get_graphicsFormat(textureArray->vector[0], 0LL);
		            v11 = v12;
		            result = 1;
		            if ( !v20 )
		              v11 = 1LL;
		            v12 = (_DWORD)v11 != 0;
		            while ( 1 )
		            {
		LABEL_39:
		              if ( (signed int)v9 >= textureArray->max_length.size )
		                return result;
		              if ( !v12 )
		                break;
		              m_BlitCubemapFaceProperties = this->fields.m_BlitCubemapFaceProperties;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		              if ( v9 >= textureArray->max_length.size )
		                goto LABEL_54;
		              if ( !m_BlitCubemapFaceProperties )
		                goto LABEL_57;
		              UnityEngine::MaterialPropertyBlock::SetTextureImpl(
		                m_BlitCubemapFaceProperties,
		                TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InputTex,
		                textureArray->vector[v9],
		                0LL);
		              v11 = (unsigned __int64)this->fields.m_BlitCubemapFaceProperties;
		              if ( !v11 )
		                goto LABEL_57;
		              UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                (MaterialPropertyBlock *)v11,
		                TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LoD,
		                0.0,
		                0LL);
		              for ( j = 0; j < 6; ++j )
		              {
		                v33 = this->fields.m_BlitCubemapFaceProperties;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                if ( !v33 )
		                  goto LABEL_57;
		                UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                  v33,
		                  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FaceIndex,
		                  (float)j,
		                  0LL);
		                v34 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                        &v44,
		                        (Texture *)this->fields.m_Cache,
		                        0LL);
		                v35 = *(_OWORD *)&v34->m_Type;
		                v36 = *(_OWORD *)&v34->m_BufferPointer;
		                v37 = *(_QWORD *)&v34->m_DepthSlice;
		                identity = UnityEngine::Quaternion::get_identity(&v47, v38);
		                m_SliceSize = this->fields._.m_SliceSize;
		                v41 = _mm_loadu_si128((const __m128i *)identity);
		                sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		                v45 = v41;
		                *(_OWORD *)&v44.m_Type = v35;
		                *(_OWORD *)&v44.m_BufferPointer = v36;
		                *(_QWORD *)&v44.m_DepthSlice = v37;
		                UnityEngine::Rendering::CoreUtils::SetRenderTarget(
		                  cmd,
		                  &v44,
		                  ClearFlag__Enum_None,
		                  (Color *)&v45,
		                  0,
		                  CubemapFace__Enum_Unknown,
		                  j + 6 * (v9 + sliceIndex * m_SliceSize),
		                  0LL);
		                UnityEngine::Rendering::CoreUtils::DrawFullScreen(
		                  cmd,
		                  this->fields.m_BlitCubemapFaceMaterial,
		                  this->fields.m_BlitCubemapFaceProperties,
		                  0,
		                  0LL);
		                result = 1;
		              }
		LABEL_52:
		              ++v9;
		            }
		            v21 = 0;
		            while ( v9 < textureArray->max_length.size )
		            {
		              v22 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v44, textureArray->vector[v9], 0LL);
		              v23 = *(_OWORD *)&v22->m_Type;
		              v24 = *(_OWORD *)&v22->m_BufferPointer;
		              v25 = *(_QWORD *)&v22->m_DepthSlice;
		              v26 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                      &v44,
		                      (Texture *)this->fields.m_Cache,
		                      0LL);
		              if ( !cmd )
		                sub_1800D8260(v28, v27);
		              v29 = *(_OWORD *)&v26->m_BufferPointer;
		              *(_OWORD *)&v46.m_Type = *(_OWORD *)&v26->m_Type;
		              v30 = *(_QWORD *)&v26->m_DepthSlice;
		              v31 = this->fields._.m_SliceSize * sliceIndex;
		              *(_OWORD *)&v46.m_BufferPointer = v29;
		              *(_QWORD *)&v46.m_DepthSlice = v30;
		              *(_OWORD *)&v44.m_Type = v23;
		              *(_OWORD *)&v44.m_BufferPointer = v24;
		              *(_QWORD *)&v44.m_DepthSlice = v25;
		              UnityEngine::Rendering::CommandBuffer::CopyTexture(cmd, &v44, v21, &v46, v21 + 6 * (v9 + v31), 0LL);
		              result = 1;
		              if ( ++v21 >= 6 )
		                goto LABEL_52;
		            }
		LABEL_54:
		            sub_1800D2AB0(v11, m_Cache);
		          }
		        }
		LABEL_57:
		        sub_1800D8260(v11, m_Cache);
		      }
		      return 0;
		    }
		    else
		    {
		      return HG::Rendering::Runtime::TextureCacheCubemap::TransferToPanoCache(this, cmd, sliceIndex, textureArray, 0LL);
		    }
		  }
		}
		
		public override Texture GetTexCache() => default; // 0x0000000189C7077C-0x0000000189C707EC
		// Texture GetTexCache()
		Texture *HG::Rendering::Runtime::TextureCacheCubemap::GetTexCache(TextureCacheCubemap *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(389, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(389, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_180(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TextureCache);
		    if ( HG::Rendering::Runtime::TextureCache::get_supportsCubemapArrayTextures(0LL) )
		      return (Texture *)this->fields.m_Cache;
		    else
		      return (Texture *)this->fields.m_CacheNoCubeArray;
		  }
		}
		
		public bool AllocTextureArray(int numCubeMaps, int width, GraphicsFormat format, bool isMipMapped, Material cubeBlitMaterial) => default; // 0x0000000189C6FFDC-0x0000000189C7050C
		// Boolean AllocTextureArray(Int32, Int32, GraphicsFormat, Boolean, Material)
		bool HG::Rendering::Runtime::TextureCacheCubemap::AllocTextureArray(
		        TextureCacheCubemap *this,
		        int32_t numCubeMaps,
		        int32_t width,
		        GraphicsFormat__Enum format,
		        bool isMipMapped,
		        Material *cubeBlitMaterial,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  RenderTexture *v14; // rax
		  String *RenderTargetAutoName; // rdx
		  RenderTexture *m_Cache; // rcx
		  Object_1 *v17; // r15
		  String *m_CacheName; // rbx
		  String *TextureAutoName; // rax
		  HGRuntimeGrassQuery_Node *v20; // rdx
		  HGRuntimeGrassQuery_Node *v21; // r8
		  Int32__Array **v22; // r9
		  Texture2DArray *v23; // rax
		  Object_1 *v24; // r15
		  String *v25; // rbx
		  int v26; // esi
		  int v27; // ebx
		  String *v28; // rax
		  HGRuntimeGrassQuery_Node *v29; // rdx
		  HGRuntimeGrassQuery_Node *v30; // r8
		  Int32__Array **v31; // r9
		  unsigned int NumMips; // eax
		  HGRuntimeGrassQuery_Node *v33; // rdx
		  HGRuntimeGrassQuery_Node *v34; // r8
		  Int32__Array **v35; // r9
		  unsigned int v36; // r15d
		  int32_t v37; // edi
		  int32_t v38; // esi
		  RenderTexture *v39; // rax
		  Object_1 *v40; // rbx
		  RenderTexture__Array *v41; // rdi
		  int32_t v42; // esi
		  int32_t v43; // edi
		  Object *v44; // rax
		  String *v45; // rbx
		  Object_1 *m_CubeBlitMaterial; // rbx
		  MethodInfo *depthBufferBits; // [rsp+28h] [rbp-B1h]
		  MethodInfo *depthBufferBitsb; // [rsp+28h] [rbp-B1h]
		  String *depthBufferBitsc; // [rsp+28h] [rbp-B1h]
		  MethodInfo *depthBufferBitsd; // [rsp+28h] [rbp-B1h]
		  MethodInfo *depthBufferBitsa; // [rsp+28h] [rbp-B1h]
		  int32_t depth; // [rsp+38h] [rbp-A1h]
		  bool v54; // [rsp+58h] [rbp-81h]
		  int widtha; // [rsp+5Ch] [rbp-7Dh]
		  int height; // [rsp+60h] [rbp-79h]
		  RenderTexture__Array *m_StagingRTs; // [rsp+68h] [rbp-71h] BYREF
		  RenderTextureDescriptor v58; // [rsp+70h] [rbp-69h] BYREF
		  Object_1 *v59; // [rsp+A8h] [rbp-31h]
		  RenderTextureDescriptor v60; // [rsp+B8h] [rbp-21h] BYREF
		
		  memset(&v58, 0, sizeof(v58));
		  if ( !IFix::WrappersManagerImpl::IsPatched(390, 0LL) )
		  {
		    v54 = HG::Rendering::Runtime::TextureCache::AllocTextureArray((TextureCache *)this, numCubeMaps, 0LL);
		    this->fields._.m_NumMipLevels = HG::Rendering::Runtime::TextureCache::GetNumMips(
		                                      (TextureCache *)this,
		                                      width,
		                                      width,
		                                      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TextureCache);
		    if ( HG::Rendering::Runtime::TextureCache::get_supportsCubemapArrayTextures(0LL) )
		    {
		      UnityEngine::RenderTextureDescriptor::RenderTextureDescriptor(&v58, width, width, format, 0, 0LL);
		      v58._dimension_k__BackingField = 6;
		      v58._volumeDepth_k__BackingField = 6 * numCubeMaps;
		      UnityEngine::RenderTextureDescriptor::set_autoGenerateMips(&v58, 0, 0LL);
		      UnityEngine::RenderTextureDescriptor::set_useMipMap(&v58, isMipMapped, 0LL);
		      v58._msaaSamples_k__BackingField = 1;
		      v14 = (RenderTexture *)sub_18002C620(TypeInfo::UnityEngine::RenderTexture);
		      v17 = (Object_1 *)v14;
		      if ( v14 )
		      {
		        v60 = v58;
		        UnityEngine::RenderTexture::RenderTexture(v14, &v60, 0LL);
		        UnityEngine::Object::set_hideFlags(v17, HideFlags__Enum_HideAndDontSave, 0LL);
		        UnityEngine::Texture::set_wrapMode((Texture *)v17, TextureWrapMode__Enum_Clamp, 0LL);
		        UnityEngine::Texture::set_filterMode((Texture *)v17, FilterMode__Enum_Trilinear, 0LL);
		        UnityEngine::Texture::set_anisoLevel((Texture *)v17, 0, 0LL);
		        m_CacheName = this->fields._.m_CacheName;
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		        TextureAutoName = UnityEngine::Rendering::CoreUtils::GetTextureAutoName(
		                            width,
		                            width,
		                            format,
		                            (TextureDimension__Enum)v58._dimension_k__BackingField,
		                            m_CacheName,
		                            isMipMapped,
		                            numCubeMaps,
		                            0LL);
		        UnityEngine::Object::set_name(v17, TextureAutoName, 0LL);
		        this->fields.m_Cache = (RenderTexture *)v17;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_Cache, v20, v21, v22, depthBufferBitsb);
		        HG::Rendering::Runtime::TextureCacheCubemap::ClearCache(this, 0LL);
		        m_Cache = this->fields.m_Cache;
		        if ( m_Cache )
		        {
		          UnityEngine::RenderTexture::Create(m_Cache, 0LL);
		          return v54;
		        }
		      }
		    }
		    else
		    {
		      this->fields.m_CubeBlitMaterial = cubeBlitMaterial;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_CubeBlitMaterial, v11, v12, v13, depthBufferBits);
		      widtha = 4 * width;
		      height = 2 * width;
		      v23 = (Texture2DArray *)sub_18002C620(TypeInfo::UnityEngine::Texture2DArray);
		      v24 = (Object_1 *)v23;
		      if ( v23 )
		      {
		        UnityEngine::Texture2DArray::Texture2DArray(
		          v23,
		          4 * width,
		          2 * width,
		          numCubeMaps,
		          format,
		          (TextureCreationFlags__Enum)isMipMapped,
		          0LL);
		        UnityEngine::Object::set_hideFlags(v24, HideFlags__Enum_HideAndDontSave, 0LL);
		        UnityEngine::Texture::set_wrapMode((Texture *)v24, TextureWrapMode__Enum_Repeat, 0LL);
		        UnityEngine::Texture::set_wrapModeV((Texture *)v24, TextureWrapMode__Enum_Clamp, 0LL);
		        UnityEngine::Texture::set_filterMode((Texture *)v24, FilterMode__Enum_Trilinear, 0LL);
		        UnityEngine::Texture::set_anisoLevel((Texture *)v24, 0, 0LL);
		        v25 = this->fields._.m_CacheName;
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		        depth = numCubeMaps;
		        v26 = 2 * width;
		        depthBufferBitsc = v25;
		        v27 = 4 * width;
		        v28 = UnityEngine::Rendering::CoreUtils::GetTextureAutoName(
		                widtha,
		                height,
		                format,
		                TextureDimension__Enum_Tex2DArray,
		                depthBufferBitsc,
		                0,
		                depth,
		                0LL);
		        UnityEngine::Object::set_name(v24, v28, 0LL);
		        this->fields.m_CacheNoCubeArray = (Texture2DArray *)v24;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_CacheNoCubeArray, v29, v30, v31, depthBufferBitsd);
		        if ( isMipMapped )
		          NumMips = HG::Rendering::Runtime::TextureCache::GetNumMips((TextureCache *)this, widtha, height, 0LL);
		        else
		          NumMips = 1;
		        this->fields.m_NumPanoMipLevels = NumMips;
		        this->fields.m_StagingRTs = (RenderTexture__Array *)il2cpp_array_new_specific_1(
		                                                              TypeInfo::UnityEngine::RenderTexture,
		                                                              NumMips);
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_StagingRTs, v33, v34, v35, depthBufferBitsa);
		        v36 = 0;
		        if ( this->fields.m_NumPanoMipLevels <= 0 )
		        {
		LABEL_27:
		          m_CubeBlitMaterial = (Object_1 *)this->fields.m_CubeBlitMaterial;
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Implicit(m_CubeBlitMaterial, 0LL) )
		          {
		            this->fields.m_CubeMipLevelPropName = UnityEngine::Shader::PropertyToID((String *)"_cubeMipLvl", 0LL);
		            this->fields.m_cubeSrcTexPropName = UnityEngine::Shader::PropertyToID((String *)"_srcCubeTexture", 0LL);
		          }
		          return v54;
		        }
		        while ( 1 )
		        {
		          m_StagingRTs = this->fields.m_StagingRTs;
		          v37 = v27 >> (v36 & 0x1F);
		          if ( v37 < 1 )
		            v37 = 1;
		          v38 = v26 >> (v36 & 0x1F);
		          if ( v38 < 1 )
		            v38 = 1;
		          v39 = (RenderTexture *)sub_18002C620(TypeInfo::UnityEngine::RenderTexture);
		          v40 = (Object_1 *)v39;
		          if ( !v39 )
		            break;
		          UnityEngine::RenderTexture::RenderTexture(v39, v37, v38, 0, format, 0LL);
		          UnityEngine::Object::set_hideFlags(v40, HideFlags__Enum_HideAndDontSave, 0LL);
		          v41 = m_StagingRTs;
		          if ( !m_StagingRTs )
		            break;
		          sub_180031B10(m_StagingRTs, v40);
		          sub_180378FEC(v41, (int)v36, v40);
		          m_Cache = (RenderTexture *)this->fields.m_StagingRTs;
		          if ( !m_Cache )
		            break;
		          if ( v36 >= LODWORD(m_Cache[1].klass) )
		            sub_1800D2AB0(m_Cache, RenderTargetAutoName);
		          v59 = (Object_1 *)*((_QWORD *)&m_Cache[1].monitor + (int)v36);
		          v42 = widtha >> (v36 & 0x1F);
		          if ( v42 < 1 )
		            v42 = 1;
		          v43 = height >> (v36 & 0x1F);
		          if ( v43 < 1 )
		            v43 = 1;
		          LODWORD(m_StagingRTs) = v36;
		          v44 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &m_StagingRTs);
		          v45 = System::String::Format((String *)"PanaCache{0}", v44, 0LL);
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		          RenderTargetAutoName = UnityEngine::Rendering::CoreUtils::GetRenderTargetAutoName(
		                                   v42,
		                                   v43,
		                                   1,
		                                   format,
		                                   v45,
		                                   0,
		                                   0,
		                                   MSAASamples__Enum_None,
		                                   0LL);
		          if ( !v59 )
		            break;
		          UnityEngine::Object::set_name(v59, RenderTargetAutoName, 0LL);
		          if ( (signed int)++v36 >= this->fields.m_NumPanoMipLevels )
		            goto LABEL_27;
		          v27 = widtha;
		          v26 = height;
		        }
		      }
		    }
		LABEL_31:
		    sub_1800D8260(m_Cache, RenderTargetAutoName);
		  }
		  m_Cache = (RenderTexture *)IFix::WrappersManagerImpl::GetPatch(390, 0LL);
		  if ( !m_Cache )
		    goto LABEL_31;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_184(
		           (ILFixDynamicMethodWrapper_2 *)m_Cache,
		           (Object *)this,
		           numCubeMaps,
		           width,
		           format,
		           isMipMapped,
		           (Object *)cubeBlitMaterial,
		           0LL);
		}
		
		internal void ClearCache() {} // 0x0000000189C7050C-0x0000000189C70624
		// Void ClearCache()
		void HG::Rendering::Runtime::TextureCacheCubemap::ClearCache(TextureCacheCubemap *this, MethodInfo *method)
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
		
		  if ( IFix::WrappersManagerImpl::IsPatched(391, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(391, 0LL);
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
		
		public void Release() {} // 0x0000000189C70844-0x0000000189C70958
		// Void Release()
		void HG::Rendering::Runtime::TextureCacheCubemap::Release(TextureCacheCubemap *this, MethodInfo *method)
		{
		  Object_1 *m_CacheNoCubeArray; // rbx
		  Object_1 *v4; // rbx
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  unsigned int v8; // ebx
		  RenderTexture__Array *m_StagingRTs; // rcx
		  Object_1 *m_CubeBlitMaterial; // rbx
		  Object_1 *m_BlitCubemapFaceMaterial; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(392, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(392, 0LL);
		    if ( !Patch )
		      goto LABEL_12;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_CacheNoCubeArray = (Object_1 *)this->fields.m_CacheNoCubeArray;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit(m_CacheNoCubeArray, 0LL) )
		    {
		      v4 = (Object_1 *)this->fields.m_CacheNoCubeArray;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::Destroy(v4, 0LL);
		      v8 = 0;
		      if ( this->fields.m_NumPanoMipLevels > 0 )
		      {
		        while ( 1 )
		        {
		          m_StagingRTs = this->fields.m_StagingRTs;
		          if ( !m_StagingRTs )
		            break;
		          if ( v8 >= m_StagingRTs->max_length.size )
		            sub_1800D2AB0(m_StagingRTs, v5);
		          m_StagingRTs = (RenderTexture__Array *)m_StagingRTs->vector[v8];
		          if ( !m_StagingRTs )
		            break;
		          UnityEngine::RenderTexture::Release((RenderTexture *)m_StagingRTs, 0LL);
		          if ( (signed int)++v8 >= this->fields.m_NumPanoMipLevels )
		            goto LABEL_8;
		        }
		LABEL_12:
		        sub_1800D8260(m_StagingRTs, v5);
		      }
		LABEL_8:
		      this->fields.m_StagingRTs = 0LL;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_StagingRTs, v5, v6, v7, v13);
		      m_CubeBlitMaterial = (Object_1 *)this->fields.m_CubeBlitMaterial;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::Destroy(m_CubeBlitMaterial, 0LL);
		    }
		    m_BlitCubemapFaceMaterial = (Object_1 *)this->fields.m_BlitCubemapFaceMaterial;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    UnityEngine::Rendering::CoreUtils::Destroy(m_BlitCubemapFaceMaterial, 0LL);
		    UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)this->fields.m_Cache, 0LL);
		  }
		}
		
		private bool TransferToPanoCache(CommandBuffer cmd, int sliceIndex, Texture[] textureArray) => default; // 0x0000000189C70958-0x0000000189C70BC8
		// Boolean TransferToPanoCache(CommandBuffer, Int32, Texture[])
		bool HG::Rendering::Runtime::TextureCacheCubemap::TransferToPanoCache(
		        TextureCacheCubemap *this,
		        CommandBuffer *cmd,
		        int32_t sliceIndex,
		        Texture__Array *textureArray,
		        MethodInfo *method)
		{
		  RenderTexture__Array *m_StagingRTs; // rdx
		  Material *m_CubeBlitMaterial; // rcx
		  int32_t v11; // edi
		  int32_t v12; // esi
		  int v13; // eax
		  RenderTargetIdentifier *v14; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  __int128 v17; // xmm1
		  Material *v18; // r9
		  int32_t i; // esi
		  RenderTargetIdentifier *v20; // rax
		  __int128 v21; // xmm6
		  __int128 v22; // xmm7
		  __int64 v23; // xmm8_8
		  RenderTargetIdentifier *v24; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  __int128 v27; // xmm1
		  __int64 v28; // xmm0_8
		  int v29; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RenderTargetIdentifier v32; // [rsp+48h] [rbp-51h] BYREF
		  RenderTargetIdentifier v33[2]; // [rsp+78h] [rbp-21h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(388, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(388, 0LL);
		    if ( !Patch )
		      goto LABEL_25;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_179(
		             Patch,
		             (Object *)this,
		             (Object *)cmd,
		             sliceIndex,
		             (Object *)textureArray,
		             0LL);
		  }
		  else
		  {
		    v11 = 0;
		    if ( !textureArray )
		      goto LABEL_25;
		    while ( v11 < textureArray->max_length.size )
		    {
		      if ( (unsigned int)v11 >= textureArray->max_length.size )
		LABEL_22:
		        sub_1800D2AB0(m_CubeBlitMaterial, m_StagingRTs);
		      m_CubeBlitMaterial = this->fields.m_CubeBlitMaterial;
		      if ( !m_CubeBlitMaterial )
		        goto LABEL_25;
		      UnityEngine::Material::SetTextureImpl(
		        m_CubeBlitMaterial,
		        this->fields.m_cubeSrcTexPropName,
		        textureArray->vector[v11],
		        0LL);
		      v12 = 0;
		      if ( this->fields.m_NumPanoMipLevels > 0 )
		      {
		        while ( 1 )
		        {
		          v13 = this->fields._.m_NumMipLevels - 1;
		          m_CubeBlitMaterial = this->fields.m_CubeBlitMaterial;
		          if ( !m_CubeBlitMaterial )
		            break;
		          if ( v13 >= v12 )
		            v13 = v12;
		          UnityEngine::Material::SetFloatImpl(m_CubeBlitMaterial, this->fields.m_CubeMipLevelPropName, (float)v13, 0LL);
		          m_StagingRTs = this->fields.m_StagingRTs;
		          if ( !m_StagingRTs )
		            break;
		          if ( (unsigned int)v12 >= m_StagingRTs->max_length.size )
		            goto LABEL_22;
		          v14 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                  v33,
		                  (Texture *)m_StagingRTs->vector[v12],
		                  0LL);
		          if ( !cmd )
		            sub_1800D8260(v16, v15);
		          v17 = *(_OWORD *)&v14->m_BufferPointer;
		          v18 = this->fields.m_CubeBlitMaterial;
		          *(_OWORD *)&v32.m_Type = *(_OWORD *)&v14->m_Type;
		          *(_QWORD *)&v32.m_DepthSlice = *(_QWORD *)&v14->m_DepthSlice;
		          *(_OWORD *)&v32.m_BufferPointer = v17;
		          UnityEngine::Rendering::CommandBuffer::Blit(cmd, 0LL, &v32, v18, 0, 0LL);
		          if ( ++v12 >= this->fields.m_NumPanoMipLevels )
		            goto LABEL_14;
		        }
		LABEL_25:
		        sub_1800D8260(m_CubeBlitMaterial, m_StagingRTs);
		      }
		LABEL_14:
		      for ( i = 0;
		            i < this->fields.m_NumPanoMipLevels;
		            UnityEngine::Rendering::CommandBuffer::CopyTexture(cmd, v33, 0, 0, &v32, v11 + v29, i++, 0LL) )
		      {
		        m_StagingRTs = this->fields.m_StagingRTs;
		        if ( !m_StagingRTs )
		          goto LABEL_25;
		        if ( (unsigned int)i >= m_StagingRTs->max_length.size )
		          goto LABEL_22;
		        v20 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v33, (Texture *)m_StagingRTs->vector[i], 0LL);
		        v21 = *(_OWORD *)&v20->m_Type;
		        v22 = *(_OWORD *)&v20->m_BufferPointer;
		        v23 = *(_QWORD *)&v20->m_DepthSlice;
		        v24 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                v33,
		                (Texture *)this->fields.m_CacheNoCubeArray,
		                0LL);
		        if ( !cmd )
		          sub_1800D8260(v26, v25);
		        v27 = *(_OWORD *)&v24->m_BufferPointer;
		        *(_OWORD *)&v32.m_Type = *(_OWORD *)&v24->m_Type;
		        v28 = *(_QWORD *)&v24->m_DepthSlice;
		        *(_OWORD *)&v32.m_BufferPointer = v27;
		        v29 = this->fields._.m_SliceSize * sliceIndex;
		        *(_QWORD *)&v32.m_DepthSlice = v28;
		        *(_OWORD *)&v33[0].m_Type = v21;
		        *(_OWORD *)&v33[0].m_BufferPointer = v22;
		        *(_QWORD *)&v33[0].m_DepthSlice = v23;
		      }
		      ++v11;
		    }
		    return 1;
		  }
		}
		
		internal static long GetApproxCacheSizeInByte(int nbElement, int resolution, int sliceSize) => default; // 0x0000000189C70624-0x0000000189C706C0
		// Int64 GetApproxCacheSizeInByte(Int32, Int32, Int32)
		int64_t HG::Rendering::Runtime::TextureCacheCubemap::GetApproxCacheSizeInByte(
		        int32_t nbElement,
		        int32_t resolution,
		        int32_t sliceSize,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(393, 0LL) )
		    return (unsigned int)(int)(float)((float)((float)(48 * resolution * resolution * nbElement) * 1.33)
		                                    * (float)sliceSize);
		  Patch = IFix::WrappersManagerImpl::GetPatch(393, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v10, v9);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_182(Patch, nbElement, resolution, sliceSize, 0LL);
		}
		
		internal static int GetMaxCacheSizeForWeightInByte(long weight, int resolution, int sliceSize) => default; // 0x0000000189C706C0-0x0000000189C7077C
		// Int32 GetMaxCacheSizeForWeightInByte(Int64, Int32, Int32)
		int32_t HG::Rendering::Runtime::TextureCacheCubemap::GetMaxCacheSizeForWeightInByte(
		        int64_t weight,
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
		
		  if ( IFix::WrappersManagerImpl::IsPatched(394, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(394, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_185(Patch, weight, resolution, sliceSize, 0LL);
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
