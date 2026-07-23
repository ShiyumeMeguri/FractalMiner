using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal interface IFrameSettingsHistoryContainer : IDebugData // TypeDefIndex: 38543
	{
		// Properties
		FrameSettingsHistory frameSettingsHistory { get; set; }
		FrameSettingsOverrideMask frameSettingsMask { get; }
		FrameSettings frameSettings { get; }
		bool hasCustomFrameSettings { get; }
		string panelName { get; }
	}
}
