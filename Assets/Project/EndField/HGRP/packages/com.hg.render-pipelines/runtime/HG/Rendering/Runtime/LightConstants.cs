using System;

namespace HG.Rendering.Runtime
{
	internal class LightConstants
	{
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00002608 File Offset: 0x00000808
		public static int NUM_PUNCTUAL_LIGHT_MASK_BYTES
		{
			get
			{
				// // UInt32 get_capacity()
				// uint32_t UnityEngine::Rendering::BitArray32::get_capacity(BitArray32 *this, MethodInfo *method)
				// {
				//   return 32;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00002608 File Offset: 0x00000808
		public static int NUM_PUNCTUAL_LIGHT_MASK_UNITS
		{
			get
			{
				// // XmlNodeType get_NodeType()
				// XmlNodeType__Enum System::Xml::Linq::XComment::get_NodeType(XComment *this, MethodInfo *method)
				// {
				//   return 8;
				// }
				// 
				return 0;
			}
		}

		public LightConstants()
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

		public const int MAX_DIRECTIONAL_LIGHTS = 4;

		public const int NUM_DIR_LIGHT_DATA_BYTES = 5;

		public const int NUM_LIGHT_COUNT_DATA_BYTES = 1;

		public const int MAX_VISIBLE_LIGHTS = 256;
	}
}
