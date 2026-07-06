using System;
using UnityEngine;

namespace HG.Rendering.Runtime.Sludge
{
	public class HGDynamicSludge
	{
		public HGDynamicSludge()
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

		public Vector2Int texelSize;

		public RectInt atlasRect;

		public Vector4 atlasTillingScale;

		public Matrix4x4 matrix4X4;

		public float rebornTime;

		public float rebornAnimTime;

		public float lastHitTime;

		public HGDynamicSludgeHit recentHitPoint;
	}
}
