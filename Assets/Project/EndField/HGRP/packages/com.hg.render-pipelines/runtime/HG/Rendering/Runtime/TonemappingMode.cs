using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "G:\\Build\\Release_v1d4\\Windows\\Rel\\Proj\\Packages\\com.hg.render-pipelines\\Runtime\\PostProcessing\\Components\\Tonemapping.cs")]
	public enum TonemappingMode // TypeDefIndex: 38063
	{
		None = 0,
		Neutral = 1,
		ACES = 2,
		Custom = 3,
		External = 4,
		ACES_modified = 5
	}
}
