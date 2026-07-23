using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public enum FrameSettingsField // TypeDefIndex: 38531
	{
		None = -1,
		LitShaderMode = 0,
		DepthPrepassWithDeferredRendering = 1,
		OpaqueObjects = 2,
		TransparentObjects = 3,
		TransparentPrepass = 8,
		TransparentPostpass = 9,
		Decals = 12,
		Refraction = 13,
		Postprocess = 15,
		LowResTransparent = 18,
		ShadowMaps = 20,
		CharacterShadowMaps = 21,
		Shadowmask = 22,
		CapsuleShadow = 23,
		LightLayers = 30,
		MaterialQualityLevel = 66,
		Bloom = 84,
		Vignette = 87,
		ColorGrading = 88,
		Tonemapping = 93
	}
}
