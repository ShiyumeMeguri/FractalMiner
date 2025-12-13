using Ruri.Rendering.Overrides;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal;

namespace Ruri.Rendering.Feature
{
    [DisallowMultipleRendererFeature("Ruri Caustics")]
    public class CausticsFeature : ScriptableRendererFeature
    {
        [SerializeField] private Shader causticsShader;
        private RuriCausticsPass _pass;

        public override void Create()
        {
            if (causticsShader == null)
                causticsShader = Shader.Find("Hidden/Ruri/Caustics");

            _pass = new RuriCausticsPass();
            // 参考截帧：在延迟光照之后，透明物体之前执行
            // 这样焦散可以叠加在不透明物体上，且能正确获取深度和法线
            _pass.renderPassEvent = RenderPassEvent.AfterRenderingDeferredLights;
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            if (renderingData.cameraData.cameraType == CameraType.Preview ||
                renderingData.cameraData.cameraType == CameraType.Reflection)
                return;

            if (causticsShader == null) return;

            _pass.Setup(causticsShader);
            renderer.EnqueuePass(_pass);
        }

        protected override void Dispose(bool disposing)
        {
            _pass?.Dispose();
        }

        private class RuriCausticsPass : ScriptableRenderPass
        {
            private Material _material;
            private Caustics _settings;

            // Shader IDs
            private static readonly int _CausticsTexture = Shader.PropertyToID("_CausticsTexture");
            private static readonly int _CausticsParams = Shader.PropertyToID("_CausticsParams");
            private static readonly int _CausticsColor = Shader.PropertyToID("_CausticsColor");
            private static readonly int _ProjectionParams_Ruri = Shader.PropertyToID("_ProjectionParams_Ruri");

            // System Texture IDs
            private static readonly int _CameraDepthTextureID = Shader.PropertyToID("_CameraDepthTexture");
            private static readonly int _GBuffer0ID = Shader.PropertyToID("_GBuffer0");
            private static readonly int _GBuffer1ID = Shader.PropertyToID("_GBuffer1");
            private static readonly int _GBuffer2ID = Shader.PropertyToID("_GBuffer2");

            public void Setup(Shader shader)
            {
                if (_material == null) _material = CoreUtils.CreateEngineMaterial(shader);
            }

            public void Dispose()
            {
                CoreUtils.Destroy(_material);
            }

            public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
            {
                var stack = VolumeManager.instance.stack;
                _settings = stack.GetComponent<Caustics>();

                if (_settings == null || !_settings.IsActive()) return;

                var resourceData = frameData.Get<UniversalResourceData>();
                var cameraData = frameData.Get<UniversalCameraData>();

                // 确保我们有 Color 和 Depth
                TextureHandle cameraColor = resourceData.activeColorTexture;
                TextureHandle cameraDepth = resourceData.activeDepthTexture;
                if (!cameraColor.IsValid() || !cameraDepth.IsValid()) return;

                using (var builder = renderGraph.AddRasterRenderPass<PassData>("Ruri Caustics Pass", out var passData))
                {
                    passData.material = _material;
                    passData.settings = _settings;
                    passData.cameraDepth = cameraDepth;
                    passData.gBuffer = resourceData.gBuffer; // 传递整个 GBuffer 数组引用

                    // 1. 声明依赖
                    builder.UseTexture(cameraDepth, AccessFlags.Read);

                    // GBuffer 依赖 (用于读取法线)
                    if (passData.gBuffer != null)
                    {
                        for (int i = 0; i < passData.gBuffer.Length; i++)
                        {
                            var tex = passData.gBuffer[i];
                            if (!tex.IsValid()) continue;

                            // 防止自我读写冲突 (虽然 Caustics Pass 不写入 GBuffer，但为了安全)
                            if (tex.Equals(cameraColor) || tex.Equals(cameraDepth)) continue;

                            builder.UseTexture(tex, AccessFlags.Read);
                        }
                    }

                    // 2. 设置输出：叠加到 Camera Color
                    // 注意：Blend Mode 在 Shader 中设置为 One One
                    builder.SetRenderAttachment(cameraColor, 0, AccessFlags.ReadWrite);

                    builder.SetRenderFunc((PassData data, RasterGraphContext ctx) =>
                    {
                        var mat = data.material;
                        var set = data.settings;

                        // 手动绑定资源以供 Shader 中的 Ruri_Deferred.hlsl 及其依赖项使用
                        // 注意：RenderGraph 自动绑定通常适用于 SetGlobalTexture，但为了确保 UnpackRuriGBuffers 能读到数据，这里显式设置
                        mat.SetTexture(_CameraDepthTextureID, data.cameraDepth);

                        if (data.gBuffer != null)
                        {
                            if (data.gBuffer.Length > 0 && data.gBuffer[0].IsValid()) mat.SetTexture(_GBuffer0ID, data.gBuffer[0]);
                            if (data.gBuffer.Length > 1 && data.gBuffer[1].IsValid()) mat.SetTexture(_GBuffer1ID, data.gBuffer[1]);
                            if (data.gBuffer.Length > 2 && data.gBuffer[2].IsValid()) mat.SetTexture(_GBuffer2ID, data.gBuffer[2]);
                        }

                        // 参数设置
                        mat.SetTexture(_CausticsTexture, set.causticsTexture.value);
                        mat.SetColor(_CausticsColor, set.causticsColor.value);

                        mat.SetVector(_CausticsParams, new Vector4(
                            set.scale.value,
                            set.speed.value,
                            set.distortionInfluence.value,
                            set.intensity.value
                        ));

                        mat.SetVector(_ProjectionParams_Ruri, new Vector4(
                            set.heightFalloff.value,
                            set.normalThreshold.value,
                            0, 0
                        ));

                        // 绘制全屏三角形
                        ctx.cmd.DrawProcedural(Matrix4x4.identity, mat, 0, MeshTopology.Triangles, 3);
                    });
                }
            }

            class PassData
            {
                public Material material;
                public Caustics settings;
                public TextureHandle cameraDepth;
                public TextureHandle[] gBuffer;
            }
        }
    }
}