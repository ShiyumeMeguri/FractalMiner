using System;

namespace HG.Rendering.Runtime
{
	public class HGGraphicsFeatureManager
	{
		public HGGraphicsFeatureManager()
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
		public static HGGraphicsFeatureSwitch csm;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static HGGraphicsFeatureSwitch asm;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		public static HGGraphicsFeatureSwitch cloudShadow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		public static HGGraphicsFeatureSwitch characterShadow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		public static HGGraphicsFeatureSwitch punctualLightShadow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		public static HGGraphicsFeatureSwitch contactShadow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		public static HGGraphicsFeatureSwitch preZ;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
		public static HGGraphicsFeatureSwitch deferred;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
		public static HGGraphicsFeatureSwitch characterPrePass;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x48")]
		public static HGGraphicsFeatureSwitch customDepthPass;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
		public static HGGraphicsFeatureSwitch deferredOpaque;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x58")]
		public static HGGraphicsFeatureSwitch deferredOpaquePreZ;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x60")]
		public static HGGraphicsFeatureSwitch deferredOpaqueEqual;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x68")]
		public static HGGraphicsFeatureSwitch deferredGrassPreZ;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x70")]
		public static HGGraphicsFeatureSwitch deferredGrass;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x78")]
		public static HGGraphicsFeatureSwitch deferredDecal;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x80")]
		public static HGGraphicsFeatureSwitch deferredErosion;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x88")]
		public static HGGraphicsFeatureSwitch deferredSludge;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x90")]
		public static HGGraphicsFeatureSwitch forward;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x98")]
		public static HGGraphicsFeatureSwitch forwardTransparent;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA0")]
		public static HGGraphicsFeatureSwitch forwardOpaque;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA8")]
		public static HGGraphicsFeatureSwitch forwardOpaquePreZ;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB0")]
		public static HGGraphicsFeatureSwitch forwardOpaqueEqual;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB8")]
		public static HGGraphicsFeatureSwitch forwardDecal;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC0")]
		public static HGGraphicsFeatureSwitch forwardCharacter;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC8")]
		public static HGGraphicsFeatureSwitch characterOutlineOpaque;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD0")]
		public static HGGraphicsFeatureSwitch characterOutlineOpaquePreZ;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD8")]
		public static HGGraphicsFeatureSwitch characterOutlineOpaqueEqual;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xE0")]
		public static HGGraphicsFeatureSwitch vfxDecal;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xE8")]
		public static HGGraphicsFeatureSwitch distortionOpaque;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xF0")]
		public static HGGraphicsFeatureSwitch distortionTransparent;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xF8")]
		public static HGGraphicsFeatureSwitch UI;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x100")]
		public static HGGraphicsFeatureSwitch UISprite;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x108")]
		public static HGGraphicsFeatureSwitch UIWorld;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x110")]
		public static HGGraphicsFeatureSwitch UIDistortion;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x118")]
		public static HGGraphicsFeatureSwitch UIFrostedGlass;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x120")]
		public static HGGraphicsFeatureSwitch deferredShading;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x128")]
		public static HGGraphicsFeatureSwitch deferredShadingDefaultLit;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x130")]
		public static HGGraphicsFeatureSwitch deferredShadingTwoSidedFoliage;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x138")]
		public static HGGraphicsFeatureSwitch deferredShadingSubsurface;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x140")]
		public static HGGraphicsFeatureSwitch splitDeferredShadingStage;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x148")]
		public static HGGraphicsFeatureSwitch usePerLightDynamicLighting;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x150")]
		public static HGGraphicsFeatureSwitch deferredShadingDirectionalLightStage;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x158")]
		public static HGGraphicsFeatureSwitch deferredShadingDynamicLightStage;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x160")]
		public static HGGraphicsFeatureSwitch deferredShadingIndirectStage;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x168")]
		public static HGGraphicsFeatureSwitch usePerTileDeferredLighting;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x170")]
		public static HGGraphicsFeatureSwitch terrain;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x178")]
		public static HGGraphicsFeatureSwitch terrainDeform;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x180")]
		public static HGGraphicsFeatureSwitch terrainPreDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x188")]
		public static HGGraphicsFeatureSwitch terrainScreenSpace;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x190")]
		public static HGGraphicsFeatureSwitch terrainPostGBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x198")]
		public static HGGraphicsFeatureSwitch terrainVTBake;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1A0")]
		public static HGGraphicsFeatureSwitch terrainIndirectionUpdate;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1A8")]
		public static HGGraphicsFeatureSwitch terrainDepthPrepass;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1B0")]
		public static HGGraphicsFeatureSwitch terrainSimpleSubsurface;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1B8")]
		public static HGGraphicsFeatureSwitch terrainSubdivision;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C0")]
		public static HGGraphicsFeatureSwitch terrainSubdivisionV2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C8")]
		public static HGGraphicsFeatureSwitch terrainSubdivisionHZBCulling;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1D0")]
		public static HGGraphicsFeatureSwitch terrainNewEditorRendering;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1D8")]
		public static HGGraphicsFeatureSwitch terrainDecalInteraction;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1E0")]
		public static HGGraphicsFeatureSwitch irradianceVolumeV2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1E8")]
		public static HGGraphicsFeatureSwitch irradianceVolumeV3;
	}
}
