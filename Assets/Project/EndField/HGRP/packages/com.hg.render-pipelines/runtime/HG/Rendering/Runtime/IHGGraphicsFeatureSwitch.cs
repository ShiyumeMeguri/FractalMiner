using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public interface IHGGraphicsFeatureSwitch // TypeDefIndex: 37530
	{
		// Properties
		bool enabled { get; }
		bool enabledForCPUCommands { get; }
	}
}
