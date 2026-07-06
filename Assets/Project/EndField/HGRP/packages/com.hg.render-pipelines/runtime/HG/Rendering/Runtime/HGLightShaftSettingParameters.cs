using System;

namespace HG.Rendering.Runtime
{
	public class HGLightShaftSettingParameters
	{
		public HGLightShaftSettingParameters()
		{
		}

		public const string FEATURE_NAME = "LightShaft";

		public readonly SettingParameter<bool> enableLightShaft;

		public readonly SettingParameter<int> lightShaftSampleNum;

		public readonly SettingParameter<float> lightShaftDownSampleFactor;

		public readonly SettingParameter<int> lightShaftBlurPassCount;
	}
}
