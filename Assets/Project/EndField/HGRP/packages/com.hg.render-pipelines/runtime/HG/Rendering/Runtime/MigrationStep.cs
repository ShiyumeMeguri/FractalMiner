using System;

namespace HG.Rendering.Runtime
{
	internal static class MigrationStep
	{
		public static MigrationStep<TVersion, TTarget> New<TVersion, TTarget>(TVersion version, Action<TTarget> action) where TVersion : struct, IConvertible where TTarget : class, IVersionable<TVersion>
		{
			return null;
		}
	}
}
