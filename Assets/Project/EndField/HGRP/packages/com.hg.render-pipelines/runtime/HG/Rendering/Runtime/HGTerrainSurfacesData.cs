using System;
using System.Runtime.InteropServices;
using HG.Rendering.Runtime.TerrainV2;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph;

namespace HG.Rendering.Runtime
{
	public class HGTerrainSurfacesData : ScriptableObject
	{
		public HGTerrainSurfacesData()
		{
			// // SingletonScriptableObject`1[System.Object]()
			// void Beyond::SingletonScriptableObject<System::Object>::SingletonScriptableObject(
			//         SingletonScriptableObject_1_System_Object_ *this,
			//         MethodInfo *method)
			// {
			//   UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
			// }
			// 
		}

		public TerrainInfo GetTerrainInfo()
		{
			// // TerrainInfo GetTerrainInfo()
			// TerrainInfo *HG::Rendering::Runtime::HGTerrainSurfacesData::GetTerrainInfo(
			//         TerrainInfo *__return_ptr retstr,
			//         HGTerrainSurfacesData *this,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // xmm0_8
			//   unsigned __int16 albedoTexPageSize; // ax
			//   __int128 v7; // xmm0
			//   __int128 v8; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   TerrainInfo *v12; // rax
			//   TerrainInfo *result; // rax
			//   TerrainInfo v14; // [rsp+20h] [rbp-20h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3433, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3433, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1222(&v14, Patch, (Object *)this, 0LL);
			//     v7 = *(_OWORD *)&v12.terrainPosition.x;
			//     v8 = *(_OWORD *)&v12.terrainSize;
			//   }
			//   else
			//   {
			//     v5 = *(_QWORD *)&this.fields.terrainPosition.x;
			//     v14.terrainPosition.z = this.fields.terrainPosition.z;
			//     v14.terrainSize = this.fields.terrainSize;
			//     v14.heightmapPageSize = this.fields.heightmapPageSize;
			//     v14.normalmapPageSize = this.fields.normalmapPageSize;
			//     v14.tintColorPageSize = this.fields.tintColorPageSize;
			//     v14.splatCtrlPageSize = this.fields.splatCtrlPageSize;
			//     albedoTexPageSize = this.fields.albedoTexPageSize;
			//     *(_QWORD *)&v14.terrainPosition.x = v5;
			//     *(float *)&v5 = this.fields.heightScale;
			//     *(_DWORD *)&v14.albedoTexPageSize = albedoTexPageSize;
			//     LODWORD(v14.heightScale) = v5;
			//     v7 = *(_OWORD *)&v14.terrainPosition.x;
			//     v8 = *(_OWORD *)&v14.terrainSize;
			//   }
			//   result = retstr;
			//   *(_OWORD *)&retstr.terrainPosition.x = v7;
			//   *(_OWORD *)&retstr.terrainSize = v8;
			//   return result;
			// }
			// 
			return null;
		}

		public void GetTerrainNodeDataArray(NativeArray<global::UnityEngine.HyperGryph.TerrainNodeData> nodeDataArray)
		{
			// // Void GetTerrainNodeDataArray(NativeArray`1[UnityEngine.HyperGryph.TerrainNodeData])
			// void HG::Rendering::Runtime::HGTerrainSurfacesData::GetTerrainNodeDataArray(
			//         HGTerrainSurfacesData *this,
			//         NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ *nodeDataArray,
			//         MethodInfo *method)
			// {
			//   HGTerrainSurfacesData_TerrainNodeData__Array *v5; // rdx
			//   __int64 v6; // rcx
			//   HGTerrainSurfacesData_TerrainNodeData__Array *nodeData; // rax
			//   Void *m_Buffer; // r9
			//   int32_t v9; // r8d
			//   HGTerrainSurfacesData_TerrainNodeData__Array *v10; // rax
			//   __int64 v11; // rax
			//   float localMinHeight; // xmm0_4
			//   int32_t localMaxHeight_low; // xmm1_4
			//   int32_t maxHeightError_low; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ v16; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919743 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::TerrainNodeData>::get_IsCreated);
			//     byte_18D919743 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3434, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3434, 0LL);
			//     if ( !Patch )
			//       goto LABEL_14;
			//     v16 = *nodeDataArray;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1223(Patch, (Object *)this, &v16, 0LL);
			//   }
			//   else if ( nodeDataArray.m_Buffer )
			//   {
			//     nodeData = this.fields.nodeData;
			//     if ( !nodeData )
			//       goto LABEL_14;
			//     if ( nodeDataArray.m_Length == nodeData.max_length.size )
			//     {
			//       m_Buffer = nodeDataArray.m_Buffer;
			//       v9 = 0;
			//       while ( 1 )
			//       {
			//         v10 = this.fields.nodeData;
			//         if ( !v10 )
			//           break;
			//         if ( v9 >= v10.max_length.size )
			//           return;
			//         v5 = this.fields.nodeData;
			//         if ( (unsigned int)v9 >= v10.max_length.size )
			//           sub_180070270(v6, v5);
			//         v11 = v9++;
			//         v6 = 3 * v11;
			//         localMinHeight = v5.vector[v11].localMinHeight;
			//         localMaxHeight_low = LODWORD(v5.vector[v11].localMaxHeight);
			//         LOBYTE(v16.m_Buffer) = v5.vector[v11].allHole;
			//         BYTE1(v16.m_Buffer) = v5.vector[v11].nodeLevel;
			//         LOWORD(v11) = v5.vector[v11].parent;
			//         *((float *)&v16.m_Buffer + 1) = localMinHeight;
			//         maxHeightError_low = LODWORD(v5.vector[(unsigned __int64)v6 / 3].maxHeightError);
			//         WORD1(v16.m_Buffer) = v11;
			//         v16.m_Length = localMaxHeight_low;
			//         v16.m_AllocatorLabel = maxHeightError_low;
			//         *(NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ *)m_Buffer = v16;
			//         m_Buffer += 16;
			//       }
			// LABEL_14:
			//       sub_180B536AC(v6, v5);
			//     }
			//   }
			// }
			// 
		}

		public void GetTerrainSectorSplatInfoArray(NativeArray<ulong> sectorSplatInfoArray)
		{
			// // Void GetTerrainSectorSplatInfoArray(NativeArray`1[System.UInt64])
			// void HG::Rendering::Runtime::HGTerrainSurfacesData::GetTerrainSectorSplatInfoArray(
			//         HGTerrainSurfacesData *this,
			//         NativeArray_1_System_UInt64_ *sectorSplatInfoArray,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   uint64_t v6; // rcx
			//   UInt64__Array *sectorSplatInfo; // rax
			//   Void *m_Buffer; // r8
			//   UInt64__Array *v9; // rax
			//   UInt64__Array *v10; // rcx
			//   __int64 v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   NativeArray_1_System_UInt64_ v13; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919744 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<unsigned long>::get_IsCreated);
			//     byte_18D919744 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3435, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3435, 0LL);
			//     if ( !Patch )
			//       goto LABEL_14;
			//     v13 = *sectorSplatInfoArray;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1224(Patch, (Object *)this, &v13, 0LL);
			//   }
			//   else if ( sectorSplatInfoArray.m_Buffer )
			//   {
			//     sectorSplatInfo = this.fields.sectorSplatInfo;
			//     if ( !sectorSplatInfo )
			//       goto LABEL_14;
			//     if ( sectorSplatInfoArray.m_Length == sectorSplatInfo.max_length.size )
			//     {
			//       m_Buffer = sectorSplatInfoArray.m_Buffer;
			//       v5 = 0LL;
			//       while ( 1 )
			//       {
			//         v9 = this.fields.sectorSplatInfo;
			//         if ( !v9 )
			//           break;
			//         if ( (int)v5 >= v9.max_length.size )
			//           return;
			//         v10 = this.fields.sectorSplatInfo;
			//         if ( (unsigned int)v5 >= v9.max_length.size )
			//           sub_180070270(v10, v5);
			//         v11 = (int)v5;
			//         v5 = (unsigned int)(v5 + 1);
			//         v6 = v10.vector[v11];
			//         *(_QWORD *)m_Buffer = v6;
			//         m_Buffer += 8;
			//       }
			// LABEL_14:
			//       sub_180B536AC(v6, v5);
			//     }
			//   }
			// }
			// 
		}

		public void GetSplatLayerDataArray(NativeArray<global::UnityEngine.HyperGryph.SplatLayerData> layerDataArray)
		{
			// // Void GetSplatLayerDataArray(NativeArray`1[UnityEngine.HyperGryph.SplatLayerData])
			// void HG::Rendering::Runtime::HGTerrainSurfacesData::GetSplatLayerDataArray(
			//         HGTerrainSurfacesData *this,
			//         NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ *layerDataArray,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGTerrainSurfacesData_SplatLayerData__Array *layerData; // rax
			//   Void *m_Buffer; // r14
			//   int32_t v9; // ebp
			//   HGTerrainSurfacesData_SplatLayerData__Array *v10; // rax
			//   HGTerrainSurfacesData_SplatLayerData__Array *v11; // rsi
			//   __int64 v12; // rbx
			//   __int128 v13; // xmm0
			//   __m128i v14; // xmm4
			//   __m128i v15; // xmm5
			//   __m128i v16; // xmm6
			//   __m128i v17; // xmm7
			//   __m128i v18; // xmm2
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ v20; // [rsp+20h] [rbp-A8h] BYREF
			//   _BYTE v21[80]; // [rsp+30h] [rbp-98h] BYREF
			//   __int128 v22; // [rsp+80h] [rbp-48h]
			// 
			//   if ( !byte_18D919745 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::SplatLayerData>::get_IsCreated);
			//     byte_18D919745 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3436, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3436, 0LL);
			//     if ( !Patch )
			//       goto LABEL_14;
			//     v20 = *layerDataArray;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1225(Patch, (Object *)this, &v20, 0LL);
			//   }
			//   else if ( layerDataArray.m_Buffer )
			//   {
			//     layerData = this.fields.layerData;
			//     if ( !layerData )
			//       goto LABEL_14;
			//     if ( layerDataArray.m_Length == layerData.max_length.size )
			//     {
			//       m_Buffer = layerDataArray.m_Buffer;
			//       v9 = 0;
			//       while ( 1 )
			//       {
			//         v10 = this.fields.layerData;
			//         if ( !v10 )
			//           break;
			//         if ( v9 >= v10.max_length.size )
			//           return;
			//         v11 = this.fields.layerData;
			//         if ( (unsigned int)v9 >= v10.max_length.size )
			//           sub_180070270(v6, v5);
			//         v12 = v9;
			//         sub_1802F01E0(v21, 0LL, 112LL);
			//         v13 = *(_OWORD *)&v11.vector[v12].packedDeformParams0.x;
			//         ++v9;
			//         v14 = _mm_loadu_si128((const __m128i *)&v11.vector[v12].splatST);
			//         v15 = _mm_loadu_si128((const __m128i *)&v11.vector[v12].diffuseRemapScale);
			//         v16 = _mm_loadu_si128((const __m128i *)&v11.vector[v12].maskMapRemapOffset);
			//         v17 = _mm_loadu_si128((const __m128i *)&v11.vector[v12].maskMapRemapScale);
			//         v18 = _mm_loadu_si128((const __m128i *)&v11.vector[v12].pomParams);
			//         *(__m128i *)m_Buffer = _mm_loadu_si128((const __m128i *)&v11.vector[v12]);
			//         *(__m128i *)&m_Buffer[16] = v14;
			//         *(__m128i *)&m_Buffer[32] = v15;
			//         *(__m128i *)&m_Buffer[48] = v16;
			//         *(__m128i *)&m_Buffer[64] = v17;
			//         *(_OWORD *)&m_Buffer[80] = v13;
			//         *(__m128i *)&m_Buffer[96] = v18;
			//         m_Buffer += 112;
			//         v22 = v13;
			//       }
			// LABEL_14:
			//       sub_180B536AC(v6, v5);
			//     }
			//   }
			// }
			// 
		}

		public Vector3 terrainPosition;

		public float heightScale;

		public int terrainSize;

		public int heightmapPageSize;

		public int normalmapPageSize;

		public int tintColorPageSize;

		public int splatCtrlPageSize;

		public int albedoTexPageSize;

		public TerrainLayerTypeData layerTypeData;

		public HGTerrainSurfacesData.SplatLayerData[] layerData;

		public Texture2D[] layerDiffuseTextures;

		public Texture2D[] layerNormalROTextures;

		public Texture2D[] layerConeMapTextures;

		public HGTerrainSurfacesData.TerrainNodeData[] nodeData;

		public ulong[] sectorSplatInfo;

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 112)]
		public struct SplatLayerData
		{
			public Vector4 packedSplatInfo;

			public Vector4 splatST;

			public Vector4 diffuseRemapScale;

			public Vector4 maskMapRemapOffset;

			public Vector4 maskMapRemapScale;

			public Vector2 packedDeformParams0;

			public HGTerrainUtils.Vector2UInt packedDeformParams1;

			public Vector4 pomParams;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 24)]
		public struct TerrainNodeData
		{
			public int allHole;

			public int nodeLevel;

			public int parent;

			public float localMinHeight;

			public float localMaxHeight;

			public float maxHeightError;
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4)]
		public struct UIntAndFloat
		{
			public uint uintValue;

			public float floatValue;
		}
	}
}
