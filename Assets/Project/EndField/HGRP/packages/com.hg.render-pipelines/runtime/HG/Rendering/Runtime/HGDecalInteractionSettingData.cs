using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
	internal struct HGDecalInteractionSettingData
	{
		public float _decalNodeWidth;

		public float _decalNodeLength;

		public float _decalNodeHeadLength;

		public float _decalNodeOffset;

		public float _nodeDistanceThreshold;

		public float _EdgeFadeRatio;

		public Vector2 _padding;
	}
}
