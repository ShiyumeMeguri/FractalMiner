using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 80)]
	public struct FWindFieldData
	{
		public Vector4 Param0;

		public Vector4 Param1;

		public Vector4 Param2;

		public Vector4 Param3;

		public Vector4 Param4;
	}
}
