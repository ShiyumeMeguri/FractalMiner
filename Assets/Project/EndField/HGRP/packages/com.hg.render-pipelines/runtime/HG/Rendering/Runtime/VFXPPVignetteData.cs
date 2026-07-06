using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class VFXPPVignetteData : VFXPPData
	{
		public VFXPPVignetteData()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		public Color color;

		[Range(0f, 1f)]
		public float intensity;

		[Range(0f, 1f)]
		public float smoothness;

		public bool rounded;

		public bool blink;
	}
}
