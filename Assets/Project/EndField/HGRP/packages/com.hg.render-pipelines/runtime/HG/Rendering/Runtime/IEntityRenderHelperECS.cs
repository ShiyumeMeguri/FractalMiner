using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public interface IEntityRenderHelperECS // TypeDefIndex: 37718
	{
		// Methods
		void Play(string vfxName);
		void Tick(float deltaTime);
		void Stop(string vfxName);
		bool IsAnyPlaying();
		void OnRelease();
	}
}
