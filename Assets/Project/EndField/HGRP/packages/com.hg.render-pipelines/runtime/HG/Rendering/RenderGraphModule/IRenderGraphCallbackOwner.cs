using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	internal interface IRenderGraphCallbackOwner // TypeDefIndex: 37420
	{
		// Methods
		void OnRenderPassExecution(HGRenderGraph renderGraph, DynamicArray<AttachDesc> colorAttachments, object camera, void* customPayload, bool renderPassIssued);
	}
}
