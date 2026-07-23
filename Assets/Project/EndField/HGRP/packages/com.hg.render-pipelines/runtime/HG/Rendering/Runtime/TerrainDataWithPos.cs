using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime.TerrainV2;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct TerrainDataWithPos // TypeDefIndex: 38652
	{
		// Fields
		public Vector3 pos; // 0x00
		public TerrainData terrainData; // 0x10
		public TerrainLayerTypeData layerTypeData; // 0x18
	}
}
