using System;

namespace HG.Rendering.Runtime
{
	public class HGCharacterQualitySettings
	{
		public HGCharacterQualitySettings()
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

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static int characterSelfShadowOffLodQuality;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		public static int characterShadowTierLevel;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static int characterOutlineTierLevel;
	}
}
