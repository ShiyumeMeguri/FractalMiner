using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGBoneCapsuleData
	{
		public Transform rootTransform;

		public float capsuleRadius;

		public float capsuleHeight;

		public Vector3 localOffset;

		public Vector3 localRotation;
	}
}
