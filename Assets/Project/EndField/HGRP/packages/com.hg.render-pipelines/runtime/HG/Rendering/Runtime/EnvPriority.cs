using System;

namespace HG.Rendering.Runtime
{
	public enum EnvPriority
	{
		VfxPp = 1000,
		UIAdditive = 600,
		UI = 500,
		CutSceneAdditive = 440,
		CutScene = 420,
		LevelSeq = 410,
		Additive = 400,
		AreaAdditive = 340,
		Area = 320,
		AreaBase = 300,
		Scene = 200,
		Base = 100,
		BlockOut = 0,
		Invalid = 2147483647
	}
}
