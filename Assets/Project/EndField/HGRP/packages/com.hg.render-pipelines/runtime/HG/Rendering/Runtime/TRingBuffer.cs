using System;
using System.Collections.Generic;

namespace HG.Rendering.Runtime
{
	public class TRingBuffer<T> where T : struct
	{
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool IsEmpty
		{
			get
			{
				return default(bool);
			}
		}

		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x00002608 File Offset: 0x00000808
		public int Capacity
		{
			get
			{
				return 0;
			}
		}

		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00002608 File Offset: 0x00000808
		public int StartIndex
		{
			get
			{
				return 0;
			}
		}

		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00002608 File Offset: 0x00000808
		public int EndIndex
		{
			get
			{
				return 0;
			}
		}

		public TRingBuffer(int size, T t = default(T))
		{
		}

		public void Reset()
		{
		}

		public int GetNodeCount()
		{
			return 0;
		}

		public T GetNodeAtIndex(int index)
		{
			return null;
		}

		public void SetNodeAtIndex(int index, ref T value)
		{
		}

		public int GetPrevIndex(int index)
		{
			return 0;
		}

		public int GetNextIndex(int index)
		{
			return 0;
		}

		public T GetCurrentNode()
		{
			return null;
		}

		public void SetCurrentNode(ref T node)
		{
		}

		public void AddNewNode(ref T node)
		{
		}

		public void DeleteTailNodes([MetadataOffset(Offset = "0x01F90D37")] int count = 1)
		{
		}

		private int ringBufferStart;

		private int ringBufferEnd;

		private T defaultT;

		private List<T> nodes;
	}
}
