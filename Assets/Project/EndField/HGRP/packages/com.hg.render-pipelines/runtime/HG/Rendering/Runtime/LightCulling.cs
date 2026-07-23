using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal abstract class LightCulling : IDisposable // TypeDefIndex: 37771
	{
		// Fields
		public static readonly int MAX_NUM_TILE_X; // 0x00
		public static readonly int MAX_NUM_TILE_Y; // 0x04
		public static readonly int NUM_Z_SLICES; // 0x08
		public static readonly int NUM_FLOAT4_PUNCTUALIGHT; // 0x0C
		public static readonly int NUM_FLOAT4_PUNCTUALIGHT_DESC; // 0x10
		public static readonly int XYPLANE_BINNING_GROUP_SIZE; // 0x14
		public static readonly int ZPLANE_BINNING_GROUP_SIZE; // 0x18
		protected NativeArray<float3> m_frustumCorners; // 0x10
		protected NativeArray<float3> m_tileVertices; // 0x20
		protected NativeArray<float4> m_XPlanes; // 0x30
		protected NativeArray<float4> m_YPlanes; // 0x40
		protected NativeArray<float4> m_lightSphereData; // 0x50
		private BinningConstants m_binningConstants; // 0x60
		private ComputeBufferDesc m_punctualLightDataDesc; // 0xA8
		protected ComputeBufferHandle m_punctualLightDataBuffer; // 0xC0
		protected NativeArray<float4> m_punctualLightDataArray; // 0xC8
		protected NativeArray<uint> m_volumetricFogLightMask; // 0xD8
		protected bool m_outputTileDrawBuffers; // 0xE8
		protected GraphicsBuffer m_quadIndexBuffer; // 0xF0
		protected ComputeBuffer[] m_drawTileArgsBuffers; // 0xF8
		protected uint m_frameIndex; // 0x100
		protected bool m_needClearArgsBuffer; // 0x104
		protected ComputeBufferHandle m_drawTileArgsBufferHandle; // 0x108
		protected ComputeBufferHandle m_drawTileArgsBufferNextFrameHandle; // 0x110
		protected ComputeBufferHandle m_tileInstanceIndicesBufferHandle; // 0x118
	
		// Properties
		public int numTiles { get; } // 0x0000000189D0E62C-0x0000000189D0E698 
		// Int32 get_numTiles()
		int32_t HG::Rendering::Runtime::LightCulling::get_numTiles(LightCulling *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  LightCulling_BinningConstants v8; // [rsp+50h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1900, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1900, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    LODWORD(v3) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                    (ILFixDynamicMethodWrapper_31 *)Patch,
		                    (Object *)this,
		                    0LL);
		  }
		  else
		  {
		    return HIDWORD(*(_QWORD *)&HG::Rendering::Runtime::LightCulling::get_binningConstants(&v8, this, 0LL)->lightCount);
		  }
		  return v3;
		}
		
		protected BinningConstants binningConstants { get; } // 0x0000000189D0E5A8-0x0000000189D0E62C 
		// LightCulling+BinningConstants get_binningConstants()
		LightCulling_BinningConstants *HG::Rendering::Runtime::LightCulling::get_binningConstants(
		        LightCulling_BinningConstants *__return_ptr retstr,
		        LightCulling *this,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm1
		  __int128 v6; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  LightCulling_BinningConstants *v10; // rax
		  LightCulling_BinningConstants *result; // rax
		  LightCulling_BinningConstants v12; // [rsp+20h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1901, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1901, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_763(&v12, Patch, (Object *)this, 0LL);
		    v5 = *(_OWORD *)&v10->tileSize;
		    *(_OWORD *)&retstr->lightCount = *(_OWORD *)&v10->lightCount;
		    v6 = *(_OWORD *)&v10->nearClipPlane;
		  }
		  else
		  {
		    v5 = *(_OWORD *)&this->fields.m_binningConstants.tileSize;
		    *(_OWORD *)&retstr->lightCount = *(_OWORD *)&this->fields.m_binningConstants.lightCount;
		    v6 = *(_OWORD *)&this->fields.m_binningConstants.nearClipPlane;
		  }
		  *(_OWORD *)&retstr->tileSize = v5;
		  result = retstr;
		  *(_OWORD *)&retstr->nearClipPlane = v6;
		  return result;
		}
		
		protected CBHandle binningConstantsCBHandle { get; private set; } // 0x0000000184D9DCA0-0x0000000184D9DCC0 0x0000000184DA21B0-0x0000000184DA21D0
		// PosRot get_value()
		PosRot *Beyond::Gameplay::ParamVariable<Beyond::PosRot>::get_value(
		        PosRot *__return_ptr retstr,
		        ParamVariable_1_Beyond_PosRot_ *this,
		        MethodInfo *method)
		{
		  PosRot *result; // rax
		  __int64 v4; // xmm1_8
		
		  result = retstr;
		  v4 = *(_QWORD *)&this->fields.m_value.eulerAngles.y;
		  *(_OWORD *)&retstr->position.x = *(_OWORD *)&this->fields.m_value.position.x;
		  *(_QWORD *)&retstr->eulerAngles.y = v4;
		  return result;
		}
		

		// Void set_binningConstantsCBHandle(CBHandle)
		void HG::Rendering::Runtime::LightCulling::set_binningConstantsCBHandle(
		        LightCulling *this,
		        CBHandle *value,
		        MethodInfo *method)
		{
		  void *ptr; // xmm1_8
		
		  ptr = value->ptr;
		  *(_OWORD *)&this->fields._binningConstantsCBHandle_k__BackingField.bufferId = *(_OWORD *)&value->bufferId;
		  this->fields._binningConstantsCBHandle_k__BackingField.ptr = ptr;
		}
		
		public ComputeBufferHandle DrawTileArgsBufferHandle { get; } // 0x0000000189D0E410-0x0000000189D0E460 
		// ComputeBufferHandle get_DrawTileArgsBufferHandle()
		ComputeBufferHandle HG::Rendering::Runtime::LightCulling::get_DrawTileArgsBufferHandle(
		        LightCulling *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1902, 0LL) )
		    return this->fields.m_drawTileArgsBufferHandle;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1902, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_764(Patch, (Object *)this, 0LL);
		}
		
		public ComputeBufferHandle TileInstanceIndicesBufferHandle { get; } // 0x0000000189D0E558-0x0000000189D0E5A8 
		// ComputeBufferHandle get_TileInstanceIndicesBufferHandle()
		ComputeBufferHandle HG::Rendering::Runtime::LightCulling::get_TileInstanceIndicesBufferHandle(
		        LightCulling *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1903, 0LL) )
		    return this->fields.m_tileInstanceIndicesBufferHandle;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1903, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_764(Patch, (Object *)this, 0LL);
		}
		
		public GraphicsBuffer QuadIndexBuffer { get; } // 0x0000000189D0E460-0x0000000189D0E558 
		// GraphicsBuffer get_QuadIndexBuffer()
		GraphicsBuffer *HG::Rendering::Runtime::LightCulling::get_QuadIndexBuffer(LightCulling *this, MethodInfo *method)
		{
		  GraphicsBuffer *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  GraphicsBuffer *v6; // rdi
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  GraphicsBuffer *m_quadIndexBuffer; // rdi
		  Array *v11; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v14; // [rsp+20h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1904, 0LL) )
		  {
		    if ( this->fields.m_quadIndexBuffer )
		      return this->fields.m_quadIndexBuffer;
		    v3 = (GraphicsBuffer *)sub_18002C620(TypeInfo::UnityEngine::GraphicsBuffer);
		    v6 = v3;
		    if ( v3 )
		    {
		      UnityEngine::GraphicsBuffer::GraphicsBuffer(v3, GraphicsBuffer_Target__Enum_Index, 6, 4, 0LL);
		      this->fields.m_quadIndexBuffer = v6;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_quadIndexBuffer, v7, v8, v9, v14);
		      m_quadIndexBuffer = this->fields.m_quadIndexBuffer;
		      v11 = (Array *)il2cpp_array_new_specific_1(TypeInfo::System::UInt32, 6LL);
		      System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		        v11,
		        FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE_Field_0,
		        0LL);
		      if ( m_quadIndexBuffer )
		      {
		        UnityEngine::GraphicsBuffer::SetData(m_quadIndexBuffer, v11, 0LL);
		        return this->fields.m_quadIndexBuffer;
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1904, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_765(Patch, (Object *)this, 0LL);
		}
		
	
		// Nested types
		protected struct BinningConstants // TypeDefIndex: 37770
		{
			// Fields
			internal int lightCount; // 0x00
			internal int numTiles; // 0x04
			internal int actualWidth; // 0x08
			internal int actualHeight; // 0x0C
			internal float tileSize; // 0x10
			internal float numTilesX; // 0x14
			internal float numTilesY; // 0x18
			internal float numSliceZ; // 0x1C
			internal float nearClipPlane; // 0x20
			internal float farClipPlane; // 0x24
			internal float zBinSlice; // 0x28
			internal float invZBinSlice; // 0x2C
		}
	
		// Constructors
		public LightCulling() {} // 0x00000001841A21F0-0x00000001841A24E0
		// LightCulling()
		void HG::Rendering::Runtime::LightCulling::LightCulling(LightCulling *this, MethodInfo *method)
		{
		  __int128 v2; // xmm1
		  __int128 v4; // xmm0
		  struct LightCulling__Class *v5; // rcx
		  LightCulling__StaticFields *static_fields; // rax
		  struct Il2CppType *v7; // rbx
		  int32_t NUM_FLOAT4_PUNCTUALIGHT; // esi
		  Type *TypeFromHandle; // rbx
		  int v10; // eax
		  String *v11; // xmm1_8
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  _BYTE v15[48]; // [rsp+30h] [rbp-30h] BYREF
		  MethodInfo *v16; // [rsp+90h] [rbp+30h]
		
		  *(_DWORD *)&v15[16] = 1107296256;
		  memset(&v15[20], 0, 20);
		  *(_DWORD *)&v15[40] = 1065353216;
		  v2 = *(_OWORD *)&v15[16];
		  *(_DWORD *)&v15[44] = 1065353216;
		  *(_OWORD *)&this->fields.m_binningConstants.lightCount = 0u;
		  v4 = *(_OWORD *)&v15[32];
		  *(_OWORD *)&this->fields.m_binningConstants.tileSize = v2;
		  *(_OWORD *)&this->fields.m_binningConstants.nearClipPlane = v4;
		  *(_OWORD *)v15 = 0LL;
		  Unity::Collections::NativeArray<Unity::Mathematics::float3>::NativeArray(
		    (NativeArray_1_Unity_Mathematics_float3_ *)v15,
		    8,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float3>::NativeArray);
		  this->fields.m_frustumCorners = *(NativeArray_1_Unity_Mathematics_float3_ *)v15;
		  v5 = TypeInfo::HG::Rendering::Runtime::LightCulling;
		  if ( !TypeInfo::HG::Rendering::Runtime::LightCulling->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::LightCulling);
		    v5 = TypeInfo::HG::Rendering::Runtime::LightCulling;
		  }
		  static_fields = v5->static_fields;
		  *(_OWORD *)v15 = 0LL;
		  Unity::Collections::NativeArray<Unity::Mathematics::float3>::NativeArray(
		    (NativeArray_1_Unity_Mathematics_float3_ *)v15,
		    (static_fields->MAX_NUM_TILE_X + 1) * (static_fields->MAX_NUM_TILE_Y + 1),
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float3>::NativeArray);
		  this->fields.m_tileVertices = *(NativeArray_1_Unity_Mathematics_float3_ *)v15;
		  *(_OWORD *)v15 = 0LL;
		  Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
		    (NativeArray_1_Unity_Mathematics_quaternion_ *)v15,
		    TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->MAX_NUM_TILE_X + 1,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::NativeArray);
		  this->fields.m_XPlanes = *(NativeArray_1_Unity_Mathematics_float4_ *)v15;
		  *(_OWORD *)v15 = 0LL;
		  Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
		    (NativeArray_1_Unity_Mathematics_quaternion_ *)v15,
		    TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->MAX_NUM_TILE_Y + 1,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::NativeArray);
		  this->fields.m_YPlanes = *(NativeArray_1_Unity_Mathematics_float4_ *)v15;
		  *(_OWORD *)v15 = 0LL;
		  Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
		    (NativeArray_1_Unity_Mathematics_quaternion_ *)v15,
		    256,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::NativeArray);
		  this->fields.m_lightSphereData = *(NativeArray_1_Unity_Mathematics_float4_ *)v15;
		  *(_OWORD *)v15 = 0LL;
		  Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
		    (NativeArray_1_Unity_Mathematics_quaternion_ *)v15,
		    (TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT << 8) + 6,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::NativeArray);
		  this->fields.m_punctualLightDataArray = *(NativeArray_1_Unity_Mathematics_float4_ *)v15;
		  *(_OWORD *)v15 = 0LL;
		  Unity::Collections::NativeArray<unsigned int>::NativeArray(
		    (NativeArray_1_System_UInt32_ *)v15,
		    8,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<unsigned int>::NativeArray);
		  this->fields.m_volumetricFogLightMask = *(NativeArray_1_System_UInt32_ *)v15;
		  v7 = TypeRef::Unity::Mathematics::float4;
		  NUM_FLOAT4_PUNCTUALIGHT = TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT;
		  if ( !TypeInfo::System::Type->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::System::Type);
		  TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v7, 0LL);
		  if ( !TypeInfo::System::Runtime::InteropServices::Marshal->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::System::Runtime::InteropServices::Marshal);
		  *(_QWORD *)&v15[12] = 0LL;
		  *(_DWORD *)v15 = (NUM_FLOAT4_PUNCTUALIGHT << 8) + 6;
		  *(_DWORD *)&v15[20] = 0;
		  v10 = System::Runtime::InteropServices::Marshal::SizeOf(TypeFromHandle);
		  v11 = *(String **)&v15[16];
		  *(_DWORD *)&v15[4] = v10;
		  *(_DWORD *)&v15[8] = 8;
		  *(_OWORD *)&this->fields.m_punctualLightDataDesc.count = *(_OWORD *)v15;
		  this->fields.m_punctualLightDataDesc.name = v11;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_punctualLightDataDesc.name, v12, v13, v14, v16);
		}
		
		static LightCulling() {} // 0x0000000184D2C0D0-0x0000000184D2C170
		// LightCulling()
		void HG::Rendering::Runtime::LightCulling::cctor(MethodInfo *method)
		{
		  TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->MAX_NUM_TILE_X = 256;
		  TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->MAX_NUM_TILE_Y = 128;
		  TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_Z_SLICES = 2048;
		  TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT = 8;
		  TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT_DESC = 3;
		  TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->XYPLANE_BINNING_GROUP_SIZE = 8;
		  TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->ZPLANE_BINNING_GROUP_SIZE = 64;
		}
		
	
		// Methods
		public virtual void Dispose() {} // 0x0000000184CADAD0-0x0000000184CADB70
		// Void Dispose()
		void HG::Rendering::Runtime::LightCulling::Dispose(LightCulling *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1905, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1905, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_ *)&this->fields,
		      MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float3>::Dispose);
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_ *)&this->fields.m_tileVertices,
		      MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float3>::Dispose);
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_ *)&this->fields.m_XPlanes,
		      MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::Dispose);
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_ *)&this->fields.m_YPlanes,
		      MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::Dispose);
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_ *)&this->fields.m_lightSphereData,
		      MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::Dispose);
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_ *)&this->fields.m_punctualLightDataArray,
		      MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::Dispose);
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_ *)&this->fields.m_volumetricFogLightMask,
		      MethodInfo::Unity::Collections::NativeArray<unsigned int>::Dispose);
		  }
		}
		
		protected abstract void _PreparePunctualLightDescInternal([IsReadOnly] in VisibleLight punctualLight, HGCamera hgCamera, int lightIndex);
		protected abstract void _PrepareCPUDataInternal(HGCamera hgCamera, NativeArray<VisibleLight> visibleLights, NativeArray<int> lightIndices, int directionalLightIndex);
		public virtual void SetOuputTileDrawBuffers(bool isNeed) {} // 0x0000000189D0E12C-0x0000000189D0E188
		// Void SetOuputTileDrawBuffers(Boolean)
		void HG::Rendering::Runtime::LightCulling::SetOuputTileDrawBuffers(LightCulling *this, bool isNeed, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1906, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1906, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, isNeed, 0LL);
		  }
		  else
		  {
		    this->fields.m_outputTileDrawBuffers = isNeed;
		  }
		}
		
		public virtual void PrepareRenderGraphBuffers(HGRenderGraph renderGraph, HGRenderGraphBuilder builder) {} // 0x0000000189D0E07C-0x0000000189D0E12C
		// Void PrepareRenderGraphBuffers(HGRenderGraph, HGRenderGraphBuilder)
		void HG::Rendering::Runtime::LightCulling::PrepareRenderGraphBuffers(
		        LightCulling *this,
		        HGRenderGraph *renderGraph,
		        HGRenderGraphBuilder *builder,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v10; // xmm1
		  ComputeBufferHandle input; // [rsp+30h] [rbp-38h] BYREF
		  HGRenderGraphBuilder v12; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1907, 0LL) )
		  {
		    if ( renderGraph )
		    {
		      input = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
		                renderGraph,
		                &this->fields.m_punctualLightDataDesc,
		                0LL);
		      this->fields.m_punctualLightDataBuffer = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
		                                                 builder,
		                                                 &input,
		                                                 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1907, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  v10 = *(_OWORD *)&builder->m_RenderGraph;
		  *(_OWORD *)&v12.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		  *(_OWORD *)&v12.m_RenderGraph = v10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_766(Patch, (Object *)this, (Object *)renderGraph, &v12, 0LL);
		}
		
		public virtual void PrepareGPUData(HGRenderGraphContext context, HGCamera hgCamera, float renderingScale, ComputeBufferHandle binningBuffer) {} // 0x0000000189D0DFF4-0x0000000189D0E07C
		// Void PrepareGPUData(HGRenderGraphContext, HGCamera, Single, ComputeBufferHandle)
		void HG::Rendering::Runtime::LightCulling::PrepareGPUData(
		        LightCulling *this,
		        HGRenderGraphContext *context,
		        HGCamera *hgCamera,
		        float renderingScale,
		        ComputeBufferHandle binningBuffer,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1908, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1908, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_767(
		      Patch,
		      (Object *)this,
		      (Object *)context,
		      (Object *)hgCamera,
		      renderingScale,
		      binningBuffer,
		      0LL);
		  }
		}
		
		public virtual void SetupGlobalConstants(HGRenderGraphContext context) {} // 0x0000000189D0E188-0x0000000189D0E410
		// Void SetupGlobalConstants(HGRenderGraphContext)
		void HG::Rendering::Runtime::LightCulling::SetupGlobalConstants(
		        LightCulling *this,
		        HGRenderGraphContext *context,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  CommandBuffer *cmd; // r14
		  int32_t size; // ebx
		  CBHandle *ConstantBuffer; // rax
		  __m128i v10; // xmm6
		  CBHandle *v11; // rax
		  __int128 v12; // xmm1
		  void *ptr; // xmm0_8
		  Void *v14; // rdx
		  uint32_t bufferId; // edx
		  HGShaderIDs__StaticFields *v16; // rcx
		  __m128i v17; // xmm1
		  int32_t v18; // ebx
		  CBHandle *v19; // rax
		  __m128i v20; // xmm6
		  LightCulling_BinningConstants *binningConstants; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  CBHandle v23[2]; // [rsp+38h] [rbp-29h] BYREF
		  LightCulling_BinningConstants v24; // [rsp+68h] [rbp+7h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1909, 0LL) )
		  {
		    if ( context )
		    {
		      cmd = context->fields.cmd;
		      size = 16 * this->fields.m_punctualLightDataArray.m_Length;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                         v23,
		                         &context->fields.renderContext,
		                         size,
		                         0LL);
		      v10 = *(__m128i *)&ConstantBuffer->bufferId;
		      v23[0].ptr = ConstantBuffer->ptr;
		      System::Buffer::MemoryCopy(this->fields.m_punctualLightDataArray.m_Buffer, (Void *)v23[0].ptr, size, size, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( cmd )
		      {
		        UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		          cmd,
		          _mm_cvtsi128_si32(v10),
		          static_fields->_LightDataBuffer,
		          _mm_cvtsi128_si32(_mm_srli_si128(v10, 4)),
		          size,
		          0LL);
		        v11 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                v23,
		                &context->fields.renderContext,
		                48,
		                0LL);
		        v12 = *(_OWORD *)&v11->bufferId;
		        v23[0].ptr = v11->ptr;
		        ptr = v23[0].ptr;
		        v14 = (Void *)v23[0].ptr;
		        *(_OWORD *)&this->fields._binningConstantsCBHandle_k__BackingField.bufferId = v12;
		        this->fields._binningConstantsCBHandle_k__BackingField.ptr = ptr;
		        System::Buffer::MemoryCopy((Void *)&this->fields.m_binningConstants, v14, 48LL, 48LL, 0LL);
		        bufferId = this->fields._binningConstantsCBHandle_k__BackingField.bufferId;
		        v16 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        v17 = _mm_srli_si128(*(__m128i *)&this->fields._binningConstantsCBHandle_k__BackingField.bufferId, 4);
		        v23[0].ptr = this->fields._binningConstantsCBHandle_k__BackingField.ptr;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		          cmd,
		          bufferId,
		          v16->_LightBinningConstants,
		          _mm_cvtsi128_si32(v17),
		          48,
		          0LL);
		        v18 = 4 * this->fields.m_volumetricFogLightMask.m_Length;
		        v19 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                v23,
		                &context->fields.renderContext,
		                v18,
		                0LL);
		        v20 = *(__m128i *)&v19->bufferId;
		        v23[0].ptr = v19->ptr;
		        Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
		          (Void *)v23[0].ptr,
		          this->fields.m_volumetricFogLightMask.m_Buffer,
		          v18,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		          cmd,
		          _mm_cvtsi128_si32(v20),
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VolumetricFogLightMask,
		          _mm_cvtsi128_si32(_mm_srli_si128(v20, 4)),
		          v18,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		        binningConstants = HG::Rendering::Runtime::LightCulling::get_binningConstants(&v24, this, 0LL);
		        UnityEngine::Rendering::CommandBuffer::SetKeyword(
		          cmd,
		          &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DisableDynamicLightLoop,
		          binningConstants->lightCount == 0,
		          0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(static_fields, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1909, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)context,
		    0LL);
		}
		
		public virtual void FrameSetup(HGCamera hgCamera) {} // 0x0000000189D0C4E8-0x0000000189D0C7BC
		// Void FrameSetup(HGCamera)
		void HG::Rendering::Runtime::LightCulling::FrameSetup(LightCulling *this, HGCamera *hgCamera, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Camera *camera; // rsi
		  Frustum frustum; // xmm6
		  unsigned __int64 v9; // xmm6_8
		  float3 *v10; // rax
		  Void *v11; // rcx
		  float v12; // edx
		  float3 *v13; // rax
		  Void *v14; // rcx
		  float v15; // edx
		  float3 *v16; // rax
		  Void *v17; // rdx
		  float v18; // r8d
		  __int64 v19; // r8
		  float3 *xyz; // rax
		  Void *m_Buffer; // rcx
		  float z; // edx
		  float3 *v23; // rax
		  Void *v24; // rcx
		  float v25; // edx
		  float3 *v26; // rax
		  Void *v27; // rdx
		  float v28; // r8d
		  float3 *v29; // rax
		  Void *v30; // rcx
		  float v31; // edx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  float4 v33; // [rsp+20h] [rbp-30h] BYREF
		  float4 v34; // [rsp+30h] [rbp-20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1912, 0LL) )
		  {
		    if ( hgCamera )
		    {
		      camera = hgCamera->fields.camera;
		      frustum = hgCamera->fields.frustum;
		      if ( camera )
		      {
		        this->fields.m_binningConstants.nearClipPlane = UnityEngine::Camera::get_nearClipPlane(
		                                                          hgCamera->fields.camera,
		                                                          0LL);
		        this->fields.m_binningConstants.farClipPlane = UnityEngine::Camera::get_farClipPlane(camera, 0LL);
		        v9 = _mm_srli_si128((__m128i)frustum, 8).m128i_u64[0];
		        if ( UnityEngine::SystemInfo::GetGraphicsUVStartsAtTop(0LL) )
		        {
		          if ( v9 )
		          {
		            sub_180049C60(v9, &v34, 4LL);
		            *(_QWORD *)&v33.x = *(_QWORD *)&v34.x;
		            v33.z = v34.z;
		            xyz = Unity::Mathematics::float4::get_xyz((float3 *)&v34, &v33, 0LL);
		            m_Buffer = this->fields.m_frustumCorners.m_Buffer;
		            z = xyz->z;
		            *(_QWORD *)m_Buffer = *(_QWORD *)&xyz->x;
		            *(float *)&m_Buffer[8] = z;
		            sub_180049C60(v9, &v34, 5LL);
		            *(_QWORD *)&v33.x = *(_QWORD *)&v34.x;
		            v33.z = v34.z;
		            v23 = Unity::Mathematics::float4::get_xyz((float3 *)&v34, &v33, 0LL);
		            v24 = this->fields.m_frustumCorners.m_Buffer;
		            v25 = v23->z;
		            *(_QWORD *)&v24[12] = *(_QWORD *)&v23->x;
		            *(float *)&v24[20] = v25;
		            sub_180049C60(v9, &v34, 6LL);
		            *(_QWORD *)&v33.x = *(_QWORD *)&v34.x;
		            v33.z = v34.z;
		            v26 = Unity::Mathematics::float4::get_xyz((float3 *)&v34, &v33, 0LL);
		            v27 = this->fields.m_frustumCorners.m_Buffer;
		            v28 = v26->z;
		            *(_QWORD *)&v27[24] = *(_QWORD *)&v26->x;
		            *(float *)&v27[32] = v28;
		            v19 = 7LL;
		            goto LABEL_9;
		          }
		        }
		        else if ( v9 )
		        {
		          sub_180049C60(v9, &v33, 6LL);
		          *(_QWORD *)&v34.x = *(_QWORD *)&v33.x;
		          v34.z = v33.z;
		          v10 = Unity::Mathematics::float4::get_xyz((float3 *)&v33, &v34, 0LL);
		          v11 = this->fields.m_frustumCorners.m_Buffer;
		          v12 = v10->z;
		          *(_QWORD *)v11 = *(_QWORD *)&v10->x;
		          *(float *)&v11[8] = v12;
		          sub_180049C60(v9, &v34, 7LL);
		          *(_QWORD *)&v33.x = *(_QWORD *)&v34.x;
		          v33.z = v34.z;
		          v13 = Unity::Mathematics::float4::get_xyz((float3 *)&v34, &v33, 0LL);
		          v14 = this->fields.m_frustumCorners.m_Buffer;
		          v15 = v13->z;
		          *(_QWORD *)&v14[12] = *(_QWORD *)&v13->x;
		          *(float *)&v14[20] = v15;
		          sub_180049C60(v9, &v34, 4LL);
		          *(_QWORD *)&v33.x = *(_QWORD *)&v34.x;
		          v33.z = v34.z;
		          v16 = Unity::Mathematics::float4::get_xyz((float3 *)&v34, &v33, 0LL);
		          v17 = this->fields.m_frustumCorners.m_Buffer;
		          v18 = v16->z;
		          *(_QWORD *)&v17[24] = *(_QWORD *)&v16->x;
		          *(float *)&v17[32] = v18;
		          v19 = 5LL;
		LABEL_9:
		          sub_180049C60(v9, &v34, v19);
		          *(_QWORD *)&v33.x = *(_QWORD *)&v34.x;
		          v33.z = v34.z;
		          v29 = Unity::Mathematics::float4::get_xyz((float3 *)&v34, &v33, 0LL);
		          v30 = this->fields.m_frustumCorners.m_Buffer;
		          v31 = v29->z;
		          *(_QWORD *)&v30[36] = *(_QWORD *)&v29->x;
		          *(float *)&v30[44] = v31;
		          return;
		        }
		      }
		    }
		LABEL_11:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1912, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)hgCamera,
		    0LL);
		}
		
		public void PrepareCPUData(HGCamera camera, BinningPass.BinningData binningData, NativeArray<VisibleLight> visibleLights, NativeArray<int> lightIndices, NativeArray<float> lightDistances, int directionalLightIndex, int punctualLightCount, uint4 lightMasks) {} // 0x0000000189D0C7BC-0x0000000189D0DFF4
		// Void PrepareCPUData(HGCamera, BinningPass+BinningData, NativeArray`1[UnityEngine.Rendering.VisibleLight], NativeArray`1[System.Int32], NativeArray`1[System.Single], Int32, Int32, uint4)
		void HG::Rendering::Runtime::LightCulling::PrepareCPUData(
		        LightCulling *this,
		        HGCamera *camera,
		        BinningPass_BinningData *binningData,
		        NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights,
		        NativeArray_1_System_Int32_ *lightIndices,
		        NativeArray_1_System_Single_ *lightDistances,
		        int32_t directionalLightIndex,
		        int32_t punctualLightCount,
		        uint4 *lightMasks,
		        MethodInfo *method)
		{
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ *v13; // r14
		  int32_t v14; // esi
		  NativeArray_1_System_Int32_ *v15; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Vector2Int sceneRTSize_k__BackingField; // rax
		  __m128i v18; // xmm15
		  __m128i v19; // xmm0
		  __int64 v20; // rax
		  __int64 v21; // rax
		  float v22; // xmm1_4
		  HGEnvironmentVolumeCameraComponent *envVolumeCameraComponent; // rbx
		  Light *light; // rax
		  Vector3 *Forward; // rax
		  __int64 v26; // xmm0_8
		  MethodInfo *v27; // r8
		  MethodInfo *v28; // r8
		  Color v29; // xmm1
		  Beyond::DampingMath *v30; // rcx
		  Beyond::DampingMath *v31; // rcx
		  HGEnvironmentVolumeCameraComponent *v32; // rax
		  HGEnvironmentPhase *interpolatedPhase; // rax
		  MethodInfo *v34; // r8
		  HGLightConfig *p_lightConfig; // rbx
		  float z; // eax
		  MethodInfo *v37; // r8
		  MethodInfo *v38; // r8
		  Vector4 *AsVector4; // rax
		  float directIntensityDividePi; // xmm1_4
		  float v41; // xmm0_4
		  Beyond::DampingMath *v42; // rcx
		  float v43; // xmm0_4
		  Beyond::DampingMath *v44; // rcx
		  HGShadowManager *shadowManager; // rdi
		  HGPunctualLightShadowManagerV2 *m_punctualLightShadowManagerV2; // rdi
		  __int64 v47; // rcx
		  HGLightCookieManager *lightCookieManager; // r15
		  Void *m_Buffer; // r8
		  Void *lightEntity; // r14
		  unsigned __int64 v51; // rax
		  Void *v52; // rax
		  float LightFalloff; // xmm2_4
		  MethodInfo *v54; // r8
		  MethodInfo *v55; // r9
		  __m128i v56; // xmm6
		  float flickerScale_Injected; // xmm0_4
		  MethodInfo *v58; // r9
		  __m128 v59; // xmm13
		  Vector3 *v60; // rax
		  __int64 v61; // xmm0_8
		  float3 *xyz; // rax
		  float v63; // ebx
		  Entity_1 Entity; // rax
		  Vector3 *Position; // rax
		  __int64 v66; // xmm0_8
		  float3 *v67; // rax
		  float v68; // xmm1_4
		  int v69; // ecx
		  HGLightAdditionalData *LightAdditionalData; // rcx
		  Vector4 lightNPRData; // xmm0
		  __m128 v72; // xmm7
		  __int64 v73; // rax
		  float volumetricScatteringIntensity; // xmm12_4
		  Vector3 *cullingBoxRelativePosition; // rax
		  __int64 v76; // xmm0_8
		  float3 *v77; // rax
		  __int64 v78; // xmm6_8
		  Vector3 *cullingBoxHalfExtents; // rax
		  __int64 v80; // xmm0_8
		  float3 *v81; // rax
		  __int64 v82; // xmm8_8
		  Vector3 *cullingBoxOrientation; // rax
		  __int64 v84; // xmm0_8
		  float3 *v85; // rax
		  float v86; // xmm10_4
		  __int64 v87; // xmm9_8
		  float v88; // xmm11_4
		  BOOL enableOBBCullingBox_Injected; // ebx
		  int v90; // r15d
		  float3 *v91; // rax
		  __int64 v92; // xmm6_8
		  float v93; // edi
		  float3 *v94; // rax
		  __int64 v95; // xmm0_8
		  __int64 v96; // r8
		  __int64 v97; // r9
		  __int128 *v98; // rbx
		  float3 *v99; // rax
		  __int64 v100; // xmm0_8
		  __int128 v101; // xmm0
		  Matrix4x4 *v102; // rax
		  __int128 v103; // xmm1
		  __int128 v104; // xmm0
		  __int128 v105; // xmm1
		  Matrix4x4 *inverse; // rax
		  __m128 v107; // xmm11
		  __m128 v108; // xmm10
		  __m128 v109; // xmm9
		  __m128 v110; // xmm8
		  float v111; // xmm9_4
		  float v112; // xmm0_4
		  Beyond::DampingMath *v113; // rcx
		  float v114; // xmm6_4
		  float v115; // xmm0_4
		  Beyond::DampingMath *v116; // rcx
		  float v117; // xmm8_4
		  Entity_1 v118; // rax
		  int32_t v119; // edi
		  int32_t v120; // ebx
		  __m128i v121; // xmm0
		  Void *v122; // rax
		  LightCulling__StaticFields *v123; // rcx
		  Void *v124; // rax
		  __int64 v125; // rcx
		  Vector4 v126; // xmm1
		  __m128i v127; // xmm0
		  Void *v128; // rax
		  __int64 v129; // rcx
		  __int64 v130; // rcx
		  Void *v131; // rax
		  int32_t v132; // ebx
		  __int128 v133; // xmm0
		  Entity_1 v134; // rax
		  int32_t v135; // r15d
		  Entity_1 v136; // rax
		  int32_t v137; // r14d
		  Entity_1 v138; // rax
		  int32_t v139; // esi
		  Entity_1 v140; // rax
		  int32_t v141; // edi
		  Entity_1 v142; // rax
		  int32_t v143; // ebx
		  Entity_1 v144; // rax
		  int32_t v145; // eax
		  int v146; // r15d
		  int v147; // r15d
		  int v148; // xmm6_4
		  float v149; // xmm8_4
		  Entity_1 v150; // rax
		  int32_t ShadowCacheIndexForCaster; // eax
		  int32_t NUM_FLOAT4_PUNCTUALIGHT; // ebx
		  __m128i v153; // xmm0
		  Void *v154; // rax
		  LightCulling__StaticFields *static_fields; // rcx
		  int32_t v156; // ebx
		  Void *v157; // rax
		  __m128i v158; // xmm0
		  Void *v159; // rax
		  __int64 v160; // rcx
		  float v161; // xmm1_4
		  __int64 v162; // rcx
		  Void *v163; // rax
		  Void *v164; // rax
		  __m128i v165; // xmm0
		  __m128i v166; // xmm1
		  float v167; // xmm2_4
		  Void *v168; // rax
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ v169; // xmm0
		  Void *v170; // rax
		  Void *v171; // rcx
		  Vector4 v172; // xmm0
		  NativeArray_1_System_Int32_ v173; // xmm0
		  __m128i v174; // xmm1
		  __int128 v175; // xmm0
		  __int64 v176; // [rsp+28h] [rbp-E0h]
		  HGSharedLightData _unity_self; // [rsp+68h] [rbp-A0h] BYREF
		  _QWORD v178[3]; // [rsp+70h] [rbp-98h] BYREF
		  Vector4 m_FinalColor; // [rsp+88h] [rbp-80h] BYREF
		  int v180; // [rsp+98h] [rbp-70h]
		  float v181; // [rsp+9Ch] [rbp-6Ch]
		  float v182; // [rsp+A0h] [rbp-68h]
		  int v183; // [rsp+A4h] [rbp-64h]
		  float specularIntensity_Injected; // [rsp+A8h] [rbp-60h]
		  float v185; // [rsp+ACh] [rbp-5Ch]
		  float v186; // [rsp+B0h] [rbp-58h]
		  float v187; // [rsp+B4h] [rbp-54h]
		  float v188; // [rsp+B8h] [rbp-50h]
		  int v189; // [rsp+BCh] [rbp-4Ch]
		  int v190; // [rsp+C0h] [rbp-48h]
		  int32_t LightCookieIndex; // [rsp+C4h] [rbp-44h]
		  int32_t v192; // [rsp+C8h] [rbp-40h]
		  Vector3 v193; // [rsp+D8h] [rbp-30h] BYREF
		  float2 v194; // [rsp+E8h] [rbp-20h]
		  HGPunctualLightShadowManagerV2 *v195; // [rsp+F0h] [rbp-18h]
		  __int128 v196; // [rsp+F8h] [rbp-10h]
		  float v197; // [rsp+108h] [rbp+0h]
		  BinningPass_BinningData v198; // [rsp+118h] [rbp+10h] BYREF
		  __m128i v199; // [rsp+138h] [rbp+30h]
		  Matrix4x4 v200; // [rsp+148h] [rbp+40h] BYREF
		  __int128 v201; // [rsp+188h] [rbp+80h]
		  LightCaster v202; // [rsp+198h] [rbp+90h] BYREF
		  __m128i v203; // [rsp+1A8h] [rbp+A0h] BYREF
		  Vector3 v204; // [rsp+1B8h] [rbp+B0h] BYREF
		  __int128 v205; // [rsp+1C8h] [rbp+C0h]
		  __int128 v206; // [rsp+1D8h] [rbp+D0h]
		  __int128 v207; // [rsp+1E8h] [rbp+E0h]
		  __int128 v208; // [rsp+1F8h] [rbp+F0h]
		  __int128 v209; // [rsp+208h] [rbp+100h]
		  __int128 v210; // [rsp+218h] [rbp+110h]
		  __int128 v211; // [rsp+228h] [rbp+120h]
		  __int128 v212; // [rsp+238h] [rbp+130h]
		  __int128 v213; // [rsp+248h] [rbp+140h]
		  __int128 v214; // [rsp+258h] [rbp+150h]
		  __int128 v215; // [rsp+268h] [rbp+160h]
		  __int64 v216; // [rsp+278h] [rbp+170h] BYREF
		  int v217; // [rsp+280h] [rbp+178h]
		  unsigned __int64 v218; // [rsp+288h] [rbp+180h]
		  HGLightCookieManager *v219; // [rsp+290h] [rbp+188h]
		  float4 v220; // [rsp+298h] [rbp+190h] BYREF
		  float3 v221; // [rsp+2A8h] [rbp+1A0h] BYREF
		  float4 v222; // [rsp+2B8h] [rbp+1B0h] BYREF
		  __int64 v223; // [rsp+2C8h] [rbp+1C0h]
		  float4 v224; // [rsp+2D8h] [rbp+1D0h] BYREF
		  __m128i v225; // [rsp+2E8h] [rbp+1E0h]
		  float4 v226; // [rsp+2F8h] [rbp+1F0h] BYREF
		  float4 v227; // [rsp+308h] [rbp+200h] BYREF
		  float4 v228; // [rsp+318h] [rbp+210h] BYREF
		  float4 v229; // [rsp+328h] [rbp+220h] BYREF
		  float4 v230; // [rsp+338h] [rbp+230h] BYREF
		  Vector3 v231; // [rsp+348h] [rbp+240h] BYREF
		  Matrix4x4 v232; // [rsp+358h] [rbp+250h] BYREF
		  float3 v233; // [rsp+398h] [rbp+290h] BYREF
		  Vector3 v234; // [rsp+3A8h] [rbp+2A0h] BYREF
		  float3 v235; // [rsp+3B8h] [rbp+2B0h] BYREF
		  float3 v236; // [rsp+3C8h] [rbp+2C0h] BYREF
		  float3 v237; // [rsp+3D8h] [rbp+2D0h] BYREF
		  float3 v238; // [rsp+3E8h] [rbp+2E0h] BYREF
		  Vector3 v239; // [rsp+3F8h] [rbp+2F0h] BYREF
		  float3 v240; // [rsp+408h] [rbp+300h] BYREF
		  float3 v241; // [rsp+418h] [rbp+310h] BYREF
		  Vector3 v242; // [rsp+428h] [rbp+320h] BYREF
		  float3 v243; // [rsp+438h] [rbp+330h] BYREF
		  Vector3 v244; // [rsp+448h] [rbp+340h] BYREF
		  Vector3 v245; // [rsp+458h] [rbp+350h] BYREF
		  Matrix4x4 v246; // [rsp+468h] [rbp+360h] BYREF
		  VisibleLight v247; // [rsp+4A8h] [rbp+3A0h] BYREF
		  __m256i v248; // [rsp+548h] [rbp+440h] BYREF
		  __int128 v249; // [rsp+568h] [rbp+460h]
		  __int128 v250; // [rsp+578h] [rbp+470h]
		  __int128 v251; // [rsp+588h] [rbp+480h]
		  __int128 v252; // [rsp+598h] [rbp+490h]
		  __int128 v253; // [rsp+5A8h] [rbp+4A0h]
		  __int128 v254; // [rsp+5B8h] [rbp+4B0h]
		  __int128 v255; // [rsp+5C8h] [rbp+4C0h]
		  float v256; // [rsp+5D8h] [rbp+4D0h]
		  Color v257; // [rsp+5E8h] [rbp+4E0h] BYREF
		  Vector4 v258; // [rsp+5F8h] [rbp+4F0h] BYREF
		  Vector4 v259; // [rsp+608h] [rbp+500h] BYREF
		  Vector4 v260; // [rsp+618h] [rbp+510h] BYREF
		  char v261[16]; // [rsp+628h] [rbp+520h] BYREF
		  Vector4 v262; // [rsp+638h] [rbp+530h] BYREF
		  VisibleLight v263; // [rsp+648h] [rbp+540h] BYREF
		
		  v13 = visibleLights;
		  sub_18033B9D0(&v247, 0LL, 148LL);
		  sub_18033B9D0(&v248, 0LL, 148LL);
		  v14 = 0;
		  _unity_self = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1913, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1913, 0LL);
		    if ( Patch )
		    {
		      *(uint4 *)&v178[1] = *lightMasks;
		      m_FinalColor = (Vector4)*lightDistances;
		      v173 = *lightIndices;
		      v174 = *(__m128i *)v13;
		      v198.uintCount = binningData->uintCount;
		      *(NativeArray_1_System_Int32_ *)&v200.m00 = v173;
		      v175 = *(_OWORD *)&binningData->tileSize;
		      v203 = v174;
		      v174.m128i_i64[0] = *(_QWORD *)&binningData->xyOffset;
		      *(_OWORD *)&v198.tileSize = v175;
		      *(_QWORD *)&v198.xyOffset = v174.m128i_i64[0];
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_774(
		        Patch,
		        (Object *)this,
		        (Object *)camera,
		        &v198,
		        (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&v203,
		        (NativeArray_1_System_Int32_ *)&v200,
		        (NativeArray_1_System_Single_ *)&m_FinalColor,
		        directionalLightIndex,
		        punctualLightCount,
		        (uint4 *)&v178[1],
		        0LL);
		      return;
		    }
		    goto LABEL_53;
		  }
		  if ( !camera )
		    goto LABEL_53;
		  this->fields.m_binningConstants.actualWidth = camera->fields._sceneRTSize_k__BackingField.m_X;
		  sceneRTSize_k__BackingField = camera->fields._sceneRTSize_k__BackingField;
		  v18 = 0LL;
		  v15 = lightIndices;
		  *(_QWORD *)&v198.xyOffset = *(_QWORD *)&binningData->xyOffset;
		  v19 = _mm_cvtsi32_si128(binningData->tileSize);
		  this->fields.m_binningConstants.actualHeight = sceneRTSize_k__BackingField.m_Y;
		  v198.uintCount = binningData->uintCount;
		  v20 = HIDWORD(*(_QWORD *)&binningData->tileSize);
		  specularIntensity_Injected = 0.0;
		  LODWORD(this->fields.m_binningConstants.tileSize) = _mm_cvtepi32_ps(v19).m128_u32[0];
		  *(_QWORD *)&v198.xyOffset = *(_QWORD *)&binningData->xyOffset;
		  *(float *)v19.m128i_i32 = (float)(int)v20;
		  v198.uintCount = binningData->uintCount;
		  v21 = HIDWORD(*(_QWORD *)&binningData->tileY);
		  v185 = 0.0;
		  LODWORD(this->fields.m_binningConstants.numTilesX) = v19.m128i_i32[0];
		  *(_QWORD *)&v198.xyOffset = *(_QWORD *)&binningData->xyOffset;
		  *(float *)v19.m128i_i32 = (float)binningData->tileY;
		  v186 = 1.0;
		  LODWORD(this->fields.m_binningConstants.numTilesY) = v19.m128i_i32[0];
		  *(_QWORD *)&v198.xyOffset = *(_QWORD *)&binningData->xyOffset;
		  v225 = 0LL;
		  this->fields.m_binningConstants.numSliceZ = (float)(int)v21;
		  v22 = this->fields.m_binningConstants.numTilesY * this->fields.m_binningConstants.numTilesX;
		  v199 = 0LL;
		  v203 = 0LL;
		  this->fields.m_binningConstants.numTiles = (int)v22;
		  this->fields.m_binningConstants.lightCount = lightIndices->m_Length;
		  if ( directionalLightIndex != -1 )
		  {
		    v247 = *(VisibleLight *)&v13->m_Buffer[148 * directionalLightIndex];
		    envVolumeCameraComponent = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(camera, 0LL);
		    light = UnityEngine::Rendering::VisibleLight::get_light(&v247, 0LL);
		    if ( !envVolumeCameraComponent )
		      goto LABEL_53;
		    if ( !HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
		            envVolumeCameraComponent,
		            light,
		            0LL) )
		    {
		      v263 = v247;
		      Forward = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward(&v204, &v263, 0LL);
		      v26 = *(_QWORD *)&Forward->x;
		      *(float *)&Forward = Forward->z;
		      *(_QWORD *)&v193.x = v26;
		      LODWORD(v193.z) = (_DWORD)Forward;
		      m_FinalColor = *UnityEngine::Vector4::op_Implicit((Vector4 *)&v178[1], &v193, v27);
		      v18 = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		                                               (Vector4 *)&v178[1],
		                                               (CinemachineSmoothPath_Waypoint *)&m_FinalColor,
		                                               0LL));
		      m_FinalColor = (Vector4)v247.m_FinalColor;
		      v29 = *UnityEngine::Color::op_Implicit((Color *)&v178[1], &m_FinalColor, v28);
		      m_FinalColor = (Vector4)v29;
		      v225 = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		                                                (Vector4 *)&v178[1],
		                                                (CinemachineSmoothPath_Waypoint *)&m_FinalColor,
		                                                0LL));
		      v199 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::LightExtensions::GetOriginalColorAndIntensity(
		                                                (float4 *)&v178[1],
		                                                v247.hgSharedLightData,
		                                                0LL));
		      v203 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::LightExtensions::GetCharacterLightColorAndIntensity(
		                                                (float4 *)&v178[1],
		                                                v247.hgSharedLightData,
		                                                camera,
		                                                0LL));
		      specularIntensity_Injected = UnityEngine::HGSharedLightData::get_specularIntensity_Injected(
		                                     &v247.hgSharedLightData,
		                                     0LL);
		      *(float *)&v26 = UnityEngine::HGSharedLightData::get_softSourceRadius_Injected(&v247.hgSharedLightData, 0LL)
		                     * 0.017453292;
		      Beyond::DampingMath::sinf(v30, v29.r);
		      v185 = *(float *)&v26;
		      *(float *)&v26 = UnityEngine::HGSharedLightData::get_softSourceRadius_Injected(&v247.hgSharedLightData, 0LL)
		                     * 0.017453292;
		      Beyond::DampingMath::cosf(v31, v29.r);
		      v186 = *(float *)&v26;
		LABEL_10:
		      v15 = lightIndices;
		      goto LABEL_11;
		    }
		    v32 = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(camera, 0LL);
		    if ( v32 )
		    {
		      interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedPhase(v32, 0LL);
		      if ( interpolatedPhase )
		      {
		        p_lightConfig = &interpolatedPhase->fields.lightConfig;
		        z = interpolatedPhase->fields.lightConfig.forwardDirect.z;
		        *(_QWORD *)&v193.x = *(_QWORD *)&p_lightConfig->forwardDirect.x;
		        v193.z = z;
		        m_FinalColor = *UnityEngine::Vector4::op_Implicit((Vector4 *)&v178[1], &v193, v34);
		        v18 = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		                                                 (Vector4 *)&v178[1],
		                                                 (CinemachineSmoothPath_Waypoint *)&m_FinalColor,
		                                                 0LL));
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLightConfig);
		        m_FinalColor = (Vector4)*HG::Rendering::Runtime::HGLightConfig::UpdateDirectFinalColor(
		                                   (Color *)&v178[1],
		                                   p_lightConfig,
		                                   0LL);
		        m_FinalColor = (Vector4)*UnityEngine::Color::op_Implicit((Color *)&v178[1], &m_FinalColor, v37);
		        v225 = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		                                                  (Vector4 *)&v178[1],
		                                                  (CinemachineSmoothPath_Waypoint *)&m_FinalColor,
		                                                  0LL));
		        m_FinalColor = *(Vector4 *)sub_183C6CBA0(&v178[1], p_lightConfig);
		        m_FinalColor = (Vector4)*UnityEngine::Color::op_Implicit((Color *)&v178[1], &m_FinalColor, v38);
		        AsVector4 = Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		                      (Vector4 *)&v178[1],
		                      (CinemachineSmoothPath_Waypoint *)&m_FinalColor,
		                      0LL);
		        directIntensityDividePi = p_lightConfig->directIntensityDividePi;
		        v199 = *(__m128i *)AsVector4;
		        *(float *)&v199.m128i_i32[3] = directIntensityDividePi;
		        v203 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::LightExtensions::GetCharacterLightColorAndIntensity(
		                                                  (float4 *)&v178[1],
		                                                  p_lightConfig,
		                                                  camera,
		                                                  0LL));
		        specularIntensity_Injected = p_lightConfig->directSpecularIntensity;
		        v41 = p_lightConfig->directSoftSourceRadius * 0.017453292;
		        Beyond::DampingMath::sinf(v42, directIntensityDividePi);
		        v185 = v41;
		        v43 = p_lightConfig->directSoftSourceRadius * 0.017453292;
		        Beyond::DampingMath::cosf(v44, directIntensityDividePi);
		        v186 = v43;
		        goto LABEL_10;
		      }
		    }
		LABEL_53:
		    sub_1800D8260(Patch, v15);
		  }
		LABEL_11:
		  shadowManager = camera->fields.shadowManager;
		  if ( !shadowManager )
		    goto LABEL_53;
		  m_punctualLightShadowManagerV2 = shadowManager->fields.m_punctualLightShadowManagerV2;
		  v47 = 0LL;
		  lightCookieManager = camera->fields.lightCookieManager;
		  v195 = m_punctualLightShadowManagerV2;
		  v219 = lightCookieManager;
		  do
		  {
		    *(_DWORD *)&this->fields.m_volumetricFogLightMask.m_Buffer[v47] = 0;
		    v47 += 4LL;
		  }
		  while ( v47 < 32 );
		  v192 = 0;
		  if ( this->fields.m_binningConstants.lightCount > 0 )
		  {
		    m_Buffer = v13->m_Buffer;
		    *(_QWORD *)&v193.x = v13->m_Buffer;
		    lightEntity = lightDistances->m_Buffer;
		    v51 = v15->m_Buffer - lightDistances->m_Buffer;
		    v202.lightEntity = (Entity_1)lightDistances->m_Buffer;
		    v218 = v51;
		    while ( 1 )
		    {
		      v52 = &m_Buffer[148 * *(int *)&lightEntity[v51]];
		      v248 = *(__m256i *)v52;
		      v249 = *(_OWORD *)&v52[32];
		      v250 = *(_OWORD *)&v52[48];
		      v251 = *(_OWORD *)&v52[64];
		      v252 = *(_OWORD *)&v52[80];
		      v253 = *(_OWORD *)&v52[96];
		      v254 = *(_OWORD *)&v52[112];
		      v255 = *(_OWORD *)&v52[128];
		      v256 = *(float *)&v52[144];
		      _unity_self = (HGSharedLightData)*((_QWORD *)&v255 + 1);
		      LightFalloff = HG::Rendering::Runtime::LightExtensions::GetLightFalloff(
		                       *(HGSharedLightData *)((char *)&v255 + 8),
		                       *(float *)lightEntity,
		                       0LL);
		      m_FinalColor = *(Vector4 *)((char *)v248.m256i_i64 + 4);
		      m_FinalColor = (Vector4)*UnityEngine::Color::op_Implicit(&v257, &m_FinalColor, v54);
		      v56 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Multiply(&v258, &m_FinalColor, LightFalloff, v55));
		      flickerScale_Injected = UnityEngine::HGSharedLightData::get_flickerScale_Injected(&_unity_self, 0LL);
		      m_FinalColor = (Vector4)v56;
		      m_FinalColor = *UnityEngine::Vector4::op_Multiply(&v259, &m_FinalColor, flickerScale_Injected, v58);
		      v59 = (__m128)_mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		                                                       &v260,
		                                                       (CinemachineSmoothPath_Waypoint *)&m_FinalColor,
		                                                       0LL));
		      *(_OWORD *)&v263.m_LightType = *(_OWORD *)v248.m256i_i8;
		      *(_OWORD *)&v263.m_FinalColor.a = *(_OWORD *)&v248.m256i_u64[2];
		      *(_OWORD *)&v263.m_ScreenRect.m_Height = v249;
		      *(_OWORD *)&v263.m_LocalToWorldMatrix.m30 = v250;
		      *(_OWORD *)&v263.m_LocalToWorldMatrix.m31 = v251;
		      *(_OWORD *)&v263.m_LocalToWorldMatrix.m32 = v252;
		      *(_OWORD *)&v263.m_LocalToWorldMatrix.m33 = v253;
		      *(_OWORD *)&v263.m_LightPriority = v254;
		      *(_OWORD *)&v263.m_InstanceId = v255;
		      v263.m_ScreenSpaceArea = v256;
		      v60 = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward(&v244, &v263, 0LL);
		      v61 = *(_QWORD *)&v60->x;
		      *(float *)&v60 = v60->z;
		      *(_QWORD *)&v220.x = v61;
		      LODWORD(v220.z) = (_DWORD)v60;
		      xyz = Unity::Mathematics::float4::get_xyz(&v243, &v220, 0LL);
		      v56.m128i_i64[0] = *(_QWORD *)&xyz->x;
		      v63 = xyz->z;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      *(_QWORD *)&v221.x = v56.m128i_i64[0];
		      v221.z = v63;
		      v194 = HG::Rendering::Runtime::HGUtils::PackNormalOctRectEncode(&v221, 0LL);
		      Entity = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(
		                 *(HGSharedLightData *)((char *)&v255 + 8),
		                 0LL);
		      if ( !lightCookieManager )
		        goto LABEL_53;
		      LightCookieIndex = HG::Rendering::Runtime::HGLightCookieManager::GetLightCookieIndex(
		                           lightCookieManager,
		                           Entity,
		                           0LL);
		      *(_OWORD *)&v263.m_LightType = *(_OWORD *)v248.m256i_i8;
		      *(_OWORD *)&v263.m_FinalColor.a = *(_OWORD *)&v248.m256i_u64[2];
		      *(_OWORD *)&v263.m_ScreenRect.m_Height = v249;
		      *(_OWORD *)&v263.m_LocalToWorldMatrix.m30 = v250;
		      *(_OWORD *)&v263.m_LocalToWorldMatrix.m31 = v251;
		      *(_OWORD *)&v263.m_LocalToWorldMatrix.m32 = v252;
		      *(_OWORD *)&v263.m_LocalToWorldMatrix.m33 = v253;
		      *(_OWORD *)&v263.m_LightPriority = v254;
		      *(_OWORD *)&v263.m_InstanceId = v255;
		      v263.m_ScreenSpaceArea = v256;
		      Position = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetPosition(&v242, &v263, 0LL);
		      v66 = *(_QWORD *)&Position->x;
		      *(float *)&Position = Position->z;
		      *(_QWORD *)&v222.x = v66;
		      LODWORD(v222.z) = (_DWORD)Position;
		      v67 = Unity::Mathematics::float4::get_xyz(&v241, &v222, 0LL);
		      v223 = *(_QWORD *)&v67->x;
		      *(_QWORD *)&v201 = v223;
		      DWORD2(v201) = LODWORD(v67->z);
		      LODWORD(v176) = v14;
		      v68 = 1.0 / *((float *)&v253 + 2);
		      *((float *)&v201 + 3) = 1.0 / *((float *)&v253 + 2);
		      sub_1804A13B8(v69, (_DWORD)this, (unsigned int)&v248, (_DWORD)camera, v176);
		      LightAdditionalData = HG::Rendering::Runtime::LightExtensions::GetLightAdditionalData(
		                              (HGLightAdditionalData *)&v200,
		                              _unity_self,
		                              0LL);
		      lightNPRData = LightAdditionalData->lightNPRData;
		      v72 = *(__m128 *)&LightAdditionalData->lightNPRType;
		      v73 = HIDWORD(*(_QWORD *)&LightAdditionalData->lightNPRType);
		      v190 = _mm_cvtsi128_si32((__m128i)v72);
		      m_FinalColor = lightNPRData;
		      *(__m128 *)&v178[1] = v72;
		      *(Vector4 *)&v232.m00 = lightNPRData;
		      if ( (_BYTE)v73 )
		        v180 = 1065353216;
		      else
		        v180 = 0;
		      volumetricScatteringIntensity = LightAdditionalData->volumetricScatteringIntensity;
		      *(Vector4 *)&v232.m00 = LightAdditionalData->lightNPRData;
		      if ( volumetricScatteringIntensity > 0.000001
		        || UnityEngine::HGSharedLightData::get_shadowOnly_Injected(&_unity_self, 0LL) )
		      {
		        *(_DWORD *)&this->fields.m_volumetricFogLightMask.m_Buffer[4 * ((__int64)v14 >> 5)] |= 1 << (v14 & 0x1F);
		      }
		      cullingBoxRelativePosition = UnityEngine::HGSharedLightData::get_cullingBoxRelativePosition(
		                                     &v239,
		                                     &_unity_self,
		                                     0LL);
		      v76 = *(_QWORD *)&cullingBoxRelativePosition->x;
		      *(float *)&cullingBoxRelativePosition = cullingBoxRelativePosition->z;
		      *(_QWORD *)&v224.x = v76;
		      LODWORD(v224.z) = (_DWORD)cullingBoxRelativePosition;
		      v77 = Unity::Mathematics::float4::get_xyz(&v240, &v224, 0LL);
		      v78 = *(_QWORD *)&v77->x;
		      v197 = v77->z;
		      cullingBoxHalfExtents = UnityEngine::HGSharedLightData::get_cullingBoxHalfExtents(&v245, &_unity_self, 0LL);
		      v80 = *(_QWORD *)&cullingBoxHalfExtents->x;
		      *(float *)&cullingBoxHalfExtents = cullingBoxHalfExtents->z;
		      *(_QWORD *)&v226.x = v80;
		      LODWORD(v226.z) = (_DWORD)cullingBoxHalfExtents;
		      v81 = Unity::Mathematics::float4::get_xyz(&v233, &v226, 0LL);
		      v82 = *(_QWORD *)&v81->x;
		      v188 = v81->z;
		      cullingBoxOrientation = UnityEngine::HGSharedLightData::get_cullingBoxOrientation(&v234, &_unity_self, 0LL);
		      v84 = *(_QWORD *)&cullingBoxOrientation->x;
		      *(float *)&cullingBoxOrientation = cullingBoxOrientation->z;
		      *(_QWORD *)&v227.x = v84;
		      LODWORD(v227.z) = (_DWORD)cullingBoxOrientation;
		      v85 = Unity::Mathematics::float4::get_xyz(&v235, &v227, 0LL);
		      v181 = 0.0;
		      v182 = 0.0;
		      v86 = 0.0;
		      v87 = *(_QWORD *)&v85->x;
		      v88 = 0.0;
		      v187 = v85->z;
		      v183 = 0;
		      enableOBBCullingBox_Injected = UnityEngine::HGSharedLightData::get_enableOBBCullingBox_Injected(&_unity_self, 0LL);
		      v90 = enableOBBCullingBox_Injected | (2
		                                          * UnityEngine::HGSharedLightData::get_enableOverrideShadowLight_Injected(
		                                              &_unity_self,
		                                              0LL));
		      v189 = v90;
		      if ( UnityEngine::HGSharedLightData::get_enableOBBCullingBox_Injected(&_unity_self, 0LL) )
		      {
		        v228.z = v197;
		        *(_QWORD *)&v228.x = v78;
		        v91 = Unity::Mathematics::float4::get_xyz(&v236, &v228, 0LL);
		        *(_QWORD *)&v229.x = v87;
		        v92 = *(_QWORD *)&v91->x;
		        v93 = v91->z;
		        v229.z = v187;
		        v94 = Unity::Mathematics::float4::get_xyz(&v237, &v229, 0LL);
		        v95 = *(_QWORD *)&v94->x;
		        *(float *)&v94 = v94->z;
		        v216 = v95;
		        v217 = (int)v94;
		        v98 = (__int128 *)sub_182FA5910(v261, &v216, v96, v97);
		        *(_QWORD *)&v230.x = v82;
		        v230.z = v188;
		        v99 = Unity::Mathematics::float4::get_xyz(&v238, &v230, 0LL);
		        *(_QWORD *)&v204.x = v92;
		        v204.z = v93;
		        v100 = *(_QWORD *)&v99->x;
		        *(float *)&v99 = v99->z;
		        *(_QWORD *)&v231.x = v100;
		        v101 = *v98;
		        LODWORD(v231.z) = (_DWORD)v99;
		        *(_OWORD *)&v200.m00 = v101;
		        v102 = UnityEngine::Matrix4x4::TRS(&v232, &v204, (Quaternion *)&v200, &v231, 0LL);
		        v103 = *(_OWORD *)&v102->m01;
		        *(_OWORD *)&v246.m00 = *(_OWORD *)&v102->m00;
		        v104 = *(_OWORD *)&v102->m02;
		        *(_OWORD *)&v246.m01 = v103;
		        v105 = *(_OWORD *)&v102->m03;
		        *(_OWORD *)&v246.m02 = v104;
		        *(_OWORD *)&v246.m03 = v105;
		        inverse = UnityEngine::Matrix4x4::get_inverse(&v200, &v246, 0LL);
		        v108 = *(__m128 *)&inverse->m03;
		        v109 = *(__m128 *)&inverse->m00;
		        v110 = *(__m128 *)&inverse->m01;
		        *(_OWORD *)&v232.m02 = *(_OWORD *)&inverse->m02;
		        v107 = *(__m128 *)&v232.m02;
		        *(__m128 *)&v232.m03 = v108;
		        *(__m128 *)&v232.m01 = v110;
		        *(__m128 *)&v232.m00 = v109;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        v188 = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(v109.m128_f32[0], v110.m128_f32[0], 0LL);
		        v187 = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(v107.m128_f32[0], v108.m128_f32[0], 0LL);
		        v181 = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(
		                 _mm_shuffle_ps(v109, v109, 85).m128_f32[0],
		                 _mm_shuffle_ps(v110, v110, 85).m128_f32[0],
		                 0LL);
		        v182 = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(
		                 _mm_shuffle_ps(v107, v107, 85).m128_f32[0],
		                 _mm_shuffle_ps(v108, v108, 85).m128_f32[0],
		                 0LL);
		        v111 = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(
		                 _mm_shuffle_ps(v109, v109, 170).m128_f32[0],
		                 _mm_shuffle_ps(v110, v110, 170).m128_f32[0],
		                 0LL);
		        LODWORD(v68) = _mm_shuffle_ps(v108, v108, 170).m128_u32[0];
		        *(float *)&v104 = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(
		                            _mm_shuffle_ps(v107, v107, 170).m128_f32[0],
		                            v68,
		                            0LL);
		        v72 = *(__m128 *)&v178[1];
		        m_punctualLightShadowManagerV2 = v195;
		        v86 = v188;
		        v88 = v187;
		        v183 = v104;
		      }
		      else
		      {
		        v111 = 0.0;
		      }
		      if ( !v248.m256i_i32[0] )
		        break;
		      if ( v248.m256i_i32[0] == 2 )
		      {
		        if ( UnityEngine::HGSharedLightData::get_enableOverrideShadowLight_Injected(&_unity_self, 0LL) )
		        {
		          v189 = -1;
		          v150 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(_unity_self, 0LL);
		          *(_OWORD *)&v200.m00 = 0LL;
		          HG::Rendering::Runtime::LightCaster::LightCaster((LightCaster *)&v200, v150, 0, 0LL);
		          if ( !m_punctualLightShadowManagerV2 )
		            goto LABEL_53;
		          *(_OWORD *)&v178[1] = *(_OWORD *)&v200.m00;
		          ShadowCacheIndexForCaster = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
		                                        m_punctualLightShadowManagerV2,
		                                        (LightCaster *)&v178[1],
		                                        0LL);
		          v148 = v189;
		          v149 = (float)ShadowCacheIndexForCaster;
		        }
		        else
		        {
		          v134 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(_unity_self, 0LL);
		          *(_OWORD *)&v200.m00 = 0LL;
		          HG::Rendering::Runtime::LightCaster::LightCaster((LightCaster *)&v200, v134, 0, 0LL);
		          if ( !m_punctualLightShadowManagerV2 )
		            goto LABEL_53;
		          *(_OWORD *)&v178[1] = *(_OWORD *)&v200.m00;
		          v135 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
		                   m_punctualLightShadowManagerV2,
		                   (LightCaster *)&v178[1],
		                   0LL);
		          v136 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(_unity_self, 0LL);
		          *(_OWORD *)&v200.m00 = 0LL;
		          HG::Rendering::Runtime::LightCaster::LightCaster((LightCaster *)&v200, v136, 1, 0LL);
		          *(_OWORD *)&v178[1] = *(_OWORD *)&v200.m00;
		          v137 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
		                   m_punctualLightShadowManagerV2,
		                   (LightCaster *)&v178[1],
		                   0LL);
		          v138 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(_unity_self, 0LL);
		          *(_OWORD *)&v200.m00 = 0LL;
		          HG::Rendering::Runtime::LightCaster::LightCaster((LightCaster *)&v200, v138, 2, 0LL);
		          *(_OWORD *)&v178[1] = *(_OWORD *)&v200.m00;
		          v139 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
		                   m_punctualLightShadowManagerV2,
		                   (LightCaster *)&v178[1],
		                   0LL);
		          v140 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(_unity_self, 0LL);
		          *(_OWORD *)&v200.m00 = 0LL;
		          HG::Rendering::Runtime::LightCaster::LightCaster((LightCaster *)&v200, v140, 3, 0LL);
		          *(_OWORD *)&v178[1] = *(_OWORD *)&v200.m00;
		          v141 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
		                   m_punctualLightShadowManagerV2,
		                   (LightCaster *)&v178[1],
		                   0LL);
		          v142 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(_unity_self, 0LL);
		          *(_OWORD *)&v200.m00 = 0LL;
		          HG::Rendering::Runtime::LightCaster::LightCaster((LightCaster *)&v200, v142, 4, 0LL);
		          *(_OWORD *)&v178[1] = *(_OWORD *)&v200.m00;
		          v143 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
		                   v195,
		                   (LightCaster *)&v178[1],
		                   0LL);
		          v144 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(_unity_self, 0LL);
		          *(_OWORD *)&v200.m00 = 0LL;
		          HG::Rendering::Runtime::LightCaster::LightCaster((LightCaster *)&v200, v144, 5, 0LL);
		          *(_OWORD *)&v178[1] = *(_OWORD *)&v200.m00;
		          v145 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
		                   v195,
		                   (LightCaster *)&v178[1],
		                   0LL);
		          if ( v135 == -1 )
		            v135 = 255;
		          if ( v137 == -1 )
		            v137 = 255;
		          if ( v139 == -1 )
		            v139 = 255;
		          if ( v141 == -1 )
		            v141 = 255;
		          if ( v143 == -1 )
		            v143 = 255;
		          if ( v145 == -1 )
		            v145 = 255;
		          v146 = v137 | (v135 << 8);
		          lightEntity = (Void *)v202.lightEntity;
		          v147 = v139 | (v146 << 8);
		          v14 = v192;
		          v148 = v141 | (v147 << 8);
		          v90 = v189;
		          LODWORD(v149) = v145 | (v143 << 8);
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCulling);
		        NUM_FLOAT4_PUNCTUALIGHT = TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT;
		        LODWORD(v209) = v59.m128_i32[0];
		        DWORD2(v209) = _mm_shuffle_ps(v59, v59, 170).m128_u32[0];
		        DWORD1(v209) = _mm_shuffle_ps(v59, v59, 85).m128_u32[0];
		        v153 = _mm_cvtsi32_si128(2
		                               * (unsigned int)UnityEngine::HGSharedLightData::get_shadowOnly_Injected(
		                                                 &_unity_self,
		                                                 0LL) + 1);
		        v154 = this->fields.m_punctualLightDataArray.m_Buffer;
		        HIDWORD(v209) = _mm_cvtepi32_ps(v153).m128_u32[0];
		        *(_OWORD *)&v154[16 * v14 * NUM_FLOAT4_PUNCTUALIGHT + 96] = v209;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCulling);
		        static_fields = TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields;
		        DWORD1(v210) = LODWORD(v194.y);
		        *(_OWORD *)&this->fields.m_punctualLightDataArray.m_Buffer[16 * static_fields->NUM_FLOAT4_PUNCTUALIGHT * v14
		                                                                 + 112] = v201;
		        *(float *)&v210 = v194.x;
		        v156 = TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT;
		        *(float *)v153.m128i_i32 = UnityEngine::HGSharedLightData::get_length_Injected(&_unity_self, 0LL);
		        v157 = this->fields.m_punctualLightDataArray.m_Buffer;
		        *((_QWORD *)&v210 + 1) = __PAIR64__(v148, v153.m128i_u32[0]);
		        *(_QWORD *)&v211 = __PAIR64__(LODWORD(volumetricScatteringIntensity), LODWORD(v149));
		        *(Vector4 *)&v178[1] = m_FinalColor;
		        *(_OWORD *)&v157[16 * v14 * v156 + 128] = v210;
		        *((_QWORD *)&v211 + 1) = __PAIR64__(v190, v180);
		        *(_OWORD *)&this->fields.m_punctualLightDataArray.m_Buffer[16
		                                                                 * TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT
		                                                                 * v14
		                                                                 + 144] = v211;
		        v158 = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		                                                  (Vector4 *)&v198,
		                                                  (CinemachineSmoothPath_Waypoint *)&v178[1],
		                                                  0LL));
		        v159 = this->fields.m_punctualLightDataArray.m_Buffer;
		        v160 = 2 * (TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT * v14 + 10LL);
		        *(_QWORD *)&v212 = __PAIR64__(LODWORD(v88), LODWORD(v86));
		        *(__m128i *)&v159[8 * v160] = v158;
		        *((float *)&v212 + 2) = v181;
		        v161 = (float)v90;
		        LODWORD(v159) = TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT * v14;
		        *((float *)&v212 + 3) = v161;
		        v162 = (int)v159;
		        v163 = this->fields.m_punctualLightDataArray.m_Buffer;
		        *(_QWORD *)&v213 = __PAIR64__(LODWORD(v111), LODWORD(v182));
		        HIDWORD(v213) = _mm_shuffle_ps(v72, v72, 255).m128_u32[0];
		        *(_OWORD *)&v163[16 * v162 + 176] = v212;
		        DWORD2(v213) = v183;
		        *(_OWORD *)&this->fields.m_punctualLightDataArray.m_Buffer[16
		                                                                 * TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT
		                                                                 * v14
		                                                                 + 192] = v213;
		        v132 = TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT;
		        LODWORD(v196) = UnityEngine::HGSharedLightData::get_cullingBoxFalloffThreshold_Injected(&_unity_self, 0LL);
		        DWORD1(v196) = UnityEngine::HGSharedLightData::get_softSourceRadius_Injected(&_unity_self, 0LL);
		        DWORD2(v196) = UnityEngine::HGSharedLightData::get_specularIntensity_Injected(&_unity_self, 0LL);
		        *((float *)&v196 + 3) = (float)LightCookieIndex;
		        v133 = v196;
		        goto LABEL_48;
		      }
		LABEL_49:
		      m_punctualLightShadowManagerV2 = v195;
		      ++v14;
		      v51 = v218;
		      lightEntity += 4;
		      lightCookieManager = v219;
		      m_Buffer = *(Void **)&v193.x;
		      v192 = v14;
		      v202.lightEntity = (Entity_1)lightEntity;
		      if ( v14 >= this->fields.m_binningConstants.lightCount )
		      {
		        v13 = visibleLights;
		        goto LABEL_51;
		      }
		    }
		    v112 = (float)(UnityEngine::HGSharedLightData::get_innerSpotAngle_Injected(&_unity_self, 0LL) / 360.0) * 3.1415927;
		    Beyond::DampingMath::cosf(v113, v68);
		    v114 = v112;
		    v115 = (float)(UnityEngine::HGSharedLightData::get_spotAngle_Injected(&_unity_self, 0LL) / 360.0) * 3.1415927;
		    Beyond::DampingMath::cosf(v116, v68);
		    v117 = v115;
		    v118 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(_unity_self, 0LL);
		    v202 = 0LL;
		    HG::Rendering::Runtime::LightCaster::LightCaster(&v202, v118, 0, 0LL);
		    if ( !m_punctualLightShadowManagerV2 )
		      goto LABEL_53;
		    *(LightCaster *)&v178[1] = v202;
		    v119 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
		             m_punctualLightShadowManagerV2,
		             (LightCaster *)&v178[1],
		             0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCulling);
		    v120 = TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT;
		    LODWORD(v206) = v59.m128_i32[0];
		    DWORD2(v206) = _mm_shuffle_ps(v59, v59, 170).m128_u32[0];
		    DWORD1(v206) = _mm_shuffle_ps(v59, v59, 85).m128_u32[0];
		    v121 = _mm_cvtsi32_si128(2 * (unsigned int)UnityEngine::HGSharedLightData::get_shadowOnly_Injected(
		                                                 &_unity_self,
		                                                 0LL));
		    v122 = this->fields.m_punctualLightDataArray.m_Buffer;
		    HIDWORD(v206) = _mm_cvtepi32_ps(v121).m128_u32[0];
		    *(_OWORD *)&v122[16 * v14 * v120 + 96] = v206;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCulling);
		    v123 = TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields;
		    *(float *)&v207 = v194.x;
		    *((float *)&v207 + 2) = v117;
		    v124 = this->fields.m_punctualLightDataArray.m_Buffer;
		    v125 = 2 * (v123->NUM_FLOAT4_PUNCTUALIGHT * v14 + 7LL);
		    *(float *)&v205 = (float)v119;
		    v126 = m_FinalColor;
		    *((float *)&v205 + 1) = volumetricScatteringIntensity;
		    *(_OWORD *)&v124[8 * v125] = v201;
		    DWORD1(v207) = LODWORD(v194.y);
		    LODWORD(v124) = TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT * v14;
		    *((float *)&v207 + 3) = 1.0 / (float)(v114 - v117);
		    *(Vector4 *)&v178[1] = v126;
		    *(_OWORD *)&this->fields.m_punctualLightDataArray.m_Buffer[16 * (int)v124 + 128] = v207;
		    *((_QWORD *)&v205 + 1) = __PAIR64__(v190, v180);
		    *(_OWORD *)&this->fields.m_punctualLightDataArray.m_Buffer[16
		                                                             * TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT
		                                                             * v14
		                                                             + 144] = v205;
		    v127 = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		                                              &v262,
		                                              (CinemachineSmoothPath_Waypoint *)&v178[1],
		                                              0LL));
		    v128 = this->fields.m_punctualLightDataArray.m_Buffer;
		    v129 = 2 * (TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT * v14 + 10LL);
		    *(_QWORD *)&v214 = __PAIR64__(LODWORD(v88), LODWORD(v86));
		    *((float *)&v215 + 1) = v111;
		    *(__m128i *)&v128[8 * v129] = v127;
		    *((float *)&v214 + 2) = v181;
		    HIDWORD(v215) = _mm_shuffle_ps(v72, v72, 255).m128_u32[0];
		    v126.x = (float)v90;
		    LODWORD(v128) = TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT * v14;
		    HIDWORD(v214) = LODWORD(v126.x);
		    v130 = (int)v128;
		    v131 = this->fields.m_punctualLightDataArray.m_Buffer;
		    *(float *)&v215 = v182;
		    *(_OWORD *)&v131[16 * v130 + 176] = v214;
		    DWORD2(v215) = v183;
		    *(_OWORD *)&this->fields.m_punctualLightDataArray.m_Buffer[16
		                                                             * TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT
		                                                             * v14
		                                                             + 192] = v215;
		    v132 = TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields->NUM_FLOAT4_PUNCTUALIGHT;
		    LODWORD(v208) = UnityEngine::HGSharedLightData::get_cullingBoxFalloffThreshold_Injected(&_unity_self, 0LL);
		    DWORD1(v208) = UnityEngine::HGSharedLightData::get_softSourceRadius_Injected(&_unity_self, 0LL);
		    DWORD2(v208) = UnityEngine::HGSharedLightData::get_specularIntensity_Injected(&_unity_self, 0LL);
		    *((float *)&v208 + 3) = (float)LightCookieIndex;
		    v133 = v208;
		LABEL_48:
		    *(_OWORD *)&this->fields.m_punctualLightDataArray.m_Buffer[16 * v14 * v132 + 208] = v133;
		    goto LABEL_49;
		  }
		LABEL_51:
		  v164 = this->fields.m_punctualLightDataArray.m_Buffer;
		  v165 = v225;
		  HIDWORD(v196) = 0;
		  v166 = v199;
		  v167 = v185;
		  *(__m128i *)v164 = v18;
		  v168 = this->fields.m_punctualLightDataArray.m_Buffer;
		  *((float *)&v196 + 1) = v167;
		  *(__m128i *)&v168[16] = v165;
		  v169 = (NativeArray_1_UnityEngine_Rendering_VisibleLight_)v203;
		  *(__m128i *)&this->fields.m_punctualLightDataArray.m_Buffer[32] = v166;
		  v170 = this->fields.m_punctualLightDataArray.m_Buffer;
		  *(float *)&v196 = specularIntensity_Injected;
		  *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&v170[48] = v169;
		  *((float *)&v196 + 2) = v186;
		  *(_OWORD *)&v178[1] = v196;
		  *(__m128i *)&this->fields.m_punctualLightDataArray.m_Buffer[64] = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4((Vector4 *)&v198, (CinemachineSmoothPath_Waypoint *)&v178[1], 0LL));
		  v171 = this->fields.m_punctualLightDataArray.m_Buffer;
		  *(uint4 *)&v171[80] = *lightMasks;
		  v172 = (Vector4)*v13;
		  *(NativeArray_1_System_Int32_ *)&v178[1] = *lightIndices;
		  m_FinalColor = v172;
		  sub_1808B5714(
		    (_DWORD)v171,
		    (_DWORD)this,
		    (_DWORD)camera,
		    (unsigned int)&m_FinalColor,
		    (__int64)&v178[1],
		    directionalLightIndex);
		}
		
	}
}
