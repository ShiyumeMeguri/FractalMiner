using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGFoliageInteractiveMeshMatrixes
	{
		public Mesh mesh;

		public NativeList<Matrix4x4> matrixs;
	}
}
