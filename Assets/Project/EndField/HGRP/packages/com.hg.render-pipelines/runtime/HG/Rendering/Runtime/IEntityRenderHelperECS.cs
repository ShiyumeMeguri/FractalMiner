using System;

namespace HG.Rendering.Runtime
{
	public interface IEntityRenderHelperECS
	{
		void Play(string vfxName);

		void Tick(float deltaTime);

		void Stop(string vfxName);

		bool IsAnyPlaying();

		void OnRelease();
	}
}
