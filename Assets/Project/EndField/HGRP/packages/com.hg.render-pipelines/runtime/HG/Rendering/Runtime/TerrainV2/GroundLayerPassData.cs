using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

namespace HG.Rendering.Runtime.TerrainV2
{
	internal class GroundLayerPassData
	{
		public GroundLayerPassData()
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

		public ComputeShader groundLayerBakeCS;

		public TextureHandle groundLayerBaseRT;

		public TextureHandle groundLayerNormalRT;

		public TextureHandle groundLayerWetRT;

		public TextureHandle groundLayerHeightRT;

		public TextureHandle defaultRT;

		public bool bDirty;

		public Vector4 layerParams;

		public uint layerIndex;
	}
}
