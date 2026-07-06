using System;
using System.Runtime.InteropServices;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
	public struct LRUNode
	{
		public int key;

		public int prev;

		public int next;
	}
}
