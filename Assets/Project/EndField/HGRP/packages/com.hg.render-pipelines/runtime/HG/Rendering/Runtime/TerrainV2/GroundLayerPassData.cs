using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.TerrainV2
{
	internal class GroundLayerPassData // TypeDefIndex: 38821
	{
		// Fields
		public ComputeShader groundLayerBakeCS; // 0x10
		public TextureHandle groundLayerBaseRT; // 0x18
		public TextureHandle groundLayerNormalRT; // 0x28
		public TextureHandle groundLayerWetRT; // 0x38
		public TextureHandle groundLayerHeightRT; // 0x48
		public TextureHandle defaultRT; // 0x58
		public bool bDirty; // 0x68
		public Vector4 layerParams; // 0x6C
		public uint layerIndex; // 0x7C
	
		// Constructors
		public GroundLayerPassData() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
	}
}
