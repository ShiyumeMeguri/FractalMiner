using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime.TerrainV2;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGTerrainSurfacesData : ScriptableObject // TypeDefIndex: 38657
	{
		// Fields
		public Vector3 terrainPosition; // 0x18
		public float heightScale; // 0x24
		public int terrainSize; // 0x28
		public int heightmapPageSize; // 0x2C
		public int normalmapPageSize; // 0x30
		public int tintColorPageSize; // 0x34
		public int splatCtrlPageSize; // 0x38
		public int albedoTexPageSize; // 0x3C
		public int cliffIndexPageSize; // 0x40
		public TerrainLayerTypeData layerTypeData; // 0x48
		public SplatLayerData[] layerData; // 0x158
		public int splatTexCount; // 0x160
		public int splatTexSize; // 0x164
		public bool hasConeMap; // 0x168
		public TerrainNodeData[] nodeData; // 0x170
		public ulong[] sectorSplatInfo; // 0x178
	
		// Nested types
		[Serializable]
		public struct SplatLayerData // TypeDefIndex: 38654
		{
			// Fields
			public Vector4 packedSplatInfo; // 0x00
			public Vector4 splatST; // 0x10
			public Vector4 diffuseRemapScale; // 0x20
			public Vector4 maskMapRemapOffset; // 0x30
			public Vector4 maskMapRemapScale; // 0x40
			public Vector2 packedDeformParams0; // 0x50
			public HGTerrainUtils.Vector2UInt packedDeformParams1; // 0x58
			public Vector4 pomParams; // 0x60
		}
	
		[Serializable]
		public struct TerrainNodeData // TypeDefIndex: 38655
		{
			// Fields
			public int allHole; // 0x00
			public int nodeLevel; // 0x04
			public int parent; // 0x08
			public float localMinHeight; // 0x0C
			public float localMaxHeight; // 0x10
			public float maxHeightError; // 0x14
		}
	
		public struct UIntAndFloat // TypeDefIndex: 38656
		{
			// Fields
			public uint uintValue; // 0x00
			public float floatValue; // 0x00
		}
	
		// Constructors
		public HGTerrainSurfacesData() {} // 0x0000000183573370-0x0000000183573380
		// SingletonScriptableObject`1[System.Object]()
		void Beyond::SingletonScriptableObject<System::Object>::SingletonScriptableObject(
		        SingletonScriptableObject_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	
		// Methods
		public TerrainInfo GetTerrainInfo() => default; // 0x0000000189C21AC8-0x0000000189C21BE0
		// TerrainInfo GetTerrainInfo()
		TerrainInfo *HG::Rendering::Runtime::HGTerrainSurfacesData::GetTerrainInfo(
		        TerrainInfo *__return_ptr retstr,
		        HGTerrainSurfacesData *this,
		        MethodInfo *method)
		{
		  int32_t v5; // esi
		  __int64 v6; // xmm0_8
		  int32_t splatTexCount; // eax
		  bool v8; // zf
		  int v9; // eax
		  __int128 v10; // xmm1
		  __int64 v11; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  TerrainInfo *v15; // rax
		  TerrainInfo v17; // [rsp+20h] [rbp-30h] BYREF
		
		  v5 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(4061, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4061, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    v15 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1431(&v17, Patch, (Object *)this, 0LL);
		    v10 = *(_OWORD *)&v15->terrainSize;
		    *(_OWORD *)&retstr->terrainPosition.x = *(_OWORD *)&v15->terrainPosition.x;
		    v11 = *(_QWORD *)&v15->heightmapPageSize;
		    v9 = *(_DWORD *)&v15->albedoTexPageSize;
		  }
		  else
		  {
		    v6 = *(_QWORD *)&this->fields.terrainPosition.x;
		    v17.terrainPosition.z = this->fields.terrainPosition.z;
		    v17.terrainSize = this->fields.terrainSize;
		    splatTexCount = this->fields.splatTexCount;
		    *(_QWORD *)&v17.terrainPosition.x = v6;
		    *(float *)&v6 = this->fields.heightScale;
		    v17.splatTexCount = splatTexCount;
		    v17.splatTexSize = this->fields.splatTexSize;
		    LODWORD(v17.heightScale) = v6;
		    v8 = !this->fields.hasConeMap;
		    v17.heightmapPageSize = this->fields.heightmapPageSize;
		    LOBYTE(v5) = !v8;
		    v17.normalmapPageSize = this->fields.normalmapPageSize;
		    v17.tintColorPageSize = this->fields.tintColorPageSize;
		    v17.splatCtrlPageSize = this->fields.splatCtrlPageSize;
		    v17.albedoTexPageSize = this->fields.albedoTexPageSize;
		    v17.cliffIndexPageSize = this->fields.cliffIndexPageSize;
		    v9 = *(_DWORD *)&v17.albedoTexPageSize;
		    v17.hasConeMap = v5;
		    v10 = *(_OWORD *)&v17.terrainSize;
		    *(_OWORD *)&retstr->terrainPosition.x = *(_OWORD *)&v17.terrainPosition.x;
		    v11 = *(_QWORD *)&v17.heightmapPageSize;
		  }
		  *(_OWORD *)&retstr->terrainSize = v10;
		  *(_QWORD *)&retstr->heightmapPageSize = v11;
		  *(_DWORD *)&retstr->albedoTexPageSize = v9;
		  return retstr;
		}
		
		public void GetTerrainNodeDataArray(NativeArray<UnityEngine.HyperGryph.TerrainNodeData> nodeDataArray) {} // 0x0000000189C21BE0-0x0000000189C21CE8
		// Void GetTerrainNodeDataArray(NativeArray`1[UnityEngine.HyperGryph.TerrainNodeData])
		void HG::Rendering::Runtime::HGTerrainSurfacesData::GetTerrainNodeDataArray(
		        HGTerrainSurfacesData *this,
		        NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ *nodeDataArray,
		        MethodInfo *method)
		{
		  HGTerrainSurfacesData_TerrainNodeData__Array *v5; // rdx
		  __int64 v6; // rcx
		  HGTerrainSurfacesData_TerrainNodeData__Array *nodeData; // rax
		  Void *m_Buffer; // r9
		  int32_t v9; // r8d
		  HGTerrainSurfacesData_TerrainNodeData__Array *v10; // rax
		  __int64 v11; // rax
		  float localMinHeight; // xmm0_4
		  int32_t localMaxHeight_low; // xmm1_4
		  int32_t maxHeightError_low; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ v16; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4062, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4062, 0LL);
		    if ( !Patch )
		      goto LABEL_12;
		    v16 = *nodeDataArray;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1432(Patch, (Object *)this, &v16, 0LL);
		  }
		  else if ( nodeDataArray->m_Buffer )
		  {
		    nodeData = this->fields.nodeData;
		    if ( !nodeData )
		      goto LABEL_12;
		    if ( nodeDataArray->m_Length == nodeData->max_length.size )
		    {
		      m_Buffer = nodeDataArray->m_Buffer;
		      v9 = 0;
		      while ( 1 )
		      {
		        v10 = this->fields.nodeData;
		        if ( !v10 )
		          break;
		        if ( v9 >= v10->max_length.size )
		          return;
		        v5 = this->fields.nodeData;
		        if ( (unsigned int)v9 >= v10->max_length.size )
		          sub_1800D2AB0(v6, v5);
		        v11 = v9++;
		        v6 = 3 * v11;
		        localMinHeight = v5->vector[v11].localMinHeight;
		        localMaxHeight_low = LODWORD(v5->vector[v11].localMaxHeight);
		        LOBYTE(v16.m_Buffer) = v5->vector[v11].allHole;
		        BYTE1(v16.m_Buffer) = v5->vector[v11].nodeLevel;
		        LOWORD(v11) = v5->vector[v11].parent;
		        *((float *)&v16.m_Buffer + 1) = localMinHeight;
		        maxHeightError_low = LODWORD(v5->vector[(unsigned __int64)v6 / 3].maxHeightError);
		        WORD1(v16.m_Buffer) = v11;
		        v16.m_Length = localMaxHeight_low;
		        v16.m_AllocatorLabel = maxHeightError_low;
		        *(NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ *)m_Buffer = v16;
		        m_Buffer += 16;
		      }
		LABEL_12:
		      sub_1800D8260(v6, v5);
		    }
		  }
		}
		
		public void GetTerrainSectorSplatInfoArray(NativeArray<ulong> sectorSplatInfoArray) {} // 0x0000000189C21CE8-0x0000000189C21D94
		// Void GetTerrainSectorSplatInfoArray(NativeArray`1[System.UInt64])
		void HG::Rendering::Runtime::HGTerrainSurfacesData::GetTerrainSectorSplatInfoArray(
		        HGTerrainSurfacesData *this,
		        NativeArray_1_System_UInt64_ *sectorSplatInfoArray,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  uint64_t v6; // rcx
		  UInt64__Array *sectorSplatInfo; // rax
		  Void *m_Buffer; // r8
		  UInt64__Array *v9; // rax
		  UInt64__Array *v10; // rcx
		  __int64 v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  NativeArray_1_System_UInt64_ v13; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4063, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4063, 0LL);
		    if ( !Patch )
		      goto LABEL_12;
		    v13 = *sectorSplatInfoArray;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1433(Patch, (Object *)this, &v13, 0LL);
		  }
		  else if ( sectorSplatInfoArray->m_Buffer )
		  {
		    sectorSplatInfo = this->fields.sectorSplatInfo;
		    if ( !sectorSplatInfo )
		      goto LABEL_12;
		    if ( sectorSplatInfoArray->m_Length == sectorSplatInfo->max_length.size )
		    {
		      m_Buffer = sectorSplatInfoArray->m_Buffer;
		      v5 = 0LL;
		      while ( 1 )
		      {
		        v9 = this->fields.sectorSplatInfo;
		        if ( !v9 )
		          break;
		        if ( (int)v5 >= v9->max_length.size )
		          return;
		        v10 = this->fields.sectorSplatInfo;
		        if ( (unsigned int)v5 >= v9->max_length.size )
		          sub_1800D2AB0(v10, v5);
		        v11 = (int)v5;
		        v5 = (unsigned int)(v5 + 1);
		        v6 = v10->vector[v11];
		        *(_QWORD *)m_Buffer = v6;
		        m_Buffer += 8;
		      }
		LABEL_12:
		      sub_1800D8260(v6, v5);
		    }
		  }
		}
		
		public void GetSplatLayerDataArray(NativeArray<UnityEngine.HyperGryph.SplatLayerData> layerDataArray) {} // 0x0000000189C21968-0x0000000189C21AC8
		// Void GetSplatLayerDataArray(NativeArray`1[UnityEngine.HyperGryph.SplatLayerData])
		void HG::Rendering::Runtime::HGTerrainSurfacesData::GetSplatLayerDataArray(
		        HGTerrainSurfacesData *this,
		        NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ *layerDataArray,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGTerrainSurfacesData_SplatLayerData__Array *layerData; // rax
		  Void *m_Buffer; // r14
		  int32_t v9; // ebp
		  HGTerrainSurfacesData_SplatLayerData__Array *v10; // rax
		  HGTerrainSurfacesData_SplatLayerData__Array *v11; // rsi
		  __int64 v12; // rbx
		  __int128 v13; // xmm0
		  __m128i v14; // xmm4
		  __m128i v15; // xmm5
		  __m128i v16; // xmm6
		  __m128i v17; // xmm7
		  __m128i v18; // xmm2
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ v20; // [rsp+20h] [rbp-A8h] BYREF
		  _BYTE v21[80]; // [rsp+30h] [rbp-98h] BYREF
		  __int128 v22; // [rsp+80h] [rbp-48h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4064, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4064, 0LL);
		    if ( !Patch )
		      goto LABEL_12;
		    v20 = *layerDataArray;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1434(Patch, (Object *)this, &v20, 0LL);
		  }
		  else if ( layerDataArray->m_Buffer )
		  {
		    layerData = this->fields.layerData;
		    if ( !layerData )
		      goto LABEL_12;
		    if ( layerDataArray->m_Length == layerData->max_length.size )
		    {
		      m_Buffer = layerDataArray->m_Buffer;
		      v9 = 0;
		      while ( 1 )
		      {
		        v10 = this->fields.layerData;
		        if ( !v10 )
		          break;
		        if ( v9 >= v10->max_length.size )
		          return;
		        v11 = this->fields.layerData;
		        if ( (unsigned int)v9 >= v10->max_length.size )
		          sub_1800D2AB0(v6, v5);
		        v12 = v9;
		        sub_18033B9D0(v21, 0LL, 112LL);
		        v13 = *(_OWORD *)&v11->vector[v12].packedDeformParams0.x;
		        ++v9;
		        v14 = _mm_loadu_si128((const __m128i *)&v11->vector[v12].splatST);
		        v15 = _mm_loadu_si128((const __m128i *)&v11->vector[v12].diffuseRemapScale);
		        v16 = _mm_loadu_si128((const __m128i *)&v11->vector[v12].maskMapRemapOffset);
		        v17 = _mm_loadu_si128((const __m128i *)&v11->vector[v12].maskMapRemapScale);
		        v18 = _mm_loadu_si128((const __m128i *)&v11->vector[v12].pomParams);
		        *(__m128i *)m_Buffer = _mm_loadu_si128((const __m128i *)&v11->vector[v12]);
		        *(__m128i *)&m_Buffer[16] = v14;
		        *(__m128i *)&m_Buffer[32] = v15;
		        *(__m128i *)&m_Buffer[48] = v16;
		        *(__m128i *)&m_Buffer[64] = v17;
		        *(_OWORD *)&m_Buffer[80] = v13;
		        *(__m128i *)&m_Buffer[96] = v18;
		        m_Buffer += 112;
		        v22 = v13;
		      }
		LABEL_12:
		      sub_1800D8260(v6, v5);
		    }
		  }
		}
		
	}
}
