using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 300)]
	public struct HGWindParamDataCache
	{
		public Vector4 _WindGlobalParams0;

		[FixedBuffer(typeof(float), 16)]
		public HGWindParamDataCache.<_WindMotorParams0>e__FixedBuffer _WindMotorParams0;

		[FixedBuffer(typeof(float), 16)]
		public HGWindParamDataCache.<_WindMotorParams1>e__FixedBuffer _WindMotorParams1;

		[FixedBuffer(typeof(float), 16)]
		public HGWindParamDataCache.<_WindMotorParams2>e__FixedBuffer _WindMotorParams2;

		[FixedBuffer(typeof(float), 16)]
		public HGWindParamDataCache.<_WindMotorParams3>e__FixedBuffer _WindMotorParams3;

		public Vector4 _WindMotorCount;

		public float _WindLeafFadeDistance;

		public float _WindLeafFadeRange;

		public byte _WindMainQuaility;

		public byte _WindMotorQuaility;

		[UnsafeValueType]
		[CompilerGenerated]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
		public struct <_WindMotorParams0>e__FixedBuffer
		{
			public float FixedElementField;
		}

		[UnsafeValueType]
		[CompilerGenerated]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
		public struct <_WindMotorParams1>e__FixedBuffer
		{
			public float FixedElementField;
		}

		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
		public struct <_WindMotorParams2>e__FixedBuffer
		{
			public float FixedElementField;
		}

		[UnsafeValueType]
		[CompilerGenerated]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
		public struct <_WindMotorParams3>e__FixedBuffer
		{
			public float FixedElementField;
		}
	}
}
