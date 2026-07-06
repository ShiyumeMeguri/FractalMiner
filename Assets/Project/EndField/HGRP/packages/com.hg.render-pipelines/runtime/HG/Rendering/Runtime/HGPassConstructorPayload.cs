using System;
using System.Runtime.InteropServices;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
	internal struct HGPassConstructorPayload
	{
		internal float disableAnimateVert;

		internal float useBuiltinConstants;

		internal float enableVerticalOcclusionDepthBias;

		internal float reserved1;
	}
}
