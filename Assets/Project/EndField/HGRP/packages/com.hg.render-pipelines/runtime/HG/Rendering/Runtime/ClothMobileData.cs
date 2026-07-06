using System;
using System.Runtime.InteropServices;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
	public struct ClothMobileData
	{
		public uint clothHash;

		public float windIntensityScale;

		public float windSoftFactor;

		public float transformScale;
	}
}
