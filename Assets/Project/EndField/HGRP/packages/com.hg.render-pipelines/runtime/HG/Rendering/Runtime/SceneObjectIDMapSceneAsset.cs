using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class SceneObjectIDMapSceneAsset : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 38701
	{
		// Fields
		internal const string k_GameObjectName = "SceneIDMap"; // Metadata: 0x023040A3
		[SerializeField]
		private List<Entry> m_Entries; // 0x18
		private Dictionary<GameObject, int> m_IndexByGameObject; // 0x20
	
		// Nested types
		[Serializable]
		private struct Entry // TypeDefIndex: 38700
		{
			// Fields
			public int id; // 0x00
			public int category; // 0x04
			public GameObject gameObject; // 0x08
		}
	
		// Constructors
		public SceneObjectIDMapSceneAsset() {} // 0x0000000189C46308-0x0000000189C46390
		// SceneObjectIDMapSceneAsset()
		void HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::SceneObjectIDMapSceneAsset(
		        SceneObjectIDMapSceneAsset *this,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_HG_Rendering_Runtime_SceneObjectIDMapSceneAsset_Entry_ *v6; // rdi
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *v10; // rax
		  Dictionary_2_UnityEngine_GameObject_System_Int32_ *v11; // rdi
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		
		  v3 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::Entry>);
		  v6 = (List_1_HG_Rendering_Runtime_SceneObjectIDMapSceneAsset_Entry_ *)v3;
		  if ( !v3
		    || (System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		          v3,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::Entry>::List),
		        this->fields.m_Entries = v6,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_Entries, v7, v8, v9, v15),
		        v10 = (Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::GameObject,int>),
		        (v11 = (Dictionary_2_UnityEngine_GameObject_System_Int32_ *)v10) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::Dictionary<System::Object,Beyond::Gameplay::ShopSystem::UnlockInfo>::Dictionary(
		    v10,
		    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::GameObject,int>::Dictionary);
		  this->fields.m_IndexByGameObject = v11;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_IndexByGameObject, v12, v13, v14, v16);
		  RootMotion::Singleton<System::Object>::Singleton((Singleton_1_System_Object__1 *)this, 0LL);
		}
		
	
		// Methods
		public void GetALLIDsFor<TCategory>(TCategory category, List<GameObject> outGameObjects, List<int> outIndices)
			where TCategory : struct, IConvertible {}
		internal bool TryGetSceneIDFor<TCategory>(GameObject gameObject, out int index, out ref TCategory category)
			where TCategory : struct, IConvertible {
			index = default;
			category = default;
			return default;
		}
		internal bool TryInsert<TCategory>(GameObject gameObject, TCategory category, out int index)
			where TCategory : struct, IConvertible {
			index = default;
			return default;
		}
		private int Insert<TCategory>(GameObject gameObject, TCategory category)
			where TCategory : struct, IConvertible => default;
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000189C46268-0x0000000189C462B8
		// Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		void HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize(
		        SceneObjectIDMapSceneAsset *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4184, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4184, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::BuildIndex(this, 0LL);
		  }
		}
		
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000189C462B8-0x0000000189C46308
		// Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		void HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize(
		        SceneObjectIDMapSceneAsset *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4186, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4186, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::CleanDestroyedGameObjects(this, 0LL);
		  }
		}
		
		private void CleanDestroyedGameObjects() {} // 0x0000000189C46170-0x0000000189C46268
		// Void CleanDestroyedGameObjects()
		void HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::CleanDestroyedGameObjects(
		        SceneObjectIDMapSceneAsset *this,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *v3; // rdx
		  List_1_HG_Rendering_Runtime_SceneObjectIDMapSceneAsset_Entry_ *v4; // rcx
		  List_1_HG_Rendering_Runtime_SceneObjectIDMapSceneAsset_Entry_ *m_Entries; // rbx
		  char v6; // si
		  int32_t v7; // ebx
		  __m128i v8; // xmm6
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __m128i v10; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4187, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4187, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_12:
		    sub_1800D8260(v4, v3);
		  }
		  m_Entries = this->fields.m_Entries;
		  v6 = 0;
		  if ( !m_Entries )
		    goto LABEL_12;
		  v7 = m_Entries->fields._size - 1;
		  if ( v7 >= 0 )
		  {
		    do
		    {
		      v3 = (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)this->fields.m_Entries;
		      if ( !v3 )
		        goto LABEL_12;
		      System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::get_Item(
		        (RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry *)&v10,
		        v3,
		        v7,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::Entry>::get_Item);
		      v8 = v10;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Equality((Object_1 *)_mm_srli_si128(v8, 8).m128i_i64[0], 0LL, 0LL) )
		      {
		        v4 = this->fields.m_Entries;
		        if ( !v4 )
		          goto LABEL_12;
		        System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::PUUjROsMtnhbqLEaBbcdiryfdlYVA>::RemoveAt(
		          (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_PUUjROsMtnhbqLEaBbcdiryfdlYVA_ *)v4,
		          v7,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::Entry>::RemoveAt);
		        v6 = 1;
		      }
		      --v7;
		    }
		    while ( v7 >= 0 );
		    if ( v6 )
		      HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::BuildIndex(this, 0LL);
		  }
		}
		
		private void BuildIndex() {} // 0x0000000189C460B8-0x0000000189C46170
		// Void BuildIndex()
		void HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::BuildIndex(
		        SceneObjectIDMapSceneAsset *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Dictionary_2_UnityEngine_GameObject_System_Int32_ *m_IndexByGameObject; // rcx
		  int32_t i; // edi
		  List_1_HG_Rendering_Runtime_SceneObjectIDMapSceneAsset_Entry_ *m_Entries; // rax
		  Dictionary_2_UnityEngine_GameObject_System_Int32_ *v7; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry v9; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4185, 0LL) )
		  {
		    m_IndexByGameObject = this->fields.m_IndexByGameObject;
		    if ( m_IndexByGameObject )
		    {
		      System::Collections::Generic::Dictionary<System::Object,int>::Clear(
		        (Dictionary_2_System_Object_System_Int32_ *)m_IndexByGameObject,
		        MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::GameObject,int>::Clear);
		      for ( i = 0; ; ++i )
		      {
		        m_Entries = this->fields.m_Entries;
		        if ( !m_Entries )
		          break;
		        if ( i >= m_Entries->fields._size )
		          return;
		        v7 = this->fields.m_IndexByGameObject;
		        System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::get_Item(
		          &v9,
		          (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)this->fields.m_Entries,
		          i,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SceneObjectIDMapSceneAsset::Entry>::get_Item);
		        if ( !v7 )
		          break;
		        System::Collections::Generic::Dictionary<System::Object,int>::set_Item(
		          (Dictionary_2_System_Object_System_Int32_ *)v7,
		          *(Object **)&v9.freeBusCount,
		          i,
		          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::GameObject,int>::set_Item);
		      }
		    }
		LABEL_9:
		    sub_1800D8260(m_IndexByGameObject, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4185, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
