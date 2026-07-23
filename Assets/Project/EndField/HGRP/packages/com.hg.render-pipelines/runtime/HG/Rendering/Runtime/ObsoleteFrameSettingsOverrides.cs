using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Flags]
	[Obsolete("For data migration")]
	internal enum ObsoleteFrameSettingsOverrides // TypeDefIndex: 38540
	{
		Shadow = 1,
		ContactShadow = 2,
		ShadowMask = 4,
		SSR = 8,
		SSAO = 16,
		SubsurfaceScattering = 32,
		Transmission = 64,
		AtmosphericScaterring = 128,
		Volumetrics = 256,
		ReprojectionForVolumetrics = 512,
		LightLayers = 1024,
		MSAA = 2048,
		ExposureControl = 4096,
		TransparentPrepass = 8192,
		TransparentPostpass = 16384,
		MotionVectors = 32768,
		ObjectMotionVectors = 65536,
		Decals = 131072,
		RoughRefraction = 262144,
		Distortion = 524288,
		Postprocess = 1048576,
		ShaderLitMode = 2097152,
		DepthPrepassWithDeferredRendering = 4194304,
		AsyncCompute = 8388608,
		OpaqueObjects = 16777216,
		TransparentObjects = 33554432,
		LightListAsync = 134217728,
		SSRAsync = 268435456,
		SSAOAsync = 536870912,
		ContactShadowsAsync = 1073741824,
		VolumeVoxelizationsAsync = 2147483647
	}
}
