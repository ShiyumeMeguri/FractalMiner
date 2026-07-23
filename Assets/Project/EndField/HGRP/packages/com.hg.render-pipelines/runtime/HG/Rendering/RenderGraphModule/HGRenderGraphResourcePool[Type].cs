using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	internal abstract class HGRenderGraphResourcePool<Type> : IHGRenderGraphResourcePool // TypeDefIndex: 37457
		where Type : class
	{
		// Fields
		[TupleElementNames(new string[2] {"resource", "frameIndex" })]
		protected Dictionary<int, SortedList<int, ValueTuple<Type, int>>> m_ResourcePool;
		protected List<int> m_RemoveList;
		private List<ValueTuple<int, Type>> m_FrameAllocatedResources;
		protected static int s_CurrentFrameIndex;
		private const int kStaleResourceLifetime = 10; // Metadata: 0x02302D75
	
		// Nested types
		private struct ResourceLogInfo // TypeDefIndex: 37455
		{
			// Fields
			public string name;
			public long size;
		}
	
		// Constructors
		protected HGRenderGraphResourcePool() {}
	
		// Methods
		protected abstract void ReleaseInternalResource(Type res);
		protected abstract string GetResourceName(Type res);
		protected abstract long GetResourceSize(Type res);
		protected abstract string GetResourceTypeName();
		protected abstract int GetSortIndex(Type res);
		public void ReleaseResource(int hash, Type resource, int currentFrameIndex) {}
		public bool TryGetResource(int hashCode, out ref Type resource) {
			resource = default;
			return default;
		}
		public override void Cleanup() {}
		public void RegisterFrameAllocation(int hash, Type value) {}
		public void UnregisterFrameAllocation(int hash, Type value) {}
		public override void CheckFrameAllocation(bool onException, int frameIndex) {}
		public override void LogResources(HGRenderGraphLogger logger) {}
		protected static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex) => default;
	}
}
