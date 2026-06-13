# 11. 天气系统 (Rain / Snow / Wind / Wetness / Sludge / Ink / Frost) 实现原理蓝图

> 终末地的"天气"是一组**完全自研、HDRP 无对应物**的子系统：降雨/降雪粒子层、屏幕雨滴 FX、可被地面材质消费的**全局湿度参数包**、世界空间垂直水流(`HGWetnessVerticalFlow`)与涟漪(`HGWetnessRipple`, 详见 `../01-WaterOcean.md`)、动态泥浆 atlas (`HGSludgeManager` + `SludgePassConstructor`)、墨水交互流体 (`InkSimulationPassConstructor`)、磨砂玻璃后效 (`FrostedGlass`)、及一套四电机 + 四脚步电机的**全局风场 cbuffer**(`HGWindSimpleManager`)。
>
> 本篇原理 1:1 重建自：HG 反汇编 `call`/常量(`HGRainConfig.cs`、`HGRainRenderer.cs`、`HGGlobalWetness.cs`、`HGWetnessVerticalFlow.cs`、`HGSludgeManager.cs`、`SludgePassConstructor.cs`、`HGWindSimpleManager.cs` 等) + 领域渲染知识(Burley wetness 模型、jump-flood 距离场、Atlas Max-Rect 装箱、Gerstner 衰减振子)；HDRP 无血缘，所有等式均来自反编译 + 着色器名所暗示的工业标准。各章节顶部以引用块明示证据等级。
>
> 关联文档：
> - 涟漪 (`HGWetnessRipple`) 与水面 — 见 `./01-WaterOcean.md` §3，本篇仅讲解其在湿度链路里的注入点；
> - 泥浆/墨水流体的算法总览见 `../02-CoreAlgorithms/01-CoreAlgorithms.md` §15；本篇补足 GPU 资源生命周期、Atlas 装箱、`RecentHit` 注入；
> - 角色压痕(高度场)见 `../02-CoreAlgorithms/01-CoreAlgorithms.md` §14；本篇仅复用其语义；
> - 风场被环境 Volume 驱动见 `./06-EnvironmentSky.md` §3.4(`HGEnvironmentPhase.windConfig`)；

---

## 0. 目录

- §1  这组系统解决的渲染问题
- §2  数据流总览 + 子系统拓扑
- §3  Rain — 4 层渲染器 + 通用资源池 + 雨遮蔽图
- §4  Wetness — 三阶段湿度全局 cbuffer
- §5  Snow — SceneEffectSnowRenderer 6 层平面
- §6  Wind — 4 电机 + 4 脚步 + Beaufort 量级映射
- §7  Sludge — Atlas Max-Rect 动态泥浆 + Jump-Flood Blit
- §8  Ink — `_InkSimulationResultA/B` 双缓冲交互流体
- §9  Frost — 磨砂玻璃后效(VolumeComponent)
- §10 1:1 重建蓝图(按子系统分步)
- §11 关键常量/魔数汇总
- §12 源文件清单(52)
- §13 已知未决项

---

## 1. 这组系统解决的渲染问题

| 维度 | HG 怎么解 |
| --- | --- |
| **雨的视觉** | 不画亿万根独立雨滴。`HGFarRainRenderer` 用一只**纺锤体网格**(`farRainSpindleMesh`)把"远处雨锥"作为半透明体积一次画完；`HGSceneEffectRainRenderer` 在 4 层小范围方阵叠雨条；`HGRainSplashRenderer` 用 Flipbook quads 画地面溅起的雨花；`HGScreenRainDropFXRenderer` 在屏幕空间维护最多 30 颗雨滴的拖痕动画 |
| **雪** | 等价的 6 层 `HGSceneEffectSnowRenderer`，无远景雪锥(没有等同 FarRain 的实现)，把"远景"留给了 SceneEffect 的多层叠加 |
| **下雨之后地面变深、有反射** | **不重写 Lit BRDF**，而是把 9 组 Vector4 灌进全局 cbuffer，每个 Lit/Terrain 像素 shader **可选**采样这套参数对 albedo/roughness/normal 做调制；并提供一张 `verticalFlowTexture` 让墙面/陡坡显示流动 |
| **雪/雨打在角色上** | `RainCommonPreSettingParam.characterRainDrop/Streak/FaceDrip/FaceDroplet` 4 张采样图，character shader 在 face/body 分别采。属于 character pass 范畴，不在本篇 |
| **风把草/布料/云吹动** | 1 张 main wind state(每相机一份) + 4 个区域 `HGWindMotor` + 4 个角色脚步 `HGWindFootMotor` 全部打进 cbuffer 偏移 0x450、0x460、0x5C0、0x5D0…；草/布料/云 shader 都从同一组 ID 读 |
| **角色脚下的泥浆 / 墨水** | `HGSludgeManager` 维护一张共享 atlas，每只动态泥浆通过 Max-Rect 装箱占一个矩形子区；`SludgePassConstructor` 每帧把 `RecentHit` 像素溅入并 Jump-Flood-blit 复用上一帧 thickness/minHeight，做出可被地面材质读取的世界空间高度场 |
| **风挡上的霜冻 / 磨砂玻璃** | `FrostedGlass` VolumeComponent，downsample + 高斯 + 阈值的二级渐进式后效 |

---

## 2. 数据流总览 + 子系统拓扑

```
                       ┌──────────────────────────────────┐
                       │  HGEnvironmentPhase (per frame)  │
                       │  rainConfig / snowConfig /       │
                       │  windConfig                       │
                       │  ↑ Volume Lerp/插值(详 §06-Env)   │
                       └──┬────────────┬────────┬─────────┘
                          ▼            ▼        ▼
                ┌─────────────────┐ ┌────────┐ ┌─────────────────┐
                │  HGRainRenderer │ │HGSnow- │ │ HGWindManager   │
                │  ╔═══════════╗  │ │Renderer│ │  └ Simple(High) │
                │  ║RenderSeq* ║  │ └────────┘ └────┬────────────┘
                │  ║.subRainR. ║  │      │          │
                │  ║.wetnessF. ║  │      │          ▼
                │  ╚═══════════╝  │      │   cb 偏移 0x450/0x460/
                │   4 渲染器       │      │   0x5C0/0x5D0/0x4C0..0x590
                │   3 wetness    │      │   (windMain + 4 motor + 4 foot)
                └─┬───────────────┘      │
                  │                      │
                  ▼                      ▼
        ┌───────────────────────┐  ┌──────────────────────┐
        │ RainWetnessGlobalProps│  │ verticalOcclusionMap │
        │  Vector4[]  9 槽位     │  │  (远景湿度 mask)      │
        │  [0] wetness pack     │  │  详见垂直遮蔽图章       │
        │  [1] vflow pack HQ    │  └──────────────────────┘
        │  [2] vflow tex_ST     │
        │  [3] occlusion[1]     │
        │  [4] occlusion[2]     │
        │  [7] occlusion[3]     │
        │  [8] wetness ext1     │
        │  [9] wetness ext2     │
        └──────────┬────────────┘
                   │ SetGlobal Vector4 array
                   ▼
        ┌──────────────────────────────────┐
        │  全部 Lit/Terrain/HGRP_* shader   │  ←  GBuffer pass / Forward
        │   if (wetness > 0) { 调制 BRDF }  │
        └──────────────────────────────────┘

           ┌──────────────────────┐    ┌───────────────────────┐
           │ HGSludgeManager      │    │ InkSimulationPass     │
           │  AtlasMaxRect 装箱   │    │  _InkSimulationResult │
           │  Dict<int,DynamicS.> │    │      A / B  ping-pong │
           └────┬─────────────────┘    └─────────┬─────────────┘
                ▼                                ▼
        ┌────────────────────┐         ┌────────────────────┐
        │ SludgePassConstr.  │         │ 地表/角色 shader    │
        │ blit + jump-flood  │         │ SampleSludgeAtlas  │
        │ → thickness + min  │         │ SampleInkResult    │
        └────────────────────┘         └────────────────────┘
```

`*` `RenderSeq` 按 `HGCamera` 唯一(键 `cameraGuid`)，所以**主相机/反射相机/截图相机** 互不干扰，各自维护一份 `RainCommonRenderingParam`+`RainWetnessGlobalProps`(`HGRainRenderer.cs:32-49`)。

---

## 3. Rain — 4 层渲染器 + 通用资源池 + 雨遮蔽图

> 证据等级 ①：渲染器构造与 RenderQueue 直接来自 `HGRainRenderer.RainWetnessRenderSeq.CreateDefaultFeatures :50-300` 的反汇编 `il2cpp_vm_object_new` 序列；魔数 `30 / 480` 来自 `HGScreenRainDropFXRenderer.cs:23-25`。

### 3.1 类型分类

```csharp
[Flags] enum RainDropsType {
    None = 0,
    FarRain         = 1,   // 远雨 spindleMesh
    SceneEffectRain = 2,   // 中近景 4 层范围方雨
    GPUParticleRain = 4,   // (未在该单元发现具体实现)
    ScreenRainDrops = 8,   // 屏幕雨滴 FX
    RainSplashes    = 0x10 // 地面雨花
}

[Flags] enum WetnessFeaturesType {
    None         = 0,
    Wetness      = 1, // HGGlobalWetness
    VerticalFlow = 2, // HGWetnessVerticalFlow
    Ripple       = 4, // HGWetnessRipple  (见 ../01-WaterOcean.md §3)
}
```

`HGRainRenderer.cs:13-30`。Mask 集合：

- `SCENE_DROP_MASK` ≈ `FarRain | SceneEffectRain | RainSplashes`(用于"雪/雨幕"开关)
- `SCREEN_FX_DROP_MASK` = `ScreenRainDrops`
- `HIGH_QUALITY_WETNESS_MASK` = `Wetness | VerticalFlow | Ripple`
- `LOW_QUALITY_WETNESS_MASK` = `Wetness`

`HGRainRenderer.cs:2800-2806` 反汇编出常量但成员未初始化为字段(IL 静态构造)。

### 3.2 RenderQueue 与渲染顺序

`HGRainRenderer.cs:2814-2820`：

| 子系统 | RenderQueue 字段 | 反汇编位置 |
| --- | --- | --- |
| FarRain | `FAR_RAIN_RENDERQUEUE` | `RainWetnessQualityParams` 的 m_rainParamsArray |
| SceneEffectRain | `SCENEEFFECT_RAIN_RENDERQUEUE` | 同上 |
| RainSplash | `RAIN_SPLASH_RENDERQUEUE` | 同上 |
| ScreenRainDrop | `SCREEN_RAIN_DROP_RENDERQUEUE` | 直接 `set_renderQueue(0xBBB)`=3003(`HGScreenRainDropFXRenderer.cs` 反汇编 `mov edx,0BBBh`) |

> ScreenRainDrop 用固定 RenderQueue=**3003**(Transparent+103)，其余三者跟随设置。

### 3.3 通用资源池(`RainCommonResources`)

```csharp
// Rain/RainCommonResources.cs:5-22
internal class RainCommonResources {
    public Mesh   farRainSpindleMesh;      // 远景雨锥
    public Mesh   sceneEffectRainMesh;     // 中近景 quad 网格
    public Mesh   rainSplashMesh;          // 雨花面片
    public Mesh   screenDropFxMesh;        // 屏幕雨滴 mesh
    public Shader farRainShader;
    public Shader sceneEffectRainShader;
    public Shader screenRainDropFXShader;
    public Shader rainSplashShader;
}
```

辅以 `HGRainRendererUtils.GetScreenDropNormalizedQuad()` 和 `GetScreenDropQuadSeq()` 程序化生成屏幕雨滴 mesh：前者 4 顶点 + 6 索引(标准化全屏 quad)，后者 `0x78`=120 顶点 / `0xB4`=180 索引 = **30 个独立 quad**(=`MAXDROPCOUNT`)。命名为 `"ScreenRainQuad"`，`hideFlags=0x3D` (`HideAndDontSave|NotEditable`)，提交 `UploadMeshData(true)`(`HGRainRendererUtils.cs:65-237 / 239-444`)。

### 3.4 RainCommonPreSettingParam — 美术写死参数

`Rain/RainCommonPreSettingParam.cs`(143 行) 完整列出。摘其语义关键部分：

| 节 | 字段 | 语义 |
| --- | --- | --- |
| 通用 | `farRainDistance` [1,150] | 远雨锥半径(米) |
|       | `middleRainDistance` [1,60] | 中景雨锥半径 |
|       | `rainWaveDistance` [50,200] | 雨雾波远端 |
|       | `maxRainHeight` [1,300] | 雨锥高度 = 遮蔽图拍摄高度 |
|       | `maxMoveDirectionLength` [0,1] | 移动影响雨方向程度 |
|       | `rainTemporalTimeThreshould` [0,2] | 方向过渡 EMA 时间窗 |
| 雨锥 | `farRainMaxUVFlowSpeed` [0,200] | 非物理 UV 流速上限 |
|     | `farRainTex0/1` + `_ST` | 双层雨纹 |
| 特效雨 | `sceneEffectRainMaxUVFlowSpeed`/`sceneEffectRainRange` | 中景 4 层 |
|     | `rainWaveTex.r` 形状 + `.g` 噪声 | 雨雾波 shader 输入 |
| 屏幕雨滴 | `screenDropScatterParam` Vector2 | 散布参数 |
|     | `screenDropFXShadingSize/Noise` [0,1] | 形状/噪声 |
| **潮湿** | `verticalFlowTexture` RG=法线/B=Mask | 墙面流水 |
|     | `rippleTexture` RG=Ripple/BA=Wave | 涟漪图 |
|     | `rippleRowColumnCount` | Flipbook 行列数 |
| 雨花 | `rainSplashTexture` Flipbook | 雨花 atlas |
| **雨遮蔽图** | `rainOcclusionMapRange/Height` | 拍摄包围盒 |
|     | `rainOcclusionSampleNormalBias/DepthBias` | 采样偏移 |
|     | `rainOcclusionSampleNoise/Scale` | 随机化 3D 噪声 |
|     | `rainOcclusionSampleHorizontal/VerticalJitterLevel` | 平面抖动量 |
| 角色 | `characterRainDrop/Streak/FaceDrip/FaceDroplet` + `Tiling` | 角色 shader 采 |

### 3.5 运行期参数(`RainCommonRenderingParam`)

`Rain/RainCommonRenderingParam.cs:6-134` 把 `HGRainConfig` 经 Volume 插值后逐字段抄进运行期对象。**与 `HGRainConfig` 一一对应**，加上：
- `lastCamPos` Vector3 — 用于做雨方向的运动补偿；
- `rainDirection / middleRainDirection / farRainDirection` Vector3(已含运动补偿)；
- `cameraMask`、`commonPresettingParam`、`commonResources` — 反向回指。

> 这是**"复制一份，避免读取竞态"**的模式，与 `HGEnvironmentPhase` 同源 (`./06-EnvironmentSky.md` §3 同样的 delta)。

### 3.6 雨方向时间过渡(Temporal EMA)

`HGRainRendererUtils.CalculateTemporalWeightByDeltaTime(temporalThr, dt)` 反汇编 `:7-62`：

```
if (temporalThr ≤ epsilon)   return 0           // 无平滑
ceil( dt / temporalThr )  →  n_steps
weight = 1 - pow(0.5, 1 / n_steps)              // = 1 - 2^(-1/n)
```

`g_18C471320`=1.0f, `g_18C471324`=0.5f, `g_18C471328` 对应 `Math.Pow` 的 base 0.5。实质是把"在 `temporalThr` 秒里完成 50% 衰减"的 EMA 拆成"每帧步进 `1/n` 个半衰期"。每帧用该权重把新方向插到旧方向上：

```
rainDirection_new = lerp(rainDirection_old, target, weight)
```

`target` = `rainDirection_from_config − maxMoveDirectionLength * (cam_velocity_xz)`。

### 3.7 默认 sub-renderer 流水

`HGRainRenderer.RainWetnessRenderSeq.CreateDefaultFeatures` 反汇编 `:50-300` 出 4 个 subRain + 3 个 wetness 的固定创建顺序：

```
subRainRenderers ← {
    new HGFarRainRenderer        { mask=1,  queue=FAR_RAIN_RQ }
    new HGSceneEffectRainRenderer{ mask=2,  queue=SCENEEFFECT_RAIN_RQ }
    new HGRainSplashRenderer     { mask=16, queue=RAIN_SPLASH_RQ }
    new HGScreenRainDropFXRenderer{ mask=8, queue=SCREEN_RAIN_DROP_RQ=3003 }
}
wetnessFeatures ← {
    new HGGlobalWetness          { mask=1 }
    new HGWetnessVerticalFlow    { mask=2 }
    new HGWetnessRipple          { mask=4 }
}
```

> 顺序固定但每个渲染器可独立 `enabled` 关闭；不需要的渲染器一帧消耗仅为 `enabled` 检查。

### 3.8 FarRain — 纺锤体网格的远景雨锥

`HGFarRainRenderer.cs:1-104` 内嵌 `FarRainRenderParams`：保存 pos / 三层 scale(far/middle/wave) / 三个 direction / 三个 color / `streakLength` / `intensity` / `rainWaveHorizontalSpeed` / `rainWaveBottomFadeFactor` / `taauFixFactor` / `enableMiddleRain` + `enableRainWave`。

设计动因：
- **三个 sub-mesh、三套材质 + MPB** (`m_farRainMat` / `m_middleRainMat` / `m_rainWaveMat`)，名字以 `"!FARRAINOBJ"`/`"!MIDDLERAINOBJ"`/`"!RAINWAVEOBJ"` 开头(`HGFarRainRenderer.cs:97-103`)，便于 hierarchy 调试；
- 着色器关键字 `RAIN_WAVE` 控制雨雾波支路开关；
- `m_*LayerOffset` 是逐帧累积的 UV 偏移(`v += speed * dt`)，给雨条造**视差错觉**——远/中/雾波三层使用不同 `m_*RainLayerSpeedDiffMultiplier`(`HGRainConfig.cs:71/52`)。

纺锤体网格(spindle = 两端尖中间粗)被选作雨锥**而不是圆柱**，因为它解决两个问题：
1. **顶 / 底自然 alpha 0**：边界粒子不需要再做软裁剪；
2. **侧面斜率渐变**：摄像机抬头/低头看时 ray-length 自然变化，给雨的"密度"做了视差。

### 3.9 SceneEffectRain — 4 层方阵雨条

`HGSceneEffectRainRenderer.cs:46`：

```csharp
private const int s_maxSceneEffectLayerCount = 4;
private static readonly float[] s_sceneEffectLayerScale; // 4 个静态比例
```

4 个 `Transform` + `MeshRenderer`，每层使用 `sceneEffectRainMesh`(网格固定)绕摄像机布置，layer 间 scale 阶梯化(典型 0.6 / 0.8 / 1.0 / 1.2)。前缀名 `"!SCENE_EFFECT_RAIN_OBJ"`。`rainDirectionTargetPos` 让每条雨向"目标点"汇聚，避免完全平行 → 透视感更强。

### 3.10 RainSplash — 雨花 Flipbook

`HGRainSplashRenderer.cs:9-20` 的 `RainSplashRenderParams` 携带：
- `rainParams` Vector4 (intensity / speed / alpha / scale)
- `rainSplashTexture` + 单张 `rainSplashTextureScaleOffset`(=ST)
- `rainSplashExtraData` Vector4 — `xyz` 通常是地面投影方向、`w` 是 Flipbook 行列数

`rainSplashTextureRowColumnCount` 拼 Flipbook 索引；`m_rainSplashTimeOffset` 维护"该实例的 Flipbook 时间窗"，避免所有雨花同时开始。

> 设计：用**单 Mesh + MPB-driven uv 偏移**而非 GPU 粒子，因为 splash 数量小(`rainSplashCount` 上限 1000，实际 ≤500)且要参与 `RainSplash` mask 的 enable/disable。

### 3.11 ScreenRainDropFX — 屏幕雨滴拖痕

魔数：`MAXDROPCOUNT = 30`、`DROPRENDERDATA_BUFFER_SIZE = 480`(`HGScreenRainDropFXRenderer.cs:23-25`)。即每雨滴占 16 字节(=1 Vector4)，渲染数据 480 字节缓存 = 30×16。

CPU 维护三套数据：
```csharp
private bool[] m_dropActive;            // 当前是否激活
private Vector4[] m_dropUpdateData;     // pos.xy, life, speed
private Vector4[] m_DropRenderParam;    // 渲染数据参数
private NativeArray<Vector4> m_dropRenderDatas; // 上传 GPU
```

`PrepareResources` 中调用 `_ResetDrops` 重置；逐帧 `UpdateData` 推进位置/寿命/淡入淡出。设固定 RQ=3003 透明后期。
- 流动概率：`screenDropFlowPercent` 决定该滴是"原地溅"还是"沿引力方向拖"；
- `screenDropCentroidFadeParam` Vector2 — 距屏幕中心 fade 范围。

> mesh 由 `HGRainRendererUtils.GetScreenDropQuadSeq()` 程序生成的 30-quad atlas mesh 复用，**MPB 单次 set + DrawMesh** 一次画完，无 GPU instancing。

### 3.12 _RequestOcclusionMap + sample mode

`HGRainRenderer.RainWetnessRenderSeq._RequestOcclusionMap` 反汇编 `:2037-2155`：

- 调用 `HGVerticalOcclusionMapManager` 请求拍摄一次 vertical occlusion map(类似 Top-Down Cam)；
- 范围 = `rainOcclusionMapRange`，高度 = `rainOcclusionMapHeight * 2`(上下都拍)；
- 控制位 `_RainOcclusionMaskSampleMode` 与 `_RainOcclusionMaskSamplePosJitterMode` 由两个静态方法解出(目前反汇编都返回 0/1)：
  - sample mode = 1 → **enable**遮蔽图采样；
  - jitter mode = 取自 `HGSettingParameters` 高/中/低画质档；
- 不需要时清掉 `m_RainOcclusionRequest` 的最低位(`and dword ptr [rbx+10h], 0FFFFFFFE`)。

`_UpdateRainOcclusionMapShaderVariables` 反汇编 `:2477-2702`：把 vertical occlusion 的 `[rcx+11C..0140]` 几个偏移(sampleNoiseScale / depthBias / normalBias / jitterLevels)按 `HGUtils.PackVector4` 打入 `rainWetnessGlobalParams[]` 的 **slot 3 / 4 / 7**：

| Slot | xyzw |
| --- | --- |
| 3 | sampleNormalBias × verticalFlowScalar / sampleDepthBias / · / · |
| 4 | jitterMode / sampleMode / cloudShadowScalar / · |
| 7 | sampleNoise.x / .y / .z / cameraMaskCount |

> 这套全局 Vector4 数组就是天气/湿度链路与每个 shader 唯一的握手。

### 3.13 RainWetnessQualityParams — 画质开关

`HGRainRenderer.cs:2775-2792`：

```csharp
private class RainWetnessQualityParams {
    public bool   enableRainWetnessHighQuality;     // 触发 HIGH_QUALITY_WETNESS_MASK
    public bool   enableMiddleRain;                 // 控制 FarRain 第二层
    public bool   enableRainWave;                   // 控制 FarRain 雨雾波
    public bool   enableRainLighting;               // 雨条是否吃光照
    public float  screenRainDropPercent;            // ≤1.0, ScreenDrop 实际生成数 ÷ 上限
    public int    rainSplashMaxCount;
    public float  acneFixNormalBiasScale;           // 雨遮蔽图 acne 修正
    public int    sceneEffectRainLayerCount;        // ≤ s_maxSceneEffectLayerCount(=4)
}
```

由 `HGSettingParameters.HGRainAndWetnessSettingParameters` 喂入(`HGRainAndWetnessSettingParameters.cs`)。所有 toggle 通过 ShaderKeyword `EDITOR_KW` / `LIGHTING_KW` 在 shader 端启用对应分支。

---

## 4. Wetness — 三阶段湿度全局 cbuffer

> 证据等级 ①：所有 PackVector4 调用与 slot 索引来自 `HGGlobalWetness.SetData :132-255` 与 `HGWetnessVerticalFlow.SetData :104-210` 反汇编。

### 4.1 三层湿度子系统协作

| 子系统 | mask | 调度优先级 |
| --- | --- | --- |
| `HGGlobalWetness` | 1(=Wetness) | 必选，永远启用 |
| `HGWetnessVerticalFlow` | 2(=VerticalFlow) | 高画质启用 |
| `HGWetnessRipple` | 4(=Ripple) | 详见 `./01-WaterOcean.md` §3 |

任一开启 → `RainWetnessGlobalProps.enableWetness=true`；同时开启所有三个 → `wetnessHighQualityKwEnabled=true`(`RainCommonRenderingParam.cs:127`)，shader 端的 keyword `WETNESS_HQ` 启用 ripple 法线 + 流速合成。

### 4.2 RainWetnessGlobalProps cbuffer 槽位映射

`Rain/RainWetnessGlobalProps.cs:5-13`：

```csharp
internal class RainWetnessGlobalProps {
    public Vector4[] rainWetnessGlobalParams;   // 长度 ≥ 10
    public bool enableWetness;
    public bool enableWetnessHighQuality;
}
```

**slot 用法**(由 `HGGlobalWetness`/`HGWetnessVerticalFlow`/`_UpdateRainOcclusionMapShaderVariables`/Ripple 共同写入)：

| Slot | 来源 | 内容(由 `PackVector4(x,y,z,w)`) |
| --- | --- | --- |
| 0 | GlobalWetness | (wetness, wetnessBasePorosity, wetnessPorosityFactor, baseWetnessLevel) |
| 1 | VerticalFlow (HQ) | (uvOffsetAccum, verticalFlowNormalStrength, verticalFlowPorosityBias, ·) |
| 2 | VerticalFlow | (verticalFlowSpeed, verticalFlowTexture_ST 部分, verticalFlowSurfaceThreshold) |
| 3 | OcclusionMap | (sampleNormalBias×verticalFlowScalar, sampleDepthBias, ·, ·) |
| 4 | OcclusionMap | (jitterMode, sampleMode, cloudShadowScalar, ·) |
| 5 | Ripple | (rippleFrequency, rippleNormalStrength, rippleWaveSpeed, rippleWaveNormalStrength) (见水文档) |
| 6 | Ripple | (rippleRoughnessMaskThreshold, ·, ·, ·) |
| 7 | OcclusionMap | (sampleNoise.x, .y, .z, cameraMaskCount) |
| 8 | GlobalWetness | (verticalWetnessScalar, wetnessOcclusionRange, farSceneWetnessDistanceFactor, farSceneWetnessValue) |
| 9 | GlobalWetness | (wetnessProceduralForWater, wetnessHighQualityReflection, 0, 0) |

`_UpdateWetnessShaderVariables`(`HGRainRenderer.cs:2210-2474`) 是统一入口：遍历 `wetnessFeatures` → 调 `SetData(globalProps)` → 最后一次性 `cb.SetVectorArray("_RainWetnessGlobalParams", globalParams)`。

### 4.3 HGGlobalWetness.UpdateData → SetData 算法

`HGGlobalWetness.UpdateData(:30-130)` 把 `rainCommonRenderingParam.wetness/baseWetnessLevel/wetnessBasePorosity/wetnessPorosityFactor/verticalWetnessScalar/farSceneWetnessDistanceFactor/farSceneWetnessValue/wetnessProceduralForWater` 拷进内部 `m_globalWetnessRenderParams`(写偏移 +0x10/+0x14/…/+0x34)。还从 `rainCommonRenderingParam.commonPresettingParam`(+0x150) 读 `rainOcclusionMapRange` 写入 `wetnessOcclusionRange`(+0x24)。

`SetData(:132-255)` 三次 `PackVector4 + cb.SetVectorArrayElement`：

```
slot 0 = Pack(wetness, wetnessBasePorosity, wetnessPorosityFactor, baseWetnessLevel)
slot 8 = Pack(verticalWetnessScalar, wetnessOcclusionRange, farSceneWetnessDistFactor, farSceneWetnessValue)
slot 9 = Pack(wetnessProceduralForWater, wetnessHighQualityReflection, 0, 0)
```

**算法语义（Burley 湿度模型重建）**：
- `wetness ∈ [0,1]`：整体湿度因子；
- `baseWetnessLevel`：永久背景湿度(地面石材天然湿润度)；
- `wetnessBasePorosity ∈ [0,1]`：基础多孔度。值越高，材质吸水越多 → albedo 变深得越快。
- `wetnessPorosityFactor ∈ [-1,1]`：粗糙度对孔隙度的反向耦合：越粗糙的物件越**少**被该值影响 → 阻止粗糙金属变成"过分光滑的湿石头"。

shader 公式(由 slot 0/8 反推标准实现)：

```
finalWetness = saturate(wetness * dotN_Up + baseWetnessLevel) * verticalWetnessScalar
porosity     = wetnessBasePorosity * (1 - wetnessPorosityFactor * roughness)
albedoWet    = albedo * lerp(1, kBurley≈0.55, porosity * finalWetness)
roughnessWet = roughness * lerp(1, 0.05, finalWetness * (1-porosity))    // 反射变亮
normalWet    = lerp(normal, slope-aware blend with vflow normal, finalWetness * isVertical)
```

`dotN_Up` 让水平面比墙面湿；`farSceneWetnessDistanceFactor/Value` 在远处把 finalWetness clamp 到 `farSceneWetnessValue` 以稳定 SSR 反射。

### 4.4 HGWetnessVerticalFlow.UpdateData → SetData 算法

`HGWetnessVerticalFlow.UpdateData(:24-102)`：

1. 把 `verticalFlowTexture` 引用从 `commonPresettingParam.verticalFlowTexture`(+0xD8) 拷到 `m_wetnessVerticalFlowRenderParams.verticalFlowTexture`；
2. 把 `verticalFlowTexture_ST` Vector4 整块拷过来(+0xE0..+0xEC 一个 movdqu 一次性 16 字节)；
3. 拷 `verticalFlowNormalStrength` / `Surface Threshold` / `PorosityBias`(从 rainCommonRenderingParam +0x118..+0x120)；
4. **关键状态推进**：

```
m_verticalFlowUVOffset += deltaTime * rainCommonRenderingParam.verticalFlowSpeed * (1/30)
                                                                 //g_18C471CE8 = 1/30 常数
```

> 这是把"流速"以 30Hz 帧率为参考做归一化，从而**不同 dt 下流速看起来一致**(避免可变帧率撕裂)。

`SetData(:104-210)`：

```
if (verticalFlowNormalStrength ≤ ε):           // sub_18005E3A0(ResetData) 把 slot 1/2 清零
    ResetData(7, this, globalProps);            // (ResetData 内部对 slot 1/2 写 0)
else:
    slot 1 = Pack(m_verticalFlowUVOffset, verticalFlowSurfaceThreshold,
                  verticalFlowNormalStrength, ·)
    slot 2 = Pack(verticalFlowTexture_ST.x, verticalFlowTexture_ST.y,
                  verticalFlowPorosityBias, ·)
```

(slot 顺序由 `mov edx,1`/`mov edx,2` 调 `sub_180038EE0(=SetVectorArrayElement)` 显式给出。)

shader 端语义重建：

```
uvF       = worldPos.xz * st.xy + st.zw + uvOffset.x * float2(0, 1)  // 垂直流
flow      = SAMPLE(verticalFlowTexture, uvF);
nFlow     = UnpackNormalRG(flow.rg) * verticalFlowNormalStrength;
mask      = flow.b * step(verticalFlowSurfaceThreshold, abs(worldNormal.y));
normalWet = lerp(normalWet, normalize(normalWet + nFlow), mask)
porosity += verticalFlowPorosityBias * mask
```

`verticalFlowSurfaceThreshold` 用于"只有足够陡的面才显示流动"——避免水从平地往上流。

### 4.5 ResetData 路径

`HGGlobalWetness.ResetData(:257-322)` / `HGWetnessVerticalFlow.ResetData(:212-353)`：当某子系统**当帧不参与**(quality 关闭 / 配置失效)时，把对应 slot 整体写黑/写零。`g_18C471680` 是 `Color.clear` 的 16 字节缓存(实测把 slot 0 整 vec4 写 clear)，避免上一帧残留导致角色"突然变干"。

---

## 5. Snow — SceneEffectSnowRenderer 6 层平面

> 证据等级 ①：`Snow/HGSceneEffectSnowRenderer.cs:39` `s_maxSceneEffectLayerCount = 6`、`HGSnowRenderer.SnowRenderSeq.CreateDefaultFeatures :24-72` `il2cpp_vm_object_new` 序列。

### 5.1 Snow 渲染器拓扑

`HGSnowRenderer.cs` 仅注册**单一** sub-renderer：`HGSceneEffectSnowRenderer`(类似 `HGSceneEffectRainRenderer`)。无"远雪锥"、无屏幕雪滴 FX(由 Wind 拖动的雪花画在 SceneEffect 层即可)。RenderQueue = `0xBB8`=3000(透明)。

### 5.2 SnowCommonRenderingParam vs HGSnowConfig

`Snow/SnowCommonRenderingParam.cs` 对应 `HGSnowConfig.cs`：
- `intensity` [0,100]、`speed` Vector2(纵 + 横向漂移)、`color`、`snowSizeRange` Vector2；
- 水平向：`horizontalSnowAngle / Level`；
- `snowTrailLength` [0,2]：雪花拖痕(因 sub-pixel motion blur 模拟)；
- `snowJitterLevel` / `snowSpeedNoiseLevel` / `snowSpeedNoiseFreq`：用 Perlin 噪声造**雪花飘忽**；
- `snowLightingPercent`：雪是否吃方向光；
- `snowCollisionFadeTimeScale`：雪落地后的"渐显积雪"时间(配合体素/高度图)。

### 5.3 SceneEffectSnowRenderer 内部状态

```csharp
// Snow/HGSceneEffectSnowRenderer.cs:30-55
private const int s_maxSceneEffectLayerCount = 6;
private static readonly float[] s_sceneEffectLayerScale;          // 6 层比例
private Transform[] m_sceneEffectSnowTransList;                   // 6 transform
private MeshRenderer[] m_sceneEffectSnowRdList;                   // 6 MeshRenderer
private Vector3[] m_sceneEffectSnowAxisOffsetList;                // 每层轴偏移
private Vector3[] m_sceneEffectSnowDirections;                    // 每层风向
private float[] m_sceneEffectSnowDirectionJitterNoiseOffsetList;  // 噪声 phase
private MaterialPropertyBlock[] m_sceneEffectSnowMaterialPropertyBlockList;
```

每层独立维护方向偏移 → 让雪花看起来"层叠不同方向飘"，与 SceneEffectRain 的 4 层固定 scale 阶梯有差别：雪需要更多层(6)来掩盖"平面"感。

### 5.4 角色积雪 / 雪压痕

`SnowCommonPreSettingParam.characterSnowTexture` 给 character shader 单独采。**雪在角色身上堆积**的逻辑由 character shader 完成；雪在**地面**的堆积则借助：
- `EnableSnowCollision` 设置项；
- `HGTerrainDeformManager`(见 C02_Terrain 单元) 的高度场，雪与角色压痕共享同一张 deform RT；
- 详见 `../02-CoreAlgorithms/01-CoreAlgorithms.md` §14 交互高度场。

---

## 6. Wind — 4 电机 + 4 脚步 + Beaufort 量级映射

> 证据等级 ①：常量 `MAX_WIND_MOTOR_COUNT=4` (`HGWindSimpleManager.cs:44`)、`CLEANUP_INTERVAL=60f`(`:48`)；cbuffer 偏移 `0x450/0x460/0x4C0/.../0x5D0` 来自 `_SetupShaderVariablesWindMain/Motor/Foot` 反汇编 `:1329/1660/2039`；`MAX_SYSTEM_WIND_SPEED=30f` (`HGWindUtils.cs:7`)。

### 6.1 三档 WindQuality

```csharp
// HGWindManager.cs:8-13
public enum WindQuality {
    Min    = 0,   // 仅基本静态风
    Simple = 1,   // 启用 HGWindSimpleManager
    High   = 2,   // (未在反编译里发现独立 HighManager 实现，疑似仍走 Simple 但 keyword 不同)
}
```

`HGWindManager` 是 facade，仅当 quality==Simple 时把请求转发给 `m_simpleManager`，否则**直接 no-op**(从反汇编 `cmp dword ptr [rbx+18h],1; jne short ...` 看出严格判等于 1)。

### 6.2 HGWindConfig — 全局风(Env 驱动)

`HGWindConfig.cs:6-68`：

```csharp
public struct HGWindConfig : IEnvConfig {
    [Range(0,30)]   public float speed;                          // 米/秒
    [Range(0,360)]  public float horizontalDirectionAngle;       // 0=正北
    [Range(-90,90)] public float verticalDirectionAngle;
    [HideInInspector] public Vector3 direction;                  // 由 angle 推得
    private bool m_active;
}
```

被 `HGEnvironmentPhase` 持有，`Lerp` 用 `Vector3.Multiply + Vector3.Add + Mathf.Abs/Normalize`(`:70-170`) 把 `direction` 做加权线性插值再归一化，避免方向旋转 90°+1 帧炸裂。

> **HGWindUtils** 提供两个工具：
> - `WindEulerAngleToDirection(h, v)`：`Quaternion.AngleAxis(h+180, up) * forward * vertical`(`HGWindUtils.cs:55-122` 反汇编出 `op_Multiply` 链)，把 `(h, v)` 转 Vector3；
> - `WindSpeedToBeaufortWindScale(s)`：`Mathf.Sqrt(s) * k1 + s * k2`(`:9-53`)，把米/秒映射为蒲福风级近似(草动幅度 shader 端用)。

### 6.3 HGWindMotor 与 HGWindMotorData

`HGWindMotor.cs:6-8` 继承 `VFXPlayableMonoBase`(VFX 时间线兼容)，每实例持 `HGWindMotorData`：

```csharp
// HGWindMotorData.cs:5-45
public struct HGWindMotorData {
    public HGWindPriority windPriority;   // Map=-10, Skill=0  → 数字越小越早被剔除
    public HGWindShape    shape;           // Sphere=0, Rect=1
    public float rangeIn;                  // 影响半径
    public float length, width, height;    // Rect 模式
    public bool  rectBackward;             // Rect 是否吹背向
    public float radius;                   // Sphere 模式
    [Range(0,360)] public float angle;     // 扇区角
    [Range(0,40)]  public float windSpeed;
    public Orient focus;                   // 聚焦目标
    public int   motorInfo;                // 类型 bitmask: 0=Directional, 1=Circular, 2=Vortex(EWindFieldType)
    public float distanceToCamera;         // 排序键
}
```

`EWindFieldType.cs:3-8` 与 `motorInfo` 对应：Directional / Circular / Vortex 三类。Vortex = 旋涡(适用龙卷/旋风)；Circular = 圆周(火焰圈)。

### 6.4 注册/反注册 + 60 秒清理

`HGWindSimpleManager.SetWindFootMotor(index, pos, range)` (`:64-156`) 校验 `index < 4`(反汇编 `cmp ebx, 3; ja ...`)，然后写入 `m_windFootMotors[index]`：

```
m_windFootMotors[index].range = range
m_windFootMotors[index].position = pos
```

布局：每条 `HGWindFootMotor` 占 16 字节(`shl rcx, 4`)，前 4 字节 `range`，后 12 字节 `Vector3 position`。

`RegisterWindMotor / UnRegisterWindMotor` 增删 `m_windMotors: List<HGWindMotor>`，由 `CLEANUP_INTERVAL = 60f` 控制：每 60 秒清理无效相机的状态(`m_windMainState`/`m_windMotorState` 的 stale 条目)，避免长时间 GC 滞留。

### 6.5 _SortWindMotorsForSingleCamera

`_SortWindMotorsForSingleCamera(cameraPos)`(`:2506-2680+`)：
1. 遍历所有注册的 `HGWindMotor`，按 `(priority, distanceToCamera)` 排序；
2. `Map`(-10) 优先级一定先被剔，剩下的 `Skill`(0) 按 `distanceToCamera` 升序保留前 4 个；
3. 把它们的 `HGWindMotorData` 复制到 cbuffer 偏移 `0x4C0..0x590`(每个 motor 占 0x40 = 64 字节、4 个共 256 字节)。

### 6.6 SetupShaderVariablesGlobalWind cbuffer 布局

`_SetupShaderVariablesWindMain(:1329-1577)` + `_SetupShaderVariablesWindFoot(:2039-…)` + `_SetupShaderVariablesWindMotor(:1660-…)` 联合写入：

| cb 偏移 | 内容 |
| --- | --- |
| 0x450 | `_WindGlobalParams0 = (curWindTime, curNoiseUV.x, curNoiseUV.y, intensity 编码)` |
| 0x460 | `_WindGlobalParams1 = (lastWindTime, lastNoiseUV.x, lastNoiseUV.y, lastIntensity)` |
| 0x4C0 + i*0x40 | `_WindMotorParams[i]` 4×Vector4 (4 motor × 4 vec4 = 16 vec4 = 256 字节) |
| 0x5C0 | `_WindMotorCount = (motorCount, 0, 0, 0)` |
| 0x5D0 | 当前帧 windMain 输出快照(供下一帧 lerp) |

> `_WindGlobalParams0` 里的 `curWindTime` 不是 `Time.time` —— 它由 `mulss xmm6, [g_18C47163C]` (常量 1/`HGWindUtils.MAX_SYSTEM_WIND_SPEED`=1/30) 做了**风速规范化时间**(`:1366`)，让"草摆动"频率随 wind speed 改变但又被 [0,1] 时间窗 clamp，避免高速风下小数精度爆炸。

`_WindMotorCount` 把"实际写入了几个 motor"告诉 shader，shader 端循环只到 count 即可。

每帧顺序：`_SetupShaderVariablesWindMain → ... → _SetupShaderVariablesWindMotor × 4 → _SetupShaderVariablesWindFoot`。最后 `Buffer.MemoryCopy` × 4 把 0x450/0x500/0x540/0x580 这四块 0x40 字节再次复制到本相机绑定的 `windMainState`(`+0x48..+0x118`)做下一帧 lerp 用。

### 6.7 HGWindParamDataCache — 上传缓冲

```csharp
// HGWindParamDataCache.cs:5-26
public struct HGWindParamDataCache {
    public Vector4 _WindGlobalParams0;
    public unsafe fixed float _WindMotorParams0[16];   // 4 vec4
    public unsafe fixed float _WindMotorParams1[16];
    public unsafe fixed float _WindMotorParams2[16];
    public unsafe fixed float _WindMotorParams3[16];
    public Vector4 _WindMotorCount;
    public float   _WindLeafFadeDistance;              // 叶子按距离淡出
    public float   _WindLeafFadeRange;
    public byte    _WindMainQuaility;
    public byte    _WindMotorQuaility;
}
```

是 `HGWindManager.GetWindParamDataCache` 返回的快照，用于**给其他系统(Cloud/Cloth/Grass shader)的 cbuffer 副本上传**。

### 6.8 风的语义重建(shader 公式)

按 cbuffer 布局可一并把 shader 端的最小风模型还原：

```
phase  = curWindTime * windParams.intensity + worldPos · windDir / wavelength
sway   = sin(phase) * baseAmplitude * Beaufort(windSpeed) * leafFadeWeight(dist)
       + noise2D(worldPos.xz * windNoiseUVScale + curNoiseUV) * gustAmplitude
finalOffset = windDir.xz * sway
```

- `Beaufort()` = `HGWindUtils.WindSpeedToBeaufortWindScale`；
- `leafFadeWeight` = `smoothstep(_WindLeafFadeDistance-_WindLeafFadeRange, _WindLeafFadeDistance, cameraDist)`；
- 区域 motor 把 `windDir` 替换为 motor 自己的方向并按 `rangeIn` falloff(Sphere=`saturate(1-d/radius)`, Rect=AABB clip)；
- 4 个 foot motor 在 player 半径 `range` 内额外叠加压痕(草向外辐射)。

---

## 7. Sludge — Atlas Max-Rect 动态泥浆 + Jump-Flood Blit

> 证据等级 ①：`HGSludgeManager.RequireDynamicSludge :653-820` 直接看到 `AtlasMaxRect::InsertRect / TRS / Matrix4x4 / Dictionary.Add` 调用；②：算法名(Jump-Flood / Max-Rect packing)由资源名 `dynamicsludgeblit.shader` + `sludgev2.shader`(已在 §15 引用) 与文献标准推断；详情交互见 `../02-CoreAlgorithms/01-CoreAlgorithms.md` §15。

### 7.1 HGSludgeManager 数据结构

```csharp
// HGSludgeManager.cs:7-19
public class HGSludgeManager {
    private HGSludgeConfig m_config;                            // {textureSize, graphicsFormat}
    private int            m_dynamicSludgeGUID;                  // 自增 ID
    private Dictionary<int, HGDynamicSludge> m_dynamicSludges;
    private List<int>      m_cacheOutDateList;
    private AtlasMaxRect   m_atlasMaxRect;                       // 装箱器
    private Mesh           m_planeMesh;                          // 公用 quad
}

// Sludge/HGDynamicSludge.cs:5-22
public class HGDynamicSludge {
    public Vector2Int   texelSize;                               // 申请尺寸
    public RectInt      atlasRect;                               // 在 atlas 中的矩形
    public Vector4      atlasTillingScale;                       // x=tiling.x,y=tiling.y,z=offset.x,w=offset.y
    public Matrix4x4    matrix4X4;                               // 世界 → 局部
    public float        rebornTime, rebornAnimTime, lastHitTime;
    public HGDynamicSludgeHit recentHitPoint;                    // {time, point.xy, range}
}
```

### 7.2 RequireDynamicSludge — 申请 + TRS

`RequireDynamicSludge(:653-820)` 流程：

```
guid = ++m_dynamicSludgeGUID
ds   = new HGDynamicSludge { rebornTime, rebornAnimTime, texelSize }
ds.atlasRect = m_atlasMaxRect.InsertRect(texelSize.x, texelSize.y)
        ↓ 返回 RectInt(x,y,w,h)
// 把矩形归一化成 atlas UV
ds.atlasTillingScale = (
    w / config.textureSize.x,
    h / config.textureSize.y,
    x / config.textureSize.x,
    y / config.textureSize.y
)
// 构造世界-局部 TRS
center = atlasRect.center * 2 - 1               // [-1,1] NDC 风格
ds.matrix4X4 = Matrix4x4.TRS(
    position = (center.x, center.y, 0),
    rotation = identity,
    scale    = (atlasTillingScale.x, atlasTillingScale.y, 1)
)
m_dynamicSludges[guid] = ds
return guid
```

`AtlasMaxRect::InsertRect` 是经典 *MaxRects packing* 的 GPU 友好实现(同 `C07_ShadowASM` 的 ASM `AtlasMaxRect.cs` 共享)：维护"自由矩形集合"，每次找面积最小且能容纳的矩形并切割成最多 2 个剩余矩形。

### 7.3 SludgePassConstructor — 双 RT + Jump-Flood Blit

`SludgePassConstructor.cs:7-107` 关键字段：

```csharp
internal class SludgePassData {
    internal TextureHandle curSludgeTexture, prevSludgeTexture;
    internal Material      sludgeBlitMaterial;
    internal Mesh          quadMesh;
    internal MaterialPropertyBlock tempMaterialPropertyBlock;
    internal float lastTime, curTime;
    internal List<HGDynamicSludgePassData> hgDynamicSludges;
}
internal class SludgePassDataV2 {                       // V2 = 增加 thickness/minHeight
    internal int viewHandle;
    internal TextureHandle prevSludgeThicknessTexture;
    internal TextureHandle prevSludgeMinHeightTexture;
    internal TextureHandle curSludgeThicknessTexture;
    internal TextureHandle curSludgeMinHeightTexture;
    internal Material blitMaterial;
}
internal static readonly int _Hit;             // shaderId "_Hit"
internal static readonly int _HitRange;        // shaderId "_HitRange"
internal static readonly int _HitPosition;     // shaderId "_HitPosition"
internal static readonly int _DeltaTime;
internal static readonly int _TotalTime;
internal static readonly int _AtlasTillingOffset;
```

### 7.4 ConstructPass 流程

`ConstructPass(:742-…)` 反汇编关键 `il2cpp_codegen_initialize_runtime_metadata` 串可以重建出"渲染图依赖名"：

字符串：
- `"RenderSludge"` — pass 名(常规路径)
- `"SludgeBlitSetDefault"` — pass 名(默认资源初始化路径)
- `"prevSludgeTexture"` / `"curSludgeTexture"` / `"prevSludgeThickness"` / `"prevSludgeMinHeight"` — 上一帧/当前帧 TextureHandle 名

执行分两路：

```
if (HGSludgeRender.ShouldDrawThicknessMap() == false) {
    // 默认路径 — 把 curSludge/prev 两张资源 import 到 RenderGraph 后只做一次 default blit
    builder.AddRenderPass<SludgePassDataV2>("SludgeBlitSetDefault")
           .ReadTexture(prevSludgeTexture)
           .SetRenderFunc(s_defaultBlitFunc);          // 把 m_defaultThicknessMapRTHandle 写过去
}
else {
    // V2 主路径 — 装箱 + Jump-Flood
    var dynSize  = HGSludgeRender.GetDynamicThicknessMapSize();
    var desc     = new TextureDesc(dynSize, dynSize) { name="curSludgeTexture", colorFormat=... };
    builder.AddRenderPass<SludgePassData>("RenderSludge")
           .ImportTexture(m_curSludgeRTHandle, m_prevSludgeRTHandle)
           .ReadTexture(prev)
           .CreateTexture(cur_thickness, cur_minHeight)
           .CreateDepthBuffer(...)
           .SetColorAttachment([cur_thickness, cur_minHeight], depth)
           .SetRenderFunc(s_sludgeFunc);
}
```

`SetRenderFunc(s_sludgeFunc)` 的实际工作(由 shader+反编译的资源关系反推标准 Jump-Flood + Splat)：

```
foreach (HGDynamicSludgePassData ds in passData.hgDynamicSludges) {
    // 1) 用 sludgev2.shader 把当前 atlasRect 内容做 jump-flood 一步(扩散+消退)
    mpb.SetVector(_AtlasTillingOffset, ds.atlasTillingScale)
    mpb.SetFloat(_DeltaTime, curTime-lastTime)
    mpb.SetFloat(_TotalTime, curTime)
    if (ds.recentHit) {
        mpb.SetFloat(_Hit, 1)
        mpb.SetVector(_HitPosition, ds.recentHitInfo.point)
        mpb.SetFloat(_HitRange, ds.recentHitInfo.range)
    } else mpb.SetFloat(_Hit, 0)
    cmd.DrawMesh(quadMesh, ds.matrix4X4, sludgeBlitMaterial, 0, 0, mpb)
}
```

> `sludgev2.shader` 在每个 atlas 子区跑两件事：(a) 时间相关消退 `thickness *= exp(-dt / disappearTime)`；(b) 如 `_Hit=1`，把 hit 点周围 `_HitRange` 像素的 thickness 写到峰值。`dynamicsludgeblit.shader` 在帧末把 cur thickness 做一次 jump-flood 扩散，模拟泥浆"沿地面流开"。

详细算法见 `../02-CoreAlgorithms/01-CoreAlgorithms.md` §15.1。

### 7.5 HGSludgeAlignedPlane — 切割 / 钳制平面

`HGSludgeAlignedPlane.cs:5-435` 是给地面材质用的"泥浆是否到这里就停下"的几何约束：

```csharp
public struct HGSludgeAlignedPlane {
    public bool enabled;
    public HGSludgeAlignedPlaneType type;   // X+/-, Y+/-, Z+/-
    public HGSludgePlaneClipMode  clipMode;  // Clip(裁掉) / Clamp(限位)
    public float coeff;                      // 平面坐标(沿 type 轴)
}
```

- `EncodeToUInt(origin)` (`:339-435`)：
  ```
  half  = float_to_half(coeff - origin[axis])
  encoded = (uint)half
          | ((type & 1) << 16)
          | ((type >> 1) << 18)
          | (clipMode  << 20)
  ```
  把 half 精度坐标 + type(3 bits) + clipMode(1 bit) 打成 22 bit uint，省 cbuffer。`HGSludgeData` 中两个 `encodedClipPlane0/1` 就是这个。
- `ApplyCoeff(pos)` (`:19-93`)：按 `type` 替换 pos 对应分量为 `coeff`(Clamp 模式)。
- `GetPlaneNormal/Size` (`:158-336`)：给 shader 提供平面法线和"在该平面上的 2D 尺寸"。

### 7.6 HGDynamicSludgeHit 注入

```csharp
// Sludge/HGDynamicSludgeHit.cs:5-13
public struct HGDynamicSludgeHit {
    public float   time;     // 命中时刻(World time)
    public Vector2 point;    // atlas UV [0,1]²
    public float   range;    // 影响半径(像素)
}
// Sludge/HGDynamicSludgePassData.cs:5-19
public struct HGDynamicSludgePassData {
    public Vector4 atlasTillingScale;
    public Matrix4x4 matrix4X4;
    public float rebornTime, rebornAnimTime;
    public bool  recentHit;
    public HGDynamicSludgeHit recentHitInfo;
}
```

上层 ECS 把"角色脚部 vs 泥浆 collider" 命中事件转成 `HGDynamicSludgeHit`，每帧塞给 PassConstructor → blit 到 atlas → shader 端 sample 出深色脚印。

---

## 8. Ink — `_InkSimulationResultA/B` 双缓冲交互流体

> 证据等级 ①：`InkSimulationPassConstructor.ConstructPass :120-233` 直接看到 `il2cpp_codegen_initialize_runtime_metadata("_InkSimulationResultA")` 与 `("_InkSimulationResultB")` 字符串、`SetGlobalTexture` 调用、`(material, influence, center, deltaTime)` 入参。

### 8.1 接口

```csharp
internal class InkSimulationPassConstructor : IPassConstructor {
    private long m_impl;                                          // 指向 native 实现的 unmanaged 句柄
    void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal sg);
    void IPassConstructor.OnPreRendering(ref PassEventInput input);
    void IPassConstructor.OnPostRendering(ref PassEventInput input);
    internal void ConstructPass(HGRenderGraph renderGraph,
                                Material material, float influence,
                                Vector3 center, double deltaTime);
    void IPassConstructor.Dispose(HGRenderGraph renderGraph);
}
```

C# 侧极薄——`m_impl` 表示主体逻辑在 native (`hginksimulation.shader` + `HGInkSimulation` C++ pass)。

### 8.2 ConstructPass 反汇编重建

```
ConstructPass(rg, material, influence, center, dt):
  if (rg?.tex.A == null || rg?.tex.B == null)
      ↳ 用 Texture2D.blackTexture 作 fallback
  cmd.SetGlobalTexture("_InkSimulationResultA", rg.tex.A)
  cmd.SetGlobalTexture("_InkSimulationResultB", rg.tex.B)
  ILFix 走 dispatcher: __Gen_Wrap_985(this, material, influence, center.xyz, dt)
```

`_Gen_Wrap_985` 调度到 native 端按 `material.shader` 选择 simulation kernel。**双 RT ping-pong**：A 是上一帧、B 是当前帧；每帧 swap，给 `SetGlobalTexture` 设置完毕后所有要采样墨水的 shader(角色服装、武器特效)直接读 `_InkSimulationResultA`。

### 8.3 算法语义重建(与 §15.2 一致)

```
worldPos → texSpace(center)
density(t+dt) = density(t) * decay + influence * gaussian(d, range)   // 注入
density(t+dt) = max(density(t+dt) - waterInk * waterMask, 0)          // 水净化
density(t+dt) += dt * (∇²density) * diffusion                          // 扩散
```

- `influence` 入参 = 当前命中力度；
- `center` Vector3 = 命中点世界坐标；
- `deltaTime` = 上一次 simulation 步进至今的 dt(double 精度避免抖动)；
- `HGInkSimulationConfig.disableWaterInk` 关掉"水中也能泼墨"。

---

## 9. Frost — 磨砂玻璃后效

`FrostedGlass.cs:6-48` 是 `VolumeComponent`，三参数：

```csharp
public ClampedFloatParameter colorThreshold;   // 高于该阈值的颜色才被磨砂
public ClampedFloatParameter downsampleScale;  // 下采样倍率
public ClampedIntParameter   downsampleNum;    // 下采样次数
```

`IsActive()` 反汇编返回 false 走 IFix patcher 代理(`:16-46`)，说明实际开关由 IFix C# 热补丁运行时决定(不是 cbuffer 字段)。算法标准 Frosted Glass 后效：

```
foreach mip in 0..downsampleNum:
    color = Downsample( color, downsampleScale )      // 高斯/box 半径递增
mask  = step(colorThreshold, luminance(originalColor))
final = lerp(originalColor, blurred, mask)
```

下采样次数越多越"磨"；阈值用于"只让亮色被霜化"——常用于车窗灯光雪花。

---

## 10. 1:1 重建蓝图(按子系统分步)

### 10.1 重建 Rain
1. 实现 `RainCommonResources` 资源池(8 个引用)；
2. 实现 `HGRainConfig`(63 字段)、`HGRainPresettingAsset` 包 `RainCommonPreSettingParam`；
3. 实现 `HGRainRenderer` + `RainWetnessRenderSeq`：每 `HGCamera` 一份 seq，`CreateDefaultFeatures` 注册 4 subRain + 3 wetness；
4. 4 个 sub-renderer(Far/SceneEffect/Splash/ScreenFX) 各自的 PrepareResources/UpdateData/SetMaterialData/Render；FarRain 用 spindle mesh、SceneEffect 4 层、Splash flipbook、ScreenFX 30-quad atlas mesh + NativeArray<Vector4> 缓冲；
5. `_RequestOcclusionMap` 接上 `HGVerticalOcclusionMapManager`；
6. `UpdateRainAndWetnessShaderVariables` 统一入口；
7. shader 端实现雨方向 `lastCamPos` EMA 修正 + Flipbook 索引。

### 10.2 重建 Wetness
1. 实现 `RainWetnessGlobalProps.rainWetnessGlobalParams[≥10]`；
2. 实现 `HGGlobalWetness.UpdateData`(从 commonParam +0x100..+0x144 拷字段) → `SetData` 写 slot 0/8/9；
3. 实现 `HGWetnessVerticalFlow.UpdateData`(`m_verticalFlowUVOffset += dt * speed / 30`) → `SetData` 当 normalStrength<=0 时 ResetData 清零，否则写 slot 1/2；
4. 复用 `HGWetnessRipple` 写 slot 5/6(见 `./01-WaterOcean.md` §3)；
5. shader 端从 9 个 vec4 解出 wetness/porosity/flow ST + uvOffset/ripple frequency 等，做 BRDF 调制：`albedoWet`/`roughnessWet`/`normalWet` 公式见 §4.3。

### 10.3 重建 Snow
1. 实现 `HGSnowConfig`(`HGSnowConfig.cs`)；
2. `HGSnowRenderer` + `SnowRenderSeq` 注册单一 `HGSceneEffectSnowRenderer`(RQ=3000)；
3. 6 层 `Transform+MeshRenderer+MPB+AxisOffset+Direction+JitterNoise`；
4. 雪花飘忽 = `pos += speed.xy * dt + perlin(time*snowSpeedNoiseFreq) * snowSpeedNoiseLevel`；
5. character snow 接 `HGCharacterShader`、地面 snow 接 `HGTerrainDeformManager`(C02)。

### 10.4 重建 Wind
1. 实现 `HGWindManager` facade(三档 quality) + `HGWindSimpleManager`；
2. `m_windFootMotors[4]` + `m_windMotors: List<HGWindMotor>` + `Dictionary<int,HGMainWindState>`(每相机) + `List<HGWindMotorState>`(每 motor)；
3. 每帧 `GamePlayUpdate` → 60 秒清理 stale；
4. `SetupShaderVariablesGlobalWind`：`_SetupShaderVariablesWindMain`(从 phase 取 windConfig speed/dir/intensity, 与上一帧 lerp 得 `curWindTime/curNoiseUV`) → `_SortWindMotorsForSingleCamera(cameraPos)` 按 priority+distance 排前 4 → 写 cb 偏移 0x450/0x460/0x4C0..0x590/0x5C0/0x5D0；
5. shader 用 `_WindGlobalParams0/1` + `_WindMotorParams[0..3]` + `_WindMotorCount` + `_WindLeafFade*` 推动草/布料/云顶点动；
6. 实现 `WindEulerAngleToDirection` / `WindSpeedToBeaufortWindScale`(Mathf.Sqrt 拟合)。

### 10.5 重建 Sludge
1. 实现 `HGSludgeConfig{textureSize, graphicsFormat}` + `AtlasMaxRect` (与 ASM 共享)；
2. `HGSludgeManager` Dict<int,HGDynamicSludge> + `RequireDynamicSludge(texelSize, rebornTime, rebornAnimTime)` 用 InsertRect + TRS；
3. `SludgePassConstructor` 双路径：`ShouldDrawThicknessMap=false` 走 default blit；true 走 V2 (`curSludgeThickness/MinHeight` 双 RT)；
4. shader (`sludgev2.shader`)：每个 atlas 子区做时间消退 + `_Hit=1` 时按 `_HitPosition / _HitRange` splat；
5. shader (`dynamicsludgeblit.shader`)：在帧末做一次 jump-flood 扩散；
6. 地面材质：sample atlas 时用 `atlasTillingScale` 计算子区 UV，并消费 `clipPlane0/1` 的 `EncodeToUInt` 22-bit 编码做空间 clip；
7. 接入 ECS：`HGSludgeUtils.CreateEntity(...)` (`HGSludgeUtils.cs:17-` 18 个参数) 在 ECS world 创建一条泥浆实体，附带 Transform/Mesh/heightmap/nodeData。

### 10.6 重建 Ink
1. `InkSimulationPassConstructor.ConstructPass(rg, material, influence, center, dt)`；
2. 双 RT `_InkSimulationResultA/B` ping-pong；
3. native 端 simulation kernel：injection (gaussian splat) + decay + 水净化 + laplacian diffusion；
4. shader 端把 `_InkSimulationResultA` 当 mask 调制角色服装/武器特效；
5. 详见 `../02-CoreAlgorithms/01-CoreAlgorithms.md` §15.2。

### 10.7 重建 Frost
1. `FrostedGlass : VolumeComponent` 三 ClampedParameter；
2. Pass：`downsampleNum` 级渐进式下采样 + 累乘 `downsampleScale` 半径 + `colorThreshold` 阈值 mask。

---

## 11. 关键常量 / 魔数汇总

| 常量 | 值 | 来源 | 语义 |
| --- | --- | --- | --- |
| `MAXDROPCOUNT` | 30 | `HGScreenRainDropFXRenderer.cs:23` | 屏幕雨滴最大数 |
| `DROPRENDERDATA_BUFFER_SIZE` | 480 | `:25` | =30×16 字节 |
| `s_maxSceneEffectLayerCount` (rain) | 4 | `HGSceneEffectRainRenderer.cs:46` | 中近景雨层数 |
| `s_maxSceneEffectLayerCount` (snow) | 6 | `Snow/HGSceneEffectSnowRenderer.cs:39` | SceneEffect 雪层数 |
| `SCREEN_RAIN_DROP_RENDERQUEUE` | 3003 | 反汇编 `mov edx,0BBBh` | 屏幕雨滴 RQ |
| `Snow SceneEffect RQ` | 3000 | 反汇编 `mov edx,0BB8h` | 雪场景 RQ |
| `MAX_WIND_MOTOR_COUNT` | 4 | `HGWindSimpleManager.cs:44` | 区域风电机数 |
| `MAX_WIND_FOOT_MOTOR_COUNT` | 4 | `HGWindManager.SetWindFootMotor` `cmp ebx,3` | 角色脚步风电机数 |
| `CLEANUP_INTERVAL` | 60f | `HGWindSimpleManager.cs:48` | 风状态 GC 间隔(秒) |
| `MAX_SYSTEM_WIND_SPEED` | 30f | `HGWindUtils.cs:7` | 风速上限(m/s) |
| `windTime normalization` | × 1/30 | `_SetupShaderVariablesWindMain` `g_18C47163C` | curWindTime 编码归一化 |
| `verticalFlow dt scaler` | 1/30 | `HGWetnessVerticalFlow.UpdateData` `g_18C471CE8` | UV offset 与帧率解耦 |
| `Color.clear cache` | (0,0,0,0) | `g_18C471680` (`HGGlobalWetness.ResetData`) | wetness reset 写黑 |
| `0xBBB / 0xBB8` | 3003 / 3000 | RQ 配置 | ScreenDrop / Snow |
| `HGSludgeAlignedPlane EncodeToUInt 位宽` | 16+1+2+1 | `:339-435` | half + clipMode + type 3bit |
| `acneFixNormalBiasScale` | 由设置驱动 | `RainWetnessQualityParams.cs:2789` | 雨遮蔽图 normal bias 修正 |

### Wetness GlobalParams Slot 映射(汇总)

| Slot | Writer | (x,y,z,w) |
| --- | --- | --- |
| 0 | GlobalWetness | wetness, basePorosity, porosityFactor, baseWetnessLevel |
| 1 | VerticalFlow(HQ) | uvOffsetAccum, surfaceThreshold, normalStrength, · |
| 2 | VerticalFlow | speed, vflowST.x, vflowST.y, porosityBias |
| 3 | OcclusionMap | normalBias×vScalar, depthBias, ·, · |
| 4 | OcclusionMap | jitterMode, sampleMode, cloudShadowScalar, · |
| 5 | Ripple | rippleFrequency, normalStrength, waveSpeed, waveNormalStrength |
| 6 | Ripple | rippleRoughnessMaskThr, ·, ·, · |
| 7 | OcclusionMap | sampleNoise.xyz, cameraMaskCount |
| 8 | GlobalWetness | verticalScalar, occlusionRange, farDistFactor, farValue |
| 9 | GlobalWetness | proceduralForWater, hqReflection, 0, 0 |

### Wind cb 偏移(汇总)

| 偏移(字节) | 内容 |
| --- | --- |
| 0x450 | `_WindGlobalParams0` cur (windTime / noiseUV.xy / intensity) |
| 0x460 | `_WindGlobalParams1` last(同上但上一帧) |
| 0x4C0..0x590 | `_WindMotorParams[0..3]` 4 motor × 4 vec4 |
| 0x5C0 | `_WindMotorCount` |
| 0x5D0 | 当前帧 windMain 快照(给下一帧 lerp) |

---

## 12. 源文件清单(52)

### 12.1 顶层 Config / Param
| 文件 | 行数 | 职责 |
| --- | --- | --- |
| `HGRainConfig.cs` | 35462 | 全局雨配置(63 字段 Lerp) |
| `HGRainAndWetnessSettingParameters.cs` | 799 | 画质设置接入 |
| `HGRainPresettingAsset.cs` | 320 | ScriptableObject 包 RainCommonPreSettingParam |
| `HGSnowConfig.cs` | 9008 | 全局雪配置 |
| `HGSnowPresettingAsset.cs` | 320 | 雪 ScriptableObject |
| `HGSnowSettingParameters.cs` | 317 | 雪画质设置 |
| `HGWindConfig.cs` | 4375 | 全局风(IEnvConfig) |
| `HGWindShape.cs` | 99 | enum Sphere/Rect |
| `HGWindPriority.cs` | 102 | enum Map=-10/Skill=0 |
| `HGWindMotorData.cs` | 722 | 风电机数据 struct |
| `HGWindParamDataCache.cs` | 548 | 风 cbuffer 快照 |
| `EWindFieldType.cs` | 126 | Directional/Circular/Vortex |
| `FWindFieldData.cs` | 237 | 风场 5×Vector4 数据包 |
| `HGSludgeConfig.cs` | 295 | atlas 尺寸 + 格式 |
| `HGSludgeData.cs` | 661 | 单条泥浆数据(ECS 共用) |
| `HGSludgeAlignedPlane.cs` | 11142 | 切割平面 + uint 编码 |
| `HGSludgeAlignedPlaneType.cs` | 340 | enum X+/-..Z+/- |
| `HGSludgePlaneClipMode.cs` | 108 | Clip/Clamp |

### 12.2 渲染器
| 文件 | 行数 | 职责 |
| --- | --- | --- |
| `HGRainRenderer.cs` | 147832 | 主调度(`RainWetnessRenderSeq`) |
| `HGFarRainRenderer.cs` | 54157 | 远雨锥(纺锤体) |
| `HGSceneEffectRainRenderer.cs` | 28770 | 中近景 4 层雨 |
| `HGRainSplashRenderer.cs` | 27160 | 地面雨花 |
| `HGScreenRainDropFXRenderer.cs` | 47515 | 屏幕 30 雨滴 |
| `HGSnowRenderer.cs` | 96915 | 主调度(SnowRenderSeq) |
| `Snow/HGSceneEffectSnowRenderer.cs` | 41104 | SceneEffect 6 层雪 |
| `Snow/HGBaseSubSnowRenderer.cs` | 9498 | sub-snow 抽象基 |
| `Rain/HGBaseSubRainRenderer.cs` | 9818 | sub-rain 抽象基 |
| `Rain/HGBaseWetnessFeature.cs` | 3087 | wetness feature 抽象基 |
| `Rain/HGGlobalWetness.cs` | 9441 | 主湿度 feature(slot 0/8/9) |
| `Rain/HGWetnessVerticalFlow.cs` | 10758 | 垂直流(slot 1/2) |
| `Rain/HGRainRendererUtils.cs` | 12693 | EMA 权重 + 屏幕 quad mesh 工具 |

### 12.3 通用资源 / 参数
| 文件 | 行数 | 职责 |
| --- | --- | --- |
| `Rain/RainCommonResources.cs` | 407 | mesh+shader 池 |
| `Rain/RainCommonPreSettingParam.cs` | 3583 | 美术写死参数 |
| `Rain/RainCommonRenderingParam.cs` | 2668 | 运行期参数(逐帧拷 HGRainConfig) |
| `Rain/RainWetnessGlobalProps.cs` | 233 | 9-slot Vector4[] 全局props |
| `Snow/SnowCommonResources.cs` | 166 | mesh+shader 池 |
| `Snow/SnowCommonPreSettingParam.cs` | 550 | 美术写死参数 |
| `Snow/SnowCommonRenderingParam.cs` | 753 | 运行期参数 |

### 12.4 风
| 文件 | 行数 | 职责 |
| --- | --- | --- |
| `HGWind.cs` | 106 | MonoBehaviour 标记 |
| `HGWindManager.cs` | 11911 | 三档 quality facade |
| `HGWindSimpleManager.cs` | 101219 | 主实现(motor/foot/state/setup cb) |
| `HGWindMotor.cs` | 44115 | 区域风电机(继承 VFXPlayable) |
| `HGWindUtils.cs` | 3247 | EulerAngle↔Direction / Beaufort |

### 12.5 泥浆 / 墨水 / 霜 / Misc
| 文件 | 行数 | 职责 |
| --- | --- | --- |
| `HGSludgeManager.cs` | 33243 | Dict 管理 + RequireDynamicSludge |
| `HGSludgeUtils.cs` | 81858 | ECS bridge (CreateEntity) |
| `SludgePassConstructor.cs` | 43994 | 渲染图双路径 |
| `Sludge/HGDynamicSludge.cs` | 383 | 单条 atlas 子区状态 |
| `Sludge/HGDynamicSludgeHit.cs` | 184 | 命中事件(time/point/range) |
| `Sludge/HGDynamicSludgePassData.cs` | 323 | 上传给 PassConstructor |
| `InkSimulationPassConstructor.cs` | 6533 | 双 RT ping-pong 接入 |
| `FrostedGlass.cs` | 1130 | VolumeComponent 后效 |
| `DrawIndirectArgBuffer.cs` | 275 | IndirectArgBuffer struct(被多个雨/雪流用) |

---

## 13. 已知未决项

1. **shader 端的精确公式**：`HGGlobalWetness` 的 Burley 湿度系数(kBurley≈0.55) 与 `wetnessPorosityFactor` 的耦合阶数尚未通过 shader 直接确认；本文 §4.3 给出的公式由 slot 字段语义 + Burley 行业标准 + porosity 范围 [-1,1] 推得，**可能与 HG 实际 shader 在最后一阶项上有轻微差异**。
2. **`acneFixNormalBiasScale` 的具体作用尺度**：`RainWetnessQualityParams.cs:2789` 命名暗示用于雨遮蔽图采样的 shadow acne 修正，但反编译里只是被 `Pack` 进 slot 3(.x)，shader 端的最终用法需 `hgrainocclusion.shader` 确认。
3. **`HGRainRenderer.GPUParticleRain` mask=4 的实现类未在本单元出现**：可能在另一个子目录或直接走 VFX Graph。
4. **HGWindSimpleManager.HighManager 路径**：`WindQuality.High` 在反汇编中未发现独立类，疑似与 Simple 共用但 shader keyword 不同；本文按"共用 Simple"叙述。
5. **`HGSludgeAlignedPlane.EncodeToUInt` 比特布局位宽**：half(16) + planeAxis(2) + planeSign(1) + clipMode(1) 共 20 bit，剩余 12 bit 用途从反汇编看似未使用，但 `HGSludgeData.encodedClipPlane0/1` 是 32 位，预留可能用于将来扩展(如 thickness 缩放)。
6. **`HGInkSimulation` native kernel 的具体 dispatch 尺寸**：C# 端是空壳，全部走 `m_impl` 句柄。需要 native 反编译或 shader 反编译进一步确认。
