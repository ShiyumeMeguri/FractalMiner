using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HG.Rendering.Runtime
{
	internal class SceneObjectIDMap
	{
		public SceneObjectIDMap()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		public static bool TryGetSceneObjectID<TCategory>(GameObject gameObject, out int index, out TCategory category) where TCategory : struct, IConvertible
		{
			return default(bool);
		}

		public static int GetOrCreateSceneObjectID<TCategory>(GameObject gameObject, TCategory category) where TCategory : struct, IConvertible
		{
			return 0;
		}

		public static void GetAllIDsForAllScenes<TCategory>(TCategory category, List<GameObject> outGameObjects, List<int> outIndices, List<Scene> outScenes) where TCategory : struct, IConvertible
		{
		}

		public static void GetAllIDsFor<TCategory>(TCategory category, Scene scene, List<GameObject> outGameObjects, List<int> outIndices) where TCategory : struct, IConvertible
		{
		}

		private static bool TryGetSceneIDMapFor(Scene scene, out SceneObjectIDMapSceneAsset map)
		{
			return default(bool);
		}

		private static SceneObjectIDMapSceneAsset CreateSceneIDMapFor(Scene scene)
		{
			// // SceneObjectIDMapSceneAsset CreateSceneIDMapFor(Scene)
			// SceneObjectIDMapSceneAsset *HG::Rendering::Runtime::SceneObjectIDMap::CreateSceneIDMapFor(
			//         Scene scene,
			//         MethodInfo *method)
			// {
			//   GameObject *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Object_1 *v6; // rsi
			//   Object *v7; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91976C )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset>);
			//     sub_18003C530(&TypeInfo::UnityEngine::GameObject);
			//     sub_18003C530(&TypeInfo::UnityEngine::SceneManagement::SceneManager);
			//     sub_18003C530(&off_18D520640);
			//     byte_18D91976C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3529, 0LL) )
			//   {
			//     v3 = (GameObject *)sub_180004920(TypeInfo::UnityEngine::GameObject);
			//     v6 = (Object_1 *)v3;
			//     if ( v3 )
			//     {
			//       UnityEngine::GameObject::GameObject(v3, (String *)"SceneIDMap", 0LL);
			//       UnityEngine::Object::set_hideFlags(
			//         v6,
			//         HideFlags__Enum_DontSaveInBuild|HideFlags__Enum_HideInInspector|HideFlags__Enum_HideInHierarchy,
			//         0LL);
			//       v7 = UnityEngine::GameObject::AddComponent<System::Object>(
			//              (GameObject *)v6,
			//              MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset>);
			//       sub_180002C70(TypeInfo::UnityEngine::SceneManagement::SceneManager);
			//       UnityEngine::SceneManagement::SceneManager::MoveGameObjectToScene((GameObject *)v6, scene, 0LL);
			//       return (SceneObjectIDMapSceneAsset *)v7;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3529, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1254(Patch, scene, 0LL);
			// }
			// 
			return null;
		}

		private static bool TryGetOrCreateSceneIDMapFor(Scene scene, out SceneObjectIDMapSceneAsset map)
		{
			return default(bool);
		}
	}
}
