using System.Collections.Generic;
using Ruri.Rendering.Overrides;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal;

namespace Ruri.Rendering.Feature
{
    [DisallowMultipleRendererFeature("Ruri Geometric Distortion")]
    public class GeometricDistortionFeature : ScriptableRendererFeature
    {
        [SerializeField] private Shader simulationShader;
        [SerializeField] private Shader accumulateShader;

        private GeometricDistortionPass _pass;

        public override void Create()
        {
            if (simulationShader == null)
                simulationShader = Shader.Find("Hidden/Ruri/GeometricDistortionSim");

            if (accumulateShader == null)
                accumulateShader = Shader.Find("Hidden/Ruri/GeometricDistortionAccumulate");

            _pass = new GeometricDistortionPass
            {
                renderPassEvent = RenderPassEvent.BeforeRendering
            };
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            if (renderingData.cameraData.cameraType == CameraType.Preview ||
                renderingData.cameraData.cameraType == CameraType.Reflection)
                return;

            if (simulationShader == null) return;

            _pass.Setup(simulationShader, accumulateShader);
            renderer.EnqueuePass(_pass);
        }

        protected override void Dispose(bool disposing)
        {
            _pass?.Dispose();
        }

        private class GeometricDistortionPass : ScriptableRenderPass
        {
            private Material _simMaterial;
            private Material _accumulateMaterial;
            private GeometricDistortion _settings;

            private RTHandle[] _historyBuffers = new RTHandle[2];
            private int _currentBufferIndex = 0;
            private bool _historyValid = false;

            private int _lastResolution;
            private float _lastSize;

            private static readonly int _WavePreFrame = Shader.PropertyToID("_WavePreFrame");
            private static readonly int _WaveSuperPreFrame = Shader.PropertyToID("_WaveSuperPreFrame");
            private static readonly int _CubeData = Shader.PropertyToID("cubeData");
            private static readonly int _SimulationTexelSize = Shader.PropertyToID("_SimulationTexelSize");
            private static readonly int _DistortionInput = Shader.PropertyToID("_DistortionInput");

            private static readonly int _GeometricDistortionMap = Shader.PropertyToID("_GeometricDistortionMap");
            private static readonly int _DistortionMatrixVP = Shader.PropertyToID("_DistortionMatrixVP");
            private static readonly int _DistortionParams = Shader.PropertyToID("_DistortionParams");
            private static readonly int _DistortionCenter = Shader.PropertyToID("_DistortionCenter");
            private static readonly int _DistortionDirection = Shader.PropertyToID("_DistortionDirection");

            private FilteringSettings _filteringSettings;
            private List<ShaderTagId> _shaderTagIds = new List<ShaderTagId>() { new ShaderTagId("GeometricDistortion") };

            public GeometricDistortionPass()
            {
                _filteringSettings = new FilteringSettings(RenderQueueRange.transparent);
            }

            public void Setup(Shader simShader, Shader accShader)
            {
                if (_simMaterial == null) _simMaterial = CoreUtils.CreateEngineMaterial(simShader);
                if (_accumulateMaterial == null && accShader != null) _accumulateMaterial = CoreUtils.CreateEngineMaterial(accShader);
            }

            public void Dispose()
            {
                CoreUtils.Destroy(_simMaterial);
                CoreUtils.Destroy(_accumulateMaterial);
                for (int i = 0; i < 2; i++)
                {
                    _historyBuffers[i]?.Release();
                    _historyBuffers[i] = null;
                }
            }

            private void EnsureBuffers(int resolution)
            {
                var desc = new RenderTextureDescriptor(resolution, resolution, RenderTextureFormat.RFloat, 0);
                desc.msaaSamples = 1;
                desc.useMipMap = false;
                desc.sRGB = false;

                bool realloc = false;
                for (int i = 0; i < 2; i++)
                {
                    realloc |= RenderingUtils.ReAllocateHandleIfNeeded(ref _historyBuffers[i], desc, FilterMode.Bilinear, TextureWrapMode.Clamp, name: $"_GeometricDistortion_{i}");
                }

                if (realloc) _historyValid = false;
            }

            public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
            {
                var stack = VolumeManager.instance.stack;
                _settings = stack.GetComponent<GeometricDistortion>();

                if (_settings == null || !_settings.IsActive())
                {
                    Shader.SetGlobalVector(_DistortionParams, Vector4.zero);
                    return;
                }

                var urpData = frameData.Get<UniversalRenderingData>();
                var cameraData = frameData.Get<UniversalCameraData>();
                var cullResults = urpData.cullResults;

                int resolution = _settings.simulationResolution.value;
                float areaSize = _settings.areaSize.value;
                Vector3 centerPos = _settings.centerPosition.value;

                if (_historyValid)
                {
                    if (resolution != _lastResolution || Mathf.Abs(areaSize - _lastSize) > 0.01f)
                        _historyValid = false;
                }

                _lastResolution = resolution;
                _lastSize = areaSize;

                EnsureBuffers(resolution);

                int readIdx = _currentBufferIndex;
                int writeIdx = (_currentBufferIndex + 1) % 2;
                _currentBufferIndex = writeIdx;

                Matrix4x4 view = Matrix4x4.TRS(centerPos + Vector3.up * 100f, Quaternion.LookRotation(Vector3.down, Vector3.forward), Vector3.one).inverse;
                Matrix4x4 proj = Matrix4x4.Ortho(-areaSize * 0.5f, areaSize * 0.5f, -areaSize * 0.5f, areaSize * 0.5f, 0.1f, 200f);
                Matrix4x4 gpuProj = GL.GetGPUProjectionMatrix(proj, true);
                Matrix4x4 vp = gpuProj * view;

                Shader.SetGlobalMatrix(_DistortionMatrixVP, vp);
                Shader.SetGlobalVector(_DistortionParams, new Vector4(_settings.displacementScale.value, _settings.innerRadius.value, _settings.outerRadius.value, 0));
                Shader.SetGlobalVector(_DistortionCenter, centerPos);
                Shader.SetGlobalVector(_DistortionDirection, _settings.displacementDirection.value.normalized);

                var preFrameHandle = renderGraph.ImportTexture(_historyBuffers[readIdx]);
                var targetHandle = renderGraph.ImportTexture(_historyBuffers[writeIdx]);

                var tempDesc = renderGraph.GetTextureDesc(targetHandle);
                tempDesc.name = "SuperPreFrameTemp";
                var superPreFrameHandle = renderGraph.CreateTexture(tempDesc);

                if (!_historyValid)
                {
                    AddClearPass(renderGraph, preFrameHandle);
                    AddClearPass(renderGraph, targetHandle);
                    AddClearPass(renderGraph, superPreFrameHandle);
                    _historyValid = true;
                }
                else
                {
                    AddCopyPass(renderGraph, targetHandle, superPreFrameHandle);
                }

                // 1. Brush Input Pass
                var brushColorDesc = new TextureDesc(resolution, resolution);
                brushColorDesc.colorFormat = GraphicsFormat.R16_SFloat;
                brushColorDesc.depthBufferBits = DepthBits.None;
                brushColorDesc.msaaSamples = MSAASamples.None;
                brushColorDesc.name = "DistortionBrushColor";
                var brushColorHandle = renderGraph.CreateTexture(brushColorDesc);

                RendererListHandle rendererList = renderGraph.CreateRendererList(
                    new RendererListParams(cullResults,
                    new DrawingSettings(_shaderTagIds[0], new SortingSettings(cameraData.camera)) { perObjectData = PerObjectData.None },
                    _filteringSettings));

                using (var builder = renderGraph.AddRasterRenderPass<InputPassData>("Distortion Brush", out var passData))
                {
                    builder.SetRenderAttachment(brushColorHandle, 0, AccessFlags.Write);
                    builder.UseRendererList(rendererList);

                    passData.view = view;
                    passData.proj = gpuProj;
                    passData.rendererList = rendererList;

                    builder.SetRenderFunc((InputPassData data, RasterGraphContext ctx) =>
                    {
                        ctx.cmd.ClearRenderTarget(false, true, Color.black);
                        ctx.cmd.SetViewProjectionMatrices(data.view, data.proj);
                        ctx.cmd.DrawRendererList(data.rendererList);
                    });
                }

                // 2. Accumulate Pass
                using (var builder = renderGraph.AddUnsafePass<AccumulatePassData>("Distortion Accumulate", out var passData))
                {
                    builder.UseTexture(brushColorHandle, AccessFlags.Read);
                    builder.UseTexture(preFrameHandle, AccessFlags.ReadWrite);

                    passData.material = _accumulateMaterial;
                    passData.input = brushColorHandle;
                    passData.targetRT = _historyBuffers[readIdx];

                    builder.SetRenderFunc((AccumulatePassData data, UnsafeGraphContext ctx) =>
                    {
                        var cmd = CommandBufferHelpers.GetNativeCommandBuffer(ctx.cmd);
                        CoreUtils.SetRenderTarget(cmd, data.targetRT, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, ClearFlag.None, Color.black);

                        if (data.material != null)
                        {
                            data.material.SetTexture(_DistortionInput, data.input);
                            CoreUtils.DrawFullScreen(cmd, data.material, null, 0);
                        }
                    });
                }
                // 3. Simulation Pass
                using (var builder = renderGraph.AddRasterRenderPass<SimPassData>("Distortion Simulation", out var passData))
                {
                    builder.SetRenderAttachment(targetHandle, 0, AccessFlags.Write);
                    builder.UseTexture(preFrameHandle, AccessFlags.Read);
                    builder.UseTexture(superPreFrameHandle, AccessFlags.Read);

                    builder.SetGlobalTextureAfterPass(targetHandle, _GeometricDistortionMap);

                    passData.material = _simMaterial;
                    passData.preFrame = preFrameHandle;
                    passData.superPreFrame = superPreFrameHandle;
                    passData.texelSize = new Vector4(1.0f / resolution, 1.0f / resolution, resolution, resolution);

                    // [Ruri Context Fix] 
                    // 还原 Quantum Break 的数值环境。
                    // 原版 Shader 里的常数 (400.0, -0.043943) 都是基于 dt ~= 0.033 (30FPS) 调整的。
                    // 为了保证算法表现一致（正确的衰减和波速），必须锁定传入 Shader 的 dt。

                    // 1. 固定时间步长 (Fixed Timestep for Physics)
                    // 不要使用 Time.deltaTime，否则高帧率下 dt*decay 趋近于 0，阻尼会失效导致永动。
                    float fixedDt = 0.033f;

                    // 2. 阻尼 (Decay Factor)
                    // RenderDoc 抓取值为 1.5 左右。
                    // 在原版公式中：weight = dt * decay - 1.0
                    // 如果 dt=0.033, decay=1.5 -> weight = 0.05 - 1.0 = -0.95
                    // 这意味着旧的一帧保留 95% 的能量（反向）。
                    float decay = _settings.decayFactor.value;

                    // 3. 高度限制 (Clamping)
                    // RenderDoc 抓取值为 6.0
                    float clampVal = _settings.heightClamp.value;

                    // 4. 传递参数
                    // x: DecayFactor (1.5)
                    // y: Clamping (6.0)
                    // z: RippleTimeDelta (0.033 - Fixed)
                    // w: Unused (400.0 is hardcoded in shader now)
                    passData.cubeData = new Vector4(decay, clampVal, fixedDt, 0);

                    builder.SetRenderFunc((SimPassData data, RasterGraphContext ctx) =>
                    {
                        if (data.material != null)
                        {
                            data.material.SetTexture(_WavePreFrame, data.preFrame);
                            data.material.SetTexture(_WaveSuperPreFrame, data.superPreFrame);
                            data.material.SetVector(_CubeData, data.cubeData);
                            data.material.SetVector(_SimulationTexelSize, data.texelSize);

                            Blitter.BlitTexture(ctx.cmd, data.preFrame, new Vector4(1, 1, 0, 0), data.material, 0);
                        }
                    });
                }
            }

            private void AddClearPass(RenderGraph graph, TextureHandle tex)
            {
                using var builder = graph.AddRasterRenderPass<ClearPassData>("Clear", out var _);
                builder.SetRenderAttachment(tex, 0, AccessFlags.Write);
                builder.SetRenderFunc((ClearPassData _, RasterGraphContext ctx) => ctx.cmd.ClearRenderTarget(false, true, Color.black));
            }

            private void AddCopyPass(RenderGraph graph, TextureHandle src, TextureHandle dst)
            {
                using var builder = graph.AddRasterRenderPass<CopyPassData>("Copy History", out var data);
                builder.UseTexture(src, AccessFlags.Read);
                builder.SetRenderAttachment(dst, 0, AccessFlags.Write);
                data.src = src;
                builder.SetRenderFunc((CopyPassData pd, RasterGraphContext ctx) => Blitter.BlitTexture(ctx.cmd, pd.src, new Vector4(1, 1, 0, 0), 0, false));
            }

            class InputPassData { public Matrix4x4 view; public Matrix4x4 proj; public RendererListHandle rendererList; }
            class AccumulatePassData { public Material material; public TextureHandle input; public RTHandle targetRT; }
            class SimPassData { public Material material; public TextureHandle preFrame; public TextureHandle superPreFrame; public Vector4 cubeData; public Vector4 texelSize; }
            class CopyPassData { public TextureHandle src; }
            class ClearPassData { }
        }
    }
}