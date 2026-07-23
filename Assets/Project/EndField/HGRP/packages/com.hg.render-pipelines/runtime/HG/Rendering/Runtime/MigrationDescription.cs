using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal static class MigrationDescription // TypeDefIndex: 37518
	{
		// Methods
		public static T LastVersion<T>()
			where T : struct, IConvertible => default;
		public static MigrationDescription<TVersion, TTarget> New<TVersion, TTarget>(params MigrationStep<TVersion, TTarget>[] steps)
			where TVersion : struct, IConvertible
			where TTarget : class, IVersionable<TVersion> => default;
	}
}
