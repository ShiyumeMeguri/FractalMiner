using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class TRingBuffer<T> // TypeDefIndex: 37742
		where T : struct
	{
		// Fields
		private int ringBufferStart;
		private int ringBufferEnd;
		private T defaultT;
		private List<T> nodes;
	
		// Properties
		public bool IsEmpty { get => default; }
		public int Capacity { get => default; }
		public int StartIndex { get => default; }
		public int EndIndex { get => default; }
	
		// Constructors
		public TRingBuffer() {} // Dummy constructor
		public TRingBuffer(int size, T t = default) {}
	
		// Methods
		public void Reset() {}
		public int GetNodeCount() => default;
		public T GetNodeAtIndex(int index) => default;
		public void SetNodeAtIndex(int index, ref ref T value) {}
		public int GetPrevIndex(int index) => default;
		public int GetNextIndex(int index) => default;
		public T GetCurrentNode() => default;
		public void SetCurrentNode(ref ref T node) {}
		public void AddNewNode(ref ref T node) {}
		public void DeleteTailNodes(int count = 1 /* Metadata: 0x02303088 */) {}
	}
}
