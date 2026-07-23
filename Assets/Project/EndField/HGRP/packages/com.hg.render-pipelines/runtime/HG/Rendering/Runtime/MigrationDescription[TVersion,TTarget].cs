using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct MigrationDescription<TVersion, TTarget> // TypeDefIndex: 37520
		where TVersion : struct, IConvertible
		where TTarget : class, IVersionable<TVersion>
	{
		// Fields
		private readonly MigrationStep<TVersion, TTarget>[] Steps;
	
		// Constructors
		public MigrationDescription(params MigrationStep<TVersion, TTarget>[] steps) {
			Steps = default;
		}
	
		// Methods
		public bool Migrate(TTarget target) => default;
		public void ExecuteStep(TTarget target, TVersion stepVersion) {}
		private static bool Equals(TVersion l, TVersion r) => default;
		private static int Compare(TVersion l, TVersion r) => default;
	}
}
