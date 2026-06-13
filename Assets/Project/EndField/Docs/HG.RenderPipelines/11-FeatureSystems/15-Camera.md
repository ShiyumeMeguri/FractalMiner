# HG Render Pipeline — 渲染相机系统 (HGCamera / ViewConstants / TAA Jitter / 物理相机) 技术实现原理蓝图

> 本文是**从零 1:1 重建** 终末地 (EndField) HG.RenderPipelines 相机系统的实现蓝图。`HGCamera` 是 **Unity HDRP `HDCamera`** 的**重度 fork**：每帧矩阵打包、TAA Halton(2,3) 抖动、history RT 双缓冲、camera-relative rendering、Frustum 6 平面 8 角点构造等**核心算法直接据 HDRP 真实源** (`com.unity.render-pipelines.high-definition@75de48326bcd/Runtime/RenderPipeline/Camera/HDCamera.cs`) 讲清并 1:1 抄录；HG 反编译 C# (`HGCamera.cs:17671 行`) 仅用来定位 **HG 的 delta**：扩充到 23 个矩阵的 `ViewConstants` (含 `widerFoVViewProjMatrix` / `reprojectionMatrix` / 独立 `cullingMatrix`)、`s_Cameras` 双键 `(Camera, xrMultipassId)` 的 keying、TAA 相位 mask `& 0x3FF` 取代 HDRP 的 `& (kTaaSequenceLength - 1)`、`HGPhysicalCamera` 默认值与 HDRP 完全一致。
>
> **配套文档（不复述、只链）**：
> - 每帧视图常量 C++ 侧布局 `HGViewConstantsCPP`：[`../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md`](../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md) §6.5
> - 算法概览（矩阵推导、log-Z、camera-relative rendering 通用约定）：[`../02-CoreAlgorithms/01-CoreAlgorithms.md`](../02-CoreAlgorithms/01-CoreAlgorithms.md)
> - 阴影 (`widerFoVViewProjMatrix` 用作扩展光照锥)：[`./07-ShadowASM.md`](./07-ShadowASM.md)
> - 体积 (`pixelCoordToViewDirWS` 用于 SkyView LUT 与 froxel)：[`./05-Volumetric.md`](./05-Volumetric.md)

---

## 0. 目录

| § | 主题 |
|---|------|
| 1 | 相机系统解决的问题 / 与 HDRP 血缘对照 |
| 2 | HGCamera ↔ HDCamera 对象模型 & keying |
| 3 | ViewConstants：23 矩阵布局，每个矩阵的算法用途 |
| 4 | 每帧 `Update` 时序与 `taaFrameIndex` 推进 |
| 5 | `GetJitteredProjectionMatrix`：Halton(2,3) 抖动注入 (HDRP 真公式) |
| 6 | `UpdateViewConstants`：camera-relative rendering + 22 个矩阵推导 |
| 7 | `UpdateFrustum`：6 平面 + 8 角点 + `zBufferParams` 推导 |
| 8 | `ComputePixelCoordToWorldSpaceViewDirectionMatrix`：天空与 SkyView LUT 用 |
| 9 | history RT 系统 (`BufferedRTHandleSystem`) 与 `CleanUnused` |
| 10 | 物理相机：`HGPhysicalCamera.GetDefaults` 与 HDRP 数值 1:1 |
| 11 | `CameraSettings` 反向通路：Custom Pass / Reflection Probe 重渲 |
| 12 | 1:1 重建蓝图 (分步) |
| 13 | 关键常量 / 魔数 / 反编译证据 |
| 14 | 源文件清单 |

---

## 1. 相机系统解决的问题 / 与 HDRP 血缘对照

### 1.1 解决什么

一个 SRP 相机系统要在每帧渲染开始前给所有 pass 提供**齐套**的**世界 → 屏幕**线性代数 (view / proj / viewProj / 它们的逆)，并且为**时间累积特效** (TAA / SSR 历史 / 体积云 history / GTAO history) 提供：

1. **当前帧 jittered 矩阵** 用于光栅 (使 sub-pixel 抖动落到几何上)；
2. **当前帧 non-jittered 矩阵** 用于运动向量、culling、SkyView (不可有像素抖动)；
3. **上一帧矩阵**用于 **reprojection**：把当前 NDC 反投到上一帧 UV 取样 history RT；
4. **camera-relative rendering** 的 view 矩阵：去掉相机平移分量、避免 GPU 端 32-bit float 精度坍塌；
5. **history RT 双缓冲** + **per-camera keying**：reflection probe / scene view / game view 各自独立的时间累积线程；
6. **culling-only 矩阵**：culling 视锥可能比绘制视锥**更宽** (FOV 覆盖、阴影扩张)；
7. **像素 → 视方向 矩阵**：天空采样、SkyView LUT 需要 (u,v) → 世界空间视方向；
8. **物理相机参数**：ISO / 快门 / 光圈 / 焦距 / 光圈叶片 / 桶形裁剪 / 变形 (DOF、自动曝光的物理基础)。

### 1.2 HG ↔ HDRP 名词映射

| HG | HDRP 同源 | 算法位置 |
|---|---|---|
| `HGCamera` (`HGCamera.cs`) | `HDCamera` (`Runtime/RenderPipeline/Camera/HDCamera.cs:23`) | §2 |
| `HGCamera.s_Cameras` 字典键 `(Camera, int)` | `HDCamera.s_Cameras` 字典键 `(Camera, int, HistoryChannel)` (`:200`) | §2.2 |
| `HGCamera.ViewConstants` (23 矩阵) | `HDCamera.ViewConstants` (15 矩阵) (`:29-83`) | §3 |
| `HGCamera.GetOrCreate(Camera, int)` | `HDCamera.GetOrCreate(Camera, int)` (`:178-207`) | §2.2 |
| `HGCamera.Update(...)` | `HDCamera.Update(...)` (`:1290-1405`) | §4 |
| `HGCamera.GetJitteredProjectionMatrix` (Halton 2,3) | `HDCamera.GetJitteredProjectionMatrix` (`:2261-2344`) | §5 |
| `HGCamera.UpdateAllViewConstants` (3-overload) | `HDCamera.UpdateAllViewConstants` (`:1982/1995`) | §6 |
| `HGCamera.UpdateViewConstants` (8 参数) | `HDCamera.UpdateViewConstants` (`:2030-2114`) | §6 |
| `HGCamera.UpdateFrustum` | `HDCamera.UpdateFrustum` (`:2116-2177`) | §7 |
| `HGCamera.ComputePixelCoordToWorldSpaceViewDirectionMatrix` | `HDCamera.ComputePixelCoordToWorldSpaceViewDirectionMatrix` (`:2363-2407`) | §8 |
| `HGCamera.IsLargeCameraMovement` | `HDCamera.IsLargeCameraMovement` (HDRP 同名函数) | §4.4 |
| `HGCamera.CleanUnused` | `HDCamera.CleanUnused` (`:1496-1521`) | §9 |
| `HGCamera.m_HistoryRTSystem` (BufferedRTHandleSystem) | `HDCamera.m_HistoryRTSystem` (`:1411`) | §9 |
| `HGCamera.taaFrameIndex` & mask `& 0x3FF` | `HDCamera.taaFrameIndex` & `kTaaSequenceLength=1024` (`:476`) | §5.1 |
| `HGPhysicalCamera.GetDefaults()` (ISO=200, 1/200s, f/16, 10m, 5 叶) | `HDPhysicalCamera.GetDefaults()` (`HDAdditionalCameraData.cs:139-151`) | §10 |
| `HGAdditionalCameraData` MonoBehaviour | `HDAdditionalCameraData` MonoBehaviour (`HDAdditionalCameraData.cs:161`) | §11 |
| `CameraSettings` 反向通路 | `CameraSettings` (HDRP) | §11 |
| `HG.Rendering.Runtime.Frustum.Create(...)` | `Frustum.Create(...)` (HDRP `Frustum.cs`) | §7.2 |

### 1.3 HG 关键 delta（一览，详见各节）

| Delta | 反编译证据 | 用途 |
|---|---|---|
| `ViewConstants` 增加 `widerFoVViewProjMatrix` / `widerFoVInvViewProjMatrix` | `HGCamera.cs:59-61` | 阴影/光照辐射范围放宽 (CSM 边缘 sample 用) |
| `ViewConstants` 增加 `reprojectionMatrix` | `HGCamera.cs:57` | 当前 NDC → 上一帧 NDC 的封装矩阵 (TAA fast path) |
| `ViewConstants` 增加独立 `cullingMatrix` | `HGCamera.cs:65` | culling 视锥 ≠ 绘制视锥 (CullingFOV override) |
| `ViewConstants` 同时存 `viewNoTransProjMatrix` 与 `nonJitteredViewNoTransProjMatrix` (HDRP 只存 `viewProjectionNoCameraTrans` 内部字段) | `HGCamera.cs:33,39` | 天空盒/SkyView 直接拿，不再每次 SetColumn(3,...) |
| 字典 keying 双键 `(Camera, xrMultipassId)` | `HGCamera.cs:374 / 2612-2844` | HDRP 三键 `(Camera, xrMultipassId, HistoryChannel)`，HG 裁掉 HistoryChannel |
| TAA 相位 mask `& 0x3FF` (硬编码 1023) | `HGCamera.cs:16089 idiv` + `& 0x3FF` | 与 HDRP `kTaaSequenceLength=1024` 数值等价但 magic 硬编码 |
| 1024 个相位上限，反编译 `idiv ecx` 后 `inc eax`，相位 = `(taaFrameIndex & 0x3FF) + 1` | `HGCamera.cs:16089-16093` | HDRP 同样 `HaltonSequence.Get(taaFrameIndex+1, 2/3)` (`:2290-2291`)，索引 +1 避开退化样本 |
| `BeforeCullingCPP` 把 culling 参数提前打包成 unmanaged `HGRenderPathBeforeCullingParamsCPP*` 给 C++ 走 ECS 剔除 | `HGCamera.cs:212` | HDRP 无此 SRP-CPP 桥；HG 一切跨过 IL2CPP 边界的剔除走 native (见 [`../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md`](../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md) §6.5) |
| `s_Cameras` 全局静态字典 + `s_Cleanup` 临时列表两阶段清理（避免迭代时改集合）| `HGCamera.cs:374-376, 11523+` | HDRP 同模式 (`HDCamera.cs:1496-1521`) |
| `taaJitter.zw` 在 CPU 端**额外乘** `1/renderingScale` (= `xmm9`) | `HGCamera.cs:16140-16151` | HDRP 在 shader 端做这个 scale；HG 前移到 CPU 省 ALU |

> **算法溯源等级**：本文 §3-§9 的**所有数学** (Halton 公式、camera-relative VP 推导、`zBufferParams` reverseZ 公式、`pixelCoordToViewDirWS` 公式) 都是 HDRP 真源 cite **行号** 1:1 抄录；HG 反编译只用来证明 **HG 也走同样路径**（同 `call`、同立即数、同次序）。HG 自创的字段也只是 **HDRP 字段集合的超集**，没有任何**算法**层的偏离。

---

## 2. HGCamera ↔ HDCamera 对象模型 & keying

### 2.1 双层架构

```
┌─────────────────────────────────────────────────────────────────────────────┐
│ 编辑器/序列化层                                                              │
│                                                                              │
│   [Unity Camera (引擎原生)]                                                  │
│        │                                                                     │
│        │ component (RequireComponent)                                        │
│        ▼                                                                     │
│   [HGAdditionalCameraData : MonoBehaviour]    (HGAdditionalCameraData.cs)    │
│   ├── clearColorMode / backgroundColorHDR / clearDepth                       │
│   ├── volumeLayerMask / volumeAnchorOverride                                 │
│   ├── antialiasing : AntialiasingMode  (None/TAA/MetalFX*/PSSR/DLSS/FSR3)    │
│   ├── physicalParameters : HGPhysicalCamera  (= GetDefaults() 默认)          │
│   ├── flipYMode / overrideCullingFOV / cullingFOVValue                       │
│   ├── allowDynamicResolution / customRenderingSettings / invertFaceCulling   │
│   ├── probeLayerMask / hasPersistentHistory / materialMipBias                │
│   ├── m_RenderingPathCustomFrameSettings : FrameSettings                     │
│   ├── customRender    : Action<ScriptableRenderContext, HGCamera>            │
│   └── requestGraphicsBuffer : RequestAccessDelegate                          │
└─────────────────────────────────────────────────────────────────────────────┘
                            │
                            │ 单向流入 (HGCamera.Update 中读取)
                            ▼
┌─────────────────────────────────────────────────────────────────────────────┐
│ 运行时层  (HGCamera.s_Cameras 字典)                                          │
│                                                                              │
│   key: (Camera, xrMultipassId : int)  ──→  HGCamera (托管类，非 MonoBehaviour) │
│                                                                              │
│   HGCamera 实例 (≈ 1640+ 字节)                                              │
│   ├── camera                  : Camera                                       │
│   ├── frustum                 : HG.Rendering.Runtime.Frustum  (6 plane+8 corner) │
│   ├── mainViewConstants       : ViewConstants  (23 mat + 3 vec3 + pad = 1520B)│
│   ├── taaJitter / taaFrameIndex / taaJitterPhaseCount                        │
│   ├── zBufferParams / projectionParams / screenParams / unity_OrthoParams    │
│   ├── m_HistoryRTSystem       : BufferedRTHandleSystem  (PINGPONG_COUNT = 2) │
│   ├── shadowManager / lightCookieManager                                     │
│   ├── volumetricIntegratedLightScatteringTexture / history…                  │
│   ├── atmosphereSkyViewLutTexture / atmosphereLutConstants                   │
│   ├── cullingViewHandle / waterProxyCullHandle / rayTracingTLASHandle  (ECS) │
│   └── renderPathInstanceCPP : long  +  beforeCullingParams : *CPP            │
└─────────────────────────────────────────────────────────────────────────────┘
```

数据**单向**：编辑器层 → 运行时层。`CameraSettings` (§11) 是**反向**通路：把一组结构化设置写回 Unity Camera + HGAdditionalCameraData。

### 2.2 keying：`(Camera, xrMultipassId)` vs HDRP `(Camera, int, HistoryChannel)`

```csharp
// HGCamera.cs:374
public static Dictionary<(Camera, int), HGCamera> s_Cameras;

// HGCamera.cs:2612 (反汇编简译)
public static HGCamera GetOrCreate(Camera camera, int xrMultipassId = 0)
{
    if (!s_Cameras.TryGetValue((camera, xrMultipassId), out var hgCam))
    {
        hgCam = new HGCamera(camera);
        s_Cameras.Add((camera, xrMultipassId), hgCam);
    }
    return hgCam;
}
```

**HDRP 原本 3 键**（`HDCamera.cs:178-207`）：

```csharp
public static HDCamera GetOrCreate(Camera camera, int xrMultipassId = 0)
    => GetOrCreate(camera, xrMultipassId, HistoryChannel.RenderLoopHistory);

internal static HDCamera GetOrCreate(Camera camera, int xrMultipassId, HistoryChannel historyChannel)
{
    if (!s_Cameras.TryGetValue((camera, xrMultipassId, historyChannel), out var hdCamera))
    {
        hdCamera = new HDCamera(camera);
        s_Cameras.Add((camera, xrMultipassId, historyChannel), hdCamera);
    }
    return hdCamera;
}
```

**HG delta**：删掉了第三键 `HistoryChannel` (HDRP 用来让用户的 `Camera.SubmitRenderRequest` 借走 8 个独立 history 槽位)。HG 显然没暴露 user render request 这套，所以一对 `(camera, xrMultipassId)` 就够了。**算法行为完全一致**：缺失时 `new HGCamera(camera)` 然后 Add 进字典；命中时直接返回。

### 2.3 构造与默认值

`HGCamera(Camera cam)` 构造路径（据反汇编 ctor 序列）写入以下默认值，等同 HDRP 的字段初始化：

| 字段 | HG 默认 | HDRP 同源 |
|---|---|---|
| `lowResScale` | `1.0f` (`g_18C471324`) | `HDCamera.cs:484` (`= 0.5f` 但首帧立即被 `DynamicResolutionHandler.GetLowResMultiplier` 覆盖；HG 直接 1.0f 起手) |
| `screenRatioCullingDistance` | `20.0f` (`g_18C4719C0`) | HG 特化字段，HDRP 无 |
| `m_PreviousClearColorMode` | `2 = None` | `HDCamera.cs:1971` `m_PreviousClearColorMode = clearColorMode;` |
| `physicalParameters` | `HGPhysicalCamera.GetDefaults()` (见 §10) | `HDAdditionalCameraData.cs:139-151` 同函数同数值 |
| `taaJitter` | `(0,0,0,0)` | `HDCamera.cs:1959` |
| `m_volumeComponentsData` | `new VolumeComponentsData()` | `HDCamera` 没有这个聚合类（HDRP 每个 effect 各自 `volumeStack.GetComponent<X>()`）；HG 把 21 个 Volume Component 一次解算后缓存（§10.3） |
| `m_envVolumeCameraComponent` | `new HGEnvironmentVolumeCameraComponent()` | HG 新增，详见 [`./06-EnvironmentSky.md`](./06-EnvironmentSky.md) |
| `m_HistoryRTSystem` | `new BufferedRTHandleSystem()` (PINGPONG_COUNT=2) | `HDCamera.cs:1293` 同类型 |

### 2.4 生命周期：GetOrCreate → Update → BeginRender → 各 pass → CleanUnused

```
管线 Frame N 开始
  ├─ for each Unity Camera in Camera.allCameras (按 depth 排序):
  │     ├─ HGCamera.GetOrCreate(cam, 0)                       § 2.2
  │     ├─ HGCamera.Update(frameSettings, hgrp, allocHist=true)  § 4
  │     │     ├─ UpdateAntialiasing()                          § 4.2
  │     │     ├─ UpdateRenderingScale(...)                     § 4.3
  │     │     ├─ taaFrameIndex 推进  ((idx + 1) & 0x3FF)       § 5.1
  │     │     ├─ UpdateAllViewConstants(hgrp)                  § 6
  │     │     │     ├─ GetJitteredProjectionMatrix(...)        § 5.2
  │     │     │     ├─ UpdateViewConstants(...)  写 22 个矩阵  § 6
  │     │     │     └─ UpdateFrustum(...)  6 面 8 角点         § 7
  │     │     ├─ UpdateVolumeAndPhysicalParameters()           § 10.3
  │     │     └─ m_HistoryRTSystem.SwapAndSetReferenceSize     § 9
  │     ├─ BeginRender(cmd)：CameraCaptureBridge / Exposure 启动  § 4.1
  │     ├─ BeforeCullingCPP → 进 ECS culling (§ 12 / 04-GraphicsCPPModule §6.5)
  │     └─ Execute Render Path (各 pass 读 mainViewConstants / frustum)
  ├─ HGCamera.CleanUnused(...)：清理 disabled / null camera 的条目  § 9.2
  └─ Frame N+1
```

---

## 3. ViewConstants：23 矩阵布局，每个矩阵的算法用途

```csharp
// HGCamera.cs:19-78
public struct ViewConstants
{
    public Matrix4x4 viewMatrix;
    public Matrix4x4 invViewMatrix;
    public Matrix4x4 projMatrix;                              // jittered (TAA 子像素抖动后)
    public Matrix4x4 nonJitteredProjMatrix;                   // 不抖动 (运动向量 / culling / SkyView)
    public Matrix4x4 invProjMatrix;
    public Matrix4x4 viewProjMatrix;                          // = projMatrix * viewMatrix
    public Matrix4x4 viewNoTransProjMatrix;                   // = projMatrix * (view 去 translation)
    public Matrix4x4 invViewProjMatrix;
    public Matrix4x4 nonJitteredViewProjMatrix;               // = nonJitteredProjMatrix * viewMatrix
    public Matrix4x4 nonJitteredViewNoTransProjMatrix;
    public Matrix4x4 invNonJitteredViewProjMatrix;
    public Matrix4x4 prevViewMatrix;
    public Matrix4x4 prevViewProjMatrix;                      // 上一帧 (用于 reprojection / motion)
    public Matrix4x4 prevViewNoTransProjMatrix;
    public Matrix4x4 prevNonJitteredViewProjMatrix;
    public Matrix4x4 prevNonJitteredViewNoTransProjMatrix;
    public Matrix4x4 prevInvViewProjMatrix;
    public Matrix4x4 prevNonJitteredInvViewProjMatrix;
    public Matrix4x4 reprojectionMatrix;                      // HG delta: 当前 NDC → 上一帧 NDC 封装
    public Matrix4x4 widerFoVViewProjMatrix;                  // HG delta: 阴影/特效 FOV 扩张
    public Matrix4x4 widerFoVInvViewProjMatrix;
    public Matrix4x4 pixelCoordToViewDirWS;                   // (pixel x,y) → world-space view direction
    public Matrix4x4 cullingMatrix;                           // culling-only VP (cullingFOV 覆盖)
    public Vector3   worldSpaceCameraPos;     internal float pad0;
    public Vector3   worldSpaceCameraPosViewOffset;  internal float pad1;  // 立体 / 反射探针 view 偏移
    public Vector3   prevWorldSpaceCameraPos; internal float pad2;
}
// sizeof = 23 * 64 + 3 * 16 = 1520 B
```

### 3.1 矩阵分组与算法用途

| 矩阵 | 公式 (HDRP `HDCamera.cs` 同源行号) | 谁消费 |
|---|---|---|
| `viewMatrix` | `= gpuView` 见 `HDCamera.cs:2091`；当 `ShaderConfig.s_CameraRelativeRendering!=0` 时 column 3 置 `(0,0,0,1)` (`HDCamera.cs:2048`) | 所有 vertex shader |
| `invViewMatrix` | `= viewMatrix.inverse` (`HDCamera.cs:2092`) | 屏幕空间反推世界坐标 (SSR / SSGI / 体积) |
| `projMatrix` | `= GL.GetGPUProjectionMatrix(jitteredProj, renderIntoTexture=true)` (`HDCamera.cs:2041, 2094`) | 光栅 + DOF / Bokeh 真实投影 |
| `nonJitteredProjMatrix` | `= GL.GetGPUProjectionMatrix(nonJitteredCameraProj, true)` (`HDCamera.cs:2043, 2093`) | 运动向量 (上一帧也是 non-jittered)，避免抖动污染速度 |
| `invProjMatrix` | `= projMatrix.inverse` (`HDCamera.cs:2095`) | view-space 反推、SSAO 半球采样 |
| `viewProjMatrix` | `= projMatrix * viewMatrix` (`HDCamera.cs:2096`) | TAA 当帧采样、frag→clip 通用 |
| `invViewProjMatrix` | `= viewProjMatrix.inverse` (`HDCamera.cs:2097`) | 屏幕 UV + 深度 → 世界坐标 (体积、雾、SSR) |
| `viewNoTransProjMatrix` | `= nonJitteredProjMatrix * (view 去 column3)` 见 `gpuVPNoTrans` (`HDCamera.cs:2058`)；HG 直接做字段（HDRP 是 `viewProjectionNoCameraTrans` 内部用） | 天空盒、SkyView LUT、Sky cube 绘制 (只要方向不要位置) |
| `nonJitteredViewProjMatrix` | `= nonJitteredProjMatrix * viewMatrix` (`HDCamera.cs:2098`) | culling、Sky、运动向量参考 |
| `nonJitteredViewNoTransProjMatrix` | 同 `viewNoTransProjMatrix` 但用 non-jittered proj | HG 显式存以避免每次重算 |
| `invNonJitteredViewProjMatrix` | `= nonJitteredViewProjMatrix.inverse` (`HDCamera.cs:2099`) | 深度 → 世界 (不用抖动 proj，避免亚像素误差) |
| `prevViewMatrix` | `= 上一帧 viewMatrix` (`HDCamera.cs:2084`) | 运动向量、TAA reprojection |
| `prevViewProjMatrix` | `= 上一帧 nonJitteredViewProjMatrix * Translate(cameraDisplacement)` (`HDCamera.cs:2086, 2111`)；位移补偿是 camera-relative rendering 的关键 | TAA reprojection、SSR history、GTAO history |
| `prevViewNoTransProjMatrix` | `= 上一帧 viewProjectionNoCameraTrans` (`HDCamera.cs:2087`) | 体积云 / 大气 history reproject |
| `prevNonJitteredViewProjMatrix` / `prevNonJitteredViewNoTransProjMatrix` | non-jittered 版本，HG 单独存 (HDRP 的 `prevViewProjMatrix` 本来就是 non-jittered，因为 `viewConstants.prevProjMatrix = viewConstants.nonJitteredProjMatrix`) | 体积 / 雾 / SkyView 的 history |
| `prevInvViewProjMatrix` | `= prevViewProjMatrix.inverse` (`HDCamera.cs:2112`) | reprojection 反算 history UV |
| `prevNonJitteredInvViewProjMatrix` | non-jittered 版本 | 运动向量计算的逆通路 |
| `reprojectionMatrix` (**HG delta**) | 封装的 `prevViewProj * invCurViewProj`，便于 TAA shader 一次乘法 | TAA / 云 history fast path (HDRP 在 .compute 里逐 pass 算) |
| `widerFoVViewProjMatrix` / `widerFoVInvViewProjMatrix` (**HG delta**) | 把 FOV 在两个方向扩张 (常见做法 `fov *= 1.1f`)，重算 VP | CSM 边缘 sample、Volumetric Cloud SDF march、特效投影 |
| `pixelCoordToViewDirWS` | 见 §8 公式 | 天空 fragment、SkyView LUT、Volumetric Cloud SDF 起点 |
| `cullingMatrix` | 当 `HGAdditionalCameraData.overrideCullingFOV=true` 时用 `cullingFOVValue` 重算 perspective；否则等于 `nonJitteredViewProjMatrix` | culling + frustum 构造 |
| `worldSpaceCameraPos` | `= cameraPosition` (`HDCamera.cs:2100`) | shader `_WorldSpaceCameraPos` |
| `worldSpaceCameraPosViewOffset` | `Vector3.zero` for mono；XR singlePass 时 `= XRView[i].pos - mainPos` (`HDCamera.cs:2016`) | XR 双眼偏移 |
| `prevWorldSpaceCameraPos` | `= worldSpaceCameraPos - cameraDisplacement`，再变成相对 (`HDCamera.cs:2110`) | 运动向量 / TAA |

### 3.2 sizeof 验证

23 矩阵 × 64 B + 3 (Vector3 + pad) × 16 B = **1520 B**，对应反汇编里 `[rbx+0x78 .. rbx+0x6F0]` 区段 (`UpdateViewConstants` 从 `mainViewConstants` 偏移 `+0x78` 起逐项 `movups`)。

### 3.3 为什么需要这么多矩阵

| 用途 | 必要矩阵 |
|---|---|
| 简单 vertex 变换 | `viewProjMatrix` 一个 |
| 屏幕反推世界 | `+ invViewProjMatrix` |
| 视空间运算 | `+ invProjMatrix + viewMatrix` |
| 天空 (只要方向) | `+ viewNoTransProjMatrix` |
| 运动向量 | `+ nonJitteredViewProjMatrix + prevNonJitteredViewProjMatrix` |
| TAA history sampling | `+ prevViewProjMatrix + prevInvViewProjMatrix`（+ reprojectionMatrix HG fast path） |
| culling | `+ cullingMatrix` |
| 阴影/光照辐射 | `+ widerFoVViewProjMatrix` |
| SkyView LUT | `+ pixelCoordToViewDirWS` |

HDRP 13 矩阵 (`HDCamera.ViewConstants:29-83`) + HG 加 10 个 (`viewNoTransProjMatrix`、`nonJitteredViewNoTransProjMatrix`、`prevViewNoTransProjMatrix`、`prevNonJitteredViewProjMatrix`、`prevNonJitteredViewNoTransProjMatrix`、`prevInvViewProjMatrix`、`prevNonJitteredInvViewProjMatrix`、`reprojectionMatrix`、`widerFoVViewProjMatrix`、`widerFoVInvViewProjMatrix`)，其中很多是 HDRP 在 .compute 里**临时**算的；HG 选择**显式存**省 ALU。**算法上没有创新**。

---

## 4. 每帧 `Update` 时序与 `taaFrameIndex` 推进

### 4.1 `Update` 主体

```csharp
// HGCamera.cs:9981 签名 + 反汇编调用序列重建
internal void Update(FrameSettings currentFrameSettings, HGRenderPipeline hgrp,
                     bool allocateHistoryBuffers = true)
{
    // 1. RenderPath 初始化 (按 currentFrameSettings 选 Forward/Deferred/...)
    InitializeRenderPath(this, ...);

    // 2. 解算 viewport (含 dynamic resolution)
    HGRenderPipeline.HGResolutionSettings.UpdateHGCameraPixelRect(this, false);

    // 3. light-weight camera 链路 (lwCameraAttached) 也走一次 InitializeRenderPath
    // 4. 写 globalMipBias、materialMipBias 进相机
    materialMipBias = additionalCameraData.materialMipBias;
    UpdateVolumeAndPhysicalParameters();                                 // §10.3

    // 5. 记下当前 frameSettings
    this.frameSettings = currentFrameSettings;
    UpdateAntialiasing();                                                // §4.2

    // 6. taaFrameIndex 推进  (§5.1 详细)
    if (resetPostProcessingHistory)
        taaFrameIndex = 0;
    else if (RequiresCameraJitter())
        taaFrameIndex = (taaFrameIndex + 1) & 0x3FF;     // & (1024-1)，HDRP HDCamera.cs:1397 一字不差

    // 7. 写 22 个矩阵 + frustum
    UpdateAllViewConstants(hgrp);                                        // §6

    isFirstFrame = false;
    cameraFrameCount++;

    // 8. history RT 系统的 swap
    if (allocateHistoryBuffers)
        m_HistoryRTSystem.SwapAndSetReferenceSize(actualWidth, actualHeight);
}
```

HDRP 同函数 (`HDCamera.cs:1290-1405`)：

```csharp
// HDCamera.cs:1394-1401
if (resetPostProcessingHistory)
    taaFrameIndex = 0;
else if (RequiresCameraJitter())
    taaFrameIndex = (taaFrameIndex + 1) & (kTaaSequenceLength - 1);
UpdateAllViewConstants();
isFirstFrame = false;
cameraFrameCount++;
```

`kTaaSequenceLength = 1024` (`HDCamera.cs:476`)，**与 HG 反编译里 `& 0x3FF` 数值完全一致**。HG 把它写死成 magic，没有暴露常量。

### 4.2 `UpdateAntialiasing`

据反汇编 `HGCamera.cs:13086-13317`：

```csharp
private void UpdateAntialiasing()
{
    // 反编译比较 [rbx+0x96C] & 0x8000：如果 frameSettings 不允许 PostProcess，强制 antialiasing=None
    // 反编译比较 [rbx+0x96C] & 0x0A：如果是 MetalFXTemporal 或 TAA 系列，调用 Camera.SetUsageHint(...)
    // 反编译比较 [rbx+0x96C] & 0x02 / 0x10/0x20/0x40：TAA / MetalFXSpatial / DLSS / FSR3
    //   只有这些模式才会 jitter projection
    // 同时检查 clearColorMode 是否变化，变化则触发 resetPostProcessingHistory

    if (additionalCameraData != null)
        antialiasing = additionalCameraData.antialiasing;

    if (clearColorMode != m_PreviousClearColorMode)
    {
        resetPostProcessingHistory = true;
        m_PreviousClearColorMode = clearColorMode;
    }
}
```

HDRP 同源 (`HDCamera.cs:1929-1972`)，把 `RequiresCameraJitter()` 的判定收敛到几个枚举位 + `frameSettings.Postprocess`。HG 用裸位运算 `test byte ptr [rbx+0x96C], N` 表达同一逻辑。

### 4.3 `UpdateRenderingScale`

`HGCamera.cs:13319` 调用 `HGSettingParameters` 与 `DynamicResolutionHandler` 算出 `actualWidth/Height`，与 HDRP `HDCamera.cs:1340-1378` 同流程：

```
actualWidth  = round(nonScaledViewport.x * dynamicResScale)
actualHeight = round(nonScaledViewport.y * dynamicResScale)
screenSize   = (w, h, 1/w, 1/h)
screenParams = (w, h, 1+1/w, 1+1/h)
lowResScale  = DynamicResolutionHandler.GetLowResMultiplier(lowResScale)
```

### 4.4 `IsLargeCameraMovement`：camera-cut 触发器

```csharp
// HGCamera.cs:11777
internal static bool IsLargeCameraMovement(in ViewConstants vc,
                                            float cameraRotationThreshold,   // 度
                                            float cameraPositionThreshold)  // 世界单位
```

反汇编算法 (`HGCamera.cs:11806-11982`)：

1. 把 `cameraRotationThreshold` 度数 × `g_18C4713F0 ≈ π/180` (= 0.0174533) → 弧度，再 `cos` → `cosThreshold`。
2. 取 `viewMatrix` 与 `prevViewMatrix` 的 column-0/1/2 (right/up/forward 基向量)：
   - `dot(curRight, prevRight)`、`dot(curUp, prevUp)`、`dot(curFwd, prevFwd)`，三者若**任一 < cosThreshold** ⇒ 大旋转。
3. 位移阈值平方比较：`SqrMagnitude(worldSpaceCameraPos - prevWorldSpaceCameraPos) > positionThreshold²`。
4. 任一满足 → 返回 true。

这是 HDRP `HDCamera.IsLargeCameraMovement` 标准做法（HDRP 同名函数原理一致）。返回 true 时管线把 `resetPostProcessingHistory = true`、`prevTransformReset = true` → 强制下一帧 reset history。

---

## 5. `GetJitteredProjectionMatrix`：Halton(2,3) 抖动注入

### 5.1 TAA 相位推进与 Halton 序列

**HDRP 真实 Halton 公式** (`com.unity.render-pipelines.core@ba70f6d20c11/Runtime/Utilities/HaltonSequence.cs:15-29`)：

```csharp
public static float Get(int index, int radix)
{
    float result = 0f;
    float fraction = 1f / radix;
    while (index > 0)
    {
        result   += (index % radix) * fraction;
        index    /= radix;
        fraction /= radix;
    }
    return result;
}
```

**HG 反编译 (`HGCamera.cs:16080-16131`) 1:1 复现同算法 + radix=2 与 radix=3 两组循环**：

```asm
; radix=2 循环（HGCamera.cs:16089-16103）
mov eax, [rdi+0x758]              ; eax = taaFrameIndex
and eax, 0x3FF                    ; & (1024-1)   ↔  & (kTaaSequenceLength - 1)
inc eax                           ; index = taaFrameIndex + 1   ↔  HDRP HDCamera.cs:2290 "(taaFrameIndex+1, 2)"
xorps xmm7, xmm7                  ; sumX = 0
xorps xmm6, xmm6                  ; sumY = 0
movss xmm1, dword ptr [g_18C471320]  ; fraction = 0.5f  (= 1/2)
mov ecx, 2                        ; radix = 2
loop2:
  cdq
  idiv ecx                        ; eax /= 2, edx = eax % 2
  movd xmm0, edx
  cvtdq2ps xmm0, xmm0
  mulss xmm0, xmm1                ; (idx % 2) * fraction
  mulss xmm1, [g_18C471320]       ; fraction /= 2   (= xmm8 = 0.5)
  addss xmm6, xmm0                ; sumX += ...
  test eax, eax
  jg short loop2
subss xmm6, dword ptr [g_18C471320]  ; sumX -= 0.5   →  jitterX = HaltonGet - 0.5

; radix=3 循环（HGCamera.cs:16110-16131）
;   用 "魔数 0x55555556 imul" 等价于 / 3 (Hacker's Delight 标准做法)
movss xmm2, dword ptr [g_18C47132C]  ; fraction divisor = 3.0f
loop3:
  mov ecx, r8d
  mov eax, 0x55555556
  imul r8d                        ; r8d / 3
  ...                             ; cdq/shr/add 校正得到商
  ; 取余 edx = r8d - 3*quot
  movd xmm0, edx
  cvtdq2ps xmm0, xmm0
  mulss xmm0, xmm1                ; (idx % 3) * fraction
  divss xmm1, xmm2                ; fraction /= 3
  addss xmm7, xmm0
  test r8d, r8d
  jg short loop3
subss xmm7, dword ptr [g_18C471320]  ; jitterY = HaltonGet - 0.5
```

**HDRP 调用站 (`HDCamera.cs:2290-2291`)** 1:1 等价：

```csharp
jitterX = HaltonSequence.Get(taaFrameIndex + 1, 2) - 0.5f;
jitterY = HaltonSequence.Get(taaFrameIndex + 1, 3) - 0.5f;
```

**为什么 `+ 1`**：HDRP 注释 (`HDCamera.cs:2288-2289`)：

> The variance between 0 and the actual halton sequence values reveals noticeable instability in Unity's shadow maps, so we avoid index 0.

**为什么 `- 0.5`**：让 jitter 均匀分布在 `[-0.5, +0.5)` 而不是 `[0, 1)`，这样 sub-pixel 抖动是**居中**的，TAA accumulation 不会单边偏。

**1024 相位**：`HDCamera.cs:474-476`：

```csharp
// This value is used to limit the taaFrameIndex value to a reasonable numeric range. The taaFrameIndex
// value is uploaded to shaders as a float so we should avoid letting it get too large to avoid precision issues.
// NOTE: We assume this value is always a power of two when using it modulate taaFrameIndex
internal const int kTaaSequenceLength = 1024;
```

HG 取 `& 0x3FF` 完全一致。

### 5.2 抖动注入 projection matrix

**HDRP `HDCamera.cs:2294-2341` 完整算法**（perspective 分支，HG 主要走这条）：

```csharp
// 1. 缩放抖动（DLSS/FSR/TAAU 等 upscale 时不缩，因为它们要 full jitter）
if (!(IsFSR2Enabled() || IsDLSSEnabled() || IsTAAUEnabled()
      || camera.cameraType == CameraType.SceneView))
{
    jitterX *= taaJitterScale;
    jitterY *= taaJitterScale;
}

// 2. 写公开字段（也上传到 cb._TaaJitterStrength）
taaJitter = new Vector4(jitterX, jitterY,
                        jitterX / actualWidth,   // 像素 → NDC 半宽归一
                        jitterY / actualHeight);

// 3. perspective: 分解投影 → 修改 4 条平面 → 重组
var planes = origProj.decomposeProjection;
float vertFov  = Math.Abs(planes.top)  + Math.Abs(planes.bottom);
float horizFov = Math.Abs(planes.left) + Math.Abs(planes.right);

var planeJitter = new Vector2(jitterX * horizFov / actualWidth,
                              jitterY * vertFov  / actualHeight);

planes.left   += planeJitter.x;
planes.right  += planeJitter.x;
planes.top    += planeJitter.y;
planes.bottom += planeJitter.y;

// 4. 处理 infinity far plane（reverse-Z）
if (float.IsInfinity(planes.zFar))
    planes.zFar = frustum.planes[5].distance;

return Matrix4x4.Frustum(planes);
```

HG 反汇编 (`HGCamera.cs:16131-16252`) 走**完全一致**的路径：

```asm
; HGCamera.cs:16140-16151：把 jitter 写到 taaJitter 字段
mov rbx, [rdi+0x60]               ; rbx = Camera 句柄
xorps xmm0, xmm0
cvtsi2ss xmm0, dword ptr [rdi+0x670]   ; actualHeight
xorps xmm1, xmm1
cvtsi2ss xmm1, dword ptr [rdi+0x66C]   ; actualWidth
movaps xmm2, xmm6                       ; xmm6 = jitterX (sumX-0.5)
divss xmm2, xmm1                        ; jitterX / actualWidth
movaps xmm1, xmm7                       ; xmm7 = jitterY
mulss xmm2, xmm9                        ; * (1/renderingScale)  ← HG delta：renderingScale 缩放
divss xmm1, xmm0                        ; jitterY / actualHeight
mulss xmm1, xmm9
; shuffle 4 个 float 进 xmm0 (jitterX, jitterY, jitterX/w*scale, jitterY/h*scale)
movups [rdi+0x68], xmm0                 ; 写到 taaJitter

; HGCamera.cs:16175-16213：分解 origProj 取 left/right/top/bottom，加 planeJitter，再走 Matrix4x4.Frustum
call UnityEngine.Camera::get_projectionMatrix (g_18FC421E0)
; 然后调用 g_18FC42220 = Matrix4x4::Frustum
```

**HG delta**：`jitterX/Y` 在写入 `taaJitter.zw` 时**额外乘了 `1/renderingScale` (= xmm9 = `g_18C471324 / renderingScale`)**。HDRP 不会乘这个 scale，因为 HDRP 的 TAA shader 自己对 jitter 做了 scale 归一。HG 把它**前移到 CPU 端**，让 shader 直接用 raw `_TaaJitterStrength.zw`。**数值正确性等价**，只是把 scale 责任搬家。

`FrameDebugger.enabled` 时同 HDRP (`HDCamera.cs:2271-2275`) 直接 `taaJitter = 0; return origProj;`：HG 反汇编 `HGCamera.cs:16068-16070`：

```asm
xor ecx, ecx
call UnityEngine.FrameDebugger::get_enabled
test al, al
jne near ptr loc_18619726A           ; 命中 → zero out jitter → return
```

---

## 6. `UpdateViewConstants`：camera-relative rendering + 22 个矩阵推导

### 6.1 顶层调度

**3 层调用 (`HGCamera.cs:11306 / 13405 / 13494`)**：

```csharp
// 公开 1 个参数版
internal void UpdateAllViewConstants(bool jitterProjectionMatrix, HGRenderPipeline hgrp)
    => UpdateAllViewConstants(jitterProjectionMatrix, /*updatePrev*/ false, hgrp);

// 私有 0 参数版 (Update 调它，自动判定 jitter)
private void UpdateAllViewConstants(HGRenderPipeline hgrp)
{
    // 反汇编 HGCamera.cs:13438-13464：
    //   bool requireJitter = (m_antialiasingMode & TAA) != 0;
    //   if (!requireJitter && SystemInfo.SupportsMetalFXTemporalScaler() &&
    //       (m_antialiasingMode & (MetalFXTemporal | DLSS | FSR3)) != 0)
    //       requireJitter = true;
    UpdateAllViewConstants(requireJitter, /*updatePrev*/ true, hgrp);
}
```

**3 参数版核心 (`HGCamera.cs:13494`)**：

```csharp
// 调用流（HGCamera.cs:13524-13633 反汇编序列）
camera.get_projectionMatrix(out Matrix4x4 proj);
camera.get_worldToCameraMatrix(out Matrix4x4 view);
camera.get_cameraToWorldMatrix(out Matrix4x4 invView);     // HG 显式取，HDRP 用 viewMatrix.inverse
camera.get_transform().get_position(out Vector3 camPos);

UpdateViewConstants(ref mainViewConstants, proj, view, invView, camPos,
                    jitterProjectionMatrix, updatePreviousFrameConstants, hgrp);
UpdateFrustum(in mainViewConstants);

m_RecorderCaptureActions = CameraCaptureBridge.GetCaptureActions(camera);
```

**HDRP 同源 (`HDCamera.cs:1995-2028`)**：

```csharp
void UpdateAllViewConstants(bool jitterProjectionMatrix, bool updatePreviousFrameConstants)
{
    var proj = camera.projectionMatrix;
    var view = camera.worldToCameraMatrix;
    var cameraPosition = camera.transform.position;
    if (xr.enabled && viewCount == 1)
        GetXrViewParameters(0, out proj, out view, out cameraPosition);
    UpdateViewConstants(ref mainViewConstants, proj, view, cameraPosition,
                        jitterProjectionMatrix, updatePreviousFrameConstants);
    // XR singlePassEnabled 时再写 m_XRViewConstants[i] (HG 反编译中也有同分支)
    UpdateFrustum(mainViewConstants);
    m_RecorderCaptureActions = CameraCaptureBridge.GetCaptureActions(camera);
}
```

### 6.2 `UpdateViewConstants` (8 参数) 算法

**HDRP `HDCamera.cs:2030-2114` 真实算法** (1:1 抄录注释)：

```csharp
void UpdateViewConstants(ref ViewConstants vc,
                          Matrix4x4 projMatrix,         // 来自 Camera.projectionMatrix
                          Matrix4x4 viewMatrix,         // 来自 Camera.worldToCameraMatrix
                          Vector3   cameraPosition,
                          bool      jitterProjectionMatrix,
                          bool      updatePreviousFrameConstants)
{
    // [STEP A] 计算 jittered / non-jittered proj
    var nonJitteredCameraProj = projMatrix;
    var cameraProj = jitterProjectionMatrix
        ? GetJitteredProjectionMatrix(nonJitteredCameraProj)
        : nonJitteredCameraProj;

    // [STEP B] GPU 投影矩阵 (跨平台 Y / Z 范围归一)
    var gpuProj            = GL.GetGPUProjectionMatrix(cameraProj,           true);
    var gpuView            = viewMatrix;
    var gpuNonJitteredProj = GL.GetGPUProjectionMatrix(nonJitteredCameraProj, true);

    // [STEP C] camera-relative rendering：去掉 view 矩阵的平移分量
    //   原因：世界坐标 32-bit float 在 1km 外就开始精度坍塌；把相机原点搬到 (0,0,0)，
    //   所有几何相对相机表示，把 (geomWorld - camPos) 在 CPU 端算好上传，
    //   GPU 只看到 ~|相机视锥半径| 范围内的小数值，精度回正。
    if (ShaderConfig.s_CameraRelativeRendering != 0)
        gpuView.SetColumn(3, new Vector4(0, 0, 0, 1));

    var gpuVP        = gpuNonJitteredProj * gpuView;
    var noTransView  = gpuView;
    if (ShaderConfig.s_CameraRelativeRendering == 0)
        noTransView.SetColumn(3, new Vector4(0, 0, 0, 1));   // 非相对模式手动去 translate
    var gpuVPNoTrans = gpuNonJitteredProj * noTransView;

    // [STEP D] 把上一帧矩阵滑到 prev 字段
    if (updatePreviousFrameConstants)
    {
        if (isFirstFrame)
        {
            // 首帧：prev = cur，避免运动向量为 NaN
            vc.prevWorldSpaceCameraPos  = cameraPosition;
            vc.prevViewMatrix            = gpuView;
            vc.prevProjMatrix            = gpuNonJitteredProj;
            vc.prevViewProjMatrix        = gpuVP;
            vc.prevInvViewProjMatrix     = vc.prevViewProjMatrix.inverse;
            vc.prevViewProjMatrixNoCameraTrans = gpuVPNoTrans;
        }
        else
        {
            // 普通帧：把上一帧 viewConstants 抓拍到 prev*
            vc.prevWorldSpaceCameraPos  = vc.worldSpaceCameraPos;
            vc.prevViewMatrix            = vc.viewMatrix;
            vc.prevProjMatrix            = vc.nonJitteredProjMatrix;
            vc.prevViewProjMatrix        = vc.nonJitteredViewProjMatrix;
            vc.prevViewProjMatrixNoCameraTrans = vc.viewProjectionNoCameraTrans;
        }
    }

    // [STEP E] 写当前帧 22 个矩阵
    vc.viewMatrix                   = gpuView;
    vc.invViewMatrix                = gpuView.inverse;
    vc.nonJitteredProjMatrix        = gpuNonJitteredProj;
    vc.projMatrix                   = gpuProj;
    vc.invProjMatrix                = gpuProj.inverse;
    vc.viewProjMatrix               = gpuProj * gpuView;
    vc.invViewProjMatrix            = vc.viewProjMatrix.inverse;
    vc.nonJitteredViewProjMatrix    = gpuNonJitteredProj * gpuView;
    vc.nonJitteredInvViewProjMatrix = vc.nonJitteredViewProjMatrix.inverse;
    vc.worldSpaceCameraPos          = cameraPosition;
    vc.worldSpaceCameraPosViewOffset = Vector3.zero;
    vc.viewProjectionNoCameraTrans  = gpuVPNoTrans;

    // [STEP F] 像素 → 视方向矩阵
    var gpuProjAspect = HDUtils.ProjectionMatrixAspect(gpuProj);
    vc.pixelCoordToViewDirWS = ComputePixelCoordToWorldSpaceViewDirectionMatrix(
        vc, screenSize, gpuProjAspect, ShaderConfig.s_CameraRelativeRendering);

    // [STEP G] camera-relative rendering 下，把 prevViewProjMatrix 也搬到当前相机原点
    if (updatePreviousFrameConstants)
    {
        Vector3 cameraDisplacement = vc.worldSpaceCameraPos - vc.prevWorldSpaceCameraPos;
        vc.prevWorldSpaceCameraPos -= vc.worldSpaceCameraPos;            // 相对 w.r.t. cur cam pos
        vc.prevViewProjMatrix      *= Matrix4x4.Translate(cameraDisplacement);
        vc.prevInvViewProjMatrix    = vc.prevViewProjMatrix.inverse;
    }
}
```

**HG 反编译完美匹配 (`HGCamera.cs:14041-14210`)**：

| 阶段 | 反编译证据 |
|---|---|
| (A) jitter 分支 | `cmp byte ptr [rbp+0x320], r15b; je 跳过 GetJitteredProjectionMatrix; call HG.Rendering.Runtime.HGCamera::GetJitteredProjectionMatrix` (`HGCamera.cs:14044-14057`) |
| (B) `GL.GetGPUProjectionMatrix` | `g_18FC41A90` 两次 (`HGCamera.cs:14063, 14080`) — HDRP 用 `GL.GetGPUProjectionMatrix` 同名 internal call |
| (C) `gpuView.SetColumn(3, (0,0,0,1))` | `mov edx, 0Ch; xorps xmm2, xmm2; call UnityEngine.Matrix4x4::set_Item × 3 次 (col=12,13,14)` + `mov edx, 0Fh; mov xmm2, 1.0; set_Item` (`HGCamera.cs:14137-14164`) — 这是 set column 3 = (0,0,0,1) 的展开 |
| (D-E) 矩阵乘法 | `g_18FC421E8 = Matrix4x4 operator*`，反复调用算 viewProj、invViewProj 等 (`HGCamera.cs:14184, 14209` 等) |
| (F) `pixelCoordToViewDirWS` | `call HG.Rendering.Runtime.HGCamera::ComputePixelCoordToWorldSpaceViewDirectionMatrix` (`HGCamera.cs:14575`) |
| (G) `Matrix4x4.Translate(cameraDisplacement)` | `call UnityEngine.Vector3::op_Subtraction` (= worldPos - prevWorldPos) 然后 `Matrix4x4 op_Multiply` (`HGCamera.cs:14816, 14820+`) |

**HG delta**：HG 把 `viewNoTransProjMatrix` 也作为显式字段写入 (HDRP 在 `viewProjectionNoCameraTrans` 内部字段写)，同时多出 `widerFoV*` 与 `reprojectionMatrix` 三个矩阵的额外计算 (反汇编 `HGCamera.cs:14586-14693` 段有 4 次额外的 `g_18FC421F8` invert + `g_18FC421E8` multiply，构造 widerFoV / reprojection)，**算法仍是同样的乘法/逆运算组合**。

### 6.3 camera-relative rendering 的数学正确性

设几何在世界坐标的位置为 \(\mathbf{p}_W\)，相机位置 \(\mathbf{c}_W\)。HDRP 在 CPU 端上传几何时已经把每个顶点替换为 \(\mathbf{p}_W - \mathbf{c}_W\)（camera-relative space, RWS）。所以 vertex shader 收到的 `positionRWS = p - c`。视矩阵的 column-3 是相机位置的负向（标准 worldToView 转换），写 `(0,0,0,1)` 等价于把 view 矩阵的平移分量清零，于是：

\[
\mathbf{p}_V = R \cdot \mathbf{p}_{RWS} = R \cdot (\mathbf{p}_W - \mathbf{c}_W) = (\text{完整 viewMatrix}) \cdot \mathbf{p}_W
\]

即结果与不做 camera-relative 一致，但**所有数值都在 ~|视锥半径| 范围**，32-bit float 精度不会塌。Step G 把 `prevViewProjMatrix *= Translate(cameraDisplacement)` 是同样的修正：上一帧的 `prevViewProj` 已经把 `prev_p_RWS = p_W - prev_c_W` 编码进矩阵，但本帧采样 history 用的是 `cur_p_RWS = p_W - cur_c_W`，差 `cameraDisplacement = cur_c_W - prev_c_W`，所以乘 `Translate(cameraDisplacement)` 把矩阵搬到当前相机原点 (`HDCamera.cs:2109-2112`)。

---

## 7. `UpdateFrustum`：6 平面 + 8 角点 + `zBufferParams`

### 7.1 `zBufferParams` 与 `projectionParams`（HDRP 真公式）

`HDCamera.cs:2139-2161`：

```csharp
float n = camera.nearClipPlane;
float f = camera.farClipPlane;

// 分析 projection matrix：p[2][3] 的符号与量级揭示 reverseZ 与 depth_0_1
float scale = projMatrix[2, 3] / (f * n) * (f - n);
bool depth_0_1 = Mathf.Abs(scale) < 1.5f;
bool reverseZ  = scale > 0;
bool flipProj  = invProjMatrix.MultiplyPoint(new Vector3(0, 1, 0)).y < 0;

// reverseZ 公式 (Humus)：http://www.humus.name/temp/Linearize%20depth.txt
if (reverseZ)
    zBufferParams = new Vector4(-1 + f / n, 1, -1 / f + 1 / n, 1 / f);
else
    zBufferParams = new Vector4(1 - f / n, f / n, 1 / f - 1 / n, 1 / n);

projectionParams = new Vector4(flipProj ? -1 : 1, n, f, 1f / f);
invProjectionParams = new Vector4(
    projMatrix[2,0] / projMatrix[0,0], projMatrix[2,1] / projMatrix[1,1], 1f, projMatrix[2,2]) / projMatrix[2,3];
invProjectionParams = new Vector4(invProjectionParams.x * 2f, invProjectionParams.y * 2f,
                                   invProjectionParams.z,
                                   invProjectionParams.w - invProjectionParams.x - invProjectionParams.y);

float orthoHeight = camera.orthographic ? 2 * camera.orthographicSize : 0;
float orthoWidth  = orthoHeight * camera.aspect;
unity_OrthoParams = new Vector4(orthoWidth, orthoHeight, 0, camera.orthographic ? 1 : 0);
```

HG `UpdateFrustum` 反汇编 (`HGCamera.cs:15280-15346`) 抓取等价指令：
- `g_18C471324 = 1.0f`，多次 `divss xmm0, near` 与 `divss xmm0, far` ⇒ `1/n`、`1/f`；
- `addss / subss / mulss` 组合 ⇒ `-1 + f/n`、`1/f - 1/n` 等四个分量；
- 把结果用 `shufps` 组装成 Vector4 写到 `[rdi+0x778]` (= `zBufferParams` 字段)。

### 7.2 `Frustum.Create`：构造 6 个平面 + 8 个角点

**HG 的 Frustum 是独立类**（`Frustum.cs`，与 HDRP `HDCamera.frustum` 字段类型一致）：

```csharp
// Frustum.cs:7
[BurstCompile]
public struct Frustum
{
    public Plane[]   planes;     // 长度 6：left, right, top, bottom, near, far
    public Vector3[] corners;    // 长度 8：near tl/tr/bl/br + far tl/tr/bl/br
}
```

`HDCamera.cs:2168-2170` 调用 (HG 同站点 `HGCamera.cs:15489`)：

```csharp
Vector3 viewDir = -viewConstants.invViewMatrix.GetColumn(2);
viewDir.Normalize();
Frustum.Create(ref frustum, viewProjMatrix,
               viewConstants.invViewMatrix.GetColumn(3),   // = camera world pos
               viewDir, n, f);

// 把 plane 拷到 frustumPlaneEquations（Vector4 形式给 shader）
for (int i = 0; i < 6; i++)
    frustumPlaneEquations[i] = new Vector4(frustum.planes[i].normal.x,
                                           frustum.planes[i].normal.y,
                                           frustum.planes[i].normal.z,
                                           frustum.planes[i].distance);
```

**Frustum.Create 的核心数学**（Frustum.cs:185-696 反汇编序列；这是工业标准做法）：

1. **平面提取自 VP 矩阵**（Gribb & Hartmann 法）。`viewProjMatrix` 的 4 行记 \(r_0, r_1, r_2, r_3\)：

\[
\begin{aligned}
\text{left}   &= r_3 + r_0 \\
\text{right}  &= r_3 - r_0 \\
\text{bottom} &= r_3 + r_1 \\
\text{top}    &= r_3 - r_1 \\
\text{near}   &= r_3 + r_2 \quad (\text{若 depth\_0\_1: } r_2) \\
\text{far}    &= r_3 - r_2
\end{aligned}
\]

每个平面 4 分量记成 \((a, b, c, d)\) 即 `Plane(normal=(a,b,c), distance=d/|n|)`，要做归一化 `1 / |(a,b,c)|`。

2. **8 角点 = 三平面交点**（`Frustum.cs:13-183 IntersectFrustumPlanes` 私有函数）。给定平面 \(P_0, P_1, P_2\) 法向 \(\mathbf{n}_0, \mathbf{n}_1, \mathbf{n}_2\) 距离 \(d_0, d_1, d_2\)，交点：

\[
\mathbf{p} = \frac{
   -d_0 (\mathbf{n}_1 \times \mathbf{n}_2)
   - d_1 (\mathbf{n}_2 \times \mathbf{n}_0)
   - d_2 (\mathbf{n}_0 \times \mathbf{n}_1)
}{\mathbf{n}_0 \cdot (\mathbf{n}_1 \times \mathbf{n}_2)}
\]

反汇编 `Frustum.cs:55-150` 序列 7 次 `Cross / Dot / op_Multiply / op_Addition / op_Subtraction` 调用，对应这个分子分母拆解。HG 用 Burst `BurstCompile` 编译，向量运算融合为 SIMD。

3. 8 个角点：`near-TL = (near, top, left)`、`near-TR = (near, top, right)` 等 8 个三平面组合。反汇编 `Frustum.cs:382-625` 8 个连续 `Frustum::IntersectFrustumPlanes` 调用，分别取：

| 角点 | 三平面 |
|---|---|
| `corners[0]` | left, bottom, near |
| `corners[1]` | right, bottom, near |
| `corners[2]` | left, top, near |
| `corners[3]` | right, top, near |
| `corners[4]` | left, bottom, far |
| `corners[5]` | right, bottom, far |
| `corners[6]` | left, top, far |
| `corners[7]` | right, top, far |

（具体顺序由 `Frustum.Create` 反汇编 `cmp dword ptr [rax+18h]` 的 boundscheck 序号决定；HDRP `Frustum.cs` 同一顺序。）

---

## 8. `ComputePixelCoordToWorldSpaceViewDirectionMatrix`：天空与 SkyView LUT 用

**HDRP 真实算法 `HDCamera.cs:2363-2407`**：

```csharp
internal Matrix4x4 ComputePixelCoordToWorldSpaceViewDirectionMatrix(
    ViewConstants vc, Vector4 resolution, float aspect = -1,
    int cameraRelativeRendering = 1)
{
    bool useGenericMatrix = xr.enabled || frameSettings.IsEnabled(AsymmetricProjection)
        || (HDUtils.IsProjectionMatrixAsymmetric(vc.projMatrix) && !camera.usePhysicalProperties);

    if (useGenericMatrix)
    {
        // 通用通路：M = viewSpaceRasterTransform · transpose(invViewProj) · Scale(-1,-1,-1)
        //  viewSpaceRasterTransform = | 2/w   0    0  -1 |
        //                             |  0  -2/h  0   1 |
        //                             |  0   0    1   0 |
        //                             |  0   0    0   1 |
        var viewSpaceRasterTransform = new Matrix4x4(
            new Vector4(2.0f * resolution.z, 0,            0,           -1),
            new Vector4(0,            -2.0f * resolution.w, 0,            1),
            new Vector4(0, 0, 1, 0),
            new Vector4(0, 0, 0, 1));

        Matrix4x4 transformT;
        if (cameraRelativeRendering == 0)
        {
            var viewNoTrans = vc.viewMatrix;
            viewNoTrans.SetColumn(3, new Vector4(0, 0, 0, 1));
            var invViewProj = (vc.projMatrix * viewNoTrans).inverse;
            transformT = invViewProj.transpose * Matrix4x4.Scale(new Vector3(-1, -1, -1));
        }
        else
        {
            transformT = vc.invViewProjMatrix.transpose * Matrix4x4.Scale(new Vector3(-1, -1, -1));
        }
        return viewSpaceRasterTransform * transformT;
    }

    // 物理相机/对称投影优化通路：用 vertFov + lensShift 重建
    float verticalFoV = camera.GetGateFittedFieldOfView() * Mathf.Deg2Rad;
    if (!camera.usePhysicalProperties)
        verticalFoV = Mathf.Atan(-1.0f / vc.projMatrix[1, 1]) * 2;
    Vector2 lensShift = camera.GetGateFittedLensShift();
    return HDUtils.ComputePixelCoordToWorldSpaceViewDirectionMatrix(
        verticalFoV, lensShift, resolution, vc.viewMatrix, false, aspect, camera.orthographic);
}
```

**为什么这个矩阵**：fragment shader 里输入 `(pixelX, pixelY)`，要得到一条从相机出发指向像素中心的**世界空间视方向**，用于：
- 天空 fragment shader：`color = SampleSky(dir)`；
- SkyView LUT：在球面坐标采样大气散射 LUT；
- Volumetric Cloud SDF march 的起点方向；
- HG `pixelCoordToViewDirWS` 字段就是这个矩阵的 GPU 表达，shader 端 `dir = mul(pixelCoordToViewDirWS, float4(pixelXY, 1, 1))`。

数学上：`viewSpaceRasterTransform` 把像素坐标 `(x, y)` 映射到 NDC `(2x/w - 1, -(2y/h - 1))`（OpenGL Y 朝下，故 `-2/h`）；`invViewProj.transpose` 把 NDC 转回**视方向**（因为方向只在乎旋转分量，转置就是法向变换的逆变换）；`Scale(-1,-1,-1)` 修正 GPU 投影 reverse-Z + Y flip 的 handedness。最后乘起来得到 `(pixelX, pixelY) → world-space dir`。

**HG 反编译 (`HGCamera.cs:16299-16654`) 完全走通用通路**（HG 没有看出走 optimized 分支的迹象，可能直接 `useGenericMatrix=true`）：

- 构造 `viewSpaceRasterTransform` 用 `set_Item(0, 2*resolution.z)`、`set_Item(5, -2*resolution.w)` 等显式调用；
- `Scale(-1,-1,-1)` 通过 `Matrix4x4` 构造完成；
- 末尾 `g_18FC421E8 = Matrix4x4 op_Multiply` 把三个矩阵乘起来返回。

---

## 9. history RT 系统 (`BufferedRTHandleSystem`) 与 `CleanUnused`

### 9.1 双缓冲

```csharp
// HGCamera.cs:272, 382
internal const int PINGPONG_COUNT = 2;
private BufferedRTHandleSystem m_HistoryRTSystem;
```

`BufferedRTHandleSystem` 是 Unity SRP Core 的标准类型 (Runtime/Common/BufferedRTHandleSystem.cs)。每个 history-id 注册一个分配器后，按 frame index 交替写入两张 RT (`PINGPONG_COUNT=2`)；shader 写当前 RT (`GetCurrentFrameRT(id)` = `GetFrameRT(id, 0)`)，从上一帧 RT 采样 (`GetPreviousFrameRT(id)` = `GetFrameRT(id, 1)`)。

HG 注册的 history-id 在反编译里可见的至少有：
- `colorPyramidHistoryMipCount` 关联的 ColorBufferMipChain（SSR、refraction 用）；
- `volumetricIntegratedLightScatteringTexture` / `historyVolumetricLightScatteringTexture`（体积雾 temporal reproject）；
- TAA history、GTAO history、SSR history 等通过 `HistoryEffectSlot` enum 索引（`HGCamera.cs:96-103`）：
  - `GlobalIllumination0 = 0`
  - `GlobalIllumination1 = 1`
  - `RayTracedReflections = 2`
  - `VolumetricClouds = 3`
  - `Count = 4`

HDRP 同 enum (`HDCamera.cs:379-387`) 多一项 `RayTracedAmbientOcclusion = 4`。HG 删了 RayTracedAO（移动端不开光追 AO）。

### 9.2 `CleanUnused` 与 `s_Cleanup` 两阶段清理

```csharp
// HGCamera.cs:11523 签名 + 反汇编序列重建
internal static void CleanUnused(HGRenderGraph rg,
                                 CustomDepthOnlyRequestManager mgr, long mgrCPP)
{
    // 阶段 1：扫描 s_Cameras，把 disabled / null 的 key 收集到 s_Cleanup
    foreach (var (key, cam) in s_Cameras)
    {
        if (cam.camera != null && cam.camera.cameraType == CameraType.SceneView)
            continue;                                                // SceneView 永不回收
        bool hasPersistentHistory = cam.m_AdditionalCameraData?.hasPersistentHistory ?? false;
        if (cam.camera == null ||
            (!cam.camera.isActiveAndEnabled
             && cam.camera.cameraType != CameraType.Preview
             && cam.camera.cameraType != CameraType.Game
             && !hasPersistentHistory && !cam.isPersistent))
        {
            s_Cleanup.Add(key);
        }
    }

    // 阶段 2：迭代 s_Cleanup，调 Dispose 并从字典移除（不能在阶段 1 同时改字典）
    foreach (var key in s_Cleanup)
    {
        s_Cameras[key].Dispose(rg, mgr, mgrCPP);
        s_Cameras.Remove(key);
    }
    s_Cleanup.Clear();
}
```

HDRP 同算法 (`HDCamera.cs:1496-1521`)：

```csharp
internal static void CleanUnused()
{
    foreach (var key in s_Cameras.Keys)
    {
        var camera = s_Cameras[key];
        if (camera.camera != null && camera.camera.cameraType == CameraType.SceneView)
            continue;
        bool hasPersistentHistory = camera.m_AdditionalCameraData != null
            && camera.m_AdditionalCameraData.hasPersistentHistory;
        if (camera.camera == null || (!camera.camera.isActiveAndEnabled
            && camera.camera.cameraType != CameraType.Preview
            && camera.camera.cameraType != CameraType.Game
            && !hasPersistentHistory && !camera.isPersistent))
            s_Cleanup.Add(key);
    }
    foreach (var cam in s_Cleanup)
    {
        s_Cameras[cam].Dispose();
        s_Cameras.Remove(cam);
    }
    s_Cleanup.Clear();
}
```

**1:1 同算法**，HG 只是把 `Dispose` 多带了三个参数（`HGRenderGraph` + `CustomDepthOnlyRequestManager` + 它的 CPP 句柄），对应 HG 自有的 CPP RenderPath 资源回收。

`ClearAll` (`HGCamera.cs:11417`) 同 HDRP `HDCamera.cs:1483-1493`：清空所有 HGCamera 包括 SceneView。

---

## 10. 物理相机：`HGPhysicalCamera.GetDefaults` 与 HDRP 数值 1:1

### 10.1 字段与约束

```csharp
// HGPhysicalCamera.cs:7-46
[Serializable]
public struct HGPhysicalCamera
{
    public const float kMinAperture   = 0.7f;
    public const float kMaxAperture   = 32f;
    public const int   kMinBladeCount = 3;
    public const int   kMaxBladeCount = 11;

    [SerializeField, Min(1f)]            private int     m_Iso;
    [SerializeField, Min(0f)]            private float   m_ShutterSpeed;
    [SerializeField, Range(0.7f, 32f)]   private float   m_Aperture;
    [SerializeField, Min(0.1f)]          private float   m_FocusDistance;
    [SerializeField, Range(3f, 11f)]     private int     m_BladeCount;
    [SerializeField]                     private Vector2 m_Curvature;
    [SerializeField, Range(0f, 1f)]      private float   m_BarrelClipping;
    [SerializeField, Range(-1f, 1f)]     private float   m_Anamorphism;
}
```

HDRP `HDPhysicalCamera` (`HDAdditionalCameraData.cs:12-46`) **字段与约束完全相同**。

### 10.2 `GetDefaults`（默认值数学验证）

HG 反汇编 `HGPhysicalCamera.cs:296-336`：

```asm
; mov dword ptr [rsp+20h], 0C8h                ; iso = 200
; mov dword ptr [rsp+24h], sub_3BA3D70A       ; shutterSpeed = 0.005 (1/200)
; mov dword ptr [rsp+28h], sub_41800000       ; aperture = 16
; mov dword ptr [rsp+2Ch], sub_41200000       ; focusDistance = 10
; mov dword ptr [rsp+30h], 5                  ; bladeCount = 5
; call set_curvature  (传 (2.0f, 11.0f) — 反汇编里两个 movss 装入 xmm)
; movss xmm0, dword ptr [g_18C47163C]         ; 0.25f
; call set_barrelClipping
; ...; anamorphism = 0
```

数值 1:1 复刻 HDRP `HDAdditionalCameraData.cs:139-151`：

```csharp
public static HDPhysicalCamera GetDefaults()
{
    HDPhysicalCamera val = new HDPhysicalCamera();
    val.iso            = 200;
    val.shutterSpeed   = 1f / 200f;     // = 0.005
    val.aperture       = 16;
    val.focusDistance  = 10;
    val.bladeCount     = 5;
    val.curvature      = new Vector2(2f, 11f);
    val.barrelClipping = 0.25f;
    val.anamorphism    = 0;
    return val;
}
```

| 字段 | 默认值 | 立即数验证 |
|---|---|---|
| `iso` | 200 | `0xC8 = 200` |
| `shutterSpeed` | `1/200 = 0.005` | `0x3BA3D70A` ≈ 0.005f (IEEE-754 verify: `0x3BA3D70A = 0.00499999988`) |
| `aperture` | 16 | `0x41800000 = 16.0f` |
| `focusDistance` | 10 | `0x41200000 = 10.0f` |
| `bladeCount` | 5 | 字面 `5` |
| `curvature` | `(2, 11)` | 反汇编 `set_curvature` 入参 |
| `barrelClipping` | 0.25 | `g_18C47163C = 0.25f` |
| `anamorphism` | 0 | xorps |

### 10.3 物理参数怎么进管线

`UpdateVolumeAndPhysicalParameters` (`HGCamera.cs:15676`)：

```csharp
private void UpdateVolumeAndPhysicalParameters()
{
    // 1. 决定 volumeLayerMask / volumeAnchor
    volumeAnchor    = additionalCameraData?.volumeAnchorOverride;
    volumeLayerMask = additionalCameraData?.volumeLayerMask ?? -1;
    if (volumeAnchor == null) volumeAnchor = camera.transform;

    // 2. 用 volumeStack 解算 21 个 VolumeComponent，结果缓存到 m_volumeComponentsData
    VolumeManager.instance.Update(volumeStack, volumeAnchor, volumeLayerMask);
    InitializeVolumeComponentsData();

    // 3. 把 physicalParameters（ISO/快门/光圈）打包成曝光 baseEV，传给 Auto Exposure
    //    EV = log2( (aperture² / shutterSpeed) * (100 / iso) )      // 标准摄影 EV 公式
    //         + Volume 的 exposureCompensation
    //    （具体送往 Exposure.compute / AutoExposure 的常量名见 16-PostProcess.md）
}
```

HDRP 等价 `HDCamera.cs:2192-2258`：选 volumeAnchor + LayerMask、调用 `VolumeManager.Update`、对 `Exposure` Volume Component 设置 `LightMeterCalibrationConstant`（依 `TargetMidGray` 三档：12.5 / 14.0 / 18.0）。

**EV 公式（标准摄影学）**：

\[
\mathrm{EV} = \log_2 \left( \frac{N^2}{t} \cdot \frac{S}{100} \right)
\]

其中 \(N\) = `aperture` (f-stop)、\(t\) = `shutterSpeed`、\(S\) = `iso`。默认值 (16, 1/200, 200) → \(\mathrm{EV} = \log_2(16^2 / 0.005 \cdot 200/100) = \log_2(102400) \approx 16.64\)，对应明亮日光。`HGPhysicalCamera.GetDefaults` 选这一组就是 HDRP 默认的 "Sunny 16 rule" 经典曝光预设。

### 10.4 DOF / Bokeh 使用 `m_BladeCount` / `m_Curvature` / `m_BarrelClipping` / `m_Anamorphism`

后处理 Bokeh DOF (C16-PostProcess) 渲染光圈形状时：
- `bladeCount = 5` → 5 边形 bokeh；
- `curvature = (2, 11)` → 光圈在 f/2 时是圆 (curvature ≥ aperture)，在 f/11 时是 5 边形（curvature 区段端点）；
- `barrelClipping = 0.25` → 25% 桶形遮挡（边缘 bokeh 椭圆变形）；
- `anamorphism = 0` → 无变形拉伸（>0 垂直变形，<0 水平变形）。

数值与 HDRP 完全一致，DOF compute shader 也是 HDRP 同源 (`com.unity.render-pipelines.high-definition@75de48326bcd/Runtime/PostProcessing/Shaders/DepthOfField*.compute`)。

---

## 11. `CameraSettings` 反向通路：Custom Pass / Reflection Probe 重渲

### 11.1 用途

`CameraSettings` 是把**一组结构化设置**打包写回 Unity Camera + `HGAdditionalCameraData`（反向 of `Update`）。典型用途：

- Custom Pass（如水反、planar reflection）借相机重新渲染场景，需要临时改 FOV / cullingMask / projection；
- Reflection Probe 烘焙时构造一个临时相机；
- 编辑器预览。

### 11.2 结构

```csharp
// CameraSettings.cs:8
[Serializable]
public struct CameraSettings
{
    public bool customRenderingSettings;
    public FrameSettings renderingPathCustomFrameSettings;
    public FrameSettingsOverrideMask renderingPathCustomFrameSettingsOverrideMask;
    public BufferClearing bufferClearing;                                 // 子结构：ClearMode + HDR 色 + clearDepth
    public Volumes volumes;                                                // 子结构：layerMask + anchorOverride
    public Frustum frustum;                                                // 子结构：mode + aspect + near/far + fov + matrix
    public Culling culling;                                                // 子结构：useOcclusion + mask + sceneCullingMask
    public bool invertFaceCulling;
    public HGAdditionalCameraData.FlipYMode flipYMode;
    public LayerMask probeLayerMask;
    public FrameSettingsRenderType defaultFrameSettings;
    internal float probeRangeCompressionFactor;
}
```

5 个嵌套子结构都提供 `NewDefault()` 工厂。`Frustum` 子结构提供两种模式：

```csharp
// CameraSettings.cs:130
public enum Mode
{
    ComputeProjectionMatrix    = 0,    // 用 (fov, aspect, near, far) 算
    UseProjectionMatrixField   = 1,    // 直接用提供的 4x4 矩阵
}
public Matrix4x4 ComputeProjectionMatrix()
{
    float fovClamped = HGUtils.ClampFOV(fieldOfView);
    float near = Mathf.Max(g_18C471290 /*1e-5*/, nearClipPlaneRaw);
    float far  = Mathf.Max(nearClipPlaneRaw + g_18C471300 /*1e-4*/, farClipPlaneRaw);
    return Matrix4x4.Perspective(fovClamped, aspect, near, far);
}
public Matrix4x4 GetUsedProjectionMatrix()
    => mode == Mode.ComputeProjectionMatrix ? ComputeProjectionMatrix() : projectionMatrix;
```

常量 `MinNearClipPlane = 1e-5f`、`MinFarClipPlane = 1e-4f`（`CameraSettings.cs:139-141`）作为 clamp 下限。

### 11.3 应用流：`CameraSettingsUtilities.ApplySettings`

```csharp
// CameraSettingsUtilities.cs:9 反汇编重建
public static void ApplySettings(this Camera cam, in CameraSettings s)
{
    // 1. 取 HGAdditionalCameraData，没有就 AddComponent
    var hgData = cam.GetComponent<HGAdditionalCameraData>()
              ?? cam.gameObject.AddComponent<HGAdditionalCameraData>();

    // 2. 拷 customRenderingSettings + FrameSettings + OverrideMask
    hgData.defaultFrameSettings = s.defaultFrameSettings;
    hgData.renderingPathCustomFrameSettings = s.renderingPathCustomFrameSettings;
    hgData.renderingPathCustomFrameSettingsOverrideMask = s.renderingPathCustomFrameSettingsOverrideMask;

    // 3. 写 Unity Camera 的 near/far/fov/aspect（带 clamp）
    cam.nearClipPlane = Mathf.Max(1e-5f, s.frustum.nearClipPlaneRaw);
    cam.farClipPlane  = Mathf.Max(s.frustum.nearClipPlaneRaw + 1e-4f, s.frustum.farClipPlaneRaw);
    cam.fieldOfView   = s.frustum.fieldOfView;
    cam.aspect        = s.frustum.aspect;

    // 4. 写 projectionMatrix（mode=Compute 时 by Matrix4x4.Perspective；mode=Field 时直接用）
    cam.projectionMatrix = s.frustum.GetUsedProjectionMatrix();

    // 5. 写 culling
    cam.useOcclusionCulling      = s.culling.useOcclusionCulling;
    cam.cullingMask              = s.culling.cullingMask;
    cam.overrideSceneCullingMask = s.culling.sceneCullingMaskOverride;

    // 6. 写 hgData 的 clearColorMode / backgroundColorHDR / clearDepth + volumes/probe/flip
    hgData.clearColorMode      = s.bufferClearing.clearColorMode;
    hgData.backgroundColorHDR  = s.bufferClearing.backgroundColorHDR;
    hgData.clearDepth          = s.bufferClearing.clearDepth;
    hgData.volumeLayerMask     = s.volumes.layerMask;
    hgData.volumeAnchorOverride= s.volumes.anchorOverride;
    hgData.invertFaceCulling   = s.invertFaceCulling;
    hgData.probeLayerMask      = s.probeLayerMask;
    hgData.flipYMode           = s.flipYMode;
    hgData.materialMipBias     = s.probeRangeCompressionFactor;    // 反汇编偏移 0xA4
}
```

反汇编 `CameraSettingsUtilities.cs:9-178` 的字段偏移与上面对应：

| C# 字段 | Camera/HGData 偏移 | 反汇编证据 |
|---|---|---|
| `clearColorMode` | `[rdi+0x20]` | `mov eax, [rsi+0x30]; mov [rdi+0x20], eax` |
| `backgroundColorHDR (Color)` | `[rdi+0x24]` | `movdqu xmm0, [rsi+0x34]; movdqu [rdi+0x24], xmm0` |
| `clearDepth` | `[rdi+0x34]` | `mov al, [rsi+0x44]; mov [rdi+0x34], al` |
| `volumeLayerMask` | `[rdi+0x38]` | `mov eax, [rsi+0x48]; mov [rdi+0x38], eax` |
| `volumeAnchorOverride (Transform)` | `[rdi+0x40]` | `mov rax, [rsi+0x50]; mov [rdi+0x40], rax` |
| `invertFaceCulling` | `[rdi+0x82]` | `mov r9b, [rsi+0]; mov [rdi+0x82], r9b` |
| `defaultFrameSettings` | `[rdi+0xD8]` | `mov eax, [rsi+0xCC]; mov [rdi+0xD8], eax` |
| `materialMipBias` | `[rdi+0xA4]` | `movss xmm0, [rsi+0xD0]; movss [rdi+0xA4], xmm0` |

### 11.4 `CameraSettingsOverride` / `CameraSettingsFields`

```csharp
// CameraSettingsFields.cs
[Flags] public enum CameraSettingsFields
{
    none                         = 0,
    bufferClearColorMode         = 0x002,
    bufferClearBackgroundColorHDR= 0x004,
    bufferClearClearDepth        = 0x008,
    volumesLayerMask             = 0x010,
    volumesAnchorOverride        = 0x020,
    frustumMode                  = 0x040,
    frustumAspect                = 0x080,
    frustumFarClipPlane          = 0x100,
    frustumNearClipPlane         = 0x200,
    frustumFieldOfView           = 0x400,
    frustumProjectionMatrix      = 0x800,
    cullingUseOcclusionCulling   = 0x1000,
    cullingCullingMask           = 0x2000,
    cullingInvertFaceCulling     = 0x4000,
    customRenderingSettings      = 0x8000,
    flipYMode                    = 0x10000,
    frameSettings                = 0x20000,
    probeLayerMask               = 0x40000,
}

// CameraSettingsOverride.cs
[Serializable] public struct CameraSettingsOverride
{
    public CameraSettingsFields camera;
}
```

用法：上层（如反射探针配置）声明 `CameraSettingsOverride.camera` 为需要覆盖的位掩码，再用 `CameraSettings.From(hgCamera)` 收集当前完整设置，与默认或目标 settings 做位选合并，再 `cam.ApplySettings(merged)`。

### 11.5 `CameraSettings.From(HGCamera)`

`CameraSettings.cs:607-1343` 反汇编：从一个 `HGCamera` 反向抓取出当前 Camera + HGAdditionalCameraData 的所有状态，构造 `CameraSettings`：

```csharp
public static CameraSettings From(HGCamera hgCamera)
{
    var s = CameraSettings.NewDefault();
    var cam = hgCamera.camera;
    s.frustum.aspect       = cam.aspect;            // 反汇编 g_18FC417C8
    s.frustum.nearClipPlaneRaw = cam.nearClipPlane; // 反汇编 g_18FC41770
    s.frustum.farClipPlaneRaw  = cam.farClipPlane;  // 反汇编 g_18FC41760
    s.frustum.fieldOfView      = cam.fieldOfView;   // 反汇编 g_18FC41780
    s.frustum.mode = Mode.ComputeProjectionMatrix;
    s.frustum.projectionMatrix = Matrix4x4.identity;

    // 反汇编 g_18FC418D8 = Camera.cullingMatrix → 写到 s.frustum.projectionMatrix 当 fallback
    cam.GetCullingMatrix(out s.frustum.projectionMatrix);

    if (cam.TryGetComponent<HGAdditionalCameraData>(out var add))
    {
        s.invertFaceCulling = add.invertFaceCulling;
        s.bufferClearing.backgroundColorHDR = add.backgroundColorHDR;
        s.bufferClearing.clearColorMode     = add.clearColorMode;
        s.bufferClearing.clearDepth         = add.clearDepth;
        s.volumes.layerMask                 = add.volumeLayerMask;
        s.renderingPathCustomFrameSettings  = add.renderingPathCustomFrameSettings;
        s.volumes.anchorOverride            = add.volumeAnchorOverride;
        s.defaultFrameSettings              = add.defaultFrameSettings;
        s.flipYMode                         = add.flipYMode;
        s.probeLayerMask                    = add.probeLayerMask;
    }

    // 检测 projectionMatrix 是否为非平凡（其某分量 != 0 或 != 1）→ 决定 mode
    if (someComponentIsNonTrivial(s.frustum.projectionMatrix))
        s.frustum.mode = Mode.UseProjectionMatrixField;
    return s;
}
```

`CameraSettings.GetHash` (`CameraSettings.cs:1346`) 用 `HashUtilities.ComputeHash128<T>` 对 10 个字段做组合哈希，输出 `Hash128`，用于检测 settings 变更避免重渲。

### 11.6 `CameraPositionSettings`

`CameraPositionSettings.cs` 是 `worldToCameraMatrix` 的同款结构：

```csharp
public enum Mode
{
    ComputeWorldToCameraMatrix = 0,
    UseWorldToCameraMatrixField = 1,
}
public static CameraPositionSettings NewDefault()
    => new() { mode = ComputeWorldToCameraMatrix,
               position = Vector3.zero, rotation = identity,
               worldToCameraMatrix = Matrix4x4.identity };
public Matrix4x4 ComputeWorldToCameraMatrix()
    => HG.Rendering.Runtime.GeometryUtils.CalculateWorldToCameraMatrixRHS(position, rotation);
public Matrix4x4 GetUsedWorldToCameraMatrix()
    => mode == Mode.ComputeWorldToCameraMatrix ? ComputeWorldToCameraMatrix() : worldToCameraMatrix;
```

`GeometryUtils.CalculateWorldToCameraMatrixRHS` 即标准 RH worldToView：把 `transform` 的 `position/rotation` 转成 `view = [R^T | -R^T * t; 0 | 1]`。

---

## 12. 1:1 重建蓝图（分步）

### 12.1 类型框架（半天）

1. 抄 `ViewConstants` (23 矩阵 + 3 Vec3 + 3 pad) 结构体（§3）。**注意字段顺序与 HDRP 不同**，HG 多 10 个矩阵；如果你要兼容 HDRP shader 接口（`ShaderVariablesGlobal` cbuffer），保留 HDRP 顺序在前 13 个，HG 新增的 10 个排末尾。
2. 抄 `HGCamera` 主类骨架：~100 个字段 + `s_Cameras` 字典 + `GetOrCreate / TryGet / Reset / ClearAll / CleanUnused`。
3. 抄 `HGPhysicalCamera` 结构体 + `GetDefaults` (ISO=200, 1/200s, f/16, 10m, 5叶, curvature=(2,11), barrelClipping=0.25, anamorphism=0)（§10）。
4. 抄 `HGAdditionalCameraData` MonoBehaviour + 嵌套枚举 + `customRender` / `requestGraphicsBuffer` 事件。
5. 抄 `CameraSettings` + 5 子结构 + `NewDefault` + `From(HGCamera)` + `CameraSettingsUtilities.ApplySettings`（§11）。
6. 抄 `Frustum` (Plane[6] + Vector3[8]) + `Frustum.Create / IntersectFrustumPlanes`（§7.2）。

### 12.2 矩阵推导（一天）

1. 实现 `GetJitteredProjectionMatrix`：
   - `if (FrameDebugger.enabled) { taaJitter=0; return origProj; }`
   - `jitterX = HaltonSequence.Get((taaFrameIndex & 0x3FF) + 1, 2) - 0.5f`；`jitterY = HaltonSequence.Get((taaFrameIndex & 0x3FF) + 1, 3) - 0.5f`；
   - 若非 DLSS/FSR/TAAU/SceneView，乘 `taaJitterScale`；
   - `taaJitter = (jitterX, jitterY, jitterX/actualWidth * (HG: 1/renderingScale), jitterY/actualHeight * (HG: 1/renderingScale))`；
   - perspective: `planes = origProj.decomposeProjection`；`planes.left/right += jitterX*horizFov/actualWidth`、`top/bottom += jitterY*vertFov/actualHeight`；`return Matrix4x4.Frustum(planes)`。
2. 实现 `UpdateViewConstants`：照 §6.2 7 步逐字复刻。
3. 实现 `ComputePixelCoordToWorldSpaceViewDirectionMatrix`：照 §8 通用通路。
4. 实现 `UpdateFrustum`：照 §7.1 算 `zBufferParams / projectionParams / unity_OrthoParams`；调 `Frustum.Create`；拷 6 个 plane 到 `frustumPlaneEquations[6]`。
5. 实现 `IsLargeCameraMovement` (§4.4)：取 view 矩阵的三个基向量 dot；取 worldPos 平方距离；任一过阈 → true。

### 12.3 生命周期（半天）

1. `Update(frameSettings, hgrp, allocateHistoryBuffers=true)` 按 §4.1 7 步：InitializeRenderPath → UpdateHGCameraPixelRect → UpdateVolumeAndPhysicalParameters → UpdateAntialiasing → 推进 `taaFrameIndex` → `UpdateAllViewConstants(hgrp)` → `m_HistoryRTSystem.SwapAndSetReferenceSize`。
2. `Reset()`：`isFirstFrame=true; cameraFrameCount=0; taaFrameIndex=0; resetPostProcessingHistory=true; prevTransformReset=true;` + 通知 `visualSky.Reset() / lightingSky.Reset()`（如果存在）。
3. `BeginRender(cmd)`：`SetReferenceSize → CameraCaptureBridge.GetCaptureActions → SetupCurrentMaterialQuality → SetupExposureTextures`。
4. `CleanUnused`：两阶段（§9.2），SceneView 永不回收，Game/Preview/`hasPersistentHistory`/`isPersistent` 也不回收。

### 12.4 history RT（半天）

1. `BufferedRTHandleSystem` 实例化 with `PINGPONG_COUNT = 2`。
2. 各 history 用 `AllocHistoryFrameRT(id, allocator, bufferCount)` 注册；具体 id 枚举见 `HistoryEffectSlot` + HDRP `HDCameraFrameHistoryType`。
3. `GetPreviousFrameRT(id) = GetFrameRT(id, 1)`、`GetCurrentFrameRT(id) = GetFrameRT(id, 0)`。

### 12.5 与其他单元的接口

- **C16 PostProcess**：消费 `mainViewConstants.projMatrix / invViewProjMatrix / prevViewProjMatrix`；TAA / Motion Blur / DOF 用 `taaJitter / taaFrameIndex / physicalParameters`；history RT 由 `BufferedRTHandleSystem` 提供。
- **C07 ShadowASM**：用 `widerFoVViewProjMatrix` / `widerFoVInvViewProjMatrix` 做 CSM 边缘 sample；`cullingMatrix` 是 CSM 计算的视锥来源。
- **C05 Volumetric**：用 `mainViewConstants.pixelCoordToViewDirWS` 做 SkyView/SDF march 起点；`volumetricIntegratedLightScatteringTexture` 是 froxel 输出。
- **C06 EnvironmentSky**：`atmosphereSkyViewLutTexture / atmosphereLutConstants` 是大气 LUT 的本相机缓存；`m_envVolumeCameraComponent` 是 per-camera Environment Volume 解算。
- **C09 GI / SSR**：用 `prevViewProjMatrix / prevInvViewProjMatrix` 做 reprojection。
- **C04 GraphicsCPPModule §6.5**：`mainViewConstants` 整体上传成 `HGViewConstantsCPP` cbuffer；C++ 侧从 unmanaged 指针读 23 个矩阵。

---

## 13. 关键常量 / 魔数 / 反编译证据

| 常量 | 值 | 反编译证据 | HDRP 同源 |
|---|---|---|---|
| `kTaaSequenceLength`（隐式） | 1024 | `HGCamera.cs:16089 and eax, 0x3FF` | `HDCamera.cs:476` 显式 const |
| Halton index 偏移 | `+1`（避退化样本 0） | `HGCamera.cs:16093 inc eax` | `HDCamera.cs:2290 (taaFrameIndex+1, 2)` |
| Halton jitter 居中 | `-0.5` | `HGCamera.cs:16104 subss xmm6, [g_18C471320]` (= 0.5f) | `HDCamera.cs:2290-2291 - 0.5f` |
| `MinNearClipPlane` | `1e-5f` | `CameraSettings.cs:139` 字面常量 + `g_18C471290` | Unity 标准 |
| `MinFarClipPlane` | `1e-4f` | `CameraSettings.cs:141` 字面常量 + `g_18C471300` | Unity 标准 |
| `kMinAperture` | 0.7 | `HGPhysicalCamera.cs:9` 字面 | `HDAdditionalCameraData.cs:17` 字面 |
| `kMaxAperture` | 32 | `HGPhysicalCamera.cs:11` 字面 | `HDAdditionalCameraData.cs:22` 字面 |
| `kMinBladeCount` | 3 | `HGPhysicalCamera.cs:13` 字面 | `HDAdditionalCameraData.cs:27` 字面 |
| `kMaxBladeCount` | 11 | `HGPhysicalCamera.cs:15` 字面 | `HDAdditionalCameraData.cs:32` 字面 |
| `PhysicalCamera` 默认 ISO | 200 | `HGPhysicalCamera.cs:309 0xC8` | `HDAdditionalCameraData.cs:142 val.iso=200` |
| `PhysicalCamera` 默认 shutterSpeed | 1/200 = 0.005 | `HGPhysicalCamera.cs:310 0x3BA3D70A` | `HDAdditionalCameraData.cs:143 1f/200f` |
| `PhysicalCamera` 默认 aperture | 16 | `HGPhysicalCamera.cs:311 0x41800000` | `HDAdditionalCameraData.cs:144 16` |
| `PhysicalCamera` 默认 focusDistance | 10 | `HGPhysicalCamera.cs:312 0x41200000` | `HDAdditionalCameraData.cs:145 10` |
| `PhysicalCamera` 默认 bladeCount | 5 | `HGPhysicalCamera.cs:319 mov ...,5` | `HDAdditionalCameraData.cs:146 5` |
| `PhysicalCamera` 默认 curvature | `(2, 11)` | `HGPhysicalCamera.cs:316-320 set_curvature` | `HDAdditionalCameraData.cs:147 Vector2(2f, 11f)` |
| `PhysicalCamera` 默认 barrelClipping | 0.25 | `HGPhysicalCamera.cs:321 g_18C47163C` | `HDAdditionalCameraData.cs:148 0.25f` |
| `PhysicalCamera` 默认 anamorphism | 0 | `HGPhysicalCamera.cs:322-327 xorps xmm3` | `HDAdditionalCameraData.cs:149 0` |
| `HGCamera.PINGPONG_COUNT` | 2 | `HGCamera.cs:272 const int` | `BufferedRTHandleSystem` 双缓冲 |
| Halton 0.5 常量 | 0.5f | `g_18C471320` | HDRP `1f/radix=2` 初值 |
| Halton 3.0 常量 | 3.0f | `g_18C47132C` | HDRP `radix=3` |
| Halton fraction(1/3) 乘法逆元 | `0x55555556` | `HGCamera.cs:16114 imul` | Hacker's Delight 标准 (用乘法替换 idiv 3) |

---

## 14. 源文件清单（9 个）

| # | 文件 | 行数 | 一句话职责 |
|---|---|---|---|
| 1 | `HGCamera.cs` | 17671 | 运行时相机主类：23 矩阵 ViewConstants + history RT + culling 句柄 + TAA 抖动 + 物理参数承载 + 22 个公开/private 方法 (§2-9) |
| 2 | `HGAdditionalCameraData.cs` | 1155 | 编辑器侧 MonoBehaviour：clearMode / antialiasing / physicalParameters / FrameSettings / customRender 事件 (§11) |
| 3 | `HGPhysicalCamera.cs` | 339 | 物理相机 struct：ISO/快门/光圈/焦距/光圈叶片/曲率/桶形/变形 + `GetDefaults` (§10) |
| 4 | `CameraSettings.cs` | 1518 | 一次性结构化设置：BufferClearing / Volumes / Frustum / Culling 子结构 + `NewDefault` + `From(HGCamera)` + `GetHash` (§11) |
| 5 | `CameraSettingsFields.cs` | 28 | `[Flags] CameraSettingsFields` 19 位枚举：覆盖掩码 (§11.4) |
| 6 | `CameraSettingsOverride.cs` | 10 | 极简包装 `struct { CameraSettingsFields camera; }`，让 Override 字段化 (§11.4) |
| 7 | `CameraSettingsUtilities.cs` | 352 | `Camera.ApplySettings(in CameraSettings)` 扩展方法：把 CameraSettings 写回 Camera + HGAdditionalCameraData (§11.3) |
| 8 | `CameraPositionSettings.cs` | 245 | worldToCameraMatrix 描述：mode + (position, rotation) + matrix 字段 + Compute / GetUsed (§11.6) |
| 9 | `Frustum.cs` | 699 | `[BurstCompile] struct Frustum`：Plane[6] + Vector3[8] + 静态 `Create / IntersectFrustumPlanes` (§7.2) |

---

> **致同行复刻者**：本单元的所有数学没有任何 HG 特化的"魔法"——核心矩阵推导是 HDRP `HDCamera.cs` 三十年来稳定的工业做法，Halton(2,3) 是 HDRP `HaltonSequence.cs` 1:1 复刻，物理相机默认值与 HDRP 数值完全一致。**HG 唯一的"创新"是把若干 HDRP 在 .compute 里临时计算的矩阵显式存到 `ViewConstants` 字段里（`viewNoTrans*`、`widerFoV*`、`reprojectionMatrix`），节约 GPU ALU 但代价是多吃 640 B (10 个矩阵) 每相机 cbuffer 带宽**。除此之外，1:1 照 HDRP `HDCamera` 就能复现。
