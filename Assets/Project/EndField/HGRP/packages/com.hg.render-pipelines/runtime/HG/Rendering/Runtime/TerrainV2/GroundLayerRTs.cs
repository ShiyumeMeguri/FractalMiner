using System;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime.TerrainV2
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct GroundLayerRTs
	{
		public RTHandle groundLayerBaseRT;

		public RTHandle groundLayerNormalRT;

		public RTHandle groundLayerWetRT;

		public RTHandle groundLayerHeightRT;

		public RTHandle defaultRT;
	}
}
