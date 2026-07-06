using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime.Sludge
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 108)]
	public struct HGDynamicSludgePassData
	{
		public Vector4 atlasTillingScale;

		public Matrix4x4 matrix4X4;

		public float rebornTime;

		public float rebornAnimTime;

		public bool recentHit;

		public HGDynamicSludgeHit recentHitInfo;
	}
}
