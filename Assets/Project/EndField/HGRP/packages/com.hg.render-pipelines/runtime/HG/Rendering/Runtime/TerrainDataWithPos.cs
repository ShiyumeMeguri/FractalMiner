using System;
using System.Runtime.InteropServices;
using HG.Rendering.Runtime.TerrainV2;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TerrainDataWithPos
	{
		public Vector3 pos;

		public TerrainData terrainData;

		public TerrainLayerTypeData layerTypeData;
	}
}
