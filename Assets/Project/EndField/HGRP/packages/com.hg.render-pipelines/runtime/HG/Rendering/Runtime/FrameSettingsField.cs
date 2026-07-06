using System;

namespace HG.Rendering.Runtime
{
	public enum FrameSettingsField
	{
		None = -1,
		[FrameSettingsField(0, FrameSettingsField.LitShaderMode, null, "Specifies the Lit Shader Mode for Cameras using these Frame Settings use to render the Scene (Depends on \"Lit Shader Mode\" in current HGRP Asset).", FrameSettingsFieldAttribute.DisplayType.BoolAsEnumPopup, typeof(LitShaderMode), null, null, 0)]
		LitShaderMode,
		[FrameSettingsField(0, FrameSettingsField.None, "Depth Prepass within Deferred", "When enabled, HGRP processes a depth prepass for Cameras using these Frame Settings. Set Lit Shader Mode to Deferred to access this option.", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, new FrameSettingsField[] { FrameSettingsField.LitShaderMode }, null, -1)]
		DepthPrepassWithDeferredRendering,
		[FrameSettingsField(0, FrameSettingsField.OpaqueObjects, null, "When enabled, Cameras using these Frame Settings render opaque GameObjects.", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, null, null, 4)]
		OpaqueObjects,
		[FrameSettingsField(0, FrameSettingsField.TransparentObjects, null, "When enabled, Cameras using these Frame Settings render Transparent GameObjects.", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, null, null, 5)]
		TransparentObjects,
		[FrameSettingsField(0, FrameSettingsField.Decals, null, "When enabled, HGRP processes a decal render pass for Cameras using these Frame Settings.", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, null, null, 6)]
		Decals = 12,
		[FrameSettingsField(0, FrameSettingsField.TransparentPrepass, null, "When enabled, HGRP processes a transparent prepass for Cameras using these Frame Settings.", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, null, null, 7)]
		TransparentPrepass = 8,
		[FrameSettingsField(0, FrameSettingsField.TransparentPostpass, null, "When enabled, HGRP processes a transparent postpass for Cameras using these Frame Settings.", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, null, null, 8)]
		TransparentPostpass,
		[FrameSettingsField(0, FrameSettingsField.None, "Low Resolution Transparent", "When enabled, HGRP processes a transparent pass in a lower resolution for Cameras using these Frame Settings.", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, null, null, 9)]
		LowResTransparent = 18,
		[FrameSettingsField(0, FrameSettingsField.Refraction, null, "When enabled, HGRP processes a refraction render pass for Cameras using these Frame Settings. This add a resolve of ColorBuffer after the drawing of opaque materials to be use for Refraction effect during transparent pass.", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, null, null, 15)]
		Refraction = 13,
		[FrameSettingsField(0, FrameSettingsField.None, "Post-process", "When enabled, HGRP processes a post-processing render pass for Cameras using these Frame Settings.", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, null, null, 18)]
		Postprocess = 15,
		[FrameSettingsField(0, FrameSettingsField.Bloom, null, "When enabled, HGRP adds bloom to Cameras affected by a Volume containing the Bloom override.", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, new FrameSettingsField[] { FrameSettingsField.Postprocess }, null, 19)]
		Bloom = 84,
		[FrameSettingsField(0, FrameSettingsField.Vignette, null, "When enabled, HGRP adds vignette to Cameras affected by a Volume containing the Vignette override.", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, new FrameSettingsField[] { FrameSettingsField.Postprocess }, null, 19)]
		Vignette = 87,
		[FrameSettingsField(0, FrameSettingsField.ColorGrading, null, "When enabled, HGRP processes color grading for Cameras using these Frame Settings.", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, new FrameSettingsField[] { FrameSettingsField.Postprocess }, null, 19)]
		ColorGrading,
		[FrameSettingsField(0, FrameSettingsField.Tonemapping, null, "When enabled, HGRP processes tonemapping for Cameras using these Frame Settings.", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, new FrameSettingsField[] { FrameSettingsField.Postprocess }, null, 19)]
		Tonemapping = 93,
		[FrameSettingsField(0, FrameSettingsField.MaterialQualityLevel, null, "The material quality level to use.", FrameSettingsFieldAttribute.DisplayType.Others, null, null, null, -1)]
		MaterialQualityLevel = 66,
		[FrameSettingsField(1, FrameSettingsField.ShadowMaps, null, "When enabled, Cameras using these Frame Settings render shadows.", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, null, null, 1)]
		ShadowMaps = 20,
		[FrameSettingsField(1, FrameSettingsField.CharacterShadowMaps, null, "When enabled, Cameras using these Frame Settings render character shadows.", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, null, null, 1)]
		CharacterShadowMaps,
		[FrameSettingsField(1, FrameSettingsField.Shadowmask, null, "When enabled, Cameras using these Frame Settings render shadows from Shadow Masks (Depends on \"Shadowmask\" in current HGRP Asset).", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, null, null, 24)]
		Shadowmask,
		[FrameSettingsField(1, FrameSettingsField.CapsuleShadow, null, "When enabled, Cameras using these Frame Settings render capsule shadows.", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, null, null, 24)]
		CapsuleShadow,
		[FrameSettingsField(1, FrameSettingsField.LightLayers, null, "When enabled, Cameras that use these Frame Settings make use of LightLayers (Depends on \"Light Layers\" in current HGRP Asset).", FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, null, null, null, -1)]
		LightLayers = 30
	}
}
