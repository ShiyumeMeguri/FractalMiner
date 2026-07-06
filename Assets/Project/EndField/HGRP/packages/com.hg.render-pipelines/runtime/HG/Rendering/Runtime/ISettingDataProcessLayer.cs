using System;

namespace HG.Rendering.Runtime
{
	internal interface ISettingDataProcessLayer
	{
		SettingDataProcessResult ProcessSettingDataChange(SettingConfigChange input, ref SettingConfigChangeData newConfigData, ref SettingConfigChangeData oldConfigData);
	}
}
