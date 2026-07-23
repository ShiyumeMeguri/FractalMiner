using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Editor
{
	[CreateAssetMenu(fileName = "HGTerrainEditorTextureCache", menuName = "\u2605 Beyond/HGTerrain/HGTerrainEditorTextureCache", order = 0)]
	public class HGTerrainEditorTextureCache : ScriptableObject // TypeDefIndex: 37492
	{
		// Fields
		public const int CURRENT_TEXTURE_CACHE_VERSION = 1; // Metadata: 0x02302EA6
		public TextureCacheEntry[] textureCache; // 0x18
		public SceneCacheEntry[] sceneCache; // 0x20
	
		// Nested types
		[Serializable]
		public struct TextureCacheEntry // TypeDefIndex: 37490
		{
			// Fields
			public string srcPath; // 0x00
			public byte[] dstGuid; // 0x08
			public Hash128 hash1280; // 0x10
			public Hash128 hash1281; // 0x20
			public int version; // 0x30
		}
	
		[Serializable]
		public struct SceneCacheEntry // TypeDefIndex: 37491
		{
			// Fields
			public string scenePath; // 0x00
			public string[] srcPaths; // 0x08
		}
	
		// Constructors
		public HGTerrainEditorTextureCache() {} // 0x0000000183573370-0x0000000183573380
		// SingletonScriptableObject`1[System.Object]()
		void Beyond::SingletonScriptableObject<System::Object>::SingletonScriptableObject(
		        SingletonScriptableObject_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	
		// Methods
		public static Dictionary<string, TextureCacheEntry> GetTextureCache(HGTerrainEditorTextureCache cache) => default; // 0x0000000189B3C004-0x0000000189B3C100
		// Dictionary`2[System.String,HG.Rendering.Editor.HGTerrainEditorTextureCache+TextureCacheEntry] GetTextureCache(HGTerrainEditorTextureCache)
		Dictionary_2_System_String_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *HG::Rendering::Editor::HGTerrainEditorTextureCache::GetTextureCache(
		        HGTerrainEditorTextureCache *cache,
		        MethodInfo *method)
		{
		  int32_t v2; // ebx
		  Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *v4; // rax
		  Dictionary_2_System_String_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *v5; // rdi
		  HGTerrainEditorTextureCache_TextureCacheEntry__Array *textureCache; // rsi
		  Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *v8; // rax
		  HGTerrainEditorTextureCache_TextureCacheEntry v9; // [rsp+20h] [rbp-88h] BYREF
		  HGTerrainEditorTextureCache_TextureCacheEntry v10; // [rsp+60h] [rbp-48h] BYREF
		
		  v2 = 0;
		  if ( !cache )
		    goto LABEL_10;
		  if ( !cache->fields.textureCache )
		  {
		    v8 = (Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>);
		    v5 = (Dictionary_2_System_String_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *)v8;
		    if ( v8 )
		    {
		      System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>::Dictionary(
		        v8,
		        MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>::Dictionary);
		      return v5;
		    }
		LABEL_10:
		    sub_1800D8260(cache, method);
		  }
		  v4 = (Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>);
		  v5 = (Dictionary_2_System_String_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *)v4;
		  if ( !v4 )
		    goto LABEL_10;
		  System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>::Dictionary(
		    v4,
		    MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>::Dictionary);
		  textureCache = cache->fields.textureCache;
		  if ( !textureCache )
		    goto LABEL_10;
		  while ( v2 < textureCache->max_length.size )
		  {
		    sub_1805942F8(textureCache, &v9, v2);
		    v10 = v9;
		    System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>::TryAdd(
		      (Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *)v5,
		      (Object *)v9.srcPath,
		      &v10,
		      MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>::TryAdd);
		    ++v2;
		  }
		  return v5;
		}
		
		public static Dictionary<string, SceneCacheEntry> GetSceneCache(HGTerrainEditorTextureCache cache) => default; // 0x0000000189B3BF3C-0x0000000189B3C004
		// Dictionary`2[System.String,HG.Rendering.Editor.HGTerrainEditorTextureCache+SceneCacheEntry] GetSceneCache(HGTerrainEditorTextureCache)
		Dictionary_2_System_String_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *HG::Rendering::Editor::HGTerrainEditorTextureCache::GetSceneCache(
		        HGTerrainEditorTextureCache *cache,
		        MethodInfo *method)
		{
		  int32_t v2; // ebx
		  Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *v4; // rax
		  Dictionary_2_System_String_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *v5; // rdi
		  __int64 v6; // r9
		  HGTerrainEditorTextureCache_SceneCacheEntry__Array *sceneCache; // rsi
		  Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *v9; // rax
		  HGTerrainEditorTextureCache_SceneCacheEntry v10; // [rsp+20h] [rbp-28h] BYREF
		  HGTerrainEditorTextureCache_SceneCacheEntry v11; // [rsp+30h] [rbp-18h] BYREF
		
		  v2 = 0;
		  if ( !cache )
		    goto LABEL_10;
		  if ( !cache->fields.sceneCache )
		  {
		    v9 = (Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>);
		    v5 = (Dictionary_2_System_String_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *)v9;
		    if ( v9 )
		    {
		      System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>::Dictionary(
		        v9,
		        MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>::Dictionary);
		      return v5;
		    }
		LABEL_10:
		    sub_1800D8260(cache, method);
		  }
		  v4 = (Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>);
		  v5 = (Dictionary_2_System_String_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *)v4;
		  if ( !v4 )
		    goto LABEL_10;
		  System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>::Dictionary(
		    v4,
		    MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>::Dictionary);
		  sceneCache = cache->fields.sceneCache;
		  if ( !sceneCache )
		    goto LABEL_10;
		  while ( v2 < sceneCache->max_length.size )
		  {
		    sub_1803C0830(sceneCache, &v10, v2, v6);
		    v11 = v10;
		    System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>::TryAdd(
		      (Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *)v5,
		      (Object *)v10.scenePath,
		      &v11,
		      MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>::TryAdd);
		    ++v2;
		  }
		  return v5;
		}
		
	}
}
