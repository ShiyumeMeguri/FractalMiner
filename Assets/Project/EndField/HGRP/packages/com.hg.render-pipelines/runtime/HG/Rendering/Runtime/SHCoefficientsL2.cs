using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 112)]
	public struct SHCoefficientsL2
	{
		public Vector4 shAr;

		public Vector4 shAg;

		public Vector4 shAb;

		public Vector4 shBr;

		public Vector4 shBg;

		public Vector4 shBb;

		public Vector4 shC;
	}
}
