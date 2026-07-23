using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal struct ShadowResult // TypeDefIndex: 37885
	{
		// Fields
		public bool directionalShadowActive; // 0x00
		public TextureHandle directionalShadowResult; // 0x04
		public bool characterShadowActive; // 0x14
		public TextureHandle characterShadowResult; // 0x18
		public bool punctualLightShadowActive; // 0x28
		public TextureHandle punctualLightShadowResult; // 0x2C
	}
}
