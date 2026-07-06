using System;
using System.Runtime.InteropServices;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MigrationDescription<TVersion, TTarget> where TVersion : struct, IConvertible where TTarget : class, IVersionable<TVersion>
	{
		public MigrationDescription(params MigrationStep<TVersion, TTarget>[] steps)
		{
		}

		public bool Migrate(TTarget target)
		{
			return default(bool);
		}

		public void ExecuteStep(TTarget target, TVersion stepVersion)
		{
		}

		private static bool Equals(TVersion l, TVersion r)
		{
			return default(bool);
		}

		private static int Compare(TVersion l, TVersion r)
		{
			return 0;
		}

		private readonly MigrationStep<TVersion, TTarget>[] Steps;
	}
}
