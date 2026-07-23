using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Serialization;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[DebuggerDisplay("FrameSettings overriding {overrides.ToString(\"X\")}")]
	[Obsolete("For data migration")]
	internal class ObsoleteFrameSettings // TypeDefIndex: 38541
	{
		// Fields
		public ObsoleteFrameSettingsOverrides overrides; // 0x10
		public bool enableShadow; // 0x14
		public bool enableContactShadows; // 0x15
		public bool enableShadowMask; // 0x16
		public bool enableSSR; // 0x17
		public bool enableSSAO; // 0x18
		public bool enableSubsurfaceScattering; // 0x19
		public bool enableTransmission; // 0x1A
		public bool enableAtmosphericScattering; // 0x1B
		public bool enableVolumetrics; // 0x1C
		public bool enableReprojectionForVolumetrics; // 0x1D
		public bool enableLightLayers; // 0x1E
		public bool enableExposureControl; // 0x1F
		public float diffuseGlobalDimmer; // 0x20
		public float specularGlobalDimmer; // 0x24
		public ObsoleteLitShaderMode shaderLitMode; // 0x28
		public bool enableDepthPrepassWithDeferredRendering; // 0x2C
		public bool enableTransparentPrepass; // 0x2D
		public bool enableMotionVectors; // 0x2E
		public bool enableObjectMotionVectors; // 0x2F
		[FormerlySerializedAs("enableDBuffer")]
		public bool enableDecals; // 0x30
		public bool enableRoughRefraction; // 0x31
		public bool enableTransparentPostpass; // 0x32
		public bool enableDistortion; // 0x33
		public bool enablePostprocess; // 0x34
		public bool enableOpaqueObjects; // 0x35
		public bool enableTransparentObjects; // 0x36
		public bool enableRealtimePlanarReflection; // 0x37
	
		// Constructors
		public ObsoleteFrameSettings() {} // 0x0000000184D55400-0x0000000184D55410
		// ObsoleteFrameSettings()
		void HG::Rendering::Runtime::ObsoleteFrameSettings::ObsoleteFrameSettings(
		        ObsoleteFrameSettings *this,
		        MethodInfo *method)
		{
		  this->fields.enableExposureControl = 1;
		}
		
	}
}
