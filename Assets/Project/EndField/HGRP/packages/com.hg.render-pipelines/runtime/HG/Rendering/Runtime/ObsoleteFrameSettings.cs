using System;
using System.Diagnostics;
using UnityEngine.Serialization;

namespace HG.Rendering.Runtime
{
	[DebuggerDisplay("FrameSettings overriding {overrides.ToString(\"X\")}")]
	[Obsolete("For data migration")]
	[Serializable]
	internal class ObsoleteFrameSettings
	{
		public ObsoleteFrameSettings()
		{
			// // ObsoleteFrameSettings()
			// void HG::Rendering::Runtime::ObsoleteFrameSettings::ObsoleteFrameSettings(
			//         ObsoleteFrameSettings *this,
			//         MethodInfo *method)
			// {
			//   this.fields.enableExposureControl = 1;
			// }
			// 
		}

		public ObsoleteFrameSettingsOverrides overrides;

		public bool enableShadow;

		public bool enableContactShadows;

		public bool enableShadowMask;

		public bool enableSSR;

		public bool enableSSAO;

		public bool enableSubsurfaceScattering;

		public bool enableTransmission;

		public bool enableAtmosphericScattering;

		public bool enableVolumetrics;

		public bool enableReprojectionForVolumetrics;

		public bool enableLightLayers;

		public bool enableExposureControl;

		public float diffuseGlobalDimmer;

		public float specularGlobalDimmer;

		public ObsoleteLitShaderMode shaderLitMode;

		public bool enableDepthPrepassWithDeferredRendering;

		public bool enableTransparentPrepass;

		public bool enableMotionVectors;

		public bool enableObjectMotionVectors;

		[FormerlySerializedAs("enableDBuffer")]
		public bool enableDecals;

		public bool enableRoughRefraction;

		public bool enableTransparentPostpass;

		public bool enableDistortion;

		public bool enablePostprocess;

		public bool enableOpaqueObjects;

		public bool enableTransparentObjects;

		public bool enableRealtimePlanarReflection;
	}
}
