using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public interface IVolumetricRenderObject // TypeDefIndex: 38751
	{
		// Properties
		int order { get; }
	
		// Methods
		void PrepareVolumetricRendering(ref VolumetricRenderInputs inputs);
		void PreVolumetricRendering(ref VolumetricRenderInputs inputs);
		void PostVolumetricRendering(ref VolumetricRenderInputs inputs);
		bool OverrideFramingCompose(VolumetricRenderer.VolumetricComposeContext context, out VolumetricRenderer.VolumetricRenderItem item);
		bool OverrideTemporalCompose(VolumetricRenderer.VolumetricComposeContext context, out VolumetricRenderer.VolumetricRenderItem item);
		void CollectVolumetricRenderItems(HGCamera hgCamera, ScriptableRenderContext renderContext, HGVolumetricCloudSettingParameters volumetricParameters, List<VolumetricRenderer.VolumetricRenderItem> items);
		void CollectVolumetricRenderItemsCPP(HGCamera hgCamera, ScriptableRenderContext renderContext, HGVolumetricCloudSettingParameters volumetricParameters, List<HGVolumetricRenderItem> renderItems);
		void OnUpdateVolumetricMaterial(CommandBuffer cmd, ScriptableRenderContext renderContext, Material material, MaterialPropertyBlock propertyBlock);
	}
}
