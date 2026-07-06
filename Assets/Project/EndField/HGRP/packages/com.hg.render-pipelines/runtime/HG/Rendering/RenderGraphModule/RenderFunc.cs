using System;

namespace HG.Rendering.RenderGraphModule
{
	// (Invoke) Token: 0x0600013E RID: 318
	public delegate void RenderFunc<PassData>(PassData data, HGRenderGraphContext renderGraphContext) where PassData : class, new();
}
