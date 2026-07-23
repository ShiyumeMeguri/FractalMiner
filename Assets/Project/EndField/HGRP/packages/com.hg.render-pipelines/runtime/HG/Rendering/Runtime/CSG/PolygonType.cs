using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.CSG
{
	[Serializable]
	[Flags]
	public enum PolygonType // TypeDefIndex: 38810
	{
		Coplanar = 0,
		Front = 1,
		Back = 2,
		Spanning = 3
	}
}
