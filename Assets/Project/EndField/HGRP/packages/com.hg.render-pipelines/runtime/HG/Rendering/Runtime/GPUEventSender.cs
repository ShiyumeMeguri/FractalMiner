using System;
using System.Runtime.InteropServices;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
	public struct GPUEventSender
	{
		internal int eventBufferCount;

		internal int eventBufferStride;
	}
}
