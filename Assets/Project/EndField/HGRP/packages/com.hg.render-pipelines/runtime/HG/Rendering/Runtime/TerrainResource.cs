using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TerrainResource
	{
		public HGTerrainRuntimeResources runtimeResources;

		public HGTerrainConfiguration configuration;

		public TerrainCollider terrainCollider;

		public Texture2DArray decalDiffuseTexArray;

		public Texture2DArray decalNormalMROTexArray;
	}
}
