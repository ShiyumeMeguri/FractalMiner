using System;
using System.Runtime.InteropServices;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct OptionalSystemFeatures
	{
		internal Nullable<SceneRTFeature> sceneRTFeature;

		internal Nullable<GPUEventFeature> gpuEventFeature;
	}
}
