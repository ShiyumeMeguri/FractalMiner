using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal struct PassEventInput // TypeDefIndex: 38510
	{
		// Fields
		internal HGCamera camera; // 0x00
		internal HGCamera uiCamera; // 0x08
		internal HGRenderGraph renderGraph; // 0x10
		internal HGRenderPipeline hgrp; // 0x18
		internal bool passSkipped; // 0x20
	}
}
