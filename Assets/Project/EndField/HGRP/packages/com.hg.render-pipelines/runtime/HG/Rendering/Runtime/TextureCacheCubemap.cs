using System;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class TextureCacheCubemap : TextureCache
	{
		public TextureCacheCubemap([MetadataOffset(Offset = "0x01F90B82")] string cacheName = "", [MetadataOffset(Offset = "0x01F90B83")] int sliceSize = 1)
		{
		}

		public override bool IsCreated()
		{
			// // Boolean IsCreated()
			// bool HG::Rendering::Runtime::TextureCacheCubemap::IsCreated(TextureCacheCubemap *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   RenderTexture *m_Cache; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(377, 0LL) )
			//   {
			//     m_Cache = this.fields.m_Cache;
			//     if ( m_Cache )
			//       return UnityEngine::RenderTexture::IsCreated(m_Cache, 0LL);
			// LABEL_5:
			//     sub_180B536AC(m_Cache, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(377, 0LL);
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
			// bool HG::Rendering::Runtime::TextureCacheCubemap::TransferToSlice(
			//         TextureCacheCubemap *this,
			//         CommandBuffer *cmd,
			//         int32_t sliceIndex,
			//         Texture__Array *textureArray,
			//         MethodInfo *method)
			// {
			//   unsigned int v5; // r14d
			//   bool v10; // r15
			//   Texture *m_Cache; // rdx
			//   unsigned __int64 v12; // rcx
			//   unsigned int i; // ebx
			//   int v14; // r14d
			//   int v15; // r14d
			//   bool result; // al
			//   int v17; // ebx
			//   int v18; // ebx
			//   GraphicsFormat__Enum graphicsFormat; // ebx
			//   bool v20; // zf
			//   int32_t v21; // ebx
			//   RenderTargetIdentifier *v22; // rax
			//   __int128 v23; // xmm6
			//   __int128 v24; // xmm7
			//   __int64 v25; // xmm8_8
			//   RenderTargetIdentifier *v26; // rax
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   __int128 v29; // xmm1
			//   __int64 v30; // xmm0_8
			//   int v31; // eax
			//   MaterialPropertyBlock *m_BlitCubemapFaceProperties; // rbx
			//   MaterialPropertyBlock *v33; // rbx
			//   RenderTargetIdentifier *v34; // rax
			//   __int128 v35; // xmm8
			//   __int128 v36; // xmm9
			//   __int64 v37; // xmm7_8
			//   MethodInfo *v38; // rdx
			//   Quaternion *identity; // rax
			//   int32_t m_SliceSize; // ebx
			//   __m128i v41; // xmm6
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int j; // [rsp+48h] [rbp-C0h]
			//   RenderTargetIdentifier v44; // [rsp+58h] [rbp-B0h] BYREF
			//   __m128i v45; // [rsp+88h] [rbp-80h] BYREF
			//   RenderTargetIdentifier v46; // [rsp+98h] [rbp-70h] BYREF
			//   Quaternion v47; // [rsp+C8h] [rbp-40h] BYREF
			// 
			//   v5 = 0;
			//   v10 = 1;
			//   if ( !byte_18D9193E4 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Cubemap);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TextureCache);
			//     sub_18003C530(&off_18D4DEC20);
			//     byte_18D9193E4 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(378, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(378, 0LL);
			//     if ( !Patch )
			//       goto LABEL_59;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_173(
			//              Patch,
			//              (Object *)this,
			//              (Object *)cmd,
			//              sliceIndex,
			//              (Object *)textureArray,
			//              0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::TextureCache);
			//     if ( HG::Rendering::Runtime::TextureCache::get_supportsCubemapArrayTextures(0LL) )
			//     {
			//       if ( textureArray && textureArray.max_length.value )
			//       {
			//         for ( i = 1; (signed int)i < textureArray.max_length.size; ++i )
			//         {
			//           if ( i >= textureArray.max_length.size )
			//             goto LABEL_56;
			//           m_Cache = textureArray.vector[i];
			//           if ( !m_Cache )
			//             goto LABEL_59;
			//           v14 = sub_18003ED00(5LL);
			//           if ( !textureArray.max_length.size )
			//             goto LABEL_56;
			//           m_Cache = textureArray.vector[0];
			//           if ( !m_Cache )
			//             goto LABEL_59;
			//           if ( v14 != (unsigned int)sub_18003ED00(5LL) )
			//             goto LABEL_20;
			//           if ( i >= textureArray.max_length.size )
			//             goto LABEL_56;
			//           m_Cache = textureArray.vector[i];
			//           if ( !m_Cache )
			//             goto LABEL_59;
			//           v15 = sub_18003ED00(7LL);
			//           if ( !textureArray.max_length.size )
			//             goto LABEL_56;
			//           m_Cache = textureArray.vector[0];
			//           if ( !m_Cache )
			//             goto LABEL_59;
			//           if ( v15 != (unsigned int)sub_18003ED00(7LL) )
			//           {
			// LABEL_20:
			//             HG::Rendering::HGRPLogger::LogWarning(
			//               (String *)"All the sub-textures should have the same dimensions to be handled by the texture cache.",
			//               0LL);
			//             return 0;
			//           }
			//           v5 = 0;
			//         }
			//         m_Cache = (Texture *)this.fields.m_Cache;
			//         if ( !m_Cache )
			//           goto LABEL_59;
			//         v17 = sub_18003ED00(5LL);
			//         if ( !textureArray.max_length.size )
			//           goto LABEL_56;
			//         m_Cache = textureArray.vector[0];
			//         if ( !m_Cache )
			//           goto LABEL_59;
			//         if ( v17 == (unsigned int)sub_18003ED00(5LL) )
			//         {
			//           m_Cache = (Texture *)this.fields.m_Cache;
			//           if ( !m_Cache )
			//             goto LABEL_59;
			//           v18 = sub_18003ED00(7LL);
			//           if ( !textureArray.max_length.size )
			//             goto LABEL_56;
			//           m_Cache = textureArray.vector[0];
			//           if ( !m_Cache )
			//             goto LABEL_59;
			//           v10 = v18 != (unsigned int)sub_18003ED00(7LL);
			//         }
			//         if ( !textureArray.max_length.size )
			//           goto LABEL_56;
			//         v12 = (unsigned __int64)textureArray.vector[0];
			//         if ( !v12 || *(struct Cubemap__Class **)v12 != TypeInfo::UnityEngine::Cubemap )
			//         {
			//           result = 1;
			//           goto LABEL_41;
			//         }
			//         v12 = (unsigned __int64)this.fields.m_Cache;
			//         if ( v12 )
			//         {
			//           graphicsFormat = UnityEngine::RenderTexture::get_graphicsFormat((RenderTexture *)v12, 0LL);
			//           if ( !textureArray.max_length.size )
			//             goto LABEL_56;
			//           m_Cache = textureArray.vector[0];
			//           if ( m_Cache && (struct Cubemap__Class *)m_Cache.klass == TypeInfo::UnityEngine::Cubemap )
			//           {
			//             v20 = graphicsFormat == UnityEngine::Texture::get_graphicsFormat(textureArray.vector[0], 0LL);
			//             v12 = v10;
			//             result = 1;
			//             if ( !v20 )
			//               v12 = 1LL;
			//             v10 = (_DWORD)v12 != 0;
			//             while ( 1 )
			//             {
			// LABEL_41:
			//               if ( (signed int)v5 >= textureArray.max_length.size )
			//                 return result;
			//               if ( !v10 )
			//                 break;
			//               m_BlitCubemapFaceProperties = this.fields.m_BlitCubemapFaceProperties;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//               if ( v5 >= textureArray.max_length.size )
			//                 goto LABEL_56;
			//               if ( !m_BlitCubemapFaceProperties )
			//                 goto LABEL_59;
			//               UnityEngine::MaterialPropertyBlock::SetTextureImpl(
			//                 m_BlitCubemapFaceProperties,
			//                 TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InputTex,
			//                 textureArray.vector[v5],
			//                 0LL);
			//               v12 = (unsigned __int64)this.fields.m_BlitCubemapFaceProperties;
			//               if ( !v12 )
			//                 goto LABEL_59;
			//               UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                 (MaterialPropertyBlock *)v12,
			//                 TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LoD,
			//                 0.0,
			//                 0LL);
			//               for ( j = 0; j < 6; ++j )
			//               {
			//                 v33 = this.fields.m_BlitCubemapFaceProperties;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                 if ( !v33 )
			//                   goto LABEL_59;
			//                 UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                   v33,
			//                   TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._FaceIndex,
			//                   (float)j,
			//                   0LL);
			//                 v34 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                         &v44,
			//                         (Texture *)this.fields.m_Cache,
			//                         0LL);
			//                 v35 = *(_OWORD *)&v34.m_Type;
			//                 v36 = *(_OWORD *)&v34.m_BufferPointer;
			//                 v37 = *(_QWORD *)&v34.m_DepthSlice;
			//                 identity = UnityEngine::Quaternion::get_identity(&v47, v38);
			//                 m_SliceSize = this.fields._.m_SliceSize;
			//                 v41 = _mm_loadu_si128((const __m128i *)identity);
			//                 sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//                 v45 = v41;
			//                 *(_OWORD *)&v44.m_Type = v35;
			//                 *(_OWORD *)&v44.m_BufferPointer = v36;
			//                 *(_QWORD *)&v44.m_DepthSlice = v37;
			//                 UnityEngine::Rendering::CoreUtils::SetRenderTarget(
			//                   cmd,
			//                   &v44,
			//                   ClearFlag__Enum_None,
			//                   (Color *)&v45,
			//                   0,
			//                   CubemapFace__Enum_Unknown,
			//                   j + 6 * (v5 + sliceIndex * m_SliceSize),
			//                   0LL);
			//                 UnityEngine::Rendering::CoreUtils::DrawFullScreen(
			//                   cmd,
			//                   this.fields.m_BlitCubemapFaceMaterial,
			//                   this.fields.m_BlitCubemapFaceProperties,
			//                   0,
			//                   0LL);
			//                 result = 1;
			//               }
			// LABEL_54:
			//               ++v5;
			//             }
			//             v21 = 0;
			//             while ( v5 < textureArray.max_length.size )
			//             {
			//               v22 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v44, textureArray.vector[v5], 0LL);
			//               v23 = *(_OWORD *)&v22.m_Type;
			//               v24 = *(_OWORD *)&v22.m_BufferPointer;
			//               v25 = *(_QWORD *)&v22.m_DepthSlice;
			//               v26 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                       &v44,
			//                       (Texture *)this.fields.m_Cache,
			//                       0LL);
			//               if ( !cmd )
			//                 sub_180B536AC(v28, v27);
			//               v29 = *(_OWORD *)&v26.m_BufferPointer;
			//               *(_OWORD *)&v46.m_Type = *(_OWORD *)&v26.m_Type;
			//               v30 = *(_QWORD *)&v26.m_DepthSlice;
			//               v31 = this.fields._.m_SliceSize * sliceIndex;
			//               *(_OWORD *)&v46.m_BufferPointer = v29;
			//               *(_QWORD *)&v46.m_DepthSlice = v30;
			//               *(_OWORD *)&v44.m_Type = v23;
			//               *(_OWORD *)&v44.m_BufferPointer = v24;
			//               *(_QWORD *)&v44.m_DepthSlice = v25;
			//               UnityEngine::Rendering::CommandBuffer::CopyTexture(cmd, &v44, v21, &v46, v21 + 6 * (v5 + v31), 0LL);
			//               result = 1;
			//               if ( ++v21 >= 6 )
			//                 goto LABEL_54;
			//             }
			// LABEL_56:
			//             sub_180070270(v12, m_Cache);
			//           }
			//         }
			// LABEL_59:
			//         sub_180B536AC(v12, m_Cache);
			//       }
			//       return 0;
			//     }
			//     else
			//     {
			//       return HG::Rendering::Runtime::TextureCacheCubemap::TransferToPanoCache(this, cmd, sliceIndex, textureArray, 0LL);
			//     }
			//   }
			// }
			// 
			return default(bool);
		}

		public override Texture GetTexCache()
		{
			// // Texture GetTexCache()
			// Texture *HG::Rendering::Runtime::TextureCacheCubemap::GetTexCache(TextureCacheCubemap *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D9193E5 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TextureCache);
			//     byte_18D9193E5 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(380, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(380, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_174(Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::TextureCache);
			//     if ( HG::Rendering::Runtime::TextureCache::get_supportsCubemapArrayTextures(0LL) )
			//       return (Texture *)this.fields.m_Cache;
			//     else
			//       return (Texture *)this.fields.m_CacheNoCubeArray;
			//   }
			// }
			// 
			return null;
		}

		public bool AllocTextureArray(int numCubeMaps, int width, GraphicsFormat format, bool isMipMapped, Material cubeBlitMaterial)
		{
			// // Boolean AllocTextureArray(Int32, Int32, GraphicsFormat, Boolean, Material)
			// bool HG::Rendering::Runtime::TextureCacheCubemap::AllocTextureArray(
			//         TextureCacheCubemap *this,
			//         int32_t numCubeMaps,
			//         int32_t width,
			//         GraphicsFormat__Enum format,
			//         bool isMipMapped,
			//         Material *cubeBlitMaterial,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   RenderTexture *v14; // rax
			//   __int64 v15; // rdx
			//   RenderTexture *m_Cache; // rcx
			//   Object_1 *v17; // r15
			//   String *m_CacheName; // rbx
			//   String *TextureAutoName; // rax
			//   HGRenderPathBase_HGRenderPathResources *v20; // rdx
			//   PassConstructorID__Enum__Array *v21; // r8
			//   HGCamera *v22; // r9
			//   int32_t v23; // r13d
			//   Texture2DArray *v24; // rax
			//   Object_1 *v25; // r15
			//   String *v26; // rbx
			//   int v27; // ebx
			//   String *v28; // rax
			//   HGRenderPathBase_HGRenderPathResources *v29; // rdx
			//   PassConstructorID__Enum__Array *v30; // r8
			//   HGCamera *v31; // r9
			//   __int64 v32; // r8
			//   __int64 v33; // r9
			//   unsigned int NumMips; // eax
			//   HGRenderPathBase_HGRenderPathResources *v35; // rdx
			//   PassConstructorID__Enum__Array *v36; // r8
			//   HGCamera *v37; // r9
			//   unsigned int v38; // r15d
			//   RenderTexture__Array *m_StagingRTs; // r13
			//   int32_t v40; // edi
			//   int32_t v41; // esi
			//   RenderTexture *v42; // rax
			//   Object_1 *v43; // rbx
			//   __int64 v44; // r8
			//   Object_1 *v45; // r13
			//   int32_t v46; // esi
			//   int32_t v47; // edi
			//   Object *v48; // rax
			//   String *v49; // rbx
			//   String *RenderTargetAutoName; // rax
			//   Object_1 *m_CubeBlitMaterial; // rbx
			//   MethodInfo *depthBufferBits; // [rsp+28h] [rbp-A1h]
			//   MethodInfo *depthBufferBitsb; // [rsp+28h] [rbp-A1h]
			//   String *depthBufferBitsc; // [rsp+28h] [rbp-A1h]
			//   MethodInfo *depthBufferBitsd; // [rsp+28h] [rbp-A1h]
			//   MethodInfo *depthBufferBitsa; // [rsp+28h] [rbp-A1h]
			//   MethodInfo *flags; // [rsp+30h] [rbp-99h]
			//   MethodInfo *flagsb; // [rsp+30h] [rbp-99h]
			//   MethodInfo *flagsc; // [rsp+30h] [rbp-99h]
			//   MethodInfo *flagsa; // [rsp+30h] [rbp-99h]
			//   bool v62; // [rsp+58h] [rbp-71h]
			//   int height; // [rsp+5Ch] [rbp-6Dh]
			//   int v64; // [rsp+60h] [rbp-69h]
			//   unsigned int v65; // [rsp+64h] [rbp-65h] BYREF
			//   RenderTextureDescriptor v66; // [rsp+68h] [rbp-61h] BYREF
			//   RenderTextureDescriptor v67; // [rsp+A8h] [rbp-21h] BYREF
			// 
			//   if ( !byte_18D9193E6 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::RenderTexture);
			//     sub_18003C530(&TypeInfo::UnityEngine::RenderTexture);
			//     sub_18003C530(&TypeInfo::UnityEngine::Texture2DArray);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TextureCache);
			//     sub_18003C530(&off_18D4DE778);
			//     sub_18003C530(&off_18D4DE750);
			//     sub_18003C530(&off_18D4DE760);
			//     byte_18D9193E6 = 1;
			//   }
			//   memset(&v66, 0, sizeof(v66));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(381, 0LL) )
			//   {
			//     v62 = HG::Rendering::Runtime::TextureCache::AllocTextureArray((TextureCache *)this, numCubeMaps, 0LL);
			//     this.fields._.m_NumMipLevels = HG::Rendering::Runtime::TextureCache::GetNumMips(
			//                                       (TextureCache *)this,
			//                                       width,
			//                                       width,
			//                                       0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::TextureCache);
			//     if ( HG::Rendering::Runtime::TextureCache::get_supportsCubemapArrayTextures(0LL) )
			//     {
			//       UnityEngine::RenderTextureDescriptor::RenderTextureDescriptor(&v66, width, width, format, 0, 0LL);
			//       v66._dimension_k__BackingField = 6;
			//       v66._volumeDepth_k__BackingField = 6 * numCubeMaps;
			//       UnityEngine::RenderTextureDescriptor::set_autoGenerateMips(&v66, 0, 0LL);
			//       UnityEngine::RenderTextureDescriptor::set_useMipMap(&v66, isMipMapped, 0LL);
			//       v66._msaaSamples_k__BackingField = 1;
			//       v14 = (RenderTexture *)sub_180004920(TypeInfo::UnityEngine::RenderTexture);
			//       v17 = (Object_1 *)v14;
			//       if ( v14 )
			//       {
			//         v67 = v66;
			//         UnityEngine::RenderTexture::RenderTexture(v14, &v67, 0LL);
			//         UnityEngine::Object::set_hideFlags(v17, HideFlags__Enum_HideAndDontSave, 0LL);
			//         UnityEngine::Texture::set_wrapMode((Texture *)v17, TextureWrapMode__Enum_Clamp, 0LL);
			//         UnityEngine::Texture::set_filterMode((Texture *)v17, FilterMode__Enum_Trilinear, 0LL);
			//         UnityEngine::Texture::set_anisoLevel((Texture *)v17, 0, 0LL);
			//         m_CacheName = this.fields._.m_CacheName;
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//         TextureAutoName = UnityEngine::Rendering::CoreUtils::GetTextureAutoName(
			//                             width,
			//                             width,
			//                             format,
			//                             (TextureDimension__Enum)v66._dimension_k__BackingField,
			//                             m_CacheName,
			//                             isMipMapped,
			//                             numCubeMaps,
			//                             0LL);
			//         UnityEngine::Object::set_name(v17, TextureAutoName, 0LL);
			//         this.fields.m_Cache = (RenderTexture *)v17;
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.m_Cache, v20, v21, v22, depthBufferBitsb, flagsb);
			//         HG::Rendering::Runtime::TextureCacheCubemap::ClearCache(this, 0LL);
			//         m_Cache = this.fields.m_Cache;
			//         if ( m_Cache )
			//         {
			//           UnityEngine::RenderTexture::Create(m_Cache, 0LL);
			//           return v62;
			//         }
			//       }
			//     }
			//     else
			//     {
			//       this.fields.m_CubeBlitMaterial = cubeBlitMaterial;
			//       sub_1800054D0((HGRenderPathScene *)&this.fields.m_CubeBlitMaterial, v11, v12, v13, depthBufferBits, flags);
			//       v23 = 4 * width;
			//       v64 = 4 * width;
			//       height = 2 * width;
			//       v24 = (Texture2DArray *)sub_180004920(TypeInfo::UnityEngine::Texture2DArray);
			//       v25 = (Object_1 *)v24;
			//       if ( v24 )
			//       {
			//         UnityEngine::Texture2DArray::Texture2DArray(
			//           v24,
			//           v23,
			//           2 * width,
			//           numCubeMaps,
			//           format,
			//           (TextureCreationFlags__Enum)isMipMapped,
			//           0LL);
			//         UnityEngine::Object::set_hideFlags(v25, HideFlags__Enum_HideAndDontSave, 0LL);
			//         UnityEngine::Texture::set_wrapMode((Texture *)v25, TextureWrapMode__Enum_Repeat, 0LL);
			//         UnityEngine::Texture::set_wrapModeV((Texture *)v25, TextureWrapMode__Enum_Clamp, 0LL);
			//         UnityEngine::Texture::set_filterMode((Texture *)v25, FilterMode__Enum_Trilinear, 0LL);
			//         UnityEngine::Texture::set_anisoLevel((Texture *)v25, 0, 0LL);
			//         v26 = this.fields._.m_CacheName;
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//         depthBufferBitsc = v26;
			//         v27 = 2 * width;
			//         v28 = UnityEngine::Rendering::CoreUtils::GetTextureAutoName(
			//                 v23,
			//                 height,
			//                 format,
			//                 TextureDimension__Enum_Tex2DArray,
			//                 depthBufferBitsc,
			//                 0,
			//                 numCubeMaps,
			//                 0LL);
			//         UnityEngine::Object::set_name(v25, v28, 0LL);
			//         this.fields.m_CacheNoCubeArray = (Texture2DArray *)v25;
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.m_CacheNoCubeArray, v29, v30, v31, depthBufferBitsd, flagsc);
			//         if ( isMipMapped )
			//           NumMips = HG::Rendering::Runtime::TextureCache::GetNumMips((TextureCache *)this, v23, height, 0LL);
			//         else
			//           NumMips = 1;
			//         this.fields.m_NumPanoMipLevels = NumMips;
			//         this.fields.m_StagingRTs = (RenderTexture__Array *)il2cpp_array_new_specific_0(
			//                                                               TypeInfo::UnityEngine::RenderTexture,
			//                                                               NumMips,
			//                                                               v32,
			//                                                               v33);
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.m_StagingRTs, v35, v36, v37, depthBufferBitsa, flagsa);
			//         v38 = 0;
			//         if ( this.fields.m_NumPanoMipLevels <= 0 )
			//         {
			// LABEL_29:
			//           m_CubeBlitMaterial = (Object_1 *)this.fields.m_CubeBlitMaterial;
			//           sub_180002C70(TypeInfo::UnityEngine::Object);
			//           if ( UnityEngine::Object::op_Implicit(m_CubeBlitMaterial, 0LL) )
			//           {
			//             this.fields.m_CubeMipLevelPropName = UnityEngine::Shader::PropertyToID((String *)"_cubeMipLvl", 0LL);
			//             this.fields.m_cubeSrcTexPropName = UnityEngine::Shader::PropertyToID((String *)"_srcCubeTexture", 0LL);
			//           }
			//           return v62;
			//         }
			//         while ( 1 )
			//         {
			//           m_StagingRTs = this.fields.m_StagingRTs;
			//           v40 = v64 >> (v38 & 0x1F);
			//           if ( v40 < 1 )
			//             v40 = 1;
			//           v41 = v27 >> (v38 & 0x1F);
			//           if ( v41 < 1 )
			//             v41 = 1;
			//           v42 = (RenderTexture *)sub_180004920(TypeInfo::UnityEngine::RenderTexture);
			//           v43 = (Object_1 *)v42;
			//           if ( !v42 )
			//             break;
			//           UnityEngine::RenderTexture::RenderTexture(v42, v40, v41, 0, format, 0LL);
			//           UnityEngine::Object::set_hideFlags(v43, HideFlags__Enum_HideAndDontSave, 0LL);
			//           if ( !m_StagingRTs )
			//             break;
			//           sub_180036D40(m_StagingRTs, v43);
			//           sub_18000FDA0(m_StagingRTs, (int)v38, v43);
			//           m_Cache = (RenderTexture *)this.fields.m_StagingRTs;
			//           if ( !m_Cache )
			//             break;
			//           if ( v38 >= LODWORD(m_Cache[1].klass) )
			//             sub_180070270(m_Cache, v15);
			//           v45 = (Object_1 *)*((_QWORD *)&m_Cache[1].monitor + (int)v38);
			//           v46 = v64 >> (v38 & 0x1F);
			//           if ( v46 < 1 )
			//             v46 = 1;
			//           v47 = height >> (v38 & 0x1F);
			//           if ( v47 < 1 )
			//             v47 = 1;
			//           v65 = v38;
			//           v48 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v65, v44);
			//           v49 = System::String::Format((String *)"PanaCache{0}", v48, 0LL);
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//           RenderTargetAutoName = UnityEngine::Rendering::CoreUtils::GetRenderTargetAutoName(
			//                                    v46,
			//                                    v47,
			//                                    1,
			//                                    format,
			//                                    v49,
			//                                    0,
			//                                    0,
			//                                    MSAASamples__Enum_None,
			//                                    0LL);
			//           if ( !v45 )
			//             break;
			//           UnityEngine::Object::set_name(v45, RenderTargetAutoName, 0LL);
			//           if ( (signed int)++v38 >= this.fields.m_NumPanoMipLevels )
			//             goto LABEL_29;
			//           v27 = height;
			//         }
			//       }
			//     }
			// LABEL_33:
			//     sub_180B536AC(m_Cache, v15);
			//   }
			//   m_Cache = (RenderTexture *)IFix::WrappersManagerImpl::GetPatch(381, 0LL);
			//   if ( !m_Cache )
			//     goto LABEL_33;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_178(
			//            (ILFixDynamicMethodWrapper_2 *)m_Cache,
			//            (Object *)this,
			//            numCubeMaps,
			//            width,
			//            format,
			//            isMipMapped,
			//            (Object *)cubeBlitMaterial,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		internal void ClearCache()
		{
			// // Void ClearCache()
			// void HG::Rendering::Runtime::TextureCacheCubemap::ClearCache(TextureCacheCubemap *this, MethodInfo *method)
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
			//   if ( !byte_18D9193E7 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Graphics);
			//     byte_18D9193E7 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(382, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(382, 0LL);
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
		}

		private bool TransferToPanoCache(CommandBuffer cmd, int sliceIndex, Texture[] textureArray)
		{
			// // Boolean TransferToPanoCache(CommandBuffer, Int32, Texture[])
			// bool HG::Rendering::Runtime::TextureCacheCubemap::TransferToPanoCache(
			//         TextureCacheCubemap *this,
			//         CommandBuffer *cmd,
			//         int32_t sliceIndex,
			//         Texture__Array *textureArray,
			//         MethodInfo *method)
			// {
			//   RenderTexture__Array *m_StagingRTs; // rdx
			//   Material *m_CubeBlitMaterial; // rcx
			//   int32_t v11; // edi
			//   int32_t v12; // esi
			//   int v13; // eax
			//   RenderTargetIdentifier *v14; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   __int128 v17; // xmm1
			//   Material *v18; // r9
			//   int32_t i; // esi
			//   RenderTargetIdentifier *v20; // rax
			//   __int128 v21; // xmm6
			//   __int128 v22; // xmm7
			//   __int64 v23; // xmm8_8
			//   RenderTargetIdentifier *v24; // rax
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   __int128 v27; // xmm1
			//   __int64 v28; // xmm0_8
			//   int v29; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RenderTargetIdentifier v32; // [rsp+48h] [rbp-51h] BYREF
			//   RenderTargetIdentifier v33[2]; // [rsp+78h] [rbp-21h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(379, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(379, 0LL);
			//     if ( !Patch )
			//       goto LABEL_25;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_173(
			//              Patch,
			//              (Object *)this,
			//              (Object *)cmd,
			//              sliceIndex,
			//              (Object *)textureArray,
			//              0LL);
			//   }
			//   else
			//   {
			//     v11 = 0;
			//     if ( !textureArray )
			//       goto LABEL_25;
			//     while ( v11 < textureArray.max_length.size )
			//     {
			//       if ( (unsigned int)v11 >= textureArray.max_length.size )
			// LABEL_22:
			//         sub_180070270(m_CubeBlitMaterial, m_StagingRTs);
			//       m_CubeBlitMaterial = this.fields.m_CubeBlitMaterial;
			//       if ( !m_CubeBlitMaterial )
			//         goto LABEL_25;
			//       UnityEngine::Material::SetTextureImpl(
			//         m_CubeBlitMaterial,
			//         this.fields.m_cubeSrcTexPropName,
			//         textureArray.vector[v11],
			//         0LL);
			//       v12 = 0;
			//       if ( this.fields.m_NumPanoMipLevels > 0 )
			//       {
			//         while ( 1 )
			//         {
			//           v13 = this.fields._.m_NumMipLevels - 1;
			//           m_CubeBlitMaterial = this.fields.m_CubeBlitMaterial;
			//           if ( !m_CubeBlitMaterial )
			//             break;
			//           if ( v13 >= v12 )
			//             v13 = v12;
			//           UnityEngine::Material::SetFloatImpl(m_CubeBlitMaterial, this.fields.m_CubeMipLevelPropName, (float)v13, 0LL);
			//           m_StagingRTs = this.fields.m_StagingRTs;
			//           if ( !m_StagingRTs )
			//             break;
			//           if ( (unsigned int)v12 >= m_StagingRTs.max_length.size )
			//             goto LABEL_22;
			//           v14 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                   v33,
			//                   (Texture *)m_StagingRTs.vector[v12],
			//                   0LL);
			//           if ( !cmd )
			//             sub_180B536AC(v16, v15);
			//           v17 = *(_OWORD *)&v14.m_BufferPointer;
			//           v18 = this.fields.m_CubeBlitMaterial;
			//           *(_OWORD *)&v32.m_Type = *(_OWORD *)&v14.m_Type;
			//           *(_QWORD *)&v32.m_DepthSlice = *(_QWORD *)&v14.m_DepthSlice;
			//           *(_OWORD *)&v32.m_BufferPointer = v17;
			//           UnityEngine::Rendering::CommandBuffer::Blit(cmd, 0LL, &v32, v18, 0, 0LL);
			//           if ( ++v12 >= this.fields.m_NumPanoMipLevels )
			//             goto LABEL_14;
			//         }
			// LABEL_25:
			//         sub_180B536AC(m_CubeBlitMaterial, m_StagingRTs);
			//       }
			// LABEL_14:
			//       for ( i = 0;
			//             i < this.fields.m_NumPanoMipLevels;
			//             UnityEngine::Rendering::CommandBuffer::CopyTexture(cmd, v33, 0, 0, &v32, v11 + v29, i++, 0LL) )
			//       {
			//         m_StagingRTs = this.fields.m_StagingRTs;
			//         if ( !m_StagingRTs )
			//           goto LABEL_25;
			//         if ( (unsigned int)i >= m_StagingRTs.max_length.size )
			//           goto LABEL_22;
			//         v20 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v33, (Texture *)m_StagingRTs.vector[i], 0LL);
			//         v21 = *(_OWORD *)&v20.m_Type;
			//         v22 = *(_OWORD *)&v20.m_BufferPointer;
			//         v23 = *(_QWORD *)&v20.m_DepthSlice;
			//         v24 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                 v33,
			//                 (Texture *)this.fields.m_CacheNoCubeArray,
			//                 0LL);
			//         if ( !cmd )
			//           sub_180B536AC(v26, v25);
			//         v27 = *(_OWORD *)&v24.m_BufferPointer;
			//         *(_OWORD *)&v32.m_Type = *(_OWORD *)&v24.m_Type;
			//         v28 = *(_QWORD *)&v24.m_DepthSlice;
			//         *(_OWORD *)&v32.m_BufferPointer = v27;
			//         v29 = this.fields._.m_SliceSize * sliceIndex;
			//         *(_QWORD *)&v32.m_DepthSlice = v28;
			//         *(_OWORD *)&v33[0].m_Type = v21;
			//         *(_OWORD *)&v33[0].m_BufferPointer = v22;
			//         *(_QWORD *)&v33[0].m_DepthSlice = v23;
			//       }
			//       ++v11;
			//     }
			//     return 1;
			//   }
			// }
			// 
			return default(bool);
		}

		internal static long GetApproxCacheSizeInByte(int nbElement, int resolution, int sliceSize)
		{
			// // Int64 GetApproxCacheSizeInByte(Int32, Int32, Int32)
			// int64_t HG::Rendering::Runtime::TextureCacheCubemap::GetApproxCacheSizeInByte(
			//         int32_t nbElement,
			//         int32_t resolution,
			//         int32_t sliceSize,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(384, 0LL) )
			//     return (unsigned int)(int)(float)((float)((float)(48 * resolution * resolution * nbElement) * 1.33)
			//                                     * (float)sliceSize);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(384, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v10, v9);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_176(Patch, nbElement, resolution, sliceSize, 0LL);
			// }
			// 
			return 0L;
		}

		internal static int GetMaxCacheSizeForWeightInByte(long weight, int resolution, int sliceSize)
		{
			// // Int32 GetMaxCacheSizeForWeightInByte(Int64, Int32, Int32)
			// int32_t HG::Rendering::Runtime::TextureCacheCubemap::GetMaxCacheSizeForWeightInByte(
			//         int64_t weight,
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
			//   if ( IFix::WrappersManagerImpl::IsPatched(385, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(385, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_179(Patch, weight, resolution, sliceSize, 0LL);
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

		private const int k_NbFace = 6;

		private Texture2DArray m_CacheNoCubeArray;

		private RenderTexture[] m_StagingRTs;

		private int m_NumPanoMipLevels;

		private Material m_CubeBlitMaterial;

		private int m_CubeMipLevelPropName;

		private int m_cubeSrcTexPropName;

		private Material m_BlitCubemapFaceMaterial;

		private MaterialPropertyBlock m_BlitCubemapFaceProperties;
	}
}
