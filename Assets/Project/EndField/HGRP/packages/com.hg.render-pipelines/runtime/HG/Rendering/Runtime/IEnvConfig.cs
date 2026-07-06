using System;

namespace HG.Rendering.Runtime
{
	public interface IEnvConfig
	{
		// (get) Token: 0x060005D5 RID: 1493
		// (set) Token: 0x060005D6 RID: 1494
		bool active
		{
			get;
			set;
		}

		void Lerp<T>(ref T src, ref T dst, float t) where T : struct, IEnvConfig;
	}
}
