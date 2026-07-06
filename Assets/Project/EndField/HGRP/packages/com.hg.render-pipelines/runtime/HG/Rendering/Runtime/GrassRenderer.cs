using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.HyperGryph;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GrassRenderer
	{
		public uint batchKey;

		public HGRenderFlags renderFlags;

		public Mesh mesh;

		public Material material;

		public int subMeshIndex;

		public float sparsity;

		public float lodScreenSizeMaxSquared;

		public float lodScreenSizeMinSquared;
	}
}
