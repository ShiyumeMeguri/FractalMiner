using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("RayTracing/RayTracingReflection", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public class RayTracingReflectionVolume : VolumeComponent
	{
		public RayTracingReflectionVolume()
		{
		}

		public FloatParameter enable;

		public RayTracingReflectionModeParameter mode;
	}
}
