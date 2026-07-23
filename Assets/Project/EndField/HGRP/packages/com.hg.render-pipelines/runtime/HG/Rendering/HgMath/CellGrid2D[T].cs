using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.HgMath
{
	public class CellGrid2D<T> // TypeDefIndex: 37479
	{
		// Fields
		private T[,] m_gridData;
		private int minCellX;
		private int minCellY;
		private int maxCellX;
		private int maxCellY;
		private static readonly UnityEngine.Color m_debugCellColor;
		private static readonly UnityEngine.Color m_debugAreaBoundaryColor;
	
		// Properties
		public int WidthCellCount { get; protected set; }
		public int HeightCellCount { get; protected set; }
		public float CellSize { get; protected set; }
		public float HalfCellSize { get; protected set; }
		public Vector2 AreaMin { get; protected set; }
		public Vector2 AreaMax { get; protected set; }
		public float Width { get; protected set; }
		public float Height { get; protected set; }
		public T this[int cellX, int cellY] { get => default; set {} }
		public T this[float x, float y] { get => default; set {} }
	
		// Constructors
		private CellGrid2D() {}
		public CellGrid2D(Vector2 areaMin, Vector2 areaMax, float cellSize) {}
		static CellGrid2D() {}
	
		// Methods
		public void Set(float x, float y, T val) {}
		public void Set(int cellX, int cellY, T val) {}
		public void GetCellIndex(float x, float y, out int cellX, out int cellY) {
			cellX = default;
			cellY = default;
		}
		public Vector2 GetCellPosition(int cellX, int cellY) => default;
		public T Get(float x, float y) => default;
		public T Get(int cellX, int cellY) => default;
		public bool ContainPoint(float x, float y) => default;
		public void GetCellAABB(int cellX, int cellY, out Vector2 min, out Vector2 max) {
			min = default;
			max = default;
		}
		public void GetLineSegmentIntersect(Vector2 p0, Vector2 p1, ref List<int> cellX, ref List<int> cellY) {}
		public void GetTriangleCoverCellIndex(Vector2 p0, Vector2 p1, Vector2 p2, ref List<int> cellX, ref List<int> cellY) {}
	}
}
