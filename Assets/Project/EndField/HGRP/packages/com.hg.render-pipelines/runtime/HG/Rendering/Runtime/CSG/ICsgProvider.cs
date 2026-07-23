using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.CSG
{
	public interface ICsgProvider // TypeDefIndex: 38798
	{
		// Properties
		IEnumerable<CSGPolygon> Polygons { get; }
	
		// Methods
		void Union(BSP bsp);
		void Intersect(BSP bsp);
		void Subtract(BSP bsp);
		void Clear();
	}
}
