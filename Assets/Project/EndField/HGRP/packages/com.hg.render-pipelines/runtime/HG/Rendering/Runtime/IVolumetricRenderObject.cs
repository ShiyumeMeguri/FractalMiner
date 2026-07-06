using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public interface IVolumetricRenderObject
	{
		// (get) Token: 0x06001B2A RID: 6954
		int order
		{
			get;
		}

		void PrepareVolumetricRendering(ref VolumetricRenderInputs inputs);

		void PreVolumetricRendering(ref VolumetricRenderInputs inputs);

		void PostVolumetricRendering(ref VolumetricRenderInputs inputs);

		bool OverrideFramingCompose(VolumetricRenderer.VolumetricComposeContext context, out VolumetricRenderer.VolumetricRenderItem item);

		bool OverrideTemporalCompose(VolumetricRenderer.VolumetricComposeContext context, out VolumetricRenderer.VolumetricRenderItem item);

		void CollectVolumetricRenderItems(HGCamera hgCamera, HGVolumetricCloudSettingParameters volumetricParameters, List<VolumetricRenderer.VolumetricRenderItem> items);

		void CollectVolumetricRenderItemsCPP(HGCamera hgCamera, HGVolumetricCloudSettingParameters volumetricParameters, List<HGVolumetricRenderItem> renderItems);

		void OnUpdateVolumetricMaterial(CommandBuffer cmd, Material material, MaterialPropertyBlock propertyBlock);
	}
}
