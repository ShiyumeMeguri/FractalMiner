using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
	public struct PerInstanceData
	{
		public Vector4 position;

		public int emitRate;

		public int padding0;

		public int padding1;

		public int padding2;
	}
}
