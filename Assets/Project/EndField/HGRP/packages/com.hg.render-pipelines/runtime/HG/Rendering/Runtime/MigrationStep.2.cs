using System;
using System.Runtime.InteropServices;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MigrationStep<TVersion, TTarget> : IEquatable<MigrationStep<TVersion, TTarget>> where TVersion : struct, IConvertible where TTarget : class, IVersionable<TVersion>
	{
		public MigrationStep(TVersion version, Action<TTarget> action)
		{
		}

		public void Migrate(TTarget target)
		{
		}

		public bool Equals(MigrationStep<TVersion, TTarget> other)
		{
			return default(bool);
		}

		private readonly Action<TTarget> m_MigrationAction;

		public readonly TVersion Version;
	}
}
