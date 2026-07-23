using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	public struct HGRenderGraphParameters // TypeDefIndex: 37415
	{
		// Fields
		public string executionName; // 0x00
		public int currentFrameIndex; // 0x08
		public bool rendererListCulling; // 0x0C
		public ScriptableRenderContext scriptableRenderContext; // 0x10
		public CommandBuffer commandBuffer; // 0x18
		public int executorID; // 0x20
		public int executorFrameIndex; // 0x24
	}
}
