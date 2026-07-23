using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public interface IEnvConfig // TypeDefIndex: 37636
	{
		// Properties
		bool active { get; set; }
	
		// Methods
		void Lerp<T>(ref ref T src, ref ref T dst, float t)
			where T : struct, IEnvConfig;
	}
}
