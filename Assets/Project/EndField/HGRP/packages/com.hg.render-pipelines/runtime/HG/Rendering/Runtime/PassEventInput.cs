using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct PassEventInput
	{
		internal HGCamera camera;

		internal HGCamera uiCamera;

		internal HGRenderGraph renderGraph;

		internal HGRenderPipeline hgrp;

		internal bool passSkipped;
	}
}
