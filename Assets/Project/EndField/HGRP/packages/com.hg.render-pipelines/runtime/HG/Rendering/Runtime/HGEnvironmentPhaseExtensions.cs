using System;
using System.Runtime.CompilerServices;

namespace HG.Rendering.Runtime
{
	public static class HGEnvironmentPhaseExtensions
	{
		[MethodImpl(256)]
		public static void CopyConfig<T>(this T current, ref T src) where T : struct, IEnvConfig
		{
		}

		[MethodImpl(256)]
		public static void LerpConfig<T>(this T current, ref T src, ref T dst, float t) where T : struct, IEnvConfig
		{
		}
	}
}
