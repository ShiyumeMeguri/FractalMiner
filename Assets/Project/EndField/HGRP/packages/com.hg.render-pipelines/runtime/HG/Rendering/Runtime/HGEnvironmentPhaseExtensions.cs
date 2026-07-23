using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class HGEnvironmentPhaseExtensions // TypeDefIndex: 37637
	{
		// Extension methods
		public static void CopyConfig<T>(this ref ref T current, ref ref T src)
			where T : struct, IEnvConfig {}
		public static void LerpConfig<T>(this ref ref T current, ref ref T src, ref ref T dst, float t)
			where T : struct, IEnvConfig {}
	}
}
