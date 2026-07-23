using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("Native RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal sealed class HGRenderGraphPassNative<PassData> : HGRenderGraphPass<PassData> // TypeDefIndex: 37448
		where PassData : class, new()
	{
		// Constructors
		public HGRenderGraphPassNative() {}
	
		// Methods
		internal override bool DepthRequiredIfMRT() => default;
		protected override void BeginRenderPassInternal(HGRenderGraph renderGraph) {}
		protected override void EndRenderPassInternal(HGRenderGraph renderGraph) {}
		protected override void BeginSubpassInternal(int subpassIndex, HGRenderGraph renderGraph) {}
		protected override void EndSubpassInternal(int subpassIndex, HGRenderGraph renderGraph) {}
		private static RTHandle ConfigureNativeAttachDesc(AttachDesc attachDesc, out AttachmentDescriptor nativeAttachDesc, HGRenderGraphResourceRegistry resourceRegistry) {
			nativeAttachDesc = default;
			return default;
		}
		private static void ConfigureViewportSize(RTHandle rt, TextureHandle handle, HGRenderGraph renderGraph, ref Vector2Int viewportSize) {}
		public override void Release(HGRenderGraphObjectPool pool) {}
	}
}
