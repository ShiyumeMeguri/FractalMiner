using System;
using System.Runtime.InteropServices;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
	public struct GeneralSystemAttributes
	{
		internal int particleCapacity;

		internal int instanceCapacity;

		internal int particleAttribSize;

		internal int padding0;
	}
}
