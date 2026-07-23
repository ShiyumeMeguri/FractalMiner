using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VirtualTextureRenderer : IDisposable // TypeDefIndex: 38644
	{
		// Fields
		private const int VT_CLIPMAP_BASE_WIDTH = 8; // Metadata: 0x02304036
		private const int VT_CACHE_PAGE_RESOLUTION = 256; // Metadata: 0x02304037
		private const int VT_CACHE_PAGE_BUFFER_SIDE_SIZE = 64; // Metadata: 0x02304039
		private const int VT_CACHE_PAGE_BUFFER_SIZE = 4096; // Metadata: 0x0230403B
		private const int VT_INDIRECT_TEX_BUFFER_COUNT = 3; // Metadata: 0x0230403D
		private const int VT_GPU_FEEDBACK_BUFFER_COUNT = 4; // Metadata: 0x0230403E
		private const float VT_CPU_FEEDBACK_RAYCAST_DIST = 1000f; // Metadata: 0x0230403F
		public const int VT_WORK_GROUP_COUNT = 32; // Metadata: 0x02304043
		public const int VT_COMPRESS_LOCAL_THREAD_COUNT = 16; // Metadata: 0x02304044
		private readonly HGTerrainConfiguration m_configuration; // 0x10
		private readonly Texture2D m_splatIndexMap; // 0x18
		private readonly Texture2D m_splatControlMap; // 0x20
		private readonly Texture2DArray m_splatsDiffuseArray; // 0x28
		private readonly Texture2DArray m_splatsNormalArray; // 0x30
		private readonly Texture2D m_terrainNormalMap; // 0x38
		private readonly Texture2D m_colorVariationTex; // 0x40
		private readonly Texture2D m_terrainHeightmap; // 0x48
		private readonly Texture2D m_deformableControlMap; // 0x50
		private readonly Dictionary<uint, int[]> m_decalNodeLut; // 0x58
		private readonly Dictionary<uint, ulong[]> m_decalBlockMaskLut; // 0x60
		private readonly HGTerrainRuntimeResources.DecalPerInstanceData[] m_decalInstanceData; // 0x68
		private readonly ComputeShader m_vtBakeCS; // 0x70
		private readonly ComputeShader m_vtCompressCS; // 0x78
		private readonly TerrainCollider m_collider; // 0x80
		private readonly int m_vtBakeMainKernel; // 0x88
		private readonly int m_vtCompressMainKernel; // 0x8C
		private uint m_frameCount; // 0x90
		private readonly LRUCache m_lruCache; // 0x98
		private readonly Dictionary<uint, int> m_nodeCacheLut; // 0xA0
		private readonly List<GlobalUV> m_globalUVs; // 0xA8
		private readonly List<uint> m_renderQueue; // 0xB0
		private NativeArray<HGTerrainUtils.Vector2Short> m_feedbackJitterSeq; // 0xC0
		private RenderTexture m_physicalBaseRt; // 0xD0
		private RenderTexture m_physicalNormRt; // 0xD8
		private Texture2DArray m_physicalBaseTex; // 0xE0
		private Texture2DArray m_physicalNormTex; // 0xE8
		private RenderTexture m_pageRt; // 0xF0
		private ComputeBuffer m_pageBuffer; // 0xF8
		private readonly Texture2DArray m_decalDiffuseTexArray; // 0x100
		private readonly Texture2DArray m_decalNormalMROTexArray; // 0x108
		private readonly Texture2D[] m_indirectTextures; // 0x110
		private ComputeBuffer[] m_gpuFeedbackBuffers; // 0x118
		private NativeArray<uint>[] m_gpuFeedbackData; // 0x120
		private AsyncGPUReadbackRequest[] m_gpuFeedbackRequests; // 0x128
		private readonly bool[] m_gpuFeedbackBufferFilled; // 0x130
		private RTHandle m_gpuFeedbackDepth; // 0x138
		private RTHandle m_gpuFeedbackColor; // 0x140
		private AttachmentDescriptor m_gpuFeedbackColorDesc; // 0x148
		private AttachmentDescriptor m_gpuFeedbackDepthDesc; // 0x1C0
		private NativeArray<int> m_cpuJitterOffsets; // 0x238
		private readonly Vector3 m_heightmapScale; // 0x248
		private readonly Vector2Int m_terrainSize; // 0x254
		private readonly Vector4 m_lightmapScaleOffset; // 0x25C
		private readonly Vector3 m_terrainPos; // 0x26C
		private readonly int m_decalMaxLevel; // 0x278
		private readonly Vector4[] m_decalInstanceInfo; // 0x280
		private readonly bool m_enableCompression; // 0x288
		private readonly LocalKeyword m_enableCompressKeywordCS; // 0x290
		private readonly LocalKeyword m_enableTerrainDecalCS; // 0x2A8
		private readonly int m_virtualTextureResolution; // 0x2C4
		private readonly float m_vtBaseMipBias; // 0x2C8
		private int m_cacheSliceWidth; // 0x2CC
		private int m_cacheSliceHeight; // 0x2D0
		private int m_cacheSliceCount; // 0x2D4
		private int m_indirectOffset; // 0x2D8
		private readonly int m_indirectMaxOffset; // 0x2DC
		private int m_blockWidth; // 0x2E0
		private int m_blockHeight; // 0x2E4
		private int m_cacheColNumPerSlice; // 0x2E8
		private int m_cacheRowNumPerSlice; // 0x2EC
		private int m_cachePageCountPerSlice; // 0x2F0
		private int m_cachePageCountTotal; // 0x2F4
		private readonly Vector2 m_virtualToTerrain; // 0x2F8
		private readonly Vector2 m_worldToVirtual; // 0x308
		private readonly Vector2 m_terrainPosOffset; // 0x310
		private readonly int m_indirectMaxLevel; // 0x318
		private readonly int m_indirectBaseLevel; // 0x31C
		private readonly int m_indirectMaxWidth; // 0x320
		private readonly int m_indirectMaxHeight; // 0x324
		private readonly int m_indirectMaxArea; // 0x328
		private int m_indirectWidth; // 0x32C
		private int m_indirectHalfWidth; // 0x330
		private int m_indirectLevel; // 0x334
		private int m_feedbackWidth; // 0x338
		private int m_feedbackHeight; // 0x33C
		private Vector2Int m_compressCSGroupSize; // 0x340
		private bool m_needVTTexturesSetup; // 0x34C
		private bool m_needVTDataBufferSetup; // 0x34D
	
		// Properties
		public ComputeBuffer terrainBakeDataBuffer { get; } // 0x0000000184D85EF0-0x0000000184D85F00 
		// ValueInput`1[UnityEngine.Vector4] get_port()
		ValueInput_1_UnityEngine_Vector4_ *FlowCanvas::Nodes::RelayValueInput<UnityEngine::Vector4>::get_port(
		        RelayValueInput_1_UnityEngine_Vector4_ *this,
		        MethodInfo *method)
		{
		  return this->fields._port_k__BackingField;
		}
		
		public Texture deformableControlMap { get => default; } // 0x0000000189C2A540-0x0000000189C2A590 
		// Texture get_deformableControlMap()
		Texture *HG::Rendering::Runtime::VirtualTextureRenderer::get_deformableControlMap(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4014, 0LL) )
		    return (Texture *)this->fields.m_deformableControlMap;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4014, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_180(Patch, (Object *)this, 0LL);
		}
		
		public Texture2D currIndirectTexture { get => default; } // 0x0000000189C2A4C0-0x0000000189C2A540 
		// Texture2D get_currIndirectTexture()
		Texture2D *HG::Rendering::Runtime::VirtualTextureRenderer::get_currIndirectTexture(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Texture2D__Array *m_indirectTextures; // r8
		  __int64 m_frameCount; // rcx
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4000, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4000, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_402(Patch, (Object *)this, 0LL);
		LABEL_7:
		    sub_1800D8260(m_frameCount, v3);
		  }
		  m_indirectTextures = this->fields.m_indirectTextures;
		  m_frameCount = this->fields.m_frameCount;
		  if ( !m_indirectTextures )
		    goto LABEL_7;
		  v6 = (unsigned int)m_frameCount / 3;
		  v7 = (unsigned int)m_frameCount % 3;
		  if ( (unsigned int)v7 >= m_indirectTextures->max_length.size )
		    sub_1800D2AB0(v7, v6);
		  return m_indirectTextures->vector[(int)v7];
		}
		
		public ref AttachmentDescriptor gpuFeedbackDepthDesc { get => default; } // 0x0000000189C2A5E0-0x0000000189C2A630 
		// AttachmentDescriptor& get_gpuFeedbackDepthDesc()
		AttachmentDescriptor *HG::Rendering::Runtime::VirtualTextureRenderer::get_gpuFeedbackDepthDesc(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4020, 0LL) )
		    return &this->fields.m_gpuFeedbackDepthDesc;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4020, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1414(Patch, (Object *)this, 0LL);
		}
		
		public ref AttachmentDescriptor gpuFeedbackColorDesc { get => default; } // 0x0000000189C2A590-0x0000000189C2A5E0 
		// AttachmentDescriptor& get_gpuFeedbackColorDesc()
		AttachmentDescriptor *HG::Rendering::Runtime::VirtualTextureRenderer::get_gpuFeedbackColorDesc(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4019, 0LL) )
		    return &this->fields.m_gpuFeedbackColorDesc;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4019, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1414(Patch, (Object *)this, 0LL);
		}
		
		public ComputeBuffer currGPUFeedbackBuffer { get => default; } // 0x0000000189C2A318-0x0000000189C2A388 
		// ComputeBuffer get_currGPUFeedbackBuffer()
		ComputeBuffer *HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackBuffer(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rcx
		  ComputeBuffer__Array *m_gpuFeedbackBuffers; // rdx
		  __int64 v5; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3988, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3988, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_506(Patch, (Object *)this, 0LL);
		LABEL_7:
		    sub_1800D8260(v3, m_gpuFeedbackBuffers);
		  }
		  m_gpuFeedbackBuffers = this->fields.m_gpuFeedbackBuffers;
		  if ( !m_gpuFeedbackBuffers )
		    goto LABEL_7;
		  v5 = this->fields.m_frameCount & 3;
		  if ( (unsigned int)v5 >= m_gpuFeedbackBuffers->max_length.size )
		    sub_1800D2AB0(v3, m_gpuFeedbackBuffers);
		  return m_gpuFeedbackBuffers->vector[v5];
		}
		
		public ref NativeArray<uint> currGPUFeedbackData { get => default; } // 0x0000000189C2A388-0x0000000189C2A3FC 
		// NativeArray`1[System.UInt32]& get_currGPUFeedbackData()
		NativeArray_1_System_UInt32_ *HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackData(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rcx
		  NativeArray_1_System_UInt32___Array *m_gpuFeedbackData; // rdx
		  __int64 v5; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3987, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3987, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1403(Patch, (Object *)this, 0LL);
		LABEL_7:
		    sub_1800D8260(v3, m_gpuFeedbackData);
		  }
		  m_gpuFeedbackData = this->fields.m_gpuFeedbackData;
		  if ( !m_gpuFeedbackData )
		    goto LABEL_7;
		  v5 = this->fields.m_frameCount & 3;
		  if ( (unsigned int)v5 >= m_gpuFeedbackData->max_length.size )
		    sub_1800D2AB0(v3, m_gpuFeedbackData);
		  return &m_gpuFeedbackData->vector[v5];
		}
		
		public ref AsyncGPUReadbackRequest currGPUFeedbackRequest { get => default; } // 0x0000000189C2A44C-0x0000000189C2A4C0 
		// AsyncGPUReadbackRequest& get_currGPUFeedbackRequest()
		AsyncGPUReadbackRequest *HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackRequest(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rcx
		  AsyncGPUReadbackRequest__Array *m_gpuFeedbackRequests; // rdx
		  __int64 v5; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3986, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3986, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1402(Patch, (Object *)this, 0LL);
		LABEL_7:
		    sub_1800D8260(v3, m_gpuFeedbackRequests);
		  }
		  m_gpuFeedbackRequests = this->fields.m_gpuFeedbackRequests;
		  if ( !m_gpuFeedbackRequests )
		    goto LABEL_7;
		  v5 = this->fields.m_frameCount & 3;
		  if ( (unsigned int)v5 >= m_gpuFeedbackRequests->max_length.size )
		    sub_1800D2AB0(v3, m_gpuFeedbackRequests);
		  return &m_gpuFeedbackRequests->vector[v5];
		}
		
		public bool currGPUFeedbackBufferFilled { get => default; } // 0x0000000189C2A2A4-0x0000000189C2A318 
		// Boolean get_currGPUFeedbackBufferFilled()
		bool HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackBufferFilled(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rcx
		  Boolean__Array *m_gpuFeedbackBufferFilled; // rdx
		  __int64 v5; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3985, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3985, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		LABEL_7:
		    sub_1800D8260(v3, m_gpuFeedbackBufferFilled);
		  }
		  m_gpuFeedbackBufferFilled = this->fields.m_gpuFeedbackBufferFilled;
		  if ( !m_gpuFeedbackBufferFilled )
		    goto LABEL_7;
		  v5 = this->fields.m_frameCount & 3;
		  if ( (unsigned int)v5 >= m_gpuFeedbackBufferFilled->max_length.size )
		    sub_1800D2AB0(v3, m_gpuFeedbackBufferFilled);
		  return m_gpuFeedbackBufferFilled->vector[v5];
		}
		
		public RTHandle currGPUFeedbackDepth { get => default; } // 0x0000000189C2A3FC-0x0000000189C2A44C 
		// RTHandle get_currGPUFeedbackDepth()
		RTHandle *HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackDepth(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4018, 0LL) )
		    return this->fields.m_gpuFeedbackDepth;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4018, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_128(Patch, (Object *)this, 0LL);
		}
		
		public HGTerrainConfiguration.VTFeedbackMode feedbackMode { get; } // 0x0000000184DA1D70-0x0000000184DA1D80 
		// Int32 get_containedPointerIds()
		int32_t UnityEngine::UIElements::VisualElement::get_containedPointerIds(VisualElement *this, MethodInfo *method)
		{
		  return this->fields._containedPointerIds_k__BackingField;
		}
		
		public Vector2 terrainToVirtual { get; } // 0x0000000184DA1D80-0x0000000184DA1DA0 
		// Vector2 get_terrainToVirtual()
		Vector2 HG::Rendering::Runtime::VirtualTextureRenderer::get_terrainToVirtual(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  return (Vector2)_mm_unpacklo_ps(
		                    (__m128)LODWORD(this->fields._terrainToVirtual_k__BackingField.x),
		                    (__m128)LODWORD(this->fields._terrainToVirtual_k__BackingField.y)).m128_u64[0];
		}
		
		public int currFeedbackWidth { get => default; } // 0x0000000189C2A254-0x0000000189C2A2A4 
		// Int32 get_currFeedbackWidth()
		int32_t HG::Rendering::Runtime::VirtualTextureRenderer::get_currFeedbackWidth(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4021, 0LL) )
		    return this->fields.m_feedbackWidth;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4021, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public int vtMaxPagePerFrame { get; set; } // 0x0000000184DA1DA0-0x0000000184DA1DB0 0x0000000184DA1DC0-0x0000000184DA1DD0
		// Int32 get_vtMaxPagePerFrame()
		int32_t HG::Rendering::Runtime::VirtualTextureRenderer::get_vtMaxPagePerFrame(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  return this->fields._vtMaxPagePerFrame_k__BackingField;
		}
		

		// Void set_vtMaxPagePerFrame(Int32)
		void HG::Rendering::Runtime::VirtualTextureRenderer::set_vtMaxPagePerFrame(
		        VirtualTextureRenderer *this,
		        int32_t value,
		        MethodInfo *method)
		{
		  this->fields._vtMaxPagePerFrame_k__BackingField = value;
		}
		
		public Vector2 currentCenterPos { get; private set; } // 0x0000000184DA1D50-0x0000000184DA1D70 0x0000000184DA1DB0-0x0000000184DA1DC0
		// Vector2 get_currentCenterPos()
		Vector2 HG::Rendering::Runtime::VirtualTextureRenderer::get_currentCenterPos(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  return (Vector2)_mm_unpacklo_ps(
		                    (__m128)LODWORD(this->fields._currentCenterPos_k__BackingField.x),
		                    (__m128)LODWORD(this->fields._currentCenterPos_k__BackingField.y)).m128_u64[0];
		}
		

		// Void set_currentCenterPos(Vector2)
		void HG::Rendering::Runtime::VirtualTextureRenderer::set_currentCenterPos(
		        VirtualTextureRenderer *this,
		        Vector2 value,
		        MethodInfo *method)
		{
		  this->fields._currentCenterPos_k__BackingField = value;
		}
		
	
		// Nested types
		public struct GlobalUV // TypeDefIndex: 38643
		{
			// Fields
			public Vector2 current; // 0x00
			public Vector2 dUVdx; // 0x08
			public Vector2 dUVdy; // 0x10
		}
	
		// Constructors
		public VirtualTextureRenderer() {} // Dummy constructor
		public VirtualTextureRenderer([IsReadOnly] in TerrainResource terrainResource) {} // 0x0000000189C29324-0x0000000189C2A254
		// VirtualTextureRenderer(TerrainResource&)
		void HG::Rendering::Runtime::VirtualTextureRenderer::VirtualTextureRenderer(
		        VirtualTextureRenderer *this,
		        TerrainResource *terrainResource,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  HGTerrainRuntimeResources *runtimeResources; // rsi
		  __int64 v6; // r12
		  TerrainCollider *terrainCollider; // r9
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  unsigned __int64 m_splatIndexMap; // rdx
		  __int64 m_vtBakeCS; // rcx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  HGTerrainRuntimeResources_TextureResources *textures; // rax
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  HGTerrainRuntimeResources_TextureResources *v18; // rax
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  HGTerrainRuntimeResources_TextureResources *v21; // rax
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  HGTerrainRuntimeResources_TextureResources *v24; // rax
		  HGRuntimeGrassQuery_Node *v25; // r8
		  Int32__Array **v26; // r9
		  HGTerrainRuntimeResources_TextureResources *v27; // rax
		  HGRuntimeGrassQuery_Node *v28; // r8
		  Int32__Array **v29; // r9
		  HGTerrainRuntimeResources_TextureResources *v30; // rax
		  HGRuntimeGrassQuery_Node *v31; // r8
		  Int32__Array **v32; // r9
		  HGTerrainRuntimeResources_TextureResources *v33; // rax
		  HGRuntimeGrassQuery_Node *v34; // r8
		  Int32__Array **v35; // r9
		  HGTerrainRuntimeResources_TextureResources *v36; // rax
		  HGRuntimeGrassQuery_Node *v37; // r8
		  Int32__Array **v38; // r9
		  HGTerrainConfiguration *m_configuration; // rax
		  HGTerrainConfiguration *v40; // rax
		  bool v41; // al
		  HGTerrainConfiguration *v42; // rax
		  int32_t vtFeedbackMode; // eax
		  HGTerrainRuntimeResources_ShaderResources *shaders; // rax
		  int32_t Kernel; // eax
		  ComputeShader *v46; // rdx
		  __int64 v47; // xmm1_8
		  HGRuntimeGrassQuery_Node *v48; // rdx
		  HGRuntimeGrassQuery_Node *v49; // r8
		  Int32__Array **v50; // r9
		  ComputeShader *v51; // rdx
		  __int64 v52; // xmm1_8
		  HGRuntimeGrassQuery_Node *v53; // rdx
		  HGRuntimeGrassQuery_Node *v54; // r8
		  Int32__Array **v55; // r9
		  RuntimePlatform__Enum platform; // eax
		  HGRuntimeGrassQuery_Node *v57; // r8
		  Int32__Array **v58; // r9
		  __int64 v59; // rax
		  InvalidEnumArgumentException *v60; // rbx
		  String *v61; // rax
		  __int64 v62; // rax
		  HGTerrainRuntimeResources_ShaderResources *v63; // rax
		  ComputeShader *terrainBC3CompressCS; // rcx
		  HGTerrainRuntimeResources_ShaderResources *v65; // rax
		  float z; // eax
		  float v67; // eax
		  ComputeBuffer *v68; // rax
		  ComputeBuffer *v69; // rbx
		  HGRuntimeGrassQuery_Node *v70; // rdx
		  HGRuntimeGrassQuery_Node *v71; // r8
		  Int32__Array **v72; // r9
		  __int64 v73; // r9
		  Vector4__Array *packedSplatInfo; // rax
		  int v75; // ebx
		  Void *m_Buffer; // r15
		  Void *v77; // r14
		  __int64 v78; // r9
		  __int64 v79; // r9
		  __int64 v80; // r9
		  __int64 v81; // r9
		  int v82; // eax
		  int v83; // r14d
		  int v84; // eax
		  int v85; // ebx
		  int v86; // eax
		  int v87; // eax
		  int v88; // r14d
		  int v89; // eax
		  int v90; // ebx
		  int v91; // eax
		  int v92; // eax
		  int v93; // ebx
		  unsigned int v94; // eax
		  int v95; // ebx
		  int v96; // eax
		  int v97; // eax
		  float m_Y; // xmm1_4
		  __int128 v99; // xmm1
		  float y; // xmm2_4
		  HGTerrainConfiguration *v101; // rax
		  HGTerrainConfiguration *v102; // rax
		  int vtMinChunkSize; // r14d
		  int32_t vtCacheSliceWidth; // eax
		  int32_t v105; // r10d
		  int32_t v106; // r9d
		  int32_t v107; // eax
		  int32_t v108; // eax
		  int v109; // eax
		  int v110; // ebx
		  int v111; // eax
		  float v112; // xmm4_4
		  float v113; // xmm3_4
		  float v114; // xmm4_4
		  float v115; // xmm1_4
		  MethodInfo *v116; // rdx
		  float v117; // xmm4_4
		  __int64 v118; // rdx
		  __int64 v119; // rcx
		  __int64 v120; // r8
		  double v121; // xmm0_8
		  HGTerrainConfiguration *v122; // r8
		  int32_t v123; // r9d
		  int32_t vtClipmapBaseOffset; // r8d
		  int32_t v125; // ecx
		  int32_t v126; // edx
		  int32_t v127; // eax
		  LRUCache *v128; // rax
		  HGRuntimeGrassQuery_Node *v129; // r8
		  Int32__Array **v130; // r9
		  Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *v131; // rax
		  Dictionary_2_System_UInt32_System_Int32_ *v132; // rbx
		  HGRuntimeGrassQuery_Node *v133; // rdx
		  HGRuntimeGrassQuery_Node *v134; // r8
		  Int32__Array **v135; // r9
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v136; // rax
		  List_1_HG_Rendering_Runtime_VirtualTextureRenderer_GlobalUV_ *v137; // rbx
		  HGRuntimeGrassQuery_Node *v138; // rdx
		  HGRuntimeGrassQuery_Node *v139; // r8
		  Int32__Array **v140; // r9
		  LowLevelList_1_System_Object_ *v141; // rax
		  List_1_System_UInt32_ *v142; // rbx
		  HGRuntimeGrassQuery_Node *v143; // rdx
		  HGRuntimeGrassQuery_Node *v144; // r8
		  Int32__Array **v145; // r9
		  HGRuntimeGrassQuery_Node *v146; // rdx
		  HGRuntimeGrassQuery_Node *v147; // r8
		  Int32__Array **v148; // r9
		  int32_t i; // r14d
		  Texture2D__Array *m_indirectTextures; // rax
		  Texture2D__Array *v151; // r15
		  int32_t m_indirectMaxWidth; // r12d
		  Texture2D *v153; // rax
		  Texture *v154; // rbx
		  HGRuntimeGrassQuery_Node *v155; // rdx
		  HGRuntimeGrassQuery_Node *v156; // r8
		  Int32__Array **v157; // r9
		  Texture2DArray *decalNormalMROTexArray; // r9
		  HGRuntimeGrassQuery_Node *v159; // rdx
		  HGRuntimeGrassQuery_Node *v160; // r8
		  int32_t m_indirectMaxLevel; // ebx
		  HGRuntimeGrassQuery_Node *v162; // rdx
		  HGRuntimeGrassQuery_Node *v163; // r8
		  Int32__Array **v164; // r9
		  HGTerrainRuntimeResources_DecalPerInstanceData__Array *instanceData; // rax
		  UInt32__Array *decalNodeKeys; // r14
		  HGTerrainRuntimeResources_DecalIndices__Array *decalIndicesValues; // r15
		  Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *v168; // rax
		  Dictionary_2_System_UInt32_System_Int32__2 *v169; // rbx
		  HGRuntimeGrassQuery_Node *v170; // rdx
		  HGRuntimeGrassQuery_Node *v171; // r8
		  Int32__Array **v172; // r9
		  unsigned int v173; // ebx
		  UInt32__Array *blockNodeKeys; // rax
		  UInt32__Array *v175; // r14
		  HGTerrainRuntimeResources_BlockMasks__Array *blockMasksValues; // rsi
		  Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *v177; // rax
		  Dictionary_2_System_UInt32_System_UInt64__1 *v178; // rbx
		  HGRuntimeGrassQuery_Node *v179; // rdx
		  HGRuntimeGrassQuery_Node *v180; // r8
		  Int32__Array **v181; // r9
		  unsigned int j; // ebx
		  HGRuntimeGrassQuery_Node *v183; // rdx
		  HGRuntimeGrassQuery_Node *v184; // r8
		  Int32__Array **v185; // r9
		  HGRuntimeGrassQuery_Node *v186; // rdx
		  HGRuntimeGrassQuery_Node *v187; // r8
		  Int32__Array **v188; // r9
		  MethodInfo *methoda; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodu; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodb; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodc; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodd; // [rsp+28h] [rbp-69h]
		  MethodInfo *methode; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodf; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodg; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodh; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodi; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodj; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodk; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodv; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodl; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodw; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodm; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodn; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodo; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodp; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodx; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodq; // [rsp+28h] [rbp-69h]
		  MethodInfo *methody; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodr; // [rsp+28h] [rbp-69h]
		  MethodInfo *methods; // [rsp+28h] [rbp-69h]
		  MethodInfo *methodt; // [rsp+28h] [rbp-69h]
		  NativeArray_1_UnityEngine_Vector4_ v214; // [rsp+38h] [rbp-59h] BYREF
		  __int128 v215; // [rsp+48h] [rbp-49h] BYREF
		  __int128 v216; // [rsp+58h] [rbp-39h] BYREF
		  __int128 v217; // [rsp+68h] [rbp-29h] BYREF
		  LocalKeyword v218; // [rsp+78h] [rbp-19h] BYREF
		  LocalKeyword v219; // [rsp+98h] [rbp+7h] BYREF
		  __int64 height; // [rsp+F8h] [rbp+67h]
		  Vector2 heightb; // [rsp+F8h] [rbp+67h]
		  int32_t heighta; // [rsp+F8h] [rbp+67h]
		
		  *(_WORD *)&this->fields.m_needVTTexturesSetup = 257;
		  runtimeResources = terrainResource->runtimeResources;
		  v6 = 0LL;
		  this->fields.m_configuration = terrainResource->configuration;
		  this->fields.m_frameCount = 0;
		  v214 = 0LL;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields,
		    (HGRuntimeGrassQuery_Node *)terrainResource,
		    (HGRuntimeGrassQuery_Node *)method,
		    v3,
		    methoda);
		  terrainCollider = terrainResource->terrainCollider;
		  this->fields.m_collider = terrainCollider;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_collider,
		    v9,
		    v10,
		    (Int32__Array **)terrainCollider,
		    methodu);
		  if ( !runtimeResources )
		    goto LABEL_111;
		  textures = runtimeResources->fields.textures;
		  if ( !textures )
		    goto LABEL_111;
		  this->fields.m_splatIndexMap = textures->fields.splatIndexMap;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_splatIndexMap,
		    (HGRuntimeGrassQuery_Node *)m_splatIndexMap,
		    v13,
		    v14,
		    methodb);
		  v18 = runtimeResources->fields.textures;
		  if ( !v18 )
		    goto LABEL_111;
		  this->fields.m_splatControlMap = v18->fields.splatControlMap;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_splatControlMap,
		    (HGRuntimeGrassQuery_Node *)m_splatIndexMap,
		    v16,
		    v17,
		    methodc);
		  v21 = runtimeResources->fields.textures;
		  if ( !v21 )
		    goto LABEL_111;
		  this->fields.m_splatsDiffuseArray = v21->fields.terrainLayerDiffuseArray;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_splatsDiffuseArray,
		    (HGRuntimeGrassQuery_Node *)m_splatIndexMap,
		    v19,
		    v20,
		    methodd);
		  v24 = runtimeResources->fields.textures;
		  if ( !v24 )
		    goto LABEL_111;
		  this->fields.m_splatsNormalArray = v24->fields.terrainLayerNormalArray;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_splatsNormalArray,
		    (HGRuntimeGrassQuery_Node *)m_splatIndexMap,
		    v22,
		    v23,
		    methode);
		  v27 = runtimeResources->fields.textures;
		  if ( !v27 )
		    goto LABEL_111;
		  this->fields.m_terrainNormalMap = v27->fields.normalmap;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_terrainNormalMap,
		    (HGRuntimeGrassQuery_Node *)m_splatIndexMap,
		    v25,
		    v26,
		    methodf);
		  v30 = runtimeResources->fields.textures;
		  if ( !v30 )
		    goto LABEL_111;
		  this->fields.m_colorVariationTex = v30->fields.colorVariationTex;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_colorVariationTex,
		    (HGRuntimeGrassQuery_Node *)m_splatIndexMap,
		    v28,
		    v29,
		    methodg);
		  v33 = runtimeResources->fields.textures;
		  if ( !v33 )
		    goto LABEL_111;
		  this->fields.m_terrainHeightmap = v33->fields.heightmap;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_terrainHeightmap,
		    (HGRuntimeGrassQuery_Node *)m_splatIndexMap,
		    v31,
		    v32,
		    methodh);
		  v36 = runtimeResources->fields.textures;
		  if ( !v36 )
		    goto LABEL_111;
		  this->fields.m_deformableControlMap = v36->fields.deformableControlMap;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_deformableControlMap,
		    (HGRuntimeGrassQuery_Node *)m_splatIndexMap,
		    v34,
		    v35,
		    methodi);
		  m_configuration = this->fields.m_configuration;
		  if ( !m_configuration )
		    goto LABEL_111;
		  this->fields._vtMaxPagePerFrame_k__BackingField = m_configuration->fields.vtMaxPagePerFrame;
		  v40 = this->fields.m_configuration;
		  if ( !v40 )
		    goto LABEL_111;
		  if ( v40->fields.vtEnableCompression )
		  {
		    v41 = 1;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
		    v41 = HG::Rendering::Runtime::HGTerrainUtils::ForceUsingCompression(0LL);
		  }
		  this->fields.m_enableCompression = v41;
		  if ( v41 )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
		    if ( !HG::Rendering::Runtime::HGTerrainUtils::SupportBufferToImageCopy(0LL) )
		      this->fields.m_enableCompression = 0;
		  }
		  v42 = this->fields.m_configuration;
		  if ( !v42 )
		    goto LABEL_111;
		  vtFeedbackMode = v42->fields.vtFeedbackMode;
		  this->fields._feedbackMode_k__BackingField = vtFeedbackMode;
		  if ( vtFeedbackMode == 1 )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
		    if ( !HG::Rendering::Runtime::HGTerrainUtils::SupportSSBOWriteInGraphicShader(0LL) )
		      this->fields._feedbackMode_k__BackingField = 0;
		  }
		  shaders = runtimeResources->fields.shaders;
		  if ( !shaders
		    || (this->fields.m_vtBakeCS = shaders->fields.terrainVTBakeCS,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&this->fields.m_vtBakeCS,
		          (HGRuntimeGrassQuery_Node *)m_splatIndexMap,
		          v37,
		          v38,
		          methodj),
		        (m_vtBakeCS = (__int64)this->fields.m_vtBakeCS) == 0) )
		  {
		    sub_1800D8260(m_vtBakeCS, m_splatIndexMap);
		  }
		  Kernel = UnityEngine::ComputeShader::FindKernel((ComputeShader *)m_vtBakeCS, (String *)"KMain", 0LL);
		  v46 = this->fields.m_vtBakeCS;
		  this->fields.m_vtBakeMainKernel = Kernel;
		  memset(&v219, 0, sizeof(v219));
		  UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v219, v46, (String *)"_VT_COMPRESSION", 0LL);
		  v47 = *(_QWORD *)&v219.m_Index;
		  *(_OWORD *)&this->fields.m_enableCompressKeywordCS.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v219.m_SpaceInfo.m_KeywordSpace;
		  *(_QWORD *)&this->fields.m_enableCompressKeywordCS.m_Index = v47;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_enableCompressKeywordCS.m_Name, v48, v49, v50, methodk);
		  v51 = this->fields.m_vtBakeCS;
		  memset(&v218, 0, sizeof(v218));
		  UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v218, v51, (String *)"_VT_TERRAIN_DECAL", 0LL);
		  v52 = *(_QWORD *)&v218.m_Index;
		  *(_OWORD *)&this->fields.m_enableTerrainDecalCS.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v218.m_SpaceInfo.m_KeywordSpace;
		  *(_QWORD *)&this->fields.m_enableTerrainDecalCS.m_Index = v52;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_enableTerrainDecalCS.m_Name, v53, v54, v55, methodv);
		  if ( this->fields.m_enableCompression )
		  {
		    platform = UnityEngine::Application::get_platform(0LL);
		    m_splatIndexMap = (unsigned int)platform;
		    if ( platform )
		    {
		      m_splatIndexMap = (unsigned int)(platform - 1);
		      if ( platform != RuntimePlatform__Enum_OSXPlayer )
		      {
		        m_splatIndexMap = (unsigned int)(platform - 2);
		        if ( platform == RuntimePlatform__Enum_WindowsPlayer )
		          goto LABEL_37;
		        if ( platform == RuntimePlatform__Enum_OSXWebPlayer
		          || platform == RuntimePlatform__Enum_OSXDashboardPlayer
		          || platform == RuntimePlatform__Enum_WindowsWebPlayer
		          || platform == (RuntimePlatform__Enum_OSXDashboardPlayer|RuntimePlatform__Enum_WindowsPlayer) )
		        {
		          goto LABEL_35;
		        }
		        m_splatIndexMap = (unsigned int)(platform - 7);
		        if ( platform == RuntimePlatform__Enum_WindowsEditor )
		        {
		LABEL_37:
		          v63 = runtimeResources->fields.shaders;
		          if ( !v63 )
		            goto LABEL_111;
		          terrainBC3CompressCS = v63->fields.terrainBC3CompressCS;
		LABEL_41:
		          this->fields.m_vtCompressCS = terrainBC3CompressCS;
		          sub_18002D1B0(
		            (HGRuntimeGrassQuery_Node *)&this->fields.m_vtCompressCS,
		            (HGRuntimeGrassQuery_Node *)m_splatIndexMap,
		            v57,
		            v58,
		            methodl);
		          m_vtBakeCS = (__int64)this->fields.m_vtCompressCS;
		          if ( !m_vtBakeCS )
		            goto LABEL_111;
		          this->fields.m_vtCompressMainKernel = UnityEngine::ComputeShader::FindKernel(
		                                                  (ComputeShader *)m_vtBakeCS,
		                                                  (String *)"KMain",
		                                                  0LL);
		          goto LABEL_43;
		        }
		        if ( platform != RuntimePlatform__Enum_IPhonePlayer && platform != RuntimePlatform__Enum_Android )
		        {
		LABEL_35:
		          v59 = sub_18007E180(&TypeInfo::System::ArgumentException);
		          v60 = (InvalidEnumArgumentException *)sub_18002C620(v59);
		          if ( v60 )
		          {
		            v61 = (String *)sub_18007E180(&off_18E27C678);
		            System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v60, v61, 0LL);
		            v62 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VirtualTextureRenderer::VirtualTextureRenderer);
		            sub_18007E190(v60, v62);
		          }
		          goto LABEL_111;
		        }
		      }
		    }
		    v65 = runtimeResources->fields.shaders;
		    if ( !v65 )
		      goto LABEL_111;
		    terrainBC3CompressCS = v65->fields.terrainASTCCompressCS;
		    goto LABEL_41;
		  }
		LABEL_43:
		  z = runtimeResources->fields.heightmapScale.z;
		  *(_QWORD *)&this->fields.m_heightmapScale.x = *(_QWORD *)&runtimeResources->fields.heightmapScale.x;
		  this->fields.m_heightmapScale.z = z;
		  this->fields.m_terrainSize = runtimeResources->fields.terrainSize;
		  this->fields.m_lightmapScaleOffset = (Vector4)_mm_loadu_si128((const __m128i *)&runtimeResources->fields.lightmapScaleOffset);
		  v67 = runtimeResources->fields.terrainPos.z;
		  *(_QWORD *)&this->fields.m_terrainPos.x = *(_QWORD *)&runtimeResources->fields.terrainPos.x;
		  this->fields.m_terrainPos.z = v67;
		  Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray(
		    &v214,
		    325,
		    Allocator__Enum_Temp,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
		  v68 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		  v69 = v68;
		  if ( !v68 )
		    goto LABEL_111;
		  UnityEngine::ComputeBuffer::ComputeBuffer(
		    v68,
		    v214.m_Length,
		    16,
		    ComputeBufferType__Enum_Constant,
		    ComputeBufferMode__Enum_Immutable,
		    0LL);
		  this->fields._terrainBakeDataBuffer_k__BackingField = v69;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._terrainBakeDataBuffer_k__BackingField,
		    v70,
		    v71,
		    v72,
		    methodw);
		  packedSplatInfo = runtimeResources->fields.terrainLayerData.packedSplatInfo;
		  if ( !packedSplatInfo )
		    goto LABEL_111;
		  v75 = 0;
		  m_Buffer = v214.m_Buffer;
		  if ( packedSplatInfo->max_length.size > 0 )
		  {
		    v77 = v214.m_Buffer + 2048;
		    height = packedSplatInfo->max_length.size;
		    while ( 1 )
		    {
		      m_vtBakeCS = (__int64)runtimeResources->fields.terrainLayerData.packedSplatInfo;
		      if ( !m_vtBakeCS )
		        break;
		      sub_180002990(m_vtBakeCS, &v215, v75, v73);
		      *(_OWORD *)&v77[-2048] = v215;
		      m_vtBakeCS = (__int64)runtimeResources->fields.terrainLayerData.splatsST;
		      if ( !m_vtBakeCS )
		        break;
		      sub_180002990(m_vtBakeCS, &v216, v75, v78);
		      *(_OWORD *)&v77[-1024] = v216;
		      m_vtBakeCS = (__int64)runtimeResources->fields.terrainLayerData.diffuseRemapScale;
		      if ( !m_vtBakeCS )
		        break;
		      sub_180002990(m_vtBakeCS, &v217, v75, v79);
		      *(_OWORD *)v77 = v217;
		      m_vtBakeCS = (__int64)runtimeResources->fields.terrainLayerData.maskMapRemapOffset;
		      if ( !m_vtBakeCS )
		        break;
		      sub_180002990(m_vtBakeCS, &v218, v75, v80);
		      *(_OWORD *)&v77[1024] = *(_OWORD *)&v218.m_SpaceInfo.m_KeywordSpace;
		      m_vtBakeCS = (__int64)runtimeResources->fields.terrainLayerData.maskMapRemapScale;
		      if ( !m_vtBakeCS )
		        break;
		      sub_180002990(m_vtBakeCS, &v219, v75++, v81);
		      ++v6;
		      *(_OWORD *)&v77[2048] = *(_OWORD *)&v219.m_SpaceInfo.m_KeywordSpace;
		      v77 += 16;
		      if ( v6 >= height )
		        goto LABEL_53;
		    }
		LABEL_111:
		    sub_1800D8260(m_vtBakeCS, m_splatIndexMap);
		  }
		LABEL_53:
		  m_splatIndexMap = (unsigned __int64)this->fields.m_splatIndexMap;
		  if ( !m_splatIndexMap )
		    goto LABEL_111;
		  v82 = sub_180002F70(5LL, m_splatIndexMap);
		  m_splatIndexMap = (unsigned __int64)this->fields.m_splatIndexMap;
		  v83 = v82;
		  if ( !m_splatIndexMap )
		    goto LABEL_111;
		  v84 = sub_180002F70(7LL, m_splatIndexMap);
		  m_splatIndexMap = (unsigned __int64)this->fields.m_splatIndexMap;
		  v85 = v84;
		  if ( !m_splatIndexMap )
		    goto LABEL_111;
		  v86 = sub_180002F70(5LL, m_splatIndexMap);
		  m_splatIndexMap = (unsigned __int64)this->fields.m_splatIndexMap;
		  if ( !m_splatIndexMap )
		    goto LABEL_111;
		  *(float *)&v215 = 1.0 / (float)v83;
		  *((float *)&v215 + 1) = 1.0 / (float)v85;
		  *((float *)&v215 + 2) = (float)v86;
		  *((float *)&v215 + 3) = (float)(int)sub_180002F70(7LL, m_splatIndexMap);
		  *(_OWORD *)&m_Buffer[5120] = v215;
		  m_splatIndexMap = (unsigned __int64)this->fields.m_splatControlMap;
		  if ( !m_splatIndexMap )
		    goto LABEL_111;
		  v87 = sub_180002F70(5LL, m_splatIndexMap);
		  m_splatIndexMap = (unsigned __int64)this->fields.m_splatControlMap;
		  v88 = v87;
		  if ( !m_splatIndexMap )
		    goto LABEL_111;
		  v89 = sub_180002F70(7LL, m_splatIndexMap);
		  m_splatIndexMap = (unsigned __int64)this->fields.m_splatControlMap;
		  v90 = v89;
		  if ( !m_splatIndexMap )
		    goto LABEL_111;
		  v91 = sub_180002F70(5LL, m_splatIndexMap);
		  m_splatIndexMap = (unsigned __int64)this->fields.m_splatControlMap;
		  if ( !m_splatIndexMap )
		    goto LABEL_111;
		  *(float *)&v215 = 1.0 / (float)v88;
		  *((float *)&v215 + 1) = 1.0 / (float)v90;
		  *((float *)&v215 + 2) = (float)v91;
		  *((float *)&v215 + 3) = (float)(int)sub_180002F70(7LL, m_splatIndexMap);
		  *(_OWORD *)&m_Buffer[5136] = v215;
		  m_splatIndexMap = (unsigned __int64)this->fields.m_splatControlMap;
		  if ( !m_splatIndexMap )
		    goto LABEL_111;
		  v92 = sub_180002F70(5LL, m_splatIndexMap);
		  m_splatIndexMap = (unsigned __int64)this->fields.m_splatIndexMap;
		  v93 = v92;
		  if ( !m_splatIndexMap )
		    goto LABEL_111;
		  v94 = sub_180002F70(5LL, m_splatIndexMap);
		  m_vtBakeCS = v94;
		  m_splatIndexMap = (unsigned __int64)this->fields.m_splatControlMap;
		  v95 = v93 / (int)v94;
		  if ( !m_splatIndexMap )
		    goto LABEL_111;
		  v96 = sub_180002F70(7LL, m_splatIndexMap);
		  m_splatIndexMap = (unsigned __int64)this->fields.m_splatIndexMap;
		  if ( !m_splatIndexMap )
		    goto LABEL_111;
		  v97 = v96 / (int)sub_180002F70(7LL, m_splatIndexMap);
		  *(float *)&v215 = 0.5 / (float)v95;
		  *((float *)&v215 + 1) = 0.5 / (float)v97;
		  *((float *)&v215 + 2) = (float)((float)v95 - 0.5) / (float)v95;
		  *((float *)&v215 + 3) = (float)((float)v97 - 0.5) / (float)v97;
		  *(_OWORD *)&m_Buffer[5152] = v215;
		  m_Y = (float)runtimeResources->fields.terrainSize.m_Y;
		  *(float *)&v215 = (float)runtimeResources->fields.terrainSize.m_X;
		  *((float *)&v215 + 1) = m_Y;
		  *((_QWORD *)&v215 + 1) = COERCE_UNSIGNED_INT(HG::Rendering::Runtime::VirtualTextureRenderer::_CalculateHeightNormFactor(this, 0LL));
		  v99 = v215;
		  HIDWORD(v215) = 1132462080;
		  *(_OWORD *)&m_Buffer[5168] = v99;
		  y = runtimeResources->fields.terrainPos.y;
		  *(float *)&v215 = runtimeResources->fields.terrainPos.x;
		  DWORD2(v215) = LODWORD(runtimeResources->fields.terrainPos.z);
		  *((float *)&v215 + 1) = y;
		  *(_OWORD *)&m_Buffer[5184] = v215;
		  m_vtBakeCS = (__int64)this->fields._terrainBakeDataBuffer_k__BackingField;
		  if ( !m_vtBakeCS )
		    goto LABEL_111;
		  *(NativeArray_1_UnityEngine_Vector4_ *)&v219.m_SpaceInfo.m_KeywordSpace = v214;
		  sub_1808B0C90(m_vtBakeCS, &v219);
		  Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		    &v214,
		    MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
		  v101 = this->fields.m_configuration;
		  if ( !v101 )
		    goto LABEL_111;
		  this->fields.m_virtualTextureResolution = v101->fields.virtualTextureResolution;
		  v102 = this->fields.m_configuration;
		  if ( !v102 )
		    goto LABEL_111;
		  vtMinChunkSize = v102->fields.vtMinChunkSize;
		  this->fields.m_vtBaseMipBias = v102->fields.vtBaseMipBias;
		  m_vtBakeCS = (__int64)this->fields.m_configuration;
		  vtCacheSliceWidth = v102->fields.vtCacheSliceWidth;
		  this->fields.m_cacheSliceWidth = vtCacheSliceWidth;
		  if ( !m_vtBakeCS )
		    goto LABEL_111;
		  v105 = *(_DWORD *)(m_vtBakeCS + 56);
		  this->fields.m_cacheSliceHeight = v105;
		  v106 = *(_DWORD *)(m_vtBakeCS + 48);
		  m_vtBakeCS = 256LL;
		  this->fields.m_cacheSliceCount = v106;
		  v107 = vtCacheSliceWidth / 256;
		  this->fields.m_cacheColNumPerSlice = v107;
		  this->fields.m_cacheRowNumPerSlice = v105 / 256;
		  v108 = v107 * (v105 / 256);
		  this->fields.m_cachePageCountPerSlice = v108;
		  this->fields.m_cachePageCountTotal = v106 * v108;
		  m_splatIndexMap = (unsigned __int64)runtimeResources->fields.textures;
		  if ( !m_splatIndexMap )
		    goto LABEL_111;
		  m_splatIndexMap = *(_QWORD *)(m_splatIndexMap + 32);
		  if ( !m_splatIndexMap )
		    goto LABEL_111;
		  v109 = sub_180002F70(5LL, m_splatIndexMap);
		  m_splatIndexMap = (unsigned __int64)runtimeResources->fields.textures;
		  v110 = v109;
		  if ( !m_splatIndexMap )
		    goto LABEL_111;
		  m_splatIndexMap = *(_QWORD *)(m_splatIndexMap + 32);
		  if ( !m_splatIndexMap )
		    goto LABEL_111;
		  v111 = sub_180002F70(7LL, m_splatIndexMap);
		  v112 = (float)this->fields.m_virtualTextureResolution * (float)vtMinChunkSize;
		  v113 = v112 / (float)(v110 - 1);
		  this->fields.m_virtualToTerrain.x = v113;
		  v114 = v112 / (float)(v111 - 1);
		  this->fields.m_virtualToTerrain.y = v114;
		  this->fields._terrainToVirtual_k__BackingField.x = 1.0 / v113;
		  this->fields._terrainToVirtual_k__BackingField.y = 1.0 / v114;
		  v115 = -runtimeResources->fields.terrainPos.z;
		  this->fields.m_terrainPosOffset.x = -runtimeResources->fields.terrainPos.x;
		  this->fields.m_terrainPosOffset.y = v115;
		  heightb = UnityEngine::Vector2Int::op_Implicit(runtimeResources->fields.terrainSize, v116);
		  this->fields.m_worldToVirtual.x = (float)(1.0 / heightb.x) / v113;
		  this->fields.m_worldToVirtual.y = (float)(1.0 / heightb.y) / v117;
		  v121 = sub_182F114D0(v119, v118, v120);
		  v122 = this->fields.m_configuration;
		  this->fields.m_indirectMaxLevel = (int)*(float *)&v121;
		  v123 = (int)*(float *)&v121 - 1;
		  this->fields.m_indirectBaseLevel = v123;
		  if ( !v122 )
		    goto LABEL_111;
		  m_vtBakeCS = (__int64)this->fields.m_configuration;
		  vtClipmapBaseOffset = v122->fields.vtClipmapBaseOffset;
		  this->fields.m_indirectOffset = vtClipmapBaseOffset;
		  if ( !m_vtBakeCS )
		    goto LABEL_111;
		  v125 = *(_DWORD *)(m_vtBakeCS + 64);
		  this->fields.m_indirectMaxOffset = v125;
		  v126 = 8 << (v125 & 0x1F);
		  this->fields.m_indirectMaxWidth = v126;
		  this->fields.m_indirectLevel = v123 - vtClipmapBaseOffset;
		  this->fields.m_indirectMaxHeight = v126 * v123;
		  v127 = 8 << (vtClipmapBaseOffset & 0x1F);
		  this->fields.m_indirectWidth = v127;
		  this->fields.m_indirectMaxArea = v126 * v126;
		  this->fields.m_indirectHalfWidth = v127 / 2;
		  this->fields.m_blockWidth = -1;
		  this->fields.m_blockHeight = -1;
		  this->fields.m_feedbackWidth = -1;
		  this->fields.m_feedbackHeight = -1;
		  this->fields._currentCenterPos_k__BackingField = 0LL;
		  v128 = (LRUCache *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::LRUCache);
		  if ( !v128 )
		    goto LABEL_111;
		  this->fields.m_lruCache = v128;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_lruCache,
		    (HGRuntimeGrassQuery_Node *)m_splatIndexMap,
		    v129,
		    v130,
		    methodm);
		  m_vtBakeCS = (__int64)this->fields.m_lruCache;
		  if ( !m_vtBakeCS )
		    goto LABEL_111;
		  HG::Rendering::Runtime::LRUCache::Reset((LRUCache *)m_vtBakeCS, this->fields.m_cachePageCountTotal, 0LL);
		  v131 = (Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<unsigned int,int>);
		  v132 = (Dictionary_2_System_UInt32_System_Int32_ *)v131;
		  if ( !v131 )
		    goto LABEL_111;
		  System::Collections::Generic::Dictionary<unsigned int,Beyond::Gameplay::Audio::VoiceBarkProcessor_VoiceEchoBarker::FBarkInfo>::Dictionary(
		    v131,
		    MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Dictionary);
		  this->fields.m_nodeCacheLut = v132;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_nodeCacheLut, v133, v134, v135, methodn);
		  v136 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>);
		  v137 = (List_1_HG_Rendering_Runtime_VirtualTextureRenderer_GlobalUV_ *)v136;
		  if ( !v136 )
		    goto LABEL_111;
		  System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		    v136,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::List);
		  this->fields.m_globalUVs = v137;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_globalUVs, v138, v139, v140, methodo);
		  v141 = (LowLevelList_1_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<unsigned int>);
		  v142 = (List_1_System_UInt32_ *)v141;
		  if ( !v141 )
		    goto LABEL_111;
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v141,
		    MethodInfo::System::Collections::Generic::List<unsigned int>::List);
		  this->fields.m_renderQueue = v142;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_renderQueue, v143, v144, v145, methodp);
		  this->fields.m_indirectTextures = (Texture2D__Array *)il2cpp_array_new_specific_1(
		                                                          TypeInfo::UnityEngine::Texture2D,
		                                                          3LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_indirectTextures, v146, v147, v148, methodx);
		  for ( i = 0; ; ++i )
		  {
		    m_indirectTextures = this->fields.m_indirectTextures;
		    if ( !m_indirectTextures )
		      goto LABEL_111;
		    if ( i >= m_indirectTextures->max_length.size )
		      break;
		    v151 = this->fields.m_indirectTextures;
		    m_indirectMaxWidth = this->fields.m_indirectMaxWidth;
		    heighta = this->fields.m_indirectMaxHeight;
		    v153 = (Texture2D *)sub_18002C620(TypeInfo::UnityEngine::Texture2D);
		    v154 = (Texture *)v153;
		    if ( !v153 )
		      goto LABEL_111;
		    UnityEngine::Texture2D::Texture2D(
		      v153,
		      m_indirectMaxWidth,
		      heighta,
		      GraphicsFormat__Enum_R8G8B8A8_UNorm,
		      TextureCreationFlags__Enum_None,
		      0LL);
		    UnityEngine::Texture::set_filterMode(v154, FilterMode__Enum_Point, 0LL);
		    UnityEngine::Texture::set_wrapMode(v154, TextureWrapMode__Enum_Clamp, 0LL);
		    UnityEngine::Texture2D::set_requestedMipmapLevel((Texture2D *)v154, 0, 0LL);
		    sub_180378FEC(v151, i, v154);
		  }
		  HG::Rendering::Runtime::VirtualTextureRenderer::_AllocatePhysicalCacheResources(this, 0LL);
		  this->fields.m_decalDiffuseTexArray = terrainResource->decalDiffuseTexArray;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_decalDiffuseTexArray, v155, v156, v157, methodq);
		  decalNormalMROTexArray = terrainResource->decalNormalMROTexArray;
		  this->fields.m_decalNormalMROTexArray = decalNormalMROTexArray;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_decalNormalMROTexArray,
		    v159,
		    v160,
		    (Int32__Array **)decalNormalMROTexArray,
		    methody);
		  m_indirectMaxLevel = this->fields.m_indirectMaxLevel;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
		  this->fields.m_decalMaxLevel = HG::Rendering::Runtime::HGTerrainUtils::GetTerrainDecalMaxLevel(
		                                   m_indirectMaxLevel,
		                                   0LL);
		  if ( runtimeResources->fields.decalResources.instanceData )
		  {
		    instanceData = runtimeResources->fields.decalResources.instanceData;
		    if ( instanceData->max_length.value )
		    {
		      this->fields.m_decalInstanceData = instanceData;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_decalInstanceData, v162, v163, v164, methodr);
		      decalNodeKeys = runtimeResources->fields.decalResources.decalNodeKeys;
		      decalIndicesValues = runtimeResources->fields.decalResources.decalIndicesValues;
		      v168 = (Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<unsigned int,System::Int32 []>);
		      v169 = (Dictionary_2_System_UInt32_System_Int32__2 *)v168;
		      if ( !v168 )
		        goto LABEL_111;
		      System::Collections::Generic::Dictionary<unsigned int,Beyond::Gameplay::Audio::VoiceBarkProcessor_VoiceEchoBarker::FBarkInfo>::Dictionary(
		        v168,
		        MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::Int32 []>::Dictionary);
		      this->fields.m_decalNodeLut = v169;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_decalNodeLut, v170, v171, v172, methods);
		      v173 = 0;
		      if ( !decalNodeKeys )
		        goto LABEL_111;
		      while ( (signed int)v173 < decalNodeKeys->max_length.size )
		      {
		        m_vtBakeCS = (__int64)this->fields.m_decalNodeLut;
		        if ( v173 >= decalNodeKeys->max_length.size )
		          goto LABEL_105;
		        if ( !decalIndicesValues )
		          goto LABEL_111;
		        if ( v173 >= decalIndicesValues->max_length.size )
		LABEL_105:
		          sub_1800D2AB0(m_vtBakeCS, m_splatIndexMap);
		        if ( !m_vtBakeCS )
		          goto LABEL_111;
		        System::Collections::Generic::Dictionary<unsigned int,System::Object>::Add(
		          (Dictionary_2_System_UInt32_System_Object_ *)m_vtBakeCS,
		          decalNodeKeys->vector[v173],
		          (Object *)decalIndicesValues->vector[v173].decalIndices,
		          MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::Int32 []>::Add);
		        ++v173;
		      }
		      blockNodeKeys = runtimeResources->fields.decalResources.blockNodeKeys;
		      if ( !blockNodeKeys )
		        goto LABEL_111;
		      if ( blockNodeKeys->max_length.value )
		      {
		        v175 = runtimeResources->fields.decalResources.blockNodeKeys;
		        blockMasksValues = runtimeResources->fields.decalResources.blockMasksValues;
		        v177 = (Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<unsigned int,System::UInt64 []>);
		        v178 = (Dictionary_2_System_UInt32_System_UInt64__1 *)v177;
		        if ( !v177 )
		          goto LABEL_111;
		        System::Collections::Generic::Dictionary<unsigned int,Beyond::Gameplay::Audio::VoiceBarkProcessor_VoiceEchoBarker::FBarkInfo>::Dictionary(
		          v177,
		          MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::UInt64 []>::Dictionary);
		        this->fields.m_decalBlockMaskLut = v178;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_decalBlockMaskLut, v179, v180, v181, methodt);
		        for ( j = 0; (signed int)j < v175->max_length.size; ++j )
		        {
		          m_vtBakeCS = (__int64)this->fields.m_decalBlockMaskLut;
		          if ( j >= v175->max_length.size )
		            goto LABEL_105;
		          if ( !blockMasksValues )
		            goto LABEL_111;
		          if ( j >= blockMasksValues->max_length.size )
		            goto LABEL_105;
		          if ( !m_vtBakeCS )
		            goto LABEL_111;
		          System::Collections::Generic::Dictionary<unsigned int,System::Object>::Add(
		            (Dictionary_2_System_UInt32_System_Object_ *)m_vtBakeCS,
		            v175->vector[j],
		            (Object *)blockMasksValues->vector[j].blockMasks,
		            MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::UInt64 []>::Add);
		        }
		      }
		      this->fields.m_decalInstanceInfo = (Vector4__Array *)il2cpp_array_new_specific_1(
		                                                             TypeInfo::UnityEngine::Vector4,
		                                                             16LL);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_decalInstanceInfo, v183, v184, v185, methodt);
		    }
		  }
		  if ( this->fields._feedbackMode_k__BackingField == 1 )
		  {
		    this->fields.m_gpuFeedbackBufferFilled = (Boolean__Array *)il2cpp_array_new_specific_1(
		                                                                 TypeInfo::System::Boolean,
		                                                                 4LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_gpuFeedbackBufferFilled, v186, v187, v188, methodr);
		    System::Array::Fill<bool>(this->fields.m_gpuFeedbackBufferFilled, 0, MethodInfo::System::Array::Fill<bool>);
		  }
		}
		
	
		// Methods
		private static uint _PackNodeKey(int level, int row, int col) => default; // 0x0000000189C28AA8-0x0000000189C28B1C
		// UInt32 _PackNodeKey(Int32, Int32, Int32)
		uint32_t HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(
		        int32_t level,
		        int32_t row,
		        int32_t col,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3993, 0LL) )
		    return col | ((row | (level << 13)) << 13);
		  Patch = IFix::WrappersManagerImpl::GetPatch(3993, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v10, v9);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1405(Patch, level, row, col, 0LL);
		}
		
		private static ValueTuple<int, int, int> _UnpackNodeKey(uint nodeKey) => default; // 0x0000000189C28EAC-0x0000000189C28F30
		// ValueTuple`3[Int32,Int32,Int32] _UnpackNodeKey(UInt32)
		ValueTuple_3_Int32_Int32_Int32_ *HG::Rendering::Runtime::VirtualTextureRenderer::_UnpackNodeKey(
		        ValueTuple_3_Int32_Int32_Int32_ *__return_ptr retstr,
		        uint32_t nodeKey,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  ValueTuple_3_Int32_Int32_Int32_ *v8; // rax
		  __int64 v9; // xmm0_8
		  ValueTuple_3_Int32_Int32_Int32_ v11[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3992, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3992, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1404(v11, Patch, nodeKey, 0LL);
		    v9 = *(_QWORD *)&v8->Item1;
		    LODWORD(v8) = v8->Item3;
		    *(_QWORD *)&retstr->Item1 = v9;
		    retstr->Item3 = (int)v8;
		  }
		  else
		  {
		    retstr->Item1 = nodeKey >> 26;
		    retstr->Item2 = (nodeKey >> 13) & 0x1FFF;
		    retstr->Item3 = nodeKey & 0x1FFF;
		  }
		  return retstr;
		}
		
		public void Dispose() {} // 0x0000000189C23FE4-0x0000000189C2417C
		// Void Dispose()
		void HG::Rendering::Runtime::VirtualTextureRenderer::Dispose(VirtualTextureRenderer *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  int32_t v4; // edi
		  ComputeBuffer *terrainBakeDataBuffer_k__BackingField; // rcx
		  int32_t feedbackMode_k__BackingField; // eax
		  Texture2D__Array *m_indirectTextures; // rbp
		  Object_1 *v8; // rbx
		  Object_1 *m_decalDiffuseTexArray; // rbx
		  __int64 v10; // rax
		  InvalidEnumArgumentException *v11; // rbx
		  String *v12; // rax
		  __int64 v13; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v4 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(4024, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4024, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_19;
		  }
		  terrainBakeDataBuffer_k__BackingField = this->fields._terrainBakeDataBuffer_k__BackingField;
		  if ( !terrainBakeDataBuffer_k__BackingField )
		    goto LABEL_19;
		  UnityEngine::ComputeBuffer::Dispose(terrainBakeDataBuffer_k__BackingField, 0LL);
		  if ( this->fields.m_feedbackJitterSeq.m_Buffer )
		    Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
		      (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&this->fields.m_feedbackJitterSeq,
		      MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::Dispose);
		  feedbackMode_k__BackingField = this->fields._feedbackMode_k__BackingField;
		  if ( feedbackMode_k__BackingField )
		  {
		    if ( feedbackMode_k__BackingField == 1 )
		    {
		      HG::Rendering::Runtime::VirtualTextureRenderer::_DestroyGPUFeedbackResources(this, 0LL);
		      goto LABEL_10;
		    }
		    v10 = sub_18007E180(&TypeInfo::System::ArgumentException);
		    v11 = (InvalidEnumArgumentException *)sub_18002C620(v10);
		    if ( v11 )
		    {
		      v12 = (String *)sub_18007E180(&off_18E27C758);
		      System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v11, v12, 0LL);
		      v13 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VirtualTextureRenderer::Dispose);
		      sub_18007E190(v11, v13);
		    }
		LABEL_19:
		    sub_1800D8260(terrainBakeDataBuffer_k__BackingField, v3);
		  }
		  if ( this->fields.m_cpuJitterOffsets.m_Buffer )
		    Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		      (NativeArray_1_UnityEngine_Vector4_ *)&this->fields.m_cpuJitterOffsets,
		      MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
		LABEL_10:
		  m_indirectTextures = this->fields.m_indirectTextures;
		  if ( !m_indirectTextures )
		    goto LABEL_19;
		  while ( v4 < m_indirectTextures->max_length.size )
		  {
		    if ( (unsigned int)v4 >= m_indirectTextures->max_length.size )
		      sub_1800D2AB0(terrainBakeDataBuffer_k__BackingField, v3);
		    v8 = (Object_1 *)m_indirectTextures->vector[v4];
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    HG::Rendering::Runtime::HGUtils::Destroy(v8, 0LL);
		    ++v4;
		  }
		  m_decalDiffuseTexArray = (Object_1 *)this->fields.m_decalDiffuseTexArray;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  HG::Rendering::Runtime::HGUtils::Destroy(m_decalDiffuseTexArray, 0LL);
		  HG::Rendering::Runtime::HGUtils::Destroy((Object_1 *)this->fields.m_decalNormalMROTexArray, 0LL);
		  HG::Rendering::Runtime::VirtualTextureRenderer::_DestroyPhysicalCacheResources(this, 0LL);
		}
		
		public void PipelineUpdate([IsReadOnly] in Vector2 vtCenter) {} // 0x0000000189C24E40-0x0000000189C25AF4
		// Void PipelineUpdate(Vector2 ByRef)
		// Hidden C++ exception states: #wind=3
		void HG::Rendering::Runtime::VirtualTextureRenderer::PipelineUpdate(
		        VirtualTextureRenderer *this,
		        Vector2 *vtCenter,
		        MethodInfo *method)
		{
		  VirtualTextureRenderer *v4; // rsi
		  uint32_t v5; // eax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector2 v10; // r8
		  Vector2 v11; // r9
		  int32_t i; // r14d
		  int v13; // r15d
		  int32_t j; // r13d
		  int32_t k; // r12d
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  Vector2 v20; // rax
		  __int64 v21; // rax
		  Vector2 v22; // rdx
		  Vector2 v23; // r8
		  int32_t v24; // r9d
		  Vector2 v25; // rdx
		  Vector2 v26; // rcx
		  int32_t feedbackMode_k__BackingField; // eax
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  __int64 v30; // r8
		  __m128 v31; // xmm7
		  __int64 v32; // rdx
		  __int64 v33; // rcx
		  System::MathF *v34; // rcx
		  int v35; // r14d
		  float v36; // xmm1_4
		  float v37; // xmm0_4
		  int v38; // r12d
		  float v39; // xmm6_4
		  System::MathF *v40; // rcx
		  System::MathF *v41; // rcx
		  System::MathF *v42; // rcx
		  __int64 v43; // rdx
		  __int64 v44; // rcx
		  __int64 v45; // r8
		  char v46; // dl
		  __int64 v47; // rcx
		  int v48; // r8d
		  int v49; // ecx
		  int32_t v50; // r14d
		  char v51; // cl
		  int32_t v52; // r12d
		  int32_t v53; // r15d
		  uint32_t v54; // eax
		  __int64 v55; // rdx
		  Dictionary_2_System_UInt32_System_Int32_ *m_nodeCacheLut; // rcx
		  __int64 v57; // rdx
		  uint32_t m; // r15d
		  Dictionary_2_System_UInt32_System_Int32_ *v59; // rcx
		  ValueTuple_3_Int32_Int32_Int32_ *v60; // rax
		  int Item3; // r8d
		  AsyncGPUReadbackRequest *currGPUFeedbackRequest; // rax
		  AsyncGPUReadbackRequest *v63; // rax
		  NativeArray_1_System_UInt32_ *currGPUFeedbackData; // r8
		  int32_t v65; // edx
		  int32_t n; // r13d
		  int32_t ii; // r12d
		  int v68; // r14d
		  int32_t v69; // r15d
		  int32_t v70; // r14d
		  uint32_t v71; // eax
		  __int64 v72; // rdx
		  Dictionary_2_System_UInt32_System_Int32_ *m_renderQueue; // rcx
		  float x; // ecx
		  int32_t v75; // r8d
		  int32_t jj; // edx
		  uint32_t v77; // eax
		  uint32_t v78; // r14d
		  ValueTuple_3_Int32_Int32_Int32_ *v79; // rax
		  int v80; // ebx
		  __int64 v81; // rdx
		  uint32_t v82; // r14d
		  Dictionary_2_System_UInt32_System_Int32_ *v83; // rcx
		  __int64 v84; // rdx
		  __int64 v85; // rcx
		  List_1_System_UInt32_ *v86; // rax
		  LRUCache *v87; // rcx
		  unsigned __int64 v88; // rax
		  int32_t v89; // ebx
		  unsigned __int64 v90; // rdx
		  Dictionary_2_System_UInt32_System_Int32_ *v91; // rcx
		  Dictionary_2_System_UInt32_System_Int32_ *v92; // rcx
		  __int64 v93; // rdx
		  List_1_System_UInt32_ *v94; // rcx
		  LRUCache *m_lruCache; // rcx
		  Texture2D *currIndirectTexture; // rax
		  __int64 v97; // rdx
		  LRUCache *v98; // rcx
		  __int64 v99; // rax
		  InvalidEnumArgumentException *v100; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v102; // rdx
		  __int64 v103; // rcx
		  String *v104; // rax
		  __int64 v105; // rax
		  AllocatorManager_AllocatorHandle allocator; // [rsp+20h] [rbp-1A8h] BYREF
		  int32_t idx; // [rsp+28h] [rbp-1A0h] BYREF
		  int32_t v108; // [rsp+2Ch] [rbp-19Ch] BYREF
		  NativeArray_1_T_Enumerator_System_Int32_ v109; // [rsp+30h] [rbp-198h] BYREF
		  NativeArray_1_T_ReadOnly_T_Enumerator_System_UInt32_ v110; // [rsp+50h] [rbp-178h] BYREF
		  NativeArray_1_System_UInt32_ *v111; // [rsp+70h] [rbp-158h]
		  NativeArray_1_System_UInt32_ *v112; // [rsp+80h] [rbp-148h]
		  NativeList_1_System_Int32_ v113; // [rsp+90h] [rbp-138h] BYREF
		  List_1_T_Enumerator_HG_Rendering_Runtime_VirtualTextureRenderer_GlobalUV_ v114; // [rsp+A0h] [rbp-128h] BYREF
		  NativeArray_1_T_ReadOnly_T_Enumerator_System_UInt32_ v115; // [rsp+C8h] [rbp-100h] BYREF
		  NativeArray_1_System_Int32_ m_Array; // [rsp+E0h] [rbp-E8h] BYREF
		  int32_t v117[2]; // [rsp+F0h] [rbp-D8h]
		  ValueTuple_3_Int32_Int32_Int32_ v118; // [rsp+F8h] [rbp-D0h] BYREF
		  Il2CppExceptionWrapper *v119; // [rsp+108h] [rbp-C0h] BYREF
		  Il2CppExceptionWrapper *v120; // [rsp+110h] [rbp-B8h] BYREF
		  Il2CppExceptionWrapper *v121; // [rsp+118h] [rbp-B0h] BYREF
		  List_1_T_Enumerator_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ v122; // [rsp+120h] [rbp-A8h] BYREF
		  Vector2 value; // [rsp+1E8h] [rbp+20h] BYREF
		
		  v4 = this;
		  v109.m_Array = 0LL;
		  v113 = 0LL;
		  value.x = 0.0;
		  idx = 0;
		  memset(&v114, 0, sizeof(v114));
		  memset(&v115, 0, sizeof(v115));
		  v108 = 0;
		  m_Array = 0LL;
		  *(_QWORD *)v117 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3995, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3995, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v103, v102);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1407(Patch, (Object *)v4, vtCenter, 0LL);
		    return;
		  }
		  ++v4->fields.m_frameCount;
		  Unity::Collections::NativeList<unsigned int>::NativeList(
		    (NativeList_1_System_UInt32_ *)&v109,
		    (AllocatorManager_AllocatorHandle)2,
		    MethodInfo::Unity::Collections::NativeList<unsigned int>::NativeList);
		  Unity::Collections::NativeList<int>::NativeList(
		    &v113,
		    (AllocatorManager_AllocatorHandle)2,
		    MethodInfo::Unity::Collections::NativeList<int>::NativeList);
		  v5 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(0, 0, 0, 0LL);
		  allocator = (AllocatorManager_AllocatorHandle)v5;
		  if ( !v4->fields.m_nodeCacheLut )
		    sub_1800D8260(v7, v6);
		  if ( System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue(
		         v4->fields.m_nodeCacheLut,
		         v5,
		         (int32_t *)&value,
		         MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue) )
		  {
		    if ( !v4->fields.m_lruCache )
		      sub_1800D8260(v9, v8);
		    HG::Rendering::Runtime::LRUCache::Lock(v4->fields.m_lruCache, SLODWORD(value.x), 0LL);
		    Unity::Collections::NativeList<int>::Add(
		      &v113,
		      (int32_t *)&value,
		      MethodInfo::Unity::Collections::NativeList<int>::Add);
		  }
		  else
		  {
		    Unity::Collections::NativeList<unsigned int>::Add(
		      (NativeList_1_System_UInt32_ *)&v109,
		      (uint32_t *)&allocator.Index,
		      MethodInfo::Unity::Collections::NativeList<unsigned int>::Add);
		  }
		  for ( i = 1; i < 3; ++i )
		  {
		    v13 = 1 << (i & 0x1F);
		    for ( j = 0; j < v13; ++j )
		    {
		      for ( k = 0; k < v13; ++k )
		      {
		        LODWORD(value.x) = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(i, j, k, 0LL);
		        if ( !v4->fields.m_nodeCacheLut )
		          sub_1800D8260(v17, v16);
		        if ( System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue(
		               v4->fields.m_nodeCacheLut,
		               LODWORD(value.x),
		               &idx,
		               MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue) )
		        {
		          if ( !v4->fields.m_lruCache )
		            sub_1800D8260(v19, v18);
		          HG::Rendering::Runtime::LRUCache::Lock(v4->fields.m_lruCache, idx, 0LL);
		          Unity::Collections::NativeList<int>::Add(&v113, &idx, MethodInfo::Unity::Collections::NativeList<int>::Add);
		        }
		      }
		    }
		  }
		  v20 = sub_1853DF234(
		          (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(vtCenter->x), (__m128)LODWORD(vtCenter->y)),
		          (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
		                                 (__m128)LODWORD(v4->fields.m_terrainPosOffset.x),
		                                 (__m128)LODWORD(v4->fields.m_terrainPosOffset.y)),
		          v10,
		          v11);
		  v21 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_185EDCFF4)(
		          v20,
		          _mm_unpacklo_ps(
		            (__m128)LODWORD(v4->fields.m_worldToVirtual.x),
		            (__m128)LODWORD(v4->fields.m_worldToVirtual.y)).m128_u64[0]);
		  value = sub_1858CACF0(v21, v22, v23, v24);
		  v4->fields._currentCenterPos_k__BackingField = value;
		  feedbackMode_k__BackingField = v4->fields._feedbackMode_k__BackingField;
		  if ( feedbackMode_k__BackingField )
		  {
		    if ( feedbackMode_k__BackingField != 1 )
		    {
		      v99 = sub_180035ED0(&TypeInfo::System::ArgumentException);
		      v100 = (InvalidEnumArgumentException *)sub_18002C620(v99);
		      if ( v100 )
		      {
		        v104 = (String *)sub_180035ED0(&off_18E27C928);
		        System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v100, v104, 0LL);
		        v105 = sub_180035ED0(&MethodInfo::HG::Rendering::Runtime::VirtualTextureRenderer::PipelineUpdate);
		        sub_18007E190(v100, v105);
		      }
		      goto LABEL_111;
		    }
		    goto LABEL_46;
		  }
		  if ( !v4->fields.m_globalUVs )
		    sub_1800D8260(v26, v25);
		  System::Collections::Generic::List<Beyond::UI::UIText_RichTextAnalyzer::RichTextParam>::GetEnumerator(
		    &v122,
		    (List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *)v4->fields.m_globalUVs,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::GetEnumerator);
		  *(_OWORD *)&v114._list = *(_OWORD *)&v122._list;
		  *(_OWORD *)&v114._current.current.x = *(_OWORD *)&v122._current.richTextTagType;
		  v114._current.dUVdy = (Vector2)v122._current.value.stringValue;
		  v110.m_Array.m_Buffer = 0LL;
		  *(_QWORD *)&v110.m_Array.m_Length = &v114;
		  try
		  {
		    while ( System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::MoveNext(
		              &v114,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::MoveNext) )
		    {
		      v31 = *(__m128 *)&v114._current.current.x;
		      sub_182F114D0(v29, v28, v30);
		      v35 = sub_182F3EA70(v33, v32);
		      v36 = (float)v4->fields.m_virtualTextureResolution - 1.0;
		      v37 = (float)v4->fields.m_virtualTextureResolution * _mm_shuffle_ps(v31, v31, 85).m128_f32[0];
		      if ( v37 < 0.0 )
		      {
		        v37 = 0.0;
		      }
		      else if ( v37 > v36 )
		      {
		        v37 = (float)v4->fields.m_virtualTextureResolution - 1.0;
		      }
		      v38 = (int)v37;
		      v39 = (float)v4->fields.m_virtualTextureResolution * v31.m128_f32[0];
		      if ( v39 < 0.0 )
		      {
		        v39 = 0.0;
		      }
		      else if ( v39 > (float)((float)v4->fields.m_virtualTextureResolution - 1.0) )
		      {
		        v39 = (float)v4->fields.m_virtualTextureResolution - 1.0;
		      }
		      System::MathF::Floor(v34, v36);
		      System::MathF::Floor(v40, v36);
		      System::MathF::Floor(v41, v36);
		      System::MathF::Floor(v42, v36);
		      sub_182F114D0(v44, v43, v45);
		      v49 = sub_1834464B0(v47, v46, v48) + 1;
		      if ( v35 > v49 )
		        v49 = v35;
		      if ( v49 < 0 )
		      {
		        v49 = 0;
		      }
		      else if ( v49 > v4->fields.m_indirectLevel - 1 )
		      {
		        v49 = v4->fields.m_indirectLevel - 1;
		      }
		      v50 = v4->fields.m_indirectMaxLevel - v49;
		      v51 = v49 & 0x1F;
		      v52 = v38 >> v51;
		      v53 = (int)v39 >> v51;
		      v54 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(v50, v52, v53, 0LL);
		      LODWORD(value.x) = v54;
		      m_nodeCacheLut = v4->fields.m_nodeCacheLut;
		      if ( !m_nodeCacheLut )
		        sub_1800D8250(0LL, v55);
		      if ( !System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey(
		              m_nodeCacheLut,
		              v54,
		              MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey) )
		      {
		        for ( m = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(v50 - 1, v52 >> 1, v53 >> 1, 0LL);
		              ;
		              m = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(
		                    (_DWORD)v111 - 1,
		                    SHIDWORD(v111) >> 1,
		                    Item3 >> 1,
		                    0LL) )
		        {
		          v59 = v4->fields.m_nodeCacheLut;
		          if ( !v59 )
		            sub_1800D8250(0LL, v57);
		          if ( System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey(
		                 v59,
		                 m,
		                 MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey)
		            || v50 <= 1 )
		          {
		            break;
		          }
		          LODWORD(value.x) = m;
		          v60 = HG::Rendering::Runtime::VirtualTextureRenderer::_UnpackNodeKey(&v118, m, 0LL);
		          v111 = *(NativeArray_1_System_UInt32_ **)&v60->Item1;
		          Item3 = v60->Item3;
		          v50 = (int)v111;
		          v112 = v111;
		        }
		      }
		      Unity::Collections::NativeList<unsigned int>::Add(
		        (NativeList_1_System_UInt32_ *)&v109,
		        (uint32_t *)&value,
		        MethodInfo::Unity::Collections::NativeList<unsigned int>::Add);
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v119 )
		  {
		    v110.m_Array.m_Buffer = (Void *)v119->ex;
		    if ( v110.m_Array.m_Buffer )
		      sub_18007E1E0(v110.m_Array.m_Buffer);
		    v4 = this;
		LABEL_46:
		    if ( HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackBufferFilled(v4, 0LL) )
		    {
		      HG::Rendering::Runtime::VirtualTextureRenderer::MarkCurrentGPUFeedbackBufferFilled(v4, 0, 0LL);
		      currGPUFeedbackRequest = HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackRequest(v4, 0LL);
		      if ( !UnityEngine::Rendering::AsyncGPUReadbackRequest::IsDone_Injected(currGPUFeedbackRequest, 0LL) )
		      {
		        v63 = HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackRequest(v4, 0LL);
		        UnityEngine::Rendering::AsyncGPUReadbackRequest::WaitForCompletion_Injected(v63, 0LL);
		      }
		      currGPUFeedbackData = HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackData(v4, 0LL);
		      v111 = currGPUFeedbackData;
		      v65 = 0;
		      for ( n = 0; n < v4->fields.m_feedbackHeight; ++n )
		      {
		        for ( ii = 0; ii < v4->fields.m_feedbackWidth; ++ii )
		        {
		          v68 = *(_DWORD *)&currGPUFeedbackData->m_Buffer[4 * ii + 4 * n * v4->fields.m_feedbackWidth];
		          if ( v65 != v68 )
		          {
		            v65 = *(_DWORD *)&currGPUFeedbackData->m_Buffer[4 * ii + 4 * n * v4->fields.m_feedbackWidth];
		            idx = v65;
		            if ( v68 < 0 )
		            {
		              LODWORD(value.x) = v4->fields.m_indirectMaxLevel - (HIBYTE(v68) & 0xF);
		              v69 = (int)(((unsigned int)v68 >> 12) & 0xFFF) >> (HIBYTE(v68) & 0xF);
		              v70 = (v68 & 0xFFF) >> (HIBYTE(v68) & 0xF);
		              v71 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(SLODWORD(value.x), v69, v70, 0LL);
		              allocator = (AllocatorManager_AllocatorHandle)v71;
		              m_renderQueue = v4->fields.m_nodeCacheLut;
		              if ( !m_renderQueue )
		                goto LABEL_111;
		              if ( !System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey(
		                      m_renderQueue,
		                      v71,
		                      MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey) )
		              {
		                x = value.x;
		                v75 = v70 >> 1;
		                for ( jj = v69 >> 1; ; jj = SHIDWORD(v112) >> 1 )
		                {
		                  v77 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(LODWORD(x) - 1, jj, v75, 0LL);
		                  v78 = v77;
		                  m_renderQueue = v4->fields.m_nodeCacheLut;
		                  if ( !m_renderQueue )
		                    break;
		                  if ( System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey(
		                         m_renderQueue,
		                         v77,
		                         MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey)
		                    || SLODWORD(value.x) <= 1 )
		                  {
		                    goto LABEL_60;
		                  }
		                  allocator = (AllocatorManager_AllocatorHandle)v78;
		                  v79 = HG::Rendering::Runtime::VirtualTextureRenderer::_UnpackNodeKey(
		                          (ValueTuple_3_Int32_Int32_Int32_ *)&v110,
		                          v78,
		                          0LL);
		                  v112 = *(NativeArray_1_System_UInt32_ **)&v79->Item1;
		                  x = *(float *)&v112;
		                  LODWORD(value.x) = (_DWORD)v112;
		                  *(_QWORD *)&v118.Item1 = v112;
		                  v75 = v79->Item3 >> 1;
		                }
		LABEL_111:
		                sub_1800D8250(m_renderQueue, v72);
		              }
		LABEL_60:
		              Unity::Collections::NativeList<unsigned int>::Add(
		                (NativeList_1_System_UInt32_ *)&v109,
		                (uint32_t *)&allocator.Index,
		                MethodInfo::Unity::Collections::NativeList<unsigned int>::Add);
		              v65 = idx;
		              currGPUFeedbackData = v111;
		            }
		          }
		        }
		      }
		    }
		  }
		  v110.m_Array = (NativeArray_1_T_ReadOnly_System_UInt32_)v109.m_Array;
		  Unity::Collections::NativeSortExtension::Sort<unsigned int>(
		    (NativeList_1_System_UInt32_ *)&v110,
		    MethodInfo::Unity::Collections::NativeSortExtension::Sort<unsigned int>);
		  m_renderQueue = (Dictionary_2_System_UInt32_System_Int32_ *)v4->fields.m_renderQueue;
		  if ( !m_renderQueue )
		    goto LABEL_111;
		  ++HIDWORD(m_renderQueue->fields._entries);
		  LODWORD(m_renderQueue->fields._entries) = 0;
		  v80 = -1;
		  Unity::Collections::NativeList<unsigned int>::GetEnumerator(
		    (NativeArray_1_T_Enumerator_System_UInt32_ *)&v110,
		    (NativeList_1_System_UInt32_ *)&v109,
		    MethodInfo::Unity::Collections::NativeList<unsigned int>::GetEnumerator);
		  v115 = v110;
		  v110.m_Array.m_Buffer = 0LL;
		  *(_QWORD *)&v110.m_Array.m_Length = &v115;
		  try
		  {
		    while ( Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<unsigned int>::MoveNext(
		              &v115,
		              MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<unsigned int>::MoveNext) )
		    {
		      v82 = v115.value;
		      if ( v115.value != v80 )
		      {
		        v83 = v4->fields.m_nodeCacheLut;
		        if ( !v83 )
		          sub_1800D8250(0LL, v81);
		        if ( System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue(
		               v83,
		               v115.value,
		               &v108,
		               MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue) )
		        {
		          m_lruCache = v4->fields.m_lruCache;
		          if ( !m_lruCache )
		            sub_1800D8250(0LL, v84);
		          HG::Rendering::Runtime::LRUCache::Visit(m_lruCache, v108, 0LL);
		        }
		        else
		        {
		          v86 = v4->fields.m_renderQueue;
		          if ( !v86 )
		            sub_1800D8250(v85, v84);
		          if ( v86->fields._size < v4->fields._vtMaxPagePerFrame_k__BackingField )
		          {
		            v87 = v4->fields.m_lruCache;
		            if ( !v87 )
		              sub_1800D8250(0LL, v84);
		            v88 = (unsigned __int64)HG::Rendering::Runtime::LRUCache::Allocate(v87, v82, 0LL);
		            v89 = v88;
		            v90 = HIDWORD(v88);
		            if ( HIDWORD(v88) != -1 )
		            {
		              v91 = v4->fields.m_nodeCacheLut;
		              if ( !v91 )
		                sub_1800D8250(0LL, v90);
		              System::Collections::Generic::Dictionary<unsigned int,int>::Remove(
		                v91,
		                HIDWORD(v88),
		                MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Remove);
		            }
		            v92 = v4->fields.m_nodeCacheLut;
		            if ( !v92 )
		              sub_1800D8250(0LL, v90);
		            System::Collections::Generic::Dictionary<unsigned int,int>::Add(
		              v92,
		              v82,
		              v89,
		              MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Add);
		            v94 = v4->fields.m_renderQueue;
		            if ( !v94 )
		              sub_1800D8250(0LL, v93);
		            sub_183E51430(v94, v82, MethodInfo::System::Collections::Generic::List<unsigned int>::Add);
		          }
		        }
		        v80 = v82;
		      }
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v120 )
		  {
		    v110.m_Array.m_Buffer = (Void *)v120->ex;
		    if ( v110.m_Array.m_Buffer )
		      sub_18007E1E0(v110.m_Array.m_Buffer);
		    v4 = this;
		  }
		  Unity::Collections::NativeList<unsigned int>::Dispose(
		    (NativeList_1_System_UInt32_ *)&v109,
		    MethodInfo::Unity::Collections::NativeList<unsigned int>::Dispose);
		  currIndirectTexture = HG::Rendering::Runtime::VirtualTextureRenderer::get_currIndirectTexture(v4, 0LL);
		  HG::Rendering::Runtime::VirtualTextureRenderer::_UpdateClipmapTexture(v4, currIndirectTexture, 0LL);
		  Unity::Collections::NativeList<int>::GetEnumerator(
		    &v109,
		    &v113,
		    MethodInfo::Unity::Collections::NativeList<int>::GetEnumerator);
		  m_Array = v109.m_Array;
		  *(_QWORD *)v117 = *(_QWORD *)&v109.m_Index;
		  v109.m_Array.m_Buffer = 0LL;
		  *(_QWORD *)&v109.m_Array.m_Length = &m_Array;
		  try
		  {
		    while ( (unsigned __int8)sub_183C7BE30(
		                               &m_Array,
		                               MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<int>::MoveNext) )
		    {
		      v98 = v4->fields.m_lruCache;
		      if ( !v98 )
		        sub_1800D8250(0LL, v97);
		      HG::Rendering::Runtime::LRUCache::Unlock(v98, v117[1], 0LL);
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v121 )
		  {
		    v109.m_Array.m_Buffer = (Void *)v121->ex;
		    if ( v109.m_Array.m_Buffer )
		      sub_18007E1E0(v109.m_Array.m_Buffer);
		  }
		  Unity::Collections::NativeList<int>::Dispose(&v113, MethodInfo::Unity::Collections::NativeList<int>::Dispose);
		}
		
		public void GameUpdate(Camera camera) {} // 0x0000000189C2417C-0x0000000189C24C48
		// Void GameUpdate(Camera)
		void HG::Rendering::Runtime::VirtualTextureRenderer::GameUpdate(
		        VirtualTextureRenderer *this,
		        Camera *camera,
		        MethodInfo *method)
		{
		  bool refreshed; // bl
		  bool v6; // al
		  __int64 v7; // rdx
		  TerrainCollider *m_globalUVs; // rcx
		  int32_t feedbackMode_k__BackingField; // eax
		  Transform *transform; // rax
		  Transform *v11; // rbx
		  __int64 v12; // rsi
		  Vector3 *down; // rax
		  float v14; // r8d
		  __int64 v15; // xmm4_8
		  __int64 v16; // xmm3_8
		  int32_t v17; // r12d
		  float i; // xmm13_4
		  int32_t j; // r15d
		  __int64 v20; // r8
		  int v21; // r13d
		  int v22; // esi
		  int32_t m_Y; // edi
		  Vector3 *v24; // rax
		  __int64 v25; // xmm0_8
		  Vector3 *v26; // rax
		  __int64 v27; // xmm0_8
		  __int64 v28; // xmm7_8
		  float z; // edi
		  MethodInfo *v30; // r9
		  Vector3 *v31; // rax
		  __int64 v32; // xmm6_8
		  float v33; // ebx
		  Vector3 *v34; // rax
		  __int64 v35; // xmm0_8
		  MethodInfo *v36; // r9
		  float m_Distance; // xmm1_4
		  MethodInfo *v38; // r9
		  MethodInfo *v39; // rax
		  float *v40; // rdx
		  __int64 v41; // xmm0_8
		  MethodInfo *v42; // r8
		  __int64 v43; // r9
		  float v44; // eax
		  __int64 v45; // xmm5_8
		  float v46; // r11d
		  __int64 v47; // r10
		  float v48; // eax
		  MethodInfo *v49; // r8
		  float v50; // xmm4_4
		  MethodInfo *v51; // r9
		  Vector3 *v52; // rax
		  __int64 v53; // r9
		  __int64 v54; // xmm3_8
		  Vector3 *v55; // rsi
		  MethodInfo *v56; // r8
		  float v57; // xmm4_4
		  MethodInfo *v58; // r9
		  Vector3 *v59; // rax
		  __int64 v60; // r10
		  __int64 v61; // xmm3_8
		  MethodInfo *v62; // r9
		  Vector3 *v63; // rbx
		  __int64 v64; // xmm7_8
		  float v65; // edi
		  __int64 v66; // xmm5_8
		  float v67; // r11d
		  MethodInfo *v68; // r9
		  MethodInfo *v69; // rax
		  __int64 v70; // xmm5_8
		  float v71; // r11d
		  MethodInfo *v72; // rax
		  float *v73; // r9
		  __int64 v74; // xmm0_8
		  __int64 v75; // xmm4_8
		  float v76; // r10d
		  __int64 *v77; // r9
		  __int64 *v78; // rax
		  __int64 v79; // xmm0_8
		  MethodInfo *v80; // r8
		  __int64 *v81; // r8
		  __m128i v82; // xmm2
		  __m128 v83; // xmm3
		  __m128 v84; // xmm1
		  __int64 v85; // xmm0_8
		  float v86; // eax
		  __m128 v87; // xmm4
		  __m128 v88; // xmm5
		  MethodInfo *v89; // r8
		  MethodInfo *v90; // r8
		  float v91; // eax
		  __int64 v92; // xmm5_8
		  __int64 v93; // xmm4_8
		  MethodInfo *v94; // r8
		  MethodInfo *v95; // r8
		  __m128 x_low; // xmm7
		  unsigned int v97; // r10d
		  __m128 v98; // xmm5
		  __m128 v99; // xmm8
		  __m128 v100; // xmm6
		  __int64 v101; // rcx
		  __int64 v102; // rcx
		  Vector2 v103; // rax
		  Vector2 v104; // r8
		  Vector2 v105; // r9
		  Vector2 v106; // xmm4_8
		  __m128 v107; // xmm5
		  __int64 v108; // rcx
		  __int64 v109; // rcx
		  Vector2 v110; // rax
		  Vector2 v111; // r8
		  Vector2 v112; // r9
		  Vector2 v113; // xmm4_8
		  Vector2 v114; // rax
		  Vector2 v115; // r9
		  AsyncGPUReadbackRequest *currGPUFeedbackRequest; // rdi
		  NativeArray_1_System_UInt32_ *currGPUFeedbackData; // rbx
		  ComputeBuffer *currGPUFeedbackBuffer; // rax
		  __int64 v119; // rax
		  InvalidEnumArgumentException *v120; // rbx
		  String *v121; // rax
		  __int64 v122; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Ray v124; // [rsp+48h] [rbp-C0h] BYREF
		  Vector3 v125; // [rsp+68h] [rbp-A0h] BYREF
		  Vector3 v126; // [rsp+78h] [rbp-90h] BYREF
		  Transform *v127; // [rsp+88h] [rbp-80h]
		  Ray v128; // [rsp+90h] [rbp-78h] BYREF
		  HGTerrainRaycastHit v129; // [rsp+A8h] [rbp-60h] BYREF
		  __int128 v130; // [rsp+E0h] [rbp-28h]
		  Vector3 v131; // [rsp+F8h] [rbp-10h] BYREF
		  Vector3 v132; // [rsp+108h] [rbp+0h] BYREF
		  Vector3 v133; // [rsp+118h] [rbp+10h] BYREF
		  Vector3 m_Normal; // [rsp+128h] [rbp+20h] BYREF
		  Vector3 v135; // [rsp+138h] [rbp+30h] BYREF
		  Vector3 v136; // [rsp+148h] [rbp+40h] BYREF
		  Vector3 v137; // [rsp+158h] [rbp+50h] BYREF
		  Vector3 v138; // [rsp+168h] [rbp+60h] BYREF
		  Vector3 v139; // [rsp+178h] [rbp+70h] BYREF
		  Vector3 v140; // [rsp+188h] [rbp+80h] BYREF
		  Vector3 v141; // [rsp+198h] [rbp+90h] BYREF
		  Vector3 v142; // [rsp+1A8h] [rbp+A0h] BYREF
		  Vector3 v143; // [rsp+1B8h] [rbp+B0h] BYREF
		  Vector3 v144; // [rsp+1C8h] [rbp+C0h] BYREF
		  Vector3 v145; // [rsp+1D8h] [rbp+D0h] BYREF
		  Vector3 v146; // [rsp+1E8h] [rbp+E0h] BYREF
		  Vector3 m_Edge02; // [rsp+1F8h] [rbp+F0h] BYREF
		  Vector3 v148; // [rsp+208h] [rbp+100h] BYREF
		  Vector3 m_Edge01; // [rsp+218h] [rbp+110h] BYREF
		  Vector3 v150; // [rsp+228h] [rbp+120h] BYREF
		  Vector3 v151; // [rsp+238h] [rbp+130h] BYREF
		  __int64 v152; // [rsp+248h] [rbp+140h]
		  Vector3 v153; // [rsp+258h] [rbp+150h] BYREF
		  Vector3 v154; // [rsp+268h] [rbp+160h] BYREF
		  __int64 v155; // [rsp+278h] [rbp+170h]
		  Vector3 v156; // [rsp+288h] [rbp+180h] BYREF
		  Vector3 v157; // [rsp+298h] [rbp+190h] BYREF
		  Vector3 v158; // [rsp+2A8h] [rbp+1A0h] BYREF
		  Vector3 v159; // [rsp+2B8h] [rbp+1B0h] BYREF
		  Vector3 v160; // [rsp+2C8h] [rbp+1C0h] BYREF
		  Vector3 v161; // [rsp+2D8h] [rbp+1D0h] BYREF
		  Vector3 v162; // [rsp+2E8h] [rbp+1E0h] BYREF
		  __int64 v163; // [rsp+2F8h] [rbp+1F0h]
		  Vector3 m_Direction; // [rsp+308h] [rbp+200h] BYREF
		  Vector3 v165; // [rsp+318h] [rbp+210h] BYREF
		  Vector3 v166; // [rsp+328h] [rbp+220h] BYREF
		  AsyncGPUReadbackRequest v167; // [rsp+338h] [rbp+230h] BYREF
		  __int128 v168; // [rsp+348h] [rbp+240h] BYREF
		  unsigned __int64 v169; // [rsp+358h] [rbp+250h]
		  Vector3 v170; // [rsp+368h] [rbp+260h] BYREF
		  Vector3 v171; // [rsp+378h] [rbp+270h] BYREF
		  Vector3 v172; // [rsp+388h] [rbp+280h] BYREF
		  Vector3 v173; // [rsp+398h] [rbp+290h] BYREF
		  Vector3 v174; // [rsp+3A8h] [rbp+2A0h] BYREF
		  Vector3 v175; // [rsp+3B8h] [rbp+2B0h] BYREF
		  Vector3 v176; // [rsp+3C8h] [rbp+2C0h] BYREF
		  Vector3 v177; // [rsp+3D8h] [rbp+2D0h] BYREF
		  Vector3 v178; // [rsp+3E8h] [rbp+2E0h] BYREF
		  Vector3 v179; // [rsp+3F8h] [rbp+2F0h] BYREF
		  Vector3 v180; // [rsp+408h] [rbp+300h] BYREF
		  Vector3 v181[12]; // [rsp+418h] [rbp+310h] BYREF
		  Vector2Int currScreenSize; // [rsp+4F0h] [rbp+3E8h] BYREF
		
		  memset(&v128, 0, sizeof(v128));
		  memset(&v129, 0, sizeof(v129));
		  v130 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3969, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3969, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)camera,
		        0LL);
		      return;
		    }
		    goto LABEL_27;
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Equality((Object_1 *)camera, 0LL, 0LL) )
		    return;
		  refreshed = HG::Rendering::Runtime::VirtualTextureRenderer::_RefreshIndirectTextureParams(this, 0LL);
		  v6 = HG::Rendering::Runtime::VirtualTextureRenderer::_RefreshPhysicalCacheParams(this, 0LL);
		  if ( v6 || refreshed )
		  {
		    this->fields.m_needVTDataBufferSetup = 1;
		    if ( v6 )
		      this->fields.m_needVTTexturesSetup = 1;
		  }
		  if ( !camera )
		    goto LABEL_27;
		  currScreenSize.m_X = UnityEngine::Camera::get_pixelWidth(camera, 0LL);
		  currScreenSize.m_Y = UnityEngine::Camera::get_pixelHeight(camera, 0LL);
		  feedbackMode_k__BackingField = this->fields._feedbackMode_k__BackingField;
		  if ( feedbackMode_k__BackingField )
		  {
		    if ( feedbackMode_k__BackingField == 1 )
		    {
		      HG::Rendering::Runtime::VirtualTextureRenderer::_RefreshGPUFeedbackParams(this, &currScreenSize, 0LL);
		      if ( HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackBufferFilled(this, 0LL) )
		      {
		        currGPUFeedbackRequest = HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackRequest(this, 0LL);
		        currGPUFeedbackData = HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackData(this, 0LL);
		        currGPUFeedbackBuffer = HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackBuffer(this, 0LL);
		        UnityEngine::Rendering::AsyncGPUReadback::RequestIntoNativeArray<unsigned int>(
		          &v167,
		          currGPUFeedbackData,
		          currGPUFeedbackBuffer,
		          0LL,
		          MethodInfo::UnityEngine::Rendering::AsyncGPUReadback::RequestIntoNativeArray<unsigned int>);
		        *currGPUFeedbackRequest = v167;
		      }
		      return;
		    }
		    v119 = sub_18007E180(&TypeInfo::System::ArgumentException);
		    v120 = (InvalidEnumArgumentException *)sub_18002C620(v119);
		    if ( v120 )
		    {
		      v121 = (String *)sub_18007E180(&off_18E27C758);
		      System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v120, v121, 0LL);
		      v122 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VirtualTextureRenderer::GameUpdate);
		      sub_18007E190(v120, v122);
		    }
		LABEL_27:
		    sub_1800D8260(m_globalUVs, v7);
		  }
		  HG::Rendering::Runtime::VirtualTextureRenderer::_RefreshCPUFeedbackParams(this, &currScreenSize, 0LL);
		  transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		  v127 = transform;
		  v11 = transform;
		  if ( !transform )
		    goto LABEL_27;
		  UnityEngine::Transform::get_position(&v126, transform, 0LL);
		  m_globalUVs = (TerrainCollider *)this->fields.m_globalUVs;
		  if ( !m_globalUVs )
		    goto LABEL_27;
		  ++HIDWORD(m_globalUVs[1].klass);
		  LODWORD(m_globalUVs[1].klass) = 0;
		  v12 = this->fields.m_frameCount % (__int64)(this->fields.m_blockWidth * this->fields.m_blockHeight);
		  v163 = v12;
		  down = UnityEngine::Vector3::get_down(&v126, (MethodInfo *)v12);
		  v125.z = v14;
		  *(_QWORD *)&v125.x = v15;
		  v16 = *(_QWORD *)&down->x;
		  *(float *)&down = down->z;
		  *(_QWORD *)&v124.m_Origin.x = v16;
		  LODWORD(v124.m_Origin.z) = (_DWORD)down;
		  UnityEngine::Ray::Ray(&v128, &v125, &v124.m_Origin, 0LL);
		  v17 = 0;
		  for ( i = UnityEngine::Camera::get_fieldOfView(camera, 0LL); v17 < this->fields.m_feedbackHeight; ++v17 )
		  {
		    for ( j = 0; j < this->fields.m_feedbackWidth; ++j )
		    {
		      v20 = j + this->fields.m_feedbackWidth * v17;
		      v21 = this->fields.m_blockWidth * j
		          + *(__int16 *)&this->fields.m_feedbackJitterSeq.m_Buffer[4 * (int)v12
		                                                                 + 4
		                                                                 * *(_DWORD *)&this->fields.m_cpuJitterOffsets.m_Buffer[4 * v20]];
		      v22 = this->fields.m_blockHeight * v17
		          + *(__int16 *)&this->fields.m_feedbackJitterSeq.m_Buffer[4 * (int)v12
		                                                                 + 2
		                                                                 + 4
		                                                                 * *(_DWORD *)&this->fields.m_cpuJitterOffsets.m_Buffer[4 * v20]];
		      if ( v21 < currScreenSize.m_X )
		      {
		        m_Y = currScreenSize.m_Y;
		        if ( v22 < currScreenSize.m_Y )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
		          v24 = HG::Rendering::Runtime::HGTerrainUtils::ScreenPointToRay(
		                  &v180,
		                  v11,
		                  i,
		                  v21,
		                  v22,
		                  currScreenSize.m_X,
		                  m_Y,
		                  0LL);
		          v25 = *(_QWORD *)&v24->x;
		          *(float *)&v24 = v24->z;
		          *(_QWORD *)&v125.x = v25;
		          LODWORD(v125.z) = (_DWORD)v24;
		          UnityEngine::Ray::set_direction(&v128, &v125, 0LL);
		          m_globalUVs = this->fields.m_collider;
		          if ( !m_globalUVs )
		            goto LABEL_27;
		          v124 = v128;
		          if ( UnityEngine::TerrainCollider::HGTerrainRaycast(m_globalUVs, &v124, &v129, 1000.0, 0, 0LL) )
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
		            v26 = HG::Rendering::Runtime::HGTerrainUtils::ScreenPointToRay(
		                    &v179,
		                    v11,
		                    i,
		                    v21 + 1,
		                    v22,
		                    currScreenSize.m_X,
		                    m_Y,
		                    0LL);
		            v27 = *(_QWORD *)&v26->x;
		            *(float *)&v26 = v26->z;
		            v28 = *(_QWORD *)&v128.m_Direction.x;
		            z = v128.m_Direction.z;
		            m_Direction = v128.m_Direction;
		            *(_QWORD *)&v165.x = v27;
		            LODWORD(v165.z) = (_DWORD)v26;
		            v31 = UnityEngine::Vector3::op_Subtraction(&v176, &v165, &m_Direction, v30);
		            v32 = *(_QWORD *)&v31->x;
		            v33 = v31->z;
		            v34 = HG::Rendering::Runtime::HGTerrainUtils::ScreenPointToRay(
		                    &v170,
		                    v127,
		                    i,
		                    v21,
		                    v22 + 1,
		                    currScreenSize.m_X,
		                    currScreenSize.m_Y,
		                    0LL);
		            v35 = *(_QWORD *)&v34->x;
		            *(float *)&v34 = v34->z;
		            *(_QWORD *)&v131.x = v35;
		            LODWORD(v131.z) = (_DWORD)v34;
		            *(_QWORD *)&v166.x = v28;
		            v166.z = z;
		            UnityEngine::Vector3::op_Subtraction(&v171, &v131, &v166, v36);
		            m_Distance = v129.m_Distance;
		            *(_QWORD *)&v132.x = v32;
		            v132.z = v33;
		            v39 = (MethodInfo *)UnityEngine::Vector3::op_Multiply(&v172, v129.m_Distance, &v132, v38);
		            v41 = *(_QWORD *)v40;
		            v133.z = v40[2];
		            *(_QWORD *)&v133.x = v41;
		            UnityEngine::Vector3::op_Multiply(&v173, m_Distance, &v133, v39);
		            m_Normal = v129.m_Normal;
		            *(_QWORD *)&v135.x = v28;
		            v135.z = z;
		            UnityEngine::Vector3::Dot(&v135, &m_Normal, v42);
		            v44 = *(float *)(v43 + 8);
		            *(_QWORD *)&v137.x = *(_QWORD *)v43;
		            *(_QWORD *)&v136.x = v45;
		            v136.z = v46;
		            v137.z = v44;
		            v48 = *(float *)(v47 + 8);
		            *(_QWORD *)&v142.x = *(_QWORD *)v47;
		            *(_QWORD *)&v141.x = v45;
		            v141.z = v46;
		            v142.z = v48;
		            *(_QWORD *)&v138.x = v28;
		            v138.z = z;
		            *(float *)&v41 = UnityEngine::Vector3::Dot(&v137, &v136, v49);
		            v52 = UnityEngine::Vector3::op_Multiply(&v174, &v138, (float)-*(float *)&v41 * v50, v51);
		            *(_QWORD *)&v140.x = *(_QWORD *)v53;
		            v54 = *(_QWORD *)&v52->x;
		            v139.z = v52->z;
		            v140.z = *(float *)(v53 + 8);
		            *(_QWORD *)&v139.x = v54;
		            v55 = UnityEngine::Vector3::op_Addition(&v175, &v140, &v139, (MethodInfo *)v53);
		            *(_QWORD *)&v143.x = v28;
		            v143.z = z;
		            *(float *)&v41 = UnityEngine::Vector3::Dot(&v142, &v141, v56);
		            v59 = UnityEngine::Vector3::op_Multiply(v181, &v143, (float)-*(float *)&v41 * v57, v58);
		            *(_QWORD *)&v145.x = *(_QWORD *)v60;
		            v61 = *(_QWORD *)&v59->x;
		            v144.z = v59->z;
		            v145.z = *(float *)(v60 + 8);
		            *(_QWORD *)&v144.x = v61;
		            v63 = UnityEngine::Vector3::op_Addition(&v177, &v145, &v144, v62);
		            v64 = *(_QWORD *)&v129.m_Edge02.x;
		            v65 = v129.m_Edge02.z;
		            m_Edge02 = v129.m_Edge02;
		            *(_QWORD *)&v146.x = v66;
		            v146.z = v67;
		            v69 = (MethodInfo *)UnityEngine::Vector3::Cross(&v178, &m_Edge02, &v146, v68);
		            m_Edge01 = v129.m_Edge01;
		            *(_QWORD *)&v148.x = v70;
		            v148.z = v71;
		            v72 = (MethodInfo *)UnityEngine::Vector3::Cross((Vector3 *)&v167, &m_Edge01, &v148, v69);
		            v74 = *(_QWORD *)v73;
		            v151.z = v73[2];
		            *(_QWORD *)&v150.x = v75;
		            v150.z = v76;
		            *(_QWORD *)&v151.x = v74;
		            *(float *)&v74 = UnityEngine::Vector3::Dot(&v151, &v150, v72);
		            LODWORD(v32) = *((_DWORD *)v77 + 2);
		            v152 = *v77;
		            *(float *)&v32 = *(float *)&v32 / *(float *)&v74;
		            v79 = *v78;
		            LODWORD(v78) = *((_DWORD *)v78 + 2);
		            *(_QWORD *)&v154.x = v79;
		            LODWORD(v154.z) = (_DWORD)v78;
		            *(_QWORD *)&v153.x = v64;
		            v153.z = v65;
		            *(float *)&v79 = UnityEngine::Vector3::Dot(&v154, &v153, v80);
		            v82 = (__m128i)*((unsigned int *)v81 + 2);
		            v155 = *v81;
		            v83 = (__m128)(unsigned int)v155;
		            v84 = (__m128)HIDWORD(v155);
		            v83.m128_f32[0] = *(float *)&v155 / *(float *)&v79;
		            v84.m128_f32[0] = *((float *)&v155 + 1) / *(float *)&v79;
		            *(float *)v82.m128i_i32 = *(float *)v82.m128i_i32 / *(float *)&v79;
		            v85 = *(_QWORD *)&v55->x;
		            v86 = v55->z;
		            v89 = (MethodInfo *)(unsigned int)_mm_cvtsi128_si32(v82);
		            *(_QWORD *)&v159.x = _mm_unpacklo_ps(v83, v84).m128_u64[0];
		            LODWORD(v157.z) = v32;
		            *(_QWORD *)&v156.x = v85;
		            v156.z = v86;
		            *(_QWORD *)&v157.x = _mm_unpacklo_ps(v88, v87).m128_u64[0];
		            *(_QWORD *)&v158.x = v85;
		            v158.z = v86;
		            LODWORD(v159.z) = (_DWORD)v89;
		            UnityEngine::Vector3::Dot(&v157, &v156, v89);
		            UnityEngine::Vector3::Dot(&v159, &v158, v90);
		            v91 = v63->z;
		            *(_QWORD *)&v160.x = *(_QWORD *)&v63->x;
		            *(_QWORD *)&v162.x = *(_QWORD *)&v160.x;
		            LODWORD(v161.z) = v32;
		            v160.z = v91;
		            *(_QWORD *)&v161.x = v92;
		            v162.z = v91;
		            *(_QWORD *)&v126.x = v93;
		            LODWORD(v126.z) = (_DWORD)v94;
		            UnityEngine::Vector3::Dot(&v161, &v160, v94);
		            UnityEngine::Vector3::Dot(&v126, &v162, v95);
		            x_low = (__m128)LODWORD(v129.m_Edge01.x);
		            x_low.m128_f32[0] = v129.m_Edge01.x * this->fields.m_worldToVirtual.x;
		            v98 = (__m128)_mm_cvtsi32_si128(v97);
		            v98.m128_f32[0] = v98.m128_f32[0] * this->fields.m_worldToVirtual.y;
		            v99 = (__m128)LODWORD(v129.m_Edge02.x);
		            v99.m128_f32[0] = v129.m_Edge02.x * this->fields.m_worldToVirtual.y;
		            v100 = (__m128)_mm_cvtsi32_si128(LODWORD(v65));
		            v100.m128_f32[0] = v100.m128_f32[0] * this->fields.m_worldToVirtual.y;
		            v84.m128_f32[0] = (float)(v129.m_Position.x + this->fields.m_terrainPosOffset.x)
		                            * this->fields.m_worldToVirtual.x;
		            *((float *)&v130 + 1) = (float)(v129.m_Position.z + this->fields.m_terrainPosOffset.y)
		                                  * this->fields.m_worldToVirtual.y;
		            LODWORD(v130) = v84.m128_i32[0];
		            sub_185EDD110(v101, _mm_unpacklo_ps(x_low, v98).m128_u64[0]);
		            v103 = (Vector2)sub_185EDD110(v102, _mm_unpacklo_ps(v99, v100).m128_u64[0]);
		            *(Vector2 *)&v124.m_Origin.x = sub_1853DF234(v106, v103, v104, v105);
		            *((_QWORD *)&v130 + 1) = *(_QWORD *)&v124.m_Origin.x;
		            sub_185EDD110(v108, _mm_unpacklo_ps(x_low, v107).m128_u64[0]);
		            v110 = (Vector2)sub_185EDD110(v109, _mm_unpacklo_ps(v99, v100).m128_u64[0]);
		            v114 = sub_1853DF234(v113, v110, v111, v112);
		            *(Vector2 *)&v124.m_Origin.x = v114;
		            if ( !*(_QWORD *)&v115 )
		              goto LABEL_27;
		            v168 = v130;
		            v169 = _mm_unpacklo_ps((__m128)LODWORD(v124.m_Origin.x), (__m128)LODWORD(v114.y)).m128_u64[0];
		            ((void (__fastcall *)(_QWORD, _QWORD, _QWORD))sub_180478AB0)(
		              v115,
		              &v168,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::Add);
		            v11 = v127;
		          }
		        }
		      }
		      LODWORD(v12) = v163;
		    }
		  }
		}
		
		public void Render(ScriptableRenderContext renderContext) {} // 0x0000000189C25AF4-0x0000000189C274B0
		// Void Render(ScriptableRenderContext)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::VirtualTextureRenderer::Render(
		        VirtualTextureRenderer *this,
		        ScriptableRenderContext renderContext,
		        MethodInfo *method)
		{
		  VirtualTextureRenderer *v3; // r15
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_System_UInt32_ *m_renderQueue; // rbx
		  CommandBuffer *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  CommandBuffer *v10; // r12
		  ComputeShader *m_vtBakeCS; // rsi
		  __int64 v12; // rdx
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  int32_t HGTerrainPerTerrain; // r13d
		  ComputeBuffer *terrainBakeDataBuffer_k__BackingField; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  int32_t count; // edi
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  int32_t stride; // ebx
		  ComputeShader *v22; // rbx
		  int32_t m_vtBakeMainKernel; // edi
		  int32_t HGTerrainPhysicalBase; // esi
		  RenderTargetIdentifier *v25; // rax
		  __int128 v26; // xmm7
		  __int64 v27; // xmm8_8
		  ComputeShader *v28; // rbx
		  int32_t v29; // edi
		  int32_t HGTerrainColorVariationTex; // esi
		  RenderTargetIdentifier *v31; // rax
		  __int128 v32; // xmm7
		  __int64 v33; // xmm8_8
		  ComputeShader *v34; // rbx
		  int32_t v35; // edi
		  int32_t HGTerrainControlMap; // esi
		  RenderTargetIdentifier *v37; // rax
		  __int128 v38; // xmm7
		  __int64 v39; // xmm8_8
		  ComputeShader *v40; // rbx
		  int32_t v41; // edi
		  int32_t HGTerrainSplatIndexMap; // esi
		  RenderTargetIdentifier *v43; // rax
		  __int128 v44; // xmm7
		  __int64 v45; // xmm8_8
		  ComputeShader *v46; // rbx
		  int32_t v47; // edi
		  int32_t HGTerrainSplats; // esi
		  RenderTargetIdentifier *v49; // rax
		  __int128 v50; // xmm7
		  __int64 v51; // xmm8_8
		  ComputeShader *v52; // rbx
		  int32_t v53; // edi
		  int32_t HGTerrainNormals; // esi
		  RenderTargetIdentifier *v55; // rax
		  __int128 v56; // xmm7
		  __int64 v57; // xmm8_8
		  ComputeShader *v58; // rbx
		  int32_t v59; // edi
		  int32_t HGTerrainTerrainNormalmapTexture; // esi
		  RenderTargetIdentifier *v61; // rax
		  __int128 v62; // xmm7
		  __int64 v63; // xmm8_8
		  Object_1 *m_decalDiffuseTexArray; // rbx
		  __int64 v65; // rdx
		  Dictionary_2_System_UInt32_System_Object_ *m_decalInstanceInfo; // rcx
		  HGTerrainConfiguration *m_configuration; // rbx
		  ComputeShader *v68; // rbx
		  int32_t v69; // edi
		  int32_t HGTerrainDecalDiffuseTexArray; // esi
		  RenderTargetIdentifier *v71; // rax
		  __int128 v72; // xmm7
		  __int64 v73; // xmm8_8
		  ComputeShader *v74; // rbx
		  int32_t v75; // edi
		  int32_t HGTerrainDecalNormalMROTexArray; // esi
		  RenderTargetIdentifier *v77; // rax
		  __int128 v78; // xmm7
		  __int64 v79; // xmm8_8
		  ComputeShader *v80; // rbx
		  int32_t v81; // edi
		  int32_t HGTerrainHeightmap; // esi
		  RenderTargetIdentifier *v83; // rax
		  __int128 v84; // xmm7
		  __int64 v85; // xmm8_8
		  int32_t i; // ebx
		  List_1_System_UInt32_ *v87; // rax
		  ValueTuple_3_Int32_Int32_Int32_ *v88; // rax
		  int Item3; // esi
		  int32_t v90; // edi
		  float v91; // xmm4_4
		  unsigned int v92; // xmm3_4
		  unsigned int v93; // xmm2_4
		  int v94; // r9d
		  float v95; // xmm1_4
		  ComputeShader *v96; // rbx
		  RenderTargetIdentifier *v97; // rax
		  __int128 v98; // xmm7
		  __int64 v99; // xmm8_8
		  ComputeShader *v100; // rbx
		  RenderTargetIdentifier *v101; // rax
		  __int128 v102; // xmm7
		  __int64 v103; // xmm8_8
		  __int64 v104; // rdx
		  __int64 v105; // r8
		  bool v106; // bl
		  int32_t m_decalMaxLevel; // eax
		  int32_t v108; // ecx
		  __int64 v109; // rcx
		  int v110; // edi
		  int32_t v111; // esi
		  int v112; // ebx
		  double v113; // xmm0_8
		  signed int v114; // eax
		  int v115; // esi
		  uint32_t v116; // eax
		  __int64 v117; // r8
		  Object *v118; // rdi
		  unsigned int v119; // eax
		  MethodInfo *v120; // rbx
		  HGTerrainRuntimeResources_DecalPerInstanceData *v121; // rax
		  char v122; // cl
		  int32_t Length; // esi
		  __int64 v124; // rdx
		  __int64 v125; // rcx
		  __int64 v126; // r8
		  __int64 v127; // rdx
		  __int64 v128; // rcx
		  double v129; // xmm0_8
		  __int64 v130; // rcx
		  char v131; // al
		  unsigned int v132; // esi
		  int v133; // ebx
		  __int64 v134; // rdx
		  __int64 v135; // rcx
		  __int64 v136; // rdx
		  __int64 v137; // rcx
		  signed int v138; // eax
		  unsigned int v139; // ebx
		  __int64 v140; // r12
		  int32_t j; // esi
		  __int64 v142; // rdx
		  __int64 v143; // r8
		  MethodInfo *v144; // rbx
		  HGTerrainRuntimeResources_DecalPerInstanceData *v145; // rax
		  Object *v146; // rbx
		  float v147; // xmm6_4
		  ComputeShader *v148; // rbx
		  ComputeShader *v149; // rdi
		  int32_t HGTerrainDecalInstanceData; // ebx
		  ComputeShader *v151; // rbx
		  int32_t HGTerrainUVTransform; // r8d
		  int32_t HGTerrainRTOffset; // r8d
		  Vector4 v154; // xmm6
		  ComputeShader *m_vtCompressCS; // rbx
		  ComputeShader *v156; // rsi
		  int32_t m_vtCompressMainKernel; // edi
		  unsigned int v158; // eax
		  Dictionary_2_System_UInt32_System_Int32_ *m_nodeCacheLut; // rbx
		  RegexCharClass_SingleRange Item; // eax
		  int32_t layer; // edi
		  int32_t v162; // esi
		  int32_t v163; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v165; // rdx
		  __int64 v166; // rcx
		  uint32_t key; // [rsp+70h] [rbp-298h]
		  uint32_t keyd; // [rsp+70h] [rbp-298h]
		  uint32_t keye; // [rsp+70h] [rbp-298h]
		  uint32_t keya; // [rsp+70h] [rbp-298h]
		  uint32_t keyb; // [rsp+70h] [rbp-298h]
		  uint32_t keyc; // [rsp+70h] [rbp-298h]
		  int32_t v173; // [rsp+74h] [rbp-294h]
		  int32_t v174; // [rsp+74h] [rbp-294h]
		  int32_t v175; // [rsp+74h] [rbp-294h]
		  char v176; // [rsp+74h] [rbp-294h]
		  unsigned int v177; // [rsp+78h] [rbp-290h]
		  int v178; // [rsp+78h] [rbp-290h]
		  int v179; // [rsp+78h] [rbp-290h]
		  int32_t v180; // [rsp+78h] [rbp-290h]
		  int32_t col; // [rsp+7Ch] [rbp-28Ch]
		  int32_t cola; // [rsp+7Ch] [rbp-28Ch]
		  int32_t colb; // [rsp+7Ch] [rbp-28Ch]
		  int32_t v184; // [rsp+80h] [rbp-288h]
		  unsigned int v185; // [rsp+80h] [rbp-288h]
		  int v186; // [rsp+84h] [rbp-284h]
		  int v187; // [rsp+84h] [rbp-284h]
		  int v188; // [rsp+88h] [rbp-280h]
		  RenderTargetIdentifier keyword; // [rsp+90h] [rbp-278h] BYREF
		  int v190; // [rsp+C0h] [rbp-248h]
		  int v191; // [rsp+C4h] [rbp-244h]
		  unsigned __int64 v192; // [rsp+C8h] [rbp-240h]
		  RenderTargetIdentifier rt; // [rsp+D0h] [rbp-238h] BYREF
		  __int64 v194; // [rsp+100h] [rbp-208h]
		  int32_t value[2]; // [rsp+108h] [rbp-200h] BYREF
		  int v196; // [rsp+110h] [rbp-1F8h]
		  int32_t v197; // [rsp+114h] [rbp-1F4h] BYREF
		  int32_t level; // [rsp+118h] [rbp-1F0h]
		  HashSet_1_System_UInt64_ *v199; // [rsp+120h] [rbp-1E8h] BYREF
		  int v200; // [rsp+128h] [rbp-1E0h]
		  Vector4 v201; // [rsp+130h] [rbp-1D8h]
		  __int128 v202; // [rsp+140h] [rbp-1C8h]
		  Object *v203; // [rsp+150h] [rbp-1B8h] BYREF
		  Object *v204; // [rsp+158h] [rbp-1B0h] BYREF
		  NativeList_1_HG_Rendering_Runtime_HGTerrainRuntimeResources_DecalPerInstanceData_ v205; // [rsp+160h] [rbp-1A8h] BYREF
		  Vector4 v206; // [rsp+170h] [rbp-198h]
		  CommandBuffer *v207; // [rsp+180h] [rbp-188h]
		  VirtualTextureRenderer *v208; // [rsp+188h] [rbp-180h]
		  Object *v209; // [rsp+190h] [rbp-178h] BYREF
		  unsigned __int64 v210; // [rsp+198h] [rbp-170h]
		  __int128 v211; // [rsp+1A8h] [rbp-160h]
		  HashSet_1_T_Enumerator_System_Int32_ v212; // [rsp+1B8h] [rbp-150h] BYREF
		  Il2CppException *ex; // [rsp+1D0h] [rbp-138h]
		  HashSet_1_T_Enumerator_System_Int32_ *v214; // [rsp+1D8h] [rbp-130h]
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ v215; // [rsp+1E0h] [rbp-128h] BYREF
		  Vector4 val; // [rsp+200h] [rbp-108h] BYREF
		  Vector4 v217; // [rsp+210h] [rbp-F8h] BYREF
		  unsigned __int64 v218; // [rsp+220h] [rbp-E8h]
		  Il2CppExceptionWrapper *v219; // [rsp+230h] [rbp-D8h] BYREF
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ v220; // [rsp+240h] [rbp-C8h] BYREF
		  ValueTuple_3_Int32_Int32_Int32_ v221; // [rsp+250h] [rbp-B8h] BYREF
		  ObjectPool_1_T_PooledObject_System_Collections_Generic_List_1_HG_Rendering_Runtime_HGRenderPipeline_RenderRequest_ v222; // [rsp+260h] [rbp-A8h] BYREF
		  ScriptableRenderContext P1; // [rsp+318h] [rbp+10h] BYREF
		  ComputeBuffer *buffer; // [rsp+328h] [rbp+20h]
		
		  P1.m_Ptr = renderContext.m_Ptr;
		  v3 = this;
		  v208 = this;
		  v206 = 0LL;
		  v201 = 0LL;
		  value[0] = 0;
		  v205 = 0LL;
		  v204 = 0LL;
		  v209 = 0LL;
		  v199 = 0LL;
		  memset(&v212, 0, sizeof(v212));
		  v203 = 0LL;
		  v215 = 0LL;
		  v197 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(3990, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3990, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v166, v165);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_204(Patch, (Object *)v3, P1, 0LL);
		    return;
		  }
		  m_renderQueue = v3->fields.m_renderQueue;
		  if ( !m_renderQueue )
		    sub_1800D8260(v5, v4);
		  if ( !m_renderQueue->fields._size )
		    return;
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::CommandBufferPool);
		  v7 = UnityEngine::Rendering::CommandBufferPool::Get((String *)"TerrainVTBake", 0LL);
		  v10 = v7;
		  v207 = v7;
		  if ( !v7 )
		    sub_1800D8260(v9, v8);
		  UnityEngine::Rendering::CommandBuffer::Clear(v7, 0LL);
		  m_vtBakeCS = v3->fields.m_vtBakeCS;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  HGTerrainPerTerrain = static_fields->_HGTerrainPerTerrain;
		  terrainBakeDataBuffer_k__BackingField = v3->fields._terrainBakeDataBuffer_k__BackingField;
		  buffer = terrainBakeDataBuffer_k__BackingField;
		  if ( !terrainBakeDataBuffer_k__BackingField )
		    sub_1800D8260(static_fields, v12);
		  count = UnityEngine::ComputeBuffer::get_count(terrainBakeDataBuffer_k__BackingField, 0LL);
		  if ( !v3->fields._terrainBakeDataBuffer_k__BackingField )
		    sub_1800D8260(v17, v16);
		  stride = UnityEngine::ComputeBuffer::get_stride(v3->fields._terrainBakeDataBuffer_k__BackingField, 0LL);
		  if ( !v10 )
		    sub_1800D8260(v20, v19);
		  UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
		    v10,
		    m_vtBakeCS,
		    HGTerrainPerTerrain,
		    buffer,
		    0,
		    count * stride,
		    0LL);
		  if ( v3->fields.m_enableCompression )
		  {
		    UnityEngine::Rendering::CommandBuffer::EnableKeyword(
		      v10,
		      v3->fields.m_vtBakeCS,
		      &v3->fields.m_enableCompressKeywordCS,
		      0LL);
		    v22 = v3->fields.m_vtBakeCS;
		    m_vtBakeMainKernel = v3->fields.m_vtBakeMainKernel;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    HGTerrainPhysicalBase = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainPhysicalBase;
		    v25 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&rt, (Texture *)v3->fields.m_pageRt, 0LL);
		    v26 = *(_OWORD *)&v25->m_BufferPointer;
		    v27 = *(_QWORD *)&v25->m_DepthSlice;
		    *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v25->m_Type;
		    *(_OWORD *)&keyword.m_BufferPointer = v26;
		    *(_QWORD *)&keyword.m_DepthSlice = v27;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		      v10,
		      v22,
		      m_vtBakeMainKernel,
		      HGTerrainPhysicalBase,
		      &keyword,
		      0,
		      0LL);
		  }
		  else
		  {
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(
		      v10,
		      v3->fields.m_vtBakeCS,
		      &v3->fields.m_enableCompressKeywordCS,
		      0LL);
		  }
		  v28 = v3->fields.m_vtBakeCS;
		  v29 = v3->fields.m_vtBakeMainKernel;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  HGTerrainColorVariationTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainColorVariationTex;
		  v31 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&rt, (Texture *)v3->fields.m_colorVariationTex, 0LL);
		  v32 = *(_OWORD *)&v31->m_BufferPointer;
		  v33 = *(_QWORD *)&v31->m_DepthSlice;
		  *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v31->m_Type;
		  *(_OWORD *)&keyword.m_BufferPointer = v32;
		  *(_QWORD *)&keyword.m_DepthSlice = v33;
		  UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		    v10,
		    v28,
		    v29,
		    HGTerrainColorVariationTex,
		    &keyword,
		    0LL);
		  v34 = v3->fields.m_vtBakeCS;
		  v35 = v3->fields.m_vtBakeMainKernel;
		  HGTerrainControlMap = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainControlMap;
		  v37 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&rt, (Texture *)v3->fields.m_splatControlMap, 0LL);
		  v38 = *(_OWORD *)&v37->m_BufferPointer;
		  v39 = *(_QWORD *)&v37->m_DepthSlice;
		  *(_OWORD *)&rt.m_Type = *(_OWORD *)&v37->m_Type;
		  *(_OWORD *)&rt.m_BufferPointer = v38;
		  *(_QWORD *)&rt.m_DepthSlice = v39;
		  UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(v10, v34, v35, HGTerrainControlMap, &rt, 0LL);
		  v40 = v3->fields.m_vtBakeCS;
		  v41 = v3->fields.m_vtBakeMainKernel;
		  HGTerrainSplatIndexMap = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainSplatIndexMap;
		  v43 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		          &keyword,
		          (Texture *)v3->fields.m_splatIndexMap,
		          0LL);
		  v44 = *(_OWORD *)&v43->m_BufferPointer;
		  v45 = *(_QWORD *)&v43->m_DepthSlice;
		  *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v43->m_Type;
		  *(_OWORD *)&keyword.m_BufferPointer = v44;
		  *(_QWORD *)&keyword.m_DepthSlice = v45;
		  UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(v10, v40, v41, HGTerrainSplatIndexMap, &keyword, 0LL);
		  v46 = v3->fields.m_vtBakeCS;
		  v47 = v3->fields.m_vtBakeMainKernel;
		  HGTerrainSplats = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainSplats;
		  v49 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		          &rt,
		          (Texture *)v3->fields.m_splatsDiffuseArray,
		          0LL);
		  v50 = *(_OWORD *)&v49->m_BufferPointer;
		  v51 = *(_QWORD *)&v49->m_DepthSlice;
		  *(_OWORD *)&rt.m_Type = *(_OWORD *)&v49->m_Type;
		  *(_OWORD *)&rt.m_BufferPointer = v50;
		  *(_QWORD *)&rt.m_DepthSlice = v51;
		  UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(v10, v46, v47, HGTerrainSplats, &rt, 0LL);
		  v52 = v3->fields.m_vtBakeCS;
		  v53 = v3->fields.m_vtBakeMainKernel;
		  HGTerrainNormals = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainNormals;
		  v55 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		          &keyword,
		          (Texture *)v3->fields.m_splatsNormalArray,
		          0LL);
		  v56 = *(_OWORD *)&v55->m_BufferPointer;
		  v57 = *(_QWORD *)&v55->m_DepthSlice;
		  *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v55->m_Type;
		  *(_OWORD *)&keyword.m_BufferPointer = v56;
		  *(_QWORD *)&keyword.m_DepthSlice = v57;
		  UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(v10, v52, v53, HGTerrainNormals, &keyword, 0LL);
		  v58 = v3->fields.m_vtBakeCS;
		  v59 = v3->fields.m_vtBakeMainKernel;
		  HGTerrainTerrainNormalmapTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainTerrainNormalmapTexture;
		  v61 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&rt, (Texture *)v3->fields.m_terrainNormalMap, 0LL);
		  v62 = *(_OWORD *)&v61->m_BufferPointer;
		  v63 = *(_QWORD *)&v61->m_DepthSlice;
		  *(_OWORD *)&rt.m_Type = *(_OWORD *)&v61->m_Type;
		  *(_OWORD *)&rt.m_BufferPointer = v62;
		  *(_QWORD *)&rt.m_DepthSlice = v63;
		  UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		    v10,
		    v58,
		    v59,
		    HGTerrainTerrainNormalmapTexture,
		    &rt,
		    0LL);
		  m_decalDiffuseTexArray = (Object_1 *)v3->fields.m_decalDiffuseTexArray;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Inequality(m_decalDiffuseTexArray, 0LL, 0LL) )
		    goto LABEL_15;
		  m_configuration = v3->fields.m_configuration;
		  if ( !m_configuration )
		    sub_1800D8260(m_decalInstanceInfo, v65);
		  if ( m_configuration->fields.enableDecal )
		  {
		    LOBYTE(buffer) = 1;
		    v68 = v3->fields.m_vtBakeCS;
		    v69 = v3->fields.m_vtBakeMainKernel;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    HGTerrainDecalDiffuseTexArray = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainDecalDiffuseTexArray;
		    v71 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		            &rt,
		            (Texture *)v3->fields.m_decalDiffuseTexArray,
		            0LL);
		    v72 = *(_OWORD *)&v71->m_BufferPointer;
		    v73 = *(_QWORD *)&v71->m_DepthSlice;
		    *(_OWORD *)&rt.m_Type = *(_OWORD *)&v71->m_Type;
		    *(_OWORD *)&rt.m_BufferPointer = v72;
		    *(_QWORD *)&rt.m_DepthSlice = v73;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		      v10,
		      v68,
		      v69,
		      HGTerrainDecalDiffuseTexArray,
		      &rt,
		      0LL);
		    v74 = v3->fields.m_vtBakeCS;
		    v75 = v3->fields.m_vtBakeMainKernel;
		    HGTerrainDecalNormalMROTexArray = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainDecalNormalMROTexArray;
		    v77 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		            &keyword,
		            (Texture *)v3->fields.m_decalNormalMROTexArray,
		            0LL);
		    v78 = *(_OWORD *)&v77->m_BufferPointer;
		    v79 = *(_QWORD *)&v77->m_DepthSlice;
		    *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v77->m_Type;
		    *(_OWORD *)&keyword.m_BufferPointer = v78;
		    *(_QWORD *)&keyword.m_DepthSlice = v79;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		      v10,
		      v74,
		      v75,
		      HGTerrainDecalNormalMROTexArray,
		      &keyword,
		      0LL);
		    v80 = v3->fields.m_vtBakeCS;
		    v81 = v3->fields.m_vtBakeMainKernel;
		    HGTerrainHeightmap = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainHeightmap;
		    v83 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		            &rt,
		            (Texture *)v3->fields.m_terrainHeightmap,
		            0LL);
		    v84 = *(_OWORD *)&v83->m_BufferPointer;
		    v85 = *(_QWORD *)&v83->m_DepthSlice;
		    *(_OWORD *)&rt.m_Type = *(_OWORD *)&v83->m_Type;
		    *(_OWORD *)&rt.m_BufferPointer = v84;
		    *(_QWORD *)&rt.m_DepthSlice = v85;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(v10, v80, v81, HGTerrainHeightmap, &rt, 0LL);
		  }
		  else
		  {
		LABEL_15:
		    LOBYTE(buffer) = 0;
		  }
		  for ( i = 0; ; i = v184 + 1 )
		  {
		    v184 = i;
		    v87 = v3->fields.m_renderQueue;
		    if ( !v87 )
		      goto LABEL_117;
		    if ( i >= v87->fields._size )
		      break;
		    key = (uint32_t)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
		                      (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)v3->fields.m_renderQueue,
		                      i,
		                      MethodInfo::System::Collections::Generic::List<unsigned int>::get_Item);
		    v88 = HG::Rendering::Runtime::VirtualTextureRenderer::_UnpackNodeKey(&v221, key, 0LL);
		    v210 = *(_QWORD *)&v88->Item1;
		    Item3 = v88->Item3;
		    v218 = v210;
		    col = Item3;
		    v192 = HIDWORD(v210);
		    v90 = v210;
		    v91 = (float)((float)SHIDWORD(v210) / (float)(1 << (v210 & 0x1F))) * v208->fields.m_virtualToTerrain.y;
		    *(float *)&v92 = (float)((float)Item3 / (float)(1 << (v210 & 0x1F))) * v3->fields.m_virtualToTerrain.x;
		    *(float *)&v93 = (float)(1.0 / (float)(1 << (v210 & 0x1F))) * v208->fields.m_virtualToTerrain.y;
		    v206.x = (float)(1.0 / (float)(1 << (v210 & 0x1F))) * v3->fields.m_virtualToTerrain.x;
		    *(_QWORD *)&v206.y = __PAIR64__(v92, v93);
		    v206.w = v91;
		    if ( v3->fields.m_enableCompression )
		    {
		      *(_QWORD *)&v201.x = COERCE_UNSIGNED_INT((float)(i << 8));
		      v201.z = (float)(i << 8);
		      v201.w = 256.0;
		    }
		    else
		    {
		      if ( !v3->fields.m_nodeCacheLut )
		        sub_1800D8260(v210 & 0x1F, v208);
		      System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue(
		        v3->fields.m_nodeCacheLut,
		        key,
		        value,
		        MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue);
		      v94 = (v3->fields.m_cachePageCountTotal - value[0]) / v3->fields.m_cachePageCountPerSlice;
		      v95 = (float)(((v3->fields.m_cachePageCountTotal - value[0]) % v3->fields.m_cachePageCountPerSlice
		                   / v3->fields.m_cacheColNumPerSlice) << 8);
		      v201.x = (float)(((v3->fields.m_cachePageCountTotal - value[0])
		                      % v3->fields.m_cachePageCountPerSlice
		                      % v3->fields.m_cacheColNumPerSlice) << 8);
		      v201.y = v95;
		      v201.z = (float)v94;
		      v201.w = 256.0;
		      v96 = v3->fields.m_vtBakeCS;
		      v173 = v3->fields.m_vtBakeMainKernel;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      keyd = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainPhysicalBase;
		      v97 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		              &rt,
		              (Texture *)v3->fields.m_physicalBaseRt,
		              0LL);
		      v98 = *(_OWORD *)&v97->m_BufferPointer;
		      v99 = *(_QWORD *)&v97->m_DepthSlice;
		      *(_OWORD *)&rt.m_Type = *(_OWORD *)&v97->m_Type;
		      *(_OWORD *)&rt.m_BufferPointer = v98;
		      *(_QWORD *)&rt.m_DepthSlice = v99;
		      UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(v10, v96, v173, keyd, &rt, 0, 0LL);
		      v100 = v3->fields.m_vtBakeCS;
		      v174 = v3->fields.m_vtBakeMainKernel;
		      keye = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainPhysicalNormal;
		      v101 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		               &keyword,
		               (Texture *)v3->fields.m_physicalNormRt,
		               0LL);
		      v102 = *(_OWORD *)&v101->m_BufferPointer;
		      v103 = *(_QWORD *)&v101->m_DepthSlice;
		      *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v101->m_Type;
		      *(_OWORD *)&keyword.m_BufferPointer = v102;
		      *(_QWORD *)&keyword.m_DepthSlice = v103;
		      UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(v10, v100, v174, keye, &keyword, 0, 0LL);
		    }
		    if ( !(_BYTE)buffer )
		    {
		      *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v3->fields.m_enableTerrainDecalCS.m_SpaceInfo.m_KeywordSpace;
		      keyword.m_BufferPointer = *(void **)&v3->fields.m_enableTerrainDecalCS.m_Index;
		      UnityEngine::Rendering::CommandBuffer::DisableComputeKeyword_Injected(
		        v10,
		        v3->fields.m_vtBakeCS,
		        (LocalKeyword *)&keyword,
		        0LL);
		      goto LABEL_84;
		    }
		    value[1] = 2;
		    Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::NativeList(
		      &v205,
		      (AllocatorManager_AllocatorHandle)2,
		      MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::NativeList);
		    v106 = 0;
		    m_decalMaxLevel = v208->fields.m_decalMaxLevel;
		    if ( v90 > v3->fields.m_decalMaxLevel )
		    {
		      v122 = (v90 - m_decalMaxLevel) & 0x1F;
		      LODWORD(v194) = (int)v192 >> v122;
		      level = Item3 >> v122;
		      keyb = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(
		               v3->fields.m_decalMaxLevel,
		               (int)v192 >> v122,
		               Item3 >> v122,
		               0LL);
		      v178 = v3->fields.m_indirectMaxLevel - v3->fields.m_decalMaxLevel;
		      v176 = v178 & 0x1F;
		      Length = 0;
		      v110 = 1;
		      v190 = 1;
		      v129 = sub_182F114D0(v125, v124, v126);
		      v191 = (int)*(float *)&v129;
		      v187 = (int)*(float *)&v129;
		      if ( !v3->fields.m_decalBlockMaskLut )
		        sub_1800D8260(v128, v127);
		      if ( !System::Collections::Generic::Dictionary<unsigned int,System::Object>::TryGetValue(
		              (Dictionary_2_System_UInt32_System_Object_ *)v3->fields.m_decalBlockMaskLut,
		              keyb,
		              &v204,
		              MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::UInt64 []>::TryGetValue) )
		        goto LABEL_74;
		      if ( !v3->fields.m_decalNodeLut )
		        sub_1800D8260(v130, v65);
		      System::Collections::Generic::Dictionary<unsigned int,System::Object>::TryGetValue(
		        (Dictionary_2_System_UInt32_System_Object_ *)v3->fields.m_decalNodeLut,
		        keyb,
		        &v209,
		        MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::Int32 []>::TryGetValue);
		      v131 = (v3->fields.m_indirectMaxLevel - v210) & 0x1F;
		      v132 = ((_DWORD)v192 << v131) - ((_DWORD)v194 << (v178 & 0x1F));
		      v192 = v132;
		      colb = (col << v131) - (level << (v178 & 0x1F));
		      v133 = 1 << v131;
		      v179 = 1 << v131;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::GenericPool<System::Collections::Generic::HashSet<int>>);
		      UnityEngine::Rendering::ListPool<HG::Rendering::Runtime::HGRenderPipeline::RenderRequest>::Get(
		        &v222,
		        (List_1_HG_Rendering_Runtime_HGRenderPipeline_RenderRequest_ **)&v199,
		        MethodInfo::UnityEngine::Rendering::GenericPool<System::Collections::Generic::HashSet<int>>::Get);
		      if ( !v199 )
		        sub_1800D8260(v135, v134);
		      System::Collections::Generic::HashSet<unsigned long>::Clear(
		        v199,
		        MethodInfo::System::Collections::Generic::HashSet<int>::Clear);
		      v138 = 0;
		      keyc = 0;
		      if ( v133 > 0 )
		      {
		        v136 = (unsigned int)v133;
		        do
		        {
		          v139 = colb + ((v138 + v132) << v176);
		          v194 = v136;
		          do
		          {
		            v137 = v139 & 0x3F;
		            v140 = 1LL << v137;
		            for ( j = 0; ; ++j )
		            {
		              if ( !v204 )
		                sub_1800D8260(v137, v136);
		              if ( j >= SLODWORD(v204[1].monitor) )
		                break;
		              if ( (unsigned int)j >= LODWORD(v204[1].monitor) )
		                sub_1800D2AB0(v137, v136);
		              if ( (v140 & (__int64)*(&v204[2].klass + j)) != 0 )
		              {
		                if ( !v199 )
		                  sub_1800D8260(v137, v136);
		                System::Collections::Generic::HashSet<int>::Add(
		                  (HashSet_1_System_Int32_ *)v199,
		                  j,
		                  MethodInfo::System::Collections::Generic::HashSet<int>::Add);
		              }
		            }
		            LOBYTE(v139) = v139 + 1;
		            --v194;
		          }
		          while ( v194 );
		          v138 = keyc + 1;
		          keyc = v138;
		          v132 = v192;
		          v136 = (unsigned int)v179;
		        }
		        while ( v138 < v179 );
		        v3 = this;
		        v10 = v207;
		      }
		      if ( !v199 )
		        sub_1800D8260(v137, v136);
		      System::Collections::Generic::HashSet<Beyond::Gameplay::FunctionAreaManager::FunctionAreaIdentifier>::GetEnumerator(
		        (HashSet_1_T_Enumerator_Beyond_Gameplay_FunctionAreaManager_FunctionAreaIdentifier_ *)&keyword,
		        (HashSet_1_Beyond_Gameplay_FunctionAreaManager_FunctionAreaIdentifier_ *)v199,
		        MethodInfo::System::Collections::Generic::HashSet<int>::GetEnumerator);
		      *(_OWORD *)&v212._set = *(_OWORD *)&keyword.m_Type;
		      *(_QWORD *)&v212._current = keyword.m_BufferPointer;
		      ex = 0LL;
		      v214 = &v212;
		      try
		      {
		        while ( System::Collections::Generic::HashSet_1_T_::Enumerator<int>::MoveNext(
		                  &v212,
		                  MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<int>::MoveNext) )
		        {
		          if ( !v209 )
		            sub_1800D8250(0LL, v142);
		          if ( v212._current >= LODWORD(v209[1].monitor) )
		            sub_1800D2AA0(v209, v142, v143);
		          if ( !v3->fields.m_decalInstanceData )
		            sub_1800D8250(v209, v142);
		          v144 = MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::Add;
		          v145 = (HGTerrainRuntimeResources_DecalPerInstanceData *)sub_18049E964(
		                                                                     v3->fields.m_decalInstanceData,
		                                                                     *((int *)&v209[2].klass + v212._current));
		          Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::Add(
		            &v205,
		            v145,
		            v144);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v219 )
		      {
		        ex = v219->ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		        v3 = this;
		        v10 = v207;
		        v110 = 1;
		        v191 = v187;
		LABEL_73:
		        v146 = (Object *)v199;
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::GenericPool<System::Collections::Generic::HashSet<int>>);
		        UnityEngine::Rendering::UnsafeGenericPool<System::Object>::Release(
		          v146,
		          MethodInfo::UnityEngine::Rendering::GenericPool<System::Collections::Generic::HashSet<int>>::Release);
		        Length = Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::get_Length(
		                   (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v205,
		                   MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::get_Length);
		        v106 = Length != 0;
		LABEL_74:
		        m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3->fields.m_decalInstanceInfo;
		        v202 = COERCE_UNSIGNED_INT((float)Length);
		        if ( !m_decalInstanceInfo )
		          goto LABEL_117;
		        *(_OWORD *)&keyword.m_Type = v202;
		        sub_18003FEF0(m_decalInstanceInfo, 0LL, &keyword);
		        goto LABEL_76;
		      }
		      v110 = v190;
		      goto LABEL_73;
		    }
		    v108 = v90 + 2;
		    if ( v90 + 2 >= m_decalMaxLevel )
		      v108 = v208->fields.m_decalMaxLevel;
		    level = v108;
		    v109 = ((_BYTE)v108 - (_BYTE)v90) & 0x1F;
		    v110 = 1 << v109;
		    v190 = 1 << v109;
		    LODWORD(v192) = (_DWORD)v192 << v109;
		    v111 = Item3 << v109;
		    cola = v111;
		    v112 = 0;
		    v200 = 0;
		    v186 = 0;
		    v113 = sub_182F114D0(v109, v104, v105);
		    v191 = (int)*(float *)&v113;
		    v114 = 0;
		    keya = 0;
		    if ( v110 > 0 )
		    {
		      v115 = -v111;
		      do
		      {
		        v188 = 0;
		        LODWORD(m_decalInstanceInfo) = cola;
		        v175 = cola;
		        LODWORD(v65) = v114 + v192;
		        v177 = v114 + v192;
		        do
		        {
		          LODWORD(v194) = v115 + (_DWORD)m_decalInstanceInfo;
		          v116 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(
		                   level,
		                   v65,
		                   (int32_t)m_decalInstanceInfo,
		                   0LL);
		          m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3->fields.m_decalNodeLut;
		          if ( !m_decalInstanceInfo )
		            goto LABEL_117;
		          if ( System::Collections::Generic::Dictionary<unsigned int,System::Object>::TryGetValue(
		                 m_decalInstanceInfo,
		                 v116,
		                 &v203,
		                 MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::Int32 []>::TryGetValue) )
		          {
		            v118 = v203;
		            v119 = 0;
		            v196 = 0;
		            if ( !v203 )
		              goto LABEL_117;
		            while ( (signed int)v119 < SLODWORD(v118[1].monitor) )
		            {
		              if ( !v118 )
		                goto LABEL_117;
		              if ( v119 >= LODWORD(v118[1].monitor) )
		                sub_1800D2AA0(m_decalInstanceInfo, v65, v117);
		              m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3->fields.m_decalInstanceData;
		              if ( !m_decalInstanceInfo )
		                goto LABEL_117;
		              v120 = MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::Add;
		              v121 = (HGTerrainRuntimeResources_DecalPerInstanceData *)sub_18049E964(
		                                                                         m_decalInstanceInfo,
		                                                                         *((int *)&v118[2].klass + (int)v119));
		              Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::Add(
		                &v205,
		                v121,
		                v120);
		              v119 = ++v196;
		            }
		            if ( !v203 )
		              goto LABEL_117;
		            v112 = LODWORD(v203[1].monitor) + v200;
		            v200 = v112;
		            v110 = v190;
		          }
		          m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3->fields.m_decalInstanceInfo;
		          *(float *)&v211 = (float)v112;
		          *(_QWORD *)((char *)&v211 + 4) = COERCE_UNSIGNED_INT((float)v186);
		          HIDWORD(v211) = 0;
		          if ( !m_decalInstanceInfo )
		            goto LABEL_117;
		          *(_OWORD *)&keyword.m_Type = v211;
		          sub_18003FEF0(m_decalInstanceInfo, (int)v194, &keyword);
		          v186 = v112;
		          ++v188;
		          m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)(unsigned int)++v175;
		          v65 = v177;
		        }
		        while ( v188 < v110 );
		        v114 = keya + 1;
		        keya = v114;
		        v115 += v110;
		      }
		      while ( v114 < v110 );
		    }
		    v106 = v112 > 0;
		LABEL_76:
		    if ( v106 )
		    {
		      m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3->fields.m_decalInstanceInfo;
		      if ( !m_decalInstanceInfo )
		        goto LABEL_117;
		      *(float *)(sub_180002100(m_decalInstanceInfo, 0LL) + 8) = (float)v110;
		      m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3->fields.m_decalInstanceInfo;
		      if ( !m_decalInstanceInfo )
		        goto LABEL_117;
		      v147 = (float)v191;
		      *(float *)(sub_180002100(m_decalInstanceInfo, 0LL) + 12) = v147;
		      v148 = v3->fields.m_vtBakeCS;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      if ( !v10 )
		        goto LABEL_117;
		      UnityEngine::Rendering::CommandBuffer::SetComputeVectorArrayParam(
		        v10,
		        v148,
		        TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainDecalInstanceInfos,
		        v3->fields.m_decalInstanceInfo,
		        0LL);
		      v149 = v3->fields.m_vtBakeCS;
		      HGTerrainDecalInstanceData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainDecalInstanceData;
		      Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiAgentData>::AsArray(
		        &v220,
		        (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&v205,
		        MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::AsArray);
		      *(NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&keyword.m_Type = v220;
		      UnityEngine::Rendering::CommandBuffer::SetComputeValueParam<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>(
		        v10,
		        v149,
		        HGTerrainDecalInstanceData,
		        (NativeArray_1_HG_Rendering_Runtime_HGTerrainRuntimeResources_DecalPerInstanceData_ *)&keyword,
		        MethodInfo::UnityEngine::Rendering::CommandBuffer::SetComputeValueParam<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>);
		      *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v3->fields.m_enableTerrainDecalCS.m_SpaceInfo.m_KeywordSpace;
		      keyword.m_BufferPointer = *(void **)&v3->fields.m_enableTerrainDecalCS.m_Index;
		      UnityEngine::Rendering::CommandBuffer::EnableComputeKeyword_Injected(
		        v10,
		        v3->fields.m_vtBakeCS,
		        (LocalKeyword *)&keyword,
		        0LL);
		    }
		    else
		    {
		      if ( !v10 )
		        goto LABEL_117;
		      *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v3->fields.m_enableTerrainDecalCS.m_SpaceInfo.m_KeywordSpace;
		      keyword.m_BufferPointer = *(void **)&v3->fields.m_enableTerrainDecalCS.m_Index;
		      UnityEngine::Rendering::CommandBuffer::DisableComputeKeyword_Injected(
		        v10,
		        v3->fields.m_vtBakeCS,
		        (LocalKeyword *)&keyword,
		        0LL);
		    }
		    Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::Dispose(
		      &v205,
		      MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::Dispose);
		LABEL_84:
		    v151 = v3->fields.m_vtBakeCS;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    HGTerrainUVTransform = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainUVTransform;
		    val = v206;
		    UnityEngine::Rendering::CommandBuffer::SetComputeVectorParam_Injected(v10, v151, HGTerrainUVTransform, &val, 0LL);
		    HGTerrainRTOffset = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainRTOffset;
		    v217 = v201;
		    UnityEngine::Rendering::CommandBuffer::SetComputeVectorParam_Injected(
		      v10,
		      v3->fields.m_vtBakeCS,
		      HGTerrainRTOffset,
		      &v217,
		      0LL);
		    UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		      v10,
		      v3->fields.m_vtBakeCS,
		      v3->fields.m_vtBakeMainKernel,
		      32,
		      32,
		      1,
		      0LL);
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		  UnityEngine::Rendering::ScriptableRenderContext::ExecuteCommandBuffer(&P1, v10, 0LL);
		  if ( v3->fields.m_enableCompression )
		  {
		    UnityEngine::Rendering::CommandBuffer::Clear(v10, 0LL);
		    Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::NativeArray(
		      &v215,
		      1,
		      Allocator__Enum_Temp,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4Int>::NativeArray);
		    LODWORD(v202) = 64;
		    DWORD1(v202) = v3->fields._vtMaxPagePerFrame_k__BackingField;
		    *((_QWORD *)&v202 + 1) = 4096LL;
		    *(_OWORD *)v215.m_Buffer = v202;
		    v154 = (Vector4)v215;
		    val = (Vector4)v215;
		    m_vtCompressCS = v3->fields.m_vtCompressCS;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    v217 = v154;
		    UnityEngine::Rendering::CommandBuffer::SetComputeValueParam<UnityEngine::Vector4Int>(
		      v10,
		      m_vtCompressCS,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainCompressCacheParam0,
		      (NativeArray_1_UnityEngine_Vector4Int_ *)&v217,
		      MethodInfo::UnityEngine::Rendering::CommandBuffer::SetComputeValueParam<UnityEngine::Vector4Int>);
		    v156 = v3->fields.m_vtCompressCS;
		    m_vtCompressMainKernel = v3->fields.m_vtCompressMainKernel;
		    LODWORD(m_vtCompressCS) = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainCommonInput;
		    rt = *UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&keyword, (Texture *)v3->fields.m_pageRt, 0LL);
		    UnityEngine::Rendering::CommandBuffer::Internal_SetComputeTextureParam(
		      v10,
		      v156,
		      m_vtCompressMainKernel,
		      (int32_t)m_vtCompressCS,
		      &rt,
		      0,
		      RenderTextureSubElement__Enum_Default,
		      -1,
		      0LL);
		    UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		      v10,
		      v3->fields.m_vtCompressCS,
		      v3->fields.m_vtCompressMainKernel,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainCommonOutput,
		      v3->fields.m_pageBuffer,
		      0,
		      -1,
		      0LL);
		    UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		      v10,
		      v3->fields.m_vtCompressCS,
		      v3->fields.m_vtCompressMainKernel,
		      v3->fields.m_compressCSGroupSize.m_X,
		      v3->fields.m_compressCSGroupSize.m_Y,
		      1,
		      0LL);
		    v180 = v3->fields._vtMaxPagePerFrame_k__BackingField << 16;
		    v158 = 0;
		    v185 = 0;
		    v65 = 0LL;
		    m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3->fields.m_renderQueue;
		    if ( !m_decalInstanceInfo )
		LABEL_117:
		      sub_1800D8250(m_decalInstanceInfo, v65);
		    LODWORD(buffer) = 0;
		    while ( (int)v65 < SLODWORD(m_decalInstanceInfo->fields._entries) )
		    {
		      m_nodeCacheLut = v3->fields.m_nodeCacheLut;
		      m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3->fields.m_renderQueue;
		      if ( m_decalInstanceInfo )
		      {
		        Item = System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
		                 (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)m_decalInstanceInfo,
		                 v158,
		                 MethodInfo::System::Collections::Generic::List<unsigned int>::get_Item);
		        if ( m_nodeCacheLut )
		        {
		          System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue(
		            m_nodeCacheLut,
		            *(_DWORD *)&Item,
		            &v197,
		            MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue);
		          layer = (v3->fields.m_cachePageCountTotal - v197) / v3->fields.m_cachePageCountPerSlice;
		          v162 = ((v3->fields.m_cachePageCountTotal - v197)
		                % v3->fields.m_cachePageCountPerSlice
		                % v3->fields.m_cacheColNumPerSlice) << 8;
		          v163 = ((v3->fields.m_cachePageCountTotal - v197) % v3->fields.m_cachePageCountPerSlice
		                / v3->fields.m_cacheColNumPerSlice) << 8;
		          UnityEngine::Rendering::CommandBuffer::CopyBufferToImage(
		            v10,
		            v3->fields.m_pageBuffer,
		            (int32_t)buffer,
		            (Texture *)v3->fields.m_physicalBaseTex,
		            v162,
		            v163,
		            0,
		            256,
		            256,
		            1,
		            0,
		            layer,
		            0LL);
		          UnityEngine::Rendering::CommandBuffer::CopyBufferToImage(
		            v10,
		            v3->fields.m_pageBuffer,
		            v180 + (_DWORD)buffer,
		            (Texture *)v3->fields.m_physicalNormTex,
		            v162,
		            v163,
		            0,
		            256,
		            256,
		            1,
		            0,
		            layer,
		            0LL);
		          v158 = v185 + 1;
		          v185 = v158;
		          LODWORD(buffer) = (_DWORD)buffer + 4096;
		          v65 = v158;
		          m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3->fields.m_renderQueue;
		          if ( m_decalInstanceInfo )
		            continue;
		        }
		      }
		      goto LABEL_117;
		    }
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		    UnityEngine::Rendering::ScriptableRenderContext::ExecuteCommandBuffer(&P1, v10, 0LL);
		    Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
		      (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&val,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4Int>::Dispose);
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::CommandBufferPool);
		  UnityEngine::Rendering::CommandBufferPool::Release(v10, 0LL);
		}
		
		private void _UpdateClipmapTexture(Texture2D indirectTex) {} // 0x0000000189C28F30-0x0000000189C29324
		// Void _UpdateClipmapTexture(Texture2D)
		void HG::Rendering::Runtime::VirtualTextureRenderer::_UpdateClipmapTexture(
		        VirtualTextureRenderer *this,
		        Texture2D *indirectTex,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  char v7; // dl
		  __int64 v8; // rcx
		  int v9; // r8d
		  char v10; // dl
		  __int64 v11; // rcx
		  int v12; // r8d
		  int32_t v13; // edx
		  int32_t v14; // r8d
		  int v15; // r13d
		  int32_t v16; // r14d
		  int32_t v17; // r15d
		  int v18; // esi
		  int32_t m_indirectLevel; // r12d
		  __int64 v20; // rcx
		  int v21; // ebx
		  char v22; // dl
		  int v23; // r8d
		  int32_t v24; // r10d
		  int v25; // r9d
		  int32_t v26; // r12d
		  int32_t v27; // r14d
		  __int64 v28; // rdx
		  int32_t v29; // r15d
		  int32_t v30; // ebx
		  Dictionary_2_System_UInt32_System_Int32_ *m_nodeCacheLut; // r13
		  uint32_t v32; // eax
		  uint32_t v33; // edx
		  Dictionary_2_System_UInt32_System_Int32_ *v34; // r13
		  uint32_t v35; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t col; // [rsp+20h] [rbp-98h]
		  int v38; // [rsp+24h] [rbp-94h]
		  int32_t v39; // [rsp+28h] [rbp-90h]
		  int32_t v40; // [rsp+2Ch] [rbp-8Ch]
		  int32_t v41; // [rsp+30h] [rbp-88h]
		  int32_t v42; // [rsp+34h] [rbp-84h]
		  int v43; // [rsp+38h] [rbp-80h]
		  int v44; // [rsp+3Ch] [rbp-7Ch]
		  int v45; // [rsp+40h] [rbp-78h]
		  int32_t v46; // [rsp+44h] [rbp-74h]
		  __int64 v47; // [rsp+48h] [rbp-70h]
		  Void *v48; // [rsp+50h] [rbp-68h]
		  Void *v49; // [rsp+58h] [rbp-60h]
		  NativeArray_1_System_UInt32_ v50; // [rsp+60h] [rbp-58h] BYREF
		  int32_t value; // [rsp+D8h] [rbp+20h] BYREF
		
		  value = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(4001, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4001, 0LL);
		    if ( !Patch )
		      goto LABEL_30;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)indirectTex,
		      0LL);
		  }
		  else
		  {
		    if ( !indirectTex )
		      goto LABEL_30;
		    UnityEngine::Texture2D::GetRawTextureData<unsigned int>(
		      &v50,
		      indirectTex,
		      MethodInfo::UnityEngine::Texture2D::GetRawTextureData<unsigned int>);
		    sub_1834464B0(v8, v7, v9);
		    sub_1834464B0(v11, v10, v12);
		    v15 = 0;
		    v43 = 0;
		    v38 = 0;
		    v16 = 0;
		    v17 = 0;
		    v48 = 0LL;
		    v18 = this->fields.m_indirectLevel - 1;
		    if ( v18 >= 0 )
		    {
		      m_indirectLevel = this->fields.m_indirectLevel;
		      v42 = m_indirectLevel;
		      do
		      {
		        v49 = &v50.m_Buffer[4 * this->fields.m_indirectMaxArea * v18];
		        v20 = v18 & 0x1F;
		        v21 = 1 << v20;
		        col = sub_1834464B0(v20, v13, v14);
		        v13 = sub_1834464B0((unsigned int)(this->fields.m_indirectHalfWidth * v21), v22, v23);
		        v24 = col;
		        v46 = v13;
		        if ( v18 == this->fields.m_indirectLevel - 1 )
		        {
		          v25 = v38;
		        }
		        else
		        {
		          v48 = &v50.m_Buffer[4 * this->fields.m_indirectMaxArea * m_indirectLevel];
		          v25 = col - 2 * v17;
		          v15 = v13 - 2 * v16;
		          v38 = v25;
		          v43 = v15;
		        }
		        v26 = 0;
		        if ( this->fields.m_indirectWidth > 0 )
		        {
		          v27 = v13;
		          v44 = v15 - v13;
		          do
		          {
		            v14 = 0;
		            v28 = 0LL;
		            v41 = 0;
		            v47 = 0LL;
		            if ( this->fields.m_indirectWidth > 0 )
		            {
		              v29 = v24;
		              v45 = v25 - v24;
		              do
		              {
		                v30 = this->fields.m_indirectMaxLevel - v18;
		                v39 = v27;
		                v40 = v29;
		                if ( v29 >= 0 && v27 >= 0 && v29 < 1 << (v30 & 0x1F) && v27 < 1 << (v30 & 0x1F) )
		                {
		                  m_nodeCacheLut = this->fields.m_nodeCacheLut;
		                  v32 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(v30, v27, v29, 0LL);
		                  if ( !m_nodeCacheLut )
		                    goto LABEL_30;
		                  if ( System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue(
		                         m_nodeCacheLut,
		                         v32,
		                         &value,
		                         MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue) )
		                  {
		LABEL_22:
		                    v33 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackIndirectParam(this, value, v30, 0LL);
		                  }
		                  else
		                  {
		                    if ( v18 == this->fields.m_indirectLevel - 1 )
		                    {
		                      while ( 1 )
		                      {
		                        --v30;
		                        v34 = this->fields.m_nodeCacheLut;
		                        v40 >>= 1;
		                        v39 >>= 1;
		                        v35 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(v30, v39, v40, 0LL);
		                        if ( !v34 )
		                          break;
		                        if ( System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue(
		                               v34,
		                               v35,
		                               &value,
		                               MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue) )
		                        {
		                          goto LABEL_22;
		                        }
		                      }
		LABEL_30:
		                      sub_1800D8260(v6, v5);
		                    }
		                    v33 = *(_DWORD *)&v48[4 * ((v29 + v45) / 2)
		                                        + 4 * (__int64)(this->fields.m_indirectMaxWidth * ((v27 + v44) / 2))];
		                  }
		                  v14 = v41;
		                  *(_DWORD *)&v49[4 * v47 + 4 * this->fields.m_indirectMaxWidth * v26] = v33;
		                  v28 = v47;
		                }
		                ++v14;
		                ++v28;
		                ++v29;
		                v41 = v14;
		                v47 = v28;
		              }
		              while ( v14 < this->fields.m_indirectWidth );
		            }
		            v25 = v38;
		            ++v26;
		            v24 = col;
		            ++v27;
		          }
		          while ( v26 < this->fields.m_indirectWidth );
		          v13 = v46;
		        }
		        v16 = v13;
		        v17 = col;
		        m_indirectLevel = v42 - 1;
		        --v18;
		        v15 = v43;
		        --v42;
		      }
		      while ( v18 >= 0 );
		    }
		    UnityEngine::Texture2D::Apply(indirectTex, 0, 0, 0LL);
		  }
		}
		
		private bool _RefreshIndirectTextureParams() => default; // 0x0000000189C28CE8-0x0000000189C28D88
		// Boolean _RefreshIndirectTextureParams()
		bool HG::Rendering::Runtime::VirtualTextureRenderer::_RefreshIndirectTextureParams(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  HGTerrainConfiguration *m_configuration; // rax
		  int32_t vtClipmapBaseOffset; // r8d
		  int32_t v7; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3970, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3970, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		LABEL_7:
		    sub_1800D8260(v4, v3);
		  }
		  m_configuration = this->fields.m_configuration;
		  if ( !m_configuration )
		    goto LABEL_7;
		  vtClipmapBaseOffset = m_configuration->fields.vtClipmapBaseOffset;
		  if ( vtClipmapBaseOffset == this->fields.m_indirectOffset )
		    return 0;
		  this->fields.m_indirectOffset = vtClipmapBaseOffset;
		  v7 = 8 << (vtClipmapBaseOffset & 0x1F);
		  this->fields.m_indirectWidth = v7;
		  this->fields.m_indirectHalfWidth = v7 / 2;
		  this->fields.m_indirectLevel = this->fields.m_indirectBaseLevel - vtClipmapBaseOffset;
		  return 1;
		}
		
		private bool _RefreshPhysicalCacheParams() => default; // 0x0000000189C28D88-0x0000000189C28EAC
		// Boolean _RefreshPhysicalCacheParams()
		bool HG::Rendering::Runtime::VirtualTextureRenderer::_RefreshPhysicalCacheParams(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  LRUCache *m_lruCache; // rcx
		  HGTerrainConfiguration *m_configuration; // rax
		  int32_t vtCacheSliceWidth; // ebp
		  int32_t vtCacheSliceHeight; // esi
		  int32_t vtCacheSliceCount; // edi
		  int32_t v10; // eax
		  int32_t v11; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3971, 0LL) )
		  {
		    m_configuration = this->fields.m_configuration;
		    if ( m_configuration )
		    {
		      vtCacheSliceWidth = m_configuration->fields.vtCacheSliceWidth;
		      vtCacheSliceHeight = m_configuration->fields.vtCacheSliceHeight;
		      vtCacheSliceCount = m_configuration->fields.vtCacheSliceCount;
		      if ( vtCacheSliceWidth == this->fields.m_cacheSliceWidth
		        && vtCacheSliceHeight == this->fields.m_cacheSliceHeight
		        && vtCacheSliceCount == this->fields.m_cacheSliceCount )
		      {
		        return 0;
		      }
		      HG::Rendering::Runtime::VirtualTextureRenderer::_DestroyPhysicalCacheResources(this, 0LL);
		      this->fields.m_cacheSliceWidth = vtCacheSliceWidth;
		      this->fields.m_cacheSliceHeight = vtCacheSliceHeight;
		      this->fields.m_cacheSliceCount = vtCacheSliceCount;
		      this->fields.m_cacheColNumPerSlice = vtCacheSliceWidth / 256;
		      v3 = (unsigned int)(vtCacheSliceHeight >> 31);
		      LODWORD(v3) = vtCacheSliceHeight % 256;
		      this->fields.m_cacheRowNumPerSlice = vtCacheSliceHeight / 256;
		      v10 = vtCacheSliceWidth / 256 * (vtCacheSliceHeight / 256);
		      m_lruCache = this->fields.m_lruCache;
		      this->fields.m_cachePageCountPerSlice = v10;
		      v11 = vtCacheSliceCount * v10;
		      this->fields.m_cachePageCountTotal = v11;
		      if ( m_lruCache )
		      {
		        HG::Rendering::Runtime::LRUCache::Reset(m_lruCache, v11, 0LL);
		        m_lruCache = (LRUCache *)this->fields.m_nodeCacheLut;
		        if ( m_lruCache )
		        {
		          System::Collections::Generic::Dictionary<Beyond::Gameplay::Core::WaterVolumePtr,System::ValueTuple<float,System::Int32Enum,System::Object>>::Clear(
		            (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)m_lruCache,
		            MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Clear);
		          HG::Rendering::Runtime::VirtualTextureRenderer::_AllocatePhysicalCacheResources(this, 0LL);
		          return 1;
		        }
		      }
		    }
		LABEL_11:
		    sub_1800D8260(m_lruCache, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3971, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		private void _DestroyPhysicalCacheResources() {} // 0x0000000189C285A0-0x0000000189C28674
		// Void _DestroyPhysicalCacheResources()
		void HG::Rendering::Runtime::VirtualTextureRenderer::_DestroyPhysicalCacheResources(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  RenderTexture *m_physicalBaseRt; // rcx
		  Object_1 *m_physicalBaseTex; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3972, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3972, 0LL);
		    if ( !Patch )
		      goto LABEL_10;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !this->fields.m_enableCompression )
		    {
		      m_physicalBaseRt = this->fields.m_physicalBaseRt;
		      if ( m_physicalBaseRt )
		      {
		        UnityEngine::RenderTexture::Release(m_physicalBaseRt, 0LL);
		        m_physicalBaseRt = this->fields.m_physicalNormRt;
		        if ( m_physicalBaseRt )
		        {
		          UnityEngine::RenderTexture::Release(m_physicalBaseRt, 0LL);
		          return;
		        }
		      }
		LABEL_10:
		      sub_1800D8260(m_physicalBaseRt, v3);
		    }
		    m_physicalBaseTex = (Object_1 *)this->fields.m_physicalBaseTex;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    HG::Rendering::Runtime::HGUtils::Destroy(m_physicalBaseTex, 0LL);
		    HG::Rendering::Runtime::HGUtils::Destroy((Object_1 *)this->fields.m_physicalNormTex, 0LL);
		    m_physicalBaseRt = this->fields.m_pageRt;
		    if ( !m_physicalBaseRt )
		      goto LABEL_10;
		    UnityEngine::RenderTexture::Release(m_physicalBaseRt, 0LL);
		    m_physicalBaseRt = (RenderTexture *)this->fields.m_pageBuffer;
		    if ( !m_physicalBaseRt )
		      goto LABEL_10;
		    UnityEngine::ComputeBuffer::Dispose((ComputeBuffer *)m_physicalBaseRt, 0LL);
		  }
		}
		
		private void _AllocatePhysicalCacheResources() {} // 0x0000000189C27EBC-0x0000000189C283CC
		// Void _AllocatePhysicalCacheResources()
		void HG::Rendering::Runtime::VirtualTextureRenderer::_AllocatePhysicalCacheResources(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  int32_t m_cacheSliceWidth; // edi
		  int32_t m_cacheSliceHeight; // ebp
		  RenderTexture *v5; // rax
		  RenderTexture *v6; // rdx
		  RenderTexture *m_physicalBaseRt; // rcx
		  RenderTexture *v8; // rsi
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  RenderTextureDescriptor *descriptor; // rax
		  int32_t memoryless_k__BackingField; // ebp
		  RenderTexture *v14; // rax
		  RenderTexture *v15; // rsi
		  HGRuntimeGrassQuery_Node *v16; // rdx
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  GraphicsFormat__Enum PlatformCompressionFormat; // ebp
		  int32_t v20; // edi
		  int32_t v21; // r14d
		  int32_t m_cacheSliceCount; // r15d
		  Texture2DArray *v23; // rax
		  Texture *v24; // rsi
		  HGRuntimeGrassQuery_Node *v25; // rdx
		  HGRuntimeGrassQuery_Node *v26; // r8
		  Int32__Array **v27; // r9
		  int32_t v28; // r14d
		  int32_t v29; // r15d
		  int32_t v30; // r12d
		  Texture2DArray *v31; // rax
		  Texture *v32; // rsi
		  HGRuntimeGrassQuery_Node *v33; // rdx
		  HGRuntimeGrassQuery_Node *v34; // r8
		  Int32__Array **v35; // r9
		  int32_t vtMaxPagePerFrame_k__BackingField; // ebp
		  RenderTexture *v37; // rax
		  RenderTexture *v38; // rsi
		  HGRuntimeGrassQuery_Node *v39; // rdx
		  HGRuntimeGrassQuery_Node *v40; // r8
		  Int32__Array **v41; // r9
		  HGTerrainConfiguration *m_configuration; // rax
		  int32_t vtMaxPagePerFrame; // esi
		  ComputeBuffer *v44; // rax
		  ComputeBuffer *v45; // rdi
		  HGRuntimeGrassQuery_Node *v46; // rdx
		  HGRuntimeGrassQuery_Node *v47; // r8
		  Int32__Array **v48; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *formata; // [rsp+20h] [rbp-B8h]
		  MethodInfo *format; // [rsp+20h] [rbp-B8h]
		  MethodInfo *formatb; // [rsp+20h] [rbp-B8h]
		  MethodInfo *formatc; // [rsp+20h] [rbp-B8h]
		  MethodInfo *formatd; // [rsp+20h] [rbp-B8h]
		  MethodInfo *formate; // [rsp+20h] [rbp-B8h]
		  __int128 v56; // [rsp+40h] [rbp-98h]
		  __int128 v57; // [rsp+50h] [rbp-88h]
		  __int128 v58; // [rsp+60h] [rbp-78h]
		  RenderTextureDescriptor v59; // [rsp+70h] [rbp-68h] BYREF
		  Vector2Int v60; // [rsp+F0h] [rbp+18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3973, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3973, 0LL);
		    if ( !Patch )
		      goto LABEL_19;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !this->fields.m_enableCompression )
		    {
		      m_cacheSliceWidth = this->fields.m_cacheSliceWidth;
		      m_cacheSliceHeight = this->fields.m_cacheSliceHeight;
		      v5 = (RenderTexture *)sub_18002C620(TypeInfo::UnityEngine::RenderTexture);
		      v8 = v5;
		      if ( v5 )
		      {
		        UnityEngine::RenderTexture::RenderTexture(
		          v5,
		          m_cacheSliceWidth,
		          m_cacheSliceHeight,
		          0,
		          GraphicsFormat__Enum_R8G8B8A8_UNorm,
		          0LL);
		        sub_180040340(10LL, v8, 5LL);
		        UnityEngine::RenderTexture::set_volumeDepth(v8, this->fields.m_cacheSliceCount, 0LL);
		        UnityEngine::RenderTexture::set_useMipMap(v8, 0, 0LL);
		        UnityEngine::RenderTexture::set_autoGenerateMips(v8, 0, 0LL);
		        UnityEngine::RenderTexture::set_enableRandomWrite(v8, 1, 0LL);
		        UnityEngine::Texture::set_wrapMode((Texture *)v8, TextureWrapMode__Enum_Clamp, 0LL);
		        UnityEngine::Texture::set_filterMode((Texture *)v8, FilterMode__Enum_Bilinear, 0LL);
		        UnityEngine::Texture::set_anisoLevel((Texture *)v8, 0, 0LL);
		        this->fields.m_physicalBaseRt = v8;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_physicalBaseRt, v9, v10, v11, formata);
		        m_physicalBaseRt = this->fields.m_physicalBaseRt;
		        if ( m_physicalBaseRt )
		        {
		          UnityEngine::RenderTexture::Create(m_physicalBaseRt, 0LL);
		          v6 = this->fields.m_physicalBaseRt;
		          if ( v6 )
		          {
		            descriptor = UnityEngine::RenderTexture::get_descriptor(&v59, v6, 0LL);
		            memoryless_k__BackingField = descriptor->_memoryless_k__BackingField;
		            v56 = *(_OWORD *)&descriptor->_width_k__BackingField;
		            v57 = *(_OWORD *)&descriptor->_mipCount_k__BackingField;
		            v58 = *(_OWORD *)&descriptor->_dimension_k__BackingField;
		            v14 = (RenderTexture *)sub_18002C620(TypeInfo::UnityEngine::RenderTexture);
		            v15 = v14;
		            if ( v14 )
		            {
		              v59._memoryless_k__BackingField = memoryless_k__BackingField;
		              *(_OWORD *)&v59._width_k__BackingField = v56;
		              *(_OWORD *)&v59._mipCount_k__BackingField = v57;
		              *(_OWORD *)&v59._dimension_k__BackingField = v58;
		              UnityEngine::RenderTexture::RenderTexture(v14, &v59, 0LL);
		              sub_180040340(10LL, v15, 5LL);
		              UnityEngine::RenderTexture::set_volumeDepth(v15, this->fields.m_cacheSliceCount, 0LL);
		              UnityEngine::RenderTexture::set_useMipMap(v15, 0, 0LL);
		              UnityEngine::RenderTexture::set_autoGenerateMips(v15, 0, 0LL);
		              UnityEngine::RenderTexture::set_enableRandomWrite(v15, 1, 0LL);
		              UnityEngine::Texture::set_wrapMode((Texture *)v15, TextureWrapMode__Enum_Clamp, 0LL);
		              UnityEngine::Texture::set_filterMode((Texture *)v15, FilterMode__Enum_Bilinear, 0LL);
		              UnityEngine::Texture::set_anisoLevel((Texture *)v15, 0, 0LL);
		              this->fields.m_physicalNormRt = v15;
		              sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_physicalNormRt, v16, v17, v18, format);
		              m_physicalBaseRt = this->fields.m_physicalNormRt;
		              if ( m_physicalBaseRt )
		              {
		                UnityEngine::RenderTexture::Create(m_physicalBaseRt, 0LL);
		                return;
		              }
		            }
		          }
		        }
		      }
		LABEL_19:
		      sub_1800D8260(m_physicalBaseRt, v6);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
		    PlatformCompressionFormat = HG::Rendering::Runtime::HGTerrainUtils::GetPlatformCompressionFormat(0LL);
		    v20 = this->fields.m_cacheSliceWidth;
		    v21 = this->fields.m_cacheSliceHeight;
		    m_cacheSliceCount = this->fields.m_cacheSliceCount;
		    v23 = (Texture2DArray *)sub_18002C620(TypeInfo::UnityEngine::Texture2DArray);
		    v24 = (Texture *)v23;
		    if ( !v23 )
		      goto LABEL_19;
		    UnityEngine::Texture2DArray::Texture2DArray(
		      v23,
		      v20,
		      v21,
		      m_cacheSliceCount,
		      PlatformCompressionFormat,
		      TextureCreationFlags__Enum_None,
		      0LL);
		    UnityEngine::Texture::set_wrapMode(v24, TextureWrapMode__Enum_Clamp, 0LL);
		    UnityEngine::Texture::set_filterMode(v24, FilterMode__Enum_Bilinear, 0LL);
		    UnityEngine::Texture::set_anisoLevel(v24, 0, 0LL);
		    this->fields.m_physicalBaseTex = (Texture2DArray *)v24;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_physicalBaseTex, v25, v26, v27, formatb);
		    v28 = this->fields.m_cacheSliceWidth;
		    v29 = this->fields.m_cacheSliceHeight;
		    v30 = this->fields.m_cacheSliceCount;
		    v31 = (Texture2DArray *)sub_18002C620(TypeInfo::UnityEngine::Texture2DArray);
		    v32 = (Texture *)v31;
		    if ( !v31 )
		      goto LABEL_19;
		    UnityEngine::Texture2DArray::Texture2DArray(
		      v31,
		      v28,
		      v29,
		      v30,
		      PlatformCompressionFormat,
		      TextureCreationFlags__Enum_None,
		      0LL);
		    UnityEngine::Texture::set_wrapMode(v32, TextureWrapMode__Enum_Clamp, 0LL);
		    UnityEngine::Texture::set_filterMode(v32, FilterMode__Enum_Bilinear, 0LL);
		    UnityEngine::Texture::set_anisoLevel(v32, 0, 0LL);
		    this->fields.m_physicalNormTex = (Texture2DArray *)v32;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_physicalNormTex, v33, v34, v35, formatc);
		    m_physicalBaseRt = (RenderTexture *)this->fields.m_physicalBaseTex;
		    if ( !m_physicalBaseRt )
		      goto LABEL_19;
		    UnityEngine::Texture2DArray::Apply((Texture2DArray *)m_physicalBaseRt, 0, 1, 0LL);
		    m_physicalBaseRt = (RenderTexture *)this->fields.m_physicalNormTex;
		    if ( !m_physicalBaseRt )
		      goto LABEL_19;
		    UnityEngine::Texture2DArray::Apply((Texture2DArray *)m_physicalBaseRt, 0, 1, 0LL);
		    vtMaxPagePerFrame_k__BackingField = this->fields._vtMaxPagePerFrame_k__BackingField;
		    v37 = (RenderTexture *)sub_18002C620(TypeInfo::UnityEngine::RenderTexture);
		    v38 = v37;
		    if ( !v37 )
		      goto LABEL_19;
		    UnityEngine::RenderTexture::RenderTexture(
		      v37,
		      vtMaxPagePerFrame_k__BackingField << 8,
		      512,
		      0,
		      GraphicsFormat__Enum_R8G8B8A8_UNorm,
		      0LL);
		    sub_180040340(10LL, v38, 2LL);
		    UnityEngine::RenderTexture::set_useMipMap(v38, 0, 0LL);
		    UnityEngine::RenderTexture::set_autoGenerateMips(v38, 0, 0LL);
		    UnityEngine::RenderTexture::set_enableRandomWrite(v38, 1, 0LL);
		    this->fields.m_pageRt = v38;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_pageRt, v39, v40, v41, formatd);
		    m_physicalBaseRt = this->fields.m_pageRt;
		    if ( !m_physicalBaseRt )
		      goto LABEL_19;
		    UnityEngine::RenderTexture::Create(m_physicalBaseRt, 0LL);
		    m_configuration = this->fields.m_configuration;
		    if ( !m_configuration )
		      goto LABEL_19;
		    vtMaxPagePerFrame = m_configuration->fields.vtMaxPagePerFrame;
		    v44 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		    v45 = v44;
		    if ( !v44 )
		      goto LABEL_19;
		    UnityEngine::ComputeBuffer::ComputeBuffer(
		      v44,
		      vtMaxPagePerFrame << 13,
		      16,
		      ComputeBufferType__Enum_Structured,
		      ComputeBufferMode__Enum_Immutable,
		      0LL);
		    this->fields.m_pageBuffer = v45;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_pageBuffer, v46, v47, v48, formate);
		    v60.m_Y = 8;
		    v60.m_X = 4 * vtMaxPagePerFrame;
		    this->fields.m_compressCSGroupSize = v60;
		  }
		}
		
		public ValueTuple<float, float, float, float> GetFeedbackSubViewRange(float origLeft, float origRight, float origBottom, float origTop) => default; // 0x0000000189C24C48-0x0000000189C24DC4
		// ValueTuple`4[Single,Single,Single,Single] GetFeedbackSubViewRange(Single, Single, Single, Single)
		ValueTuple_4_Single_Single_Single_Single_ *HG::Rendering::Runtime::VirtualTextureRenderer::GetFeedbackSubViewRange(
		        ValueTuple_4_Single_Single_Single_Single_ *__return_ptr retstr,
		        VirtualTextureRenderer *this,
		        float origLeft,
		        float origRight,
		        float origBottom,
		        float origTop,
		        MethodInfo *method)
		{
		  float v9; // xmm6_4
		  int v10; // eax
		  float v11; // xmm4_4
		  float m_blockHeight; // xmm0_4
		  float v13; // xmm3_4
		  float v14; // xmm0_4
		  float v15; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  ValueTuple_4_Single_Single_Single_Single_ v20; // [rsp+40h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4016, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4016, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v18, v17);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1412(
		                 &v20,
		                 Patch,
		                 (Object *)this,
		                 origLeft,
		                 origRight,
		                 origBottom,
		                 origTop,
		                 0LL);
		  }
		  else
		  {
		    v9 = origRight - origLeft;
		    v10 = *(_DWORD *)&this->fields.m_feedbackJitterSeq.m_Buffer[4
		                                                              * ((int)this->fields.m_frameCount & (unsigned __int64)(this->fields.m_blockWidth * this->fields.m_blockHeight - 1LL))];
		    v11 = (float)((float)((float)(origRight - origLeft) * (float)(__int16)v10) / (float)this->fields.m_blockWidth)
		        + origLeft;
		    m_blockHeight = (float)this->fields.m_blockHeight;
		    retstr->Item1 = v11;
		    v13 = (float)((float)((float)SHIWORD(v10) * (float)(origTop - origBottom)) / m_blockHeight) + origBottom;
		    v14 = (float)this->fields.m_blockHeight;
		    v15 = (float)(v9 / (float)this->fields.m_blockWidth) + v11;
		    retstr->Item3 = v13;
		    retstr->Item2 = v15;
		    retstr->Item4 = (float)((float)(origTop - origBottom) / v14) + v13;
		  }
		  return retstr;
		}
		
		private void _GenerateJitterSequenceForSSBO(int blockWidth, int blockHeight) {} // 0x0000000189C288A4-0x0000000189C28A00
		// Void _GenerateJitterSequenceForSSBO(Int32, Int32)
		void HG::Rendering::Runtime::VirtualTextureRenderer::_GenerateJitterSequenceForSSBO(
		        VirtualTextureRenderer *this,
		        int32_t blockWidth,
		        int32_t blockHeight,
		        MethodInfo *method)
		{
		  __int64 v7; // rbx
		  int32_t v8; // r14d
		  int v9; // r9d
		  __int64 i; // r8
		  int v11; // eax
		  int v12; // edx
		  int32_t v13; // eax
		  int v14; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  int v18; // [rsp+30h] [rbp-28h]
		  NativeArray_1_HG_Rendering_Runtime_HGTerrainUtils_Vector2Short_ v19; // [rsp+38h] [rbp-20h] BYREF
		
		  v7 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3982, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3982, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v17, v16);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_272(
		      (ILFixDynamicMethodWrapper_6 *)Patch,
		      (Object *)this,
		      (UIInertiaViewPager_State__Enum)blockWidth,
		      (UIInertiaViewPager_State__Enum)blockHeight,
		      0LL);
		  }
		  else
		  {
		    if ( this->fields.m_feedbackJitterSeq.m_Buffer )
		      Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
		        (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&this->fields.m_feedbackJitterSeq,
		        MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::Dispose);
		    v8 = blockHeight * blockWidth;
		    v19 = 0LL;
		    Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::NativeArray(
		      &v19,
		      blockHeight * blockWidth,
		      Allocator__Enum_Persistent,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::NativeArray);
		    v9 = 0;
		    this->fields.m_feedbackJitterSeq = v19;
		    if ( blockHeight * blockWidth > 0 )
		    {
		      for ( i = 0LL; i < v8; *(_DWORD *)&this->fields.m_feedbackJitterSeq.m_Buffer[4 * i++] = v18 )
		      {
		        v11 = v9;
		        v12 = v9++ >> 31;
		        LOWORD(v18) = __SPAIR64__(v12, v11) % blockWidth;
		        HIWORD(v18) = __SPAIR64__(v12, v11) / blockWidth;
		      }
		      do
		      {
		        v13 = UnityEngine::Random::RandomRangeInt(0, v8, 0LL);
		        v14 = *(_DWORD *)&this->fields.m_feedbackJitterSeq.m_Buffer[4 * v7];
		        *(_DWORD *)&this->fields.m_feedbackJitterSeq.m_Buffer[4 * v7++] = *(_DWORD *)&this->fields.m_feedbackJitterSeq.m_Buffer[4 * v13];
		        *(_DWORD *)&this->fields.m_feedbackJitterSeq.m_Buffer[4 * v13] = v14;
		      }
		      while ( v7 < v8 );
		    }
		  }
		}
		
		private void _GenerateJitterSequenceForPhysX(int blockWidth, int blockHeight, int feedbackWidth, int feedbackHeight) {} // 0x0000000189C28674-0x0000000189C288A4
		// Void _GenerateJitterSequenceForPhysX(Int32, Int32, Int32, Int32)
		void HG::Rendering::Runtime::VirtualTextureRenderer::_GenerateJitterSequenceForPhysX(
		        VirtualTextureRenderer *this,
		        int32_t blockWidth,
		        int32_t blockHeight,
		        int32_t feedbackWidth,
		        int32_t feedbackHeight,
		        MethodInfo *method)
		{
		  int v10; // edi
		  int v11; // r9d
		  __int64 i; // r8
		  int v13; // eax
		  int v14; // edx
		  __int64 v15; // rsi
		  int32_t v16; // eax
		  int v17; // ecx
		  int32_t v18; // r9d
		  __int64 v19; // r8
		  __int64 v20; // rdx
		  Void *m_Buffer; // rcx
		  int v22; // eax
		  int32_t v23; // ebp
		  __int64 v24; // rsi
		  __int64 v25; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  int v27; // [rsp+40h] [rbp-28h]
		  NativeArray_1_HG_Rendering_Runtime_HGTerrainUtils_Vector2Short_ v28; // [rsp+48h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3978, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3978, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v25);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_997(
		      Patch,
		      (Object *)this,
		      blockWidth,
		      blockHeight,
		      feedbackWidth,
		      feedbackHeight,
		      0LL);
		  }
		  else
		  {
		    if ( this->fields.m_feedbackJitterSeq.m_Buffer )
		      Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
		        (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&this->fields.m_feedbackJitterSeq,
		        MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::Dispose);
		    v10 = blockHeight * blockWidth;
		    v28 = 0LL;
		    Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::NativeArray(
		      &v28,
		      2 * blockHeight * blockWidth,
		      Allocator__Enum_Persistent,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::NativeArray);
		    v11 = 0;
		    this->fields.m_feedbackJitterSeq = v28;
		    if ( blockHeight * blockWidth > 0 )
		    {
		      for ( i = 0LL; i < v10; *(_DWORD *)&this->fields.m_feedbackJitterSeq.m_Buffer[4 * i++] = v27 )
		      {
		        v13 = v11;
		        v14 = v11++ >> 31;
		        LOWORD(v27) = __SPAIR64__(v14, v13) % blockWidth;
		        HIWORD(v27) = __SPAIR64__(v14, v13) / blockWidth;
		      }
		      v15 = 0LL;
		      do
		      {
		        v16 = UnityEngine::Random::RandomRangeInt(0, v10, 0LL);
		        v17 = *(_DWORD *)&this->fields.m_feedbackJitterSeq.m_Buffer[4 * v15];
		        *(_DWORD *)&this->fields.m_feedbackJitterSeq.m_Buffer[4 * v15++] = *(_DWORD *)&this->fields.m_feedbackJitterSeq.m_Buffer[4 * v16];
		        *(_DWORD *)&this->fields.m_feedbackJitterSeq.m_Buffer[4 * v16] = v17;
		      }
		      while ( v15 < v10 );
		    }
		    v18 = v10;
		    if ( v10 < this->fields.m_feedbackJitterSeq.m_Length )
		    {
		      v19 = 0LL;
		      do
		      {
		        v20 = v19 + 4LL * v10;
		        m_Buffer = this->fields.m_feedbackJitterSeq.m_Buffer;
		        ++v18;
		        v22 = *(_DWORD *)&m_Buffer[v19];
		        v19 += 4LL;
		        *(_DWORD *)&m_Buffer[v20] = v22;
		      }
		      while ( v18 < this->fields.m_feedbackJitterSeq.m_Length );
		    }
		    if ( this->fields.m_cpuJitterOffsets.m_Buffer )
		      Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		        (NativeArray_1_UnityEngine_Vector4_ *)&this->fields.m_cpuJitterOffsets,
		        MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
		    v28 = 0LL;
		    Unity::Collections::NativeArray<int>::NativeArray(
		      (NativeArray_1_System_Int32_ *)&v28,
		      feedbackHeight * feedbackWidth,
		      Allocator__Enum_Persistent,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		    v23 = 0;
		    this->fields.m_cpuJitterOffsets = (NativeArray_1_System_Int32_)v28;
		    if ( this->fields.m_cpuJitterOffsets.m_Length > 0 )
		    {
		      v24 = 0LL;
		      do
		      {
		        ++v23;
		        *(_DWORD *)&this->fields.m_cpuJitterOffsets.m_Buffer[v24] = UnityEngine::Random::RandomRangeInt(0, v10, 0LL);
		        v24 += 4LL;
		      }
		      while ( v23 < this->fields.m_cpuJitterOffsets.m_Length );
		    }
		    this->fields.m_frameCount = 0;
		  }
		}
		
		private void _DestroyGPUFeedbackResources() {} // 0x0000000189C28428-0x0000000189C285A0
		// Void _DestroyGPUFeedbackResources()
		void HG::Rendering::Runtime::VirtualTextureRenderer::_DestroyGPUFeedbackResources(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  int32_t v3; // ebx
		  __int64 v4; // rdx
		  RTHandle *m_gpuFeedbackColor; // rcx
		  ComputeBuffer__Array *m_gpuFeedbackBuffers; // rbp
		  int32_t i; // esi
		  ComputeBuffer *v8; // rcx
		  RTHandle *m_gpuFeedbackDepth; // rcx
		  AsyncGPUReadbackRequest__Array *m_gpuFeedbackRequests; // rbp
		  int32_t j; // esi
		  NativeArray_1_System_UInt32___Array *m_gpuFeedbackData; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  AsyncGPUReadbackRequest _unity_self; // [rsp+20h] [rbp-28h] BYREF
		  NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_ v15; // [rsp+30h] [rbp-18h] BYREF
		
		  _unity_self = 0LL;
		  v3 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(3983, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3983, 0LL);
		    if ( !Patch )
		LABEL_26:
		      sub_1800D8260(v8, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    System::Array::Fill<bool>(this->fields.m_gpuFeedbackBufferFilled, 0, MethodInfo::System::Array::Fill<bool>);
		    if ( this->fields.m_gpuFeedbackBuffers )
		    {
		      m_gpuFeedbackBuffers = this->fields.m_gpuFeedbackBuffers;
		      for ( i = 0; i < m_gpuFeedbackBuffers->max_length.size; ++i )
		      {
		        if ( (unsigned int)i >= m_gpuFeedbackBuffers->max_length.size )
		LABEL_24:
		          sub_1800D2AB0(m_gpuFeedbackColor, v4);
		        v8 = m_gpuFeedbackBuffers->vector[i];
		        if ( !v8 )
		          goto LABEL_26;
		        UnityEngine::ComputeBuffer::Dispose(v8, 0LL);
		      }
		    }
		    m_gpuFeedbackDepth = this->fields.m_gpuFeedbackDepth;
		    if ( m_gpuFeedbackDepth )
		      UnityEngine::Rendering::RTHandle::Release(m_gpuFeedbackDepth, 0LL);
		    m_gpuFeedbackColor = this->fields.m_gpuFeedbackColor;
		    if ( m_gpuFeedbackColor )
		      UnityEngine::Rendering::RTHandle::Release(m_gpuFeedbackColor, 0LL);
		    if ( this->fields.m_gpuFeedbackRequests )
		    {
		      m_gpuFeedbackRequests = this->fields.m_gpuFeedbackRequests;
		      for ( j = 0; j < m_gpuFeedbackRequests->max_length.size; ++j )
		      {
		        if ( (unsigned int)j >= m_gpuFeedbackRequests->max_length.size )
		          goto LABEL_24;
		        _unity_self = m_gpuFeedbackRequests->vector[j];
		        if ( !UnityEngine::Rendering::AsyncGPUReadbackRequest::IsDone_Injected(&_unity_self, 0LL) )
		          UnityEngine::Rendering::AsyncGPUReadbackRequest::WaitForCompletion_Injected(&_unity_self, 0LL);
		      }
		    }
		    if ( this->fields.m_gpuFeedbackData )
		    {
		      m_gpuFeedbackData = this->fields.m_gpuFeedbackData;
		      while ( v3 < m_gpuFeedbackData->max_length.size )
		      {
		        if ( (unsigned int)v3 >= m_gpuFeedbackData->max_length.size )
		          goto LABEL_24;
		        v15 = (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_)m_gpuFeedbackData->vector[v3];
		        Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		          &v15,
		          MethodInfo::Unity::Collections::NativeArray<unsigned int>::Dispose);
		        ++v3;
		      }
		    }
		  }
		}
		
		private void _AllocateGPUFeedbackResources(int blockWidth, int blockHeight, int feedbackWidth, int feedbackHeight) {} // 0x0000000189C27A84-0x0000000189C27EBC
		// Void _AllocateGPUFeedbackResources(Int32, Int32, Int32, Int32)
		void HG::Rendering::Runtime::VirtualTextureRenderer::_AllocateGPUFeedbackResources(
		        VirtualTextureRenderer *this,
		        int32_t blockWidth,
		        int32_t blockHeight,
		        int32_t feedbackWidth,
		        int32_t feedbackHeight,
		        MethodInfo *method)
		{
		  int32_t v10; // ebx
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  __int64 v14; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  int32_t i; // edi
		  ComputeBuffer__Array *m_gpuFeedbackBuffers; // rax
		  ComputeBuffer__Array *v18; // r14
		  ComputeBuffer *v19; // rax
		  ComputeBuffer *v20; // rbp
		  HGRuntimeGrassQuery_Node *v21; // rdx
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  int32_t j; // edi
		  NativeArray_1_System_UInt32___Array *m_gpuFeedbackData; // rax
		  NativeArray_1_System_UInt32___Array *v26; // rbp
		  __int64 v27; // rax
		  HGRuntimeGrassQuery_Node *v28; // rdx
		  HGRuntimeGrassQuery_Node *v29; // r8
		  Int32__Array **v30; // r9
		  int32_t m_feedbackWidth; // edi
		  int32_t m_feedbackHeight; // ebx
		  HGRuntimeGrassQuery_Node *v33; // rdx
		  HGRuntimeGrassQuery_Node *v34; // r8
		  Int32__Array **v35; // r9
		  MethodInfo *v36; // rdx
		  Color v37; // xmm1
		  RenderTargetIdentifier *v38; // rax
		  __int128 v39; // xmm2
		  __int64 v40; // xmm0_8
		  HGRuntimeGrassQuery_Node *v41; // rdx
		  HGRuntimeGrassQuery_Node *v42; // r8
		  Int32__Array **v43; // r9
		  MethodInfo *v44; // rdx
		  Color v45; // xmm1
		  RenderTargetIdentifier *v46; // rax
		  __int128 v47; // xmm2
		  __int64 v48; // xmm0_8
		  MethodInfo *usage; // [rsp+20h] [rbp-F8h]
		  MethodInfo *usagea; // [rsp+20h] [rbp-F8h]
		  MethodInfo *usageb; // [rsp+20h] [rbp-F8h]
		  MethodInfo *usagec; // [rsp+20h] [rbp-F8h]
		  MethodInfo *usaged; // [rsp+20h] [rbp-F8h]
		  NativeArray_1_System_UInt32_ v54; // [rsp+A0h] [rbp-78h] BYREF
		  RenderTargetIdentifier v55; // [rsp+B0h] [rbp-68h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3984, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3984, 0LL);
		    if ( !Patch )
		LABEL_15:
		      sub_1800D8260(Patch, v14);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_997(
		      Patch,
		      (Object *)this,
		      blockWidth,
		      blockHeight,
		      feedbackWidth,
		      feedbackHeight,
		      0LL);
		  }
		  else
		  {
		    this->fields.m_feedbackWidth = feedbackWidth;
		    this->fields.m_feedbackHeight = feedbackHeight;
		    this->fields.m_blockWidth = blockWidth;
		    this->fields.m_blockHeight = blockHeight;
		    v10 = feedbackHeight * feedbackWidth;
		    this->fields.m_gpuFeedbackBuffers = (ComputeBuffer__Array *)il2cpp_array_new_specific_1(
		                                                                  TypeInfo::UnityEngine::ComputeBuffer,
		                                                                  4LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_gpuFeedbackBuffers, v11, v12, v13, usage);
		    for ( i = 0; ; ++i )
		    {
		      m_gpuFeedbackBuffers = this->fields.m_gpuFeedbackBuffers;
		      if ( !m_gpuFeedbackBuffers )
		        goto LABEL_15;
		      if ( i >= m_gpuFeedbackBuffers->max_length.size )
		        break;
		      v18 = this->fields.m_gpuFeedbackBuffers;
		      v19 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		      v20 = v19;
		      if ( !v19 )
		        goto LABEL_15;
		      UnityEngine::ComputeBuffer::ComputeBuffer(
		        v19,
		        v10,
		        4,
		        ComputeBufferType__Enum_Structured,
		        ComputeBufferMode__Enum_Immutable,
		        0LL);
		      sub_180378FEC(v18, i, v20);
		    }
		    this->fields.m_gpuFeedbackData = (NativeArray_1_System_UInt32___Array *)il2cpp_array_new_specific_1(
		                                                                              TypeInfo::Unity::Collections::NativeArray<unsigned int>,
		                                                                              4LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_gpuFeedbackData, v21, v22, v23, usagea);
		    for ( j = 0; ; ++j )
		    {
		      m_gpuFeedbackData = this->fields.m_gpuFeedbackData;
		      if ( !m_gpuFeedbackData )
		        goto LABEL_15;
		      if ( j >= m_gpuFeedbackData->max_length.size )
		        break;
		      v26 = this->fields.m_gpuFeedbackData;
		      v54 = 0LL;
		      Unity::Collections::NativeArray<unsigned int>::NativeArray(
		        &v54,
		        v10,
		        Allocator__Enum_Persistent,
		        NativeArrayOptions__Enum_ClearMemory,
		        MethodInfo::Unity::Collections::NativeArray<unsigned int>::NativeArray);
		      if ( (unsigned int)j >= v26->max_length.size )
		        sub_1800D2AB0(Patch, v14);
		      v27 = 2 * (j + 2LL);
		      *(NativeArray_1_System_UInt32_ *)(&v26->klass + v27) = v54;
		    }
		    this->fields.m_gpuFeedbackRequests = (AsyncGPUReadbackRequest__Array *)il2cpp_array_new_specific_1(
		                                                                             TypeInfo::UnityEngine::Rendering::AsyncGPUReadbackRequest,
		                                                                             4LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_gpuFeedbackRequests, v28, v29, v30, usageb);
		    m_feedbackWidth = this->fields.m_feedbackWidth;
		    m_feedbackHeight = this->fields.m_feedbackHeight;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		    this->fields.m_gpuFeedbackDepth = UnityEngine::Rendering::RTHandles::Alloc(
		                                        m_feedbackWidth,
		                                        m_feedbackHeight,
		                                        1,
		                                        DepthBits__Enum_Depth32,
		                                        GraphicsFormat__Enum_D32_SFloat,
		                                        FilterMode__Enum_Point,
		                                        TextureWrapMode__Enum_Clamp,
		                                        TextureDimension__Enum_Tex2D,
		                                        0,
		                                        0,
		                                        0,
		                                        0,
		                                        1,
		                                        0.0,
		                                        MSAASamples__Enum_None,
		                                        0,
		                                        RenderTextureMemoryless__Enum_Depth,
		                                        (String *)"",
		                                        0LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_gpuFeedbackDepth, v33, v34, v35, usagec);
		    sub_18033B9D0(&this->fields.m_gpuFeedbackDepthDesc, 0LL, 120LL);
		    v37 = (Color)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one((Vector4 *)&v54, v36));
		    *(_QWORD *)&this->fields.m_gpuFeedbackDepthDesc.m_ClearDepth = 1065353216LL;
		    this->fields.m_gpuFeedbackDepthDesc.m_LoadAction = 1;
		    this->fields.m_gpuFeedbackDepthDesc.m_ClearColor = v37;
		    v38 = UnityEngine::Rendering::RTHandle::op_Implicit(&v55, this->fields.m_gpuFeedbackDepth, 0LL);
		    v39 = *(_OWORD *)&v38->m_BufferPointer;
		    v40 = *(_QWORD *)&v38->m_DepthSlice;
		    *(_OWORD *)&this->fields.m_gpuFeedbackDepthDesc.m_LoadStoreTarget.m_Type = *(_OWORD *)&v38->m_Type;
		    *(_OWORD *)&this->fields.m_gpuFeedbackDepthDesc.m_LoadStoreTarget.m_BufferPointer = v39;
		    *(_QWORD *)&this->fields.m_gpuFeedbackDepthDesc.m_LoadStoreTarget.m_DepthSlice = v40;
		    this->fields.m_gpuFeedbackDepthDesc.m_Format = 93;
		    this->fields.m_gpuFeedbackColor = UnityEngine::Rendering::RTHandles::Alloc(
		                                        this->fields.m_feedbackWidth,
		                                        this->fields.m_feedbackHeight,
		                                        1,
		                                        DepthBits__Enum_None,
		                                        GraphicsFormat__Enum_R8G8B8A8_UNorm,
		                                        FilterMode__Enum_Point,
		                                        TextureWrapMode__Enum_Clamp,
		                                        TextureDimension__Enum_Tex2D,
		                                        0,
		                                        0,
		                                        0,
		                                        0,
		                                        1,
		                                        0.0,
		                                        MSAASamples__Enum_None,
		                                        0,
		                                        RenderTextureMemoryless__Enum_Color,
		                                        (String *)"",
		                                        0LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_gpuFeedbackColor, v41, v42, v43, usaged);
		    sub_18033B9D0(&this->fields.m_gpuFeedbackColorDesc, 0LL, 120LL);
		    v45 = (Color)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one((Vector4 *)&v54, v44));
		    *(_QWORD *)&this->fields.m_gpuFeedbackColorDesc.m_ClearDepth = 1065353216LL;
		    this->fields.m_gpuFeedbackColorDesc.m_LoadAction = 1;
		    this->fields.m_gpuFeedbackColorDesc.m_ClearColor = v45;
		    v46 = UnityEngine::Rendering::RTHandle::op_Implicit(&v55, this->fields.m_gpuFeedbackColor, 0LL);
		    v47 = *(_OWORD *)&v46->m_BufferPointer;
		    v48 = *(_QWORD *)&v46->m_DepthSlice;
		    *(_OWORD *)&this->fields.m_gpuFeedbackColorDesc.m_LoadStoreTarget.m_Type = *(_OWORD *)&v46->m_Type;
		    *(_OWORD *)&this->fields.m_gpuFeedbackColorDesc.m_LoadStoreTarget.m_BufferPointer = v47;
		    *(_QWORD *)&this->fields.m_gpuFeedbackColorDesc.m_LoadStoreTarget.m_DepthSlice = v48;
		    this->fields.m_gpuFeedbackColorDesc.m_Format = 8;
		  }
		}
		
		private void _RefreshGPUFeedbackParams([IsReadOnly] in Vector2Int currScreenSize) {} // 0x0000000189C28BE8-0x0000000189C28CE8
		// Void _RefreshGPUFeedbackParams(Vector2Int ByRef)
		void HG::Rendering::Runtime::VirtualTextureRenderer::_RefreshGPUFeedbackParams(
		        VirtualTextureRenderer *this,
		        Vector2Int *currScreenSize,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGTerrainConfiguration *m_configuration; // rsi
		  int32_t vtSSBOBlockWidth; // esi
		  int32_t vtSSBOBlockHeight; // edi
		  int32_t v10; // r15d
		  int32_t feedbackHeight; // ebp
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3981, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3981, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1400(Patch, (Object *)this, currScreenSize, 0LL);
		      return;
		    }
		LABEL_9:
		    sub_1800D8260(v6, v5);
		  }
		  m_configuration = this->fields.m_configuration;
		  if ( !m_configuration )
		    goto LABEL_9;
		  vtSSBOBlockWidth = m_configuration->fields.vtSSBOBlockWidth;
		  vtSSBOBlockHeight = this->fields.m_configuration->fields.vtSSBOBlockHeight;
		  if ( vtSSBOBlockWidth != this->fields.m_blockWidth || vtSSBOBlockHeight != this->fields.m_blockHeight )
		    HG::Rendering::Runtime::VirtualTextureRenderer::_GenerateJitterSequenceForSSBO(
		      this,
		      vtSSBOBlockWidth,
		      vtSSBOBlockHeight,
		      0LL);
		  v10 = (vtSSBOBlockWidth + currScreenSize->m_X - 1) / vtSSBOBlockWidth;
		  feedbackHeight = (int)(vtSSBOBlockHeight + HIDWORD(*(unsigned __int64 *)currScreenSize) - 1) / vtSSBOBlockHeight;
		  if ( __PAIR64__(feedbackHeight, v10) != *(_QWORD *)&this->fields.m_feedbackWidth )
		  {
		    HG::Rendering::Runtime::VirtualTextureRenderer::_DestroyGPUFeedbackResources(this, 0LL);
		    HG::Rendering::Runtime::VirtualTextureRenderer::_AllocateGPUFeedbackResources(
		      this,
		      vtSSBOBlockWidth,
		      vtSSBOBlockHeight,
		      v10,
		      feedbackHeight,
		      0LL);
		  }
		}
		
		private void _RefreshCPUFeedbackParams([IsReadOnly] in Vector2Int currScreenSize) {} // 0x0000000189C28B1C-0x0000000189C28BE8
		// Void _RefreshCPUFeedbackParams(Vector2Int ByRef)
		void HG::Rendering::Runtime::VirtualTextureRenderer::_RefreshCPUFeedbackParams(
		        VirtualTextureRenderer *this,
		        Vector2Int *currScreenSize,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGTerrainConfiguration *m_configuration; // rax
		  int32_t vtFeedbackWidth; // r9d
		  int32_t feedbackHeight; // r8d
		  int32_t v10; // r10d
		  int32_t v11; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3977, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3977, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1400(Patch, (Object *)this, currScreenSize, 0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(v6, v5);
		  }
		  m_configuration = this->fields.m_configuration;
		  if ( !m_configuration )
		    goto LABEL_7;
		  vtFeedbackWidth = m_configuration->fields.vtFeedbackWidth;
		  this->fields.m_feedbackWidth = vtFeedbackWidth;
		  feedbackHeight = m_configuration->fields.vtFeedbackHeight;
		  this->fields.m_feedbackHeight = feedbackHeight;
		  v10 = (vtFeedbackWidth + currScreenSize->m_X - 1) / vtFeedbackWidth;
		  v11 = (int)(HIDWORD(*(unsigned __int64 *)currScreenSize) + feedbackHeight - 1) / feedbackHeight;
		  if ( v10 != this->fields.m_blockWidth || v11 != this->fields.m_blockHeight )
		  {
		    this->fields.m_blockWidth = v10;
		    this->fields.m_blockHeight = v11;
		    HG::Rendering::Runtime::VirtualTextureRenderer::_GenerateJitterSequenceForPhysX(
		      this,
		      v10,
		      v11,
		      vtFeedbackWidth,
		      feedbackHeight,
		      0LL);
		  }
		}
		
		private float _CalculateHeightNormFactor() => default; // 0x0000000189C283CC-0x0000000189C28428
		// Single _CalculateHeightNormFactor()
		float HG::Rendering::Runtime::VirtualTextureRenderer::_CalculateHeightNormFactor(
		        VirtualTextureRenderer *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4007, 0LL) )
		    return this->fields.m_heightmapScale.y * 2.0000916;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4007, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		
		public void SetupVTTexturesForMaterial(Material terrainLitMaterial) {} // 0x0000000189C278F0-0x0000000189C27A84
		// Void SetupVTTexturesForMaterial(Material)
		void HG::Rendering::Runtime::VirtualTextureRenderer::SetupVTTexturesForMaterial(
		        VirtualTextureRenderer *this,
		        Material *terrainLitMaterial,
		        MethodInfo *method)
		{
		  int32_t HGTerrainIndirectTexture; // esi
		  Texture *currIndirectTexture; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Texture *m_physicalBaseTex; // r8
		  Texture *m_physicalNormTex; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4004, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4004, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)terrainLitMaterial,
		        0LL);
		      return;
		    }
		LABEL_12:
		    sub_1800D8260(v8, v7);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  HGTerrainIndirectTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainIndirectTexture;
		  currIndirectTexture = (Texture *)HG::Rendering::Runtime::VirtualTextureRenderer::get_currIndirectTexture(this, 0LL);
		  if ( !terrainLitMaterial )
		    goto LABEL_12;
		  UnityEngine::Material::SetTextureImpl(terrainLitMaterial, HGTerrainIndirectTexture, currIndirectTexture, 0LL);
		  if ( this->fields.m_needVTTexturesSetup )
		  {
		    this->fields.m_needVTTexturesSetup = 0;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    if ( this->fields.m_enableCompression )
		      m_physicalBaseTex = (Texture *)this->fields.m_physicalBaseTex;
		    else
		      m_physicalBaseTex = (Texture *)this->fields.m_physicalBaseRt;
		    UnityEngine::Material::SetTextureImpl(
		      terrainLitMaterial,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainPhysicalBase,
		      m_physicalBaseTex,
		      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    if ( this->fields.m_enableCompression )
		      m_physicalNormTex = (Texture *)this->fields.m_physicalNormTex;
		    else
		      m_physicalNormTex = (Texture *)this->fields.m_physicalNormRt;
		    UnityEngine::Material::SetTextureImpl(
		      terrainLitMaterial,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainPhysicalNormal,
		      m_physicalNormTex,
		      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    UnityEngine::Material::SetTextureImpl(
		      terrainLitMaterial,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainTerrainNormalmapTexture,
		      (Texture *)this->fields.m_terrainNormalMap,
		      0LL);
		    UnityEngine::Material::SetTextureImpl(
		      terrainLitMaterial,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainHeightmap,
		      (Texture *)this->fields.m_terrainHeightmap,
		      0LL);
		  }
		}
		
		public void SetVTTexturesGlobal(CommandBuffer cmd) {} // 0x0000000189C274B0-0x0000000189C276C0
		// Void SetVTTexturesGlobal(CommandBuffer)
		void HG::Rendering::Runtime::VirtualTextureRenderer::SetVTTexturesGlobal(
		        VirtualTextureRenderer *this,
		        CommandBuffer *cmd,
		        MethodInfo *method)
		{
		  int32_t HGTerrainIndirectTexture; // ebx
		  Texture *currIndirectTexture; // rax
		  RenderTargetIdentifier *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int128 v10; // xmm1
		  int32_t HGTerrainPhysicalBase; // ebx
		  Texture *m_physicalBaseTex; // rdx
		  RenderTargetIdentifier *v13; // rax
		  __int64 v14; // xmm2_8
		  __int128 v15; // xmm1
		  int32_t HGTerrainPhysicalNormal; // ebx
		  Texture *m_physicalNormTex; // rdx
		  RenderTargetIdentifier *v18; // rax
		  __int64 v19; // xmm2_8
		  __int128 v20; // xmm1
		  int32_t HGTerrainTerrainNormalmapTexture; // ebx
		  RenderTargetIdentifier *v22; // rax
		  __int128 v23; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  RenderTargetIdentifier v27; // [rsp+20h] [rbp-60h] BYREF
		  RenderTargetIdentifier v28; // [rsp+50h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4009, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4009, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v26, v25);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)cmd,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    HGTerrainIndirectTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainIndirectTexture;
		    currIndirectTexture = (Texture *)HG::Rendering::Runtime::VirtualTextureRenderer::get_currIndirectTexture(this, 0LL);
		    v7 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v28, currIndirectTexture, 0LL);
		    if ( !cmd )
		      sub_1800D8260(v9, v8);
		    v10 = *(_OWORD *)&v7->m_BufferPointer;
		    *(_OWORD *)&v27.m_Type = *(_OWORD *)&v7->m_Type;
		    *(_QWORD *)&v27.m_DepthSlice = *(_QWORD *)&v7->m_DepthSlice;
		    *(_OWORD *)&v27.m_BufferPointer = v10;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, HGTerrainIndirectTexture, &v27, 0LL);
		    HGTerrainPhysicalBase = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainPhysicalBase;
		    if ( this->fields.m_enableCompression )
		      m_physicalBaseTex = (Texture *)this->fields.m_physicalBaseTex;
		    else
		      m_physicalBaseTex = (Texture *)this->fields.m_physicalBaseRt;
		    v13 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v28, m_physicalBaseTex, 0LL);
		    v14 = *(_QWORD *)&v13->m_DepthSlice;
		    v15 = *(_OWORD *)&v13->m_BufferPointer;
		    *(_OWORD *)&v27.m_Type = *(_OWORD *)&v13->m_Type;
		    *(_OWORD *)&v27.m_BufferPointer = v15;
		    *(_QWORD *)&v27.m_DepthSlice = v14;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, HGTerrainPhysicalBase, &v27, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    HGTerrainPhysicalNormal = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainPhysicalNormal;
		    if ( this->fields.m_enableCompression )
		      m_physicalNormTex = (Texture *)this->fields.m_physicalNormTex;
		    else
		      m_physicalNormTex = (Texture *)this->fields.m_physicalNormRt;
		    v18 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v28, m_physicalNormTex, 0LL);
		    v19 = *(_QWORD *)&v18->m_DepthSlice;
		    v20 = *(_OWORD *)&v18->m_BufferPointer;
		    *(_OWORD *)&v27.m_Type = *(_OWORD *)&v18->m_Type;
		    *(_OWORD *)&v27.m_BufferPointer = v20;
		    *(_QWORD *)&v27.m_DepthSlice = v19;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, HGTerrainPhysicalNormal, &v27, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    HGTerrainTerrainNormalmapTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainTerrainNormalmapTexture;
		    v22 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		            &v28,
		            (Texture *)this->fields.m_terrainNormalMap,
		            0LL);
		    v23 = *(_OWORD *)&v22->m_BufferPointer;
		    *(_OWORD *)&v27.m_Type = *(_OWORD *)&v22->m_Type;
		    *(_QWORD *)&v27.m_DepthSlice = *(_QWORD *)&v22->m_DepthSlice;
		    *(_OWORD *)&v27.m_BufferPointer = v23;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, HGTerrainTerrainNormalmapTexture, &v27, 0LL);
		  }
		}
		
		public void SetupVTDataBufferForMaterial(ComputeBuffer perTerrainDataBuffer) {} // 0x0000000189C276C0-0x0000000189C278F0
		// Void SetupVTDataBufferForMaterial(ComputeBuffer)
		void HG::Rendering::Runtime::VirtualTextureRenderer::SetupVTDataBufferForMaterial(
		        VirtualTextureRenderer *this,
		        ComputeBuffer *perTerrainDataBuffer,
		        MethodInfo *method)
		{
		  Void *m_Buffer; // rbx
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v11; // [rsp+30h] [rbp-28h]
		  NativeArray_1_UnityEngine_Vector4_ v12; // [rsp+40h] [rbp-18h] BYREF
		
		  v12 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(4005, 0LL) )
		  {
		    if ( !this->fields.m_needVTDataBufferSetup )
		      return;
		    this->fields.m_needVTDataBufferSetup = 0;
		    Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray(
		      &v12,
		      6,
		      Allocator__Enum_Temp,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
		    m_Buffer = v12.m_Buffer;
		    *((_QWORD *)&v11 + 1) = this->fields._terrainToVirtual_k__BackingField;
		    *(float *)&v11 = 1.0 / (float)this->fields.m_terrainSize.m_X;
		    *((float *)&v11 + 1) = 1.0 / (float)(int)HIDWORD(*(_QWORD *)&this->fields.m_terrainSize);
		    *(_OWORD *)v12.m_Buffer = v11;
		    *(float *)&v11 = this->fields.m_terrainPos.x;
		    *(_QWORD *)((char *)&v11 + 4) = *(_QWORD *)&this->fields.m_terrainPos.y;
		    HIDWORD(v11) = HG::Rendering::Runtime::VirtualTextureRenderer::_CalculateHeightNormFactor(this, 0LL);
		    v8 = v11;
		    HIDWORD(v11) = 1132462080;
		    *(_OWORD *)&m_Buffer[16] = v8;
		    *(float *)&v11 = (float)this->fields.m_cacheSliceWidth;
		    *((float *)&v11 + 1) = (float)this->fields.m_cacheSliceHeight;
		    DWORD2(v11) = LODWORD(this->fields.m_vtBaseMipBias);
		    v9 = v11;
		    HIDWORD(v11) = 0;
		    *(_OWORD *)&m_Buffer[32] = v9;
		    *(float *)&v11 = (float)this->fields.m_indirectMaxWidth;
		    *((float *)&v11 + 1) = (float)this->fields.m_indirectMaxHeight;
		    *((float *)&v11 + 2) = (float)this->fields.m_virtualTextureResolution;
		    *(_OWORD *)&m_Buffer[48] = v11;
		    *(float *)&v11 = (float)this->fields.m_indirectWidth;
		    *((float *)&v11 + 1) = (float)this->fields.m_indirectLevel;
		    *(_OWORD *)&m_Buffer[64] = (unsigned __int64)v11;
		    *(__m128i *)&m_Buffer[80] = _mm_loadu_si128((const __m128i *)&this->fields.m_lightmapScaleOffset);
		    if ( perTerrainDataBuffer )
		    {
		      sub_1808B0C90(perTerrainDataBuffer, &v12);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4005, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)perTerrainDataBuffer,
		    0LL);
		}
		
		private uint _PackIndirectParam(int pageIndex, int level) => default; // 0x0000000189C28A00-0x0000000189C28AA8
		// UInt32 _PackIndirectParam(Int32, Int32)
		uint32_t HG::Rendering::Runtime::VirtualTextureRenderer::_PackIndirectParam(
		        VirtualTextureRenderer *this,
		        int32_t pageIndex,
		        int32_t level,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4002, 0LL) )
		    return ((this->fields.m_cachePageCountTotal - pageIndex)
		          % this->fields.m_cachePageCountPerSlice
		          % this->fields.m_cacheColNumPerSlice) | ((((level | (((this->fields.m_cachePageCountTotal - pageIndex)
		                                                              / this->fields.m_cachePageCountPerSlice) << 8)) << 8) | ((this->fields.m_cachePageCountTotal - pageIndex) % this->fields.m_cachePageCountPerSlice / this->fields.m_cacheColNumPerSlice)) << 8);
		  Patch = IFix::WrappersManagerImpl::GetPatch(4002, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v10, v9);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_10(
		           (ILFixDynamicMethodWrapper_14 *)Patch,
		           (Object *)this,
		           (SocketOptionLevel__Enum)pageIndex,
		           (SocketOptionName__Enum)level,
		           0LL);
		}
		
		public void MarkCurrentGPUFeedbackBufferFilled(bool filled) {} // 0x0000000189C24DC4-0x0000000189C24E40
		// Void MarkCurrentGPUFeedbackBufferFilled(Boolean)
		void HG::Rendering::Runtime::VirtualTextureRenderer::MarkCurrentGPUFeedbackBufferFilled(
		        VirtualTextureRenderer *this,
		        bool filled,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Boolean__Array *m_gpuFeedbackBufferFilled; // r8
		  __int64 v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3999, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3999, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, filled, 0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(v6, v5);
		  }
		  m_gpuFeedbackBufferFilled = this->fields.m_gpuFeedbackBufferFilled;
		  if ( !m_gpuFeedbackBufferFilled )
		    goto LABEL_7;
		  v8 = this->fields.m_frameCount & 3;
		  if ( (unsigned int)v8 >= m_gpuFeedbackBufferFilled->max_length.size )
		    sub_1800D2AB0(v6, v5);
		  m_gpuFeedbackBufferFilled->vector[v8] = filled;
		}
		
		private void ClearArray<T>(NativeArray<T> array)
			where T : struct {}
	}
}
