using System;
using System.Runtime.InteropServices;

namespace HG.Rendering.Runtime.TerrainV2
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
	public struct TerrainSubsurfaceParams
	{
		public bool _UseSubsurfaceProfile;

		public float _SubsurfaceCurvatureScale;

		public float _SubsurfaceCurvatureOffset;
	}
}
