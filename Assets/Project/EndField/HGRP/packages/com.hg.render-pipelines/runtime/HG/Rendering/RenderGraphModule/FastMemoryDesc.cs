using System;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

namespace HG.Rendering.RenderGraphModule
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
	public struct FastMemoryDesc
	{
		public bool inFastMemory;

		public FastMemoryFlags flags;

		public float residencyFraction;
	}
}
