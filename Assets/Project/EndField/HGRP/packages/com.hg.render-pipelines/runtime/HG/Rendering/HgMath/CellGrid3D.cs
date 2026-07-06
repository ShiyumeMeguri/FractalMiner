using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HG.Rendering.HgMath
{
	[DefaultMember("Item")]
	public class CellGrid3D<T>
	{
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x06000348 RID: 840 RVA: 0x000025D0 File Offset: 0x000007D0
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

		// (get) Token: 0x06000349 RID: 841 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x0600034A RID: 842 RVA: 0x000025D0 File Offset: 0x000007D0
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

		// (get) Token: 0x0600034B RID: 843 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x0600034C RID: 844 RVA: 0x000025D0 File Offset: 0x000007D0
		public int DepthCellCount
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

		// (get) Token: 0x0600034D RID: 845 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x0600034E RID: 846 RVA: 0x000025D0 File Offset: 0x000007D0
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

		// (get) Token: 0x0600034F RID: 847 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000350 RID: 848 RVA: 0x000025D0 File Offset: 0x000007D0
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

		// (get) Token: 0x06000351 RID: 849 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000352 RID: 850 RVA: 0x000025D0 File Offset: 0x000007D0
		public Vector3 VolumeMin
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

		// (get) Token: 0x06000353 RID: 851 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000354 RID: 852 RVA: 0x000025D0 File Offset: 0x000007D0
		public Vector3 VolumeMax
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

		// (get) Token: 0x06000355 RID: 853 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000356 RID: 854 RVA: 0x000025D0 File Offset: 0x000007D0
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

		// (get) Token: 0x06000357 RID: 855 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000358 RID: 856 RVA: 0x000025D0 File Offset: 0x000007D0
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

		// (get) Token: 0x06000359 RID: 857 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x0600035A RID: 858 RVA: 0x000025D0 File Offset: 0x000007D0
		public float Depth
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

		// (get) Token: 0x0600035B RID: 859 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600035C RID: 860 RVA: 0x000025D0 File Offset: 0x000007D0
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

		// (get) Token: 0x0600035D RID: 861 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600035E RID: 862 RVA: 0x000025D0 File Offset: 0x000007D0
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

		private CellGrid3D()
		{
		}

		public CellGrid3D(Vector3 volumeMin, Vector3 volumeMax, float cellSize)
		{
		}

		public void Set(float x, float y, float z, T val)
		{
		}

		public void Set(int cellX, int cellY, int cellZ, T val)
		{
		}

		public void GetCellIndex(float x, float y, float z, out int cellX, out int cellY, out int cellZ)
		{
		}

		public Vector3 GetCellPosition(int cellX, int cellY, int cellZ)
		{
			return null;
		}

		public T Get(float x, float y, float z)
		{
			return null;
		}

		public T Get(int cellX, int cellY, int cellZ)
		{
			return null;
		}

		public bool ContainPoint(float x, float y, float z)
		{
			return default(bool);
		}

		public void GetTriangleCoverCellIndex(Vector3 p0, Vector3 p1, Vector3 p2, ref List<int> cellX, ref List<int> cellY, ref List<int> cellZ)
		{
		}

		private T[,,] m_gridData;

		private int minCellX;

		private int minCellY;

		private int minCellZ;

		private int maxCellX;

		private int maxCellY;

		private int maxCellZ;
	}
}
