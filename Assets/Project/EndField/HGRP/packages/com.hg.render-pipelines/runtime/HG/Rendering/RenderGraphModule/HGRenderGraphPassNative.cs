using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("Native RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal sealed class HGRenderGraphPassNative<PassData> : HGRenderGraphPass<PassData> where PassData : class, new()
	{
		public HGRenderGraphPassNative()
		{
		}

		internal override bool DepthRequiredIfMRT()
		{
			return default(bool);
		}

		protected override void BeginRenderPassInternal(HGRenderGraph renderGraph)
		{
		}

		protected override void EndRenderPassInternal(HGRenderGraph renderGraph)
		{
		}

		protected override void BeginSubpassInternal(int subpassIndex, HGRenderGraph renderGraph)
		{
		}

		protected override void EndSubpassInternal(int subpassIndex, HGRenderGraph renderGraph)
		{
		}

		private static RTHandle ConfigureNativeAttachDesc(AttachDesc attachDesc, out AttachmentDescriptor nativeAttachDesc, HGRenderGraphResourceRegistry resourceRegistry)
		{
			return null;
		}

		private static void ConfigureViewportSize(RTHandle rt, TextureHandle handle, HGRenderGraph renderGraph, ref Vector2Int viewportSize)
		{
		}

		public override void Release(HGRenderGraphObjectPool pool)
		{
		}
	}
}
