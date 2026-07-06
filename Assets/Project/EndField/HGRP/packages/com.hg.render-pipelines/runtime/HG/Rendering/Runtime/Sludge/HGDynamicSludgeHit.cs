using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime.Sludge
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
	public struct HGDynamicSludgeHit
	{
		public float time;

		public Vector2 point;

		public float range;
	}
}
