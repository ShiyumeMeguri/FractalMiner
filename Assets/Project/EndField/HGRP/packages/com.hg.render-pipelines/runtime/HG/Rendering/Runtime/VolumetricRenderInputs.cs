using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct VolumetricRenderInputs // TypeDefIndex: 38750
	{
		// Fields
		public HGCamera hgCamera; // 0x00
		public HGRenderGraphContext context; // 0x08
		public TextureHandle sceneColor; // 0x10
		public TextureHandle sceneDepth; // 0x20
		public TextureHandle sceneDepthToSample; // 0x30
		public TextureHandle historySceneDepth; // 0x40
		public Material volumetricComposeMaterial; // 0x50
		public HGVolumetricCloudSettingParameters volumetricParameters; // 0x58
		public List<IVolumetricRenderObject> volumetricRenderObjects; // 0x60
	}
}
