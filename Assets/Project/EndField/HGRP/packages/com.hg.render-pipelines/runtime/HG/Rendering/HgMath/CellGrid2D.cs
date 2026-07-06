using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HG.Rendering.HgMath
{
	[DefaultMember("Item")]
	public class CellGrid2D<T>
	{
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x0600036A RID: 874 RVA: 0x000025D0 File Offset: 0x000007D0
		public int WidthCellCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// (get) Token: 0x0600036B RID: 875 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x0600036C RID: 876 RVA: 0x000025D0 File Offset: 0x000007D0
		public int HeightCellCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// (get) Token: 0x0600036D RID: 877 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x0600036E RID: 878 RVA: 0x000025D0 File Offset: 0x000007D0
		public float CellSize
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// (get) Token: 0x0600036F RID: 879 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000370 RID: 880 RVA: 0x000025D0 File Offset: 0x000007D0
		public float HalfCellSize
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// (get) Token: 0x06000371 RID: 881 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000372 RID: 882 RVA: 0x000025D0 File Offset: 0x000007D0
		public Vector2 AreaMin
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// (get) Token: 0x06000373 RID: 883 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000374 RID: 884 RVA: 0x000025D0 File Offset: 0x000007D0
		public Vector2 AreaMax
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// (get) Token: 0x06000375 RID: 885 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000376 RID: 886 RVA: 0x000025D0 File Offset: 0x000007D0
		public float Width
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// (get) Token: 0x06000377 RID: 887 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000378 RID: 888 RVA: 0x000025D0 File Offset: 0x000007D0
		public float Height
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// (get) Token: 0x06000379 RID: 889 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600037A RID: 890 RVA: 0x000025D0 File Offset: 0x000007D0
		public T Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// (get) Token: 0x0600037B RID: 891 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600037C RID: 892 RVA: 0x000025D0 File Offset: 0x000007D0
		public T Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private CellGrid2D()
		{
		}

		public CellGrid2D(Vector2 areaMin, Vector2 areaMax, float cellSize)
		{
		}

		public void Set(float x, float y, T val)
		{
		}

		public void Set(int cellX, int cellY, T val)
		{
		}

		public void GetCellIndex(float x, float y, out int cellX, out int cellY)
		{
		}

		public Vector2 GetCellPosition(int cellX, int cellY)
		{
			return null;
		}

		public T Get(float x, float y)
		{
			return null;
		}

		public T Get(int cellX, int cellY)
		{
			return null;
		}

		public bool ContainPoint(float x, float y)
		{
			return default(bool);
		}

		public void GetCellAABB(int cellX, int cellY, out Vector2 min, out Vector2 max)
		{
		}

		public void GetLineSegmentIntersect(Vector2 p0, Vector2 p1, ref List<int> cellX, ref List<int> cellY)
		{
		}

		public void GetTriangleCoverCellIndex(Vector2 p0, Vector2 p1, Vector2 p2, ref List<int> cellX, ref List<int> cellY)
		{
		}

		private T[,] m_gridData;

		private int minCellX;

		private int minCellY;

		private int maxCellX;

		private int maxCellY;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly Color m_debugCellColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly Color m_debugAreaBoundaryColor;
	}
}
