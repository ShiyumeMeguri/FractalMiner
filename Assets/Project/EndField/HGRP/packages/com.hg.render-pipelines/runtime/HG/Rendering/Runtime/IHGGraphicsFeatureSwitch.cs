using System;

namespace HG.Rendering.Runtime
{
	public interface IHGGraphicsFeatureSwitch
	{
		// (get) Token: 0x060003FA RID: 1018
		bool enabled
		{
			get;
		}

		// (get) Token: 0x060003FB RID: 1019
		bool enabledForCPUCommands
		{
			get;
		}
	}
}
