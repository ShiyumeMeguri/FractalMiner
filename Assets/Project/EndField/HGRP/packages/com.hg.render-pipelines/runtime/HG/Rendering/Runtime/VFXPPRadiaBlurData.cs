using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class VFXPPRadiaBlurData : VFXPPData
	{
		public VFXPPRadiaBlurData()
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

		[Range(0f, 0.3f)]
		public float intensity;

		public bool useAsCenterPosition;

		public bool averageSteps;

		[Range(1f, 2f)]
		public float power;
	}
}
