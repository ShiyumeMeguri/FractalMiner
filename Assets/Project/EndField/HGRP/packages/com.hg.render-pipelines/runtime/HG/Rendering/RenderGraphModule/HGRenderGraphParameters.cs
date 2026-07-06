using System;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

namespace HG.Rendering.RenderGraphModule
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGRenderGraphParameters
	{
		public string executionName;

		public int currentFrameIndex;

		public bool rendererListCulling;

		public ScriptableRenderContext scriptableRenderContext;

		public CommandBuffer commandBuffer;

		public int executorID;

		public int executorFrameIndex;
	}
}
