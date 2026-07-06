using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 224)]
	public struct HGInteractionNodeInstanceData
	{
		public Matrix4x4 localToWorld;

		public Matrix4x4 worldToLocal;

		public Matrix4x4 prevLocalToWorld;

		public float radius;

		public float length;

		public float height;

		public float heightScale;

		public float groundHeight;

		public float capsuleLocalHeight;

		public Vector2 padding;
	}
}
