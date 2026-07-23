using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct TerrainResource // TypeDefIndex: 38617
	{
		// Fields
		public HGTerrainRuntimeResources runtimeResources; // 0x00
		public HGTerrainConfiguration configuration; // 0x08
		public TerrainCollider terrainCollider; // 0x10
		public Texture2DArray decalDiffuseTexArray; // 0x18
		public Texture2DArray decalNormalMROTexArray; // 0x20
	}
}
