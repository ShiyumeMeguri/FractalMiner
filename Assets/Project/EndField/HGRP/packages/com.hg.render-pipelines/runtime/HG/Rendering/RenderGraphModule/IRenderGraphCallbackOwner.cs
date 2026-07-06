using System;
using UnityEngine.Rendering;

namespace HG.Rendering.RenderGraphModule
{
	internal interface IRenderGraphCallbackOwner
	{
		unsafe void OnRenderPassExecution(HGRenderGraph renderGraph, DynamicArray<AttachDesc> colorAttachments, object camera, void* customPayload, bool renderPassIssued);
	}
}
