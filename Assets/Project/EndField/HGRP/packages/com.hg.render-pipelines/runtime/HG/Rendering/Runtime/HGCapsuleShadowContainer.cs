using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGCapsuleShadowContainer // TypeDefIndex: 38680
	{
		// Fields
		public Transform rootTransform; // 0x00
		public float capsuleRadius; // 0x08
		public float capsuleHeight; // 0x0C
		public Vector3 localOffset; // 0x10
		public Vector3 localRotation; // 0x1C
		public float intensityScale; // 0x28
		public bool enabled; // 0x2C
		public bool isFoot; // 0x2D
	}
}
