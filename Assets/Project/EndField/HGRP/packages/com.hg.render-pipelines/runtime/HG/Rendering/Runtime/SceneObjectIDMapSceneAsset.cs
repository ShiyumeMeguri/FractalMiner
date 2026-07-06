using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	internal class SceneObjectIDMapSceneAsset : MonoBehaviour, ISerializationCallbackReceiver
	{
		public SceneObjectIDMapSceneAsset()
		{
		}

		public void GetALLIDsFor<TCategory>(TCategory category, List<GameObject> outGameObjects, List<int> outIndices) where TCategory : struct, IConvertible
		{
		}

		internal bool TryGetSceneIDFor<TCategory>(GameObject gameObject, out int index, out TCategory category) where TCategory : struct, IConvertible
		{
			return default(bool);
		}

		internal bool TryInsert<TCategory>(GameObject gameObject, TCategory category, out int index) where TCategory : struct, IConvertible
		{
			return default(bool);
		}

		private int Insert<TCategory>(GameObject gameObject, TCategory category) where TCategory : struct, IConvertible
		{
			return 0;
		}

		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			// // Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
			// void HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize(
			//         SceneObjectIDMapSceneAsset *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3531, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3531, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::BuildIndex(this, 0LL);
			//   }
			// }
			// 
		}

		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
			// // Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
			// void HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize(
			//         SceneObjectIDMapSceneAsset *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3533, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3533, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::CleanDestroyedGameObjects(this, 0LL);
			//   }
			// }
			// 
		}

		private void CleanDestroyedGameObjects()
		{
			// // Void CleanDestroyedGameObjects()
			// void HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::CleanDestroyedGameObjects(
			//         SceneObjectIDMapSceneAsset *this,
			//         MethodInfo *method)
			// {
			//   List_1_HG_Rendering_Runtime_SceneObjectIDMapSceneAsset_Entry_ *v3; // rdx
			//   List_1_HG_Rendering_Runtime_SceneObjectIDMapSceneAsset_Entry_ *v4; // rcx
			//   List_1_HG_Rendering_Runtime_SceneObjectIDMapSceneAsset_Entry_ *m_Entries; // rdi
			//   char v6; // si
			//   int32_t v7; // edi
			//   __m128i v8; // xmm6
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __m128i v10; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91976D )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::Entry>::RemoveAt);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::Entry>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::Entry>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D91976D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3534, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3534, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_14:
			//     sub_180B536AC(v4, v3);
			//   }
			//   m_Entries = this.fields.m_Entries;
			//   v6 = 0;
			//   if ( !m_Entries )
			//     goto LABEL_14;
			//   v7 = m_Entries.fields._size - 1;
			//   if ( v7 >= 0 )
			//   {
			//     do
			//     {
			//       v3 = this.fields.m_Entries;
			//       if ( !v3 )
			//         goto LABEL_14;
			//       System::Collections::Generic::List<Beyond::SparkBuffer::Serialize::ObjectReflector_ReflectType::FieldInfo>::get_Item(
			//         (ObjectReflector_ReflectType_FieldInfo *)&v10,
			//         (List_1_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *)v3,
			//         v7,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::Entry>::get_Item);
			//       v8 = v10;
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Equality((Object_1 *)_mm_srli_si128(v8, 8).m128i_i64[0], 0LL, 0LL) )
			//       {
			//         v4 = this.fields.m_Entries;
			//         if ( !v4 )
			//           goto LABEL_14;
			//         System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::PUUjROsMtnhbqLEaBbcdiryfdlYVA>::RemoveAt(
			//           (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_PUUjROsMtnhbqLEaBbcdiryfdlYVA_ *)v4,
			//           v7,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::Entry>::RemoveAt);
			//         v6 = 1;
			//       }
			//       --v7;
			//     }
			//     while ( v7 >= 0 );
			//     if ( v6 )
			//       HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::BuildIndex(this, 0LL);
			//   }
			// }
			// 
		}

		private void BuildIndex()
		{
			// // Void BuildIndex()
			// void HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::BuildIndex(
			//         SceneObjectIDMapSceneAsset *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Dictionary_2_UnityEngine_GameObject_System_Int32_ *m_IndexByGameObject; // rcx
			//   int32_t i; // edi
			//   List_1_HG_Rendering_Runtime_SceneObjectIDMapSceneAsset_Entry_ *m_Entries; // rax
			//   Dictionary_2_UnityEngine_GameObject_System_Int32_ *v7; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ObjectReflector_ReflectType_FieldInfo v9; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D91976E )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::GameObject,int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::GameObject,int>::set_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::Entry>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::Entry>::get_Item);
			//     byte_18D91976E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3532, 0LL) )
			//   {
			//     m_IndexByGameObject = this.fields.m_IndexByGameObject;
			//     if ( m_IndexByGameObject )
			//     {
			//       System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Clear(
			//         (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)m_IndexByGameObject,
			//         MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::GameObject,int>::Clear);
			//       for ( i = 0; ; ++i )
			//       {
			//         m_Entries = this.fields.m_Entries;
			//         if ( !m_Entries )
			//           break;
			//         if ( i >= m_Entries.fields._size )
			//           return;
			//         v7 = this.fields.m_IndexByGameObject;
			//         System::Collections::Generic::List<Beyond::SparkBuffer::Serialize::ObjectReflector_ReflectType::FieldInfo>::get_Item(
			//           &v9,
			//           (List_1_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *)this.fields.m_Entries,
			//           i,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::Entry>::get_Item);
			//         if ( !v7 )
			//           break;
			//         System::Collections::Generic::Dictionary<System::Object,int>::set_Item(
			//           (Dictionary_2_System_Object_System_Int32_ *)v7,
			//           (Object *)v9.type,
			//           i,
			//           MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::GameObject,int>::set_Item);
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(m_IndexByGameObject, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3532, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		internal const string k_GameObjectName = "SceneIDMap";

		[SerializeField]
		private List<SceneObjectIDMapSceneAsset.Entry> m_Entries;

		private Dictionary<GameObject, int> m_IndexByGameObject;

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct Entry
		{
			public int id;

			public int category;

			public GameObject gameObject;
		}
	}
}
