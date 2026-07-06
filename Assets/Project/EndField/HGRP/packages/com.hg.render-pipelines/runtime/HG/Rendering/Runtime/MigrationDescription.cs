using System;

namespace HG.Rendering.Runtime
{
	internal static class MigrationDescription
	{
		public static T LastVersion<T>() where T : struct, IConvertible
		{
			return null;
		}

		public static MigrationDescription<TVersion, TTarget> New<TVersion, TTarget>(params MigrationStep<TVersion, TTarget>[] steps) where TVersion : struct, IConvertible where TTarget : class, IVersionable<TVersion>
		{
			return null;
		}
	}
}
