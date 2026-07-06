using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 20)]
	public struct InputRippleData
	{
		public Vector2 positionXZ;

		public float size;

		public float distanceXZ;

		public float priority;
	}
}
