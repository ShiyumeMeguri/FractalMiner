using System;
using System.Runtime.InteropServices;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
	internal struct SettingConfigChangeData
	{
		internal HGDeviceType deviceType;

		internal int settingTier;

		internal string featureName;
	}
}
