using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal static class MigrationStep // TypeDefIndex: 37521
	{
		// Methods
		public static MigrationStep<TVersion, TTarget> New<TVersion, TTarget>(TVersion version, Action<TTarget> action)
			where TVersion : struct, IConvertible
			where TTarget : class, IVersionable<TVersion> => default;
	}
}
