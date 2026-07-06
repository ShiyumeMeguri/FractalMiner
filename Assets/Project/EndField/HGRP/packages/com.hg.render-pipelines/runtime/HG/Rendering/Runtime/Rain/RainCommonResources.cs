using System;
using UnityEngine;

namespace HG.Rendering.Runtime.Rain
{
	internal class RainCommonResources
	{
		public RainCommonResources()
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

		public Mesh farRainSpindleMesh;

		public Mesh sceneEffectRainMesh;

		public Mesh rainSplashMesh;

		public Mesh screenDropFxMesh;

		public Shader farRainShader;

		public Shader sceneEffectRainShader;

		public Shader screenRainDropFXShader;

		public Shader rainSplashShader;
	}
}
