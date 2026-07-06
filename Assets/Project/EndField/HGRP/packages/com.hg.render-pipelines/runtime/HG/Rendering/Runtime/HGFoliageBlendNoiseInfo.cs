using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class HGFoliageBlendNoiseInfo
	{
		public HGFoliageBlendNoiseInfo()
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

		public Texture2D blendNoiseTexture;

		public Vector4 tillingOffset;

		public Vector2 textureDir;

		public float remapMin;

		public float remapMax;
	}
}
