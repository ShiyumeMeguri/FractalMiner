using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public enum EnvPriority // TypeDefIndex: 37642
	{
		BlockOut = 0,
		Base = 100,
		Scene = 200,
		AreaBase = 300,
		Area = 320,
		AreaAdditive = 340,
		Additive = 400,
		LevelSeq = 410,
		CutScene = 420,
		CutSceneAdditive = 440,
		UI = 500,
		UIAdditive = 600,
		VfxPp = 1000,
		Invalid = 2147483647
	}
}
