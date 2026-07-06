using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.HgMath
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 24)]
	public struct Triangle2D
	{
		public Triangle2D(Vector2 _p0, Vector2 _p1, Vector2 _p2)
		{
			// // Triangle2(Vector2, Vector2, Vector2)
			// void Dest::Math::Triangle2::Triangle2(Triangle2 *this, Vector2 v0, Vector2 v1, Vector2 v2, MethodInfo *method)
			// {
			//   this.V0 = v0;
			//   this.V1 = v1;
			//   this.V2 = v2;
			// }
			// 
		}

		public Vector2 p0;

		public Vector2 p1;

		public Vector2 p2;
	}
}
