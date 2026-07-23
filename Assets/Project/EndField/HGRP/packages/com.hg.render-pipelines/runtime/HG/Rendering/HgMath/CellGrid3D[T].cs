using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.HgMath
{
	public class CellGrid3D<T> // TypeDefIndex: 37478
	{
		// Fields
		private T[,,] m_gridData;
		private int minCellX;
		private int minCellY;
		private int minCellZ;
		private int maxCellX;
		private int maxCellY;
		private int maxCellZ;
	
		// Properties
		public int WidthCellCount { get; protected set; }
		public int HeightCellCount { get; protected set; }
		public int DepthCellCount { get; protected set; }
		public float CellSize { get; protected set; }
		public float HalfCellSize { get; protected set; }
		public Vector3 VolumeMin { get; protected set; }
		public Vector3 VolumeMax { get; protected set; }
		public float Width { get; protected set; }
		public float Height { get; protected set; }
		public float Depth { get; protected set; }
		public T this[int cellX, int cellY, int cellZ] { get => default; set {} }
		public T this[float x, float y, float z] { get => default; set {} }
	
		// Constructors
		private CellGrid3D() {}
		public CellGrid3D(Vector3 volumeMin, Vector3 volumeMax, float cellSize) {}
	
		// Methods
		public void Set(float x, float y, float z, T val) {}
		public void Set(int cellX, int cellY, int cellZ, T val) {}
		public void GetCellIndex(float x, float y, float z, out int cellX, out int cellY, out int cellZ) {
			cellX = default;
			cellY = default;
			cellZ = default;
		}
		public Vector3 GetCellPosition(int cellX, int cellY, int cellZ) => default;
		public T Get(float x, float y, float z) => default;
		public T Get(int cellX, int cellY, int cellZ) => default;
		public bool ContainPoint(float x, float y, float z) => default;
		public void GetTriangleCoverCellIndex(Vector3 p0, Vector3 p1, Vector3 p2, ref List<int> cellX, ref List<int> cellY, ref List<int> cellZ) {}
	}
}
