using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "F:\\Build\\Release_v1d2\\Windows\\Rel\\Proj\\Packages\\com.hg.render-pipelines\\Runtime\\PostProcessing\\Components\\Tonemapping.cs")]
	public enum TonemappingMode
	{
		None,
		[HideInInspector]
		Neutral,
		[HideInInspector]
		ACES,
		[HideInInspector]
		Custom,
		[HideInInspector]
		External,
		ACES_modified
	}
}
