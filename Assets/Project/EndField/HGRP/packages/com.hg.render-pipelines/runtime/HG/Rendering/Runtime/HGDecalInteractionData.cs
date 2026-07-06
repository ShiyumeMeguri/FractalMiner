using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 144)]
	internal struct HGDecalInteractionData
	{
		public Matrix4x4 _transform;

		public Vector4 _data0;

		public Vector4 _data1;

		public Vector4 _data2;

		public Vector4 _data3;

		public Vector4 _data4;
	}
}
