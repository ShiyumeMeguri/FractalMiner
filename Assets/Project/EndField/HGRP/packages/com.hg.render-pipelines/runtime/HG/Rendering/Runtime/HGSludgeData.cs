using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGSludgeData
	{
		public Vector3 originW;

		public Vector3 up;

		public Vector3 right;

		public Vector3 forward;

		public uint sludgeSize;

		public float thickness;

		public float sizeY;

		public float rebornTime;

		public float rebornAnimTime;

		public float disappearTime;

		public Bounds boundsW;

		public uint encodedClipPlane0;

		public uint encodedClipPlane1;

		public Material sludgeMaterial;

		public Texture2D heightmap;

		public NativeArray<SludgeNodeData> nodeData;
	}
}
