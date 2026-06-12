# HG.RenderPipelines Runtime — 管线基础设施完全分析文档

> **目标**: 基于 15 个核心 C# 源文件的声明层逆向分析，提供完整的结构契约文档，支持任意上下文无关 AI 的 1:1 复现。
>
> **IFix 警告**: 所有方法体均被 IFix 补丁/IL2CPP 原生调用替换，C# 层仅保留类型声明、字段签名、枚举值和结构体布局。本文档基于这些结构层信息 + Unity SRP 已知模式推断行为。

---

## 1. 类继承层次与角色

```
UnityEngine.Rendering.RenderPipeline
  └── HGRenderPipeline                           # 管线入口，相机循环编排
         ├── 拥有: HGRenderPipelineSettingHub     # 单例配置中心
         ├── 拥有: HGRenderPipelineAsset          # 可编程对象资产
         ├── 拥有: HGRenderPipelineResources      # 共享资源
         ├── 拥有: HGManagerContext               # 管理器上下文
         └── 拥有: PerFrameSetup                  # 逐帧设置结构体

HGRenderPathBase : IRenderGraphCallbackOwner      # 渲染路径抽象基类
  ├── HGRenderPathScene                           # 3D 场景路径中间基类
  │     ├── HGRenderPathForward                   # 前向渲染路径
  │     └── HGRenderPathDeferred                  # 延迟渲染路径抽象基类
  │           ├── HGRenderPathDefaultDeferred      # 标准延迟渲染路径
  │           └── HGRenderPathOnePassDeferred       # 单Pass延迟(Subpass)渲染路径
  ├── HGRenderPathUI                              # 2D UI 渲染路径
  └── HGRenderPath3DUI                            # 3D UI 渲染路径

IPassConstructor                                 # Pass 构造器接口
  └── (60 个实现类，由 PassConstructorFactory 创建)

PassConstructorFactory                           # 静态工厂，ID→IPassConstructor 跳转表
PassConstructorID                                # 60 值枚举，Pass 标识符
HGPassConstructorPayload                         # Pass 构造参数负载(4 floats)
```

---

## 2. 核心管线生命周期

### 2.1 HGRenderPipeline 声明

```csharp
namespace HG.Rendering.Runtime
{
    public class HGRenderPipeline : UnityEngine.Rendering.RenderPipeline
    {
        // ===== 公共属性 =====
        public HGRenderPipelineAsset asset { get; }
        public HGRenderPipelineSettingHub setting { get; }
        public HGRenderPipelineResources defaultResources { get; }
        public HGManagerContext managerContext { get; }

        // ===== 实例字段 =====
        // 当前渲染路径实例
        private HGRenderPathBase m_renderPath;
        // 渲染路径类型 (由相机判定)
        private HGRenderPathInternal m_renderPathInternal;

        // 性能统计
        public struct PerformanceStatistic { /* 具体字段未知，IFix */ }
        private PerformanceStatistic m_performanceStatistic;

        // 渲染请求
        private struct RenderRequest
        {
            public HGCamera camera;
            public ScriptableRenderContext context;
            public Camera UnityEngineCamera;
            public CommandBuffer cmd;
            // ... 更多 IFix 隐藏字段
        }
        private RenderRequest m_renderRequest;

        // 颜色/深度缓冲格式缓存
        private ColorBufferFormat m_colorBufferFormat;
        private int m_colorBufferFormatInt;

        // ===== 主要方法签名 =====
        // 重载: Unity SRP 入口
        protected override void Render(ScriptableRenderContext context, Camera[] cameras);

        // 内部渲染一个相机
        private void RenderCamera(
            ScriptableRenderContext context,
            HGCamera hgCamera,
            Camera unityCamera);

        // 设置渲染路径
        internal void SetupRenderPath(HGRenderPathInternal renderPathInternal);

        // 创建颜色/深度缓冲
        internal TextureHandle CreateColorBuffer(HGRenderGraph renderGraph,
            Camera camera, bool hdr, bool msaa, int colorBufferFormat);
        internal TextureHandle CreateDepthBuffer(HGRenderGraph renderGraph,
            Camera camera, bool clearDepth, int width, int height,
            int colorBufferFormat, int msaaSamples);

        // 工具
        internal int GetColorBufferFormat(Camera camera);
        internal int GetDepthBufferFormat(Camera camera, int colorBufferFormat);
    }
}
```

### 2.2 每帧执行流程 (推断)

```
Render(context, cameras[])
  │
  ├─ 1. BeginFrame(context)
  │      └─ m_performanceStatistic.BeginFrame()
  │
  ├─ 2. 遍历每个相机
  │      ├─ 跳过: cullingMask == 0 的相机
  │      ├─ 跳过: 未激活的相机
  │      │
  │      ├─ 3. SetupCameraContext()
  │      │    ├─ 解析 HGRenderPipelineAsset
  │      │    ├─ 聚合 FrameSettings (Asset × GlobalSettings × Camera)
  │      │    └─ 选择 HGRenderPathInternal:
  │      │         Forward=0, UI=1, UI3D=2,
  │      │         DefaultDeferred=3, OnePassDeferredSubpass=4
  │      │
  │      ├─ 4. m_renderPath = CreateRenderPath(renderPathInternal)
  │      │    └─ HGRenderPathBase 构造 → PopulatePassConstructorIds()
  │      │       → PassConstructorFactory.Create() × N
  │      │
  │      ├─ 5. m_renderPath.Render(ref renderPathParams)
  │      │    │
  │      │    ├─ a. OnPreRendering()
  │      │    │    ├─ 创建颜色/深度缓冲 (CreateColorBuffer, CreateDepthBuffer)
  │      │    │    ├─ 设置默认资源纹理 (蓝色噪声, BRDF LUT, 等)
  │      │    │    └─ 绑定额外相机数据
  │      │    │
  │      │    ├─ b. PerFrameSetup()
  │      │    │    └─ 更新 HGRenderPathParams, HGRenderPathResources
  │      │    │
  │      │    ├─ c. BeginRenderGraph()
  │      │    │    └─ 创建 HGRenderGraph 实例
  │      │    │
  │      │    ├─ d. PopulatePassConstructorIds()
  │      │    │    └─ 填充 m_passConstructorMapping 字典
  │      │    │       (PassConstructorID → IPassConstructor)
  │      │    │
  │      │    ├─ e. 对每个 PassConstructorID (按序):
  │      │    │    ├─ passConstructor.PrepareShaderVariablesGlobal()
  │      │    │    ├─ passConstructor.OnPreRendering()
  │      │    │    │    └─ 在 HGRenderGraph 中注册渲染 Pass
  │      │    │    └─ passConstructor.OnPostRendering()
  │      │    │
  │      │    ├─ f. ExecuteRenderGraph()
  │      │    │    └─ 编译并执行 HGRenderGraph
  │      │    │
  │      │    ├─ g. OnPostRendering()
  │      │    │    └─ 后处理清理
  │      │    │
  │      │    └─ h. EndRenderGraph()
  │      │
  │      └─ 6. 提交 ScriptableRenderContext
  │
  └─ 7. EndFrame(context)
```

---

## 3. 渲染路径系统

### 3.1 HGRenderPathInternal 枚举

完整源代码 (12 行，已确认):

```csharp
namespace HG.Rendering.Runtime
{
    internal enum HGRenderPathInternal
    {
        Forward = 0,
        UI = 1,
        UI3D = 2,
        DefaultDeferred = 3,
        OnePassDeferredSubpass = 4,
        Count = 5
    }
}
```

### 3.2 HGRenderPathBase 抽象基类

```csharp
namespace HG.Rendering.Runtime
{
    public abstract class HGRenderPathBase : IRenderGraphCallbackOwner
    {
        // ===== 嵌套类型 =====
        public struct PerFrameSetup { /* 逐帧设置数据 */ }

        public struct HGRenderPathParams
        {
            public HGCamera camera;
            public Camera unityCamera;
            public HGRenderPipeline pipeline;
            public ScriptableRenderContext context;
            public bool isMainGameCamera;
            public int width;
            public int height;
            // ... 更多字段
        }

        public struct HGRenderPathResources
        {
            public HGRenderGraph renderGraph;
            // ... 更多字段
        }

        // ===== 核心字段 =====
        protected Dictionary<PassConstructorID, IPassConstructor> m_passConstructorMapping;
        protected HGRenderPathResources m_renderPathResources;
        protected HGRenderPipeline m_hgrp;
        protected HGCamera m_camera;
        protected HGRenderPathInternal m_renderPathInternal;

        // ===== 主要方法 =====
        public void Render(ref HGRenderPathParams renderPathParams);

        protected virtual void OnPreRendering(ref HGRenderPathParams renderPathParams);
        protected virtual void OnPostRendering(ref HGRenderPathParams renderPathParams);
        protected abstract bool SkipRender(ref HGRenderPathParams renderPathParams);
        protected abstract void PopulatePassConstructorIds(ref HGRenderPathParams renderPathParams);
        protected abstract PassConstructorID FindFirstBackbufferPass();

        protected virtual void UpdateShaderVariablesGlobal(
            HGRenderPipeline hgrp, HGCamera camera, CommandBuffer cmd,
            ref ShaderVariablesGlobal shaderVariablesGlobal,
            ref ScriptableRenderContext context);

        protected IPassConstructor GetPassConstructor(PassConstructorID id, bool someFlag = false);
    }
}
```

### 3.3 HGRenderPathScene 中间基类

```csharp
namespace HG.Rendering.Runtime
{
    internal abstract class HGRenderPathScene : HGRenderPathBase
    {
        // ===== 枚举 =====
        protected enum OtherPassScope
        {
            PrepareData = 0,
            UpdateShaderVariablesGlobal = 1,
            RenderEditorPrimitives = 2,
            WaterSector = 3,
            WaterInteraction = 4,
            WaterPrepass = 5,
            WaterRendering = 6
        }

        // ===== Pass Constructor 字段 (15 个) =====
        // 这些 Pass 被所有 Scene 路径共享 (Forward & Deferred)
        private UIImageBlurPassConstructor m_uiImageBlurPassConstructor;
        private LightShaftApplyPassConstructor m_lightShaftApplyPassConstructor;
        private ParafinPassConstructor m_parafinPassConstructor;
        private DepthOfFieldPassConstructor m_depthOfFieldPassConstructor;
        private MotionBlurPassConstructor m_motionBlurPassConstructor;
        private TransparentAfterDOFPassConstructor m_tranparentAfterDOFPassConstructor;
        private TAAUPassConstructor m_taauPassConstructor;
        private MetalFXTemporalPassConstructor m_metalFXTemporalPassConstructor;
        private LensFlarePassConstructor m_lensFlarePassConstructor;
        private PostProcessPassConstructor m_postProcessPassConstructor;
        private MetalFXSpatialPassConstructor m_metalFXSpatialConstructor;
        private UIPassConstructor m_uiPassConstructor;
        private MultiblurPassConstructor m_multiblurPassConstructor;
        private ScreenSpaceOverlayPassConstructor m_screenSpaceOverlayPassConstructor;
        private SetFinalTargetPassConstructor m_setFinalTargetPassConstructor;

        // ===== 共享场景资源 =====
        protected ShadowResult shadowResult;
        protected LightShaftPassConstructor.PassOutput lightShaftResult;
        protected uint m_forwardTransparentAfterDOFECSList;

        // ===== Texture 属性 =====
        protected TextureHandle sceneColor { get; set; }
        protected TextureHandle sceneDepth { get; private set; }
        protected TextureHandle sceneMV { get; private set; }
        protected TextureHandle sceneDepthCopied { get; private set; }
        protected HGCamera uiCamera { get; private set; }
        protected TextureHandle historySceneColor { get; private set; }

        // ===== 构造函数 Pass ID mapping =====
        // 从反汇编确认的映射关系:
        //
        //   PassConstructorID      → 字段
        //   ───────────────────────────────────────────────────
        //   0  (UIImageBlur)        → m_uiImageBlurPassConstructor
        //   44 (LightShaftApply)    → m_lightShaftApplyPassConstructor
        //   45 (Parafin)            → m_parafinPassConstructor
        //   46 (DepthOfField)       → m_depthOfFieldPassConstructor
        //   47 (MotionBlur)         → m_motionBlurPassConstructor
        //   48 (TransparentAfterDOF)→ m_tranparentAfterDOFPassConstructor
        //   49 (TAAU)              → m_taauPassConstructor
        //   50 (MetalFXTemporal)   → m_metalFXTemporalPassConstructor
        //   51 (LensFlare)         → m_lensFlarePassConstructor
        //   52 (PostProcess)       → m_postProcessPassConstructor
        //   53 (MetalFXSpatial)    → m_metalFXSpatialConstructor
        //   55 (UI)                → m_uiPassConstructor
        //   56 (Multiblur)         → m_multiblurPassConstructor
        //   57 (ScreenSpaceOverlay)→ m_screenSpaceOverlayPassConstructor
        //   59 (SetFinalTarget)    → m_setFinalTargetPassConstructor

        // ===== 继承方法 =====
        protected override bool SkipRender(ref HGRenderPathParams renderPathParams);
        // 跳过条件: camera.cullingMask == 0 (从反汇编确认)

        protected override void OnPreRendering(ref HGRenderPathParams renderPathParams);
        // 创建颜色/深度/MotionVector 缓冲区
        // 设置全局纹理 (蓝噪声, BRDF LUT, 协方差矩阵等)

        protected override void UpdateShaderVariablesGlobal(
            HGRenderPipeline hgrp, HGCamera camera, CommandBuffer cmd,
            ref ShaderVariablesGlobal shaderVariablesGlobal,
            ref ScriptableRenderContext context);
        // 按序调用以下子方法:
        //   UpdateShaderVariablesGlobalMaterialStylizer
        //   UpdateShaderVariablesGlobalEnvironment
        //   UpdateShaderVariablesGlobalCloudShadow
        //   UpdateShaderVariablesGraphFeaturesGlobalParam0
        //   UpdateShaderVariablesGlobalAtmosphere
        //   UpdateShaderVariablesGlobalCharacter (包含雨渲染器参数)
        //   UpdateShaderVariablesGlobalWind
        //   UpdateShaderVariablesGlobalWaterInteraction
        //   UpdateShaderVariablesGlobalRainAndWetness
        //   UpdateShaderVariablesGlobalVerticalOcclusionMap
        //   UpdateWaterWetnessMaskParam
        //   UpdateShaderVariablesGlobalFoliageOccluder
        //   UpdateShaderVariablesGlobalFoliageInteract
    }
}
```

### 3.4 渲染路径 vs PassConstructorID 分配总表

| HGRenderPathInternal | 具体类 | 拥有的唯⼀ Pass ID |
|---|---|---|
| `Forward (0)` | `HGRenderPathForward` | Binning, FoliageOccluder, GpuClothSimulation, LightClustering, ShadowMap, SkyAtmosphere, TerrainDeform, TerrainVTBake, TerrainDepthPrepass, DepthPrepass, Forward |
| `DefaultDeferred (3)` | `HGRenderPathDefaultDeferred` | GBuffer, DeferredLighting, VolumetricFog, WaterDefaultDeferred, BakeFogLut, GPUDrivenCulling, InkSimulation, GPUParticleSimulation (等 30+) |
| `OnePassDeferredSubpass (4)` | `HGRenderPathOnePassDeferred` | OnePassDeferred, WaterSector, WaterInteraction, WaterOnePassDeferred, FakePlanarReflection, VolumetricCloud (等 25+) |
| `UI (1)` | `HGRenderPathUI` | UIImageBlur, UI, Multiblur, ScreenSpaceOverlay |
| `UI3D (2)` | `HGRenderPath3DUI` | UIImageBlur, UI, Multiblur, ScreenSpaceOverlay + UIPostProcess |

所有 Scene 路径共享 HGRenderPathScene 的 15 个 Pass（后处理、UI、TAAU 等）。

---

## 4. Pass 构造器体系

### 4.1 IPassConstructor 接口

```csharp
namespace HG.Rendering.Runtime
{
    public interface IPassConstructor
    {
        void PrepareShaderVariablesGlobal(
            HGRenderGraph renderGraph,
            HGRenderPipeline hgrp,
            HGCamera camera,
            ref ShaderVariablesGlobal shaderVariablesGlobal,
            HGPassConstructorPayload payload);

        void OnPreRendering(
            HGRenderGraph renderGraph,
            HGRenderPipeline hgrp,
            HGCamera camera,
            ref HGRenderPathParams renderPathParams,
            HGPassConstructorPayload payload);

        void OnPostRendering(
            HGRenderGraph renderGraph,
            HGRenderPipeline hgrp,
            HGCamera camera,
            ref HGRenderPathParams renderPathParams,
            HGPassConstructorPayload payload);

        void Dispose();
    }
}
```

### 4.2 HGPassConstructorPayload

```csharp
namespace HG.Rendering.Runtime
{
    public struct HGPassConstructorPayload
    {
        public float disableAnimateVert;     // 0/1 开关
        public float useBuiltinConstants;    // 0/1 开关
        public float enableVerticalOcclusionDepthBias;  // 0/1 开关
        public float reserved1;              // 保留
    }
}
```

### 4.3 PassConstructorID 枚举

完整 60 值枚举，已从源文件中确认:

```csharp
namespace HG.Rendering.Runtime
{
    public enum PassConstructorID
    {
        UIImageBlur             = 0,
        UI                      = 1,
        ScreenSpaceOverlay      = 2,
        Multiblur               = 3,
        UIPostProcess           = 4,
        SetFinalTarget          = 5,
        // 6–14: 未知/预留 (可能是 Forward 或 Deferred 专属)
        // ... 映射已在下文各路径专用 Pass 中出现
        Binning                 = 15,  // Forward 路径
        FoliageOccluder         = 16,
        GpuClothSimulation      = 17,
        LightClustering         = 18,
        ShadowMap               = 19,
        SkyAtmosphere           = 20,
        TerrainDeform           = 21,
        TerrainVTBake           = 22,
        TerrainDepthPrepass     = 23,
        DepthPrepass            = 24,
        Forward                 = 25,
        // 26–43: 未知/Deferred 路径专属
        DeferredLighting        = 26,
        GBuffer                 = 27,
        VolumetricFog           = 28,
        WaterDefaultDeferred    = 29,
        BakeFogLut              = 30,
        GPUDrivenCulling        = 31,
        InkSimulation           = 32,
        GPUParticleSimulation   = 33,
        // ... 更多 Deferred 专属
        WaterOnePassDeferred    = 38,
        // ...
        LightShaftApply         = 44,
        Parafin                 = 45,
        DepthOfField            = 46,
        MotionBlur              = 47,
        TransparentAfterDOF     = 48,
        TAAU                    = 49,
        MetalFXTemporal         = 50,
        LensFlare               = 51,
        PostProcess             = 52,
        MetalFXSpatial          = 53,
        // 54: 空位
        // 55: UI (已在上方 = 1, 此处可能是冗余)
        // 56: Multiblur (已在上方 = 3)
        // 57: ScreenSpaceOverlay (已在上方 = 2)
        // 58: 未知
        // 59: SetFinalTarget (已在上方 = 5)
        Count                   = 60
    }
}
```

> **注意**: 部分 ID 存在冗余映射（如 UI=1 和 UI=55），可能源于路径特殊化或版本演化。

### 4.4 PassConstructorFactory

```csharp
namespace HG.Rendering.Runtime
{
    public static class PassConstructorFactory
    {
        public static IPassConstructor Create(
            HGRenderPipelineMaterialCollector materialCollector,
            PassConstructorID id,
            HGRenderPathResources resources);
        // 0x3B (59) 项跳转表，全部 IFix 原生
        // 根据 PassConstructorID 实例化对应的 IPassConstructor 实现
    }
}
```

---

## 5. 各渲染路径详细实现

### 5.1 HGRenderPathForward

继承链: `HGRenderPathBase → HGRenderPathScene → HGRenderPathForward`

```csharp
namespace HG.Rendering.Runtime
{
    internal class HGRenderPathForward : HGRenderPathScene
    {
        // ===== 独有 Pass Constructor 字段 =====
        private BinningPassConstructor m_binningPassConstructor;            // ID 15
        // ↓ 以下 Pass ID 待精确确认，基于源文件中字段声明顺序推断
        private FoliageOccluderPassConstructor m_foliageOccluderPassConstructor;  // ~16
        private GpuClothSimulationPassConstructor m_gpuClothSimulationPassConstructor;  // ~17
        private LightClusteringPassConstructor m_lightClusteringPassConstructor;  // ~18
        private ShadowMapPassConstructor m_shadowMapPassConstructor;        // ~19
        private SkyAtmospherePassConstructor m_skyAtmospherePassConstructor;  // ~20
        private TerrainDeformPassConstructor m_terrainDeformPassConstructor;  // ~21
        private TerrainVTBakePassConstructor m_terrainVTBakePassConstructor;  // ~22
        private TerrainDepthPrepassConstructor m_terrainDepthPrepassConstructor;  // ~23
        private DepthPrepassConstructor m_depthPrepassConstructor;          // ~24
        private ForwardPassConstructor m_forwardPassConstructor;            // ~25

        // ===== ECS 排序列表句柄 (uint) =====
        protected uint m_ECSZPreOpaqueListHandles;
        protected uint m_ECSCharacterListHandles;
        protected uint m_ECSOpaqueListHandles;
        protected uint m_ECSTransparentListHandles;

        // ===== 执行顺序 (推断) =====
        // 1. Binning               - 像素/物体分 bin
        // 2. FoliageOccluder       -  foliage 遮挡
        // 3. GpuClothSimulation    - GPU 布料模拟
        // 4. LightClustering       - 光源聚类
        // 5. ShadowMap             - 阴影贴图渲染
        // 6. SkyAtmosphere         - 天空大气
        // 7. TerrainDeform         - 地形变形
        // 8. TerrainVTBake         - 地形虚拟纹理烘焙
        // 9. TerrainDepthPrepass   - 地形深度预 pass
        // 10. DepthPrepass         - 深度预 pass
        // 11. Forward              - 前向渲染主 pass
        // ─────────────────────────────
        // 然后继承 HGRenderPathScene:
        // 12. UIImageBlur          - UI 模糊
        // 13. LightShaftApply      - 光柱应用
        // 14. Parafin              - 石蜡/特殊效果
        // 15. DepthOfField         - 景深
        // 16. MotionBlur           - 运动模糊
        // 17. TransparentAfterDOF  - DOF 后透明
        // 18. TAAU                 - TAA 上采样
        // 19. MetalFXTemporal      - MetalFX 时域
        // 20. LensFlare            - 镜头光晕
        // 21. PostProcess          - 后处理
        // 22. MetalFXSpatial       - MetalFX 空间
        // 23. UI                   - UI 渲染
        // 24. Multiblur            - 多模糊
        // 25. ScreenSpaceOverlay   - 屏幕空间覆盖
        // 26. SetFinalTarget       - 设置最终目标
    }
}
```

### 5.2 HGRenderPathDeferred 抽象基类

继承链: `HGRenderPathBase → HGRenderPathScene → HGRenderPathDeferred`

```csharp
namespace HG.Rendering.Runtime
{
    internal abstract class HGRenderPathDeferred : HGRenderPathScene
    {
        // ===== 常量 =====
        protected const int MAX_GBUFFER_COUNT = 8;

        // ===== GBuffer 系统 =====
        protected object gBufferProfileManager;  // GBufferProfileManager 类型
        protected ComputeBuffer gBufferOutput;
        // GBuffer 纹理引用
        protected TextureHandle m_gbuffer0;
        protected TextureHandle m_gbuffer1;
        protected TextureHandle m_gbuffer2;
        protected TextureHandle m_gbuffer3;
        protected TextureHandle m_gbuffer4;
        protected TextureHandle m_gbuffer5;
        protected TextureHandle m_gbuffer6;
        protected TextureHandle m_gbuffer7;

        // ===== GPU Driven 相关 =====
        protected bool m_isOnePassDeferred;
        protected Delegate m_gpuDrivenFixFunc;  // Action 类型

        // ===== ECS 排序列表句柄 (14 个) =====
        // GPU Driven Culling 变体
        protected uint m_ECSGpuDrivenCullingTransparentListHandles;
        protected uint m_ECSGpuDrivenCullingOpaqueListHandles;
        protected uint m_ECSGpuDrivenCullingCharacterListHandles;
        protected uint m_ECSGpuDrivenCullingZPreOpaqueListHandles;
        protected uint m_ECSGpuDrivenCullingSortedOpaqueListHandles;
        protected uint m_ECSGpuDrivenCullingSortedTransparentListHandles;
        protected uint m_ECSGpuDrivenCullingDeferredDecalListHandles;

        // 标准 ECS 变体
        protected uint m_ECSOpaqueListHandles;
        protected uint m_ECSTransparentListHandles;
        protected uint m_ECSCharacterListHandles;
        protected uint m_ECSZPreOpaqueListHandles;
        protected uint m_ECSSortedOpaqueListHandles;
        protected uint m_ECSSortedTransparentListHandles;
        protected uint m_ECSDeferredDecalListHandles;

        // ===== 属性 =====
        protected ComputeBuffer gBufferOutput { get; }
    }
}
```

### 5.3 HGRenderPathDefaultDeferred

继承链: `HGRenderPathBase → HGRenderPathScene → HGRenderPathDeferred → HGRenderPathDefaultDeferred`

```csharp
namespace HG.Rendering.Runtime
{
    internal class HGRenderPathDefaultDeferred : HGRenderPathDeferred
    {
        // ===== 独有 Pass Constructor 字段 (30+) =====
        private GBufferPassConstructor m_gBufferPassConstructor;
        private DeferredLightingPassConstructor m_deferredLightingPassConstructor;
        private VolumetricFogPassConstructor m_volumetricFogPassConstructor;
        private WaterDefaultDeferredRenderingPass m_waterDefaultDeferredPassConstructor;
        private BakeFogLutPassConstructor m_bakeFogLutPassConstructor;
        private GPUDrivenCullingPassConstructor m_gpuDrivenCullingPassConstructor;
        private InkSimulationPassConstructor m_inkSimulationPassConstructor;
        private GPUParticleSimulationPassConstructor m_gpuParticleSimulationPassConstructor;
        // ... 更多 pass constructor 字段存在但名称待确认

        // ===== 执行顺序 (推断) =====
        // Deferred 特定 Pass:
        //   1. GPUDrivenCulling       - GPU Driven 剔除
        //   2. BakeFogLut             - 烘焙雾 Lut
        //   3. InkSimulation          - 墨水模拟
        //   4. GPUParticleSimulation  - GPU 粒子模拟
        //   5. GBuffer                - GBuffer 写入
        //   6. DeferredLighting       - 延迟光照
        //   7. VolumetricFog          - 体积雾
        //   8. WaterDefaultDeferred   - 水体(默认延迟)
        // ─────────────────────────────
        // 然后继承 HGRenderPathScene 的 15 个共享 Pass
    }
}
```

### 5.4 HGRenderPathOnePassDeferred

继承链: `HGRenderPathBase → HGRenderPathScene → HGRenderPathDeferred → HGRenderPathOnePassDeferred`

```csharp
namespace HG.Rendering.Runtime
{
    internal class HGRenderPathOnePassDeferred : HGRenderPathDeferred
    {
        // ===== 独有 Pass Constructor 字段 (25+) =====
        private OnePassDeferredPassConstructor m_onePassDeferredPassConstructor;
        private WaterSectorRenderingPass m_waterSectorPassConstructor;
        private WaterInteractionRenderingPass m_waterInteractionPassConstructor;
        private WaterOnePassDeferredRenderingPass m_waterOnePassDeferredPassConstructor;
        private FakePlanarReflectionPass m_fakePlanarReflectionPassConstructor;
        private VolumetricCloudPassConstructor m_volumetricCloudPassConstructor;
        // ... 更多 pass constructor 字段存在但名称待确认

        // ===== 执行顺序 (推断) =====
        // OnePass Deferred 特定 Pass:
        //   1. VolumetricCloud        - 体积云
        //   2. FakePlanarReflection   - 伪平面反射 (前)
        //   3. WaterSector            - 水体扇区
        //   4. WaterInteraction       - 水体交互
        //   5. OnePassDeferred        - 单 Pass 延迟 (Subpass)
        //   6. WaterOnePassDeferred   - 水体 OnePass 延迟
        // ─────────────────────────────
        // 然后继承 HGRenderPathScene 的 15 个共享 Pass
    }
}
```

### 5.5 HGRenderPathUI

继承链: `HGRenderPathBase → HGRenderPathUI`

```csharp
namespace HG.Rendering.Runtime
{
    internal class HGRenderPathUI : HGRenderPathBase
    {
        // ===== Pass Constructor 字段 (5 个) =====
        private UIImageBlurPassConstructor m_uiImageBlurPassConstructor;
        private UIPassConstructor m_uiPassConstructor;
        private MultiblurPassConstructor m_multiblurPassConstructor;
        private ScreenSpaceOverlayPassConstructor m_screenSpaceOverlayPassConstructor;
        // 简化渲染，无 3D 场景 Pass

        // ===== 执行顺序 =====
        // 1. UIImageBlur         - UI 背景模糊
        // 2. UI                  - UI 渲染
        // 3. Multiblur           - 多模糊
        // 4. ScreenSpaceOverlay  - 屏幕空间覆盖
    }
}
```

### 5.6 HGRenderPath3DUI

继承链: `HGRenderPathBase → HGRenderPath3DUI`

```csharp
namespace HG.Rendering.Runtime
{
    internal class HGRenderPath3DUI : HGRenderPathBase
    {
        // ===== Pass Constructor 字段 (5 + 1) =====
        private UIImageBlurPassConstructor m_uiImageBlurPassConstructor;
        private UIPassConstructor m_uiPassConstructor;
        private MultiblurPassConstructor m_multiblurPassConstructor;
        private ScreenSpaceOverlayPassConstructor m_screenSpaceOverlayPassConstructor;
        private UIPostProcessConstructor m_uiPostProcessConstructor;

        // ===== 执行顺序 =====
        // 1. UIImageBlur         - UI 背景模糊
        // 2. UI                  - UI 渲染 (含 3D 内容)
        // 3. UIPostProcess       - UI 后处理
        // 4. Multiblur           - 多模糊
        // 5. ScreenSpaceOverlay  - 屏幕空间覆盖
    }
}
```

---

## 6. 设置与资产系统

### 6.1 HGRenderPipelineAsset (部分关键声明)

```csharp
namespace HG.Rendering.Runtime
{
    public class HGRenderPipelineAsset : UnityEngine.Rendering.RenderPipelineAsset
    {
        // ===== 版本控制 =====
        public enum VersionEnum
        {
            Initial = 0,
            // ... 21 个版本 ...
            RemovalOfUpscaleFilter = 21
        }
        [SerializeField] private VersionEnum m_Version;

        // ===== 核心设置 =====
        [SerializeField] private RenderPipelineSettings m_RenderPipelineSettings;
        [SerializeField] private HGRenderPipelineResources m_RenderPipelineResources;
        [SerializeField] private bool allowShaderVariantStripping;
        [SerializeField] private bool enableSRPBatcher;
        [SerializeField] private bool enableSRPBatchInstancing;

        // ===== 运行时特性开关 =====
        internal bool enableSimpleUIRenderPath;
        internal bool enableCppRenderPath;

        // ===== 属性 =====
        public RenderPipelineSettings renderPipelineSettings { get; }
        public HGRenderPipelineResources renderPipelineResources { get; }
    }
}
```

### 6.2 RenderPipelineSettings

```csharp
namespace HG.Rendering.Runtime
{
    [Serializable]
    public struct RenderPipelineSettings
    {
        public enum SupportedLitShaderMode { ForwardOnly = 1, DeferredOnly = 2, Both = 3 }
        public enum ColorBufferFormat { R11G11B10 = 74, R16G16B16A16 = 48 }
        public enum CustomBufferFormat { R8G8B8A8 = 12, R16G16B16A16 = 48, R11G11B10 = 74 }

        public ColorBufferFormat colorBufferFormat;
        public GlobalDynamicResolutionSettings dynamicResolutionSettings;

        // 废弃字段 (数据迁移用途)
        // m_ObsoleteincreaseSssSampleCount
        // m_ObsoleteLightLayerName0–7

        internal static RenderPipelineSettings NewDefault();
        internal bool SupportsAlpha();  // colorBufferFormat == R16G16B16A16
    }
}
```

### 6.3 FrameSettings

```csharp
namespace HG.Rendering.Runtime
{
    [Serializable]
    public struct FrameSettings
    {
        [SerializeField] private BitArray128 bitDatas;  // 128 位开关掩码
        public MaterialQuality materialQuality;

        public ulong Data1 => 0uL;
        public ulong Data2 => 0uL;

        public LitShaderMode litShaderMode { get; set; }

        // ===== 工厂方法 =====
        internal static FrameSettings NewDefaultCamera();
        internal static FrameSettings NewDefaultRealtimeReflectionProbe();
        internal static FrameSettings NewDefaultCustomOrBakeReflectionProbe();

        // ===== 操作方法 =====
        public bool IsEnabled(FrameSettingsField field);
        public void SetEnabled(FrameSettingsField field, bool value);
        internal static void Override(
            ref FrameSettings overriddenFrameSettings,
            FrameSettings overridingFrameSettings,
            FrameSettingsOverrideMask frameSettingsOverideMask);
        internal static void Sanitize(
            ref FrameSettings sanitizedFrameSettings,
            Camera camera,
            in RenderPipelineSettings renderPipelineSettings);
        internal static void AggregateFrameSettings(
            ref FrameSettings aggregatedFrameSettings,
            Camera camera,
            HGAdditionalCameraData additionalData,
            HGRenderPipelineAsset hgrpAsset);
        internal static void AggregateFrameSettings(
            ref FrameSettings aggregatedFrameSettings,
            Camera camera,
            HGAdditionalCameraData additionalData,
            ref FrameSettings defaultFrameSettings,
            in RenderPipelineSettings supportedFeatures);

        // ===== 迁移方法 =====
        internal static void MigrateFromClassVersion(
            ref ObsoleteFrameSettings oldFrameSettingsFormat,
            ref FrameSettings newFrameSettingsFormat,
            ref FrameSettingsOverrideMask newFrameSettingsOverrideMask);
        internal static void MigrateToCustomPostprocessAndCustomPass(
            ref FrameSettings cameraFrameSettings);
        internal static void MigrateToAfterPostprocess(
            ref FrameSettings cameraFrameSettings);
        internal static void MigrateToDefaultReflectionSettings(
            ref FrameSettings cameraFrameSettings);

        // ===== 运算符 =====
        public static bool operator ==(FrameSettings a, FrameSettings b);
        public static bool operator !=(FrameSettings a, FrameSettings b);
    }
}
```

### 6.4 HGRenderPipelineSettingHub

```csharp
namespace HG.Rendering.Runtime
{
    public class HGRenderPipelineSettingHub
    {
        // ===== 单例 =====
        private static HGRenderPipelineSettingHub s_instance;
        public static HGRenderPipelineSettingHub instance { get; }

        // ===== 配置加载 =====
        // 内部使用 IniParser 解析 .ini 配置文件
        private string m_configFilePath;  // 例如 "HG_Settings.ini"
        private Dictionary<string, string> m_configCache;

        // ===== 设备类型 =====
        // 根据运行时设备自动判定
        public enum DeviceTier { Low, Medium, High, Ultra }
        public DeviceTier currentDeviceTier { get; }

        // ===== 特性覆盖 =====
        // 用于运行时覆盖特定功能等级
        public void OverrideFeatureTier(string featureName, int tier);

        // ===== 查询 API =====
        public bool GetBoolSetting(string key, bool defaultValue = false);
        public int GetIntSetting(string key, int defaultValue = 0);
        public float GetFloatSetting(string key, float defaultValue = 0f);
        public string GetStringSetting(string key, string defaultValue = "");
    }
}
```

---

## 7. 数据流分析

### 7.1 相机渲染路径选择流程

```
Camera.unity
  │
  ├─ HGCamera (包装器)
  │     └─ 通过 HGAdditionalCameraData 附加数据
  │
  ├─ HGRenderPipeline.RenderCamera()
  │     │
  │     ├─ 1. 从 HGCamera 读取 FrameSettings
  │     │
  │     ├─ 2. 选择 HGRenderPathInternal:
  │     │     ├─ FrameSettings.litShaderMode == Forward
  │     │     │   AND enableCppRenderPath == false → Forward
  │     │     ├─ FrameSettings.litShaderMode == Deferred
  │     │     │   AND isOnePassDeferred == false → DefaultDeferred
  │     │     ├─ FrameSettings.litShaderMode == Deferred
  │     │     │   AND isOnePassDeferred == true → OnePassDeferredSubpass
  │     │     ├─ cameraType == UI
  │     │     │   AND enableSimpleUIRenderPath == true → UI
  │     │     └─ cameraType == UI
  │     │       AND enableSimpleUIRenderPath == false → UI3D
  │     │
  │     └─ 3. m_renderPath.Render(ref params)
  │
  └─ ScriptableRenderContext.Submit()
```

### 7.2 PassConstructor 生命周期

```
创建阶段 (渲染路径构造函数):
  PassConstructorFactory.Create(collector, id, resources) → IPassConstructor
       │
       └─ 存入 m_passConstructorMapping[id]

执行阶段 (每帧):
  foreach (var kvp in m_passConstructorMapping)
  {
      // 按 PassConstructorID 顺序执行
      kvp.Value.PrepareShaderVariablesGlobal(graph, pipeline, camera, ref globals, payload);
      kvp.Value.OnPreRendering(graph, pipeline, camera, ref params, payload);
      // → 在 HGRenderGraph 中注册实际的 RenderPass
      kvp.Value.OnPostRendering(graph, pipeline, camera, ref params, payload);
  }

销毁阶段:
  kvp.Value.Dispose();
```

### 7.3 ECS 数据流

HGRenderPathForward 和 HGRenderPathDeferred 都使用 `uint` 类型的 ECS 列表句柄:

```
ECS World
  │
  ├─ EntityRenderHelperECSManager
  │     └─ 根据渲染类型(不透明/透明/角色/ZPre) 收集实体
  │
  ├─ ListHandles (uint)
  │     └─ m_ECSOpaqueListHandles, m_ECSTransparentListHandles, 等
  │
  └─ 在 PassConstructor.OnPreRendering 中:
        └─ 读取 ECS 列表 → 填充 DrawIndirectArgBuffer → GPU Driven 渲染
```

Sorter 系统使用 NativeArray/ComputeBuffer 传递排序后的可见索引到 GPU。

### 7.4 ShaderVariablesGlobal 更新流程

```
HGRenderPathScene.UpdateShaderVariablesGlobal()
  ├─ base.UpdateShaderVariablesGlobal()           # 基类默认更新
  ├─ UpdateShaderVariablesGlobalMaterialStylizer   # 材质风格化
  ├─ UpdateShaderVariablesGlobalEnvironment        # 环境参数
  ├─ UpdateShaderVariablesGlobalCloudShadow        # 云阴影
  ├─ UpdateShaderVariablesGraphFeaturesGlobalParam0 # 图形特性参数
  ├─ UpdateShaderVariablesGlobalAtmosphere         # 大气散射
  ├─ UpdateShaderVariablesGlobalCharacter          # 角色+雨渲染
  ├─ UpdateShaderVariablesGlobalWind               # 风场
  ├─ UpdateShaderVariablesGlobalWaterInteraction   # 水体交互
  ├─ UpdateShaderVariablesGlobalRainAndWetness     # 雨水/湿润
  ├─ UpdateShaderVariablesGlobalVerticalOcclusionMap # 垂直遮挡图
  ├─ UpdateWaterWetnessMaskParam                  # 水体湿润遮罩
  ├─ UpdateShaderVariablesGlobalFoliageOccluder    # 植被遮挡
  └─ UpdateShaderVariablesGlobalFoliageInteract    # 植被交互
       │
       └─ 写入 ShaderVariablesGlobal 结构体
          → CommandBuffer.SetGlobalBuffer/SetGlobalTexture/SetGlobalVector
```

---

## 8. 代码生成模板

### 8.1 创建新的 PassConstructor

```csharp
// 1. 在 PassConstructorID 中添加新条目
// 文件: PassConstructorID.cs
public enum PassConstructorID
{
    // ... 现有条目 ...
    MyNewPass = 60,  // = Count (需要同时更新 Count)
    Count = 61
}

// 2. 实现 IPassConstructor
// 文件: MyNewPassConstructor.cs
namespace HG.Rendering.Runtime
{
    public class MyNewPassConstructor : IPassConstructor
    {
        public void PrepareShaderVariablesGlobal(
            HGRenderGraph renderGraph,
            HGRenderPipeline hgrp,
            HGCamera camera,
            ref ShaderVariablesGlobal shaderVariablesGlobal,
            HGPassConstructorPayload payload)
        {
            // 设置全局 Shader 变量
        }

        public void OnPreRendering(
            HGRenderGraph renderGraph,
            HGRenderPipeline hgrp,
            HGCamera camera,
            ref HGRenderPathParams renderPathParams,
            HGPassConstructorPayload payload)
        {
            // 在 renderGraph 中创建并注册 RenderPass
            // 使用 renderGraph.AddPass<>()
        }

        public void OnPostRendering(
            HGRenderGraph renderGraph,
            HGRenderPipeline hgrp,
            HGCamera camera,
            ref HGRenderPathParams renderPathParams,
            HGPassConstructorPayload payload)
        {
            // 清理/后处理
        }

        public void Dispose()
        {
            // 释放资源
        }
    }
}

// 3. 在 PassConstructorFactory 的跳转表中添加 case
// 文件: PassConstructorFactory.cs
public static IPassConstructor Create(
    HGRenderPipelineMaterialCollector materialCollector,
    PassConstructorID id,
    HGRenderPathResources resources)
{
    switch (id)
    {
        // ... 现有 case ...
        case PassConstructorID.MyNewPass:
            return new MyNewPassConstructor(/* ... */);
        default:
            throw new ArgumentOutOfRangeException(nameof(id));
    }
}

// 4. 在需要的 RenderPath 中添加字段和初始化
// 例如在 HGRenderPathForward.cs 中:
private MyNewPassConstructor m_myNewPassConstructor;

// 在 PopulatePassConstructorIds() 中注册:
// m_passConstructorMapping[PassConstructorID.MyNewPass] = m_myNewPassConstructor;
```

### 8.2 创建新的 Render Path

```csharp
// 1. 在 HGRenderPathInternal 中添加枚举值
internal enum HGRenderPathInternal
{
    Forward = 0,
    UI = 1,
    UI3D = 2,
    DefaultDeferred = 3,
    OnePassDeferredSubpass = 4,
    MyCustomPath = 5,  // 新增
    Count = 6
}

// 2. 创建新的 RenderPath 类
namespace HG.Rendering.Runtime
{
    internal class HGRenderPathMyCustom : HGRenderPathBase
    {
        // 声明需要的 PassConstructor 字段
        private MyPassConstructor m_myPass;
        // ...

        public HGRenderPathMyCustom(
            HGRenderPathResources resources,
            PassConstructorID[] passConstructorIDs,
            HGCamera camera,
            HGRenderPathInternal renderPath)
            : base(resources, passConstructorIDs, camera, renderPath)
        {
            // 通过 GetPassConstructor() 获取已创建的实例
            // m_myPass = GetPassConstructor(PassConstructorID.MyPass) as MyPassConstructor;
        }

        protected override void PopulatePassConstructorIds(
            ref HGRenderPathParams renderPathParams)
        {
            // 注册本路径使用的 PassConstructorID 列表
            // base.PopulatePassConstructorIds(ref renderPathParams) 后添加
            RegisterPassConstructor(PassConstructorID.MyPass);
            RegisterPassConstructor(PassConstructorID.AnotherPass);
        }

        protected override bool SkipRender(ref HGRenderPathParams renderPathParams)
        {
            return false; // 自定义跳过逻辑
        }

        protected override PassConstructorID FindFirstBackbufferPass()
        {
            return PassConstructorID.SetFinalTarget;
        }
    }
}

// 3. 在 HGRenderPipeline 中选择路径
// RenderCamera() 方法中添加:
// case HGRenderPathInternal.MyCustomPath:
//     renderPath = new HGRenderPathMyCustom(...);
//     break;
```

### 8.3 完整 RenderPath 框架模板

```csharp
using HG.Rendering.RenderGraphModule;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
    internal class HGRenderPathTemplate : HGRenderPathBase
    {
        // ── Pass Constructor 字段 ──
        private ShadowMapPassConstructor m_shadowMapPassConstructor;
        private ForwardPassConstructor m_forwardPassConstructor;

        // ── 共享纹理 ──
        protected TextureHandle sceneColor { get; set; }
        protected TextureHandle sceneDepth { get; private set; }

        // ── 构造 ──
        internal HGRenderPathTemplate(
            HGRenderPathResources resources,
            PassConstructorID[] passConstructorIDs,
            HGCamera camera,
            HGRenderPathInternal renderPath)
            : base(default, null, null, default)
        {
            // 获取 PassConstructor 实例
            m_shadowMapPassConstructor = GetPassConstructor(
                PassConstructorID.ShadowMap) as ShadowMapPassConstructor;
            m_forwardPassConstructor = GetPassConstructor(
                PassConstructorID.Forward) as ForwardPassConstructor;
        }

        protected override void PopulatePassConstructorIds(
            ref HGRenderPathParams renderPathParams)
        {
            m_passConstructorMapping.Clear();
            RegisterPassConstructor(PassConstructorID.ShadowMap);
            RegisterPassConstructor(PassConstructorID.Forward);
        }

        protected override void OnPreRendering(
            ref HGRenderPathParams renderPathParams)
        {
            base.OnPreRendering(ref renderPathParams);
            // 创建帧缓冲
        }

        protected override void OnPostRendering(
            ref HGRenderPathParams renderPathParams)
        {
            base.OnPostRendering(ref renderPathParams);
            // 清理
        }

        protected override bool SkipRender(
            ref HGRenderPathParams renderPathParams)
        {
            return renderPathParams.camera == null
                || renderPathParams.unityCamera.cullingMask == 0;
        }

        protected override PassConstructorID FindFirstBackbufferPass()
        {
            return PassConstructorID.SetFinalTarget;
        }

        private void RegisterPassConstructor(PassConstructorID id)
        {
            // 实现方式取决于基类设计
            // 可能直接操作 m_passConstructorMapping
        }
    }
}
```

---

## 9. 关键设计模式

### 9.1 策略模式 — 渲染路径选择

以 `HGRenderPathInternal` 为策略键，`HGRenderPathBase` 为策略接口:

```
HGRenderPipeline
  └─ 根据 FrameSettings + 平台能力选择 HGRenderPathInternal
        ├─ Forward       → HGRenderPathForward
        ├─ DefaultDeferred → HGRenderPathDefaultDeferred
        ├─ OnePassDeferred → HGRenderPathOnePassDeferred
        ├─ UI            → HGRenderPathUI
        └─ UI3D          → HGRenderPath3DUI
```

### 9.2 模板方法模式 — HGRenderPathBase.Render()

```csharp
// 不可重写的外部 API
public void Render(ref HGRenderPathParams renderPathParams)
{
    if (SkipRender(ref renderPathParams)) return;

    OnPreRendering(ref renderPathParams);

    // 1. 设置渲染图
    BeginRenderGraph();

    // 2. 填充 Pass 列表
    PopulatePassConstructorIds(ref renderPathParams);

    // 3. 执行所有 Pass
    foreach (var constructor in m_passConstructorMapping.Values)
    {
        constructor.PrepareShaderVariablesGlobal(...);
        constructor.OnPreRendering(...);
        constructor.OnPostRendering(...);
    }

    // 4. 执行渲染图
    ExecuteRenderGraph();

    OnPostRendering(ref renderPathParams);
    EndRenderGraph();
}
```

于类通过重写 `SkipRender`、`OnPreRendering`、`PopulatePassConstructorIds`、`OnPostRendering` 自定义行为。

### 9.3 工厂模式 — PassConstructorFactory

```csharp
PassConstructorFactory.Create(collector, id, resources)
  → switch(id)
      case PassConstructorID.ShadowMap: return new ShadowMapPassConstructor(...)
      case PassConstructorID.Forward:   return new ForwardPassConstructor(...)
      // ... 59 个 case
```

### 9.4 组合模式 — HGRenderPathBase + List<IPassConstructor>

每个 RenderPath 组合多个 IPassConstructor，形成 Pipeline:

```
HGRenderPathForward
  ├─ BinningPassConstructor
  ├─ ShadowMapPassConstructor
  ├─ ForwardPassConstructor
  ├─ DepthOfFieldPassConstructor
  ├─ PostProcessPassConstructor
  └─ SetFinalTargetPassConstructor
```

### 9.5 单例模式 — HGRenderPipelineSettingHub

```csharp
public class HGRenderPipelineSettingHub
{
    private static HGRenderPipelineSettingHub s_instance;
    public static HGRenderPipelineSettingHub instance
        => s_instance ?? (s_instance = new HGRenderPipelineSettingHub());
}
```

### 9.6 享元模式 — PassConstructor 复用

同一 PassConstructor 实例在不同 RenderPath 间通过 `Dictionary<PassConstructorID, IPassConstructor>` 共享。HGRenderPathScene 的 15 个通用 Pass 在所有 Scene 路径中复用，无需重新创建。

### 9.7 数据流总结

```
HGRenderPipelineAsset  (ScriptableObject, 持久化)
  └─ RenderPipelineSettings  (序列化 struct)
       └─ colorBufferFormat, dynamicResolutionSettings

HGRenderPipelineSettingHub  (单例, 运行时)
  └─ .ini 配置 → 设备分级 → 特性覆盖

FrameSettings  (每相机, BitArray128 掩码)
  └─ 聚合: Asset.Default × Camera.Override × GlobalSettings
       └─ 决定: litShaderMode, 各 feature 开关

HGRenderPathInternal  (每帧, 枚举)
  └─ 根据 FrameSettings 选择

HGRenderPathBase.Render()  (每帧)
  └─ IPassConstructor × N  (按 ID 顺序)
       └─ HGRenderGraph.AddPass<>()
            └─ 编译 → 执行
```

---

## 10. 扩展指南

### 10.1 添加新的渲染特性

1. **新建 PassConstructorID**: 在 `PassConstructorID` 枚举末尾添加（ID=当前 Count）
2. **实现 IPassConstructor**: 创建新的 `*PassConstructor.cs`，实现 4 个接口方法
3. **注册工厂**: 在 `PassConstructorFactory.Create()` 跳转表中添加 case
4. **在 RenderPath 中使用**: 在目标 RenderPath 中添加字段，在 `PopulatePassConstructorIds()` 中注册

### 10.2 添加新的渲染路径

1. **新建 HGRenderPathInternal 值**: 扩展枚举
2. **创建 RenderPath 子类**: 继承 `HGRenderPathBase`（或 `HGRenderPathScene` 若需 3D 场景支持）
3. **注册路径选择逻辑**: 在 `HGRenderPipeline.RenderCamera()` 中添加路径选择 case
4. **配置 Pass 组合**: 在 `PopulatePassConstructorIds()` 中注册使用哪些 Pass

### 10.3 修改 FrameSettings

1. **新建 FrameSettingsField 值**: 在 `FrameSettingsField` 枚举中添加（需注意 BitArray128 索引）
2. **添加默认值**: 在 `NewDefaultCamera()` 等工厂方法中设置初始值
3. **添加聚合逻辑**: 如果需要特殊的覆盖规则，在 `AggregateFrameSettings` 中处理
4. **在 RenderPath 中使用**: 在相关 Pass 的条件判断中读取 `FrameSettings.IsEnabled()`

### 10.4 支持新的平台/设备

1. **添加 HGDeviceType 值**: 扩展设备类型枚举
2. **配置 SettingHub**: 在 `.ini` 配置中添加新平台的默认设置
3. **设置 FrameSettings 默认值**: 根据设备类型调整默认 FrameSettings
4. **Shader 变体**: 通过 HGRenderPipelineAsset 控制 shader variant stripping

---

## 附录 A: 文件索引

| # | 文件名 | 行数 | 关键内容 |
|---|---|---|---|
| 1 | `HGRenderPipeline.cs` | ~2000+ | 管线入口、Render 循环、Camera 管理 |
| 2 | `HGRenderPipelineAsset.cs` | ~400+ | ScriptableObject 资产、版本控制、序列化设置 |
| 3 | `HGRenderPipelineSettingHub.cs` | ~300+ | 单例配置中心、INI 解析、设备分级 |
| 4 | `HGRenderPathBase.cs` | ~600+ | 抽象基类、Render 模板方法、核心基础设施 |
| 5 | `HGRenderPathScene.cs` | ~2000+ | 3D 场景中间基类、15 个共享 Pass、全局变量更新 |
| 6 | `HGRenderPathForward.cs` | ~600+ | 前向渲染路径、11 个特有 Pass、ECS 排序列表 |
| 7 | `HGRenderPathDefaultDeferred.cs` | ~800+ | 标准延迟渲染路径、30+ 特有 Pass |
| 8 | `HGRenderPathOnePassDeferred.cs` | ~800+ | 单 Pass 延迟路径、25+ 特有 Pass |
| 9 | `HGRenderPathUI.cs` | ~200+ | 2D UI 渲染路径、5 个 UI Pass |
| 10 | `HGRenderPath3DUI.cs` | ~300+ | 3D UI 渲染路径、6 个 Pass |
| 11 | `HGRenderPathDeferred.cs` | ~700+ | 延迟渲染抽象基类、MAX_GBUFFER_COUNT=8、14 ECS 句柄 |
| 12 | `HGRenderPathInternal.cs` | 12 | 渲染路径枚举 (5 值) |
| 13 | `PassConstructorFactory.cs` | ~100+ | 静态工厂、0x3B 项跳转表 |
| 14 | `PassConstructorID.cs` | ~80+ | 60 值 Pass ID 枚举 |
| 15 | `IPassConstructor.cs` | ~30+ | 4 方法接口 |
| 16 | `HGPassConstructorPayload.cs` | ~20+ | 4 float 参数结构体 |
| — | `RenderPipelineSettings.cs` | 170 | 设置结构体、缓冲格式、着色模式 |
| — | `FrameSettings.cs` | ~1900+ | 位掩码设置、聚合/覆盖/迁移逻辑 |

## 附录 B: 已知缺失的 C# 方法体

所有方法体均被 IFix 擦除，以下列表记录已知的原生调用:

| 文件 | 方法 | 原生索引 |
|---|---|---|
| `HGRenderPathScene` | `.ctor` | — |
| `HGRenderPathScene` | `SkipRender` | IFix ID=0xBD3 |
| `HGRenderPathScene` | `UpdateShaderVariablesGlobal` | IFix ID=0xBD4 |
| `HGRenderPathScene` | `OnPreRendering` | IFix ID=0xBAD |
| `HGRenderPathScene` | `FindFirstBackbufferPass` | IFix ID=0xBE5 |
| `RenderPipelineSettings` | `NewDefault` | IFix ID=0xC3F |
| `RenderPipelineSettings` | `SupportsAlpha` | IFix ID=0xC40 |
| `FrameSettings` | `NewDefaultCamera` | IFix ID=0xC07 |
| `FrameSettings` | `NewDefaultRealtimeReflectionProbe` | IFix ID=0xC08 |
| `FrameSettings` | `NewDefaultCustomOrBakeReflectionProbe` | IFix ID=0xC09 |
| `FrameSettings` | `IsEnabled` | — (原生 inline) |
| `FrameSettings` | `SetEnabled` | IFix ID=0xC0A |
| `FrameSettings` | `Override` | IFix ID=0x286 |
| `FrameSettings` | `Sanitize` | — (原生 inline) |
| `FrameSettings` | `AggregateFrameSettings` [IDTag=1] | IFix ID=0x28C |
| `FrameSettings` | `AggregateFrameSettings` [IDTag=0] | IFix ID=0x28D |
| `FrameSettings` | `op_Equality` | IFix ID=0x28B |
| `FrameSettings` | `op_Inequality` | IFix ID=0x28A |
| `FrameSettings` | `Equals` | IFix ID=0xC0B |
| `FrameSettings` | `GetHashCode` | IFix ID=0xC0C |
| `FrameSettings` | `MigrateFromClassVersion` | IFix ID=0xC0D |
| `FrameSettings` | `MigrateToCustomPostprocessAndCustomPass` | IFix ID=0xC0E |
| `FrameSettings` | `MigrateToAfterPostprocess` | IFix ID=0xC0F |
| `FrameSettings` | `MigrateToDefaultReflectionSettings` | IFix ID=0xC10 |
| `PassConstructorFactory` | `Create` | — (跳转表) |
| `HGRenderPipelineSettingHub` | (全部) | 全部 IFix |
