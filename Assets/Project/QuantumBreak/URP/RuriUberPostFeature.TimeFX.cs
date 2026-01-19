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
            private Material _timeFXCompositeMat;

            private static readonly int _TimeFX_VelocityTexID = Shader.PropertyToID("_VelocityTex");
            // [Fix] ID Renamed
            private static readonly int _TimeFX_TextureID = Shader.PropertyToID("_TimeFXTexture");
            private static readonly int _TimeFX_BlitTextureID = Shader.PropertyToID("_BlitTexture");
            private static readonly int _TimeFX_SimulationTimeID = Shader.PropertyToID("_SimulationTime");
            private static readonly int _TimeFX_ParamsID = Shader.PropertyToID("_Params");

            private void SetupTimeFXComposite()
            {
                if (_timeFXCompositeMat == null && _feature.timeFXCompositeShader != null)
                    _timeFXCompositeMat = CoreUtils.CreateEngineMaterial(_feature.timeFXCompositeShader);
            }

            private void DisposeTimeFXComposite()
            {
                CoreUtils.Destroy(_timeFXCompositeMat);
            }

            private void RecordTimeFX(RenderGraph renderGraph, ContextContainer frameData, VolumeStack stack)
            {
                var settings = stack.GetComponent<TimeFX>();
                if (settings == null || !settings.IsActive()) return;

                if (!_timeFXHandle.IsValid() || !_displateCompositeHandle.IsValid()) return;

                var resourceData = frameData.Get<UniversalResourceData>();
                TextureHandle cameraColor = resourceData.activeColorTexture;

                var desc = renderGraph.GetTextureDesc(cameraColor);
                var compDesc = desc;
                compDesc.name = "TimeFX_Composite";
                TextureHandle compositeResult = renderGraph.CreateTexture(compDesc);

                using (var builder = renderGraph.AddUnsafePass<TimeFXCompositeData>("TimeFX Composite", out var passData))
                {
                    builder.UseTexture(_timeFXHandle, AccessFlags.Read);
                    builder.UseTexture(_displateCompositeHandle, AccessFlags.Read);
                    builder.UseTexture(cameraColor, AccessFlags.Read);
                    builder.UseTexture(compositeResult, AccessFlags.Write);

                    passData.material = _timeFXCompositeMat;
                    passData.fxTex = _timeFXHandle;
                    passData.velocityTex = _displateCompositeHandle;
                    passData.bgTex = cameraColor;
                    passData.outputTex = compositeResult;
                    passData.simulationTime = Time.time;
                    passData.paramsVec = new Vector4(
                        settings.stutterFrequency.value,
                        settings.chromaticAberration.value,
                        settings.effectIntensity.value,
                        Time.time
                    );
                    passData.props = new MaterialPropertyBlock();

                    builder.SetRenderFunc((TimeFXCompositeData data, UnsafeGraphContext ctx) =>
                    {
                        var cmd = CommandBufferHelpers.GetNativeCommandBuffer(ctx.cmd);
                        if (data.material != null)
                        {
                            data.props.Clear();
                            data.props.SetTexture(_TimeFX_VelocityTexID, data.velocityTex);
                            // [Fix] Using new ID
                            data.props.SetTexture(_TimeFX_TextureID, data.fxTex);
                            data.props.SetTexture(_TimeFX_BlitTextureID, data.bgTex);

                            data.props.SetFloat(_TimeFX_SimulationTimeID, data.simulationTime);
                            data.props.SetVector(_TimeFX_ParamsID, data.paramsVec);

                            CoreUtils.SetRenderTarget(cmd, data.outputTex, RenderBufferLoadAction.DontCare, RenderBufferStoreAction.Store, ClearFlag.None, Color.black);
                            CoreUtils.DrawFullScreen(cmd, data.material, data.props, 0);
                        }
                    });
                }

                using (var builder = renderGraph.AddRasterRenderPass<TimeFXCopyPassData>("TimeFX Composite CopyBack", out var passData))
                {
                    builder.UseTexture(compositeResult, AccessFlags.Read);
                    builder.SetRenderAttachment(cameraColor, 0, AccessFlags.Write);
                    passData.src = compositeResult;
                    builder.SetRenderFunc((TimeFXCopyPassData data, RasterGraphContext ctx) =>
                    {
                        Blitter.BlitTexture(ctx.cmd, data.src, new Vector4(1, 1, 0, 0), 0, false);
                    });
                }
            }

            class TimeFXCompositeData
            {
                public Material material;
                public TextureHandle fxTex;
                public TextureHandle velocityTex;
                public TextureHandle bgTex;
                public TextureHandle outputTex;
                public float simulationTime;
                public Vector4 paramsVec;
                public MaterialPropertyBlock props;
            }

            class TimeFXCopyPassData { public TextureHandle src; }
        }
    }
}