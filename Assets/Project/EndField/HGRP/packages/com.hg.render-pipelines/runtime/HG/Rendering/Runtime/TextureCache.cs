using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal abstract class TextureCache // TypeDefIndex: 37524
	{
		// Fields
		protected string m_CacheName; // 0x10
		protected int m_NumMipLevels; // 0x18
		protected int m_SliceSize; // 0x1C
		private int m_NumTextures; // 0x20
		private Dictionary<uint, int> m_LocatorInSliceDictionnary; // 0x28
		private SliceEntry[] m_SliceArray; // 0x30
		private int[] m_SortedIdxArray; // 0x38
		private Texture[] m_autoContentArray; // 0x40
		private static uint g_MaxFrameCount; // 0x00
		private static uint g_InvalidTexID; // 0x04
		protected const int k_FP16SizeInByte = 2; // Metadata: 0x02302EEA
		protected const int k_NbChannel = 4; // Metadata: 0x02302EEB
		protected const float k_MipmapFactorApprox = 1.33f; // Metadata: 0x02302EEC
		internal const int k_MaxSupported = 250; // Metadata: 0x02302EF0
		private static List<int> s_TempIntList; // 0x08
	
		// Properties
		public static bool isMobileBuildTarget { get; } // 0x0000000189B41778-0x0000000189B417BC 
		// Boolean get_isMobileBuildTarget()
		bool HG::Rendering::Runtime::TextureCache::get_isMobileBuildTarget(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(375, 0LL) )
		    return UnityEngine::Application::get_isMobilePlatform(0LL);
		  Patch = IFix::WrappersManagerImpl::GetPatch(375, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		}
		
		public static bool supportsCubemapArrayTextures { get; } // 0x0000000189B417BC-0x0000000189B41804 
		// Boolean get_supportsCubemapArrayTextures()
		bool HG::Rendering::Runtime::TextureCache::get_supportsCubemapArrayTextures(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(376, 0LL) )
		    return !UnityEngine::Rendering::GraphicsSettings::HasShaderDefine(
		              BuiltinShaderDefine__Enum_UNITY_NO_CUBEMAP_ARRAY,
		              0LL);
		  Patch = IFix::WrappersManagerImpl::GetPatch(376, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		}
		
	
		// Nested types
		private struct SliceEntry // TypeDefIndex: 37523
		{
			// Fields
			public uint texId; // 0x00
			public uint countLRU; // 0x04
			public uint sliceEntryHash; // 0x08
		}
	
		// Constructors
		protected TextureCache() {} // Dummy constructor
		protected TextureCache(string cacheName, int sliceSize = 1 /* Metadata: 0x02302EE8 */) {} // 0x0000000189B41718-0x0000000189B41778
		// TextureCache(String, Int32)
		void HG::Rendering::Runtime::TextureCache::TextureCache(
		        TextureCache *this,
		        String *cacheName,
		        int32_t sliceSize,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		
		  this->fields.m_autoContentArray = (Texture__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Texture, 1LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_autoContentArray, v7, v8, v9, v13);
		  this->fields.m_CacheName = cacheName;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v10, v11, v12, v14);
		  this->fields.m_NumTextures = 0;
		  this->fields.m_NumMipLevels = 0;
		  this->fields.m_SliceSize = sliceSize;
		}
		
		static TextureCache() {} // 0x0000000189B41698-0x0000000189B41718
		// TextureCache()
		void HG::Rendering::Runtime::TextureCache::cctor(MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  List_1_System_Int32_ *v4; // rbx
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  MethodInfo *v8; // [rsp+50h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields->g_MaxFrameCount = -1;
		  TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields->g_InvalidTexID = 0;
		  v1 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<int>);
		  v4 = (List_1_System_Int32_ *)v1;
		  if ( !v1 )
		    sub_1800D8260(v3, v2);
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v1,
		    MethodInfo::System::Collections::Generic::List<int>::List);
		  TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields->s_TempIntList = v4;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields->s_TempIntList,
		    v5,
		    v6,
		    v7,
		    v8);
		}
		
	
		// Methods
		public virtual bool IsCreated() => default; // 0x0000000189B40D40-0x0000000189B40D8C
		// Boolean IsCreated()
		bool HG::Rendering::Runtime::TextureCache::IsCreated(TextureCache *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(361, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(361, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public string GetCacheName() => default; // 0x0000000189B40B54-0x0000000189B40BA4
		// String GetCacheName()
		String *HG::Rendering::Runtime::TextureCache::GetCacheName(TextureCache *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(362, 0LL) )
		    return this->fields.m_CacheName;
		  Patch = IFix::WrappersManagerImpl::GetPatch(362, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		public int GetNumMipLevels() => default; // 0x0000000189B40BA4-0x0000000189B40BF0
		// Int32 GetNumMipLevels()
		int32_t HG::Rendering::Runtime::TextureCache::GetNumMipLevels(TextureCache *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(363, 0LL) )
		    return this->fields.m_NumMipLevels;
		  Patch = IFix::WrappersManagerImpl::GetPatch(363, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		protected bool AllocTextureArray(int numTextures) => default; // 0x0000000189B408DC-0x0000000189B40A58
		// Boolean AllocTextureArray(Int32)
		bool HG::Rendering::Runtime::TextureCache::AllocTextureArray(
		        TextureCache *this,
		        int32_t numTextures,
		        MethodInfo *method)
		{
		  bool v5; // sf
		  bool v6; // of
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *v13; // rax
		  __int64 v14; // rdx
		  _DWORD *m_SortedIdxArray; // rcx
		  Dictionary_2_System_UInt32_System_Int32_ *v16; // rbx
		  HGRuntimeGrassQuery_Node *v17; // rdx
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  unsigned int v20; // esi
		  int32_t v21; // eax
		  TextureCache_SliceEntry__Array *m_SliceArray; // r14
		  uint32_t g_MaxFrameCount; // ebx
		  uint32_t g_InvalidTexID; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v27; // [rsp+20h] [rbp-8h]
		  MethodInfo *v28; // [rsp+20h] [rbp-8h]
		  MethodInfo *v29; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(364, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(364, 0LL);
		    if ( !Patch )
		      goto LABEL_14;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_17(
		             (ILFixDynamicMethodWrapper_13 *)Patch,
		             (Object *)this,
		             (NaviDirection__Enum)numTextures,
		             0LL);
		  }
		  else
		  {
		    v6 = __OFSUB__(numTextures, this->fields.m_SliceSize);
		    v5 = numTextures - this->fields.m_SliceSize < 0;
		    if ( numTextures >= this->fields.m_SliceSize )
		    {
		      this->fields.m_SliceArray = (TextureCache_SliceEntry__Array *)il2cpp_array_new_specific_1(
		                                                                      TypeInfo::HG::Rendering::Runtime::TextureCache::SliceEntry,
		                                                                      (unsigned int)numTextures);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_SliceArray, v7, v8, v9, v27);
		      this->fields.m_SortedIdxArray = (Int32__Array *)il2cpp_array_new_specific_1(
		                                                        TypeInfo::System::Int32,
		                                                        (unsigned int)numTextures);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_SortedIdxArray, v10, v11, v12, v28);
		      v13 = (Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<unsigned int,int>);
		      v16 = (Dictionary_2_System_UInt32_System_Int32_ *)v13;
		      if ( !v13 )
		        goto LABEL_14;
		      System::Collections::Generic::Dictionary<unsigned int,Beyond::Gameplay::Audio::VoiceBarkProcessor_VoiceEchoBarker::FBarkInfo>::Dictionary(
		        v13,
		        MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Dictionary);
		      this->fields.m_LocatorInSliceDictionnary = v16;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_LocatorInSliceDictionnary, v17, v18, v19, v29);
		      v20 = 0;
		      v14 = (unsigned int)(numTextures >> 31);
		      LODWORD(v14) = numTextures % this->fields.m_SliceSize;
		      v21 = numTextures / this->fields.m_SliceSize;
		      this->fields.m_NumTextures = v21;
		      if ( v21 > 0 )
		      {
		        while ( 1 )
		        {
		          m_SliceArray = this->fields.m_SliceArray;
		          if ( !m_SliceArray )
		            break;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TextureCache);
		          g_MaxFrameCount = TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields->g_MaxFrameCount;
		          *(_DWORD *)(sub_1803C07B0(m_SliceArray, (int)v20) + 4) = g_MaxFrameCount;
		          m_SortedIdxArray = this->fields.m_SliceArray;
		          if ( !m_SortedIdxArray )
		            break;
		          g_InvalidTexID = TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields->g_InvalidTexID;
		          *(_DWORD *)sub_1803C07B0(m_SortedIdxArray, (int)v20) = g_InvalidTexID;
		          m_SortedIdxArray = this->fields.m_SortedIdxArray;
		          if ( !m_SortedIdxArray )
		            break;
		          if ( v20 >= m_SortedIdxArray[6] )
		            sub_1800D2AB0(m_SortedIdxArray, v14);
		          m_SortedIdxArray[v20 + 8] = v20;
		          if ( (signed int)++v20 >= this->fields.m_NumTextures )
		            goto LABEL_10;
		        }
		LABEL_14:
		        sub_1800D8260(m_SortedIdxArray, v14);
		      }
		LABEL_10:
		      v6 = __OFSUB__(numTextures, this->fields.m_SliceSize);
		      v5 = numTextures - this->fields.m_SliceSize < 0;
		    }
		    return v5 == v6;
		  }
		}
		
		public abstract Texture GetTexCache();
		public uint GetTextureHash(Texture texture) => default; // 0x0000000189B40CDC-0x0000000189B40D40
		// UInt32 GetTextureHash(Texture)
		uint32_t HG::Rendering::Runtime::TextureCache::GetTextureHash(TextureCache *this, Texture *texture, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(365, 0LL) )
		  {
		    if ( texture )
		      return UnityEngine::Texture::get_updateCount(texture, 0LL);
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(365, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_120(
		           (ILFixDynamicMethodWrapper_18 *)Patch,
		           (ClientSingleMapMarkData *)this,
		           (ClientSingleMapMarkData *)texture,
		           0LL);
		}
		
		public int ReserveSlice(Texture texture, out bool needUpdate) {
			needUpdate = default;
			return default;
		} // 0x0000000189B4122C-0x0000000189B4149C
		// Int32 ReserveSlice(Texture, Boolean ByRef)
		int32_t HG::Rendering::Runtime::TextureCache::ReserveSlice(
		        TextureCache *this,
		        Texture *texture,
		        bool *needUpdate,
		        MethodInfo *method)
		{
		  TextureCache__StaticFields *static_fields; // rdx
		  Dictionary_2_System_UInt32_System_Int32_ *m_LocatorInSliceDictionnary; // rcx
		  int32_t InstanceID; // ebp
		  int32_t i; // ebx
		  Int32__Array *m_SortedIdxArray; // rsi
		  __int64 v12; // rsi
		  int v13; // ebx
		  Dictionary_2_System_UInt32_System_Int32_ *v14; // rbx
		  uint32_t *v15; // rax
		  uint32_t TextureHash; // eax
		  bool v17; // bp
		  bool v18; // bl
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t value[6]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(366, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(366, 0LL);
		    if ( !Patch )
		      goto LABEL_32;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_173(Patch, (Object *)this, (Object *)texture, needUpdate, 0LL);
		  }
		  else
		  {
		    *needUpdate = 0;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality((Object_1 *)texture, 0LL, 0LL) )
		      return -1;
		    if ( !texture )
		      goto LABEL_32;
		    InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)texture, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TextureCache);
		    static_fields = TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields;
		    if ( InstanceID == static_fields->g_InvalidTexID )
		    {
		      return -1;
		    }
		    else
		    {
		      value[0] = -1;
		      m_LocatorInSliceDictionnary = this->fields.m_LocatorInSliceDictionnary;
		      if ( !m_LocatorInSliceDictionnary )
		        goto LABEL_32;
		      if ( System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue(
		             m_LocatorInSliceDictionnary,
		             InstanceID,
		             value,
		             MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue) )
		      {
		        TextureHash = HG::Rendering::Runtime::TextureCache::GetTextureHash(this, texture, 0LL);
		        m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this->fields.m_SliceArray;
		        if ( !m_LocatorInSliceDictionnary )
		          goto LABEL_32;
		        LODWORD(v12) = value[0];
		        v17 = *needUpdate;
		        *needUpdate = v17 | (*(_DWORD *)(sub_1803C07B0(m_LocatorInSliceDictionnary, value[0]) + 8) != TextureHash);
		      }
		      else
		      {
		        for ( i = 0; ; ++i )
		        {
		          if ( i >= this->fields.m_NumTextures )
		          {
		            LODWORD(v12) = value[0];
		            goto LABEL_26;
		          }
		          m_SortedIdxArray = this->fields.m_SortedIdxArray;
		          if ( !m_SortedIdxArray )
		            goto LABEL_32;
		          if ( (unsigned int)i >= m_SortedIdxArray->max_length.size )
		            sub_1800D2AB0(m_LocatorInSliceDictionnary, static_fields);
		          m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this->fields.m_SliceArray;
		          v12 = m_SortedIdxArray->vector[i];
		          if ( !m_LocatorInSliceDictionnary )
		            goto LABEL_32;
		          if ( *(_DWORD *)(sub_1803C07B0(m_LocatorInSliceDictionnary, v12) + 4) )
		            break;
		        }
		        *needUpdate = 1;
		        m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this->fields.m_SliceArray;
		        if ( !m_LocatorInSliceDictionnary )
		          goto LABEL_32;
		        v13 = *(_DWORD *)sub_1803C07B0(m_LocatorInSliceDictionnary, v12);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TextureCache);
		        if ( v13 != TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields->g_InvalidTexID )
		        {
		          m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this->fields.m_SliceArray;
		          v14 = this->fields.m_LocatorInSliceDictionnary;
		          if ( m_LocatorInSliceDictionnary )
		          {
		            v15 = (uint32_t *)sub_1803C07B0(m_LocatorInSliceDictionnary, v12);
		            if ( v14 )
		            {
		              System::Collections::Generic::Dictionary<unsigned int,int>::Remove(
		                v14,
		                *v15,
		                MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Remove);
		              goto LABEL_19;
		            }
		          }
		LABEL_32:
		          sub_1800D8260(m_LocatorInSliceDictionnary, static_fields);
		        }
		LABEL_19:
		        m_LocatorInSliceDictionnary = this->fields.m_LocatorInSliceDictionnary;
		        if ( !m_LocatorInSliceDictionnary )
		          goto LABEL_32;
		        System::Collections::Generic::Dictionary<unsigned int,int>::Add(
		          m_LocatorInSliceDictionnary,
		          InstanceID,
		          v12,
		          MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Add);
		        m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this->fields.m_SliceArray;
		        if ( !m_LocatorInSliceDictionnary )
		          goto LABEL_32;
		        *(_DWORD *)sub_1803C07B0(m_LocatorInSliceDictionnary, v12) = InstanceID;
		      }
		LABEL_26:
		      if ( (_DWORD)v12 != -1 )
		      {
		        m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this->fields.m_SliceArray;
		        if ( !m_LocatorInSliceDictionnary )
		          goto LABEL_32;
		        *(_DWORD *)(sub_1803C07B0(m_LocatorInSliceDictionnary, (int)v12) + 4) = 0;
		      }
		      v18 = *needUpdate;
		      *needUpdate = v18 | sub_180006280(4LL, this) ^ 1;
		      return v12;
		    }
		  }
		}
		
		[IDTag(0)]
		public bool UpdateSlice(CommandBuffer cmd, int sliceIndex, Texture[] contentArray, uint textureHash) => default; // 0x0000000189B415F0-0x0000000189B41698
		// Boolean UpdateSlice(CommandBuffer, Int32, Texture[], UInt32)
		bool HG::Rendering::Runtime::TextureCache::UpdateSlice(
		        TextureCache *this,
		        CommandBuffer *cmd,
		        int32_t sliceIndex,
		        Texture__Array *contentArray,
		        uint32_t textureHash,
		        MethodInfo *method)
		{
		  int v10; // ecx
		  __int64 v12; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(367, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(367, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v12);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_175(
		             Patch,
		             (Object *)this,
		             (Object *)cmd,
		             sliceIndex,
		             (Object *)contentArray,
		             textureHash,
		             0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::TextureCache::SetSliceHash(this, sliceIndex, textureHash, 0LL);
		    return sub_1808ADCA4(v10, (_DWORD)this, (_DWORD)cmd, sliceIndex, (__int64)contentArray);
		  }
		}
		
		[IDTag(1)]
		public bool UpdateSlice(CommandBuffer cmd, int sliceIndex, Texture texture, uint textureHash) => default; // 0x0000000189B41518-0x0000000189B415F0
		// Boolean UpdateSlice(CommandBuffer, Int32, Texture, UInt32)
		bool HG::Rendering::Runtime::TextureCache::UpdateSlice(
		        TextureCache *this,
		        CommandBuffer *cmd,
		        int32_t sliceIndex,
		        Texture *texture,
		        uint32_t textureHash,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Texture__Array *m_autoContentArray; // rdi
		  int v13; // ecx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(369, 0LL) )
		  {
		    HG::Rendering::Runtime::TextureCache::SetSliceHash(this, sliceIndex, textureHash, 0LL);
		    m_autoContentArray = this->fields.m_autoContentArray;
		    if ( m_autoContentArray )
		    {
		      sub_180031B10(this->fields.m_autoContentArray, texture);
		      sub_180378FEC(m_autoContentArray, 0LL, texture);
		      return sub_1808ADCA4(v13, (_DWORD)this, (_DWORD)cmd, sliceIndex, (__int64)this->fields.m_autoContentArray);
		    }
		LABEL_5:
		    sub_1800D8260(Patch, v10);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(369, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_175(
		           Patch,
		           (Object *)this,
		           (Object *)cmd,
		           sliceIndex,
		           (Object *)texture,
		           textureHash,
		           0LL);
		}
		
		public void SetSliceHash(int sliceIndex, uint hash) {} // 0x0000000189B4149C-0x0000000189B41518
		// Void SetSliceHash(Int32, UInt32)
		void HG::Rendering::Runtime::TextureCache::SetSliceHash(
		        TextureCache *this,
		        int32_t sliceIndex,
		        uint32_t hash,
		        MethodInfo *method)
		{
		  __int64 v4; // rsi
		  __int64 v7; // rdx
		  TextureCache_SliceEntry__Array *m_SliceArray; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v4 = sliceIndex;
		  if ( !IFix::WrappersManagerImpl::IsPatched(368, 0LL) )
		  {
		    m_SliceArray = this->fields.m_SliceArray;
		    if ( m_SliceArray )
		    {
		      *(_DWORD *)(sub_1803C07B0(m_SliceArray, v4) + 8) = hash;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_SliceArray, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(368, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_272(
		    (ILFixDynamicMethodWrapper_6 *)Patch,
		    (Object *)this,
		    (UIInertiaViewPager_State__Enum)v4,
		    (UIInertiaViewPager_State__Enum)hash,
		    0LL);
		}
		
		protected abstract bool TransferToSlice(CommandBuffer cmd, int sliceIndex, Texture[] textureArray);
		public int FetchSlice(CommandBuffer cmd, Texture texture, bool forceReinject = false /* Metadata: 0x02302EE9 */) => default; // 0x0000000189B40A58-0x0000000189B40B54
		// Int32 FetchSlice(CommandBuffer, Texture, Boolean)
		int32_t HG::Rendering::Runtime::TextureCache::FetchSlice(
		        TextureCache *this,
		        CommandBuffer *cmd,
		        Texture *texture,
		        bool forceReinject,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  int32_t v10; // esi
		  __int64 v11; // rcx
		  Texture__Array *m_autoContentArray; // rbx
		  Texture__Array *v13; // rbx
		  uint32_t textureHash; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  bool needUpdate; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(370, 0LL) )
		  {
		    needUpdate = 0;
		    v10 = HG::Rendering::Runtime::TextureCache::ReserveSlice(this, texture, &needUpdate, 0LL);
		    LOBYTE(v11) = forceReinject || needUpdate;
		    if ( v10 == -1 || !(_BYTE)v11 )
		      return v10;
		    m_autoContentArray = this->fields.m_autoContentArray;
		    if ( m_autoContentArray )
		    {
		      sub_180031B10(this->fields.m_autoContentArray, texture);
		      sub_180378FEC(m_autoContentArray, 0LL, texture);
		      v13 = this->fields.m_autoContentArray;
		      textureHash = HG::Rendering::Runtime::TextureCache::GetTextureHash(this, texture, 0LL);
		      HG::Rendering::Runtime::TextureCache::UpdateSlice(this, cmd, v10, v13, textureHash, 0LL);
		      return v10;
		    }
		LABEL_8:
		    sub_1800D8260(v11, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(370, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_176(
		           Patch,
		           (Object *)this,
		           (Object *)cmd,
		           (Object *)texture,
		           forceReinject,
		           0LL);
		}
		
		public void NewFrame() {} // 0x0000000189B40D8C-0x0000000189B41030
		// Void NewFrame()
		void HG::Rendering::Runtime::TextureCache::NewFrame(TextureCache *this, MethodInfo *method)
		{
		  int32_t v3; // ebx
		  List_1_System_Int32_ *static_fields; // rcx
		  int *monitor; // rdx
		  int32_t v6; // esi
		  Int32__Array *m_SortedIdxArray; // rax
		  __int64 v8; // rax
		  int v9; // ecx
		  int32_t v10; // r14d
		  int32_t v11; // esi
		  TextureCache_SliceEntry__Array *m_SliceArray; // rbp
		  int32_t Item; // eax
		  __int64 v14; // rax
		  Int32__Array *v15; // rbp
		  int32_t v16; // eax
		  __int64 v17; // rcx
		  int v18; // esi
		  uint32_t v19; // ebx
		  __int64 v20; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(371, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(371, 0LL);
		    if ( !Patch )
		      goto LABEL_35;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v3 = 0;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TextureCache);
		    static_fields = (List_1_System_Int32_ *)TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields;
		    monitor = (int *)static_fields->monitor;
		    if ( !monitor )
		      goto LABEL_35;
		    ++monitor[7];
		    monitor[6] = 0;
		    v6 = 0;
		    if ( this->fields.m_NumTextures > 0 )
		    {
		      while ( 1 )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TextureCache);
		        m_SortedIdxArray = this->fields.m_SortedIdxArray;
		        static_fields = TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields->s_TempIntList;
		        if ( !m_SortedIdxArray )
		          break;
		        if ( (unsigned int)v6 >= m_SortedIdxArray->max_length.size )
		          goto LABEL_33;
		        if ( !static_fields )
		          break;
		        sub_183081250(
		          static_fields,
		          (unsigned int)m_SortedIdxArray->vector[v6],
		          MethodInfo::System::Collections::Generic::List<int>::Add);
		        monitor = (int *)this->fields.m_SortedIdxArray;
		        if ( !monitor )
		          break;
		        if ( v6 >= (unsigned int)monitor[6] )
		LABEL_33:
		          sub_1800D2AB0(static_fields, monitor);
		        static_fields = (List_1_System_Int32_ *)this->fields.m_SliceArray;
		        if ( !static_fields )
		          break;
		        v8 = sub_1803C07B0(static_fields, monitor[v6 + 8]);
		        v9 = v3 + 1;
		        if ( !*(_DWORD *)(v8 + 4) )
		          v9 = v3;
		        ++v6;
		        v3 = v9;
		        if ( v6 >= this->fields.m_NumTextures )
		          goto LABEL_13;
		      }
		LABEL_35:
		      sub_1800D8260(static_fields, monitor);
		    }
		LABEL_13:
		    v10 = 0;
		    v11 = 0;
		    if ( this->fields.m_NumTextures > 0 )
		    {
		      do
		      {
		        m_SliceArray = this->fields.m_SliceArray;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TextureCache);
		        monitor = (int *)TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields;
		        static_fields = (List_1_System_Int32_ *)*((_QWORD *)monitor + 1);
		        if ( !static_fields )
		          goto LABEL_35;
		        Item = System::Collections::Generic::List<int>::get_Item(
		                 static_fields,
		                 v11,
		                 MethodInfo::System::Collections::Generic::List<int>::get_Item);
		        if ( !m_SliceArray )
		          goto LABEL_35;
		        v14 = sub_1803C07B0(m_SliceArray, Item);
		        v15 = this->fields.m_SortedIdxArray;
		        if ( *(_DWORD *)(v14 + 4) )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TextureCache);
		          static_fields = TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields->s_TempIntList;
		          if ( !static_fields )
		            goto LABEL_35;
		          v16 = System::Collections::Generic::List<int>::get_Item(
		                  static_fields,
		                  v11,
		                  MethodInfo::System::Collections::Generic::List<int>::get_Item);
		          if ( !v15 )
		            goto LABEL_35;
		          if ( (unsigned int)v10 >= v15->max_length.size )
		            goto LABEL_33;
		          v17 = v10++;
		        }
		        else
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TextureCache);
		          static_fields = TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields->s_TempIntList;
		          if ( !static_fields )
		            goto LABEL_35;
		          v16 = System::Collections::Generic::List<int>::get_Item(
		                  static_fields,
		                  v11,
		                  MethodInfo::System::Collections::Generic::List<int>::get_Item);
		          if ( !v15 )
		            goto LABEL_35;
		          if ( (unsigned int)v3 >= v15->max_length.size )
		            goto LABEL_33;
		          v17 = v3++;
		        }
		        v15->vector[v17] = v16;
		      }
		      while ( ++v11 < this->fields.m_NumTextures );
		    }
		    v18 = 0;
		    if ( this->fields.m_NumTextures > 0 )
		    {
		      while ( 1 )
		      {
		        static_fields = (List_1_System_Int32_ *)this->fields.m_SliceArray;
		        if ( !static_fields )
		          goto LABEL_35;
		        v19 = *(_DWORD *)(sub_1803C07B0(static_fields, v18) + 4);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TextureCache);
		        if ( v19 < TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields->g_MaxFrameCount )
		        {
		          static_fields = (List_1_System_Int32_ *)this->fields.m_SliceArray;
		          if ( !static_fields )
		            goto LABEL_35;
		          v20 = sub_1803C07B0(static_fields, v18);
		          ++*(_DWORD *)(v20 + 4);
		        }
		        if ( ++v18 >= this->fields.m_NumTextures )
		          return;
		      }
		    }
		  }
		}
		
		public void RemoveEntryFromSlice(Texture texture) {} // 0x0000000189B41030-0x0000000189B4122C
		// Void RemoveEntryFromSlice(Texture)
		void HG::Rendering::Runtime::TextureCache::RemoveEntryFromSlice(
		        TextureCache *this,
		        Texture *texture,
		        MethodInfo *method)
		{
		  __int64 static_fields; // rdx
		  Dictionary_2_System_UInt32_System_Int32_ *m_LocatorInSliceDictionnary; // rcx
		  int32_t InstanceID; // ebx
		  int32_t Item; // eax
		  __int64 v9; // rsi
		  int32_t v10; // r8d
		  int v11; // eax
		  __int64 v12; // r9
		  __int64 v13; // rax
		  Int32__Array *m_SortedIdxArray; // rax
		  TextureCache_SliceEntry__Array *m_SliceArray; // rbp
		  uint32_t g_MaxFrameCount; // ebx
		  uint32_t g_InvalidTexID; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(372, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(372, 0LL);
		    if ( !Patch )
		      goto LABEL_27;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)texture,
		      0LL);
		  }
		  else
		  {
		    if ( !texture )
		      goto LABEL_27;
		    InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)texture, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TextureCache);
		    static_fields = (__int64)TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields;
		    if ( InstanceID != *(_DWORD *)(static_fields + 4) )
		    {
		      m_LocatorInSliceDictionnary = this->fields.m_LocatorInSliceDictionnary;
		      if ( !m_LocatorInSliceDictionnary )
		        goto LABEL_27;
		      if ( System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey(
		             m_LocatorInSliceDictionnary,
		             InstanceID,
		             MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey) )
		      {
		        m_LocatorInSliceDictionnary = this->fields.m_LocatorInSliceDictionnary;
		        if ( !m_LocatorInSliceDictionnary )
		          goto LABEL_27;
		        Item = System::Collections::Generic::Dictionary<unsigned int,int>::get_Item(
		                 m_LocatorInSliceDictionnary,
		                 InstanceID,
		                 MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::get_Item);
		        LOBYTE(static_fields) = 0;
		        v9 = Item;
		        v10 = 0;
		        do
		        {
		          if ( v10 >= this->fields.m_NumTextures )
		            return;
		          m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this->fields.m_SortedIdxArray;
		          if ( !m_LocatorInSliceDictionnary )
		            goto LABEL_27;
		          if ( (unsigned int)v10 >= LODWORD(m_LocatorInSliceDictionnary->fields._entries) )
		            goto LABEL_25;
		          static_fields = (unsigned __int8)static_fields;
		          v11 = v10 + 1;
		          if ( *(&m_LocatorInSliceDictionnary->fields._count + v10) == (_DWORD)v9 )
		          {
		            v11 = v10;
		            static_fields = 1LL;
		          }
		          v10 = v11;
		        }
		        while ( !(_BYTE)static_fields );
		        static_fields = 0LL;
		        if ( v11 > 0 )
		        {
		          do
		          {
		            m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this->fields.m_SortedIdxArray;
		            if ( !m_LocatorInSliceDictionnary )
		              goto LABEL_27;
		            if ( (unsigned int)static_fields >= LODWORD(m_LocatorInSliceDictionnary->fields._entries) )
		              goto LABEL_25;
		            v12 = (int)static_fields + 1LL;
		            if ( (unsigned int)v12 >= LODWORD(m_LocatorInSliceDictionnary->fields._entries) )
		              goto LABEL_25;
		            v13 = (int)static_fields;
		            static_fields = (unsigned int)(static_fields + 1);
		            m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)*((unsigned int *)&m_LocatorInSliceDictionnary->fields._count
		                                                                                      + v13);
		            this->fields.m_SortedIdxArray->vector[v12] = (int)m_LocatorInSliceDictionnary;
		          }
		          while ( (int)static_fields < v10 );
		        }
		        m_SortedIdxArray = this->fields.m_SortedIdxArray;
		        if ( !m_SortedIdxArray )
		          goto LABEL_27;
		        if ( !m_SortedIdxArray->max_length.size )
		LABEL_25:
		          sub_1800D2AB0(m_LocatorInSliceDictionnary, static_fields);
		        m_SortedIdxArray->vector[0] = v9;
		        m_LocatorInSliceDictionnary = this->fields.m_LocatorInSliceDictionnary;
		        if ( !m_LocatorInSliceDictionnary
		          || (System::Collections::Generic::Dictionary<unsigned int,int>::Remove(
		                m_LocatorInSliceDictionnary,
		                InstanceID,
		                MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Remove),
		              (m_SliceArray = this->fields.m_SliceArray) == 0LL)
		          || (sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TextureCache),
		              g_MaxFrameCount = TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields->g_MaxFrameCount,
		              *(_DWORD *)(sub_1803C07B0(m_SliceArray, v9) + 4) = g_MaxFrameCount,
		              (m_LocatorInSliceDictionnary = (Dictionary_2_System_UInt32_System_Int32_ *)this->fields.m_SliceArray) == 0LL) )
		        {
		LABEL_27:
		          sub_1800D8260(m_LocatorInSliceDictionnary, static_fields);
		        }
		        g_InvalidTexID = TypeInfo::HG::Rendering::Runtime::TextureCache->static_fields->g_InvalidTexID;
		        *(_DWORD *)sub_1803C07B0(m_LocatorInSliceDictionnary, v9) = g_InvalidTexID;
		      }
		    }
		  }
		}
		
		[IDTag(1)]
		protected int GetNumMips(int width, int height) => default; // 0x0000000189B40C5C-0x0000000189B40CDC
		// Int32 GetNumMips(Int32, Int32)
		int32_t HG::Rendering::Runtime::TextureCache::GetNumMips(
		        TextureCache *this,
		        int32_t width,
		        int32_t height,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(373, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(373, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_10(
		               (ILFixDynamicMethodWrapper_14 *)Patch,
		               (Object *)this,
		               (SocketOptionLevel__Enum)width,
		               (SocketOptionName__Enum)height,
		               0LL);
		LABEL_7:
		    sub_1800D8260(v8, v7);
		  }
		  if ( !this )
		    goto LABEL_7;
		  if ( width <= height )
		    width = height;
		  return HG::Rendering::Runtime::TextureCache::GetNumMips(this, width, 0LL);
		}
		
		[IDTag(0)]
		protected int GetNumMips(int dim) => default; // 0x0000000189B40BF0-0x0000000189B40C5C
		// Int32 GetNumMips(Int32)
		int32_t HG::Rendering::Runtime::TextureCache::GetNumMips(TextureCache *this, int32_t dim, MethodInfo *method)
		{
		  int32_t v5; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  v5 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(374, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(374, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(
		             (ILFixDynamicMethodWrapper_6 *)Patch,
		             (Object *)this,
		             (NaviDirection__Enum)dim,
		             0LL);
		  }
		  else
		  {
		    for ( ; dim; dim = (unsigned int)dim >> 1 )
		      ++v5;
		    return v5;
		  }
		}
		
	}
}
