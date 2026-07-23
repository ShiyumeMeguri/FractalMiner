using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryph;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct GrassRenderer // TypeDefIndex: 37995
	{
		// Fields
		public uint batchKey; // 0x00
		public HGRenderFlags renderFlags; // 0x04
		public Mesh mesh; // 0x08
		public Material material; // 0x10
		public int subMeshIndex; // 0x18
		public float sparsity; // 0x1C
		public float lodScreenSizeMaxSquared; // 0x20
		public float lodScreenSizeMinSquared; // 0x24
	}
}
