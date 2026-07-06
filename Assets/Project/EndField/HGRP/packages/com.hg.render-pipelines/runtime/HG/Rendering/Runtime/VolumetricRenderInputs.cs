using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct VolumetricRenderInputs
	{
		public HGCamera hgCamera;

		public HGRenderGraphContext context;

		public TextureHandle sceneColor;

		public TextureHandle sceneDepth;

		public TextureHandle sceneDepthToSample;

		public TextureHandle historySceneDepth;

		public Material volumetricComposeMaterial;

		public HGVolumetricCloudSettingParameters volumetricParameters;

		public List<IVolumetricRenderObject> volumetricRenderObjects;
	}
}
