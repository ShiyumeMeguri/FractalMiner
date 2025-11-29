using Ruri.Rendering.Overrides;
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
            private Material _vectorBlurMat;

            private static readonly int _VB_VelocityTexID = Shader.PropertyToID("_VelocityTex");
            private static readonly int _VB_SourceTexID = Shader.PropertyToID("_SourceTex");
            private static readonly int _VB_SourceSizeID = Shader.PropertyToID("_SourceSize");
            private static readonly int _VB_ParamsID = Shader.PropertyToID("_Params");

            private void SetupVectorBlur()
            {
                if (_vectorBlurMat == null && _feature.vectorBlurShader != null)
                    _vectorBlurMat = CoreUtils.CreateEngineMaterial(_feature.vectorBlurShader);
            }

            private void DisposeVectorBlur()
            {
                CoreUtils.Destroy(_vectorBlurMat);
            }

            private void RecordVectorBlur(RenderGraph renderGraph, ContextContainer frameData, VolumeStack stack)
            {
                var settings = stack.GetComponent<VectorBlur>();
                if (settings == null || !settings.IsActive()) return;

                // Requires composite/velocity buffer from Displate
                if (!_displateCompositeHandle.IsValid()) return;

                var resourceData = frameData.Get<UniversalResourceData>();
                TextureHandle cameraColor = resourceData.activeColorTexture;
                var desc = renderGraph.GetTextureDesc(cameraColor);

                var tempDesc = desc;
                tempDesc.name = "VectorBlur_Temp";
                TextureHandle blurredHandle = renderGraph.CreateTexture(tempDesc);

                using (var builder = renderGraph.AddUnsafePass<VBBlurPassData>("Vector Blur", out var passData))
                {
                    builder.UseTexture(_displateCompositeHandle, AccessFlags.Read);
                    builder.UseTexture(cameraColor, AccessFlags.Read);
                    builder.UseTexture(blurredHandle, AccessFlags.Write);

                    passData.material = _vectorBlurMat;
                    passData.inputTex = cameraColor;
                    passData.velocityTex = _displateCompositeHandle;
                    passData.outputTex = blurredHandle;
                    passData.sourceSize = new Vector4(desc.width, desc.height, 1f / desc.width, 1f / desc.height);
                    passData.paramsVec = new Vector4(0, 0, settings.blurScale.value, 0);
                    passData.props = new MaterialPropertyBlock();

                    builder.SetRenderFunc((VBBlurPassData data, UnsafeGraphContext ctx) =>
                    {
                        var cmd = CommandBufferHelpers.GetNativeCommandBuffer(ctx.cmd);
                        if (data.material == null) return;

                        data.props.Clear();
                        data.props.SetTexture(_VB_VelocityTexID, data.velocityTex);
                        data.props.SetTexture(_VB_SourceTexID, data.inputTex);
                        data.props.SetVector(_VB_ParamsID, data.paramsVec);
                        data.props.SetVector(_VB_SourceSizeID, data.sourceSize);

                        CoreUtils.SetRenderTarget(cmd, data.outputTex, RenderBufferLoadAction.DontCare, RenderBufferStoreAction.Store, ClearFlag.None, Color.black);
                        CoreUtils.DrawFullScreen(cmd, data.material, data.props, 0);
                    });
                }

                // Copy back to CameraColor
                using (var builder = renderGraph.AddRasterRenderPass<VBCopyPassData>("Vector Blur CopyBack", out var passData))
                {
                    builder.UseTexture(blurredHandle, AccessFlags.Read);
                    builder.SetRenderAttachment(cameraColor, 0, AccessFlags.Write);
                    passData.src = blurredHandle;
                    builder.SetRenderFunc((VBCopyPassData data, RasterGraphContext ctx) =>
                    {
                        Blitter.BlitTexture(ctx.cmd, data.src, new Vector4(1, 1, 0, 0), 0, false);
                    });
                }
            }

            class VBBlurPassData
            {
                public Material material;
                public TextureHandle inputTex;
                public TextureHandle velocityTex;
                public TextureHandle outputTex;
                public Vector4 paramsVec;
                public Vector4 sourceSize;
                public MaterialPropertyBlock props;
            }

            class VBCopyPassData { public TextureHandle src; }
        }
    }
}