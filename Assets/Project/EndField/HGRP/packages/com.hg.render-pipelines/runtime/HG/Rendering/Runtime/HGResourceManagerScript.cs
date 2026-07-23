using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond;
using Beyond.Resource;
using Unity.Profiling;
using UnityEngine.HyperGryph;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGResourceManagerScript // TypeDefIndex: 37916
	{
		// Fields
		private FAssetProxyHandle[] m_assetHandles; // 0x10
		private int m_assetHandleCount; // 0x18
		private AssetIdentifier[] m_assetIdentifiers; // 0x20
		private IndexedHashSet<AssetHandleIndex> m_loadingAssetHandleIndexSet; // 0x28
		private ProfilerMarker<int> RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER; // 0x30
		private ProfilerMarker RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER_LOAD_ASYNC; // 0x38
		private ProfilerMarker RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER_UpdateAssetHandle; // 0x40
		private ProfilerMarker<int> RESOURCE_MANAGER_SCRIPT_UPDATE_ASSET_INDEXSET; // 0x48
	
		// Properties
		public int loadingAssetCount { get => default; } // 0x0000000189B59130-0x0000000189B59190 
		// Int32 get_loadingAssetCount()
		int32_t HG::Rendering::Runtime::HGResourceManagerScript::get_loadingAssetCount(
		        HGResourceManagerScript *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *m_loadingAssetHandleIndexSet; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2346, 0LL) )
		  {
		    m_loadingAssetHandleIndexSet = this->fields.m_loadingAssetHandleIndexSet;
		    if ( m_loadingAssetHandleIndexSet )
		      return Beyond::UniqueList<System::Object>::get_length(
		               (UniqueList_1_System_Object_ *)m_loadingAssetHandleIndexSet,
		               MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count);
		LABEL_5:
		    sub_1800D8260(m_loadingAssetHandleIndexSet, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2346, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public HGResourceManagerScript() {} // 0x0000000182ED76A0-0x0000000182ED79E0
		// HGResourceManagerScript()
		void HG::Rendering::Runtime::HGResourceManagerScript::HGResourceManagerScript(
		        HGResourceManagerScript *this,
		        MethodInfo *method)
		{
		  struct HGResourceManager__Class *v3; // rax
		  Delegate *getFileHashMappingCallback; // rsi
		  HGResourceManager_GetFileHashMappingCallback *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Delegate *v8; // rdi
		  HGResourceManager_GetFileHashMappingCallback *v9; // rax
		  Int32__Array **v10; // r9
		  HGRenderPathBase_HGRenderPathResources *v11; // rdx
		  Delegate *getFilePathMappingCallback; // rsi
		  HGResourceManager_GetFilePathMappingCallback *v13; // rax
		  Delegate *v14; // rdi
		  HGResourceManager_GetFilePathMappingCallback *v15; // rax
		  Int32__Array **v16; // r9
		  HGRenderPathBase_HGRenderPathResources *v17; // rdx
		  Delegate *getWaterSectorTextureCallback; // rsi
		  HGResourceManager_GetTextureFromHGWaterSectorDataCallback *v19; // rax
		  Delegate *v20; // rdi
		  HGResourceManager_GetTextureFromHGWaterSectorDataCallback *v21; // rax
		  PassConstructorID__Enum__Array *v22; // r8
		  Int32__Array **v23; // r9
		  HGRenderPathBase_HGRenderPathResources *v24; // rdx
		  HGRenderPathBase_HGRenderPathResources *v25; // rdx
		  PassConstructorID__Enum__Array *v26; // r8
		  Int32__Array **v27; // r9
		  HGRenderPathBase_HGRenderPathResources *v28; // rdx
		  PassConstructorID__Enum__Array *v29; // r8
		  Int32__Array **v30; // r9
		  IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v31; // rax
		  IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v32; // rdi
		  HGRenderPathBase_HGRenderPathResources *v33; // rdx
		  PassConstructorID__Enum__Array *v34; // r8
		  Int32__Array **v35; // r9
		  MethodInfo *methoda; // [rsp+20h] [rbp-18h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-18h]
		  MethodInfo *methodc; // [rsp+20h] [rbp-18h]
		  MethodInfo *methodd; // [rsp+20h] [rbp-18h]
		  MethodInfo *methode; // [rsp+20h] [rbp-18h]
		  MethodInfo *v41; // [rsp+28h] [rbp-10h]
		  MethodInfo *v42; // [rsp+28h] [rbp-10h]
		  MethodInfo *v43; // [rsp+28h] [rbp-10h]
		  MethodInfo *v44; // [rsp+28h] [rbp-10h]
		  MethodInfo *v45; // [rsp+28h] [rbp-10h]
		  MethodInfo *v46; // [rsp+60h] [rbp+28h]
		  MethodInfo *v47; // [rsp+68h] [rbp+30h]
		
		  this->fields.RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER = 0;
		  this->fields.RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER_LOAD_ASYNC.m_Ptr = Unity::Profiling::LowLevel::Unsafe::ProfilerUnsafeUtility::CreateMarker(
		                                                                          (String *)"HGResourceManagerScript.ResourceManager.LoadAsync.",
		                                                                          1u,
		                                                                          MarkerFlags__Enum_Default,
		                                                                          0,
		                                                                          0LL);
		  this->fields.RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER_UpdateAssetHandle.m_Ptr = Unity::Profiling::LowLevel::Unsafe::ProfilerUnsafeUtility::CreateMarker(
		                                                                                 (String *)"HGResourceManagerScript.Resou"
		                                                                                           "rceManager.UpdateAssetHandle",
		                                                                                 1u,
		                                                                                 MarkerFlags__Enum_Default,
		                                                                                 0,
		                                                                                 0LL);
		  this->fields.RESOURCE_MANAGER_SCRIPT_UPDATE_ASSET_INDEXSET = 0;
		  v3 = TypeInfo::UnityEngine::HyperGryph::HGResourceManager;
		  if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::HGResourceManager);
		    v3 = TypeInfo::UnityEngine::HyperGryph::HGResourceManager;
		  }
		  getFileHashMappingCallback = (Delegate *)v3->static_fields->getFileHashMappingCallback;
		  v5 = (HGResourceManager_GetFileHashMappingCallback *)sub_1800368D0(TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback);
		  v8 = (Delegate *)v5;
		  if ( !v5 )
		    goto LABEL_4;
		  UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback::GetFileHashMappingCallback(
		    v5,
		    0LL,
		    MethodInfo::Beyond::VFS::VirtualFileSystem::TryGetFilePathMappingCallback,
		    0LL);
		  v9 = (HGResourceManager_GetFileHashMappingCallback *)System::Delegate::Combine(getFileHashMappingCallback, v8, 0LL);
		  v11 = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback;
		  if ( v9 )
		  {
		    if ( v9->klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback )
		      sub_18031E1F4(v9, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback);
		    TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getFileHashMappingCallback = v9;
		    v11 = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback;
		    if ( v9->klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback )
		      sub_18031E1F4(v9, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback);
		  }
		  else
		  {
		    TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getFileHashMappingCallback = 0LL;
		  }
		  sub_18002D1B0(
		    (HGRenderPathScene *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields,
		    v11,
		    (PassConstructorID__Enum__Array *)v9,
		    v10,
		    methoda,
		    v41);
		  getFilePathMappingCallback = (Delegate *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getFilePathMappingCallback;
		  v13 = (HGResourceManager_GetFilePathMappingCallback *)sub_1800368D0(TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback);
		  v14 = (Delegate *)v13;
		  if ( !v13 )
		    goto LABEL_4;
		  UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback::GetFilePathMappingCallback(
		    v13,
		    0LL,
		    MethodInfo::Beyond::VFS::VirtualFileSystem::TryGetFilePathMappingCallback,
		    0LL);
		  v15 = (HGResourceManager_GetFilePathMappingCallback *)System::Delegate::Combine(getFilePathMappingCallback, v14, 0LL);
		  v17 = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback;
		  if ( v15 )
		  {
		    if ( v15->klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback )
		      sub_18031E1F4(v15, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback);
		    TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getFilePathMappingCallback = v15;
		    v17 = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback;
		    if ( v15->klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback )
		      sub_18031E1F4(v15, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback);
		  }
		  else
		  {
		    TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getFilePathMappingCallback = 0LL;
		  }
		  sub_18002D1B0(
		    (HGRenderPathScene *)&TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getFilePathMappingCallback,
		    v17,
		    (PassConstructorID__Enum__Array *)v15,
		    v16,
		    methodb,
		    v42);
		  getWaterSectorTextureCallback = (Delegate *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getWaterSectorTextureCallback;
		  v19 = (HGResourceManager_GetTextureFromHGWaterSectorDataCallback *)sub_1800368D0(TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback);
		  v20 = (Delegate *)v19;
		  if ( !v19 )
		    goto LABEL_4;
		  UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback::GetTextureFromHGWaterSectorDataCallback(
		    v19,
		    0LL,
		    MethodInfo::HG::Rendering::Runtime::HGWaterSectorData::GetWaterSectorTextureFromScriptableObject,
		    0LL);
		  v21 = (HGResourceManager_GetTextureFromHGWaterSectorDataCallback *)System::Delegate::Combine(
		                                                                       getWaterSectorTextureCallback,
		                                                                       v20,
		                                                                       0LL);
		  v24 = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback;
		  if ( v21 )
		  {
		    if ( v21->klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback )
		      sub_18031E1F4(v21, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback);
		    TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getWaterSectorTextureCallback = v21;
		    v24 = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback;
		    if ( v21->klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback )
		      sub_18031E1F4(v21, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback);
		  }
		  else
		  {
		    TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getWaterSectorTextureCallback = 0LL;
		  }
		  sub_18002D1B0(
		    (HGRenderPathScene *)&TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getWaterSectorTextureCallback,
		    v24,
		    v22,
		    v23,
		    methodc,
		    v43);
		  UnityEngine::HyperGryph::HGResourceManager::Reset(0LL);
		  this->fields.m_assetHandles = (FAssetProxyHandle__Array *)il2cpp_array_new_specific_1(
		                                                              TypeInfo::Beyond::Resource::FAssetProxyHandle,
		                                                              1024LL);
		  sub_18002D1B0((HGRenderPathScene *)&this->fields, v25, v26, v27, methodd, v44);
		  this->fields.m_assetHandleCount = 0;
		  this->fields.m_assetIdentifiers = (AssetIdentifier__Array *)il2cpp_array_new_specific_1(
		                                                                TypeInfo::UnityEngine::HyperGryph::AssetIdentifier,
		                                                                1024LL);
		  sub_18002D1B0((HGRenderPathScene *)&this->fields.m_assetIdentifiers, v28, v29, v30, methode, v45);
		  v31 = (IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *)sub_1800368D0(TypeInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>);
		  v32 = v31;
		  if ( !v31 )
		LABEL_4:
		    sub_1800D8260(v7, v6);
		  Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::IndexedHashSet(
		    v31,
		    MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::IndexedHashSet);
		  this->fields.m_loadingAssetHandleIndexSet = v32;
		  sub_18002D1B0((HGRenderPathScene *)&this->fields.m_loadingAssetHandleIndexSet, v33, v34, v35, v46, v47);
		}
		
	
		// Methods
		public void Dispose() {} // 0x0000000189B58294-0x0000000189B585A0
		// Void Dispose()
		void HG::Rendering::Runtime::HGResourceManagerScript::Dispose(HGResourceManagerScript *this, MethodInfo *method)
		{
		  Delegate *getFileHashMappingCallback; // rsi
		  HGResourceManager_GetFileHashMappingCallback *v4; // rax
		  HGRenderPathBase_HGRenderPathResources *v5; // rdx
		  __int64 v6; // rcx
		  Delegate *v7; // rdi
		  PassConstructorID__Enum__Array *v8; // rax
		  Int32__Array **v9; // r9
		  HGResourceManager_GetFileHashMappingCallback *v10; // rdx
		  Delegate *getFilePathMappingCallback; // rsi
		  HGResourceManager_GetFilePathMappingCallback *v12; // rax
		  Delegate *v13; // rdi
		  PassConstructorID__Enum__Array *v14; // rax
		  Int32__Array **v15; // r9
		  HGResourceManager_GetFilePathMappingCallback *v16; // rdx
		  Delegate *getWaterSectorTextureCallback; // rsi
		  HGResourceManager_GetTextureFromHGWaterSectorDataCallback *v18; // rax
		  Delegate *v19; // rdi
		  PassConstructorID__Enum__Array *v20; // rax
		  Int32__Array **v21; // r9
		  HGResourceManager_GetTextureFromHGWaterSectorDataCallback *v22; // rdx
		  PassConstructorID__Enum__Array *v23; // r8
		  Int32__Array **v24; // r9
		  FAssetProxyHandle__Array *m_assetHandles; // rsi
		  int32_t v26; // edi
		  HGRenderPathBase_HGRenderPathResources *v27; // rdx
		  PassConstructorID__Enum__Array *v28; // r8
		  Int32__Array **v29; // r9
		  HGRenderPathBase_HGRenderPathResources *v30; // rdx
		  PassConstructorID__Enum__Array *v31; // r8
		  Int32__Array **v32; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  FAssetProxyHandle v34; // [rsp+20h] [rbp-38h] BYREF
		  FAssetProxyHandle v35; // [rsp+38h] [rbp-20h] BYREF
		
		  memset(&v34, 0, sizeof(v34));
		  if ( IFix::WrappersManagerImpl::IsPatched(2276, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2276, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_34:
		    sub_1800D8260(v6, v5);
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::HyperGryph::HGResourceManager);
		  getFileHashMappingCallback = (Delegate *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getFileHashMappingCallback;
		  v4 = (HGResourceManager_GetFileHashMappingCallback *)sub_18002C620(TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback);
		  v7 = (Delegate *)v4;
		  if ( !v4 )
		    goto LABEL_34;
		  UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback::GetFileHashMappingCallback(
		    v4,
		    0LL,
		    MethodInfo::Beyond::VFS::VirtualFileSystem::TryGetFilePathMappingCallback,
		    0LL);
		  v8 = (PassConstructorID__Enum__Array *)System::Delegate::Remove(getFileHashMappingCallback, v7, 0LL);
		  if ( v8 )
		  {
		    if ( (struct HGResourceManager_GetFileHashMappingCallback__Class *)v8->klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback )
		      sub_18031E1F4(v8, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback);
		    v10 = (HGResourceManager_GetFileHashMappingCallback *)v8;
		  }
		  else
		  {
		    v10 = 0LL;
		  }
		  TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getFileHashMappingCallback = v10;
		  if ( v8
		    && (struct HGResourceManager_GetFileHashMappingCallback__Class *)v8->klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback )
		  {
		    sub_18031E1F4(v8, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback);
		  }
		  sub_18002D1B0(
		    (HGRenderPathScene *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields,
		    (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFileHashMappingCallback,
		    v8,
		    v9,
		    *(MethodInfo **)&v34.m_untrackedHandle.m_handleObjectID,
		    *(MethodInfo **)&v34.m_untrackedHandle.m_assetProxyObj.m_handleID);
		  getFilePathMappingCallback = (Delegate *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getFilePathMappingCallback;
		  v12 = (HGResourceManager_GetFilePathMappingCallback *)sub_18002C620(TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback);
		  v13 = (Delegate *)v12;
		  if ( !v12 )
		    goto LABEL_34;
		  UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback::GetFilePathMappingCallback(
		    v12,
		    0LL,
		    MethodInfo::Beyond::VFS::VirtualFileSystem::TryGetFilePathMappingCallback,
		    0LL);
		  v14 = (PassConstructorID__Enum__Array *)System::Delegate::Remove(getFilePathMappingCallback, v13, 0LL);
		  if ( v14 )
		  {
		    if ( (struct HGResourceManager_GetFilePathMappingCallback__Class *)v14->klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback )
		      sub_18031E1F4(v14, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback);
		    v16 = (HGResourceManager_GetFilePathMappingCallback *)v14;
		  }
		  else
		  {
		    v16 = 0LL;
		  }
		  TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getFilePathMappingCallback = v16;
		  if ( v14
		    && (struct HGResourceManager_GetFilePathMappingCallback__Class *)v14->klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback )
		  {
		    sub_18031E1F4(v14, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback);
		  }
		  sub_18002D1B0(
		    (HGRenderPathScene *)&TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getFilePathMappingCallback,
		    (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetFilePathMappingCallback,
		    v14,
		    v15,
		    *(MethodInfo **)&v34.m_untrackedHandle.m_handleObjectID,
		    *(MethodInfo **)&v34.m_untrackedHandle.m_assetProxyObj.m_handleID);
		  getWaterSectorTextureCallback = (Delegate *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getWaterSectorTextureCallback;
		  v18 = (HGResourceManager_GetTextureFromHGWaterSectorDataCallback *)sub_18002C620(TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback);
		  v19 = (Delegate *)v18;
		  if ( !v18 )
		    goto LABEL_34;
		  UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback::GetTextureFromHGWaterSectorDataCallback(
		    v18,
		    0LL,
		    MethodInfo::HG::Rendering::Runtime::HGWaterSectorData::GetWaterSectorTextureFromScriptableObject,
		    0LL);
		  v20 = (PassConstructorID__Enum__Array *)System::Delegate::Remove(getWaterSectorTextureCallback, v19, 0LL);
		  if ( v20 )
		  {
		    if ( (struct HGResourceManager_GetTextureFromHGWaterSectorDataCallback__Class *)v20->klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback )
		      sub_18031E1F4(v20, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback);
		    v22 = (HGResourceManager_GetTextureFromHGWaterSectorDataCallback *)v20;
		  }
		  else
		  {
		    v22 = 0LL;
		  }
		  TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getWaterSectorTextureCallback = v22;
		  if ( v20
		    && (struct HGResourceManager_GetTextureFromHGWaterSectorDataCallback__Class *)v20->klass != TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback )
		  {
		    sub_18031E1F4(v20, TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback);
		  }
		  sub_18002D1B0(
		    (HGRenderPathScene *)&TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields->getWaterSectorTextureCallback,
		    (HGRenderPathBase_HGRenderPathResources *)TypeInfo::UnityEngine::HyperGryph::HGResourceManager::GetTextureFromHGWaterSectorDataCallback,
		    v20,
		    v21,
		    *(MethodInfo **)&v34.m_untrackedHandle.m_handleObjectID,
		    *(MethodInfo **)&v34.m_untrackedHandle.m_assetProxyObj.m_handleID);
		  m_assetHandles = this->fields.m_assetHandles;
		  v26 = 0;
		  if ( !m_assetHandles )
		    goto LABEL_34;
		  while ( v26 < m_assetHandles->max_length.size )
		  {
		    sub_1800035F0(m_assetHandles, &v35, v26);
		    v34 = v35;
		    Beyond::Resource::FAssetProxyHandle::Dispose(&v34, 0LL);
		    ++v26;
		  }
		  this->fields.m_assetHandles = 0LL;
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this->fields,
		    v5,
		    v23,
		    v24,
		    *(MethodInfo **)&v34.m_untrackedHandle.m_handleObjectID,
		    *(MethodInfo **)&v34.m_untrackedHandle.m_assetProxyObj.m_handleID);
		  this->fields.m_assetHandleCount = 0;
		  this->fields.m_assetIdentifiers = 0LL;
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this->fields.m_assetIdentifiers,
		    v27,
		    v28,
		    v29,
		    *(MethodInfo **)&v34.m_untrackedHandle.m_handleObjectID,
		    *(MethodInfo **)&v34.m_untrackedHandle.m_assetProxyObj.m_handleID);
		  this->fields.m_loadingAssetHandleIndexSet = 0LL;
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this->fields.m_loadingAssetHandleIndexSet,
		    v30,
		    v31,
		    v32,
		    *(MethodInfo **)&v34.m_untrackedHandle.m_handleObjectID,
		    *(MethodInfo **)&v34.m_untrackedHandle.m_assetProxyObj.m_handleID);
		}
		
		public void GameplayUpdate() {} // 0x0000000182EF7EB0-0x0000000182EF95D0
		// Void GameplayUpdate()
		// Hidden C++ exception states: #wind=5 #try_helpers=1
		void HG::Rendering::Runtime::HGResourceManagerScript::GameplayUpdate(HGResourceManagerScript *this, MethodInfo *method)
		{
		  HGResourceManagerScript *v2; // r15
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v5; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Object *instance; // rdi
		  struct ILFixDynamicMethodWrapper_3__Class *v12; // rcx
		  ILFixDynamicMethodWrapper_3__Array *v13; // rbx
		  ILFixDynamicMethodWrapper_3__Array *v14; // rbx
		  ILFixDynamicMethodWrapper_3 *v15; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  bool v18; // bl
		  void (__fastcall *v19)(bool); // rax
		  __int64 *v20; // rdx
		  unsigned __int64 v21; // r8
		  __int128 v22; // xmm6
		  Il2CppClass *klass; // rcx
		  int v24; // ebx
		  __int64 v25; // rdi
		  Il2CppClass *v26; // rax
		  const Il2CppRGCTXData *rgctx_data; // rax
		  __int64 v28; // r12
		  __m128i v29; // xmm6
		  __int64 v30; // r14
		  FAssetProxyHandle__Array *v31; // rcx
		  unsigned __int64 v32; // rdx
		  unsigned __int64 v33; // r8
		  __int64 v34; // rdx
		  __int64 v35; // r8
		  __int64 v36; // rbx
		  void (__fastcall __noreturn **v37)(); // rax
		  unsigned int v38; // eax
		  __int64 v39; // rax
		  unsigned int *v40; // rdx
		  signed __int64 v41; // r9
		  unsigned int v42; // r8d
		  signed __int64 v43; // rtt
		  __int64 v44; // rbx
		  __int64 v45; // rax
		  __int64 v46; // rbx
		  _QWORD **v47; // rax
		  __int64 v48; // rax
		  struct ILFixDynamicMethodWrapper_3__Class *v49; // rax
		  ILFixDynamicMethodWrapper_3__Array *v50; // rcx
		  ILFixDynamicMethodWrapper_3 *v51; // rcx
		  FAssetProxyHandle__Array *v52; // rcx
		  __int64 v53; // rax
		  __int64 v54; // rdx
		  IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v55; // r14
		  struct MethodInfo *v56; // rbx
		  const Il2CppRGCTXData *v57; // rcx
		  Il2CppRGCTXData v58; // rbx
		  Dictionary_2_UnityEngine_HyperGryph_AssetHandleIndex_System_Int32_ *m_indexDict; // rsi
		  __int64 v60; // rdi
		  int32_t Entry; // eax
		  Dictionary_2_TKey_TValue_Entry_UnityEngine_HyperGryph_AssetHandleIndex_System_Int32___Array *entries; // rcx
		  int32_t value; // edi
		  AssetIdentifier__Array *v64; // rcx
		  __int64 v65; // rdi
		  bool v66; // si
		  __int64 v67; // rbx
		  void (__fastcall __noreturn **v68)(); // rax
		  unsigned int v69; // eax
		  __int64 v70; // rax
		  unsigned int *v71; // rdx
		  signed __int64 v72; // r9
		  unsigned int v73; // r8d
		  __int64 v74; // rtt
		  __int64 v75; // rbx
		  __int64 v76; // rax
		  __int64 v77; // rbx
		  _QWORD **v78; // rax
		  __int64 v79; // r8
		  __int64 v80; // rax
		  HGResourceManager__StaticFields *static_fields; // rcx
		  Type__Array *kAssetTypeToUnityType; // rax
		  Type *v83; // rbx
		  StringPathHash v84; // xmm6_8
		  __int64 *v85; // rdx
		  __int64 v86; // rcx
		  FAssetProxyHandle__Array *m_assetHandles; // rax
		  HGResourceManagerScript__Fields *p_fields; // rbx
		  struct MethodInfo *v89; // r14
		  int32_t v90; // esi
		  int32_t length; // edi
		  const Il2CppRGCTXData *v92; // rax
		  Il2CppRGCTXData v93; // rsi
		  FAssetProxyHandle__Array *v94; // r14
		  __int64 v95; // rax
		  Array *v96; // rax
		  Array *v97; // rsi
		  unsigned int v98; // ebx
		  char v99; // bl
		  __int64 v100; // rtt
		  __int64 v101; // rax
		  unsigned int v102; // ebx
		  char v103; // bl
		  __int64 v104; // rtt
		  _BYTE *rgctxDataDummy; // rax
		  unsigned int v106; // ebx
		  char v107; // bl
		  __int64 v108; // rtt
		  unsigned __int64 p_m_assetIdentifiers; // rbx
		  struct MethodInfo *v110; // r14
		  int32_t v111; // esi
		  int32_t v112; // edi
		  const Il2CppRGCTXData *v113; // rax
		  Il2CppRGCTXData v114; // rsi
		  __int64 v115; // r14
		  __int64 v116; // rax
		  Array *v117; // rax
		  Array *v118; // rsi
		  unsigned int v119; // ebx
		  __int64 *v120; // rdx
		  char v121; // bl
		  __int64 v122; // rtt
		  __int64 v123; // rax
		  unsigned int v124; // ebx
		  __int64 *v125; // rdx
		  char v126; // bl
		  __int64 v127; // rtt
		  _BYTE *v128; // rax
		  unsigned int v129; // ebx
		  __int64 *v130; // rdx
		  char v131; // bl
		  __int64 v132; // rtt
		  __int64 v133; // rdx
		  __int64 v134; // r8
		  AssetState__Enum v135; // r8d
		  AssetIdentifier v136; // xmm6
		  FAssetProxyHandle__Array *v137; // rcx
		  IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *m_loadingAssetHandleIndexSet; // rcx
		  struct HGResourceManager__Class *v139; // rcx
		  void (__fastcall *v140)(int32_t *, AssetIdentifier *, _QWORD, _QWORD); // rax
		  AssetIdentifier__Array *m_assetIdentifiers; // rcx
		  void (*v142)(void); // rax
		  __int64 v143; // rdx
		  __int64 v144; // rcx
		  __int64 v145; // r8
		  IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v146; // rax
		  struct MethodInfo *v147; // rdx
		  const Il2CppRGCTXData *v148; // rcx
		  IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v149; // rax
		  struct MethodInfo *v150; // rdx
		  List_1_UnityEngine_HyperGryph_AssetHandleIndex_ *m_list; // rbx
		  const Il2CppRGCTXData *v152; // rcx
		  int32_t size; // edi
		  IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v154; // rbx
		  struct MethodInfo *v155; // rdx
		  List_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v156; // rbx
		  const Il2CppRGCTXData *v157; // rcx
		  AssetHandleIndex__Array *items; // rbx
		  __int64 index; // rbx
		  FAssetProxyHandle__Array *v160; // rcx
		  AssetIdentifier__Array *v161; // rcx
		  AssetIdentifier v162; // xmm6
		  Object_1 *v163; // rsi
		  AssetState__Enum v164; // r8d
		  struct Object_1__Class *v165; // rcx
		  Object_1 *v166; // rax
		  __int64 v167; // rdx
		  __int64 v168; // rcx
		  int32_t InstanceID; // esi
		  AssetState__Enum v170; // r8d
		  _BYTE *v171; // rdx
		  IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v172; // rcx
		  __int64 v173; // rax
		  __int64 v174; // rax
		  ArgumentOutOfRangeException *v175; // rbx
		  String *v176; // rdi
		  String *v177; // rax
		  __int64 v178; // rax
		  ArgumentOutOfRangeException *v179; // rbx
		  String *v180; // rdi
		  String *v181; // rax
		  __int64 v182; // rax
		  __int64 v183; // rax
		  _BYTE v184[32]; // [rsp+0h] [rbp-228h] BYREF
		  char v185; // [rsp+30h] [rbp-1F8h] BYREF
		  char v186; // [rsp+31h] [rbp-1F7h] BYREF
		  int32_t v187[4]; // [rsp+38h] [rbp-1F0h] BYREF
		  Il2CppException *ex; // [rsp+48h] [rbp-1E0h]
		  char *v189; // [rsp+50h] [rbp-1D8h]
		  Il2CppException *v190; // [rsp+58h] [rbp-1D0h]
		  char *v191; // [rsp+60h] [rbp-1C8h]
		  FAssetProxyHandle v192; // [rsp+68h] [rbp-1C0h] BYREF
		  int v193; // [rsp+80h] [rbp-1A8h]
		  FAssetProxyHandle P0; // [rsp+88h] [rbp-1A0h] BYREF
		  _OWORD v195[3]; // [rsp+A0h] [rbp-188h] BYREF
		  FAssetProxyHandle v196; // [rsp+D0h] [rbp-158h] BYREF
		  __int64 v197; // [rsp+E8h] [rbp-140h]
		  char *v198; // [rsp+F0h] [rbp-138h]
		  AssetIdentifier v199; // [rsp+100h] [rbp-128h] BYREF
		  AssetIdentifier v200[2]; // [rsp+110h] [rbp-118h] BYREF
		  __m256i v201; // [rsp+130h] [rbp-F8h] BYREF
		  _BYTE v202[24]; // [rsp+150h] [rbp-D8h]
		  int v203; // [rsp+168h] [rbp-C0h] BYREF
		  int v204; // [rsp+178h] [rbp-B0h] BYREF
		  Il2CppExceptionWrapper *v205; // [rsp+188h] [rbp-A0h] BYREF
		  Il2CppExceptionWrapper *v206; // [rsp+190h] [rbp-98h] BYREF
		  Il2CppExceptionWrapper *v207; // [rsp+198h] [rbp-90h] BYREF
		  Il2CppExceptionWrapper *v208; // [rsp+1A0h] [rbp-88h] BYREF
		  __int64 v209; // [rsp+1C0h] [rbp-68h]
		  FAssetProxyHandle v210; // [rsp+1C8h] [rbp-60h] BYREF
		  char v212; // [rsp+240h] [rbp+18h] BYREF
		  char v213; // [rsp+248h] [rbp+20h] BYREF
		
		  v2 = this;
		  memset(v195, 0, sizeof(v195));
		  memset(&v192, 0, sizeof(v192));
		  v185 = 0;
		  memset(&P0, 0, sizeof(P0));
		  v212 = 0;
		  v186 = 0;
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v3, method);
		  if ( wrapperArray->max_length.size > 2297 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = v3->static_fields->wrapperArray;
		    if ( !v5 )
		      sub_1800D8260(v3, method);
		    if ( v5->max_length.size <= 0x8F9u )
		      sub_1800D2AB0(v3, method);
		    if ( v5[63].vector[29] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2297, 0LL);
		      if ( !Patch )
		        sub_1800D8260(v8, v7);
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		      return;
		    }
		  }
		  instance = Beyond::SingletonScriptableObject<System::Object>::get_instance(MethodInfo::Beyond::SingletonScriptableObject<Beyond::Resource::ResourceOptions>::get_instance);
		  if ( !instance )
		    sub_1800D8260(v10, v9);
		  v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v13 = v12->static_fields->wrapperArray;
		  if ( !v13 )
		    sub_1800D8260(v12, v9);
		  if ( v13->max_length.size <= 1853 )
		    goto LABEL_24;
		  if ( !v12->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v12);
		    v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v14 = v12->static_fields->wrapperArray;
		  if ( !v14 )
		    sub_1800D8260(v12, v9);
		  if ( v14->max_length.size <= 0x73Du )
		    sub_1800D2AB0(v12, v9);
		  if ( v14[51].vector[17] )
		  {
		    v15 = IFix::WrappersManagerImpl::GetPatch(1853, 0LL);
		    if ( !v15 )
		      sub_1800D8260(v17, v16);
		    v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v15, instance, 0LL);
		  }
		  else
		  {
		LABEL_24:
		    v18 = 1;
		  }
		  if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::HGResourceManager);
		  v19 = (void (__fastcall *)(bool))qword_18F370970;
		  if ( !qword_18F370970 )
		  {
		    v19 = (void (__fastcall *)(bool))il2cpp_resolve_icall_1("UnityEngine.HyperGryph.HGResourceManager::set_usingVFS(System.Boolean)");
		    if ( !v19 )
		    {
		      v173 = sub_1802EE1B8("UnityEngine.HyperGryph.HGResourceManager::set_usingVFS(System.Boolean)");
		      sub_18007E1B0(v173, 0LL);
		    }
		    qword_18F370970 = (__int64)v19;
		  }
		  v19(v18);
		  v22 = *(_OWORD *)sub_183CCA730(&v196);
		  v213 = 0;
		  v197 = 0LL;
		  v198 = &v213;
		  memset((char *)v201.m256i_i64 + 4, 0, 28);
		  klass = MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::AssetOperation>::GetEnumerator->klass;
		  if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(klass, v20);
		  v201.m256i_i32[0] = -1;
		  memset(&v201.m256i_u64[1], 0, 24);
		  v195[0] = v22;
		  v195[1] = *(_OWORD *)v201.m256i_i8;
		  v195[2] = 0uLL;
		  v190 = 0LL;
		  v191 = (char *)v195;
		  try
		  {
		    while ( 1 )
		    {
		      v24 = LODWORD(v195[1]) + 1;
		      LODWORD(v195[1]) = v24;
		      if ( v24 >= SDWORD2(v195[0]) )
		        break;
		      v25 = *(_QWORD *)&v195[0];
		      v26 = MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::HyperGryph::AssetOperation>::MoveNext->klass;
		      if ( ((__int64)v26->vtable[0].methodPtr & 1) == 0 )
		        sub_1800360B0(v26, v20);
		      rgctx_data = v26->rgctx_data;
		      if ( !*((_QWORD *)rgctx_data->rgctxDataDummy + 7) )
		        sub_1800430B0(rgctx_data->rgctxDataDummy);
		      *(_OWORD *)((char *)&v195[1] + 8) = *(_OWORD *)(v25 + 24LL * v24);
		      *((_QWORD *)&v195[2] + 1) = *(_QWORD *)(v25 + 24LL * v24 + 16);
		      *(_OWORD *)v202 = *(_OWORD *)(v25 + 24LL * v24);
		      *(_QWORD *)&v202[16] = *(_QWORD *)(v25 + 24LL * v24 + 16);
		      v28 = HIDWORD(*(_QWORD *)v202);
		      v193 = *(_DWORD *)&v202[4];
		      v29 = *(__m128i *)v202;
		      v209 = *(_QWORD *)&v202[16];
		      v30 = *(_QWORD *)(v25 + 24LL * v24) >> 16;
		      if ( *(_BYTE *)(v25 + 24LL * v24) )
		      {
		        v65 = (int)v209;
		        v66 = (unsigned int)(v209 - 7) <= 1;
		        if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::HGResourceManager);
		        if ( !byte_18F369421 )
		        {
		          v21 = _InterlockedExchangeAdd64(
		                  (volatile signed __int64 *)&TypeInfo::UnityEngine::HyperGryph::HGResourceManager,
		                  0LL);
		          if ( (v21 & 1) != 0 )
		          {
		            v67 = ((unsigned int)v21 >> 1) & 0xFFFFFFF;
		            switch ( (unsigned int)v21 >> 29 )
		            {
		              case 1u:
		                v68 = (void (__fastcall __noreturn **)())sub_180036020((unsigned int)v67);
		                goto LABEL_130;
		              case 2u:
		                v68 = (void (__fastcall __noreturn **)())sub_1800362C0((unsigned int)v67);
		                goto LABEL_130;
		              case 3u:
		              case 6u:
		                v69 = ((unsigned int)v21 >> 1) & 0xFFFFFFF;
		                v21 = (unsigned int)v21 >> 29;
		                if ( (_DWORD)v21 )
		                {
		                  if ( (_DWORD)v21 == 3 )
		                  {
		                    v68 = (void (__fastcall __noreturn **)())sub_180009A40(v69);
		                    goto LABEL_130;
		                  }
		                  if ( (_DWORD)v21 == 6 )
		                  {
		                    v70 = sub_1802F8800(v69);
		                    v68 = (void (__fastcall __noreturn **)())sub_180026660(v70, 0LL);
		                    goto LABEL_130;
		                  }
		                }
		                else if ( v69 == 1 )
		                {
		                  v68 = off_18B8C2EC0;
		                  goto LABEL_130;
		                }
		LABEL_129:
		                v68 = 0LL;
		LABEL_130:
		                if ( v68 )
		                  _InterlockedExchange64(
		                    (volatile __int64 *)&TypeInfo::UnityEngine::HyperGryph::HGResourceManager,
		                    (__int64)v68);
		                break;
		              case 4u:
		                v68 = (void (__fastcall __noreturn **)())sub_1802F8760((unsigned int)v67);
		                goto LABEL_130;
		              case 5u:
		                if ( *(_QWORD *)(qword_18F371F68 + 8 * v67) )
		                {
		                  v68 = *(void (__fastcall __noreturn ***)())(qword_18F371F68 + 8 * v67);
		                }
		                else
		                {
		                  v71 = (unsigned int *)(qword_18F360DF8 + *(int *)(qword_18F360E00 + 8) + 8 * v67);
		                  v72 = il2cpp_string_new_len(qword_18F360DF8 + (int)v71[1] + *(int *)(qword_18F360E00 + 16), *v71);
		                  v68 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
		                                                             (volatile signed __int64 *)(qword_18F371F68 + 8 * v67),
		                                                             v72,
		                                                             0LL);
		                  if ( !v68 )
		                  {
		                    v21 = qword_18F371F68 + 8 * v67;
		                    if ( dword_18F35FD08 )
		                    {
		                      v73 = (v21 >> 12) & 0x1FFFFF;
		                      v20 = &qword_18F103690[(unsigned __int64)v73 >> 6];
		                      v21 = v73 & 0x3F;
		                      _m_prefetchw(v20);
		                      do
		                        v74 = *v20;
		                      while ( v74 != _InterlockedCompareExchange64(v20, *v20 | (1LL << v21), *v20) );
		                    }
		                    v68 = (void (__fastcall __noreturn **)())v72;
		                  }
		                }
		                goto LABEL_130;
		              case 7u:
		                v75 = sub_1802F8760((unsigned int)v67);
		                v76 = *(_QWORD *)(v75 + 16);
		                v77 = (v75 - *(_QWORD *)(v76 + 128)) >> 5;
		                if ( *(_BYTE *)(v76 + 42) == 21 )
		                {
		                  v78 = *(_QWORD ***)(v76 + 96);
		                  if ( *v78 )
		                  {
		                    v79 = **v78 - (qword_18F360DF8 + *(int *)(qword_18F360E00 + 160));
		                    v76 = sub_180009B10(v79 / 92 + v79);
		                  }
		                  else
		                  {
		                    v76 = 0LL;
		                  }
		                }
		                v204 = v77 + *(_DWORD *)(*(_QWORD *)(v76 + 104) + 32LL);
		                v80 = sub_1801CD744(
		                        (unsigned int)&v204,
		                        (int)qword_18F360DF8 + *(_DWORD *)(qword_18F360E00 + 64),
		                        *(int *)(qword_18F360E00 + 68) / 0xCuLL,
		                        12,
		                        (__int64)sub_1802F7130);
		                if ( !v80 )
		                  goto LABEL_129;
		                v20 = (__int64 *)*(unsigned int *)(v80 + 8);
		                if ( (_DWORD)v20 == -1 )
		                  goto LABEL_129;
		                v68 = (void (__fastcall __noreturn **)())((char *)v20 + qword_18F360DF8 + *(int *)(qword_18F360E00 + 72));
		                goto LABEL_130;
		              default:
		                break;
		            }
		          }
		          byte_18F369421 = 1;
		        }
		        if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::HGResourceManager);
		        static_fields = TypeInfo::UnityEngine::HyperGryph::HGResourceManager->static_fields;
		        kAssetTypeToUnityType = static_fields->kAssetTypeToUnityType;
		        if ( !kAssetTypeToUnityType )
		          sub_1800D8250(static_fields, v20);
		        if ( (unsigned int)v65 >= kAssetTypeToUnityType->max_length.size )
		          sub_1800D2AA0(static_fields, v20, v21);
		        v83 = kAssetTypeToUnityType->vector[v65];
		        if ( !TypeInfo::Beyond::Resource::ResourceManager->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::Beyond::Resource::ResourceManager);
		        v84.hash = _mm_srli_si128(v29, 8).m128i_u64[0];
		        v192 = *Beyond::Resource::ResourceManager::LoadAsync(
		                  &v210,
		                  v84,
		                  v83,
		                  (RootCategory__Enum)v66,
		                  (EResourceRequestPriority__Enum)(unsigned __int16)v30,
		                  0LL);
		        m_assetHandles = v2->fields.m_assetHandles;
		        if ( !m_assetHandles )
		          sub_1800D8250(v86, v85);
		        if ( v28 >= m_assetHandles->max_length.size )
		        {
		          p_fields = &v2->fields;
		          v89 = MethodInfo::UnityEngine::Rendering::ArrayExtensions::Grow<Beyond::Resource::FAssetProxyHandle>;
		          v90 = v28 + 1;
		          if ( !MethodInfo::UnityEngine::Rendering::ArrayExtensions::Grow<Beyond::Resource::FAssetProxyHandle>->rgctx_data )
		            sub_1800430B0(MethodInfo::UnityEngine::Rendering::ArrayExtensions::Grow<Beyond::Resource::FAssetProxyHandle>);
		          if ( p_fields->m_assetHandles )
		            length = p_fields->m_assetHandles->max_length.size;
		          else
		            length = 1;
		          for ( ; length < v90; length *= 2 )
		            ;
		          v92 = v89->rgctx_data;
		          if ( p_fields->m_assetHandles )
		          {
		            v93.rgctxDataDummy = v92[1].rgctxDataDummy;
		            if ( !*((_QWORD *)v93.rgctxDataDummy + 7) )
		              ((void (__fastcall *)(_QWORD))sub_1800430B0)((const Il2CppRGCTXData)v92[1].rgctxDataDummy);
		            if ( length < 0 )
		            {
		              v174 = sub_18007E180(&TypeInfo::System::ArgumentOutOfRangeException);
		              v175 = (ArgumentOutOfRangeException *)sub_1800368D0(v174);
		              sub_180003640(v175);
		              v176 = (String *)sub_18007E180(&off_18E326CE0);
		              v177 = (String *)sub_18007E180(&off_18E2BE450);
		              System::ArgumentOutOfRangeException::ArgumentOutOfRangeException(v175, v177, v176, 0LL);
		              ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_18007E190)(v175, (Il2CppRGCTXData)v93.rgctxDataDummy);
		            }
		            v94 = p_fields->m_assetHandles;
		            if ( p_fields->m_assetHandles )
		            {
		              if ( v94->max_length.size != length )
		              {
		                v95 = **((_QWORD **)v93.rgctxDataDummy + 7);
		                if ( (*(_BYTE *)(v95 + 312) & 1) == 0 )
		                  sub_1800360B0(**((_QWORD **)v93.rgctxDataDummy + 7), v85);
		                v96 = (Array *)il2cpp_array_new_specific_1(v95, (unsigned int)length);
		                v97 = v96;
		                if ( v94->max_length.size <= length )
		                  length = v94->max_length.size;
		                System::Array::Copy((Array *)v94, 0, v96, 0, length, 0LL);
		                p_fields->m_assetHandles = (FAssetProxyHandle__Array *)v97;
		                if ( dword_18F35FD08 )
		                {
		                  v98 = ((unsigned __int64)p_fields >> 12) & 0x1FFFFF;
		                  v85 = &qword_18F103690[(unsigned __int64)v98 >> 6];
		                  v99 = v98 & 0x3F;
		                  _m_prefetchw(v85);
		                  do
		                    v100 = *v85;
		                  while ( v100 != _InterlockedCompareExchange64(v85, *v85 | (1LL << v99), *v85) );
		                }
		              }
		            }
		            else
		            {
		              v101 = **((_QWORD **)v93.rgctxDataDummy + 7);
		              if ( (*(_BYTE *)(v101 + 312) & 1) == 0 )
		                sub_1800360B0(**((_QWORD **)v93.rgctxDataDummy + 7), v85);
		              p_fields->m_assetHandles = (FAssetProxyHandle__Array *)il2cpp_array_new_specific_1(
		                                                                       v101,
		                                                                       (unsigned int)length);
		              if ( dword_18F35FD08 )
		              {
		                v102 = ((unsigned __int64)p_fields >> 12) & 0x1FFFFF;
		                v85 = &qword_18F103690[(unsigned __int64)v102 >> 6];
		                v103 = v102 & 0x3F;
		                _m_prefetchw(v85);
		                do
		                  v104 = *v85;
		                while ( v104 != _InterlockedCompareExchange64(v85, *v85 | (1LL << v103), *v85) );
		              }
		            }
		          }
		          else
		          {
		            rgctxDataDummy = v92->rgctxDataDummy;
		            if ( (rgctxDataDummy[312] & 1) == 0 )
		              sub_1800360B0(rgctxDataDummy, v85);
		            p_fields->m_assetHandles = (FAssetProxyHandle__Array *)il2cpp_array_new_specific_1(
		                                                                     rgctxDataDummy,
		                                                                     (unsigned int)length);
		            if ( dword_18F35FD08 )
		            {
		              v106 = ((unsigned __int64)p_fields >> 12) & 0x1FFFFF;
		              v85 = &qword_18F103690[(unsigned __int64)v106 >> 6];
		              v107 = v106 & 0x3F;
		              _m_prefetchw(v85);
		              do
		                v108 = *v85;
		              while ( v108 != _InterlockedCompareExchange64(v85, *v85 | (1LL << v107), *v85) );
		            }
		          }
		          p_m_assetIdentifiers = (unsigned __int64)&v2->fields.m_assetIdentifiers;
		          v110 = MethodInfo::UnityEngine::Rendering::ArrayExtensions::Grow<UnityEngine::HyperGryph::AssetIdentifier>;
		          v111 = v28 + 1;
		          if ( !MethodInfo::UnityEngine::Rendering::ArrayExtensions::Grow<UnityEngine::HyperGryph::AssetIdentifier>->rgctx_data )
		            sub_1800430B0(MethodInfo::UnityEngine::Rendering::ArrayExtensions::Grow<UnityEngine::HyperGryph::AssetIdentifier>);
		          if ( *(_QWORD *)p_m_assetIdentifiers )
		            v112 = *(_DWORD *)(*(_QWORD *)p_m_assetIdentifiers + 24LL);
		          else
		            v112 = 1;
		          for ( ; v112 < v111; v112 *= 2 )
		            ;
		          v113 = v110->rgctx_data;
		          if ( *(_QWORD *)p_m_assetIdentifiers )
		          {
		            v114.rgctxDataDummy = v113[1].rgctxDataDummy;
		            if ( !*((_QWORD *)v114.rgctxDataDummy + 7) )
		              ((void (__fastcall *)(_QWORD))sub_1800430B0)((const Il2CppRGCTXData)v113[1].rgctxDataDummy);
		            if ( v112 < 0 )
		            {
		              v178 = sub_18007E180(&TypeInfo::System::ArgumentOutOfRangeException);
		              v179 = (ArgumentOutOfRangeException *)sub_1800368D0(v178);
		              sub_180003640(v179);
		              v180 = (String *)sub_18007E180(&off_18E326CE0);
		              v181 = (String *)sub_18007E180(&off_18E2BE450);
		              System::ArgumentOutOfRangeException::ArgumentOutOfRangeException(v179, v181, v180, 0LL);
		              ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_18007E190)(
		                v179,
		                (Il2CppRGCTXData)v114.rgctxDataDummy);
		            }
		            v115 = *(_QWORD *)p_m_assetIdentifiers;
		            if ( *(_QWORD *)p_m_assetIdentifiers )
		            {
		              if ( *(_DWORD *)(v115 + 24) != v112 )
		              {
		                v116 = **((_QWORD **)v114.rgctxDataDummy + 7);
		                if ( (*(_BYTE *)(v116 + 312) & 1) == 0 )
		                  sub_1800360B0(**((_QWORD **)v114.rgctxDataDummy + 7), v85);
		                v117 = (Array *)il2cpp_array_new_specific_1(v116, (unsigned int)v112);
		                v118 = v117;
		                if ( *(_DWORD *)(v115 + 24) <= v112 )
		                  v112 = *(_DWORD *)(v115 + 24);
		                System::Array::Copy((Array *)v115, 0, v117, 0, v112, 0LL);
		                *(_QWORD *)p_m_assetIdentifiers = v118;
		                if ( dword_18F35FD08 )
		                {
		                  v119 = (p_m_assetIdentifiers >> 12) & 0x1FFFFF;
		                  v120 = &qword_18F103690[(unsigned __int64)v119 >> 6];
		                  v121 = v119 & 0x3F;
		                  _m_prefetchw(v120);
		                  do
		                    v122 = *v120;
		                  while ( v122 != _InterlockedCompareExchange64(v120, *v120 | (1LL << v121), *v120) );
		                }
		              }
		            }
		            else
		            {
		              v123 = **((_QWORD **)v114.rgctxDataDummy + 7);
		              if ( (*(_BYTE *)(v123 + 312) & 1) == 0 )
		                sub_1800360B0(**((_QWORD **)v114.rgctxDataDummy + 7), v85);
		              *(_QWORD *)p_m_assetIdentifiers = il2cpp_array_new_specific_1(v123, (unsigned int)v112);
		              if ( dword_18F35FD08 )
		              {
		                v124 = (p_m_assetIdentifiers >> 12) & 0x1FFFFF;
		                v125 = &qword_18F103690[(unsigned __int64)v124 >> 6];
		                v126 = v124 & 0x3F;
		                _m_prefetchw(v125);
		                do
		                  v127 = *v125;
		                while ( v127 != _InterlockedCompareExchange64(v125, *v125 | (1LL << v126), *v125) );
		              }
		            }
		          }
		          else
		          {
		            v128 = v113->rgctxDataDummy;
		            if ( (v128[312] & 1) == 0 )
		              sub_1800360B0(v128, v85);
		            *(_QWORD *)p_m_assetIdentifiers = il2cpp_array_new_specific_1(v128, (unsigned int)v112);
		            if ( dword_18F35FD08 )
		            {
		              v129 = (p_m_assetIdentifiers >> 12) & 0x1FFFFF;
		              v130 = &qword_18F103690[(unsigned __int64)v129 >> 6];
		              v131 = v129 & 0x3F;
		              _m_prefetchw(v130);
		              do
		                v132 = *v130;
		              while ( v132 != _InterlockedCompareExchange64(v130, *v130 | (1LL << v131), *v130) );
		            }
		          }
		        }
		        ex = 0LL;
		        v189 = &v185;
		        try
		        {
		          if ( Beyond::Resource::FAssetProxyHandle::IsValid(&v192, 0LL) )
		          {
		            v137 = v2->fields.m_assetHandles;
		            if ( !v137 )
		              sub_1800D8250(0LL, v133);
		            if ( (unsigned int)v28 >= v137->max_length.size )
		              sub_1800D2AA0(v137, v133, v134);
		            v137->vector[v28] = v192;
		            ++v2->fields.m_assetHandleCount;
		            m_loadingAssetHandleIndexSet = v2->fields.m_loadingAssetHandleIndexSet;
		            if ( !m_loadingAssetHandleIndexSet )
		              sub_1800D8250(0LL, v133);
		            Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::Add(
		              m_loadingAssetHandleIndexSet,
		              (AssetHandleIndex)v28,
		              MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::Add);
		            v139 = TypeInfo::UnityEngine::HyperGryph::HGResourceManager;
		            if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::HGResourceManager);
		              v139 = TypeInfo::UnityEngine::HyperGryph::HGResourceManager;
		            }
		            v136 = *(AssetIdentifier *)&v202[8];
		            v200[0] = *(AssetIdentifier *)&v202[8];
		            v187[0] = v28;
		            if ( !v139->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(v139);
		            v140 = (void (__fastcall *)(int32_t *, AssetIdentifier *, _QWORD, _QWORD))qword_18F3709B0;
		            if ( !qword_18F3709B0 )
		            {
		              v140 = (void (__fastcall *)(int32_t *, AssetIdentifier *, _QWORD, _QWORD))il2cpp_resolve_icall_1(
		                                                                                          "UnityEngine.HyperGryph.HGResou"
		                                                                                          "rceManager::UpdateAssetHandle_"
		                                                                                          "Injected(UnityEngine.HyperGryp"
		                                                                                          "h.AssetHandleIndex&,UnityEngin"
		                                                                                          "e.HyperGryph.AssetIdentifier&,"
		                                                                                          "UnityEngine.HyperGryph.AssetSt"
		                                                                                          "ate,System.Int32)");
		              if ( !v140 )
		              {
		                v182 = sub_1802EE1B8(
		                         "UnityEngine.HyperGryph.HGResourceManager::UpdateAssetHandle_Injected(UnityEngine.HyperGryph.Ass"
		                         "etHandleIndex&,UnityEngine.HyperGryph.AssetIdentifier&,UnityEngine.HyperGryph.AssetState,System.Int32)");
		                sub_18007E1B0(v182, 0LL);
		              }
		              qword_18F3709B0 = (__int64)v140;
		            }
		            v140(v187, v200, 0LL, 0LL);
		          }
		          else
		          {
		            Beyond::Resource::FAssetProxyHandle::Dispose(&v192, 0LL);
		            if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::HGResourceManager);
		            v136 = *(AssetIdentifier *)&v202[8];
		            v199 = *(AssetIdentifier *)&v202[8];
		            LOBYTE(v135) = 2;
		            UnityEngine::HyperGryph::HGResourceManager::UpdateAssetHandle((AssetHandleIndex)v28, &v199, v135, 0, 0LL);
		          }
		        }
		        catch ( Il2CppExceptionWrapper *v205 )
		        {
		          v20 = (__int64 *)v184;
		          ex = v205->ex;
		          if ( ex )
		            sub_18007E1E0(ex);
		          v2 = this;
		          v136 = *(AssetIdentifier *)&v202[8];
		          LODWORD(v28) = v193;
		        }
		        m_assetIdentifiers = v2->fields.m_assetIdentifiers;
		        if ( !m_assetIdentifiers )
		          sub_1800D8250(0LL, v20);
		        if ( (unsigned int)v28 >= m_assetIdentifiers->max_length.size )
		          sub_1800D2AA0(m_assetIdentifiers, v20, v21);
		        m_assetIdentifiers->vector[(unsigned int)v28] = v136;
		      }
		      else
		      {
		        v31 = v2->fields.m_assetHandles;
		        if ( !v31 )
		          sub_1800D8250(0LL, v20);
		        if ( *(_DWORD *)&v202[4] >= v31->max_length.size )
		          sub_1800D2AA0(v31, v20, v21);
		        P0 = v31->vector[v28];
		        if ( Beyond::Resource::FAssetProxyHandle::IsValid(&P0, 0LL) )
		        {
		          if ( IFix::WrappersManagerImpl::IsPatched(590, 0LL) )
		          {
		            if ( !byte_18F382510 )
		            {
		              v33 = _InterlockedExchangeAdd64(
		                      (volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper,
		                      0LL);
		              if ( (v33 & 1) != 0 )
		              {
		                v36 = ((unsigned int)v33 >> 1) & 0xFFFFFFF;
		                switch ( (unsigned int)v33 >> 29 )
		                {
		                  case 1u:
		                    v37 = (void (__fastcall __noreturn **)())sub_180036020((unsigned int)v36);
		                    goto LABEL_72;
		                  case 2u:
		                    v37 = (void (__fastcall __noreturn **)())sub_1800362C0((unsigned int)v36);
		                    goto LABEL_72;
		                  case 3u:
		                  case 6u:
		                    v38 = ((unsigned int)v33 >> 1) & 0xFFFFFFF;
		                    v33 = (unsigned int)v33 >> 29;
		                    if ( (_DWORD)v33 )
		                    {
		                      if ( (_DWORD)v33 == 3 )
		                      {
		                        v37 = (void (__fastcall __noreturn **)())sub_180009A40(v38);
		                        goto LABEL_72;
		                      }
		                      if ( (_DWORD)v33 == 6 )
		                      {
		                        v39 = sub_1802F8800(v38);
		                        v37 = (void (__fastcall __noreturn **)())sub_180026660(v39, 0LL);
		                        goto LABEL_72;
		                      }
		                    }
		                    else if ( v38 == 1 )
		                    {
		                      v37 = off_18B8C2EC0;
		                      goto LABEL_72;
		                    }
		LABEL_71:
		                    v37 = 0LL;
		LABEL_72:
		                    if ( v37 )
		                      _InterlockedExchange64(
		                        (volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper,
		                        (__int64)v37);
		                    break;
		                  case 4u:
		                    v37 = (void (__fastcall __noreturn **)())sub_1802F8760((unsigned int)v36);
		                    goto LABEL_72;
		                  case 5u:
		                    if ( *(_QWORD *)(qword_18F371F68 + 8 * v36) )
		                    {
		                      v37 = *(void (__fastcall __noreturn ***)())(qword_18F371F68 + 8 * v36);
		                    }
		                    else
		                    {
		                      v40 = (unsigned int *)(qword_18F360DF8 + *(int *)(qword_18F360E00 + 8) + 8 * v36);
		                      v41 = il2cpp_string_new_len(qword_18F360DF8 + (int)v40[1] + *(int *)(qword_18F360E00 + 16), *v40);
		                      v37 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
		                                                                 (volatile signed __int64 *)(qword_18F371F68 + 8 * v36),
		                                                                 v41,
		                                                                 0LL);
		                      if ( !v37 )
		                      {
		                        v33 = qword_18F371F68 + 8 * v36;
		                        if ( dword_18F35FD08 )
		                        {
		                          v42 = (v33 >> 12) & 0x1FFFFF;
		                          v32 = 0x180000000LL + 8 * ((unsigned __int64)v42 >> 6) + 252720784;
		                          v33 = v42 & 0x3F;
		                          _m_prefetchw((const void *)v32);
		                          do
		                            v43 = *(_QWORD *)v32;
		                          while ( v43 != _InterlockedCompareExchange64(
		                                           (volatile signed __int64 *)v32,
		                                           *(_QWORD *)v32 | (1LL << v33),
		                                           *(_QWORD *)v32) );
		                        }
		                        v37 = (void (__fastcall __noreturn **)())v41;
		                      }
		                    }
		                    goto LABEL_72;
		                  case 7u:
		                    v44 = sub_1802F8760((unsigned int)v36);
		                    v45 = *(_QWORD *)(v44 + 16);
		                    v46 = (v44 - *(_QWORD *)(v45 + 128)) >> 5;
		                    if ( *(_BYTE *)(v45 + 42) == 21 )
		                    {
		                      v47 = *(_QWORD ***)(v45 + 96);
		                      if ( *v47 )
		                        v45 = sub_180009AD0(**v47);
		                      else
		                        v45 = 0LL;
		                    }
		                    v203 = v46 + *(_DWORD *)(*(_QWORD *)(v45 + 104) + 32LL);
		                    v48 = sub_1801CD744(
		                            (unsigned int)&v203,
		                            (int)qword_18F360DF8 + *(_DWORD *)(qword_18F360E00 + 64),
		                            *(int *)(qword_18F360E00 + 68) / 0xCuLL,
		                            12,
		                            (__int64)sub_1802F7130);
		                    if ( !v48 )
		                      goto LABEL_71;
		                    v32 = *(unsigned int *)(v48 + 8);
		                    if ( (_DWORD)v32 == -1 )
		                      goto LABEL_71;
		                    v37 = (void (__fastcall __noreturn **)())(v32 + qword_18F360DF8 + *(int *)(qword_18F360E00 + 72));
		                    goto LABEL_72;
		                  default:
		                    break;
		                }
		              }
		              byte_18F382510 = 1;
		            }
		            v49 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		              v49 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            v50 = v49->static_fields->wrapperArray;
		            if ( !v50 )
		              sub_1800D8250(0LL, v32);
		            if ( v50->max_length.size <= 0x24Eu )
		              sub_1800D2AA0(v50, v32, v33);
		            v51 = v50[16].vector[14];
		            if ( !v51 )
		              sub_1800D8250(0LL, v32);
		            IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_203(v51, &P0, 0LL);
		          }
		          else
		          {
		            Beyond::Resource::FAssetProxyUntrackedHandle::Dispose(&P0.m_untrackedHandle, 0LL);
		          }
		          v52 = v2->fields.m_assetHandles;
		          if ( !v52 )
		            sub_1800D8250(0LL, v34);
		          if ( (unsigned int)v28 >= v52->max_length.size )
		            sub_1800D2AA0(v52, v34, v35);
		          v53 = v28;
		          v54 = 0LL;
		          *(_OWORD *)&v52->vector[v53].m_untrackedHandle.m_handleObjectID = 0LL;
		          v52->vector[v53].m_untrackedHandle.m_mainVersion = 0;
		          --v2->fields.m_assetHandleCount;
		          v55 = v2->fields.m_loadingAssetHandleIndexSet;
		          if ( !v55 )
		            sub_1800D8250(v52, 0LL);
		          v56 = MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::Remove;
		          if ( !*((_QWORD *)MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::Remove->klass->rgctx_data[18].rgctxDataDummy
		                + 4) )
		            (*(void (**)(void))MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::Remove->klass->rgctx_data[18].rgctxDataDummy)();
		          v57 = v56->klass->rgctx_data;
		          v58.rgctxDataDummy = v57[18].rgctxDataDummy;
		          m_indexDict = v55->fields.m_indexDict;
		          if ( !m_indexDict )
		            sub_1800D8250(v57, v54);
		          if ( !*(_QWORD *)(*(_QWORD *)(*(_QWORD *)(*((_QWORD *)v58.rgctxDataDummy + 4) + 192LL) + 152LL) + 32LL) )
		            (**(void (***)(void))(*(_QWORD *)(*((_QWORD *)v58.rgctxDataDummy + 4) + 192LL) + 152LL))();
		          v60 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)v58.rgctxDataDummy + 4) + 192LL) + 152LL);
		          if ( !*(_QWORD *)(*(_QWORD *)(*(_QWORD *)(*(_QWORD *)(v60 + 32) + 192LL) + 176LL) + 32LL) )
		            (**(void (***)(void))(*(_QWORD *)(*(_QWORD *)(v60 + 32) + 192LL) + 176LL))();
		          Entry = System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::AssetHandleIndex,int>::FindEntry(
		                    m_indexDict,
		                    (AssetHandleIndex)v28,
		                    *(MethodInfo **)(*(_QWORD *)(*(_QWORD *)(v60 + 32) + 192LL) + 176LL));
		          if ( Entry >= 0 )
		          {
		            entries = m_indexDict->fields._entries;
		            if ( !entries )
		              sub_1800D8250(0LL, v20);
		            if ( (unsigned int)Entry >= entries->max_length.size )
		              sub_1800D2AA0(entries, Entry, v21);
		            value = entries->vector[Entry].value;
		            if ( !*(_QWORD *)(*(_QWORD *)(*(_QWORD *)(*((_QWORD *)v58.rgctxDataDummy + 4) + 192LL) + 160LL) + 32LL) )
		              (**(void (***)(void))(*(_QWORD *)(*((_QWORD *)v58.rgctxDataDummy + 4) + 192LL) + 160LL))();
		            Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::RemoveAtSwapBack(
		              v55,
		              value,
		              *(MethodInfo **)(*(_QWORD *)(*((_QWORD *)v58.rgctxDataDummy + 4) + 192LL) + 160LL));
		          }
		        }
		        v64 = v2->fields.m_assetIdentifiers;
		        if ( !v64 )
		          sub_1800D8250(0LL, v20);
		        if ( (unsigned int)v28 >= v64->max_length.size )
		          sub_1800D2AA0(v64, v20, v21);
		        v64->vector[v28] = 0LL;
		      }
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v206 )
		  {
		    v190 = v206->ex;
		    if ( v190 )
		      sub_18007E1E0(v190);
		    v2 = this;
		    goto LABEL_229;
		  }
		  memset((char *)&v195[1] + 8, 0, 24);
		LABEL_229:
		  if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::HGResourceManager);
		  v142 = (void (*)(void))qword_18F370990;
		  if ( !qword_18F370990 )
		  {
		    v142 = (void (*)(void))il2cpp_resolve_icall_1("UnityEngine.HyperGryph.HGResourceManager::ClearAssetOperations()");
		    if ( !v142 )
		    {
		      v183 = sub_1802EE1B8("UnityEngine.HyperGryph.HGResourceManager::ClearAssetOperations()");
		      sub_18007E1B0(v183, 0LL);
		    }
		    qword_18F370990 = (__int64)v142;
		  }
		  v142();
		  v146 = v2->fields.m_loadingAssetHandleIndexSet;
		  if ( !v146 )
		    sub_1800D8250(v144, v143);
		  v147 = MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count;
		  if ( !v146->fields.m_list )
		    sub_1800D8250(v144, MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count);
		  v148 = MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count->klass->rgctx_data;
		  if ( !*((_QWORD *)v148[1].rgctxDataDummy + 4) )
		    (*(void (**)(void))MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count->klass->rgctx_data[1].rgctxDataDummy)();
		  v212 = 0;
		  ex = 0LL;
		  v189 = &v212;
		  try
		  {
		    v149 = v2->fields.m_loadingAssetHandleIndexSet;
		    if ( !v149 )
		      sub_1800D8250(v148, v147);
		    v150 = MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count;
		    m_list = v149->fields.m_list;
		    if ( !m_list )
		      sub_1800D8250(v148, MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count);
		    v152 = MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count->klass->rgctx_data;
		    if ( !*((_QWORD *)v152[1].rgctxDataDummy + 4) )
		      (*(void (**)(void))MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count->klass->rgctx_data[1].rgctxDataDummy)();
		    size = m_list->fields._size;
		    while ( 1 )
		    {
		      v187[0] = --size;
		      if ( size < 0 )
		        break;
		      v154 = v2->fields.m_loadingAssetHandleIndexSet;
		      if ( !v154 )
		        sub_1800D8250(v152, v150);
		      v155 = MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Item;
		      v156 = v154->fields.m_list;
		      if ( !v156 )
		        sub_1800D8250(v152, MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Item);
		      v157 = MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Item->klass->rgctx_data;
		      if ( !*((_QWORD *)v157[9].rgctxDataDummy + 4) )
		        (*(void (**)(void))MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Item->klass->rgctx_data[9].rgctxDataDummy)();
		      if ( (unsigned int)size >= v156->fields._size )
		        System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		      items = v156->fields._items;
		      if ( !items )
		        sub_1800D8250(v157, v155);
		      if ( (unsigned int)size >= items->max_length.size )
		        sub_1800D2AA0(v157, v155, v145);
		      index = items->vector[size].index;
		      v160 = v2->fields.m_assetHandles;
		      if ( !v160 )
		        sub_1800D8250(0LL, v155);
		      if ( (unsigned int)index >= v160->max_length.size )
		        sub_1800D2AA0(v160, v155, v145);
		      v196 = v160->vector[index];
		      if ( Beyond::Resource::FAssetProxyHandle::get_isDone(&v196, 0LL) )
		      {
		        v161 = v2->fields.m_assetIdentifiers;
		        if ( !v161 )
		          sub_1800D8250(0LL, v150);
		        if ( (unsigned int)index >= v161->max_length.size )
		          sub_1800D2AA0(v161, v150, v145);
		        v162 = v161->vector[index];
		        v190 = 0LL;
		        v191 = &v186;
		        try
		        {
		          v163 = Beyond::Resource::FAssetProxyHandle::Get(&v196, 0LL);
		          v165 = TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            v165 = TypeInfo::UnityEngine::Object;
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		              v165 = TypeInfo::UnityEngine::Object;
		            }
		          }
		          if ( !v163 )
		            goto LABEL_356;
		          if ( !v165->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(v165);
		          if ( v163->fields.m_CachedPtr )
		          {
		            v166 = Beyond::Resource::FAssetProxyHandle::Get(&v196, 0LL);
		            if ( !v166 )
		              sub_1800D8250(v168, v167);
		            InstanceID = UnityEngine::Object::GetInstanceID(v166, 0LL);
		            if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::HGResourceManager);
		            v200[0] = v162;
		            LOBYTE(v170) = 1;
		            UnityEngine::HyperGryph::HGResourceManager::UpdateAssetHandle(
		              (AssetHandleIndex)index,
		              v200,
		              v170,
		              InstanceID,
		              0LL);
		          }
		          else
		          {
		LABEL_356:
		            if ( !TypeInfo::UnityEngine::HyperGryph::HGResourceManager->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::HGResourceManager);
		            v199 = v162;
		            LOBYTE(v164) = 2;
		            UnityEngine::HyperGryph::HGResourceManager::UpdateAssetHandle((AssetHandleIndex)index, &v199, v164, 0, 0LL);
		          }
		        }
		        catch ( Il2CppExceptionWrapper *v207 )
		        {
		          v171 = v184;
		          v190 = v207->ex;
		          if ( v190 )
		            sub_18007E1E0(v190);
		          v2 = this;
		          size = v187[0];
		        }
		        v172 = v2->fields.m_loadingAssetHandleIndexSet;
		        if ( !v172 )
		          sub_1800D8250(0LL, v171);
		        Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::RemoveAtSwapBack(
		          v172,
		          size,
		          MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::RemoveAtSwapBack);
		      }
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v208 )
		  {
		    ex = v208->ex;
		    if ( ex )
		      sub_18007E1E0(ex);
		    if ( v197 )
		      sub_18007E1E0(v197);
		  }
		}
		
		public bool ValidateAndReset() => default; // 0x0000000189B585A0-0x0000000189B59130
		// Boolean ValidateAndReset()
		// Hidden C++ exception states: #wind=3
		bool HG::Rendering::Runtime::HGResourceManagerScript::ValidateAndReset(
		        HGResourceManagerScript *this,
		        MethodInfo *method)
		{
		  HGResourceManagerScript *v2; // rsi
		  __int64 v3; // rdx
		  __int64 v4; // rbx
		  FAssetProxyHandle__Array *m_assetHandles; // rcx
		  __int64 v6; // rdx
		  ILFixDynamicMethodWrapper_3 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  FAssetProxyHandle__Array *v10; // rcx
		  __int64 v11; // rax
		  __int64 v12; // rdx
		  IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *m_loadingAssetHandleIndexSet; // rcx
		  __int64 v14; // rdx
		  __int64 v15; // r8
		  AssetIdentifier__Array *m_assetIdentifiers; // rcx
		  __int64 v17; // rdx
		  UniqueList_1_System_Object_ *v18; // rcx
		  StringBuilder *v20; // rax
		  StringBuilder *v21; // r14
		  StringBuilder *v22; // rax
		  StringBuilder *v23; // rax
		  StringBuilder *v24; // rax
		  int v25; // r12d
		  StringBuilder *v26; // rax
		  int m_assetHandleCount; // ebx
		  unsigned int v28; // ebx
		  FAssetProxyHandle__Array *v29; // rax
		  FAssetProxyHandle *v30; // rax
		  __int64 v31; // r9
		  struct AssetType__Enum__Class *v32; // r13
		  __int64 v33; // rdx
		  __int64 v34; // rax
		  __int64 v35; // rbx
		  __int64 v36; // rcx
		  __int64 v37; // rdx
		  __int64 *v38; // rax
		  __int64 *v39; // r15
		  char *v40; // rcx
		  __int64 v41; // r8
		  char *v42; // rax
		  unsigned __int64 v43; // r8
		  __int64 *v44; // rax
		  __int64 v45; // rdx
		  __int64 v46; // rcx
		  __int64 v47; // r14
		  __int64 v48; // rdx
		  __int64 v49; // rax
		  __int64 v50; // rcx
		  __int64 v51; // r13
		  __int64 v52; // rbx
		  __int64 v53; // rcx
		  __int64 v54; // rdx
		  Object *v55; // rax
		  Object *v56; // r15
		  Object *v57; // rcx
		  __int64 v58; // r8
		  Object *v59; // rax
		  unsigned __int64 v60; // r8
		  Object *v61; // rax
		  __int64 v62; // rdx
		  __int64 v63; // rcx
		  __int64 v64; // r14
		  __int64 v65; // rdx
		  __int64 v66; // rax
		  int v67; // eax
		  struct RuntimeType__Class *v68; // rbx
		  RuntimeType *v69; // r14
		  String *v70; // rax
		  StringBuilder *v71; // rax
		  StringBuilder *v72; // rax
		  StringBuilder__Class *klass; // rdx
		  StringBuilder *v74; // rcx
		  StringBuilder *v75; // rax
		  StringBuilder *v76; // rbx
		  StringBuilder *v77; // r14
		  int32_t length; // eax
		  StringBuilder *v79; // rax
		  StringBuilder *v80; // rax
		  StringBuilder *v81; // rax
		  int32_t v82; // r14d
		  String *v83; // rdx
		  int32_t v84; // r15d
		  AssetIdentifier__Array *v85; // r12
		  IndexedHashSet_1_UnityEngine_HyperGryph_AssetHandleIndex_ *v86; // rcx
		  AssetHandleIndex v87; // eax
		  __int64 v88; // r9
		  RuntimeType *object_1; // r12
		  struct RuntimeType__Class *v90; // r13
		  StringBuilder *v91; // rax
		  StringBuilder *v92; // rax
		  String *v93; // rbx
		  ELogChannel__Enum v94; // ecx
		  ILFixDynamicMethodWrapper_2 *v95; // rax
		  __int64 *v96; // [rsp+30h] [rbp-128h] BYREF
		  FAssetProxyUntrackedHandle value; // [rsp+38h] [rbp-120h] BYREF
		  Il2CppType *p_byval_arg; // [rsp+50h] [rbp-108h] BYREF
		  __int64 v99; // [rsp+58h] [rbp-100h] BYREF
		  RuntimeType *v100; // [rsp+60h] [rbp-F8h]
		  _QWORD v101[2]; // [rsp+68h] [rbp-F0h] BYREF
		  FAssetProxyUntrackedHandle v102; // [rsp+78h] [rbp-E0h] BYREF
		  StringBuilder *v103; // [rsp+90h] [rbp-C8h]
		  StringBuilder *v104; // [rsp+98h] [rbp-C0h]
		  NativeArray_1_T_Enumerator_UnityEngine_HyperGryph_AssetOperation_ v105; // [rsp+A0h] [rbp-B8h] BYREF
		  NativeArray_1_T_Enumerator_UnityEngine_HyperGryph_AssetOperation_ v106; // [rsp+D0h] [rbp-88h] BYREF
		  Il2CppExceptionWrapper *v107; // [rsp+100h] [rbp-58h] BYREF
		  char v108[8]; // [rsp+108h] [rbp-50h] BYREF
		  char v109; // [rsp+110h] [rbp-48h] BYREF
		  char v110[64]; // [rsp+118h] [rbp-40h] BYREF
		  unsigned int v112; // [rsp+170h] [rbp+18h]
		  Object *v113; // [rsp+170h] [rbp+18h]
		  int v114; // [rsp+178h] [rbp+20h]
		  StringBuilder *v115; // [rsp+178h] [rbp+20h]
		
		  v2 = this;
		  memset(&v102, 0, sizeof(v102));
		  if ( !IFix::WrappersManagerImpl::IsPatched(2347, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::HyperGryph::HGResourceManager);
		    *(_OWORD *)&value.m_handleObjectID = *(_OWORD *)sub_183CCA730(&value);
		    Unity::Collections::NativeArray<UnityEngine::HyperGryph::AssetOperation>::GetEnumerator(
		      &v105,
		      (NativeArray_1_UnityEngine_HyperGryph_AssetOperation_ *)&value,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::AssetOperation>::GetEnumerator);
		    v106 = v105;
		    v101[0] = 0LL;
		    v101[1] = &v106;
		    try
		    {
		      while ( (unsigned __int8)sub_183BABA80(
		                                 &v106,
		                                 MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::HyperGryph::AssetOperation>::MoveNext) )
		      {
		        v4 = HIDWORD(*(_QWORD *)&v106.value.isLoadOperation);
		        if ( !v106.value.isLoadOperation )
		        {
		          m_assetHandles = v2->fields.m_assetHandles;
		          if ( !m_assetHandles )
		            sub_1800D8250(0LL, v3);
		          sub_1800035F0(m_assetHandles, &value, HIDWORD(*(_QWORD *)&v106.value.isLoadOperation));
		          v102 = value;
		          if ( IFix::WrappersManagerImpl::IsPatched(590, 0LL) )
		          {
		            Patch = IFix::WrappersManagerImpl::GetPatch(590, 0LL);
		            if ( !Patch )
		              sub_1800D8250(v9, v8);
		            IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_203(Patch, (FAssetProxyHandle *)&v102, 0LL);
		          }
		          else
		          {
		            Beyond::Resource::FAssetProxyUntrackedHandle::Dispose(&v102, 0LL);
		          }
		          v10 = v2->fields.m_assetHandles;
		          if ( !v10 )
		            sub_1800D8250(0LL, v6);
		          v11 = sub_180006380(v10, v4);
		          *(_OWORD *)v11 = 0LL;
		          *(_DWORD *)(v11 + 16) = 0;
		          --v2->fields.m_assetHandleCount;
		          m_loadingAssetHandleIndexSet = v2->fields.m_loadingAssetHandleIndexSet;
		          if ( !m_loadingAssetHandleIndexSet )
		            sub_1800D8250(0LL, v12);
		          Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::Remove(
		            m_loadingAssetHandleIndexSet,
		            (AssetHandleIndex)v4,
		            MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::Remove);
		          m_assetIdentifiers = v2->fields.m_assetIdentifiers;
		          if ( !m_assetIdentifiers )
		            sub_1800D8250(0LL, v14);
		          if ( (unsigned int)v4 >= m_assetIdentifiers->max_length.size )
		            sub_1800D2AA0(m_assetIdentifiers, v14, v15);
		          m_assetIdentifiers->vector[v4] = 0LL;
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v107 )
		    {
		      v101[0] = v107->ex;
		      if ( v101[0] )
		        sub_18007E1E0(v101[0]);
		      v2 = this;
		LABEL_18:
		      sub_1800036A0(TypeInfo::UnityEngine::HyperGryph::HGResourceManager);
		      UnityEngine::HyperGryph::HGResourceManager::ClearAssetOperations(0LL);
		      v18 = (UniqueList_1_System_Object_ *)v2->fields.m_loadingAssetHandleIndexSet;
		      if ( !v18 )
		        goto LABEL_139;
		      if ( Beyond::UniqueList<System::Object>::get_length(
		             v18,
		             MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count) <= 0 )
		      {
		        if ( v2->fields.m_assetHandleCount <= 0 )
		          return 1;
		        v20 = (StringBuilder *)sub_18002C620(TypeInfo::System::Text::StringBuilder);
		        v21 = v20;
		        v104 = v20;
		        if ( v20 )
		        {
		          System::Text::StringBuilder::StringBuilder(v20, 0LL);
		          v22 = System::Text::StringBuilder::Append(
		                  v21,
		                  (String *)"HG Resource Manager Script 的 AssetHandle 在退出后仍有残留，共 ",
		                  0LL);
		          if ( v22 )
		          {
		            v23 = System::Text::StringBuilder::Append(v22, v2->fields.m_assetHandleCount, 0LL);
		            if ( v23 )
		            {
		              v24 = System::Text::StringBuilder::Append(v23, (String *)" 个（最多列出 ", 0LL);
		              if ( v24 )
		              {
		                v25 = 100;
		                v26 = System::Text::StringBuilder::Append(v24, 100, 0LL);
		                if ( v26 )
		                {
		                  System::Text::StringBuilder::Append(v26, (String *)" 个）：", 0LL);
		                  m_assetHandleCount = v2->fields.m_assetHandleCount;
		                  sub_1800036A0(TypeInfo::System::Math);
		                  if ( m_assetHandleCount <= 100 )
		                    v25 = m_assetHandleCount;
		                  v17 = 0LL;
		                  v112 = 0;
		                  v28 = 0;
		                  v114 = 0;
		                  v18 = 0LL;
		                  v29 = v2->fields.m_assetHandles;
		                  if ( v29 )
		                  {
		                    while ( (int)v18 < v29->max_length.size && (int)v17 < v25 )
		                    {
		                      v18 = (UniqueList_1_System_Object_ *)v2->fields.m_assetHandles;
		                      if ( !v18 )
		                        goto LABEL_139;
		                      v30 = (FAssetProxyHandle *)sub_180006380(v18, (int)v28);
		                      if ( Beyond::Resource::FAssetProxyHandle::IsValid(v30, 0LL) )
		                      {
		                        v18 = (UniqueList_1_System_Object_ *)v2->fields.m_assetIdentifiers;
		                        if ( !v18 )
		                          goto LABEL_139;
		                        sub_180002990(v18, &value, (int)v28, v31);
		                        v103 = System::Text::StringBuilder::Append(v21, (String *)"\nAssetType: ", 0LL);
		                        v32 = TypeInfo::UnityEngine::HyperGryph::AssetType;
		                        v105.m_Array.m_Buffer = (Void *)TypeInfo::UnityEngine::HyperGryph::AssetType;
		                        *(_QWORD *)&v105.m_Array.m_Length = -1LL;
		                        v105.m_Index = value.m_assetProxyObj.m_handleID;
		                        p_byval_arg = &TypeInfo::UnityEngine::HyperGryph::AssetType->_0.byval_arg;
		                        v99 = 0LL;
		                        if ( (unsigned __int8)sub_180029050(qword_18F360EA8, &p_byval_arg, &v99) )
		                        {
		                          v34 = v99;
		                        }
		                        else
		                        {
		                          v35 = qword_18F360100;
		                          if ( (*(_BYTE *)(qword_18F360100 + 312) & 2) == 0 )
		                          {
		                            v96 = &qword_18F360A90;
		                            sub_1802DEE10(&qword_18F360A90);
		                            sub_18004C730(v35, &v96);
		                            sub_1802DEE70(v96);
		                          }
		                          if ( *(_QWORD *)(v35 + 96) && (*(_BYTE *)(v35 + 312) & 8) != 0 )
		                            v35 = *(_QWORD *)(v35 + 64);
		                          v36 = *(unsigned int *)(v35 + 248);
		                          if ( (*(_BYTE *)(v35 + 312) & 0x20) != 0 )
		                          {
		                            if ( *(_QWORD *)(v35 + 8) )
		                            {
		                              v44 = (__int64 *)sub_18002CF00(v36, v35);
		                            }
		                            else
		                            {
		                              v45 = 1LL;
		                              if ( dword_18F35FD0C == 1 )
		                                v45 = 4LL;
		                              v44 = (__int64 *)sub_180017620(v36, v45);
		                              *v44 = v35;
		                            }
		                            v39 = v44;
		                          }
		                          else
		                          {
		                            v37 = 0LL;
		                            if ( dword_18F35FD0C == 1 )
		                              v37 = 3LL;
		                            v38 = (__int64 *)sub_180017620(v36, v37);
		                            v39 = v38;
		                            *v38 = v35;
		                            v38[1] = 0LL;
		                            v40 = (char *)(v38 + 2);
		                            v41 = *(unsigned int *)(v35 + 248);
		                            if ( *(_DWORD *)(v35 + 248) >= 0x80u )
		                            {
		                              sub_18033B9D0(v40, 0LL, v41 - 16);
		                            }
		                            else
		                            {
		                              v42 = (char *)v38 + v41;
		                              v43 = (unsigned __int64)(v42 - v40 + 7) >> 3;
		                              if ( v40 > v42 )
		                                v43 = 0LL;
		                              if ( v43 )
		                                sub_18033B9D0(v40, 0LL, 8 * v43);
		                            }
		                          }
		                          _InterlockedIncrement64(&qword_18F360F20);
		                          if ( (*(_BYTE *)(v35 + 313) & 2) != 0 )
		                            sub_18002E5E0(
		                              (_DWORD)v39,
		                              (unsigned int)sub_18000A6C0,
		                              0,
		                              (unsigned int)&v109,
		                              (__int64)v108);
		                          if ( (dword_18F371F28 & 0x80u) != 0 )
		                          {
		                            v46 = qword_18F3714E0;
		                            v47 = qword_18F3714E0;
		                            v48 = qword_18F3714E8;
		                            if ( qword_18F3714E0 != qword_18F3714E0 + 8 * qword_18F3714E8 )
		                            {
		                              do
		                              {
		                                v49 = *(_QWORD *)v47;
		                                if ( *(char *)(*(_QWORD *)v47 + 8LL) < 0 && *(_QWORD *)(v49 + 40) )
		                                {
		                                  (*(void (__fastcall **)(_QWORD, __int64 *, __int64))(v49 + 40))(
		                                    *(_QWORD *)v49,
		                                    v39,
		                                    v35);
		                                  v48 = qword_18F3714E8;
		                                  v46 = qword_18F3714E0;
		                                }
		                                v47 += 8LL;
		                              }
		                              while ( v47 != v46 + 8 * v48 );
		                            }
		                          }
		                          il2cpp_runtime_class_init_1(v35);
		                          v39[2] = (__int64)p_byval_arg;
		                          v34 = sub_18000F7C0(qword_18F360EA8, &p_byval_arg, v39);
		                        }
		                        v100 = (RuntimeType *)v34;
		                        if ( (struct AssetType__Enum__Class *)v32->_0.element_class == v32 )
		                          v50 = 0LL;
		                        else
		                          v50 = (__int64)&v32->_0.element_class->byval_arg;
		                        LOBYTE(v33) = 1;
		                        v51 = sub_180028750(v50, v33);
		                        v52 = v51;
		                        if ( (*(_BYTE *)(v51 + 312) & 2) == 0 )
		                        {
		                          v96 = &qword_18F360A90;
		                          sub_1802DEE10(&qword_18F360A90);
		                          sub_18004C730(v51, &v96);
		                          sub_1802DEE70(v96);
		                        }
		                        if ( *(_QWORD *)(v51 + 96) && (*(_BYTE *)(v51 + 312) & 8) != 0 )
		                          v52 = *(_QWORD *)(v51 + 64);
		                        v53 = *(unsigned int *)(v52 + 248);
		                        if ( (*(_BYTE *)(v52 + 312) & 0x20) != 0 )
		                        {
		                          if ( *(_QWORD *)(v52 + 8) )
		                          {
		                            v61 = (Object *)sub_18002CF00(v53, v52);
		                          }
		                          else
		                          {
		                            v62 = 1LL;
		                            if ( dword_18F35FD0C == 1 )
		                              v62 = 4LL;
		                            v61 = (Object *)sub_180017620(v53, v62);
		                            v61->klass = (Object__Class *)v52;
		                          }
		                          v56 = v61;
		                        }
		                        else
		                        {
		                          v54 = 0LL;
		                          if ( dword_18F35FD0C == 1 )
		                            v54 = 3LL;
		                          v55 = (Object *)sub_180017620(v53, v54);
		                          v56 = v55;
		                          v55->klass = (Object__Class *)v52;
		                          v55->monitor = 0LL;
		                          v57 = v55 + 1;
		                          v58 = *(unsigned int *)(v52 + 248);
		                          if ( *(_DWORD *)(v52 + 248) >= 0x80u )
		                          {
		                            sub_18033B9D0(v57, 0LL, v58 - 16);
		                          }
		                          else
		                          {
		                            v59 = (Object *)((char *)v55 + v58);
		                            v60 = (unsigned __int64)((char *)v59 - (char *)v57 + 7) >> 3;
		                            if ( v57 > v59 )
		                              v60 = 0LL;
		                            if ( v60 )
		                              sub_18033B9D0(v57, 0LL, 8 * v60);
		                          }
		                        }
		                        _InterlockedIncrement64(&qword_18F360F20);
		                        if ( (*(_BYTE *)(v52 + 313) & 2) != 0 )
		                          sub_18002E5E0((_DWORD)v56, (unsigned int)sub_18000A6C0, 0, (unsigned int)v101, (__int64)v110);
		                        if ( (dword_18F371F28 & 0x80u) != 0 )
		                        {
		                          v63 = qword_18F3714E0;
		                          v64 = qword_18F3714E0;
		                          v65 = qword_18F3714E8;
		                          if ( qword_18F3714E0 != qword_18F3714E0 + 8 * qword_18F3714E8 )
		                          {
		                            do
		                            {
		                              v66 = *(_QWORD *)v64;
		                              if ( *(char *)(*(_QWORD *)v64 + 8LL) < 0 && *(_QWORD *)(v66 + 40) )
		                              {
		                                (*(void (__fastcall **)(_QWORD, Object *, __int64))(v66 + 40))(*(_QWORD *)v66, v56, v52);
		                                v65 = qword_18F3714E8;
		                                v63 = qword_18F3714E0;
		                              }
		                              v64 += 8LL;
		                            }
		                            while ( v64 != v63 + 8 * v65 );
		                          }
		                        }
		                        il2cpp_runtime_class_init_1(v52);
		                        v67 = mono_class_value_size_0(v51, 0LL);
		                        sub_18033B330(&v56[1], &v105.m_Index, v67);
		                        sub_1800036A0(TypeInfo::System::Enum);
		                        v68 = TypeInfo::System::RuntimeType;
		                        v69 = v100;
		                        if ( v100 )
		                        {
		                          if ( !(unsigned __int8)sub_180005080(v100->klass, TypeInfo::System::RuntimeType) )
		                            sub_18031E1F4(v69, v68);
		                        }
		                        else
		                        {
		                          v69 = 0LL;
		                        }
		                        v70 = System::Enum::InternalFormat(v69, v56, 0LL);
		                        v18 = (UniqueList_1_System_Object_ *)v103;
		                        if ( !v103 )
		                          goto LABEL_139;
		                        v71 = System::Text::StringBuilder::Append(v103, v70, 0LL);
		                        if ( !v71 )
		                          goto LABEL_139;
		                        v72 = System::Text::StringBuilder::Append(v71, (String *)" AssetHash: ", 0LL);
		                        if ( !v72 )
		                          goto LABEL_139;
		                        System::Text::StringBuilder::Append(v72, *(int64_t *)&value.m_handleObjectID, 0LL);
		                        v17 = ++v112;
		                        v21 = v104;
		                        v28 = v114;
		                      }
		                      else
		                      {
		                        v17 = v112;
		                      }
		                      v114 = ++v28;
		                      v18 = (UniqueList_1_System_Object_ *)v28;
		                      v29 = v2->fields.m_assetHandles;
		                      if ( !v29 )
		                        goto LABEL_139;
		                    }
		                    sub_1800049A0(v21->klass);
		                    klass = v21->klass;
		                    v74 = v21;
		                    goto LABEL_129;
		                  }
		                }
		              }
		            }
		          }
		        }
		LABEL_139:
		        sub_1800D8250(v18, v17);
		      }
		      v75 = (StringBuilder *)sub_18002C620(TypeInfo::System::Text::StringBuilder);
		      v76 = v75;
		      if ( !v75 )
		        goto LABEL_139;
		      System::Text::StringBuilder::StringBuilder(v75, 0LL);
		      v77 = System::Text::StringBuilder::Append(
		              v76,
		              (String *)"HG Resource Manager Script 的 LoadingAssetIndexSet 在退出后仍有残留，共 ",
		              0LL);
		      v18 = (UniqueList_1_System_Object_ *)v2->fields.m_loadingAssetHandleIndexSet;
		      if ( !v18 )
		        goto LABEL_139;
		      length = Beyond::UniqueList<System::Object>::get_length(
		                 v18,
		                 MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count);
		      if ( !v77 )
		        goto LABEL_139;
		      v79 = System::Text::StringBuilder::Append(v77, length, 0LL);
		      if ( !v79 )
		        goto LABEL_139;
		      v80 = System::Text::StringBuilder::Append(v79, (String *)" 个（最多列出 ", 0LL);
		      if ( !v80 )
		        goto LABEL_139;
		      v81 = System::Text::StringBuilder::Append(v80, 100, 0LL);
		      if ( !v81 )
		        goto LABEL_139;
		      System::Text::StringBuilder::Append(v81, (String *)" 个）：", 0LL);
		      v18 = (UniqueList_1_System_Object_ *)v2->fields.m_loadingAssetHandleIndexSet;
		      if ( !v18 )
		        goto LABEL_139;
		      v82 = Beyond::UniqueList<System::Object>::get_length(
		              v18,
		              MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Count);
		      sub_1800036A0(TypeInfo::System::Math);
		      v84 = 0;
		      if ( v82 > 100 )
		      {
		        v82 = 100;
		      }
		      else if ( v82 <= 0 )
		      {
		LABEL_128:
		        sub_1800049A0(v76->klass);
		        klass = v76->klass;
		        v74 = v76;
		LABEL_129:
		        v93 = (String *)((__int64 (__fastcall *)(StringBuilder *, Il2CppMethodPointer))klass->vtable.ToString.method)(
		                          v74,
		                          klass->vtable.System_Runtime_Serialization_ISerializable_GetObjectData.methodPtr);
		        sub_1800036A0(TypeInfo::Beyond::DLogger);
		        LOBYTE(v94) = 1;
		        Beyond::DLogger::LogError(v94, v93, 0LL);
		        return 0;
		      }
		      do
		      {
		        v85 = v2->fields.m_assetIdentifiers;
		        v86 = v2->fields.m_loadingAssetHandleIndexSet;
		        if ( !v86 )
		          goto LABEL_142;
		        v87.index = Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Item(
		                      v86,
		                      v84,
		                      MethodInfo::Beyond::IndexedHashSet<UnityEngine::HyperGryph::AssetHandleIndex>::get_Item).index;
		        if ( !v85 )
		          goto LABEL_142;
		        sub_180002990(v85, &value, v87.index, v88);
		        v115 = System::Text::StringBuilder::Append(v76, (String *)"\nAssetType: ", 0LL);
		        v105.m_Array.m_Buffer = (Void *)TypeInfo::UnityEngine::HyperGryph::AssetType;
		        *(_QWORD *)&v105.m_Array.m_Length = -1LL;
		        v105.m_Index = value.m_assetProxyObj.m_handleID;
		        object_1 = (RuntimeType *)il2cpp_type_get_object_1(&TypeInfo::UnityEngine::HyperGryph::AssetType->_0.byval_arg);
		        v113 = (Object *)System::Enum::get_value((System::Enum *)&v105);
		        sub_1800036A0(TypeInfo::System::Enum);
		        v90 = TypeInfo::System::RuntimeType;
		        if ( object_1 )
		        {
		          if ( !(unsigned __int8)sub_180005080(object_1->klass, TypeInfo::System::RuntimeType) )
		            sub_18031E1F4(object_1, v90);
		        }
		        else
		        {
		          object_1 = 0LL;
		        }
		        v83 = System::Enum::InternalFormat(object_1, v113, 0LL);
		        if ( !v115
		          || (v91 = System::Text::StringBuilder::Append(v115, v83, 0LL)) == 0LL
		          || (v92 = System::Text::StringBuilder::Append(v91, (String *)" AssetHash: ", 0LL)) == 0LL )
		        {
		LABEL_142:
		          sub_1800D8250(v86, v83);
		        }
		        System::Text::StringBuilder::Append(v92, *(int64_t *)&value.m_handleObjectID, 0LL);
		        ++v84;
		      }
		      while ( v84 < v82 );
		      goto LABEL_128;
		    }
		    sub_1801F46F0(v101);
		    goto LABEL_18;
		  }
		  v95 = IFix::WrappersManagerImpl::GetPatch(2347, 0LL);
		  if ( !v95 )
		    goto LABEL_139;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v95, (Object *)v2, 0LL);
		}
		
	}
}
