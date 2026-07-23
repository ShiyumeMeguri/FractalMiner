using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("Regular RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal sealed class HGRenderGraphPassRegular<PassData> : HGRenderGraphPass<PassData> // TypeDefIndex: 37447
		where PassData : class, new()
	{
		// Constructors
		public HGRenderGraphPassRegular() {}
	
		// Methods
		internal override bool DepthRequiredIfMRT() => default;
		protected override void BeginRenderPassInternal(HGRenderGraph renderGraph) {}
		protected override void EndRenderPassInternal(HGRenderGraph renderGraph) {}
		protected override void BeginSubpassInternal(int subpassIndex, HGRenderGraph renderGraph) {}
		protected override void EndSubpassInternal(int subpassIndex, HGRenderGraph renderGraph) {}
		private static void SetupRenderTargets(ref NativeArray<AttachDesc> colorAttachments, ref AttachDesc depthAttachment, HGRenderGraph renderGraph) {}
		public override void Release(HGRenderGraphObjectPool pool) {}
	}
}
