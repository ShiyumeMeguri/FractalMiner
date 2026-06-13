# HG Render Pipeline — Environment / Sky / Atmosphere (环境 · 天空 · 大气 · 天体) 技术实现原理蓝图

> 本文是 **从零重建** 终末地 (EndField) HG.RenderPipelines 环境系统的实现蓝图。
> 大气散射 (Rayleigh + Mie + Ozone + Multi-Scattering + Aerial-Perspective LUT) 的核心算法是 **HDRP fork 血缘**(`com.unity.render-pipelines.high-definition@75de48326bcd/Runtime/Sky/PhysicallyBasedSky/*` — Bruneton 1999 + Hillaire 2020 EGSR 现代化实现): 故 LUT 4D 参数化 / Chapman 函数 / 各向异性相函数 / 多次散射近似 / 4D 大气 LUT 编码 等算法**直接据 HDRP 真实源**讲清; HG 反编译 C# 仅用来定位 **HG 的 delta**: 21 子-config 聚合的 **环境 Phase**、`s_interpolatedPhase` 静态广播 (GpuCloth/Volumetric/Cloud 读取)、Volume Priority 排序混合、Distance/Time/Manual 三种 fade 模式、Animated Volume Timeline driven phase、双星球 + 月亮 + 高精度星球的 Celestial 系统、3 RGB 密度层 + 星云的星空、HG 削减的天体大气 (10/10 采样固定值)。
>
> 配套已有文档 (不复述、只链):
> - 算法概览 (大气散射): [`../02-CoreAlgorithms/01-CoreAlgorithms.md`](../02-CoreAlgorithms/01-CoreAlgorithms.md) §12
> - C++ Config blittable 结构 (环境 phase 中转): [`../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md`](../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md) §4 (HGEnvironmentPhaseCPP, HGSkyConfigCPP, HGAtmosphereConfigCPP, HGCelestialConfigCPP, HGStarConfigCPP)
> - 体积雾 / 体积云 (从 Atmosphere LUT 读 transmittance): [`./05-Volumetric.md`](./05-Volumetric.md) §3 / §4 / §7
> - GI / SH (Sky → IrradianceVolume 烘焙输入): [`./09-GI-IrradianceSH.md`](./09-GI-IrradianceSH.md)
> - 阴影 (CameraSpace 大气 LUT 采样 cascade): [`./07-ShadowASM.md`](./07-ShadowASM.md)

---

## 0. 目录

| § | 主题 |
|---|------|
| 1 | 解决什么渲染问题 / 视觉目标 |
| 2 | 总体拓扑 + HDRP 血缘对照 + 数据流 |
| 3 | Environment Phase: 21 子-config 聚合 + 静态广播 |
| 4 | Environment Volume: 优先级排序 / Distance · Time · Manual 三种混合 |
| 5 | LerpConfig`<T>`: 类型化插值、t==0 / t>=1−ε 快路径 |
| 6 | Animated Environment Volume: Timeline driven phase |
| 7 | 大气散射: 4 LUT 体系 (Transmittance / MultiScattered / SkyView / Aerial-Perspective Fog) — HDRP 同源算法 |
| 8 | Bruneton 数学全集: 光学深度 Chapman / Rayleigh / Mie Cornette-Shanks / Ozone tent / 球面相交 |
| 9 | LUT 4D 参数化 (Yusov 球面坐标 ↔ texCoord) + 4D → "deep 3D" 编码 |
| 10 | SkyRenderer: ProceduralSky vs Skybox + Sun Disc + Reflection / Ambient SH |
| 11 | Celestial: 双星 (Talos α + Planet) + 月亮 + 高精度星球 + 星环 + 行星大气 |
| 12 | Star: 3 RGB 密度层 + 噪声/Baked Map + 星云遮蔽 |
| 13 | 关键常量 / 魔数总表 (HDRP 行号 + HG 反编译来源) |
| 14 | 1:1 复刻蓝图 (分步) |
| 15 | 源文件清单 (20 个 HG `.cs` + 6 个 HDRP 引用源, 每个一行职责) |

---

## 1. 解决什么渲染问题 / 视觉目标

**开放世界 + 风格化场景需要在一套环境表达里同时调动的视觉效果:**

| 视觉效果 | 子系统 | 关键质感 |
|---------|-------|---------|
| 物理正确的天空颜色 (蓝/橙/紫渐变 + 地平线霾) | `HGAtmosphereConfig` + 4 LUT + procedural sky | 看 Rayleigh 蓝/夕阳橙、看 ozone 紫、Tent 拐点压住地平线 |
| 距离参与雾 (远山蓝雾 / 距离蒙版) | Atmosphere LUT (Aerial-Perspective) → 透明 / 不透明 forward 重采样 | 与体积雾在数学上一致, 但廉价 (查 3D LUT 而不是 froxel march) |
| 太阳本体 + 光晕 (Sun disc + flare) | `HGSkyConfig.sunDisc*` + Celestial flare 系统 | 软边圆盘 + Gauss falloff, HDR 亮度 |
| 月亮 / 双星 / 星环 / 高精度星球 | `HGCelestialConfig` (moon/talosAlpha/planet/advanced) | 星球绕轨道、自转倾角、贴图/模拟两种绘制、行星大气、星环 |
| 星空 (Milky Way + 闪烁星点 + 星云) | `HGStarConfig` (3 RGB density layer + nebula) | RGB 三层 tiling 不同的星点、噪声闪烁、星云遮蔽 |
| 区域氛围切换 (室内→室外 / 黄昏→夜) | `HGEnvironmentVolume` + Phase + Lerp | 平滑 distance fade-in/fade-out / Timeline driven animation |

**所有这些视觉的"风格化调色板"集中在一个 `HGEnvironmentPhase` ScriptableObject 里**, 通过区域 Volume 优先级**插值合成**一个 *Interpolated Phase*。该 phase 被静态广播 `HGEnvironmentManager.s_interpolatedPhase`,**让管线里所有需要环境量的子系统 (天空、大气、雾、云、风、阴影、后处理 ColorGrading、AutoExposure、GpuCloth (读风)) 共享同一个真值**。

---

## 2. 总体拓扑 + HDRP 血缘对照 + 数据流

```
              Scene (Editor 摆放)
              ┌─────────────────────────────────────────┐
              │  HGEnvironmentVolume (priority Q)        │  Q 越小, 优先级越高
              │  ├── Global / Box / Sphere / PolyArea / Cylinder
              │  ├── BlendMode = None / Distance / Time / Manual
              │  ├── BlendDistance ∈ [1, 200] m (Exp)
              │  ├── FadeIn / FadeOut ∈ [0, 20] s
              │  └── envPhase  ──▶  HGEnvironmentPhase asset
              │                       (or AnimatedEnvVolume → inline 21 configs)
              └─────────────────────────────────────────┘
                              │
                  +───── Register / Unregister
                  │
                  ▼
              HGEnvironmentManager  (单例; HGEnvironmentManager.cs:9-67)
              ├── activeVolumes : HashSet<HGEnvironmentVolume>           (注册集)
              ├── sortedVolumes : List (按 priority + type CompareTo)    (排序集; CompareTo: HGEnvironmentVolume.cs:459-560)
              ├── interpolatedVolumes : IndexedHashSet (本帧贡献集合)
              ├── interpolatedVolumesFactor : List<float> (每个体积的混合权重)
              ├── defaultPhase   (兜底 phase, 永远 active = true)
              └── s_interpolatedPhase  ──▶  本帧合成出的环境真值  (静态属性, HGEnvironmentManager.cs:67)
                                              ▲
                                              │
                              GpuCloth / Cloud / Volumetric / ColorGrading / Wind
                                  (所有子系统直接读 s_interpolatedPhase)


HGEnvironmentManager.PipelineUpdate(cameras, settings)   (HGEnvironmentManager.cs:553)
       │
       ├── 1. 排序: 若 sortNeeded → sortedVolumes 重排 (priority 升序, 同优先级 type 序)
       ├── 2. 每相机: GetFinalTrigger(camera, override)   (HGEnvironmentManager.cs:618; 优先取全局 trigger override → HGRenderPipeline.interpolateTrigger → Camera.main)
       ├── 3. UpdateCameraComponent(camera)              (HGEnvironmentManager.cs:873; 给 HGEnvironmentVolumeCameraComponent 算本帧贡献集)
       │      ├── 遍历 sortedVolumes:
       │      │    factor = blendMode 决定的混合权重
       │      │    if (factor > 0) interpolatedVolumes.Add(volume); interpolatedVolumesFactor.Add(factor)
       │      └── _UpdateInterpolatedPhase(camera)
       │            ├── interpolatedPhase.CopyFrom(defaultPhase)
       │            └── foreach (volume in interpolatedVolumes by reverse-priority order)
       │                    interpolatedPhase.Lerp(interpolatedPhase, volume.envPhase, factor)
       │              ⇒ 用 Lerp 把 volume 的 phase 叠加到当前累积 phase
       └── 4. PerCameraUpdate(camera, context)   (HGEnvironmentManager.cs:954; 推驱动子系统: Rain / Snow renderer)


HGAtmosphereRenderer.SetupShaderVariablesGlobalAtmosphereFog(cb, hgCam, phase)  (HGAtmosphereRenderer.cs:195)
       │  把 interpolatedPhase.{atmosphereConfig, fogConfig, heightFogConfig, volumetricFogConfig, cloudConfig} 打成
       │  ShaderVariablesGlobal._AtmosphereFogParams0~5 / _FogBakeLut* 等 cbuffer 字段
       ▼
SkyAtmospherePassConstructor.ConstructPass   (SkyAtmospherePassConstructor.cs:148)
       │  AddRenderPass<SkyAtmospherePassData>("Render Sky Atmosphere"  ←→  "Compute Sky Atmosphere")
       │      ShouldRenderAtmosphereLutUsingCompute() ?  ComputeShader  :  Material  → 4 LUT
       │  EnableAsyncCompute(useCompute)
       ▼
HGAtmosphereRenderer.RenderAtmosphereLut(cmd, ctx, hgCam, phase, mat, cs, rg, impl, params)  (HGAtmosphereRenderer.cs:1271)
       │  烘焙 4 LUT (大小由 HGAtmosphereSettingParameters 提供):
       │    ┌─────────────────────────┐
       │    │ TransmittanceLut (2D)   │   光学深度 → 透射率, 由 atmosphere 参数 hash
       │    │   width × height        │
       │    ├─────────────────────────┤
       │    │ MultiScatteredLuminance │   多次散射近似 (Hillaire eq.9-10)
       │    │   (2D, 32×32 同源)      │
       │    ├─────────────────────────┤
       │    │ SkyViewLut (2D, 球面参) │   当前观察点 → 天空亮度  (用 sun 方向 hash)
       │    │   width × height        │
       │    └─────────────────────────┘
       │  FogLUT (3D AerialPerspective) 在 SetupBakeFogLut 单独烘焙 (HGAtmosphereRenderer.cs:2868)
       ▼
HGSkyRenderer / HGSkydomeStarRenderer / Celestial draw → 全屏 fullscreen 或 icosphere mesh
        └── 读 4 LUT → 计算天空颜色 + sun disc + flare + 星体 + 行星大气
```

### 2.1 HG ↔ HDRP 同源对照表 (1:1 文件 + 行号)

| HG (反编译) | HDRP (源码) | 算法/职责 |
|----|----|----|
| `HGAtmosphereRenderer.cs` | `PhysicallyBasedSkyRenderer.cs:9-718` | 大气 LUT 烘焙的 driver (cache + dispatch) |
| `HGAtmosphereRenderer.RenderAtmosphereLut` (`:1271`) | `PhysicallyBasedSkyRenderer.PrecomputeTables` (`:192-217`) + `RenderSkyViewLut` (`:237-251`) + `RenderAtmosphericScatteringLut` (`:253-276`) | 3-4 阶段 LUT 烘焙 |
| `HGAtmosphereSettingParameters.cs:9-45` | `ShaderVariablesPhysicallyBasedSky.cs:7-26` `PbrSkyConfig` enum | LUT 尺寸来源, HG 改为运行时 `SettingParameter<int>`, HDRP 是编译期 const |
| `HGAtmosphereConfig.cs:7-67` | `PhysicallyBasedSky.cs:26-180` | Atmospheric parameters: 行星半径、大气深度、Rayleigh/Mie 系数、Ozone tent |
| `HGSkyConfig.cs:9-100` | `PhysicallyBasedSky.cs:39-180` (groundTint/space*/rotation*) + `SkySettings.cs` (intensity) | Sky 总参 + Sun disc + Cubemap 反射 |
| `HGCelestialConfig.cs:9-220` | `PhysicallyBasedSkyRenderer.FillCelestialBodyData` (`:631-702`) + `CelestialBodyData` struct | 天体 (Sun/Moon/Planet) 描述: forward/color/angularRadius/flare/shadowIndex |
| `HGStarConfig.cs:7-238` | (HG 自研, HDRP 无原生 starfield; 走 `groundEmissionTexture`/`spaceEmissionTexture`) | RGB 三层星密度 + 星云 |
| `HGEnvironmentPhase.cs:1-50` | HDRP `Volume` + `VolumeComponent` (per-frame stack) | HG 用单聚合 ScriptableObject 替代 HDRP 的 VolumeStack |
| `HGEnvironmentVolume.cs:9-1188` | `Volume.cs` + `VolumeComponent.cs` (Box/Sphere collider) | HG 改: 用 `BeyondPolyLineShape` 支持 PolyArea/Cylinder, 自带 fade in/out 时序 |
| `SkyAtmospherePassConstructor.cs:9-388` | `HDRenderPipeline` 内嵌 sky pass | HG 抽成 IPassConstructor 独立 pass |

**底层算法引用** (Hillaire 2020 EGSR; 见 `SkyLUTGenerator.compute:1`):
> *Ref: A Scalable and Production Ready Sky and Atmosphere Rendering Technique - Hillaire, EGSR 2020*
> https://sebh.github.io/publications/egsr2020.pdf

HDRP 的 PhysicallyBasedSky **正是该论文 + 经典 Bruneton 1999 / 2008 的工程实现**, 4 LUT (Transmittance / Multi-Scattering / Sky-View / Aerial-Perspective) 完全对应论文 §3.1-§3.4。HG 沿用同一套, 只是 LUT 尺寸做成运行时可调 (`HGAtmosphereSettingParameters`)。

---

## 3. Environment Phase: 21 子-config 聚合 + 静态广播

> *源*: `HGEnvironmentPhase.cs:6-49`

**`HGEnvironmentPhase` 是一个 `ScriptableObject`, 内嵌 21 个 struct 字段, 每个字段都实现 `IEnvConfig` (active 标志 + Lerp 方法)**。这是 HG 替代 HDRP `VolumeStack` 的核心数据载体: 一个 phase = 一套"美术调色板"。

```csharp
// HGEnvironmentPhase.cs:5-48
[CreateAssetMenu(fileName = "Env_", menuName = "Env Phase")]
public class HGEnvironmentPhase : ScriptableObject
{
    public HGLightConfig           lightConfig;            // 主光照
    public HGSkyConfig             skyConfig;              // §10
    public HGAtmosphereConfig      atmosphereConfig;       // §7
    public HGFogConfig             fogConfig;              // 远距大气雾 (见 05-Volumetric §3)
    public HGHeightFogConfig       heightFogConfig;        // 高度雾
    public HGVolumetricFogConfig   volumetricFogConfig;    // 体积雾 (见 05-Volumetric §3)
    public HGVolumetricCloudConfig volumetricCloudConfig;  // 体积云 (见 05-Volumetric §4)
    public HGCloudConfig           cloudConfig;            // 远景层云
    public HGCelestialConfig       celestialConfig;        // §11
    public HGWindConfig            windConfig;             // 全局风, 被 GpuCloth/草/云读
    public HGLightShaftConfig      lightShaftConfig;       // 屏空光柱
    public HGTerrainDeformConfig   terrainDeformConfig;    // 地形变形 (见 C02)
    public HGInkSimulationConfig   inkSimulationConfig;    // 墨水/液体
    public HGRainConfig            rainConfig;             // 雨
    public HGSnowConfig            snowConfig;             // 雪
    public HGStarConfig            starConfig;             // §12
    public HGLensFlareConfig       lensFlareConfig;        // 镜头眩光
    public HGColorGradingConfig    colorGradingConfig;     // 后处理调色
    public HGAutoExposureConfig    autoExposureConfig;     // 自动曝光
    public HGShadowConfig          shadowConfig;           // 阴影 (见 C07)
    public HGAnamorphicStreaksConfig anamorphicStreaksConfig; // 长条 bloom 条纹
}
```

### 3.1 Initialize: 把 21 个静态 defaultConfig 批量 memcpy 进字段

> *源*: `HGEnvironmentPhase.cs:50-1045` (`Initialize`)

**`Initialize()` 不是 `OnEnable`, 而是显式调用**, 它做的事是把每个 config 的静态 `defaultConfig` 字段(由各 config struct 内的构造函数填充, 见 `HGAtmosphereConfig(bool active):91-127` 给出的默认值)逐个 `movups` 16 字节一次 (XMM 寄存器) 拷贝到对应 phase 字段:

- 反编译显示是经典的 SIMD memcpy: `movups xmm0,[rax]; movups [rbx+offset],xmm0` 循环展开 2 次 (`mov edx, 2`/`sub rdx, 1; jne`) , 每个 config 一段 — 总共 21 段连续 inline。
- 反编译 `HGAtmosphereConfig(bool active)` (`:89-148`) 看到默认数值:
  - `groundRadius = 6371000 m` (`sub_45C6C000` = 6.371e6, 地球半径)
  - `atmosphereHeight = 60000 m` (`sub_42700000` = 60.0 → 60 km; HDRP 默认 100 km, HG 取地表+对流层为主)
  - `multiScatteringFactor = 1.0` (`sub_3F800000`)
  - `rayleighScatteringScale = 0.0331` (`sub_3D0793DE`)
  - `mieScatteringScale = 8.0` (`sub_41000000`)
  - `mieAnisotropy = 0.8` (`sub_3F4CCCCD`) — 与 HDRP `aerosolAnisotropy = 0.8` (`PhysicallyBasedSky.cs:110`) **一致**

### 3.2 CopyFrom / Lerp: 对所有 21 个 config 逐个调 `LerpConfig<T>`

> *源*: `HGEnvironmentPhase.cs:1047-1290` (`CopyFrom`, `Lerp`)

```text
HGEnvironmentPhase.Lerp(a, b, t):
    foreach (T in 21 个 config 类型):
        HGEnvironmentPhaseExtensions.LerpConfig<T>(
            ref current.fieldT, ref a.fieldT, ref b.fieldT, t)
```

反编译里 `Lerp` 是一段对每个 config 类型重复的展开代码 (`HGEnvironmentPhase.cs:1084-1287`, 长度 ~6KB), 每段:
1. `lock xadd [LerpConfig<T>_TypeInfo], r8`  — 触发该泛型实例化的元数据 lazy init (IFix 反编译典型模式)
2. 取得 `LerpConfig<T>` 函数指针, 直接 `call`

### 3.3 ActivateAllEnvConfig(bool): 一次性把所有 21 个 config 的 `active` 字段置位

> *源*: `HGEnvironmentPhase.cs:1290-1453`

用于"完全禁用某个 phase"——通过把 active 字段一刀切置 false, 在 LerpConfig 路径上会被快路径绕开 (见 §5)。

### 3.4 s_interpolatedPhase 静态广播 (跨子系统真值源)

`HGEnvironmentManager.cs:67` 暴露 `public static HGEnvironmentPhase s_interpolatedPhase => null;` (反编译 stub, 实际 getter 返回单例字段 `m_interpolatedPhase`)。各子系统读法 (反编译片段示例):

```text
mov rax, [HG.Rendering.Runtime.HGEnvironmentManager_TypeInfo]
call HGEnvironmentManager::get_instance
mov rax, [rax + 0x9D0]   ; m_interpolatedPhase (offset 0x9D0)
```

**这是关键 delta**: HDRP 用 VolumeStack/VolumeManager API 在每 pass 入口拉一份 snapshot, HG 改为 **每帧 update 一次,**然后让所有子系统**直接读静态指针**——零拷贝, 但要求子系统**不在同帧内修改 phase 字段**。GpuCloth (`05-Volumetric.md` §6) 读 `windConfig`、Cloud renderer 读 `cloudConfig`/`volumetricCloudConfig`、ColorGrading 读 `colorGradingConfig` 都是同一模式。

---

## 4. Environment Volume: 优先级排序 + 三种混合模式

> *源*: `HGEnvironmentVolume.cs:9-1188`, `EnvBlendMode.cs`, `EnvPriority.cs`, `EnvVolumeType.cs`

### 4.1 数据字段 (`HGEnvironmentVolume.cs:19-69`)

| 字段 | 类型 | 含义 |
|----|----|----|
| `_volumeType` | `EnvVolumeType` | Global=0 / Box=1 / Sphere=2 / PolyArea=3 / Cylinder=4 (`EnvVolumeType.cs:3-10`) |
| `_blendMode` | `EnvBlendMode` | None=0 / Distance=1 / Time=2 / Manual=3 (`EnvBlendMode.cs:3-9`) |
| `_priority` | `EnvPriority` | enum: VfxPp=1000, UIAdditive=600, UI=500, CutScene*=420/440, Additive=400, Area*=300-340, Scene=200, Base=100, BlockOut=0 (`EnvPriority.cs:3-19`) |
| `_blendDistance` | `float`, exp [1, 200] m | Distance fade 的物理距离 |
| `_fadeInDuration` | `float`, [0, 20] s | Time fade 进入时间 |
| `_fadeOutDuration` | `float`, [0, 20] s | Time fade 离开时间 |
| `_manualBlendFactor` | `float`, [0, 1] | Manual 模式权重 |
| `_envPhase` | `HGEnvironmentPhase` | 指向 ScriptableObject |
| `_polyLineShape` | `BeyondPolyLineShape` | PolyArea / Cylinder 拓扑 |
| `dataPerCameras` | `Dictionary<HGCamera, InterpolateDataPerCamera>` | 每相机独立的时序 fade state (`timeFadingFactor`) |

### 4.2 CompareTo: 排序键 = (priority↑, volumeType↑)

> *源*: `HGEnvironmentVolume.cs:459-560`

```csharp
public int CompareTo(HGEnvironmentVolume other)
{
    if (this.priority == other.priority)
        return ((EnvVolumeType)this.volumeType).CompareTo(other.volumeType);
    return ((EnvPriority)this.priority).CompareTo(other.priority);
}
```

反编译 box 进 `EnvPriority`/`EnvVolumeType` 然后比较——典型 enum CompareTo 走 `System.Enum::CompareTo` (offset 索引到比较表)。
**排序结果**: 低优先级在前 (Base 100 → Scene 200 → Area 300 → ...) , Volume 在 _UpdateInterpolatedPhase 里**从高优先级到低优先级反向覆盖**, 即:
- 先 `CopyFrom(defaultPhase)` — 默认调色板;
- 然后从最低优先级开始, 用该 volume 的 phase 与当前累积态 Lerp(t = factor) — 高优先级 volume 会**最后写入**, 因此在重叠区域统治视觉。

### 4.3 Distance Fade — `_DistanceToEdge` + `GetDistanceBlendFactor`

> *源*: `HGEnvironmentVolume.cs:855-1169`

```text
GetDistanceBlendFactor(triggerPos):
    if (volumeType == Global) return 1.0  // 全局体积永远满权
    d = _DistanceToEdge(triggerPos)        // 几何距离 (Box/Sphere/PolyArea/Cylinder)
    factor = saturate(d / (_blendDistance + ε))
    return factor
```

`_DistanceToEdge` 按 `EnvVolumeType` 分支:

| volumeType | 算法 (反编译) | 关键 call |
|---|---|---|
| `Global=0` | 直接返回 `+∞` (`g_18C47146C`) | — |
| `Box=1` | 转 local space: `triggerLocal = transform.WorldToLocal * triggerPos`; 计算到 box 边缘的最小距离 (反编译: `Vector3::op_Subtraction` → `Quaternion::op_Multiply` → abs → 各分量 min/max 组合) | `Transform::InverseTransformPoint`-style 手动展开 |
| `Sphere=2` | `(r − \|triggerPos − center\|)` | `Vector3::Distance` |
| `PolyArea=3` | `BeyondPolyLineShape::GetDistanceToEdgeInArea` | 调 Beyond 引擎 native 多边形距离 |
| `Cylinder=4` | (与 PolyArea 共享 BeyondPolyLineShape, 把 polyLine 当圆柱底圈) | `BeyondPolyLineShape::GetDistanceToEdgeInArea` |

PolyArea/Cylinder 走 `BeyondPolyLineShape::GetDistanceToEdgeInArea`(triggerLocal, blendDistance, isPolyArea ? 1.0 : 0.0)——这是 HG 接 Beyond 引擎的 Native 函数,做带高度的多边形距离场计算 (`_DistanceToEdge` 反编译 `:898-1099` 显示三层 quaternion 旋转 + scale + axis-aligned min 组合)。

### 4.4 Time Fade — `timeFadingFactor` 每相机独立时序

> *源*: `HGEnvironmentVolume+InterpolateDataPerCamera struct:14-17`, 属性 getter/setter (`:237-239`)

`HGEnvironmentVolume.timeFadingFactor` 是 (this, camera) → float 的属性 (内部从 `dataPerCameras[hgCamera].timeFadingFactor` 取). 每帧由 `HGEnvironmentManager._UpdateCameraComponent` 在 trigger 进入/离开 volume 时驱动:
- **进入** (trigger 在 Distance fade 范围内, `factor > 0`): `timeFadingFactor += dt / _fadeInDuration`, 直至饱和 1.0;
- **离开** (factor = 0): `timeFadingFactor -= dt / _fadeOutDuration`, 直至 0;
- **timeFadingOut** bool 记录方向, 用于反向时也走 fadeOutDuration 而不是 fadeInDuration。

### 4.5 Manual Mode

直接读 `_manualBlendFactor` 作为权重 (`[0, 1]`)。用于 Cinematic / Timeline / 玩家面板手动控制——不依赖 trigger 位置。

### 4.6 None Mode

`factor = 1` 或 `0` (binary on/off), 没有过渡。

---

## 5. LerpConfig`<T>`: 类型化插值 + t==0 / t>=1−ε 快路径

> *源*: `HGEnvironmentPhaseExtensions.cs:6-134`

**这是整个 phase 系统的"原子操作"**, 21 个 config 在 phase Lerp 里循环调用同一个泛型方法:

```csharp
[MethodImpl(MethodImplOptions.AggressiveInlining)]
public static void LerpConfig<T>(this ref T current, ref T src, ref T dst, float t)
    where T : struct, IEnvConfig
```

反编译 (`:46-133`) 揭示 **三个判断分支**:

| 条件 (反编译) | 含义 | 行为 |
|---|---|---|
| `!src.active && !dst.active` | 两端都禁用 | 直接退出, current 不变 |
| `t == 0` (`ucomiss xmm6, [g_18C471248]` + `jp/je`) | 完全偏向 src | `current = src` (3 个 `movups xmm` 拷贝整个 struct) |
| `t >= (1.0 - ε)` (`subss xmm0, [rcx]; comiss xmm6, xmm0; jae`) **且** `current.active` | 几乎完全偏向 dst 且当前已激活 | `current = dst` (3 个 `movups xmm`) |
| 否则 | 真正插值 | `current.active = true; T.Lerp(ref current, ref src, ref dst, t)` (call 进各 struct 自己的 Lerp) |

**ε 是机器精度的 1.0 - x 范围**, 从 `g_18C471324` (= 1.0) 减去 `[rcx]` (eps 表头) 算出。

每个 config struct 自己的 Lerp 方法负责按字段做插值, 例如:

```text
HGAtmosphereConfig.Lerp(current, src, dst, t):    // HGAtmosphereConfig.cs:150-310
    current.groundRadius        = Mathf.Lerp(src.groundRadius,        dst.groundRadius,        t);
    current.groundAlbedo        = Color.Lerp (src.groundAlbedo,       dst.groundAlbedo,        t);
    current.outerSunIrradianceColor = Color.Lerp(src..., dst..., t);
    current.atmosphereHeight    = Mathf.Lerp(...);
    current.multiScatteringFactor = Mathf.Lerp(...);
    current.rayleighScatteringScale = Mathf.Lerp(...);
    current.rayleighScattering  = Color.Lerp(...);
    current.rayleighExponentialDistribution = Mathf.Lerp(...);
    current.mieScatteringScale  = Mathf.Lerp(...);
    current.mieScattering       = Color.Lerp(...);
    current.mieAbsorptionScale  = Mathf.Lerp(...);
    current.mieAbsorption       = Color.Lerp(...);
    current.mieAnisotropy       = Mathf.Lerp(...);
    current.mieExponentialDistribution = Mathf.Lerp(...);
    current.ozoneAbsorptionScale = Mathf.Lerp(...);
    current.ozoneAbsorption     = Color.Lerp(...);
    current.tentTipAltitude     = Mathf.Lerp(...);
    current.tentTipValue        = Mathf.Lerp(...);
    current.tentWidth           = Mathf.Lerp(...);
```

反编译 (`HGAtmosphereConfig.cs:160-310`) 完全验证了上述顺序: 一连串 `movss xmm1, [rbx+off]; movss xmm0, [rdi+off]; call loc_1840EB060` (`Mathf.Lerp`) 和 `Color.Lerp` (`loc_18472D4A0`) 调用。**所有 19 个浮点 + 颜色字段被逐个独立 lerp, 不做矢量化** — 因为这是 IFix 反编译可热替换的 user code 路径。

### 5.1 HGSkyConfig.Lerp 的特殊处理 (SH lerp + 双路径 SH)

> *源*: `HGSkyConfig.cs:228-622`

**SH (球谐) 字段不能简单 Mathf.Lerp**, HG 用 `SphericalHarmonicsL2::op_Multiply` + `op_Addition` (HDRP / Unity 内置算子):

```text
current.skyAmbientSH = src.skyAmbientSH * (1−t) + dst.skyAmbientSH * t
```

而且 `useCustomIVDefaultSH` 是个 bool 开关 — Lerp 时若两端开关不同要做特殊处理:
- 两端都开 (`src.useCustomIVDefaultSH && dst.useCustomIVDefaultSH`): 两个 customIVDefaultSH 直接 SH-lerp;
- 只 src 开: 用 `Color::get_clear` 当 dst 的 SH, 即从 customSH 逐步 fade 到清色;
- 只 dst 开: 镜像;
- 都关: 跳过此字段。

反编译 (`:288-455`) 完整复现了上述三分支选择, 然后做 SH 标量乘加。

---

## 6. Animated Environment Volume: Timeline driven inline phase

> *源*: `HGAnimatedEnvironmentVolume.cs:6-200+`

`HGAnimatedEnvironmentVolume : HGEnvironmentVolume`, 区别:

1. **不引用外部 `HGEnvironmentPhase` asset**, 而是把 21 个 config 字段**内联**在自己身上 (字段定义 `:10-48` 与 phase 完全镜像)。
2. `override envPhase => null` — 防止上层错误地拿到一个静态 phase。
3. `override HasEnvPhase() => true` (反编译 `:69-100`, IFix 路径)。
4. `override GetEnvPhaseForInterpolate()`: **运行时按需 `ScriptableObject.CreateInstance<HGEnvironmentPhase>()` 创建一个一次性 phase 对象**, 然后把 21 个内联字段**逐个 memcpy** 进去, 再返回该 phase (反编译 `:104-200+`, 同样是 21 段 `movups xmm` 循环)。
5. 这样 `HGEnvironmentManager._UpdateInterpolatedPhase` 在调 `volume.envPhase` 时 (虚分派), Animated 版本会拿到当前 Timeline 驱动好的 inline 数据快照。

**用途**: Timeline / VFXPlayable 可以 keyframe 每个 config 字段, 实现 cinematic 场景里的环境插值动画(如黄昏定时变天黑、特定 cutscene 推 colorGrading 变冷等)。

---

## 7. 大气散射: 4 LUT 体系 (HDRP 同源算法)

> *引用*: `HGAtmosphereRenderer.cs:1271, 2108, 2299`; 对照 HDRP `PhysicallyBasedSkyRenderer.cs:182-276`, `SkyLUTGenerator.compute:1-457`, `InScatteredRadiancePrecomputation.compute:1-135`, `GroundIrradiancePrecomputation.compute:1-79`.

### 7.1 HG 烘焙 4 张 LUT (与 HDRP 同名/同语义)

> *HG 源*: `HGAtmosphereRenderer._RenderAtmosphereLutPS` (`:2108-...`), `_DispatchAtmosphereLutCS` (`:2299-...`)

```text
public void RenderAtmosphereLut(cmd, ctx, hgCam, phase, mat, cs, rg, impl, atmosphereParams):
    if (!ShouldRenderAtmosphereLut(hgCam, ref atmosphereLutConstants, atmosphereParams))
        return;   // hash-based skip: phase 参数没变 ⇒ 复用上帧 LUT

    if (ShouldRenderAtmosphereLutUsingCompute(atmosphereParams)) {
        // GPU compute 路径 (PC/PS5/Xbox)
        _DispatchAtmosphereLutCS(cmd, cs, skyViewLut, transmittanceLut, multiScatteredLuminanceLut, atmosphereParams);
    } else {
        // 像素着色器 fallback 路径 (移动端)
        _RenderAtmosphereLutPS(cmd, mat, skyViewLut, transmittanceLut, multiScatteredLuminanceLut, atmosphereParams);
    }

    // FogLUT (Aerial-Perspective) 在单独通路: SetupShaderVariablesGlobalBakeFogLut + BakeFogLutPassConstructor
```

四张 LUT 名字与 HDRP 完全对齐:

| HG LUT | HDRP 对应 | 维度 | 含义 |
|---|---|---|---|
| **TransmittanceLut** | (HDRP 没有独立 transmittance LUT, 而是用 Chapman 函数实时算; HG 单独烘到 LUT) | 2D `transmittanceLutWidth × Height` (`HGAtmosphereSettingParameters.cs:11-13`) | T(r, cosθ) — 给定半径 r 和天顶角 cosθ 沿出射方向到大气顶的透射率 |
| **MultiScatteredLuminanceLut** | `m_MultiScatteringLut` (`PhysicallyBasedSkyRenderer.cs:107-115`), 由 `MultiScatteringLUT` kernel 烘 (`SkyLUTGenerator.compute:142-197`) | 2D `multiScatteredLuminanceLutWidth × Height` (默认 32×32, 见 `ShaderVariablesPhysicallyBasedSky.cs:16-17`) | 多次散射近似 (Hillaire eq.9-10): `F_ms = 1/(1-radianceMS)` |
| **SkyViewLut** | `m_SkyViewLut` (`PhysicallyBasedSkyRenderer.cs:121-130`), 由 `SkyViewLUT` kernel 烘 (`SkyLUTGenerator.compute:205-221`) | 2D `skyViewLutWidth × Height`(HDRP 默认 256×144, `ShaderVariablesPhysicallyBasedSky.cs:20-21`) | 当前观察点(摄像机)下, 球面方向 → 天空亮度 |
| **AtmosphericScatteringLut** / FogLUT | `m_AtmosphericScatteringLut` (`PhysicallyBasedSkyRenderer.cs:145-153`), 由 `AtmosphericScatteringLUTCamera/World` kernel 烘 (`SkyLUTGenerator.compute:274-362`) | 3D `fogLutWidth × Height × Depth` (HDRP 默认 32×32×64) | 受 cascade shadow 调制的 Aerial-Perspective LUT, 给不透明/透明物体重采样雾 |

### 7.2 LUT 是 hash 缓存的 — 跨帧/跨场景共享

> *HG 源*: `HGAtmosphereRenderer.ShouldRenderAtmosphereLut` (`:1162`); *HDRP 同源*: `PhysicallyBasedSkyRenderer.PrecomputationCache` (`:13-57`)

HDRP `PrecomputationCache`: 用 `hash = pbrSky.GetPrecomputationHashCode(hdCamera)` 做键, 缓存 `RTHandle` 集合; 多相机/多 sky 复用同一份 LUT (`PhysicallyBasedSkyRenderer.cs:537-543`)。HG 在 `ShouldRenderAtmosphereLut` 比对 `AtmosphereLutConstants` 与上帧的版本 (12 个 Vector4 cbuffer 字段, `HGAtmosphereRenderer.cs:10-35`), 命中则跳过该帧 dispatch (反编译 `:1700-1965` 有 `cmp` + `jne` 判断 + `forceRenderAtmosphereLutEveryFrame` debug 强制开关)。

### 7.3 HG 关键 delta: LUT 尺寸运行时可调

HDRP 的 LUT 尺寸是**编译期常量** (`PbrSkyConfig` enum, `ShaderVariablesPhysicallyBasedSky.cs:4-26`):
```csharp
GroundIrradianceTableSize           = 256
InScatteredRadianceTableSizeX/Y/Z/W = 128 / 32 / 16 / 64   (4D 模拟为 3D)
MultiScatteringLutWidth/Height      = 32 / 32
SkyViewLutWidth/Height              = 256 / 144
AtmosphericScatteringLutW/H/D       = 32 / 32 / 64
```

HG 全部改成 `SettingParameter<int>` 运行时可调 (`HGAtmosphereSettingParameters.cs:9-39`), 让 RuntimeQuality 系统 (`HGRuntimeQuality.*`) 在不同设备下输出不同 LUT 分辨率 (PC 高、Mobile 低)。

---

## 8. Bruneton 数学全集 (HDRP 直接照抄, HG 复用)

> *源*: `PhysicallyBasedSkyCommon.hlsl:1-601`

### 8.1 介质参数 (per height)

```hlsl
// PhysicallyBasedSkyCommon.hlsl:42-78
float3 AirScatter(float height)       { return _AirSeaLevelScattering.rgb * exp(-height * _AirDensityFalloff); }
float3 AerosolScatter(float height)   { return _AerosolSeaLevelScattering.rgb * exp(-height * _AerosolDensityFalloff); }
float  OzoneDensity(float height)     { return saturate(1 - abs(height * _OzoneScaleOffset.x + _OzoneScaleOffset.y)); }

float3 AtmosphereExtinction(float height) {
    const float densityMie      = exp(-height * _AerosolDensityFalloff);
    const float densityRayleigh = exp(-height * _AirDensityFalloff);
    const float densityOzone    = OzoneDensity(height);
    return max(densityMie      * _AerosolSeaLevelExtinction
             + densityRayleigh * _AirSeaLevelExtinction.xyz
             + densityOzone    * _OzoneSeaLevelExtinction.xyz, FLT_MIN);
}
```

**HG 对照**: 这些数值来自 `phase.atmosphereConfig` (`HGAtmosphereConfig.cs:7-67`):
- `_AirSeaLevelScattering` ← `rayleighScattering * rayleighScatteringScale`
- `_AirDensityFalloff` ← `1.0f / airScaleHeight`,其中 `airScaleHeight = HDRP.ScaleHeightFromLayerDepth(rayleighExponentialDistribution * 1000)`,即 `H = d * 0.144765f` (`PhysicallyBasedSky.cs:181-187`)
- `_AerosolDensityFalloff` ← `1.0f / mieScaleHeight` (同公式, `mieExponentialDistribution`)
- `_OzoneScaleOffset` ← `(2/ozoneLayerWidth, -2*ozoneStart/ozoneLayerWidth − 1)` (`PhysicallyBasedSkyRenderer.cs:504`) — 这是 Ozone "tent" 函数的 2-参标准化, HG 用 `tentTipAltitude / tentWidth / tentTipValue` 三参表示同一 tent。

### 8.2 相函数 (Phase Function)

```hlsl
// PhysicallyBasedSkyCommon.hlsl:47-60
float AirPhase(float LdotV)     { return RayleighPhaseFunction(-LdotV); }                                      // 3/(16π) · (1 + cos²θ)
float AerosolPhase(float LdotV) { return _AerosolPhasePartConstant * CornetteShanksPhasePartVarying(_AerosolAnisotropy, -LdotV); }

// PhysicallyBasedSkyRenderer.cs:404-409
static float CornetteShanksPhasePartConstant(float anisotropy) {
    float g = anisotropy;
    return (3.0f / (8.0f * Mathf.PI)) * (1.0f - g * g) / (2.0f + g * g);
}
```

Cornette-Shanks 公式:
```math
p_{CS}(θ, g) = \frac{3(1-g^2)}{8π(2+g^2)} · \frac{1 + cos²θ}{(1 + g² - 2g·cosθ)^{3/2}}
```

**HG 对照**: `phase.atmosphereConfig.mieAnisotropy` ∈ [0, 0.999], 默认 0.8 (与 HDRP `aerosolAnisotropy` 默认 0.8 一致, `PhysicallyBasedSky.cs:110`)。

### 8.3 Chapman 函数 — 大气光学深度的高度积分解析近似

```hlsl
// PhysicallyBasedSkyCommon.hlsl:266-281
float ChapmanUpperApprox(float z, float cosTheta) {
    float c = cosTheta;
    float n = 0.761643 * ((1 + 2 * z) - (c * c * z));
    float d = c * z + sqrt(z * (1.47721 + 0.273828 * (c * c * z)));
    return 0.5 * c + (n * rcp(d));
}

float ChapmanHorizontal(float z) {
    float r = rsqrt(z);
    float s = z * r; // sqrt(z)
    return 0.626657 * (r + 2 * s);
}
```

**这两个数值魔数 0.761643 / 1.47721 / 0.273828 / 0.626657 必须 1:1 照抄**, 是 Schüler 2012 Chapman 函数级数展开后的拟合常数。`ComputeAtmosphericOpticalDepth` (`PhysicallyBasedSkyCommon.hlsl:366-477`) 把这两个组合, 处理 above-horizon / below-horizon 两种几何分支, 输出三通道 (Rayleigh, Mie, Ozone) 光学深度。

### 8.4 Ozone 光学深度 — 4-sample 数值积分

```hlsl
// PhysicallyBasedSkyCommon.hlsl:308-364
float ComputeOzoneOpticalDepth(float r, float cosTheta, float distAlongRay)
{
    // 用射线和 ozone 内/外球求交, 分 below/inside 两段
    // 每段 2 sample, 总共 4 sample 数值积分
    const uint count = 2;
    // ...
    ozoneOD += OzoneDensity(h) * dt;     // i=0..1
    // ...
    return ozoneOD * 0.6f;               // 经验缩放 (`:363`)
}
```

`0.6f` 是 HDRP 写死的"this is a very crude approximation, should be reworked"的经验值 (`:306` 注释)。 **HG 直接沿用**(没找到反编译里在 HG 端覆盖)。

### 8.5 多次散射 LUT (Hillaire 2020 eq.9-10)

> *源*: `SkyLUTGenerator.compute:142-197` (kernel `MultiScatteringLUT`)

```hlsl
// 每个 thread 用 Hammersley2d(SAMPLE_COUNT=64) 在球面上均匀采样一个 V 方向
// 沿 V 做 16 步 RTE 积分, 得到 single-scattering radiance 和 multiScattering 累加
[numthreads(1, 1, 64)]
void MultiScatteringLUT(uint3 coord : SV_DispatchThreadID) {
    UnmapMultipleScattering(coord.xy, sunZenithCosAngle, radialDistance);
    float3 L = float3(0, sunZenithCosAngle, SinFromCos(sunZenithCosAngle));
    float3 O = float3(0, radialDistance, 0);
    float2 U = Hammersley2d(threadIdx, 64);
    float3 V = SampleSphereUniform(U.x, U.y);
    // ... EvaluateAtmosphericColor → skyColor + multiScattering 累加
    radiance   = skyColor       * (4π * IsotropicPhaseFunction() / 64);   // dS, :181
    radianceMS = multiScattering * (4π * IsotropicPhaseFunction() / 64);
    ParallelSum(threadIdx, radiance, radianceMS);   // group-shared reduction

    // Hillaire EGSR 2020 eq.9-10:
    const float3 F_ms = 1.0f * rcp(1.0 - radianceMS);   // :193, eq.9 ("Approximate infinite multiple scattering")
    const float3 MS   = radiance * F_ms;                // :194, eq.10
    _MultiScatteringLUT_RW[coord.xy] = MS;
}
```

**核心数学** (论文 §4):
- 单步无限多次散射几何级数: 假设每次 bounce 损失相同的能量 `radianceMS`, 累加无穷次 = `radiance / (1 - radianceMS)` (eq.9)
- 这避免了在运行时做多次散射的多重 ray-march

**关键魔数** (1:1 照抄):
- `SAMPLE_COUNT = 64` (group-shared parallel reduction 大小, 也是球面方向数)
- `sampleCount = 16` 沿视线 RTE 积分步数 (`SkyLUTGenerator.compute:43`)
- `MS_EXPOSURE = 100.0f / MS_EXPOSURE_INV = 0.01f` — 多次散射数值表存到 LUT 时 pre-expose 100x 减带 (`PhysicallyBasedSkyCommon.hlsl:33-34`)

### 8.6 SkyViewLut — 球面参数化 (preserve horizon detail)

> *源*: `SkyLUTGenerator.compute:205-221` (kernel `SkyViewLUT`), `PhysicallyBasedSkyEvaluation.hlsl:46-73`

```hlsl
float2 MapSkyView(float cosChi, float3 V) {       // :46-59
    float coord = FastACos(cosChi) / HALF_PI;
    uv.y = sqrt(1.0 - coord);                     // 二次变换, 保地平线细节
    float phi = FastACos(normalize(V.xz).x);
    if (V.z < 0.0f) phi = TWO_PI - phi;
    uv.x = phi / TWO_PI;
}

void UnmapSkyView(uint2 coord, out float3 V) {    // :61-73
    float remapped = 1.0 - uv.y * uv.y;           // 反二次变换
    float cosChi = saturate(cos(remapped * HALF_PI));
    float sinChi = SinFromCos(cosChi);
    V = float3(sinChi, cosChi, sinChi);
    float phi = TWO_PI * uv.x;
    V.xz *= float2(cos(phi), sin(phi));
}
```

`sqrt(1 - coord)` 把 90° (地平线) 附近的纹素密度 2x 拉密, 防止地平线霾走样。**这是 HDRP/HG 共同做的关键 LUT 参数化**, 直接对应论文 §3.2 Fig.3。

### 8.7 Aerial-Perspective LUT — 3D 上的"distance, screen UV" 映射

> *源*: `PhysicallyBasedSkyEvaluation.hlsl:94-128`, `SkyLUTGenerator.compute:274-362`

```hlsl
#define ATMOSPHERIC_SCATTERING_MAX_DISTANCE 128000.0f   // :92, 128 km
float3 MapAtmosphericScattering(float2 positionNDC, float t, float cosChi) {  // :94-107
    const float offset = rcp(2 * PBRSKYCONFIG_ATMOSPHERIC_SCATTERING_LUT_DEPTH);
    float r = _PlanetaryRadius + _CameraAltitude;
    t -= max(IntersectSphere(_AtmosphericRadius, cosChi, r).x, 0);
    t /= ATMOSPHERIC_SCATTERING_MAX_DISTANCE;
    float s = sqrt(max(t - offset*offset, 0.0f)) - offset;  // inverse of GetSample()
    return float3(positionNDC, s);
}
```

3D LUT 的 `(u, v)` 是屏空 NDC, `(w)` 是相机到 fragment 的距离非线性映射 (sqrt remap, 保近距细节)。运行时 `EvaluateCameraAtmosphericScattering` (`:152-173`) 给任意不透明/透明物体重采样雾, 而非每像素 ray-march。

每个 fragment 的 sun-shadow 由 cascade shadow map 在 LUT 烘焙阶段直接采样 (`SkyLUTGenerator.compute:313-337`) — 这是 HDRP 的"Fog with Cascade Shadow"特性, HG 沿用 (`HGAtmosphereRenderer.SetupShaderVariablesGlobalBakeFogLut` 把当前帧的 cascade shadow uniform 推进 cbuffer)。

### 8.8 GetSample: 二次非线性采样分布

> *源*: `PhysicallyBasedSkyEvaluation.hlsl:28-42`

```hlsl
void GetSample(uint s, uint sampleCount, float tExit, out float t, out float dt) {
    float t0 = (s) / (float)sampleCount;
    float t1 = (s + 1.0f) / (float)sampleCount;
    t0 = t0 * t0 * tExit;          // 二次分布 (近距密, 远距疏)
    t1 = t1 * t1 * tExit;
    t = lerp(t0, t1, 0.5f);        // 0.5 gives the closest result to reference
    dt = t1 - t0;
}
```

二次分布**让靠近相机的采样点密集 4 倍**, 因为 single-scattering 主要贡献来自相机附近 (exp 落差最大处)。

### 8.9 IntegrateOverSegment (Frostbite 分析积分)

> *源*: `PhysicallyBasedSkyEvaluation.hlsl:17-26`

```hlsl
float3 IntegrateOverSegment(float3 S, float3 transmittanceOverSegment, float3 transmittance, float3 sigmaE) {
    // See slide 28 at http://www.frostbite.com/2015/08/physically-based-unified-volumetric-rendering-in-frostbite
    // Assumes homogeneous medium along the interval
    float3 Sint = (S - S * transmittanceOverSegment) / sigmaE;
    return transmittance * Sint;
}
```

这是 Frostbite 2015 的解析积分公式 (Lagarde):
```math
∫₀^{Δt} S · exp(-σ_e · s) ds = S · (1 - exp(-σ_e · Δt)) / σ_e = S · (1 - T_{seg}) / σ_e
```

`05-Volumetric.md` §3 体积雾用同一公式; **大气和体积雾在数学上同源, 区别只是介质参数 (σ_e/σ_s) 来源和采样几何**。

---

## 9. LUT 4D 参数化 (Yusov) + 4D → "deep 3D" 编码

> *源*: `PhysicallyBasedSkyCommon.hlsl:196-264, 543-571`; `InScatteredRadiancePrecomputation.compute:1-135`

In-scattered radiance LUT 是 4D 函数 `R(height, cosChi(view), cosL(sun), φ_L(sun azimuth w.r.t. view))`, 维度:
- `height`: [0, atmosphereDepth] (默认 60-100 km)
- `cosChi` = cos(view zenith), [-1, 1]
- `cosL` = cos(sun zenith), [-0.5, 1] (太阳超过 120° 不存)
- `φL` = sun azimuth (rad), [0, π]

### 9.1 Yusov 球面 / 高度参数化 (preserve horizon detail)

```hlsl
// PhysicallyBasedSkyCommon.hlsl:175-186
float MapQuadraticHeight(float h) { return sqrt(h * _RcpAtmosphericDepth); }   // 高度 2x 拉密
float UnmapQuadraticHeight(float v) { return v * v * _AtmosphericDepth; }

// :196-217 — view 方向参数化 (above/below horizon 不连续)
float2 MapAerialPerspective(float cosChi, float height, float texelSize) {
    float r      = height + R;
    float cosHor = ComputeCosineOfHorizonAngle(r);  // = -sqrt(1 - (R/r)²)
    float s = FastSign(cosChi - cosHor);
    float m = sqrt(abs(cosChi - cosHor)) * rsqrt(1 - s * cosHor);
    m = s * max(m, texelSize);           // 半 texel 偏移避地平线 bilinear 串
    float u = saturate(m * 0.5 + 0.5);
    float v = MapQuadraticHeight(height);
    return float2(u, v);
}

// :522-533 — sun 方向参数化 (allocate more samples around 90°)
float MapCosineOfZenithAngle(float NdotL) {
    float x = max(NdotL, -0.5);
    float s = CopySign(sqrt(abs(x)), x);
    return saturate(0.585786 * s + 0.414214);
}
```

魔数 `0.585786 = sqrt(2) - 1` / `0.414214 = 1 - (sqrt(2) - 1)` — **照抄不改写**, 是论文中 quadratic remap 把 [-0.5, 1] 映到 [0, 1] 的解析常数。

### 9.2 4D → "deep 3D" 编码 (4 维 LUT 模拟成 3D 纹理)

```hlsl
// PhysicallyBasedSkyCommon.hlsl:543-571
TexCoord4D ConvertPositionAndOrientationToTexCoords(float height, float NdotV, float NdotL, float phiL) {
    const uint zTexSize = PBRSKYCONFIG_IN_SCATTERED_RADIANCE_TABLE_SIZE_Z;  // 16
    const uint zTexCnt  = PBRSKYCONFIG_IN_SCATTERED_RADIANCE_TABLE_SIZE_W;  // 64
    // u, v = MapAerialPerspective(...)
    float w = (0.5 + (INV_PI * phiL) * (zTexSize - 1)) * rcp(zTexSize);
    float k = MapCosineOfZenithAngle(NdotL) * (zTexCnt - 1);     // ∈ [0, 63]
    TexCoord4D tc;
    tc.u  = u; tc.v = v;
    tc.w0 = (floor(k) + w) * rcp(zTexCnt);
    tc.w1 = (ceil(k)  + w) * rcp(zTexCnt);
    tc.a  = frac(k);
    return tc;
}
```

**关键**: 4D LUT 用 3D 纹理实现, Z 维存 W×Z = 64×16 = 1024 切片; 第 4 维 (sun zenith) 用 floor/ceil 两次 3D 采样 + `frac(k)` 线性混合。
**HDRP 默认尺寸**: 128×32×(16×64) (`ShaderVariablesPhysicallyBasedSky.cs:10-13`), 即一张 128×32×1024 的 3D 纹理。HG 用 `SettingParameter<int>` 让 MultiScattered/SkyView LUT 可调, 但 in-scattered radiance LUT 是否完全同尺寸取决于 HG 反编译里没暴露的内部尺寸 (HG 用 `multiScatteredLuminanceLut` 名字暗示它把 single + multi 合并了)。

### 9.3 InScatteredRadiancePrecomputation kernel 主循环

```hlsl
// InScatteredRadiancePrecomputation.compute:23-135
[numthreads(4, 4, 4)]
void main(uint3 dispatchThreadId : SV_DispatchThreadID) {
    // ... 解出 (cosChi, height, phiL, NdotL)
    float tMax = lookAboveHorizon ? IntersectSphere(A, cosChi, r).y
                                  : IntersectSphere(R, cosChi, r).x;
    const int numSamples = 16;
    for (int i = 0; i < numSamples; i++) {
        GetSample(i, numSamples, tMax, t, dt);
        float3 P = O + t * -V;
        const float3 sigmaE     = AtmosphereExtinction(height);
        const float3 transmittanceOverSegment = TransmittanceFromOpticalDepth(sigmaE * dt);
        float3 sunTransmittance = EvaluateSunColorAttenuation(NdotL, r);
        float3 airTerm     = sunTransmittance * AirScatter(height);
        float3 aerosolTerm = sunTransmittance * AerosolScatter(height);
        float3 scatteringMS = AirScatter(height) + AerosolScatter(height);
        float3 msTerm = EvaluateMultipleScattering(NdotL, height) * scatteringMS;
        airTableEntry     += IntegrateOverSegment(airTerm,     transmittanceOverSegment, transmittance, sigmaE);
        aerosolTableEntry += IntegrateOverSegment(aerosolTerm, transmittanceOverSegment, transmittance, sigmaE);
        msTableEntry      += IntegrateOverSegment(msTerm,      transmittanceOverSegment, transmittance, sigmaE);
        transmittance *= transmittanceOverSegment;
    }
    _AirSingleScatteringTable[tableCoord]     = airTableEntry;
    _AerosolSingleScatteringTable[tableCoord] = aerosolTableEntry;
    _MultipleScatteringTable[tableCoord]      = msTableEntry * MS_EXPOSURE;  // pre-expose 100x
}
```

Dispatch 维度 (HDRP `PhysicallyBasedSkyRenderer.cs:203-206`):
```text
DispatchCompute(s_InScatteredRadiancePrecomputationCS, 0,
    (int)PbrSkyConfig.InScatteredRadianceTableSizeX / 4,        // 128 / 4 = 32
    (int)PbrSkyConfig.InScatteredRadianceTableSizeY / 4,        //  32 / 4 = 8
    (int)PbrSkyConfig.InScatteredRadianceTableSizeZ / 4 *
    (int)PbrSkyConfig.InScatteredRadianceTableSizeW);           //  16/4 * 64 = 256
```

总线程数 = 32 × 8 × 256 × (4×4×4) = 32 × 8 × 256 × 64 = 4,194,304 = LUT 总 texel 数, 一一对应。

### 9.4 Ground Irradiance LUT — Cosine-weighted hemisphere 89 samples

> *源*: `GroundIrradiancePrecomputation.compute:1-79`

```hlsl
[numthreads(64, 1, 1)]
void main(uint dispatchThreadId : SV_DispatchThreadID) {
    float NdotL = UnmapCosineOfZenithAngle(uv.x);
    float3 groundIrradiance = 0.0f;
    if (NdotL > 0) {
        float3 oDepth = ComputeAtmosphericOpticalDepth(_PlanetaryRadius, NdotL, true);
        groundIrradiance = TransmittanceFromOpticalDepth(oDepth) * NdotL;     // 直射部分
    }
    const int numVolumeSamples = 89;                                          // Fibonacci 球面采样
    for (int i = 0; i < numVolumeSamples; i++) {
        float2 f = Fibonacci2d(i, 89);
        float3 L = SampleHemisphereCosine(f.x, f.y);
        // 用 ConvertPositionAndOrientationToTexCoords 查 in-scattered radiance LUT
        // 乘以相函数 AirPhase(LdotV) / AerosolPhase(LdotV) / MS_EXPOSURE_INV
        groundIrradiance += weight * radiance;       // weight = π / 89
    }
    _GroundIrradianceTable[tableCoord] = groundIrradiance;
}
```

`numVolumeSamples = 89` 是 Fibonacci 球面采样的"漂亮"数 (相邻 2 角接近黄金角度, low discrepancy)。

---

## 10. SkyRenderer: ProceduralSky vs Skybox + Sun Disc + Reflection / Ambient SH

> *源*: `HGSkyConfig.cs:9-624`, `HGSkyRenderer.cs:8-...`

### 10.1 HGSkyConfig 字段一览 (`HGSkyConfig.cs:19-99`)

| 字段 | 类型 | 含义 / 默认 |
|---|---|---|
| `skyDistance` | float [1, 30000] | 程序化天空 mesh 半径 (默认 10000m, 反编译 `:142` = `sub_461C4000`) |
| `skyBakedIndirectIntensity` | float [0, 5] | 烘焙间接光乘数 (默认 1.0) |
| `skyDirectIntensity` | float [0, 10] | 直接光乘数 (默认 1.0) |
| `useCustomIVDefaultSH` | bool | 是否覆盖默认 IrradianceVolume SH |
| `customIVDefaultSH` | `SphericalHarmonicsL2` | 27 浮点 L2 SH 系数 |
| `skyMaterialType` | enum | `ProceduralSky=0` / `Skybox=1` |
| `proceduralSkyLuxFactor` | float [0, 10] | 程序化天空照度系数 |
| `enableSunDisc` | bool | 绘制太阳本体 |
| `sunDiscRadius` | float [0, 1] | 太阳角半径 |
| `sunDiscRampIntensity` | float [0, 1] | 太阳渐变范围 |
| `sunDiscColor` | Color (HDR) | 太阳颜色 (含强度) |
| `skyboxBrightness` | float exp [0, 200000] | Skybox 亮度乘数 |
| `skyboxTintColor` | Color | Skybox 色调 |
| `skyboxRotation` | float [0, 360] | Skybox 旋转角 |
| `visibleBox` | Vector3 | 相机可见反射探针范围 (默认 100, 100, 100) |
| `reflectionType` | enum | `FromSky=0` / `Custom=1` |
| `reflectionMap` | Cubemap | 自定义反射 cubemap |
| `culloff` | float [0, 9] | Deringing 系数 (反编译 `:163` 默认 0.1, ≈ HDRP `windowing` cubemap convolution) |
| `skyAmbientSH` | `SphericalHarmonicsL2` | 全局环境漫反射 SH |
| `skyboxCubeMap` | Cubemap | 实际 skybox 贴图 |

### 10.2 ProceduralSky 通路 — Icosphere mesh + LUT 采样

> *源*: `HGSkyRenderer.cs:117-140`

```text
private const float PROCEDURAL_SKY_SCALE = 2000f;        // :117
public const int TALOS_RT_RESOLUTION = 2048;             // :139
public const int PLANET_ALPHA_RT_RESOLUTION = 1024;
private const float PLANET_RADIUS_TO_ATMOSPHERE_SCALE = 2000f;   // :143
private const float ATMOSPHERE_HEIGHT_INVERT_NUMBER = 30f;       // :145
// 大气积分采样步数 (PC vs Mobile 分开)
private const float ATMOSPHERE_OUTER_SCATTER_SAMPLE_STEP_PC     = 10f;  // :147
private const float ATMOSPHERE_INNER_SCATTER_SAMPLE_STEP_PC     =  5f;
private const float ATMOSPHERE_OUTER_SCATTER_SAMPLE_STEP_MOBILE =  5f;  // :151
private const float ATMOSPHERE_INNER_SCATTER_SAMPLE_STEP_MOBILE =  2f;
```

- **Icosphere mesh** (`m_IcosphereMesh`, `:119`) 是 sky dome 几何 — 由 16 字段的 `PlanetBillBoardConstants` cbuffer (`:10-115`) 驱动 procedural sky shader, 每个字段对应一个 sky/billboard 参数。
- `GetSkyDistance(camera) → s_interpolatedPhase.skyConfig.skyDistance` (反编译 `:155-248`)
- `GetSkyScale(camera) → Vector3(skyDistance, skyDistance, skyDistance)` (反编译 `:251-309`)

### 10.3 SkyRenderer 关键 Constants (`HGSkyRenderer.cs:10-115`)

`PlanetBillBoardConstants` (51 字段) 复用为远景行星 billboard 的整套 GPU 常量, 包括:
- `_RealPlanetRadius / _AtmosphereRatios / _Density_Multiplier / _g (Henyey-Greenstein 各向异性) / _StepsI / _StepsL / _Mie_Height_Scale`
- `_Ray / _Mie / _Ambient` — 3 个 Vector4 散射系数
- `_PlanetWSBase / _BBWSBase / _PlanetScale / _FresnelColor / _TintColor / _SeaDeep / _SeaShallow / _IndirectColor`
- `_CustomLightDir / _CustomLightColPla / _CloudsShadowColor`
- `_BaseColorMap_ST / _ErosionMap_ST` — uv 变换

这些都是远景行星/billboard rendering 的细化参数, 用于 `HGSkydomeStarRenderer._RenderStar` (`HGSkydomeStarRenderer.cs:154+`) 流程。

### 10.4 Sun Disc — Cone + Gauss falloff

`enableSunDisc + sunDiscRadius + sunDiscRampIntensity + sunDiscColor` 在 procedural sky shader 内是经典的:
```hlsl
float angle  = dot(viewDir, sunDir);
float cosR1  = cos(sunDiscRadius);
float cosR2  = cos(sunDiscRadius + sunDiscRampIntensity);
float disc   = smoothstep(cosR2, cosR1, angle);
finalColor += disc * sunDiscColor;
```

(HG shader 不在反编译 .cs 里, 但反编译 `_RenderStar` 看到的 Star pass index 与 sun disc pass 处于同一 procedural sky shader, 见 `HGSkydomeStarRenderer.cs:42-43` `SKYDOME_STAR_PASS_INDEX / FULL_SCREEN_DEBUG_PASS_INDEX`)。

---

## 11. Celestial: 双星 (Talos α + Planet) + 月亮 + 高精度星球 + 星环 + 行星大气

> *源*: `HGCelestialConfig.cs:9-1015+`, `HGSkydomeStarRenderer.cs:154+`

### 11.1 Celestial 数据结构 (`HGCelestialConfig.cs:871-880`)

```csharp
public struct HGCelestialConfig : IEnvConfig
{
    public HGCelestialObjectConfig            moonConfig;          // 月亮 (无大气)
    public HGCelestialAtmosphereObjectConfig  talosAlphaConfig;    // Talos α (主星, 有大气)
    public HGCelestialAtmosphereObjectConfig  planetConfig;        // 玩家所在的行星 (有大气)
    public HGCelestialAdvancedObjectConfig    advancedPlanetConfig;// 高精度行星 (自定义 material)
}
```

### 11.2 HGCelestialObjectConfig — 月亮型 (`:213-377`)

| 字段 | 范围 | 默认 (反编译 `:271-296`) |
|---|---|---|
| `radius` | [1, 79000] | 22400 (`sub_45AF0000`) — Talos α 半径 km |
| `orbitRadius` | float | 184320000 (`sub_4834AA00`) ≈ 1.84e8 km |
| `enableRing` | bool | false |
| `drawPlanetBelowHorizon` | [0, 1] | 1.0 — 地平线下星环不可见度 |
| `worldLongitude` | [0, 360] | 0 |
| `worldLatitude` | [-90, 90] | 1 (= 1° 北) |
| `rotationAroundUp` | [0, 360] | 45 (= 45° Y 轴旋转) |
| `ring` | RingProperty | (默认空) |

### 11.3 HGCelestialAtmosphereObjectConfig — 带大气的星球 (`:13-209`)

```csharp
public bool   drawPlanetInSkydome;                  // 是否在天空中绘制
public float  drawPlanetBelowHorizon;               // [0, 1] 地平线下不可见度
public CelestialObjectProperty   objectProperty;    // radius / selfTilt(X/Z) / selfRotationY
public CelestialDrawer           skydomeDrawer;     // drawMode (Texture/Simulated) + material + pitchYaw + incidentLightingPitchYaw
public bool   enableRing;
public RingProperty              ring;              // outerRadius / width / ringColor (HDR) / planetRingMap
public bool   enableAtmosphere;
public AtmosphereProperty        atmosphere;        // bakeFaceVisibility / atmosphereHeight / numInscatteredSamplePoints (10!) / numOpticalDepthSamplePoints (10!) / coff_R / heightScale_R / atmosphereBrightness / atmosphereHueshift
```

**HG 关键 delta** (`AtmosphereProperty(bool active)`, `:692-712`):
- `numInscatteredSamplePoints = 10` (HideInInspector 写死) — HDRP 主天空 16 sample, **HG 远景行星只用 10 sample**
- `numOpticalDepthSamplePoints = 10` (HideInInspector 写死) — 同样削减
- `coff_R = 10` (`sub_41200000`) — 散射对比
- `heightScale_R = 22` (`sub_41B00000`) — 散射高度系数
- `atmosphereBrightness = 80` (`sub_42A00000`) — 整体亮度
- `atmosphereHueshift = 0` — 默认无色调偏移

这些是远景行星 (Talos α / Planet) 的轻量大气, 不走 4 LUT, 而是在 `_RenderStar` (`HGSkydomeStarRenderer.cs:154+`) 用 `PlanetBillBoardConstants` 直接走 procedural shader 做光照——只有 10 sample 因为远景, 不要求精度。

### 11.4 CelestialObjectProperty — 自转 (`:427-522`)

| 字段 | 默认 (`:466-471`) | 含义 |
|---|---|---|
| `radius` | 22400 (`sub_45AF0000`) | 同 §11.2, km |
| `selfTiltX` | 0 | 自转倾角-X (rel. orbit) |
| `selfTiltZ` | 0 | 自转倾角-Z |
| `selfRotationY` | 0 | 自转角 (Y 轴) |

### 11.5 CelestialDrawer — 绘制属性 (`:525-634`)

```csharp
public enum DrawMode { Texture = 0, Simulated = 1 }
public DrawMode drawMode;
public Material drawMaterial;
public Vector2  pitchYaw;                  // 默认 (140, 180): (`sub_430C0000, sub_43340000`)
public Vector2  incidentLightingPitchYaw;  // 默认 (134, 224): (`sub_43060000, sub_43600000`)
```

- `Texture` 模式: 用 `drawMaterial` + texture 直接渲染 (适合 baked 星球纹理)
- `Simulated` 模式: 走完整的 procedural shading (大气 + sea + clouds), 由 `PlanetBillBoardConstants` 驱动

### 11.6 RingProperty — 星环 (`:788-869`)

| 字段 | 范围 | 含义 |
|---|---|---|
| `outerRadius` | [0, 160000] | 星环外半径 km |
| `width` | [0, 50000] | 星环宽度 km |
| `ringColor` | Color HDR | 颜色与 alpha |
| `planetRingMap` | Texture | 环纹理 |

### 11.7 HGCelestialAdvancedObjectConfig — 用户自定义高精度星球 (`:380-424`)

```csharp
public bool     drawAdvancedPlanet;        // 绘制开关
public Material advancedPlanetMat;         // 自定义材质
```

绕过 procedural 通路, 让美术上完全自定义的 ShaderGraph / shader 渲染特写星球。

### 11.8 _RenderStar 流程 (`HGSkydomeStarRenderer.cs:154-...`)

反编译片段 (`:319-400+`) 显示渲染流程:
1. 用 `GetInterpolatedPhase(hgCamera)` 拿当前帧 phase 的 `celestialConfig`
2. 算 pitch/yaw → quaternion → 计算星球 world position (`GetProceduralSkyMeshRadius` × 单位向量)
3. 设置 LocalKeyword: `RENDER_MODE_TEXTURE_KEYWORD_NAME` / `DRAW_RING_KEYWORD_NAME` / `DRAW_ATMOSPHERE_KEYWORD_NAME` / `DRAW_ATMOSPHERE_BAKE_KEYWORD_NAME`
4. 推 `PlanetBillBoardConstants` (51 字段, §10.3) 进 CBuffer
5. `DrawMesh(starMesh, transform, drawMaterial, SKYDOME_STAR_PASS_INDEX)`

每个 celestial 对象 (moon/talosAlpha/planet/advanced) 各一次 Draw, 顺序: 距相机远的先绘 (天空 dome 上的 painter's algorithm)。

### 11.9 GetMapWorldSpaceBasisInPlanetSpace (`:1115+`)

这个函数算"玩家所在地图在行星上的局部坐标系", 用于:
- 把 worldLongitude / worldLatitude / rotationAroundUp 三个角度转成 (up, forward, right) 3 个 Vector3
- 反编译 (`:1144-1326`) 用 `Quaternion.AngleAxis` 多次旋转 `Vector3.up / forward` 推出 up
- 然后 `Cross(up, ...)` + `op_UnaryNegation` 推出 forward + right
- 这给所有"天空中星球位置"提供地理参考帧, 与玩家在地球上看星空对应

`PercentageDeg(deg) = deg * (1/360)` (`:1081-1112`, 反编译 `mulss xmm6, [g_18E5EC46C]` = mul by 1/360 = 0.00277f) — 角度归一化辅助。

---

## 12. Star: 3 RGB 密度层 + 噪声/Baked Map + 星云遮蔽

> *源*: `HGStarConfig.cs:7-394`

### 12.1 三层 RGB 密度星点

```csharp
public enum StarType { RealTimeNoise = 0, BakedMap = 1 }
public bool   enableStars;
public StarType starType;             // 全局密度来源
public float  starsSize;              // [0.5, 2] 总密度 tiling
public float  starsFlickerSpeed;      // [0.001, 0.1] 闪烁速度

// Layer 0 (R 通道)
public Color  starsTint;              // 默认 white (`:175-176`)
public float  starsOffset0;
public float  starsDensityR;          // [0.1, 3]
public float  starsDensity;           // [0.001, 1] 大小
public float  starsExposure;          // [0, 1000] 曝光

// Layer 1 (G 通道) — 同样字段 + Tint1/Offset1/DensityG/Density1/Exposure1
// Layer 2 (B 通道) — 同样字段 + Tint2/Offset2/DensityB/Density2/Exposure2
```

反编译默认值 (`HGStarConfig(bool active):157-208`):
- `starsSize = 1.0` (`sub_3F800000`)
- `starsDensityR / G / B = 1.0` (`sub_3F800000`)
- `nebulaStarConverage = 0.1` (`sub_3DCCCCCD` ≈ 0.1)
- 所有 `Tint*` 默认 `Color.white`

### 12.2 星云 (Nebula)

```csharp
public bool      enableNebula;
public Texture   nebulaMap;
public Color     nebulaTint;
public float     nebulaMapRotation;       // [0, 360]
public float     nebulaStarConverage;     // [-5, 10] 星云对星星的遮蔽性
```

`nebulaStarConverage` ∈ [-5, 10]: 负值让星点穿透星云、正值让星云遮蔽星点 (alpha mask)。

### 12.3 实现路径

- **RealTimeNoise 模式**: 用 3D Worley/Voronoi 噪声生成星点 (shader 内), 三层 RGB 独立 tiling/offset, FlickerSpeed 用时间动 sin 摇晃。
- **BakedMap 模式**: 直接采样 `skyboxStarNoiseMap` (RGB 三通道分别代表三个 layer), 不参与时间闪烁。
- `skyBoxStarRangeMap` + `skyBoxStarDensityMapRotation` — 二次过滤的 mask 图, 用于"避免星空里出现星点不该出现的地方" (银河带控制); rotation 用于跟太阳/季节联动。
- `debugMode` 让美术调试时只看某个 RGB channel 或合成。

---

## 13. 关键常量 / 魔数总表

### 13.1 HDRP LUT 尺寸 (HG 改为运行时可调)

| 常量 | HDRP 值 | 来源 | HG 处理 |
|---|---|---|---|
| `GroundIrradianceTableSize` | 256 | `ShaderVariablesPhysicallyBasedSky.cs:7` | HG 未独立暴露 |
| `InScatteredRadianceTableSizeX/Y/Z/W` | 128/32/16/64 | `ShaderVariablesPhysicallyBasedSky.cs:10-13` | HG 未直接暴露 (估计编译期常量) |
| `MultiScatteringLutWidth/Height` | 32/32 | `ShaderVariablesPhysicallyBasedSky.cs:16-17` | HG `multiScatteredLuminanceLutWidth/Height` `SettingParameter<int>` |
| `SkyViewLutWidth/Height` | 256/144 | `ShaderVariablesPhysicallyBasedSky.cs:20-21` | HG `skyViewLutWidth/Height` `SettingParameter<int>` |
| `AtmosphericScatteringLutWidth/Height/Depth` | 32/32/64 | `ShaderVariablesPhysicallyBasedSky.cs:24-26` | HG `fogLutWidth/Height` + 第三维由 encode ratio 控 |
| `ATMOSPHERIC_SCATTERING_MAX_DISTANCE` | 128000 m (128 km) | `PhysicallyBasedSkyEvaluation.hlsl:92` | 同源, HG 沿用 |

### 13.2 Dispatch 维度 (1:1 照抄)

| Kernel | 线程组 | Dispatch 维度 |
|---|---|---|
| `MultiScatteringLUT` | (1, 1, 64) | (32, 32, 1) |
| `SkyViewLUT` | (8, 8, 1) | (256/8, 144/8, 1) = (32, 18, 1) |
| `AtmosphericScatteringLUTCamera/World` | (1, 1, 64) | (32, 32, 1) |
| `AtmosphericScatteringBlur` | (16, 16, 1) | (1, 1, 64) — depth 维 |
| `InScatteredRadiancePrecomputation::main` | (4, 4, 4) | (32, 8, 256) |
| `GroundIrradiancePrecomputation::main` | (64, 1, 1) | (4, 1, 1) — TableSize 256 / 64 |

### 13.3 关键数学常数

| 常量 | 值 | 来源 / 用途 |
|---|---|---|
| `Chapman 拟合 a` | 0.761643 | `PhysicallyBasedSkyCommon.hlsl:269` |
| `Chapman 拟合 b` | 1.47721 | `PhysicallyBasedSkyCommon.hlsl:270` |
| `Chapman 拟合 c` | 0.273828 | `PhysicallyBasedSkyCommon.hlsl:270` |
| `ChapmanHorizontal 常数` | 0.626657 | `PhysicallyBasedSkyCommon.hlsl:280` |
| `MapCosineOfZenithAngle a` | 0.585786 | `PhysicallyBasedSkyCommon.hlsl:526` |
| `MapCosineOfZenithAngle b` | 0.414214 | `PhysicallyBasedSkyCommon.hlsl:526` |
| `Ozone OD 缩放` | 0.6 | `PhysicallyBasedSkyCommon.hlsl:363` (HDRP 注释: "very crude approximation") |
| `MS_EXPOSURE` | 100.0 | `PhysicallyBasedSkyCommon.hlsl:33` (多次散射 LUT pre-expose) |
| `MS_EXPOSURE_INV` | 0.01 | `PhysicallyBasedSkyCommon.hlsl:34` |
| `RTE sample count` | 16 | `SkyLUTGenerator.compute:43`, `InScatteredRadiancePrecomputation.compute:98` |
| `MS group size` | 64 | `SkyLUTGenerator.compute:88` |
| `Ground irradiance Fibonacci samples` | 89 | `GroundIrradiancePrecomputation.compute:41` |
| `Earth radius default` | 6,378,100 m | `PhysicallyBasedSky.cs:40` |
| `Default air scale height` | 8000 m | `PhysicallyBasedSky.cs:44` |
| `Default aerosol scale height` | 1200 m | `PhysicallyBasedSky.cs:45` |
| `Default ozone min altitude` | 20 km | `PhysicallyBasedSky.cs:47` |
| `Default ozone width` | 20 km | `PhysicallyBasedSky.cs:48` |
| `Default aerosol anisotropy g` | 0.8 | `PhysicallyBasedSky.cs:110` |
| Scale-height ↔ layer-depth 系数 | 0.144765 | `PhysicallyBasedSky.cs:181-191` (`H = d * 0.144765`, 即 `H = d / -ln(0.001)`) |

### 13.4 HG 反编译验证的默认 atmosphere 数值 (`HGAtmosphereConfig(bool active):91-127`)

| 字段 | 反编译 IEEE-754 | 物理值 | 物理含义 |
|---|---|---|---|
| `groundRadius` | `sub_45C6C000` | 6371000 m | 地球半径 |
| `atmosphereHeight` | `sub_42700000` | 60.0 | 60 km (HG 调短, HDRP 默认 100) |
| `multiScatteringFactor` | `sub_3F800000` | 1.0 | 多散射强度 100% |
| `rayleighScatteringScale` | `sub_3D0793DE` | 0.0331 | Rayleigh 散射全局缩放 |
| `mieScatteringScale` | `sub_41000000` | 8.0 | Mie 散射缩放 |
| `mieAbsorptionScale` | `sub_39E8C8AC` | ~4.4e-4 | Mie 吸收 (极小) |
| `mieAnisotropy` | `sub_3F4CCCCD` | 0.8 | Cornette-Shanks g |
| `mieExponentialDistribution` | `sub_3F99999A` | 1.2 | Mie scale height (km) |
| `ozoneAbsorptionScale` | `sub_3AF68BE3` | ~0.00188 | Ozone 吸收 |
| `tentTipAltitude` | `sub_41C80000` | 25.0 | Tent 顶在 25 km |
| `tentTipValue` | `sub_3F800000` | 1.0 | Tent 顶峰值 |
| `tentWidth` | `sub_41700000` | 15.0 | Tent 宽度 15 km |

### 13.5 HG 关键 Volume 常量

| 常量 | 值 | 来源 |
|---|---|---|
| `blendDistance 范围` | [1, 200] m exp | `HGEnvironmentVolume.cs:37` |
| `fadeInDuration / fadeOutDuration` | [0, 20] s | `HGEnvironmentVolume.cs:42-52` |
| `EnvPriority.VfxPp` | 1000 (最高) | `EnvPriority.cs:5` |
| `EnvPriority.BlockOut` | 0 (最低实用) | `EnvPriority.cs:16` |
| `EnvPriority.Invalid` | int.MinValue | `EnvPriority.cs:17` |

### 13.6 SkyRenderer 常量 (`HGSkyRenderer.cs:117-153`)

| 常量 | 值 | 含义 |
|---|---|---|
| `PROCEDURAL_SKY_SCALE` | 2000 | Procedural sky dome 缩放 |
| `TALOS_RT_RESOLUTION` | 2048 | Talos α billboard RT 分辨率 |
| `PLANET_ALPHA_RT_RESOLUTION` | 1024 | Planet alpha RT 分辨率 |
| `PLANET_RADIUS_TO_ATMOSPHERE_SCALE` | 2000 | 行星半径→大气厚度比 |
| `ATMOSPHERE_HEIGHT_INVERT_NUMBER` | 30 | 大气高度倒数因子 |
| `ATMOSPHERE_OUTER_SCATTER_SAMPLE_STEP_PC` | 10 | PC 端外散射步长 |
| `ATMOSPHERE_INNER_SCATTER_SAMPLE_STEP_PC` | 5 | PC 端内散射步长 |
| `ATMOSPHERE_OUTER_SCATTER_SAMPLE_STEP_MOBILE` | 5 | Mobile 端外散射 (减半) |
| `ATMOSPHERE_INNER_SCATTER_SAMPLE_STEP_MOBILE` | 2 | Mobile 端内散射 (减半再多) |

---

## 14. 1:1 复刻蓝图 (分步)

要重建该系统的工程师, 按以下顺序:

### 14.1 阶段 A — Environment Phase + Volume + Manager

1. **创 `IEnvConfig` 接口** (`active` + `Lerp`), 每个 config struct 实现。
2. **写 21 个 config struct**: 字段命名 + 范围 + 默认值参 §3.1 反编译表。
3. **实现 `LerpConfig<T>` 泛型扩展** (§5 三分支: 两端禁用退出 / t==0 fast / t>=1-ε fast / 真插值)。
4. **写 `HGEnvironmentPhase` ScriptableObject**: 21 个字段 + `Initialize/CopyFrom/Lerp/ActivateAllEnvConfig`。
5. **写 `HGEnvironmentVolume` MonoBehaviour**:
   - 字段 + `EnvVolumeType` enum (5 类) + `EnvBlendMode` enum (4 类) + `EnvPriority` enum (优先级整数表)
   - `CompareTo`: 先 priority, 再 volumeType
   - `_DistanceToEdge`: 按 volumeType 5 分支 (Box/Sphere 用 transform InverseTransformPoint + scale; Poly/Cylinder 接外部 polyLineShape lib)
   - `GetDistanceBlendFactor`: `saturate(_DistanceToEdge / (blendDistance + ε))`
   - `OnPlay/OnStop` → `HGEnvironmentManager.Register/Unregister`
6. **写 `HGAnimatedEnvironmentVolume : HGEnvironmentVolume`**:
   - 内联 21 配置字段 (与 phase 同字段)
   - `override envPhase => null`
   - `GetEnvPhaseForInterpolate`: `ScriptableObject.CreateInstance<HGEnvironmentPhase>()` + memcpy 21 字段
7. **写 `HGEnvironmentManager` 单例**:
   - `activeVolumes (HashSet) / sortedVolumes (List) / interpolatedVolumes (IndexedHashSet) / interpolatedVolumesFactor (List<float>) / defaultPhase / m_interpolatedPhase`
   - 静态属性 `s_interpolatedPhase` 暴露 `m_interpolatedPhase`
   - `PipelineUpdate(cameras, settings)`: 排序 + 每相机 `_UpdateCameraComponent`
   - `_UpdateInterpolatedPhase`: `CopyFrom(defaultPhase)` + 反向遍历 interpolatedVolumes Lerp
   - `PerCameraUpdate`: 推 Rain/Snow renderer

### 14.2 阶段 B — Atmosphere LUT (HDRP 同源)

8. **直接 fork HDRP `PhysicallyBasedSkyCommon.hlsl`**: 所有数学函数 1:1 照抄, 包括 §8 / §9 全部魔数。
9. **fork HDRP `InScatteredRadiancePrecomputation.compute`**: 4D → 3D 4×4×4 thread group。
10. **fork HDRP `GroundIrradiancePrecomputation.compute`**: 64 thread group + Fibonacci 89 samples。
11. **fork HDRP `SkyLUTGenerator.compute`**: 4 kernel (`MultiScatteringLUT` + `SkyViewLUT` + `AtmosphericScatteringLUTCamera` + `AtmosphericScatteringLUTWorld` + `AtmosphericScatteringBlur`)。
12. **fork HDRP `PhysicallyBasedSkyEvaluation.hlsl`**: 提供 `EvaluateDistantAtmosphere` + `EvaluateCameraAtmosphericScattering` 接口给天空和 forward / forward+ 通道用。
13. **写 `HGAtmosphereRenderer`**:
    - `AtmosphereLutConstants` cbuffer (12 Vector4)
    - `SetupShaderVariablesGlobalAtmosphereFog/HeightFog/BakeFogLut` 把 phase 字段打成 cbuffer
    - `RenderAtmosphereLut`: hash skip + (compute / pixel) 分支调度
    - `ShouldRenderAtmosphereLut` hash 比对
    - LUT 分辨率走 `HGAtmosphereSettingParameters` `SettingParameter<int>`

### 14.3 阶段 C — SkyAtmospherePassConstructor

14. **写 IPassConstructor**: 在 RenderGraph 里挂一个 "Render Sky Atmosphere" pass (compute 时改名 "Compute Sky Atmosphere"), `EnableAsyncCompute(useCompute)` + 调 `RenderAtmosphereLut`。

### 14.4 阶段 D — SkyRenderer

15. **写 `HGSkyRenderer`**:
    - `PlanetBillBoardConstants` 51 字段 cbuffer
    - 加载 Icosphere mesh + procedural sky material + skybox cubemap material
    - 全屏 procedural sky pass: 用 SkyView LUT + Transmittance LUT 计算每像素天空颜色
    - Sun disc / Reflection map / Ambient SH 上传

### 14.5 阶段 E — Celestial + Star

16. **写 `HGSkydomeStarRenderer`**:
    - 算每个 celestial (moon/talosAlpha/planet/advanced) 的 world position 用 `pitchYaw + GetMapWorldSpaceBasisInPlanetSpace`
    - 推 `PlanetBillBoardConstants` 进 shader, 设 LocalKeyword (Texture / Ring / Atmosphere / AtmosphereBake)
    - `DrawMesh(starMesh, transform, drawMaterial, SKYDOME_STAR_PASS_INDEX)`
17. **写 Star 子层 shader**:
    - 3D Worley + 三层 tiling 出 RGB 星点 (RealTimeNoise) 或采 `skyboxStarNoiseMap` (BakedMap)
    - 用 `skyBoxStarRangeMap` 做 banding mask + `skyBoxStarDensityMapRotation` 旋转
    - `enableNebula` 时叠 `nebulaMap`, alpha 用 `nebulaStarConverage` 控星点遮蔽

### 14.6 依赖 / 接口

- 上游: HGRenderPipeline / HGCamera / HGRenderGraph / Beyond.BeyondPolyLineShape
- 下游: GpuCloth (读 windConfig), Cloud (读 cloudConfig/volumetricCloudConfig), Volumetric (读 fogConfig/heightFogConfig/volumetricFogConfig), ColorGrading (读 colorGradingConfig), AutoExposure (读 autoExposureConfig), AnamorphicStreaks (读 anamorphicStreaksConfig), Shadow (读 shadowConfig), Rain/Snow renderer (读 rainConfig/snowConfig)
- 与体积雾共享: `SetupShaderVariablesGlobalAtmosphereFog` 把 fog 系列也一起推 cbuffer (`HGAtmosphereRenderer.cs:195-532`), 因为大气和雾共用 transmittance / extinction 数学。

### 14.7 难点

- **HDRP HLSL 1:1 必须照抄**: 任何 Chapman 系数偏差都会让地平线霾错色 / 错紫。
- **`s_interpolatedPhase` 时序**: 必须保证 `HGEnvironmentManager.PipelineUpdate` 在所有读它的子系统之前调用 (`HGRenderPipeline.Render` 的顺序很关键)。
- **4D LUT 4×4×4 thread group**: 入门容易出错 (uint3 dispatchThreadId 解 4D 索引)。
- **PolyArea / Cylinder volume**: 需要 Beyond.BeyondPolyLineShape native 距离场库支持; 替代品: 三角形扫描算法 / SDF。
- **Animated phase 的 GC 风险**: `ScriptableObject.CreateInstance<HGEnvironmentPhase>()` 每帧调会 GC alloc — 必须 cache (HG 用 `s_animatedEnvPhase` 单例 cache, `HGAnimatedEnvironmentVolume.cs:50`)。
- **HG 削减的 Celestial 大气 10 sample**: HG `CelestialAtmosphereObjectConfig.atmosphere.numInscatteredSamplePoints = 10` 是远景行星不要求精度的优化, 移动端可能进一步降到 5。

---

## 15. 源文件清单

### 15.1 HG 反编译源 (本单元 C06)

| 文件 | 行 | 职责 |
|---|---|---|
| `EnvBlendMode.cs` | 1-10 | enum (None=0/Distance=1/Time=2/Manual=3) |
| `EnvPriority.cs` | 1-20 | enum 整数表 (VfxPp=1000 → BlockOut=0, Invalid=int.MinValue) |
| `EnvVolumeType.cs` | 1-11 | enum (Global=0/Box=1/Sphere=2/PolyArea=3/Cylinder=4) |
| `HGEnvironmentPhase.cs` | 1-3584 | 环境 phase 聚合 ScriptableObject (21 子-config + Initialize/CopyFrom/Lerp/ActivateAllEnvConfig) |
| `HGEnvironmentPhaseExtensions.cs` | 1-136 | LerpConfig`<T>` / CopyConfig`<T>` 通用泛型 (active 检查 + t==0 / t>=1−ε 快路径) |
| `HGEnvironmentVolume.cs` | 1-1188 | Volume MonoBehaviour: priority/blendMode/_DistanceToEdge/GetDistanceBlendFactor/CompareTo |
| `HGAnimatedEnvironmentVolume.cs` | 1-200+ | 内联 21 字段, GetEnvPhaseForInterpolate 按需 ScriptableObject.CreateInstance |
| `HGEnvironmentManager.cs` | 1-1998 | 单例: activeVolumes/sortedVolumes/PipelineUpdate/PerCameraUpdate/_UpdateInterpolatedPhase + s_interpolatedPhase 静态广播 |
| `HGEnvironmentUtils.cs` | 1-200+ | Vector min/max component, IFix-hooked extension methods |
| `HGEnvironmentVolumeCameraComponent.cs` | 1-97 | per-camera 累积态: interpolatedPhase / interpolatedVolumes / interpolatedVolumesFactor |
| `IEnvConfig.cs` | 1-10 | 子-config 接口 (active 字段 + Lerp<T> 泛型方法) |
| `HGAtmosphereConfig.cs` | 1-313 | 大气 19 字段 (Rayleigh/Mie/Ozone tent), 默认值通过反编译构造函数解出 |
| `HGAtmosphereRenderer.cs` | 1-3331+ | LUT 烘焙 driver: SetupShaderVariablesGlobal* + RenderAtmosphereLut + Hash skip |
| `HGAtmosphereSettingParameters.cs` | 1-47 | LUT 尺寸的运行时 `SettingParameter<int>` (HG 改 HDRP 编译期常量为可调) |
| `HGCelestialConfig.cs` | 1-1633 | 月亮 + Talos α + Planet + Advanced (radius/orbit/tilt/ring/atmosphere) + GetMapWorldSpaceBasisInPlanetSpace |
| `HGSkyConfig.cs` | 1-624 | 程序化天空 / Skybox / Sun disc / Reflection / Ambient SH |
| `HGSkydomeStarRenderer.cs` | 1-400+ | Celestial 绘制 driver: _RenderStar 推 51 字段 PlanetBillBoardConstants + LocalKeyword + DrawMesh |
| `HGSkyRenderer.cs` | 1-400+ | Procedural sky / Skybox 绘制 + GetSkyDistance/Scale/Radius + 11 常量 |
| `HGStarConfig.cs` | 1-394 | 3 RGB 密度层 + 噪声/baked map / 星云 / debug mode |
| `SkyAtmospherePassConstructor.cs` | 1-388 | IPassConstructor: AddRenderPass("Render/Compute Sky Atmosphere") + EnableAsyncCompute |

### 15.2 HDRP 同源引用 (1:1 fork 来源, 全在 `D:\Ruri\02.Unity\Project\HDRP\Library\PackageCache\com.unity.render-pipelines.high-definition@75de48326bcd\Runtime\Sky\PhysicallyBasedSky\`)

| HDRP 文件 | 行 | 职责 |
|---|---|---|
| `PhysicallyBasedSkyRenderer.cs` | 1-719 | LUT 烘焙 driver + PrecomputationCache + CelestialBodyData buffer |
| `PhysicallyBasedSkyCommon.hlsl` | 1-601 | 大气数学全集 (Chapman / Rayleigh/Mie/Ozone / 球面相交 / 参数化) |
| `InScatteredRadiancePrecomputation.compute` | 1-135 | 4D in-scattered radiance LUT kernel (4×4×4 thread group) |
| `GroundIrradiancePrecomputation.compute` | 1-79 | Ground irradiance LUT kernel (64 thread + Fibonacci 89 samples) |
| `SkyLUTGenerator.compute` | 1-457 | 4 kernel: MultiScatteringLUT / SkyViewLUT / AtmosphericScatteringLUT (Camera+World) / Blur (Hillaire 2020 EGSR 实现) |
| `PhysicallyBasedSkyEvaluation.hlsl` | 1-175 | LUT 采样接口 (EvaluateDistantAtmosphere / EvaluateCameraAtmosphericScattering / Frostbite 分析积分) |
| `ShaderVariablesPhysicallyBasedSky.cs` | 1-27 | LUT 尺寸 const enum (HG 改运行时) |
| `PhysicallyBasedSky.cs` | 1-200+ | Volume Component (HDRP API, HG 改 ScriptableObject) + Bruneton 默认常量 |

---
