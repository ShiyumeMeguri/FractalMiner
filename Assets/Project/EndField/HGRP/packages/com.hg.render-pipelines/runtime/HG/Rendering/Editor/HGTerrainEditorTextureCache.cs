using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Editor
{
	[CreateAssetMenu(fileName = "HGTerrainEditorTextureCache", menuName = "HGTerrain/HGTerrainEditorTextureCache", order = 0)]
	public class HGTerrainEditorTextureCache : ScriptableObject
	{
		public HGTerrainEditorTextureCache()
		{
			// // SingletonScriptableObject`1[System.Object]()
			// void Beyond::SingletonScriptableObject<System::Object>::SingletonScriptableObject(
			//         SingletonScriptableObject_1_System_Object_ *this,
			//         MethodInfo *method)
			// {
			//   UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
			// }
			// 
		}

		public static Dictionary<string, HGTerrainEditorTextureCache.TextureCacheEntry> GetTextureCache(HGTerrainEditorTextureCache cache)
		{
			// // Dictionary`2[System.String,HG.Rendering.Editor.HGTerrainEditorTextureCache+TextureCacheEntry] GetTextureCache(HGTerrainEditorTextureCache)
			// Dictionary_2_System_String_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *HG::Rendering::Editor::HGTerrainEditorTextureCache::GetTextureCache(
			//         HGTerrainEditorTextureCache *cache,
			//         MethodInfo *method)
			// {
			//   int32_t v2; // ebx
			//   Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *v4; // rax
			//   Dictionary_2_System_String_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *v5; // rdi
			//   HGTerrainEditorTextureCache_TextureCacheEntry__Array *textureCache; // rsi
			//   Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *v8; // rax
			//   HGTerrainEditorTextureCache_TextureCacheEntry v9; // [rsp+20h] [rbp-88h] BYREF
			//   HGTerrainEditorTextureCache_TextureCacheEntry v10; // [rsp+60h] [rbp-48h] BYREF
			// 
			//   v2 = 0;
			//   if ( !byte_18D9193C7 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>::TryAdd);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>::Dictionary);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>);
			//     byte_18D9193C7 = 1;
			//   }
			//   if ( !cache )
			//     goto LABEL_12;
			//   if ( !cache.fields.textureCache )
			//   {
			//     v8 = (Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>);
			//     v5 = (Dictionary_2_System_String_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *)v8;
			//     if ( v8 )
			//     {
			//       System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>::Dictionary(
			//         v8,
			//         MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>::Dictionary);
			//       return v5;
			//     }
			// LABEL_12:
			//     sub_180B536AC(cache, method);
			//   }
			//   v4 = (Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>);
			//   v5 = (Dictionary_2_System_String_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *)v4;
			//   if ( !v4 )
			//     goto LABEL_12;
			//   System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>::Dictionary(
			//     v4,
			//     MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>::Dictionary);
			//   textureCache = cache.fields.textureCache;
			//   if ( !textureCache )
			//     goto LABEL_12;
			//   while ( v2 < textureCache.max_length.size )
			//   {
			//     sub_18052C0D8(textureCache, &v9, v2);
			//     v10 = v9;
			//     System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>::TryAdd(
			//       (Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_TextureCacheEntry_ *)v5,
			//       (Object *)v9.srcPath,
			//       &v10,
			//       MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::TextureCacheEntry>::TryAdd);
			//     ++v2;
			//   }
			//   return v5;
			// }
			// 
			return null;
		}

		public static Dictionary<string, HGTerrainEditorTextureCache.SceneCacheEntry> GetSceneCache(HGTerrainEditorTextureCache cache)
		{
			// // Dictionary`2[System.String,HG.Rendering.Editor.HGTerrainEditorTextureCache+SceneCacheEntry] GetSceneCache(HGTerrainEditorTextureCache)
			// Dictionary_2_System_String_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *HG::Rendering::Editor::HGTerrainEditorTextureCache::GetSceneCache(
			//         HGTerrainEditorTextureCache *cache,
			//         MethodInfo *method)
			// {
			//   int32_t v2; // ebx
			//   Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *v4; // rax
			//   Dictionary_2_System_String_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *v5; // rdi
			//   __int64 v6; // r9
			//   HGTerrainEditorTextureCache_SceneCacheEntry__Array *sceneCache; // rsi
			//   Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *v9; // rax
			//   HGTerrainEditorTextureCache_SceneCacheEntry v10; // [rsp+20h] [rbp-28h] BYREF
			//   HGTerrainEditorTextureCache_SceneCacheEntry v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   v2 = 0;
			//   if ( !byte_18D9193C8 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>::TryAdd);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>::Dictionary);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>);
			//     byte_18D9193C8 = 1;
			//   }
			//   if ( !cache )
			//     goto LABEL_12;
			//   if ( !cache.fields.sceneCache )
			//   {
			//     v9 = (Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>);
			//     v5 = (Dictionary_2_System_String_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *)v9;
			//     if ( v9 )
			//     {
			//       System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>::Dictionary(
			//         v9,
			//         MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>::Dictionary);
			//       return v5;
			//     }
			// LABEL_12:
			//     sub_180B536AC(cache, method);
			//   }
			//   v4 = (Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>);
			//   v5 = (Dictionary_2_System_String_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *)v4;
			//   if ( !v4 )
			//     goto LABEL_12;
			//   System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>::Dictionary(
			//     v4,
			//     MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>::Dictionary);
			//   sceneCache = cache.fields.sceneCache;
			//   if ( !sceneCache )
			//     goto LABEL_12;
			//   while ( v2 < sceneCache.max_length.size )
			//   {
			//     sub_18037A36C(sceneCache, &v10, v2, v6);
			//     v11 = v10;
			//     System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>::TryAdd(
			//       (Dictionary_2_System_Object_HG_Rendering_Editor_HGTerrainEditorTextureCache_SceneCacheEntry_ *)v5,
			//       (Object *)v10.scenePath,
			//       &v11,
			//       MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Editor::HGTerrainEditorTextureCache::SceneCacheEntry>::TryAdd);
			//     ++v2;
			//   }
			//   return v5;
			// }
			// 
			return null;
		}

		public const int CURRENT_TEXTURE_CACHE_VERSION = 1;

		public HGTerrainEditorTextureCache.TextureCacheEntry[] textureCache;

		public HGTerrainEditorTextureCache.SceneCacheEntry[] sceneCache;

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 56)]
		public struct TextureCacheEntry
		{
			public string srcPath;

			public byte[] dstGuid;

			public Hash128 hash1280;

			public Hash128 hash1281;

			public int version;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct SceneCacheEntry
		{
			public string scenePath;

			public string[] srcPaths;
		}
	}
}
