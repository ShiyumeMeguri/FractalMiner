using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct FLocalLightData // TypeDefIndex: 38724
	{
		// Fields
		public Vector3 Position; // 0x00
		public float Radius; // 0x0C
		public Vector3 Color; // 0x10
		public float InvRadius; // 0x1C
		public Vector3 Direction; // 0x20
		public int bSpotLight; // 0x2C
		public Vector2 SpotAngles; // 0x30
		public int bInverseSquared; // 0x38
		public float FalloffExponent; // 0x3C
		public float ShadowIntensity; // 0x40
		public float MsScatteringFactor; // 0x44
		public float MsExtinctionFactor; // 0x48
		public float Padding; // 0x4C
	}
}
