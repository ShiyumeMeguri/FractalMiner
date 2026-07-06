using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 80)]
	public struct FLocalLightData
	{
		public Vector3 Position;

		public float Radius;

		public Vector3 Color;

		public float InvRadius;

		public Vector3 Direction;

		public int bSpotLight;

		public Vector2 SpotAngles;

		public int bInverseSquared;

		public float FalloffExponent;

		public float ShadowIntensity;

		public float MsScatteringFactor;

		public float MsExtinctionFactor;

		public float Padding;
	}
}
