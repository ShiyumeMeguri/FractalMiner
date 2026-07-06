using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal abstract class TextureCache
	{
		// (get) Token: 0x060003BE RID: 958 RVA: 0x000025D8 File Offset: 0x000007D8
		public static bool isMobileBuildTarget
		{
			get
			{
				// // Boolean get_isMobileBuildTarget()
				// bool HG::Rendering::Runtime::TextureCache::get_isMobileBuildTarget(MethodInfo *method)
				// {
				//   return UnityEngine::Application::get_isMobilePlatform(0LL);
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x060003BF RID: 959 RVA: 0x000025D8 File Offset: 0x000007D8
		public static bool supportsCubemapArrayTextures
		{
			get
			{
				// // Boolean get_supportsCubemapArrayTextures()
				// bool HG::Rendering::Runtime::TextureCache::get_supportsCubemapArrayTextures(MethodInfo *method)
				// {
				//   return !UnityEngine::Rendering::GraphicsSettings::HasShaderDefine(
				//             BuiltinShaderDefine__Enum_UNITY_NO_CUBEMAP_ARRAY,
				//             0LL);
				// }
				// 
				return default(bool);
			}
		}

		protected TextureCache(string cacheName, [MetadataOffset(Offset = "0x01F90B77")] int sliceSize = 1)
		{
		}

		public virtual bool IsCreated()
		{
			// // Boolean IsCreated()
			// bool HG::Rendering::Runtime::TextureCache::IsCreated(TextureCache *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(354, 0LL) )
			//     return 1;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(354, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public string GetCacheName()
		{
			// // String GetCacheName()
			// String *HG::Rendering::Runtime::TextureCache::GetCacheName(TextureCache *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(355, 0LL) )
			//     return this.fields.m_CacheName;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(355, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public int GetNumMipLevels()
		{
			// // Int32 GetNumMipLevels()
			// int32_t HG::Rendering::Runtime::TextureCache::GetNumMipLevels(TextureCache *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(356, 0LL) )
			//     return this.fields.m_NumMipLevels;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(356, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0;
		}

		protected bool AllocTextureArray(int numTextures)
		{
			return default(bool);
		}

		public abstract Texture GetTexCache();

		public uint GetTextureHash(Texture texture)
		{
			// // UInt32 GetTextureHash(Texture)
			// uint32_t HG::Rendering::Runtime::TextureCache::GetTextureHash(TextureCache *this, Texture *texture, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(358, 0LL) )
			//   {
			//     if ( texture )
			//       return UnityEngine::Texture::get_updateCount(texture, 0LL);
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(358, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_104(
			//            (ILFixDynamicMethodWrapper_13 *)Patch,
			//            (Object *)this,
			//            (Object *)texture,
			//            0LL);
			// }
			// 
			return 0U;
		}

		public int ReserveSlice(Texture texture, out bool needUpdate)
		{
			// // Int32 ReserveSlice(Texture, Boolean ByRef)
			// int32_t HG::Rendering::Runtime::TextureCache::ReserveSlice(
			//         TextureCache *this,
			//         Texture *texture,
			//         bool *needUpdate,
			//         MethodInfo *method)
			// {
			//   TextureCache__StaticFields *static_fields; // rdx
			//   Dictionary_2_System_UInt32_System_Int32_ *m_LocatorInSliceDictionnary; // rcx
			//   int32_t InstanceID; // ebp
			//   int32_t i; // ebx
			//   Int32__Array *m_SortedIdxArray; // rsi
			//   __int64 v12; // rsi
			//   int v13; // ebx
			//   Dictionary_2_System_UInt32_System_Single_ *v14; // rbx
			//   uint32_t *v15; // rax
			//   uint32_t TextureHash; // eax
			//   bool v17; // bp
			//   bool v18; // bl
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t value[6]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9193D9 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TextureCache);
			//     byte_18D9193D9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(359, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(359, 0LL);
			//     if ( !Patch )
			//       goto LABEL_34;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_167(Patch, (Object *)this, (Object *)texture, needUpdate, 0LL);
			//   }
			//   else
			//   {
			//     *needUpdate = 0;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality((Object_1 *)texture, 0LL, 0LL) )
			//       return -1;
			//     if ( !texture )
			//       goto LABEL_34;
			//     InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)texture, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::TextureCache);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::TextureCache.static_fields;
			//     if ( InstanceID == static_fields.g_InvalidTexID )
			//     {
			//       return -1;
			//     }
			//     else
			//     {
			//       value[0] = -1;
			//       m_LocatorInSliceDictionnary = this.fields.m_LocatorInSliceDictionnary;
			//       if ( !m_LocatorInSliceDictionnary )
			//         goto LABEL_34;
			//       if ( System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue(
			//              m_LocatorInSliceDictionnary,
			//              InstanceID,
			//              value,
			//              MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue) )
			//       {
			//         TextureHash = HG::Rendering::Runtime::TextureCache::GetTextureHash(this, texture, 0LL);
			//         m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this.fields.m_SliceArray;
			//         if ( !m_LocatorInSliceDictionnary )
			//           goto LABEL_34;
			//         LODWORD(v12) = value[0];
			//         v17 = *needUpdate;
			//         *needUpdate = v17 | (*(_DWORD *)(sub_18037A31C(m_LocatorInSliceDictionnary, value[0]) + 8) != TextureHash);
			//       }
			//       else
			//       {
			//         for ( i = 0; ; ++i )
			//         {
			//           if ( i >= this.fields.m_NumTextures )
			//           {
			//             LODWORD(v12) = value[0];
			//             goto LABEL_28;
			//           }
			//           m_SortedIdxArray = this.fields.m_SortedIdxArray;
			//           if ( !m_SortedIdxArray )
			//             goto LABEL_34;
			//           if ( (unsigned int)i >= m_SortedIdxArray.max_length.size )
			//             sub_180070270(m_LocatorInSliceDictionnary, static_fields);
			//           m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this.fields.m_SliceArray;
			//           v12 = m_SortedIdxArray.vector[i];
			//           if ( !m_LocatorInSliceDictionnary )
			//             goto LABEL_34;
			//           if ( *(_DWORD *)(sub_18037A31C(m_LocatorInSliceDictionnary, v12) + 4) )
			//             break;
			//         }
			//         *needUpdate = 1;
			//         m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this.fields.m_SliceArray;
			//         if ( !m_LocatorInSliceDictionnary )
			//           goto LABEL_34;
			//         v13 = *(_DWORD *)sub_18037A31C(m_LocatorInSliceDictionnary, v12);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::TextureCache);
			//         if ( v13 != TypeInfo::HG::Rendering::Runtime::TextureCache.static_fields.g_InvalidTexID )
			//         {
			//           m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this.fields.m_SliceArray;
			//           v14 = (Dictionary_2_System_UInt32_System_Single_ *)this.fields.m_LocatorInSliceDictionnary;
			//           if ( m_LocatorInSliceDictionnary )
			//           {
			//             v15 = (uint32_t *)sub_18037A31C(m_LocatorInSliceDictionnary, v12);
			//             if ( v14 )
			//             {
			//               System::Collections::Generic::Dictionary<unsigned int,float>::Remove(
			//                 v14,
			//                 *v15,
			//                 MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Remove);
			//               goto LABEL_21;
			//             }
			//           }
			// LABEL_34:
			//           sub_180B536AC(m_LocatorInSliceDictionnary, static_fields);
			//         }
			// LABEL_21:
			//         m_LocatorInSliceDictionnary = this.fields.m_LocatorInSliceDictionnary;
			//         if ( !m_LocatorInSliceDictionnary )
			//           goto LABEL_34;
			//         System::Collections::Generic::Dictionary<unsigned int,int>::Add(
			//           m_LocatorInSliceDictionnary,
			//           InstanceID,
			//           v12,
			//           MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Add);
			//         m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this.fields.m_SliceArray;
			//         if ( !m_LocatorInSliceDictionnary )
			//           goto LABEL_34;
			//         *(_DWORD *)sub_18037A31C(m_LocatorInSliceDictionnary, v12) = InstanceID;
			//       }
			// LABEL_28:
			//       if ( (_DWORD)v12 != -1 )
			//       {
			//         m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this.fields.m_SliceArray;
			//         if ( !m_LocatorInSliceDictionnary )
			//           goto LABEL_34;
			//         *(_DWORD *)(sub_18037A31C(m_LocatorInSliceDictionnary, (int)v12) + 4) = 0;
			//       }
			//       v18 = *needUpdate;
			//       *needUpdate = v18 | sub_1800023D0(4LL, this) ^ 1;
			//       return v12;
			//     }
			//   }
			// }
			// 
			return 0;
		}

		[IDTag(0)]
		public bool UpdateSlice(CommandBuffer cmd, int sliceIndex, Texture[] contentArray, uint textureHash)
		{
			// // Boolean UpdateSlice(CommandBuffer, Int32, Texture[], UInt32)
			// bool HG::Rendering::Runtime::TextureCache::UpdateSlice(
			//         TextureCache *this,
			//         CommandBuffer *cmd,
			//         int32_t sliceIndex,
			//         Texture__Array *contentArray,
			//         uint32_t textureHash,
			//         MethodInfo *method)
			// {
			//   int v10; // ecx
			//   __int64 v12; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(360, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(360, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v12);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_169(
			//              Patch,
			//              (Object *)this,
			//              (Object *)cmd,
			//              sliceIndex,
			//              (Object *)contentArray,
			//              textureHash,
			//              0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::TextureCache::SetSliceHash(this, sliceIndex, textureHash, 0LL);
			//     return sub_18082F3F4(v10, (_DWORD)this, (_DWORD)cmd, sliceIndex, (__int64)contentArray);
			//   }
			// }
			// 
			return default(bool);
		}

		[IDTag(1)]
		public bool UpdateSlice(CommandBuffer cmd, int sliceIndex, Texture texture, uint textureHash)
		{
			// // Boolean UpdateSlice(CommandBuffer, Int32, Texture, UInt32)
			// bool HG::Rendering::Runtime::TextureCache::UpdateSlice(
			//         TextureCache *this,
			//         CommandBuffer *cmd,
			//         int32_t sliceIndex,
			//         Texture *texture,
			//         uint32_t textureHash,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Texture__Array *m_autoContentArray; // rdi
			//   int v13; // ecx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(362, 0LL) )
			//   {
			//     HG::Rendering::Runtime::TextureCache::SetSliceHash(this, sliceIndex, textureHash, 0LL);
			//     m_autoContentArray = this.fields.m_autoContentArray;
			//     if ( m_autoContentArray )
			//     {
			//       sub_180036D40(this.fields.m_autoContentArray, texture);
			//       sub_180328478(m_autoContentArray, 0LL, texture);
			//       return sub_18082F3F4(v13, (_DWORD)this, (_DWORD)cmd, sliceIndex, (__int64)this.fields.m_autoContentArray);
			//     }
			// LABEL_5:
			//     sub_180B536AC(Patch, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(362, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_169(
			//            Patch,
			//            (Object *)this,
			//            (Object *)cmd,
			//            sliceIndex,
			//            (Object *)texture,
			//            textureHash,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		public void SetSliceHash(int sliceIndex, uint hash)
		{
			// // Void SetSliceHash(Int32, UInt32)
			// void HG::Rendering::Runtime::TextureCache::SetSliceHash(
			//         TextureCache *this,
			//         int32_t sliceIndex,
			//         uint32_t hash,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rsi
			//   __int64 v7; // rdx
			//   TextureCache_SliceEntry__Array *m_SliceArray; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v4 = sliceIndex;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(361, 0LL) )
			//   {
			//     m_SliceArray = this.fields.m_SliceArray;
			//     if ( m_SliceArray )
			//     {
			//       *(_DWORD *)(sub_18037A31C(m_SliceArray, v4) + 8) = hash;
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_SliceArray, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(361, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_56((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, v4, hash, 0LL);
			// }
			// 
		}

		protected abstract bool TransferToSlice(CommandBuffer cmd, int sliceIndex, Texture[] textureArray);

		public int FetchSlice(CommandBuffer cmd, Texture texture, [MetadataOffset(Offset = "0x01F90B78")] bool forceReinject = false)
		{
			// // Int32 FetchSlice(CommandBuffer, Texture, Boolean)
			// int32_t HG::Rendering::Runtime::TextureCache::FetchSlice(
			//         TextureCache *this,
			//         CommandBuffer *cmd,
			//         Texture *texture,
			//         bool forceReinject,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   int32_t v10; // esi
			//   __int64 v11; // rcx
			//   Texture__Array *m_autoContentArray; // rbx
			//   Texture__Array *v13; // rbx
			//   uint32_t textureHash; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   bool needUpdate; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(363, 0LL) )
			//   {
			//     needUpdate = 0;
			//     v10 = HG::Rendering::Runtime::TextureCache::ReserveSlice(this, texture, &needUpdate, 0LL);
			//     LOBYTE(v11) = forceReinject || needUpdate;
			//     if ( v10 == -1 || !(_BYTE)v11 )
			//       return v10;
			//     m_autoContentArray = this.fields.m_autoContentArray;
			//     if ( m_autoContentArray )
			//     {
			//       sub_180036D40(this.fields.m_autoContentArray, texture);
			//       sub_180328478(m_autoContentArray, 0LL, texture);
			//       v13 = this.fields.m_autoContentArray;
			//       textureHash = HG::Rendering::Runtime::TextureCache::GetTextureHash(this, texture, 0LL);
			//       HG::Rendering::Runtime::TextureCache::UpdateSlice(this, cmd, v10, v13, textureHash, 0LL);
			//       return v10;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v11, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(363, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_170(
			//            Patch,
			//            (Object *)this,
			//            (Object *)cmd,
			//            (Object *)texture,
			//            forceReinject,
			//            0LL);
			// }
			// 
			return 0;
		}

		public void NewFrame()
		{
			// // Void NewFrame()
			// void HG::Rendering::Runtime::TextureCache::NewFrame(TextureCache *this, MethodInfo *method)
			// {
			//   int32_t v3; // ebx
			//   List_1_System_Int32_ *static_fields; // rcx
			//   int *monitor; // rdx
			//   int32_t v6; // esi
			//   Int32__Array *m_SortedIdxArray; // rax
			//   __int64 v8; // rax
			//   int v9; // ecx
			//   int32_t v10; // r14d
			//   int32_t v11; // esi
			//   TextureCache_SliceEntry__Array *m_SliceArray; // rbp
			//   int Item; // eax
			//   __int64 v14; // rax
			//   Int32__Array *v15; // rbp
			//   RegexCharClass_SingleRange v16; // eax
			//   __int64 v17; // rcx
			//   int v18; // esi
			//   uint32_t v19; // ebx
			//   __int64 v20; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9193DA )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TextureCache);
			//     byte_18D9193DA = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(364, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(364, 0LL);
			//     if ( !Patch )
			//       goto LABEL_37;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     v3 = 0;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::TextureCache);
			//     static_fields = (List_1_System_Int32_ *)TypeInfo::HG::Rendering::Runtime::TextureCache.static_fields;
			//     monitor = (int *)static_fields.monitor;
			//     if ( !monitor )
			//       goto LABEL_37;
			//     ++monitor[7];
			//     monitor[6] = 0;
			//     v6 = 0;
			//     if ( this.fields.m_NumTextures > 0 )
			//     {
			//       while ( 1 )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::TextureCache);
			//         m_SortedIdxArray = this.fields.m_SortedIdxArray;
			//         static_fields = TypeInfo::HG::Rendering::Runtime::TextureCache.static_fields.s_TempIntList;
			//         if ( !m_SortedIdxArray )
			//           break;
			//         if ( (unsigned int)v6 >= m_SortedIdxArray.max_length.size )
			//           goto LABEL_35;
			//         if ( !static_fields )
			//           break;
			//         sub_18231EF50(static_fields, m_SortedIdxArray.vector[v6]);
			//         monitor = (int *)this.fields.m_SortedIdxArray;
			//         if ( !monitor )
			//           break;
			//         if ( v6 >= (unsigned int)monitor[6] )
			// LABEL_35:
			//           sub_180070270(static_fields, monitor);
			//         static_fields = (List_1_System_Int32_ *)this.fields.m_SliceArray;
			//         if ( !static_fields )
			//           break;
			//         v8 = sub_18037A31C(static_fields, monitor[v6 + 8]);
			//         v9 = v3 + 1;
			//         if ( !*(_DWORD *)(v8 + 4) )
			//           v9 = v3;
			//         ++v6;
			//         v3 = v9;
			//         if ( v6 >= this.fields.m_NumTextures )
			//           goto LABEL_15;
			//       }
			// LABEL_37:
			//       sub_180B536AC(static_fields, monitor);
			//     }
			// LABEL_15:
			//     v10 = 0;
			//     v11 = 0;
			//     if ( this.fields.m_NumTextures > 0 )
			//     {
			//       do
			//       {
			//         m_SliceArray = this.fields.m_SliceArray;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::TextureCache);
			//         monitor = (int *)TypeInfo::HG::Rendering::Runtime::TextureCache.static_fields;
			//         static_fields = (List_1_System_Int32_ *)*((_QWORD *)monitor + 1);
			//         if ( !static_fields )
			//           goto LABEL_37;
			//         Item = (int)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                       (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)static_fields,
			//                       v11,
			//                       MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//         if ( !m_SliceArray )
			//           goto LABEL_37;
			//         v14 = sub_18037A31C(m_SliceArray, Item);
			//         v15 = this.fields.m_SortedIdxArray;
			//         if ( *(_DWORD *)(v14 + 4) )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::TextureCache);
			//           static_fields = TypeInfo::HG::Rendering::Runtime::TextureCache.static_fields.s_TempIntList;
			//           if ( !static_fields )
			//             goto LABEL_37;
			//           v16 = System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                   (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)static_fields,
			//                   v11,
			//                   MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//           if ( !v15 )
			//             goto LABEL_37;
			//           if ( (unsigned int)v10 >= v15.max_length.size )
			//             goto LABEL_35;
			//           v17 = v10++;
			//         }
			//         else
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::TextureCache);
			//           static_fields = TypeInfo::HG::Rendering::Runtime::TextureCache.static_fields.s_TempIntList;
			//           if ( !static_fields )
			//             goto LABEL_37;
			//           v16 = System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                   (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)static_fields,
			//                   v11,
			//                   MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//           if ( !v15 )
			//             goto LABEL_37;
			//           if ( (unsigned int)v3 >= v15.max_length.size )
			//             goto LABEL_35;
			//           v17 = v3++;
			//         }
			//         v15.vector[v17] = (int32_t)v16;
			//       }
			//       while ( ++v11 < this.fields.m_NumTextures );
			//     }
			//     v18 = 0;
			//     if ( this.fields.m_NumTextures > 0 )
			//     {
			//       while ( 1 )
			//       {
			//         static_fields = (List_1_System_Int32_ *)this.fields.m_SliceArray;
			//         if ( !static_fields )
			//           goto LABEL_37;
			//         v19 = *(_DWORD *)(sub_18037A31C(static_fields, v18) + 4);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::TextureCache);
			//         if ( v19 < TypeInfo::HG::Rendering::Runtime::TextureCache.static_fields.g_MaxFrameCount )
			//         {
			//           static_fields = (List_1_System_Int32_ *)this.fields.m_SliceArray;
			//           if ( !static_fields )
			//             goto LABEL_37;
			//           v20 = sub_18037A31C(static_fields, v18);
			//           ++*(_DWORD *)(v20 + 4);
			//         }
			//         if ( ++v18 >= this.fields.m_NumTextures )
			//           return;
			//       }
			//     }
			//   }
			// }
			// 
		}

		public void RemoveEntryFromSlice(Texture texture)
		{
			// // Void RemoveEntryFromSlice(Texture)
			// void HG::Rendering::Runtime::TextureCache::RemoveEntryFromSlice(
			//         TextureCache *this,
			//         Texture *texture,
			//         MethodInfo *method)
			// {
			//   __int64 static_fields; // rdx
			//   Dictionary_2_System_UInt32_System_Int32_ *m_LocatorInSliceDictionnary; // rcx
			//   int32_t InstanceID; // ebx
			//   int32_t Item; // eax
			//   __int64 v9; // rsi
			//   int32_t v10; // r8d
			//   int v11; // eax
			//   __int64 v12; // r9
			//   __int64 v13; // rax
			//   Int32__Array *m_SortedIdxArray; // rax
			//   TextureCache_SliceEntry__Array *m_SliceArray; // rbp
			//   uint32_t g_MaxFrameCount; // ebx
			//   uint32_t g_InvalidTexID; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9193DB )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TextureCache);
			//     byte_18D9193DB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(365, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(365, 0LL);
			//     if ( !Patch )
			//       goto LABEL_29;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)texture,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !texture )
			//       goto LABEL_29;
			//     InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)texture, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::TextureCache);
			//     static_fields = (__int64)TypeInfo::HG::Rendering::Runtime::TextureCache.static_fields;
			//     if ( InstanceID != *(_DWORD *)(static_fields + 4) )
			//     {
			//       m_LocatorInSliceDictionnary = this.fields.m_LocatorInSliceDictionnary;
			//       if ( !m_LocatorInSliceDictionnary )
			//         goto LABEL_29;
			//       if ( System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey(
			//              m_LocatorInSliceDictionnary,
			//              InstanceID,
			//              MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey) )
			//       {
			//         m_LocatorInSliceDictionnary = this.fields.m_LocatorInSliceDictionnary;
			//         if ( !m_LocatorInSliceDictionnary )
			//           goto LABEL_29;
			//         Item = System::Collections::Generic::Dictionary<unsigned int,int>::get_Item(
			//                  m_LocatorInSliceDictionnary,
			//                  InstanceID,
			//                  MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::get_Item);
			//         LOBYTE(static_fields) = 0;
			//         v9 = Item;
			//         v10 = 0;
			//         do
			//         {
			//           if ( v10 >= this.fields.m_NumTextures )
			//             return;
			//           m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this.fields.m_SortedIdxArray;
			//           if ( !m_LocatorInSliceDictionnary )
			//             goto LABEL_29;
			//           if ( (unsigned int)v10 >= LODWORD(m_LocatorInSliceDictionnary.fields._entries) )
			//             goto LABEL_27;
			//           static_fields = (unsigned __int8)static_fields;
			//           v11 = v10 + 1;
			//           if ( *(&m_LocatorInSliceDictionnary.fields._count + v10) == (_DWORD)v9 )
			//           {
			//             v11 = v10;
			//             static_fields = 1LL;
			//           }
			//           v10 = v11;
			//         }
			//         while ( !(_BYTE)static_fields );
			//         static_fields = 0LL;
			//         if ( v11 > 0 )
			//         {
			//           do
			//           {
			//             m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this.fields.m_SortedIdxArray;
			//             if ( !m_LocatorInSliceDictionnary )
			//               goto LABEL_29;
			//             if ( (unsigned int)static_fields >= LODWORD(m_LocatorInSliceDictionnary.fields._entries) )
			//               goto LABEL_27;
			//             v12 = (int)static_fields + 1LL;
			//             if ( (unsigned int)v12 >= LODWORD(m_LocatorInSliceDictionnary.fields._entries) )
			//               goto LABEL_27;
			//             v13 = (int)static_fields;
			//             static_fields = (unsigned int)(static_fields + 1);
			//             m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)*((unsigned int *)&m_LocatorInSliceDictionnary.fields._count
			//                                                                                       + v13);
			//             this.fields.m_SortedIdxArray.vector[v12] = (int)m_LocatorInSliceDictionnary;
			//           }
			//           while ( (int)static_fields < v10 );
			//         }
			//         m_SortedIdxArray = this.fields.m_SortedIdxArray;
			//         if ( !m_SortedIdxArray )
			//           goto LABEL_29;
			//         if ( !m_SortedIdxArray.max_length.size )
			// LABEL_27:
			//           sub_180070270(m_LocatorInSliceDictionnary, static_fields);
			//         m_SortedIdxArray.vector[0] = v9;
			//         m_LocatorInSliceDictionnary = this.fields.m_LocatorInSliceDictionnary;
			//         if ( !m_LocatorInSliceDictionnary
			//           || (System::Collections::Generic::Dictionary<unsigned int,float>::Remove(
			//                 (Dictionary_2_System_UInt32_System_Single_ *)m_LocatorInSliceDictionnary,
			//                 InstanceID,
			//                 MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Remove),
			//               (m_SliceArray = this.fields.m_SliceArray) == 0LL)
			//           || (sub_180002C70(TypeInfo::HG::Rendering::Runtime::TextureCache),
			//               g_MaxFrameCount = TypeInfo::HG::Rendering::Runtime::TextureCache.static_fields.g_MaxFrameCount,
			//               *(_DWORD *)(sub_18037A31C(m_SliceArray, v9) + 4) = g_MaxFrameCount,
			//               (m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this.fields.m_SliceArray) == 0LL) )
			//         {
			// LABEL_29:
			//           sub_180B536AC(m_LocatorInSliceDictionnary, static_fields);
			//         }
			//         g_InvalidTexID = TypeInfo::HG::Rendering::Runtime::TextureCache.static_fields.g_InvalidTexID;
			//         *(_DWORD *)sub_18037A31C(m_LocatorInSliceDictionnary, v9) = g_InvalidTexID;
			//       }
			//     }
			//   }
			// }
			// 
		}

		[IDTag(1)]
		protected int GetNumMips(int width, int height)
		{
			// // Int32 GetNumMips(Int32, Int32)
			// int32_t HG::Rendering::Runtime::TextureCache::GetNumMips(
			//         TextureCache *this,
			//         int32_t width,
			//         int32_t height,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(366, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(366, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			//                (ILFixDynamicMethodWrapper_14 *)Patch,
			//                (Object *)this,
			//                (SocketOptionLevel__Enum)width,
			//                (SocketOptionName__Enum)height,
			//                0LL);
			// LABEL_7:
			//     sub_180B536AC(v8, v7);
			//   }
			//   if ( !this )
			//     goto LABEL_7;
			//   if ( width <= height )
			//     width = height;
			//   return HG::Rendering::Runtime::TextureCache::GetNumMips(this, width, 0LL);
			// }
			// 
			return 0;
		}

		[IDTag(0)]
		protected int GetNumMips(int dim)
		{
			// // Int32 GetNumMips(Int32)
			// int32_t HG::Rendering::Runtime::TextureCache::GetNumMips(TextureCache *this, int32_t dim, MethodInfo *method)
			// {
			//   int32_t v5; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   v5 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(367, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(367, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_47(
			//              (ILFixDynamicMethodWrapper_20 *)Patch,
			//              (Object *)this,
			//              dim,
			//              0LL);
			//   }
			//   else
			//   {
			//     for ( ; dim; dim = (unsigned int)dim >> 1 )
			//       ++v5;
			//     return v5;
			//   }
			// }
			// 
			return 0;
		}

		protected string m_CacheName;

		protected int m_NumMipLevels;

		protected int m_SliceSize;

		private int m_NumTextures;

		private Dictionary<uint, int> m_LocatorInSliceDictionnary;

		private TextureCache.SliceEntry[] m_SliceArray;

		private int[] m_SortedIdxArray;

		private Texture[] m_autoContentArray;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static uint g_MaxFrameCount;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		private static uint g_InvalidTexID;

		protected const int k_FP16SizeInByte = 2;

		protected const int k_NbChannel = 4;

		protected const float k_MipmapFactorApprox = 1.33f;

		internal const int k_MaxSupported = 250;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static List<int> s_TempIntList;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
		private struct SliceEntry
		{
			public uint texId;

			public uint countLRU;

			public uint sliceEntryHash;
		}
	}
}
