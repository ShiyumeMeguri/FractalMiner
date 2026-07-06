using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 96)]
	internal struct ClothSkeletonData
	{
		[FixedBuffer(typeof(float), 24)]
		public ClothSkeletonData.<skeletonData>e__FixedBuffer skeletonData;

		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 96)]
		public struct <skeletonData>e__FixedBuffer
		{
			public float FixedElementField;
		}
	}
}
