# 净室实现文档: 光照、AO和反射系统

## 概述

本文档基于对 HG.RenderPipelines.Runtime 中 10 个核心 C# 源文件的分析，描述延迟光照（Deferred Lighting）、Ground Truth AO（GTAO）、屏幕空间反射（SSR）、假平面反射（Fake Planar Reflection）、粒子光照（Particle Lighting）和深度金字塔（Depth Pyramid）六个子系统。所有代码均以 IL2CPP 反编译形式呈现（C# 外壳 + x86_64 汇编），因此算法细节主要从类/结构体字段、着色器资源名称、性能分析 ID、着色器属性 ID 以及资源加载路径中推断得出。

---

## DeferredLightingPass（延迟光照计算）

### 类定义

- **DeferredLightingPass**（静态类，位于 `DeferredLightingPass.cs`）
  - 内部枚举 `LightMeshType`：`Cone = 0`、`Sphere = 1`
  - 内部结构体 `LightMeshDrawRequest`：`lightMeshType`、`lightMeshMatrix`、`lightIndex`
  - 内部结构体 `DeferredLightingRenderParams`：通过位域/布尔值控制各个子阶段的启用
    - `enableDeferredShadingDefaultLit`
    - `enableDeferredShadingTwoSidedFoliage`
    - `enableDeferredShadingSubsurface`
    - `splitDeferredShadingStage`
    - `usePerLightDynamicLighting`
    - `enableDeferredShadingDirectionalLightStage`
    - `enableDeferredShadingDynamicLightStage`
    - `enableDeferredShadingIndirectStage`
    - `enableDeferredShadingTileDraw`
    - `drawTileArgs`（ComputeBufferHandle）
    - `tileInstanceIndices`（ComputeBufferHandle）
    - `quadIndexBuffer`（GraphicsBuffer）
  - 两个静态 `MaterialPropertyBlock`：`s_coneMpb`、`s_sphereMpb`

- **DeferredLightingPassConstructor**（`IPassConstructor`，位于 `DeferredLightingPassConstructor.cs`）
  - `PassInput`：`sceneColor`、`sceneDepth`、`sceneDepthCopied`、`historySceneColor`、`indirectAmbientOcclusionTexture`、`ssrLightingTexture`、`ssrFadenessTexture`、`planarReflectionTexture`、`fogBakeLutTexture`、`waterWetnessMaskTexture`、`hgrp`、`gBufferOutput`、`shadowResult`、`sceneColorFormat`
  - `PassOutput`：`sceneColor`
  - `DeferredLightingPassData`：`colorBuffer`、`depthBuffer`、`depthTexture`、`previousSceneColorTexture`、输入纹理列表、`gbuffer[]`、`hgCamera`、`deferredLightingMaterial`、`deferredLightingWriteAlphaMaterial`
  - 构造函数从 `HGRenderPipelineMaterialCollector` 获取两种材质（路径通过资源列表提供）

### 逐像素光照Pass逻辑

`DrawDeferredLighting()` 通过一系列 `CoreUtils.DrawFullScreen()` 调用来绘制不同光照阶段，材质 pass 索引由 `DeferredLightingRenderParams` 中的位标志控制：

1. **Directional Light Stage**（pass 索引 0-2）：默认 Lit、TwoSided Foliage、Subsurface
2. **Dynamic Light Stage**（pass 索引 3-5）：动态光源累加
3. **Indirect Stage**（pass 索引 6-8）：间接光照
4. **Tile Draw Stage**（pass 索引 9-11）：基于贴片的绘制

当 `usePerLightDynamicLighting` 启用时（`LightMeshType` 枚举），则调用 `DrawPerLightDeferredLighting()` 使用 `DrawMeshInstanced` 绘制 Sphere/Cone 网格来表示每个动态光源的影响范围。

`DrawDeferredLightingWriteAlpha()` 根据 `DeferredLightingRenderParams` 位标志输出透明明度信息（pass 0-2）。

### GBuffer解码

`PrepareDeferredLightingPass()` 从 `GBufferOutput` 中读取 4 个 GBuffer 纹理（0-3），通过 `HGRenderGraphBuilder.ReadTexture()` 绑定到渲染图。GBuffer 纹理作为只读输入绑定到延迟光照材质。

### 光源列表遍历

`DrawPerLightDeferredLighting()` 使用 `NativeArray<float>` 和 `NativeArray<Matrix4x4>` 收集光源数据（强度 + 世界矩阵），然后通过 `MaterialPropertyBlock.SetFloatArray()` 将光源数据上传，最后使用 `CommandBuffer.DrawMeshInstanced()` 进行 Instanced 绘制。支持 Sphere 和 Cone 两种光源形状。

### Shader绑定

材质关键字通过 `Material.SetKeyword()` 进行控制，涉及的关键字来自 `HGShaderKeyWords`，包括 `_TERRAIN_SIMPLE_SUBSURFACE` 等。`HGRenderGraphBuilder.SetGlobalTexture()` 用于绑定全局纹理，`CommandBuffer.SetGlobalBuffer()` 用于绑定光源列表 ComputeBuffer。

---

## GTAOPass（Ground Truth AO）

### 球面方向重要性采样

通过 GTAO compute shader（`GTAmbientOcclusionCS`）实现。算法基于球面方向的重要性采样，围绕法线方向在半球内分布采样向量。核心参数包括：
- `radius`：采样半径
- `radiusMultiplier`：半径乘数
- `falloffRange`：衰减范围
- `sampleDistributionPower`：采样分布幂次
- `thinOccluderCompensation`：薄遮挡物补偿
- `finalValuePower`：最终值幂次
- `depthMIPSamplingOffset`：深度 MIP 采样偏移
- `mvFactor` / `depthFactor`：时域复用权重

AO 计算使用深度 MIP 链（5 级）进行层次化采样，以提高性能并减少带宽。

### Hilbert排序

Compute shader 的线程组布局为 `GTAO_NUMTHREADS_X = 8`、`GTAO_NUMTHREADS_Y = 8`。线程组在屏幕上以 8x8 块进行调度。采样模式使用某种形式的空间排序（可能为 Hilbert 或 Morton 序）来改善缓存局部性。

### AO计算

完整的 GTAO 管线通过以下 profile ID 标识（按执行顺序）：

| Profile ID | 名称 | 说明 |
|-----------|------|------|
| 73 | `GTAO` | 总体 AO Pass |
| 74 | `GTAOPrefilterDepth` | 深度预过滤，生成 5 级深度 MIP 链 |
| 75 | `GTAOMain` | 主 AO 计算 Pass |
| 76 | `GTAOTemporal` | 时域复用/滤波 |
| 77 | `GTAOBlur` | 双边模糊去噪（可配置 `denoisePassCount`） |
| 78 | `GTAOUpsample` | 半分辨率上采样到全分辨率 |

AO 结果存储在 `_GTAOMainAOTermRT`，经过 Temporal -> Blur -> Upsample 后生成最终输出 `indirectAmbientOcclusionTexture`。

### GTAmbientOcclusion Volume组件

`GTAmbientOcclusion : VolumeComponent` 定义在 `GTAmbientOcclusion.cs` 中，可配置参数：

| 参数 | 类型 | 说明 |
|------|------|------|
| `enable` | BoolParameter | 启用开关 |
| `enableFP32Depths` | BoolParameter | 使用 FP32 深度 |
| `enableBentNormals` | BoolParameter（私有） | 输出弯曲法线 |
| `qualityLevel` | ClampedIntParameter | 质量级别 |
| `denoisePasses` | ClampedIntParameter | 去噪 Pass 次数 |
| `radius` | ClampedFloatParameter | AO 采样半径 |
| `radiusMultiplier` | MinFloatParameter | 半径乘数 |
| `falloffRange` | MinFloatParameter | 衰减范围 |
| `sampleDistributionPower` | MinFloatParameter | 采样分布幂次 |
| `thinOccluderCompensation` | MinFloatParameter | 薄遮挡补偿 |
| `finalValuePower` | MinFloatParameter | 最终值幂次 |
| `depthMIPSamplingOffset` | MinFloatParameter | MIP 偏移 |
| `mvFactor` / `depthFactor` | MinFloatParameter | 时域复用系数 |

着色器关键字：`s_GTAOUseFP32Depths`、`s_GTAOBentNormals`

---

## HyperScreenSpaceReflection（SSR屏幕空间反射）

### 分层光线步进

SSR 管线使用 compute shader（`Runtime/Shaders/Lighting/SSR/ScreenSpaceReflectionCS.compute`）进行分层光线步进（Hierarchical Ray Marching），也使用 pixel shader（`ScreenSpaceReflectionPS.shader`）作为 Fallback。

`ScreenSpaceReflectionData` 结构体包含关键参数：
- `param0` ~ `param7`：SSR 参数
- `previousColorPyramidRenderSize`：前一帧颜色金字塔尺寸
- `currentColorPyramidRenderSize`：当前帧颜色金字塔尺寸

`PassData` 关键字段：
- `renderSize`、`ssrRenderSize`（半分辨率）、`temporalRenderSize`
- `maxMipCount`：最大 MIP 级数
- `upsample`：是否执行上采样
- `importanceSample`：是否启用重要性采样（关键字 `s_SSRImportanceSample`）
- `cbData`：`ScreenSpaceReflectionData` 常量缓冲区
- `ssrRenderWetness`：是否渲染湿表面反射

### Hi-Z tracing

深度层级通过深度金字塔纹理（`_SSRSceneDepthPyramid`）提供。光线步进算法使用层次化深度遍历（Hi-Z map），从屏幕空间位置出发沿反射方向步进，在每个 MIP 级别测试深度相交。最大 MIP 级别由 `maxMipCount` 控制（由渲染尺寸的对数决定，上限 7）。

Gbuffer 法线/粗糙度（`_NormalRoughnessTexture`）用于计算反射方向和初始偏移以避免自相交。

### 颜色金字塔

SSR 使用颜色金字塔（`currentColorPyramidTexture`）作为射线步进时的颜色来源。颜色金字塔通过降采样当前帧场景颜色构建。预计算的颜色金字塔允许在低 MIP 级别进行更高效的锥体追踪（cone tracing）。

### 时域复用

SSR 管线包含完整的时域复用（Temporal Filtering）：
- `temporalRenderSize`：时域纹理分辨率
- `previousTemporalColorTexture` / `currentTemporalColorTexture`：前后帧时域颜色
- `previousFadenessTexture` / `currentFadenessTexture`：前后帧衰减纹理

时域复用通过 motion vector（`_SSRMotionVector`）进行 reprojection，并将历史颜色与当前帧的 ray marching 结果混合。`firstFrame` 标志用于重置时域累积。

### 最终合成

SSR 管线步骤（按 profile ID 排序）：

| Profile ID | 名称 | 说明 |
|-----------|------|------|
| 86 | `ScreenSpaceReflection` | 总体 SSR 管理 |
| 87 | `ScreenSpaceReflectionRayMarching` | 光线步进主 Pass |
| 88 | `ScreenSpaceReflectionFadeness` | 衰减纹理构建（基于屏幕边缘/深度差异） |
| 89 | `ScreenSpaceReflectionTemporal` | 时域滤波 |
| 90 | `ScreenSpaceReflectionColorPyramid` | 颜色金字塔构建 |
| 91 | `ScreenSpaceReflectionColorResolve` | 最终颜色 Resolve |
| 92 | `ScreenSpaceReflectionColorUpsample` | 上采样到全分辨率 |
| 93-95 | `Deferred/TBuffer/GBuffer` | 延迟管线的 GBuffer 变体 |

此外还有 **Improved SSR** 管线（profile 96-104）提供更精细的控制：ComputeLowDepth、TiledClassification、RayMarching、Unpack、Reproject、Upsampling、ImagePyramidGeneration、Resolve。

`ScreenSpaceReflectionVolume : VolumeComponent` 提供用户可调参数：
- `enable`、`fadenessOnScreen`、`fadenessOnDepth`、`fadenessOnDepthFactor`、`fadenessOnMirrorMul`、`fadenessOnMirrorAdd`、`mipThreshold`

---

## FakePlanarReflection（假平面反射）

### 镜像场景绘制到RT

`FakePlanarReflectionPass : IPassConstructor` 将场景从镜像摄像机角度渲染到离屏 RT。管线包含三个子阶段：

1. **Depth Prepass（Z-only）**：`FakePlanarReflectionPreZ` (137) - 将场景深度写入离屏深度 RT
2. **Lighting Pass**：`FakePlanarReflectionLighting` (138) - 以反射方向渲染场景颜色到 `Fake Planar Reflection Color texture`
3. **Blur Pass**：`FakePlanarReflectionBlur` (139) - 对反射纹理进行 Blur

纹理命名：
- `"Fake Planar Reflection Color texture"`（`m_planarReflectionTexture`）
- `"Fake Planar Reflection Color Blur texture"`（`m_planarReflectionBlurTexture`）
- `"Fake Planar Reflection Depth texture"`（`m_planarReflectionDepthTexture`）

ECS 列表控制渲染的对象：
- `characterPrePassECSList`、`forwardOpaqueECSList`、`characterOpaqueECSList`、`characterOutlineOpaqueECSList` 等

### Blur处理

`BlurData` 结构体包含 `blurSize` 和 `param0`。模糊半径来自 `HGCamera.fakePlanarReflectionBlur` 属性。使用 `m_blurMaterial` 对反射颜色纹理进行水平/垂直高斯模糊或类似模糊处理。

### 反射合成

在最终合成阶段，平面反射纹理通过 `_FakePlanarReflectionTexture` 着色器 ID 绑定到延迟光照材质，作为额外的反射输入参与光照计算。

### HGPlanarReflectionManager

`HGPlanarReflectionManager` 类仅有 `Release()` 方法（通过 IFix patching 实现）。该 Manager 负责管理平面反射资源的生命周期。

---

## ParticleLightingPass（粒子光照）

### 粒子光照算法

`ParticleLightingPassConstructor : IPassConstructor` 通过 compute shader 实现粒子逐光源照明：

常量：
- `THREAD_COUNT = 64`：线程组大小
- `MAX_PARTICLE_COUNT = 4096`：最大粒子数

着色器 kernel：`"ParticleLightingMain"`

输入/输出：
- `binningBufferHandle`：光源分箱缓冲区（来自 Binning Pass）
- `ParticleLightingIVInput ivInput`：辐照度体积（Irradiance Volume）输入
- `lightingResultBuffer`（ComputeBuffer）：输出光照结果
- `asmShadowMapRT`：ASM 阴影图（动态分辨率阴影）

### IV集成

粒子光照接收 `ParticleLightingIVInput` 结构体，该结构体通过常量缓冲区（CBHandle `ivInputCBHandle`）传递辐射度体积数据。使用 `HGASMManager.GetASMManager()` 获取 ASM（Adaptive Shadow Map）管理器以绑定阴影贴图。

每个线程处理多个粒子（64 线程组 * 64 = 4096 粒子/组）。着色器关键字 `PER_PARTICLE_SYSTEM_LIGHTING`（字符串 `"PER_PARTICLE_SYSTEM_LIGHTING"`）控制是否启用逐粒子系统光照。

---

## DepthPyramid（深度/颜色金字塔）

### 2x2 Min/Max下采样

`DepthPyramidRenderingPass` 提供三种实现策略：

1. **DepthPyramidNoLDSRenderingPass**：不使用 LDS（共享内存）的纯计算着色器实现
2. **DepthPyramidLDSRenderingPass**：使用 LDS 以提高性能
3. **DepthPyramidCustomMipsRenderingPass**：自定义 MIP 级别构建，支持 `MAX_MIP_COUNT = 7`

`CBufferData` 结构体：
- `prevTextureSize`：上一级纹理尺寸
- `currTextureSize`：当前级纹理尺寸
- `param0`：额外参数

### Mip构建

构建要点：
- 输入深度纹理 -> 输出深度金字塔纹理
- 每级 MIP 使用 2x2 像素的 **Min**（最小深度）或 **Max**（最大深度）进行降采样
- NoLDS 版本直接从源纹理采样；LDS 版本先将数据加载到共享内存再降采样
- CustomMips 版本允许自定义每级的降采样策略
- 关键字 `s_MipLevelCount1` ~ `s_MipLevelCount4` 标识 MIP 级别的数量
- `s_FetchFromLastMip`：是否从最后一级 MIP 采样
- Profile：`DepthPyramid` (38)、`HiZDownSamplePhase0` (3)、`HiZDownSamplePhase1` (4)

渲染图资源名称：`"Depth Pyramid"`、`"DepthPyramid"`

---

## 1:1 复刻实现要点

要在新引擎中 1:1 复刻此光照系统，需注意以下关键点：

1. **渲染图框架（Render Graph）**：所有 Pass 都基于 `IPassConstructor` 接口和 `HGRenderGraph`/`HGRenderGraphBuilder` 的渲染图系统。需实现纹理生命周期管理和 Pass 依赖排序。

2. **GBuffer 布局**：延迟光照依赖 4 个 GBuffer 纹理（Albedo、Specular/Roughness、Normal、Emissive/Other），通过 `GBufferOutput.GetGBufferAttachment()` 访问。

3. **着色器资源加载**：Compute Shader 和 Material 通过 `HGRenderPipelineMaterialCollector.CreateMaterial()` 和资源列表（`HGRenderPathResources`）加载。关键路径包括 `Runtime/Shaders/Lighting/SSR/`、`Runtime/Shaders/RayTracing/Reflection/` 等。

4. **IFix patching**：原始代码使用 HybridCLR/IFix 进行热补丁。净室实现应直接用原生 C# 替换所有 IFix 调用。

5. **ECS 列表**：Forward Opaque、Character、Outline 等渲染列表通过 ECS（Entity Component System）管理，使用 `uint` 句柄传递。

6. **着色器 ID 系统**：所有 Shader Property ID 集中在 `HGShaderIDs` 和 `HGShaderKeyWords` 中。必须按 ID 完整复刻以避免绑定遗漏。

7. **ComputeBuffer/tile shading**：`drawTileArgs` 和 `tileInstanceIndices` 用于基于贴片的延迟光照（后续扩展）。

8. **CVAR/Quality 系统**：SSR 采样数（`ssrRayMarchingSampleCount`）和质量级别来自 `HGSettingParameters` 设置参数。

9. **时域复用的帧管理**：所有时域效果（GTAO Temporal、SSR Temporal）需要管理 `firstFrame` 标志、历史纹理乒乓（previous/current）和运动向量重投影。

10. **Volume 框架**：`GTAmbientOcclusion` 和 `ScreenSpaceReflectionVolume` 均继承自 Unity `VolumeComponent`，通过 Volume 框架覆盖全局参数。
