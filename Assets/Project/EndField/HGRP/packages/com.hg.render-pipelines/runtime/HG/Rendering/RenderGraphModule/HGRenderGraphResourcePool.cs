using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HG.Rendering.RenderGraphModule
{
	internal abstract class HGRenderGraphResourcePool<Type> : IHGRenderGraphResourcePool where Type : class
	{
		protected HGRenderGraphResourcePool()
		{
		}

		protected abstract void ReleaseInternalResource(Type res);

		protected abstract string GetResourceName(Type res);

		protected abstract long GetResourceSize(Type res);

		protected abstract string GetResourceTypeName();

		protected abstract int GetSortIndex(Type res);

		public void ReleaseResource(int hash, Type resource, int currentFrameIndex)
		{
		}

		public bool TryGetResource(int hashCode, out Type resource)
		{
			return default(bool);
		}

		public override void Cleanup()
		{
		}

		public void RegisterFrameAllocation(int hash, Type value)
		{
		}

		public void UnregisterFrameAllocation(int hash, Type value)
		{
		}

		public override void CheckFrameAllocation(bool onException, int frameIndex)
		{
		}

		public override void LogResources(HGRenderGraphLogger logger)
		{
		}

		protected static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex)
		{
			return default(bool);
		}

		[TupleElementNames(new string[] { "resource", "frameIndex" })]
		protected Dictionary<int, SortedList<int, ValueTuple<Type, int>>> m_ResourcePool;

		protected List<int> m_RemoveList;

		private List<ValueTuple<int, Type>> m_FrameAllocatedResources;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		protected static int s_CurrentFrameIndex;

		private const int kStaleResourceLifetime = 10;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct ResourceLogInfo
		{
			public string name;

			public long size;
		}
	}
}
