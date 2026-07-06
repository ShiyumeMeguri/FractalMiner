using System;

namespace HG.Rendering.Runtime
{
	public enum LightShaftPassIndex
	{
		DownSample,
		OcclusionTermDownSample,
		RadialBlur,
		OcclusionTerm,
		ApplyLightShaft
	}
}
