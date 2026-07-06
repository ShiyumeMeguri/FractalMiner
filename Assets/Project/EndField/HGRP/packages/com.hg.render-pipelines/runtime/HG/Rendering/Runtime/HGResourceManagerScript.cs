using System;
using Beyond;
using Beyond.Resource;
using Unity.Profiling;
using UnityEngine.HyperGryph;

namespace HG.Rendering.Runtime
{
	public class HGResourceManagerScript
	{
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00002608 File Offset: 0x00000808
		public int loadingAssetCount
		{
			get
			{
				// // Int32 get_loadingAssetCount()
				// int32_t HG::Rendering::Runtime::HGResourceManagerScript::get_loadingAssetCount(
				//         HGResourceManagerScript *this,
				//         MethodInfo *method)
				// {
				//   IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *m_loadingAssetHandleIndexSet; // rcx
				// 
				//   if ( !byte_18D9193EA )
				//   {
				//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count);
				//     byte_18D9193EA = 1;
				//   }
				//   m_loadingAssetHandleIndexSet = this.fields.m_loadingAssetHandleIndexSet;
				//   if ( !m_loadingAssetHandleIndexSet )
				//     sub_180B536AC(0LL, method);
				//   return Beyond::UniqueList<System::Object>::get_length(
				//            (UniqueList_1_System_Object_ *)m_loadingAssetHandleIndexSet,
				//            MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count);
				// }
				// 
				return 0;
			}
		}

		public HGResourceManagerScript()
		{
			// // HGResourceManagerScript()
			// void HG::Rendering::Runtime::HGResourceManagerScript::HGResourceManagerScript(
			//         HGResourceManagerScript *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct HGResourceManager__Class *v4; // rax
			//   Delegate *getFileHashMappingCallback; // rsi
			//   HGResourceManager_GetFileHashMappingCallback *v6; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Delegate *v9; // rdi
			//   HGResourceManager_GetFileHashMappingCallback *v10; // rax
			//   HGCamera *v11; // r9
			//   HGRenderPathBase_HGRenderPathResources *v12; // rdx
			//   Delegate *getFilePathMappingCallback; // rsi
			//   HGResourceManager_GetFilePathMappingCallback *v14; // rax
			//   Delegate *v15; // rdi
			//   HGResourceManager_GetFilePathMappingCallback *v16; // rax
			//   HGCamera *v17; // r9
			//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
			//   Delegate *getWaterSectorTextureCallback; // rsi
			//   HGResourceManager_GetTextureFromHGWaterSectorDataCallback *v20; // rax
			//   Delegate *v21; // rdi
			//   HGResourceManager_GetTextureFromHGWaterSectorDataCallback *v22; // rax
			//   PassConstructorID__Enum__Array *v23; // r8
			//   HGCamera *v24; // r9
			//   HGRenderPathBase_HGRenderPathResources *v25; // rdx
			//   __int64 v26; // r8
			//   __int64 v27; // r9
			//   HGRenderPathBase_HGRenderPathResources *v28; // rdx
			//   PassConstructorID__Enum__Array *v29; // r8
			//   HGCamera *v30; // r9
			//   __int64 v31; // r8
			//   __int64 v32; // r9
			//   HGRenderPathBase_HGRenderPathResources *v33; // rdx
			//   PassConstructorID__Enum__Array *v34; // r8
			//   HGCamera *v35; // r9
			//   IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v36; // rax
			//   IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v37; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v38; // rdx
			//   PassConstructorID__Enum__Array *v39; // r8
			//   HGCamera *v40; // r9
			//   MethodInfo *methoda; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methodc; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methodd; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methode; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v46; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v47; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v48; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v49; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v50; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v51; // [rsp+60h] [rbp+28h]
			//   MethodInfo *v52; // [rsp+68h] [rbp+30h]
			// 
			//   if ( !byte_18D8ED962 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::AssetIdentifier);
			//     sub_18003C530(&TypeInfo::Beyond::Resource::FAssetProxyHandle);
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback);
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback);
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback);
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::HGResourceManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGWaterSectorData::GetWaterSectorTextureFromScriptableObject);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::IndexedHashSet);
			//     sub_18003C530(&TypeInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>);
			//     sub_18003C530(&MethodInfo::Unity::Profiling::ProfilerMarker<int>::ProfilerMarker);
			//     sub_18003C530(MethodInfo::Beyond::VFS::VirtualFileSystem::TryGetFilePathMappingCallback);
			//     sub_18003C530(MethodInfo::Beyond::VFS::VirtualFileSystem::TryGetFilePathMappingCallback);
			//     sub_18003C530(&off_18C9A6FA8);
			//     sub_18003C530(&off_18C8E2528);
			//     sub_18003C530(&off_18C8E2598);
			//     sub_18003C530(&off_18C8E25A8);
			//     sub_18003C530(&off_18C8E25B8);
			//     byte_18D8ED962 = 1;
			//   }
			//   this.fields.RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER = 0;
			//   this.fields.RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER_LOAD_ASYNC.m_Ptr = Unity::Profiling::LowLevel::Unsafe::ProfilerUnsafeUtility::CreateMarker(
			//                                                                           (String *)"HGResourceManagerScript.ResourceManager.LoadAsync.",
			//                                                                           1u,
			//                                                                           MarkerFlags__Enum_Default,
			//                                                                           0,
			//                                                                           0LL);
			//   this.fields.RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER_UpdateAssetHandle.m_Ptr = Unity::Profiling::LowLevel::Unsafe::ProfilerUnsafeUtility::CreateMarker(
			//                                                                                  (String *)"HGResourceManagerScript.Resou"
			//                                                                                            "rceManager.UpdateAssetHandle",
			//                                                                                  1u,
			//                                                                                  MarkerFlags__Enum_Default,
			//                                                                                  0,
			//                                                                                  0LL);
			//   this.fields.RESOURCE_MANAGER_SCRIPT_UPDATE_ASSET_INDEXSET = 0;
			//   v4 = TypeInfo::UnityEngine::HyperGryph::HGResourceManager;
			//   if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::HGResourceManager, v3);
			//     v4 = TypeInfo::UnityEngine::HyperGryph::HGResourceManager;
			//   }
			//   getFileHashMappingCallback = (Delegate *)v4.static_fields.getFileHashMappingCallback;
			//   v6 = (HGResourceManager_GetFileHashMappingCallback *)sub_180004920(TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback);
			//   v9 = (Delegate *)v6;
			//   if ( !v6 )
			//     goto LABEL_6;
			//   UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback::GetFileHashMappingCallback(
			//     v6,
			//     0LL,
			//     MethodInfo::Beyond::VFS::VirtualFileSystem::TryGetFilePathMappingCallback[0],
			//     0LL);
			//   v10 = (HGResourceManager_GetFileHashMappingCallback *)System::Delegate::Combine(getFileHashMappingCallback, v9, 0LL);
			//   v12 = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback;
			//   if ( v10 )
			//   {
			//     if ( v10.klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback )
			//       sub_1802DC21C(v10, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback);
			//     TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getFileHashMappingCallback = v10;
			//     v12 = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback;
			//     if ( v10.klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback )
			//       sub_1802DC21C(v10, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback);
			//   }
			//   else
			//   {
			//     TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getFileHashMappingCallback = 0LL;
			//   }
			//   sub_1800054D0(
			//     (HGRenderPathScene *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields,
			//     v12,
			//     (PassConstructorID__Enum__Array *)v10,
			//     v11,
			//     methoda,
			//     v46);
			//   getFilePathMappingCallback = (Delegate *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getFilePathMappingCallback;
			//   v14 = (HGResourceManager_GetFilePathMappingCallback *)sub_180004920(TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback);
			//   v15 = (Delegate *)v14;
			//   if ( !v14 )
			//     goto LABEL_6;
			//   UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback::GetFilePathMappingCallback(
			//     v14,
			//     0LL,
			//     MethodInfo::Beyond::VFS::VirtualFileSystem::TryGetFilePathMappingCallback[0],
			//     0LL);
			//   v16 = (HGResourceManager_GetFilePathMappingCallback *)System::Delegate::Combine(getFilePathMappingCallback, v15, 0LL);
			//   v18 = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback;
			//   if ( v16 )
			//   {
			//     if ( v16.klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback )
			//       sub_1802DC21C(v16, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback);
			//     TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getFilePathMappingCallback = v16;
			//     v18 = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback;
			//     if ( v16.klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback )
			//       sub_1802DC21C(v16, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback);
			//   }
			//   else
			//   {
			//     TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getFilePathMappingCallback = 0LL;
			//   }
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getFilePathMappingCallback,
			//     v18,
			//     (PassConstructorID__Enum__Array *)v16,
			//     v17,
			//     methodb,
			//     v47);
			//   getWaterSectorTextureCallback = (Delegate *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getWaterSectorTextureCallback;
			//   v20 = (HGResourceManager_GetTextureFromHGWaterSectorDataCallback *)sub_180004920(TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback);
			//   v21 = (Delegate *)v20;
			//   if ( !v20 )
			//     goto LABEL_6;
			//   UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback::GetTextureFromHGWaterSectorDataCallback(
			//     v20,
			//     0LL,
			//     MethodInfo::HG::Rendering::Runtime::HGWaterSectorData::GetWaterSectorTextureFromScriptableObject,
			//     0LL);
			//   v22 = (HGResourceManager_GetTextureFromHGWaterSectorDataCallback *)System::Delegate::Combine(
			//                                                                        getWaterSectorTextureCallback,
			//                                                                        v21,
			//                                                                        0LL);
			//   v25 = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback;
			//   if ( v22 )
			//   {
			//     if ( v22.klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback )
			//       sub_1802DC21C(v22, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback);
			//     TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getWaterSectorTextureCallback = v22;
			//     v25 = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback;
			//     if ( v22.klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback )
			//       sub_1802DC21C(v22, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback);
			//   }
			//   else
			//   {
			//     TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getWaterSectorTextureCallback = 0LL;
			//   }
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getWaterSectorTextureCallback,
			//     v25,
			//     v23,
			//     v24,
			//     methodc,
			//     v48);
			//   UnityEngine::HyperGryph::HGResourceManager::Reset(0LL);
			//   this.fields.m_assetHandles = (FAssetProxyHandle__Array *)il2cpp_array_new_specific_0(
			//                                                               TypeInfo::Beyond::Resource::FAssetProxyHandle,
			//                                                               1024LL,
			//                                                               v26,
			//                                                               v27);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields, v28, v29, v30, methodd, v49);
			//   this.fields.m_assetHandleCount = 0;
			//   this.fields.m_assetIdentifiers = (AssetIdentifier__Array *)il2cpp_array_new_specific_0(
			//                                                                 TypeInfo::UnityEngine::HyperGryph::AssetIdentifier,
			//                                                                 1024LL,
			//                                                                 v31,
			//                                                                 v32);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_assetIdentifiers, v33, v34, v35, methode, v50);
			//   v36 = (IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *)sub_180004920(TypeInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>);
			//   v37 = v36;
			//   if ( !v36 )
			// LABEL_6:
			//     sub_180B536AC(v8, v7);
			//   Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::IndexedHashSet(
			//     v36,
			//     MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::IndexedHashSet);
			//   this.fields.m_loadingAssetHandleIndexSet = v37;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_loadingAssetHandleIndexSet, v38, v39, v40, v51, v52);
			// }
			// 
		}

		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::HGResourceManagerScript::Dispose(HGResourceManagerScript *this, MethodInfo *method)
			// {
			//   Delegate *getFileHashMappingCallback; // rsi
			//   HGResourceManager_GetFileHashMappingCallback *v4; // rax
			//   HGRenderPathBase_HGRenderPathResources *v5; // rdx
			//   __int64 v6; // rcx
			//   Delegate *v7; // rdi
			//   PassConstructorID__Enum__Array *v8; // rax
			//   HGCamera *v9; // r9
			//   HGResourceManager_GetFileHashMappingCallback *v10; // rdx
			//   Delegate *getFilePathMappingCallback; // rsi
			//   HGResourceManager_GetFilePathMappingCallback *v12; // rax
			//   Delegate *v13; // rdi
			//   PassConstructorID__Enum__Array *v14; // rax
			//   HGCamera *v15; // r9
			//   HGResourceManager_GetFilePathMappingCallback *v16; // rdx
			//   Delegate *getWaterSectorTextureCallback; // rsi
			//   HGResourceManager_GetTextureFromHGWaterSectorDataCallback *v18; // rax
			//   Delegate *v19; // rdi
			//   PassConstructorID__Enum__Array *v20; // rax
			//   HGCamera *v21; // r9
			//   HGResourceManager_GetTextureFromHGWaterSectorDataCallback *v22; // rdx
			//   PassConstructorID__Enum__Array *v23; // r8
			//   HGCamera *v24; // r9
			//   FAssetProxyHandle__Array *m_assetHandles; // rsi
			//   int32_t v26; // edi
			//   HGRenderPathBase_HGRenderPathResources *v27; // rdx
			//   PassConstructorID__Enum__Array *v28; // r8
			//   HGCamera *v29; // r9
			//   HGRenderPathBase_HGRenderPathResources *v30; // rdx
			//   PassConstructorID__Enum__Array *v31; // r8
			//   HGCamera *v32; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   FAssetProxyHandle v34; // [rsp+20h] [rbp-38h] BYREF
			//   FAssetProxyHandle v35; // [rsp+38h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D9193EB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback);
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback);
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback);
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::HGResourceManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGWaterSectorData::GetWaterSectorTextureFromScriptableObject);
			//     sub_18003C530(MethodInfo::Beyond::VFS::VirtualFileSystem::TryGetFilePathMappingCallback);
			//     sub_18003C530(MethodInfo::Beyond::VFS::VirtualFileSystem::TryGetFilePathMappingCallback);
			//     byte_18D9193EB = 1;
			//   }
			//   memset(&v34, 0, sizeof(v34));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1923, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1923, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_36:
			//     sub_180B536AC(v6, v5);
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::HyperGryph::HGResourceManager);
			//   getFileHashMappingCallback = (Delegate *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getFileHashMappingCallback;
			//   v4 = (HGResourceManager_GetFileHashMappingCallback *)sub_180004920(TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback);
			//   v7 = (Delegate *)v4;
			//   if ( !v4 )
			//     goto LABEL_36;
			//   UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback::GetFileHashMappingCallback(
			//     v4,
			//     0LL,
			//     MethodInfo::Beyond::VFS::VirtualFileSystem::TryGetFilePathMappingCallback[0],
			//     0LL);
			//   v8 = (PassConstructorID__Enum__Array *)System::Delegate::Remove(getFileHashMappingCallback, v7, 0LL);
			//   if ( v8 )
			//   {
			//     if ( (struct HGResourceManager_GetFileHashMappingCallback__Class *)v8.klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback )
			//       sub_1802DC21C(v8, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback);
			//     v10 = (HGResourceManager_GetFileHashMappingCallback *)v8;
			//   }
			//   else
			//   {
			//     v10 = 0LL;
			//   }
			//   TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getFileHashMappingCallback = v10;
			//   if ( v8
			//     && (struct HGResourceManager_GetFileHashMappingCallback__Class *)v8.klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback )
			//   {
			//     sub_1802DC21C(v8, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback);
			//   }
			//   sub_1800054D0(
			//     (HGRenderPathScene *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields,
			//     (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback,
			//     v8,
			//     v9,
			//     *(MethodInfo **)&v34.m_untrackedHandle.m_handleObjectID,
			//     *(MethodInfo **)&v34.m_untrackedHandle.m_assetProxyObj.m_handleID);
			//   getFilePathMappingCallback = (Delegate *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getFilePathMappingCallback;
			//   v12 = (HGResourceManager_GetFilePathMappingCallback *)sub_180004920(TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback);
			//   v13 = (Delegate *)v12;
			//   if ( !v12 )
			//     goto LABEL_36;
			//   UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback::GetFilePathMappingCallback(
			//     v12,
			//     0LL,
			//     MethodInfo::Beyond::VFS::VirtualFileSystem::TryGetFilePathMappingCallback[0],
			//     0LL);
			//   v14 = (PassConstructorID__Enum__Array *)System::Delegate::Remove(getFilePathMappingCallback, v13, 0LL);
			//   if ( v14 )
			//   {
			//     if ( (struct HGResourceManager_GetFilePathMappingCallback__Class *)v14.klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback )
			//       sub_1802DC21C(v14, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback);
			//     v16 = (HGResourceManager_GetFilePathMappingCallback *)v14;
			//   }
			//   else
			//   {
			//     v16 = 0LL;
			//   }
			//   TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getFilePathMappingCallback = v16;
			//   if ( v14
			//     && (struct HGResourceManager_GetFilePathMappingCallback__Class *)v14.klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback )
			//   {
			//     sub_1802DC21C(v14, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback);
			//   }
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getFilePathMappingCallback,
			//     (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback,
			//     v14,
			//     v15,
			//     *(MethodInfo **)&v34.m_untrackedHandle.m_handleObjectID,
			//     *(MethodInfo **)&v34.m_untrackedHandle.m_assetProxyObj.m_handleID);
			//   getWaterSectorTextureCallback = (Delegate *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getWaterSectorTextureCallback;
			//   v18 = (HGResourceManager_GetTextureFromHGWaterSectorDataCallback *)sub_180004920(TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback);
			//   v19 = (Delegate *)v18;
			//   if ( !v18 )
			//     goto LABEL_36;
			//   UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback::GetTextureFromHGWaterSectorDataCallback(
			//     v18,
			//     0LL,
			//     MethodInfo::HG::Rendering::Runtime::HGWaterSectorData::GetWaterSectorTextureFromScriptableObject,
			//     0LL);
			//   v20 = (PassConstructorID__Enum__Array *)System::Delegate::Remove(getWaterSectorTextureCallback, v19, 0LL);
			//   if ( v20 )
			//   {
			//     if ( (struct HGResourceManager_GetTextureFromHGWaterSectorDataCallback__Class *)v20.klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback )
			//       sub_1802DC21C(v20, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback);
			//     v22 = (HGResourceManager_GetTextureFromHGWaterSectorDataCallback *)v20;
			//   }
			//   else
			//   {
			//     v22 = 0LL;
			//   }
			//   TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getWaterSectorTextureCallback = v22;
			//   if ( v20
			//     && (struct HGResourceManager_GetTextureFromHGWaterSectorDataCallback__Class *)v20.klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback )
			//   {
			//     sub_1802DC21C(v20, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback);
			//   }
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields.getWaterSectorTextureCallback,
			//     (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback,
			//     v20,
			//     v21,
			//     *(MethodInfo **)&v34.m_untrackedHandle.m_handleObjectID,
			//     *(MethodInfo **)&v34.m_untrackedHandle.m_assetProxyObj.m_handleID);
			//   m_assetHandles = this.fields.m_assetHandles;
			//   v26 = 0;
			//   if ( !m_assetHandles )
			//     goto LABEL_36;
			//   while ( v26 < m_assetHandles.max_length.size )
			//   {
			//     sub_1800023A0(m_assetHandles, &v35, v26);
			//     v34 = v35;
			//     Beyond::Resource::FAssetProxyHandle::Dispose(&v34, 0LL);
			//     ++v26;
			//   }
			//   this.fields.m_assetHandles = 0LL;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields,
			//     v5,
			//     v23,
			//     v24,
			//     *(MethodInfo **)&v34.m_untrackedHandle.m_handleObjectID,
			//     *(MethodInfo **)&v34.m_untrackedHandle.m_assetProxyObj.m_handleID);
			//   this.fields.m_assetHandleCount = 0;
			//   this.fields.m_assetIdentifiers = 0LL;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_assetIdentifiers,
			//     v27,
			//     v28,
			//     v29,
			//     *(MethodInfo **)&v34.m_untrackedHandle.m_handleObjectID,
			//     *(MethodInfo **)&v34.m_untrackedHandle.m_assetProxyObj.m_handleID);
			//   this.fields.m_loadingAssetHandleIndexSet = 0LL;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_loadingAssetHandleIndexSet,
			//     v30,
			//     v31,
			//     v32,
			//     *(MethodInfo **)&v34.m_untrackedHandle.m_handleObjectID,
			//     *(MethodInfo **)&v34.m_untrackedHandle.m_assetProxyObj.m_handleID);
			// }
			// 
		}

		public void GameplayUpdate()
		{
			// // Void GameplayUpdate()
			// // Hidden C++ exception states: #wind=5 #try_helpers=1
			// void HG::Rendering::Runtime::HGResourceManagerScript::GameplayUpdate(HGResourceManagerScript *this, MethodInfo *method)
			// {
			//   HGResourceManagerScript *v2; // r15
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v5; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   struct HGResourceManager__Class *v11; // rcx
			//   void (__fastcall *v12)(struct HGResourceManager__Class *); // rax
			//   __int64 *v13; // rdx
			//   unsigned __int64 v14; // r8
			//   signed __int64 v15; // r9
			//   __int128 v16; // xmm6
			//   Il2CppClass *klass; // rcx
			//   int v18; // ebx
			//   __int64 v19; // rdi
			//   Il2CppClass *v20; // rax
			//   const Il2CppRGCTXData *rgctx_data; // rax
			//   __int64 v22; // r12
			//   __m128i v23; // xmm6
			//   __int64 v24; // r14
			//   FAssetProxyHandle__Array *v25; // rcx
			//   __int64 v26; // rdx
			//   __int64 v27; // r8
			//   __int64 v28; // r9
			//   FAssetProxyHandle__Array *v29; // rcx
			//   __int64 v30; // rax
			//   __int64 v31; // rdx
			//   IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v32; // r14
			//   struct MethodInfo *v33; // rbx
			//   const Il2CppRGCTXData *v34; // rcx
			//   Il2CppRGCTXData v35; // rbx
			//   Dictionary_2_UnityEngine_HyperGryph_AssetHandleIndex_System_Int32_ *m_indexDict; // rsi
			//   __int64 v37; // rdi
			//   int32_t Entry; // eax
			//   Dictionary_2_TKey_TValue_Entry_UnityEngine_HyperGryph_AssetHandleIndex_System_Int32___Array *entries; // rcx
			//   int32_t value; // edi
			//   AssetIdentifier__Array *v41; // rcx
			//   __int64 v42; // rdi
			//   bool v43; // si
			//   __int64 v44; // rbx
			//   void (__fastcall __noreturn **v45)(); // rax
			//   unsigned int v46; // eax
			//   __int64 v47; // rax
			//   unsigned int *v48; // rdx
			//   unsigned int v49; // r8d
			//   __int64 v50; // rtt
			//   __int64 v51; // rbx
			//   __int64 v52; // rax
			//   __int64 v53; // rbx
			//   _QWORD **v54; // rax
			//   __int64 v55; // r8
			//   __int64 v56; // rax
			//   HGResourceManager__StaticFields *static_fields; // rcx
			//   Type__Array *kAssetTypeToUnityType; // rax
			//   Type *v59; // rbx
			//   StringPathHash v60; // xmm6_8
			//   __int64 v61; // rdx
			//   __int64 v62; // rcx
			//   __int64 v63; // r8
			//   __int64 v64; // r9
			//   FAssetProxyHandle__Array *m_assetHandles; // rax
			//   HGResourceManagerScript__Fields *p_fields; // rbx
			//   struct MethodInfo *v67; // r14
			//   int32_t v68; // esi
			//   int32_t length; // edi
			//   const Il2CppRGCTXData *v70; // rax
			//   Il2CppRGCTXData v71; // rsi
			//   FAssetProxyHandle__Array *v72; // r14
			//   __int64 v73; // rax
			//   Array *v74; // rax
			//   Array *v75; // rsi
			//   unsigned int v76; // ebx
			//   __int64 *v77; // rdx
			//   char v78; // bl
			//   __int64 v79; // rtt
			//   __int64 v80; // rax
			//   unsigned int v81; // ebx
			//   __int64 *v82; // rdx
			//   char v83; // bl
			//   __int64 v84; // rtt
			//   _BYTE *rgctxDataDummy; // rax
			//   unsigned int v86; // ebx
			//   __int64 *v87; // rdx
			//   char v88; // bl
			//   __int64 v89; // rtt
			//   unsigned __int64 p_m_assetIdentifiers; // rbx
			//   struct MethodInfo *v91; // r14
			//   int32_t v92; // esi
			//   int32_t v93; // edi
			//   const Il2CppRGCTXData *v94; // rax
			//   Il2CppRGCTXData v95; // rsi
			//   __int64 v96; // r14
			//   __int64 v97; // rax
			//   Array *v98; // rax
			//   Array *v99; // rsi
			//   unsigned int v100; // ebx
			//   __int64 *v101; // rdx
			//   char v102; // bl
			//   __int64 v103; // rtt
			//   __int64 v104; // rax
			//   unsigned int v105; // ebx
			//   __int64 *v106; // rdx
			//   char v107; // bl
			//   __int64 v108; // rtt
			//   _BYTE *v109; // rax
			//   unsigned int v110; // ebx
			//   __int64 *v111; // rdx
			//   char v112; // bl
			//   __int64 v113; // rtt
			//   __int64 v114; // rdx
			//   __int64 v115; // r8
			//   __int64 v116; // r9
			//   __int64 v117; // rdx
			//   AssetState__Enum v118; // r8d
			//   AssetIdentifier v119; // xmm6
			//   FAssetProxyHandle__Array *v120; // rcx
			//   IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *m_loadingAssetHandleIndexSet; // rcx
			//   __int64 *v122; // rdx
			//   unsigned int v123; // r8d
			//   __int64 v124; // rbx
			//   void (__fastcall __noreturn **v125)(); // rax
			//   unsigned int v126; // eax
			//   unsigned int v127; // r8d
			//   __int64 v128; // rax
			//   unsigned int *v129; // rdx
			//   signed __int64 v130; // r9
			//   char v131; // r8
			//   __int64 v132; // rtt
			//   __int64 v133; // rbx
			//   __int64 v134; // rax
			//   __int64 v135; // rbx
			//   _QWORD **v136; // rax
			//   __int64 v137; // r8
			//   __int64 v138; // rax
			//   void (__fastcall *v139)(int32_t *, AssetIdentifier *, _QWORD, _QWORD); // rax
			//   AssetIdentifier__Array *m_assetIdentifiers; // rcx
			//   void (*v141)(void); // rax
			//   __int64 v142; // rdx
			//   __int64 v143; // rcx
			//   __int64 v144; // r8
			//   __int64 v145; // r9
			//   IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v146; // rax
			//   struct MethodInfo *v147; // rdx
			//   const Il2CppRGCTXData *v148; // rcx
			//   IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v149; // rax
			//   struct MethodInfo *v150; // rdx
			//   List_1_UnityEngine_HyperGryph_AssetHandleIndex_ *m_list; // rbx
			//   const Il2CppRGCTXData *v152; // rcx
			//   int32_t size; // edi
			//   IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v154; // rbx
			//   struct MethodInfo *v155; // rdx
			//   List_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v156; // rbx
			//   const Il2CppRGCTXData *v157; // rcx
			//   AssetHandleIndex__Array *items; // rbx
			//   __int64 index; // rbx
			//   FAssetProxyHandle__Array *v160; // rcx
			//   AssetIdentifier__Array *v161; // rcx
			//   AssetIdentifier v162; // xmm6
			//   __int64 v163; // rdx
			//   Object_1 *v164; // rsi
			//   __int64 v165; // rdx
			//   AssetState__Enum v166; // r8d
			//   Object_1 *v167; // rax
			//   __int64 v168; // rdx
			//   __int64 v169; // rcx
			//   __int64 v170; // rdx
			//   int32_t InstanceID; // esi
			//   AssetState__Enum v172; // r8d
			//   _BYTE *v173; // rdx
			//   IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v174; // rcx
			//   __int64 v175; // rax
			//   __int64 v176; // rax
			//   ArgumentOutOfRangeException *v177; // rbx
			//   String *v178; // rdi
			//   String *v179; // rax
			//   __int64 v180; // rax
			//   ArgumentOutOfRangeException *v181; // rbx
			//   String *v182; // rdi
			//   String *v183; // rax
			//   __int64 v184; // rax
			//   __int64 v185; // rax
			//   _BYTE v186[32]; // [rsp+0h] [rbp-228h] BYREF
			//   char v187; // [rsp+30h] [rbp-1F8h] BYREF
			//   char v188; // [rsp+31h] [rbp-1F7h] BYREF
			//   int32_t v189[4]; // [rsp+38h] [rbp-1F0h] BYREF
			//   int v190; // [rsp+48h] [rbp-1E0h]
			//   Il2CppException *ex; // [rsp+50h] [rbp-1D8h]
			//   char *v192; // [rsp+58h] [rbp-1D0h]
			//   Il2CppException *v193; // [rsp+60h] [rbp-1C8h]
			//   char *v194; // [rsp+68h] [rbp-1C0h]
			//   FAssetProxyHandle v195; // [rsp+70h] [rbp-1B8h] BYREF
			//   _OWORD v196[3]; // [rsp+88h] [rbp-1A0h] BYREF
			//   FAssetProxyUntrackedHandle v197; // [rsp+B8h] [rbp-170h] BYREF
			//   FAssetProxyHandle v198; // [rsp+D0h] [rbp-158h] BYREF
			//   __int64 v199; // [rsp+E8h] [rbp-140h]
			//   char *v200; // [rsp+F0h] [rbp-138h]
			//   AssetIdentifier v201; // [rsp+100h] [rbp-128h] BYREF
			//   AssetIdentifier v202[2]; // [rsp+110h] [rbp-118h] BYREF
			//   __m256i v203; // [rsp+130h] [rbp-F8h] BYREF
			//   _BYTE v204[24]; // [rsp+150h] [rbp-D8h]
			//   int v205; // [rsp+168h] [rbp-C0h] BYREF
			//   int v206; // [rsp+178h] [rbp-B0h] BYREF
			//   Il2CppExceptionWrapper *v207; // [rsp+188h] [rbp-A0h] BYREF
			//   Il2CppExceptionWrapper *v208; // [rsp+190h] [rbp-98h] BYREF
			//   Il2CppExceptionWrapper *v209; // [rsp+198h] [rbp-90h] BYREF
			//   Il2CppExceptionWrapper *v210; // [rsp+1A0h] [rbp-88h] BYREF
			//   __int64 v211; // [rsp+1C0h] [rbp-68h]
			//   FAssetProxyHandle v212; // [rsp+1C8h] [rbp-60h] BYREF
			//   char v214; // [rsp+240h] [rbp+18h] BYREF
			//   char v215; // [rsp+248h] [rbp+20h] BYREF
			// 
			//   v2 = this;
			//   if ( !byte_18D8ED963 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ArrayExtensions::Grow<UnityEngine::HyperGryph::AssetIdentifier>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ArrayExtensions::Grow<Beyond::Resource::FAssetProxyHandle>);
			//     sub_18003C530(&MethodInfo::Unity::Profiling::ProfilerMarker_1_TP1_::AutoScope<int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::HyperGryph::AssetOperation>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::HyperGryph::AssetOperation>::MoveNext);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::HyperGryph::AssetOperation>::get_Current);
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::HGResourceManager);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::Add);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::RemoveAtSwapBack);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::Remove);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Item);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::AssetOperation>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::Unity::Profiling::ProfilerMarker<int>::Auto);
			//     sub_18003C530(&TypeInfo::Beyond::Resource::ResourceManager);
			//     sub_18003C530(&MethodInfo::Beyond::SingletonScriptableObject<Beyond::Resource::ResourceOptions>::get_instance);
			//     byte_18D8ED963 = 1;
			//   }
			//   memset(v196, 0, sizeof(v196));
			//   memset(&v195, 0, sizeof(v195));
			//   v187 = 0;
			//   memset(&v198, 0, sizeof(v198));
			//   v214 = 0;
			//   v188 = 0;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v3, method);
			//   if ( wrapperArray.max_length.size > 1945 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, method);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = v3.static_fields.wrapperArray;
			//     if ( !v5 )
			//       sub_180B536AC(v3, method);
			//     if ( v5.max_length.size <= 0x799u )
			//       sub_180070270(v3, method);
			//     if ( v5[54].vector[1] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1945, 0LL);
			//       if ( !Patch )
			//         sub_180B536AC(v8, v7);
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//       return;
			//     }
			//   }
			//   if ( !Beyond::SingletonScriptableObject<System::Object>::get_instance(MethodInfo::Beyond::SingletonScriptableObject<Beyond::Resource::ResourceOptions>::get_instance) )
			//     sub_180B536AC(v10, v9);
			//   v11 = TypeInfo::UnityEngine::HyperGryph::HGResourceManager;
			//   if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::HGResourceManager, v9);
			//   v12 = (void (__fastcall *)(struct HGResourceManager__Class *))qword_18D8F5B88;
			//   if ( !qword_18D8F5B88 )
			//   {
			//     v12 = (void (__fastcall *)(struct HGResourceManager__Class *))il2cpp_resolve_icall_0(
			//                                                                     "UnityEngine.HyperGryph.HGResourceManager::set_usingV"
			//                                                                     "FS(System.Boolean)");
			//     if ( !v12 )
			//     {
			//       v175 = sub_1802DBBE8("UnityEngine.HyperGryph.HGResourceManager::set_usingVFS(System.Boolean)");
			//       sub_18000F750(v175, 0LL);
			//     }
			//     qword_18D8F5B88 = (__int64)v12;
			//   }
			//   LOBYTE(v11) = 1;
			//   v12(v11);
			//   v16 = *(_OWORD *)sub_1822A1990(&v197);
			//   v215 = 0;
			//   v199 = 0LL;
			//   v200 = &v215;
			//   memset((char *)v203.m256i_i64 + 4, 0, 28);
			//   klass = MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::AssetOperation>::GetEnumerator.klass;
			//   if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(klass);
			//   v203.m256i_i32[0] = -1;
			//   memset(&v203.m256i_u64[1], 0, 24);
			//   v196[0] = v16;
			//   v196[1] = *(_OWORD *)v203.m256i_i8;
			//   v196[2] = 0uLL;
			//   v193 = 0LL;
			//   v194 = (char *)v196;
			//   try
			//   {
			//     while ( 1 )
			//     {
			//       v18 = LODWORD(v196[1]) + 1;
			//       LODWORD(v196[1]) = v18;
			//       if ( v18 >= SDWORD2(v196[0]) )
			//         break;
			//       v19 = *(_QWORD *)&v196[0];
			//       v20 = MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::HyperGryph::AssetOperation>::MoveNext.klass;
			//       if ( ((__int64)v20.vtable[0].methodPtr & 1) == 0 )
			//         sub_18003C700(v20);
			//       rgctx_data = v20.rgctx_data;
			//       if ( !*((_QWORD *)rgctx_data.rgctxDataDummy + 7) )
			//         sub_180041F40(rgctx_data.rgctxDataDummy);
			//       *(_OWORD *)((char *)&v196[1] + 8) = *(_OWORD *)(v19 + 24LL * v18);
			//       *((_QWORD *)&v196[2] + 1) = *(_QWORD *)(v19 + 24LL * v18 + 16);
			//       *(_OWORD *)v204 = *(_OWORD *)(v19 + 24LL * v18);
			//       *(_QWORD *)&v204[16] = *(_QWORD *)(v19 + 24LL * v18 + 16);
			//       v22 = HIDWORD(*(_QWORD *)v204);
			//       v190 = *(_DWORD *)&v204[4];
			//       v23 = *(__m128i *)v204;
			//       v211 = *(_QWORD *)&v204[16];
			//       v24 = *(_QWORD *)(v19 + 24LL * v18) >> 16;
			//       if ( *(_BYTE *)(v19 + 24LL * v18) )
			//       {
			//         v42 = (int)v211;
			//         v43 = (unsigned int)(v211 - 7) <= 1;
			//         if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::HGResourceManager, v13);
			//         if ( !byte_18D8ED990 )
			//         {
			//           v14 = _InterlockedExchangeAdd64(
			//                   (volatile signed __int64 *)&TypeInfo::UnityEngine::HyperGryph::HGResourceManager,
			//                   0LL);
			//           if ( (v14 & 1) != 0 )
			//           {
			//             v44 = ((unsigned int)v14 >> 1) & 0xFFFFFFF;
			//             switch ( (unsigned int)v14 >> 29 )
			//             {
			//               case 1u:
			//                 v45 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v44);
			//                 goto LABEL_83;
			//               case 2u:
			//                 v45 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v44);
			//                 goto LABEL_83;
			//               case 3u:
			//               case 6u:
			//                 v46 = ((unsigned int)v14 >> 1) & 0xFFFFFFF;
			//                 v14 = (unsigned int)v14 >> 29;
			//                 if ( (_DWORD)v14 )
			//                 {
			//                   if ( (_DWORD)v14 == 3 )
			//                   {
			//                     v45 = (void (__fastcall __noreturn **)())sub_180039480(v46);
			//                     goto LABEL_83;
			//                   }
			//                   if ( (_DWORD)v14 == 6 )
			//                   {
			//                     v47 = sub_1802DF9C0(v46);
			//                     v45 = (void (__fastcall __noreturn **)())sub_18005F4B0(v47, 0LL);
			//                     goto LABEL_83;
			//                   }
			//                 }
			//                 else if ( v46 == 1 )
			//                 {
			//                   v45 = off_18A2C5600;
			//                   goto LABEL_83;
			//                 }
			// LABEL_82:
			//                 v45 = 0LL;
			// LABEL_83:
			//                 if ( v45 )
			//                   _InterlockedExchange64(
			//                     (volatile __int64 *)&TypeInfo::UnityEngine::HyperGryph::HGResourceManager,
			//                     (__int64)v45);
			//                 break;
			//               case 4u:
			//                 v45 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v44);
			//                 goto LABEL_83;
			//               case 5u:
			//                 if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v44) )
			//                 {
			//                   v45 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v44);
			//                 }
			//                 else
			//                 {
			//                   v48 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v44);
			//                   v15 = il2cpp_string_new_len(qword_18D8E5198 + (int)v48[1] + *(int *)(qword_18D8E51A0 + 16), *v48);
			//                   v45 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                              (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v44),
			//                                                              v15,
			//                                                              0LL);
			//                   if ( !v45 )
			//                   {
			//                     v14 = qword_18D8F6F98 + 8 * v44;
			//                     if ( dword_18D8E43F8 )
			//                     {
			//                       v49 = (v14 >> 12) & 0x1FFFFF;
			//                       v13 = &qword_18D6870D0[(unsigned __int64)v49 >> 6];
			//                       v14 = v49 & 0x3F;
			//                       _m_prefetchw(v13);
			//                       do
			//                         v50 = *v13;
			//                       while ( v50 != _InterlockedCompareExchange64(v13, *v13 | (1LL << v14), *v13) );
			//                     }
			//                     v45 = (void (__fastcall __noreturn **)())v15;
			//                   }
			//                 }
			//                 goto LABEL_83;
			//               case 7u:
			//                 v51 = sub_1802DF920((unsigned int)v44);
			//                 v52 = *(_QWORD *)(v51 + 16);
			//                 v53 = (v51 - *(_QWORD *)(v52 + 128)) >> 5;
			//                 if ( *(_BYTE *)(v52 + 42) == 21 )
			//                 {
			//                   v54 = *(_QWORD ***)(v52 + 96);
			//                   if ( *v54 )
			//                   {
			//                     v55 = **v54 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                     v52 = sub_180039550(v55 / 92 + v55);
			//                   }
			//                   else
			//                   {
			//                     v52 = 0LL;
			//                   }
			//                 }
			//                 v205 = v53 + *(_DWORD *)(*(_QWORD *)(v52 + 104) + 32LL);
			//                 v56 = sub_1801B8ECC(
			//                         (unsigned int)&v205,
			//                         (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                         *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                         12,
			//                         (__int64)sub_1802C7760);
			//                 if ( !v56 )
			//                   goto LABEL_82;
			//                 v13 = (__int64 *)*(unsigned int *)(v56 + 8);
			//                 if ( (_DWORD)v13 == -1 )
			//                   goto LABEL_82;
			//                 v45 = (void (__fastcall __noreturn **)())((char *)v13 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                 goto LABEL_83;
			//               default:
			//                 break;
			//             }
			//           }
			//           byte_18D8ED990 = 1;
			//         }
			//         if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::HGResourceManager, v13);
			//         static_fields = TypeInfo::UnityEngine::HyperGryph::HGResourceManager.static_fields;
			//         kAssetTypeToUnityType = static_fields.kAssetTypeToUnityType;
			//         if ( !kAssetTypeToUnityType )
			//           sub_1802DC2C8(static_fields, v13);
			//         if ( (unsigned int)v42 >= kAssetTypeToUnityType.max_length.size )
			//           sub_180070260(static_fields, v13, v14, v15);
			//         v59 = kAssetTypeToUnityType.vector[v42];
			//         if ( !TypeInfo::Beyond::Resource::ResourceManager._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::Beyond::Resource::ResourceManager, v13);
			//         v60.hash = _mm_srli_si128(v23, 8).m128i_u64[0];
			//         v195 = *Beyond::Resource::ResourceManager::LoadAsync(
			//                   &v212,
			//                   v60,
			//                   v59,
			//                   (RootCategory__Enum)v43,
			//                   (EResourceRequestPriority__Enum)(unsigned __int16)v24,
			//                   0LL);
			//         m_assetHandles = v2.fields.m_assetHandles;
			//         if ( !m_assetHandles )
			//           sub_1802DC2C8(v62, v61);
			//         if ( v22 >= m_assetHandles.max_length.size )
			//         {
			//           p_fields = &v2.fields;
			//           v67 = MethodInfo::UnityEngine::Rendering::ArrayExtensions::Grow<Beyond::Resource::FAssetProxyHandle>;
			//           v68 = v22 + 1;
			//           if ( !MethodInfo::UnityEngine::Rendering::ArrayExtensions::Grow<Beyond::Resource::FAssetProxyHandle>.rgctx_data )
			//             sub_180041F40(MethodInfo::UnityEngine::Rendering::ArrayExtensions::Grow<Beyond::Resource::FAssetProxyHandle>);
			//           if ( p_fields.m_assetHandles )
			//             length = p_fields.m_assetHandles.max_length.size;
			//           else
			//             length = 1;
			//           for ( ; length < v68; length *= 2 )
			//             ;
			//           v70 = v67.rgctx_data;
			//           if ( p_fields.m_assetHandles )
			//           {
			//             v71.rgctxDataDummy = v70[1].rgctxDataDummy;
			//             if ( !*((_QWORD *)v71.rgctxDataDummy + 7) )
			//               ((void (__fastcall *)(_QWORD))sub_180041F40)((const Il2CppRGCTXData)v70[1].rgctxDataDummy);
			//             if ( length < 0 )
			//             {
			//               v176 = sub_18000F7E0(&TypeInfo::System::ArgumentOutOfRangeException);
			//               v177 = (ArgumentOutOfRangeException *)sub_18004C870(v176);
			//               sub_180002BF0(v177);
			//               v178 = (String *)sub_18000F7E0(&off_18CDB2200);
			//               v179 = (String *)sub_18000F7E0(&off_18D4F9ED0);
			//               System::ArgumentOutOfRangeException::ArgumentOutOfRangeException(v177, v179, v178, 0LL);
			//               ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_18000F7C0)(v177, (Il2CppRGCTXData)v71.rgctxDataDummy);
			//             }
			//             v72 = p_fields.m_assetHandles;
			//             if ( p_fields.m_assetHandles )
			//             {
			//               if ( v72.max_length.size != length )
			//               {
			//                 v73 = **((_QWORD **)v71.rgctxDataDummy + 7);
			//                 if ( (*(_BYTE *)(v73 + 312) & 1) == 0 )
			//                   sub_18003C700(**((_QWORD **)v71.rgctxDataDummy + 7));
			//                 v74 = (Array *)il2cpp_array_new_specific_0(v73, (unsigned int)length, v63, v64);
			//                 v75 = v74;
			//                 if ( v72.max_length.size <= length )
			//                   length = v72.max_length.size;
			//                 System::Array::Copy((Array *)v72, 0, v74, 0, length, 0LL);
			//                 p_fields.m_assetHandles = (FAssetProxyHandle__Array *)v75;
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v76 = ((unsigned __int64)p_fields >> 12) & 0x1FFFFF;
			//                   v77 = &qword_18D6870D0[(unsigned __int64)v76 >> 6];
			//                   v78 = v76 & 0x3F;
			//                   _m_prefetchw(v77);
			//                   do
			//                     v79 = *v77;
			//                   while ( v79 != _InterlockedCompareExchange64(v77, *v77 | (1LL << v78), *v77) );
			//                 }
			//               }
			//             }
			//             else
			//             {
			//               v80 = **((_QWORD **)v71.rgctxDataDummy + 7);
			//               if ( (*(_BYTE *)(v80 + 312) & 1) == 0 )
			//                 sub_18003C700(**((_QWORD **)v71.rgctxDataDummy + 7));
			//               p_fields.m_assetHandles = (FAssetProxyHandle__Array *)il2cpp_array_new_specific_0(
			//                                                                        v80,
			//                                                                        (unsigned int)length,
			//                                                                        v63,
			//                                                                        v64);
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v81 = ((unsigned __int64)p_fields >> 12) & 0x1FFFFF;
			//                 v82 = &qword_18D6870D0[(unsigned __int64)v81 >> 6];
			//                 v83 = v81 & 0x3F;
			//                 _m_prefetchw(v82);
			//                 do
			//                   v84 = *v82;
			//                 while ( v84 != _InterlockedCompareExchange64(v82, *v82 | (1LL << v83), *v82) );
			//               }
			//             }
			//           }
			//           else
			//           {
			//             rgctxDataDummy = v70.rgctxDataDummy;
			//             if ( (rgctxDataDummy[312] & 1) == 0 )
			//               sub_18003C700(rgctxDataDummy);
			//             p_fields.m_assetHandles = (FAssetProxyHandle__Array *)il2cpp_array_new_specific_0(
			//                                                                      rgctxDataDummy,
			//                                                                      (unsigned int)length,
			//                                                                      v63,
			//                                                                      v64);
			//             if ( dword_18D8E43F8 )
			//             {
			//               v86 = ((unsigned __int64)p_fields >> 12) & 0x1FFFFF;
			//               v87 = &qword_18D6870D0[(unsigned __int64)v86 >> 6];
			//               v88 = v86 & 0x3F;
			//               _m_prefetchw(v87);
			//               do
			//                 v89 = *v87;
			//               while ( v89 != _InterlockedCompareExchange64(v87, *v87 | (1LL << v88), *v87) );
			//             }
			//           }
			//           p_m_assetIdentifiers = (unsigned __int64)&v2.fields.m_assetIdentifiers;
			//           v91 = MethodInfo::UnityEngine::Rendering::ArrayExtensions::Grow<UnityEngine::HyperGryph::AssetIdentifier>;
			//           v92 = v22 + 1;
			//           if ( !MethodInfo::UnityEngine::Rendering::ArrayExtensions::Grow<UnityEngine::HyperGryph::AssetIdentifier>.rgctx_data )
			//             sub_180041F40(MethodInfo::UnityEngine::Rendering::ArrayExtensions::Grow<UnityEngine::HyperGryph::AssetIdentifier>);
			//           if ( *(_QWORD *)p_m_assetIdentifiers )
			//             v93 = *(_DWORD *)(*(_QWORD *)p_m_assetIdentifiers + 24LL);
			//           else
			//             v93 = 1;
			//           for ( ; v93 < v92; v93 *= 2 )
			//             ;
			//           v94 = v91.rgctx_data;
			//           if ( *(_QWORD *)p_m_assetIdentifiers )
			//           {
			//             v95.rgctxDataDummy = v94[1].rgctxDataDummy;
			//             if ( !*((_QWORD *)v95.rgctxDataDummy + 7) )
			//               ((void (__fastcall *)(_QWORD))sub_180041F40)((const Il2CppRGCTXData)v94[1].rgctxDataDummy);
			//             if ( v93 < 0 )
			//             {
			//               v180 = sub_18000F7E0(&TypeInfo::System::ArgumentOutOfRangeException);
			//               v181 = (ArgumentOutOfRangeException *)sub_18004C870(v180);
			//               sub_180002BF0(v181);
			//               v182 = (String *)sub_18000F7E0(&off_18CDB2200);
			//               v183 = (String *)sub_18000F7E0(&off_18D4F9ED0);
			//               System::ArgumentOutOfRangeException::ArgumentOutOfRangeException(v181, v183, v182, 0LL);
			//               ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_18000F7C0)(v181, (Il2CppRGCTXData)v95.rgctxDataDummy);
			//             }
			//             v96 = *(_QWORD *)p_m_assetIdentifiers;
			//             if ( *(_QWORD *)p_m_assetIdentifiers )
			//             {
			//               if ( *(_DWORD *)(v96 + 24) != v93 )
			//               {
			//                 v97 = **((_QWORD **)v95.rgctxDataDummy + 7);
			//                 if ( (*(_BYTE *)(v97 + 312) & 1) == 0 )
			//                   sub_18003C700(**((_QWORD **)v95.rgctxDataDummy + 7));
			//                 v98 = (Array *)il2cpp_array_new_specific_0(v97, (unsigned int)v93, v63, v64);
			//                 v99 = v98;
			//                 if ( *(_DWORD *)(v96 + 24) <= v93 )
			//                   v93 = *(_DWORD *)(v96 + 24);
			//                 System::Array::Copy((Array *)v96, 0, v98, 0, v93, 0LL);
			//                 *(_QWORD *)p_m_assetIdentifiers = v99;
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v100 = (p_m_assetIdentifiers >> 12) & 0x1FFFFF;
			//                   v101 = &qword_18D6870D0[(unsigned __int64)v100 >> 6];
			//                   v102 = v100 & 0x3F;
			//                   _m_prefetchw(v101);
			//                   do
			//                     v103 = *v101;
			//                   while ( v103 != _InterlockedCompareExchange64(v101, *v101 | (1LL << v102), *v101) );
			//                 }
			//               }
			//             }
			//             else
			//             {
			//               v104 = **((_QWORD **)v95.rgctxDataDummy + 7);
			//               if ( (*(_BYTE *)(v104 + 312) & 1) == 0 )
			//                 sub_18003C700(**((_QWORD **)v95.rgctxDataDummy + 7));
			//               *(_QWORD *)p_m_assetIdentifiers = il2cpp_array_new_specific_0(v104, (unsigned int)v93, v63, v64);
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v105 = (p_m_assetIdentifiers >> 12) & 0x1FFFFF;
			//                 v106 = &qword_18D6870D0[(unsigned __int64)v105 >> 6];
			//                 v107 = v105 & 0x3F;
			//                 _m_prefetchw(v106);
			//                 do
			//                   v108 = *v106;
			//                 while ( v108 != _InterlockedCompareExchange64(v106, *v106 | (1LL << v107), *v106) );
			//               }
			//             }
			//           }
			//           else
			//           {
			//             v109 = v94.rgctxDataDummy;
			//             if ( (v109[312] & 1) == 0 )
			//               sub_18003C700(v109);
			//             *(_QWORD *)p_m_assetIdentifiers = il2cpp_array_new_specific_0(v109, (unsigned int)v93, v63, v64);
			//             if ( dword_18D8E43F8 )
			//             {
			//               v110 = (p_m_assetIdentifiers >> 12) & 0x1FFFFF;
			//               v111 = &qword_18D6870D0[(unsigned __int64)v110 >> 6];
			//               v112 = v110 & 0x3F;
			//               _m_prefetchw(v111);
			//               do
			//                 v113 = *v111;
			//               while ( v113 != _InterlockedCompareExchange64(v111, *v111 | (1LL << v112), *v111) );
			//             }
			//           }
			//         }
			//         ex = 0LL;
			//         v192 = &v187;
			//         try
			//         {
			//           if ( Beyond::Resource::FAssetProxyHandle::IsValid(&v195, 0LL) )
			//           {
			//             v120 = v2.fields.m_assetHandles;
			//             if ( !v120 )
			//               sub_1802DC2C8(0LL, v114);
			//             if ( (unsigned int)v22 >= v120.max_length.size )
			//               sub_180070260(v120, v114, v115, v116);
			//             v120.vector[v22] = v195;
			//             ++v2.fields.m_assetHandleCount;
			//             m_loadingAssetHandleIndexSet = v2.fields.m_loadingAssetHandleIndexSet;
			//             if ( !m_loadingAssetHandleIndexSet )
			//               sub_1802DC2C8(0LL, v114);
			//             Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::Add(
			//               m_loadingAssetHandleIndexSet,
			//               (AssetHandleIndex)v22,
			//               MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::Add);
			//             if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::HGResourceManager, v122);
			//             v119 = *(AssetIdentifier *)&v204[8];
			//             v202[0] = *(AssetIdentifier *)&v204[8];
			//             v189[0] = v22;
			//             if ( !byte_18D8F5B94 )
			//             {
			//               v123 = _InterlockedExchangeAdd64(
			//                        (volatile signed __int64 *)&TypeInfo::UnityEngine::HyperGryph::HGResourceManager,
			//                        0LL);
			//               if ( (v123 & 1) != 0 )
			//               {
			//                 v124 = (v123 >> 1) & 0xFFFFFFF;
			//                 switch ( v123 >> 29 )
			//                 {
			//                   case 1u:
			//                     v125 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v124);
			//                     goto LABEL_196;
			//                   case 2u:
			//                     v125 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v124);
			//                     goto LABEL_196;
			//                   case 3u:
			//                   case 6u:
			//                     v126 = (v123 >> 1) & 0xFFFFFFF;
			//                     v127 = v123 >> 29;
			//                     if ( v127 )
			//                     {
			//                       if ( v127 == 3 )
			//                       {
			//                         v125 = (void (__fastcall __noreturn **)())sub_180039480(v126);
			//                         goto LABEL_196;
			//                       }
			//                       if ( v127 == 6 )
			//                       {
			//                         v128 = sub_1802DF9C0(v126);
			//                         v125 = (void (__fastcall __noreturn **)())sub_18005F4B0(v128, 0LL);
			//                         goto LABEL_196;
			//                       }
			//                     }
			//                     else if ( v126 == 1 )
			//                     {
			//                       v125 = off_18A2C5600;
			//                       goto LABEL_196;
			//                     }
			// LABEL_195:
			//                     v125 = 0LL;
			// LABEL_196:
			//                     if ( v125 )
			//                       _InterlockedExchange64(
			//                         (volatile __int64 *)&TypeInfo::UnityEngine::HyperGryph::HGResourceManager,
			//                         (__int64)v125);
			//                     break;
			//                   case 4u:
			//                     v125 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v124);
			//                     goto LABEL_196;
			//                   case 5u:
			//                     if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v124) )
			//                     {
			//                       v125 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v124);
			//                     }
			//                     else
			//                     {
			//                       v129 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v124);
			//                       v130 = il2cpp_string_new_len(
			//                                qword_18D8E5198 + (int)v129[1] + *(int *)(qword_18D8E51A0 + 16),
			//                                *v129);
			//                       v125 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                   (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v124),
			//                                                                   v130,
			//                                                                   0LL);
			//                       if ( !v125 )
			//                       {
			//                         if ( dword_18D8E43F8 )
			//                         {
			//                           v122 = &qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v124) >> 12) & 0x1FFFFF) >> 6];
			//                           v131 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v124) >> 12) & 0x3F;
			//                           _m_prefetchw(v122);
			//                           do
			//                             v132 = *v122;
			//                           while ( v132 != _InterlockedCompareExchange64(v122, *v122 | (1LL << v131), *v122) );
			//                         }
			//                         v125 = (void (__fastcall __noreturn **)())v130;
			//                       }
			//                     }
			//                     goto LABEL_196;
			//                   case 7u:
			//                     v133 = sub_1802DF920((unsigned int)v124);
			//                     v134 = *(_QWORD *)(v133 + 16);
			//                     v135 = (v133 - *(_QWORD *)(v134 + 128)) >> 5;
			//                     if ( *(_BYTE *)(v134 + 42) == 21 )
			//                     {
			//                       v136 = *(_QWORD ***)(v134 + 96);
			//                       if ( *v136 )
			//                       {
			//                         v137 = **v136 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                         v134 = sub_180039550(v137 / 92 + v137);
			//                       }
			//                       else
			//                       {
			//                         v134 = 0LL;
			//                       }
			//                     }
			//                     v206 = v135 + *(_DWORD *)(*(_QWORD *)(v134 + 104) + 32LL);
			//                     v138 = sub_1801B8ECC(
			//                              (unsigned int)&v206,
			//                              (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                              *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                              12,
			//                              (__int64)sub_1802C7760);
			//                     if ( !v138 )
			//                       goto LABEL_195;
			//                     v122 = (__int64 *)*(unsigned int *)(v138 + 8);
			//                     if ( (_DWORD)v122 == -1 )
			//                       goto LABEL_195;
			//                     v125 = (void (__fastcall __noreturn **)())((char *)v122
			//                                                              + qword_18D8E5198
			//                                                              + *(int *)(qword_18D8E51A0 + 72));
			//                     goto LABEL_196;
			//                   default:
			//                     break;
			//                 }
			//               }
			//               byte_18D8F5B94 = 1;
			//             }
			//             if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::HGResourceManager, v122);
			//             v139 = (void (__fastcall *)(int32_t *, AssetIdentifier *, _QWORD, _QWORD))qword_18D8F5BE0;
			//             if ( !qword_18D8F5BE0 )
			//             {
			//               v139 = (void (__fastcall *)(int32_t *, AssetIdentifier *, _QWORD, _QWORD))il2cpp_resolve_icall_0(
			//                                                                                           "UnityEngine.HyperGryph.HGResou"
			//                                                                                           "rceManager::UpdateAssetHandle_"
			//                                                                                           "Injected(UnityEngine.HyperGryp"
			//                                                                                           "h.AssetHandleIndex&,UnityEngin"
			//                                                                                           "e.HyperGryph.AssetIdentifier&,"
			//                                                                                           "UnityEngine.HyperGryph.AssetSt"
			//                                                                                           "ate,System.Int32)");
			//               if ( !v139 )
			//               {
			//                 v184 = sub_1802DBBE8(
			//                          "UnityEngine.HyperGryph.HGResourceManager::UpdateAssetHandle_Injected(UnityEngine.HyperGryph.Ass"
			//                          "etHandleIndex&,UnityEngine.HyperGryph.AssetIdentifier&,UnityEngine.HyperGryph.AssetState,System.Int32)");
			//                 sub_18000F750(v184, 0LL);
			//               }
			//               qword_18D8F5BE0 = (__int64)v139;
			//             }
			//             v139(v189, v202, 0LL, 0LL);
			//           }
			//           else
			//           {
			//             Beyond::Resource::FAssetProxyHandle::Dispose(&v195, 0LL);
			//             if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::HGResourceManager, v117);
			//             v119 = *(AssetIdentifier *)&v204[8];
			//             v201 = *(AssetIdentifier *)&v204[8];
			//             LOBYTE(v118) = 2;
			//             UnityEngine::HyperGryph::HGResourceManager::UpdateAssetHandle((AssetHandleIndex)v22, &v201, v118, 0, 0LL);
			//           }
			//         }
			//         catch ( Il2CppExceptionWrapper *v207 )
			//         {
			//           v13 = (__int64 *)v186;
			//           ex = v207.ex;
			//           if ( ex )
			//             sub_18000F780(ex);
			//           v2 = this;
			//           v119 = *(AssetIdentifier *)&v204[8];
			//           LODWORD(v22) = v190;
			//         }
			//         m_assetIdentifiers = v2.fields.m_assetIdentifiers;
			//         if ( !m_assetIdentifiers )
			//           sub_1802DC2C8(0LL, v13);
			//         if ( (unsigned int)v22 >= m_assetIdentifiers.max_length.size )
			//           sub_180070260(m_assetIdentifiers, v13, v14, v15);
			//         m_assetIdentifiers.vector[(unsigned int)v22] = v119;
			//       }
			//       else
			//       {
			//         v25 = v2.fields.m_assetHandles;
			//         if ( !v25 )
			//           sub_1802DC2C8(0LL, v13);
			//         if ( *(_DWORD *)&v204[4] >= v25.max_length.size )
			//           sub_180070260(v25, v13, v14, v15);
			//         v198 = v25.vector[v22];
			//         if ( Beyond::Resource::FAssetProxyHandle::IsValid(&v198, 0LL) )
			//         {
			//           Beyond::Resource::FAssetProxyHandle::Dispose(&v198, 0LL);
			//           v29 = v2.fields.m_assetHandles;
			//           if ( !v29 )
			//             sub_1802DC2C8(0LL, v26);
			//           if ( (unsigned int)v22 >= v29.max_length.size )
			//             sub_180070260(v29, v26, v27, v28);
			//           v30 = v22;
			//           v31 = 0LL;
			//           *(_OWORD *)&v29.vector[v30].m_untrackedHandle.m_handleObjectID = 0LL;
			//           v29.vector[v30].m_untrackedHandle.m_mainVersion = 0;
			//           --v2.fields.m_assetHandleCount;
			//           v32 = v2.fields.m_loadingAssetHandleIndexSet;
			//           if ( !v32 )
			//             sub_1802DC2C8(v29, 0LL);
			//           v33 = MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::Remove;
			//           if ( !*((_QWORD *)MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::Remove.klass.rgctx_data[18].rgctxDataDummy
			//                 + 4) )
			//             (*(void (**)(void))MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::Remove.klass.rgctx_data[18].rgctxDataDummy)();
			//           v34 = v33.klass.rgctx_data;
			//           v35.rgctxDataDummy = v34[18].rgctxDataDummy;
			//           m_indexDict = v32.fields.m_indexDict;
			//           if ( !m_indexDict )
			//             sub_1802DC2C8(v34, v31);
			//           if ( !*(_QWORD *)(*(_QWORD *)(*(_QWORD *)(*((_QWORD *)v35.rgctxDataDummy + 4) + 192LL) + 152LL) + 32LL) )
			//             (**(void (***)(void))(*(_QWORD *)(*((_QWORD *)v35.rgctxDataDummy + 4) + 192LL) + 152LL))();
			//           v37 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)v35.rgctxDataDummy + 4) + 192LL) + 152LL);
			//           if ( !*(_QWORD *)(*(_QWORD *)(*(_QWORD *)(*(_QWORD *)(v37 + 32) + 192LL) + 176LL) + 32LL) )
			//             (**(void (***)(void))(*(_QWORD *)(*(_QWORD *)(v37 + 32) + 192LL) + 176LL))();
			//           Entry = System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::AssetHandleIndex,int>::FindEntry(
			//                     m_indexDict,
			//                     (AssetHandleIndex)v22,
			//                     *(MethodInfo **)(*(_QWORD *)(*(_QWORD *)(v37 + 32) + 192LL) + 176LL));
			//           if ( Entry >= 0 )
			//           {
			//             entries = m_indexDict.fields._entries;
			//             if ( !entries )
			//               sub_1802DC2C8(0LL, v13);
			//             if ( (unsigned int)Entry >= entries.max_length.size )
			//               sub_180070260(entries, Entry, v14, v15);
			//             value = entries.vector[Entry].value;
			//             if ( !*(_QWORD *)(*(_QWORD *)(*(_QWORD *)(*((_QWORD *)v35.rgctxDataDummy + 4) + 192LL) + 160LL) + 32LL) )
			//               (**(void (***)(void))(*(_QWORD *)(*((_QWORD *)v35.rgctxDataDummy + 4) + 192LL) + 160LL))();
			//             Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::RemoveAtSwapBack(
			//               v32,
			//               value,
			//               *(MethodInfo **)(*(_QWORD *)(*((_QWORD *)v35.rgctxDataDummy + 4) + 192LL) + 160LL));
			//           }
			//         }
			//         v41 = v2.fields.m_assetIdentifiers;
			//         if ( !v41 )
			//           sub_1802DC2C8(0LL, v13);
			//         if ( (unsigned int)v22 >= v41.max_length.size )
			//           sub_180070260(v41, v13, v14, v15);
			//         v41.vector[v22] = 0LL;
			//       }
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v208 )
			//   {
			//     v13 = (__int64 *)v186;
			//     v193 = v208.ex;
			//     if ( v193 )
			//       sub_18000F780(v193);
			//     v2 = this;
			//     goto LABEL_213;
			//   }
			//   memset((char *)&v196[1] + 8, 0, 24);
			// LABEL_213:
			//   if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::HGResourceManager, v13);
			//   v141 = (void (*)(void))qword_18D8F5BA8;
			//   if ( !qword_18D8F5BA8 )
			//   {
			//     v141 = (void (*)(void))il2cpp_resolve_icall_0("UnityEngine.HyperGryph.HGResourceManager::ClearAssetOperations()");
			//     if ( !v141 )
			//     {
			//       v185 = sub_1802DBBE8("UnityEngine.HyperGryph.HGResourceManager::ClearAssetOperations()");
			//       sub_18000F750(v185, 0LL);
			//     }
			//     qword_18D8F5BA8 = (__int64)v141;
			//   }
			//   v141();
			//   v146 = v2.fields.m_loadingAssetHandleIndexSet;
			//   if ( !v146 )
			//     sub_1802DC2C8(v143, v142);
			//   v147 = MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count;
			//   if ( !v146.fields.m_list )
			//     sub_1802DC2C8(v143, MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count);
			//   v148 = MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count.klass.rgctx_data;
			//   if ( !*((_QWORD *)v148[1].rgctxDataDummy + 4) )
			//     (*(void (**)(void))MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count.klass.rgctx_data[1].rgctxDataDummy)();
			//   v214 = 0;
			//   ex = 0LL;
			//   v192 = &v214;
			//   try
			//   {
			//     v149 = v2.fields.m_loadingAssetHandleIndexSet;
			//     if ( !v149 )
			//       sub_1802DC2C8(v148, v147);
			//     v150 = MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count;
			//     m_list = v149.fields.m_list;
			//     if ( !m_list )
			//       sub_1802DC2C8(v148, MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count);
			//     v152 = MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count.klass.rgctx_data;
			//     if ( !*((_QWORD *)v152[1].rgctxDataDummy + 4) )
			//       (*(void (**)(void))MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count.klass.rgctx_data[1].rgctxDataDummy)();
			//     size = m_list.fields._size;
			//     while ( 1 )
			//     {
			//       v189[0] = --size;
			//       if ( size < 0 )
			//         break;
			//       v154 = v2.fields.m_loadingAssetHandleIndexSet;
			//       if ( !v154 )
			//         sub_1802DC2C8(v152, v150);
			//       v155 = MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Item;
			//       v156 = v154.fields.m_list;
			//       if ( !v156 )
			//         sub_1802DC2C8(v152, MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Item);
			//       v157 = MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Item.klass.rgctx_data;
			//       if ( !*((_QWORD *)v157[9].rgctxDataDummy + 4) )
			//         (*(void (**)(void))MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Item.klass.rgctx_data[9].rgctxDataDummy)();
			//       if ( (unsigned int)size >= v156.fields._size )
			//         System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//       items = v156.fields._items;
			//       if ( !items )
			//         sub_1802DC2C8(v157, v155);
			//       if ( (unsigned int)size >= items.max_length.size )
			//         sub_180070260(v157, v155, v144, v145);
			//       index = items.vector[size].index;
			//       v160 = v2.fields.m_assetHandles;
			//       if ( !v160 )
			//         sub_1802DC2C8(0LL, v155);
			//       if ( (unsigned int)index >= v160.max_length.size )
			//         sub_180070260(v160, v155, v144, v145);
			//       v197 = (FAssetProxyUntrackedHandle)v160.vector[index];
			//       if ( Beyond::Resource::FAssetProxyUntrackedHandle::get_isDone(&v197, 0LL) )
			//       {
			//         v161 = v2.fields.m_assetIdentifiers;
			//         if ( !v161 )
			//           sub_1802DC2C8(0LL, v150);
			//         if ( (unsigned int)index >= v161.max_length.size )
			//           sub_180070260(v161, v150, v144, v145);
			//         v162 = v161.vector[index];
			//         v193 = 0LL;
			//         v194 = &v188;
			//         try
			//         {
			//           v164 = Beyond::Resource::FAssetProxyHandle::Get((FAssetProxyHandle *)&v197, 0LL);
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v163);
			//           if ( UnityEngine::Object::op_Equality(v164, 0LL, 0LL) )
			//           {
			//             if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::HGResourceManager, v165);
			//             v201 = v162;
			//             LOBYTE(v166) = 2;
			//             UnityEngine::HyperGryph::HGResourceManager::UpdateAssetHandle((AssetHandleIndex)index, &v201, v166, 0, 0LL);
			//           }
			//           else
			//           {
			//             v167 = Beyond::Resource::FAssetProxyHandle::Get((FAssetProxyHandle *)&v197, 0LL);
			//             if ( !v167 )
			//               sub_1802DC2C8(v169, v168);
			//             InstanceID = UnityEngine::Object::GetInstanceID(v167, 0LL);
			//             if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::HGResourceManager, v170);
			//             v202[0] = v162;
			//             LOBYTE(v172) = 1;
			//             UnityEngine::HyperGryph::HGResourceManager::UpdateAssetHandle(
			//               (AssetHandleIndex)index,
			//               v202,
			//               v172,
			//               InstanceID,
			//               0LL);
			//           }
			//         }
			//         catch ( Il2CppExceptionWrapper *v209 )
			//         {
			//           v173 = v186;
			//           v193 = v209.ex;
			//           if ( v193 )
			//             sub_18000F780(v193);
			//           v2 = this;
			//           size = v189[0];
			//         }
			//         v174 = v2.fields.m_loadingAssetHandleIndexSet;
			//         if ( !v174 )
			//           sub_1802DC2C8(0LL, v173);
			//         Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::RemoveAtSwapBack(
			//           v174,
			//           size,
			//           MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::RemoveAtSwapBack);
			//       }
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v210 )
			//   {
			//     ex = v210.ex;
			//     if ( ex )
			//       sub_18000F780(ex);
			//     if ( v199 )
			//       sub_18000F780(v199);
			//   }
			// }
			// 
		}

		private FAssetProxyHandle[] m_assetHandles;

		private int m_assetHandleCount;

		private AssetIdentifier[] m_assetIdentifiers;

		private IndexedHashSet<AssetHandleIndex> m_loadingAssetHandleIndexSet;

		private ProfilerMarker<int> RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER;

		private ProfilerMarker RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER_LOAD_ASYNC;

		private ProfilerMarker RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER_UpdateAssetHandle;

		private ProfilerMarker<int> RESOURCE_MANAGER_SCRIPT_UPDATE_ASSET_INDEXSET;
	}
}
