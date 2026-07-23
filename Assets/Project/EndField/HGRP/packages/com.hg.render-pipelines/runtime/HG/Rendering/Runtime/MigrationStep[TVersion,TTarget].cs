using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct MigrationStep<TVersion, TTarget> : IEquatable<HG.Rendering.Runtime.MigrationStep<TVersion, TTarget>> // TypeDefIndex: 37522
		where TVersion : struct, IConvertible
		where TTarget : class, IVersionable<TVersion>
	{
		// Fields
		private readonly Action<TTarget> m_MigrationAction;
		public readonly TVersion Version;
	
		// Constructors
		public MigrationStep(TVersion version, Action<TTarget> action) {
			m_MigrationAction = default;
			Version = default;
		}
	
		// Methods
		public void Migrate(TTarget target) {}
		public bool Equals(MigrationStep<TVersion, TTarget> other) => default;
	}
}
