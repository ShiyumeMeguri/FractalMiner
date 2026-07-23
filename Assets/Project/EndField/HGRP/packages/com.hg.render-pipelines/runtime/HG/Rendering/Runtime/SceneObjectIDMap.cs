using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class SceneObjectIDMap // TypeDefIndex: 38699
	{
		// Constructors
		public SceneObjectIDMap() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
	
		// Methods
		public static bool TryGetSceneObjectID<TCategory>(GameObject gameObject, out int index, out ref TCategory category)
			where TCategory : struct, IConvertible {
			index = default;
			category = default;
			return default;
		}
		public static int GetOrCreateSceneObjectID<TCategory>(GameObject gameObject, TCategory category)
			where TCategory : struct, IConvertible => default;
		public static void GetAllIDsForAllScenes<TCategory>(TCategory category, List<GameObject> outGameObjects, List<int> outIndices, List<Scene> outScenes)
			where TCategory : struct, IConvertible {}
		public static void GetAllIDsFor<TCategory>(TCategory category, Scene scene, List<GameObject> outGameObjects, List<int> outIndices)
			where TCategory : struct, IConvertible {}
		private static bool TryGetSceneIDMapFor(Scene scene, out SceneObjectIDMapSceneAsset map) {
			map = default;
			return default;
		} // 0x0000000189C464E4-0x0000000189C46638
		// Boolean TryGetSceneIDMapFor(Scene, SceneObjectIDMapSceneAsset ByRef)
		bool HG::Rendering::Runtime::SceneObjectIDMap::TryGetSceneIDMapFor(
		        Scene scene,
		        SceneObjectIDMapSceneAsset **map,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  Object_1 *v8; // rcx
		  GameObject__Array *RootGameObjects; // rbp
		  unsigned int v10; // edi
		  String *name; // rax
		  Object *v12; // rax
		  Object_1 *v13; // rbx
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v19; // [rsp+20h] [rbp-8h]
		  Scene v20; // [rsp+30h] [rbp+8h] BYREF
		
		  v20.m_Handle = scene.m_Handle;
		  if ( !IFix::WrappersManagerImpl::IsPatched(4181, 0LL) )
		  {
		    if ( !UnityEngine::SceneManagement::Scene::GetIsLoadedInternal(scene.m_Handle, 0LL) )
		    {
		LABEL_16:
		      *map = 0LL;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)map, v5, v6, v7, v19);
		      return 0;
		    }
		    RootGameObjects = UnityEngine::SceneManagement::Scene::GetRootGameObjects(&v20, 0LL);
		    v10 = 0;
		    if ( RootGameObjects )
		    {
		      while ( (signed int)v10 < RootGameObjects->max_length.size )
		      {
		        if ( v10 >= RootGameObjects->max_length.size )
		          goto LABEL_15;
		        v8 = (Object_1 *)RootGameObjects->vector[v10];
		        if ( !v8 )
		          goto LABEL_18;
		        name = UnityEngine::Object::get_name(v8, 0LL);
		        if ( System::String::Equals(name, (String *)"SceneIDMap", 0LL) )
		        {
		          if ( v10 >= RootGameObjects->max_length.size )
		LABEL_15:
		            sub_1800D2AB0(v8, v5);
		          v8 = (Object_1 *)RootGameObjects->vector[v10];
		          if ( !v8 )
		            goto LABEL_18;
		          v12 = UnityEngine::GameObject::GetComponent<System::Object>(
		                  (GameObject *)v8,
		                  MethodInfo::UnityEngine::GameObject::GetComponent<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset>);
		          *map = (SceneObjectIDMapSceneAsset *)v12;
		          v13 = (Object_1 *)v12;
		          sub_18002D1B0((HGRuntimeGrassQuery_Node *)map, v14, v15, v16, v19);
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Inequality(v13, 0LL, 0LL) )
		          {
		            v5 = (HGRuntimeGrassQuery_Node *)*map;
		            if ( !*map )
		              goto LABEL_18;
		            if ( !(unsigned __int8)sub_180034AC0(0LL, v5, 0LL) )
		              return 1;
		          }
		        }
		        ++v10;
		      }
		      goto LABEL_16;
		    }
		LABEL_18:
		    sub_1800D8260(v8, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4181, 0LL);
		  if ( !Patch )
		    goto LABEL_18;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1465(Patch, scene, map, 0LL);
		}
		
		private static SceneObjectIDMapSceneAsset CreateSceneIDMapFor(Scene scene) => default; // 0x0000000189C46390-0x0000000189C4644C
		// SceneObjectIDMapSceneAsset CreateSceneIDMapFor(Scene)
		SceneObjectIDMapSceneAsset *HG::Rendering::Runtime::SceneObjectIDMap::CreateSceneIDMapFor(
		        Scene scene,
		        MethodInfo *method)
		{
		  GameObject *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Object_1 *v6; // rsi
		  Object *v7; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4182, 0LL) )
		  {
		    v3 = (GameObject *)sub_18002C620(TypeInfo::UnityEngine::GameObject);
		    v6 = (Object_1 *)v3;
		    if ( v3 )
		    {
		      UnityEngine::GameObject::GameObject(v3, (String *)"SceneIDMap", 0LL);
		      UnityEngine::Object::set_hideFlags(
		        v6,
		        HideFlags__Enum_DontSaveInBuild|HideFlags__Enum_HideInInspector|HideFlags__Enum_HideInHierarchy,
		        0LL);
		      v7 = UnityEngine::GameObject::AddComponent<System::Object>(
		             (GameObject *)v6,
		             MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset>);
		      sub_1800036A0(TypeInfo::UnityEngine::SceneManagement::SceneManager);
		      UnityEngine::SceneManagement::SceneManager::MoveGameObjectToScene((GameObject *)v6, scene, 0LL);
		      return (SceneObjectIDMapSceneAsset *)v7;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4182, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1466(Patch, scene, 0LL);
		}
		
		private static bool TryGetOrCreateSceneIDMapFor(Scene scene, out SceneObjectIDMapSceneAsset map) {
			map = default;
			return default;
		} // 0x0000000189C4644C-0x0000000189C464E4
		// Boolean TryGetOrCreateSceneIDMapFor(Scene, SceneObjectIDMapSceneAsset ByRef)
		bool HG::Rendering::Runtime::SceneObjectIDMap::TryGetOrCreateSceneIDMapFor(
		        Scene scene,
		        SceneObjectIDMapSceneAsset **map,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4183, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4183, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1465(Patch, scene, map, 0LL);
		  }
		  else if ( UnityEngine::SceneManagement::Scene::GetIsLoadedInternal(scene.m_Handle, 0LL) )
		  {
		    if ( !HG::Rendering::Runtime::SceneObjectIDMap::TryGetSceneIDMapFor(scene, map, 0LL) )
		    {
		      *map = HG::Rendering::Runtime::SceneObjectIDMap::CreateSceneIDMapFor(scene, 0LL);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)map, v8, v9, v10, v15);
		    }
		    return 1;
		  }
		  else
		  {
		    *map = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)map, v5, v6, v7, v15);
		    return 0;
		  }
		}
		
	}
}
