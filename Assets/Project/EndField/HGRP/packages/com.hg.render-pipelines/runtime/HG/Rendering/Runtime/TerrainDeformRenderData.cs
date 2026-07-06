using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 60)]
	internal struct TerrainDeformRenderData
	{
		public TerrainDeformConstData constData;

		public Vector3 curCenter;
	}
}
