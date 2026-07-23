using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Flags]
	public enum LightLayerEnum // TypeDefIndex: 37791
	{
		Nothing = 0,
		LightLayerDefault = 1,
		LightLayer1 = 2,
		LightLayer2 = 4,
		LightLayer3 = 8,
		LightLayer4 = 16,
		LightLayer5 = 32,
		LightLayer6 = 64,
		LightLayer7 = 128,
		Everything = 255
	}
}
