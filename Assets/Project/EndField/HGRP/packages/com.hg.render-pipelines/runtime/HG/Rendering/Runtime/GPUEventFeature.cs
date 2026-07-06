using System;
using System.Runtime.InteropServices;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GPUEventFeature
	{
		internal Guid guid;

		internal Nullable<GPUEventSender> senderData;
	}
}
