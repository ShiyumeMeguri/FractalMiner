using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGCharacterQualitySettings // TypeDefIndex: 38687
	{
		// Fields
		public static int characterSelfShadowOffLodQuality; // 0x00
		public static int characterShadowTierLevel; // 0x04
		public static int characterOutlineTierLevel; // 0x08
	
		// Constructors
		public HGCharacterQualitySettings() {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static HGCharacterQualitySettings() {} // 0x0000000184D7A550-0x0000000184D7A590
		// HGCharacterQualitySettings()
		void HG::Rendering::Runtime::HGCharacterQualitySettings::cctor(MethodInfo *method)
		{
		  TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings->static_fields->characterSelfShadowOffLodQuality = 2;
		  TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings->static_fields->characterShadowTierLevel = 1000;
		  TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings->static_fields->characterOutlineTierLevel = 1000;
		}
		
	}
}
