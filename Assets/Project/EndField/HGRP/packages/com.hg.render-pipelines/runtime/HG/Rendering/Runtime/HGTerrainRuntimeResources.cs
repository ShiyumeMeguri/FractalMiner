using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGTerrainRuntimeResources", menuName = "\u2605 Beyond/HGTerrain/HGTerrainRuntimeResources", order = 0)]
	public class HGTerrainRuntimeResources : ScriptableObject // TypeDefIndex: 38636
	{
		// Fields
		public Vector2Int terrainSize; // 0x18
		public Vector3 heightmapScale; // 0x20
		public int chunkTreeDepth; // 0x2C
		public Vector3 terrainPos; // 0x30
		public int lightmapIndex; // 0x3C
		public Vector4 lightmapScaleOffset; // 0x40
		public ChunkData chunkData; // 0x50
		public MeshResources meshes; // 0x88
		public DecalResources decalResources; // 0x90
		public TerrainLayerInfo terrainLayerData; // 0xD0
		public TextureResources textures; // 0x100
		public ShaderResources shaders; // 0x108
		public Material terrainLitMaterial; // 0x110
	
		// Nested types
		[Serializable]
		[ReloadGroup]
		public sealed class TextureResources // TypeDefIndex: 38624
		{
			// Fields
			[Reload("Terrain/SplatIndexMap.tga", ReloadAttribute.Package.Root)]
			public Texture2D splatIndexMap; // 0x10
			[Reload("Terrain/SplatControlMap.tga", ReloadAttribute.Package.Root)]
			public Texture2D splatControlMap; // 0x18
			[Reload("Terrain/Heightmap.asset", ReloadAttribute.Package.Root)]
			public Texture2D heightmap; // 0x20
			[Reload("Terrain/Normalmap.tga", ReloadAttribute.Package.Root)]
			public Texture2D normalmap; // 0x28
			[Reload("Terrain/SplatLayerDiffuseArray.tga", ReloadAttribute.Package.Root)]
			public Texture2DArray terrainLayerDiffuseArray; // 0x30
			[Reload("Terrain/SplatLayerNormalArray.tga", ReloadAttribute.Package.Root)]
			public Texture2DArray terrainLayerNormalArray; // 0x38
			[Reload("Terrain/ColorVariation.tga", ReloadAttribute.Package.Root)]
			public Texture2D colorVariationTex; // 0x40
			[Reload("Terrain/DeformableControlMap.tga", ReloadAttribute.Package.Root)]
			public Texture2D deformableControlMap; // 0x48
			public Texture2D lightmapColorTex; // 0x50
			public Texture2D lightmapDirTex; // 0x58
			public Texture2D shadowMask; // 0x60
	
			// Constructors
			public TextureResources() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		public enum TextureResourcesFields // TypeDefIndex: 38625
		{
			SplatIndexMap = 0,
			SplatControlMap = 1,
			Heightmap = 2,
			Normalmap = 3,
			TerrainLayerDiffuseArray = 4,
			TerrainLayerNormalArray = 5,
			ColorVariationTex = 6,
			DeformableControlMap = 7
		}
	
		[Serializable]
		[ReloadGroup]
		public sealed class MeshResources // TypeDefIndex: 38626
		{
			// Fields
			[Reload("Terrain/ChunkMesh.asset", ReloadAttribute.Package.Root)]
			public Mesh chunkMesh; // 0x10
	
			// Constructors
			public MeshResources() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		public enum MeshResourcesFields // TypeDefIndex: 38627
		{
			ChunkMesh = 0
		}
	
		[Serializable]
		public sealed class ShaderResources // TypeDefIndex: 38628
		{
			// Fields
			public Shader terrainLitPS; // 0x10
			public ComputeShader terrainVTBakeCS; // 0x18
			public ComputeShader terrainASTCCompressCS; // 0x20
			public ComputeShader terrainBC3CompressCS; // 0x28
	
			// Constructors
			public ShaderResources() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		[Serializable]
		public struct TerrainLayerInfo // TypeDefIndex: 38629
		{
			// Fields
			public Vector4[] packedSplatInfo; // 0x00
			public Vector4[] splatsST; // 0x08
			public Vector4[] diffuseRemapScale; // 0x10
			public Vector4[] maskMapRemapOffset; // 0x18
			public Vector4[] maskMapRemapScale; // 0x20
			public int[] packedSignificantLayerInfo; // 0x28
		}
	
		[Serializable]
		public struct ChunkData // TypeDefIndex: 38630
		{
			// Fields
			public float[] centerXs; // 0x00
			public float[] centerYs; // 0x08
			public float[] centerZs; // 0x10
			public float[] extentXs; // 0x18
			public float[] extentYs; // 0x20
			public float[] extentZs; // 0x28
			public int[] chunkLevel; // 0x30
		}
	
		[Serializable]
		public struct DecalPerInstanceData // TypeDefIndex: 38631
		{
			// Fields
			public Vector2Int row00; // 0x00
			public Vector2 row01; // 0x08
			public Vector4 row1; // 0x10
			public Vector4 row2; // 0x20
			public Vector4 row3; // 0x30
		}
	
		[Serializable]
		public struct UInt128 // TypeDefIndex: 38632
		{
			// Fields
			public long num0; // 0x00
			public long num1; // 0x08
	
			// Constructors
			public UInt128(byte[] bytes) {
				num0 = default;
				num1 = default;
			} // 0x0000000189C23EF8-0x0000000189C23F6C
			// HGTerrainRuntimeResources+UInt128(Byte[])
			void HG::Rendering::Runtime::HGTerrainRuntimeResources::UInt128::UInt128(
			        HGTerrainRuntimeResources_UInt128 *this,
			        Byte__Array *bytes,
			        MethodInfo *method)
			{
			  int v3; // r8d
			  Byte__Array *v4; // r10
			  HGTerrainRuntimeResources_UInt128 *v5; // r9
			  int32_t v6; // r11d
			
			  v3 = 0;
			  v4 = bytes;
			  this->num1 = 0LL;
			  v5 = this;
			  this->num0 = 0LL;
			  v6 = 0;
			  if ( !bytes )
			    sub_1800D8260(this, 0LL);
			  do
			  {
			    if ( (unsigned int)v6 >= v4->max_length.size
			      || (this = (HGTerrainRuntimeResources_UInt128 *)(v3 & 0x3F),
			          bytes = (Byte__Array *)(v6 + 8LL),
			          v5->num0 |= (unsigned __int64)v4->vector[v6] << (char)this,
			          (unsigned int)bytes >= v4->max_length.size) )
			    {
			      sub_1800D2AB0(this, bytes);
			    }
			    this = (HGTerrainRuntimeResources_UInt128 *)(v3 & 0x3F);
			    ++v6;
			    v3 += 8;
			    v5->num1 |= (unsigned __int64)v4->vector[(_QWORD)bytes] << (char)this;
			  }
			  while ( v3 < 64 );
			}
			
	
			// Methods
			public static implicit operator UInt128(byte[] bytes) => default; // 0x0000000189C23F6C-0x0000000189C23FE4
			// HGTerrainRuntimeResources+UInt128 op_Implicit(Byte[])
			HGTerrainRuntimeResources_UInt128 *HG::Rendering::Runtime::HGTerrainRuntimeResources::UInt128::op_Implicit(
			        HGTerrainRuntimeResources_UInt128 *__return_ptr retstr,
			        Byte__Array *bytes,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			  HGTerrainRuntimeResources_UInt128 v9; // [rsp+20h] [rbp-18h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(4029, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(4029, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1419(&v9, Patch, (Object *)bytes, 0LL);
			  }
			  else
			  {
			    *retstr = 0LL;
			    HG::Rendering::Runtime::HGTerrainRuntimeResources::UInt128::UInt128(retstr, bytes, 0LL);
			  }
			  return retstr;
			}
			
			public Guid ToGuid() => default; // 0x0000000189C23DF4-0x0000000189C23EF8
			// Guid ToGuid()
			Guid *HG::Rendering::Runtime::HGTerrainRuntimeResources::UInt128::ToGuid(
			        Guid *__return_ptr retstr,
			        HGTerrainRuntimeResources_UInt128 *this,
			        MethodInfo *method)
			{
			  int64_t num0; // rdx
			  int16_t num0_high; // r9
			  int64_t v7; // r8
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v9; // rdx
			  __int64 v10; // rcx
			  uint8_t d; // [rsp+20h] [rbp-78h]
			  uint8_t e; // [rsp+28h] [rbp-70h]
			  uint8_t f; // [rsp+30h] [rbp-68h]
			  uint8_t g; // [rsp+38h] [rbp-60h]
			  uint8_t h; // [rsp+40h] [rbp-58h]
			  uint8_t i; // [rsp+48h] [rbp-50h]
			  uint8_t j; // [rsp+50h] [rbp-48h]
			  uint8_t k; // [rsp+58h] [rbp-40h]
			  Guid v20; // [rsp+70h] [rbp-28h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(4030, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(4030, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v10, v9);
			    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1420(&v20, Patch, this, 0LL);
			  }
			  else
			  {
			    num0 = this->num0;
			    num0_high = HIWORD(this->num0);
			    k = HIBYTE(this->num1);
			    j = BYTE6(this->num1);
			    i = (unsigned __int16)WORD2(this->num1) >> 8;
			    h = BYTE4(this->num1);
			    g = HIBYTE(LODWORD(this->num1));
			    f = BYTE2(LODWORD(this->num1));
			    e = BYTE1(LODWORD(this->num1));
			    v7 = this->num0 >> 32;
			    d = this->num1;
			    *retstr = 0LL;
			    System::Guid::Guid(retstr, num0, v7, num0_high, d, e, f, g, h, i, j, k, 0LL);
			  }
			  return retstr;
			}
			
		}
	
		[Serializable]
		public struct DecalIndices // TypeDefIndex: 38633
		{
			// Fields
			public int[] decalIndices; // 0x00
	
			// Constructors
			public DecalIndices(int[] decalIndices) {
				this.decalIndices = default;
			} // 0x0000000185392320-0x0000000185392328
			// Void WriteUnaligned[Object](Byte ByRef, Object)
			void System::Runtime::CompilerServices::Unsafe::WriteUnaligned<System::Object>(
			        uint8_t *destination,
			        Object *value,
			        MethodInfo *method)
			{
			  Int32__Array **v3; // r9
			  MethodInfo *v4; // [rsp+28h] [rbp+28h]
			
			  *(_QWORD *)destination = value;
			  sub_18002D1B0(
			    (HGRuntimeGrassQuery_Node *)destination,
			    (HGRuntimeGrassQuery_Node *)value,
			    (HGRuntimeGrassQuery_Node *)method,
			    v3,
			    v4);
			}
			
	
			// Methods
			public static implicit operator DecalIndices(int[] decalIndices) => default; // 0x0000000189C1D11C-0x0000000189C1D17C
			// HGTerrainRuntimeResources+DecalIndices op_Implicit(Int32[])
			HGTerrainRuntimeResources_DecalIndices HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalIndices::op_Implicit(
			        Int32__Array *decalIndices,
			        MethodInfo *method)
			{
			  HGRuntimeGrassQuery_Node *v3; // rdx
			  HGRuntimeGrassQuery_Node *v4; // r8
			  Int32__Array **v5; // r9
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v8; // rdx
			  __int64 v9; // rcx
			  MethodInfo *v10; // [rsp+20h] [rbp-8h]
			  Int32__Array *v11; // [rsp+40h] [rbp+18h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(4031, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(4031, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v9, v8);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1421(Patch, (Object *)decalIndices, 0LL);
			  }
			  else
			  {
			    v11 = decalIndices;
			    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v11, v3, v4, v5, v10);
			    return (HGTerrainRuntimeResources_DecalIndices)v11;
			  }
			}
			
		}
	
		[Serializable]
		public struct BlockMasks // TypeDefIndex: 38634
		{
			// Fields
			public ulong[] blockMasks; // 0x00
	
			// Constructors
			public BlockMasks(ulong[] blockMasks) {
				this.blockMasks = default;
			} // 0x0000000185392320-0x0000000185392328
			// Void WriteUnaligned[Object](Byte ByRef, Object)
			void System::Runtime::CompilerServices::Unsafe::WriteUnaligned<System::Object>(
			        uint8_t *destination,
			        Object *value,
			        MethodInfo *method)
			{
			  Int32__Array **v3; // r9
			  MethodInfo *v4; // [rsp+28h] [rbp+28h]
			
			  *(_QWORD *)destination = value;
			  sub_18002D1B0(
			    (HGRuntimeGrassQuery_Node *)destination,
			    (HGRuntimeGrassQuery_Node *)value,
			    (HGRuntimeGrassQuery_Node *)method,
			    v3,
			    v4);
			}
			
	
			// Methods
			public static implicit operator BlockMasks(ulong[] blockMasks) => default; // 0x0000000189C1C4B4-0x0000000189C1C514
			// HGTerrainRuntimeResources+BlockMasks op_Implicit(UInt64[])
			HGTerrainRuntimeResources_BlockMasks HG::Rendering::Runtime::HGTerrainRuntimeResources::BlockMasks::op_Implicit(
			        UInt64__Array *blockMasks,
			        MethodInfo *method)
			{
			  HGRuntimeGrassQuery_Node *v3; // rdx
			  HGRuntimeGrassQuery_Node *v4; // r8
			  Int32__Array **v5; // r9
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v8; // rdx
			  __int64 v9; // rcx
			  MethodInfo *v10; // [rsp+20h] [rbp-8h]
			  UInt64__Array *v11; // [rsp+40h] [rbp+18h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(4032, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(4032, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v9, v8);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1422(Patch, (Object *)blockMasks, 0LL);
			  }
			  else
			  {
			    v11 = blockMasks;
			    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v11, v3, v4, v5, v10);
			    return (HGTerrainRuntimeResources_BlockMasks)v11;
			  }
			}
			
		}
	
		[Serializable]
		public struct DecalResources // TypeDefIndex: 38635
		{
			// Fields
			public DecalPerInstanceData[] instanceData; // 0x00
			public UInt128[] diffuseTexList; // 0x08
			public UInt128[] normalMROTexList; // 0x10
			public uint[] decalNodeKeys; // 0x18
			public DecalIndices[] decalIndicesValues; // 0x20
			public uint[] blockNodeKeys; // 0x28
			public BlockMasks[] blockMasksValues; // 0x30
			public bool dynamicAsset; // 0x38
		}
	
		// Constructors
		public HGTerrainRuntimeResources() {} // 0x0000000183573370-0x0000000183573380
		// SingletonScriptableObject`1[System.Object]()
		void Beyond::SingletonScriptableObject<System::Object>::SingletonScriptableObject(
		        SingletonScriptableObject_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	}
}
