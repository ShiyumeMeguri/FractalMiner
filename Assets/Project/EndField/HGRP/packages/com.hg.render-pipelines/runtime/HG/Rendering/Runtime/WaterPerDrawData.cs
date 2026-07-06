using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 192)]
	public struct WaterPerDrawData
	{
		public Matrix4x4 viewProjMatrix;

		public Matrix4x4 viewProjInvMatrix;

		public Vector4 param0;

		public Vector4 param1;

		public Vector4 param2;

		public Vector4 param3;
	}
}
