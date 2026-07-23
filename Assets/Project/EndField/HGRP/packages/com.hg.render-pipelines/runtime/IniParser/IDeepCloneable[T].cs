using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace IniParser
{
	public interface IDeepCloneable<T> // TypeDefIndex: 37374
		where T : class
	{
		// Methods
		T DeepClone();
	}
}
