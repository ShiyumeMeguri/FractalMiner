using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Editor
{
	[CreateAssetMenu(fileName = "HGTerrainEditorResources", menuName = "\u2605 Beyond/HGTerrain/HGTerrainEditorResources", order = 0)]
	public class HGTerrainEditorResources : ScriptableObject // TypeDefIndex: 37489
	{
		// Fields
		public ShaderResources shaders; // 0x18
	
		// Nested types
		[Serializable]
		[ReloadGroup]
		public sealed class ShaderResources // TypeDefIndex: 37488
		{
			// Fields
			[Reload("Editor/Shaders/Terrain/BuildTerrainSplatIndexControl.compute", ReloadAttribute.Package.Root)]
			public ComputeShader buildTerrainSplatIndexControlCS; // 0x10
			[Reload("Editor/Shaders/Terrain/FixTerrainControlMap.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fixTerrainControlMapCS; // 0x18
			[Reload("Editor/Shaders/Terrain/BuildTerrainNormalmap.compute", ReloadAttribute.Package.Root)]
			public ComputeShader buildTerrainNormalmapCS; // 0x20
			[Reload("Editor/Shaders/Terrain/BlitTerrainDecalTexture.shader", ReloadAttribute.Package.Root)]
			public Shader blitTerrainDecalTexturePS; // 0x28
			[Reload("Runtime/Shaders/Utils/GenerateMinMipmap.compute", ReloadAttribute.Package.Root)]
			public ComputeShader buildConeMapCS; // 0x30
			[Reload("Editor/Shaders/Terrain/BuildTerrainSectorSplatInfo.compute", ReloadAttribute.Package.Root)]
			public ComputeShader buildTerrainSectorSplatInfoCS; // 0x38
			[Reload("Editor/Shaders/Terrain/TerrainCheckTexDiff.compute", ReloadAttribute.Package.Root)]
			public ComputeShader checkTexDiffCS; // 0x40
	
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
	
		// Constructors
		public HGTerrainEditorResources() {} // 0x0000000183573370-0x0000000183573380
		// SingletonScriptableObject`1[System.Object]()
		void Beyond::SingletonScriptableObject<System::Object>::SingletonScriptableObject(
		        SingletonScriptableObject_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	}
}
