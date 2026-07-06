using System;
using HG.Rendering.Runtime.Snow;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGSnowPresettingAsset", menuName = "HGSnow/HGSnowPresettingAsset")]
	public class HGSnowPresettingAsset : ScriptableObject
	{
		public HGSnowPresettingAsset()
		{
		}

		public SnowCommonPreSettingParam snowCommonPreSettingParam;
	}
}
