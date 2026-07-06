using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGTerrainRuntimeResources", menuName = "HGTerrain/HGTerrainRuntimeResources", order = 0)]
	public class HGTerrainRuntimeResources : ScriptableObject
	{
		public HGTerrainRuntimeResources()
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

		public Vector2Int terrainSize;

		public Vector3 heightmapScale;

		public int chunkTreeDepth;

		public Vector3 terrainPos;

		public int lightmapIndex;

		public Vector4 lightmapScaleOffset;

		public HGTerrainRuntimeResources.ChunkData chunkData;

		public HGTerrainRuntimeResources.MeshResources meshes;

		public HGTerrainRuntimeResources.DecalResources decalResources;

		public HGTerrainRuntimeResources.TerrainLayerInfo terrainLayerData;

		public HGTerrainRuntimeResources.TextureResources textures;

		public HGTerrainRuntimeResources.ShaderResources shaders;

		public Material terrainLitMaterial;

		[ReloadGroup]
		[Serializable]
		public sealed class TextureResources
		{
			public TextureResources()
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}

			[Reload("Terrain/SplatIndexMap.tga", ReloadAttribute.Package.Root)]
			public Texture2D splatIndexMap;

			[Reload("Terrain/SplatControlMap.tga", ReloadAttribute.Package.Root)]
			public Texture2D splatControlMap;

			[Reload("Terrain/Heightmap.asset", ReloadAttribute.Package.Root)]
			public Texture2D heightmap;

			[Reload("Terrain/Normalmap.tga", ReloadAttribute.Package.Root)]
			public Texture2D normalmap;

			[Reload("Terrain/SplatLayerDiffuseArray.tga", ReloadAttribute.Package.Root)]
			public Texture2DArray terrainLayerDiffuseArray;

			[Reload("Terrain/SplatLayerNormalArray.tga", ReloadAttribute.Package.Root)]
			public Texture2DArray terrainLayerNormalArray;

			[Reload("Terrain/ColorVariation.tga", ReloadAttribute.Package.Root)]
			public Texture2D colorVariationTex;

			[Reload("Terrain/DeformableControlMap.tga", ReloadAttribute.Package.Root)]
			public Texture2D deformableControlMap;

			public Texture2D lightmapColorTex;

			public Texture2D lightmapDirTex;

			public Texture2D shadowMask;
		}

		public enum TextureResourcesFields
		{
			SplatIndexMap,
			SplatControlMap,
			Heightmap,
			Normalmap,
			TerrainLayerDiffuseArray,
			TerrainLayerNormalArray,
			ColorVariationTex,
			DeformableControlMap
		}

		[ReloadGroup]
		[Serializable]
		public sealed class MeshResources
		{
			public MeshResources()
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}

			[Reload("Terrain/ChunkMesh.asset", ReloadAttribute.Package.Root)]
			public Mesh chunkMesh;
		}

		public enum MeshResourcesFields
		{
			ChunkMesh
		}

		[Serializable]
		public sealed class ShaderResources
		{
			public ShaderResources()
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}

			public Shader terrainLitPS;

			public ComputeShader terrainVTBakeCS;

			public ComputeShader terrainASTCCompressCS;

			public ComputeShader terrainBC3CompressCS;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 48)]
		public struct TerrainLayerInfo
		{
			public Vector4[] packedSplatInfo;

			public Vector4[] splatsST;

			public Vector4[] diffuseRemapScale;

			public Vector4[] maskMapRemapOffset;

			public Vector4[] maskMapRemapScale;

			public int[] packedSignificantLayerInfo;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 56)]
		public struct ChunkData
		{
			public float[] centerXs;

			public float[] centerYs;

			public float[] centerZs;

			public float[] extentXs;

			public float[] extentYs;

			public float[] extentZs;

			public int[] chunkLevel;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
		public struct DecalPerInstanceData
		{
			public Vector2Int row00;

			public Vector2 row01;

			public Vector4 row1;

			public Vector4 row2;

			public Vector4 row3;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		public struct UInt128
		{
			public UInt128(byte[] bytes)
			{
				// // HGTerrainRuntimeResources+UInt128(Byte[])
				// void HG::Rendering::Runtime::HGTerrainRuntimeResources::UInt128::UInt128(
				//         HGTerrainRuntimeResources_UInt128 *this,
				//         Byte__Array *bytes,
				//         MethodInfo *method)
				// {
				//   int v3; // r8d
				//   Byte__Array *v4; // r10
				//   HGTerrainRuntimeResources_UInt128 *v5; // r9
				//   int32_t v6; // r11d
				// 
				//   v3 = 0;
				//   v4 = bytes;
				//   this.num1 = 0LL;
				//   v5 = this;
				//   this.num0 = 0LL;
				//   v6 = 0;
				//   if ( !bytes )
				//     sub_180B536AC(this, 0LL);
				//   do
				//   {
				//     if ( (unsigned int)v6 >= v4.max_length.size
				//       || (this = (HGTerrainRuntimeResources_UInt128 *)(v3 & 0x3F),
				//           bytes = (Byte__Array *)(v6 + 8LL),
				//           v5.num0 |= (unsigned __int64)v4.vector[v6] << (char)this,
				//           (unsigned int)bytes >= v4.max_length.size) )
				//     {
				//       sub_180070270(this, bytes);
				//     }
				//     this = (HGTerrainRuntimeResources_UInt128 *)(v3 & 0x3F);
				//     ++v6;
				//     v3 += 8;
				//     v5.num1 |= (unsigned __int64)v4.vector[(_QWORD)bytes] << (char)this;
				//   }
				//   while ( v3 < 64 );
				// }
				// 
			}

			public static implicit operator HGTerrainRuntimeResources.UInt128(byte[] bytes)
			{
				// // HGTerrainRuntimeResources+UInt128 op_Implicit(Byte[])
				// HGTerrainRuntimeResources_UInt128 *HG::Rendering::Runtime::HGTerrainRuntimeResources::UInt128::op_Implicit(
				//         HGTerrainRuntimeResources_UInt128 *__return_ptr retstr,
				//         Byte__Array *bytes,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				//   HGTerrainRuntimeResources_UInt128 v9; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(3401, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3401, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1209(&v9, Patch, (Object *)bytes, 0LL);
				//   }
				//   else
				//   {
				//     *retstr = 0LL;
				//     HG::Rendering::Runtime::HGTerrainRuntimeResources::UInt128::UInt128(retstr, bytes, 0LL);
				//   }
				//   return retstr;
				// }
				// 
				return default(HGTerrainRuntimeResources.UInt128);
			}

			public Guid ToGuid()
			{
				// // Guid ToGuid()
				// Guid *HG::Rendering::Runtime::HGTerrainRuntimeResources::UInt128::ToGuid(
				//         Guid *__return_ptr retstr,
				//         HGTerrainRuntimeResources_UInt128 *this,
				//         MethodInfo *method)
				// {
				//   int64_t num0; // rdx
				//   int16_t num0_high; // r9
				//   int64_t v7; // r8
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v9; // rdx
				//   __int64 v10; // rcx
				//   uint8_t d; // [rsp+20h] [rbp-78h]
				//   uint8_t e; // [rsp+28h] [rbp-70h]
				//   uint8_t f; // [rsp+30h] [rbp-68h]
				//   uint8_t g; // [rsp+38h] [rbp-60h]
				//   uint8_t h; // [rsp+40h] [rbp-58h]
				//   uint8_t i; // [rsp+48h] [rbp-50h]
				//   uint8_t j; // [rsp+50h] [rbp-48h]
				//   uint8_t k; // [rsp+58h] [rbp-40h]
				//   Guid v20; // [rsp+70h] [rbp-28h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(3402, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3402, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v10, v9);
				//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1210(&v20, Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     num0 = this.num0;
				//     num0_high = HIWORD(this.num0);
				//     k = HIBYTE(this.num1);
				//     j = BYTE6(this.num1);
				//     i = (unsigned __int16)WORD2(this.num1) >> 8;
				//     h = BYTE4(this.num1);
				//     g = HIBYTE(LODWORD(this.num1));
				//     f = BYTE2(LODWORD(this.num1));
				//     e = BYTE1(LODWORD(this.num1));
				//     v7 = this.num0 >> 32;
				//     d = this.num1;
				//     *retstr = 0LL;
				//     System::Guid::Guid(retstr, num0, v7, num0_high, d, e, f, g, h, i, j, k, 0LL);
				//   }
				//   return retstr;
				// }
				// 
				return null;
			}

			public long num0;

			public long num1;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
		public struct DecalIndices
		{
			public DecalIndices(int[] decalIndices)
			{
				// // Void WriteUnaligned[Object](Byte ByRef, Object)
				// void System::Runtime::CompilerServices::Unsafe::WriteUnaligned<System::Object>(
				//         uint8_t *destination,
				//         Object *value,
				//         MethodInfo *method)
				// {
				//   HGCamera *v3; // r9
				//   MethodInfo *v4; // [rsp+28h] [rbp+28h]
				//   MethodInfo *v5; // [rsp+30h] [rbp+30h]
				// 
				//   *(_QWORD *)destination = value;
				//   sub_1800054D0(
				//     (HGRenderPathScene *)destination,
				//     (HGRenderPathBase_HGRenderPathResources *)value,
				//     (PassConstructorID__Enum__Array *)method,
				//     v3,
				//     v4,
				//     v5);
				// }
				// 
			}

			public static implicit operator HGTerrainRuntimeResources.DecalIndices(int[] decalIndices)
			{
				return default(HGTerrainRuntimeResources.DecalIndices);
			}

			public int[] decalIndices;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
		public struct BlockMasks
		{
			public BlockMasks(ulong[] blockMasks)
			{
				// // Void WriteUnaligned[Object](Byte ByRef, Object)
				// void System::Runtime::CompilerServices::Unsafe::WriteUnaligned<System::Object>(
				//         uint8_t *destination,
				//         Object *value,
				//         MethodInfo *method)
				// {
				//   HGCamera *v3; // r9
				//   MethodInfo *v4; // [rsp+28h] [rbp+28h]
				//   MethodInfo *v5; // [rsp+30h] [rbp+30h]
				// 
				//   *(_QWORD *)destination = value;
				//   sub_1800054D0(
				//     (HGRenderPathScene *)destination,
				//     (HGRenderPathBase_HGRenderPathResources *)value,
				//     (PassConstructorID__Enum__Array *)method,
				//     v3,
				//     v4,
				//     v5);
				// }
				// 
			}

			public static implicit operator HGTerrainRuntimeResources.BlockMasks(ulong[] blockMasks)
			{
				return default(HGTerrainRuntimeResources.BlockMasks);
			}

			public ulong[] blockMasks;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
		public struct DecalResources
		{
			public HGTerrainRuntimeResources.DecalPerInstanceData[] instanceData;

			public HGTerrainRuntimeResources.UInt128[] diffuseTexList;

			public HGTerrainRuntimeResources.UInt128[] normalMROTexList;

			public uint[] decalNodeKeys;

			public HGTerrainRuntimeResources.DecalIndices[] decalIndicesValues;

			public uint[] blockNodeKeys;

			public HGTerrainRuntimeResources.BlockMasks[] blockMasksValues;

			public bool dynamicAsset;
		}
	}
}
