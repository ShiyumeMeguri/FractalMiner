using System;
using System.Runtime.InteropServices;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 20)]
	internal struct DrawIndirectArgBuffer
	{
		internal int indexCountPerInstance;

		internal int instanceCount;

		internal int startIndexLocation;

		internal int baseVertexLocation;

		internal int startInstanceLocation;
	}
}
