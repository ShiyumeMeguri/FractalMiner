using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HG.Rendering.RenderGraphModule
{
	internal class HGRenderGraphDebugData
	{
		public HGRenderGraphDebugData()
		{
		}

		public void Clear()
		{
		}

		public List<HGRenderGraphDebugData.PassDebugData> passList;

		public List<HGRenderGraphDebugData.ResourceDebugData>[] resourceLists;

		[DebuggerDisplay("PassDebug: {name}")]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct PassDebugData
		{
			public string name;

			public List<int>[] resourceReadLists;

			public List<int>[] resourceWriteLists;

			public bool culled;

			public bool generateDebugData;
		}

		[DebuggerDisplay("ResourceDebug: {name} [{creationPassIndex}:{releasePassIndex}]")]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct ResourceDebugData
		{
			public string name;

			public bool imported;

			public int creationPassIndex;

			public int releasePassIndex;

			public List<int> consumerList;

			public List<int> producerList;
		}
	}
}
