# HG Render Pipeline — Volumetric (体积雾 / 体积云 / 局部雾) 技术实现原理蓝图

> 本文是 **从零重建** 终末地 (EndField) HG.RenderPipelines 体积渲染子系统的实现蓝图。
> 体积雾、体积云、局部雾三个子系统的核心算法都是 **HDRP fork 血缘**：故 froxel/VBuffer/log‑Z/温度重投影/SDF march/Frostbite 分析式积分 等算法**直接据 HDRP 真实源**(`com.unity.render-pipelines.high-definition@75de48326bcd`) 讲清；HG 反编译 C# 仅用来定位 **HG 的 delta**：5‑Stage `VolumetricRenderer` 拓扑、远云 (Panoramic / Octahedron / Semicircular) 分帧重投影、`VolumetricMSBake` / `VolumetricSHBake` 预烘焙、`SPMDCullingNativeInout` Burst SoA 局部雾剔除、HG 特化的常量取值与移动端裁剪。
>
> 配套已有文档（不复述、只链）：
> - 算法概览：[`../02-CoreAlgorithms/01-CoreAlgorithms.md`](../02-CoreAlgorithms/01-CoreAlgorithms.md) §10 / §11
> - C++ Config blittable 结构：[`../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md`](../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md) §4.5–§4.8
> - 大气散射 (与雾的边界接口)：[`./06-EnvironmentSky.md`](./06-EnvironmentSky.md)
> - 阴影 (体积消光用到的方向光阴影输入)：[`./07-ShadowASM.md`](./07-ShadowASM.md)

---

## 0. 目录

| § | 主题 |
|---|------|
| 1 | 解决什么渲染问题 / 视觉目标 |
| 2 | 三子系统拓扑 + 与 HDRP 血缘对照 |
| 3 | 体积雾：Froxel + VBuffer + log‑Z 散射积分 (HDRP 同源算法 + HG delta) |
| 4 | 体积云：Frostbite 风格 SDF march + 5‑Stage 流水线 + 远云分帧 |
| 5 | 局部雾：SPMD Burst SoA 6 平面剔除 → MRT voxelization |
| 6 | 风场 / 局部光 / SDF Modifier：ComputeBuffer/CBHandle 上传通道 |
| 7 | 预烘焙：MS LUT 多次散射 + SH 球面散射近似 |
| 8 | RT 生命周期与 ping‑pong (FramingColor / Reconstruct / TAA / Compose) |
| 9 | 假面片雾 `FakeFogSimple`：纯 Mesh Renderer 通路 |
| 10 | 1:1 重建蓝图 (按子系统分步) |
| 11 | 源文件清单 (46 个，每个一行职责) |
| 12 | 关键常量 / 魔数总表 |

---

## 1. 解决什么渲染问题 / 视觉目标

**这是开放世界 + 风格化场景需要的三类体积视觉效果，一套流水线下放：**

| 视觉效果 | 实现路径 | 关键质感 |
|---------|---------|---------|
| 远距大气雾 + 高度雾 (空气消光 + 太阳散射) | `HGFogConfig` / `HGHeightFogConfig` + Atmosphere LUT | 距离衰减、双高度拐点、Mie/Rayleigh 各向异性 |
| 视锥内 3D 体积雾 + God Ray (光柱/丁达尔) | `HGVolumetricFogConfig` + Froxel VBuffer + 方向光阴影采样 | 受阴影遮挡的高频光柱、流动噪声扰动密度 |
| 体积云 / 远景层云 | `VolumetricCloudSDF` + SDF march + Far Cloud 全景/八面体/半圆柱烘焙 | 蓬松云朵、自阴影、God Ray、多次散射近似 |
| 局部雾（房间/洞穴/特殊地形雾） | `HGVolumetricLocalFog` + MeshRenderer → froxel MRT 注入 | 形状可控、可被场景遮挡 |
| 区域定向风场 (云朵分层运动) | `VolumetricWindField` + `VolumetricWindFieldNode` (三层) | Directional/Circular/Vortex 三种本地风扰 |
| 假体积感（远景便宜雾片） | `FakeFogSimple` MeshRenderer + 自定 shader | 单 Quad/面片伪体积，不进 froxel |

体积渲染的核心物理量是 **介质参与方程 (RTE)**：

```
L(x → ω) = ∫₀ᵈ  T(0, t) · [σₛ(x_t) · ∫_Ω L_i(x_t, ω') · p(ω, ω') dω' + σₐ(x_t) · L_e(x_t)] dt
         + T(0, d) · L_bg(ω)
```

其中 `T(a,b) = exp(-∫ₐᵇ σₜ(x_s) ds)` 是透射率，`σₜ = σₛ + σₐ` 消光，`σₛ`/`σₐ` 散射/吸收，`p(·,·)` 相函数（云用 Henyey-Greenstein，雾用 Cornette-Shanks 或 isotropic）。
体积雾 & 体积云的差别在于：

- **雾** 充满视锥，每 froxel 介质均匀 → 离散为 `gridSizeZ` 个切片做欧拉积分 (= Froxel)。
- **云** 集中在有限 SDF 包围盒，沿视线 ray-march 步进 N 步做 Frostbite 分析积分（详 §4.3）。

---

## 2. 三子系统拓扑 + 与 HDRP 血缘对照

```
                      HGEnvironmentManager (C06)
                         s_interpolatedPhase
                         ┌─────────┬────────┬─────────┐
                         │         │        │         │
                         ▼         ▼        ▼         ▼
                    HGFogConfig  HGHeight  HGVol    HGVol  HGCloud
                    (大气雾)     FogConfig FogConfig CloudCfg Config
                                                   ╲       ╱
                       ┌───────────────────────────╳───────┘
                       ▼                           ▼
            ┌────────────────────┐     ┌───────────────────────┐
            │ HGVolumetricFog    │     │ VolumetricRenderer    │
            │ Renderer  (Froxel) │     │ (Cloud 5-Stage Pipe)  │
            │ HDRP 同源:         │     │ HDRP 同源:            │
            │  VolumetricLighting│     │  VolumetricClouds(.   │
            │  .compute /        │     │  compute / Trace /    │
            │  VBuffer.hlsl      │     │  Combine / Filter)    │
            │  VolumetricLighting│     │ HG delta:             │
            │  Filtering.compute │     │  • 5-Stage 显式拓扑   │
            │ HG delta:          │     │  • Far Cloud 3 模式   │
            │  • 仍用 froxel +   │     │  • SDF 资产替噪声 LUT │
            │   log-Z, 但额外    │     │  • MS/SH 预烘焙缓存   │
            │   暴露 64-jitter   │     │  • ComposeOverride    │
            │  • 双高度雾 + Flow │     │   per-volume          │
            │   noise           │     │                       │
            └────────────────────┘     └───────────────────────┘
                       │                           │
                       ├───── 局部雾 (本文 §5) ────┤
                       │   HGVolumetricLocalFog   │
                       │     + SPMDCullingNative  │
                       │       (Burst SoA 剔除)   │
                       │                           │
                       └───── 风场 / 本地光 ──────┤
                            ComputeBuffer/CBHandle│
                                                  ▼
                                  SceneColor 合成 (透明阶段前后)
```

**HG ↔ HDRP 名词映射 (本子系统专用)**：

| HG 类 / 概念 | HDRP 同源 | 算法位置 |
|---|---|---|
| `HGVolumetricFogRenderer` 三阶段 | `HDRenderPipeline.VolumetricLighting.cs` + `VolumetricLighting.compute` + `VolumeVoxelization.compute` + `VolumetricLightingFiltering.compute` | §3 |
| `HGVolumetricFogRenderer.GetVolumetricFogGridZParams` | `VBufferParameters.ComputeLogarithmicDepthEncodingParams` (`HDRenderPipeline.VolumetricLighting.cs:266`) | §3.2 |
| `_LightScatteringFrameJitterOffsets[64]` | `m_xySeq` + `m_zSeq` Halton/Hammersley pairs (`HDRenderPipeline.VolumetricLighting.cs:331-348`) | §3.3 |
| `VolumetricRenderer.Render` 5‑Stage | `HDRenderPipeline.VolumetricClouds*.cs` (Accumulation / FullResolution / LowResolution / Sky) | §4.4 |
| `VolumetricCloudSDF` SDF march | `VolumetricCloudsUtilities.hlsl::TraceVolumetricRay` (`:480`) | §4.3 |
| `EvaluateCloud` (Frostbite 积分) | `VolumetricCloudsUtilities.hlsl::EvaluateCloud` (`:440`) | §4.3 |
| `VolumetricMSBake` 多次散射 LUT | `EvaluateMultipleScattering` (3 阶 forward+backward HG 在 `:157-169`) | §7.1 |
| `VolumetricFarCloudRenderer` 全景/八面体 | HDRP **无** — HG 自研 (§4.6) | §4.6 |
| `HGVolumetricLocalFog` + `SPMDCullingNativeInout` | `LocalVolumetricFog` + `LocalVolumetricFogManager` (`HDRP/.../VolumetricLighting/LocalVolumetricFog*.cs`)，HG 改 Burst SoA 实现 | §5 |
| `HGCloudConfig` 天空 2D 云 | 与 HDRP `VolumetricClouds` 独立（HG 把 2D 平面云保留为单独 IEnvConfig） | §2 |

> **核心算法原理在 HDRP 端，本文据 HDRP 源精确讲清；HG delta 据反编译 C# 调用图 + 常量定位**。

---

## 3. 体积雾 — Froxel + VBuffer + 单次散射 + 温度重投影

> 同源 HDRP：`VolumetricLighting.compute` (782 行) + `VBuffer.hlsl` (~280 行) + `HDRenderPipeline.VolumetricLighting.cs` (`ComputeLogarithmicDepthEncodingParams` `:266`, `VBufferParameters` `:183-296`, `m_zSeq` Halton `:331-348`)。
> HG 入口：`HGVolumetricFogRenderer.cs` 三阶段公开 API、`HGVolumetricFogUtils.GetVolumetricFogGridZParams`、`VolumetricFogPassConstructor`。

### 3.1 总览：为什么 froxel

视锥按屏幕 X/Y 分块、按视距 Z 分切片，得到 W × H × D 个**截头四棱锥体素 (frustum voxel ≡ froxel)**。在每个 froxel 内估算介质参数 (`σₛ`/`σₐ`/相位)、单次散射结果与透射率，然后**沿摄像机射线积分整列 froxel** 得到屏幕空间的雾辐亮度 + 透射率，最后与场景颜色按透射率混合。这样的好处是：

1. **散射只算 W×H×D 次而非每像素 N 步**，把 ray march 摊薄成 `D` 次 dispatch；
2. **VBuffer 本身就是缓存**：透明物体、雾合成共用同一 4D 纹理 (`_VBufferLighting`)；
3. **天然支持 temporal reproject**：把 froxel 中心反投到上一帧的 VBuffer 即可。

### 3.2 VBuffer 维度 + 指数 Z 分布 (HDRP 真实公式)

#### 3.2.1 XY 维度

```hlsl
// HDRP VolumetricLighting.compute:28
#ifdef VL_PRESET_OPTIMAL
  #define VBUFFER_VOXEL_SIZE 8    // 8 像素一个 froxel
#endif
```

HDRP 默认 8 像素 → 1080p ⇒ `(240, 135)` XY；切片 `64`，得到 `240×135×64 = 2,073,600` froxel。HG 用 `HGVolumetricFogRenderer.GetVolumetricFogGridSize` 走同一思路：

```csharp
// 据 HGVolumetricFogRenderer.cs:84 调用 HGVolumetricFogUtils.DivideAndRoundUp 两次
public static Vector3Int GetVolumetricFogGridSize(
    Vector2Int viewRectSize, out Vector2Int volumetricFogGridToPixel)
{
    int gp = settings.gridPixelSize;              // 默认 8 (HDRP 同 VBUFFER_VOXEL_SIZE)
    Vector2Int gridMax  = DivideAndRoundUp(maxSourceRTSize, gp);
    Vector2Int gridCurr = DivideAndRoundUp(viewRectSize,    gp);
    volumetricFogGridToPixel = gp 的复用 (...);
    return new Vector3Int(gridCurr.x, gridCurr.y, settings.gridSizeZ);
}
```

> **HG delta**：HDRP 用 `Fog.fogControlMode` 在 `Balance/Manual` 之间动态选 voxelSize 与 sliceCount (`HDRenderPipeline.VolumetricLighting.cs:367-413`)；HG 用 `SettingParameter<int>` 走 `RuntimeQuality` 选 quality‑tier 取值（移动端可降至 4×4 voxel + 32 slice）。`maxSourceRTSize` 与 `viewRectSize` 都向上取整意味着 VBuffer 物理纹理大小**按可能的最大视口分配一次，按当前视口写一个子矩形**——避免动态分辨率切换时反复 alloc。

#### 3.2.2 Z 切片：log‑Z 指数分布

雾对近处密、远处稀，**自然把 Z 分布做成指数**。HDRP 给出精确公式 (`HDRenderPipeline.VolumetricLighting.cs:266-295`)：

```csharp
// EncodeLogarithmicDepth: e = encode.x + encode.y · log2(max(0, z - encode.z))
// DecodeLogarithmicDepth: z = decode.x · 2^(d · decode.y) + decode.z
static Vector4 ComputeLogarithmicDepthEncodingParams(float n, float f, float c)
{
    Vector4 p;
    p.y = 1.0f / Mathf.Log(c * (f - n) + 1, 2);   // 1 / log2(c(f-n) + 1)
    p.x = Mathf.Log(c, 2) * p.y;
    p.z = n - 1.0f / c;
    p.w = 0;
    return p;
}
static Vector4 ComputeLogarithmicDepthDecodingParams(float n, float f, float c)
{
    return new Vector4(
        1.0f / c,
        Mathf.Log(c * (f - n) + 1, 2),
        n - 1.0f / c,
        0);
}
```

**参数含义**：

- `n` = VBuffer 起始距离 (≈ 摄像机 near plane)；
- `f` = VBuffer 结束距离 (取 `min(n + depthExtent, farFrustumDiagDist)`，HDRP 用 球面‑capped 视锥)；
- `c` = "切片均匀度" — HDRP `c = 2 - 2·sliceDistributionUniformity`，范围 `[0.001, 2]`：`c→0` 时退化为线性等距，`c→2` 时强烈前密后疏。

数学上：

```
slice_index   d  ∈ [0, 1)
view_distance z  = (1/c) · 2^(d·log2(c(f-n)+1)) + (n - 1/c)
              = (1/c) · (c(f-n)+1)^d + (n - 1/c)
```

写开就是 `z(d) = (n - 1/c) + (1/c) · exp(d · ln(1 + c(f-n)))`——典型的"线性 + 指数"组合，参数 `c` 同时控制起始斜率与远端密度。

**HG delta**：`HGVolumetricFogRenderer.GetVolumetricFogGridZParams(startDistance, near, far, gridSizeZ)` (`:281`) 返回 `Vector3 (A, B, C)`，不直接复用 HDRP 的 4 元组，而是把 encode/decode 信息压缩：

- `A = (n - 1/c)`
- `B = 1/c`
- `C = c · (f - n) + 1`

然后 shader 端 `z = A + B · pow(C, slice / sliceCount)`，等价 HDRP，但**省了一次 log2/exp2 编码反编码**，更适合移动端（避免 fp32 精度损失）。`c` 在 HG 端是 `SettingParameter<int> depthDistributionScale`（整数刻度，UI 用 0..10）→ HG 内部 `c = clamp((10 - scale) * 0.2, 0.001, 2)` 把均匀度反向（数值越大越均匀，对应 HDRP `sliceDistributionUniformity`），**最终物理含义一致**。

`_GetVolumetricFogZSliceFromDepth(depth, gridZParams)` (`HGVolumetricFogRenderer.cs:219`) 反解 `slice = log_C((depth - A) / B)`——给透明物体在 fwd pass 中查 VBuffer 用。

#### 3.2.3 抖动序列（Halton）

```csharp
// HDRP HDRenderPipeline.VolumetricLighting.cs:331-348
Vector4[] m_PackedCoeffs;          // ZH (Zonal Harmonics) 7 系数 (HG L2 = 3+3+1)
ZonalHarmonicsL2 m_PhaseZH;
Vector2[] m_xySeq;                 // Halton(2,3) XY 序列 (7 帧)
float[] m_zSeq = {                 // 7 等距数, 中位为 0.5
    7/14, 3/14, 11/14, 5/14, 9/14, 1/14, 13/14
};
```

HG `VolumetricFogLightScatteringConstants._LightScatteringFrameJitterOffsets[64]` (`HGVolumetricFogRenderer.cs:62`) 是同样的低差异序列**但保留 16 个 Vec4 周期**，便于在不同温度复用窗口下取出对应抖动。`HGVolumetricFogRenderer.VolumetricFogTemporalRandom(frameNumber)` (`:442`) 在 CPU 端取模映射出当帧三轴随机数 `(x, y, z)`，乘 `lightScatteringSampleJitterMultiplier` 后注入 `_VBufferSampleOffset.xyz`。

> **HG delta**：HDRP 用 7 帧累积 (`numFrames=7`，`m_zSeq` 长 7)，HG **扩到 16 (Vec4 数) × 4 = 64 浮点**给更多自由度（视觉上柔化光柱锯齿），但**累积权重仍是 EMA**（详 §3.5）。

### 3.3 三阶段 GPU 执行模型

HDRP 是这条流水：

```
1. VolumeVoxelization.compute  → _VBufferDensity (RGB scatter, A extinction)
2. VolumetricLighting.compute  → _VBufferLighting (单次散射 + temporal blend)
3. (可选) VolumetricLightingFiltering.compute  → 3x3 高斯水平滤波
```

HG 把同一 3‑pass 显式暴露为 `HGVolumetricFogRenderer` 的三个方法：

```
HGVolumetricFogRenderer.ComputeVolumetricFogGridInjection    ⇄ HDRP VolumeVoxelization
HGVolumetricFogRenderer.RenderVolumetricFogVoxelization      ← (光栅 MRT 注入 Local Fog；HDRP 在 :LocalVolumetricFogManager.DrawInstancedFogVolumes)
HGVolumetricFogRenderer.ComputeVolumetricFogLightScattering  ⇄ HDRP VolumetricLighting
HGVolumetricFogRenderer.ComputeVolumetricFogFinalIntegration ⇄ HDRP 内嵌的 "compose" pass
```

#### 3.3.1 Stage A — Density Injection (`_VBufferDensity` 填充)

每个 froxel 计算介质参数：

```
σₛ_rgb(x_froxel) = sum over (global fog + height fog + local fog):
    scattering * extinction_multiplier * height_falloff(x.y) * flow_noise_mod(x, t)
σₜ(x_froxel)     = max(FLT_MIN, σₛ.x + σₛ.y + σₛ.z + absorption)
anisotropy       = g (HG: 全局 _GlobalFogAnisotropy)
```

HDRP `VolumeVoxelization.compute` 关键步骤：

1. 对每个 `(x, y, slice)` 计算 froxel 中心世界坐标 `centerWS` (反解 log‑Z + view ray)；
2. 累加全局 fog 密度；
3. 遍历 visible `LocalVolumetricFog`（OrientedBBox 6 平面 + atlas mask），把 mask 中的 density 累加；
4. 写 `_VBufferDensity[uint3(x,y,slice)] = float4(scattering.rgb, extinction)`。

**HG delta**：

- 局部雾的剔除 **不在** voxelization 内部循环——HG 提前在 CPU 用 Burst SoA `SPMDCullingNativeInout` 算可见列表 (§5)，再用 **MRT 光栅 voxelization** (`RenderVolumetricFogVoxelization`：用 `s_voxelizationMaterialPropertyBlock` 跑全屏 quad mesh 写所有 slice 输出)。
- **Flow Noise**：`HGVolumetricFogConfig` 暴露 `enableVLFlowNoise / flowVLNoiseIntensity / flowVLNoiseTilling / flowVLNoiseDirAngle / flowVLNoiseSpeed`，shader 在密度采样位置上加 2D flow‑map：
  ```
  uv_distorted = uv + flowMap(uv).xy · time · speed
  density *= 1 + intensity * (noise(uv_distorted) - 0.5)
  ```
  HDRP 无此 native flow，HG 移植自 Frostbite "flow noise" 经验做法以增加云气流动感。

#### 3.3.2 Stage B — Light Scattering (`_VBufferLighting` 填充 + 温度重投影)

这是体积雾的**算法核心**——HDRP `VolumetricLighting.compute::FillVolumetricLightingBuffer` (`:533-789`)。对每个屏幕像素的 ray：

```
ray.originWS    = camera position
ray.centerDirWS = unproject(pixel, _VBufferCoordToViewDirWS)  // 像素中心反投视向
ray.jitterDirWS = normalize(centerDir + jitter.x · xDirDeriv + jitter.y · yDirDeriv)
ray.geomDist    = LinearEyeDepth(_CameraDepthTexture[pixel])   // 不透明几何遮挡
```

然后 **逐 slice 累积**：

```
for slice = 0 .. _VBufferSliceCount-1:
    t0 = max(tStart, DecodeLogZ(slice/D))         # slice 起点
    t1 = max(tStart, DecodeLogZ((slice+1)/D))     # slice 终点
    if (ray.geomDist in [t0, t1]):
        t1 = max(t0·1.0001, ray.geomDist)         # geo aware:截断到不透明
    dt = t1 - t0
    if (dt <= 0): _VBufferLighting[...] = 0; continue

    # 在 slice **中心** (log space) 取介质
    t       = DecodeLogZ(slice/D + 0.5/D)
    centerWS = origin + t · centerDir
    (σₛ, σₜ) = _VBufferDensity[(x,y,slice)]

    # Stochastic Universal Sampling: 在 [t0,t1] 内随机选一点采阴影
    rndVal  = frac(GenerateHashedRandomFloat(pixelXY) + _VBufferSampleOffset.z)
    ImportanceSampleHomogeneousMedium(rndVal, σₜ, dt, tOffset, weight)
    t_sample = t0 + tOffset
    posWS    = origin + t_sample · jitterDir

    # ★ 评估方向光散射
    sunShadow = GetDirectionalShadowAttenuation(posWS, jitterDir)
    L_sun_rgb = sunColor · sunShadow · sunVolumetricLightDimmer
    aggregate.radianceNoPhase  += weight · L_sun_rgb
    aggregate.radianceComplete += weight · L_sun_rgb · phase(jitterDir · sunDir, g)

    # ★ Big-tile light list 遍历可见 punctual lights
    for each light in BigTile(pixelXY):
        L_punct = EvalPunctual(light, posWS, jitterDir)
        aggregate.radianceComplete += L_punct · phase(...)
        aggregate.radianceNoPhase  += L_punct

    # ★ APV (Adaptive Probe Volume) 漫反射 GI: SH9 评估
    apvDiffuseGI = EvaluateAdaptiveProbeVolume(posWS)
    aggregate.radianceComplete += apvDiffuseGI · phase
    aggregate.radianceNoPhase  += apvDiffuseGI

    # ★ Temporal Reproject (ENABLE_REPROJECTION)
    voxelValue       = float4(noPhase, σₜ·dt)
    linearizedValue  = LinearizeRGBD(voxelValue)
    normalizedValue  = linearizedValue / dt
    historyValue     = SampleVBuffer(_VBufferHistory, centerWS, _PrevCamPosRWS, UNITY_MATRIX_PREV_VP, ...)
    if (historyValid && history.a != 0):
        # "Pixar blend" 在 log space 做 EMA
        n           = 7              # numFrames
        frameWeight = 1/n
        historyW    = 1 - 1/n
        blended    = lerp(normalizedValue, history, historyW)
    else:
        blended    = normalizedValue
    _VBufferFeedback[voxel] = clamp(blended * exposureMult, 0, HALF_MAX)
    blendValue = DelinearizeRGBD(blended * dt)

    # ★ 累积透射率与积分
    transmittance        = TransmittanceFromOpticalDepth(opticalDepth)     # exp(-OD)
    phaseConst           = _CornetteShanksConstant                          # 各向异性预乘后的相位常数
    probeRadianceSlice   = probeInScatteredRadiance · TransmittanceIntegralHomogeneousMedium(σₜ, dt)
    totalRadiance       += transmittance · σₛ · (phaseConst · blendValue.rgb + probeRadianceSlice)
    opticalDepth        += blendValue.a       # σₜ·dt

    # ★ 写 VBufferLighting (在感知 space 存,适合后续 3x3 滤波)
    _VBufferLighting[voxel] = LinearizeRGBD(float4(totalRadiance, opticalDepth)) · float4(exposure.xxx, 1)

    if (t0 · 0.99 > maxDist): break
```

**关键算法点**：

1. **`ImportanceSampleHomogeneousMedium`** ——给定 slice 内均匀介质 + 透射率分布，按 `p(t) ∝ exp(-σₜ·t)` 反 CDF 采样得到 `tOffset` 和重要性 `weight = (1 - exp(-σₜ·dt)) / σₜ`。weight 已经把"从 t0 到采样点的透射率"算进去，所以 `radiance += weight · L_light`。
2. **EMA 历史融合**：`X_n = (1/n)·V_n + ((n-1)/n)·X_{n-1}`，n=7 等效"过去 7 帧均匀加权平均"——这是 HDRP `ComputeHistoryWeight()` 数学注释 (`:132-153`) 的依据。
3. **"Pixar blend" 在 log space**：`LinearizeRGBD(rgbd)` 把 `(rgb, opticalDepth)` 变成 `(rgb · transmittance, transmittance)` 形式，使得**两帧透射率乘性融合**与**色彩加性融合**互不串扰。`DelinearizeRGBD` 是其逆。这能避免雾色彩在快速镜头下"灰掉"。
4. **NoPhase + Phase 双路**：相函数与抖动是独立维度。如果直接给融合后的 `radianceComplete` 历史，多光源场景下 `phaseCurrFrame` 不稳定（详 HDRP 注释 `:721-731`），所以历史存 `radianceNoPhase`，**只在最后乘相函数**——这是 HDRP 的精妙处。HG 完全沿用：`VolumetricFogLightScatteringConstants` 有 9 组 `_VolumetricFogLightScatteringParams0..8` 携带相函数系数等参数。

**HG delta**：

- HDRP 走 `LightLoop` Big‑Tile (`USE_BIG_TILE_LIGHTLIST`)；HG 用 `enableScalarizeDynamicLightLoop` (`HGVolumetricFogSettingParameters`) 切是否做 wave‑uniform scalarization——移动端关，主机端开。
- HDRP punctual light shadow 取 `PUNCTUAL_SHADOW_ULTRA_LOW` (1 PCF tap)；HG 增加 `enablePunctualLightShadow` 总开关 + 单独 `punctualLightShadowResult: TextureHandle` 输入 (`VolumetricFogPassConstructor.ComputeVolumetricFogPassData`)，**预先在 shadow pass 里把可见 punctual light shadow 烘到一张共享 atlas**，体积雾只采样不再做 sun shadow 一样的层级查找。
- HDRP `historyMissSuperSampleCount` 等同于 HDRP 的 `numFrames` (固定 7)；HG 把它做成 `SettingParameter<int>`，新区域重投影失败时按该数额外做超采样，**避免新进入的体素一帧灰雾爆点**。`fogHistoryWeight` 同理。

#### 3.3.3 Stage C — Final Integration (Compose)

HDRP 在透明物体 forward pass 里**直接采样 `_VBufferLighting`** 做合成（`VBuffer.hlsl::SampleVBuffer` 三签名 NDC / WorldPos / Slice）。`SampleVBuffer` 用：

- **biquadratic 3×3 filter** 重建（"A Fresh Look at Generalized Sampling" 引用），减少 froxel 边缘锯齿；
- **clamp‑to‑edge** 或 **clamp‑to‑border** 避免泄光；
- log‑Z 编码 `w = EncodeLogarithmicDepth(linearDist)` 再 3D 纹理采样。

HG `ComputeVolumetricFogFinalIntegration` (`HGVolumetricFogRenderer.cs:3006`) 把 VBuffer 沿 Z 提前积分成 **`_IntegratedLightScattering`** (单 3D 纹理，slice = depth)，后续 forward / compose pass 只需 trilinear 一次，**避免每个 fragment 在 forward pass 里跑 3×3 biquadratic**——移动端友好优化。`HGVolumetricComposeData._VolumeMatVP / _VolumetricZBufferParam / _VolumetricZEncodeParam` 提供合成用的"反 NDC → world"变换。

### 3.4 体积雾常量打包结构 (HG)

```csharp
// HGVolumetricFogRenderer.cs:44-49
public struct VolumetricFogGridInjectionConstants
{
    public Vector4 _VolumetricFogGridInjectionParams0;     // gridSize.xyz + 1/gridSize.z
    public Vector4 _VolumetricFogGridInjectionParams1;     // ZParams (A, B, C, sliceCount)
}

// HGVolumetricFogRenderer.cs:51-76
public struct VolumetricFogLightScatteringConstants
{
    public Vector4 _VolumetricFogGridInjectionParams0;
    public Vector4 _VolumetricFogGridInjectionParams1;
    public Vector4 _VolumetricFogLightScatteringParams0;   // 散射 albedo + extinction scale
    public Vector4 _VolumetricFogLightScatteringParams1;   // mie/rayleigh 颜色与各向异性 g
    public Vector4 _VolumetricFogLightScatteringParams2;   // 高度雾 startHeight/falloff/double-curve
    public Vector4 _VolumetricFogLightScatteringParams3;   // direct lighting intensity + sky intensity
    public Vector4 _VolumetricFogLightScatteringParams4;   // distance / nearFade / cutoff
    public Vector4 _VolumetricFogLightScatteringParams5;   // emissive 1/2 颜色
    public Vector4 _VolumetricFogLightScatteringParams6;   // FlowNoise 方向 / 强度
    public Vector4 _VolumetricFogLightScatteringParams7;   // historyMiss superSample + fogHistoryWeight
    public Vector4 _VolumetricFogLightScatteringParams8;   // 保留 / volumetric ambient
    public unsafe fixed float _LightScatteringFrameJitterOffsets[64];  // 16 Vec4 抖动表
}
```

> 字段名按反编译 C# 直接照抄；**槽位语义**据 [§4.7 HGVolumetricFogConfigCPP](../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md#47-hgvolumetricfogconfigcpp--体积雾配置独立结构) 的 15 字段一一对应。具体每槽位的浮点打包 (例: P0.x = albedo.r, P0.y = albedo.g…) 需要从 `volumetric/volumetricfog.shader` 反向核对——本文按主题归类，**不写无法佐证的具体打包**。

### 3.5 体积雾 dispatch 时序

```
HGCamera.Update
  └─→ HGVolumetricFogRenderer.SetupShaderVariablesGlobalVolumetricFog
        写 ShaderVariablesGlobal CB 中所有 _VolumetricFogParams*

ShadowResult (来自 C07-ShadowASM) → VolumetricFogPassConstructor.PassInput
  └─→ ConstructPass:
        AddRenderPass × 3:
          ① ComputeVolumetricFogGridInjection
              CS: volumetricFogGridInjectionCS, kernel "Main"
              dispatch (ceil(gridX/8), ceil(gridY/8), ceil(gridZ/8))   // HDRP 是 8×8×1, HG 走 8³ 立方
              SRV: _LocalLightList (_LocalFogList) ComputeBuffer (来自 §5/§6)
              UAV: _VBufferA (vBufferA)

          ② RenderVolumetricFogVoxelization                            // Local Fog 光栅 MRT 注入 (HG 特有)
              MaterialPropertyBlock 在每个可见 Local Fog mesh 上跑 quad render
              MRT: vBufferA[slice] 全 Z 范围 GS 复制

          ③ ComputeVolumetricFogLightScattering
              CS: volumetricFogLightScatteringCS, kernel "Main"
              dispatch (ceil(gridX/8), ceil(gridY/8), 1)               // 散射沿 Z 串行,Z 内积分
              SRV: _VBufferA, _VBufferHistory, _PunctualLightShadowResult, _APVBuffer
              UAV: _VBufferB (lighting), _VBufferFeedback (历史 next frame)

          ④ ComputeVolumetricFogFinalIntegration
              CS: volumetricFogFinalIntegrationCS, kernel "Main"
              dispatch (ceil(gridX/8), ceil(gridY/8), 1)               // 同尺寸,沿 Z 积分
              UAV: _IntegratedLightScattering (供 forward pass 单次 tex3D 采样)
```

> 本文不照抄具体 kernel name 字符串（无源），按 HDRP 同源命名习惯命名。`punctualLightShadowActive=false` 时跳过 punctual 分支。

---

## 4. 体积云 — Frostbite 风格 SDF March + 5‑Stage 流水线 + 远云分帧

> 同源 HDRP：`VolumetricCloudsUtilities.hlsl::TraceVolumetricRay` (`:480-650`) + `EvaluateCloud` (`:440-466`)（Frostbite 2016 "Sky & Clouds in Frostbite"）+ `VolumetricCloudsTrace.compute::RenderClouds` (`:55-112`) + `VolumetricClouds.compute` 5 kernel (Reproject / PreUpscale / Upscale × 2 / Combine × 2)。
> HG 入口：`VolumetricRenderer.cs` (16K 行的 4 Stage class) + `VolumetricCloudPassConstructor` + `VolumetricCloudSDF`(主组件) + `VolumetricFarCloudRenderer`(远云)。

### 4.1 视觉目标 vs HDRP

HDRP 体积云做的是 **气象云层 + 远景**——通过 2D weathermap + 3D Worley/Perlin 噪声查体素，沿视线 ray-march，在两个 R/r 球面之间。HG 把这套思路扩到 **本地体积云 (Local Volumetric Cloud)**：

- 云体不是无限大气层，而是**离线烘焙的 SDF + Density 3D 资产** (`VolumetricSdfAsset.SdfTexs[]`：[0]=Density, [1]=Advanced(法线/MS), [2]=SH)。
- 多个 `VolumetricCloudSDF` 体积可在场景中布置（巨型空中浮岛、洞穴内云气等），每相机维护 `Dictionary<HGCamera, VolumetricFarCloudRenderer>` 做 fade & far-cloud。
- 渲染目标包含 **near cloud (sub‑frame SDF march)** + **far cloud (远景全景烘焙)**，二者通过 5‑Stage 拓扑合成。

### 4.2 5‑Stage 流水线拓扑 (HG 独有)

```csharp
// EVolumetricStage.cs:3-10
public enum EVolumetricStage
{
    Framing        = 0,     // 棋盘/Quarter 重建低分辨率云体
    BeforeTemporal = 1,     // 在 TAA 前合成 (允许 framing pass 也被 TAA 累积)
    Temporal       = 2,     // 自有 TAA pass (允许与 BeforeTemporal merge)
    AfterTemporal  = 3,     // 在 TAA 后合成 (per-volume override 用)
    SceneCompose   = 4,     // 最终 blit 到 sceneColor
}
```

每个 Stage 都是一个 `VolumetricRenderStage` 派生类（`FramingStage`/`GeneralComposeStage`/`TemporalStage`/`SceneComposeStage` —— `GeneralComposeStage` 同时实现 `BeforeTemporal` 与 `AfterTemporal`），包含：

- `List<VolumetricRenderNode> renderNodes`：本 Stage 当帧要处理的体积对象节点；
- `SortNodes()`：按 `NodeCompare = (ComposePriority, RenderQueue, SortingOrder, DistToCamera)` 四级排序；
- `ProcessImpl(ref inputs, ref colorRT, ref depthsRT)`：抽象，由派生类实现；
- `Process(...)`：装饰 IFix 代理 `_003C_003EiFixBaseProxy_ProcessImpl` 后调用。

HG 用 `Dictionary<EVolumetricStage, VolumetricRenderStage> m_RenderStages` 持有这 4/5 个 stage，由 `UpdateVolumetricRenderPipeline(...)` (`VolumetricRenderer.cs:8781`) 在每帧开始按 `enableFraming + enableTAA + m_CanMergeTAAPass` 三态选择哪些 stage 启用。

```
Render(inputs):
  1. UpdateCamera                                  // 写 _VolumetricTAAPrevWorldSpaceCamera{Pos,Forward}
  2. DisableAllStages                              // 全部 reset
  3. AddToComposeCache                             // 逐 IVolumetricRenderObject 注册 override
  4. UpdateVolumetricRenderPipeline                // 选 stage 拓扑
  5. GetVolumetricRenderRTSize / UpdateVolumetricRTs  // ping-pong RT 分配
  6. UpdateRenderStageAndDraw                      // 按枚举顺序 Process 每个 stage
       Framing → BeforeTemporal → Temporal → AfterTemporal → SceneCompose
       (每 Stage: ProcessImpl → 遍历 renderNodes → 排序 → Callback)
  7. ProcessPassMerge                              // s_MergeTAAPass{NMVNDO,EMVNDO,EMVEDO,NMVEDO} keyword 选合并
  8. DrawVolumetric                                // 最后 blit 到 inputs.sceneColor
```

**为什么是 5 Stage 而不是 HDRP 的 2‑pass (Reproject + Upscale)**：

- HDRP 体积云对场景做**单一全屏 trace + 同分辨率 TAA**；它**不需要** Framing 棋盘重建，因为 trace 已经在 1/2 分辨率，TAA 直接累积。
- HG 体积云每个 SDF Volume 都可能**独立**有 `bEnableFraming` (棋盘) 与 `bEnableTAA`(温度累积) 两个开关，不同 Volume 拓扑可能完全不同；同帧需要把它们正确**排序+合成**。所以 HG 把每个语义阶段都做成显式 Stage，让 `RenderNode.bEnableFraming/bEnableTAA` 决定它放进哪几个 Stage 的 `renderNodes`。
- `m_CanMergeTAAPass`：当 `BeforeTemporal` 和 `Temporal` 中间无 `OffScreenPass` 时，可把它们合并成同一个 RenderPass（少一次 store/load）—— 用 4 个 keyword `s_MergeTAAPassNMVNDO`(无 MV 无 DO)、`NMVEDO`(无 MV 启用 DO)、`EMVNDO`、`EMVEDO` 切 shader 路径。

### 4.3 SDF March 核心算法 (HDRP 同源)

HDRP `VolumetricCloudsUtilities.hlsl::TraceVolumetricRay` (`:480-650`) 算法蓝图：

```
1. 视线与云体包围盒求交 → (rayMarchRange.start, rayMarchRange.end)
2. totalDistance = min(end, ray.maxRayLength) - start
3. stepS = min(totalDistance / _NumPrimarySteps, _MaxStepSize)
4. 初始化:
     transmittance = 1
     scattering    = 0
     ambient       = 0
     meanDistance  = 0
     meanDivider   = 0
     activeSampling = true
     sequentialEmpty = 0
5. for i in 0 .. _NumPrimarySteps:
     posPS = ConvertToPS(originWS + (start + currentDist) · direction)
     fade  = saturate((currentDist - _FadeInStart) / (_FadeInStart + _FadeInDistance))    # 距离 fade
     erosionMip = lerp(0, 4, saturate((currentDist - MIN_EROSION_DISTANCE) / (MAX - MIN)))

     if activeSampling:
        # ★ 主采样: 评估 SDF/density/Worley/Perlin
        cloudProps = EvaluateCloudProperties(posPS, /*noiseMip*/ 0, erosionMip, /*cheap*/ false, /*lightSampling*/ false)
        cloudProps.density *= fade
        if cloudProps.density > CLOUD_DENSITY_TRESHOLD:
            # ★ Frostbite 分析式积分 (EvaluateCloud :440-466)
            extinction   = density · sigmaT
            transmittance_step = exp(-extinction · stepS)

            # ★ Powder 效果 (近光源处提亮)
            powder = PowderEffect(density, cosAngle, _PowderEffectIntensity)
            # ★ 太阳透射率 (沿光线方向再 march N 步)
            sunT = EvaluateSunTransmittance(posPS, sunDir, phaseFn)
            sunLuminance     = sunT · powder
            ambientLuminance = cloudProps.ambientOcclusion

            # ★ 能量守恒分析式积分 (Frostbite 2015 slide 28)
            # 等效 S = ∫₀^stepS T(0,τ) · σₛ · L_sun dτ
            #       = L_sun · σₛ · (1 - exp(-σₜ·stepS)) / σₜ
            # 因 albedo=1 ⇒ σₛ=σₜ, 简化为
            scattering += sunLuminance · (transmittance - transmittance · transmittance_step)
            ambient    += ambientLuminance · (transmittance - transmittance · transmittance_step)
            transmittance *= transmittance_step

            # 累加深度 (Frostbite 加权平均)
            meanDistance += currentDist · transmittance
            meanDivider  += transmittance

            if transmittance < 0.003: break                        # ★ 早退: 99.7% 已被吸收
            sequentialEmpty = 0
        else:
            sequentialEmpty++
        if sequentialEmpty == EMPTY_STEPS_BEFORE_LARGE_STEPS:
            activeSampling = false                                 # ★ 切大步进模式

        currentDist += stepS
     else:
        # ★ 大步进模式: 只采便宜版 density, 若发现密度则回退
        cheap = EvaluateCloudProperties(posPS, 1, 0, /*cheap*/ true, false)
        cheap.density *= fade
        if cheap.density > 0:
            activeSampling = true                                  # 回退到主采样
            currentDist -= stepS                                   # 退一步,重新主采
        else:
            currentDist += stepS · LARGE_STEP_MULT
6. meanDistance /= max(meanDivider, FLT_MIN)
```

#### 4.3.1 Frostbite 分析式积分推导

设介质均匀，单步 `dt`：

```
T(0, t)   = exp(-σₜ · t)                       # 沿步透射率
S(stepS)  = ∫₀^stepS T(0, τ) · σₛ · L dτ
          = L · σₛ · ∫₀^stepS exp(-σₜ·τ) dτ
          = L · σₛ · (1 - exp(-σₜ·stepS)) / σₜ
          = L · (σₛ/σₜ) · (1 - T_step)
albedo=1 ⇒ σₛ=σₜ ⇒ S = L · (1 - T_step)

完整累积:
    scattering_new = scattering_old + L · transmittance_old · (1 - T_step)
    transmittance_new = transmittance_old · T_step
```

这正是 HDRP `EvaluateCloud` (`:463-465`) 的代码：

```hlsl
volumetricRay.scattering    += sunLuminance · (volumetricRay.transmittance
                                              - volumetricRay.transmittance · transmittance);
volumetricRay.ambient       += ambientLuminance · (volumetricRay.transmittance
                                                  - volumetricRay.transmittance · transmittance);
volumetricRay.transmittance *= transmittance;
```

`transmittance - transmittance · T_step = transmittance · (1 - T_step)`，所以省了一次乘法 —— 但语义一样。**HG 完全沿用**：`VolumetricCloudSDF.cs` 在 `UpdateMat()` 写 `_OpticalDepthScale / _InvOpticalDepthScale / _PhaseG / _PhaseG2 / _PhaseK / _PhaseK2 / _PhaseBlend`，shader 端就是上述积分 + 双 HG 相函数混合（前向 g₁=0.8 + 后向 g₂=-0.3 + 权重 K）。

#### 4.3.2 双 HG 相函数 + Powder

HG 相函数（标准）：

```
HG(cosθ, g) = (1 - g²) / [4π · (1 + g² - 2g·cosθ)^(3/2)]
```

- 单一 g 不能同时表现"太阳后散射光晕"和"侧背散射 dimmer"——所以**双相函数**：
  ```
  phase = lerp( HG(cosθ, g_forward),    # g₁ ≈ 0.8  (forward 光晕)
                HG(cosθ, g_backward),   # g₂ ≈ -0.3 (backward dimmer)
                K_blend )
  ```
- HDRP 在 `EvaluateMultipleScattering` (`:155-170`) 把 3 阶 forward+backward HG 用 `_MultiScattering` 衰减叠加。HG 把这部分预计算到 **MS LUT** (`VolumetricMSBake`)，shader 端只查表（详 §7.1）。

**Powder Effect**：物理上是"靠近发光介质边界处颜色变深"现象（云朵向阳面的暗边），近似公式：

```
powder = 1 - exp(-2 · density · powderIntensity)
        // 乘到 sunLuminance 上, 形成 |cosθ| 大时按 density 增益的视觉

// HDRP VolumetricCloudsUtilities.hlsl PowderEffect: 还按 cosθ 做 0~1 fade,
// 避免逆光时 powder 把云体压成黑色 (反直觉)
```

HG `VolumetricCloudSDF.UpdateMat()` 写 `_GodRayPow / _GodRayIntensity / _GodRayBlurCount / _GodRayBlurWidth / _GodrayCubic` 这一组就是**"God Ray"**——分离的轴向二次 march 沿太阳方向再积分，最后与 cloud 颜色加性叠加做"丁达尔光柱"。HDRP 同样有 god ray 路径但形态不同（HDRP god ray 在 atmospheric scattering 里）。

### 4.4 Empty‑Skip 加速结构 (HG 特有)

HG 的体积云不是 HDRP 那种 weathermap+noise 程序云，而是**烘焙 SDF**。所以 HG 把 march 加速从 HDRP 的 "EMPTY_STEPS_BEFORE_LARGE_STEPS" 计数器升级成 **基于 SDF 的"真空腔体跳跃"**：

```csharp
// VolumetricCloudSDF.UpdateEmptySkipRT(...) :2995 写以下属性:
_EmptySkipRT          : 一张低分辨率 3D 纹理 (= SDF 的下采样版)
_EmptySkipRTScale     : 主纹理 → empty skip 纹理的缩放比
_EmptySkipUVScale     : UV remap
_EmptySkipStepNum     : 跳跃步数预算
_EmptySkipSdfScale    : SDF 值 → world step 距离的转换
_EmptySkipRange       : 整体 march 范围
_EnableEmptySkipSample: 是否启用
```

march 时 shader 先查 `_EmptySkipRT` 拿到当前位置最近 cloud 表面距离 `d_sdf`，若 `d_sdf > stepS`，**直接跳到 `currentDist + d_sdf · _EmptySkipSdfScale`**——这是 SDF Sphere Tracing 的经典做法，比 HDRP 的"连续 N 步空采样后切大步"显著高效，但**前提是有离线烘焙 SDF 资产**。

**HG keyword 切换**：

- `s_EnableEmptySkip` —— 单层 empty skip RT (近云 only)
- `s_EnableEmptySkipTwoLayers` —— 双层 (近 + 远云分别有 empty skip)
- `s_EnableSH` —— 启用 SH 多次散射近似 (用 `_SHTex`，需 `_SHSampleBuffer` 配套)

### 4.5 五种 Stage 的具体行为 (HG)

```
┌─ Framing Stage (FramingStage.ProcessImpl :1075) ─────────────────┐
│ 输入: m_FramingColor, m_FramingDepth (低分辨率 m_FramingWidth/Height)│
│ 流程:                                                              │
│   1. UpdateFramingKeywords (设 s_FramingQuarter / s_FramingCheckerboard)│
│   2. 排序 renderNodes (NodeCompare)                                │
│   3. 对每个 node: Process(VolumetricCallbackContext) — Callback 通常│
│      Blit 把 framing pass 结果累积进 m_FramingColor                │
│   4. 棋盘 (Checkerboard): 当前帧只渲染 2x2 中 1 像素, 用            │
│      _PixelSubOffset 把当前像素切换到不同位置, 下一帧补全。         │
│   5. Quarter: 1 帧只渲 4 像素中的 1 个, 4 帧周期。                  │
│ 输出: m_FramingColor → 重建 pass 用 (m_ReconstructColors ping-pong)│
└──────────────────────────────────────────────────────────────────┘

┌─ BeforeTemporal Stage (GeneralComposeStage.ProcessImpl :1930) ───┐
│ 用途: TAA 之前合成 framing 重建结果 + per-volume override          │
│ 关键: 多个 cloud volume 之间的"compose 顺序"在这里固化            │
│      (NodeCompare → 按 priority/queue 决定先合谁)                  │
│ 输出: m_ComposeColor / m_ComposeDepth                              │
└──────────────────────────────────────────────────────────────────┘

┌─ Temporal Stage (TemporalStage.ProcessImpl :2564) ───────────────┐
│ 输入: m_ComposeColor (cur), m_TAAColors[prev] (history)            │
│ 流程:                                                              │
│   1. UpdateTemporalKeywords (enableMV, enableDO 二位 → 4 keyword)  │
│   2. 用 _VolumetricTAAPrevWorldSpaceCamera{Pos,Forward} 计算       │
│      cloud uv reprojection                                         │
│   3. Blit shader: 历史与当前按 _TAABlendRatio (典型 0.95) lerp      │
│      + Color AABB Clamp (s_TAAEnableColorAABB) / Neighbor          │
│      Avg (s_TAAEnableNeighborAvg) 防止 ghost                       │
│ 输出: m_TAAColors[cur]; ping-pong index = m_TAAIndex               │
└──────────────────────────────────────────────────────────────────┘

┌─ AfterTemporal Stage (GeneralComposeStage 复用) ────────────────┐
│ 用途: 某些云体(如 cutscene 主云)的 TAA 后单独合成 override        │
│ 通过 VolumetricCloudSDF.OverrideTemporalCompose 返回 RenderItem  │
└──────────────────────────────────────────────────────────────────┘

┌─ SceneCompose Stage (SceneComposeStage.ProcessImpl :3300) ─────┐
│ 输入: m_TAAColors[final], _CameraDepthTexture                  │
│ 流程:                                                            │
│   1. SetGlobalKeyword(s_ComposeVolumetric, true)                 │
│   2. CustomBlit (volumetricComposeMaterial)                      │
│      ShaderPass: depth-aware blend with sceneColor               │
│      depth fade: smoothstep(_DepthFadeDistance, ...)             │
│   3. 写回 inputs.sceneColor                                       │
└──────────────────────────────────────────────────────────────────┘
```

`m_CanMergeTAAPass = true` 时：BeforeTemporal + Temporal 合成同一 `RenderPass`，用 `s_MergeTAAPass{NMVNDO|EMVNDO|EMVEDO|NMVEDO}` keyword 4 选 1 决定 shader 路径——这是显式打包了 "EnableMotionVector (M/N)" × "EnableDepthOpt (E/N)" 的 2×2 矩阵。`HasOffScreenPassBefore(target)` (`VolumetricRenderer.cs:8579`) 判断是否合并安全。

### 4.6 远云 (`VolumetricFarCloudRenderer`) — 三种烘焙模式

近云 (`m_DrawNear`) 走 §4.3 SDF march；远云 (`m_DrawFar`) 走**离屏烘焙**到一张持久 RT，每帧只更新一小块、用 reprojection 拼接。HG 的 `VolumetricFarCloudRenderer` 给三种几何模式：

#### 4.6.1 Panoramic — 全景烘焙

```
m_FarCloudPanoramicColorRT, m_FarCloudPanoramicDepthRT
└─ 大小: (panoramicSizeX, panoramicSizeY)  典型 1024×512 或 2048×1024
└─ 投影: equirectangular (经度 0..2π / 纬度 -π/2..π/2)
└─ Bake: 每隔 _PanoramicUpdateDistance (远云强制刷新阈值, 据 m_BakedFarCloudCenter
   与 hgCamera.pos 距离 > MAX_FAR_CLOUD_FORCE_UPDATE_DISTANCE 时 force=true)
   ColorRT[uv] = TraceVolumetricRay(ray_with_uv_to_direction)
└─ 渲染: scene compose 时按 viewDir 查 panoramic RT
```

适合摄像机定点平移（不大旋转）下的"天空背景云海"。

#### 4.6.2 Octahedron — 八面体投影烘焙

```
m_FarCloudPanoramicColorRT (复用同槽位)
└─ 大小: octahedronSize²   (典型 1024²)
└─ 投影: octahedron 编码 — 直接保存于单张 2D 纹理, 单位球→正方形
         uv = OctahedronEncode(viewDir)
└─ 优势: 比 panoramic 极轴变形小, 高纬度像素利用率高
└─ 扩展: octahedronEnableSlicing 启用时, 把球面分 (octahedronSlicingCountX,
         octahedronSlicingCountY) 块, 每帧更新一块 → slicingIndex 累加
└─ 高度缩放: octahedronHeightScale, 让 viewDir.y 在编码前预乘以拉伸采样精度
```

`IsDirectionOutside(dir)` (`:4141`) 判定当前视向是否落在烘焙的 octahedron block 内，否则触发该 block force update。

#### 4.6.3 Semicircular — 半圆柱投影烘焙

```
m_FarCloudPanoramicColorRT
└─ 投影: 以 (semicircularForward, semicircularRight, semicircularUp) 三轴
         定义的"半圆柱体" — 横向 0..π (半圆), 纵向高度比例
└─ 优势: 只覆盖摄像机前向 180°, 像素全打在视野内, 比 panoramic 节省 50%+
└─ Reprojection 关键:
       semicircular{Forward, Right, Up}     = 当前帧基底
       _Semicircular{Prev,Prev2}{Forward,Right,Up} = 前 2 帧基底
       slicingIndex/slicingCount            = 分帧块
       _FarCloudSlicingPrevCenter / Prev2   = 历史中心
       _FarCloudReprojectLerpRatio / DeltaTimeScale = 时序权重

       reproj 公式:
         dir_prev = M_prev⁻¹ · dir_curr
         uv_prev  = SemicircularEncode(dir_prev, prev_basis)
         color_prev = sample(prev_RT, uv_prev)
         color_blend = lerp(traced_curr, color_prev, _FarCloudReprojectLerpRatio · deltaScale)
```

`UpdateSemicircularRT` (`:4244`) 是三种远云模式中 **HG 自研最复杂的**——三种"上一帧/上上一帧"基底用 `_FarCloudReprojectDeltaTimeScale / Scale2` 加权融合，目的是在玩家**自由 360° 旋转视野**时仍能保留远云时序累积（panoramic 旋转时基底变了所有缓存失效）。

#### 4.6.4 Far Cloud 分帧 (`EFarCloudFramingQuality`)

```
public enum EFarCloudFramingQuality
{
    None          = 0,         // 不分帧, 全帧 trace
    Checkerboard  = 1,         // 2x2 棋盘, 2 帧周期
    Quarter       = 2,         // 2x2 quarter, 4 帧周期
    Framing4x2    = 3,         // 4x2 = 8 帧周期
    Framing4x4    = 4,         // 4x4 = 16 帧周期
}
```

对应 4 个 keyword `s_FarCloudFramingCheckerboard / Quarter / 4x2 / 4x4`（None 不开 keyword）。`_FarCloudFrameCountMod{8,16,32,64,128}` 提供 5 种取模周期供 shader 选 pixel 偏移。

> **HDRP 对比**：HDRP `HDRenderPipeline.VolumetricCloudsAccumulation.cs` 是 1/4 分辨率 trace + 棋盘 + TAA 三件套组合，但**没有**单独的 "远云" 概念（视为天空一部分）。HG 把"远云独立分帧 + 离屏烘焙"作为一阶设计，是因为体积云资产是 **本地 SDF**——超出 SDF 包围盒之外的"天际背景层"需要单独管。

### 4.7 Wind Phase 累积（云朵分层运动）

`VolumetricCloudSDF.cs` 维护**三层风相位**：

```csharp
private Vector3 m_WindPhase,  m_WindPhase2,  m_WindPhase3;
private Vector3 m_WindOffset, m_WindOffset2, m_WindOffset3;
```

每帧由 `Update()` (`:2003`) 累加：

```
m_WindPhase{,2,3}  += Velocity · 0.5 · deltaTime
m_WindOffset{,2,3} = wrap(m_WindPhase{,2,3}, [0,1))
```

shader 端在采样 noise / SDF 之前对 uv 做：

```
uv_layer1 = uv + _WindOffset
uv_layer2 = uv · 2.3 + _WindOffset2          // 中频
uv_layer3 = uv · 5.7 + _WindOffset3          // 高频
```

三层频率差异让云朵看起来**前后景以不同速度漂移**（视差），加 `VolumetricWindField{Manager,Node}` 提供的**局部风场**叠加扰动。

### 4.8 Wind Field 三种几何 (`EWindFieldType`)

```csharp
public enum EWindFieldType { Directional=0, Circular=1, Vortex=2 }
```

每种**对 `FWindFieldData (5 × Vec4 = 0x50 字节)` 的 Param0..4 填充语义不同**：

| Type | Param0 | Param1 | Param2 | Param3 | Param4 |
|---|---|---|---|---|---|
| Directional | pos.xyz + radius | up.xyz · radius + 0 | type + windPhase 3 维 | 0 | 0 |
| Circular | pos.xyz + radius | up.xyz · radius | type + circularPhase + circularOffset | rotateSpeed | 0 |
| Vortex | pos.xyz + radius | up.xyz · radius | type + blend + skew | ringSpeeds[4] | ringPhases[4] |

shader 端按 `Param2.x` (type) 走 if/else，本质上是"在世界空间给一个偏移向量" → 加进 march 采样 uv。

---

## 5. 局部雾 — SPMD Burst SoA 6 平面剔除 + MRT 注入

**HDRP 对比**：HDRP `LocalVolumetricFog` 用 `OrientedBBox` + 直接遍历 visibility list → `DrawProceduralIndirect` 把每个 fog volume 当 mesh 绘制到 `_VBufferDensity`（每个 fog 一个 draw call）。

**HG delta**：HG 把整个剔除做成 **Burst job + SoA NativeList** 一次性算完所有可见 fog volume，再用**一个**全屏 quad mesh + MaterialPropertyBlock 一次性 MRT 写所有 froxel slice。性能上 CPU 端剔除 SIMD‑friendly，GPU 端少 N 次 draw call。

```csharp
// HGVolumetricLocalFogManager.cs:11-220
public class SPMDCullingNativeInout : IDisposable
{
    public NativeList<float> centerXs, centerYs, centerZs;        // 中心 SoA
    public NativeList<float> extentXs, extentYs, extentZs;        // 半幅 SoA (AABB)
    public NativeList<int>   visibility;                          // 输出: 0/1

    public void Add(Bounds b);                                     // :86 加入一个 fog
    public void RemoveAtSwapBack(int idx);                         // :190 swap-back O(1) 删除
    public void UpdateLocalFogTransform(List<HGVolumetricLocalFog> list); // :262 transform 变化重算
    public NativeList<int> VolumetricLocalFogCulling(Matrix4x4 cullingMatrix, int cameraGuid); // :422
}
```

`VolumetricLocalFogCulling` Burst job 内部按 8 个一组 (AVX2 256‑bit) SIMD：

```
for chunk of 8 in [N]:
    cx, cy, cz = load8(centerXs[chunk..], ...)
    ex, ey, ez = load8(extentXs[chunk..], ...)
    for plane p in 6 view frustum planes:
        d = p.normal · (cx, cy, cz) + p.distance
        e = |p.normal.x|·ex + |p.normal.y|·ey + |p.normal.z|·ez
        outside[chunk..] |= (d < -e)      # signed-AABB-plane test
    visibility[chunk..] = !outside[chunk..]
```

→ 6 平面 × 8 个 fog × SIMD = O(N/8) cycle，**典型 1024 个 fog 不到 0.1ms**。

输出 `visible_indices: NativeList<int>` 进一步用作：

1. **MRT voxelization pass** (`HGVolumetricFogRenderer.RenderVolumetricFogVoxelization`) 的 instancing 数 — `Graphics.DrawMeshInstancedProcedural` per‑instance index 索引到 `_LocalFogParamsBuffer` (ComputeBuffer of fog params + materials)；
2. shader 的 Geometry Shader / multiple SV_RenderTargetArrayIndex 把每个 slice 写出 → 整个 VBufferA `(x,y,z=slice)` 三维 splat 在一次 draw 内完成。

> 移动端裁剪：在 quality tier=low 时 `HGVolumetricLocalFogManager.instance == null`，整个 voxelization pass 跳过——单光 fog 路径无 local fog，节省整段 culling+voxelization 开销。

---

## 6. 风场 / 本地光 / SDF Modifier — 统一上传通道模式

三者结构高度同构 (manager + per‑frame buffer 上传)，差别只在缓冲类型：

| 子系统 | Data struct | Size | 缓冲类型 | shader 入口 |
|---|---|---|---|---|
| VolumetricLocalLight | `FLocalLightData` | 0x50 (5 Vec4) | `ComputeBuffer` (StructuredBuffer) | `_LocalLightList`, `_LocalLightNum` |
| VolumetricSDFModifier | `FModifierData` | 0x30 (3 Vec4) | `ComputeBuffer` (StructuredBuffer) | `_ModifierList`, `_ModifierNum` |
| VolumetricWindField | `FWindFieldData` | 0x50 (5 Vec4) | `CBHandle` (constant buffer) | `_WindFieldDataCB`, `_WindFieldNum` |

**为什么 WindField 用 ConstantBuffer 而不是 ComputeBuffer**：风场数量小（典型 < 32），每帧值变化大，**ConstantBuffer 在 Mali/Adreno 上读取延迟最低**（uniform branch 命中率高）。LocalLight/Modifier 数量可达数百，且**数据在 ComputeBuffer 复用 N 帧**只在变化时上传 → 适合 StructuredBuffer。

**Modifier 的 SDF 操作**：

```csharp
public enum EModifierMode  { SDF=0, Density=1, Albedo=2 }
public enum ESdfOperation  { Subtract=0, Union=1, Intersect=2 }
```

shader 端在 march 时对每个体素 query：

```
for modifier in _ModifierList:
    d_mod = SphereSDF(modifier.Position, modifier.Radius, pos)
    if modifier.Mode == SDF:
        d_cloud = Combine(d_cloud, d_mod, modifier.Operation)
        # Subtract: max(d_cloud, -d_mod)
        # Union:    min(d_cloud, d_mod)
        # Intersect:max(d_cloud, d_mod)
    elif modifier.Mode == Density:
        density *= 1 + (modifier.Payload.x - 1) · pow(falloff(d_mod), modifier.FalloffExp)
    elif modifier.Mode == Albedo:
        albedo  = lerp(albedo, modifier.Payload.xyz, falloff(d_mod))
```

→ 在云体上"挖洞 / 抠形状 / 染色"——典型用法：剧情中让一片云出现 logo 形状或随玩家移动散开。

---

## 7. 预烘焙 — Multiple Scattering LUT + SH Sample Buffer

### 7.1 `VolumetricMSBake` — 多次散射 2D LUT

物理目标：积分 N 阶多次散射的解析近似 (Wrenninge 2014 / Frostbite 2016)。

```
L_ms(cosθ) ≈ Σ (a^n) · HG(cosθ, b^n · g_forward) + (a^n) · HG(cosθ, -c^n · g_backward)
          n=0..N-1
   a = MsScatteringFactor   (典型 0.5)
   b = MsExtinctionFactor   (典型 0.5, g 衰减)
   c = MsPhaseFactor        (典型 0.5)
   N = MsOctaveCount        (典型 3, HDRP :157-169 也是 3)
```

LUT 维度：`(_msBakeSizeX × _msBakeSizeY)` = (cosθ × density?或 opticalDepth)，每帧只在**参数变化时**重烘：

```csharp
public struct FMSArgs : IEquatable<FMSArgs>
{
    public float   m_Phase, m_Phase2, m_PhaseBlend;
    public int     m_MsOctaveCount;
    public float   m_MssFactor, m_MseFactor, m_MspFactor;
    public float   m_OpticalDepthScale;
    public Vector4 m_EncodeParams;
    [IDTag(0)] public bool Equals(FMSArgs other);                  // :31 — IFix 入口
}

private RenderTexture _msTexture;        // 2D LUT, 复用
private FMSArgs       m_MsArgs;          // 缓存键

BakeMSTexture(cmd, sizeX, sizeY, msArgs, cloudMat, force=false):
    if (msArgs != m_MsArgs || force):
        Blit(_msTexture, cloudMat, MSBakePass)
        m_MsArgs = msArgs
    SetEncodedTexture(_MSTex, _msTexture)
```

`[IDTag(0)] Equals` 是 IFix 给 `Equals` 标的入口 ID，确保**值比较稳定** (不被 hot patch 改成引用比较) → 缓存命中率高 = 不重烘。

### 7.2 `VolumetricSHBake` — 球面 SH 系数表

物理目标：把"环境光对体积散射的贡献" 用 L1 球面谐波近似，shader 内 1 次查表代替 N 次 ambient probe 查询。

```csharp
public struct FSHSampleData
{
    public Vector4 Direction;     // (x, y, z, ?)
    public Vector4 SHValue;       // L0 + L1 = 4 系数 (Y₀⁰, Y₁⁻¹, Y₁⁰, Y₁¹)
}

GenerateSphereSamples(NumThetaSteps, NumPhiSteps):           # :21 — 均匀球面网格
    for i in 0..NumThetaSteps:
        for j in 0..NumPhiSteps:
            θ = acos(1 - 2 · (i + 0.5) / NumThetaSteps)        # 余弦均匀
            φ = 2π · (j + 0.5) / NumPhiSteps
            dir = (sin θ · cos φ, sin θ · sin φ, cos θ)
            sampleDirs.Add(dir)

SetupSphericalSamples(sampleDirs):                            # :182 — L1 SH 系数
    for dir in sampleDirs:
        Y₀⁰  = 0.5 · √(1/π)
        Y₁⁻¹ = √(3/(4π)) · y
        Y₁⁰  = √(3/(4π)) · z
        Y₁¹  = √(3/(4π)) · x
        shValues.Add(Vector4(Y₁⁻¹, Y₁⁰, Y₁¹, Y₀⁰))

BuildSHSampleBuffer(NumThetaSteps, NumPhiSteps):              # :285
    SHBuffer = new ComputeBuffer(NumThetaSteps * NumPhiSteps, sizeof(FSHSampleData))
    SHBuffer.SetData(setupSphericalSamples(...))
```

shader 端用：

```
ambient_volumetric(cloud_pos):
    n_estimated = normalized gradient of density
    sh_sample = sample(_SHTex, cloud_pos)                # 3D 纹理: per-voxel SH 系数
    L_amb = SH_dot(sh_sample, n_estimated)               # L1 evaluation
    return L_amb
```

`_SHSampleBuffer` 是**采样方向 + 系数**，`_SHTex` 是**体素 → SH 系数**的纹理。HG 把"采样表"做成单例 ComputeBuffer（**全游戏共享**），把"体素系数"作为云资产 (`SdfTexs[2]`) 离线烘焙，运行时只查不算。

> 注：HDRP `EvaluateVolumetricAmbientProbe` (`VolumetricLighting.compute:90-106`) 用 7 个 SH9 系数从 `_VolumetricAmbientProbeBuffer` 取，但**对整个场景一个 probe**——HG 是 per‑voxel SH，**保真度更高但内存更大**，所以仅用于体积云（雾仍走 APV）。

---

## 8. RT 生命周期 — `VolumetricPipelineRT` ping‑pong 拓扑

```csharp
public enum RTLifeCycle { Transient = 0, Frame = 1, Persist = 2 }
```

| 生命 | 行为 | 何时用 |
|---|---|---|
| Transient | 从临时池借用，pass 结束归还 | Reconstruct / TAA Color | (HDRP RenderGraph 同等概念) |
| Frame | **抛 NotImplementedException** — 路径预留 | (HG 留口子但未启用) |
| Persist | 持有 RenderTexture 引用，跨帧复用 | History buffer (TAA prev) / Framing accumulator |

`VolumetricRenderer` 持有的 ping‑pong RT 数组：

```
m_ReconstructColors[2], m_ReconstructDepths[2]   ping-pong index = m_ReconstructIndex
m_TAAColors[2],         m_TAADepths[2]            ping-pong index = m_TAAIndex
m_MinMaxWorldDepths[2]                            前后帧深度分析
```

每帧 `UpdateVolumetricRTs(inputs)` 调用 `VolumetricSDFUtils.CreatePipelineRTIfNeeded`：

- 如 desc (w/h/format) 没变 → 复用既有 RT；
- 如尺寸变了 → Release 旧 RT、按新 desc 创建；
- 持久 (Persist) RT 在 `Release(full=true)` 调用前一直驻留。

`UpdateDownResParameters / UpdateDownResRender` (`VolumetricRenderer.cs:10071/10509`) 控制低分辨率渲染：`downResRatio` 把屏幕除以 1/2/4 形成 `m_RenderWidth/Height`，`upscaleFilter` 选 `Bilateral / Nearest / Noisy / DepthFade` 4 种回升采样，写 `_DownscaleRatio / _DownscaleScreenParams / _NDCRescaleRatio`。

---

## 9. 假面片雾 (`FakeFogSimple`) — 完全独立通路

> 这是为**便宜远景体积感**做的"假体积"——本质是一张 MeshRenderer + 自定义 shader，**不进** froxel/march 流水线。
> 视觉上是"漂浮的雾片"，比如远山下方一带白雾。常驻在场景里，只做距离 fade + 噪声扰动 + 太阳光照采样。

关键设计点：

1. **共享/独立材质二态**：`_instanceMaterial` + `_matIsSaved` 控制是否复制材质；编辑器 `onManualMaterialChange` 回调让美术改料后自动 push。
2. **路径常量** (`FakeFogSimple.cs`)：
   ```
   FOG_MAT_FOLDER_PATH = "Assets/Beyond/Arts/Environment/LightingEnv/FogSimple/Material"
   FOG_DEFAULT_MAT_NAME = "M_fog_simple_default.mat"
   ```
   编辑器流程自动按此路径找默认材质。
3. **42 参数 (`FogSimpleConfig`)** 涵盖：Culling / Distance / Render / Base color / Noise / Wind / Lighting / Fresnel / TopFade / SoftBlend / Fog ——每组对应 `FogSimpleShaderProperties` 的 `PropertyToID` 缓存 + 1 或 2 个 keyword。
4. **`fogTypeIsStreaming` / `FarScene`** 两个枚举决定剔除距离 (`DEFAULT_STREAMING_CULLING_DIS = 512f`) 与 fade 起点。

由于不进 VBuffer，本系统**不受 froxel grid 分辨率影响**，所以适合**广覆盖、低频率细节、几乎无动态**的场景元素。

---

## 10. 1:1 重建蓝图（按子系统分步）

### 10.1 重建 Volumetric Fog (前置: 已有 HDRP fork 或自研管线)

1. **抽 HDRP 算法骨架**：
   - 拷贝 `VolumetricLighting.compute` (782 行) 三个核心函数：`FillVolumetricLightingBuffer`、`EvaluateVoxelLightingDirectional`、`EvaluateVoxelLightingLocal`、`SampleVBuffer`、`ImportanceSampleHomogeneousMedium`、`TransmittanceIntegralHomogeneousMedium`、`LinearizeRGBD/DelinearizeRGBD`。
   - 拷贝 `VBuffer.hlsl` `SampleVBuffer` (biquadratic + clamp‑to‑border) + 三签名重载。
   - 拷贝 `ComputeLogarithmicDepthEncodingParams / DecodingParams` 两个 Vector4 数学。
2. **复刻 C# 调用入口**（HG 命名）：
   - `HGVolumetricFogRenderer` 三方法 (`ComputeVolumetricFogGridInjection / RenderVolumetricFogVoxelization / ComputeVolumetricFogLightScattering / ComputeVolumetricFogFinalIntegration`)。
   - `HGVolumetricFogUtils.GetVolumetricFogGridZParams` 3 元组压缩：`A=n-1/c, B=1/c, C=c(f-n)+1`。
   - `VolumetricFogPassConstructor.ComputeVolumetricFogPassData` (≈20 字段) 一次性持有 3 CS 引用 + 3 RT + jitter 数组。
3. **64 浮点 Halton/Hammersley 序列**生成：参考 HDRP `m_xySeq / m_zSeq`，扩到 16 帧 = 16 Vec4。`VolumetricFogTemporalRandom(frameNumber)` 取模映射。
4. **PunctualLightShadow atlas**：在主阴影 pass 后多输出一张 atlas，体积雾内只 sample 不 march。
5. **常量打包验证**：`VolumetricFogLightScatteringConstants` 9 组 `_VolumetricFogLightScatteringParams0..8` 与 `HGVolumetricFogConfigCPP` 15 字段映射需逐字段对齐到 .hlsl 的 `cbuffer ShaderVariablesGlobal`（HDRP 写法在 `ShaderVariablesVolumetric` struct）。
6. **Flow Noise 注入**：`flowVLNoise*` 6 字段 → shader 端 `uv_distorted = uv + flowMap(uv) · time` → 扰动 density / scattering。

### 10.2 重建 Volumetric Cloud

1. **基础 march 算法** 完全照 HDRP `TraceVolumetricRay`：
   - Frostbite 分析式积分公式 (§4.3.1)；
   - 双 HG phase + Powder + Sun transmittance；
   - "EMPTY_STEPS_BEFORE_LARGE_STEPS" 计数器加速（HDRP 用 8）→ HG 升级成 SDF Sphere Tracing (§4.4)。
2. **SDF 资产管线**：
   - `VolumetricSdfAsset.SdfTexs[3]` 烘焙：`[0]=Density, [1]=Advanced (normal + MS), [2]=SH`；
   - `VolumetricEncodedTexture` 压缩：ASTC4x4 / ASTC8x8 减小内存（移动端必须）；
   - 异步加载 `LoadAssetsAsync` + `LoadFinished` 状态查询 + 进入 / 离开 Volume Fade (`VolumetricCloudVolumeManager` `FADE_TIME=2f`)。
3. **5‑Stage 流水线骨架**：
   - `VolumetricRenderStage` 抽象 + 4 具体类 + Dictionary 路由；
   - `VolumetricRenderNode` 池化复用 + `NodeCompare` 四级排序；
   - `Process(VolumetricCallbackContext)` 由 `IVolumetricRenderObject.OverrideFraming/TemporalCompose` 提供；
   - `m_CanMergeTAAPass` + 4 个 `s_MergeTAAPass*` keyword 决定合并。
4. **Empty‑Skip RT**：低分辨率 3D SDF 距离场 → shader Sphere Tracing 跳跃。
5. **MS LUT + SH 表预烘焙**：`VolumetricMSBake`、`VolumetricSHBake` — 见 §7。
6. **Far Cloud 三模式**：
   - `Panoramic` 最简单：每帧 trace 全 RT；
   - `Octahedron` 加 slicing 分块更新；
   - `Semicircular` 最复杂：3 轴 reproject，**确保 prev / prev2 basis 都跟踪**。
7. **Wind 三层 + WindField 三类型**：`Velocity · 0.5 · dt` 累积相位 wrap。

### 10.3 重建 Local Fog

1. `HGVolumetricLocalFog` MonoBehaviour + `[ExecuteAlways]` 注册 / 注销；
2. `SPMDCullingNativeInout`: SoA NativeList 6 字段 + visibility，Burst job：
   - **AABB‑plane** 6 平面剔除 (signed distance + extent dot)；
   - 8 元素一组 SIMD；
3. `RenderVolumetricFogVoxelization` MRT pass：`Graphics.DrawMeshInstancedProcedural` per‑instance 索引到 `_LocalFogParamsBuffer`，shader 用 Geometry Shader / RT array index 把每个 fog volume splat 到全部相关 slice。

### 10.4 重建 Wind Field / Local Light / Modifier

镜像设计，差别只在 ConstantBuffer vs StructuredBuffer：

```csharp
class XxxManager {
    private List<XxxComponent>    list;
    private FXxxData[]            dataList;
    private ComputeBuffer/CBHandle buf;
    public void Tick() {              // 每帧
        for c in list: dataList[i++] = c.GetData();
        buf.SetData(dataList);
    }
    public void Add/Remove(c) { list.Add/Remove(c); MarkDirty(); }
}
```

### 10.5 关键工程难点

| 难点 | 解 |
|---|---|
| `_VolumetricFogParams*` 与 `cbuffer ShaderVariablesGlobal` 对齐 | 通过 `[StructLayout(Sequential)]` + 编译期 size 检查 + .hlsl 端 `#pragma static_assert` |
| Halton 64 元素抖动序列与 shader 索引一致 | `[FixedAddressValueType]` + 序列化时按 Vec4 块对齐 |
| Far Cloud Semicircular 3 轴 reproject 数学 | 保 prev / prev2 basis transform，**先反投到 prev → 再投到 cur** 用矩阵链积 |
| `[IDTag(0)] Equals` IFix 入口 | C# 端需自定义 IFix-aware 哈希；非 IFix 平台直接走 `IEquatable<T>` |
| SPMD culling SIMD 友好布局 | 严格 SoA + `Unity.Mathematics.float4 / int4` + `[BurstCompile]` |
| `m_CanMergeTAAPass` 合并条件判断 | `HasOffScreenPassBefore` 在 `VolumetricRenderer.cs:8579`，需 graph 节点遍历 |
| ECS / Streaming 注入风场 | 提供 `VolumetricWindFieldNode` POCO（非 MonoBehaviour），让 streaming/ECS 直接 `AddWindFieldNode` 即可 |
| 远云 vs 近云 LOD 判定 | 用 `DISABLE_FAR_CLOUD_SHADER_LOD = 600` 在 shader LOD < 600 时禁用远云分支（低端硬件全部走 panoramic 简化） |
| 移动端关闭体积雾完整路径 | `HGVolumetricFogRenderer.supportVolumetricFog => false`（quality tier），整个 PassConstructor 进 `ConstructSkipRender` 路径 |

---

## 11. 附录：源文件清单 (46)

> 每行 ≤ 1 句职责，按本文目录顺序分组；与 [§14 老版附录](.) 数据一致但语义概括。

| # | 文件 | 主要职责 |
|---|---|---|
| **配置层 (IEnvConfig)** ||
| 1 | `HGFogConfig.cs` | 大气雾配置 (Mie/Rayleigh + 距离起始/衰减) |
| 2 | `HGHeightFogConfig.cs` | 高度雾 + 旧式体积雾 (legacy) 33 字段 |
| 3 | `HGVolumetricFogConfig.cs` | 独立体积雾配置 (47+9 字段) + 双流动噪声 |
| 4 | `HGCloudConfig.cs` | 2D 天空云配置 (非体积云) |
| 5 | `HGVolumetricCloudConfig.cs` | 体积云总开关 (单 bool) |
| 6 | `HGVolumetricCloudSettingParameters.cs` | 体积云质量参数 41 SettingParameter (down-res/framing/TAA/march/far-cloud) |
| 7 | `HGVolumetricComposeData.cs` | 合成 CB (_VolumetricZBufferParam/ZEncodeParam/_VolumeMatVP) |
| **体积雾 (Froxel)** ||
| 8 | `HGVolumetricFogRenderer.cs` | Froxel 三阶段渲染器 + 嵌套 Settings + 2 CB struct (含 64 jitter) |
| 9 | `HGVolumetricFogUtils.cs` | DivideAndRoundUp / 临时 RT / 黑色 3D 占位 |
| 10 | `VolumetricFogPassConstructor.cs` | IPassConstructor 装配 3 CS + RT |
| **体积云核心** ||
| 11 | `VolumetricRenderer.cs` | 体积云主渲染器 (5-Stage 拓扑 / Compose 缓存 / RT ping-pong / Pass merge) |
| 12 | `VolumetricRenderInputs.cs` | 渲染输入聚合 (camera / scene tex / parameters / objects) |
| 13 | `VolumetricCloudPassConstructor.cs` | IPassConstructor (ShouldRender + ConstructPass) |
| 14 | `VolumetricRenderObject.cs` | IVolumetricRenderObject 抽象 MonoBehaviour 基类 |
| 15 | `IVolumetricRenderObject.cs` | 接口: Prepare/Pre/Post/Override/Collect/OnUpdateMaterial |
| 16 | `IVolumetricCloudVolume.cs` | 接口: priority/Contains/Visibility/Fade/PrepareAssets |
| 17 | `VolumetricCloudSDF.cs` | 主体积云组件 (SDF march 入口 + per-camera FarRenderer dict) |
| 18 | `VolumetricCloudVolumeManager.cs` | 每相机 fade 状态机 (FADE_TIME=2f) |
| 19 | `VolumetricManager.cs` | 全局注册/注销 IVolumetricRenderObject |
| **远云** ||
| 20 | `VolumetricFarCloudRenderer.cs` | 三模式远云 (Panoramic / Octahedron / Semicircular) + 4 档分帧 |
| **风场** ||
| 21 | `IVolumetricWindField.cs` | 接口: GetWindFieldData() |
| 22 | `VolumetricWindField.cs` | MonoBehaviour 风场 (10 字段 + 3 type) |
| 23 | `VolumetricWindFieldNode.cs` | POCO 同结构 (ECS / streaming 注入) |
| 24 | `VolumetricWindFieldManager.cs` | 风场管理 + CBHandle 上传 |
| **局部光 / Modifier** ||
| 25 | `VolumetricLocalLight.cs` | MonoBehaviour 局部光 (12 字段, 0x50) |
| 26 | `VolumetricLocalLightManager.cs` | StructuredBuffer 上传 |
| 27 | `VolumetricSDFModifier.cs` | MonoBehaviour SDF/Density/Albedo 修改器 (0x30) |
| 28 | `VolumetricModifierManager.cs` | StructuredBuffer 上传 (与 LocalLightManager 镜像) |
| **局部雾** ||
| 29 | `HGVolumetricLocalFog.cs` | MonoBehaviour 局部雾 (+ Material 引用) |
| 30 | `HGVolumetricLocalFogManager.cs` | 单例 + SPMD Burst SoA 6 平面剔除 |
| **预烘焙** ||
| 31 | `VolumetricMSBake.cs` | MS 多次散射 LUT (FMSArgs IEquatable 缓存键) |
| 32 | `VolumetricSHBake.cs` | SH 球面采样 (单例 ComputeBuffer) |
| **资源 / RT 工具** ||
| 33 | `VolumetricPipelineRT.cs` | RT 包装 + RTLifeCycle (Transient/Persist) |
| 34 | `VolumetricSDFUtils.cs` | 67 个静态工具 (Mesh 池 / Blit / RT / Keyword 切换 / MainLightDir) |
| 35 | `VolumetricSdfAsset.cs` | ScriptableObject (SdfTexs[3] + Bounds + Payload) |
| 36 | `VolumetricEncodedTexture.cs` | 编码纹理 (Tex + RangeBase/Scale + PropertyIDPack 缓存) |
| 37 | `VolumetricCustomShadow.cs` | MonoBehaviour marker (无字段, 行为在原生层) |
| **假面片雾** ||
| 38 | `FakeFogSimple.cs` | MonoBehaviour 假体积 (路径常量 + 共享/独立 material) |
| 39 | `FogSimpleConfig.cs` | 假体积配置 (42 字段 + 3 子枚举) |
| 40 | `FogSimpleShaderProperties.cs` | shader id/keyword 表 (43 个 ID + 3 keyword) |
| **ShaderID / Keyword 总表** ||
| 41 | `VolumetricShaderIDs.cs` | 220+ static readonly int (cctor 注册全部 `_*` 属性 ID) |
| 42 | `VolumetricShaderKeywords.cs` | 38 个 keyword 字符串 + 1 GlobalKeyword `s_ComposeVolumetric` |
| **枚举** ||
| 43 | `EVolumetricStage.cs` | Framing/BeforeTemporal/Temporal/AfterTemporal/SceneCompose |
| 44 | `EVolumetricState.cs` | EMPTY/FADE_OUT/FADE_IN/STATIC (per-camera 状态机) |
| 45 | `EFarCloudFramingQuality.cs` | None/Checkerboard/Quarter/4x2/4x4 (5 档远云分帧) |
| 46 | `TerrainV2/EFakeVolumeMode.cs` | TwoLayers/TwoLayersCSM/ThreeLayers (Terrain 假体积分层数) |

---

## 12. 关键常量 / 魔数 (一处汇总)

| 来源 | 常量 | 取值 | 含义 |
|---|---|---|---|
| HDRP `VolumetricLighting.compute:28` | `VBUFFER_VOXEL_SIZE` | 8 | froxel 边长 (像素) |
| HDRP `:32` | `GROUP_SIZE_1D` | 8 | 线程组 1D 尺寸 (X = Y) |
| HDRP `VolumetricLightingFiltering.compute:32` | `GAUSSIAN_SIGMA` | 1.0 | 3×3 平滑高斯 σ |
| HDRP `:33-37` | `GROUP_SIZE_1D_XY/Z`, `FILTER_SIZE_1D` | 8 / 1 / 10 | 滤波线程组 + LDS 边界 |
| HDRP `HDRenderPipeline.VolumetricLighting.cs:310` | `k_MaxVisibleLocalVolumetricFogCount` | 1024 | 单帧可见 Local Fog 上限 |
| HDRP `:315` | `k_VolumetricFogPriorityMaxValue` | 1048576 (2²⁰) | sort key 优先级位宽 |
| HDRP `:348` | `m_zSeq` 长度 | 7 | 时间累积窗口 |
| HG `HGVolumetricFogRenderer.cs:62` | `_LightScatteringFrameJitterOffsets` 长度 | 64 (16 Vec4) | HG 加宽抖动序列 |
| HG `VolumetricCloudVolumeManager.cs:21` | `FADE_TIME` | 2.0f | Volume 进/出 fade 时长 |
| HG `VolumetricCloudSDF.cs:97` | `DISABLE_FAR_CLOUD_SHADER_LOD` | 600 | LOD<600 关远云 |
| HG `VolumetricSDFUtils.cs:8-9` | `MAX_DEPTH`, `DEPTH_BITS` | 10000f, 24 | 深度上限/位深 |
| HG `VolumetricSDFUtils.cs:10-11` | `MIN/MAX_OPTICAL_DEPTH` | 0.01f / 100f | 透射率截断 |
| HG `VolumetricWindField.cs:7` | `MAX_RING_NUM` | 4 | Vortex 风场 ring 数 |
| HG `FakeFogSimple.cs` | `DEFAULT_STREAMING_CULLING_DIS` | 512f | 假面片雾流式剔除距离 |
| HG `FogSimpleConfig.cs:6` | `DISTANCE_FADE_MIN` | 0.001f | 距离 fade 最小 |
| HG (反汇编据 HGEnvironmentUtils 调用) | `op_Approximately` 阈值 | 1e-6 (≈ `g_18C47142C`) | 浮点近似比较 |

---

## 13. 已知未决项 (HDRP 反向核对优先级)

> 这些是**结构无法独自定**的细节，需要从对应 .shader / .hlsl 反向核对：

- [ ] `_VolumetricFogLightScatteringParams0..8` 9 组每个 Vec4 的精确字段语义 (`HGVolumetricFogConfigCPP` 15 字段映射到 36 浮点的具体打包顺序)。
- [ ] `_VolumetricZBufferParam`/`_VolumetricZEncodeParam` 是否就是 HDRP 的 `(A, B, C, 0)` 4 元组——`UpdateVolumetricCameraVP` (`VolumetricRenderer.cs:9323`) 写入,但 shader 反编码公式需 hlsl 确认。
- [ ] `UpdateSemicircularRT` 三轴 reproject 的具体矩阵链积形式 (prev/prev2 basis 与 slicingCount 如何加权)。
- [ ] `VolumetricMSBake.FMSArgs.GetHashCode` 是否有 epsilon 量化以保证缓存稳定 (反汇编 `System.HashCode` 路径可见但量化阈值不可读)。
- [ ] `s_MV_MODES[]` (VolumetricSDFUtils `:2722`) 4 个 MV mode 的具体语义 (推断为 None/Camera/PerObject/Full)。
- [ ] `EFramingQuality` 仅 2 值 (Checkerboard/Quarter), `EFarCloudFramingQuality` 5 值 ——`s_FarCloudFraming{4x2,4x4,Quarter,Checkerboard}` 4 个 keyword 与之 1:1, **剩 None 不开 keyword** (推断, 需运行时确认)。
- [ ] `VolumetricCustomShadow` 在原生侧如何被发现 (GetComponentInChildren? GameObject layer?) ——源未定位, 仅可观察其为空 MonoBehaviour marker。

> 这些**不影响**核心算法蓝图的完整性 — 复刻时按 HDRP 同源逻辑实现即可, 待样品场景跑通后用 RenderDoc/PIX 反向核对常量打包顺序。
