using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal interface IFrameSettingsHistoryContainer : IDebugData
	{
		// (get) Token: 0x0600131F RID: 4895
		// (set) Token: 0x06001320 RID: 4896
		FrameSettingsHistory frameSettingsHistory
		{
			get;
			set;
		}

		// (get) Token: 0x06001321 RID: 4897
		FrameSettingsOverrideMask frameSettingsMask
		{
			get;
		}

		// (get) Token: 0x06001322 RID: 4898
		FrameSettings frameSettings
		{
			get;
		}

		// (get) Token: 0x06001323 RID: 4899
		bool hasCustomFrameSettings
		{
			get;
		}

		// (get) Token: 0x06001324 RID: 4900
		string panelName
		{
			get;
		}
	}
}
