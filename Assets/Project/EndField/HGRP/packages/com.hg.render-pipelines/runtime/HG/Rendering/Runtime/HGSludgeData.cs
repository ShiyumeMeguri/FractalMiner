using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct HGSludgeData // TypeDefIndex: 37680
	{
		// Fields
		public Vector3 originW; // 0x00
		public Vector3 up; // 0x0C
		public Vector3 right; // 0x18
		public Vector3 forward; // 0x24
		public uint sludgeSize; // 0x30
		public float thickness; // 0x34
		public float sizeY; // 0x38
		public float rebornTime; // 0x3C
		public float rebornAnimTime; // 0x40
		public float disappearTime; // 0x44
		public Bounds boundsW; // 0x48
		public uint encodedClipPlane0; // 0x60
		public uint encodedClipPlane1; // 0x64
		public Material sludgeMaterial; // 0x68
		public Texture2D heightmap; // 0x70
		public NativeArray<SludgeNodeData> nodeData; // 0x78
	}
}
