using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class HGUtils // TypeDefIndex: 38572
	{
		// Fields
		internal const PerObjectData k_RendererConfigurationBakedLighting = PerObjectData.None | PerObjectData.LightProbe | PerObjectData.ReflectionProbes | PerObjectData.LightProbeProxyVolume | PerObjectData.Lightmaps; // Metadata: 0x02303EDE
		internal const PerObjectData k_RendererConfigurationBakedLightingWithShadowMask = PerObjectData.None | PerObjectData.LightProbe | PerObjectData.ReflectionProbes | PerObjectData.LightProbeProxyVolume | PerObjectData.Lightmaps | PerObjectData.OcclusionProbe | PerObjectData.OcclusionProbeProxyVolume | PerObjectData.ShadowMask; // Metadata: 0x02303EDF
		internal static LayerMask UI_2D_LAYER; // 0x00
		internal static LayerMask UI_3D_LAYER; // 0x04
		private static Matrix4x4 s_preTransform90Matrix; // 0x08
		private static Matrix4x4 s_preTransform270Matrix; // 0x48
		private static Matrix4x4 s_preTransform180Matrix; // 0x88
		private static RenderTargetIdentifier s_backBufferIdentifier; // 0xC8
		private static Texture3D m_ClearTexture3D; // 0xF0
		private static RTHandle m_ClearTexture3DRTH; // 0xF8
		private static Dictionary<GraphicsFormat, int> graphicsFormatSizeCache; // 0x100
		private static GraphicsFormat[] m_RWTextureWithoutAlphaColorFormatList; // 0x108
		private static GraphicsFormat[] m_RWTextureWithAlphaColorFormatList; // 0x110
		private static GraphicsFormat m_RWTextureWithAlphaFormat; // 0x118
		private static GraphicsFormat m_RWTextureWithoutAlphaFormat; // 0x11C
		private const int MAX_RESOLUTION_HEIGHT_MOBILE = 1080; // Metadata: 0x02303EE1
		private const int MIN_RESOLUTION_HEIGHT_MOBILE = 432; // Metadata: 0x02303EE3
		private static readonly RenderFunc<WaterMarkPassData> s_WaterMarkRenderFunc; // 0x120
		private static Texture2D s_uiCameraTexture; // 0x128
		private static RTHandle s_uiCameraRT; // 0x130
		private static UnityEngine.Color s_cachedUiCameraClearColor; // 0x138
	
		// Properties
		internal static HGAdditionalCameraData s_DefaultHGAdditionalCameraData { get; } // 0x0000000189C11840-0x0000000189C1188C 
		// HGAdditionalCameraData get_s_DefaultHGAdditionalCameraData()
		HGAdditionalCameraData *HG::Rendering::Runtime::HGUtils::get_s_DefaultHGAdditionalCameraData(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(682, 0LL) )
		    return (HGAdditionalCameraData *)UnityEngine::Rendering::ComponentSingleton<System::Object>::get_instance(MethodInfo::UnityEngine::Rendering::ComponentSingleton<HG::Rendering::Runtime::HGAdditionalCameraData>::get_instance);
		  Patch = IFix::WrappersManagerImpl::GetPatch(682, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_266(Patch, 0LL);
		}
		
		public static Texture3D clearTexture3D { get; } // 0x0000000189C11594-0x0000000189C11790 
		// Texture3D get_clearTexture3D()
		Texture3D *HG::Rendering::Runtime::HGUtils::get_clearTexture3D(MethodInfo *method)
		{
		  Object_1 *m_ClearTexture3D; // rbx
		  Texture3D *v2; // rax
		  __int64 v3; // rdx
		  Texture3D *m_ClearTexture3DRTH; // rcx
		  Object_1 *v5; // rbx
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  TileBase *v9; // rdx
		  Vector3Int *v10; // r8
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  Texture3D *v12; // r10
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *formata; // [rsp+20h] [rbp-38h]
		  MethodInfo *formatb; // [rsp+20h] [rbp-38h]
		  MethodInfo *format; // [rsp+20h] [rbp-38h]
		  TileAnimationData v21; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3756, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    m_ClearTexture3D = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_ClearTexture3D;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality(m_ClearTexture3D, 0LL, 0LL) )
		    {
		LABEL_8:
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      return TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_ClearTexture3D;
		    }
		    v2 = (Texture3D *)sub_18002C620(TypeInfo::UnityEngine::Texture3D);
		    v5 = (Object_1 *)v2;
		    if ( v2 )
		    {
		      UnityEngine::Texture3D::Texture3D(
		        v2,
		        1,
		        1,
		        1,
		        GraphicsFormat__Enum_R8G8B8A8_SRGB,
		        TextureCreationFlags__Enum_None,
		        0LL);
		      UnityEngine::Object::set_name(v5, (String *)"Transparent Texture 3D", 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_ClearTexture3D = (Texture3D *)v5;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_ClearTexture3D,
		        v6,
		        v7,
		        v8,
		        formata);
		      TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                 &v21,
		                                 v9,
		                                 v10,
		                                 (ITilemap *)TypeInfo::HG::Rendering::Runtime::HGUtils,
		                                 formatb);
		      if ( v12 )
		      {
		        v21 = *TileAnimationDataNoRef;
		        UnityEngine::Texture3D::SetPixel(v12, 0, 0, 0, (Color *)&v21, 0LL);
		        m_ClearTexture3DRTH = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_ClearTexture3D;
		        if ( m_ClearTexture3DRTH )
		        {
		          UnityEngine::Texture3D::Apply(m_ClearTexture3DRTH, 0LL);
		          m_ClearTexture3DRTH = (Texture3D *)TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_ClearTexture3DRTH;
		          if ( m_ClearTexture3DRTH )
		          {
		            UnityEngine::Rendering::RTHandle::Release((RTHandle *)m_ClearTexture3DRTH, 0LL);
		            TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_ClearTexture3DRTH = 0LL;
		            sub_18002D1B0(
		              (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_ClearTexture3DRTH,
		              v13,
		              v14,
		              v15,
		              format);
		            goto LABEL_8;
		          }
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(m_ClearTexture3DRTH, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3756, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_642(Patch, 0LL);
		}
		
		public static RTHandle clearTexture3DRTH { get; } // 0x0000000189C1144C-0x0000000189C11594 
		// RTHandle get_clearTexture3DRTH()
		RTHandle *HG::Rendering::Runtime::HGUtils::get_clearTexture3DRTH(MethodInfo *method)
		{
		  struct HGUtils__Class *v1; // rcx
		  Object_1 *m_ClearTexture3D; // rbx
		  __int64 v3; // rdx
		  RTHandle *m_ClearTexture3DRTH; // rcx
		  Texture *clearTexture3D; // rbx
		  RTHandle *v6; // rax
		  HGUtils__StaticFields *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3757, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    v1 = TypeInfo::HG::Rendering::Runtime::HGUtils;
		    if ( TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_ClearTexture3DRTH )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      m_ClearTexture3D = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_ClearTexture3D;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Equality(m_ClearTexture3D, 0LL, 0LL) )
		      {
		LABEL_7:
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        return TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_ClearTexture3DRTH;
		      }
		      v1 = TypeInfo::HG::Rendering::Runtime::HGUtils;
		    }
		    sub_1800036A0(v1);
		    m_ClearTexture3DRTH = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_ClearTexture3DRTH;
		    if ( m_ClearTexture3DRTH )
		    {
		      UnityEngine::Rendering::RTHandle::Release(m_ClearTexture3DRTH, 0LL);
		      clearTexture3D = (Texture *)HG::Rendering::Runtime::HGUtils::get_clearTexture3D(0LL);
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		      v6 = UnityEngine::Rendering::RTHandleSystem::Alloc(clearTexture3D, 0LL);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		      static_fields->m_ClearTexture3DRTH = v6;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_ClearTexture3DRTH,
		        (HGRuntimeGrassQuery_Node *)static_fields,
		        v8,
		        v9,
		        v12);
		      goto LABEL_7;
		    }
		LABEL_9:
		    sub_1800D8260(m_ClearTexture3DRTH, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3757, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1321(Patch, 0LL);
		}
		
		public static RenderPipelineSettings hgrpSettings { get; } // 0x0000000189C11790-0x0000000189C11840 
		// RenderPipelineSettings get_hgrpSettings()
		RenderPipelineSettings *HG::Rendering::Runtime::HGUtils::get_hgrpSettings(
		        RenderPipelineSettings *__return_ptr retstr,
		        MethodInfo *method)
		{
		  HGRenderPipelineAsset *currentAsset; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderPipelineSettings *currentPlatformRenderPipelineSettings; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v8; // xmm1
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  __int128 v11; // xmm0
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  RenderPipelineSettings *result; // rax
		  RenderPipelineSettings v15; // [rsp+20h] [rbp-78h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3758, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3758, 0LL);
		    if ( Patch )
		    {
		      currentPlatformRenderPipelineSettings = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1301(&v15, Patch, 0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  currentAsset = HG::Rendering::Runtime::HGRenderPipeline::get_currentAsset(0LL);
		  if ( !currentAsset )
		    goto LABEL_5;
		  currentPlatformRenderPipelineSettings = HG::Rendering::Runtime::HGRenderPipelineAsset::get_currentPlatformRenderPipelineSettings(
		                                            &v15,
		                                            currentAsset,
		                                            0LL);
		LABEL_7:
		  v8 = *(_OWORD *)&currentPlatformRenderPipelineSettings->dynamicResolutionSettings.DLSSSharpness;
		  *(_OWORD *)&retstr->colorBufferFormat = *(_OWORD *)&currentPlatformRenderPipelineSettings->colorBufferFormat;
		  v9 = *(_OWORD *)&currentPlatformRenderPipelineSettings->dynamicResolutionSettings.forcedPercentage;
		  *(_OWORD *)&retstr->dynamicResolutionSettings.DLSSSharpness = v8;
		  v10 = *(_OWORD *)&currentPlatformRenderPipelineSettings->m_ObsoleteLightLayerName0;
		  *(_OWORD *)&retstr->dynamicResolutionSettings.forcedPercentage = v9;
		  v11 = *(_OWORD *)&currentPlatformRenderPipelineSettings->m_ObsoleteLightLayerName2;
		  *(_OWORD *)&retstr->m_ObsoleteLightLayerName0 = v10;
		  v12 = *(_OWORD *)&currentPlatformRenderPipelineSettings->m_ObsoleteLightLayerName4;
		  *(_OWORD *)&retstr->m_ObsoleteLightLayerName2 = v11;
		  v13 = *(_OWORD *)&currentPlatformRenderPipelineSettings->m_ObsoleteLightLayerName6;
		  result = retstr;
		  *(_OWORD *)&retstr->m_ObsoleteLightLayerName4 = v12;
		  *(_OWORD *)&retstr->m_ObsoleteLightLayerName6 = v13;
		  return result;
		}
		
	
		// Nested types
		internal struct PackedMipChainInfo // TypeDefIndex: 38569
		{
			// Fields
			public Vector2Int textureSize; // 0x00
			public Vector2Int hardwareTextureSize; // 0x08
			public int mipLevelCount; // 0x10
			public Vector2Int[] mipLevelSizes; // 0x18
			public Vector2Int[] mipLevelOffsets; // 0x20
			private bool m_OffsetBufferWillNeedUpdate; // 0x28
	
			// Methods
			public void Allocate() {} // 0x00000001849E15A0-0x00000001849E1610
			// Void Allocate()
			void HG::Rendering::Runtime::HGUtils::PackedMipChainInfo::Allocate(
			        HGUtils_PackedMipChainInfo *this,
			        MethodInfo *method)
			{
			  HGRuntimeGrassQuery_Node *v3; // rdx
			  HGRuntimeGrassQuery_Node *v4; // r8
			  Int32__Array **v5; // r9
			  HGRuntimeGrassQuery_Node *v6; // rdx
			  HGRuntimeGrassQuery_Node *v7; // r8
			  Int32__Array **v8; // r9
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v10; // rdx
			  __int64 v11; // rcx
			  MethodInfo *v12; // [rsp+20h] [rbp-8h]
			  MethodInfo *v13; // [rsp+20h] [rbp-8h]
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3821, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3821, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v11, v10);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1354(Patch, this, 0LL);
			  }
			  else
			  {
			    this->mipLevelOffsets = (Vector2Int__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2Int, 15LL);
			    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->mipLevelOffsets, v3, v4, v5, v12);
			    this->mipLevelSizes = (Vector2Int__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2Int, 15LL);
			    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->mipLevelSizes, v6, v7, v8, v13);
			    this->m_OffsetBufferWillNeedUpdate = 1;
			  }
			}
			
			public void ComputePackedMipChainInfo(Vector2Int viewportSize) {} // 0x0000000183023C40-0x0000000183023FC0
			// Void ComputePackedMipChainInfo(Vector2Int)
			void HG::Rendering::Runtime::HGUtils::PackedMipChainInfo::ComputePackedMipChainInfo(
			        HGUtils_PackedMipChainInfo *this,
			        Vector2Int viewportSize,
			        MethodInfo *method)
			{
			  void *mipLevelOffsets; // rcx
			  Vector2Int__Array *v6; // rdx
			  Vector2Int__Array *mipLevelSizes; // rax
			  struct DynamicResolutionHandler__Class *v8; // rcx
			  DynamicResolutionHandler *v9; // rax
			  __int64 v10; // r8
			  int32_t v11; // esi
			  int hardwareTextureSize; // r15d
			  int v13; // r12d
			  __int64 v14; // rbp
			  int v15; // eax
			  int v16; // eax
			  Vector2Int__Array *v17; // rbx
			  Vector2Int__Array *v18; // rax
			  unsigned __int64 v19; // rbx
			  __int64 v20; // rax
			  int v21; // r14d
			  unsigned __int64 v22; // rbx
			  int32_t m_X; // ebp
			  int32_t m_Y; // ebp
			  float v25; // xmm0_4
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  struct DynamicResolutionHandler__Class *v27; // rcx
			  DynamicResolutionHandler *v28; // rax
			  Vector2Int v29; // [rsp+20h] [rbp-68h]
			  Vector2Int v30; // [rsp+A8h] [rbp+20h]
			  Vector2Int v31; // [rsp+A8h] [rbp+20h]
			
			  mipLevelOffsets = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    mipLevelOffsets = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v6 = (Vector2Int__Array *)**((_QWORD **)mipLevelOffsets + 23);
			  if ( !v6 )
			    goto LABEL_44;
			  if ( v6->max_length.size > 745 )
			  {
			    if ( !*((_DWORD *)mipLevelOffsets + 56) )
			    {
			      il2cpp_runtime_class_init_1(mipLevelOffsets);
			      mipLevelOffsets = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    v6 = (Vector2Int__Array *)**((_QWORD **)mipLevelOffsets + 23);
			    if ( !v6 )
			      goto LABEL_44;
			    if ( v6->max_length.size <= 0x2E9u )
			LABEL_45:
			      sub_1800D2AB0(mipLevelOffsets, v6);
			    if ( v6[20].vector[25] )
			    {
			      Patch = IFix::WrappersManagerImpl::GetPatch(745, 0LL);
			      if ( Patch )
			      {
			        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_295(Patch, this, viewportSize, 0LL);
			        return;
			      }
			      goto LABEL_44;
			    }
			  }
			  mipLevelSizes = this->mipLevelSizes;
			  if ( !mipLevelSizes )
			    goto LABEL_44;
			  if ( !mipLevelSizes->max_length.size )
			    goto LABEL_45;
			  if ( viewportSize == *(_QWORD *)mipLevelSizes->vector )
			    return;
			  v8 = TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler;
			  if ( !TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler->_1.cctor_finished_or_no_cctor )
			    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler);
			  v9 = (DynamicResolutionHandler *)sub_1831019F0(v8, v6, method);
			  if ( !v9 )
			    goto LABEL_44;
			  if ( UnityEngine::Rendering::DynamicResolutionHandler::HardwareDynamicResIsEnabled(v9, 0LL) )
			  {
			    v27 = TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler;
			    if ( !TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler->_1.cctor_finished_or_no_cctor )
			      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler);
			    v28 = (DynamicResolutionHandler *)sub_1831019F0(v27, v6, v10);
			    if ( !v28 )
			      goto LABEL_44;
			    this->hardwareTextureSize = UnityEngine::Rendering::DynamicResolutionHandler::ApplyScalesOnSize(
			                                  v28,
			                                  viewportSize,
			                                  0LL);
			  }
			  else
			  {
			    this->hardwareTextureSize = viewportSize;
			  }
			  mipLevelOffsets = this->mipLevelSizes;
			  if ( !mipLevelOffsets )
			    goto LABEL_44;
			  if ( !*((_DWORD *)mipLevelOffsets + 6) )
			    goto LABEL_45;
			  *((_QWORD *)mipLevelOffsets + 4) = this->hardwareTextureSize;
			  mipLevelOffsets = this->mipLevelOffsets;
			  if ( !mipLevelOffsets )
			LABEL_44:
			    sub_1800D8260(mipLevelOffsets, v6);
			  if ( !*((_DWORD *)mipLevelOffsets + 6) )
			    goto LABEL_45;
			  *((_QWORD *)mipLevelOffsets + 4) = TypeInfo::UnityEngine::Vector2Int->static_fields->s_Zero;
			  v11 = 0;
			  hardwareTextureSize = (int)this->hardwareTextureSize;
			  v13 = HIDWORD(*(_QWORD *)&this->hardwareTextureSize);
			  do
			  {
			    v14 = v11++;
			    mipLevelOffsets = TypeInfo::System::Math;
			    if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
			      il2cpp_runtime_class_init_1(TypeInfo::System::Math);
			    v15 = (hardwareTextureSize + 1) >> 1;
			    hardwareTextureSize = 1;
			    if ( v15 > 1 )
			      hardwareTextureSize = v15;
			    v30.m_X = hardwareTextureSize;
			    v16 = (v13 + 1) >> 1;
			    v6 = this->mipLevelSizes;
			    v13 = 1;
			    if ( v16 > 1 )
			      v13 = v16;
			    v30.m_Y = v13;
			    if ( !v6 )
			      goto LABEL_44;
			    if ( (unsigned int)v11 >= v6->max_length.size )
			      goto LABEL_45;
			    mipLevelOffsets = (void *)v11;
			    v6->vector[v11] = v30;
			    v17 = this->mipLevelOffsets;
			    if ( !v17 )
			      goto LABEL_44;
			    if ( (unsigned int)v14 >= v17->max_length.size )
			      goto LABEL_45;
			    v18 = this->mipLevelSizes;
			    v19 = (unsigned __int64)v17->vector[v14];
			    if ( !v18 )
			      goto LABEL_44;
			    if ( (unsigned int)v14 >= v18->max_length.size )
			      goto LABEL_45;
			    v20 = sub_185EC333C(v19, *(_QWORD *)&v18->vector[v14]);
			    if ( (v11 & 1) != 0 )
			    {
			      v21 = v19;
			      v29.m_X = v19;
			      v19 = v20;
			    }
			    else
			    {
			      v21 = v20;
			      v29.m_X = v20;
			    }
			    v22 = HIDWORD(v19);
			    v29.m_Y = v22;
			    v6 = this->mipLevelOffsets;
			    if ( !v6 )
			      goto LABEL_44;
			    if ( (unsigned int)v11 >= v6->max_length.size )
			      goto LABEL_45;
			    v6->vector[v11] = v29;
			    m_X = this->hardwareTextureSize.m_X;
			    if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
			      il2cpp_runtime_class_init_1(TypeInfo::System::Math);
			    if ( m_X < v21 + hardwareTextureSize )
			      m_X = v21 + hardwareTextureSize;
			    this->hardwareTextureSize.m_X = m_X;
			    m_Y = this->hardwareTextureSize.m_Y;
			    if ( m_Y < v13 + (int)v22 )
			      m_Y = v13 + v22;
			    this->hardwareTextureSize.m_Y = m_Y;
			  }
			  while ( hardwareTextureSize > 1 || v13 > 1 );
			  v31.m_X = (int)sub_1801D3680();
			  v25 = sub_1801D3680();
			  this->m_OffsetBufferWillNeedUpdate = 1;
			  v31.m_Y = (int)v25;
			  this->textureSize = v31;
			  this->mipLevelCount = v11 + 1;
			}
			
			public ComputeBuffer GetOffsetBufferData(ComputeBuffer mipLevelOffsetsBuffer) => default; // 0x0000000189C11898-0x0000000189C11910
			// ComputeBuffer GetOffsetBufferData(ComputeBuffer)
			ComputeBuffer *HG::Rendering::Runtime::HGUtils::PackedMipChainInfo::GetOffsetBufferData(
			        HGUtils_PackedMipChainInfo *this,
			        ComputeBuffer *mipLevelOffsetsBuffer,
			        MethodInfo *method)
			{
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3822, 0LL) )
			  {
			    if ( !this->m_OffsetBufferWillNeedUpdate )
			      return mipLevelOffsetsBuffer;
			    if ( mipLevelOffsetsBuffer )
			    {
			      UnityEngine::ComputeBuffer::SetData(mipLevelOffsetsBuffer, (Array *)this->mipLevelOffsets, 0LL);
			      this->m_OffsetBufferWillNeedUpdate = 0;
			      return mipLevelOffsetsBuffer;
			    }
			LABEL_7:
			    sub_1800D8260(v6, v5);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(3822, 0LL);
			  if ( !Patch )
			    goto LABEL_7;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1355(Patch, this, (Object *)mipLevelOffsetsBuffer, 0LL);
			}
			
		}
	
		private class WaterMarkPassData // TypeDefIndex: 38570
		{
			// Fields
			public uint ecsRendererList; // 0x10
			public uint hgUiRendererList; // 0x14
			public Vector2Int finalRTSize; // 0x18
	
			// Constructors
			public WaterMarkPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		static HGUtils() {} // 0x000000018402F360-0x000000018402F860
		// HGUtils()
		void HG::Rendering::Runtime::HGUtils::cctor(MethodInfo *method)
		{
		  __m128i v1; // xmm1
		  HGUtils__StaticFields *static_fields; // rcx
		  __int128 v3; // xmm1
		  HGUtils__StaticFields *v4; // rcx
		  __int128 v5; // xmm0
		  __int128 v6; // xmm1
		  __int128 v7; // xmm1
		  HGUtils__StaticFields *v8; // rcx
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  __m128i v11; // xmm0
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  HGUtils__StaticFields *v14; // rcx
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  HGUtils__StaticFields *v19; // rcx
		  Dictionary_2_System_Int32Enum_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_ *v20; // rax
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  Dictionary_2_System_Int32Enum_System_Int32_ *v23; // rbx
		  HGRuntimeGrassQuery_Node *v24; // rdx
		  HGRuntimeGrassQuery_Node *v25; // r8
		  Int32__Array **v26; // r9
		  Array *v27; // rbx
		  HGRuntimeGrassQuery_Node *v28; // rdx
		  HGRuntimeGrassQuery_Node *v29; // r8
		  Int32__Array **v30; // r9
		  Array *v31; // rbx
		  HGRuntimeGrassQuery_Node *v32; // rdx
		  HGRuntimeGrassQuery_Node *v33; // r8
		  Int32__Array **v34; // r9
		  struct HGUtils_c__Class *v35; // rax
		  Object *v36; // rdi
		  RenderFunc_1_System_Object_ *v37; // rax
		  HGRuntimeGrassQuery_Node__Class *v38; // rbx
		  HGRuntimeGrassQuery_Node *v39; // rdx
		  HGRuntimeGrassQuery_Node *v40; // r8
		  Int32__Array **v41; // r9
		  Int32__Array **v42; // r9
		  HGRuntimeGrassQuery_Node *v43; // rdx
		  HGRuntimeGrassQuery_Node *v44; // r8
		  Int32__Array **v45; // r9
		  HGRuntimeGrassQuery_Node *v46; // rdx
		  HGRuntimeGrassQuery_Node *v47; // r8
		  MethodInfo *v48; // rdx
		  MethodInfo *v49; // [rsp+20h] [rbp-39h]
		  MethodInfo *v50; // [rsp+20h] [rbp-39h]
		  MethodInfo *v51; // [rsp+20h] [rbp-39h]
		  MethodInfo *v52; // [rsp+20h] [rbp-39h]
		  MethodInfo *v53; // [rsp+20h] [rbp-39h]
		  MethodInfo *v54; // [rsp+20h] [rbp-39h]
		  Matrix4x4 v55; // [rsp+30h] [rbp-29h] BYREF
		  __m128i v56; // [rsp+70h] [rbp+17h] BYREF
		  __m128i v57; // [rsp+80h] [rbp+27h] BYREF
		  __m128i si128; // [rsp+90h] [rbp+37h] BYREF
		  __m128i v59; // [rsp+A0h] [rbp+47h] BYREF
		
		  TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->UI_2D_LAYER.m_Mask = 32;
		  si128 = _mm_load_si128((const __m128i *)&xmmword_18B959550);
		  v1 = _mm_load_si128((const __m128i *)&xmmword_18B959940);
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		  memset(&v55, 0, 32);
		  static_fields->UI_3D_LAYER.m_Mask = 1024;
		  memset(&v55.m02, 0, 32);
		  v57 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		  v59 = _mm_load_si128((const __m128i *)&xmmword_18B9593A0);
		  v56 = v1;
		  UnityEngine::Matrix4x4::Matrix4x4(&v55, (Vector4 *)&v56, (Vector4 *)&v59, (Vector4 *)&si128, (Vector4 *)&v57, 0LL);
		  v3 = *(_OWORD *)&v55.m01;
		  v4 = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		  *(_OWORD *)&v4->s_preTransform90Matrix.m00 = *(_OWORD *)&v55.m00;
		  v5 = *(_OWORD *)&v55.m02;
		  *(_OWORD *)&v4->s_preTransform90Matrix.m01 = v3;
		  v6 = *(_OWORD *)&v55.m03;
		  *(_OWORD *)&v4->s_preTransform90Matrix.m02 = v5;
		  *(_OWORD *)&v4->s_preTransform90Matrix.m03 = v6;
		  memset(&v55, 0, sizeof(v55));
		  v56 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		  v59 = _mm_load_si128((const __m128i *)&xmmword_18B959550);
		  si128 = _mm_load_si128((const __m128i *)&xmmword_18B959950);
		  v57 = _mm_load_si128((const __m128i *)&xmmword_18B959930);
		  UnityEngine::Matrix4x4::Matrix4x4(&v55, (Vector4 *)&v57, (Vector4 *)&si128, (Vector4 *)&v59, (Vector4 *)&v56, 0LL);
		  v7 = *(_OWORD *)&v55.m01;
		  v8 = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		  *(_OWORD *)&v8->s_preTransform270Matrix.m00 = *(_OWORD *)&v55.m00;
		  v9 = *(_OWORD *)&v55.m02;
		  *(_OWORD *)&v8->s_preTransform270Matrix.m01 = v7;
		  v10 = *(_OWORD *)&v55.m03;
		  *(_OWORD *)&v8->s_preTransform270Matrix.m02 = v9;
		  memset(&v55, 0, sizeof(v55));
		  v11 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		  *(_OWORD *)&v8->s_preTransform270Matrix.m03 = v10;
		  v56 = v11;
		  v59 = _mm_load_si128((const __m128i *)&xmmword_18B959550);
		  si128 = _mm_load_si128((const __m128i *)&xmmword_18B959940);
		  v57 = _mm_load_si128((const __m128i *)&xmmword_18B959950);
		  UnityEngine::Matrix4x4::Matrix4x4(&v55, (Vector4 *)&v57, (Vector4 *)&si128, (Vector4 *)&v59, (Vector4 *)&v56, 0LL);
		  v12 = *(_OWORD *)&v55.m00;
		  v13 = *(_OWORD *)&v55.m01;
		  v14 = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		  *(_OWORD *)&v55.m00 = 0xFFFFFFFF00000002uLL;
		  *(_QWORD *)&v55.m01 = 0LL;
		  *(_OWORD *)&v14->s_preTransform180Matrix.m00 = v12;
		  v55.m21 = 0.0;
		  v15 = *(_OWORD *)&v55.m02;
		  *(_OWORD *)&v14->s_preTransform180Matrix.m01 = v13;
		  v55.m31 = NAN;
		  v16 = *(_OWORD *)&v55.m03;
		  *(_OWORD *)&v14->s_preTransform180Matrix.m02 = v15;
		  *(_QWORD *)&v55.m02 = 0LL;
		  v17 = *(_OWORD *)&v55.m00;
		  *(_OWORD *)&v14->s_preTransform180Matrix.m03 = v16;
		  v18 = *(_OWORD *)&v55.m01;
		  v19 = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		  *(_OWORD *)&v19->s_backBufferIdentifier.m_Type = v17;
		  *(_QWORD *)&v17 = *(_QWORD *)&v55.m02;
		  *(_OWORD *)&v19->s_backBufferIdentifier.m_BufferPointer = v18;
		  *(_QWORD *)&v19->s_backBufferIdentifier.m_DepthSlice = v17;
		  v20 = (Dictionary_2_System_Int32Enum_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::Experimental::Rendering::GraphicsFormat,int>);
		  v23 = (Dictionary_2_System_Int32Enum_System_Int32_ *)v20;
		  if ( !v20 )
		    goto LABEL_5;
		  System::Collections::Generic::Dictionary<System::Int32Enum,Beyond::Gameplay::Core::AbilitySystem_ComboController::MappingModifier>::Dictionary(
		    v20,
		    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Experimental::Rendering::GraphicsFormat,int>::Dictionary);
		  System::Collections::Generic::Dictionary<System::Int32Enum,int>::Add(
		    v23,
		    (Int32Enum__Enum)8u,
		    4,
		    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Experimental::Rendering::GraphicsFormat,int>::Add);
		  System::Collections::Generic::Dictionary<System::Int32Enum,int>::Add(
		    v23,
		    (Int32Enum__Enum)0x30u,
		    8,
		    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Experimental::Rendering::GraphicsFormat,int>::Add);
		  System::Collections::Generic::Dictionary<System::Int32Enum,int>::Add(
		    v23,
		    (Int32Enum__Enum)0x6Bu,
		    1,
		    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Experimental::Rendering::GraphicsFormat,int>::Add);
		  TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->graphicsFormatSizeCache = (Dictionary_2_UnityEngine_Experimental_Rendering_GraphicsFormat_System_Int32_ *)v23;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->graphicsFormatSizeCache,
		    v24,
		    v25,
		    v26,
		    v49);
		  v27 = (Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Experimental::Rendering::GraphicsFormat, 5LL);
		  System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		    v27,
		    F604D07FF40B13BB0249C3B29F3267E762F4D97F2D89F4F26F640748FFB7A41F_Field,
		    0LL);
		  v28 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		  v28[3].fields.left = (HGRuntimeGrassQuery_Node *)v27;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_RWTextureWithoutAlphaColorFormatList,
		    v28,
		    v29,
		    v30,
		    v50);
		  v31 = (Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Experimental::Rendering::GraphicsFormat, 3LL);
		  System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		    v31,
		    8935511DB89A77716BD091BB49CF96239D018D703782BA2C3657B391D983B654_Field,
		    0LL);
		  v32 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		  v32[3].fields.right = (HGRuntimeGrassQuery_Node *)v31;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_RWTextureWithAlphaColorFormatList,
		    v32,
		    v33,
		    v34,
		    v51);
		  TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_RWTextureWithAlphaFormat = 0;
		  TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_RWTextureWithoutAlphaFormat = 0;
		  v35 = TypeInfo::HG::Rendering::Runtime::HGUtils::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils::__c);
		    v35 = TypeInfo::HG::Rendering::Runtime::HGUtils::__c;
		  }
		  v36 = (Object *)v35->static_fields->__9;
		  v37 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGUtils::WaterMarkPassData>);
		  v38 = (HGRuntimeGrassQuery_Node__Class *)v37;
		  if ( !v37 )
		LABEL_5:
		    sub_1800D8260(v22, v21);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v37,
		    v36,
		    MethodInfo::HG::Rendering::Runtime::HGUtils::__c::__cctor_b__141_0,
		    0LL);
		  v39 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		  v39[4].klass = v38;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_WaterMarkRenderFunc,
		    v39,
		    v40,
		    v41,
		    v52);
		  v42 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGUtils;
		  TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_uiCameraTexture = 0LL;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_uiCameraTexture,
		    v43,
		    v44,
		    v42,
		    v53);
		  v45 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGUtils;
		  TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_uiCameraRT = 0LL;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_uiCameraRT,
		    v46,
		    v47,
		    v45,
		    v54);
		  TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_cachedUiCameraClearColor = (Color)*UnityEngine::Quaternion::get_identity(
		                                                                                                   (Quaternion *)&v56,
		                                                                                                   v48);
		}
		
	
		// Methods
		public static PerObjectData GetBakedLightingRenderConfig() => default; // 0x0000000189C0D114-0x0000000189C0D158
		// PerObjectData GetBakedLightingRenderConfig()
		PerObjectData__Enum HG::Rendering::Runtime::HGUtils::GetBakedLightingRenderConfig(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3754, 0LL) )
		    return 15;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3754, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
		public static PerObjectData GetBakedLightingWithShadowMaskRenderConfig() => default; // 0x0000000189C0D158-0x0000000189C0D19C
		// PerObjectData GetBakedLightingWithShadowMaskRenderConfig()
		PerObjectData__Enum HG::Rendering::Runtime::HGUtils::GetBakedLightingWithShadowMaskRenderConfig(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3755, 0LL) )
		    return 1807;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3755, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
		public static Material GetBlitMaterial(bool isFP32Output, TextureDimension dimension, bool singleSlice = false /* Metadata: 0x02303EBD */) => default; // 0x0000000183D24360-0x0000000183D24420
		// Material GetBlitMaterial(Boolean, TextureDimension, Boolean)
		// local variable allocation has failed, the output may be wrong!
		Material *HG::Rendering::Runtime::HGUtils::GetBlitMaterial(
		        bool isFP32Output,
		        TextureDimension__Enum dimension,
		        bool singleSlice,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  struct Blitter__Class *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_11;
		  if ( wrapperArray->max_length.size > 1151 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( v6 )
		    {
		      if ( LODWORD(v6->_0.namespaze) <= 0x47F )
		        sub_1800D2AB0(v6, *(_QWORD *)&dimension);
		      if ( !*(_QWORD *)&v6[24]._1.initializationExceptionGCHandle )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1151, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(Patch, isFP32Output, dimension, singleSlice, 0LL);
		    }
		LABEL_11:
		    sub_1800D8260(v6, *(_QWORD *)&dimension);
		  }
		LABEL_5:
		  v9 = TypeInfo::UnityEngine::Rendering::Blitter;
		  if ( !TypeInfo::UnityEngine::Rendering::Blitter->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::Blitter);
		    v9 = TypeInfo::UnityEngine::Rendering::Blitter;
		  }
		  if ( dimension == TextureDimension__Enum_Tex2DArray )
		  {
		    if ( singleSlice )
		    {
		      if ( !v9->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v9);
		        v9 = TypeInfo::UnityEngine::Rendering::Blitter;
		      }
		      return v9->static_fields->s_BlitTexArraySingleSlice;
		    }
		    else
		    {
		      if ( !v9->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v9);
		        v9 = TypeInfo::UnityEngine::Rendering::Blitter;
		      }
		      return v9->static_fields->s_BlitTexArray;
		    }
		  }
		  else
		  {
		    if ( !v9->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v9);
		      v9 = TypeInfo::UnityEngine::Rendering::Blitter;
		    }
		    return v9->static_fields->s_Blit;
		  }
		}
		
		[IDTag(5)]
		public static Vector4 PackVector4(Vector3 v) => default; // 0x0000000189C0F1A0-0x0000000189C0F228
		// Vector4 PackVector4(Vector3)
		Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1426, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1426, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->w = 0.0;
		    retstr->x = x;
		    retstr->y = v->y;
		    retstr->z = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 PackVector4(Vector3 v, float w) => default; // 0x0000000183D9F870-0x0000000183D9F8F0
		// Vector4 PackVector4(Vector3, Single)
		Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(
		        Vector4 *__return_ptr retstr,
		        Vector3 *v,
		        float w,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v11; // [rsp+30h] [rbp-38h] BYREF
		  Vector4 v12; // [rsp+40h] [rbp-28h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 898 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x382 )
		        sub_1800D2AB0(v5, wrapperArray);
		      if ( !v5[19]._0.castClass )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(898, 0LL);
		      if ( Patch )
		      {
		        v10 = *(_QWORD *)&v->x;
		        v11.z = v->z;
		        *(_QWORD *)&v11.x = v10;
		        *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_356(&v12, Patch, &v11, w, 0LL);
		        return retstr;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v5, wrapperArray);
		  }
		LABEL_5:
		  retstr->x = v->x;
		  retstr->y = v->y;
		  retstr->z = v->z;
		  retstr->w = w;
		  return retstr;
		}
		
		[IDTag(10)]
		public static Vector4 PackVector4(UnityEngine.Color c) => default; // 0x0000000189C0F120-0x0000000189C0F1A0
		// Vector4 PackVector4(Color)
		Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(Vector4 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3759, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3759, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1322(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    r = c->r;
		    retstr->w = 0.0;
		    retstr->x = r;
		    retstr->y = c->g;
		    retstr->z = c->b;
		  }
		  return retstr;
		}
		
		[IDTag(4)]
		public static Vector4 PackVector4(UnityEngine.Color c, float w) => default; // 0x0000000189C0F29C-0x0000000189C0F330
		// Vector4 PackVector4(Color, Single)
		Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(
		        Vector4 *__return_ptr retstr,
		        Color *c,
		        float w,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+30h] [rbp-38h] BYREF
		  Vector4 v11; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1423, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1423, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_583(&v11, Patch, &v10, w, 0LL);
		  }
		  else
		  {
		    retstr->x = c->r;
		    retstr->y = c->g;
		    retstr->z = c->b;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		[IDTag(11)]
		public static Vector4 PackVector4(Vector2 v1) => default; // 0x0000000189C0F330-0x0000000189C0F3BC
		// Vector4 PackVector4(Vector2)
		Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(Vector4 *__return_ptr retstr, Vector2 v1, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3760, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3760, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v1, 0LL);
		  }
		  else
		  {
		    retstr->z = 0.0;
		    retstr->w = 0.0;
		    *(Vector2 *)&retstr->x = v1;
		  }
		  return retstr;
		}
		
		[IDTag(8)]
		public static Vector4 PackVector4(Vector2 v1, Vector2 v2) => default; // 0x0000000189C0F478-0x0000000189C0F52C
		// Vector4 PackVector4(Vector2, Vector2)
		Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(
		        Vector4 *__return_ptr retstr,
		        Vector2 v1,
		        Vector2 v2,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v13; // [rsp+40h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1541, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1541, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_633(&v13, Patch, v1, v2, 0LL);
		  }
		  else
		  {
		    *(Vector2 *)&retstr->x = v1;
		    *(Vector2 *)&retstr->z = v2;
		  }
		  return retstr;
		}
		
		[IDTag(7)]
		public static Vector4 PackVector4(Vector2 v, float f1, float f2) => default; // 0x0000000189C0F52C-0x0000000189C0F5E8
		// Vector4 PackVector4(Vector2, Single, Single)
		Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(
		        Vector4 *__return_ptr retstr,
		        Vector2 v,
		        float f1,
		        float f2,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v12; // [rsp+38h] [rbp-50h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1526, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1526, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_623(&v12, Patch, v, f1, f2, 0LL);
		  }
		  else
		  {
		    *(Vector2 *)&retstr->x = v;
		    retstr->z = f1;
		    retstr->w = f2;
		  }
		  return retstr;
		}
		
		[IDTag(6)]
		public static Vector4 PackVector4(float f1, float f2, Vector2 v) => default; // 0x0000000189C0F3BC-0x0000000189C0F478
		// Vector4 PackVector4(Single, Single, Vector2)
		Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(
		        Vector4 *__return_ptr retstr,
		        float f1,
		        float f2,
		        Vector2 v,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v12; // [rsp+38h] [rbp-50h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1525, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1525, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_622(&v12, Patch, f1, f2, v, 0LL);
		  }
		  else
		  {
		    *(Vector2 *)&retstr->z = v;
		    retstr->x = f1;
		    retstr->y = f2;
		  }
		  return retstr;
		}
		
		[IDTag(9)]
		public static Vector4 PackVector4(float f1) => default; // 0x0000000189C0F228-0x0000000189C0F29C
		// Vector4 PackVector4(Single)
		Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(Vector4 *__return_ptr retstr, float f1, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v8; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3294, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3294, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1212(&v8, Patch, f1, 0LL);
		  }
		  else
		  {
		    retstr->y = 0.0;
		    retstr->z = 0.0;
		    retstr->w = 0.0;
		    retstr->x = f1;
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 PackVector4(float f1, float f2) => default; // 0x0000000183C16240-0x0000000183C162C0
		// Vector4 PackVector4(Single, Single)
		Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(
		        Vector4 *__return_ptr retstr,
		        float f1,
		        float f2,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v9; // [rsp+30h] [rbp-38h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 902 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x386 )
		        sub_1800D2AB0(v5, wrapperArray);
		      if ( !v5[19]._0.typeMetadataHandle )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(902, 0LL);
		      if ( Patch )
		      {
		        *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359(&v9, Patch, f1, f2, 0LL);
		        return retstr;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v5, wrapperArray);
		  }
		LABEL_5:
		  retstr->x = f1;
		  *(_QWORD *)&retstr->z = 0LL;
		  retstr->y = f2;
		  return retstr;
		}
		
		[IDTag(3)]
		public static Vector4 PackVector4(float f1, float f2, float f3) => default; // 0x0000000183BF5390-0x0000000183BF5420
		// Vector4 PackVector4(Single, Single, Single)
		Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(
		        Vector4 *__return_ptr retstr,
		        float f1,
		        float f2,
		        float f3,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v10; // [rsp+30h] [rbp-48h] BYREF
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 939 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( v6 )
		    {
		      if ( LODWORD(v6->_0.namespaze) <= 0x3AB )
		        sub_1800D2AB0(v6, wrapperArray);
		      if ( !v6[20]._0.namespaze )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(939, 0LL);
		      if ( Patch )
		      {
		        *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_376(&v10, Patch, f1, f2, f3, 0LL);
		        return retstr;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v6, wrapperArray);
		  }
		LABEL_5:
		  retstr->x = f1;
		  retstr->w = 0.0;
		  retstr->y = f2;
		  retstr->z = f3;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 PackVector4(float f1, float f2, float f3, float f4) => default; // 0x0000000183BB6410-0x0000000183BB64B0
		// Vector4 PackVector4(Single, Single, Single, Single)
		Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(
		        Vector4 *__return_ptr retstr,
		        float f1,
		        float f2,
		        float f3,
		        float f4,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v11; // [rsp+40h] [rbp-48h] BYREF
		
		  v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v7->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 899 )
		  {
		    if ( !v7->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v7);
		      v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7->static_fields->wrapperArray;
		    if ( v7 )
		    {
		      if ( LODWORD(v7->_0.namespaze) <= 0x383 )
		        sub_1800D2AB0(v7, wrapperArray);
		      if ( !v7[19]._0.declaringType )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(899, 0LL);
		      if ( Patch )
		      {
		        *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_357(&v11, Patch, f1, f2, f3, f4, 0LL);
		        return retstr;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v7, wrapperArray);
		  }
		LABEL_5:
		  retstr->w = f4;
		  retstr->x = f1;
		  retstr->y = f2;
		  retstr->z = f3;
		  return retstr;
		}
		
		internal static int GetRuntimeDebugPanelWidth(HGCamera hgCamera) => default; // 0x0000000189C0E45C-0x0000000189C0E4F4
		// Int32 GetRuntimeDebugPanelWidth(HGCamera)
		int32_t HG::Rendering::Runtime::HGUtils::GetRuntimeDebugPanelWidth(HGCamera *hgCamera, MethodInfo *method)
		{
		  DebugManager *instance; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  bool displayRuntimeUI; // al
		  int32_t actualWidth_k__BackingField; // edi
		  int32_t v8; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3761, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3761, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		               (ILFixDynamicMethodWrapper_31 *)Patch,
		               (Object *)hgCamera,
		               0LL);
		LABEL_8:
		    sub_1800D8260(v5, v4);
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::DebugManager);
		  instance = UnityEngine::Rendering::DebugManager::get_instance(0LL);
		  if ( !instance )
		    goto LABEL_8;
		  displayRuntimeUI = UnityEngine::Rendering::DebugManager::get_displayRuntimeUI(instance, 0LL);
		  if ( !hgCamera )
		    goto LABEL_8;
		  actualWidth_k__BackingField = hgCamera->fields._actualWidth_k__BackingField;
		  v8 = displayRuntimeUI ? 0x262 : 0;
		  sub_1800036A0(TypeInfo::System::Math);
		  if ( actualWidth_k__BackingField <= v8 )
		    return actualWidth_k__BackingField;
		  return v8;
		}
		
		internal static float ProjectionMatrixAspect([IsReadOnly] in Matrix4x4 matrix) => default; // 0x0000000183E6DA60-0x0000000183E6DAC0
		// Single ProjectionMatrixAspect(Matrix4x4 ByRef)
		float HG::Rendering::Runtime::HGUtils::ProjectionMatrixAspect(Matrix4x4 *matrix, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 773 )
		    return (float)-matrix->m11 / matrix->m00;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x305 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[16]._1.typeHierarchy )
		    return (float)-matrix->m11 / matrix->m00;
		  Patch = IFix::WrappersManagerImpl::GetPatch(773, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, wrapperArray);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_301(Patch, matrix, 0LL);
		}
		
		internal static bool IsProjectionMatrixAsymmetric([IsReadOnly] in Matrix4x4 matrix) => default; // 0x00000001833A35E0-0x00000001833A3660
		// Boolean IsProjectionMatrixAsymmetric(Matrix4x4 ByRef)
		bool HG::Rendering::Runtime::HGUtils::IsProjectionMatrixAsymmetric(Matrix4x4 *matrix, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size > 775 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x307 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !*(_QWORD *)&v3[16]._1.initializationExceptionGCHandle )
		        return matrix->m02 != 0.0 || matrix->m12 != 0.0;
		      Patch = IFix::WrappersManagerImpl::GetPatch(775, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_302(Patch, matrix, 0LL);
		    }
		LABEL_9:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  return matrix->m02 != 0.0 || matrix->m12 != 0.0;
		}
		
		internal static Matrix4x4 ComputePixelCoordToWorldSpaceViewDirectionMatrix(float verticalFoV, Vector2 lensShift, Vector4 screenSize, Matrix4x4 worldToViewMatrix, bool renderToCubemap, float aspectRatio = -1f /* Metadata: 0x02303EBE */, bool isOrthographic = false /* Metadata: 0x02303EC2 */) => default; // 0x00000001833A2B20-0x00000001833A2F40
		// Matrix4x4 ComputePixelCoordToWorldSpaceViewDirectionMatrix(Single, Vector2, Vector4, Matrix4x4, Boolean, Single, Boolean)
		Matrix4x4 *HG::Rendering::Runtime::HGUtils::ComputePixelCoordToWorldSpaceViewDirectionMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        float verticalFoV,
		        Vector2 lensShift,
		        Vector4 *screenSize,
		        Matrix4x4 *worldToViewMatrix,
		        bool renderToCubemap,
		        float aspectRatio,
		        bool isOrthographic,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v10; // rcx
		  ILFixDynamicMethodWrapper_2 *wrapperArray; // rdx
		  float v14; // xmm7_4
		  float v15; // xmm3_4
		  float v16; // xmm5_4
		  float v17; // xmm6_4
		  float v18; // xmm2_4
		  __m128i v19; // xmm0
		  Vector4 *v20; // r8
		  Vector4 *v21; // rdx
		  MethodInfo *v22; // r8
		  Vector4 v23; // xmm6
		  void (__fastcall *v24)(Matrix4x4 *, Matrix4x4 *); // rax
		  __int128 v25; // xmm0
		  __int128 v26; // xmm1
		  void (__fastcall *v27)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
		  void (__fastcall *v28)(Matrix4x4 *, Matrix4x4 *); // rax
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  Matrix4x4 *result; // rax
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  __int128 v36; // xmm1
		  Vector4 v37; // xmm0
		  Matrix4x4 *v38; // rax
		  __int128 v39; // xmm1
		  __int128 v40; // xmm0
		  float w; // xmm2_4
		  float v42; // xmm3_4
		  __int64 v43; // rax
		  __int64 v44; // rax
		  __int64 v45; // rax
		  _WORD v46[16]; // [rsp+58h] [rbp-B0h] BYREF
		  __m128i si128; // [rsp+78h] [rbp-90h] BYREF
		  __m128i v48; // [rsp+88h] [rbp-80h] BYREF
		  Vector2 v49; // [rsp+98h] [rbp-70h]
		  Matrix4x4 v50; // [rsp+A8h] [rbp-60h] BYREF
		  Matrix4x4 v51; // [rsp+E8h] [rbp-20h] BYREF
		  Matrix4x4 v52; // [rsp+128h] [rbp+20h] BYREF
		  Matrix4x4 v53; // [rsp+168h] [rbp+60h] BYREF
		  Matrix4x4 v54; // [rsp+1A8h] [rbp+A0h] BYREF
		
		  v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v49 = lensShift;
		  memset(&v51, 0, sizeof(v51));
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (ILFixDynamicMethodWrapper_2 *)v10->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_16;
		  if ( wrapperArray->fields.methodId > 776 )
		  {
		    if ( !v10->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v10);
		      v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v10 = (struct ILFixDynamicMethodWrapper_2__Class *)v10->static_fields->wrapperArray;
		    if ( v10 )
		    {
		      if ( LODWORD(v10->_0.namespaze) <= 0x308 )
		        sub_1800D2AB0(v10, wrapperArray);
		      if ( !*(_QWORD *)&v10[16]._1.cctor_finished_or_no_cctor )
		        goto LABEL_5;
		      wrapperArray = IFix::WrappersManagerImpl::GetPatch(776, 0LL);
		      if ( wrapperArray )
		      {
		        v34 = *(_OWORD *)&worldToViewMatrix->m01;
		        *(_OWORD *)&v50.m00 = *(_OWORD *)&worldToViewMatrix->m00;
		        v35 = *(_OWORD *)&worldToViewMatrix->m02;
		        *(_OWORD *)&v50.m01 = v34;
		        v36 = *(_OWORD *)&worldToViewMatrix->m03;
		        *(_OWORD *)&v50.m02 = v35;
		        v37 = *screenSize;
		        *(_OWORD *)&v50.m03 = v36;
		        *(Vector4 *)v46 = v37;
		        v38 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_303(
		                &v53,
		                wrapperArray,
		                verticalFoV,
		                lensShift,
		                (Vector4 *)v46,
		                &v50,
		                renderToCubemap,
		                aspectRatio,
		                isOrthographic,
		                0LL);
		        v39 = *(_OWORD *)&v38->m01;
		        *(_OWORD *)&retstr->m00 = *(_OWORD *)&v38->m00;
		        v40 = *(_OWORD *)&v38->m02;
		        *(_OWORD *)&retstr->m01 = v39;
		        v31 = *(_OWORD *)&v38->m03;
		        *(_OWORD *)&retstr->m02 = v40;
		        goto LABEL_15;
		      }
		    }
		LABEL_16:
		    sub_1800D8260(v10, wrapperArray);
		  }
		LABEL_5:
		  if ( isOrthographic )
		  {
		    v20 = (Vector4 *)v46;
		    w = screenSize->w;
		    v21 = (Vector4 *)&v46[8];
		    v42 = screenSize->z * -2.0;
		    v19 = 0LL;
		    *(_DWORD *)v46 = 0;
		    *(_QWORD *)&v46[4] = 0LL;
		    *(float *)&v46[8] = v42;
		    *(float *)&v46[2] = w * -2.0;
		    si128 = _mm_load_si128((const __m128i *)&xmmword_18DC81180);
		    memset(&v46[10], 0, 12);
		  }
		  else
		  {
		    v14 = aspectRatio;
		    if ( aspectRatio < 0.0 )
		      v14 = screenSize->w * screenSize->x;
		    v15 = sub_180338A80(v10, wrapperArray, lensShift, screenSize);
		    v16 = (float)(1.0 - (float)(v49.y * 2.0)) * v15;
		    v17 = (float)(screenSize->w * -2.0) * v15;
		    v18 = (float)((float)(screenSize->z * -2.0) * v15) * v14;
		    if ( renderToCubemap )
		    {
		      v17 = -v17;
		      v16 = -v16;
		    }
		    v19 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		    v20 = (Vector4 *)&v46[8];
		    *(float *)si128.m128i_i32 = (float)((float)(1.0 - (float)(v49.x * 2.0)) * v15) * v14;
		    v21 = (Vector4 *)v46;
		    *(float *)&si128.m128i_i32[1] = v16;
		    *(float *)&v46[10] = v17;
		    *(float *)v46 = v18;
		    si128.m128i_i32[2] = -1082130432;
		    si128.m128i_i32[3] = 0;
		    *(_QWORD *)&v46[12] = 0LL;
		    *(_QWORD *)&v46[2] = 0LL;
		    *(_QWORD *)&v46[6] = 0LL;
		  }
		  v48 = v19;
		  UnityEngine::Matrix4x4::Matrix4x4(&v51, v21, v20, (Vector4 *)&si128, (Vector4 *)&v48, 0LL);
		  UnityEngine::Matrix4x4::set_Item(worldToViewMatrix, 12, 0.0, 0LL);
		  UnityEngine::Matrix4x4::set_Item(worldToViewMatrix, 13, 0.0, 0LL);
		  UnityEngine::Matrix4x4::set_Item(worldToViewMatrix, 14, 0.0, 0LL);
		  UnityEngine::Matrix4x4::set_Item(worldToViewMatrix, 15, 1.0, 0LL);
		  v48 = *(__m128i *)UnityEngine::Matrix4x4::GetRow((Vector4 *)&v48, worldToViewMatrix, 2, 0LL);
		  v23 = *UnityEngine::Vector4::op_UnaryNegation((Vector4 *)v46, (Vector4 *)&v48, v22);
		  UnityEngine::Matrix4x4::set_Item(worldToViewMatrix, 2, v23.x, 0LL);
		  UnityEngine::Matrix4x4::set_Item(worldToViewMatrix, 6, _mm_shuffle_ps((__m128)v23, (__m128)v23, 85).m128_f32[0], 0LL);
		  UnityEngine::Matrix4x4::set_Item(
		    worldToViewMatrix,
		    10,
		    _mm_shuffle_ps((__m128)v23, (__m128)v23, 170).m128_f32[0],
		    0LL);
		  UnityEngine::Matrix4x4::set_Item(
		    worldToViewMatrix,
		    14,
		    _mm_shuffle_ps((__m128)v23, (__m128)v23, 255).m128_f32[0],
		    0LL);
		  v24 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))qword_18F36FA68;
		  *(_OWORD *)&v52.m00 = *(_OWORD *)&worldToViewMatrix->m00;
		  v25 = *(_OWORD *)&worldToViewMatrix->m02;
		  *(_OWORD *)&v52.m01 = *(_OWORD *)&worldToViewMatrix->m01;
		  *(_OWORD *)&v52.m02 = v25;
		  v26 = *(_OWORD *)&worldToViewMatrix->m03;
		  memset(&v50, 0, sizeof(v50));
		  *(_OWORD *)&v52.m03 = v26;
		  if ( !qword_18F36FA68 )
		  {
		    v24 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                           "UnityEngine.Matrix4x4::Transpose_Injected(UnityEngine.Matrix4"
		                                                           "x4&,UnityEngine.Matrix4x4&)");
		    if ( !v24 )
		    {
		      v43 = sub_1802EE1B8("UnityEngine.Matrix4x4::Transpose_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v43, 0LL);
		    }
		    qword_18F36FA68 = (__int64)v24;
		  }
		  v24(&v52, &v50);
		  v27 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18F36FA50;
		  v53 = v50;
		  v54 = v51;
		  memset(&v51, 0, sizeof(v51));
		  if ( !qword_18F36FA50 )
		  {
		    v27 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                        "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_I"
		                                                                        "njected(UnityEngine.Matrix4x4&,UnityEngine.Matri"
		                                                                        "x4x4&,UnityEngine.Matrix4x4&)");
		    if ( !v27 )
		    {
		      v44 = sub_1802EE1B8(
		              "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Unit"
		              "yEngine.Matrix4x4&)");
		      sub_18007E1B0(v44, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v27;
		  }
		  v27(&v53, &v54, &v51);
		  v28 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))qword_18F36FA68;
		  v52 = v51;
		  memset(&v50, 0, sizeof(v50));
		  if ( !qword_18F36FA68 )
		  {
		    v28 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                           "UnityEngine.Matrix4x4::Transpose_Injected(UnityEngine.Matrix4"
		                                                           "x4&,UnityEngine.Matrix4x4&)");
		    if ( !v28 )
		    {
		      v45 = sub_1802EE1B8("UnityEngine.Matrix4x4::Transpose_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v45, 0LL);
		    }
		    qword_18F36FA68 = (__int64)v28;
		  }
		  v28(&v52, &v50);
		  v29 = *(_OWORD *)&v50.m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v50.m00;
		  v30 = *(_OWORD *)&v50.m02;
		  *(_OWORD *)&retstr->m01 = v29;
		  v31 = *(_OWORD *)&v50.m03;
		  *(_OWORD *)&retstr->m02 = v30;
		LABEL_15:
		  result = retstr;
		  *(_OWORD *)&retstr->m03 = v31;
		  return result;
		}
		
		internal static float ComputZPlaneTexelSpacing(float planeDepth, float verticalFoV, float resolutionY) => default; // 0x0000000189C0B838-0x0000000189C0B8D4
		// Single ComputZPlaneTexelSpacing(Single, Single, Single)
		float HG::Rendering::Runtime::HGUtils::ComputZPlaneTexelSpacing(
		        float planeDepth,
		        float verticalFoV,
		        float resolutionY,
		        MethodInfo *method)
		{
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  __int64 v6; // r8
		  __int64 v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3762, 0LL) )
		    return (float)(sub_180338A80(v5, v4, v6, v7) * (float)(2.0 / resolutionY)) * planeDepth;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3762, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v11, v10);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_98(
		           (ILFixDynamicMethodWrapper_17 *)Patch,
		           planeDepth,
		           verticalFoV,
		           resolutionY,
		           0LL);
		}
		
		public static void BlitQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear) {} // 0x0000000189C0B3FC-0x0000000189C0B4F8
		// Void BlitQuad(CommandBuffer, Texture, Vector4, Vector4, Int32, Boolean)
		void HG::Rendering::Runtime::HGUtils::BlitQuad(
		        CommandBuffer *cmd,
		        Texture *source,
		        Vector4 *scaleBiasTex,
		        Vector4 *scaleBiasRT,
		        int32_t mipLevelTex,
		        bool bilinear,
		        MethodInfo *method)
		{
		  Vector4 v11; // xmm1
		  __int64 v12; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Vector4 v14; // xmm1
		  Vector4 v15; // [rsp+40h] [rbp-28h] BYREF
		  Vector4 v16; // [rsp+50h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3763, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3763, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v12);
		    v14 = *scaleBiasTex;
		    v16 = *scaleBiasRT;
		    v15 = v14;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1324(
		      Patch,
		      (Object *)cmd,
		      (Object *)source,
		      &v15,
		      &v16,
		      mipLevelTex,
		      bilinear,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::Blitter);
		    v11 = *scaleBiasTex;
		    v15 = *scaleBiasRT;
		    v16 = v11;
		    UnityEngine::Rendering::Blitter::BlitQuad(cmd, source, &v16, &v15, mipLevelTex, bilinear, 0LL);
		  }
		}
		
		public static void BlitQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) {} // 0x0000000189C0B2C0-0x0000000189C0B3FC
		// Void BlitQuadWithPadding(CommandBuffer, Texture, Vector2, Vector4, Vector4, Int32, Boolean, Int32)
		void HG::Rendering::Runtime::HGUtils::BlitQuadWithPadding(
		        CommandBuffer *cmd,
		        Texture *source,
		        Vector2 textureSize,
		        Vector4 *scaleBiasTex,
		        Vector4 *scaleBiasRT,
		        int32_t mipLevelTex,
		        bool bilinear,
		        int32_t paddingInPixels,
		        MethodInfo *method)
		{
		  Vector4 v13; // xmm1
		  __int64 v14; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Vector4 v16; // xmm1
		  Vector4 v17; // [rsp+50h] [rbp-38h] BYREF
		  Vector4 v18; // [rsp+60h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3764, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3764, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v14);
		    v16 = *scaleBiasTex;
		    v18 = *scaleBiasRT;
		    v17 = v16;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1325(
		      Patch,
		      (Object *)cmd,
		      (Object *)source,
		      textureSize,
		      &v17,
		      &v18,
		      mipLevelTex,
		      bilinear,
		      paddingInPixels,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::Blitter);
		    v13 = *scaleBiasTex;
		    v17 = *scaleBiasRT;
		    v18 = v13;
		    UnityEngine::Rendering::Blitter::BlitQuadWithPadding(
		      cmd,
		      source,
		      textureSize,
		      &v18,
		      &v17,
		      mipLevelTex,
		      bilinear,
		      paddingInPixels,
		      0LL);
		  }
		}
		
		public static void BlitQuadWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) {} // 0x0000000189C0B184-0x0000000189C0B2C0
		// Void BlitQuadWithPaddingMultiply(CommandBuffer, Texture, Vector2, Vector4, Vector4, Int32, Boolean, Int32)
		void HG::Rendering::Runtime::HGUtils::BlitQuadWithPaddingMultiply(
		        CommandBuffer *cmd,
		        Texture *source,
		        Vector2 textureSize,
		        Vector4 *scaleBiasTex,
		        Vector4 *scaleBiasRT,
		        int32_t mipLevelTex,
		        bool bilinear,
		        int32_t paddingInPixels,
		        MethodInfo *method)
		{
		  Vector4 v13; // xmm1
		  __int64 v14; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Vector4 v16; // xmm1
		  Vector4 v17; // [rsp+50h] [rbp-38h] BYREF
		  Vector4 v18; // [rsp+60h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3765, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3765, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v14);
		    v16 = *scaleBiasTex;
		    v18 = *scaleBiasRT;
		    v17 = v16;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1325(
		      Patch,
		      (Object *)cmd,
		      (Object *)source,
		      textureSize,
		      &v17,
		      &v18,
		      mipLevelTex,
		      bilinear,
		      paddingInPixels,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::Blitter);
		    v13 = *scaleBiasTex;
		    v17 = *scaleBiasRT;
		    v18 = v13;
		    UnityEngine::Rendering::Blitter::BlitQuadWithPaddingMultiply(
		      cmd,
		      source,
		      textureSize,
		      &v18,
		      &v17,
		      mipLevelTex,
		      bilinear,
		      paddingInPixels,
		      0LL);
		  }
		}
		
		public static void BlitOctahedralWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) {} // 0x0000000189C0B048-0x0000000189C0B184
		// Void BlitOctahedralWithPadding(CommandBuffer, Texture, Vector2, Vector4, Vector4, Int32, Boolean, Int32)
		void HG::Rendering::Runtime::HGUtils::BlitOctahedralWithPadding(
		        CommandBuffer *cmd,
		        Texture *source,
		        Vector2 textureSize,
		        Vector4 *scaleBiasTex,
		        Vector4 *scaleBiasRT,
		        int32_t mipLevelTex,
		        bool bilinear,
		        int32_t paddingInPixels,
		        MethodInfo *method)
		{
		  Vector4 v13; // xmm1
		  __int64 v14; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Vector4 v16; // xmm1
		  Vector4 v17; // [rsp+50h] [rbp-38h] BYREF
		  Vector4 v18; // [rsp+60h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3766, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3766, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v14);
		    v16 = *scaleBiasTex;
		    v18 = *scaleBiasRT;
		    v17 = v16;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1325(
		      Patch,
		      (Object *)cmd,
		      (Object *)source,
		      textureSize,
		      &v17,
		      &v18,
		      mipLevelTex,
		      bilinear,
		      paddingInPixels,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::Blitter);
		    v13 = *scaleBiasTex;
		    v17 = *scaleBiasRT;
		    v18 = v13;
		    UnityEngine::Rendering::Blitter::BlitOctahedralWithPadding(
		      cmd,
		      source,
		      textureSize,
		      &v18,
		      &v17,
		      mipLevelTex,
		      bilinear,
		      paddingInPixels,
		      0LL);
		  }
		}
		
		public static void BlitOctahedralWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) {} // 0x0000000189C0AF0C-0x0000000189C0B048
		// Void BlitOctahedralWithPaddingMultiply(CommandBuffer, Texture, Vector2, Vector4, Vector4, Int32, Boolean, Int32)
		void HG::Rendering::Runtime::HGUtils::BlitOctahedralWithPaddingMultiply(
		        CommandBuffer *cmd,
		        Texture *source,
		        Vector2 textureSize,
		        Vector4 *scaleBiasTex,
		        Vector4 *scaleBiasRT,
		        int32_t mipLevelTex,
		        bool bilinear,
		        int32_t paddingInPixels,
		        MethodInfo *method)
		{
		  Vector4 v13; // xmm1
		  __int64 v14; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Vector4 v16; // xmm1
		  Vector4 v17; // [rsp+50h] [rbp-38h] BYREF
		  Vector4 v18; // [rsp+60h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3767, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3767, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v14);
		    v16 = *scaleBiasTex;
		    v18 = *scaleBiasRT;
		    v17 = v16;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1325(
		      Patch,
		      (Object *)cmd,
		      (Object *)source,
		      textureSize,
		      &v17,
		      &v18,
		      mipLevelTex,
		      bilinear,
		      paddingInPixels,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::Blitter);
		    v13 = *scaleBiasTex;
		    v17 = *scaleBiasRT;
		    v18 = v13;
		    UnityEngine::Rendering::Blitter::BlitOctahedralWithPaddingMultiply(
		      cmd,
		      source,
		      textureSize,
		      &v18,
		      &v17,
		      mipLevelTex,
		      bilinear,
		      paddingInPixels,
		      0LL);
		  }
		}
		
		[IDTag(0)]
		public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear) {} // 0x0000000189C0B690-0x0000000189C0B75C
		// Void BlitTexture(CommandBuffer, RTHandle, Vector4, Single, Boolean)
		void HG::Rendering::Runtime::HGUtils::BlitTexture(
		        CommandBuffer *cmd,
		        RTHandle *source,
		        Vector4 *scaleBias,
		        float mipLevel,
		        bool bilinear,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Vector4 v11; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3768, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3768, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v9);
		    v11 = *scaleBias;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1326(
		      Patch,
		      (Object *)cmd,
		      (Object *)source,
		      &v11,
		      mipLevel,
		      bilinear,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::Blitter);
		    v11 = *scaleBias;
		    UnityEngine::Rendering::Blitter::BlitTexture(cmd, source, &v11, mipLevel, bilinear, 0LL);
		  }
		}
		
		public static void BlitTexture2D(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear) {} // 0x0000000189C0B4F8-0x0000000189C0B5C4
		// Void BlitTexture2D(CommandBuffer, RTHandle, Vector4, Single, Boolean)
		void HG::Rendering::Runtime::HGUtils::BlitTexture2D(
		        CommandBuffer *cmd,
		        RTHandle *source,
		        Vector4 *scaleBias,
		        float mipLevel,
		        bool bilinear,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Vector4 v11; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3769, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3769, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v9);
		    v11 = *scaleBias;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1326(
		      Patch,
		      (Object *)cmd,
		      (Object *)source,
		      &v11,
		      mipLevel,
		      bilinear,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::Blitter);
		    v11 = *scaleBias;
		    UnityEngine::Rendering::Blitter::BlitTexture2D(cmd, source, &v11, mipLevel, bilinear, 0LL);
		  }
		}
		
		[IDTag(1)]
		private static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass) {} // 0x0000000189C0B5C4-0x0000000189C0B690
		// Void BlitTexture(CommandBuffer, RTHandle, Vector4, Material, Int32)
		void HG::Rendering::Runtime::HGUtils::BlitTexture(
		        CommandBuffer *cmd,
		        RTHandle *source,
		        Vector4 *scaleBias,
		        Material *material,
		        int32_t pass,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Vector4 v12; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3770, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3770, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v10);
		    v12 = *scaleBias;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1327(
		      Patch,
		      (Object *)cmd,
		      (Object *)source,
		      &v12,
		      (Object *)material,
		      pass,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::Blitter);
		    v12 = *scaleBias;
		    UnityEngine::Rendering::Blitter::BlitTexture(cmd, source, &v12, material, pass, 0LL);
		  }
		}
		
		[IDTag(0)]
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0f /* Metadata: 0x02303EC3 */, bool bilinear = false /* Metadata: 0x02303EC7 */) {} // 0x0000000189C0AD6C-0x0000000189C0AE20
		// Void BlitCameraTexture(CommandBuffer, RTHandle, RTHandle, Single, Boolean)
		void HG::Rendering::Runtime::HGUtils::BlitCameraTexture(
		        CommandBuffer *cmd,
		        RTHandle *source,
		        RTHandle *destination,
		        float mipLevel,
		        bool bilinear,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3771, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3771, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1328(
		      Patch,
		      (Object *)cmd,
		      (Object *)source,
		      (Object *)destination,
		      mipLevel,
		      bilinear,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::Blitter);
		    UnityEngine::Rendering::Blitter::BlitCameraTexture(cmd, source, destination, mipLevel, bilinear, 0LL);
		  }
		}
		
		public static void BlitCameraTexture2D(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0f /* Metadata: 0x02303EC8 */, bool bilinear = false /* Metadata: 0x02303ECC */) {} // 0x0000000189C0AB1C-0x0000000189C0ABD0
		// Void BlitCameraTexture2D(CommandBuffer, RTHandle, RTHandle, Single, Boolean)
		void HG::Rendering::Runtime::HGUtils::BlitCameraTexture2D(
		        CommandBuffer *cmd,
		        RTHandle *source,
		        RTHandle *destination,
		        float mipLevel,
		        bool bilinear,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3772, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3772, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1328(
		      Patch,
		      (Object *)cmd,
		      (Object *)source,
		      (Object *)destination,
		      mipLevel,
		      bilinear,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::Blitter);
		    UnityEngine::Rendering::Blitter::BlitCameraTexture2D(cmd, source, destination, mipLevel, bilinear, 0LL);
		  }
		}
		
		[IDTag(1)]
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material, int pass) {} // 0x0000000189C0ACBC-0x0000000189C0AD6C
		// Void BlitCameraTexture(CommandBuffer, RTHandle, RTHandle, Material, Int32)
		void HG::Rendering::Runtime::HGUtils::BlitCameraTexture(
		        CommandBuffer *cmd,
		        RTHandle *source,
		        RTHandle *destination,
		        Material *material,
		        int32_t pass,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3773, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3773, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1329(
		      Patch,
		      (Object *)cmd,
		      (Object *)source,
		      (Object *)destination,
		      (Object *)material,
		      pass,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::Blitter);
		    UnityEngine::Rendering::Blitter::BlitCameraTexture(cmd, source, destination, material, pass, 0LL);
		  }
		}
		
		[IDTag(2)]
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Vector4 scaleBias, float mipLevel = 0f /* Metadata: 0x02303ECD */, bool bilinear = false /* Metadata: 0x02303ED1 */) {} // 0x0000000189C0ABD0-0x0000000189C0ACBC
		// Void BlitCameraTexture(CommandBuffer, RTHandle, RTHandle, Vector4, Single, Boolean)
		void HG::Rendering::Runtime::HGUtils::BlitCameraTexture(
		        CommandBuffer *cmd,
		        RTHandle *source,
		        RTHandle *destination,
		        Vector4 *scaleBias,
		        float mipLevel,
		        bool bilinear,
		        MethodInfo *method)
		{
		  __int64 v11; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Vector4 v13; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3774, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3774, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v11);
		    v13 = *scaleBias;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1330(
		      Patch,
		      (Object *)cmd,
		      (Object *)source,
		      (Object *)destination,
		      &v13,
		      mipLevel,
		      bilinear,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::Blitter);
		    v13 = *scaleBias;
		    UnityEngine::Rendering::Blitter::BlitCameraTexture(cmd, source, destination, &v13, mipLevel, bilinear, 0LL);
		  }
		}
		
		[IDTag(3)]
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect destViewport, float mipLevel = 0f /* Metadata: 0x02303ED2 */, bool bilinear = false /* Metadata: 0x02303ED6 */) {} // 0x0000000189C0AE20-0x0000000189C0AF0C
		// Void BlitCameraTexture(CommandBuffer, RTHandle, RTHandle, Rect, Single, Boolean)
		void HG::Rendering::Runtime::HGUtils::BlitCameraTexture(
		        CommandBuffer *cmd,
		        RTHandle *source,
		        RTHandle *destination,
		        Rect *destViewport,
		        float mipLevel,
		        bool bilinear,
		        MethodInfo *method)
		{
		  __int64 v11; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Rect v13; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3775, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3775, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v11);
		    v13 = *destViewport;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1331(
		      Patch,
		      (Object *)cmd,
		      (Object *)source,
		      (Object *)destination,
		      &v13,
		      mipLevel,
		      bilinear,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::Blitter);
		    v13 = *destViewport;
		    UnityEngine::Rendering::Blitter::BlitCameraTexture(cmd, source, destination, &v13, mipLevel, bilinear, 0LL);
		  }
		}
		
		[IDTag(0)]
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RTHandle colorBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x02303ED7 */) {} // 0x0000000189C0CA30-0x0000000189C0CB60
		// Void DrawFullScreen(CommandBuffer, Material, RTHandle, MaterialPropertyBlock, Int32)
		void HG::Rendering::Runtime::HGUtils::DrawFullScreen(
		        CommandBuffer *commandBuffer,
		        Material *material,
		        RTHandle *colorBuffer,
		        MaterialPropertyBlock *properties,
		        int32_t shaderPassId,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *static_fields; // rcx
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  Matrix4x4 v15; // [rsp+50h] [rbp-48h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3776, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    UnityEngine::Rendering::CoreUtils::SetRenderTarget(
		      commandBuffer,
		      colorBuffer,
		      ClearFlag__Enum_None,
		      0,
		      CubemapFace__Enum_Unknown,
		      -1,
		      0LL);
		    static_fields = (ILFixDynamicMethodWrapper_2 *)TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    if ( commandBuffer )
		    {
		      v12 = *(_OWORD *)&static_fields[2].klass;
		      *(_OWORD *)&v15.m00 = *(_OWORD *)&static_fields[1].fields.methodId;
		      v13 = *(_OWORD *)&static_fields[2].fields.virtualMachine;
		      *(_OWORD *)&v15.m01 = v12;
		      v14 = *(_OWORD *)&static_fields[2].fields.anonObj;
		      *(_OWORD *)&v15.m02 = v13;
		      *(_OWORD *)&v15.m03 = v14;
		      UnityEngine::Rendering::CommandBuffer::DrawProcedural(
		        commandBuffer,
		        &v15,
		        material,
		        shaderPassId,
		        MeshTopology__Enum_Triangles,
		        3,
		        1,
		        properties,
		        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(static_fields, v10);
		  }
		  static_fields = IFix::WrappersManagerImpl::GetPatch(3776, 0LL);
		  if ( !static_fields )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1329(
		    static_fields,
		    (Object *)commandBuffer,
		    (Object *)material,
		    (Object *)colorBuffer,
		    (Object *)properties,
		    shaderPassId,
		    0LL);
		}
		
		[IDTag(1)]
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RTHandle colorBuffer, RTHandle depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x02303ED8 */) {} // 0x0000000189C0C614-0x0000000189C0C75C
		// Void DrawFullScreen(CommandBuffer, Material, RTHandle, RTHandle, MaterialPropertyBlock, Int32)
		void HG::Rendering::Runtime::HGUtils::DrawFullScreen(
		        CommandBuffer *commandBuffer,
		        Material *material,
		        RTHandle *colorBuffer,
		        RTHandle *depthStencilBuffer,
		        MaterialPropertyBlock *properties,
		        int32_t shaderPassId,
		        MethodInfo *method)
		{
		  __int64 v11; // rdx
		  ILFixDynamicMethodWrapper_2 *static_fields; // rcx
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  Matrix4x4 v16; // [rsp+50h] [rbp-48h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3777, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    UnityEngine::Rendering::CoreUtils::SetRenderTarget(
		      commandBuffer,
		      colorBuffer,
		      depthStencilBuffer,
		      0,
		      CubemapFace__Enum_Unknown,
		      -1,
		      0LL);
		    static_fields = (ILFixDynamicMethodWrapper_2 *)TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    if ( commandBuffer )
		    {
		      v13 = *(_OWORD *)&static_fields[2].klass;
		      *(_OWORD *)&v16.m00 = *(_OWORD *)&static_fields[1].fields.methodId;
		      v14 = *(_OWORD *)&static_fields[2].fields.virtualMachine;
		      *(_OWORD *)&v16.m01 = v13;
		      v15 = *(_OWORD *)&static_fields[2].fields.anonObj;
		      *(_OWORD *)&v16.m02 = v14;
		      *(_OWORD *)&v16.m03 = v15;
		      UnityEngine::Rendering::CommandBuffer::DrawProcedural(
		        commandBuffer,
		        &v16,
		        material,
		        shaderPassId,
		        MeshTopology__Enum_Triangles,
		        3,
		        1,
		        properties,
		        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(static_fields, v11);
		  }
		  static_fields = IFix::WrappersManagerImpl::GetPatch(3777, 0LL);
		  if ( !static_fields )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1332(
		    static_fields,
		    (Object *)commandBuffer,
		    (Object *)material,
		    (Object *)colorBuffer,
		    (Object *)depthStencilBuffer,
		    (Object *)properties,
		    shaderPassId,
		    0LL);
		}
		
		[IDTag(2)]
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, RTHandle depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x02303ED9 */) {} // 0x0000000189C0C75C-0x0000000189C0C890
		// Void DrawFullScreen(CommandBuffer, Material, RenderTargetIdentifier[], RTHandle, MaterialPropertyBlock, Int32)
		void HG::Rendering::Runtime::HGUtils::DrawFullScreen(
		        CommandBuffer *commandBuffer,
		        Material *material,
		        RenderTargetIdentifier__Array *colorBuffers,
		        RTHandle *depthStencilBuffer,
		        MaterialPropertyBlock *properties,
		        int32_t shaderPassId,
		        MethodInfo *method)
		{
		  __int64 v11; // rdx
		  ILFixDynamicMethodWrapper_2 *static_fields; // rcx
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  Matrix4x4 v16; // [rsp+50h] [rbp-48h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3778, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    UnityEngine::Rendering::CoreUtils::SetRenderTarget(commandBuffer, colorBuffers, depthStencilBuffer, 0LL);
		    static_fields = (ILFixDynamicMethodWrapper_2 *)TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    if ( commandBuffer )
		    {
		      v13 = *(_OWORD *)&static_fields[2].klass;
		      *(_OWORD *)&v16.m00 = *(_OWORD *)&static_fields[1].fields.methodId;
		      v14 = *(_OWORD *)&static_fields[2].fields.virtualMachine;
		      *(_OWORD *)&v16.m01 = v13;
		      v15 = *(_OWORD *)&static_fields[2].fields.anonObj;
		      *(_OWORD *)&v16.m02 = v14;
		      *(_OWORD *)&v16.m03 = v15;
		      UnityEngine::Rendering::CommandBuffer::DrawProcedural(
		        commandBuffer,
		        &v16,
		        material,
		        shaderPassId,
		        MeshTopology__Enum_Triangles,
		        3,
		        1,
		        properties,
		        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(static_fields, v11);
		  }
		  static_fields = IFix::WrappersManagerImpl::GetPatch(3778, 0LL);
		  if ( !static_fields )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1332(
		    static_fields,
		    (Object *)commandBuffer,
		    (Object *)material,
		    (Object *)colorBuffers,
		    (Object *)depthStencilBuffer,
		    (Object *)properties,
		    shaderPassId,
		    0LL);
		}
		
		[IDTag(3)]
		public static void DrawFullScreen(CommandBuffer commandBuffer, Rect viewport, Material material, RenderTargetIdentifier destination, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x02303EDA */, int depthSlice = -1 /* Metadata: 0x02303EDB */) {} // 0x0000000189C0C890-0x0000000189C0CA30
		// Void DrawFullScreen(CommandBuffer, Rect, Material, RenderTargetIdentifier, MaterialPropertyBlock, Int32, Int32)
		void HG::Rendering::Runtime::HGUtils::DrawFullScreen(
		        CommandBuffer *commandBuffer,
		        Rect *viewport,
		        Material *material,
		        RenderTargetIdentifier *destination,
		        MaterialPropertyBlock *properties,
		        int32_t shaderPassId,
		        int32_t depthSlice,
		        MethodInfo *method)
		{
		  __int128 v12; // xmm1
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  Matrix4x4__StaticFields *static_fields; // rcx
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  __int64 v19; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int128 v21; // xmm0
		  Rect v22; // xmm1
		  Rect v23; // [rsp+58h] [rbp-19h] BYREF
		  Matrix4x4 v24; // [rsp+68h] [rbp-9h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3779, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3779, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v19);
		    v21 = *(_OWORD *)&destination->m_Type;
		    *(_OWORD *)&v24.m01 = *(_OWORD *)&destination->m_BufferPointer;
		    v22 = *viewport;
		    *(_OWORD *)&v24.m00 = v21;
		    *(_QWORD *)&v21 = *(_QWORD *)&destination->m_DepthSlice;
		    v23 = v22;
		    *(_QWORD *)&v24.m02 = v21;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1333(
		      Patch,
		      (Object *)commandBuffer,
		      &v23,
		      (Object *)material,
		      (RenderTargetIdentifier *)&v24,
		      (Object *)properties,
		      shaderPassId,
		      depthSlice,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    v12 = *(_OWORD *)&destination->m_BufferPointer;
		    *(_OWORD *)&v24.m00 = *(_OWORD *)&destination->m_Type;
		    *(_QWORD *)&v24.m02 = *(_QWORD *)&destination->m_DepthSlice;
		    *(_OWORD *)&v24.m01 = v12;
		    UnityEngine::Rendering::CoreUtils::SetRenderTarget(
		      commandBuffer,
		      (RenderTargetIdentifier *)&v24,
		      ClearFlag__Enum_None,
		      0,
		      CubemapFace__Enum_Unknown,
		      depthSlice,
		      0LL);
		    if ( !commandBuffer )
		      sub_1800D8260(v14, v13);
		    v23 = *viewport;
		    UnityEngine::Rendering::CommandBuffer::SetViewport(commandBuffer, &v23, 0LL);
		    static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    v16 = *(_OWORD *)&static_fields->identityMatrix.m01;
		    *(_OWORD *)&v24.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		    v17 = *(_OWORD *)&static_fields->identityMatrix.m02;
		    *(_OWORD *)&v24.m01 = v16;
		    v18 = *(_OWORD *)&static_fields->identityMatrix.m03;
		    *(_OWORD *)&v24.m02 = v17;
		    *(_OWORD *)&v24.m03 = v18;
		    UnityEngine::Rendering::CommandBuffer::DrawProcedural(
		      commandBuffer,
		      &v24,
		      material,
		      shaderPassId,
		      MeshTopology__Enum_Triangles,
		      3,
		      1,
		      properties,
		      0LL);
		  }
		}
		
		[IDTag(4)]
		public static void DrawFullScreen(CommandBuffer commandBuffer, Rect viewport, Material material, RenderTargetIdentifier destination, RTHandle depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x02303EDC */) {} // 0x0000000189C0C424-0x0000000189C0C614
		// Void DrawFullScreen(CommandBuffer, Rect, Material, RenderTargetIdentifier, RTHandle, MaterialPropertyBlock, Int32)
		void HG::Rendering::Runtime::HGUtils::DrawFullScreen(
		        CommandBuffer *commandBuffer,
		        Rect *viewport,
		        Material *material,
		        RenderTargetIdentifier *destination,
		        RTHandle *depthStencilBuffer,
		        MaterialPropertyBlock *properties,
		        int32_t shaderPassId,
		        MethodInfo *method)
		{
		  RenderTargetIdentifier *v12; // rax
		  __int128 v13; // xmm7
		  __int128 v14; // xmm8
		  __int64 v15; // xmm6_8
		  __int128 v16; // xmm1
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  Matrix4x4__StaticFields *static_fields; // rcx
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  __int64 v23; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int128 v25; // xmm0
		  Rect v26; // xmm1
		  Rect v27; // [rsp+58h] [rbp-79h] BYREF
		  Matrix4x4 v28; // [rsp+68h] [rbp-69h] BYREF
		  RenderTargetIdentifier v29; // [rsp+A8h] [rbp-29h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3780, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3780, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v23);
		    v25 = *(_OWORD *)&destination->m_Type;
		    *(_OWORD *)&v28.m01 = *(_OWORD *)&destination->m_BufferPointer;
		    v26 = *viewport;
		    *(_OWORD *)&v28.m00 = v25;
		    *(_QWORD *)&v28.m02 = *(_QWORD *)&destination->m_DepthSlice;
		    v27 = v26;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1334(
		      Patch,
		      (Object *)commandBuffer,
		      &v27,
		      (Object *)material,
		      (RenderTargetIdentifier *)&v28,
		      (Object *)depthStencilBuffer,
		      (Object *)properties,
		      shaderPassId,
		      0LL);
		  }
		  else
		  {
		    v12 = UnityEngine::Rendering::RTHandle::op_Implicit((RenderTargetIdentifier *)&v28, depthStencilBuffer, 0LL);
		    v13 = *(_OWORD *)&v12->m_Type;
		    v14 = *(_OWORD *)&v12->m_BufferPointer;
		    v15 = *(_QWORD *)&v12->m_DepthSlice;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    v16 = *(_OWORD *)&destination->m_BufferPointer;
		    *(_OWORD *)&v28.m00 = *(_OWORD *)&destination->m_Type;
		    *(_QWORD *)&v28.m02 = *(_QWORD *)&destination->m_DepthSlice;
		    *(_OWORD *)&v29.m_Type = v13;
		    *(_OWORD *)&v29.m_BufferPointer = v14;
		    *(_QWORD *)&v29.m_DepthSlice = v15;
		    *(_OWORD *)&v28.m01 = v16;
		    UnityEngine::Rendering::CoreUtils::SetRenderTarget(
		      commandBuffer,
		      (RenderTargetIdentifier *)&v28,
		      &v29,
		      ClearFlag__Enum_None,
		      0,
		      CubemapFace__Enum_Unknown,
		      -1,
		      0LL);
		    if ( !commandBuffer )
		      sub_1800D8260(v18, v17);
		    v27 = *viewport;
		    UnityEngine::Rendering::CommandBuffer::SetViewport(commandBuffer, &v27, 0LL);
		    static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    v20 = *(_OWORD *)&static_fields->identityMatrix.m01;
		    *(_OWORD *)&v28.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		    v21 = *(_OWORD *)&static_fields->identityMatrix.m02;
		    *(_OWORD *)&v28.m01 = v20;
		    v22 = *(_OWORD *)&static_fields->identityMatrix.m03;
		    *(_OWORD *)&v28.m02 = v21;
		    *(_OWORD *)&v28.m03 = v22;
		    UnityEngine::Rendering::CommandBuffer::DrawProcedural(
		      commandBuffer,
		      &v28,
		      material,
		      shaderPassId,
		      MeshTopology__Enum_Triangles,
		      3,
		      1,
		      properties,
		      0LL);
		  }
		}
		
		internal static Vector4 GetMouseCoordinates(HGCamera camera) => default; // 0x0000000189C0DF28-0x0000000189C0E004
		// Vector4 GetMouseCoordinates(HGCamera)
		Vector4 *HG::Rendering::Runtime::HGUtils::GetMouseCoordinates(
		        Vector4 *__return_ptr retstr,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Camera *v6; // rcx
		  MousePositionDebug *instance; // rsi
		  float m_X; // xmm0_4
		  __int64 v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v12; // [rsp+20h] [rbp-18h] BYREF
		  Vector2 InputMousePosition; // [rsp+40h] [rbp+8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3781, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3781, 0LL);
		    if ( Patch )
		    {
		      *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(&v12, Patch, (Object *)camera, 0LL);
		      return retstr;
		    }
		LABEL_7:
		    sub_1800D8260(v6, v5);
		  }
		  instance = UnityEngine::Rendering::MousePositionDebug::get_instance(0LL);
		  if ( !camera )
		    goto LABEL_7;
		  v6 = camera->fields.camera;
		  if ( !v6 )
		    goto LABEL_7;
		  UnityEngine::Camera::get_cameraType(v6, 0LL);
		  if ( !instance )
		    goto LABEL_7;
		  InputMousePosition = UnityEngine::Rendering::MousePositionDebug::GetInputMousePosition(instance, 0LL);
		  m_X = (float)camera->fields._taauRTSize_k__BackingField.m_X;
		  v9 = HIDWORD(*(_QWORD *)&camera->fields._taauRTSize_k__BackingField);
		  *(Vector2 *)&retstr->x = InputMousePosition;
		  retstr->z = InputMousePosition.x / m_X;
		  retstr->w = InputMousePosition.y / (float)(int)v9;
		  return retstr;
		}
		
		internal static Vector4 GetMouseClickCoordinates(HGCamera camera) => default; // 0x0000000189C0DE80-0x0000000189C0DF28
		// Vector4 GetMouseClickCoordinates(HGCamera)
		Vector4 *HG::Rendering::Runtime::HGUtils::GetMouseClickCoordinates(
		        Vector4 *__return_ptr retstr,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  MousePositionDebug *instance; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __m128i v8; // xmm1
		  __int64 v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v12; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3782, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3782, 0LL);
		    if ( Patch )
		    {
		      *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(&v12, Patch, (Object *)camera, 0LL);
		      return retstr;
		    }
		LABEL_6:
		    sub_1800D8260(v7, v6);
		  }
		  instance = UnityEngine::Rendering::MousePositionDebug::get_instance(0LL);
		  if ( !camera || !instance )
		    goto LABEL_6;
		  v8 = _mm_cvtsi32_si128(camera->fields._taauRTSize_k__BackingField.m_X);
		  retstr->x = 0.0;
		  retstr->y = 0.0;
		  v9 = HIDWORD(*(_QWORD *)&camera->fields._taauRTSize_k__BackingField);
		  retstr->z = 0.0 / _mm_cvtepi32_ps(v8).m128_f32[0];
		  retstr->w = 0.0 / (float)(int)v9;
		  return retstr;
		}
		
		internal static bool IsRegularPreviewCamera(Camera camera) => default; // 0x000000018344FD50-0x000000018344FDD0
		// Boolean IsRegularPreviewCamera(Camera)
		bool HG::Rendering::Runtime::HGUtils::IsRegularPreviewCamera(Camera *camera, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  unsigned int (__fastcall *v5)(Camera *); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rax
		  Object *v9; // rbx
		  Object *component; // [rsp+40h] [rbp+18h] BYREF
		
		  component = 0LL;
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size > 688 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( !v3 )
		      goto LABEL_9;
		    if ( LODWORD(v3->_0.namespaze) <= 0x2B0 )
		      sub_1800D2AB0(v3, wrapperArray);
		    if ( *(_QWORD *)&v3[14]._1.thread_static_fields_offset )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(688, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                 (ILFixDynamicMethodWrapper_20 *)Patch,
		                 (Object *)camera,
		                 0LL);
		      goto LABEL_9;
		    }
		  }
		  if ( !camera )
		    goto LABEL_9;
		  v5 = (unsigned int (__fastcall *)(Camera *))qword_18F36F138;
		  if ( !qword_18F36F138 )
		  {
		    v5 = (unsigned int (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cameraType()");
		    if ( !v5 )
		    {
		      v8 = sub_1802EE1B8("UnityEngine.Camera::get_cameraType()");
		      sub_18007E1B0(v8, 0LL);
		    }
		    qword_18F36F138 = (__int64)v5;
		  }
		  if ( v5(camera) != 4 )
		    return 0;
		  UnityEngine::Component::TryGetComponent<System::Object>(
		    (Component *)camera,
		    &component,
		    MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
		  v9 = component;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Equality((Object_1 *)v9, 0LL, 0LL) )
		    return 1;
		  if ( !component )
		LABEL_9:
		    sub_1800D8260(v3, wrapperArray);
		  return LOBYTE(component[22].klass) == 0;
		}
		
		internal static string GetHGRenderPipelinePath() => default; // 0x0000000189C0DE38-0x0000000189C0DE80
		// String GetHGRenderPipelinePath()
		String *HG::Rendering::Runtime::HGUtils::GetHGRenderPipelinePath(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2989, 0LL) )
		    return (String *)"Packages/com.hg.render-pipelines/";
		  Patch = IFix::WrappersManagerImpl::GetPatch(2989, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1106(Patch, 0LL);
		}
		
		internal static string GetCorePath() => default; // 0x0000000189C0D19C-0x0000000189C0D1E4
		// String GetCorePath()
		String *HG::Rendering::Runtime::HGUtils::GetCorePath(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3783, 0LL) )
		    return (String *)"Packages/com.unity.render-pipelines.core/";
		  Patch = IFix::WrappersManagerImpl::GetPatch(3783, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1106(Patch, 0LL);
		}
		
		internal static string GetVFXPath() => default; // 0x0000000189C0E960-0x0000000189C0E9A8
		// String GetVFXPath()
		String *HG::Rendering::Runtime::HGUtils::GetVFXPath(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3784, 0LL) )
		    return (String *)"Packages/com.unity.visualeffectgraph/";
		  Patch = IFix::WrappersManagerImpl::GetPatch(3784, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1106(Patch, 0LL);
		}
		
		internal static RenderPipelineAsset SwitchToBuiltinRenderPipeline(out bool assetWasFromQuality) {
			assetWasFromQuality = default;
			return default;
		} // 0x0000000189C10F88-0x0000000189C1105C
		// RenderPipelineAsset SwitchToBuiltinRenderPipeline(Boolean ByRef)
		RenderPipelineAsset *HG::Rendering::Runtime::HGUtils::SwitchToBuiltinRenderPipeline(
		        bool *assetWasFromQuality,
		        MethodInfo *method)
		{
		  RenderPipelineAsset *defaultRenderPipeline; // rax
		  RenderPipelineAsset *v4; // rsi
		  Object_1 *currentRenderPipeline; // rbx
		  RenderPipelineAsset *result; // rax
		  RenderPipelineAsset *renderPipeline; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3785, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3785, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1335(Patch, assetWasFromQuality, 0LL);
		  }
		  else
		  {
		    defaultRenderPipeline = UnityEngine::Rendering::GraphicsSettings::get_defaultRenderPipeline(0LL);
		    *assetWasFromQuality = 0;
		    v4 = defaultRenderPipeline;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality((Object_1 *)v4, 0LL, 0LL)
		      && (currentRenderPipeline = (Object_1 *)UnityEngine::Rendering::GraphicsSettings::get_currentRenderPipeline(0LL),
		          sub_1800036A0(TypeInfo::UnityEngine::Object),
		          UnityEngine::Object::op_Equality(currentRenderPipeline, (Object_1 *)v4, 0LL)) )
		    {
		      UnityEngine::Rendering::GraphicsSettings::set_INTERNAL_defaultRenderPipeline(0LL, 0LL);
		      return v4;
		    }
		    else
		    {
		      renderPipeline = UnityEngine::QualitySettings::get_renderPipeline(0LL);
		      UnityEngine::QualitySettings::set_INTERNAL_renderPipeline(0LL, 0LL);
		      result = renderPipeline;
		      *assetWasFromQuality = 1;
		    }
		  }
		  return result;
		}
		
		internal static void RestoreRenderPipelineAsset(bool wasUnsetFromQuality, RenderPipelineAsset renderPipelineAsset) {} // 0x0000000189C10D74-0x0000000189C10DE0
		// Void RestoreRenderPipelineAsset(Boolean, RenderPipelineAsset)
		void HG::Rendering::Runtime::HGUtils::RestoreRenderPipelineAsset(
		        bool wasUnsetFromQuality,
		        RenderPipelineAsset *renderPipelineAsset,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3786, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3786, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_155(
		      (ILFixDynamicMethodWrapper_18 *)Patch,
		      wasUnsetFromQuality,
		      (SkillData *)renderPipelineAsset,
		      0LL);
		  }
		  else if ( wasUnsetFromQuality )
		  {
		    UnityEngine::QualitySettings::set_INTERNAL_renderPipeline((ScriptableObject *)renderPipelineAsset, 0LL);
		  }
		  else
		  {
		    UnityEngine::Rendering::GraphicsSettings::set_INTERNAL_defaultRenderPipeline(
		      (ScriptableObject *)renderPipelineAsset,
		      0LL);
		  }
		}
		
		internal static int DivRoundUp(int x, int y) => default; // 0x0000000189C0C3C8-0x0000000189C0C424
		// Int32 DivRoundUp(Int32, Int32)
		int32_t HG::Rendering::Runtime::HGUtils::DivRoundUp(int32_t x, int32_t y, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3787, 0LL) )
		    return (x + y - 1) / y;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3787, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v8, v7);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_50((ILFixDynamicMethodWrapper_15 *)Patch, x, y, 0LL);
		}
		
		internal static bool IsQuaternionValid(Quaternion q) => default; // 0x0000000189C0EBF0-0x0000000189C0EC7C
		// Boolean IsQuaternionValid(Quaternion)
		bool HG::Rendering::Runtime::HGUtils::IsQuaternionValid(Quaternion *q, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Quaternion v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3788, 0LL) )
		    return (float)((float)((float)((float)(q->x * q->x) + (float)(q->y * q->y)) + (float)(q->z * q->z))
		                 + (float)(q->w * q->w)) > COERCE_FLOAT(1);
		  Patch = IFix::WrappersManagerImpl::GetPatch(3788, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *q;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1337(Patch, &v7, 0LL);
		}
		
		internal static void CheckRTCreated(RenderTexture rt) {} // 0x0000000189C0B75C-0x0000000189C0B7C4
		// Void CheckRTCreated(RenderTexture)
		void HG::Rendering::Runtime::HGUtils::CheckRTCreated(RenderTexture *rt, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3789, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3789, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)rt, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v4, v3);
		  }
		  if ( !rt )
		    goto LABEL_6;
		  if ( !UnityEngine::RenderTexture::IsCreated(rt, 0LL) )
		    UnityEngine::RenderTexture::Create(rt, 0LL);
		}
		
		internal static float ComputeViewportScale(int viewportSize, int bufferSize) => default; // 0x0000000189C0BF68-0x0000000189C0BFD8
		// Single ComputeViewportScale(Int32, Int32)
		float HG::Rendering::Runtime::HGUtils::ComputeViewportScale(
		        int32_t viewportSize,
		        int32_t bufferSize,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3790, 0LL) )
		    return (float)(1.0 / (float)bufferSize) * (float)viewportSize;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3790, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v8, v7);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1338(Patch, viewportSize, bufferSize, 0LL);
		}
		
		internal static float ComputeViewportLimit(int viewportSize, int bufferSize) => default; // 0x0000000189C0BDE4-0x0000000189C0BE5C
		// Single ComputeViewportLimit(Int32, Int32)
		float HG::Rendering::Runtime::HGUtils::ComputeViewportLimit(
		        int32_t viewportSize,
		        int32_t bufferSize,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3791, 0LL) )
		    return (float)((float)viewportSize - 0.5) * (float)(1.0 / (float)bufferSize);
		  Patch = IFix::WrappersManagerImpl::GetPatch(3791, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v8, v7);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1338(Patch, viewportSize, bufferSize, 0LL);
		}
		
		internal static Vector4 ComputeViewportScaleAndLimit(Vector2Int viewportSize, Vector2Int bufferSize) => default; // 0x0000000189C0BE5C-0x0000000189C0BF68
		// Vector4 ComputeViewportScaleAndLimit(Vector2Int, Vector2Int)
		Vector4 *HG::Rendering::Runtime::HGUtils::ComputeViewportScaleAndLimit(
		        Vector4 *__return_ptr retstr,
		        Vector2Int viewportSize,
		        Vector2Int bufferSize,
		        MethodInfo *method)
		{
		  float v7; // xmm8_4
		  float v8; // xmm7_4
		  float v9; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  Vector4 v14; // [rsp+30h] [rbp-48h] BYREF
		  int32_t viewportSizea; // [rsp+8Ch] [rbp+14h]
		  int32_t bufferSizea; // [rsp+94h] [rbp+1Ch]
		
		  bufferSizea = bufferSize.m_Y;
		  viewportSizea = viewportSize.m_Y;
		  if ( IFix::WrappersManagerImpl::IsPatched(3792, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3792, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1339(&v14, Patch, viewportSize, bufferSize, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    v7 = HG::Rendering::Runtime::HGUtils::ComputeViewportScale(viewportSize.m_X, bufferSize.m_X, 0LL);
		    v8 = HG::Rendering::Runtime::HGUtils::ComputeViewportScale(viewportSizea, bufferSizea, 0LL);
		    v9 = HG::Rendering::Runtime::HGUtils::ComputeViewportLimit(viewportSize.m_X, bufferSize.m_X, 0LL);
		    retstr->w = HG::Rendering::Runtime::HGUtils::ComputeViewportLimit(viewportSizea, bufferSizea, 0LL);
		    retstr->x = v7;
		    retstr->y = v8;
		    retstr->z = v9;
		  }
		  return retstr;
		}
		
		internal static bool IsSupportedGraphicDevice(GraphicsDeviceType graphicDevice) => default; // 0x0000000189C0EC7C-0x0000000189C0ECE0
		// Boolean IsSupportedGraphicDevice(GraphicsDeviceType)
		bool HG::Rendering::Runtime::HGUtils::IsSupportedGraphicDevice(
		        GraphicsDeviceType__Enum graphicDevice,
		        MethodInfo *method)
		{
		  int v3; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3793, 0LL) )
		    return (unsigned int)graphicDevice <= GraphicsDeviceType__Enum_PlayStation5NGGC
		        && (v3 = 262627588, _bittest(&v3, graphicDevice))
		        || graphicDevice == GraphicsDeviceType__Enum_OpenGLES3;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3793, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v7, v6);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_95(
		           (ILFixDynamicMethodWrapper_17 *)Patch,
		           (AudioLogChannel__Enum)graphicDevice,
		           0LL);
		}
		
		internal static bool IsMacOSVersionAtLeast(string os, int majorVersion, int minorVersion, int patchVersion) => default; // 0x0000000189C0EA6C-0x0000000189C0EBA4
		// Boolean IsMacOSVersionAtLeast(String, Int32, Int32, Int32)
		bool HG::Rendering::Runtime::HGUtils::IsMacOSVersionAtLeast(
		        String *os,
		        int32_t majorVersion,
		        int32_t minorVersion,
		        int32_t patchVersion,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  int32_t IndexOf; // eax
		  String *v12; // rax
		  String__Array *v13; // rax
		  String__Array *v14; // rdi
		  String *v15; // rbx
		  int32_t v16; // ebp
		  int32_t v17; // ebx
		  int32_t v18; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3794, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3794, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_253(
		               (ILFixDynamicMethodWrapper_6 *)Patch,
		               (Object *)os,
		               majorVersion,
		               minorVersion,
		               patchVersion,
		               0LL);
		LABEL_17:
		    sub_1800D8260(v10, v9);
		  }
		  if ( !os )
		    goto LABEL_17;
		  IndexOf = System::String::LastIndexOf(os, (String *)" ", 0LL);
		  v12 = System::String::Substring(os, IndexOf + 1, 0LL);
		  if ( !v12 )
		    goto LABEL_17;
		  v13 = System::String::Split(v12, 0x2Eu, StringSplitOptions__Enum_None, 0LL);
		  v14 = v13;
		  if ( !v13 )
		    goto LABEL_17;
		  if ( !v13->max_length.size
		    || (v15 = v13->vector[0],
		        sub_1800036A0(TypeInfo::System::Convert),
		        v16 = System::Convert::ToInt32(v15, 0LL),
		        v14->max_length.size <= 1u)
		    || (v17 = System::Convert::ToInt32(v14->vector[1], 0LL), v14->max_length.size <= 2u) )
		  {
		    sub_1800D2AB0(v10, v9);
		  }
		  v18 = System::Convert::ToInt32(v14->vector[2], 0LL);
		  return v16 >= majorVersion
		      && (v16 > majorVersion || v17 >= minorVersion && (v17 > minorVersion || v18 >= patchVersion));
		}
		
		internal static bool IsOperatingSystemSupported(string os) => default; // 0x0000000189C0EBA4-0x0000000189C0EBF0
		// Boolean IsOperatingSystemSupported(String)
		bool HG::Rendering::Runtime::HGUtils::IsOperatingSystemSupported(String *os, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3795, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3795, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)os, 0LL);
		}
		
		internal static bool IsGraphicsAPIOpenGL() => default; // 0x0000000189C0EA00-0x0000000189C0EA6C
		// Boolean IsGraphicsAPIOpenGL()
		bool HG::Rendering::Runtime::HGUtils::IsGraphicsAPIOpenGL(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3796, 0LL) )
		    return UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_OpenGLES2
		        || UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_OpenGLES3
		        || UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_OpenGLCore;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3796, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		}
		
		internal static void GetScaleAndBiasForLinearDistanceFade(float fadeDistance, out float scale, out float bias) {
			scale = default;
			bias = default;
		} // 0x0000000189C0E4F4-0x0000000189C0E594
		// Void GetScaleAndBiasForLinearDistanceFade(Single, Single ByRef, Single ByRef)
		void HG::Rendering::Runtime::HGUtils::GetScaleAndBiasForLinearDistanceFade(
		        float fadeDistance,
		        float *scale,
		        float *bias,
		        MethodInfo *method)
		{
		  float v6; // xmm1_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3797, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3797, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1342(Patch, fadeDistance, scale, bias, 0LL);
		  }
		  else
		  {
		    v6 = fadeDistance - (float)(fadeDistance * 0.89999998);
		    *scale = 1.0 / v6;
		    *bias = (float)-(float)(fadeDistance * 0.89999998) / v6;
		  }
		}
		
		internal static float ComputeLinearDistanceFade(float distanceToCamera, float fadeDistance) => default; // 0x0000000189C0BA24-0x0000000189C0BAD0
		// Single ComputeLinearDistanceFade(Single, Single)
		float HG::Rendering::Runtime::HGUtils::ComputeLinearDistanceFade(
		        float distanceToCamera,
		        float fadeDistance,
		        MethodInfo *method)
		{
		  float v4; // xmm0_4
		  Beyond::JobMathf *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  float bias[4]; // [rsp+20h] [rbp-38h] BYREF
		  float scale; // [rsp+78h] [rbp+20h] BYREF
		
		  scale = 0.0;
		  bias[0] = 0.0;
		  if ( IFix::WrappersManagerImpl::IsPatched(3798, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3798, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(Patch, distanceToCamera, fadeDistance, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    HG::Rendering::Runtime::HGUtils::GetScaleAndBiasForLinearDistanceFade(fadeDistance, &scale, bias, 0LL);
		    v4 = (float)(scale * distanceToCamera) + bias[0];
		    Beyond::JobMathf::Clamp01(v5, fadeDistance);
		    return 1.0 - v4;
		  }
		}
		
		internal static float ComputeWeightedLinearFadeDistance(Vector3 position1, Vector3 position2, float weight, float fadeDistance) => default; // 0x0000000189C0BFD8-0x0000000189C0C100
		// Single ComputeWeightedLinearFadeDistance(Vector3, Vector3, Single, Single)
		float HG::Rendering::Runtime::HGUtils::ComputeWeightedLinearFadeDistance(
		        Vector3 *position1,
		        Vector3 *position2,
		        float weight,
		        float fadeDistance,
		        MethodInfo *method)
		{
		  MethodInfo *v8; // r9
		  float v9; // eax
		  __int64 v10; // xmm0_8
		  float v11; // eax
		  Vector3 *v12; // rax
		  __int64 v13; // xmm3_8
		  double v14; // xmm0_8
		  float v15; // xmm6_4
		  __int64 v17; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  __int64 v20; // xmm0_8
		  float v21; // eax
		  Vector3 v22; // [rsp+38h] [rbp-11h] BYREF
		  Vector3 v23; // [rsp+48h] [rbp-1h] BYREF
		  Vector3 v24[2]; // [rsp+58h] [rbp+Fh] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3799, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3799, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v17);
		    z = position2->z;
		    *(_QWORD *)&v23.x = *(_QWORD *)&position2->x;
		    v20 = *(_QWORD *)&position1->x;
		    v23.z = z;
		    v21 = position1->z;
		    *(_QWORD *)&v22.x = v20;
		    v22.z = v21;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1343(Patch, &v22, &v23, weight, fadeDistance, 0LL);
		  }
		  else
		  {
		    v9 = position2->z;
		    *(_QWORD *)&v22.x = *(_QWORD *)&position2->x;
		    v10 = *(_QWORD *)&position1->x;
		    v22.z = v9;
		    v11 = position1->z;
		    *(_QWORD *)&v23.x = v10;
		    v23.z = v11;
		    v12 = UnityEngine::Vector3::op_Subtraction(v24, &v23, &v22, v8);
		    v13 = *(_QWORD *)&v12->x;
		    *(float *)&v12 = v12->z;
		    *(_QWORD *)&v23.x = v13;
		    LODWORD(v23.z) = (_DWORD)v12;
		    v14 = sub_182FAE390(&v23);
		    v15 = *(float *)&v14;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    return HG::Rendering::Runtime::HGUtils::ComputeLinearDistanceFade(v15, fadeDistance, 0LL) * weight;
		  }
		}
		
		internal static bool PostProcessIsFinalPass(HGCamera hgCamera) => default; // 0x0000000189C0F5E8-0x0000000189C0F648
		// Boolean PostProcessIsFinalPass(HGCamera)
		bool HG::Rendering::Runtime::HGUtils::PostProcessIsFinalPass(HGCamera *hgCamera, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3800, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3800, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		             (ILFixDynamicMethodWrapper_20 *)Patch,
		             (Object *)hgCamera,
		             0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Debug);
		    return !UnityEngine::Debug::get_isDebugBuild(0LL);
		  }
		}
		
		internal static Vector4 ConvertGUIDToVector4(string guid) => default; // 0x0000000189C0C100-0x0000000189C0C1EC
		// Vector4 ConvertGUIDToVector4(String)
		Vector4 *HG::Rendering::Runtime::HGUtils::ConvertGUIDToVector4(
		        Vector4 *__return_ptr retstr,
		        String *guid,
		        MethodInfo *method)
		{
		  Vector4 *v5; // rbx
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int64 v8; // rdi
		  int v9; // esi
		  String *v10; // rax
		  uint8_t v11; // al
		  __int64 v12; // rcx
		  Vector4 v13; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 *result; // rax
		  Vector4 v16; // [rsp+20h] [rbp-18h] BYREF
		
		  v5 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3801, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3801, 0LL);
		    if ( Patch )
		    {
		      v13 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(&v16, Patch, (Object *)guid, 0LL);
		      goto LABEL_13;
		    }
		LABEL_11:
		    sub_1800D8260(v7, v6);
		  }
		  v8 = il2cpp_array_new_specific_1(TypeInfo::System::Byte, 16LL);
		  v9 = 0;
		  if ( !guid )
		    goto LABEL_11;
		  do
		  {
		    v10 = System::String::Substring(guid, 2 * v9, 2, 0LL);
		    v11 = System::Byte::Parse(v10, NumberStyles__Enum_HexNumber, 0LL);
		    if ( !v8 )
		      goto LABEL_11;
		    if ( (unsigned int)v9 >= *(_DWORD *)(v8 + 24) )
		      sub_1800D2AB0(v7, v6);
		    v12 = v9++;
		    *(_BYTE *)(v12 + v8 + 32) = v11;
		  }
		  while ( v9 < 16 );
		  if ( *(_DWORD *)(v8 + 24) )
		    v5 = (Vector4 *)(v8 + 32);
		  v13 = *v5;
		LABEL_13:
		  result = retstr;
		  *retstr = v13;
		  return result;
		}
		
		internal static string ConvertVector4ToGUID(Vector4 vector) => default; // 0x0000000189C0C1EC-0x0000000189C0C2F0
		// String ConvertVector4ToGUID(Vector4)
		String *HG::Rendering::Runtime::HGUtils::ConvertVector4ToGUID(Vector4 *vector, MethodInfo *method)
		{
		  StringBuilder *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  StringBuilder *v6; // rdi
		  Byte *v7; // rbx
		  __int64 v8; // rbp
		  String *v9; // rax
		  Byte__Array *v10; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3802, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3802, 0LL);
		    if ( Patch )
		    {
		      v13 = *vector;
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1344(Patch, &v13, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v5, v4);
		  }
		  v3 = (StringBuilder *)sub_18002C620(TypeInfo::System::Text::StringBuilder);
		  v6 = v3;
		  if ( !v3 )
		    goto LABEL_7;
		  System::Text::StringBuilder::StringBuilder(v3, 0LL);
		  v7 = (Byte *)vector;
		  v8 = 16LL;
		  do
		  {
		    v9 = System::Byte::ToString(v7, (String *)"x2", 0LL);
		    System::Text::StringBuilder::Append(v6, v9, 0LL);
		    ++v7;
		    --v8;
		  }
		  while ( v8 );
		  v10 = (Byte__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Byte, 16LL);
		  sub_1800036A0(TypeInfo::System::Runtime::InteropServices::Marshal);
		  System::Runtime::InteropServices::Marshal::Copy(vector, v10, 0, 16, 0LL);
		  return (String *)sub_180032CB0(3LL, v6);
		}
		
		public static UnityEngine.Color NormalizeColor(UnityEngine.Color color) => default; // 0x0000000189C0ED68-0x0000000189C0EF4C
		// Color NormalizeColor(Color)
		Color *HG::Rendering::Runtime::HGUtils::NormalizeColor(Color *__return_ptr retstr, Color *color, MethodInfo *method)
		{
		  MethodInfo *v5; // rdx
		  MethodInfo *v6; // r9
		  MethodInfo *v7; // r8
		  MethodInfo *v8; // r8
		  __m128 v9; // xmm1
		  __m128 v10; // xmm4
		  float v11; // xmm5_4
		  float v12; // xmm2_4
		  float v13; // xmm0_4
		  float v14; // xmm3_4
		  float v15; // xmm0_4
		  float v16; // xmm1_4
		  float v17; // xmm4_4
		  __m128 v18; // xmm7
		  __m128 v19; // xmm6
		  float v20; // xmm3_4
		  MethodInfo *v21; // r8
		  Color v22; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  Color *result; // rax
		  Vector4 v27; // [rsp+20h] [rbp-50h] BYREF
		  Color v28; // [rsp+30h] [rbp-40h] BYREF
		  Vector4 v29; // [rsp+40h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3803, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3803, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v25, v24);
		    v28 = *color;
		    v22 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345((Color *)&v29, Patch, &v28, 0LL);
		  }
		  else
		  {
		    v28 = *color;
		    v27 = *UnityEngine::Vector4::get_one(&v27, v5);
		    UnityEngine::Vector4::op_Multiply(&v29, &v27, 0.000099999997, v6);
		    v9 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit((Color *)&v29, (Vector4 *)&v28, v7));
		    if ( v9.m128_f32[0] <= v10.m128_f32[0] )
		      v11 = v10.m128_f32[0];
		    else
		      v11 = v9.m128_f32[0];
		    v12 = _mm_shuffle_ps(v9, v9, 85).m128_f32[0];
		    v13 = _mm_shuffle_ps(v10, v10, 85).m128_f32[0];
		    if ( v12 <= v13 )
		      v12 = v13;
		    v14 = _mm_shuffle_ps(v9, v9, 170).m128_f32[0];
		    v15 = _mm_shuffle_ps(v10, v10, 170).m128_f32[0];
		    if ( v14 <= v15 )
		      v14 = v15;
		    v16 = _mm_shuffle_ps(v9, v9, 255).m128_f32[0];
		    v17 = _mm_shuffle_ps(v10, v10, 255).m128_f32[0];
		    if ( v16 <= v17 )
		      v16 = v17;
		    v27.x = v11;
		    v27.y = v12;
		    v27.z = v14;
		    v27.w = v16;
		    v18 = (__m128)v27;
		    v28 = (Color)v27;
		    v19 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit((Color *)&v29, (Vector4 *)&v28, v8));
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ColorUtils);
		    v20 = (float)((float)(_mm_shuffle_ps(v19, v19, 85).m128_f32[0] * 0.7151522) + (float)(v19.m128_f32[0] * 0.2126729))
		        + (float)(_mm_shuffle_ps(v19, v19, 170).m128_f32[0] * 0.072175004);
		    v27.x = v18.m128_f32[0] / v20;
		    v27.y = _mm_shuffle_ps(v18, v18, 85).m128_f32[0] / v20;
		    v27.z = _mm_shuffle_ps(v18, v18, 170).m128_f32[0] / v20;
		    v27.w = _mm_shuffle_ps(v18, v18, 255).m128_f32[0] / v20;
		    v28 = (Color)v27;
		    *color = *UnityEngine::Color::op_Implicit((Color *)&v29, (Vector4 *)&v28, v21);
		    color->a = 1.0;
		    v22 = *color;
		  }
		  result = retstr;
		  *retstr = v22;
		  return result;
		}
		
		[Obsolete("Please use CoreUtils.DrawRendererList instead.")]
		public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, UnityEngine.Rendering.RendererUtils.RendererList rendererList) {} // 0x0000000189C0CB60-0x0000000189C0CBFC
		// Void DrawRendererList(ScriptableRenderContext, CommandBuffer, RendererList)
		void HG::Rendering::Runtime::HGUtils::DrawRendererList(
		        ScriptableRenderContext renderContext,
		        CommandBuffer *cmd,
		        RendererList *rendererList,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  RendererList v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3804, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3804, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v10 = *rendererList;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1346(Patch, renderContext, (Object *)cmd, &v10, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    v10 = *rendererList;
		    UnityEngine::Rendering::CoreUtils::DrawRendererList(renderContext, cmd, &v10, 0LL);
		  }
		}
		
		internal static string ComputeProbeCameraName(string probeName, int face, string viewerName) => default; // 0x0000000189C0BAD0-0x0000000189C0BDE4
		// String ComputeProbeCameraName(String, Int32, String)
		String *HG::Rendering::Runtime::HGUtils::ComputeProbeCameraName(
		        String *probeName,
		        int32_t face,
		        String *viewerName,
		        MethodInfo *method)
		{
		  __int64 stringLength; // rdx
		  unsigned __int64 static_fields; // rcx
		  String *v9; // rsi
		  unsigned __int64 v10; // r8
		  __int64 v11; // rax
		  void *v12; // rsp
		  uint16_t *p_value; // r12
		  int32_t v14; // r14d
		  uint16_t *i; // rdi
		  uint16_t Chars; // ax
		  int32_t v17; // r14d
		  int32_t v18; // r15d
		  int32_t j; // ebx
		  _WORD *v20; // r15
		  int v21; // ecx
		  uint16_t *v22; // rdi
		  int32_t k; // ebx
		  uint16_t v24; // ax
		  int v25; // ebx
		  int32_t v26; // r15d
		  int v27; // esi
		  int32_t m; // ebx
		  uint16_t v29; // ax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  uint16_t value; // [rsp+30h] [rbp+0h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3805, 0LL) )
		  {
		    if ( !probeName )
		    {
		      static_fields = (unsigned __int64)TypeInfo::System::String->static_fields;
		      probeName = *(String **)static_fields;
		    }
		    v9 = (String *)"null";
		    if ( viewerName )
		      v9 = viewerName;
		    if ( !probeName )
		      goto LABEL_52;
		    static_fields = 40LL;
		    if ( probeName->fields._stringLength < 40 )
		      static_fields = (unsigned int)probeName->fields._stringLength;
		    if ( !v9 )
		      goto LABEL_52;
		    stringLength = 40LL;
		    if ( v9->fields._stringLength < 40 )
		      stringLength = (unsigned int)v9->fields._stringLength;
		    if ( !"HGProbe RenderCamera (" || !": " || !" for viewer '" || !"')" )
		      goto LABEL_52;
		    v10 = 2LL
		        * (*(_DWORD *)"mera ("
		         + *(_DWORD *)&asc_190F00328[16]
		         + *(_DWORD *)&aForViewer[16]
		         + 2
		         + (int)static_fields
		         + (int)stringLength
		         + *(_DWORD *)&asc_190E8FC5F[16]);
		    if ( v10 )
		    {
		      v11 = v10 + 15;
		      if ( v10 + 15 < v10 )
		        v11 = 0xFFFFFFFFFFFFFF0LL;
		      v12 = alloca(v11 & 0xFFFFFFFFFFFFFFF0uLL);
		      p_value = &value;
		    }
		    else
		    {
		      p_value = 0LL;
		    }
		    sub_18033B9D0(p_value, 0LL, v10);
		    v14 = 0;
		    for ( i = p_value; ; ++i )
		    {
		      static_fields = (unsigned __int64)"HGProbe RenderCamera (";
		      if ( !"HGProbe RenderCamera (" )
		        goto LABEL_52;
		      if ( v14 >= *(_DWORD *)"mera (" )
		        break;
		      Chars = System::String::get_Chars((String *)"HGProbe RenderCamera (", v14++, 0LL);
		      *i = Chars;
		    }
		    v17 = probeName->fields._stringLength;
		    v18 = 0;
		    if ( v17 >= 40 )
		    {
		      v17 = 40;
		    }
		    else if ( v17 <= 0 )
		    {
		LABEL_30:
		      for ( j = 0; ; ++j )
		      {
		        static_fields = (unsigned __int64)": ";
		        if ( !": " )
		          goto LABEL_52;
		        v20 = i + 1;
		        if ( j >= *(_DWORD *)&asc_190F00328[16] )
		          break;
		        *i++ = System::String::get_Chars((String *)": ", j, 0LL);
		      }
		      v21 = (205 * face) >> 11;
		      *i = v21 + 48;
		      v22 = i + 2;
		      *v20 = face - 10 * v21 + 48;
		      for ( k = 0; ; ++k )
		      {
		        static_fields = (unsigned __int64)" for viewer '";
		        if ( !" for viewer '" )
		          goto LABEL_52;
		        if ( k >= *(_DWORD *)&aForViewer[16] )
		          break;
		        v24 = System::String::get_Chars((String *)" for viewer '", k, 0LL);
		        *v22++ = v24;
		      }
		      v25 = v9->fields._stringLength;
		      v26 = 0;
		      if ( v25 >= 40 )
		      {
		        v25 = 40;
		      }
		      else if ( v25 <= 0 )
		      {
		LABEL_43:
		        v27 = v25 + v17;
		        for ( m = 0; ; ++m )
		        {
		          if ( !"')" )
		            goto LABEL_52;
		          if ( m >= *(_DWORD *)&asc_190E8FC5F[16] )
		            break;
		          v29 = System::String::get_Chars((String *)"')", m, 0LL);
		          *v22++ = v29;
		        }
		        static_fields = (unsigned __int64)"HGProbe RenderCamera (";
		        if ( "HGProbe RenderCamera (" )
		        {
		          static_fields = (unsigned __int64)": ";
		          if ( ": " )
		          {
		            static_fields = (unsigned __int64)" for viewer '";
		            if ( " for viewer '" )
		              return System::String::CreateString(
		                       0LL,
		                       p_value,
		                       0,
		                       *(_DWORD *)"mera ("
		                     + 2
		                     + *(_DWORD *)&aForViewer[16]
		                     + v27
		                     + *(_DWORD *)&asc_190E8FC5F[16]
		                     + *(_DWORD *)&asc_190F00328[16],
		                       0LL);
		          }
		        }
		LABEL_52:
		        sub_1800D8260(static_fields, stringLength);
		      }
		      do
		        *v22++ = System::String::get_Chars(v9, v26++, 0LL);
		      while ( v26 < v25 );
		      goto LABEL_43;
		    }
		    do
		      *i++ = System::String::get_Chars(probeName, v18++, 0LL);
		    while ( v18 < v17 );
		    goto LABEL_30;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3805, 0LL);
		  if ( !Patch )
		    goto LABEL_52;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1347(Patch, (Object *)probeName, face, (Object *)viewerName, 0LL);
		}
		
		internal static string ComputeCameraName(string cameraName) => default; // 0x0000000189C0B8D4-0x0000000189C0BA24
		// String ComputeCameraName(String)
		String *HG::Rendering::Runtime::HGUtils::ComputeCameraName(String *cameraName, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  int32_t stringLength; // ebx
		  unsigned __int64 v6; // r8
		  __int64 v7; // rax
		  void *v8; // rsp
		  uint16_t *p_value; // rsi
		  int32_t v10; // r14d
		  uint16_t *i; // r15
		  uint16_t Chars; // ax
		  int32_t j; // r14d
		  uint16_t v14; // ax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  uint16_t value; // [rsp+30h] [rbp+0h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2776, 0LL) )
		  {
		    if ( cameraName )
		    {
		      stringLength = 40;
		      if ( cameraName->fields._stringLength < 40 )
		        stringLength = cameraName->fields._stringLength;
		      if ( "HGRenderPipeline::Render " )
		      {
		        v6 = 2LL * (stringLength + *(_DWORD *)"::Render ");
		        if ( v6 )
		        {
		          v7 = v6 + 15;
		          if ( v6 + 15 < v6 )
		            v7 = 0xFFFFFFFFFFFFFF0LL;
		          v8 = alloca(v7 & 0xFFFFFFFFFFFFFFF0uLL);
		          p_value = &value;
		        }
		        else
		        {
		          p_value = 0LL;
		        }
		        sub_18033B9D0(p_value, 0LL, v6);
		        v10 = 0;
		        for ( i = p_value; ; ++i )
		        {
		          if ( !"HGRenderPipeline::Render " )
		            goto LABEL_20;
		          if ( v10 >= *(_DWORD *)"::Render " )
		            break;
		          Chars = System::String::get_Chars((String *)"HGRenderPipeline::Render ", v10++, 0LL);
		          *i = Chars;
		        }
		        for ( j = 0; j < stringLength; ++i )
		        {
		          v14 = System::String::get_Chars(cameraName, j++, 0LL);
		          *i = v14;
		        }
		        if ( "HGRenderPipeline::Render " )
		          return System::String::CreateString(0LL, p_value, 0, stringLength + *(_DWORD *)"::Render ", 0LL);
		      }
		    }
		LABEL_20:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2776, 0LL);
		  if ( !Patch )
		    goto LABEL_20;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)cameraName, 0LL);
		}
		
		internal static float ClampFOV(float fov) => default; // 0x0000000189C0B7C4-0x0000000189C0B838
		// Single ClampFOV(Single)
		float HG::Rendering::Runtime::HGUtils::ClampFOV(float fov, MethodInfo *method)
		{
		  float v2; // xmm6_4
		  int v3; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  v2 = fov;
		  if ( IFix::WrappersManagerImpl::IsPatched(3806, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3806, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, fov, 0LL);
		  }
		  else
		  {
		    v3 = 925353388;
		    if ( v2 < 0.0000099999997 )
		      return *(float *)&v3;
		    v3 = 1127415808;
		    if ( v2 > 179.0 )
		      return *(float *)&v3;
		    return v2;
		  }
		}
		
		internal static ulong GetSceneCullingMaskFromCamera(Camera camera) => default; // 0x000000018324CA40-0x000000018324CAA0
		// UInt64 GetSceneCullingMaskFromCamera(Camera)
		uint64_t HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(Camera *camera, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 859 )
		    return 0LL;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x35B )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[18]._0.events )
		    return 0LL;
		  Patch = IFix::WrappersManagerImpl::GetPatch(859, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return (uint64_t)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_739(
		                     (ILFixDynamicMethodWrapper_3 *)Patch,
		                     (Object *)camera,
		                     0LL);
		}
		
		internal static HGAdditionalCameraData TryGetAdditionalCameraDataOrDefault(Camera camera) => default; // 0x0000000183451E40-0x00000001834520A0
		// HGAdditionalCameraData TryGetAdditionalCameraDataOrDefault(Camera)
		HGAdditionalCameraData *HG::Rendering::Runtime::HGUtils::TryGetAdditionalCameraDataOrDefault(
		        Camera *camera,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  struct Object_1__Class *v5; // rcx
		  __int64 v6; // rdx
		  bool (*v7)(Object *, Object *, MethodInfo *); // r9
		  Il2CppMethodPointer methodPtr; // r8
		  struct MethodInfo *v9; // rdi
		  __int64 (__fastcall *v10)(Camera *, __int64, Il2CppMethodPointer); // rax
		  __int64 v11; // rsi
		  void (***rgctx_data)(void); // rcx
		  void (**v13)(void); // rdx
		  const Il2CppRGCTXData *v14; // rcx
		  void *rgctxDataDummy; // rbx
		  struct Type__Class *v16; // rcx
		  System::Type **v17; // rbx
		  System::Type *v18; // rbx
		  void (__fastcall *v19)(__int64, System::Type *, _QWORD, char *); // rax
		  HGRuntimeGrassQuery_Node *v20; // rdx
		  HGRuntimeGrassQuery_Node *v21; // r8
		  Int32__Array **v22; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v25; // rax
		  __int64 v26; // rax
		  __int128 v27; // [rsp+20h] [rbp-18h] BYREF
		  HGAdditionalCameraData *v28; // [rsp+50h] [rbp+18h] BYREF
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_32;
		  if ( wrapperArray->max_length.size > 681 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( !v3 )
		      goto LABEL_32;
		    if ( LODWORD(v3->_0.namespaze) <= 0x2A9 )
		      sub_1800D2AB0(v3, wrapperArray);
		    if ( *(_QWORD *)&v3[14]._1.initializationExceptionGCHandle )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(681, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13(Patch, (Object *)camera, 0LL);
		      goto LABEL_32;
		    }
		  }
		  v5 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v5 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v5 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !camera )
		    goto LABEL_50;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v5);
		  if ( !camera->fields._._._.m_CachedPtr )
		    goto LABEL_50;
		  sub_1800049A0(camera->klass);
		  v7 = (bool (*)(Object *, Object *, MethodInfo *))camera->klass->vtable.Equals.method;
		  methodPtr = camera->klass->vtable.Finalize.methodPtr;
		  if ( v7 == System::Object::Equals || (char *)v7 == (char *)System::RuntimeType::Equals )
		  {
		LABEL_14:
		    v9 = MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>;
		    if ( !MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>->rgctx_data )
		      sub_1800430B0(MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
		    v10 = (__int64 (__fastcall *)(Camera *, __int64, Il2CppMethodPointer))qword_18F36FBC8;
		    if ( !qword_18F36FBC8 )
		    {
		      v10 = (__int64 (__fastcall *)(Camera *, __int64, Il2CppMethodPointer))il2cpp_resolve_icall_1("UnityEngine.Component::get_gameObject()");
		      if ( !v10 )
		      {
		        v25 = sub_1802EE1B8("UnityEngine.Component::get_gameObject()");
		        sub_18007E1B0(v25, 0LL);
		      }
		      qword_18F36FBC8 = (__int64)v10;
		    }
		    v11 = v10(camera, v6, methodPtr);
		    if ( v11 )
		    {
		      rgctx_data = (void (***)(void))v9->rgctx_data;
		      v13 = *rgctx_data;
		      if ( !(*rgctx_data)[4] )
		        (*v13)();
		      v14 = v9->rgctx_data;
		      rgctxDataDummy = v14->rgctxDataDummy;
		      if ( !*((_QWORD *)v14->rgctxDataDummy + 7) )
		        sub_1800430B0(v14->rgctxDataDummy);
		      v16 = TypeInfo::System::Type;
		      v17 = (System::Type **)*((_QWORD *)rgctxDataDummy + 7);
		      v27 = 0LL;
		      v18 = *v17;
		      if ( !TypeInfo::System::Type->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::System::Type);
		        v16 = TypeInfo::System::Type;
		      }
		      if ( v18 )
		      {
		        if ( !v16->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v16);
		        v18 = (System::Type *)System::Type::internal_from_handle(v18, v13);
		      }
		      v19 = (void (__fastcall *)(__int64, System::Type *, _QWORD, char *))qword_18F36FC20;
		      if ( !qword_18F36FC20 )
		      {
		        v19 = (void (__fastcall *)(__int64, System::Type *, _QWORD, char *))il2cpp_resolve_icall_1(
		                                                                              "UnityEngine.GameObject::TryGetComponentFas"
		                                                                              "tPath(System.Type,System.Int32,System.IntPtr)");
		        if ( !v19 )
		        {
		          v26 = sub_1802EE1B8("UnityEngine.GameObject::TryGetComponentFastPath(System.Type,System.Int32,System.IntPtr)");
		          sub_18007E1B0(v26, 0LL);
		        }
		        qword_18F36FC20 = (__int64)v19;
		      }
		      v19(v11, v18, 0LL, (char *)&v27 + 8);
		      v28 = (HGAdditionalCameraData *)v27;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v28, v20, v21, v22, (MethodInfo *)v27);
		      if ( (_QWORD)v27 )
		        return v28;
		      goto LABEL_50;
		    }
		LABEL_32:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  if ( (char *)v7 == (char *)System::RuntimeType::IsInstanceOfType )
		  {
		    LOBYTE(v6) = 1;
		    sub_180028750(camera->fields._._._.m_CachedPtr, v6);
		    goto LABEL_14;
		  }
		  if ( !((unsigned __int8 (__fastcall *)(Camera *, _QWORD, Il2CppMethodPointer))v7)(camera, 0LL, methodPtr) )
		    goto LABEL_14;
		LABEL_50:
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  return HG::Rendering::Runtime::HGUtils::get_s_DefaultHGAdditionalCameraData(0LL);
		}
		
		internal static int GetFormatSizeInBytes(GraphicsFormat format) => default; // 0x0000000189C0DB50-0x0000000189C0DE38
		// Int32 GetFormatSizeInBytes(GraphicsFormat)
		// Hidden C++ exception states: #wind=1
		int32_t HG::Rendering::Runtime::HGUtils::GetFormatSizeInBytes(GraphicsFormat__Enum format, MethodInfo *method)
		{
		  GraphicsFormat__Enum v2; // esi
		  __int64 v3; // rdx
		  HGUtils__StaticFields *static_fields; // rcx
		  String *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  String *v8; // rbx
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  int32_t stringLength; // edi
		  String *v12; // rbx
		  int32_t v13; // edi
		  MatchCollection *v14; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  __int64 v21; // rax
		  Capture *v22; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  String *v25; // rax
		  HGUtils__StaticFields *v26; // rdx
		  Dictionary_2_System_Int32Enum_System_Int32_ *graphicsFormatSizeCache; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  __int64 v32; // [rsp+20h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v33; // [rsp+28h] [rbp-50h] BYREF
		  __int128 v34; // [rsp+30h] [rbp-48h]
		  void *ex; // [rsp+40h] [rbp-38h] BYREF
		  _OWORD v36[3]; // [rsp+48h] [rbp-30h] BYREF
		  int32_t value; // [rsp+90h] [rbp+18h] BYREF
		  IEnumerator *Enumerator; // [rsp+98h] [rbp+20h] BYREF
		
		  v2 = format;
		  value = 0;
		  v32 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3807, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		    if ( !static_fields->graphicsFormatSizeCache )
		      sub_1800D8260(static_fields, v3);
		    if ( System::Collections::Generic::Dictionary<System::Int32Enum,int>::TryGetValue(
		           (Dictionary_2_System_Int32Enum_System_Int32_ *)static_fields->graphicsFormatSizeCache,
		           (Int32Enum__Enum)v2,
		           &value,
		           MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Experimental::Rendering::GraphicsFormat,int>::TryGetValue) )
		    {
		      return value;
		    }
		    ex = TypeInfo::UnityEngine::Experimental::Rendering::GraphicsFormat;
		    *(_QWORD *)&v36[0] = -1LL;
		    DWORD2(v36[0]) = v2;
		    v5 = System::Enum::ToString((Enum *)&ex, 0LL);
		    v8 = v5;
		    if ( !v5 )
		      sub_1800D8260(v7, v6);
		    stringLength = System::String::IndexOf(v5, 0x5Fu, 0LL);
		    if ( stringLength == -1 )
		    {
		      if ( !v8 )
		        sub_1800D8260(v10, v9);
		      stringLength = v8->fields._stringLength;
		    }
		    if ( !v8 )
		      sub_1800D8260(v10, v9);
		    v12 = System::String::Substring(v8, 0, stringLength, 0LL);
		    v13 = 0;
		    value = 0;
		    sub_1800036A0(TypeInfo::System::Text::RegularExpressions::Regex);
		    v14 = System::Text::RegularExpressions::Regex::Matches(v12, (String *)"\\d+", 0LL);
		    if ( !v14 )
		      sub_1800D8260(v16, v15);
		    Enumerator = System::Text::RegularExpressions::MatchCollection::GetEnumerator(v14, 0LL);
		    *(_QWORD *)&v34 = &Enumerator;
		    *((_QWORD *)&v34 + 1) = &v32;
		    ex = 0LL;
		    v36[0] = v34;
		    try
		    {
		      while ( 1 )
		      {
		        if ( !Enumerator )
		          sub_1800D8250(v18, v17);
		        if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
		          break;
		        if ( !Enumerator )
		          sub_1800D8250(v20, v19);
		        v21 = sub_1800428A0(1LL, TypeInfo::System::Collections::IEnumerator, Enumerator);
		        v22 = (Capture *)sub_180005130(v21, TypeInfo::System::Text::RegularExpressions::Match);
		        if ( !v22 )
		          sub_1800D8250(v24, v23);
		        v25 = System::Text::RegularExpressions::Capture::get_Value(v22, 0LL);
		        v13 += System::Int32::Parse(v25, 0LL);
		        value = v13;
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v33 )
		    {
		      ex = v33->ex;
		      sub_180BFE040(v36);
		      if ( ex )
		        sub_18007E1E0(ex);
		      v2 = format;
		      v13 = value;
		      goto LABEL_19;
		    }
		    sub_180BFE040(v36);
		LABEL_19:
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    v26 = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		    graphicsFormatSizeCache = (Dictionary_2_System_Int32Enum_System_Int32_ *)v26->graphicsFormatSizeCache;
		    if ( !graphicsFormatSizeCache )
		      sub_1800D8250(0LL, v26);
		    System::Collections::Generic::Dictionary<System::Int32Enum,int>::set_Item(
		      graphicsFormatSizeCache,
		      (Int32Enum__Enum)v2,
		      v13 / 8,
		      MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Experimental::Rendering::GraphicsFormat,int>::set_Item);
		    return v13 / 8;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3807, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v31, v30);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_64((ILFixDynamicMethodWrapper_18 *)Patch, v2, 0LL);
		}
		
		internal static void DisplayMessageNotification(string msg) {} // 0x0000000189C0C378-0x0000000189C0C3C8
		// Void DisplayMessageNotification(String)
		void HG::Rendering::Runtime::HGUtils::DisplayMessageNotification(String *msg, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3808, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3808, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)msg, 0LL);
		  }
		  else
		  {
		    HG::Rendering::HGRPLogger::LogError(msg, 0LL);
		  }
		}
		
		internal static string GetUnsupportedAPIMessage(string graphicAPI) => default; // 0x0000000189C0E65C-0x0000000189C0E960
		// String GetUnsupportedAPIMessage(String)
		String *HG::Rendering::Runtime::HGUtils::GetUnsupportedAPIMessage(String *graphicAPI, MethodInfo *method)
		{
		  String *OperatingSystem; // rbp
		  char *v4; // rbx
		  unsigned __int32 v5; // eax
		  unsigned __int32 v6; // eax
		  __int64 v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  String__Array *v10; // rdi
		  String *v11; // rdi
		  String *v12; // rax
		  String *v13; // rax
		  char *v14; // rdx
		  String *result; // rax
		  __int64 v16; // rax
		  ArgumentNullException *v17; // rbx
		  String *v18; // rax
		  __int64 v19; // rax
		  __int64 v20; // rax
		  ArgumentNullException *v21; // rbx
		  String *v22; // rax
		  __int64 v23; // rax
		  __int64 v24; // rax
		  ArgumentNullException *v25; // rbx
		  String *v26; // rax
		  __int64 v27; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3809, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3809, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		               (ILFixDynamicMethodWrapper_26 *)Patch,
		               (Object *)graphicAPI,
		               0LL);
		    goto LABEL_30;
		  }
		  OperatingSystem = UnityEngine::SystemInfo::GetOperatingSystem(0LL);
		  v4 = 0LL;
		  v5 = UnityEngine::SystemInfo::GetOperatingSystemFamily(0LL) - 1;
		  if ( v5 )
		  {
		    v6 = v5 - 1;
		    if ( v6 )
		    {
		      if ( v6 == 1 )
		        v4 = "Linux";
		    }
		    else
		    {
		      v4 = "Windows";
		    }
		  }
		  else
		  {
		    v4 = "Mac";
		  }
		  v7 = il2cpp_array_new_specific_1(TypeInfo::System::String, 5LL);
		  v10 = (String__Array *)v7;
		  if ( !v7 )
		    goto LABEL_30;
		  sub_180005370(v7, 0LL, "Platform ");
		  sub_180005370(v10, 1LL, OperatingSystem);
		  sub_180005370(v10, 2LL, " with graphics API ");
		  sub_180005370(v10, 3LL, graphicAPI);
		  sub_180005370(v10, 4LL, " is not supported with HGRP");
		  v11 = System::String::Concat(v10, 0LL);
		  if ( !graphicAPI )
		    goto LABEL_30;
		  if ( !"OpenGL" )
		  {
		    v24 = sub_18007E180(&TypeInfo::System::ArgumentNullException);
		    v25 = (ArgumentNullException *)sub_1800368D0(v24);
		    if ( v25 )
		    {
		      v26 = (String *)sub_18007E180(&off_18E363330);
		      System::ArgumentNullException::ArgumentNullException(v25, v26, 0LL);
		      v27 = sub_18007E180(&MethodInfo::System::String::StartsWith);
		      sub_18007E190(v25, v27);
		    }
		    goto LABEL_30;
		  }
		  if ( !System::String::StartsWith(graphicAPI, (String *)"OpenGL", StringComparison__Enum_CurrentCulture, 0LL) )
		    goto LABEL_20;
		  v12 = UnityEngine::SystemInfo::GetOperatingSystem(0LL);
		  if ( !v12 )
		    goto LABEL_30;
		  if ( !"Mac" )
		  {
		    v20 = sub_18007E180(&TypeInfo::System::ArgumentNullException);
		    v21 = (ArgumentNullException *)sub_1800368D0(v20);
		    if ( v21 )
		    {
		      v22 = (String *)sub_18007E180(&off_18E363330);
		      System::ArgumentNullException::ArgumentNullException(v21, v22, 0LL);
		      v23 = sub_18007E180(&MethodInfo::System::String::StartsWith);
		      sub_18007E190(v21, v23);
		    }
		    goto LABEL_30;
		  }
		  if ( System::String::StartsWith(v12, (String *)"Mac", StringComparison__Enum_CurrentCulture, 0LL) )
		  {
		    v14 = ", use the Metal graphics API instead";
		    goto LABEL_19;
		  }
		  v13 = UnityEngine::SystemInfo::GetOperatingSystem(0LL);
		  if ( !v13 )
		LABEL_30:
		    sub_1800D8260(v9, v8);
		  if ( !"Windows" )
		  {
		    v16 = sub_18007E180(&TypeInfo::System::ArgumentNullException);
		    v17 = (ArgumentNullException *)sub_1800368D0(v16);
		    if ( v17 )
		    {
		      v18 = (String *)sub_18007E180(&off_18E363330);
		      System::ArgumentNullException::ArgumentNullException(v17, v18, 0LL);
		      v19 = sub_18007E180(&MethodInfo::System::String::StartsWith);
		      sub_18007E190(v17, v19);
		    }
		    goto LABEL_30;
		  }
		  if ( !System::String::StartsWith(v13, (String *)"Windows", StringComparison__Enum_CurrentCulture, 0LL) )
		    goto LABEL_20;
		  v14 = ", use the Vulkan graphics API instead";
		LABEL_19:
		  v11 = System::String::Concat(v11, (String *)v14, 0LL);
		LABEL_20:
		  result = System::String::Concat(
		             v11,
		             (String *)".\nChange the platform/device to a compatible one or remove incompatible graphics APIs.\n",
		             0LL);
		  if ( v4 )
		    return System::String::Concat(
		             result,
		             (String *)"To do this, go to Project Settings > Player > Other Settings and modify the Graphics APIs for ",
		             (String *)v4,
		             (String *)" list.",
		             0LL);
		  return result;
		}
		
		internal static int GetTextureHash(Texture texture) => default; // 0x0000000189C0E5FC-0x0000000189C0E65C
		// Int32 GetTextureHash(Texture)
		int32_t HG::Rendering::Runtime::HGUtils::GetTextureHash(Texture *texture, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3810, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3810, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)texture, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    return UnityEngine::Rendering::CoreUtils::GetTextureHash(texture, 0LL);
		  }
		}
		
		internal static void ReleaseComponentSingletons() {} // 0x0000000183949BA0-0x0000000183949BD0
		// Void ReleaseComponentSingletons()
		void HG::Rendering::Runtime::HGUtils::ReleaseComponentSingletons(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(560, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(560, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v3, v2);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    UnityEngine::Rendering::ComponentSingleton<System::Object>::Release(MethodInfo::UnityEngine::Rendering::ComponentSingleton<HG::Rendering::Runtime::HGAdditionalCameraData>::Release);
		  }
		}
		
		internal static float CopySign(float x, float s, bool ignoreNegZero = true /* Metadata: 0x02303EDD */) => default; // 0x0000000189C0C2F0-0x0000000189C0C378
		// Single CopySign(Single, Single, Boolean)
		// local variable allocation has failed, the output may be wrong!
		float HG::Rendering::Runtime::HGUtils::CopySign(float x, float s, bool ignoreNegZero, MethodInfo *method)
		{
		  float result; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1916, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1916, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_769(Patch, x, s, ignoreNegZero, 0LL);
		  }
		  else
		  {
		    LODWORD(result) = _mm_cvtsi128_si32(*(__m128i *)&x) & 0x7FFFFFFF;
		    if ( s < 0.0 )
		      return -result;
		  }
		  return result;
		}
		
		internal static float2 PackNormalOctRectEncode(float3 n) => default; // 0x0000000189C0EF4C-0x0000000189C0F0A4
		// float2 PackNormalOctRectEncode(float3)
		float2 HG::Rendering::Runtime::HGUtils::PackNormalOctRectEncode(float3 *n, MethodInfo *method)
		{
		  MethodInfo *v3; // r8
		  float v4; // eax
		  float3 *v5; // rax
		  __int64 v6; // xmm0_8
		  __int64 v7; // xmm1_8
		  MethodInfo *v8; // r8
		  MethodInfo *v9; // r9
		  float3 *v10; // rax
		  float v11; // ebx
		  __m128 v12; // xmm0
		  __m128 y_low; // xmm6
		  __int64 v14; // rcx
		  __int64 v16; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 vector; // [rsp+20h] [rbp-50h] BYREF
		  Vector3 value; // [rsp+30h] [rbp-40h] BYREF
		  float3 v21; // [rsp+40h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1915, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1915, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v16);
		    z = n->z;
		    *(_QWORD *)&v21.x = *(_QWORD *)&n->x;
		    v21.z = z;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_770(Patch, &v21, 0LL);
		  }
		  else
		  {
		    v4 = n->z;
		    *(_QWORD *)&vector.x = *(_QWORD *)&n->x;
		    *(_QWORD *)&value.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		    value.z = 1.0;
		    vector.z = v4;
		    v5 = Unity::Mathematics::math::abs(&v21, (float3 *)&vector, v3);
		    v6 = *(_QWORD *)&n->x;
		    v7 = *(_QWORD *)&v5->x;
		    vector.z = v5->z;
		    v21.z = n->z;
		    *(_QWORD *)&vector.x = v7;
		    *(_QWORD *)&v21.x = v6;
		    *(float *)&v6 = Dest::Math::Vector3ex::Dot(&vector, &value, v8);
		    v10 = Unity::Mathematics::float3::op_Multiply((float3 *)&value, &v21, 1.0 / *(float *)&v6, v9);
		    v11 = v10->z;
		    *(_QWORD *)&vector.x = *(_QWORD *)&v10->x;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    v12 = (__m128)0x3F000000u;
		    y_low = (__m128)LODWORD(vector.y);
		    v12.m128_f32[0] = sub_182EE75E0(v14);
		    v12.m128_f32[0] = HG::Rendering::Runtime::HGUtils::CopySign(v12.m128_f32[0], v11, 1, 0LL);
		    y_low.m128_f32[0] = y_low.m128_f32[0] + vector.x;
		    return (float2)_mm_unpacklo_ps(v12, y_low).m128_u64[0];
		  }
		}
		
		internal static float PackTwoHalfValuesAsFloat(float x, float y) => default; // 0x0000000189C0F0A4-0x0000000189C0F120
		// Single PackTwoHalfValuesAsFloat(Single, Single)
		float HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(float x, float y, MethodInfo *method)
		{
		  MethodInfo *v3; // rdx
		  MethodInfo *v4; // rdx
		  uint32_t v5; // eax
		  int v6; // r10d
		  float result; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1918, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1918, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(Patch, x, y, 0LL);
		  }
		  else
		  {
		    Unity::Mathematics::math::f32tof16(y, v3);
		    v5 = Unity::Mathematics::math::f32tof16(x, v4);
		    LODWORD(result) = v5 | v6;
		  }
		  return result;
		}
		
		public static GraphicsFormat GetDeviceSupportedRWTextureFormat(bool useAlpha) => default; // 0x0000000189C0D1E4-0x0000000189C0D490
		// GraphicsFormat GetDeviceSupportedRWTextureFormat(Boolean)
		GraphicsFormat__Enum HG::Rendering::Runtime::HGUtils::GetDeviceSupportedRWTextureFormat(
		        bool useAlpha,
		        MethodInfo *method)
		{
		  struct HGUtils__Class *v3; // rcx
		  HGUtils__StaticFields *static_fields; // rax
		  unsigned int i; // ebx
		  _DWORD *m_RWTextureWithAlphaColorFormatList; // rcx
		  GraphicsFormat__Enum__Array *m_RWTextureWithoutAlphaColorFormatList; // rdx
		  bool IsFormatSupported; // al
		  unsigned int j; // ebx
		  bool v11; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2871, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2871, 0LL);
		    if ( !Patch )
		      goto LABEL_33;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1051(Patch, useAlpha, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    v3 = TypeInfo::HG::Rendering::Runtime::HGUtils;
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		    if ( !useAlpha )
		    {
		      if ( static_fields->m_RWTextureWithoutAlphaFormat )
		      {
		LABEL_16:
		        sub_1800036A0(v3);
		        return TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_RWTextureWithoutAlphaFormat;
		      }
		      for ( i = 0; ; ++i )
		      {
		        sub_1800036A0(v3);
		        m_RWTextureWithAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils;
		        m_RWTextureWithoutAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_RWTextureWithoutAlphaColorFormatList;
		        if ( !m_RWTextureWithoutAlphaColorFormatList )
		          goto LABEL_33;
		        if ( (signed int)i >= m_RWTextureWithoutAlphaColorFormatList->max_length.size )
		          goto LABEL_14;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        m_RWTextureWithAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_RWTextureWithoutAlphaColorFormatList;
		        if ( !m_RWTextureWithAlphaColorFormatList )
		          goto LABEL_33;
		        if ( i >= m_RWTextureWithAlphaColorFormatList[6] )
		          goto LABEL_31;
		        IsFormatSupported = UnityEngine::SystemInfo::IsFormatSupported(
		                              (GraphicsFormat__Enum)m_RWTextureWithAlphaColorFormatList[i + 8],
		                              FormatUsage__Enum_LoadStore,
		                              0LL);
		        v3 = TypeInfo::HG::Rendering::Runtime::HGUtils;
		        if ( IsFormatSupported )
		          break;
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      m_RWTextureWithAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils;
		      m_RWTextureWithoutAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_RWTextureWithoutAlphaColorFormatList;
		      if ( m_RWTextureWithoutAlphaColorFormatList )
		      {
		        if ( i < m_RWTextureWithoutAlphaColorFormatList->max_length.size )
		        {
		          TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_RWTextureWithoutAlphaFormat = m_RWTextureWithoutAlphaColorFormatList->vector[i];
		          m_RWTextureWithAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils;
		LABEL_14:
		          sub_1800036A0(m_RWTextureWithAlphaColorFormatList);
		          v3 = TypeInfo::HG::Rendering::Runtime::HGUtils;
		          if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_RWTextureWithoutAlphaFormat )
		          {
		            HG::Rendering::HGRPLogger::LogWarning(
		              (String *)"No supported texture format could enable random write in HGUtils defined format list",
		              0LL);
		            v3 = TypeInfo::HG::Rendering::Runtime::HGUtils;
		          }
		          goto LABEL_16;
		        }
		LABEL_31:
		        sub_1800D2AB0(m_RWTextureWithAlphaColorFormatList, m_RWTextureWithoutAlphaColorFormatList);
		      }
		LABEL_33:
		      sub_1800D8260(m_RWTextureWithAlphaColorFormatList, m_RWTextureWithoutAlphaColorFormatList);
		    }
		    if ( !static_fields->m_RWTextureWithAlphaFormat )
		    {
		      for ( j = 0; ; ++j )
		      {
		        sub_1800036A0(v3);
		        m_RWTextureWithAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils;
		        m_RWTextureWithoutAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_RWTextureWithAlphaColorFormatList;
		        if ( !m_RWTextureWithoutAlphaColorFormatList )
		          goto LABEL_33;
		        if ( (signed int)j >= m_RWTextureWithoutAlphaColorFormatList->max_length.size )
		          goto LABEL_28;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        m_RWTextureWithAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_RWTextureWithAlphaColorFormatList;
		        if ( !m_RWTextureWithAlphaColorFormatList )
		          goto LABEL_33;
		        if ( j >= m_RWTextureWithAlphaColorFormatList[6] )
		          goto LABEL_31;
		        v11 = UnityEngine::SystemInfo::IsFormatSupported(
		                (GraphicsFormat__Enum)m_RWTextureWithAlphaColorFormatList[j + 8],
		                FormatUsage__Enum_LoadStore,
		                0LL);
		        v3 = TypeInfo::HG::Rendering::Runtime::HGUtils;
		        if ( v11 )
		          break;
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      m_RWTextureWithAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils;
		      m_RWTextureWithoutAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_RWTextureWithAlphaColorFormatList;
		      if ( !m_RWTextureWithoutAlphaColorFormatList )
		        goto LABEL_33;
		      if ( j >= m_RWTextureWithoutAlphaColorFormatList->max_length.size )
		        goto LABEL_31;
		      TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_RWTextureWithAlphaFormat = m_RWTextureWithoutAlphaColorFormatList->vector[j];
		      m_RWTextureWithAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils;
		LABEL_28:
		      sub_1800036A0(m_RWTextureWithAlphaColorFormatList);
		      v3 = TypeInfo::HG::Rendering::Runtime::HGUtils;
		      if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_RWTextureWithAlphaFormat )
		      {
		        HG::Rendering::HGRPLogger::LogWarning(
		          (String *)"No supported texture format could enable random write in HGUtils defined format list",
		          0LL);
		        v3 = TypeInfo::HG::Rendering::Runtime::HGUtils;
		      }
		    }
		    sub_1800036A0(v3);
		    return TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->m_RWTextureWithAlphaFormat;
		  }
		}
		
		public static bool IsSkyboxRenderingEnabled(HGCamera hgCamera) => default; // 0x000000018344F580-0x000000018344F6C0
		// Boolean IsSkyboxRenderingEnabled(HGCamera)
		bool HG::Rendering::Runtime::HGUtils::IsSkyboxRenderingEnabled(HGCamera *hgCamera, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rdx
		  int *wrapperArray; // rcx
		  HGAdditionalCameraData *m_AdditionalCameraData; // rdi
		  HGAdditionalCameraData *v7; // rax
		  int32_t clearColorMode; // eax
		  int *v10; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2__StaticFields *v12; // rax
		  ILFixDynamicMethodWrapper_2 *v13; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = v2->static_fields;
		  wrapperArray = (int *)static_fields->wrapperArray;
		  if ( !static_fields->wrapperArray )
		    goto LABEL_18;
		  if ( wrapperArray[6] > 1077 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = v2->static_fields;
		    v10 = (int *)static_fields->wrapperArray;
		    if ( !static_fields->wrapperArray )
		      goto LABEL_18;
		    if ( (unsigned int)v10[6] <= 0x435 )
		      goto LABEL_35;
		    if ( *((_QWORD *)v10 + 1081) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1077, 0LL);
		      if ( !Patch )
		        goto LABEL_18;
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		               (ILFixDynamicMethodWrapper_20 *)Patch,
		               (Object *)hgCamera,
		               0LL);
		    }
		  }
		  if ( !hgCamera )
		    goto LABEL_18;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)v2->static_fields;
		  static_fields = *(ILFixDynamicMethodWrapper_2__StaticFields **)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_18;
		  if ( SLODWORD(static_fields[3].wrapperArray) > 741 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = (int *)v2->static_fields;
		    v12 = *(ILFixDynamicMethodWrapper_2__StaticFields **)wrapperArray;
		    if ( !*(_QWORD *)wrapperArray )
		      goto LABEL_18;
		    if ( LODWORD(v12[3].wrapperArray) > 0x2E5 )
		    {
		      if ( v12[745].wrapperArray )
		      {
		        v13 = IFix::WrappersManagerImpl::GetPatch(741, 0LL);
		        if ( v13 )
		        {
		          clearColorMode = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
		                             (ILFixDynamicMethodWrapper_26 *)v13,
		                             (Object *)hgCamera,
		                             0LL);
		          return clearColorMode == 0;
		        }
		LABEL_18:
		        sub_1800D8260(wrapperArray, static_fields);
		      }
		      goto LABEL_10;
		    }
		LABEL_35:
		    sub_1800D2AB0(wrapperArray, static_fields);
		  }
		LABEL_10:
		  wrapperArray = (int *)TypeInfo::UnityEngine::Object;
		  m_AdditionalCameraData = hgCamera->fields.m_AdditionalCameraData;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    wrapperArray = (int *)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      wrapperArray = (int *)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( m_AdditionalCameraData )
		  {
		    if ( !wrapperArray[56] )
		      il2cpp_runtime_class_init_1(wrapperArray);
		    if ( m_AdditionalCameraData->fields._._._._.m_CachedPtr )
		    {
		      v7 = hgCamera->fields.m_AdditionalCameraData;
		      if ( v7 )
		      {
		        clearColorMode = v7->fields.clearColorMode;
		        return clearColorMode == 0;
		      }
		      goto LABEL_18;
		    }
		  }
		  wrapperArray = (int *)hgCamera->fields.camera;
		  if ( !wrapperArray )
		    goto LABEL_18;
		  if ( UnityEngine::Camera::get_clearFlags((Camera *)wrapperArray, 0LL) == CameraClearFlags__Enum_Skybox )
		    return 1;
		  wrapperArray = (int *)hgCamera->fields.camera;
		  if ( !wrapperArray )
		    goto LABEL_18;
		  UnityEngine::Camera::get_clearFlags((Camera *)wrapperArray, 0LL);
		  return 0;
		}
		
		public static bool IsInIsolatedDisplayMode(Camera camera) => default; // 0x00000001832DC700-0x00000001832DC760
		// Boolean IsInIsolatedDisplayMode(Camera)
		bool HG::Rendering::Runtime::HGUtils::IsInIsolatedDisplayMode(Camera *camera, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 804 )
		    return 0;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x324 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[17]._0.castClass )
		    return 0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(804, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)camera, 0LL);
		}
		
		public static void ReleaseTemporaryRenderTexture(ref RenderTexture renderTexture) {} // 0x00000001837DD300-0x00000001837DD350
		// Void ReleaseTemporaryRenderTexture(RenderTexture ByRef)
		void HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(RenderTexture **renderTexture, MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(542, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(542, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_229(Patch, renderTexture, 0LL);
		  }
		  else
		  {
		    UnityEngine::RenderTexture::ReleaseTemporary(*renderTexture, 0LL);
		    *renderTexture = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)renderTexture, v3, v4, v5, v9);
		  }
		}
		
		public static void Destroy(UnityEngine.Object obj) {} // 0x00000001844FFD50-0x00000001844FFDA0
		// Void Destroy(Object)
		void HG::Rendering::Runtime::HGUtils::Destroy(Object_1 *obj, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2529, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2529, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)obj, 0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    UnityEngine::Object::Destroy(obj, 0LL);
		  }
		}
		
		internal static HGRenderPathInternal GetInternalRenderPath(HGRenderPath renderPath) => default; // 0x0000000183101FF0-0x00000001831020A0
		// HGRenderPathInternal GetInternalRenderPath(HGRenderPath)
		HGRenderPathInternal__Enum HG::Rendering::Runtime::HGUtils::GetInternalRenderPath(
		        HGRenderPath__Enum renderPath,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  __int64 (*v5)(void); // rax
		  unsigned int v6; // edi
		  unsigned __int8 (__fastcall *v7)(_QWORD, __int64); // rax
		  HGRenderPathInternal__Enum result; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rax
		  __int64 v11; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_11;
		  if ( wrapperArray->max_length.size > 704 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x2C0 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[15]._0.namespaze )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(704, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_64((ILFixDynamicMethodWrapper_18 *)Patch, renderPath, 0LL);
		    }
		LABEL_11:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( !TypeInfo::UnityEngine::Graphics->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Graphics);
		  v5 = (__int64 (*)(void))qword_18F36F380;
		  if ( !qword_18F36F380 )
		  {
		    v5 = (__int64 (*)(void))il2cpp_resolve_icall_1("UnityEngine.Graphics::get_activeTier()");
		    if ( !v5 )
		    {
		      v10 = sub_1802EE1B8("UnityEngine.Graphics::get_activeTier()");
		      sub_18007E1B0(v10, 0LL);
		    }
		    qword_18F36F380 = (__int64)v5;
		  }
		  v6 = v5();
		  v7 = (unsigned __int8 (__fastcall *)(_QWORD, __int64))qword_18F370308;
		  if ( !qword_18F370308 )
		  {
		    v7 = (unsigned __int8 (__fastcall *)(_QWORD, __int64))il2cpp_resolve_icall_1(
		                                                            "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(Unit"
		                                                            "yEngine.Rendering.GraphicsTier,UnityEngine.Rendering.BuiltinShaderDefine)");
		    if ( !v7 )
		    {
		      v11 = sub_1802EE1B8(
		              "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(UnityEngine.Rendering.GraphicsTier,UnityEngine.Ren"
		              "dering.BuiltinShaderDefine)");
		      sub_18007E1B0(v11, 0LL);
		    }
		    qword_18F370308 = (__int64)v7;
		  }
		  if ( !v7(v6, 37LL) )
		    return renderPath;
		  result = HGRenderPathInternal__Enum_OnePassDeferredSubpass;
		  if ( renderPath != HGRenderPath__Enum_Deferred )
		    return renderPath;
		  return result;
		}
		
		[IDTag(1)]
		internal static float GetRenderingScale(HGCamera hgCamera, HGSettingParameters settingParameters) => default; // 0x000000018324ED10-0x000000018324F080
		// Single GetRenderingScale(HGCamera, HGSettingParameters)
		float HG::Rendering::Runtime::HGUtils::GetRenderingScale(
		        HGCamera *hgCamera,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  Object *v4; // rsi
		  void *v5; // rcx
		  __int64 v6; // r8
		  HGAdditionalCameraData *m_AdditionalCameraData; // rax
		  int32_t hgRenderPath; // eax
		  SettingParameter_1_System_Single_ *cullingViewScreenSizeMin_k__BackingField; // rbx
		  void (__fastcall *v10)(SettingParameter_1_System_Single_ *, int *, int *); // rax
		  SettingParameter_1_System_Single_ *v11; // rbx
		  void (__fastcall *v12)(SettingParameter_1_System_Single_ *, _DWORD *, int *); // rax
		  unsigned int (*v13)(void); // rax
		  int v14; // ebp
		  unsigned int (*v15)(void); // rax
		  MonitorData *monitor; // rbx
		  struct MethodInfo *v17; // rdi
		  Il2CppClass *klass; // rax
		  Il2CppClass *v19; // rcx
		  float v20; // xmm1_4
		  ILFixDynamicMethodWrapper_2 *v22; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v24; // rax
		  __int64 v25; // rax
		  __int64 v26; // rax
		  __int64 v27; // rax
		  __int64 v28; // rax
		  __int64 v29; // rax
		  int v30; // [rsp+20h] [rbp-18h] BYREF
		  int v31; // [rsp+24h] [rbp-14h] BYREF
		  _DWORD v32[4]; // [rsp+28h] [rbp-10h] BYREF
		  int v33; // [rsp+58h] [rbp+20h] BYREF
		
		  v4 = (Object *)settingParameters;
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **((_QWORD **)v5 + 23);
		  if ( !v6 )
		    goto LABEL_44;
		  if ( *(int *)(v6 + 24) <= 755 )
		    goto LABEL_92;
		  if ( !*((_DWORD *)v5 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  settingParameters = (HGSettingParameters *)**((_QWORD **)v5 + 23);
		  if ( !settingParameters )
		    goto LABEL_44;
		  if ( LODWORD(settingParameters->fields._ocScreenSizeMin_k__BackingField) <= 0x2F3 )
		    goto LABEL_75;
		  if ( !settingParameters[3].fields._csmEnableOcclusionCulling2_k__BackingField )
		  {
		LABEL_92:
		    if ( !hgCamera )
		      goto LABEL_44;
		    if ( !*((_DWORD *)v5 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    settingParameters = (HGSettingParameters *)**((_QWORD **)v5 + 23);
		    if ( !settingParameters )
		      goto LABEL_44;
		    if ( SLODWORD(settingParameters->fields._ocScreenSizeMin_k__BackingField) <= 703 )
		      goto LABEL_10;
		    if ( !*((_DWORD *)v5 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    settingParameters = (HGSettingParameters *)**((_QWORD **)v5 + 23);
		    if ( !settingParameters )
		      goto LABEL_44;
		    if ( LODWORD(settingParameters->fields._ocScreenSizeMin_k__BackingField) <= 0x2BF )
		      goto LABEL_75;
		    if ( settingParameters[3].fields._fsr3UseLanczosLut_k__BackingField )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(703, 0LL);
		      if ( !Patch )
		        goto LABEL_44;
		      hgRenderPath = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                       (ILFixDynamicMethodWrapper_31 *)Patch,
		                       (Object *)hgCamera,
		                       0LL);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_10:
		      m_AdditionalCameraData = hgCamera->fields.m_AdditionalCameraData;
		      if ( !m_AdditionalCameraData )
		        goto LABEL_44;
		      hgRenderPath = m_AdditionalCameraData->fields.hgRenderPath;
		    }
		    if ( hgRenderPath != 3 )
		    {
		      if ( HG::Rendering::Runtime::HGCamera::get_renderPath(hgCamera, 0LL) )
		        return 1.0;
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !*((_DWORD *)v5 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    settingParameters = (HGSettingParameters *)**((_QWORD **)v5 + 23);
		    if ( !settingParameters )
		      goto LABEL_44;
		    if ( SLODWORD(settingParameters->fields._ocScreenSizeMin_k__BackingField) <= 756 )
		      goto LABEL_19;
		    if ( !*((_DWORD *)v5 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (void *)**((_QWORD **)v5 + 23);
		    if ( !v5 )
		      goto LABEL_44;
		    if ( *((_DWORD *)v5 + 6) > 0x2F4u )
		    {
		      if ( *((_QWORD *)v5 + 760) )
		      {
		        v24 = IFix::WrappersManagerImpl::GetPatch(756, 0LL);
		        if ( v24 )
		          return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)v24, v4, 0LL);
		LABEL_44:
		        sub_1800D8260(v5, settingParameters);
		      }
		LABEL_19:
		      v5 = TypeInfo::UnityEngine::Display;
		      if ( !TypeInfo::UnityEngine::Display->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Display);
		        v5 = TypeInfo::UnityEngine::Display;
		        if ( !TypeInfo::UnityEngine::Display->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Display);
		          v5 = TypeInfo::UnityEngine::Display;
		        }
		      }
		      settingParameters = *(HGSettingParameters **)(*((_QWORD *)v5 + 23) + 8LL);
		      if ( settingParameters )
		      {
		        cullingViewScreenSizeMin_k__BackingField = settingParameters->fields._cullingViewScreenSizeMin_k__BackingField;
		        v30 = 0;
		        v31 = 0;
		        if ( !*((_DWORD *)v5 + 56) )
		          il2cpp_runtime_class_init_1(v5);
		        v10 = (void (__fastcall *)(SettingParameter_1_System_Single_ *, int *, int *))qword_18F36F318;
		        if ( !qword_18F36F318 )
		        {
		          v10 = (void (__fastcall *)(SettingParameter_1_System_Single_ *, int *, int *))il2cpp_resolve_icall_1(
		                                                                                          "UnityEngine.Display::GetSystem"
		                                                                                          "ExtImpl(System.IntPtr,System.I"
		                                                                                          "nt32&,System.Int32&)");
		          if ( !v10 )
		          {
		            v25 = sub_1802EE1B8("UnityEngine.Display::GetSystemExtImpl(System.IntPtr,System.Int32&,System.Int32&)");
		            sub_18007E1B0(v25, 0LL);
		          }
		          qword_18F36F318 = (__int64)v10;
		        }
		        v10(cullingViewScreenSizeMin_k__BackingField, &v30, &v31);
		        v5 = TypeInfo::UnityEngine::Display;
		        if ( !TypeInfo::UnityEngine::Display->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Display);
		          v5 = TypeInfo::UnityEngine::Display;
		        }
		        settingParameters = *(HGSettingParameters **)(*((_QWORD *)v5 + 23) + 8LL);
		        if ( settingParameters )
		        {
		          v11 = settingParameters->fields._cullingViewScreenSizeMin_k__BackingField;
		          v32[0] = 0;
		          v33 = 0;
		          if ( !*((_DWORD *)v5 + 56) )
		            il2cpp_runtime_class_init_1(v5);
		          v12 = (void (__fastcall *)(SettingParameter_1_System_Single_ *, _DWORD *, int *))qword_18F36F318;
		          if ( !qword_18F36F318 )
		          {
		            v12 = (void (__fastcall *)(SettingParameter_1_System_Single_ *, _DWORD *, int *))il2cpp_resolve_icall_1(
		                                                                                               "UnityEngine.Display::GetS"
		                                                                                               "ystemExtImpl(System.IntPt"
		                                                                                               "r,System.Int32&,System.Int32&)");
		            if ( !v12 )
		            {
		              v26 = sub_1802EE1B8("UnityEngine.Display::GetSystemExtImpl(System.IntPtr,System.Int32&,System.Int32&)");
		              sub_18007E1B0(v26, 0LL);
		            }
		            qword_18F36F318 = (__int64)v12;
		          }
		          v12(v11, v32, &v33);
		          v13 = (unsigned int (*)(void))qword_18F36F340;
		          v14 = v33;
		          if ( !qword_18F36F340 )
		          {
		            v13 = (unsigned int (*)(void))il2cpp_resolve_icall_1("UnityEngine.Screen::GetScreenOrientation()");
		            if ( !v13 )
		            {
		              v27 = sub_1802EE1B8("UnityEngine.Screen::GetScreenOrientation()");
		              sub_18007E1B0(v27, 0LL);
		            }
		            qword_18F36F340 = (__int64)v13;
		          }
		          if ( v13() == 3 )
		            goto LABEL_84;
		          v15 = (unsigned int (*)(void))qword_18F36F340;
		          if ( !qword_18F36F340 )
		          {
		            v15 = (unsigned int (*)(void))il2cpp_resolve_icall_1("UnityEngine.Screen::GetScreenOrientation()");
		            if ( !v15 )
		            {
		              v28 = sub_1802EE1B8("UnityEngine.Screen::GetScreenOrientation()");
		              sub_18007E1B0(v28, 0LL);
		            }
		            qword_18F36F340 = (__int64)v15;
		          }
		          if ( v15() == 4 )
		          {
		LABEL_84:
		            if ( v14 > v30 )
		              v14 = v30;
		          }
		          if ( v4 )
		          {
		            monitor = v4[67].monitor;
		            v17 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		            if ( monitor )
		            {
		              klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		              if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		                sub_1800360B0(
		                  MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass,
		                  settingParameters);
		              if ( !*((_QWORD *)klass->rgctx_data[6].rgctxDataDummy + 4) )
		              {
		                v29 = sub_18011C4C0(v17->klass);
		                (**(void (***)(void))(*(_QWORD *)(v29 + 192) + 48LL))();
		              }
		              v19 = v17->klass;
		              if ( ((__int64)v19->vtable[0].methodPtr & 1) == 0 )
		                sub_1800360B0(v19, settingParameters);
		              v20 = *((float *)monitor + 10);
		              if ( v14 <= 1080 )
		              {
		                if ( v14 < 432 )
		                  return 1.0;
		                else
		                  return (float)((sub_182F3EA70(v19, settingParameters) + 432) & 0xFFFFFFFE) / (float)v14;
		              }
		              return v20;
		            }
		          }
		        }
		      }
		      goto LABEL_44;
		    }
		LABEL_75:
		    sub_1800D2AB0(v5, settingParameters);
		  }
		  v22 = IFix::WrappersManagerImpl::GetPatch(755, 0LL);
		  if ( !v22 )
		    goto LABEL_44;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_297(v22, (Object *)hgCamera, v4, 0LL);
		}
		
		[IDTag(0)]
		internal static float GetRenderingScale(HGSettingParameters settingParameters) => default; // 0x000000018324F080-0x000000018324F2F0
		// Single GetRenderingScale(HGSettingParameters)
		float HG::Rendering::Runtime::HGUtils::GetRenderingScale(HGSettingParameters *settingParameters, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  __int64 v5; // rdi
		  void (__fastcall *v6)(__int64, int *, int *); // rax
		  __int64 v7; // rdi
		  void (__fastcall *v8)(__int64, _DWORD *, int *); // rax
		  __int64 v9; // rcx
		  unsigned int (__fastcall *v10)(__int64); // rax
		  int v11; // esi
		  unsigned int (__fastcall *v12)(_QWORD **); // rax
		  SettingParameter_1_System_Single_ *renderingScale_k__BackingField; // rbx
		  struct MethodInfo *v14; // rdi
		  Il2CppClass *klass; // rax
		  Il2CppClass *v16; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v19; // rax
		  __int64 v20; // rax
		  __int64 v21; // rax
		  __int64 v22; // rax
		  __int64 v23; // rax
		  int v24; // [rsp+20h] [rbp-18h] BYREF
		  _DWORD v25[5]; // [rsp+24h] [rbp-14h] BYREF
		  int v26; // [rsp+50h] [rbp+18h] BYREF
		  int v27; // [rsp+58h] [rbp+20h] BYREF
		
		  v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = *v3[23];
		  if ( !v4 )
		    goto LABEL_30;
		  if ( *(int *)(v4 + 24) <= 756 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (_QWORD **)*v3[23];
		  if ( !v3 )
		LABEL_30:
		    sub_1800D8260(v3, v4);
		  if ( *((_DWORD *)v3 + 6) <= 0x2F4u )
		    sub_1800D2AB0(v3, v4);
		  if ( v3[760] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(756, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		               (ILFixDynamicMethodWrapper_15 *)Patch,
		               (Object *)settingParameters,
		               0LL);
		    goto LABEL_30;
		  }
		LABEL_5:
		  v3 = (_QWORD **)TypeInfo::UnityEngine::Display;
		  if ( !TypeInfo::UnityEngine::Display->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Display);
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Display;
		    if ( !TypeInfo::UnityEngine::Display->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Display);
		      v3 = (_QWORD **)TypeInfo::UnityEngine::Display;
		    }
		  }
		  v4 = v3[23][1];
		  if ( !v4 )
		    goto LABEL_30;
		  v5 = *(_QWORD *)(v4 + 16);
		  v27 = 0;
		  v24 = 0;
		  if ( !*((_DWORD *)v3 + 56) )
		    il2cpp_runtime_class_init_1(v3);
		  v6 = (void (__fastcall *)(__int64, int *, int *))qword_18F36F318;
		  if ( !qword_18F36F318 )
		  {
		    v6 = (void (__fastcall *)(__int64, int *, int *))il2cpp_resolve_icall_1(
		                                                       "UnityEngine.Display::GetSystemExtImpl(System.IntPtr,System.Int32&,System.Int32&)");
		    if ( !v6 )
		    {
		      v19 = sub_1802EE1B8("UnityEngine.Display::GetSystemExtImpl(System.IntPtr,System.Int32&,System.Int32&)");
		      sub_18007E1B0(v19, 0LL);
		    }
		    qword_18F36F318 = (__int64)v6;
		  }
		  v6(v5, &v27, &v24);
		  v3 = (_QWORD **)TypeInfo::UnityEngine::Display;
		  if ( !TypeInfo::UnityEngine::Display->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Display);
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Display;
		  }
		  v4 = v3[23][1];
		  if ( !v4 )
		    goto LABEL_30;
		  v7 = *(_QWORD *)(v4 + 16);
		  v25[0] = 0;
		  v26 = 0;
		  if ( !*((_DWORD *)v3 + 56) )
		    il2cpp_runtime_class_init_1(v3);
		  v8 = (void (__fastcall *)(__int64, _DWORD *, int *))qword_18F36F318;
		  if ( !qword_18F36F318 )
		  {
		    v8 = (void (__fastcall *)(__int64, _DWORD *, int *))il2cpp_resolve_icall_1(
		                                                          "UnityEngine.Display::GetSystemExtImpl(System.IntPtr,System.Int"
		                                                          "32&,System.Int32&)");
		    if ( !v8 )
		    {
		      v20 = sub_1802EE1B8("UnityEngine.Display::GetSystemExtImpl(System.IntPtr,System.Int32&,System.Int32&)");
		      sub_18007E1B0(v20, 0LL);
		    }
		    qword_18F36F318 = (__int64)v8;
		  }
		  v8(v7, v25, &v26);
		  v10 = (unsigned int (__fastcall *)(__int64))qword_18F36F340;
		  v11 = v26;
		  if ( !qword_18F36F340 )
		  {
		    v10 = (unsigned int (__fastcall *)(__int64))il2cpp_resolve_icall_1("UnityEngine.Screen::GetScreenOrientation()");
		    if ( !v10 )
		    {
		      v21 = sub_1802EE1B8("UnityEngine.Screen::GetScreenOrientation()");
		      sub_18007E1B0(v21, 0LL);
		    }
		    qword_18F36F340 = (__int64)v10;
		  }
		  if ( v10(v9) == 3 )
		    goto LABEL_53;
		  v12 = (unsigned int (__fastcall *)(_QWORD **))qword_18F36F340;
		  if ( !qword_18F36F340 )
		  {
		    v12 = (unsigned int (__fastcall *)(_QWORD **))il2cpp_resolve_icall_1("UnityEngine.Screen::GetScreenOrientation()");
		    if ( !v12 )
		    {
		      v22 = sub_1802EE1B8("UnityEngine.Screen::GetScreenOrientation()");
		      sub_18007E1B0(v22, 0LL);
		    }
		    qword_18F36F340 = (__int64)v12;
		  }
		  if ( v12(v3) == 4 )
		  {
		LABEL_53:
		    if ( v11 > v27 )
		      v11 = v27;
		  }
		  if ( !settingParameters )
		    goto LABEL_30;
		  renderingScale_k__BackingField = settingParameters->fields._renderingScale_k__BackingField;
		  v14 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !renderingScale_k__BackingField )
		    goto LABEL_30;
		  klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v4);
		  if ( !*((_QWORD *)klass->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v23 = sub_18011C4C0(v14->klass);
		    (**(void (__fastcall ***)(_QWORD))(*(_QWORD *)(v23 + 192) + 48LL))(*(_QWORD *)(v23 + 192));
		  }
		  v16 = v14->klass;
		  if ( ((__int64)v16->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v16, v4);
		  if ( v11 > 1080 )
		    return renderingScale_k__BackingField->fields._paramValue_k__BackingField;
		  if ( v11 < 432 )
		    return 1.0;
		  return (float)((sub_182F3EA70(v16, v4) + 432) & 0xFFFFFFFE) / (float)v11;
		}
		
		[IDTag(1)]
		public static Bounds TransformBounds([IsReadOnly] in Bounds b, Transform t) => default; // 0x0000000189C1105C-0x0000000189C1117C
		// Bounds TransformBounds(Bounds ByRef, Transform)
		Bounds *HG::Rendering::Runtime::HGUtils::TransformBounds(
		        Bounds *__return_ptr retstr,
		        Bounds *b,
		        Transform *t,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Matrix4x4 *localToWorldMatrix; // rax
		  Bounds *v10; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v12; // xmm0
		  __int64 v13; // xmm1_8
		  Bounds *result; // rax
		  Bounds v15; // [rsp+30h] [rbp-98h] BYREF
		  __int128 v16; // [rsp+48h] [rbp-80h]
		  __int128 v17; // [rsp+58h] [rbp-70h]
		  __int128 v18; // [rsp+68h] [rbp-60h]
		  Matrix4x4 v19; // [rsp+80h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3811, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3811, 0LL);
		    if ( Patch )
		    {
		      v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1349(&v15, Patch, b, (Object *)t, 0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  if ( !t )
		    goto LABEL_5;
		  localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v19, t, 0LL);
		  v16 = *(_OWORD *)&localToWorldMatrix->m00;
		  v17 = *(_OWORD *)&localToWorldMatrix->m01;
		  v18 = *(_OWORD *)&localToWorldMatrix->m02;
		  *(_OWORD *)&v15.m_Center.x = *(_OWORD *)&localToWorldMatrix->m03;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  *(_OWORD *)&v19.m00 = v16;
		  *(_OWORD *)&v19.m01 = v17;
		  *(_OWORD *)&v19.m02 = v18;
		  *(_OWORD *)&v19.m03 = *(_OWORD *)&v15.m_Center.x;
		  v10 = HG::Rendering::Runtime::HGUtils::TransformBounds(&v15, b, &v19, 0LL);
		LABEL_7:
		  v12 = *(_OWORD *)&v10->m_Center.x;
		  v13 = *(_QWORD *)&v10->m_Extents.y;
		  result = retstr;
		  *(_OWORD *)&retstr->m_Center.x = v12;
		  *(_QWORD *)&retstr->m_Extents.y = v13;
		  return result;
		}
		
		[IDTag(0)]
		public static Bounds TransformBounds([IsReadOnly] in Bounds b, Matrix4x4 m) => default; // 0x0000000189C1117C-0x0000000189C1144C
		// Bounds TransformBounds(Bounds ByRef, Matrix4x4)
		Bounds *HG::Rendering::Runtime::HGUtils::TransformBounds(
		        Bounds *__return_ptr retstr,
		        Bounds *b,
		        Matrix4x4 *m,
		        MethodInfo *method)
		{
		  __int128 v7; // xmm1
		  __int128 v8; // xmm4
		  __int128 v9; // xmm0
		  __int128 v10; // xmm3
		  __m128 y_low; // xmm8
		  __m128 si128; // xmm5
		  __m128 v13; // xmm8
		  __int128 v14; // xmm0
		  __m128 v15; // xmm7
		  __m128 v16; // xmm7
		  __int128 v17; // xmm0
		  float v18; // xmm6_4
		  Vector3 *v19; // rax
		  MethodInfo *v20; // r9
		  Vector3 *v21; // rax
		  float v22; // r8d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  Vector3 v30; // [rsp+38h] [rbp-59h] BYREF
		  Vector3 m_Extents; // [rsp+48h] [rbp-49h] BYREF
		  Bounds v32; // [rsp+58h] [rbp-39h] BYREF
		  Matrix4x4 v33; // [rsp+78h] [rbp-19h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1714, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1714, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v25, v24);
		    v26 = *(_OWORD *)&m->m01;
		    *(_OWORD *)&v33.m00 = *(_OWORD *)&m->m00;
		    v27 = *(_OWORD *)&m->m02;
		    *(_OWORD *)&v33.m01 = v26;
		    v28 = *(_OWORD *)&m->m03;
		    *(_OWORD *)&v33.m02 = v27;
		    *(_OWORD *)&v33.m03 = v28;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_685(&v32, Patch, b, &v33, 0LL);
		  }
		  else
		  {
		    v7 = *(_OWORD *)&b->m_Center.x;
		    v8 = *(_OWORD *)&m->m00;
		    *(_QWORD *)&v32.m_Extents.y = *(_QWORD *)&b->m_Extents.y;
		    *(_OWORD *)&v32.m_Center.x = v7;
		    m_Extents = v32.m_Extents;
		    v9 = *(_OWORD *)&b->m_Center.x;
		    v10 = *(_OWORD *)&m->m01;
		    *(_QWORD *)&v32.m_Extents.y = *(_QWORD *)&b->m_Extents.y;
		    *(_OWORD *)&v32.m_Center.x = v9;
		    v30.z = v32.m_Extents.z;
		    *(_QWORD *)&v30.x = *(_QWORD *)&v32.m_Extents.x;
		    y_low = (__m128)LODWORD(v32.m_Extents.y);
		    si128 = (__m128)_mm_load_si128((const __m128i *)&xmmword_18B9592D0);
		    y_low.m128_f32[0] = v32.m_Extents.y * *(float *)&v10;
		    v13 = _mm_and_ps(y_low, si128);
		    LODWORD(v7) = COERCE_UNSIGNED_INT(v32.m_Extents.z * COERCE_FLOAT(*(_OWORD *)&m->m02)) & si128.m128_i32[0];
		    *(_QWORD *)&v32.m_Extents.y = *(_QWORD *)&b->m_Extents.y;
		    v30.z = v32.m_Extents.z;
		    v13.m128_f32[0] = (float)(v13.m128_f32[0]
		                            + COERCE_FLOAT(COERCE_UNSIGNED_INT(m_Extents.x * *(float *)&v8) & si128.m128_i32[0]))
		                    + *(float *)&v7;
		    *(_OWORD *)&v32.m_Center.x = *(_OWORD *)&b->m_Center.x;
		    *(_QWORD *)&v30.x = *(_QWORD *)&v32.m_Extents.x;
		    v14 = *(_OWORD *)&b->m_Center.x;
		    *(_QWORD *)&v32.m_Extents.y = *(_QWORD *)&b->m_Extents.y;
		    *(_OWORD *)&v32.m_Center.x = v14;
		    m_Extents = v32.m_Extents;
		    v15 = (__m128)LODWORD(v32.m_Extents.y);
		    v15.m128_f32[0] = v32.m_Extents.y * m->m11;
		    LODWORD(v7) = COERCE_UNSIGNED_INT(v32.m_Extents.z * m->m12) & si128.m128_i32[0];
		    v16 = _mm_and_ps(v15, si128);
		    v16.m128_f32[0] = v16.m128_f32[0] + COERCE_FLOAT(COERCE_UNSIGNED_INT(v30.x * m->m10) & si128.m128_i32[0]);
		    *(_QWORD *)&v32.m_Extents.y = *(_QWORD *)&b->m_Extents.y;
		    v30.z = v32.m_Extents.z;
		    v16.m128_f32[0] = v16.m128_f32[0] + *(float *)&v7;
		    *(_OWORD *)&v32.m_Center.x = *(_OWORD *)&b->m_Center.x;
		    *(_QWORD *)&v30.x = *(_QWORD *)&v32.m_Extents.x;
		    v17 = *(_OWORD *)&b->m_Center.x;
		    *(_QWORD *)&v32.m_Extents.y = *(_QWORD *)&b->m_Extents.y;
		    *(_OWORD *)&v32.m_Center.x = v17;
		    m_Extents = v32.m_Extents;
		    v18 = (float)(COERCE_FLOAT(COERCE_UNSIGNED_INT(v32.m_Extents.y * m->m21) & si128.m128_i32[0])
		                + COERCE_FLOAT(COERCE_UNSIGNED_INT(v30.x * m->m20) & si128.m128_i32[0]))
		        + COERCE_FLOAT(COERCE_UNSIGNED_INT(v32.m_Extents.z * m->m22) & si128.m128_i32[0]);
		    *(_QWORD *)&m_Extents.x = *(_QWORD *)&b->m_Center.x;
		    LODWORD(m_Extents.z) = _mm_cvtsi128_si32(_mm_loadl_epi64((const __m128i *)&b->m_Center.z));
		    v19 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v30, m, &m_Extents, 0LL);
		    m_Extents.z = v18;
		    *(_QWORD *)&v10 = *(_QWORD *)&v19->x;
		    *(_QWORD *)&m_Extents.x = _mm_unpacklo_ps(v13, v16).m128_u64[0];
		    v21 = UnityEngine::Vector3::op_Multiply(&v30, &m_Extents, 2.0, v20);
		    *(_QWORD *)&v7 = *(_QWORD *)&v21->x;
		    m_Extents.z = v21->z;
		    v30.z = v22;
		    *(_OWORD *)&retstr->m_Center.x = 0LL;
		    *(_QWORD *)&retstr->m_Extents.y = 0LL;
		    *(_QWORD *)&m_Extents.x = v7;
		    *(_QWORD *)&v30.x = v10;
		    UnityEngine::Bounds::Bounds(retstr, &v30, &m_Extents, 0LL);
		  }
		  return retstr;
		}
		
		public static void SetCBData<T>(ref CBHandle cbHandle, T value, int offset)
			where T : struct {}
		public static void SetPerPassConstants(float flipX, float flipY, float renderPathInjected, float orientationType, CommandBuffer cmd, ScriptableRenderContext context) {} // 0x0000000183A7F2B0-0x0000000183A7F530
		// Void SetPerPassConstants(Single, Single, Single, Single, CommandBuffer, ScriptableRenderContext)
		void HG::Rendering::Runtime::HGUtils::SetPerPassConstants(
		        float flipX,
		        float flipY,
		        float renderPathInjected,
		        float orientationType,
		        CommandBuffer *cmd,
		        ScriptableRenderContext context,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v7; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  struct ScriptableRenderContext__Class *v10; // rcx
		  bool v11; // zf
		  void (__fastcall *v12)(ScriptableRenderContext *, __int64, __int128 *); // rax
		  void (__fastcall *v13)(__int64, _DWORD *, __int64); // rax
		  __int64 v14; // rbx
		  void (__fastcall *v15)(__int64, __int128 *, __int64); // rax
		  struct HGShaderIDs__Class *v16; // rax
		  unsigned int PerPassConstants; // edi
		  void (__fastcall *v18)(CommandBuffer *, _QWORD, _QWORD, _QWORD, int); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v20; // rax
		  __int64 v21; // rax
		  __int64 v22; // rax
		  __int64 v23; // rax
		  _DWORD v24[4]; // [rsp+40h] [rbp-88h] BYREF
		  __int128 v25; // [rsp+50h] [rbp-78h] BYREF
		  __int128 v26; // [rsp+60h] [rbp-68h] BYREF
		  __int64 v27; // [rsp+70h] [rbp-58h]
		
		  v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v7->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_23;
		  if ( wrapperArray->max_length.size <= 1208 )
		    goto LABEL_5;
		  if ( !v7->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v7);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v7->static_fields->wrapperArray;
		  if ( !wrapperArray )
		LABEL_23:
		    sub_1800D8260(wrapperArray, v7);
		  if ( wrapperArray->max_length.size <= 0x4B8u )
		    sub_1800D2AB0(wrapperArray, v7);
		  if ( wrapperArray[33].vector[20] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1208, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_461(
		        Patch,
		        flipX,
		        flipY,
		        renderPathInjected,
		        orientationType,
		        (Object *)cmd,
		        context,
		        0LL);
		      return;
		    }
		    goto LABEL_23;
		  }
		LABEL_5:
		  v10 = TypeInfo::UnityEngine::Rendering::ScriptableRenderContext;
		  *(float *)&v24[3] = orientationType;
		  *(float *)v24 = renderPathInjected;
		  *(float *)&v24[1] = flipX;
		  v11 = TypeInfo::UnityEngine::Rendering::ScriptableRenderContext->_1.cctor_finished_or_no_cctor == 0;
		  *(float *)&v24[2] = flipY;
		  if ( v11 )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		    v10 = TypeInfo::UnityEngine::Rendering::ScriptableRenderContext;
		  }
		  v26 = 0LL;
		  v27 = 0LL;
		  if ( !v10->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v10);
		  v12 = (void (__fastcall *)(ScriptableRenderContext *, __int64, __int128 *))qword_18F370388;
		  if ( !qword_18F370388 )
		  {
		    v12 = (void (__fastcall *)(ScriptableRenderContext *, __int64, __int128 *))il2cpp_resolve_icall_1(
		                                                                                 "UnityEngine.Rendering.ScriptableRenderC"
		                                                                                 "ontext::AllocateConstantBuffer_Injected"
		                                                                                 "(UnityEngine.Rendering.ScriptableRender"
		                                                                                 "Context&,System.Int32,UnityEngine.Rendering.CBHandle&)");
		    if ( !v12 )
		    {
		      v20 = sub_1802EE1B8(
		              "UnityEngine.Rendering.ScriptableRenderContext::AllocateConstantBuffer_Injected(UnityEngine.Rendering.Scrip"
		              "tableRenderContext&,System.Int32,UnityEngine.Rendering.CBHandle&)");
		      sub_18007E1B0(v20, 0LL);
		    }
		    qword_18F370388 = (__int64)v12;
		  }
		  v12(&context, 32LL, &v26);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  if ( !MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::HGRenderPathConstants>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::HGRenderPathConstants>);
		  v13 = (void (__fastcall *)(__int64, _DWORD *, __int64))qword_18F36EF28;
		  if ( !qword_18F36EF28 )
		  {
		    v13 = (void (__fastcall *)(__int64, _DWORD *, __int64))il2cpp_resolve_icall_1(
		                                                             "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(Sys"
		                                                             "tem.Void*,System.Void*,System.Int64)");
		    if ( !v13 )
		    {
		      v21 = sub_1802EE1B8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(System.Void*,System.Void*,System.Int64)");
		      sub_18007E1B0(v21, 0LL);
		    }
		    qword_18F36EF28 = (__int64)v13;
		  }
		  v14 = v27;
		  v13(v27, v24, 16LL);
		  v25 = 0LL;
		  if ( !MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<HG::Rendering::Runtime::HGPassConstructorPayload>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<HG::Rendering::Runtime::HGPassConstructorPayload>);
		  v15 = (void (__fastcall *)(__int64, __int128 *, __int64))qword_18F36EF28;
		  if ( !qword_18F36EF28 )
		  {
		    v15 = (void (__fastcall *)(__int64, __int128 *, __int64))il2cpp_resolve_icall_1(
		                                                               "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(S"
		                                                               "ystem.Void*,System.Void*,System.Int64)");
		    if ( !v15 )
		    {
		      v22 = sub_1802EE1B8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(System.Void*,System.Void*,System.Int64)");
		      sub_18007E1B0(v22, 0LL);
		    }
		    qword_18F36EF28 = (__int64)v15;
		  }
		  v15(v14 + 16, &v25, 16LL);
		  v16 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGShaderIDs->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    v16 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
		  }
		  PerPassConstants = v16->static_fields->_PerPassConstants;
		  if ( !cmd )
		    goto LABEL_23;
		  v18 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD, _QWORD, int))qword_18F370368;
		  if ( !qword_18F370368 )
		  {
		    v18 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD, _QWORD, int))il2cpp_resolve_icall_1(
		                                                                               "UnityEngine.Rendering.CommandBuffer::SetG"
		                                                                               "lobalConstantBufferInternal0(System.UInt3"
		                                                                               "2,System.Int32,System.Int32,System.Int32)");
		    if ( !v18 )
		    {
		      v23 = sub_1802EE1B8(
		              "UnityEngine.Rendering.CommandBuffer::SetGlobalConstantBufferInternal0(System.UInt32,System.Int32,System.In"
		              "t32,System.Int32)");
		      sub_18007E1B0(v23, 0LL);
		    }
		    qword_18F370368 = (__int64)v18;
		  }
		  v18(cmd, (unsigned int)v26, PerPassConstants, DWORD1(v26), 32);
		}
		
		internal static Matrix4x4 GetPreTransformMatrix(bool renderToBackBuffer) => default; // 0x0000000189C0E2E4-0x0000000189C0E45C
		// Matrix4x4 GetPreTransformMatrix(Boolean)
		Matrix4x4 *HG::Rendering::Runtime::HGUtils::GetPreTransformMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        bool renderToBackBuffer,
		        MethodInfo *method)
		{
		  unsigned __int32 v5; // eax
		  unsigned __int32 v6; // eax
		  Matrix4x4__StaticFields *v7; // rcx
		  __int128 v8; // xmm1
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  HGUtils__StaticFields *v11; // rcx
		  __int128 v12; // xmm1
		  HGUtils__StaticFields *v13; // rcx
		  __int128 v14; // xmm1
		  HGUtils__StaticFields *static_fields; // rcx
		  __int128 v16; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  Matrix4x4 *v20; // rax
		  __int128 v21; // xmm1
		  Matrix4x4 *result; // rax
		  Matrix4x4 v23; // [rsp+20h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3818, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3818, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v19, v18);
		    v20 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1353(&v23, Patch, renderToBackBuffer, 0LL);
		    v21 = *(_OWORD *)&v20->m01;
		    *(_OWORD *)&retstr->m00 = *(_OWORD *)&v20->m00;
		    v9 = *(_OWORD *)&v20->m02;
		    *(_OWORD *)&retstr->m01 = v21;
		    v10 = *(_OWORD *)&v20->m03;
		  }
		  else
		  {
		    if ( !renderToBackBuffer )
		      goto LABEL_6;
		    sub_1800036A0(TypeInfo::UnityEngine::Display);
		    v5 = UnityEngine::Display::get_preTransform(0LL) - 1;
		    if ( !v5 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		      v16 = *(_OWORD *)&static_fields->s_preTransform90Matrix.m01;
		      *(_OWORD *)&retstr->m00 = *(_OWORD *)&static_fields->s_preTransform90Matrix.m00;
		      v9 = *(_OWORD *)&static_fields->s_preTransform90Matrix.m02;
		      *(_OWORD *)&retstr->m01 = v16;
		      v10 = *(_OWORD *)&static_fields->s_preTransform90Matrix.m03;
		      goto LABEL_13;
		    }
		    v6 = v5 - 1;
		    if ( !v6 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v13 = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		      v14 = *(_OWORD *)&v13->s_preTransform180Matrix.m01;
		      *(_OWORD *)&retstr->m00 = *(_OWORD *)&v13->s_preTransform180Matrix.m00;
		      v9 = *(_OWORD *)&v13->s_preTransform180Matrix.m02;
		      *(_OWORD *)&retstr->m01 = v14;
		      v10 = *(_OWORD *)&v13->s_preTransform180Matrix.m03;
		      goto LABEL_13;
		    }
		    if ( v6 == 1 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v11 = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		      v12 = *(_OWORD *)&v11->s_preTransform270Matrix.m01;
		      *(_OWORD *)&retstr->m00 = *(_OWORD *)&v11->s_preTransform270Matrix.m00;
		      v9 = *(_OWORD *)&v11->s_preTransform270Matrix.m02;
		      *(_OWORD *)&retstr->m01 = v12;
		      v10 = *(_OWORD *)&v11->s_preTransform270Matrix.m03;
		    }
		    else
		    {
		LABEL_6:
		      v7 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		      v8 = *(_OWORD *)&v7->identityMatrix.m01;
		      *(_OWORD *)&retstr->m00 = *(_OWORD *)&v7->identityMatrix.m00;
		      v9 = *(_OWORD *)&v7->identityMatrix.m02;
		      *(_OWORD *)&retstr->m01 = v8;
		      v10 = *(_OWORD *)&v7->identityMatrix.m03;
		    }
		  }
		LABEL_13:
		  *(_OWORD *)&retstr->m02 = v9;
		  result = retstr;
		  *(_OWORD *)&retstr->m03 = v10;
		  return result;
		}
		
		[IDTag(1)]
		internal static GraphicsFormat GetSupportedFormatForDepth(GraphicsFormat format) => default; // 0x0000000189C0E594-0x0000000189C0E5FC
		// GraphicsFormat GetSupportedFormatForDepth(GraphicsFormat)
		GraphicsFormat__Enum HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(
		        GraphicsFormat__Enum format,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  DepthBits__Enum depthBits; // [rsp+40h] [rbp+18h] BYREF
		
		  depthBits = DepthBits__Enum_None;
		  if ( IFix::WrappersManagerImpl::IsPatched(1190, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1190, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1102((ILFixDynamicMethodWrapper_3 *)Patch, format, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    return HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(format, &depthBits, 0LL);
		  }
		}
		
		[IDTag(0)]
		internal static GraphicsFormat GetSupportedFormatForDepth(GraphicsFormat format, out DepthBits depthBits) {
			depthBits = default;
			return default;
		} // 0x00000001837E04A0-0x00000001837E0580
		// GraphicsFormat GetSupportedFormatForDepth(GraphicsFormat, DepthBits ByRef)
		GraphicsFormat__Enum HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(
		        GraphicsFormat__Enum format,
		        DepthBits__Enum *depthBits,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  unsigned __int8 (__fastcall *v7)(__int64, __int64); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rax
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_15;
		  if ( wrapperArray->max_length.size <= 138 )
		    goto LABEL_5;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		LABEL_15:
		    sub_1800D8260(v5, depthBits);
		  if ( LODWORD(v5->_0.namespaze) <= 0x8A )
		    sub_1800D2AB0(v5, depthBits);
		  if ( v5[3]._0.gc_desc )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(138, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_61(Patch, format, depthBits, 0LL);
		    goto LABEL_15;
		  }
		LABEL_5:
		  switch ( format )
		  {
		    case GraphicsFormat__Enum_D16_UNorm:
		      if ( UnityEngine::SystemInfo::IsFormatSupported(GraphicsFormat__Enum_D16_UNorm, FormatUsage__Enum_Render, 0LL) )
		      {
		        *depthBits = DepthBits__Enum_Depth16;
		        return 90;
		      }
		      goto LABEL_34;
		    case GraphicsFormat__Enum_D24_UNorm:
		      if ( UnityEngine::SystemInfo::IsFormatSupported(GraphicsFormat__Enum_D24_UNorm, FormatUsage__Enum_Render, 0LL) )
		        goto LABEL_31;
		      if ( !UnityEngine::SystemInfo::IsFormatSupported(GraphicsFormat__Enum_D32_SFloat, FormatUsage__Enum_Render, 0LL) )
		        goto LABEL_34;
		      goto LABEL_28;
		    case GraphicsFormat__Enum_D32_SFloat:
		      if ( !UnityEngine::SystemInfo::IsFormatSupported(GraphicsFormat__Enum_D32_SFloat, FormatUsage__Enum_Render, 0LL) )
		      {
		        if ( !UnityEngine::SystemInfo::IsFormatSupported(GraphicsFormat__Enum_D24_UNorm, FormatUsage__Enum_Render, 0LL) )
		          goto LABEL_34;
		LABEL_31:
		        *depthBits = DepthBits__Enum_Depth24;
		        return 91;
		      }
		LABEL_28:
		      *depthBits = DepthBits__Enum_Depth32;
		      return 93;
		  }
		  if ( format != GraphicsFormat__Enum_D24_UNorm_S8_UInt )
		  {
		    if ( format == GraphicsFormat__Enum_D32_SFloat_S8_UInt )
		    {
		      v7 = (unsigned __int8 (__fastcall *)(__int64, __int64))qword_18F36FF88;
		      if ( !qword_18F36FF88 )
		      {
		        v7 = (unsigned __int8 (__fastcall *)(__int64, __int64))il2cpp_resolve_icall_1(
		                                                                 "UnityEngine.SystemInfo::IsFormatSupported(UnityEngine.E"
		                                                                 "xperimental.Rendering.GraphicsFormat,UnityEngine.Experi"
		                                                                 "mental.Rendering.FormatUsage)");
		        if ( !v7 )
		        {
		          v10 = sub_1802EE1B8(
		                  "UnityEngine.SystemInfo::IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat,UnityEngin"
		                  "e.Experimental.Rendering.FormatUsage)");
		          sub_18007E1B0(v10, 0LL);
		        }
		        qword_18F36FF88 = (__int64)v7;
		      }
		      if ( v7(94LL, 4LL) )
		        goto LABEL_12;
		      if ( UnityEngine::SystemInfo::IsFormatSupported(
		             GraphicsFormat__Enum_D24_UNorm_S8_UInt,
		             FormatUsage__Enum_Render,
		             0LL) )
		      {
		        goto LABEL_37;
		      }
		    }
		LABEL_34:
		    *depthBits = DepthBits__Enum_None;
		    return 0;
		  }
		  if ( !UnityEngine::SystemInfo::IsFormatSupported(
		          GraphicsFormat__Enum_D24_UNorm_S8_UInt,
		          FormatUsage__Enum_Render,
		          0LL) )
		  {
		    if ( UnityEngine::SystemInfo::IsFormatSupported(
		           GraphicsFormat__Enum_D32_SFloat_S8_UInt,
		           FormatUsage__Enum_Render,
		           0LL) )
		    {
		LABEL_12:
		      *depthBits = DepthBits__Enum_Depth32;
		      return 94;
		    }
		    goto LABEL_34;
		  }
		LABEL_37:
		  *depthBits = DepthBits__Enum_Depth24;
		  return 92;
		}
		
		internal static TextureHandle GeneratePairedDepthTarget(HGRenderGraph renderGraph, HGCamera camera, TextureHandle colorTarget) => default; // 0x0000000189C0CEAC-0x0000000189C0D114
		// TextureHandle GeneratePairedDepthTarget(HGRenderGraph, HGCamera, TextureHandle)
		TextureHandle *HG::Rendering::Runtime::HGUtils::GeneratePairedDepthTarget(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        TextureHandle *colorTarget,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  int32_t msaaSamples_k__BackingField; // r13d
		  TextureDesc *TextureDescRef; // rax
		  int32_t width; // r14d
		  int32_t height; // r15d
		  int32_t v15; // eax
		  bool clearDepth; // al
		  HGRuntimeGrassQuery_Node *v17; // rdx
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  char *v20; // rax
		  TextureHandle *v21; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v23; // xmm0
		  TextureHandle *result; // rax
		  MethodInfo *v25; // [rsp+28h] [rbp-E0h]
		  TextureHandle v26; // [rsp+38h] [rbp-D0h] BYREF
		  TextureHandle v27; // [rsp+48h] [rbp-C0h] BYREF
		  TextureDesc v28; // [rsp+58h] [rbp-B0h] BYREF
		  TextureDesc v29; // [rsp+B8h] [rbp-50h] BYREF
		  DepthBits__Enum depthBits; // [rsp+158h] [rbp+50h] BYREF
		
		  depthBits = DepthBits__Enum_None;
		  v26.handle = 0LL;
		  v26.fallBackResource.m_Value = 0;
		  sub_18033B9D0(&v28, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(2949, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2949, 0LL);
		    if ( Patch )
		    {
		      v27 = *colorTarget;
		      v21 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1091(
		              &v26,
		              Patch,
		              (Object *)renderGraph,
		              (Object *)camera,
		              &v27,
		              0LL);
		      goto LABEL_15;
		    }
		LABEL_13:
		    sub_1800D8260(v10, v9);
		  }
		  if ( !camera )
		    goto LABEL_13;
		  msaaSamples_k__BackingField = camera->fields._msaaSamples_k__BackingField;
		  LOBYTE(v26.handle.m_Value) = 1;
		  v26.handle._type_k__BackingField = 1;
		  if ( !renderGraph )
		    goto LABEL_13;
		  TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(renderGraph, colorTarget, 0LL);
		  width = TextureDescRef->width;
		  height = TextureDescRef->height;
		  if ( UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_Vulkan )
		  {
		    v27 = *colorTarget;
		    if ( HG::Rendering::RenderGraphModule::HGRenderGraph::IsBackBuffer(renderGraph, &v27, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Display);
		      if ( UnityEngine::Display::get_preTransform(0LL) == Display_PreTransform__Enum_PreTransformRotate90
		        || (sub_1800036A0(TypeInfo::UnityEngine::Display),
		            UnityEngine::Display::get_preTransform(0LL) == Display_PreTransform__Enum_PreTransformRotate270) )
		      {
		        v15 = width;
		        width = height;
		        height = v15;
		      }
		    }
		  }
		  HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v28, width, height, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  v28.colorFormat = HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(
		                      GraphicsFormat__Enum_D24_UNorm_S8_UInt,
		                      &depthBits,
		                      0LL);
		  v28.bindTextureMS = msaaSamples_k__BackingField != 1;
		  v28.depthBufferBits = depthBits;
		  v28.msaaSamples = camera->fields._msaaSamples_k__BackingField;
		  clearDepth = HG::Rendering::Runtime::HGCamera::get_clearDepth(camera, 0LL);
		  v28.filterMode = 0;
		  v28.clearBuffer = clearDepth;
		  v20 = "CameraDepthStencil";
		  if ( msaaSamples_k__BackingField != 1 )
		    v20 = "CameraDepthStencilMSAA";
		  v28.wrapMode = 1;
		  v28.name = (String *)v20;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v28.name, v17, v18, v19, v25);
		  *(ResourceHandle *)&v28.fastMemoryDesc.inFastMemory = v26.handle;
		  v28.memoryless = 2;
		  v28.fastMemoryDesc.residencyFraction = 1.0;
		  v29 = v28;
		  v21 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v27, renderGraph, &v29, 0LL);
		LABEL_15:
		  v23 = *v21;
		  result = retstr;
		  *retstr = v23;
		  return result;
		}
		
		internal static bool RenderWithAlpha(HGCamera hgCamera = null) => default; // 0x000000018344DE70-0x000000018344DFD0
		// Boolean RenderWithAlpha(HGCamera)
		bool HG::Rendering::Runtime::HGUtils::RenderWithAlpha(HGCamera *hgCamera, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  struct Object_1__Class **static_fields; // rdx
		  struct Object_1__Class *v5; // rcx
		  HGAdditionalCameraData *m_AdditionalCameraData; // rdi
		  HGAdditionalCameraData *v7; // rax
		  bool enableAlpha; // al
		  char v9; // bl
		  struct Object_1__Class *v11; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  const Il2CppImage *image; // rax
		  ILFixDynamicMethodWrapper_2 *v14; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (struct Object_1__Class **)v2->static_fields;
		  v5 = *static_fields;
		  if ( !*static_fields )
		    goto LABEL_23;
		  if ( SLODWORD(v5->_0.namespaze) > 961 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (struct Object_1__Class **)v2->static_fields;
		    v11 = *static_fields;
		    if ( !*static_fields )
		      goto LABEL_23;
		    if ( LODWORD(v11->_0.namespaze) <= 0x3C1 )
		      goto LABEL_40;
		    if ( v11[20]._1.typeHierarchy )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(961, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                 (ILFixDynamicMethodWrapper_20 *)Patch,
		                 (Object *)hgCamera,
		                 0LL);
		      goto LABEL_23;
		    }
		  }
		  if ( !hgCamera )
		    goto LABEL_18;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct Object_1__Class *)v2->static_fields;
		  static_fields = (struct Object_1__Class **)v5->_0.image;
		  if ( !v5->_0.image )
		    goto LABEL_23;
		  if ( *((int *)static_fields + 6) <= 962 )
		    goto LABEL_10;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct Object_1__Class *)v2->static_fields;
		  image = v5->_0.image;
		  if ( !v5->_0.image )
		    goto LABEL_23;
		  if ( image->typeCount <= 0x3C2 )
		LABEL_40:
		    sub_1800D2AB0(v5, static_fields);
		  if ( *(_QWORD *)&image[107].typeCount )
		  {
		    v14 = IFix::WrappersManagerImpl::GetPatch(962, 0LL);
		    if ( !v14 )
		      goto LABEL_23;
		    enableAlpha = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                    (ILFixDynamicMethodWrapper_20 *)v14,
		                    (Object *)hgCamera,
		                    0LL);
		    goto LABEL_17;
		  }
		LABEL_10:
		  v5 = TypeInfo::UnityEngine::Object;
		  m_AdditionalCameraData = hgCamera->fields.m_AdditionalCameraData;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v5 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v5 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( m_AdditionalCameraData )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v5);
		    if ( m_AdditionalCameraData->fields._._._._.m_CachedPtr )
		    {
		      v7 = hgCamera->fields.m_AdditionalCameraData;
		      if ( v7 )
		      {
		        enableAlpha = v7->fields.enableAlpha;
		        goto LABEL_17;
		      }
		LABEL_23:
		      sub_1800D8260(v5, static_fields);
		    }
		  }
		  enableAlpha = 0;
		LABEL_17:
		  if ( enableAlpha )
		  {
		    v9 = 1;
		    goto LABEL_19;
		  }
		LABEL_18:
		  v9 = 0;
		LABEL_19:
		  if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		  return v9 != 0;
		}
		
		internal static bool ProcessRTExtraction(RTExtractionType type, TextureHandle src, HGCamera camera, HGRenderGraph renderGraph) => default; // 0x0000000189C0FDE0-0x0000000189C10248
		// Boolean ProcessRTExtraction(RTExtractionType, TextureHandle, HGCamera, HGRenderGraph)
		// Hidden C++ exception states: #wind=2
		bool HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
		        RTExtractionType__Enum type,
		        TextureHandle *src,
		        HGCamera *camera,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  Object *v5; // r14
		  Object *v6; // r15
		  TextureHandle *v7; // r13
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ v13; // xmm0
		  HashSet_1_UnityEngine_Rendering_RTHandle_ *Item1; // rsi
		  _BYTE *v15; // rdx
		  Il2CppException *v16; // rcx
		  Object *current; // rdi
		  TextureHandle v18; // xmm6
		  MethodInfo *v19; // rcx
		  ExtractionDoneCallback *extractionDoneCallback; // rax
		  __int64 v21; // rdx
		  HashSet_1_UnityEngine_Rendering_RTHandle_ *Item2; // rdi
		  Object *v23; // r12
		  TextureHandle v24; // xmm6
		  MethodInfo *v25; // rcx
		  ExtractionDoneCallback *v26; // rax
		  __int64 v27; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  _BYTE v32[32]; // [rsp+0h] [rbp-138h] BYREF
		  Il2CppException *ex; // [rsp+50h] [rbp-E8h]
		  HashSet_1_T_Enumerator_System_Object_ *v34; // [rsp+58h] [rbp-E0h]
		  HashSet_1_T_Enumerator_System_Object_ v35; // [rsp+60h] [rbp-D8h] BYREF
		  TextureHandle v36; // [rsp+80h] [rbp-B8h] BYREF
		  ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ v37; // [rsp+90h] [rbp-A8h]
		  TextureHandle v38; // [rsp+A0h] [rbp-98h] BYREF
		  TextureHandle v39; // [rsp+B0h] [rbp-88h] BYREF
		  HashSet_1_T_Enumerator_System_Object_ v40; // [rsp+C0h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v41; // [rsp+D8h] [rbp-60h] BYREF
		  Il2CppExceptionWrapper *v42; // [rsp+E0h] [rbp-58h] BYREF
		
		  v5 = (Object *)renderGraph;
		  v6 = (Object *)camera;
		  v7 = src;
		  memset(&v35, 0, sizeof(v35));
		  if ( IFix::WrappersManagerImpl::IsPatched(3566, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3566, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v31, v30);
		    v36 = *v7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1271(Patch, type, &v36, v6, v5, 0LL);
		  }
		  else
		  {
		    if ( !v6 )
		      sub_1800D8260(v10, v9);
		    v13 = *HG::Rendering::Runtime::HGCamera::GetRTForExtraction(
		             (ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ *)&v36,
		             (HGCamera *)v6,
		             type,
		             0LL);
		    v37 = v13;
		    Item1 = v13.Item1;
		    if ( !v13.Item1 )
		      sub_1800D8260(v12, v11);
		    v35 = *(HashSet_1_T_Enumerator_System_Object_ *)sub_180367ED0(&v40, v13.Item1);
		    ex = 0LL;
		    v34 = &v35;
		    try
		    {
		      while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
		                &v35,
		                MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::MoveNext) )
		      {
		        current = v35._current;
		        if ( !v5 )
		          sub_1800D8250(v16, v15);
		        v18 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                 (TextureHandle *)&v40,
		                 (HGRenderGraph *)v5,
		                 (RTHandle *)v35._current,
		                 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		        v38 = 0LL;
		        v39 = v18;
		        v36 = *v7;
		        HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		          (HGRenderGraph *)v5,
		          &v36,
		          &v39,
		          1,
		          -1,
		          0,
		          (Rect *)&v38,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		        extractionDoneCallback = HG::Rendering::Runtime::HGCamera::get_extractionDoneCallback(v19);
		        if ( !extractionDoneCallback )
		          sub_1800D8250(0LL, v21);
		        ((void (__fastcall *)(void *, Object *, Object *, void *))extractionDoneCallback->fields._._.invoke_impl)(
		          extractionDoneCallback->fields._._.method_code,
		          v6,
		          current,
		          extractionDoneCallback->fields._._.method);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v41 )
		    {
		      v15 = v32;
		      ex = v41->ex;
		      v16 = ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v5 = (Object *)renderGraph;
		      v6 = (Object *)camera;
		      v7 = src;
		      Item1 = v37.Item1;
		    }
		    Item2 = v37.Item2;
		    if ( !v37.Item2 )
		      goto LABEL_34;
		    System::Collections::Generic::HashSet<unsigned long>::GetEnumerator(
		      (HashSet_1_T_Enumerator_System_UInt64_ *)&v40,
		      (HashSet_1_System_UInt64_ *)v37.Item2,
		      MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::GetEnumerator);
		    v35 = v40;
		    ex = 0LL;
		    v34 = &v35;
		    try
		    {
		      while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
		                &v35,
		                MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::MoveNext) )
		      {
		        v23 = v35._current;
		        if ( !v5 )
		          sub_1800D8250(v16, v15);
		        v24 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                 (TextureHandle *)&v40,
		                 (HGRenderGraph *)v5,
		                 (RTHandle *)v35._current,
		                 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		        v36 = 0LL;
		        v39 = v24;
		        v38 = *v7;
		        HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		          (HGRenderGraph *)v5,
		          &v38,
		          &v39,
		          1,
		          -1,
		          0,
		          (Rect *)&v36,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		        v26 = HG::Rendering::Runtime::HGCamera::get_extractionDoneCallback(v25);
		        if ( !v26 )
		          sub_1800D8250(0LL, v27);
		        ((void (__fastcall *)(void *, Object *, Object *, void *))v26->fields._._.invoke_impl)(
		          v26->fields._._.method_code,
		          v6,
		          v23,
		          v26->fields._._.method);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v42 )
		    {
		      v15 = v32;
		      ex = v42->ex;
		      v16 = ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      Item2 = v37.Item2;
		      Item1 = v37.Item1;
		    }
		    if ( !Item1 )
		      goto LABEL_34;
		    if ( Item1->fields._count > 0 )
		      return 1;
		    if ( !Item2 )
		LABEL_34:
		      sub_1800D8250(v16, v15);
		    return Item2->fields._count > 0;
		  }
		}
		
		internal static bool ProcessWaterMarkRTs(HGCamera camera, HGCamera uiCamera, Shader blitPS, IntPtr cullingResults, HGRenderGraph renderGraph, ref HGRenderPathBase.HGRenderPathParams renderPathParams) => default; // 0x0000000189C10248-0x0000000189C10D74
		// Boolean ProcessWaterMarkRTs(HGCamera, HGCamera, Shader, IntPtr, HGRenderGraph, HGRenderPathBase+HGRenderPathParams ByRef)
		// Hidden C++ exception states: #wind=3
		bool HG::Rendering::Runtime::HGUtils::ProcessWaterMarkRTs(
		        HGCamera *camera,
		        HGCamera *uiCamera,
		        Shader *blitPS,
		        void *cullingResults,
		        HGRenderGraph *renderGraph,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  HGCamera *v9; // r15
		  HGCamera *v10; // r13
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *WaterMarkRTs; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  Dictionary_2_System_Text_RegularExpressions_Regex_CachedCodeEntryKey_System_Object_ *v16; // rsi
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  RTHandle *end; // xmm6_8
		  TextureHandle v20; // xmm8
		  TextureHandle v21; // xmm6
		  int32_t cullingLayerMask; // ebx
		  __int64 v23; // rdx
		  HGGraphicsFeatureSwitch *UISprite; // rcx
		  HGRenderGraph *v25; // r14
		  HGRenderGraphContext *HGContext; // r12
		  uint32_t RendererList; // eax
		  uint32_t v28; // r12d
		  HGRenderGraphContext *v29; // r12
		  __int64 v30; // rdx
		  RTHandle *v31; // r12
		  float v32; // xmm6_4
		  RenderTexture *m_CachedPtr; // rcx
		  RenderTexture *v34; // rbx
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  int v39; // esi
		  TextureHandle v40; // xmm7
		  int v41; // r12d
		  TextureHandle v42; // xmm6
		  ProfilingSampler *v43; // rax
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  bool clearDepth; // r12
		  unsigned int v47; // esi
		  __int64 v48; // rdx
		  __int64 v49; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-288h]
		  uint32_t viewHandle; // [rsp+60h] [rbp-248h]
		  uint32_t viewHandlea; // [rsp+60h] [rbp-248h]
		  signed int viewHandleb; // [rsp+60h] [rbp-248h]
		  uint32_t viewHandlec; // [rsp+60h] [rbp-248h]
		  int v59; // [rsp+64h] [rbp-244h]
		  uint32_t v60; // [rsp+68h] [rbp-240h]
		  uint32_t v61; // [rsp+6Ch] [rbp-23Ch]
		  Object *v62; // [rsp+70h] [rbp-238h] BYREF
		  Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *v63; // [rsp+78h] [rbp-230h]
		  Il2CppException *ex; // [rsp+80h] [rbp-228h] BYREF
		  void *v65; // [rsp+88h] [rbp-220h]
		  uint32_t key; // [rsp+90h] [rbp-218h] BYREF
		  DepthBits__Enum depthBits; // [rsp+94h] [rbp-214h]
		  Rect v68; // [rsp+A0h] [rbp-208h] BYREF
		  uint32_t v69; // [rsp+B0h] [rbp-1F8h]
		  MonitorData *v70; // [rsp+B8h] [rbp-1F0h]
		  Rect v71; // [rsp+C0h] [rbp-1E8h] BYREF
		  Rect v72; // [rsp+D0h] [rbp-1D8h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ v73; // [rsp+E0h] [rbp-1C8h] BYREF
		  HGRenderGraphBuilder v74; // [rsp+118h] [rbp-190h] BYREF
		  HGRenderPathBase_HGRenderPathParams *v75; // [rsp+138h] [rbp-170h]
		  TextureHandle v76; // [rsp+140h] [rbp-168h] BYREF
		  HGRenderGraphBuilder v77; // [rsp+150h] [rbp-158h] BYREF
		  FacLineDrawer_LineData value; // [rsp+170h] [rbp-138h] BYREF
		  TextureHandle v79; // [rsp+190h] [rbp-118h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Text_RegularExpressions_Regex_CachedCodeEntryKey_System_Object_ v80; // [rsp+1A0h] [rbp-108h] BYREF
		  Il2CppExceptionWrapper *v81; // [rsp+1D8h] [rbp-D0h] BYREF
		  Il2CppExceptionWrapper *v82; // [rsp+1E0h] [rbp-C8h] BYREF
		  Il2CppExceptionWrapper *v83; // [rsp+1E8h] [rbp-C0h] BYREF
		  TextureHandle v84; // [rsp+1F0h] [rbp-B8h] BYREF
		  __int64 v85; // [rsp+200h] [rbp-A8h]
		  TextureHandle v86; // [rsp+208h] [rbp-A0h] BYREF
		  TextureHandle v87; // [rsp+218h] [rbp-90h] BYREF
		  TextureHandle v88; // [rsp+228h] [rbp-80h] BYREF
		  TextureHandle v89; // [rsp+238h] [rbp-70h] BYREF
		
		  v9 = uiCamera;
		  v10 = camera;
		  v75 = renderPathParams;
		  memset(&v73, 0, sizeof(v73));
		  key = 0;
		  memset(&value, 0, sizeof(value));
		  v70 = 0LL;
		  memset(&v74, 0, sizeof(v74));
		  v62 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3564, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3564, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v53, v52);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1270(
		             Patch,
		             (Object *)v10,
		             (Object *)v9,
		             (Object *)blitPS,
		             cullingResults,
		             (Object *)renderGraph,
		             renderPathParams,
		             0LL);
		  }
		  else
		  {
		    if ( !v10 )
		      sub_1800D8260(v12, v11);
		    WaterMarkRTs = HG::Rendering::Runtime::HGCamera::GetWaterMarkRTs(v10, 0LL);
		    v16 = (Dictionary_2_System_Text_RegularExpressions_Regex_CachedCodeEntryKey_System_Object_ *)WaterMarkRTs;
		    v63 = WaterMarkRTs;
		    if ( !WaterMarkRTs )
		      sub_1800D8260(v15, v14);
		    if ( WaterMarkRTs->fields._count != WaterMarkRTs->fields._freeCount )
		    {
		      if ( v9 )
		        goto LABEL_12;
		      v73 = *(Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ *)sub_1808AEE70(&v80, WaterMarkRTs);
		      ex = 0LL;
		      v65 = &v73;
		      try
		      {
		        while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,Beyond::UI::FacLineDrawer::LineData>::MoveNext(
		                  &v73,
		                  MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::MoveNext) )
		        {
		          *(_OWORD *)&v80._dictionary = *(_OWORD *)&v73._current.key;
		          end = (RTHandle *)v73._current.value.end;
		          v85 = *(_OWORD *)&_mm_unpackhi_pd(*(__m128d *)&v73._current.value.end, *(__m128d *)&v73._current.value.end);
		          if ( !renderGraph )
		            sub_1800D8250(v18, v17);
		          v20 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                   &v79,
		                   renderGraph,
		                   (RTHandle *)v73._current.value.start,
		                   0LL);
		          v21 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                   (TextureHandle *)&v77,
		                   renderGraph,
		                   end,
		                   0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		          v72 = 0LL;
		          v71 = (Rect)v21;
		          v68 = (Rect)v20;
		          HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		            renderGraph,
		            (TextureHandle *)&v68,
		            (TextureHandle *)&v71,
		            1,
		            -1,
		            0,
		            &v72,
		            0,
		            0LL);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v81 )
		      {
		        ex = v81->ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		        v9 = uiCamera;
		        v10 = camera;
		        v16 = (Dictionary_2_System_Text_RegularExpressions_Regex_CachedCodeEntryKey_System_Object_ *)v63;
		LABEL_12:
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        cullingLayerMask = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->UI_2D_LAYER.m_Mask;
		        UnityEngine::SystemInfo::IsFormatSupported(
		          GraphicsFormat__Enum_D32_SFloat_S8_UInt,
		          FormatUsage__Enum_Render,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		        UISprite = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->UISprite;
		        if ( !UISprite )
		          goto LABEL_62;
		        if ( HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(UISprite, 0LL) )
		        {
		          if ( !v9 )
		            goto LABEL_62;
		          viewHandle = v9->fields.cullingViewHandle;
		          v25 = renderGraph;
		          if ( !renderGraph )
		            goto LABEL_62;
		          HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		          if ( !HGContext )
		            goto LABEL_62;
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          LOWORD(globalKeywords) = 0;
		          RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                           viewHandle,
		                           HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
		                           HGRenderFlags__Enum_Transparent,
		                           HGShaderLightMode__Enum_WaterMarkUI,
		                           globalKeywords,
		                           HGContext->fields.renderContext.m_Ptr,
		                           0,
		                           0,
		                           cullingLayerMask,
		                           0,
		                           0,
		                           0LL);
		          v28 = -1;
		        }
		        else
		        {
		          v28 = -1;
		          RendererList = -1;
		          v25 = renderGraph;
		        }
		        v60 = RendererList;
		        v59 = -1;
		        v69 = RendererList;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		        UISprite = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->UISprite;
		        if ( !UISprite )
		          goto LABEL_62;
		        if ( HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(UISprite, 0LL) )
		        {
		          if ( !v9 )
		            goto LABEL_62;
		          UISprite = (HGGraphicsFeatureSwitch *)v9->fields.camera;
		          if ( !UISprite )
		            goto LABEL_62;
		          viewHandlea = UnityEngine::Object::GetInstanceID((Object_1 *)UISprite, 0LL);
		          if ( !v25 )
		            goto LABEL_62;
		          v29 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(v25, 0LL);
		          if ( !v29 )
		            goto LABEL_62;
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          v28 = UnityEngine::HyperGryph::HGUIRender::CreateRendererList(
		                  cullingLayerMask,
		                  0,
		                  0,
		                  0x4000000u,
		                  0x8000,
		                  0x7FFF,
		                  viewHandlea,
		                  v29->fields.renderContext.m_Ptr,
		                  0,
		                  3.4028235e38,
		                  0LL);
		          v59 = v28;
		        }
		        v61 = v28;
		        if ( v16 )
		        {
		          System::Collections::Generic::Dictionary<System::Text::RegularExpressions::Regex::CachedCodeEntryKey,System::Object>::GetEnumerator(
		            &v80,
		            v16,
		            MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::GetEnumerator);
		          v73 = (Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_UI_FacLineDrawer_LineData_)v80;
		          *(_QWORD *)&v72.m_XMin = 0LL;
		          *(_QWORD *)&v72.m_Width = &v73;
		          try
		          {
		            while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,Beyond::UI::FacLineDrawer::LineData>::MoveNext(
		                      &v73,
		                      MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::MoveNext) )
		            {
		              *(_OWORD *)&v80._dictionary = *(_OWORD *)&v73._current.key;
		              *(_OWORD *)&v80._current.key._options = *(_OWORD *)&v73._current.value.end;
		              System::Collections::Generic::KeyValuePair<unsigned int,Beyond::UI::FacLineDrawer::LineData>::Deconstruct(
		                (KeyValuePair_2_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ *)&v80,
		                &key,
		                &value,
		                MethodInfo::System::Collections::Generic::KeyValuePair<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Deconstruct);
		              *(_QWORD *)&v68.m_XMin = value.start;
		              v31 = (RTHandle *)value.end;
		              v32 = *(float *)&value.link;
		              if ( value.start )
		                m_CachedPtr = (RenderTexture *)value.start->fields._._._._.m_CachedPtr;
		              else
		                m_CachedPtr = 0LL;
		              if ( value.end )
		                v34 = (RenderTexture *)value.end->fields._._._._.m_CachedPtr;
		              else
		                v34 = 0LL;
		              if ( !m_CachedPtr )
		                sub_1800D8250(0LL, v30);
		              UnityEngine::RenderTexture::Create(m_CachedPtr, 0LL);
		              if ( !v34 )
		                sub_1800D8250(v36, v35);
		              UnityEngine::RenderTexture::Create(v34, 0LL);
		              viewHandleb = sub_180002F70(5LL, v34);
		              v39 = sub_180002F70(7LL, v34);
		              if ( !v25 )
		                sub_1800D8250(v38, v37);
		              v40 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(&v86, v25, v31, 0LL);
		              v79 = v40;
		              LODWORD(v70) = viewHandleb;
		              v41 = (int)(float)((float)v39 / v32);
		              HIDWORD(v70) = v41;
		              v42 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                       &v87,
		                       v25,
		                       *(RTHandle **)&v68.m_XMin,
		                       0LL);
		              v71.m_XMin = 0.0;
		              v71.m_YMin = (float)(v39 - v41);
		              v71.m_Width = (float)viewHandleb;
		              v71.m_Height = (float)v41;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		              v68 = v71;
		              v76 = v40;
		              *(TextureHandle *)&v77.m_RenderPass = v42;
		              HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		                v25,
		                (TextureHandle *)&v77,
		                &v76,
		                1,
		                -1,
		                0,
		                &v68,
		                0,
		                0LL);
		              v43 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                      (Int32Enum__Enum)0xCFu,
		                      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		              HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		                &v77,
		                v25,
		                (String *)"Water Mark",
		                &v62,
		                v43,
		                1,
		                ProfilingHGPass__Enum_None,
		                MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGUtils::WaterMarkPassData>);
		              v74 = v77;
		              ex = 0LL;
		              v65 = &v74;
		              try
		              {
		                HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v74, 0, 0LL);
		                if ( !v10 )
		                  sub_1800D8250(v45, v44);
		                clearDepth = HG::Rendering::Runtime::HGCamera::get_clearDepth(v10, 0LL);
		                LODWORD(v68.m_XMin) = v10->fields._msaaSamples_k__BackingField;
		                depthBits = v75->perFrameSetup.depthBits;
		                viewHandlec = v75->perFrameSetup.depthGraphicsFormat;
		                v47 = sub_180002F70(5LL, v34);
		                v63 = (Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *)__PAIR64__(sub_180002F70(7LL, v34), v47);
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		                v76 = *HG::Rendering::Runtime::HGRenderPipeline::CreateDepthBuffer(
		                         &v88,
		                         v25,
		                         clearDepth,
		                         LODWORD(v68.m_XMin),
		                         depthBits,
		                         (GraphicsFormat__Enum)viewHandlec,
		                         (Vector2Int)v63,
		                         0LL);
		                *(_OWORD *)&v77.m_RenderPass = 0LL;
		                HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		                  &v89,
		                  &v74,
		                  &v79,
		                  0,
		                  RenderBufferLoadAction__Enum_Load,
		                  RenderBufferStoreAction__Enum_Store,
		                  (Color *)&v77,
		                  0,
		                  0LL);
		                HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		                  &v84,
		                  &v74,
		                  &v76,
		                  DepthAccess__Enum_Write,
		                  RenderBufferLoadAction__Enum_Clear,
		                  RenderBufferStoreAction__Enum_DontCare,
		                  1.0,
		                  0,
		                  0,
		                  0LL);
		                if ( !v62 )
		                  sub_1800D8250(v49, v48);
		                LODWORD(v62[1].klass) = v60;
		                if ( !v62 )
		                  sub_1800D8250(v60, v48);
		                HIDWORD(v62[1].klass) = v59;
		                if ( !v62 )
		                  sub_1800D8250(0LL, v48);
		                v62[1].monitor = v70;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		                HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		                  &v74,
		                  (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_WaterMarkRenderFunc,
		                  (Object *)v9,
		                  0,
		                  MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGUtils::WaterMarkPassData>);
		              }
		              catch ( Il2CppExceptionWrapper *v82 )
		              {
		                ex = v82->ex;
		                sub_180268AE0(&ex);
		                v25 = renderGraph;
		                v9 = uiCamera;
		                v10 = camera;
		                v60 = v69;
		                v59 = v61;
		                continue;
		              }
		              sub_180268AE0(&ex);
		            }
		          }
		          catch ( Il2CppExceptionWrapper *v83 )
		          {
		            *(Il2CppExceptionWrapper *)&v72.m_XMin = (Il2CppExceptionWrapper)v83->ex;
		            if ( *(_QWORD *)&v72.m_XMin )
		              sub_18007E1E0(*(_QWORD *)&v72.m_XMin);
		          }
		          return 1;
		        }
		LABEL_62:
		        sub_1800D8250(UISprite, v23);
		      }
		      return 1;
		    }
		    return 0;
		  }
		}
		
		internal static bool ProcessInplaceWaterMarkRTs(HGCamera camera, HGCamera uiCamera, Shader blitPS, IntPtr cullingResults, HGRenderGraph renderGraph, ref HGRenderPathBase.HGRenderPathParams renderPathParams) => default; // 0x0000000189C0F648-0x0000000189C0FDE0
		// Boolean ProcessInplaceWaterMarkRTs(HGCamera, HGCamera, Shader, IntPtr, HGRenderGraph, HGRenderPathBase+HGRenderPathParams ByRef)
		// Hidden C++ exception states: #wind=2
		bool HG::Rendering::Runtime::HGUtils::ProcessInplaceWaterMarkRTs(
		        HGCamera *camera,
		        HGCamera *uiCamera,
		        Shader *blitPS,
		        void *cullingResults,
		        HGRenderGraph *renderGraph,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  HGCamera *v10; // r13
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *InplaceWaterMarkRTs; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *v16; // r15
		  int32_t cullingLayerMask; // ebx
		  __int64 v18; // rdx
		  HGGraphicsFeatureManager__StaticFields *static_fields; // rcx
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  HGRenderGraph *v22; // rsi
		  uint32_t cullingViewHandle; // r12d
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  HGRenderGraphContext *HGContext; // r14
		  uint32_t RendererList; // eax
		  uint32_t v28; // r12d
		  __int64 v29; // rdx
		  HGGraphicsFeatureManager__StaticFields *v30; // rcx
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  int32_t InstanceID; // r12d
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  HGRenderGraphContext *v38; // r14
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry current; // xmm6
		  RTHandle *coreZone; // r14
		  ICoreZoneState__Class *klass; // rbx
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  int v46; // r15d
		  ProfilingSampler *v47; // rax
		  __int64 v48; // rdx
		  __int64 v49; // rcx
		  bool clearDepth; // r15
		  unsigned int v51; // r14d
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v56; // rdx
		  __int64 v57; // rcx
		  HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-1C8h]
		  uint32_t v59; // [rsp+60h] [rbp-188h]
		  int v60; // [rsp+64h] [rbp-184h]
		  GraphicsFormat__Enum depthGraphicsFormat; // [rsp+64h] [rbp-184h]
		  Object *v62; // [rsp+68h] [rbp-180h] BYREF
		  DepthBits__Enum depthBits; // [rsp+70h] [rbp-178h]
		  MSAASamples__Enum msaaSamples_k__BackingField; // [rsp+74h] [rbp-174h]
		  uint32_t v65; // [rsp+78h] [rbp-170h]
		  uint32_t v66; // [rsp+7Ch] [rbp-16Ch]
		  MonitorData *v67; // [rsp+80h] [rbp-168h]
		  Vector2Int v68; // [rsp+88h] [rbp-160h]
		  _QWORD v69[2]; // [rsp+90h] [rbp-158h] BYREF
		  HGRenderGraphBuilder v70; // [rsp+A0h] [rbp-148h] BYREF
		  HGRenderPathBase_HGRenderPathParams *v71; // [rsp+C0h] [rbp-128h]
		  Il2CppException *ex; // [rsp+C8h] [rbp-120h]
		  List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *v73; // [rsp+D0h] [rbp-118h]
		  List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ v74; // [rsp+D8h] [rbp-110h] BYREF
		  HGRenderGraphBuilder v75; // [rsp+F8h] [rbp-F0h] BYREF
		  Il2CppExceptionWrapper *v76; // [rsp+118h] [rbp-D0h] BYREF
		  Il2CppExceptionWrapper *v77; // [rsp+120h] [rbp-C8h] BYREF
		  Color v78; // [rsp+130h] [rbp-B8h] BYREF
		  TextureHandle v79; // [rsp+140h] [rbp-A8h] BYREF
		  TextureHandle v80; // [rsp+150h] [rbp-98h] BYREF
		  TextureHandle v81; // [rsp+160h] [rbp-88h] BYREF
		  TextureHandle v82; // [rsp+170h] [rbp-78h] BYREF
		  TextureHandle v83[4]; // [rsp+180h] [rbp-68h] BYREF
		
		  v10 = camera;
		  v71 = renderPathParams;
		  memset(&v74, 0, sizeof(v74));
		  v67 = 0LL;
		  memset(&v70, 0, sizeof(v70));
		  v62 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3565, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3565, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v57, v56);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1270(
		             Patch,
		             (Object *)v10,
		             (Object *)uiCamera,
		             (Object *)blitPS,
		             cullingResults,
		             (Object *)renderGraph,
		             renderPathParams,
		             0LL);
		  }
		  else
		  {
		    if ( !v10 )
		      sub_1800D8260(v12, v11);
		    InplaceWaterMarkRTs = HG::Rendering::Runtime::HGCamera::GetInplaceWaterMarkRTs(v10, 0LL);
		    v16 = InplaceWaterMarkRTs;
		    if ( !InplaceWaterMarkRTs )
		      sub_1800D8260(v15, v14);
		    if ( InplaceWaterMarkRTs->fields._size )
		    {
		      if ( uiCamera )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        cullingLayerMask = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->UI_2D_LAYER.m_Mask;
		        UnityEngine::SystemInfo::IsFormatSupported(
		          GraphicsFormat__Enum_D32_SFloat_S8_UInt,
		          FormatUsage__Enum_Render,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		        if ( !static_fields->UISprite )
		          sub_1800D8260(static_fields, v18);
		        v22 = renderGraph;
		        if ( HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(static_fields->UISprite, 0LL) )
		        {
		          cullingViewHandle = uiCamera->fields.cullingViewHandle;
		          if ( !renderGraph )
		            sub_1800D8260(v21, v20);
		          HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		          if ( !HGContext )
		            sub_1800D8260(v25, v24);
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          LOWORD(globalKeywords) = 0;
		          RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                           cullingViewHandle,
		                           HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
		                           HGRenderFlags__Enum_Transparent,
		                           HGShaderLightMode__Enum_WaterMarkUI,
		                           globalKeywords,
		                           HGContext->fields.renderContext.m_Ptr,
		                           0,
		                           0,
		                           cullingLayerMask,
		                           0,
		                           0,
		                           0LL);
		          v28 = -1;
		        }
		        else
		        {
		          v28 = -1;
		          RendererList = -1;
		        }
		        v59 = RendererList;
		        v65 = RendererList;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		        v30 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		        if ( !v30->UISprite )
		          sub_1800D8260(v30, v29);
		        if ( HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(v30->UISprite, 0LL) )
		        {
		          if ( !uiCamera->fields.camera )
		            sub_1800D8260(v32, v31);
		          InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)uiCamera->fields.camera, 0LL);
		          if ( !renderGraph )
		            sub_1800D8260(v34, v33);
		          v38 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		          if ( !v38 )
		            sub_1800D8260(v37, v36);
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          v28 = UnityEngine::HyperGryph::HGUIRender::CreateRendererList(
		                  cullingLayerMask,
		                  0,
		                  0,
		                  0x4000000u,
		                  0x8000,
		                  0x7FFF,
		                  InstanceID,
		                  v38->fields.renderContext.m_Ptr,
		                  0,
		                  3.4028235e38,
		                  0LL);
		        }
		        v66 = v28;
		        v74 = *(List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)sub_1808AEEB4(v83, v16);
		        ex = 0LL;
		        v73 = &v74;
		        try
		        {
		          while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::MoveNext(
		                    &v74,
		                    MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::MoveNext) )
		          {
		            current = v74._current;
		            coreZone = (RTHandle *)v74._current.coreZone;
		            if ( !v74._current.coreZone || (klass = v74._current.coreZone[1].klass) == 0LL )
		              sub_1800D8250(v40, v39);
		            UnityEngine::RenderTexture::Create((RenderTexture *)v74._current.coreZone[1].klass, 0LL);
		            v60 = sub_180002F70(5LL, klass);
		            v46 = sub_180002F70(7LL, klass);
		            if ( !v22 )
		              sub_1800D8250(v45, v44);
		            v79 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(&v80, v22, coreZone, 0LL);
		            LODWORD(v67) = v60;
		            HIDWORD(v67) = (int)(float)((float)v46 / _mm_shuffle_ps((__m128)current, (__m128)current, 170).m128_f32[0]);
		            v47 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                    (Int32Enum__Enum)0xCFu,
		                    MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		            HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		              &v75,
		              v22,
		              (String *)"Water Mark",
		              &v62,
		              v47,
		              1,
		              ProfilingHGPass__Enum_None,
		              MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGUtils::WaterMarkPassData>);
		            v70 = v75;
		            v69[0] = 0LL;
		            v69[1] = &v70;
		            try
		            {
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v70, 0, 0LL);
		              if ( !v10 )
		                sub_1800D8250(v49, v48);
		              clearDepth = HG::Rendering::Runtime::HGCamera::get_clearDepth(v10, 0LL);
		              msaaSamples_k__BackingField = v10->fields._msaaSamples_k__BackingField;
		              depthBits = v71->perFrameSetup.depthBits;
		              depthGraphicsFormat = v71->perFrameSetup.depthGraphicsFormat;
		              v51 = sub_180002F70(5LL, klass);
		              v68 = (Vector2Int)__PAIR64__(sub_180002F70(7LL, klass), v51);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		              *(TextureHandle *)&v75.m_RenderPass = *HG::Rendering::Runtime::HGRenderPipeline::CreateDepthBuffer(
		                                                       &v81,
		                                                       v22,
		                                                       clearDepth,
		                                                       msaaSamples_k__BackingField,
		                                                       depthBits,
		                                                       depthGraphicsFormat,
		                                                       v68,
		                                                       0LL);
		              v78 = 0LL;
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		                &v82,
		                &v70,
		                &v79,
		                0,
		                RenderBufferLoadAction__Enum_Clear,
		                RenderBufferStoreAction__Enum_Store,
		                &v78,
		                0,
		                0LL);
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		                v83,
		                &v70,
		                (TextureHandle *)&v75,
		                DepthAccess__Enum_Write,
		                RenderBufferLoadAction__Enum_Clear,
		                RenderBufferStoreAction__Enum_DontCare,
		                1.0,
		                0,
		                0,
		                0LL);
		              if ( !v62 )
		                sub_1800D8250(v53, v52);
		              LODWORD(v62[1].klass) = v59;
		              if ( !v62 )
		                sub_1800D8250(v59, v52);
		              HIDWORD(v62[1].klass) = v28;
		              if ( !v62 )
		                sub_1800D8250(0LL, v52);
		              v62[1].monitor = v67;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		                &v70,
		                (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_WaterMarkRenderFunc,
		                (Object *)uiCamera,
		                0,
		                MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGUtils::WaterMarkPassData>);
		            }
		            catch ( Il2CppExceptionWrapper *v76 )
		            {
		              v69[0] = v76->ex;
		              sub_180268AE0(v69);
		              v22 = renderGraph;
		              v10 = camera;
		              v59 = v65;
		              v28 = v66;
		              continue;
		            }
		            sub_180268AE0(v69);
		          }
		        }
		        catch ( Il2CppExceptionWrapper *v77 )
		        {
		          ex = v77->ex;
		          if ( ex )
		            sub_18007E1E0(ex);
		        }
		      }
		      return 1;
		    }
		    else
		    {
		      return 0;
		    }
		  }
		}
		
		internal static bool ExtractFinalResultForInplaceWaterMarkRTs(TextureHandle src, HGCamera camera, HGRenderGraph renderGraph) => default; // 0x0000000189C0CBFC-0x0000000189C0CEAC
		// Boolean ExtractFinalResultForInplaceWaterMarkRTs(TextureHandle, HGCamera, HGRenderGraph)
		// Hidden C++ exception states: #wind=1
		bool HG::Rendering::Runtime::HGUtils::ExtractFinalResultForInplaceWaterMarkRTs(
		        TextureHandle *src,
		        HGCamera *camera,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *InplaceWaterMarkRTs; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry current; // xmm6
		  RTHandle *coreZone; // rsi
		  ICoreZoneState__Class *klass; // rdi
		  int v17; // r15d
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  int v20; // edi
		  TextureHandle *v21; // rax
		  int v22; // ecx
		  TextureHandle v23; // xmm6
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  Rect v28; // [rsp+50h] [rbp-B8h]
		  Il2CppException *ex; // [rsp+60h] [rbp-A8h]
		  TextureHandle v30; // [rsp+70h] [rbp-98h] BYREF
		  List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ v31; // [rsp+80h] [rbp-88h] BYREF
		  Il2CppExceptionWrapper *v32; // [rsp+A0h] [rbp-68h] BYREF
		  Rect v33; // [rsp+B0h] [rbp-58h] BYREF
		  TextureHandle v34; // [rsp+C0h] [rbp-48h] BYREF
		  TextureHandle v35[3]; // [rsp+D0h] [rbp-38h] BYREF
		
		  memset(&v31, 0, sizeof(v31));
		  if ( IFix::WrappersManagerImpl::IsPatched(3569, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3569, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v27, v26);
		    v30 = *src;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1272(Patch, &v30, (Object *)camera, (Object *)renderGraph, 0LL);
		  }
		  else
		  {
		    if ( !camera )
		      sub_1800D8260(v8, v7);
		    InplaceWaterMarkRTs = HG::Rendering::Runtime::HGCamera::GetInplaceWaterMarkRTs(camera, 0LL);
		    if ( !InplaceWaterMarkRTs )
		      sub_1800D8260(v11, v10);
		    if ( InplaceWaterMarkRTs->fields._size )
		    {
		      v31 = *(List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)sub_1808AEEB4(v35, InplaceWaterMarkRTs);
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::MoveNext(
		                  &v31,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::MoveNext) )
		        {
		          current = v31._current;
		          coreZone = (RTHandle *)v31._current.coreZone;
		          if ( !v31._current.coreZone || (klass = v31._current.coreZone[1].klass) == 0LL )
		            sub_1800D8250(v13, v12);
		          UnityEngine::RenderTexture::Create((RenderTexture *)v31._current.coreZone[1].klass, 0LL);
		          v17 = sub_180002F70(5LL, klass);
		          v20 = sub_180002F70(7LL, klass);
		          if ( !renderGraph )
		            sub_1800D8250(v19, v18);
		          v21 = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(v35, renderGraph, coreZone, 0LL);
		          v22 = (int)(float)((float)v20 / _mm_shuffle_ps((__m128)current, (__m128)current, 170).m128_f32[0]);
		          v23 = *v21;
		          v28.m_XMin = 0.0;
		          v28.m_YMin = (float)(v20 - v22);
		          v28.m_Width = (float)v17;
		          v28.m_Height = (float)v22;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		          v33 = v28;
		          v34 = v23;
		          v30 = *src;
		          HG::Rendering::Runtime::CopyTexturePass::BlitTexture(renderGraph, &v30, &v34, 1, -1, 0, &v33, 1, 0LL);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v32 )
		      {
		        ex = v32->ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		      }
		      return 1;
		    }
		    else
		    {
		      return 0;
		    }
		  }
		}
		
		internal static RTHandle GetOrCreateUICameraClearRT(UnityEngine.Color clearColor) => default; // 0x0000000189C0E004-0x0000000189C0E2E4
		// RTHandle GetOrCreateUICameraClearRT(Color)
		RTHandle *HG::Rendering::Runtime::HGUtils::GetOrCreateUICameraClearRT(Color *clearColor, MethodInfo *method)
		{
		  struct HGUtils__Class *v3; // rcx
		  Object_1 *s_uiCameraTexture; // rbx
		  struct HGUtils__Class *v5; // r8
		  __int64 v6; // rdx
		  Texture2D *v7; // rcx
		  Texture2D *v8; // rax
		  Texture2D *v9; // rbx
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  Texture *v13; // rbx
		  RTHandle *v14; // rax
		  HGUtils__StaticFields *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *mipChaina; // [rsp+20h] [rbp-38h]
		  MethodInfo *mipChain; // [rsp+20h] [rbp-38h]
		  Color v22; // [rsp+30h] [rbp-28h] BYREF
		  Color s_cachedUiCameraClearColor; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3668, 0LL) )
		  {
		    v3 = TypeInfo::HG::Rendering::Runtime::HGUtils;
		    clearColor->a = 1.0;
		    sub_1800036A0(v3);
		    s_uiCameraTexture = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_uiCameraTexture;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(s_uiCameraTexture, 0LL, 0LL) )
		    {
		      v8 = (Texture2D *)sub_18002C620(TypeInfo::UnityEngine::Texture2D);
		      v9 = v8;
		      if ( v8 )
		      {
		        UnityEngine::Texture2D::Texture2D(v8, 1, 1, TextureFormat__Enum_RGBA32, 0, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_uiCameraTexture = v9;
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_uiCameraTexture,
		          v10,
		          v11,
		          v12,
		          mipChaina);
		        v7 = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_uiCameraTexture;
		        if ( v7 )
		        {
		          s_cachedUiCameraClearColor = *clearColor;
		          UnityEngine::Texture2D::SetPixel(v7, 0, 0, &s_cachedUiCameraClearColor, 0LL);
		          v7 = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_uiCameraTexture;
		          if ( v7 )
		          {
		            UnityEngine::Texture2D::Apply(v7, 0LL);
		            TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_cachedUiCameraClearColor = *clearColor;
		            v13 = (Texture *)TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_uiCameraTexture;
		            sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		            v14 = UnityEngine::Rendering::RTHandleSystem::Alloc(v13, 0LL);
		            static_fields = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		            static_fields->s_uiCameraRT = v14;
		            sub_18002D1B0(
		              (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_uiCameraRT,
		              (HGRuntimeGrassQuery_Node *)static_fields,
		              v16,
		              v17,
		              mipChain);
		            goto LABEL_11;
		          }
		        }
		      }
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v22 = *clearColor;
		      s_cachedUiCameraClearColor = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_cachedUiCameraClearColor;
		      if ( (unsigned __int8)sub_182FA61B0(&s_cachedUiCameraClearColor, &v22) )
		      {
		LABEL_12:
		        sub_1800036A0(v5);
		        return TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_uiCameraRT;
		      }
		      sub_1800036A0(v5);
		      v7 = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_uiCameraTexture;
		      if ( v7 )
		      {
		        s_cachedUiCameraClearColor = *clearColor;
		        UnityEngine::Texture2D::SetPixel(v7, 0, 0, &s_cachedUiCameraClearColor, 0LL);
		        v7 = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_uiCameraTexture;
		        if ( v7 )
		        {
		          UnityEngine::Texture2D::Apply(v7, 0LL);
		          TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->s_cachedUiCameraClearColor = *clearColor;
		LABEL_11:
		          v5 = TypeInfo::HG::Rendering::Runtime::HGUtils;
		          goto LABEL_12;
		        }
		      }
		    }
		LABEL_14:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3668, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  s_cachedUiCameraClearColor = *clearColor;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1278(Patch, &s_cachedUiCameraClearColor, 0LL);
		}
		
		public static int ComputeTextureStreamingBudget(HGSettingParameters settingParameters) => default; // 0x000000018350DAF0-0x000000018350DCB0
		// Int32 ComputeTextureStreamingBudget(HGSettingParameters)
		int32_t HG::Rendering::Runtime::HGUtils::ComputeTextureStreamingBudget(
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  int32_t GraphicsMemorySize; // eax
		  SettingParameter_1_System_Int32_ *textureQuality16GB_k__BackingField; // rbx
		  struct MethodInfo *v7; // rsi
		  Il2CppClass *klass; // rax
		  Int32Enum__Enum paramValue_k__BackingField; // ebx
		  SettingParameter_1_System_Int32_ *textureStreamingMaxBudget_k__BackingField; // rdi
		  struct MethodInfo *v11; // rsi
		  Il2CppClass *v12; // rax
		  Il2CppClass *v13; // rcx
		  int32_t v14; // edi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v17; // rax
		  SettingParameter_1_System_Int32_ *textureQuality6GB_k__BackingField; // rcx
		  __int64 v19; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_30;
		  if ( wrapperArray->max_length.size > 506 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( !v3 )
		      goto LABEL_30;
		    if ( LODWORD(v3->_0.namespaze) <= 0x1FA )
		      sub_1800D2AB0(v3, wrapperArray);
		    if ( v3[10].vtable.Equals.method )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(506, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                 (ILFixDynamicMethodWrapper_31 *)Patch,
		                 (Object *)settingParameters,
		                 0LL);
		      goto LABEL_30;
		    }
		  }
		  GraphicsMemorySize = UnityEngine::SystemInfo::GetGraphicsMemorySize(0LL);
		  if ( (float)GraphicsMemorySize < 7311.3599 )
		  {
		    if ( settingParameters )
		    {
		      textureQuality6GB_k__BackingField = settingParameters->fields._textureQuality6GB_k__BackingField;
		      goto LABEL_46;
		    }
		    goto LABEL_30;
		  }
		  if ( (float)GraphicsMemorySize < 9400.3203 )
		  {
		    if ( settingParameters )
		    {
		      textureQuality6GB_k__BackingField = settingParameters->fields._textureQuality8GB_k__BackingField;
		      goto LABEL_46;
		    }
		    goto LABEL_30;
		  }
		  if ( (float)GraphicsMemorySize < 11489.279 )
		  {
		    if ( settingParameters )
		    {
		      textureQuality6GB_k__BackingField = settingParameters->fields._textureQuality10GB_k__BackingField;
		      goto LABEL_46;
		    }
		LABEL_30:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  if ( !settingParameters )
		    goto LABEL_30;
		  if ( (float)GraphicsMemorySize < 13578.24 )
		  {
		    textureQuality6GB_k__BackingField = settingParameters->fields._textureQuality12GB_k__BackingField;
		LABEL_46:
		    paramValue_k__BackingField = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                   (SettingParameter_1_System_Int32Enum_ *)textureQuality6GB_k__BackingField,
		                                   MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    goto LABEL_18;
		  }
		  textureQuality16GB_k__BackingField = settingParameters->fields._textureQuality16GB_k__BackingField;
		  v7 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !textureQuality16GB_k__BackingField )
		    goto LABEL_30;
		  klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)klass->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v17 = sub_18011C4C0(v7->klass);
		    (**(void (***)(void))(*(_QWORD *)(v17 + 192) + 48LL))();
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v7->klass;
		  if ( ((__int64)v3->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v3, wrapperArray);
		  paramValue_k__BackingField = textureQuality16GB_k__BackingField->fields._paramValue_k__BackingField;
		LABEL_18:
		  textureStreamingMaxBudget_k__BackingField = settingParameters->fields._textureStreamingMaxBudget_k__BackingField;
		  v11 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !textureStreamingMaxBudget_k__BackingField )
		    goto LABEL_30;
		  v12 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v12->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v12->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v19 = sub_18011C4C0(v11->klass);
		    (**(void (***)(void))(*(_QWORD *)(v19 + 192) + 48LL))();
		  }
		  v13 = v11->klass;
		  if ( ((__int64)v13->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v13, wrapperArray);
		  v14 = textureStreamingMaxBudget_k__BackingField->fields._paramValue_k__BackingField;
		  if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		  if ( (int)paramValue_k__BackingField > v14 )
		    return v14;
		  return paramValue_k__BackingField;
		}
		
		public static int GetEstimatedVRAMUsage() => default; // 0x0000000189C0D490-0x0000000189C0DB50
		// Int32 GetEstimatedVRAMUsage()
		int32_t HG::Rendering::Runtime::HGUtils::GetEstimatedVRAMUsage(MethodInfo *method)
		{
		  HGRenderPipelineSettingHub *instance; // rax
		  __int64 v2; // rdx
		  HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *s_settingParameters; // rcx
		  HGRenderPipeline *currentPipeline; // rax
		  HGSettingParameters *settingParameters_k__BackingField; // rdi
		  HGRenderPipeline_HGResolutionSettings *resolutionSettings; // rax
		  HGRenderPipeline_HGResolutionSettings *v7; // rax
		  HGRenderPipeline_HGResolutionSettings *v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  int32_t v11; // ebp
		  HGRenderPipeline_HGResolutionSettings *v12; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  HGRenderPipeline_HGResolutionSettings *v15; // rax
		  int32_t TAAUResolveResolutionWidth; // ebx
		  HGRenderPipeline_HGResolutionSettings *v17; // rax
		  SettingParameter_1_UnityEngine_HyperGryphEngineCode_StreamlineDLSSFGMode_ *dlssGMode_k__BackingField; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3Int v23; // [rsp+30h] [rbp-D8h] BYREF
		  Vector2Int finalRTSizea; // [rsp+118h] [rbp+10h]
		  Vector2Int finalRTSize; // [rsp+118h] [rbp+10h]
		  Vector2Int taauSize; // [rsp+120h] [rbp+18h] BYREF
		
		  taauSize = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3819, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3819, 0LL);
		    if ( !Patch )
		      goto LABEL_30;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    if ( HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL) )
		    {
		      instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		      if ( instance )
		      {
		        HG::Rendering::Runtime::HGRenderPipelineSettingHub::RefreshDirtySettings(instance, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		        currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		        if ( currentPipeline )
		        {
		          settingParameters_k__BackingField = currentPipeline->fields._settingParameters_k__BackingField;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		          HG::Rendering::Runtime::HGUtils::GetRenderingScale(settingParameters_k__BackingField, 0LL);
		          resolutionSettings = HG::Rendering::Runtime::HGRenderPipeline::get_resolutionSettings(0LL);
		          if ( resolutionSettings )
		          {
		            HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::GetTAAUResolveResolutionWidth(
		              resolutionSettings,
		              0LL);
		            v7 = HG::Rendering::Runtime::HGRenderPipeline::get_resolutionSettings(0LL);
		            if ( v7 )
		            {
		              HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::GetTAAUResolveResolutionHeight(v7, 0LL);
		              v8 = HG::Rendering::Runtime::HGRenderPipeline::get_resolutionSettings(0LL);
		              if ( v8 )
		              {
		                HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::GetTAAUResolveResolutionWidth(v8, 0LL);
		                v11 = sub_182F3EA70(v10, v9);
		                v12 = HG::Rendering::Runtime::HGRenderPipeline::get_resolutionSettings(0LL);
		                if ( v12 )
		                {
		                  HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::GetTAAUResolveResolutionHeight(
		                    v12,
		                    0LL);
		                  finalRTSizea.m_X = v11;
		                  finalRTSizea.m_Y = sub_182F3EA70(v14, v13);
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		                  HG::Rendering::Runtime::HGVolumetricFogRenderer::GetVolumetricFogGridSize(
		                    &v23,
		                    finalRTSizea,
		                    &taauSize,
		                    0LL);
		                  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		                  if ( s_settingParameters )
		                  {
		                    HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                      s_settingParameters->fields.enableVolumetricFog,
		                      MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		                    if ( settingParameters_k__BackingField )
		                    {
		                      if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                             settingParameters_k__BackingField->fields._csmEnabled_k__BackingField,
		                             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		                      {
		                        HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                          (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField->fields._csmShadowMapTileResolution_k__BackingField,
		                          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		                        HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                          (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField->fields._csmShadowMapTileResolution_k__BackingField,
		                          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		                      }
		                      if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                             settingParameters_k__BackingField->fields._asmEnabled_k__BackingField,
		                             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		                      {
		                        HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                          (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField->fields._asmShadowMapTileResolution_k__BackingField,
		                          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		                        HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                          (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField->fields._asmShadowMapTileResolution_k__BackingField,
		                          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		                      }
		                      if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                             settingParameters_k__BackingField->fields._characterShadowEnabled_k__BackingField,
		                             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		                      {
		                        HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                          (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField->fields._characterShadowMapResolution_k__BackingField,
		                          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		                        HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                          (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField->fields._characterShadowMapResolution_k__BackingField,
		                          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		                      }
		                      if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                             settingParameters_k__BackingField->fields._punctualLightShadowEnabled_k__BackingField,
		                             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		                      {
		                        HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                          (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField->fields._punctualLightTileMaxSize_k__BackingField,
		                          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		                        HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                          (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField->fields._punctualLightTileMaxSize_k__BackingField,
		                          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		                        HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                          (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField->fields._punctualLightEnvDynamicCasterCount_k__BackingField,
		                          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		                        HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                          (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField->fields._punctualLightMovableDynamicCasterCount_k__BackingField,
		                          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		                        sub_1832DBD50();
		                      }
		                      HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                        settingParameters_k__BackingField->fields._contactShadowEnableParam_k__BackingField,
		                        MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		                      HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                        settingParameters_k__BackingField->fields._ssrEnable_k__BackingField,
		                        MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		                      HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                        settingParameters_k__BackingField->fields._ssrV2Upsample_k__BackingField,
		                        MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		                      if ( !UnityEngine::HyperGryph::HGDLSSUtil::IsStreamlineDLSSSupported(0LL)
		                        || settingParameters_k__BackingField->fields._dlssEnable_k__BackingField )
		                      {
		                        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		                        v15 = HG::Rendering::Runtime::HGRenderPipeline::get_resolutionSettings(0LL);
		                        if ( v15 )
		                        {
		                          TAAUResolveResolutionWidth = HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::GetTAAUResolveResolutionWidth(
		                                                         v15,
		                                                         0LL);
		                          v17 = HG::Rendering::Runtime::HGRenderPipeline::get_resolutionSettings(0LL);
		                          if ( v17 )
		                          {
		                            taauSize.m_X = TAAUResolveResolutionWidth;
		                            taauSize.m_Y = HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::GetTAAUResolveResolutionHeight(
		                                             v17,
		                                             0LL);
		                            finalRTSize.m_X = UnityEngine::Screen::get_width(0LL);
		                            finalRTSize.m_Y = UnityEngine::Screen::get_height(0LL);
		                            if ( !UnityEngine::HyperGryph::HGDLSSUtil::IsStreamlineDLSSGSupported(0LL) )
		                            {
		LABEL_27:
		                              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		                              HG::Rendering::Runtime::HGUtils::ComputeTextureStreamingBudget(
		                                settingParameters_k__BackingField,
		                                0LL);
		                              return sub_182F3EA70(v20, v19);
		                            }
		                            dlssGMode_k__BackingField = settingParameters_k__BackingField->fields._dlssGMode_k__BackingField;
		                            if ( dlssGMode_k__BackingField )
		                            {
		                              if ( dlssGMode_k__BackingField->fields._paramValue_k__BackingField )
		                                UnityEngine::HyperGryphEngineCode::HGCPPDLSSUtil::CalcStreamlineDLSSGVRAMUsage(
		                                  taauSize,
		                                  finalRTSize,
		                                  0LL);
		                              goto LABEL_27;
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		LABEL_30:
		      sub_1800D8260(s_settingParameters, v2);
		    }
		    return -1;
		  }
		}
		
		public static int GetVRAMUsageWarningThreshold() => default; // 0x0000000189C0E9A8-0x0000000189C0EA00
		// Int32 GetVRAMUsageWarningThreshold()
		int32_t HG::Rendering::Runtime::HGUtils::GetVRAMUsageWarningThreshold(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  __int64 v2; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3820, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3820, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    UnityEngine::SystemInfo::GetGraphicsMemorySize(0LL);
		    return sub_182F3EA70(v2, v1);
		  }
		}
		
		internal static ComputeShader SelectGPUDrivenCullingShader(HGRenderPipelineRuntimeResources resources) => default; // 0x0000000189C10DE0-0x0000000189C10ED0
		// ComputeShader SelectGPUDrivenCullingShader(HGRenderPipelineRuntimeResources)
		ComputeShader *HG::Rendering::Runtime::HGUtils::SelectGPUDrivenCullingShader(
		        HGRenderPipelineRuntimeResources *resources,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  Object_1 *GPUDrivenCullingCS; // rsi
		  char WaveIntrinsicsSupportedStages; // bl
		  char WaveIntrinsicsSupportedOperations; // al
		  HGRenderPipelineRuntimeResources_ShaderResources *v9; // rbx
		  Object_1 *GPUDrivenCullingWaveBasicCS; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3591, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3591, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1275(Patch, (Object *)resources, 0LL);
		LABEL_14:
		    sub_1800D8260(v4, v3);
		  }
		  if ( !resources )
		    goto LABEL_14;
		  shaders = resources->fields.shaders;
		  if ( !shaders )
		    goto LABEL_14;
		  GPUDrivenCullingCS = (Object_1 *)shaders->fields.GPUDrivenCullingCS;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Equality(GPUDrivenCullingCS, 0LL, 0LL) )
		    return 0LL;
		  WaveIntrinsicsSupportedStages = UnityEngine::SystemInfo::GetWaveIntrinsicsSupportedStages(0LL);
		  WaveIntrinsicsSupportedOperations = UnityEngine::SystemInfo::GetWaveIntrinsicsSupportedOperations(0LL);
		  if ( (WaveIntrinsicsSupportedStages & 0x20) == 0 || (WaveIntrinsicsSupportedOperations & 0xD) != 0xD )
		    return (ComputeShader *)GPUDrivenCullingCS;
		  v9 = resources->fields.shaders;
		  if ( !v9 )
		    goto LABEL_14;
		  GPUDrivenCullingWaveBasicCS = (Object_1 *)v9->fields.GPUDrivenCullingWaveBasicCS;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Inequality(GPUDrivenCullingWaveBasicCS, 0LL, 0LL) )
		    return (ComputeShader *)GPUDrivenCullingCS;
		  return (ComputeShader *)GPUDrivenCullingWaveBasicCS;
		}
		
	
		// Extension methods
		public static float Sqr(this float f) => default; // 0x0000000189C10ED0-0x0000000189C10F2C
		// Single Sqr(Single)
		float HG::Rendering::Runtime::HGUtils::Sqr(float f, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3812, 0LL) )
		    return f * f;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3812, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v5, v4);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, f, 0LL);
		}
		
		public static float Sqrt(this float f) => default; // 0x0000000189C10F2C-0x0000000189C10F88
		// Single Sqrt(Single)
		float HG::Rendering::Runtime::HGUtils::Sqrt(float f, MethodInfo *method)
		{
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3813, 0LL) )
		    return sub_1803386C0(v3, v2);
		  Patch = IFix::WrappersManagerImpl::GetPatch(3813, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v7, v6);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, f, 0LL);
		}
		
		internal static int MaxAxis(this Vector3 v) => default; // 0x0000000189C0ECE0-0x0000000189C0ED68
		// Int32 MaxAxis(Vector3)
		int32_t HG::Rendering::Runtime::HGUtils::MaxAxis(Vector3 *v, MethodInfo *method)
		{
		  int32_t v3; // edi
		  float v4; // xmm0_4
		  __int64 v6; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-18h] BYREF
		
		  v3 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(3814, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3814, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v6);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1350(Patch, &v9, 0LL);
		  }
		  else
		  {
		    v4 = v->z;
		    if ( v4 <= v->x || v4 <= v->y )
		    {
		      LOBYTE(v3) = v->y > v->x;
		      return v3;
		    }
		    else
		    {
		      return 2;
		    }
		  }
		}
		
		[IDTag(1)]
		public static float Abs(this float f) => default; // 0x00000001831F55A0-0x00000001831F5610
		// Single Abs(Single)
		float HG::Rendering::Runtime::HGUtils::Abs(float f, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 3815 )
		    return fabs(f);
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 0xEE7u )
		    sub_1800D2AB0(wrapperArray, v2);
		  if ( !wrapperArray[106].max_length.value )
		    return fabs(f);
		  Patch = IFix::WrappersManagerImpl::GetPatch(3815, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(wrapperArray, v2);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, f, 0LL);
		}
		
		[IDTag(2)]
		public static Vector2 Abs(this Vector2 v) => default; // 0x0000000189C0AA88-0x0000000189C0AB1C
		// Vector2 Abs(Vector2)
		Vector2 HG::Rendering::Runtime::HGUtils::Abs(Vector2 v, MethodInfo *method)
		{
		  MethodInfo *v3; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3816, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3816, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1351(Patch, v, 0LL);
		  }
		  else
		  {
		    *(_QWORD *)&v9.x = _mm_unpacklo_ps(
		                         _mm_and_ps((__m128)LODWORD(v.x), *(__m128 *)&xmmword_18B9592D0),
		                         _mm_and_ps((__m128)LODWORD(v.y), *(__m128 *)&xmmword_18B9592D0)).m128_u64[0];
		    v9.z = 0.0;
		    return UnityEngine::Vector4::op_Implicit(&v9, v3);
		  }
		}
		
		[IDTag(0)]
		public static Vector3 Abs(this Vector3 v) => default; // 0x0000000183D54980-0x0000000183D54A10
		// Vector3 Abs(Vector3)
		Vector3 *HG::Rendering::Runtime::HGUtils::Abs(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  __int32 v7; // xmm2_4
		  float z; // xmm1_4
		  int v9; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // xmm0_8
		  Vector3 *v13; // rax
		  __int64 v14; // xmm0_8
		  Vector3 v15; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v16[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 626 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x272 )
		        sub_1800D2AB0(v5, wrapperArray);
		      if ( !v5[13]._0.methods )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(626, 0LL);
		      if ( Patch )
		      {
		        v12 = *(_QWORD *)&v->x;
		        v15.z = v->z;
		        *(_QWORD *)&v15.x = v12;
		        v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v16, Patch, &v15, 0LL);
		        v14 = *(_QWORD *)&v13->x;
		        *(float *)&v13 = v13->z;
		        *(_QWORD *)&retstr->x = v14;
		        LODWORD(retstr->z) = (_DWORD)v13;
		        return retstr;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v5, wrapperArray);
		  }
		LABEL_5:
		  COERCE_FLOAT(v7 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_i32[0]);
		  z = v->z;
		  LODWORD(retstr->x) = LODWORD(v->x) & v7;
		  v9 = LODWORD(v->y) & v7;
		  LODWORD(retstr->z) = LODWORD(z) & v7;
		  LODWORD(retstr->y) = v9;
		  return retstr;
		}
		
		[IDTag(3)]
		public static Vector4 Abs(this Vector4 v) => default; // 0x0000000189C0AA0C-0x0000000189C0AA88
		// Vector4 Abs(Vector4)
		Vector4 *HG::Rendering::Runtime::HGUtils::Abs(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3817, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3817, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    *(__m128 *)retstr = _mm_and_ps(*(__m128 *)v, *(__m128 *)&xmmword_18B9592D0);
		  }
		  return retstr;
		}
		
	}
}
