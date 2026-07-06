using System;
using System.Diagnostics;
using Unity.Collections;

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("Regular RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal sealed class HGRenderGraphPassRegular<PassData> : HGRenderGraphPass<PassData> where PassData : class, new()
	{
		public HGRenderGraphPassRegular()
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

		private static void SetupRenderTargets(ref NativeArray<AttachDesc> colorAttachments, ref AttachDesc depthAttachment, HGRenderGraph renderGraph)
		{
		}

		public override void Release(HGRenderGraphObjectPool pool)
		{
		}
	}
}
