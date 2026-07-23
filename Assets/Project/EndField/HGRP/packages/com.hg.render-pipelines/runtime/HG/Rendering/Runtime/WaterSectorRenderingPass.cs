using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond.Resource;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class WaterSectorRenderingPass : IPassConstructor // TypeDefIndex: 38489
	{
		// Fields
		private const int TEXTURE_SIZE = 256; // Metadata: 0x02303CED
		private const string TEXTURE_NAME = "WaterSectorTexture3x3"; // Metadata: 0x02303CEF
		private const string TEXTURE_NAME_DEBUG_NOMOD = "WaterSectorTexture3x3_Debug_NoMod"; // Metadata: 0x02303D05
		private const string TEXTURE_NAME_DEBUG_MOD3 = "WaterSectorTexture3x3_Debug_Mod3"; // Metadata: 0x02303D27
		private int m_sectorTextureSize; // 0x10
		private RTHandle m_sectorTexture3x3; // 0x18
		public TextureHandle sectorTexture3x3; // 0x20
		private bool m_needClear; // 0x30
		private string m_scenePath; // 0x38
		private SectorNode[] m_waterSectors; // 0x40
		private Queue<int> m_pendingUnloadQueue; // 0x48
		private Queue<int> m_pendingCopyQueue; // 0x50
		private Queue<SectorLoadingNode> m_pendingLoadedQueue; // 0x58
	
		// Nested types
		private enum SectorState // TypeDefIndex: 38484
		{
			Loading = 0,
			Loaded = 1,
			ToUnload = 2,
			Unload = 3
		}
	
		private struct SectorNode // TypeDefIndex: 38485
		{
			// Fields
			public bool isInTexture; // 0x00
			public ValueTuple<int, int> coords; // 0x04
			public ValueTuple<int, int> coordsMod3; // 0x0C
			public SectorState state; // 0x14
			public FAssetProxyHandle assetHandle; // 0x18
			public string texurePath; // 0x30
	
			// Methods
			public HGWaterSectorData GetData() => default; // 0x0000000189BDF31C-0x0000000189BDF374
			// HGWaterSectorData GetData()
			HGWaterSectorData *HG::Rendering::Runtime::WaterSectorRenderingPass::SectorNode::GetData(
			        WaterSectorRenderingPass_SectorNode *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3483, 0LL) )
			    return (HGWaterSectorData *)Beyond::Resource::FAssetProxyHandle::Get<System::Object>(
			                                  &this->assetHandle,
			                                  MethodInfo::Beyond::Resource::FAssetProxyHandle::Get<HG::Rendering::Runtime::HGWaterSectorData>);
			  Patch = IFix::WrappersManagerImpl::GetPatch(3483, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1252(Patch, this, 0LL);
			}
			
			public void Release() {} // 0x0000000189BDF374-0x0000000189BDF3E8
			// Void Release()
			void HG::Rendering::Runtime::WaterSectorRenderingPass::SectorNode::Release(
			        WaterSectorRenderingPass_SectorNode *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3474, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3474, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1249(Patch, this, 0LL);
			  }
			  else
			  {
			    if ( Beyond::Resource::FAssetProxyHandle::IsValid(&this->assetHandle, 0LL) )
			    {
			      Beyond::Resource::FAssetProxyHandle::Dispose(&this->assetHandle, 0LL);
			      *(_OWORD *)&this->assetHandle.m_untrackedHandle.m_handleObjectID = 0LL;
			      this->assetHandle.m_untrackedHandle.m_mainVersion = 0;
			    }
			    this->state = 3;
			  }
			}
			
		}
	
		private struct SectorLoadingNode // TypeDefIndex: 38486
		{
			// Fields
			public int sectorIndex; // 0x00
			public string texturePath; // 0x08
			public FAssetProxyHandle assetHandle; // 0x10
	
			// Methods
			public bool Ready() => default; // 0x0000000189BDF244-0x0000000189BDF2AC
			// Boolean Ready()
			bool HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode::Ready(
			        WaterSectorRenderingPass_SectorLoadingNode *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3481, 0LL) )
			    return Beyond::Resource::FAssetProxyHandle::IsInvalid(&this->assetHandle, 0LL)
			        || Beyond::Resource::FAssetProxyHandle::get_isDone(&this->assetHandle, 0LL);
			  Patch = IFix::WrappersManagerImpl::GetPatch(3481, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1251(Patch, this, 0LL);
			}
			
			public void Release() {} // 0x0000000189BDF2AC-0x0000000189BDF31C
			// Void Release()
			void HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode::Release(
			        WaterSectorRenderingPass_SectorLoadingNode *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3475, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3475, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1250(Patch, this, 0LL);
			  }
			  else if ( Beyond::Resource::FAssetProxyHandle::IsValid(&this->assetHandle, 0LL) )
			  {
			    Beyond::Resource::FAssetProxyHandle::Dispose(&this->assetHandle, 0LL);
			    *(_OWORD *)&this->assetHandle.m_untrackedHandle.m_handleObjectID = 0LL;
			    this->assetHandle.m_untrackedHandle.m_mainVersion = 0;
			  }
			}
			
		}
	
		private class SectorCopyPassData // TypeDefIndex: 38487
		{
			// Fields
			public Vector4 scaleBiasTex; // 0x10
			public Vector4 scaleBiasRT; // 0x20
			public Texture2D copyTexture; // 0x30
	
			// Constructors
			public SectorCopyPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
			
		}
	
		// Constructors
		internal WaterSectorRenderingPass() {} // 0x0000000182EDB190-0x0000000182EDB2D0
	
		// Methods
		private bool ShouldRender(bool waterSectorRendering) => default; // 0x0000000189BEF628-0x0000000189BEF680
		// Boolean ShouldRender(Boolean)
		bool HG::Rendering::Runtime::WaterSectorRenderingPass::ShouldRender(
		        WaterSectorRenderingPass *this,
		        bool waterSectorRendering,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3467, 0LL) )
		    return waterSectorRendering;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3467, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v8, v7);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1248(Patch, (Object *)this, waterSectorRendering, 0LL);
		}
		
		private void Initialize(HGWaterGlobalConfig globalConfig) {} // 0x0000000189BEE0C4-0x0000000189BEE30C
		private void Release() {} // 0x0000000184B310B0-0x0000000184B31160
		// Void Release()
		void HG::Rendering::Runtime::WaterSectorRenderingPass::Release(WaterSectorRenderingPass *this, MethodInfo *method)
		{
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v3; // rdx
		  WaterSectorRenderingPass_SectorNode__Array *v4; // rcx
		  VolumetricRenderer_VolumetricBounds *v5; // r8
		  Int32__Array **v6; // r9
		  Queue_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorLoadingNode_ *m_pendingLoadedQueue; // rax
		  Queue_1_System_Int32_ *m_pendingCopyQueue; // rax
		  Queue_1_System_Int32_ *m_pendingUnloadQueue; // rax
		  unsigned int i; // edi
		  WaterSectorRenderingPass_SectorNode__Array *m_waterSectors; // rax
		  WaterSectorRenderingPass_SectorNode *v12; // rax
		  _BYTE *v13; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  WaterSectorRenderingPass_SectorLoadingNode v15; // [rsp+20h] [rbp-58h] BYREF
		  WaterSectorRenderingPass_SectorLoadingNode v16; // [rsp+48h] [rbp-30h] BYREF
		
		  memset(&v15, 0, sizeof(v15));
		  if ( !IFix::WrappersManagerImpl::IsPatched(3473, 0LL) )
		  {
		    if ( this->fields.m_waterSectors )
		    {
		      for ( i = 0; ; ++i )
		      {
		        m_waterSectors = this->fields.m_waterSectors;
		        if ( !m_waterSectors )
		          break;
		        if ( i >= (__int64)m_waterSectors->max_length.size )
		          goto LABEL_3;
		        v12 = (WaterSectorRenderingPass_SectorNode *)sub_1804A20AC(this->fields.m_waterSectors, i);
		        HG::Rendering::Runtime::WaterSectorRenderingPass::SectorNode::Release(v12, 0LL);
		        v4 = this->fields.m_waterSectors;
		        if ( !v4 )
		          break;
		        v13 = (_BYTE *)sub_1804A20AC(v4, i);
		        *v13 = 0;
		      }
		    }
		    else
		    {
		LABEL_3:
		      this->fields.m_waterSectors = 0LL;
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_waterSectors,
		        v3,
		        v5,
		        v6,
		        *(MethodInfo **)&v15.sectorIndex,
		        (bool)v15.texturePath,
		        v15.assetHandle.m_untrackedHandle.m_handleObjectID,
		        v15.assetHandle.m_untrackedHandle.m_assetProxyObj.m_handleID,
		        *(float *)&v15.assetHandle.m_untrackedHandle.m_mainVersion,
		        v16.sectorIndex,
		        (bool)v16.texturePath,
		        v16.assetHandle.m_untrackedHandle.m_handleObjectID,
		        *(MethodInfo **)&v16.assetHandle.m_untrackedHandle.m_assetProxyObj.m_handleID);
		      while ( 1 )
		      {
		        m_pendingLoadedQueue = this->fields.m_pendingLoadedQueue;
		        if ( !m_pendingLoadedQueue )
		          goto LABEL_5;
		        if ( !m_pendingLoadedQueue->fields._size )
		          break;
		        System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Peek(
		          &v16,
		          this->fields.m_pendingLoadedQueue,
		          MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Peek);
		        v15 = v16;
		        HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode::Release(&v15, 0LL);
		        v3 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)this->fields.m_pendingLoadedQueue;
		        if ( !v3 )
		          goto LABEL_5;
		        System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Dequeue(
		          &v16,
		          (Queue_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorLoadingNode_ *)v3,
		          MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Dequeue);
		      }
		      while ( 1 )
		      {
		        m_pendingCopyQueue = this->fields.m_pendingCopyQueue;
		        if ( !m_pendingCopyQueue )
		          goto LABEL_5;
		        if ( !m_pendingCopyQueue->fields._size )
		          break;
		        System::Collections::Generic::Queue<int>::Dequeue(
		          this->fields.m_pendingCopyQueue,
		          MethodInfo::System::Collections::Generic::Queue<int>::Dequeue);
		      }
		      while ( 1 )
		      {
		        m_pendingUnloadQueue = this->fields.m_pendingUnloadQueue;
		        if ( !m_pendingUnloadQueue )
		          break;
		        if ( !m_pendingUnloadQueue->fields._size )
		          return;
		        System::Collections::Generic::Queue<int>::Dequeue(
		          this->fields.m_pendingUnloadQueue,
		          MethodInfo::System::Collections::Generic::Queue<int>::Dequeue);
		      }
		    }
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3473, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void ResizeTextures() {} // 0x0000000189BEE540-0x0000000189BEE5BC
		private void ReleaseTextures() {} // 0x0000000184B31060-0x0000000184B310B0
		// Void ReleaseTextures()
		void HG::Rendering::Runtime::WaterSectorRenderingPass::ReleaseTextures(
		        WaterSectorRenderingPass *this,
		        MethodInfo *method)
		{
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v3; // rdx
		  VolumetricRenderer_VolumetricBounds *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		  bool v10; // [rsp+58h] [rbp+30h]
		  int32_t v11; // [rsp+60h] [rbp+38h]
		  int32_t v12; // [rsp+68h] [rbp+40h]
		  float v13; // [rsp+70h] [rbp+48h]
		  int32_t v14; // [rsp+78h] [rbp+50h]
		  bool v15; // [rsp+80h] [rbp+58h]
		  bool v16; // [rsp+88h] [rbp+60h]
		  MethodInfo *v17; // [rsp+90h] [rbp+68h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3469, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3469, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.m_sectorTexture3x3 )
		  {
		    UnityEngine::Rendering::RTHandle::Release(this->fields.m_sectorTexture3x3, 0LL);
		    this->fields.m_sectorTexture3x3 = 0LL;
		    sub_18002D1B0(
		      (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_sectorTexture3x3,
		      v3,
		      v4,
		      v5,
		      v9,
		      v10,
		      v11,
		      v12,
		      v13,
		      v14,
		      v15,
		      v16,
		      v17);
		  }
		}
		
		public void Render(HGRenderGraph renderGraph, HGCamera hgCamera, HGSettingParameters settingParameter) {} // 0x0000000189BEE30C-0x0000000189BEE540
		// Void Render(HGRenderGraph, HGCamera, HGSettingParameters)
		void HG::Rendering::Runtime::WaterSectorRenderingPass::Render(
		        WaterSectorRenderingPass *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        HGSettingParameters *settingParameter,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  Component *camera; // rcx
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  ResourceHandle v13; // xmm6_8
		  uint32_t z_low; // r15d
		  bool v15; // al
		  HGManagerContext *currentManagerContext; // rax
		  HGWaterGlobalConfig *globalConfig; // rax
		  HGWaterGlobalConfig *v18; // rsi
		  String *m_scenePath; // rbx
		  String *scenePath; // rax
		  int32_t m_sectorTextureSize; // ebx
		  RTHandle *m_sectorTexture3x3; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v24; // [rsp+30h] [rbp-20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3476, 0LL) )
		  {
		    if ( hgCamera )
		    {
		      camera = (Component *)hgCamera->fields.camera;
		      if ( camera )
		      {
		        transform = UnityEngine::Component::get_transform(camera, 0LL);
		        if ( transform )
		        {
		          position = UnityEngine::Transform::get_position((Vector3 *)&v24, transform, 0LL);
		          v13 = *(ResourceHandle *)&position->x;
		          z_low = LODWORD(position->z);
		          if ( renderGraph )
		          {
		            this->fields.sectorTexture3x3 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                               &v24,
		                                               renderGraph,
		                                               this->fields.m_sectorTexture3x3,
		                                               0LL);
		            if ( settingParameter )
		            {
		              v15 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                      settingParameter->fields._waterSectorRendering_k__BackingField,
		                      MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		              if ( !HG::Rendering::Runtime::WaterSectorRenderingPass::ShouldRender(this, v15, 0LL) )
		                return;
		              currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		              if ( currentManagerContext )
		              {
		                camera = (Component *)currentManagerContext->fields._waterManager_k__BackingField;
		                if ( camera )
		                {
		                  globalConfig = HG::Rendering::Runtime::HGWaterManager::get_globalConfig((HGWaterManager *)camera, 0LL);
		                  v18 = globalConfig;
		                  if ( !this->fields.m_waterSectors )
		                  {
		LABEL_14:
		                    HG::Rendering::Runtime::WaterSectorRenderingPass::Release(this, 0LL);
		                    HG::Rendering::Runtime::WaterSectorRenderingPass::Initialize(this, v18, 0LL);
		                    m_sectorTexture3x3 = this->fields.m_sectorTexture3x3;
		                    this->fields.m_needClear = 1;
		                    this->fields.sectorTexture3x3 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                                       &v24,
		                                                       renderGraph,
		                                                       m_sectorTexture3x3,
		                                                       0LL);
		LABEL_15:
		                    HG::Rendering::Runtime::WaterSectorRenderingPass::SectorUnloadUpdate(this, 0LL);
		                    v24.handle = v13;
		                    v24.fallBackResource.m_Value = z_low;
		                    HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingUpdate(
		                      this,
		                      v18,
		                      (Vector3 *)&v24,
		                      0LL);
		                    HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadedUpdate(this, 0LL);
		                    v24.handle = v13;
		                    v24.fallBackResource.m_Value = z_low;
		                    HG::Rendering::Runtime::WaterSectorRenderingPass::SectorTextureCopyUpdate(
		                      this,
		                      v18,
		                      (Vector3 *)&v24,
		                      0LL);
		                    v24.handle = v13;
		                    v24.fallBackResource.m_Value = z_low;
		                    HG::Rendering::Runtime::WaterSectorRenderingPass::SectorTextureCopyPass(
		                      this,
		                      renderGraph,
		                      v18,
		                      (Vector3 *)&v24,
		                      0LL);
		                    return;
		                  }
		                  m_scenePath = this->fields.m_scenePath;
		                  if ( globalConfig )
		                  {
		                    scenePath = HG::Rendering::Runtime::HGWaterGlobalConfig::get_scenePath(globalConfig, 0LL);
		                    if ( !System::String::op_Inequality(m_scenePath, scenePath, 0LL) )
		                    {
		                      m_sectorTextureSize = this->fields.m_sectorTextureSize;
		                      if ( m_sectorTextureSize == HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorTextureSize(
		                                                    v18,
		                                                    0LL) )
		                        goto LABEL_15;
		                    }
		                    goto LABEL_14;
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_17:
		    sub_1800D8260(camera, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3476, 0LL);
		  if ( !Patch )
		    goto LABEL_17;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
		    (ILFixDynamicMethodWrapper_10 *)Patch,
		    (Object *)this,
		    (Object *)renderGraph,
		    (Object *)hgCamera,
		    (Object *)settingParameter,
		    0LL);
		}
		
		private void SectorUnloadUpdate() {} // 0x0000000189BEF570-0x0000000189BEF628
		// Void SectorUnloadUpdate()
		void HG::Rendering::Runtime::WaterSectorRenderingPass::SectorUnloadUpdate(
		        WaterSectorRenderingPass *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Queue_1_System_Int32_ *m_waterSectors; // rcx
		  Queue_1_System_Int32_ *m_pendingUnloadQueue; // rax
		  signed int v6; // eax
		  __int64 v7; // rdi
		  WaterSectorRenderingPass_SectorNode *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3477, 0LL) )
		  {
		    while ( 1 )
		    {
		      m_pendingUnloadQueue = this->fields.m_pendingUnloadQueue;
		      if ( !m_pendingUnloadQueue )
		        break;
		      if ( !m_pendingUnloadQueue->fields._size )
		        return;
		      v6 = System::Collections::Generic::Queue<unsigned int>::Peek(
		             (Queue_1_System_UInt32_ *)this->fields.m_pendingUnloadQueue,
		             MethodInfo::System::Collections::Generic::Queue<int>::Peek);
		      m_waterSectors = this->fields.m_pendingUnloadQueue;
		      v7 = v6;
		      if ( !m_waterSectors )
		        break;
		      System::Collections::Generic::Queue<int>::Dequeue(
		        m_waterSectors,
		        MethodInfo::System::Collections::Generic::Queue<int>::Dequeue);
		      m_waterSectors = (Queue_1_System_Int32_ *)this->fields.m_waterSectors;
		      if ( !m_waterSectors )
		        break;
		      if ( *(_DWORD *)(sub_1804A20AC(m_waterSectors, v7) + 20) == 2 )
		      {
		        m_waterSectors = (Queue_1_System_Int32_ *)this->fields.m_waterSectors;
		        if ( !m_waterSectors )
		          break;
		        v8 = (WaterSectorRenderingPass_SectorNode *)sub_1804A20AC(m_waterSectors, v7);
		        HG::Rendering::Runtime::WaterSectorRenderingPass::SectorNode::Release(v8, 0LL);
		      }
		    }
		LABEL_10:
		    sub_1800D8260(m_waterSectors, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3477, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void SectorLoadingUpdate(HGWaterGlobalConfig globalConfig, Vector3 pos) {} // 0x0000000189BEE784-0x0000000189BEEA58
		// Void SectorLoadingUpdate(HGWaterGlobalConfig, Vector3)
		void HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingUpdate(
		        WaterSectorRenderingPass *this,
		        HGWaterGlobalConfig *globalConfig,
		        Vector3 *pos,
		        MethodInfo *method)
		{
		  WaterSectorRenderingPass_SectorNode__Array *m_waterSectors; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float v9; // eax
		  unsigned __int64 SectorCoords; // rax
		  int32_t v11; // edi
		  unsigned __int64 v12; // rax
		  int v13; // r12d
		  int v14; // r15d
		  int32_t SectorIndex; // eax
		  __int64 v16; // rsi
		  __int128 v17; // xmm2
		  String *texurePath; // xmm1_8
		  __int128 v19; // xmm0
		  bool v20; // zf
		  Boolean__Array *sectorDataExists; // rax
		  String__Array *sectorDataPaths; // rax
		  Object *v23; // rbx
		  StringPathHash v24; // rbx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v25; // rdx
		  VolumetricRenderer_VolumetricBounds *v26; // r8
		  Int32__Array **v27; // r9
		  float z; // eax
		  MethodInfo *v29; // [rsp+28h] [rbp-79h]
		  bool v30; // [rsp+30h] [rbp-71h]
		  Vector3 v31; // [rsp+38h] [rbp-69h] BYREF
		  Object *param1; // [rsp+48h] [rbp-59h]
		  __int128 v33; // [rsp+50h] [rbp-51h] BYREF
		  __int128 v34; // [rsp+60h] [rbp-41h]
		  __int64 m_mainVersion; // [rsp+70h] [rbp-31h]
		  FAssetProxyHandle v36; // [rsp+78h] [rbp-29h] BYREF
		  __int128 v37; // [rsp+98h] [rbp-9h] BYREF
		  __int128 v38; // [rsp+A8h] [rbp+7h]
		  __int128 v39; // [rsp+B8h] [rbp+17h]
		  String *v40; // [rsp+C8h] [rbp+27h]
		
		  m_mainVersion = 0LL;
		  v33 = 0LL;
		  v34 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3478, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3478, 0LL);
		    if ( Patch )
		    {
		      z = pos->z;
		      *(_QWORD *)&v31.x = *(_QWORD *)&pos->x;
		      v31.z = z;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_836(Patch, (Object *)this, (Object *)globalConfig, &v31, 0LL);
		      return;
		    }
		LABEL_25:
		    sub_1800D8260(Patch, m_waterSectors);
		  }
		  if ( !globalConfig )
		    goto LABEL_25;
		  v9 = pos->z;
		  *(_QWORD *)&v31.x = *(_QWORD *)&pos->x;
		  v31.z = v9;
		  SectorCoords = (unsigned __int64)HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorCoords(globalConfig, &v31, 0LL);
		  v11 = SectorCoords;
		  v12 = HIDWORD(SectorCoords);
		  *(_QWORD *)&v31.x = v12;
		  v13 = -1;
		  do
		  {
		    v14 = -1;
		    do
		    {
		      SectorIndex = HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorIndex(globalConfig, v11 + v13, v14 + v12, 0LL);
		      v16 = SectorIndex;
		      if ( SectorIndex != -1 )
		      {
		        m_waterSectors = this->fields.m_waterSectors;
		        if ( !m_waterSectors )
		          goto LABEL_25;
		        if ( (unsigned int)SectorIndex >= m_waterSectors->max_length.size )
		          goto LABEL_23;
		        v17 = *(_OWORD *)&m_waterSectors->vector[SectorIndex].coordsMod3.Item2;
		        texurePath = m_waterSectors->vector[SectorIndex].texurePath;
		        v37 = *(_OWORD *)&m_waterSectors->vector[SectorIndex].isInTexture;
		        v19 = *(_OWORD *)&m_waterSectors->vector[SectorIndex].assetHandle.m_untrackedHandle.m_assetProxyObj.m_handleID;
		        v40 = texurePath;
		        v39 = v19;
		        if ( DWORD1(v17) == 3 )
		        {
		          v20 = !m_waterSectors->vector[SectorIndex].isInTexture;
		          v39 = v19;
		          v40 = texurePath;
		          v38 = v17;
		          if ( v20 )
		          {
		            sectorDataExists = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorDataExists(globalConfig, 0LL);
		            if ( !sectorDataExists )
		              goto LABEL_25;
		            if ( (unsigned int)v16 >= sectorDataExists->max_length.size )
		              goto LABEL_23;
		            if ( sectorDataExists->vector[v16] )
		            {
		              sectorDataPaths = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorDataPaths(globalConfig, 0LL);
		              if ( !sectorDataPaths )
		                goto LABEL_25;
		              if ( (unsigned int)v16 >= sectorDataPaths->max_length.size )
		LABEL_23:
		                sub_1800D2AB0(Patch, m_waterSectors);
		              param1 = (Object *)sectorDataPaths->vector[v16];
		              v23 = param1;
		              sub_1800036A0(TypeInfo::Beyond::Resource::HashStringPathProcessor);
		              v24.hash = sub_182F75F50(v23);
		              sub_1800036A0(TypeInfo::Beyond::Resource::ResourceManager);
		              Beyond::Resource::ResourceManager::LoadAsync<System::Object>(
		                (FAssetProxyHandle *)&v37,
		                v24,
		                RootCategory__Enum_Main,
		                EResourceRequestPriority__Enum_Default,
		                MethodInfo::Beyond::Resource::ResourceManager::LoadAsync<HG::Rendering::Runtime::HGWaterSectorData>);
		              v36.m_untrackedHandle.m_mainVersion = v38;
		              *(_OWORD *)&v36.m_untrackedHandle.m_handleObjectID = v37;
		              if ( Beyond::Resource::FAssetProxyHandle::IsValid(&v36, 0LL) )
		              {
		                m_mainVersion = (unsigned int)v36.m_untrackedHandle.m_mainVersion;
		                v34 = *(_OWORD *)&v36.m_untrackedHandle.m_handleObjectID;
		                *((_QWORD *)&v33 + 1) = param1;
		                ((void (__stdcall *)(VolumetricRenderer_VolumetricRenderItem *, Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *, VolumetricRenderer_VolumetricBounds *, Int32__Array **, MethodInfo *, bool, int32_t, int32_t, float, int32_t))sub_18002D1B0)(
		                  (VolumetricRenderer_VolumetricRenderItem *)((char *)&v33 + 8),
		                  v25,
		                  v26,
		                  v27,
		                  v29,
		                  v30,
		                  SLODWORD(v31.x),
		                  SLODWORD(v31.z),
		                  *(float *)&param1,
		                  v16);
		                Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_pendingLoadedQueue;
		                if ( !Patch )
		                  goto LABEL_25;
		                v37 = v33;
		                *(_QWORD *)&v39 = m_mainVersion;
		                v38 = v34;
		                System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Enqueue(
		                  (Queue_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorLoadingNode_ *)Patch,
		                  (WaterSectorRenderingPass_SectorLoadingNode *)&v37,
		                  MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Enqueue);
		                Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_waterSectors;
		                if ( !Patch )
		                  goto LABEL_25;
		                *(_DWORD *)(sub_1804A20AC(Patch, v16) + 20) = 0;
		              }
		              else
		              {
		                HG::Rendering::HGRPLogger::LogCritical<System::Object>(
		                  (String *)"Fail to load water sector asset: assetPath({0})",
		                  param1,
		                  MethodInfo::HG::Rendering::HGRPLogger::LogCritical<System::String>);
		              }
		            }
		          }
		        }
		      }
		      *(float *)&v12 = v31.x;
		      ++v14;
		    }
		    while ( v14 <= 1 );
		    ++v13;
		  }
		  while ( v13 <= 1 );
		}
		
		private void SectorLoadedUpdate() {} // 0x0000000189BEE5BC-0x0000000189BEE784
		// Void SectorLoadedUpdate()
		void HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadedUpdate(
		        WaterSectorRenderingPass *this,
		        MethodInfo *method)
		{
		  Queue_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorLoadingNode_ *v3; // rdx
		  WaterSectorRenderingPass_SectorNode__Array *m_waterSectors; // rcx
		  Queue_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorLoadingNode_ *m_pendingLoadedQueue; // rax
		  int32_t m_mainVersion; // ebx
		  __int64 v7; // rax
		  WaterSectorRenderingPass_SectorNode__Array *v8; // rbx
		  __int64 sectorIndex; // rsi
		  WaterSectorRenderingPass_SectorNode__Array *v10; // rcx
		  __int64 v11; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v12; // rdx
		  VolumetricRenderer_VolumetricBounds *v13; // r8
		  Int32__Array **v14; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v16; // [rsp+20h] [rbp-60h]
		  __int128 v17; // [rsp+20h] [rbp-60h]
		  WaterSectorRenderingPass_SectorLoadingNode v18; // [rsp+30h] [rbp-50h] BYREF
		  WaterSectorRenderingPass_SectorLoadingNode v19; // [rsp+58h] [rbp-28h] BYREF
		
		  memset(&v18, 0, sizeof(v18));
		  if ( !IFix::WrappersManagerImpl::IsPatched(3480, 0LL) )
		  {
		    while ( 1 )
		    {
		      m_pendingLoadedQueue = this->fields.m_pendingLoadedQueue;
		      if ( !m_pendingLoadedQueue )
		        break;
		      if ( !m_pendingLoadedQueue->fields._size )
		        return;
		      System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Peek(
		        &v19,
		        this->fields.m_pendingLoadedQueue,
		        MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Peek);
		      v18 = v19;
		      if ( !HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode::Ready(&v18, 0LL) )
		        return;
		      m_waterSectors = this->fields.m_waterSectors;
		      if ( !m_waterSectors )
		        break;
		      if ( !*(_DWORD *)(sub_1804A20AC(m_waterSectors, v18.sectorIndex) + 20)
		        && Beyond::Resource::FAssetProxyHandle::IsValid(&v18.assetHandle, 0LL) )
		      {
		        m_waterSectors = this->fields.m_waterSectors;
		        if ( !m_waterSectors )
		          break;
		        m_mainVersion = v18.assetHandle.m_untrackedHandle.m_mainVersion;
		        v16 = *(_OWORD *)&v18.assetHandle.m_untrackedHandle.m_handleObjectID;
		        v7 = sub_1804A20AC(m_waterSectors, v18.sectorIndex);
		        *(_OWORD *)(v7 + 24) = v16;
		        *(_DWORD *)(v7 + 40) = m_mainVersion;
		        m_waterSectors = this->fields.m_waterSectors;
		        if ( !m_waterSectors )
		          break;
		        *(_DWORD *)(sub_1804A20AC(m_waterSectors, v18.sectorIndex) + 20) = 1;
		        v8 = this->fields.m_waterSectors;
		        sectorIndex = v18.sectorIndex;
		        if ( !v8 )
		          break;
		        v10 = this->fields.m_waterSectors;
		        v17 = *(_OWORD *)&v18.sectorIndex;
		        *(_QWORD *)&v19.assetHandle.m_untrackedHandle.m_mainVersion = *(_QWORD *)&v18.assetHandle.m_untrackedHandle.m_mainVersion;
		        *(_OWORD *)&v19.assetHandle.m_untrackedHandle.m_handleObjectID = *(_OWORD *)&v18.assetHandle.m_untrackedHandle.m_handleObjectID;
		        *(_QWORD *)(sub_1804A20AC(v10, v18.sectorIndex) + 48) = _mm_srli_si128(*(__m128i *)&v18.sectorIndex, 8).m128i_u64[0];
		        v11 = sub_1804A20AC(v8, sectorIndex);
		        sub_18002D1B0(
		          (VolumetricRenderer_VolumetricRenderItem *)(v11 + 48),
		          v12,
		          v13,
		          v14,
		          (MethodInfo *)v17,
		          SBYTE8(v17),
		          v18.sectorIndex,
		          (int32_t)v18.texturePath,
		          *(float *)&v18.assetHandle.m_untrackedHandle.m_handleObjectID,
		          v18.assetHandle.m_untrackedHandle.m_assetProxyObj.m_handleID,
		          v18.assetHandle.m_untrackedHandle.m_mainVersion,
		          v19.sectorIndex,
		          (MethodInfo *)v19.texturePath);
		      }
		      v3 = this->fields.m_pendingLoadedQueue;
		      if ( !v3 )
		        break;
		      System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Dequeue(
		        &v19,
		        v3,
		        MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Dequeue);
		    }
		LABEL_15:
		    sub_1800D8260(m_waterSectors, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3480, 0LL);
		  if ( !Patch )
		    goto LABEL_15;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void SectorTextureCopyUpdate(HGWaterGlobalConfig globalConfig, Vector3 pos) {} // 0x0000000189BEF310-0x0000000189BEF570
		// Void SectorTextureCopyUpdate(HGWaterGlobalConfig, Vector3)
		void HG::Rendering::Runtime::WaterSectorRenderingPass::SectorTextureCopyUpdate(
		        WaterSectorRenderingPass *this,
		        HGWaterGlobalConfig *globalConfig,
		        Vector3 *pos,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float v9; // eax
		  unsigned __int64 SectorCoords; // rax
		  unsigned __int64 v11; // r13
		  int32_t v12; // ebx
		  int v13; // r12d
		  int v14; // r15d
		  int32_t SectorIndex; // eax
		  __int64 v16; // rbp
		  Boolean__Array *sectorDataExists; // rax
		  WaterSectorRenderingPass_SectorNode *v18; // rax
		  Object_1 *Data; // rdi
		  Object_1 *klass; // rdi
		  float z; // eax
		  Vector3 v22; // [rsp+30h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3482, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3482, 0LL);
		    if ( !Patch )
		      goto LABEL_31;
		    z = pos->z;
		    *(_QWORD *)&v22.x = *(_QWORD *)&pos->x;
		    v22.z = z;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_836(Patch, (Object *)this, (Object *)globalConfig, &v22, 0LL);
		  }
		  else
		  {
		    if ( !globalConfig )
		      goto LABEL_31;
		    v9 = pos->z;
		    *(_QWORD *)&v22.x = *(_QWORD *)&pos->x;
		    v22.z = v9;
		    SectorCoords = (unsigned __int64)HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorCoords(
		                                       globalConfig,
		                                       &v22,
		                                       0LL);
		    Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_pendingCopyQueue;
		    v11 = HIDWORD(SectorCoords);
		    v12 = SectorCoords;
		    if ( !Patch )
		      goto LABEL_31;
		    System::Collections::Generic::Queue<UnityEngine::Vector3>::Clear(
		      (Queue_1_UnityEngine_Vector3_ *)Patch,
		      MethodInfo::System::Collections::Generic::Queue<int>::Clear);
		    v13 = -1;
		    do
		    {
		      v14 = -1;
		      do
		      {
		        SectorIndex = HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorIndex(
		                        globalConfig,
		                        v12 + v13,
		                        v14 + v11,
		                        0LL);
		        v16 = SectorIndex;
		        if ( SectorIndex != -1 )
		        {
		          sectorDataExists = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorDataExists(globalConfig, 0LL);
		          if ( !sectorDataExists )
		            goto LABEL_31;
		          if ( (unsigned int)v16 >= sectorDataExists->max_length.size )
		            sub_1800D2AB0(Patch, v7);
		          if ( sectorDataExists->vector[v16] )
		          {
		            Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_waterSectors;
		            if ( !Patch )
		              goto LABEL_31;
		            if ( !*(_BYTE *)sub_1804A20AC(Patch, v16) )
		            {
		              Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_waterSectors;
		              if ( !Patch )
		                goto LABEL_31;
		              if ( *(_DWORD *)(sub_1804A20AC(Patch, v16) + 20) == 2 )
		              {
		                Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_waterSectors;
		                if ( !Patch )
		                  goto LABEL_31;
		                *(_DWORD *)(sub_1804A20AC(Patch, v16) + 20) = 1;
		              }
		              Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_waterSectors;
		              if ( !Patch )
		                goto LABEL_31;
		              if ( *(_DWORD *)(sub_1804A20AC(Patch, v16) + 20) != 1 )
		              {
		                Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_pendingCopyQueue;
		                if ( Patch )
		                {
		                  System::Collections::Generic::Queue<UnityEngine::Vector3>::Clear(
		                    (Queue_1_UnityEngine_Vector3_ *)Patch,
		                    MethodInfo::System::Collections::Generic::Queue<int>::Clear);
		                  return;
		                }
		LABEL_31:
		                sub_1800D8260(Patch, v7);
		              }
		              Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_waterSectors;
		              if ( !Patch )
		                goto LABEL_31;
		              v18 = (WaterSectorRenderingPass_SectorNode *)sub_1804A20AC(Patch, v16);
		              Data = (Object_1 *)HG::Rendering::Runtime::WaterSectorRenderingPass::SectorNode::GetData(v18, 0LL);
		              sub_1800036A0(TypeInfo::UnityEngine::Object);
		              if ( !UnityEngine::Object::op_Equality(Data, 0LL, 0LL) )
		              {
		                if ( !Data )
		                  goto LABEL_31;
		                klass = (Object_1 *)Data[1].klass;
		                sub_1800036A0(TypeInfo::UnityEngine::Object);
		                if ( !UnityEngine::Object::op_Equality(klass, 0LL, 0LL) )
		                {
		                  Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_pendingCopyQueue;
		                  if ( !Patch )
		                    goto LABEL_31;
		                  System::Collections::Generic::Queue<int>::Enqueue(
		                    (Queue_1_System_Int32_ *)Patch,
		                    v16,
		                    MethodInfo::System::Collections::Generic::Queue<int>::Enqueue);
		                }
		              }
		            }
		          }
		        }
		        ++v14;
		      }
		      while ( v14 <= 1 );
		      ++v13;
		    }
		    while ( v13 <= 1 );
		  }
		}
		
		private void SectorTextureCopyPass(HGRenderGraph renderGraph, HGWaterGlobalConfig globalConfig, Vector3 pos) {} // 0x0000000189BEEA58-0x0000000189BEF310
		// Void SectorTextureCopyPass(HGRenderGraph, HGWaterGlobalConfig, Vector3)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::WaterSectorRenderingPass::SectorTextureCopyPass(
		        WaterSectorRenderingPass *this,
		        HGRenderGraph *renderGraph,
		        HGWaterGlobalConfig *globalConfig,
		        Vector3 *pos,
		        MethodInfo *method)
		{
		  HGRenderGraph *v7; // r13
		  WaterSectorRenderingPass *v8; // r14
		  __int64 v9; // rdx
		  Queue_1_System_Int32_ *m_pendingUnloadQueue; // rcx
		  Queue_1_System_Int32_ *m_pendingCopyQueue; // rbx
		  unsigned __int64 SectorCoords; // rax
		  int32_t v13; // ebx
		  unsigned __int64 v14; // r13
		  int32_t sectorCoordsMin; // r12d
		  int v16; // ebx
		  int32_t i; // r15d
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  ProfilingSampler *v20; // rax
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  int v23; // r8d
		  __m128i si128; // xmm6
		  RenderFunc_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorCopyPassData_ *_9__28_0; // rbx
		  Object *v26; // rsi
		  RenderFunc_1_System_Object_ *v27; // rax
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  unsigned __int64 v30; // r8
		  unsigned __int64 v31; // rdx
		  signed __int64 v32; // rtt
		  __m128i v33; // xmm8
		  Queue_1_System_Int32_ *v34; // rax
		  int32_t v35; // eax
		  __int64 v36; // r12
		  ProfilingSampler *v37; // rax
		  __int64 v38; // rdx
		  WaterSectorRenderingPass_SectorNode__Array *m_waterSectors; // rcx
		  __int64 v40; // rdx
		  HGRenderGraphPass *v41; // rbx
		  WaterSectorRenderingPass_SectorNode__Array *v42; // rcx
		  WaterSectorRenderingPass_SectorNode *v43; // rax
		  HGWaterSectorData *Data; // rax
		  __int64 v45; // rdx
		  Object *v46; // rcx
		  Object *v47; // rdx
		  Object__Class *waterSectorTexture0; // rcx
		  unsigned int v49; // edx
		  unsigned __int64 v50; // r8
		  char v51; // dl
		  signed __int64 v52; // rtt
		  RenderFunc_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorCopyPassData_ *_9__28_1; // rbx
		  Object *v54; // r15
		  RenderFunc_1_System_Object_ *v55; // rax
		  __int64 v56; // rdx
		  __int64 v57; // rcx
		  unsigned __int64 v58; // rdx
		  unsigned __int64 v59; // r8
		  signed __int64 v60; // rtt
		  __int64 v61; // rdx
		  __int64 v62; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rbx
		  int32_t SectorIndex; // [rsp+50h] [rbp-128h]
		  int32_t v65; // [rsp+50h] [rbp-128h]
		  Object *v66; // [rsp+58h] [rbp-120h] BYREF
		  Object v67; // [rsp+60h] [rbp-118h] BYREF
		  HGRenderGraphBuilder v68; // [rsp+70h] [rbp-108h] BYREF
		  __m128i v69; // [rsp+90h] [rbp-E8h] BYREF
		  __int64 v70; // [rsp+A0h] [rbp-D8h] BYREF
		  HGRenderGraphBuilder v71; // [rsp+A8h] [rbp-D0h] BYREF
		  HGRenderGraphBuilder v72; // [rsp+C8h] [rbp-B0h] BYREF
		  Il2CppExceptionWrapper *v73; // [rsp+E8h] [rbp-90h] BYREF
		  Il2CppExceptionWrapper *v74; // [rsp+F0h] [rbp-88h] BYREF
		  TextureHandle v75[5]; // [rsp+F8h] [rbp-80h] BYREF
		
		  v7 = renderGraph;
		  v8 = this;
		  memset(&v71, 0, sizeof(v71));
		  v70 = 0LL;
		  memset(&v72, 0, sizeof(v72));
		  v66 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3484, 0LL) )
		  {
		    m_pendingCopyQueue = v8->fields.m_pendingCopyQueue;
		    if ( !m_pendingCopyQueue )
		      sub_1800D8260(m_pendingUnloadQueue, v9);
		    if ( m_pendingCopyQueue->fields._size > 0 )
		    {
		      if ( !globalConfig )
		        sub_1800D8260(m_pendingUnloadQueue, v9);
		      v68.m_RenderPass = *(HGRenderGraphPass **)&pos->x;
		      *(float *)&v68.m_Resources = pos->z;
		      SectorCoords = (unsigned __int64)HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorCoords(
		                                         globalConfig,
		                                         (Vector3 *)&v68,
		                                         0LL);
		      v13 = SectorCoords;
		      v14 = HIDWORD(SectorCoords);
		      v68.m_RenderPass = (HGRenderGraphPass *)HIDWORD(SectorCoords);
		      sectorCoordsMin = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMin(globalConfig, 0LL);
		      v16 = -v13;
		      while ( sectorCoordsMin <= HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMax(globalConfig, 0LL) )
		      {
		        for ( i = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMin(globalConfig, 0LL);
		              i <= HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMax(globalConfig, 0LL);
		              ++i )
		        {
		          SectorIndex = HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorIndex(
		                          globalConfig,
		                          sectorCoordsMin,
		                          i,
		                          0LL);
		          if ( (int)sub_1833FD1B0((unsigned int)(v16 + sectorCoordsMin)) > 1
		            || (int)sub_1833FD1B0((unsigned int)(i - v14)) > 1 )
		          {
		            if ( !v8->fields.m_waterSectors )
		              sub_1800D8260(v19, v18);
		            *(_BYTE *)sub_1804A20AC(v8->fields.m_waterSectors, SectorIndex) = 0;
		            LODWORD(v14) = v68.m_RenderPass;
		          }
		        }
		        ++sectorCoordsMin;
		      }
		      v7 = renderGraph;
		    }
		    if ( v8->fields.m_needClear )
		    {
		      v20 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x31u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !v7 )
		        sub_1800D8260(v22, v21);
		      v71 = *(HGRenderGraphBuilder *)sub_1808AFCC4((unsigned int)v75, (_DWORD)v7, v23, (unsigned int)&v70, (__int64)v20);
		      v67.klass = 0LL;
		      v67.monitor = (MonitorData *)&v71;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v71, 0, 0LL);
		        si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		        v69 = si128;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v68,
		          &v71,
		          &v8->fields.sectorTexture3x3,
		          0,
		          RenderBufferLoadAction__Enum_Clear,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&v69,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c);
		        _9__28_0 = TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c->static_fields->__9__28_0;
		        if ( !_9__28_0 )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c);
		          v26 = (Object *)TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c->static_fields->__9;
		          v27 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorCopyPassData>);
		          _9__28_0 = (RenderFunc_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorCopyPassData_ *)v27;
		          if ( !v27 )
		            sub_1800D8250(v29, v28);
		          HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		            v27,
		            v26,
		            MethodInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c::_SectorTextureCopyPass_b__28_0,
		            0LL);
		          TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c->static_fields->__9__28_0 = _9__28_0;
		          if ( dword_18F35FD08 )
		          {
		            v30 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c->static_fields->__9__28_0 >> 12) & 0x1FFFFF) >> 6;
		            v31 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c->static_fields->__9__28_0 >> 12) & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v30 + 36190]);
		            do
		              v32 = qword_18F0BCBA0[v30 + 36190];
		            while ( v32 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v30 + 36190], v32 | (1LL << v31), v32) );
		          }
		        }
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v71,
		          (RenderFunc_1_System_Object_ *)_9__28_0,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorCopyPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v73 )
		      {
		        v67.klass = (Object__Class *)v73->ex;
		        sub_180268AE0(&v67);
		        v8 = this;
		        si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		        v7 = renderGraph;
		        goto LABEL_26;
		      }
		      sub_180268AE0(&v67);
		LABEL_26:
		      v8->fields.m_needClear = 0;
		    }
		    else
		    {
		      si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		    }
		    v33 = _mm_load_si128((const __m128i *)&xmmword_18B959740);
		    while ( 1 )
		    {
		      v34 = v8->fields.m_pendingCopyQueue;
		      if ( !v34 )
		        break;
		      if ( v34->fields._size <= 0 )
		        return;
		      v35 = System::Collections::Generic::Queue<int>::Dequeue(
		              v8->fields.m_pendingCopyQueue,
		              MethodInfo::System::Collections::Generic::Queue<int>::Dequeue);
		      v36 = v35;
		      v65 = v35;
		      v37 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x31u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !v7 )
		        break;
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v68,
		        v7,
		        (String *)"Water Sector Copy",
		        &v66,
		        v37,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorCopyPassData>);
		      v72 = v68;
		      v69.m128i_i64[0] = 0LL;
		      v69.m128i_i64[1] = (__int64)&v72;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v72, 0, 0LL);
		        m_waterSectors = v8->fields.m_waterSectors;
		        if ( !m_waterSectors )
		          sub_1800D8250(0LL, v38);
		        v41 = *(HGRenderGraphPass **)(sub_1804A20AC(m_waterSectors, v36) + 12);
		        v68.m_RenderPass = v41;
		        v42 = v8->fields.m_waterSectors;
		        if ( !v42 )
		          sub_1800D8250(0LL, v40);
		        v43 = (WaterSectorRenderingPass_SectorNode *)sub_1804A20AC(v42, v36);
		        Data = HG::Rendering::Runtime::WaterSectorRenderingPass::SectorNode::GetData(v43, 0LL);
		        if ( !v66 )
		          sub_1800D8250(0LL, v45);
		        v66[1] = (Object)v33;
		        v67.klass = (Object__Class *)0x3EAAAAAB3EAAAAABLL;
		        *(float *)&v67.monitor = (float)(int)v41 / 3.0;
		        *((float *)&v67.monitor + 1) = (float)SHIDWORD(v68.m_RenderPass) / 3.0;
		        v46 = v66;
		        if ( !v66 )
		          sub_1800D8250(0LL, v45);
		        v66[2] = v67;
		        v47 = v66;
		        if ( !Data )
		          sub_1800D8250(v46, v66);
		        waterSectorTexture0 = (Object__Class *)Data->fields.waterSectorTexture0;
		        if ( !v66 )
		          sub_1800D8250(waterSectorTexture0, 0LL);
		        v66[3].klass = waterSectorTexture0;
		        if ( dword_18F35FD08 )
		        {
		          v49 = ((unsigned __int64)&v47[3] >> 12) & 0x1FFFFF;
		          v50 = (unsigned __int64)v49 >> 6;
		          v51 = v49 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v50 + 36190]);
		          do
		            v52 = qword_18F0BCBA0[v50 + 36190];
		          while ( v52 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v50 + 36190], v52 | (1LL << v51), v52) );
		        }
		        *(__m128i *)&v68.m_RenderPass = si128;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          v75,
		          &v72,
		          &v8->fields.sectorTexture3x3,
		          0,
		          RenderBufferLoadAction__Enum_Load,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&v68,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c);
		        _9__28_1 = TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c->static_fields->__9__28_1;
		        if ( !_9__28_1 )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c);
		          v54 = (Object *)TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c->static_fields->__9;
		          v55 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorCopyPassData>);
		          _9__28_1 = (RenderFunc_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorCopyPassData_ *)v55;
		          if ( !v55 )
		            sub_1800D8250(v57, v56);
		          HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		            v55,
		            v54,
		            MethodInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c::_SectorTextureCopyPass_b__28_1,
		            0LL);
		          TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c->static_fields->__9__28_1 = _9__28_1;
		          if ( dword_18F35FD08 )
		          {
		            v58 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c->static_fields->__9__28_1 >> 12) & 0x1FFFFF) >> 6;
		            v59 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c->static_fields->__9__28_1 >> 12) & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v58 + 36190]);
		            do
		              v60 = qword_18F0BCBA0[v58 + 36190];
		            while ( v60 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v58 + 36190], v60 | (1LL << v59), v60) );
		          }
		        }
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v72,
		          (RenderFunc_1_System_Object_ *)_9__28_1,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorCopyPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v74 )
		      {
		        *(Il2CppExceptionWrapper *)v69.m128i_i8 = (Il2CppExceptionWrapper)v74->ex;
		        sub_180268AE0(&v69);
		        v8 = this;
		        LODWORD(v36) = v65;
		        si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		        v33 = _mm_load_si128((const __m128i *)&xmmword_18B959740);
		        v7 = renderGraph;
		        goto LABEL_49;
		      }
		      sub_180268AE0(&v69);
		LABEL_49:
		      m_pendingUnloadQueue = v8->fields.m_pendingUnloadQueue;
		      if ( !m_pendingUnloadQueue )
		        break;
		      System::Collections::Generic::Queue<int>::Enqueue(
		        m_pendingUnloadQueue,
		        v36,
		        MethodInfo::System::Collections::Generic::Queue<int>::Enqueue);
		      m_pendingUnloadQueue = (Queue_1_System_Int32_ *)v8->fields.m_waterSectors;
		      if ( !m_pendingUnloadQueue )
		        break;
		      *(_BYTE *)sub_1804A20AC(m_pendingUnloadQueue, (int)v36) = 1;
		      m_pendingUnloadQueue = (Queue_1_System_Int32_ *)v8->fields.m_waterSectors;
		      if ( !m_pendingUnloadQueue )
		        break;
		      *(_DWORD *)(sub_1804A20AC(m_pendingUnloadQueue, (int)v36) + 20) = 2;
		    }
		    sub_1800D8250(m_pendingUnloadQueue, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3484, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v62, v61);
		  v68.m_RenderPass = *(HGRenderGraphPass **)&pos->x;
		  *(float *)&v68.m_Resources = pos->z;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1254(
		    Patch,
		    (Object *)v8,
		    (Object *)v7,
		    (Object *)globalConfig,
		    (Vector3 *)&v68,
		    0LL);
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BEE070-0x0000000189BEE0C4
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::WaterSectorRenderingPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        WaterSectorRenderingPass *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3489, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3489, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BEE01C-0x0000000189BEE070
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::WaterSectorRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        WaterSectorRenderingPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3490, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3490, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BEDFC8-0x0000000189BEE01C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::WaterSectorRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        WaterSectorRenderingPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3491, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3491, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184B31010-0x0000000184B31060
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::WaterSectorRenderingPass::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        WaterSectorRenderingPass *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3492, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3492, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::WaterSectorRenderingPass::Release(this, 0LL);
		    HG::Rendering::Runtime::WaterSectorRenderingPass::ReleaseTextures(this, 0LL);
		  }
		}
		
	}
}
