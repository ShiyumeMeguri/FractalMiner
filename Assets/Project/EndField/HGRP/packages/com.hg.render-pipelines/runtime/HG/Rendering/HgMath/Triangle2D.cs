using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.HgMath
{
	[Serializable]
	public struct Triangle2D // TypeDefIndex: 37476
	{
		// Fields
		public Vector2 p0; // 0x00
		public Vector2 p1; // 0x08
		public Vector2 p2; // 0x10
	
		// Constructors
		public Triangle2D(Vector2 _p0, Vector2 _p1, Vector2 _p2) {
			p0 = default;
			p1 = default;
			p2 = default;
		} // 0x0000000184D8C0D0-0x0000000184D8C0E0
		// Triangle2(Vector2, Vector2, Vector2)
		void Dest::Math::Triangle2::Triangle2(Triangle2 *this, Vector2 v0, Vector2 v1, Vector2 v2, MethodInfo *method)
		{
		  this->V0 = v0;
		  this->V1 = v1;
		  this->V2 = v2;
		}
		
	}
}
