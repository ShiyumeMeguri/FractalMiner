using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 48)]
	public struct SHCoefficientsL1
	{
		public Vector4 shAr;

		public Vector4 shAg;

		public Vector4 shAb;
	}
}
