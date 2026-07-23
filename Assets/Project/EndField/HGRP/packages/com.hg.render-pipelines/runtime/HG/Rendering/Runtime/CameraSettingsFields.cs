using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Flags]
	public enum CameraSettingsFields // TypeDefIndex: 38660
	{
		none = 0,
		bufferClearColorMode = 2,
		bufferClearBackgroundColorHDR = 4,
		bufferClearClearDepth = 8,
		volumesLayerMask = 16,
		volumesAnchorOverride = 32,
		frustumMode = 64,
		frustumAspect = 128,
		frustumFarClipPlane = 256,
		frustumNearClipPlane = 512,
		frustumFieldOfView = 1024,
		frustumProjectionMatrix = 2048,
		cullingUseOcclusionCulling = 4096,
		cullingCullingMask = 8192,
		cullingInvertFaceCulling = 16384,
		customRenderingSettings = 32768,
		flipYMode = 65536,
		frameSettings = 131072,
		probeLayerMask = 262144
	}
}
