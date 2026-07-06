using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.HgMath
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 36)]
	public struct Triangle3D
	{
		public Vector3 p0;

		public Vector3 p1;

		public Vector3 p2;
	}
}
