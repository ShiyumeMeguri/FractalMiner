using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering.RenderGraphModule;

public class PunishingGrayRavenPostProcess : ScriptableRendererFeature
{
    [Serializable]
    public class Settings
    {
        public Shader poseFXShader;

        [Header("Luminance Filter")]
        public float filterThreshold = 0.3f;
        public float filterScaler = 1.0f;

        [Header("Bloom Settings")]
        public float blurDir = 1.0f;
        public Vector4 bloomCombineCoeff = new Vector4(0.35f, 0.35f, 0.35f, 0.5f);

        public Vector4 finalBlendFactor = new Vector4(0.25f, 1.0f, 0.0f, 0.0f);
        public Vector4 consoleSettings = new Vector4(0.33f, 8.0f, 0.25f, 0.06f);

        [Header("Color Grading Settings")]
        public float exposure = 13.0f;
        public float contrast = 1.8f;
        public Texture2D userLutTexture;

        public Vector4 userLutParams = new Vector4(0.00098f, 0.03125f, 31.0f, 0.0f);
    }

    public Settings settings = new Settings();
    private const string K_GRAY_RAVEN_TAG = "GrayRaven PostFX";
    private GrayRavenRenderGraphPass _renderGraphPass;

    public override void Create()
    {
        _renderGraphPass = new GrayRavenRenderGraphPass(settings)
        {
            renderPassEvent = RenderPassEvent.AfterRenderingTransparents
        };
    }

    public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
    {
        renderer.EnqueuePass(_renderGraphPass);
    }

    private class GrayRavenRenderGraphPass : ScriptableRenderPass
    {
        private readonly Settings _settings;
        private readonly Material _material;

        private readonly int _filterThresholdId = Shader.PropertyToID("_FilterThreshold");
        private readonly int _filterScalerId = Shader.PropertyToID("_FilterScaler");
        private readonly int _blurDirId = Shader.PropertyToID("_BlurDir");
        private readonly int _bloomCombineCoeffId = Shader.PropertyToID("_BloomCombineCoeff");
        private readonly int _finalBlendFactorId = Shader.PropertyToID("_FinalBlendFactor");
        private readonly int _consoleSettingsId = Shader.PropertyToID("_ConsoleSettings");
        private readonly int _exposureId = Shader.PropertyToID("_Exposure");
        private readonly int _contrastId = Shader.PropertyToID("_Contrast");
        private readonly int _userLutId = Shader.PropertyToID("_UserLut");
        private readonly int _userLutParamsId = Shader.PropertyToID("_UserLut_Params");

        private static readonly ProfilingSampler PROFILING_SAMPLER =
            new ProfilingSampler(K_GRAY_RAVEN_TAG);

        private class PassData
        {
            internal Material material;
            internal Settings settings;
            internal TextureHandle source;
            internal TextureHandle bloom0, bloom1, bloomLuma;
            internal TextureHandle bloom256_0, bloom256_1;
            internal TextureHandle bloom128_0, bloom128_1;
            internal TextureHandle bloom64_0, bloom64_1;
            internal TextureHandle bloom32_0, bloom32_1;
            internal TextureHandle combineTemp;
            internal TextureHandle colorGradingTemp;

            internal int filterThresholdId, filterScalerId;
            internal int blurDirId;
            internal int bloomCombineCoeffId, finalBlendFactorId, consoleSettingsId;
            internal int exposureId, contrastId, userLutId, userLutParamsId;
        }

        public GrayRavenRenderGraphPass(Settings settings)
        {
            _settings = settings;
            if (settings.poseFXShader == null)
            {
                settings.poseFXShader = Shader.Find("Ruri/PunishingGrayRaven/PostProcess");
            }
            _material = CoreUtils.CreateEngineMaterial(settings.poseFXShader);
        }
        public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
        {
            var resourceData = frameData.Get<UniversalResourceData>();
            var cameraData = frameData.Get<UniversalCameraData>();
            var srcHandle = resourceData.activeColorTexture;
            var desc = cameraData.cameraTargetDescriptor;
            desc.msaaSamples = 1;
            desc.depthBufferBits = 0;

            // 1) 四分之一分辨率输入
            var quarterDesc = desc;
            quarterDesc.width >>= 2;
            quarterDesc.height >>= 2;
            var bloom0 = UniversalRenderer.CreateRenderGraphTexture(renderGraph, quarterDesc, "_BloomTex0", true, FilterMode.Bilinear);
            var bloom1 = UniversalRenderer.CreateRenderGraphTexture(renderGraph, quarterDesc, "_BloomTex1", true, FilterMode.Bilinear);

            // 2) 固定 256×256 提取亮度
            var lumaDesc = desc;
            lumaDesc.width = 256;
            lumaDesc.height = 256;
            var bloomLuma = UniversalRenderer.CreateRenderGraphTexture(renderGraph, lumaDesc, "_BloomLuma", true, FilterMode.Bilinear);

            // 3) 多级模糊纹理
            var bloom256_0 = UniversalRenderer.CreateRenderGraphTexture(renderGraph, lumaDesc, "_Bloom256_0", true, FilterMode.Bilinear);
            var bloom256_1 = UniversalRenderer.CreateRenderGraphTexture(renderGraph, lumaDesc, "_Bloom256_1", true, FilterMode.Bilinear);

            var halfDesc = lumaDesc;
            halfDesc.width >>= 1;
            halfDesc.height >>= 1;
            var bloom128_0 = UniversalRenderer.CreateRenderGraphTexture(renderGraph, halfDesc, "_Bloom128_0", true, FilterMode.Bilinear);
            var bloom128_1 = UniversalRenderer.CreateRenderGraphTexture(renderGraph, halfDesc, "_Bloom128_1", true, FilterMode.Bilinear);

            var quarter2Desc = halfDesc;
            quarter2Desc.width >>= 1;
            quarter2Desc.height >>= 1;
            var bloom64_0 = UniversalRenderer.CreateRenderGraphTexture(renderGraph, quarter2Desc, "_Bloom64_0", true, FilterMode.Bilinear);
            var bloom64_1 = UniversalRenderer.CreateRenderGraphTexture(renderGraph, quarter2Desc, "_Bloom64_1", true, FilterMode.Bilinear);

            var eighthDesc = quarter2Desc;
            eighthDesc.width >>= 1;
            eighthDesc.height >>= 1;
            var bloom32_0 = UniversalRenderer.CreateRenderGraphTexture(renderGraph, eighthDesc, "_Bloom32_0", true, FilterMode.Bilinear);
            var bloom32_1 = UniversalRenderer.CreateRenderGraphTexture(renderGraph, eighthDesc, "_Bloom32_1", true, FilterMode.Bilinear);

            // 4) 合并临时 & 色彩分级临时
            var combineTemp = UniversalRenderer.CreateRenderGraphTexture(renderGraph, lumaDesc, "_BloomCombineTemp", true, FilterMode.Bilinear);
            var colorGradingTemp = UniversalRenderer.CreateRenderGraphTexture(renderGraph, desc, "_ColorGradingTemp", true, FilterMode.Bilinear);

            using (var builder = renderGraph.AddUnsafePass<PassData>(K_GRAY_RAVEN_TAG, out var pd, PROFILING_SAMPLER))
            {
                builder.AllowPassCulling(false);

                // 资源声明
                builder.UseTexture(srcHandle, AccessFlags.ReadWrite);
                builder.UseTexture(bloom0, AccessFlags.ReadWrite);
                builder.UseTexture(bloom1, AccessFlags.ReadWrite);
                builder.UseTexture(bloomLuma, AccessFlags.ReadWrite);
                builder.UseTexture(bloom256_0, AccessFlags.ReadWrite);
                builder.UseTexture(bloom256_1, AccessFlags.ReadWrite);
                builder.UseTexture(bloom128_0, AccessFlags.ReadWrite);
                builder.UseTexture(bloom128_1, AccessFlags.ReadWrite);
                builder.UseTexture(bloom64_0, AccessFlags.ReadWrite);
                builder.UseTexture(bloom64_1, AccessFlags.ReadWrite);
                builder.UseTexture(bloom32_0, AccessFlags.ReadWrite);
                builder.UseTexture(bloom32_1, AccessFlags.ReadWrite);
                builder.UseTexture(combineTemp, AccessFlags.ReadWrite);
                builder.UseTexture(colorGradingTemp, AccessFlags.ReadWrite);

                // 数据传递
                pd.material = _material;
                pd.settings = _settings;
                pd.source = srcHandle;
                pd.bloom0 = bloom0;
                pd.bloom1 = bloom1;
                pd.bloomLuma = bloomLuma;
                pd.bloom256_0 = bloom256_0;
                pd.bloom256_1 = bloom256_1;
                pd.bloom128_0 = bloom128_0;
                pd.bloom128_1 = bloom128_1;
                pd.bloom64_0 = bloom64_0;
                pd.bloom64_1 = bloom64_1;
                pd.bloom32_0 = bloom32_0;
                pd.bloom32_1 = bloom32_1;
                pd.combineTemp = combineTemp;
                pd.colorGradingTemp = colorGradingTemp;
                pd.filterThresholdId = _filterThresholdId;
                pd.filterScalerId = _filterScalerId;
                pd.blurDirId = _blurDirId;
                pd.bloomCombineCoeffId = _bloomCombineCoeffId;
                pd.finalBlendFactorId = _finalBlendFactorId;
                pd.consoleSettingsId = _consoleSettingsId;
                pd.exposureId = _exposureId;
                pd.contrastId = _contrastId;
                pd.userLutId = _userLutId;
                pd.userLutParamsId = _userLutParamsId;

                builder.SetRenderFunc((PassData data, UnsafeGraphContext ctx) =>
                {
                    var cmd = CommandBufferHelpers.GetNativeCommandBuffer(ctx.cmd);
                    var mat = data.material;
                    var s = data.settings;
                    var load = RenderBufferLoadAction.DontCare;
                    var store = RenderBufferStoreAction.Store;

                    cmd.BeginSample(K_GRAY_RAVEN_TAG);

                    // 1) 四分之一分辨率模糊
                    Blitter.BlitCameraTexture(cmd, data.source, data.bloom0, load, store, mat, 0);
                    Blitter.BlitCameraTexture(cmd, data.bloom0, data.bloom1, load, store, mat, 0);

                    // 2) 提取亮度
                    mat.SetFloat(data.filterScalerId, s.filterScaler);
                    mat.SetFloat(data.filterThresholdId, s.filterThreshold);
                    Blitter.BlitCameraTexture(cmd, data.bloom1, data.bloomLuma, load, store, mat, 1);

                    // 3) 256 模糊 (5x5)
                    cmd.SetGlobalVector(data.blurDirId, new Vector4(s.blurDir, 0, 0, 0));
                    Blitter.BlitCameraTexture(cmd, data.bloomLuma, data.bloom256_0, load, store, mat, 2);
                    cmd.SetGlobalVector(data.blurDirId, new Vector4(0, s.blurDir, 0, 0));
                    Blitter.BlitCameraTexture(cmd, data.bloom256_0, data.bloom256_1, load, store, mat, 2);

                    // 4) 128 模糊 (8x8)
                    cmd.Blit(data.bloom256_1, data.bloom128_0);
                    cmd.SetGlobalVector(data.blurDirId, new Vector4(s.blurDir, 0, 0, 0));
                    Blitter.BlitCameraTexture(cmd, data.bloom128_0, data.bloom128_1, load, store, mat, 3);
                    cmd.SetGlobalVector(data.blurDirId, new Vector4(0, s.blurDir, 0, 0));
                    Blitter.BlitCameraTexture(cmd, data.bloom128_1, data.bloom128_0, load, store, mat, 3);

                    // 5) 64 模糊 (11x11)
                    cmd.Blit(data.bloom128_0, data.bloom64_0);
                    cmd.SetGlobalVector(data.blurDirId, new Vector4(s.blurDir, 0, 0, 0));
                    Blitter.BlitCameraTexture(cmd, data.bloom64_0, data.bloom64_1, load, store, mat, 4);
                    cmd.SetGlobalVector(data.blurDirId, new Vector4(0, s.blurDir, 0, 0));
                    Blitter.BlitCameraTexture(cmd, data.bloom64_1, data.bloom64_0, load, store, mat, 4);

                    // 6) 32 模糊 (11x11)
                    cmd.Blit(data.bloom64_0, data.bloom32_0);
                    cmd.SetGlobalVector(data.blurDirId, new Vector4(s.blurDir, 0, 0, 0));
                    Blitter.BlitCameraTexture(cmd, data.bloom32_0, data.bloom32_1, load, store, mat, 4);
                    cmd.SetGlobalVector(data.blurDirId, new Vector4(0, s.blurDir, 0, 0));
                    Blitter.BlitCameraTexture(cmd, data.bloom32_1, data.bloom32_0, load, store, mat, 4);

                    // 7) 合并四级结果
                    cmd.SetGlobalTexture("_BloomTex0", data.bloom256_1);
                    cmd.SetGlobalTexture("_BloomTex1", data.bloom128_1);
                    cmd.SetGlobalTexture("_BloomTex2", data.bloom64_1);
                    cmd.SetGlobalTexture("_BloomTex3", data.bloom32_1);
                    cmd.SetGlobalVector(data.bloomCombineCoeffId, s.bloomCombineCoeff);
                    Blitter.BlitCameraTexture(cmd, data.combineTemp, data.combineTemp, load, store, mat, 5);

                    // 8) 色彩分级 & 输出
                    mat.SetTexture(data.userLutId, s.userLutTexture);
                    Shader.SetGlobalVector(data.consoleSettingsId, s.consoleSettings);
                    Shader.SetGlobalFloat(data.contrastId, s.contrast);
                    Shader.SetGlobalFloat(data.exposureId, s.exposure);
                    Shader.SetGlobalVector(data.finalBlendFactorId, s.finalBlendFactor);
                    Shader.SetGlobalVector(data.userLutParamsId, s.userLutParams);
                    cmd.SetGlobalTexture("_BloomTex", data.combineTemp);
                    Blitter.BlitCameraTexture(cmd, data.source, data.source, load, store, mat, 6);

                    cmd.EndSample(K_GRAY_RAVEN_TAG);
                });
            }
        }
    }
}
