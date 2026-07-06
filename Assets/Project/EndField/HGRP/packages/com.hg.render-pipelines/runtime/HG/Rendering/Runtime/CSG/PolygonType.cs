using System;

namespace HG.Rendering.Runtime.CSG
{
	[Flags]
	[Serializable]
	public enum PolygonType
	{
		Coplanar = 0,
		Front = 1,
		Back = 2,
		Spanning = 3
	}
}
