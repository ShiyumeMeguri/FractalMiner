using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public interface IVersionable<TVersion> // TypeDefIndex: 37516
		where TVersion : struct, IConvertible
	{
		// Properties
		TVersion version { get; set; }
	}
}
