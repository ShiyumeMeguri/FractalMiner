using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 96)]
	public struct HGVolumetricComposeData
	{
		public Vector4 _VolumetricZBufferParam;

		public Vector4 _VolumetricZEncodeParam;

		public Matrix4x4 _VolumeMatVP;
	}
}
