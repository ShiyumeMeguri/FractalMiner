using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Editor
{
	[CreateAssetMenu(fileName = "HGTerrainEditorResources", menuName = "HGTerrain/HGTerrainEditorResources", order = 0)]
	public class HGTerrainEditorResources : ScriptableObject
	{
		public HGTerrainEditorResources()
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

		public HGTerrainEditorResources.ShaderResources shaders;

		[ReloadGroup]
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

			[Reload("Editor/Shaders/Terrain/BuildTerrainSplatIndexControl.compute", ReloadAttribute.Package.Root)]
			public ComputeShader buildTerrainSplatIndexControlCS;

			[Reload("Editor/Shaders/Terrain/FixTerrainControlMap.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fixTerrainControlMapCS;

			[Reload("Editor/Shaders/Terrain/BuildTerrainNormalmap.compute", ReloadAttribute.Package.Root)]
			public ComputeShader buildTerrainNormalmapCS;

			[Reload("Editor/Shaders/Terrain/BlitTerrainDecalTexture.shader", ReloadAttribute.Package.Root)]
			public Shader blitTerrainDecalTexturePS;

			[Reload("Runtime/Shaders/Utils/GenerateMinMipmap.compute", ReloadAttribute.Package.Root)]
			public ComputeShader buildConeMapCS;

			[Reload("Editor/Shaders/Terrain/BuildTerrainSectorSplatInfo.compute", ReloadAttribute.Package.Root)]
			public ComputeShader buildTerrainSectorSplatInfoCS;

			[Reload("Editor/Shaders/Terrain/TerrainCheckTexDiff.compute", ReloadAttribute.Package.Root)]
			public ComputeShader checkTexDiffCS;
		}
	}
}
