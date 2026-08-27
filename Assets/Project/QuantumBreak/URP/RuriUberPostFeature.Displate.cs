using Ruri.Rendering.Overrides;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal;

namespace Ruri.Rendering.Feature
{
    public partial class RuriUberPostFeature
    {
        private partial class RuriUberPostPass
        {
            private FilteringSettings _displateFilteringSettings;

            // Updated Tags corresponding to Shader LightModes
            private List<ShaderTagId> _displateCompositeTags = new List<ShaderTagId>() { new ShaderTagId("DisplateComposite") };
            private List<ShaderTagId> _timeFXTags = new List<ShaderTagId>() { new ShaderTagId("TimeFX") };

            private TextureHandle _displateCompositeHandle;
            private TextureHandle _timeFXHandle;

            private void SetupDisplate()
            {
                _displateFilteringSettings = new FilteringSettings(RenderQueueRange.transparent);
            }

            private void DisposeDisplate()
            {
            }

            private void RecordDisplate(RenderGraph renderGraph, ContextContainer frameData, VolumeStack stack)
            {
                var settings = stack.GetComponent<DisplateFX>();
                if (settings == null || !settings.IsActive())
                {
                    _displateCompositeHandle = TextureHandle.nullHandle;
                    _timeFXHandle = TextureHandle.nullHandle;
                    return;
                }

                var urpData = frameData.Get<UniversalRenderingData>();
                var cameraData = frameData.Get<UniversalCameraData>();
                var resourceData = frameData.Get<UniversalResourceData>();
                var cullResults = urpData.cullResults;

                var desc = renderGraph.GetTextureDesc(resourceData.activeColorTexture);

                // 1. Composite Buffer (formerly Velocity) (R16G16)
                var compositeDesc = desc;
                compositeDesc.name = "Displate_Composite";
                compositeDesc.clearBuffer = true;
                compositeDesc.depthBufferBits = 0;
                compositeDesc.colorFormat = UnityEngine.Experimental.Rendering.GraphicsFormat.R16G16_SFloat;
                _displateCompositeHandle = renderGraph.CreateTexture(compositeDesc);

                // 2. TimeFX Buffer (formerly FX) (R16G16B16A16)
                var fxDesc = desc;
                fxDesc.name = "TimeFX_Visual";
                fxDesc.clearBuffer = true;
                fxDesc.depthBufferBits = 0;
                fxDesc.colorFormat = UnityEngine.Experimental.Rendering.GraphicsFormat.R16G16B16A16_SFloat;
                _timeFXHandle = renderGraph.CreateTexture(fxDesc);

                // Pass 1: Composite (Distortion Field)
                RendererListHandle compositeList = renderGraph.CreateRendererList(
                    new RendererListParams(cullResults,
                    new DrawingSettings(_displateCompositeTags[0], new SortingSettings(cameraData.camera)) { perObjectData = PerObjectData.None },
                    _displateFilteringSettings));

                using (var builder = renderGraph.AddRasterRenderPass<DisplatePassData>("DisplateComposite Pass", out var passData))
                {
                    builder.SetRenderAttachment(_displateCompositeHandle, 0, AccessFlags.Write);
                    builder.SetRenderAttachmentDepth(resourceData.activeDepthTexture, AccessFlags.Read);
                    builder.UseRendererList(compositeList);
                    passData.rendererList = compositeList;
                    builder.SetRenderFunc((DisplatePassData data, RasterGraphContext ctx) =>
                    {
                        ctx.cmd.ClearRenderTarget(false, true, Color.black);
                        ctx.cmd.DrawRendererList(data.rendererList);
                    });
                }

                // Pass 2: TimeFX (Visual Particles)
                // Executed before TimeFXComposite as per request logic (Recorded here, consumed later)
                RendererListHandle timeFXList = renderGraph.CreateRendererList(
                    new RendererListParams(cullResults,
                    new DrawingSettings(_timeFXTags[0], new SortingSettings(cameraData.camera)) { perObjectData = PerObjectData.None },
                    _displateFilteringSettings));

                using (var builder = renderGraph.AddRasterRenderPass<DisplatePassData>("TimeFX Pass", out var passData))
                {
                    builder.SetRenderAttachment(_timeFXHandle, 0, AccessFlags.Write);
                    builder.SetRenderAttachmentDepth(resourceData.activeDepthTexture, AccessFlags.Read);
                    builder.UseRendererList(timeFXList);
                    passData.rendererList = timeFXList;
                    builder.SetRenderFunc((DisplatePassData data, RasterGraphContext ctx) =>
                    {
                        ctx.cmd.ClearRenderTarget(false, true, Color.black);
                        ctx.cmd.DrawRendererList(data.rendererList);
                    });
                }
            }

            class DisplatePassData { public RendererListHandle rendererList; }
        }
    }
}