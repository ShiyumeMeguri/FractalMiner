using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public enum HGRenderPath
	{
		[InspectorName("Forward")]
		Forward,
		[InspectorName("UI")]
		UI,
		[InspectorName("3D UI")]
		UI3D,
		[InspectorName("Deferred")]
		Deferred
	}
}
