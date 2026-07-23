using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class HGTerrainUtils // TypeDefIndex: 38640
	{
		// Fields
		public const int TERRAIN_LAYER_TEX_RESOLUTION = 1024; // Metadata: 0x02303F5E
		public const int TERRAIN_DECAL_TEXTURE_RESOLUTION = 512; // Metadata: 0x02303F60
		public const int TERRAIN_DECAL_MAX_PER_PAGE = 256; // Metadata: 0x02303F62
		public const int TERRAIN_DECAL_MAX_PER_BLOCK = 16; // Metadata: 0x02303F64
		public const int TERRAIN_DECAL_ACQUISITION_OFFSET = 2; // Metadata: 0x02303F65
		private const int TERRAIN_DECAL_MAX_ALLOWED_LEVEL = 8; // Metadata: 0x02303F66
		public const int TERRAIN_WETNESS_THRESHOLD = 130; // Metadata: 0x02303F67
		private const string TERRAIN_RUNTIME_RESOURCE_PATH = "Terrain/HGTerrainRuntimeResources.asset"; // Metadata: 0x02303F69
		private const string TERRAIN_CONFIGURATION_PATH = "Terrain/HGTerrainConfiguration.asset"; // Metadata: 0x02303F91
		public const string TERRAIN_HEIGHTMAP_RESOURCE_PATH = "Terrain/Heightmap.asset"; // Metadata: 0x02303FB6
		public const string TERRAIN_LIT_MATERIAL_PATH = "Terrain/HGTerrainLitMaterial.mat"; // Metadata: 0x02303FCE
		public const string TERRAIN_DATA_ROOT_FOLDER_NAME = "Data/Terrain"; // Metadata: 0x02303FEF
		public const string TERRAIN_ROOT_FOLDER_NAME = "Terrain"; // Metadata: 0x02303FFC
		public const string TERRAIN_INTERMEDIATE_SO_NAME = "[x]HGTerrainDataWithPosObject.asset"; // Metadata: 0x02304004
		public const string TERRAIN_LAYER_NAME = "Terrain"; // Metadata: 0x02304028
		public static readonly int TERRAIN_LAYER_INDEX; // 0x00
		public static readonly int TERRAIN_LAYER_MASK; // 0x04
		public const int TERRAIN_SPLAT_MAX_ALPHAMAP_COUNT = 16; // Metadata: 0x02304030
		public const int TERRAIN_SPLAT_MAX_LAYER_COUNT = 64; // Metadata: 0x02304031
		public const int TERRAIN_SPLAT_TEX_ARRAY_SLICE_COUNT_PC = 32; // Metadata: 0x02304033
		public const int TERRAIN_SPLAT_TEX_ARRAY_SLICE_COUNT_MOBILE = 24; // Metadata: 0x02304034
		public const int AVERAGE_COLOR_CALCULATION_ARRAY_LENGTH = 16; // Metadata: 0x02304035
	
		// Nested types
		public struct Vector2Short // TypeDefIndex: 38637
		{
			// Fields
			public short x; // 0x00
			public short y; // 0x02
		}
	
		[Serializable]
		public struct Vector2UInt // TypeDefIndex: 38638
		{
			// Fields
			public uint x; // 0x00
			public uint y; // 0x04
	
			// Constructors
			public Vector2UInt(uint x, uint y) {
				this.x = default;
				this.y = default;
			} // 0x0000000184D85C40-0x0000000184D85C50
			// ValueTuple`2[Beyond.Gameplay.FunctionAreaManager+FunctionAreaIdentifier,Int32](FunctionAreaManager+FunctionAreaIdentifier, Int32)
			void System::ValueTuple<Beyond::Gameplay::FunctionAreaManager::FunctionAreaIdentifier,int>::ValueTuple(
			        ValueTuple_2_Beyond_Gameplay_FunctionAreaManager_FunctionAreaIdentifier_Int32_ *this,
			        FunctionAreaManager_FunctionAreaIdentifier item1,
			        int32_t item2,
			        MethodInfo *method)
			{
			  this->Item1 = item1;
			  this->Item2 = item2;
			}
			
		}
	
		// Constructors
		static HGTerrainUtils() {} // 0x0000000184D59A70-0x0000000184D59AC0
		// HGTerrainUtils()
		void HG::Rendering::Runtime::HGTerrainUtils::cctor(MethodInfo *method)
		{
		  TypeInfo::HG::Rendering::Runtime::HGTerrainUtils->static_fields->TERRAIN_LAYER_INDEX = UnityEngine::LayerMask::NameToLayer(
		                                                                                           (String *)"Terrain",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGTerrainUtils->static_fields->TERRAIN_LAYER_MASK = 1 << (TypeInfo::HG::Rendering::Runtime::HGTerrainUtils->static_fields->TERRAIN_LAYER_INDEX & 0x1F);
		}
		
	
		// Methods
		[IDTag(0)]
		public static string JoinPath(string path0, string path1) => default; // 0x0000000189C225F4-0x0000000189C226D4
		// String JoinPath(String, String)
		String *HG::Rendering::Runtime::HGTerrainUtils::JoinPath(String *path0, String *path1, MethodInfo *method)
		{
		  ReadOnlySpan_1_Char_ v5; // xmm7
		  ReadOnlySpan_1_Char_ v6; // xmm6
		  String *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  String *v10; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ReadOnlySpan_1_Char_ v13; // [rsp+20h] [rbp-48h] BYREF
		  ReadOnlySpan_1_Char_ v14; // [rsp+30h] [rbp-38h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4033, 0LL) )
		  {
		    v5 = *(ReadOnlySpan_1_Char_ *)sub_182F12A50(&v14, path0);
		    v6 = *(ReadOnlySpan_1_Char_ *)sub_182F12A50(&v14, path1);
		    sub_1800036A0(TypeInfo::System::IO::Path);
		    v13 = v6;
		    v14 = v5;
		    v7 = System::IO::Path::Join(&v14, &v13, 0LL);
		    if ( v7 )
		    {
		      v10 = System::String::Replace(v7, 0x5Cu, 0x2Fu, 0LL);
		      if ( v10 )
		        return System::String::TrimEnd(v10, 0x2Fu, 0LL);
		    }
		LABEL_6:
		    sub_1800D8260(v9, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4033, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_130(Patch, (Object *)path0, (Object *)path1, 0LL);
		}
		
		public static string GenSubTerrainName(int index) => default; // 0x0000000189C21EE8-0x0000000189C21F58
		// String GenSubTerrainName(Int32)
		String *HG::Rendering::Runtime::HGTerrainUtils::GenSubTerrainName(int32_t index, MethodInfo *method)
		{
		  Object *v3; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  int32_t v8; // [rsp+40h] [rbp+18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4034, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4034, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1423(Patch, index, 0LL);
		  }
		  else
		  {
		    v8 = index;
		    v3 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v8);
		    return System::String::Format((String *)"Sub Terrain {0}", v3, 0LL);
		  }
		}
		
		[IDTag(1)]
		public static string JoinPath(string path0, string path1, string path2) => default; // 0x0000000189C224CC-0x0000000189C225F4
		// String JoinPath(String, String, String)
		String *HG::Rendering::Runtime::HGTerrainUtils::JoinPath(
		        String *path0,
		        String *path1,
		        String *path2,
		        MethodInfo *method)
		{
		  ReadOnlySpan_1_Char_ v7; // xmm8
		  ReadOnlySpan_1_Char_ v8; // xmm7
		  ReadOnlySpan_1_Char_ v9; // xmm6
		  String *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  String *v13; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ReadOnlySpan_1_Char_ v16; // [rsp+30h] [rbp-68h] BYREF
		  ReadOnlySpan_1_Char_ v17; // [rsp+40h] [rbp-58h] BYREF
		  ReadOnlySpan_1_Char_ v18[2]; // [rsp+50h] [rbp-48h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4035, 0LL) )
		  {
		    v7 = *(ReadOnlySpan_1_Char_ *)sub_182F12A50(v18, path0);
		    v8 = *(ReadOnlySpan_1_Char_ *)sub_182F12A50(v18, path1);
		    v9 = *(ReadOnlySpan_1_Char_ *)sub_182F12A50(v18, path2);
		    sub_1800036A0(TypeInfo::System::IO::Path);
		    v16 = v9;
		    v17 = v8;
		    v18[0] = v7;
		    v10 = System::IO::Path::Join(v18, &v17, &v16, 0LL);
		    if ( v10 )
		    {
		      v13 = System::String::Replace(v10, 0x5Cu, 0x2Fu, 0LL);
		      if ( v13 )
		        return System::String::TrimEnd(v13, 0x2Fu, 0LL);
		    }
		LABEL_6:
		    sub_1800D8260(v12, v11);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4035, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		           (ILFixDynamicMethodWrapper_26 *)Patch,
		           (Object *)path0,
		           (Object *)path1,
		           (Object *)path2,
		           0LL);
		}
		
		[IDTag(0)]
		public static string GetCurrentSceneResourcePath(Terrain terrain = null) => default; // 0x0000000189C2203C-0x0000000189C22130
		// String GetCurrentSceneResourcePath(Terrain)
		String *HG::Rendering::Runtime::HGTerrainUtils::GetCurrentSceneResourcePath(Terrain *terrain, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Scene v5; // eax
		  GameObject *gameObject; // rax
		  int32_t m_Handle; // ebx
		  String *v8; // rdi
		  String *PathInternal; // rax
		  String *v10; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4036, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4036, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		               (ILFixDynamicMethodWrapper_26 *)Patch,
		               (Object *)terrain,
		               0LL);
		    goto LABEL_11;
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Equality((Object_1 *)terrain, 0LL, 0LL) )
		  {
		    if ( terrain )
		    {
		      gameObject = UnityEngine::Component::get_gameObject((Component *)terrain, 0LL);
		      if ( gameObject )
		      {
		        v5.m_Handle = UnityEngine::GameObject::get_scene(gameObject, 0LL).m_Handle;
		        goto LABEL_7;
		      }
		    }
		LABEL_11:
		    sub_1800D8260(v4, v3);
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::SceneManagement::SceneManager);
		  v5.m_Handle = UnityEngine::SceneManagement::SceneManager::GetActiveScene(0LL).m_Handle;
		LABEL_7:
		  m_Handle = v5.m_Handle;
		  v8 = (String *)"";
		  PathInternal = UnityEngine::SceneManagement::Scene::GetPathInternal(v5.m_Handle, 0LL);
		  if ( System::String::op_Inequality(PathInternal, (String *)"", 0LL) )
		  {
		    v10 = UnityEngine::SceneManagement::Scene::GetPathInternal(m_Handle, 0LL);
		    sub_1800036A0(TypeInfo::System::IO::Path);
		    return System::IO::Path::GetDirectoryName(v10, 0LL);
		  }
		  return v8;
		}
		
		[IDTag(1)]
		public static string GetCurrentSceneResourcePath(GameObject gameObject) => default; // 0x0000000189C21F58-0x0000000189C2203C
		// String GetCurrentSceneResourcePath(GameObject)
		String *HG::Rendering::Runtime::HGTerrainUtils::GetCurrentSceneResourcePath(GameObject *gameObject, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Scene v5; // eax
		  int32_t m_Handle; // ebx
		  String *v7; // rdi
		  String *PathInternal; // rax
		  String *v9; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4037, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4037, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		               (ILFixDynamicMethodWrapper_26 *)Patch,
		               (Object *)gameObject,
		               0LL);
		    goto LABEL_10;
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Equality((Object_1 *)gameObject, 0LL, 0LL) )
		  {
		    if ( gameObject )
		    {
		      v5.m_Handle = UnityEngine::GameObject::get_scene(gameObject, 0LL).m_Handle;
		      goto LABEL_6;
		    }
		LABEL_10:
		    sub_1800D8260(v4, v3);
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::SceneManagement::SceneManager);
		  v5.m_Handle = UnityEngine::SceneManagement::SceneManager::GetActiveScene(0LL).m_Handle;
		LABEL_6:
		  m_Handle = v5.m_Handle;
		  v7 = (String *)"";
		  PathInternal = UnityEngine::SceneManagement::Scene::GetPathInternal(v5.m_Handle, 0LL);
		  if ( System::String::op_Inequality(PathInternal, (String *)"", 0LL) )
		  {
		    v9 = UnityEngine::SceneManagement::Scene::GetPathInternal(m_Handle, 0LL);
		    sub_1800036A0(TypeInfo::System::IO::Path);
		    return System::IO::Path::GetDirectoryName(v9, 0LL);
		  }
		  return v7;
		}
		
		public static string GetCurrentTerrainResourcesPath(GameObject terrain = null) => default; // 0x0000000189C22238-0x0000000189C22340
		// String GetCurrentTerrainResourcesPath(GameObject)
		String *HG::Rendering::Runtime::HGTerrainUtils::GetCurrentTerrainResourcesPath(GameObject *terrain, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Scene v5; // eax
		  int32_t m_Handle; // ebx
		  String *v7; // rdi
		  String *PathInternal; // rax
		  String *v9; // rbx
		  String *DirectoryName; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4038, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4038, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		               (ILFixDynamicMethodWrapper_26 *)Patch,
		               (Object *)terrain,
		               0LL);
		    goto LABEL_10;
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Equality((Object_1 *)terrain, 0LL, 0LL) )
		  {
		    if ( terrain )
		    {
		      v5.m_Handle = UnityEngine::GameObject::get_scene(terrain, 0LL).m_Handle;
		      goto LABEL_6;
		    }
		LABEL_10:
		    sub_1800D8260(v4, v3);
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::SceneManagement::SceneManager);
		  v5.m_Handle = UnityEngine::SceneManagement::SceneManager::GetActiveScene(0LL).m_Handle;
		LABEL_6:
		  m_Handle = v5.m_Handle;
		  v7 = (String *)"";
		  PathInternal = UnityEngine::SceneManagement::Scene::GetPathInternal(v5.m_Handle, 0LL);
		  if ( System::String::op_Inequality(PathInternal, (String *)"", 0LL) )
		  {
		    v9 = UnityEngine::SceneManagement::Scene::GetPathInternal(m_Handle, 0LL);
		    sub_1800036A0(TypeInfo::System::IO::Path);
		    DirectoryName = System::IO::Path::GetDirectoryName(v9, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
		    return HG::Rendering::Runtime::HGTerrainUtils::JoinPath(
		             DirectoryName,
		             (String *)"Terrain/HGTerrainRuntimeResources.asset",
		             0LL);
		  }
		  return v7;
		}
		
		public static string GetCurrentTerrainConfigurationPath(GameObject terrain = null) => default; // 0x0000000189C22130-0x0000000189C22238
		// String GetCurrentTerrainConfigurationPath(GameObject)
		String *HG::Rendering::Runtime::HGTerrainUtils::GetCurrentTerrainConfigurationPath(
		        GameObject *terrain,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Scene v5; // eax
		  int32_t m_Handle; // ebx
		  String *v7; // rdi
		  String *PathInternal; // rax
		  String *v9; // rbx
		  String *DirectoryName; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4039, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4039, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		               (ILFixDynamicMethodWrapper_26 *)Patch,
		               (Object *)terrain,
		               0LL);
		    goto LABEL_10;
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Equality((Object_1 *)terrain, 0LL, 0LL) )
		  {
		    if ( terrain )
		    {
		      v5.m_Handle = UnityEngine::GameObject::get_scene(terrain, 0LL).m_Handle;
		      goto LABEL_6;
		    }
		LABEL_10:
		    sub_1800D8260(v4, v3);
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::SceneManagement::SceneManager);
		  v5.m_Handle = UnityEngine::SceneManagement::SceneManager::GetActiveScene(0LL).m_Handle;
		LABEL_6:
		  m_Handle = v5.m_Handle;
		  v7 = (String *)"";
		  PathInternal = UnityEngine::SceneManagement::Scene::GetPathInternal(v5.m_Handle, 0LL);
		  if ( System::String::op_Inequality(PathInternal, (String *)"", 0LL) )
		  {
		    v9 = UnityEngine::SceneManagement::Scene::GetPathInternal(m_Handle, 0LL);
		    sub_1800036A0(TypeInfo::System::IO::Path);
		    DirectoryName = System::IO::Path::GetDirectoryName(v9, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
		    return HG::Rendering::Runtime::HGTerrainUtils::JoinPath(
		             DirectoryName,
		             (String *)"Terrain/HGTerrainConfiguration.asset",
		             0LL);
		  }
		  return v7;
		}
		
		public static string GetHGRenderPipelinePath() => default; // 0x0000000189C22340-0x0000000189C22390
		// String GetHGRenderPipelinePath()
		String *HG::Rendering::Runtime::HGTerrainUtils::GetHGRenderPipelinePath(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4040, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4040, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v4, v3);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1106(Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    return HG::Rendering::Runtime::HGUtils::GetHGRenderPipelinePath(0LL);
		  }
		}
		
		public static void MultidimensionalSpanFillBool(bool[,] array, bool value) {} // 0x0000000189C226D4-0x0000000189C2279C
		// Void MultidimensionalSpanFillBool(Boolean[,], Boolean)
		void HG::Rendering::Runtime::HGTerrainUtils::MultidimensionalSpanFillBool(
		        Boolean__Array_1 *array,
		        bool value,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  int Length; // esi
		  int v8; // eax
		  __int64 v9; // rdx
		  Il2CppArrayBounds *bounds; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Span_1_SByte_ v12; // [rsp+20h] [rbp-18h] BYREF
		
		  v12 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(4042, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4042, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)array, value, 0LL);
		      return;
		    }
		LABEL_8:
		    sub_1800D8260(v6, v5);
		  }
		  if ( !array )
		    goto LABEL_8;
		  Length = System::Array::GetLength((System::Array *)array, 0);
		  v8 = System::Array::GetLength((System::Array *)array, 1);
		  bounds = array->bounds;
		  if ( !LODWORD(bounds->length) || !LODWORD(bounds[1].length) )
		    sub_1800D2AB0(bounds, v9);
		  ((void (__fastcall *)(Span_1_SByte_ *, bool *, _QWORD, struct MethodInfo *))sub_189C1C45C)(
		    &v12,
		    array->vector,
		    (unsigned int)(Length * v8),
		    MethodInfo::System::Span<bool>::Span);
		  System::Span<signed char>::Fill(&v12, value, MethodInfo::System::Span<bool>::Fill);
		}
		
		public static float DegreeToRadian(float degree) => default; // 0x0000000189C21D94-0x0000000189C21DFC
		// Single DegreeToRadian(Single)
		float HG::Rendering::Runtime::HGTerrainUtils::DegreeToRadian(float degree, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3980, 0LL) )
		    return (float)(degree / 180.0) * 3.1415927;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3980, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v5, v4);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, degree, 0LL);
		}
		
		public static int PackLinearColor(UnityEngine.Color color) => default; // 0x0000000189C2279C-0x0000000189C22894
		// Int32 PackLinearColor(Color)
		int32_t HG::Rendering::Runtime::HGTerrainUtils::PackLinearColor(Color *color, MethodInfo *method)
		{
		  double v3; // xmm0_8
		  float v4; // xmm9_4
		  double v5; // xmm0_8
		  float v6; // xmm8_4
		  double v7; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Color v12; // [rsp+20h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4043, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4043, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    v12 = *color;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1426(Patch, &v12, 0LL);
		  }
		  else
		  {
		    v3 = ((double (*)(void))sub_1800316C0)();
		    v4 = *(float *)&v3;
		    v5 = ((double (*)(void))sub_1800316C0)();
		    v6 = *(float *)&v5;
		    v7 = ((double (*)(void))sub_1800316C0)();
		    return (unsigned __int8)(int)v4 | (((unsigned __int8)(int)v6 | ((((int)sub_1800316C0() << 8) | (unsigned __int8)(int)*(float *)&v7) << 8)) << 8);
		  }
		}
		
		public static Vector3 ScreenPointToRay(Transform transform, float fov, int x, int y, int screenX, int screenY) => default; // 0x0000000189C22D10-0x0000000189C22E88
		// Vector3 ScreenPointToRay(Transform, Single, Int32, Int32, Int32, Int32)
		Vector3 *HG::Rendering::Runtime::HGTerrainUtils::ScreenPointToRay(
		        Vector3 *__return_ptr retstr,
		        Transform *transform,
		        float fov,
		        int32_t x,
		        int32_t y,
		        int32_t screenX,
		        int32_t screenY,
		        MethodInfo *method)
		{
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // r8
		  __int64 v14; // r9
		  float v15; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v17; // rcx
		  Vector3 *v18; // rax
		  __int64 v19; // xmm0_8
		  float z; // eax
		  Vector3 v22; // [rsp+50h] [rbp-30h] BYREF
		  Vector3 v23; // [rsp+60h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3979, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3979, 0LL);
		    if ( Patch )
		    {
		      v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1401(
		              &v23,
		              Patch,
		              (Object *)transform,
		              fov,
		              x,
		              y,
		              screenX,
		              screenY,
		              0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v17, Patch);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
		  HG::Rendering::Runtime::HGTerrainUtils::DegreeToRadian(fov, 0LL);
		  v15 = sub_180338A80(v12, v11, v13, v14);
		  v22.z = 1.0;
		  v22.x = (float)((float)((float)((float)x + (float)x) - (float)screenX) * v15) / (float)screenY;
		  v22.y = (float)((float)((float)((float)y + (float)y) - (float)screenY) * (float)-v15) / (float)screenY;
		  sub_182F9FFD0(&v22);
		  if ( !transform )
		    goto LABEL_5;
		  v23 = v22;
		  v18 = UnityEngine::Transform::TransformVector(&v22, transform, &v23, 0LL);
		LABEL_7:
		  v19 = *(_QWORD *)&v18->x;
		  z = v18->z;
		  *(_QWORD *)&retstr->x = v19;
		  retstr->z = z;
		  return retstr;
		}
		
		public static string FromGuidToTextureFullPath(string rootPath, [IsReadOnly] in Guid guid) => default; // 0x0000000189C21E48-0x0000000189C21EE8
		// String FromGuidToTextureFullPath(String, Guid ByRef)
		String *HG::Rendering::Runtime::HGTerrainUtils::FromGuidToTextureFullPath(
		        String *rootPath,
		        Guid *guid,
		        MethodInfo *method)
		{
		  Object *v5; // rax
		  String *v6; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Guid v11; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4044, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4044, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1427(Patch, (Object *)rootPath, guid, 0LL);
		  }
		  else
		  {
		    v11 = *guid;
		    v5 = (Object *)il2cpp_value_box_0(TypeInfo::System::Guid, &v11);
		    v6 = System::String::Format((String *)"{0}.tga", v5, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
		    return HG::Rendering::Runtime::HGTerrainUtils::JoinPath(rootPath, v6, 0LL);
		  }
		}
		
		public static int GetTerrainDecalMaxLevel(int indirectMaxLevel) => default; // 0x0000000189C22478-0x0000000189C224CC
		// Int32 GetTerrainDecalMaxLevel(Int32)
		int32_t HG::Rendering::Runtime::HGTerrainUtils::GetTerrainDecalMaxLevel(int32_t indirectMaxLevel, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4045, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4045, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_64((ILFixDynamicMethodWrapper_18 *)Patch, indirectMaxLevel, 0LL);
		  }
		  else
		  {
		    if ( indirectMaxLevel >= 8 )
		      return 8;
		    return indirectMaxLevel;
		  }
		}
		
		public static bool SupportBufferToImageCopy() => default; // 0x0000000189C22E88-0x0000000189C22EE0
		// Boolean SupportBufferToImageCopy()
		bool HG::Rendering::Runtime::HGTerrainUtils::SupportBufferToImageCopy(MethodInfo *method)
		{
		  GraphicsDeviceType__Enum GraphicsDeviceType; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4046, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4046, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		  }
		  else
		  {
		    GraphicsDeviceType = UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL);
		    return GraphicsDeviceType == GraphicsDeviceType__Enum_Vulkan || GraphicsDeviceType == GraphicsDeviceType__Enum_Metal;
		  }
		}
		
		public static bool ForceUsingCompression() => default; // 0x0000000189C21DFC-0x0000000189C21E48
		// Boolean ForceUsingCompression()
		bool HG::Rendering::Runtime::HGTerrainUtils::ForceUsingCompression(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4047, 0LL) )
		    return UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_Metal;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4047, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		}
		
		public static bool SupportSSBOWriteInGraphicShader() => default; // 0x0000000189C22EE0-0x0000000189C22F48
		// Boolean SupportSSBOWriteInGraphicShader()
		bool HG::Rendering::Runtime::HGTerrainUtils::SupportSSBOWriteInGraphicShader(MethodInfo *method)
		{
		  GraphicsDeviceType__Enum GraphicsDeviceType; // eax
		  int v2; // ecx
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4048, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4048, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		  }
		  else
		  {
		    GraphicsDeviceType = UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL);
		    result = (unsigned int)GraphicsDeviceType <= GraphicsDeviceType__Enum_Vulkan
		          && (v2 = 2424836, _bittest(&v2, GraphicsDeviceType))
		          && UnityEngine::SystemInfo::SupportedRandomWriteTargetCount(0LL) > 0;
		  }
		  return result;
		}
		
		public static GraphicsFormat GetPlatformCompressionFormat() => default; // 0x0000000189C22390-0x0000000189C22478
		// GraphicsFormat GetPlatformCompressionFormat()
		GraphicsFormat__Enum HG::Rendering::Runtime::HGTerrainUtils::GetPlatformCompressionFormat(MethodInfo *method)
		{
		  RuntimePlatform__Enum platform; // eax
		  __int64 v2; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  InvalidEnumArgumentException *v5; // rbx
		  String *v6; // rax
		  __int64 v7; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3974, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3974, 0LL);
		    if ( !Patch )
		      goto LABEL_16;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    platform = UnityEngine::Application::get_platform(0LL);
		    if ( (unsigned int)platform >= RuntimePlatform__Enum_WindowsPlayer )
		    {
		      switch ( platform )
		      {
		        case RuntimePlatform__Enum_WindowsPlayer:
		          return 101;
		        case RuntimePlatform__Enum_OSXWebPlayer:
		        case RuntimePlatform__Enum_OSXDashboardPlayer:
		        case RuntimePlatform__Enum_WindowsWebPlayer:
		        case RuntimePlatform__Enum_OSXDashboardPlayer|RuntimePlatform__Enum_WindowsPlayer:
		          goto LABEL_11;
		        case RuntimePlatform__Enum_WindowsEditor:
		          return 101;
		      }
		      if ( platform != RuntimePlatform__Enum_IPhonePlayer && platform != RuntimePlatform__Enum_Android )
		      {
		LABEL_11:
		        v2 = sub_18007E180(&TypeInfo::System::ArgumentException);
		        v5 = (InvalidEnumArgumentException *)sub_18002C620(v2);
		        if ( v5 )
		        {
		          v6 = (String *)sub_18007E180(&off_18E27C678);
		          System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v5, v6, 0LL);
		          v7 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::HGTerrainUtils::GetPlatformCompressionFormat);
		          sub_18007E190(v5, v7);
		        }
		LABEL_16:
		        sub_1800D8260(v4, v3);
		      }
		    }
		    return 130;
		  }
		}
		
		public static Matrix4x4 PerspectiveOffCenter(float left, float right, float bottom, float top, float near, float far) => default; // 0x0000000189C22894-0x0000000189C22AD0
		// Matrix4x4 PerspectiveOffCenter(Single, Single, Single, Single, Single, Single)
		Matrix4x4 *HG::Rendering::Runtime::HGTerrainUtils::PerspectiveOffCenter(
		        Matrix4x4 *__return_ptr retstr,
		        float left,
		        float right,
		        float bottom,
		        float top,
		        float near_1,
		        float far_1,
		        MethodInfo *method)
		{
		  float v10; // xmm8_4
		  float v11; // xmm6_4
		  float v12; // xmm7_4
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  Matrix4x4 *v19; // rax
		  __int128 v20; // xmm1
		  Matrix4x4 *result; // rax
		  Matrix4x4 v22; // [rsp+58h] [rbp-79h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4017, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4017, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v18, v17);
		    v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1413(&v22, Patch, left, right, bottom, top, near_1, far_1, 0LL);
		    v20 = *(_OWORD *)&v19->m01;
		    *(_OWORD *)&retstr->m00 = *(_OWORD *)&v19->m00;
		    v14 = *(_OWORD *)&v19->m02;
		    *(_OWORD *)&retstr->m01 = v20;
		    v15 = *(_OWORD *)&v19->m03;
		  }
		  else
		  {
		    v10 = 1.0 / (float)(near_1 - far_1);
		    v11 = 1.0 / (float)(right - left);
		    v12 = 1.0 / (float)(top - bottom);
		    sub_18033B9D0(&v22, 0LL, 64LL);
		    UnityEngine::Matrix4x4::set_Item(&v22, 0, (float)(near_1 + near_1) * v11, 0LL);
		    UnityEngine::Matrix4x4::set_Item(&v22, 8, (float)(left + right) * v11, 0LL);
		    UnityEngine::Matrix4x4::set_Item(&v22, 5, (float)(near_1 + near_1) * v12, 0LL);
		    UnityEngine::Matrix4x4::set_Item(&v22, 9, (float)(bottom + top) * v12, 0LL);
		    UnityEngine::Matrix4x4::set_Item(&v22, 10, (float)(near_1 + far_1) * v10, 0LL);
		    UnityEngine::Matrix4x4::set_Item(&v22, 14, (float)((float)(near_1 + near_1) * far_1) * v10, 0LL);
		    UnityEngine::Matrix4x4::set_Item(&v22, 11, -1.0, 0LL);
		    v13 = *(_OWORD *)&v22.m01;
		    *(_OWORD *)&retstr->m00 = *(_OWORD *)&v22.m00;
		    v14 = *(_OWORD *)&v22.m02;
		    *(_OWORD *)&retstr->m01 = v13;
		    v15 = *(_OWORD *)&v22.m03;
		  }
		  result = retstr;
		  *(_OWORD *)&retstr->m02 = v14;
		  *(_OWORD *)&retstr->m03 = v15;
		  return result;
		}
		
		public static bool ShouldDisableContactShadow() => default; // 0x0000000183C94CB0-0x0000000183C94D90
		// Boolean ShouldDisableContactShadow()
		bool HG::Rendering::Runtime::HGTerrainUtils::ShouldDisableContactShadow(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  __int64 v3; // rdx
		  HGTerrainV2__StaticFields *static_fields; // rcx
		  _OWORD *v5; // rax
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  _BYTE v16[280]; // [rsp+20h] [rbp-118h] BYREF
		
		  v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_8;
		  if ( wrapperArray->max_length.size > 991 )
		  {
		    if ( !v1->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v1);
		      v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v1->static_fields->wrapperArray;
		    if ( wrapperArray )
		    {
		      if ( wrapperArray->max_length.size <= 0x3DFu )
		        sub_1800D2AB0(wrapperArray, v1);
		      if ( !wrapperArray[27].vector[19] )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(991, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		    }
		LABEL_8:
		    sub_1800D8260(wrapperArray, v1);
		  }
		LABEL_5:
		  v3 = 2LL;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGTerrainV2->static_fields;
		  v5 = v16;
		  do
		  {
		    v5 += 8;
		    v6 = *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._glintData._EnableFakeGlint;
		    v7 = *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._glintData._GlintScale;
		    static_fields = (HGTerrainV2__StaticFields *)((char *)static_fields + 128);
		    *(v5 - 8) = v6;
		    v8 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeRefractionHeightScale;
		    *(v5 - 7) = v7;
		    v9 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustDepth;
		    *(v5 - 6) = v8;
		    v10 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustFlowSpeed.w;
		    *(v5 - 5) = v9;
		    v11 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustTint.a;
		    *(v5 - 4) = v10;
		    v12 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._FakeVolumeMask;
		    *(v5 - 3) = v11;
		    v13 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeShadowData._FakeShadowStrength;
		    *(v5 - 2) = v12;
		    *(v5 - 1) = v13;
		    --v3;
		  }
		  while ( v3 );
		  *v5 = *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._glintData._EnableFakeGlint;
		  return v16[248];
		}
		
	
		// Extension methods
		[IDTag(0)]
		public static int Pow(this int bas, int exp) => default; // 0x0000000189C22AD0-0x0000000189C22BE8
		// Int32 Pow(Int32, Int32)
		int32_t HG::Rendering::Runtime::HGTerrainUtils::Pow(int32_t bas, int32_t exp, MethodInfo *method)
		{
		  IEnumerable_1_System_Int32_ *v5; // rsi
		  Func_3_Int32_Int32_Int32_ *_9__32_0; // rbx
		  Object *v7; // rdi
		  GenericDelegateCallerGen_uintuint_EnumDelegate_3_System_UInt32_System_UInt32_System_Int32Enum_ *v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3946, 0LL) )
		  {
		    v5 = System::Linq::Enumerable::Repeat<int>(bas, exp, MethodInfo::System::Linq::Enumerable::Repeat<int>);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c);
		    _9__32_0 = TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c->static_fields->__9__32_0;
		    if ( _9__32_0 )
		      return System::Linq::Enumerable::Aggregate<int,int>(
		               v5,
		               1,
		               _9__32_0,
		               MethodInfo::System::Linq::Enumerable::Aggregate<int,int>);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c);
		    v7 = (Object *)TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c->static_fields->__9;
		    v8 = (GenericDelegateCallerGen_uintuint_EnumDelegate_3_System_UInt32_System_UInt32_System_Int32Enum_ *)sub_18002C620(TypeInfo::System::Func<int,int,int>);
		    _9__32_0 = (Func_3_Int32_Int32_Int32_ *)v8;
		    if ( v8 )
		    {
		      Beyond::Reflection::GenericDelegateCallerGen::uintuint_EnumDelegate<unsigned int,unsigned int,System::Int32Enum>::uintuint_EnumDelegate(
		        v8,
		        v7,
		        MethodInfo::HG::Rendering::Runtime::HGTerrainUtils::__c::_Pow_b__32_0,
		        0LL);
		      TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c->static_fields->__9__32_0 = _9__32_0;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c->static_fields->__9__32_0,
		        v11,
		        v12,
		        v13,
		        v16);
		      return System::Linq::Enumerable::Aggregate<int,int>(
		               v5,
		               1,
		               _9__32_0,
		               MethodInfo::System::Linq::Enumerable::Aggregate<int,int>);
		    }
		LABEL_7:
		    sub_1800D8260(v10, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3946, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_50((ILFixDynamicMethodWrapper_15 *)Patch, bas, exp, 0LL);
		}
		
		[IDTag(1)]
		public static float Pow(this float bas, int exp) => default; // 0x0000000189C22BE8-0x0000000189C22D10
		// Single Pow(Single, Int32)
		float HG::Rendering::Runtime::HGTerrainUtils::Pow(float bas, int32_t exp, MethodInfo *method)
		{
		  IEnumerable_1_System_Single_ *v4; // rsi
		  Func_3_Single_Single_Single_ *_9__33_0; // rbx
		  Object *v6; // rdi
		  Func_3_Single_Single_Single_ *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v15; // [rsp+20h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4041, 0LL) )
		  {
		    v4 = System::Linq::Enumerable::Repeat<float>(bas, exp, MethodInfo::System::Linq::Enumerable::Repeat<float>);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c);
		    _9__33_0 = TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c->static_fields->__9__33_0;
		    if ( _9__33_0 )
		      return System::Linq::Enumerable::Aggregate<float,float>(
		               v4,
		               1.0,
		               _9__33_0,
		               MethodInfo::System::Linq::Enumerable::Aggregate<float,float>);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c);
		    v6 = (Object *)TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c->static_fields->__9;
		    v7 = (Func_3_Single_Single_Single_ *)sub_18002C620(TypeInfo::System::Func<float,float,float>);
		    _9__33_0 = v7;
		    if ( v7 )
		    {
		      System::Func<float,float,float>::Func(
		        v7,
		        v6,
		        MethodInfo::HG::Rendering::Runtime::HGTerrainUtils::__c::_Pow_b__33_0,
		        0LL);
		      TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c->static_fields->__9__33_0 = _9__33_0;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c->static_fields->__9__33_0,
		        v10,
		        v11,
		        v12,
		        v15);
		      return System::Linq::Enumerable::Aggregate<float,float>(
		               v4,
		               1.0,
		               _9__33_0,
		               MethodInfo::System::Linq::Enumerable::Aggregate<float,float>);
		    }
		LABEL_7:
		    sub_1800D8260(v9, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4041, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1425(Patch, bas, exp, 0LL);
		}
		
		public static void RemoveComponentTerrainUtils<T>(this GameObject obj)
			where T : Component {}
	}
}
