using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 60)]
	internal struct ShadowResult
	{
		public bool directionalShadowActive;

		public TextureHandle directionalShadowResult;

		public bool characterShadowActive;

		public TextureHandle characterShadowResult;

		public bool punctualLightShadowActive;

		public TextureHandle punctualLightShadowResult;
	}
}
