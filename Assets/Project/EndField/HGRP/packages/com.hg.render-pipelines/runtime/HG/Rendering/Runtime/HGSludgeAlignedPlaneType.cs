using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public enum HGSludgeAlignedPlaneType
	{
		[InspectorName("X+")]
		X_Pos,
		[InspectorName("X-")]
		X_Neg,
		[InspectorName("Y+")]
		Y_Pos,
		[InspectorName("Y-")]
		Y_Neg,
		[InspectorName("Z+")]
		Z_Pos,
		[InspectorName("Z-")]
		Z_Neg
	}
}
