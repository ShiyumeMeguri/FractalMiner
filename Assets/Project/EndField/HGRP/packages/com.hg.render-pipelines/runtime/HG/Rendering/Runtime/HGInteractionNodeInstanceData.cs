using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct HGInteractionNodeInstanceData // TypeDefIndex: 37750
	{
		// Fields
		public Matrix4x4 localToWorld; // 0x00
		public Matrix4x4 worldToLocal; // 0x40
		public Matrix4x4 prevLocalToWorld; // 0x80
		public float radius; // 0xC0
		public float length; // 0xC4
		public float height; // 0xC8
		public float heightScale; // 0xCC
		public float groundHeight; // 0xD0
		public float capsuleLocalHeight; // 0xD4
		public Vector2 padding; // 0xD8
	}
}
