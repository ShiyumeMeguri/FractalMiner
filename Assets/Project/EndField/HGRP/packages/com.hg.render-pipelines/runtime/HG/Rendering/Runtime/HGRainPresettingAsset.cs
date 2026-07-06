using System;
using HG.Rendering.Runtime.Rain;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGRainPresettingAsset", menuName = "HGRain/HGRainPresettingAsset")]
	public class HGRainPresettingAsset : ScriptableObject
	{
		public HGRainPresettingAsset()
		{
		}

		public RainCommonPreSettingParam rainCommonPreSettingParam;
	}
}
