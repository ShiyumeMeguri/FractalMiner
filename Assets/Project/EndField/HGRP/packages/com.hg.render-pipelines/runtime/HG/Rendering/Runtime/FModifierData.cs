using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 48)]
	public struct FModifierData
	{
		public Vector3 Position;

		public float Radius;

		public Vector3 Payload;

		public int Mode;

		public int Operation;

		public float FalloffExp;

		public Vector2 Padding;
	}
}
