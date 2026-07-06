using System;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class TextureCache2D : TextureCache
	{
		public TextureCache2D([MetadataOffset(Offset = "0x01F90B81")] string cacheName = "")
		{
			// // TextureCache2D(String)
			// void HG::Rendering::Runtime::TextureCache2D::TextureCache2D(
			//         TextureCache2D *this,
			//         String *cacheName,
			//         MethodInfo *method)
			// {
			//   if ( !byte_18D9193DD )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TextureCache);
			//     byte_18D9193DD = 1;
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::TextureCache);
			//   HG::Rendering::Runtime::TextureCache::TextureCache((TextureCache *)this, cacheName, 1, 0LL);
			// }
			// 
		}

		private bool TextureHasMipmaps(Texture texture)
		{
			// // Boolean TextureHasMipmaps(Texture)
			// bool HG::Rendering::Runtime::TextureCache2D::TextureHasMipmaps(
			//         TextureCache2D *this,
			//         Texture *texture,
			//         MethodInfo *method)
			// {
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   RenderTexture *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9193DE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::RenderTexture);
			//     sub_18003C530(&TypeInfo::UnityEngine::Texture2D);
			//     byte_18D9193DE = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(368, 0LL) )
			//   {
			//     if ( texture && (struct Texture2D__Class *)texture.klass == TypeInfo::UnityEngine::Texture2D )
			//       return UnityEngine::Texture::get_mipmapCount(texture, 0LL) > 1;
			//     if ( sub_18003F550(texture, TypeInfo::UnityEngine::RenderTexture) )
			//     {
			//       v8 = (RenderTexture *)sub_18003F550(texture, TypeInfo::UnityEngine::RenderTexture);
			//       return UnityEngine::RenderTexture::get_useMipMap(v8, 0LL);
			//     }
			// LABEL_10:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(368, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//            (ILFixDynamicMethodWrapper_36 *)Patch,
			//            (Object *)this,
			//            (Object *)texture,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		public override bool IsCreated()
		{
			// // Boolean IsCreated()
			// bool HG::Rendering::Runtime::TextureCache2D::IsCreated(TextureCache2D *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   RenderTexture *m_Cache; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(369, 0LL) )
			//   {
			//     m_Cache = this.fields.m_Cache;
			//     if ( m_Cache )
			//       return UnityEngine::RenderTexture::IsCreated(m_Cache, 0LL);
			// LABEL_5:
			//     sub_180B536AC(m_Cache, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(369, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		protected override bool TransferToSlice(CommandBuffer cmd, int sliceIndex, Texture[] textureArray)
		{
			// // Boolean TransferToSlice(CommandBuffer, Int32, Texture[])
			// bool HG::Rendering::Runtime::TextureCache2D::TransferToSlice(
			//         TextureCache2D *this,
			//         CommandBuffer *cmd,
			//         int32_t sliceIndex,
			//         Texture__Array *textureArray,
			//         MethodInfo *method)
			// {
			//   bool v9; // si
			//   Texture *m_Cache; // rdx
			//   unsigned __int64 v11; // rcx
			//   unsigned int i; // edi
			//   int v13; // esi
			//   int v14; // esi
			//   bool result; // al
			//   int v16; // edi
			//   int v17; // edi
			//   GraphicsFormat__Enum graphicsFormat; // edi
			//   bool v19; // zf
			//   unsigned int j; // edi
			//   RenderTargetIdentifier *v21; // rax
			//   Texture *v22; // rdx
			//   RenderTargetIdentifier *v23; // rax
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   __int128 v26; // xmm1
			//   __int64 v27; // xmm0_8
			//   int v28; // eax
			//   RenderTargetIdentifier *v29; // rax
			//   Texture *v30; // rdx
			//   RenderTargetIdentifier *v31; // rax
			//   __int64 v32; // rdx
			//   __int64 v33; // rcx
			//   __int128 v34; // xmm1
			//   __int64 v35; // xmm0_8
			//   int v36; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v38; // [rsp+38h] [rbp-61h]
			//   __int64 v39; // [rsp+38h] [rbp-61h]
			//   RenderTargetIdentifier v40; // [rsp+48h] [rbp-51h] BYREF
			//   __int128 v41; // [rsp+78h] [rbp-21h]
			//   __int128 v42; // [rsp+88h] [rbp-11h]
			//   RenderTargetIdentifier v43; // [rsp+98h] [rbp-1h] BYREF
			// 
			//   v9 = 1;
			//   if ( !byte_18D9193DF )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::HGRPLogger::LogWarning<UnityEngine::Texture>);
			//     sub_18003C530(&TypeInfo::UnityEngine::RenderTexture);
			//     sub_18003C530(&TypeInfo::UnityEngine::Texture2D);
			//     sub_18003C530(&off_18D4DEC20);
			//     sub_18003C530(&off_18D4DEC30);
			//     byte_18D9193DF = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(370, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(370, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_173(
			//                Patch,
			//                (Object *)this,
			//                (Object *)cmd,
			//                sliceIndex,
			//                (Object *)textureArray,
			//                0LL);
			//     goto LABEL_67;
			//   }
			//   if ( !textureArray )
			//     return 0;
			//   if ( !textureArray.max_length.value )
			//   {
			//     if ( !textureArray.max_length.size )
			//       goto LABEL_65;
			//     if ( !sub_18003F5A0(textureArray.vector[0], TypeInfo::UnityEngine::RenderTexture) )
			//     {
			//       if ( !textureArray.max_length.size )
			//         goto LABEL_65;
			//       v11 = (unsigned __int64)textureArray.vector[0];
			//       if ( !v11 || *(struct Texture2D__Class **)v11 != TypeInfo::UnityEngine::Texture2D )
			//         return 0;
			//     }
			//   }
			//   for ( i = 1; (signed int)i < textureArray.max_length.size; ++i )
			//   {
			//     if ( i >= textureArray.max_length.size )
			//       goto LABEL_65;
			//     m_Cache = textureArray.vector[i];
			//     if ( !m_Cache )
			//       goto LABEL_67;
			//     v13 = sub_18003ED00(5LL);
			//     if ( !textureArray.max_length.size )
			//       goto LABEL_65;
			//     m_Cache = textureArray.vector[0];
			//     if ( !m_Cache )
			//       goto LABEL_67;
			//     if ( v13 != (unsigned int)sub_18003ED00(5LL) )
			//       goto LABEL_29;
			//     if ( i >= textureArray.max_length.size )
			//       goto LABEL_65;
			//     m_Cache = textureArray.vector[i];
			//     if ( !m_Cache )
			//       goto LABEL_67;
			//     v14 = sub_18003ED00(7LL);
			//     if ( !textureArray.max_length.size )
			//       goto LABEL_65;
			//     m_Cache = textureArray.vector[0];
			//     if ( !m_Cache )
			//       goto LABEL_67;
			//     if ( v14 != (unsigned int)sub_18003ED00(7LL) )
			//       goto LABEL_29;
			//     if ( !textureArray.max_length.size )
			//       goto LABEL_65;
			//     if ( !sub_18003F5A0(textureArray.vector[0], TypeInfo::UnityEngine::RenderTexture) )
			//     {
			//       if ( !textureArray.max_length.size )
			//         goto LABEL_65;
			//       v11 = (unsigned __int64)textureArray.vector[0];
			//       if ( !v11 || *(struct Texture2D__Class **)v11 != TypeInfo::UnityEngine::Texture2D )
			//       {
			// LABEL_29:
			//         HG::Rendering::HGRPLogger::LogWarning(
			//           (String *)"All the sub-textures should have the same dimensions to be handled by the texture cache.",
			//           0LL);
			//         return 0;
			//       }
			//     }
			//     v9 = 1;
			//   }
			//   m_Cache = (Texture *)this.fields.m_Cache;
			//   if ( !m_Cache )
			//     goto LABEL_67;
			//   v16 = sub_18003ED00(5LL);
			//   if ( !textureArray.max_length.size )
			//     goto LABEL_65;
			//   m_Cache = textureArray.vector[0];
			//   if ( !m_Cache )
			//     goto LABEL_67;
			//   if ( v16 == (unsigned int)sub_18003ED00(5LL) )
			//   {
			//     m_Cache = (Texture *)this.fields.m_Cache;
			//     if ( !m_Cache )
			//       goto LABEL_67;
			//     v17 = sub_18003ED00(7LL);
			//     if ( !textureArray.max_length.size )
			// LABEL_65:
			//       sub_180070270(v11, m_Cache);
			//     m_Cache = textureArray.vector[0];
			//     if ( !m_Cache )
			//       goto LABEL_67;
			//     v9 = v17 != (unsigned int)sub_18003ED00(7LL);
			//   }
			//   if ( !textureArray.max_length.size )
			//     goto LABEL_65;
			//   v11 = (unsigned __int64)textureArray.vector[0];
			//   if ( !v11 || *(struct Texture2D__Class **)v11 != TypeInfo::UnityEngine::Texture2D )
			//   {
			//     result = 1;
			//     goto LABEL_50;
			//   }
			//   v11 = (unsigned __int64)this.fields.m_Cache;
			//   if ( !v11 )
			// LABEL_67:
			//     sub_180B536AC(v11, m_Cache);
			//   graphicsFormat = UnityEngine::RenderTexture::get_graphicsFormat((RenderTexture *)v11, 0LL);
			//   if ( !textureArray.max_length.size )
			//     goto LABEL_65;
			//   m_Cache = textureArray.vector[0];
			//   if ( !m_Cache || (struct Texture2D__Class *)m_Cache.klass != TypeInfo::UnityEngine::Texture2D )
			//     goto LABEL_67;
			//   v19 = graphicsFormat == UnityEngine::Texture::get_graphicsFormat(textureArray.vector[0], 0LL);
			//   v11 = v9;
			//   result = 1;
			//   if ( !v19 )
			//     v11 = 1LL;
			//   v9 = (_DWORD)v11 != 0;
			// LABEL_50:
			//   for ( j = 0; (signed int)j < textureArray.max_length.size; ++j )
			//   {
			//     if ( j >= textureArray.max_length.size
			//       || !HG::Rendering::Runtime::TextureCache2D::TextureHasMipmaps(this, textureArray.vector[j], 0LL)
			//       && j >= textureArray.max_length.size )
			//     {
			//       goto LABEL_65;
			//     }
			//     if ( v9 )
			//     {
			//       if ( j >= textureArray.max_length.size )
			//         goto LABEL_65;
			//       v29 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v40, textureArray.vector[j], 0LL);
			//       v30 = (Texture *)this.fields.m_Cache;
			//       v42 = *(_OWORD *)&v29.m_Type;
			//       v41 = *(_OWORD *)&v29.m_BufferPointer;
			//       v39 = *(_QWORD *)&v29.m_DepthSlice;
			//       v31 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v43, v30, 0LL);
			//       if ( !cmd )
			//         sub_180B536AC(v33, v32);
			//       v34 = *(_OWORD *)&v31.m_BufferPointer;
			//       *(_OWORD *)&v40.m_Type = *(_OWORD *)&v31.m_Type;
			//       v35 = *(_QWORD *)&v31.m_DepthSlice;
			//       v36 = this.fields._.m_SliceSize * sliceIndex;
			//       *(_OWORD *)&v40.m_BufferPointer = v34;
			//       *(_QWORD *)&v40.m_DepthSlice = v35;
			//       *(_OWORD *)&v43.m_Type = v42;
			//       *(_OWORD *)&v43.m_BufferPointer = v41;
			//       *(_QWORD *)&v43.m_DepthSlice = v39;
			//       UnityEngine::Rendering::CommandBuffer::Blit(cmd, &v43, &v40, 0, j + v36, 0LL);
			//     }
			//     else
			//     {
			//       if ( j >= textureArray.max_length.size )
			//         goto LABEL_65;
			//       v21 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v40, textureArray.vector[j], 0LL);
			//       v22 = (Texture *)this.fields.m_Cache;
			//       v41 = *(_OWORD *)&v21.m_Type;
			//       v42 = *(_OWORD *)&v21.m_BufferPointer;
			//       v38 = *(_QWORD *)&v21.m_DepthSlice;
			//       v23 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v40, v22, 0LL);
			//       if ( !cmd )
			//         sub_180B536AC(v25, v24);
			//       v26 = *(_OWORD *)&v23.m_BufferPointer;
			//       *(_OWORD *)&v43.m_Type = *(_OWORD *)&v23.m_Type;
			//       v27 = *(_QWORD *)&v23.m_DepthSlice;
			//       v28 = this.fields._.m_SliceSize * sliceIndex;
			//       *(_OWORD *)&v43.m_BufferPointer = v26;
			//       *(_QWORD *)&v43.m_DepthSlice = v27;
			//       *(_OWORD *)&v40.m_Type = v41;
			//       *(_OWORD *)&v40.m_BufferPointer = v42;
			//       *(_QWORD *)&v40.m_DepthSlice = v38;
			//       UnityEngine::Rendering::CommandBuffer::CopyTexture(cmd, &v40, 0, &v43, j + v28, 0LL);
			//     }
			//     result = 1;
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		public override Texture GetTexCache()
		{
			// // Texture GetTexCache()
			// Texture *HG::Rendering::Runtime::TextureCache2D::GetTexCache(TextureCache2D *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(371, 0LL) )
			//     return (Texture *)this.fields.m_Cache;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(371, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_174(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public bool AllocTextureArray(int numTextures, int width, int height, GraphicsFormat format, bool isMipMapped)
		{
			// // Boolean AllocTextureArray(Int32, Int32, Int32, GraphicsFormat, Boolean)
			// bool HG::Rendering::Runtime::TextureCache2D::AllocTextureArray(
			//         TextureCache2D *this,
			//         int32_t numTextures,
			//         int32_t width,
			//         int32_t height,
			//         GraphicsFormat__Enum format,
			//         bool isMipMapped,
			//         MethodInfo *method)
			// {
			//   bool v11; // r12
			//   RenderTexture *v12; // rax
			//   __int64 v13; // rdx
			//   RenderTexture *m_Cache; // rcx
			//   Object_1 *v15; // r13
			//   String *m_CacheName; // rbx
			//   String *TextureAutoName; // rax
			//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
			//   PassConstructorID__Enum__Array *v19; // r8
			//   HGCamera *v20; // r9
			//   MethodInfo *depthBufferBits; // [rsp+28h] [rbp-81h]
			//   MethodInfo *P4; // [rsp+30h] [rbp-79h]
			//   RenderTextureDescriptor v24; // [rsp+48h] [rbp-61h] BYREF
			//   RenderTextureDescriptor v25; // [rsp+88h] [rbp-21h] BYREF
			// 
			//   if ( !byte_18D9193E0 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::RenderTexture);
			//     byte_18D9193E0 = 1;
			//   }
			//   memset(&v24, 0, sizeof(v24));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(372, 0LL) )
			//   {
			//     v11 = HG::Rendering::Runtime::TextureCache::AllocTextureArray((TextureCache *)this, numTextures, 0LL);
			//     this.fields._.m_NumMipLevels = HG::Rendering::Runtime::TextureCache::GetNumMips(
			//                                       (TextureCache *)this,
			//                                       width,
			//                                       height,
			//                                       0LL);
			//     UnityEngine::RenderTextureDescriptor::RenderTextureDescriptor(&v24, width, height, format, 0, 0LL);
			//     v24._dimension_k__BackingField = 5;
			//     v24._volumeDepth_k__BackingField = numTextures;
			//     UnityEngine::RenderTextureDescriptor::set_useMipMap(&v24, isMipMapped, 0LL);
			//     v24._msaaSamples_k__BackingField = 1;
			//     v12 = (RenderTexture *)sub_180004920(TypeInfo::UnityEngine::RenderTexture);
			//     v15 = (Object_1 *)v12;
			//     if ( v12 )
			//     {
			//       v25 = v24;
			//       UnityEngine::RenderTexture::RenderTexture(v12, &v25, 0LL);
			//       UnityEngine::Object::set_hideFlags(v15, HideFlags__Enum_HideAndDontSave, 0LL);
			//       UnityEngine::Texture::set_wrapMode((Texture *)v15, TextureWrapMode__Enum_Clamp, 0LL);
			//       m_CacheName = this.fields._.m_CacheName;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       TextureAutoName = UnityEngine::Rendering::CoreUtils::GetTextureAutoName(
			//                           width,
			//                           height,
			//                           format,
			//                           TextureDimension__Enum_Tex2DArray,
			//                           m_CacheName,
			//                           0,
			//                           numTextures,
			//                           0LL);
			//       UnityEngine::Object::set_name(v15, TextureAutoName, 0LL);
			//       this.fields.m_Cache = (RenderTexture *)v15;
			//       sub_1800054D0((HGRenderPathScene *)&this.fields.m_Cache, v18, v19, v20, depthBufferBits, P4);
			//       HG::Rendering::Runtime::TextureCache2D::ClearCache(this, 0LL);
			//       m_Cache = this.fields.m_Cache;
			//       if ( m_Cache )
			//       {
			//         UnityEngine::RenderTexture::Create(m_Cache, 0LL);
			//         return v11;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(m_Cache, v13);
			//   }
			//   m_Cache = (RenderTexture *)IFix::WrappersManagerImpl::GetPatch(372, 0LL);
			//   if ( !m_Cache )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_175(
			//            (ILFixDynamicMethodWrapper_2 *)m_Cache,
			//            (Object *)this,
			//            numTextures,
			//            width,
			//            height,
			//            format,
			//            isMipMapped,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		internal void ClearCache()
		{
			// // Void ClearCache()
			// void HG::Rendering::Runtime::TextureCache2D::ClearCache(TextureCache2D *this, MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   RenderTexture *m_Cache; // rdx
			//   RenderTextureDescriptor *descriptor; // rax
			//   int32_t NumMips; // ebp
			//   int32_t v7; // esi
			//   RenderTexture *v8; // rbx
			//   TileBase *v9; // rdx
			//   Vector3Int *v10; // r8
			//   ITilemap *v11; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v13; // [rsp+20h] [rbp-A8h]
			//   TileAnimationData v14; // [rsp+30h] [rbp-98h] BYREF
			//   TileAnimationData v15; // [rsp+40h] [rbp-88h] BYREF
			//   RenderTextureDescriptor v16; // [rsp+88h] [rbp-40h] BYREF
			// 
			//   if ( !byte_18D9193E1 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Graphics);
			//     byte_18D9193E1 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(373, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(373, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v3, m_Cache);
			//   }
			//   m_Cache = this.fields.m_Cache;
			//   if ( !m_Cache )
			//     goto LABEL_12;
			//   descriptor = UnityEngine::RenderTexture::get_descriptor(&v16, m_Cache, 0LL);
			//   if ( (_mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&descriptor._dimension_k__BackingField, 12)) & 1) != 0 )
			//   {
			//     NumMips = HG::Rendering::Runtime::TextureCache::GetNumMips(
			//                 (TextureCache *)this,
			//                 *(_OWORD *)&descriptor._width_k__BackingField,
			//                 HIDWORD(*(_QWORD *)&descriptor._width_k__BackingField),
			//                 0LL);
			//     v7 = 0;
			//     if ( NumMips <= 0 )
			//       return;
			//   }
			//   else
			//   {
			//     NumMips = 1;
			//     v7 = 0;
			//   }
			//   do
			//   {
			//     v8 = this.fields.m_Cache;
			//     sub_180002C70(TypeInfo::UnityEngine::Graphics);
			//     UnityEngine::Graphics::SetRenderTarget(v8, v7, CubemapFace__Enum_Unknown, -1, 0LL);
			//     v14 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(&v15, v9, v10, v11, v13);
			//     UnityEngine::GL::Clear(0, 1, (Color *)&v14, 0LL);
			//     ++v7;
			//   }
			//   while ( v7 < NumMips );
			// }
			// 
		}

		public void Release()
		{
			// // Void Release()
			// void HG::Rendering::Runtime::TextureCache2D::Release(TextureCache2D *this, MethodInfo *method)
			// {
			//   Object_1 *m_Cache; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D9193E2 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     byte_18D9193E2 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(374, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(374, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     m_Cache = (Object_1 *)this.fields.m_Cache;
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     UnityEngine::Rendering::CoreUtils::Destroy(m_Cache, 0LL);
			//   }
			// }
			// 
		}

		internal static long GetApproxCacheSizeInByte(int nbElement, int resolution, int sliceSize)
		{
			// // Int64 GetApproxCacheSizeInByte(Int32, Int32, Int32)
			// int64_t HG::Rendering::Runtime::TextureCache2D::GetApproxCacheSizeInByte(
			//         int32_t nbElement,
			//         int32_t resolution,
			//         int32_t sliceSize,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(375, 0LL) )
			//     return (unsigned int)(int)(float)((float)((float)(8 * resolution * resolution * nbElement) * 1.33) * (float)sliceSize);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(375, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v10, v9);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_176(Patch, nbElement, resolution, sliceSize, 0LL);
			// }
			// 
			return 0L;
		}

		internal static int GetMaxCacheSizeForWeightInByte(int weight, int resolution, int sliceSize)
		{
			// // Int32 GetMaxCacheSizeForWeightInByte(Int32, Int32, Int32)
			// int32_t HG::Rendering::Runtime::TextureCache2D::GetMaxCacheSizeForWeightInByte(
			//         int32_t weight,
			//         int32_t resolution,
			//         int32_t sliceSize,
			//         MethodInfo *method)
			// {
			//   char v7; // dl
			//   __int64 v8; // rcx
			//   int v9; // r8d
			//   int32_t result; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(376, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(376, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1196(Patch, weight, resolution, sliceSize, 0LL);
			//   }
			//   else
			//   {
			//     result = sub_182592070(v8, v7, v9);
			//     if ( result < 1 )
			//     {
			//       return 1;
			//     }
			//     else if ( result > 250 )
			//     {
			//       return 250;
			//     }
			//   }
			//   return result;
			// }
			// 
			return 0;
		}

		public bool <>iFixBaseProxy_IsCreated()
		{
			// // Boolean <>iFixBaseProxy_IsCreated()
			// bool HG::Rendering::Runtime::TextureCacheCubemap::__iFixBaseProxy_IsCreated(
			//         TextureCacheCubemap *this,
			//         MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::TextureCache::IsCreated((TextureCache *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		private RenderTexture m_Cache;
	}
}
