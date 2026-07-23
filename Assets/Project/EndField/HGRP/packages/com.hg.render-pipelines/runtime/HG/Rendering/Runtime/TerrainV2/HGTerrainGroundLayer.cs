using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using HG.Rendering.Runtime;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.TerrainV2
{
	public class HGTerrainGroundLayer // TypeDefIndex: 38825
	{
		// Fields
		private RTHandle m_groundLayerBaseRT; // 0x10
		private RTHandle m_groundLayerNormalRT; // 0x18
		private RTHandle m_groundLayerWetRT; // 0x20
		private RTHandle m_groundLayerHeightRT; // 0x28
		private RTHandle m_defaultRT; // 0x30
		public const int TEXTURE_SIZE = 1024; // Metadata: 0x023044E1
		public const int TERRAIN_GROUND_LAYER_CLIPMAP_NUM = 2; // Metadata: 0x023044E3
		private HGTerrainGroundLayerClipmap[] clipmaps; // 0x38
	
		// Constructors
		public HGTerrainGroundLayer() {} // 0x0000000182ED8520-0x0000000182ED8550
		// HGTerrainGroundLayer()
		void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::HGTerrainGroundLayer(
		        HGTerrainGroundLayer *this,
		        MethodInfo *method)
		{
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v3; // rdx
		  VolumetricRenderer_VolumetricBounds *v4; // r8
		  Int32__Array **v5; // r9
		  MethodInfo *v6; // [rsp+50h] [rbp+28h]
		  MethodInfo *v7; // [rsp+58h] [rbp+30h]
		  int32_t v8; // [rsp+60h] [rbp+38h]
		  int32_t v9; // [rsp+68h] [rbp+40h]
		  float v10; // [rsp+70h] [rbp+48h]
		  int32_t v11; // [rsp+78h] [rbp+50h]
		  bool v12; // [rsp+80h] [rbp+58h]
		  bool v13; // [rsp+88h] [rbp+60h]
		  MethodInfo *v14; // [rsp+90h] [rbp+68h]
		
		  this->fields.clipmaps = (HGTerrainGroundLayerClipmap__Array *)il2cpp_array_new_specific_1(
		                                                                  TypeInfo::HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap,
		                                                                  2LL);
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields.clipmaps,
		    v3,
		    v4,
		    v5,
		    v6,
		    v7,
		    v8,
		    v9,
		    v10,
		    v11,
		    v12,
		    v13,
		    v14);
		}
		
	
		// Methods
		private void InitializeRenderTextureResources() {} // 0x0000000189C79A60-0x0000000189C79D48
		// Void InitializeRenderTextureResources()
		void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::InitializeRenderTextureResources(
		        HGTerrainGroundLayer *this,
		        MethodInfo *method)
		{
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v3; // rdx
		  VolumetricRenderer_VolumetricBounds *v4; // r8
		  Int32__Array **v5; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v6; // rdx
		  VolumetricRenderer_VolumetricBounds *v7; // r8
		  Int32__Array **v8; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v9; // rdx
		  VolumetricRenderer_VolumetricBounds *v10; // r8
		  Int32__Array **v11; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v12; // rdx
		  VolumetricRenderer_VolumetricBounds *v13; // r8
		  Int32__Array **v14; // r9
		  Texture *blackTexture; // rbx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v16; // rdx
		  VolumetricRenderer_VolumetricBounds *v17; // r8
		  Int32__Array **v18; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  MethodInfo *colorFormat; // [rsp+20h] [rbp-98h]
		  MethodInfo *colorFormata; // [rsp+20h] [rbp-98h]
		  MethodInfo *colorFormatb; // [rsp+20h] [rbp-98h]
		  MethodInfo *colorFormatc; // [rsp+20h] [rbp-98h]
		  MethodInfo *colorFormatd; // [rsp+20h] [rbp-98h]
		  MethodInfo *filterMode; // [rsp+28h] [rbp-90h]
		  MethodInfo *filterModea; // [rsp+28h] [rbp-90h]
		  MethodInfo *filterModeb; // [rsp+28h] [rbp-90h]
		  MethodInfo *filterModec; // [rsp+28h] [rbp-90h]
		  MethodInfo *filterModed; // [rsp+28h] [rbp-90h]
		  TextureWrapMode__Enum wrapMode; // [rsp+30h] [rbp-88h]
		  TextureWrapMode__Enum wrapModea; // [rsp+30h] [rbp-88h]
		  TextureWrapMode__Enum wrapModeb; // [rsp+30h] [rbp-88h]
		  TextureWrapMode__Enum wrapModec; // [rsp+30h] [rbp-88h]
		  TextureWrapMode__Enum wrapModed; // [rsp+30h] [rbp-88h]
		  TextureDimension__Enum dimension; // [rsp+38h] [rbp-80h]
		  TextureDimension__Enum dimensiona; // [rsp+38h] [rbp-80h]
		  TextureDimension__Enum dimensionb; // [rsp+38h] [rbp-80h]
		  TextureDimension__Enum dimensionc; // [rsp+38h] [rbp-80h]
		  TextureDimension__Enum dimensiond; // [rsp+38h] [rbp-80h]
		  float enableRandomWrite; // [rsp+40h] [rbp-78h]
		  float enableRandomWritea; // [rsp+40h] [rbp-78h]
		  float enableRandomWriteb; // [rsp+40h] [rbp-78h]
		  float enableRandomWritec; // [rsp+40h] [rbp-78h]
		  float enableRandomWrited; // [rsp+40h] [rbp-78h]
		  int32_t useMipMap; // [rsp+48h] [rbp-70h]
		  int32_t useMipMapa; // [rsp+48h] [rbp-70h]
		  int32_t useMipMapb; // [rsp+48h] [rbp-70h]
		  int32_t useMipMapc; // [rsp+48h] [rbp-70h]
		  int32_t useMipMapd; // [rsp+48h] [rbp-70h]
		  bool autoGenerateMips; // [rsp+50h] [rbp-68h]
		  bool autoGenerateMipsa; // [rsp+50h] [rbp-68h]
		  bool autoGenerateMipsb; // [rsp+50h] [rbp-68h]
		  bool autoGenerateMipsc; // [rsp+50h] [rbp-68h]
		  bool autoGenerateMipsd; // [rsp+50h] [rbp-68h]
		  bool isShadowMap; // [rsp+58h] [rbp-60h]
		  bool isShadowMapa; // [rsp+58h] [rbp-60h]
		  bool isShadowMapb; // [rsp+58h] [rbp-60h]
		  bool isShadowMapc; // [rsp+58h] [rbp-60h]
		  bool isShadowMapd; // [rsp+58h] [rbp-60h]
		  MethodInfo *anisoLevel; // [rsp+60h] [rbp-58h]
		  MethodInfo *anisoLevela; // [rsp+60h] [rbp-58h]
		  MethodInfo *anisoLevelb; // [rsp+60h] [rbp-58h]
		  MethodInfo *anisoLevelc; // [rsp+60h] [rbp-58h]
		  MethodInfo *anisoLeveld; // [rsp+60h] [rbp-58h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3422, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3422, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v21, v20);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !this->fields.m_groundLayerBaseRT )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		      this->fields.m_groundLayerBaseRT = UnityEngine::Rendering::RTHandles::Alloc(
		                                           1024,
		                                           1024,
		                                           2,
		                                           DepthBits__Enum_None,
		                                           GraphicsFormat__Enum_R8G8B8A8_UNorm,
		                                           FilterMode__Enum_Bilinear,
		                                           TextureWrapMode__Enum_Clamp,
		                                           TextureDimension__Enum_Tex2DArray,
		                                           1,
		                                           0,
		                                           0,
		                                           0,
		                                           1,
		                                           0.0,
		                                           MSAASamples__Enum_None,
		                                           0,
		                                           RenderTextureMemoryless__Enum_None,
		                                           (String *)"TerrainGroundLayerBaseRT",
		                                           0LL);
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)&this->fields,
		        v3,
		        v4,
		        v5,
		        colorFormata,
		        filterModea,
		        wrapModea,
		        dimensiona,
		        enableRandomWritea,
		        useMipMapa,
		        autoGenerateMipsa,
		        isShadowMapa,
		        anisoLevela);
		    }
		    if ( !this->fields.m_groundLayerNormalRT )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		      this->fields.m_groundLayerNormalRT = UnityEngine::Rendering::RTHandles::Alloc(
		                                             1024,
		                                             1024,
		                                             2,
		                                             DepthBits__Enum_None,
		                                             GraphicsFormat__Enum_R8G8B8A8_UNorm,
		                                             FilterMode__Enum_Bilinear,
		                                             TextureWrapMode__Enum_Clamp,
		                                             TextureDimension__Enum_Tex2DArray,
		                                             1,
		                                             0,
		                                             0,
		                                             0,
		                                             1,
		                                             0.0,
		                                             MSAASamples__Enum_None,
		                                             0,
		                                             RenderTextureMemoryless__Enum_None,
		                                             (String *)"TerrainGroundLayerNormalRT",
		                                             0LL);
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_groundLayerNormalRT,
		        v6,
		        v7,
		        v8,
		        colorFormatb,
		        filterModeb,
		        wrapModeb,
		        dimensionb,
		        enableRandomWriteb,
		        useMipMapb,
		        autoGenerateMipsb,
		        isShadowMapb,
		        anisoLevelb);
		    }
		    if ( !this->fields.m_groundLayerWetRT )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		      this->fields.m_groundLayerWetRT = UnityEngine::Rendering::RTHandles::Alloc(
		                                          1024,
		                                          1024,
		                                          2,
		                                          DepthBits__Enum_None,
		                                          GraphicsFormat__Enum_R8G8B8A8_UNorm,
		                                          FilterMode__Enum_Bilinear,
		                                          TextureWrapMode__Enum_Clamp,
		                                          TextureDimension__Enum_Tex2DArray,
		                                          1,
		                                          0,
		                                          0,
		                                          0,
		                                          1,
		                                          0.0,
		                                          MSAASamples__Enum_None,
		                                          0,
		                                          RenderTextureMemoryless__Enum_None,
		                                          (String *)"TerrainGroundLayerWetRT",
		                                          0LL);
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_groundLayerWetRT,
		        v9,
		        v10,
		        v11,
		        colorFormatc,
		        filterModec,
		        wrapModec,
		        dimensionc,
		        enableRandomWritec,
		        useMipMapc,
		        autoGenerateMipsc,
		        isShadowMapc,
		        anisoLevelc);
		    }
		    if ( !this->fields.m_groundLayerHeightRT )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		      this->fields.m_groundLayerHeightRT = UnityEngine::Rendering::RTHandles::Alloc(
		                                             1024,
		                                             1024,
		                                             2,
		                                             DepthBits__Enum_None,
		                                             GraphicsFormat__Enum_R16_UNorm,
		                                             FilterMode__Enum_Bilinear,
		                                             TextureWrapMode__Enum_Clamp,
		                                             TextureDimension__Enum_Tex2DArray,
		                                             1,
		                                             0,
		                                             0,
		                                             0,
		                                             1,
		                                             0.0,
		                                             MSAASamples__Enum_None,
		                                             0,
		                                             RenderTextureMemoryless__Enum_None,
		                                             (String *)"TerrainGroundLayerWetRT",
		                                             0LL);
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_groundLayerHeightRT,
		        v12,
		        v13,
		        v14,
		        colorFormatd,
		        filterModed,
		        wrapModed,
		        dimensiond,
		        enableRandomWrited,
		        useMipMapd,
		        autoGenerateMipsd,
		        isShadowMapd,
		        anisoLeveld);
		    }
		    if ( !this->fields.m_defaultRT )
		    {
		      blackTexture = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		      this->fields.m_defaultRT = UnityEngine::Rendering::RTHandleSystem::Alloc(blackTexture, 0LL);
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_defaultRT,
		        v16,
		        v17,
		        v18,
		        colorFormat,
		        filterMode,
		        wrapMode,
		        dimension,
		        enableRandomWrite,
		        useMipMap,
		        autoGenerateMips,
		        isShadowMap,
		        anisoLevel);
		    }
		  }
		}
		
		public void Initialize() {} // 0x0000000182ED8170-0x0000000182ED8280
		// Void Initialize()
		void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::Initialize(
		        HGTerrainGroundLayer *this,
		        MethodInfo *method)
		{
		  float v3; // xmm6_4
		  __int64 v4; // rbx
		  HGTerrainGroundLayerClipmap__Array *clipmaps; // rsi
		  __int64 v6; // rax
		  __int64 v7; // rdx
		  HGTerrainGroundLayerClipmap__Array *v8; // rcx
		  __int64 v9; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5457, 0LL) )
		  {
		    v3 = 15.0;
		    v4 = 0LL;
		    while ( 1 )
		    {
		      clipmaps = this->fields.clipmaps;
		      v6 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap);
		      v9 = v6;
		      if ( !v6 )
		        break;
		      *(_DWORD *)(v6 + 28) = 1092616192;
		      *(_QWORD *)(v6 + 16) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		      *(_DWORD *)(v6 + 24) = 0;
		      if ( !clipmaps )
		        break;
		      sub_180031B10(clipmaps, v6);
		      sub_1800020D0(clipmaps, (unsigned int)v4, v9);
		      v8 = this->fields.clipmaps;
		      if ( !v8 )
		        break;
		      if ( (unsigned int)v4 >= v8->max_length.size )
		        sub_1800D2AB0(v8, v7);
		      v8 = (HGTerrainGroundLayerClipmap__Array *)v8->vector[v4];
		      if ( !v8 )
		        break;
		      HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::Initialize(
		        (HGTerrainGroundLayerClipmap *)v8,
		        v3,
		        v4,
		        0LL);
		      v4 = (unsigned int)(v4 + 1);
		      v3 = v3 * 5.0;
		      if ( (unsigned int)v4 >= 2 )
		        return;
		    }
		LABEL_4:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5457, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void Release() {} // 0x0000000189C79D48-0x0000000189C79E88
		public void GetTerrainDeformParams(ref ShaderVariablesGlobal cb) {} // 0x0000000189C79990-0x0000000189C79A60
		// Void GetTerrainDeformParams(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::GetTerrainDeformParams(
		        HGTerrainGroundLayer *this,
		        ShaderVariablesGlobal *cb,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  int v6; // ebx
		  char *i; // rdi
		  HGTerrainGroundLayerClipmap__Array *clipmaps; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 params0; // [rsp+20h] [rbp-20h] BYREF
		  Vector4 params1; // [rsp+30h] [rbp-10h] BYREF
		
		  params0 = 0LL;
		  params1 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3411, 0LL) )
		  {
		    v6 = 0;
		    for ( i = (char *)&cb[1]._ScreenSize.y; ; i += 16 )
		    {
		      clipmaps = this->fields.clipmaps;
		      if ( !clipmaps )
		        break;
		      if ( (unsigned int)v6 >= clipmaps->max_length.size )
		        sub_1800D2AB0(clipmaps, v5);
		      clipmaps = (HGTerrainGroundLayerClipmap__Array *)clipmaps->vector[v6];
		      if ( !clipmaps )
		        break;
		      HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::GetTerrainDeformParams(
		        (HGTerrainGroundLayerClipmap *)clipmaps,
		        &params0,
		        &params1,
		        0LL);
		      ++v6;
		      *(Vector4 *)(i - 4) = params0;
		      *(Vector4 *)(i + 28) = params1;
		      if ( v6 >= 2 )
		        return;
		    }
		LABEL_10:
		    sub_1800D8260(clipmaps, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3411, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, cb, 0LL);
		}
		
		public void SetPlayerCenter(Vector3 position) {} // 0x0000000183339CF0-0x0000000183339D80
		// Void SetPlayerCenter(Vector3)
		void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::SetPlayerCenter(
		        HGTerrainGroundLayer *this,
		        Vector3 *position,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  HGTerrainGroundLayerClipmap__Array *clipmaps; // rbx
		  int32_t v8; // edi
		  float v9; // eax
		  float z; // eax
		  Vector3 v11[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4052, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4052, 0LL);
		    if ( Patch )
		    {
		      z = position->z;
		      *(_QWORD *)&v11[0].x = *(_QWORD *)&position->x;
		      v11[0].z = z;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_370(Patch, (Object *)this, v11, 0LL);
		      return;
		    }
		LABEL_8:
		    sub_1800D8260(Patch, v5);
		  }
		  clipmaps = this->fields.clipmaps;
		  v8 = 0;
		  if ( !clipmaps )
		    goto LABEL_8;
		  while ( v8 < clipmaps->max_length.size )
		  {
		    if ( (unsigned int)v8 >= clipmaps->max_length.size )
		      sub_1800D2AB0(Patch, v5);
		    Patch = (ILFixDynamicMethodWrapper_2 *)clipmaps->vector[v8];
		    if ( !Patch )
		      goto LABEL_8;
		    v9 = position->z;
		    *(_QWORD *)&v11[0].x = *(_QWORD *)&position->x;
		    v11[0].z = v9;
		    HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::SetPlayerCenter(
		      (HGTerrainGroundLayerClipmap *)Patch,
		      v11,
		      0LL);
		    ++v8;
		  }
		}
		
		public void Render(HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189C79E88-0x0000000189C79FF4
		// Void Render(HGRenderGraph, HGCamera)
		void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::Render(
		        HGTerrainGroundLayer *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v7; // rdx
		  VolumetricRenderer_VolumetricBounds *v8; // r8
		  Int32__Array **v9; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v10; // rdx
		  VolumetricRenderer_VolumetricBounds *v11; // r8
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v12; // rdx
		  VolumetricRenderer_VolumetricBounds *v13; // r8
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v14; // rdx
		  VolumetricRenderer_VolumetricBounds *v15; // r8
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v16; // rdx
		  VolumetricRenderer_VolumetricBounds *v17; // r8
		  __int64 v18; // rdx
		  __int128 v19; // xmm6
		  unsigned int v20; // ebx
		  __int128 v21; // xmm7
		  MeshFilter *v22; // xmm8_8
		  HGTerrainGroundLayerClipmap__Array *clipmaps; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v25; // [rsp+28h] [rbp-49h]
		  MethodInfo *v26; // [rsp+28h] [rbp-49h]
		  MethodInfo *v27; // [rsp+28h] [rbp-49h]
		  MethodInfo *v28; // [rsp+28h] [rbp-49h]
		  MethodInfo *v29; // [rsp+28h] [rbp-49h]
		  MethodInfo *v30; // [rsp+30h] [rbp-41h]
		  MethodInfo *v31; // [rsp+30h] [rbp-41h]
		  MethodInfo *v32; // [rsp+30h] [rbp-41h]
		  MethodInfo *v33; // [rsp+30h] [rbp-41h]
		  MethodInfo *v34; // [rsp+30h] [rbp-41h]
		  VolumetricRenderer_VolumetricRenderItem v35; // [rsp+38h] [rbp-39h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3421, 0LL) )
		  {
		    HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::InitializeRenderTextureResources(this, 0LL);
		    v35.Callback = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)this->fields.m_groundLayerBaseRT;
		    memset(&v35.material, 0, 32);
		    ((void (__stdcall *)(VolumetricRenderer_VolumetricRenderItem *, Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *, VolumetricRenderer_VolumetricBounds *, Int32__Array **, MethodInfo *, MethodInfo *))sub_18002D1B0)(
		      &v35,
		      v7,
		      v8,
		      v9,
		      v25,
		      v30);
		    v35.material = (Material *)this->fields.m_groundLayerNormalRT;
		    ((void (__stdcall *)(VolumetricRenderer_VolumetricRenderItem *, Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *, VolumetricRenderer_VolumetricBounds *, Int32__Array **, MethodInfo *, MethodInfo *, int32_t))sub_18002D1B0)(
		      (VolumetricRenderer_VolumetricRenderItem *)&v35.material,
		      v10,
		      v11,
		      (Int32__Array **)v35.material,
		      v26,
		      v31,
		      (int32_t)v35.Callback);
		    *(_QWORD *)&v35.bounds.enableBounds = this->fields.m_groundLayerWetRT;
		    ((void (__stdcall *)(VolumetricRenderer_VolumetricRenderItem *, Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *, VolumetricRenderer_VolumetricBounds *, Int32__Array **, MethodInfo *, MethodInfo *, int32_t, int32_t))sub_18002D1B0)(
		      (VolumetricRenderer_VolumetricRenderItem *)&v35.bounds,
		      v12,
		      v13,
		      *(Int32__Array ***)&v35.bounds.enableBounds,
		      v27,
		      v32,
		      (int32_t)v35.Callback,
		      (int32_t)v35.material);
		    *(_QWORD *)&v35.bounds.worldBounds.m_Center.y = this->fields.m_groundLayerHeightRT;
		    ((void (__stdcall *)(VolumetricRenderer_VolumetricRenderItem *, Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *, VolumetricRenderer_VolumetricBounds *, Int32__Array **, MethodInfo *, MethodInfo *, int32_t, int32_t, float))sub_18002D1B0)(
		      (VolumetricRenderer_VolumetricRenderItem *)&v35.bounds.worldBounds.m_Center.y,
		      v14,
		      v15,
		      *(Int32__Array ***)&v35.bounds.worldBounds.m_Center.y,
		      v28,
		      v33,
		      (int32_t)v35.Callback,
		      (int32_t)v35.material,
		      *(float *)&v35.bounds.enableBounds);
		    *(_QWORD *)&v35.bounds.worldBounds.m_Extents.x = this->fields.m_defaultRT;
		    ((void (__stdcall *)(VolumetricRenderer_VolumetricRenderItem *, Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *, VolumetricRenderer_VolumetricBounds *, Int32__Array **, MethodInfo *, MethodInfo *, int32_t, int32_t, float, int32_t))sub_18002D1B0)(
		      (VolumetricRenderer_VolumetricRenderItem *)&v35.bounds.worldBounds.m_Extents,
		      v16,
		      v17,
		      *(Int32__Array ***)&v35.bounds.worldBounds.m_Extents.x,
		      v29,
		      v34,
		      (int32_t)v35.Callback,
		      (int32_t)v35.material,
		      *(float *)&v35.bounds.enableBounds,
		      SLODWORD(v35.bounds.worldBounds.m_Center.y));
		    v19 = *(_OWORD *)&v35.Callback;
		    v20 = 0;
		    v21 = *(_OWORD *)&v35.bounds.enableBounds;
		    v22 = *(MeshFilter **)&v35.bounds.worldBounds.m_Extents.x;
		    while ( 1 )
		    {
		      clipmaps = this->fields.clipmaps;
		      if ( !clipmaps )
		        break;
		      if ( v20 >= clipmaps->max_length.size )
		        sub_1800D2AB0(clipmaps, v18);
		      clipmaps = (HGTerrainGroundLayerClipmap__Array *)clipmaps->vector[v20];
		      if ( !clipmaps )
		        break;
		      *(_OWORD *)&v35.SortingOrder = v19;
		      *(_OWORD *)&v35.bPureBlit = v21;
		      v35.meshFilter = v22;
		      HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::Render(
		        (HGTerrainGroundLayerClipmap *)clipmaps,
		        renderGraph,
		        hgCamera,
		        (GroundLayerRTs *)&v35.SortingOrder,
		        0LL);
		      if ( (int)++v20 >= 2 )
		        return;
		    }
		LABEL_10:
		    sub_1800D8260(clipmaps, v18);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3421, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)this,
		    (Object *)renderGraph,
		    (Object *)hgCamera,
		    0LL);
		}
		
	}
}
