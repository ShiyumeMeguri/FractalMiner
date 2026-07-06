using System;
using System.Collections.Generic;

namespace HG.Rendering.Runtime.CSG
{
	public interface ICsgProvider
	{
		// (get) Token: 0x06001C61 RID: 7265
		IEnumerable<CSGPolygon> Polygons
		{
			get;
		}

		void Union(BSP bsp);

		void Intersect(BSP bsp);

		void Subtract(BSP bsp);

		void Clear();
	}
}
