# HG Render Pipeline — Water / Ocean (水体 / 海洋 / 水面装饰) 技术实现原理蓝图

> 本文是 **从零 1:1 重建** 终末地 (EndField) HG.RenderPipelines 水体子系统的实现蓝图。
>
> **算法来源声明（§1.5 零偏差）**:
>  HDRP 同源水体仿真的算法 / 公式 / 常量 / 线程组尺寸 **据 HDRP 真实源 `com.unity.render-pipelines.high-definition@75de48326bcd/Runtime/Water/**` 1:1 照抄并 cite `文件:行`**。
>  HG 反编译 C# 仅作两类用途：
>   ① 标注 **HG 相对 HDRP 的 delta**（HG 拆掉 FFT 频谱仿真、改成 **「sector 3×3 流式 atlas + 静态法线贴图 + 局部 Ripple 仿真 + 1298‑Vector4 全局聚合 cbuffer + WaterOnePassDeferred 6‑SubPass」** 的工业管线）；
>   ② 锁定 HG 特化的常量取值 / 容量上限 / cbuffer 布局 / `MaterialPropertyBlock` slot 编号。
>  每条 delta 后面挂 **反编译 `文件:行` 或常量** 证据；纯算法公式则 **必 cite HDRP `文件:行`**。
>
> 配套已有文档（不复述、只链）：
> - litwater / waterrendering / ripple compute shader：[`../10-Shaders/01-Shaders.md`](../10-Shaders/01-Shaders.md) §3.4 / §4.5
> - 透明阶段水面合成 + `sceneDepthWithWater`：[`../01-PipelineCore/02-GeometryPasses.md`](../01-PipelineCore/02-GeometryPasses.md) §3.7
> - GBuffer 与单/多 Pass：[`../01-PipelineCore/02-GeometryPasses.md`](../01-PipelineCore/02-GeometryPasses.md) §3.1–§3.5
> - 透明排序与水下 SSR 反射：[`./09-GI-IrradianceSH.md`](./09-GI-IrradianceSH.md) §`HyperScreenSpaceReflectionRenderingPass`

---

## 0. 目录

| § | 主题 |
|---|------|
| 1 | 该系统解决什么渲染问题 / 最终视觉效果 |
| 2 | HG 水系统拓扑 + HDRP 血缘对照表（核心 delta 一图）|
| 3 | 全局数据模型：1298‑Vector4 `waterGPUData` 大缓冲 + 20‑Vector4 `waterRippleData` |
| 4 | 数据准备 CPU 通道：`HGWaterManager.PipelineUpdate` 的 5 阶段聚合 |
| 5 | Sector 流送系统：3×3 mod‑3 atlas（HG 特有，HDRP 无对应）|
| 6 | Ripple 交互系统：8 槽优先级队列 + 3 Pass（Add / Simulate / HeightConvertToNormal）|
| 7 | 频谱海洋算法的 HDRP 同源参考（HG 已剪枝；保留作为 1:1 蓝图后备）|
| 8 | 水面渲染主流水线：`WaterOnePassDeferredRenderingPass` 6‑SubPass + V2 间接 / Tessellation |
| 9 | 透明阶段 fallback：`WaterDefaultDeferredRenderingPass` PassData 全字段语义 |
| 10 | 水下 + 焦散 + 折射：HDRP 同源算法 + HG MaterialPropertyBlock 通道 |
| 11 | 水面装饰：WaterDecal 4 PassID + WaterProxy 6 PassID + Wetness 3D mask |
| 12 | Rain `HGWetnessRipple`：雨滴涟漪叠加进水面法线 |
| 13 | ECS 接入：`HGWaterRendererV2` → `HGWaterComponent` + Bounding* + RenderObjectInfo |
| 14 | 1:1 复刻蓝图（分步落地）|
| 15 | 关键常量 / 魔数总表 |
| 16 | 源文件清单（23 个，每个一行职责）|

---

## 1. 该系统解决什么渲染问题 / 最终视觉效果

| 视觉效果 | HG 实现路径 | 关键质感 |
|---|---|---|
| 大面积海洋 / 湖泊 / 河流 | sector 3×3 流式 atlas + LOD 网格 + 静态法线贴图阵列（`normalMapArray`）+ flowmap 二维流向 | 远景平滑、近景细密、流动方向可控 |
| 大小双层波浪 + 顶点位移 | 同一 `HGWaterConfig` 携带 `smallWaveNormalType` / `largeWaveNormalType` 两套 + `flowFullCycle` 大小循环 | 双频叠加波纹、可视位移 |
| 水体颜色 / 散射 / 吸收（瑞利+米氏混合）| Beer-Lambert 衰减 + 双色 `absorptionTint`/`absorptionTint2` 渐变 + `rayleighMieLerpFactor` | 浅水透明、深水偏蓝/绿 |
| 折射 + 屏幕空间反射 | `WaterOnePassDeferred` 的 Reflect SubPass + `HyperScreenSpaceReflectionRenderingPass`（C09）| 水面镜像、IOR=0.67 默认 |
| 白沫（岸边 / 浪尖 / 角色周围）| `foamOpacity` / `foamFadeDistance` + foamG 第二通道 + `flowBaseColor` | 距离衰减、波峰白沫、自发光 |
| 焦散（水下光斑）| `causticMap` 平铺 + `causticDistort` 扰动 + `causticStartDepth`/`causticEndDepth` 渐变 | 起始/结束深度可控的光斑 |
| 角色 / 物体交互涟漪 | `WaterInteractionRenderingPass` 的 Add → Simulate → HeightConvertToNormal 3 Pass + RippleDataManager 8 槽优先级队列 | 角色周围扩散圈、波峰锐度可调 |
| 静止涟漪 / 移动涟漪 | `stillRippleFrequency` / `moveRippleFrequency` 控制自动涟漪生成 | 风吹静水波纹 + 角色移动尾迹 |
| 雨滴打在水面 | `HGWetnessRipple` 的 `rippleTexture` + `rippleRowColumnCount` 分帧采样 | 雨点扩散水波 |
| 表面打湿（陆地受水浸润）| `enableWetnessMask` + `wetnessOffset` + 3D mask 噪声 | 河岸石头被水打湿的暗化效果 |

---

## 2. HG 水系统拓扑 + HDRP 血缘对照表（核心 delta 一图）

```
HG（终末地）水管线                          HDRP@75de48326bcd 对应
─────────────────────────────────────────  ─────────────────────────────
HGWaterGlobalConfig (Scene 锚)              WaterSurface (Component)
    sectorXNum × sectorZNum × sectorSize   一张无限大 surface, 无 sector
    flowMap / causticMap / normalMapArray    
    rainMap / sectorDataPaths[]            
        │                                       │
        ▼                                       ▼
HGWaterManager (单例)                       WaterSystem (单例)
  - waterGPUData : 1298 × Vector4           - WaterSimulationResourcesGPU
  - waterRippleData : 20 × Vector4              ├─ phillipsSpectrumBuffer (FFT)
  - m_waterConfigs[64]                          ├─ displacementBuffer (3 band)
  - 32 static + 32 dynamic 上限                  ├─ additionalDataBuffer (normal+foam)
        │                                       └─ causticsBuffer
        ▼                                       │
RippleDataManager (8 槽优先级)              （HDRP 没有这套，HDRP 用 decal+spectrum）
  - 优先级: MAIN=5..DEFAULT=0
  - IsHigherPriority/IsLowerPriority
        │
        ▼
3 个 IPassConstructor:                      partial WaterSystem 内多 step:
 1. WaterSectorRenderingPass                 - InitializePhillipsSpectrum  CS
    (3×3 mod-3 atlas, sectorTextureSize)    - EvaluateDispersion           CS
                                            - EvaluateNormals[Jacobian]    CS
 2. WaterInteractionRenderingPass            - FourierTransform Row/Col    CS
    (Add → Simulate → HeightToNormal 3 Pass)- WaterDeformation             CS
                                            - WaterFoam (Reproject/Attn)   CS
 3. WaterOnePassDeferredRenderingPass        - WaterEvaluation              CS
    或 WaterDefaultDeferredRenderingPass V2  - WaterLighting                CS
    （6-SubPass: GBufferBlit/GBuffer/        - WaterLine                    CS (underwater)
      DepthBlit/Reflect/Lighting/FSDebug）
        │                                   并行：
        ▼                                   - PowerOfTwoTextureAtlas (decal)
HGWaterRendererV2 (per-tile MonoBehaviour)  - WaterDecal 5 PassType
  → ECS Entity + HGWaterComponent             (Deformation/Foam/Mask/
    + BoundingCenter/ExtentX/Y/Z              Large+Ripples Current)
    + RenderObjectInfoComponent             - WaterDeformer (Legacy)
                                            - WaterFoamGenerator (Legacy)
```

**关键 delta（每条都在后文挂证据）：**

| # | HG 怎么做 | HDRP 怎么做 | HG 这么改的原因 |
|---|---|---|---|
| D1 | **不跑 FFT 频谱仿真**；用静态 `Texture2DArray normalMapArray`（小波 + 大波 2 张）+ 离线 `flowMap` + 局部 ripple compute | InitializePhillipsSpectrum + EvaluateDispersion + 2D FFT (Row/Col) + EvaluateNormalsJacobian，**每帧** GPU 跑 3 band × 256² | 移动端 / 风格化游戏，FFT 太重；预烘焙法线 + 局部交互 ripple 足够风格化海面 |
| D2 | **Sector 3×3 mod-3 流式 atlas**（`WaterSectorRenderingPass`），每 sector 一张 `HGWaterSectorData.waterSectorTexture0` 异步加载 | 单一 `WaterSurface`，无 sector 切片 | 终末地大世界开放场景，海域跨多 sector，HDRP 单 surface 无法 stream |
| D3 | **1298 × Vector4 单一聚合缓冲**（`waterGPUData`，layout: 0..9 全局/10..17 参数/18+ 材质×20×64 槽）+ 20-Vector4 `waterRippleData` | 多个 `ShaderVariablesWater` + `WaterSurfaceProfile[]` + 分散 cbuffer | HG 用 native plugin (`UnityEngine.HyperGryph.HGWaterRender`) 上传，单缓冲 IL2CPP MemCpy 最快 |
| D4 | **8 槽 RippleDataManager 优先级队列**（MAIN_CHARACTER=5..DEFAULT=0）+ `IsHigherPriority(priority > || (== && distance <))` | 无角色交互涟漪概念（HDRP 用 WaterDecal） | 玩家周围必须涟漪 > NPC > 默认 |
| D5 | **WaterOnePassDeferred 6 SubPass enum**（GBufferBlit / GBuffer / DepthBlit / Reflect / Lighting / FullScreenDebug） | 多个独立 RenderGraph pass | HG 把水合成进 GBuffer/Depth 的 blit 也算成 SubPass，统一 material pass index 管理 |
| D6 | **`MAX_STATIC_WATER_TYPES = 32`、`MAX_DYNAMIC_WATER_TYPES = 32`、`MAX_NUM_WATER_TYPES = 64`** 硬上限 | 无固定上限，按 WaterSurface 数量 | HG cbuffer 是定长 1298 Vector4，必须固定 |
| D7 | **`RIPPLE_SIMULATION_RANGE = 32f`、`RIPPLE_SIMULATION_SIZE = 12`、`RIPPLE_LIST_MAX_SIZE = 8`** | 无对应（HDRP 用 deformation/foam decal atlas）| 角色周围 32m 圆形仿真区，12 单位分辨率，最多 8 个角色 |
| D8 | **WaterPass 三层枚举**：`WaterProxyPassID` 6 ID / `WaterDecalPassID` 4 ID / `WaterTextureProcessPassID` 4 ID + `WaterPassName.Tessellation0/1/Lighting` | `WaterDecal.PassType` 5 个 + 直接走 RenderGraph pass 名 | HG 用同一份 material 跑多个 sub-pass index，节省 material 数 |
| D9 | **`Rain.HGWetnessRipple`**：雨水涟漪用 `rippleTexture` + `rippleRowColumnCount` flipbook，时间偏移 `rippleTimeOffset` 累加 | HDRP 无对应；雨用 decal | 风格化雨；性能远低于 FFT |
| D10 | **`HGWaterRendererV2` 每 tile MonoBehaviour → ECS Entity**（HGWaterComponent + Bounding* + RenderObjectInfo） | HDRP 用 Mesh + Material 直渲染 | HG 用自研 ECS（`UnityEngine.HyperGryph.ECS`）跑 GPU-driven culling/sort |

---

## 3. 全局数据模型：1298-Vector4 `waterGPUData` 大缓冲 + 20-Vector4 `waterRippleData`

### 3.1 容量常量（**逐字照抄**反编译）

```csharp
// HGWaterManager.cs (HG.Rendering.Runtime)
public const int INVALID_MATERIAL_INDEX            = -1;
public const int MAX_STATIC_WATER_TYPES            = 32;
public const int MAX_DYNAMIC_WATER_TYPES           = 32;
public const int MAX_NUM_WATER_TYPES               = 64;
public const int WATER_DEFAULT_TEXTURE_SIZE        = 2;
public const int WATER_RIPPLE_DATA_VECTOR4_COUNT   = 20;
public const int WATER_GPU_DATA_PARAMS_START       = 10;
public const int WATER_GPU_DATA_MATERIAL_START     = 18;
public const int WATER_GPU_DATA_MATERIAL_VECTOR4_COUNT = 20;
public const int WATER_GPU_DATA_VECTOR4_COUNT      = 1298;     // ← 单一聚合 cbuffer 容量
public const float RIPPLE_SIMULATION_RANGE         = 32f;       // 角色周围仿真半径 (m)
private const float RIPPLE_SIZE_CHANGE_SPEED       = 5000f;
private const int   RIPPLE_LIST_MAX_SIZE           = 8;
private const int   RIPPLE_SIMULATION_SIZE         = 12;
private const float characterSpeedSizeInfluence    = 0.04f;
private const float sizeRandomInfluence            = 0.04f;
private const float boatRippleRandomSize           = 0.02f;
private const float boatRippleRandomSizeSpeed      = 10f;
```
据反编译 `HGWaterManager.cs:10-94`。

### 3.2 `waterGPUData` 1298-Vector4 布局（区段化）

```
Vector4 索引   字节偏移      内容
─────────────  ────────────  ─────────────────────────────────────────
[0..9]         0..159        全局 params (前 10 个 Vector4)
                              典型槽位（据 UpdateWaterCPUAndGPUData
                              `HGWaterManager.cs:757-1244` 反汇编）:
                              [+0xA0h] flowMap/normalMapArray width/mip/etc
                              [+0xB0h] color::clear (RGBA=0)
                              [+0xC0h] color::clear
                              [+0xD0h] sectorSize 浮点 + .25f
[10..17]       160..287      runtime params 8 Vector4  (WATER_GPU_DATA_PARAMS_START=10)
[18..1297]    288..20767     材质数据：64 槽 × 20 Vector4 = 1280 Vector4
                              (WATER_GPU_DATA_MATERIAL_START=18,
                               WATER_GPU_DATA_MATERIAL_VECTOR4_COUNT=20)

  ┌── 每个 64 槽位的 20 Vector4 内布局
  │     (据 HGWaterConfig.CopyConfig 反汇编, edx 0..0x13=20 次 SetValue):
  │   slot[0]  absorptionTint (Color.toVector4)
  │   slot[1]  normalScale.x, smallWaveNormalType, normalTilling.y, normalTilling.z (4 float)
  │   slot[2]  absorptionTint2
  │   slot[3]  waterRayleighScatteringMeter
  │   slot[4]  waterRayleighAbsorptionMeter
  │   slot[5]  flowDirectionVector.xy, 0, ±1 (largeWaveInvDir → ±1)
  │   slot[6]  waveVertexDisplacementScaler, displacementNormalStrength,
  │            distanceNormalMinStrength, scatterScale
  │   slot[7]  envLightIntensity, envSpecularDesaturation, sceneColorEnvInfluence,
  │            specular
  │   slot[8]  emissiveStrength, foamShapeOffset, foamRoughness, foamOpacity
  │   slot[9]  rippleNormalEdgeWidth, foamDisplacementDistance, foamFadeDistance,
  │            absorptionScale
  │   slot[10] safeFullAbsorpDistance, distanceEdgeBlendFactor, distanceBlend,
  │            distanceFade
  │   slot[11] envLightSpecularIntensity, dirSpecNormalScaler, rayleighMieLerpFactor,
  │            roughness
  │   slot[12] interactiveSpeed, interactiveRippleSize,
  │            interactiveRippleForwardOffset, (1/waterIOR)
  │   slot[13] causticTilling, causticDistort, causticSpeed, 32.0(常量)
  │   slot[14] causticEndDepth, causticStartDepth, waterBaseColorSubsurfaceScaler,
  │            causticOpacity
  │   slot[15] 0(常量), foamColorG.r, foamColorG.g, foamColorG.b   ← isGamePlayConfig 时 = 0
  │   slot[16] flowSpeed, normalTilling, normalScale(int→float), (largeWaveInvDir?1:-1)
  │   slot[17] interactiveBeta, 0, 0, 0
  │   slot[18] Color.clear  (foam tint 占位)
  │   slot[19] Color.clear  (备用)
```
据反编译 `HGWaterConfig.cs:712-984`（`CopyConfig` 方法的 20 次 `MaterialData.SetValue` 调用，每次 edx 编号 0..0x13）。

### 3.3 单材质 20-Vector4 写入路径：`MaterialData.SetValue`

```csharp
// HGWaterConfig.MaterialData : NativeArray<Vector4>(20, Persistent)
public void SetValue(int index, Vector4 value)
{
    // 反汇编:
    //   mov rax,[rsi]              ; rsi = NativeArray<Vector4> handle
    //   mov rcx,rdi                ; rdi = index
    //   movups xmm0,[rbx]          ; xmm0 = value (4 float)
    //   add rcx,rcx                ; index*2
    //   movups [rax+rcx*8],xmm0    ; *(Vector4*)(rax + index*16) = xmm0
}
```
据反汇编 `HGWaterConfig.cs:301-347`。**index ∈ [0, 19]**；总长 20 Vector4 = 320 字节，对应每个水材质上传到 `waterGPUData[18 + materialIndex*20 .. +20]`。

### 3.4 `UpdateStaticWater` / `UpdateDynamicWater` 上传路径

```csharp
public void UpdateStaticWater(string name, int materialIndex, ref NativeArray<Vector4> materialData)
{
    // 反汇编验证:
    //   cmp ebx, 1Fh                ; materialIndex 必须 ≤ 31 (MAX_STATIC=32)
    //   ja  LOG_ERROR               ; 否则输出错误日志
    //   lea eax,[rbx+rbx*4]
    //   shl eax,6                   ; offset = materialIndex * 5 * 64 = materialIndex * 320 字节
    //   add eax,120h                ; +0x120 = 288 字节 = 18 Vector4 (= WATER_GPU_DATA_MATERIAL_START)
    //   call UnsafeUtility::MemCpy(dst, src, 0x140)  ; 0x140 = 320 字节 = 20 Vector4
}
```
据反汇编 `HGWaterManager.cs:1246-1317`。**关键算术**：每槽位偏移 `0x120 + materialIndex * 0x140 = 288 + materialIndex * 320` 字节，刚好匹配 §3.2 的 18+materialIndex*20 Vector4 起点。`MemCpy` 长度 `0x140 = 320 字节 = 20 Vector4`（一整个 `MaterialData`）。

**Dynamic 路径同理但 static+32**：动态材质从 `materialIndex=32` 起算（HG 用 IL2CPP MemCpy 0x140 字节，反汇编 `HGWaterManager.cs:1319+` 同 layout）。

### 3.5 `waterRippleData` 20 Vector4 布局

`waterRippleData : NativeArray<Vector4>(20)` 由 `RippleDataManager` 聚合 8 个 InputRippleData（每个携带 `positionXZ`, `size`, `distanceXZ`, `priority`）+ 全局 ripple 参数（damp/alpha/beta/speed 来自 `HGWaterInteractiveSetting`）。

```
[0]      centerRippleData(玩家): position.x, position.z, size, priority
[1..8]   8 个 InputRippleData (RippleDataManager._list[0..7])
         每个: position.x, position.z, size, distance ⊕ priority(pack)
[9..12]  全局参数: interactiveDamp/Alpha/Beta/Speed,
         interactiveRippleSize, stillRippleFrequency, moveRippleFrequency,
         rippleNormalStrength
[13..16] 地形涟漪强度配置 (terrainRippleStrengthConfig per ColliderSurfaceType)
[17..19] 备用
```
据反编译 `HGWaterManager.cs:42-44`（NativeArray 字段定义）+ `HGWaterInteractiveSetting.cs` 字段顺序。

### 3.6 native plugin 上传：`UnityEngine.HyperGryph.HGWaterRender::UpdateHGWaterGloablConfigCPP`

CPU 数据装好后，HG 通过 native plugin **一次性上传**到 GPU cbuffer：

```csharp
// HGWaterManager.PipelineUpdate -> UpdateWaterCPUAndGPUData -> ...
call HG.Rendering.Runtime.HGWaterManager::SetRippleDataToRenderPipeLine
call UnityEngine.HyperGryph.HGWaterRender::UpdateHGWaterGloablConfigCPP(
    string scenePath, int sectorNum, int sectorSize,
    int[] sectorDataAssetHashes, bool[] sectorDataExists,
    int sectorCoordsMin, int sectorCoordsMax)
```
据反汇编 `HGWaterManager.cs:480` 的 `call UnityEngine.HyperGryph.HGWaterRender::UpdateHGWaterGloablConfigCPP`。native 侧把 1298 Vector4 一次性 `cbuffer` 写到 shader 全局变量。

---

## 4. 数据准备 CPU 通道：`HGWaterManager.PipelineUpdate` 的 5 阶段聚合

每帧从 `HGRenderPipeline.Render` 调用以下序列：

```
PipelineUpdate (HGWaterManager.cs:266-529)
├─ 1. UpdateWaterCPUAndGPUData     ─ 把 64 材质 NativeArray 重排进 1298 cbuffer
├─ 2. SetRippleDataToRenderPipeLine─ 把 20 Vector4 ripple data 推到 RP
├─ 3. UpdateWaterGlobalConfigValidIndex ─ 选第一个 ShouldRenderWater() = true 的 globalConfig
├─ 4. UpdateHGWaterGloablConfigCPP ─ native plugin 一次上传 sector 元信息
└─ 5. UpdateStaticWater × 32 + UpdateDynamicWater × 32 (按需)
```

**EarlyUpdate**（更早时机）：清空 `m_rawRippleDataList`、`m_RippleDataManager` 自增内部帧戳。据反汇编 `HGWaterManager.cs:193-264`。

**Release**：3 个 NativeArray<Vector4>（waterGPUData / waterRippleData / defaultWaterMaterialData）都 `Dispose()`。据反汇编 `HGWaterManager.cs:531-587`。

---

## 5. Sector 流送系统：3×3 mod-3 atlas（HG 特有，HDRP 无对应）

这是 HG 完全自研的部分，HDRP 没有 sector 概念。

### 5.1 数据结构

```csharp
// WaterSectorRenderingPass.cs:11-27
private enum SectorState { Loading = 0, Loaded = 1, ToUnload = 2, Unload = 3 }

private struct SectorNode {
    public bool isInTexture;             // 是否已写入 atlas
    public (int, int) coords;            // sector 全局坐标 (x, z)
    public (int, int) coordsMod3;        // mod-3 atlas 内坐标 ∈ [0,2] × [0,2]
    public SectorState state;            // 4 态状态机
    public FAssetProxyHandle assetHandle;
    public string texurePath;            // HGWaterSectorData asset path
}

private struct SectorLoadingNode {
    public int sectorIndex;
    public string texturePath;
    public FAssetProxyHandle assetHandle;
    public bool Ready();                 // assetHandle.IsInvalid || .isDone
}

private const int TEXTURE_SIZE = 256;    // ← atlas 单 sector 大小（硬编码）
private const string TEXTURE_NAME = "WaterSectorTexture3x3";  // (= 256*3 = 768²)
```
据反编译 `WaterSectorRenderingPass.cs:11-243`。

### 5.2 mod-3 atlas 算法（原理叙述）

**算法目标**：玩家在世界自由移动，需要随时拿到当前位置周围 3×3 = 9 个 sector 的 flowmap/法线，但 atlas 是固定 768×768（=256×3），sector 总数 N 可能上百。

**做法（clipmap 式取模映射）**：
1. 每个 sector 的全局坐标 `(coordX, coordZ)`（来自玩家位置 → `globalConfig.GetSectorCoords(pos)`）。
2. atlas 内坐标 `coordsMod3 = (coordX % 3, coordZ % 3)`（python 风格：负数取正余）。
3. atlas 物理坐标 = `coordsMod3 * 256`，即第 `(coordsMod3.x, coordsMod3.y)` 个 tile（共 9 个 tile）。
4. 当玩家移动，新进入视野的 sector 的 mod3 坐标会**覆盖**当前 atlas tile 中那个 mod3 一样的旧 sector。
5. 旧 sector 进 `m_pendingUnloadQueue`，新 sector 进 `m_pendingLoadedQueue`（异步 `Beyond.Resource.ResourceManager.LoadAsync<HGWaterSectorData>`）。

```csharp
// WaterSectorRenderingPass.SectorLoadingUpdate (反汇编片段)
// 反汇编片段:
//   mov ecx, sub_55555556         ; 0x55555556 = 0xAAAAAAAB 的反 = mod 3 magic constant
//   imul ecx                       ; (coordX - coordsMin) * 0x55555556 → 高 32 位 = (coord) / 3
//   ...                            ; 然后 sub 得到余数 = (coord) % 3
//   mov [rsp+20h], ecx             ; coordsMod3.x
//   ...
//   mov [rsp+24h], r8d             ; coordsMod3.z
```
据反汇编 `WaterSectorRenderingPass.cs:391-577`（`Initialize` 方法对每个 sector 计算 mod3）+ 反汇编中的 `0x55555556` 魔数（除以 3 的 reciprocal 乘法）。

### 5.3 5 步流送时序（每帧）

```
Render(renderGraph, hgCamera, settingParameters)
  ├─ [1] SectorUnloadUpdate       — 处理 pendingUnloadQueue：state == ToUnload 的 → Release & Unload
  ├─ [2] SectorLoadingUpdate      — 玩家周围 (camera pos → coords ±1 × ±1) 9 sector
  │                                   遍历，若状态 == Unload → 入 pendingLoadedQueue
  │                                   异步 ResourceManager.LoadAsync<HGWaterSectorData>(priority=10)
  │                                   反汇编中 r9d = 10 是优先级常量
  ├─ [3] SectorLoadedUpdate       — 检查 pendingLoadedQueue 队首是否 Ready (handle.isDone)
  │                                   若 Ready: state = Loaded, 写入 assetHandle, dequeue
  ├─ [4] SectorTextureCopyUpdate  — 已 Loaded 但 isInTexture == false 的 → 入 pendingCopyQueue
  └─ [5] SectorTextureCopyPass    — RenderGraph pass: SectorCopyPassData {scaleBiasTex, scaleBiasRT, copyTexture}
                                     从 source HGWaterSectorData.waterSectorTexture0 (256²) 拷贝到 atlas
                                     的 (coordsMod3.x*256, coordsMod3.y*256, 256, 256) 子矩形
```
据反汇编 `WaterSectorRenderingPass.cs:725-892` (Render 方法 5 步调用链) + `SectorLoadingUpdate` 中 `r9d, 0Ah` 的优先级常量。

### 5.4 与 HDRP 的关系

HDRP **没有**这套；HDRP 用单一 `WaterSurface` + 无限重复 FFT 频谱，全局共享。HG 之所以引入 sector：
- 大世界（开放地图 ≫ 海面 patch size），每个 sector 有自己定制的 `flowmap` 和 `ripple priority`；
- 流送资产，避免一次性加载所有海域 normal/flow 贴图；
- 与 C02_Terrain 的 sector 系统（也是 3×3 mod-3 atlas）共用 streaming 策略。

---

## 6. Ripple 交互系统：8 槽优先级队列 + 3 Pass

### 6.1 RippleDataManager：8 槽优先级队列算法

```csharp
// HGWaterRipplePriority.cs (硬编码常量, 据 HGWaterRipplePriority.cs:1-17 照抄)
public const int MAIN_CHARACTER           = 5;
public const int HIGH_PRIORITY_CHARACTER  = 4;
public const int LOW_PRIORITY_CHARACTER   = 3;
public const int PLAYER_INTERACTION       = 2;
public const int NON_CHARACTER            = 1;
public const int DEFAULT                  = 0;

// InputRippleData.cs:1-15 照抄
public struct InputRippleData {
    public Vector2 positionXZ;
    public float size;
    public float distanceXZ;
    public float priority;
}
```

**优先级比较函数（核心算法）**：

```csharp
// RippleDataManager.IsHigherPriority(a, b)
//   if (a.priority > b.priority) return true;
//   if (a.priority == b.priority) return b.distanceXZ > a.distanceXZ;  // 同优先级时距离更近优先
//   return false;
```
据反汇编 `RippleDataManager.cs:411-476`：
```
movss xmm1, [rdi+10h]      ; a.priority (offset 0x10)
comiss xmm1, [rbx+10h]     ; cmp b.priority
jbe ...
movss xmm0, [rbx+0Ch]      ; b.distanceXZ (offset 0x0C)
comiss xmm0, [rdi+0Ch]     ; > a.distanceXZ ?
seta al
```

**Add 流程（带溢出策略）**：

```csharp
public void Add(InputRippleData newData) {
    // 反编译反汇编验证:
    //   - 若 list.Count < Capacity (==8): list.Add(newData);
    //     UpdateMinIndexAfterAdd: 若 _minIndex 已知且新数据 < _list[_minIndex] → _minIndex = list.Count - 1
    //   - 否则 (满载, list.Count == 8):
    //     若 IsHigherPriority(newData, _list[_minIndex]):
    //         _list[_minIndex] = newData;
    //         FindMinIndex();   // O(8) 线性扫描找新最低
}
```
据反汇编 `RippleDataManager.cs:115-409`。容量 = 8 (`RIPPLE_LIST_MAX_SIZE`)；`_minIndex` 缓存最低优先级槽位，避免每次 Add 都扫一遍。

**FindMinIndex 算法（O(N) 线性扫描）**：
```csharp
private void FindMinIndex() {
    _minIndex = 0;
    for (int i = 1; i < _list.Count; i++)
        if (IsLowerPriority(_list[i], _list[_minIndex])) _minIndex = i;
}
```
据反汇编 `RippleDataManager.cs:325-409`。

### 6.2 Reset：清空时机

`UpdateWaterState`（反汇编 `RippleDataManager.cs:644-734`）：
- 玩家**离开水面 + 等待 10 秒**（`LEAVE_WATER_WAIT_TIME = 10f`）后 → `HGWaterManager.SetShouldRenderRippleState(false)`，关闭 ripple Pass 渲染；
- 玩家**进入水面** → 立即 `shouldRenderRipple = true`，记录 `m_emptyStartTime = Time.time`。

### 6.3 WaterInteractionRenderingPass：3 个串行 RenderGraph Pass

```
                  ┌─────────────────────────────────────────┐
                  │  WaterInteractionRenderingPass.Render   │
                  └─────────────────────────────────────────┘
                                  │
   AllocateConstantBuffer(0x140 = 320 字节 = 20 Vector4 ripple data)
                                  │
                                  ▼
        ┌─────────────────────────────────────────────┐
   ProfileId=0x32 (Interaction Add)
        │ Pass 1: "Interaction Add"                   │
        │   - 读 prev simulate (m_prevSimulateTexture)│
        │   - 输出 currAddTexture (R16 单通道?)        │
        │   - material: m_interactionAddMaterial      │
        │   - shader: rippleadd                       │ 
        └─────────────────────────────────────────────┘
                                  │
   ProfileId=0x34
                                  ▼
        ┌─────────────────────────────────────────────┐
        │ Pass 2: "RippleSimulate"                    │
        │   - 读 prev/curr add (双纹理 ping-pong)      │
        │   - 输出 currSimulateTexture                │
        │   - material: m_interactionSimulateMaterial │
        │   - shader: ripplesimulate                  │
        │     算法: 离散波动方程 h_{n+1} = damp*(2*h_n│
        │       - h_{n-1} + alpha*∇²h_n) + beta*src   │
        │     (interactiveDamp/Alpha/Beta/Speed 来自   │
        │      HGWaterInteractiveSetting)              │
        └─────────────────────────────────────────────┘
                                  │
   ProfileId=0x35
                                  ▼
        ┌─────────────────────────────────────────────┐
        │ Pass 3: "RippleHeightConvertToNormal"       │
        │   - 读 currSimulateTexture (高度场)          │
        │   - 输出 currNormalTexture (R16G16 normal)  │
        │   - material: m_interactionHeightConvertMat │
        │   - 算法: ∇h 中心差分 → 法线                  │
        │     N = normalize(-∂h/∂x, 1/strength, -∂h/∂y│
        └─────────────────────────────────────────────┘
```
据反汇编 `WaterInteractionRenderingPass.cs:478-1131`：
- AddRenderPass × 3 with profile ID `0x32`, `0x34`, `0x35`；
- pass name 常量 `"Interaction Add"`, `"RippleSimulate"`, `"RippleHeightConvertToNormal"`；
- 3 个 PassData class（InteractionAddData / InteractionSimulateData / InteractionHeightConvertData）。

### 6.4 离散波动方程（据 HGWaterInteractiveSetting 4 参数推断 + ripplesimulate.shader 的存在）

HG 用的是 **2D 离散波动方程**（与 Realtime VFX 圈内 "interactive water" 标准做法一致；HGWaterInteractiveSetting 的 4 个参数与该方程吻合）：

```
h[t+1, x, y] = damp * (
    interactiveAlpha * (h[t, x-1, y] + h[t, x+1, y] + h[t, x, y-1] + h[t, x, y+1])
  + interactiveBeta  * h[t, x, y]
  - (2 - 4*alpha - beta) * h[t-1, x, y]
) + interactiveSpeed * source[t, x, y]
```
其中：
- `interactiveDamp ∈ [0.95, 1]`（`HGWaterInteractiveSetting.cs:10-11`），波能衰减率；
- `interactiveAlpha`/`interactiveBeta` 是 5 点拉普拉斯算子的系数；
- `interactiveSpeed` 控制 source 注入强度。

仿真区为玩家周围 **32m × 32m**（`RIPPLE_SIMULATION_RANGE = 32f`），离散网格 **12 × 12**（`RIPPLE_SIMULATION_SIZE = 12`），所以网格步长 `dx = 32/12 ≈ 2.67m/cell`。

（说明：算法形式据领域知识（标准 2D wave equation FDM）重建；具体 alpha/beta 系数表达式需对照 `ripplesimulate.shader` 源确认，**这是本节唯一一个 ② 反编译推断 + ③ 领域知识混合的点**，但形态与 HGWaterInteractiveSetting 4 参数完美吻合。）

### 6.5 `WaterInteractionSafeDeltaTime`：避免大 dt 数值爆炸

```csharp
// WaterInteractionRenderingPass.UpdateWaterInteractionSafeDeltaTime(dt)
// 反汇编片段:
//   movss xmm0, [g_18E5EC464]      ; 下限 (典型 1/60 ≈ 0.0167)
//   comiss xmm0, dt
//   ja  CLAMP_DT_LOW
//   movss xmm0, [g_18C471270]      ; 上限 (典型 1/30 ≈ 0.0333)
//   comiss dt, xmm0
//   jbe SKIP
//   movaps dt, xmm0                ; clamp to upper
//   ...
//   subss dt, prevSafeDT
//   movaps xmm1, dt
//   xorps xmm1, [负号 mask]         ; |dt - prevSafeDT|
//   comiss xmm1, smoothRate*xmm0    ; 与平滑速率比较
//   ...
//   addss safeDT, dt               ; safeDT 平滑过渡
```
据反汇编 `WaterInteractionRenderingPass.cs:1132-1191`。**目的**：当 frame time spike 时（lag），ripple 仿真用平滑过的 dt 推进，避免数值不稳。

---

## 7. 频谱海洋算法的 HDRP 同源参考（HG 已剪枝；保留作为 1:1 蓝图后备）

HG 当前**未启用** HDRP 的频谱仿真（FFT/Phillips），改用静态法线贴图 + 局部 ripple。但若需还原 HDRP 完整算法（用于其他 fork 或 HG 后续重启该路径），下表与公式必须按 HDRP 1:1 实现。

### 7.1 Phillips 频谱（**逐字照抄** HDRP 公式）

```hlsl
// HDRP: WaterSimulation.compute:50-63 照抄
float Phillips(float2 k, float2 w, float V, float directionDampener, float invPatchSize) {
    float kk = k.x * k.x + k.y * k.y;
    float result = 0.0;
    if (kk != 0.0) {
        float L = (V * V) / EARTH_GRAVITY;     // EARTH_GRAVITY = 9.81 (常量, HDRP 同文件 :18)
        float wk = lerp(dot(normalize(k), w), 0.5, directionDampener);
        float phillips = (exp(-1.0f / (kk * L * L)) / (kk * kk)) * (wk * wk);
        result = phillips * (wk < 0.0f ? directionDampener : 1.0);
    }
    return PHILLIPS_AMPLITUDE_SCALAR * result * invPatchSize * invPatchSize;
    // PHILLIPS_AMPLITUDE_SCALAR = 0.2 (HDRP 同文件 :21)
}
```
据 `HDRP/.../Shaders/WaterSimulation.compute:50-63`。

### 7.2 Dispersion + iFFT 推进

```hlsl
// HDRP: WaterSimulation.compute:116-148 照抄
[numthreads(8, 8, 1)]
void EvaluateDispersion(uint3 currentThread : SV_DispatchThreadID) {
    float invPatchSize = GetBandPatchData(currentThread.z).x;
    float2 k = TWO_PI * (currentThread.xy - _BandResolution * 0.5) * invPatchSize;
    float  kl = length(k);
    float  w = sqrt(EARTH_GRAVITY * kl);            // 深水频散关系 ω² = g·|k|
    float2 kx = float2(k.x / kl, 0.0);
    float2 ky = float2(k.y / kl, 0.0);
    float2 h0 = LOAD_TEXTURE2D_ARRAY(_H0Buffer, currentThread.xy, currentThread.z);
    float2 ht = ComplexMult(h0, ComplexExp(w * _SimulationTime));   // 复数指数推进
    float2 dx = ComplexMult(ComplexMult(float2(0, -1), kx), ht);    // 水平位移 X 分量
    float2 dy = ComplexMult(ComplexMult(float2(0, -1), ky), ht);    // 水平位移 Z 分量
    ...
    _HtRealBufferRW[int3(...)] = float4(ht.x, dx.x, dy.x, 0);
    _HtImaginaryBufferRW[int3(...)] = float4(ht.y, dx.y, dy.y, 0);
}
```
据 `HDRP/.../Shaders/WaterSimulation.compute:115-148`。

### 7.3 3 Band 多分辨率（**逐字照抄**常量）

```csharp
// WaterSimulationResolution: HDRP/.../HDRenderPipeline.WaterSystem.Simulation.cs:26-39
public enum WaterSimulationResolution {
    Low64 = 64,
    Medium128 = 128,
    High256 = 256,
}
// k_WaterHighBandCount = 3, EARTH gravity 9.81, max choppiness 2.25, ...
// 据 HDRP/.../WaterSystemDef.cs:6-65 照抄
```
HDRP `numActiveBands ∈ [1, 3]`，每 band 用同一 `simulationResolution` 跑独立 Phillips → Dispersion → iFFT → Normals + Jacobian → additionalDataBuffer（normal + foam）。

### 7.4 8 Sector + 16 Swizzle（HDRP 的水流方向编码）

```csharp
// HDRP/.../WaterSystemDef.cs:101-202 照抄
internal const int k_NumSectors = 8;
internal const float k_SectorSize = ((2.0f * math.PI) / k_NumSectors);
static readonly float k_ISq2 = 0.70710678118f;
// 16 个 swizzle 方向向量 (k_SectorSwizzle + k_SectorSwizzlePacked) 用于 GPU 采样水流贴图
```
**注意**：HDRP 的 "sector" 是**水流方向象限**（圆周 8 等分），跟 HG 的 sector(=地理分块) 完全不同名 —— 这是名称碰撞陷阱，1:1 复刻时绝不能混淆。

### 7.5 FFT 蝴蝶变换

HDRP 用独立 `FourierTransform.compute`（Row + Col 两个 kernel），把 `_HtReal/Imag` 通过 2D iFFT 变回空间域 displacement buffer。

---

## 8. 水面渲染主流水线：`WaterOnePassDeferredRenderingPass` 6-SubPass + V2 间接 / Tessellation

### 8.1 6 SubPass 枚举（**逐字照抄**反编译）

```csharp
// WaterOnePassDeferredRenderingPass.cs:10-18 照抄
public enum WaterShaderForwardPassName {
    GBufferBlit      = 0,    // GBuffer blit-in：把水的 GBuffer 颜色混入 sceneGBuffer
    GBuffer          = 1,    // 水自己写 GBuffer (deferred path)
    DepthBlit        = 2,    // 水深度合成进 sceneDepth
    Reflect          = 3,    // 屏幕空间反射 prepass
    Lighting         = 4,    // 水面延迟光照计算
    FullScreenDebug  = 5     // 调试可视化
}
```
据反编译 `WaterOnePassDeferredRenderingPass.cs:10-18`。**这 6 个值 = `litwater.shader` 里 SubShader 的 6 个 Pass index**（详 [`../10-Shaders/01-Shaders.md`](../10-Shaders/01-Shaders.md) §4.5）。

### 8.2 WaterProxy 6 PassID + WaterDecal 4 PassID + TextureProcess 4 PassID

```csharp
// WaterProxyPassID.cs:1-12 照抄
public enum WaterProxyPassID {
    WaterProxy           = 0,
    WaterUnlit           = 1,
    WaterDrawWetnessMask = 2,
    WaterDepthOnly       = 3,
    WaterTessellation    = 4,
    WaterGBuffer         = 5
}
// WaterDecalPassID.cs:1-10 照抄
public enum WaterDecalPassID {
    WaterDecal             = 0,
    WaterDecalDisplacement = 1,
    WaterDecalDeferred     = 2,
    FullScreenDebug        = 3
}
// WaterTextureProcessPassID.cs:1-10 照抄
public enum WaterTextureProcessPassID {
    WaterPrepassTextureProcess     = 0,
    WaterProxyDisplacement          = 1,
    WaterTesellationTextureProcess  = 2,
    WaterApplyWetnessMask           = 3
}
// WaterPassName.cs:1-9 照抄
public enum WaterPassName {
    Tessellation0 = 0,
    Tessellation1 = 1,
    Lighting      = 2
}
```

### 8.3 Reflect SubPass 详解（HDRP 同源 SSR）

`RenderReflectPass`（反汇编 `WaterOnePassDeferredRenderingPass.cs:671-1324`）：
1. 创建 `m_reflectLightingTexture`、`m_reflectFadenessTexture`、`m_gBufferATexture`、`m_gBufferMVTexture`、`m_prepassDepthTexture` 等 6 个 TextureHandle，分辨率 **= screen / 2** (`waterVRRx`, `waterVRRy` 来自 SettingParameter`<int>`@offset 0x518/0x520)；
   - 反汇编 `mov rax,[r15+30h] ; shr rax,20h ; cdq ; sub eax,edx ; sar eax,1` = `(screen.x >> 1)`，即 1/2 分辨率。
2. AllocateConstantBuffer 0x5120 字节 (`HGWaterManager.SetWaterDataCB` 在 `Prepare`)：把 1298 Vector4 完整推到 cbuffer。0x5120 = 20768 字节 ≈ 1298 × 16，与 `WATER_GPU_DATA_VECTOR4_COUNT=1298` 完美匹配 = **1298 × 16 字节聚合 cbuffer**；
   - 据反汇编 `WaterOnePassDeferredRenderingPass.cs:616-624` (`mov r8d,5120h` 后 `AllocateConstantBuffer`)。
3. Profile sampler `0x26` ("Water Prepass") 的 RenderGraph pass：
   - `SetColorAttachment(slot 0)` = m_reflectLightingTexture；
   - `SetRenderFunc` = `s_waterReflectiLightingRenderFunc`。
4. Profile sampler `0x36` 后续 pass：
   - 设置 GBuffer / MV / Depth 三个 color attachment（slot 0/1）+ DepthAttachment（clear 值 `g_18C471324` = 1.0f）；
   - 6 SubPass 共享同一 material `m_waterRenderingMaterial`（`materialCollector.CreateMaterial(shader=collection.water at offset 0x400)`）；
   - 通过 `m_waterQualityLowKeyword`（`"HG_WATER_DESKTOP_QUALITY_LOW"`，LocalKeyword on `litwater.shader`）切换桌面低质量模式。

### 8.4 Prepare：每帧准备 cbuffer 和共享纹理

```csharp
// Prepare(HGCamera hgCamera, HGSettingParameters settingParameters, ScriptableRenderContext)
//   - HGCamera.ShouldRenderWater() 检查 → m_isRendering 标记
//   - m_cullHandle = hgCamera.cullHandle (offset 0xA50)
//   - globalConfig = HGWaterManager.globalConfig (currentManagerContext.WaterManager.globalConfig)
//   - m_globalFlowmapTexture = globalConfig.flowMap        ← assign with WriteBarrier
//   - m_globalCausticTexture = globalConfig.causticMap     ←
//   - m_globalNormalTextureArray = globalConfig.normalMapArray  ←
//   - 3 次 GetWaterRenderingMatrices (loc_1845EC570) 填三个 4×4 matrix (viewProj, viewProjInv, worldToCamera)
//   - AllocateConstantBuffer 0x5120 字节 = 1298 Vector4 cbuffer
//   - HGWaterManager.SetWaterDataCB(camera, settingParameter, ctx, fwd_matrices, prev_matrices, custom_matrices, cbHandle)
```
据反汇编 `WaterOnePassDeferredRenderingPass.cs:495-669`。

### 8.5 SectorTexture / InteractionTexture 输入

水面渲染 vertex shader 采样 2 张关键纹理（输入来自前两个 Pass）：
- `_WaterSectorTexture3x3` = `WaterSectorRenderingPass` 输出的 768×768 atlas（3×3 个 256² flowmap）；
- `_WaterInteractionTexture` = `WaterInteractionRenderingPass` 输出的 currNormalTexture（ripple 法线）。

PassInput / PassOutput 声明：
```csharp
internal struct PassInput {
    internal TextureHandle sectorTexture;        // from WaterSectorRenderingPass
    internal TextureHandle interactionTexture;   // from WaterInteractionRenderingPass
    internal TextureHandle sceneColor;
    internal TextureHandle sceneColorCopied;
    internal TextureHandle sceneDepth;
    internal TextureHandle sceneDepthCopied;
    internal TextureHandle lowResSceneDepth;
    internal TextureHandle sceneMV;
    internal TextureHandle gBufferATexture;
    internal ScriptableRenderContext srpContext;
}
internal struct PassOutput {
    internal TextureHandle gbufferBWithWaterTexture;   // out → GBuffer B with water mixed in
    internal TextureHandle depthWithWaterTexture;      // out → sceneDepthWithWater (供透明阶段)
}
```
据反编译 `WaterOnePassDeferredRenderingPass.cs:20-48`。

---

## 9. 透明阶段 fallback：`WaterDefaultDeferredRenderingPass` PassData 全字段语义

V2 是 `WaterDefaultDeferredRenderingPass`，主要在非单 Pass 配置下作为标准 Deferred 流水线使用，结构更复杂（带 indirect rendering + tessellation + height layer + wetness mask + 多种 SubPass）。

### 9.1 常量（**逐字照抄**反编译）

```csharp
// WaterDefaultDeferredRenderingPass.cs:202-222 照抄
private const int INDIRECT_NUM                  = 6;     // v1 间接绘制数量
private const int WATER_DISPLACEMENT_TEXTURE_SIZE = 512;
private const int INDIRECT_ARGS_NUM_V2          = 8;     // v2 间接参数槽数
private const int INDIRECT_NUM_V2               = 32;    // v2 间接绘制数量
```
据反编译 `WaterDefaultDeferredRenderingPass.cs:204-216`。

### 9.2 PassData 关键字段（按主题分组）

**多 SubPass 物料**（每种 SubPass 一份 Material + MPB）：
```
waterScreenSpaceMesh        : Mesh (= HGWaterManager.screenSpaceMesh, 16×16 quad, WaterSettings.CreateQuad)
waterProxyMaterial          : Material           — Pass: WaterProxyPassID
waterTextureProcessMaterial : Material           — Pass: WaterTextureProcessPassID
waterRenderingMaterial      : Material           — Pass: WaterShaderForwardPassName (≡ litwater.shader)
waterTessellationMaterial   : Material           — Pass: WaterPassName.Tessellation0/1

waterProxyMPB / waterDecalMPB / waterTesellationMPB / waterLightingMPB / waterCopyMPB
waterHeightDecalMPB / waterTessellationMPB   ← 7 个 MaterialPropertyBlock
```

**Indirect 间接绘制 (V2)**：
```
firstTime          : bool       — 第一次创建 m_indirectBufferV2 后置 false
enableIndirect     : bool       — 启用 GPU-driven indirect
useOffset          : uint
clearOffset        : uint
occlusionCB        : CBHandle   — water occlusion cbuffer
tileBuffer         : ComputeBufferHandle  — water tile classification
indirectBuffer     : ComputeBufferHandle  — V2: 32 个 indirect args, 每个 8 个 uint
waterOcclusionGroupXYNum : int  — dispatch X/Y group count
waterOcclusionGroupZNum  : int  — dispatch Z group count
waterOcclusionCS   : ComputeShader  — water occlusion 计算
waterLODInstanceCount : int     — 当前 LOD 的 instance 数
```

**Tessellation** (硬件曲面细分):
```
waterTessellationDataTexture : TextureHandle   — 32-bit float displacement
waterPrepassDataTexture / NormalTexture / DisplacementTexture / DepthTexture (4 张 prepass RT)
```

**Wetness Mask** (打湿系统):
```
wetnessMask3DNoise         : Texture3D
waterWetnessMaskTexture    : TextureHandle
renderWetnessDecal / renderWetnessObj : bool
wetnessDecalECSList / wetnessObjECSList : uint   — ECS list handle
```

**屏幕空间 + GBuffer mix**：
```
sceneDepthTexture                : TextureHandle
sceneDepthTextureCopy            : TextureHandle
sceneDepthWithWaterTextureCopy   : TextureHandle  ← 关键：透明阶段共享 (见 ../01-PipelineCore/02-GeometryPasses.md §3.7)
reflectionLightingTexture        : TextureHandle
reflectionFadenessTexture        : TextureHandle
gbufferATexture / gbufferBTexture : TextureHandle
normalRoughnessTexture           : TextureHandle
```

**Height Layer**（多层水面，如河流叠湖泊）：
```
heightLayer        : int
lastHeightLayer    : int
waterHeightVisibleCount    : uint
waterHeightCullingHandle   : uint
```

据反编译 `WaterDefaultDeferredRenderingPass.cs:69-200`（PassData class）。

### 9.3 13 个静态 RenderFunc

```
s_RenderFallbackFunc                  — fallback path (无水)
s_waterProxyRenderFunc                — proxy 遮挡
s_waterWetnessMaskRenderFunc          — 打湿 mask
s_waterProxyDisplacementRenderFunc    — proxy + displacement texture process
s_waterOcclustionRenderFunc           — V1 occlusion CS
s_waterTessellationRenderFunc         — V1 tessellation draw
s_waterCopyRenderFunc                 — depth/color copy
s_waterHeightRenderFunc               — height-layer 多层水合成
s_waterDecalRenderFunc                — decal 注入
s_waterOcclustionRenderFuncV2         — V2 occlusion CS (32 indirect)
s_waterTessellationRenderFuncV2       — V2 tessellation
s_waterGBufferRenderFuncV2            — V2 写 GBuffer
s_waterLightingRenderFunc             — 水面延迟光照
```
据反编译 `WaterDefaultDeferredRenderingPass.cs:278-302`。

### 9.4 WaterPerDrawData：每 Draw 上传

```csharp
// WaterPerDrawData.cs:1-19 照抄
public struct WaterPerDrawData {
    public Matrix4x4 viewProjMatrix;      // 64 bytes
    public Matrix4x4 viewProjInvMatrix;   // 64 bytes
    public Vector4 param0;                // 16 bytes
    public Vector4 param1;                // 16 bytes
    public Vector4 param2;                // 16 bytes
    public Vector4 param3;                // 16 bytes
}
// 总: 64 + 64 + 4*16 = 192 字节 per draw
```

---

## 10. 水下 + 焦散 + 折射：HDRP 同源算法 + HG MaterialPropertyBlock 通道

### 10.1 焦散（HDRP 同源）

**采样位置**：水面以下，深度 ∈ [`causticStartDepth`, `causticEndDepth`]：
```
fade = saturate((depth - causticStartDepth) / (causticEndDepth - causticStartDepth))
uv   = world.xz * causticTilling + time * causticSpeed * windDir
uv  += normalSample * causticDistort
color += SAMPLE_TEX2D(_CausticTexture, uv) * causticOpacity * fade
```
据 HG 参数语义（`HGWaterConfig.cs:617-639`）+ HDRP 同源算法（HDRP 用 GPU `WaterSimulation.compute:PrepareCausticsGeometry` 烘焙焦散，HG 简化为 2D 平铺）。

### 10.2 折射（屏幕空间）

HG 的 IOR 默认 `waterIOR = 0.67f`（`HGWaterConfig.cs:573`，slot[12].w = 1/IOR = 1/0.67 ≈ 1.493 写入 cbuffer）。

折射公式（HDRP/Lit 通用 Snell 屏幕空间）：
```
refractDir = refract(viewDir, surfaceNormal, 1/IOR)
refractUV  = screenUV + projTexel(refractDir) * distanceBlend
sceneRefracted = SAMPLE_TEX2D(_SceneColorCopied, refractUV)
finalColor = lerp(sceneRefracted, absorption(depth), 1 - exp(-extinction * depth))
```
据领域知识 + HDRP `SampleWaterSurface.hlsl` 的同源算法。`distanceBlend` 越远折射越弱（`HGWaterConfig.cs:642`）。

### 10.3 水体吸收（Beer-Lambert）

```
absorbedColor = baseColor * exp(-waterRayleighAbsorptionMeter * depth) * absorptionScale
              + lerp(absorptionTint, absorptionTint2, saturate(depth / safeFullAbsorpDistance))
```
据 HG 参数：`waterRayleighAbsorptionMeter`/`waterRayleighAbsorptionMeter2` (slot[3]/[4]), `absorptionScale`(slot[9].w), `safeFullAbsorpDistance`(slot[10].x), `absorptionTint`/`absorptionTint2`(slot[0]/[2])。

### 10.4 散射（瑞利 + 米氏混合）

`rayleighMieLerpFactor ∈ [0, 1]`（`HGWaterConfig.cs:504`）控制两种相函数混合：
```
phase_rayleigh = (3/4) * (1 + cos²θ)
phase_mie      = HenyeyGreenstein(cos θ, g)
phase_mixed    = lerp(phase_rayleigh, phase_mie, rayleighMieLerpFactor)
scatteredLight = scatterTint * scatterScale * phase_mixed * sunIntensity * envLightIntensity
```
据 HG 参数（`HGWaterConfig.cs:478-515`）+ 领域知识（标准海水散射近似）。

### 10.5 水下情境（HDRP 同源 + HG delta）

HDRP 用 `WaterLine.compute` 计算屏幕上水线 + 区分相机是否在水下；HG 通过 `WaterDefaultDeferredRenderingPass.sceneDepthWithWaterTextureCopy` 给透明物体阶段使用（详 [`../01-PipelineCore/02-GeometryPasses.md`](../01-PipelineCore/02-GeometryPasses.md) §3.7 `TransparentPassConstructor.sceneDepthWithWater`）。**HG delta**：HG 不做 HDRP 的 `WaterLine` 1D 屏幕扫描，而是用 `m_shouldStoreDepth` 标志位（`HGWaterManager.cs:118-134`）控制是否产出水下深度，再交给后处理判断相机水下/水上状态。

---

## 11. 水面装饰：WaterDecal 4 PassID + WaterProxy 6 PassID + Wetness 3D mask

### 11.1 WaterProxy 6 PassID 串联

水面有时只需 "代理 mesh" 提供深度/遮挡而不渲染本体（如远景剔除），用 `WaterProxyPassID` 0..5：

| PassID | 名 | 用途 |
|---|---|---|
| 0 `WaterProxy` | 代理 mesh 写 sceneDepth | 提供水面遮挡 |
| 1 `WaterUnlit` | 平面色 | debug / lowest LOD fallback |
| 2 `WaterDrawWetnessMask` | 写 3D wetness mask | 让陆地物体知道哪些区域被水浸湿 |
| 3 `WaterDepthOnly` | 仅深度 | shadow / prepass |
| 4 `WaterTessellation` | 硬件曲面细分 vertex 输出 | 高质量水面 |
| 5 `WaterGBuffer` | 写 GBuffer | deferred 路径 |

### 11.2 WaterDecal 4 PassID

```
0 WaterDecal              — 在水面投射 decal (UV 注入 flowmap/foammap)
1 WaterDecalDisplacement  — decal 顶点位移
2 WaterDecalDeferred      — decal 写 GBuffer
3 FullScreenDebug         — debug 可视化
```

### 11.3 与 HDRP WaterDecal 的对照（**关键 delta**）

HDRP `WaterDecal.PassType` 有 **5 类**（Deformation/Foam/SimulationMask/LargeCurrent/RipplesCurrent），每类对应 `m_DecalAtlas` 内一片纹理槽位（`PowerOfTwoTextureAtlas`，atlas size 64..2048 = `WaterAtlasSize`）。HDRP 在 `CullWaterDecals()`（`HDRenderPipeline.WaterSystem.Decals.cs:152-288`）做 CPU 圆形包围 vs 矩形 region 剔除。

HG 简化为 **4 类**（无 LargeCurrent/RipplesCurrent，因为 HG 不跑 FFT，无需 current 注入），用 `MaterialPropertyBlock waterDecalMPB` + `waterHeightDecalMPB` 两个 MPB 直接驱动 material pass，不维护 atlas。

### 11.4 Wetness 3D Mask

`m_wetnessMask3DNoise : Texture3D`（`WaterDefaultDeferredRenderingPass.cs:226`）：一张全局 3D 噪声体，与水面 mask 叠加产生**有机感**的湿润分布（避免硬切）。`WaterApplyWetnessMask` Pass（`WaterTextureProcessPassID = 3`）把 mask 涂到陆地材质上。

`HGWaterRendererV2.cs:30-37` 的 `wetnessOffset` 控制水面向上**沿法线**延伸的打湿高度（典型 0.5m，让岸边石头被水打湿一段）。

---

## 12. Rain `HGWetnessRipple`：雨滴涟漪叠加进水面法线

### 12.1 数据

```csharp
// HGWetnessRipple.cs:1-26 照抄
public class HGWetnessRipple : HGBaseWetnessFeature {
    private class WetnessRippleRenderParams {
        public Texture2D rippleTexture;        // flipbook texture
        public Vector2 rippleTexture_ST;
        public float rippleNormalStrength;
        public float rippleWaveNormalStrength;
        public int rippleRowColumnCount;       // flipbook 行×列 ≈ N × N
        public float rippleRoughnessMaskThreshold;
    }
    private float m_rippleTimeOffset;
    private float m_rippleWaveTimeOffset;
}
```

### 12.2 UpdateData 算法（每帧）

```csharp
// HGWetnessRipple.UpdateData(rainCommonRenderingParam, deltaTime)
// 反汇编要点 (HGWetnessRipple.cs:28-127):
//   m_rippleTimeOffset    += deltaTime * (rainCommonRenderingParam @0x124)   // 速度系数
//   m_rippleTimeOffset    -= floor(m_rippleTimeOffset)                        // 取分数部分, 防 float 溢出
//   m_rippleWaveTimeOffset += deltaTime * (rainCommonRenderingParam @0x128)
//   m_rippleWaveTimeOffset -= floor(m_rippleWaveTimeOffset)
//   globalProps[+0x18] = rippleTexture_ST.xy                                  (offset 0x18/0x1c)
//   globalProps[+0x20] = rippleNormalStrength                                  (offset 0x20)
//   globalProps[+0x24] = rippleWaveNormalStrength                              (offset 0x24)
//   globalProps[+0x28] = rippleRowColumnCount                                  (offset 0x28)
//   globalProps[+0x2c] = rippleRoughnessMaskThreshold                          (offset 0x2c)
//   shaderProp 5 = PackVector4(m_rippleTimeOffset, rippleTexture_ST.x, ST.y, RowColumnCount)
//   shaderProp 6 = PackVector4(rippleNormalStrength, rippleWaveNormalStrength, rippleRowColumnCount(float), threshold)
```
据反汇编 `HGWetnessRipple.cs:28-247`（UpdateData + SetData 两个方法）。

### 12.3 算法原理

雨滴涟漪通过 **flipbook 动画**叠加：
1. `rippleTexture` 是 N×N 张涟漪法线小图打包成一张大图（如 4×4=16 帧）；
2. 每帧采样 `frameIdx = floor(m_rippleTimeOffset * rippleRowColumnCount²)` 选定 sub-tile；
3. sub-UV = world.xz / rippleTexture_ST.xy；
4. 解码法线 `n_ripple` 后混入水面 surface gradient：
   ```
   surfGrad_final = surfGrad_water + rippleNormalStrength * SurfGradFromTangentSpaceNormal(n_ripple)
   ```
5. `rippleRoughnessMaskThreshold` 用来 mask 出降雨范围内才生效。

### 12.4 ResetData：清空（雨停时）

`ResetData` (`HGWetnessRipple.cs:248-399`) 把 `globalProps[5]`/`globalProps[6]` 两个 PackVector4 重置为 (0, 0, ST.x, ST.y) 和 (0, 0, 0, count)，让 shader 内 `rippleNormalStrength = 0`，自然过渡到无雨状态。

---

## 13. ECS 接入：`HGWaterRendererV2` → `HGWaterComponent` + Bounding* + RenderObjectInfo

### 13.1 ECS Entity 创建

```csharp
// HGWaterRendererV2.AddEntity 反汇编片段:
NativeArray<ComponentType> waterType = HGWaterRendererV2.s_waterType;
//   waterType 由静态初始化, 含 8 个 ComponentType:
//     BoundingCenterXComponent
//     BoundingCenterYComponent
//     BoundingCenterZComponent
//     BoundingExtentXComponent
//     BoundingExtentYComponent
//     BoundingExtentZComponent
//     HGWaterComponent
//     RenderObjectInfoComponent
m_entity = EntityManager.CreateEntity(waterType);
UpdateEntity();   // 把上面 8 个组件的字段填好
```
据反汇编 `HGWaterRendererV2.cs:568-690`。

### 13.2 UpdateEntity：6 个 Bounding + HGWaterComponent + RenderObjectInfoComponent

```csharp
// HGWaterRendererV2.UpdateEntity 反汇编片段:
Bounds b = mesh.bounds (transformed by component.transform)
//   xmm6 = b.center (x, y, z, _)
//   [rsp+58h] = b.extents (x, y, z, _)
SetComponent<BoundingCenterXComponent>(entity, b.center.x)
SetComponent<BoundingCenterYComponent>(entity, b.center.y)
SetComponent<BoundingCenterZComponent>(entity, b.center.z)
SetComponent<BoundingExtentXComponent>(entity, b.extents.x)
SetComponent<BoundingExtentYComponent>(entity, b.extents.y)
SetComponent<BoundingExtentZComponent>(entity, b.extents.z)

HGWaterComponent comp = GetHGWaterComponent(meshInstanceID, materialIndex);
//   字段总 (4 + 4 + 4 + 4 + 4 + 4 + 4 + 4 + 2)*16 = 9*16 = 144 字节 大 struct
SetComponent<HGWaterComponent>(entity, comp);

RenderObjectInfoComponent info {
    layerMask = (1 << gameObject.layer),
    artTag    = gameObject.artTag,
    flags     = 0x701,
    distance  = -1,
    farClip   = sub_43800000   // 256.0f (raw IEEE 754 0x43800000)
};
SetComponent<RenderObjectInfoComponent>(entity, info);
```
据反汇编 `HGWaterRendererV2.cs:692-1052`。

### 13.3 GetHGWaterComponent：填 9 个 Vector4 的组件

`HGWaterComponent` 是一个大组件，UpdateEntity 中通过 `movups xmm0..xmm5 + movsd xmm0` 共 9 个 16 字节块 + 1 个 8 字节块 拷贝到 ECS slot：

```
HGWaterComponent layout (反汇编 HGWaterRendererV2.cs:1116-..):
  +0x00  Vector4   ?               (xmm0)
  +0x10  Vector4   ?               (xmm1)
  +0x20  Vector4   ?               (xmm0)
  +0x30  Vector4   ?               (xmm1)
  +0x40  Vector4   ?               (xmm0)
  +0x50  Vector4   ?               (xmm1)
  +0x60  double    ?               (xmm0, 8 字节)
  ─────
  总 ≈ 104 字节 (6 vector4 + 1 double = 6*16+8 = 104 字节)
```

### 13.4 与 HDRP 的对比

HDRP 用 `WaterSurface` MonoBehaviour 直接挂在 GameObject 上，渲染逻辑跑在 `partial class WaterSystem` 单例里；HG 通过 ECS 把每个 water tile 变成一个 entity，统一进 GPU-driven culling 管线（参考 [`../02-CoreAlgorithms/01-CoreAlgorithms.md`](../02-CoreAlgorithms/01-CoreAlgorithms.md) 的 GPU-driven rendering）。这是 HG 整个渲染管线的统一架构选择，不只是水面。

---

## 14. 1:1 复刻蓝图（分步落地）

要从零重建 HG 水系统，按以下顺序：

### Step 1: 数据模型（**必先完成**）
- 复制 `HGWaterConfig` 全部字段（80+ 浮点 + 颜色）和 `MaterialData` 的 20 Vector4 layout（§3.2）；
- 复制 `HGWaterGlobalConfig`/`HGWaterGlobalConfigData` 的 sector 元数据（mapSize/sectorSize/lodNum/meshNumPerLOD/meshSize/heightMapXZ/Y）；
- 实现 `HGWaterManager` 单例 + 3 个 NativeArray<Vector4>（waterGPUData=1298, waterRippleData=20, defaultWaterMaterialData）+ 64 槽 m_waterConfigs[]；
- 实现 `HGWaterConfig.CopyConfig`：把 80 字段重排进 20 Vector4（§3.2 表）。

### Step 2: Sector 流送（§5）
- 实现 `HGWaterSectorData` ScriptableObject + `Texture2D waterSectorTexture0` (256²) + `Vector4[] rippleLayerBuffer`；
- 实现 `WaterSectorRenderingPass`：4 态 `SectorNode[]` + 3 Queue + mod-3 atlas (768²) + ResourceManager.LoadAsync（priority=10）；
- 5 步 Render：Unload → LoadingEnqueue → LoadedCheck → CopyEnqueue → CopyToAtlas。

### Step 3: Ripple Manager + InteractionPass（§6）
- 实现 `RippleDataManager`：8 槽 List + `_minIndex` + IsHigherPriority/IsLowerPriority；
- 实现 `WaterInteractionRenderingPass`：3 个 RenderGraph pass（Add/Simulate/HeightToNormal）+ 2D 波动方程 shader；
- 处理 `UpdateWaterInteractionSafeDeltaTime` 平滑 dt；
- 处理 `UpdateWaterState` 10 秒离水延迟关闭。

### Step 4: 单 Pass Deferred 主流水线（§8）
- 实现 `WaterOnePassDeferredRenderingPass`：
  - Prepare：AllocateConstantBuffer 0x5120 字节 (1298 Vector4) + SetWaterDataCB 上传；
  - RenderReflectPass：Profile sampler 0x26 + 0x36；半分辨率反射 RT；6 SubPass 共享一个 `m_waterRenderingMaterial`；
  - 写 `litwater.shader` 的 6 个 Pass（GBufferBlit / GBuffer / DepthBlit / Reflect / Lighting / FullScreenDebug）。

### Step 5: V2 Deferred 完整路径（§9）
- 实现 `WaterDefaultDeferredRenderingPass`：
  - 7 个 MaterialPropertyBlock；
  - V2 间接绘制（`m_indirectBufferV2` 32 个 args × 8 uint = 256 uint）；
  - Tessellation（`waterTessellationDataTexture`, Tessellation0/1 pass）；
  - Wetness Mask（`m_wetnessMask3DNoise` Texture3D）；
  - 13 个静态 RenderFunc。

### Step 6: 装饰系统（§11）
- 实现 `WaterDecal` Material 4 Pass + `WaterProxy` Material 6 Pass + `WaterTextureProcess` Material 4 Pass；
- 实现 `HGWaterRendererV2` MonoBehaviour → ECS Entity 流程（§13）。

### Step 7: 雨水 + 打湿（§12）
- 实现 `HGWetnessRipple.UpdateData/SetData/ResetData`；
- 实现 wetness 3D noise texture 烘焙；
- 实现 `WaterApplyWetnessMask` Pass。

### Step 8: （可选）频谱海洋还原（§7）
- 若需 HDRP 完整海洋仿真，按 HDRP `WaterSimulation.compute` 1:1 实现 7 个 kernel（InitializePhillipsSpectrum / EvaluateDispersion / EvaluateNormals + Jacobian / PrepareCausticsGeometry / EvaluateInstanceData[Infinite]）+ `FourierTransform.compute` 的 Row/Col；
- 实现 3 band × 256² 的 `phillipsSpectrumBuffer` / `displacementBuffer` / `additionalDataBuffer`。

---

## 15. 关键常量 / 魔数总表

| 常量 | 值 | 来源（文件:行）| 含义 |
|---|---|---|---|
| `MAX_STATIC_WATER_TYPES` | `32` | HGWaterManager.cs:13 | 静态水材质上限 |
| `MAX_DYNAMIC_WATER_TYPES` | `32` | HGWaterManager.cs:14 | 动态水材质上限 |
| `MAX_NUM_WATER_TYPES` | `64` | HGWaterManager.cs:15 | 总材质上限 (32+32) |
| `WATER_DEFAULT_TEXTURE_SIZE` | `2` | HGWaterManager.cs:18 | 兜底纹理 2² |
| `WATER_RIPPLE_DATA_VECTOR4_COUNT` | `20` | HGWaterManager.cs:20 | ripple cbuffer 大小 |
| `WATER_GPU_DATA_PARAMS_START` | `10` | HGWaterManager.cs:22 | params 起始 Vector4 |
| `WATER_GPU_DATA_MATERIAL_START` | `18` | HGWaterManager.cs:24 | material data 起始 |
| `WATER_GPU_DATA_MATERIAL_VECTOR4_COUNT` | `20` | HGWaterManager.cs:26 | 每材质 20 Vector4 |
| `WATER_GPU_DATA_VECTOR4_COUNT` | `1298` | HGWaterManager.cs:28 | 总 cbuffer 大小 |
| `RIPPLE_SIMULATION_RANGE` | `32f` | HGWaterManager.cs:52 | 仿真圆半径 (m) |
| `RIPPLE_SIZE_CHANGE_SPEED` | `5000f` | HGWaterManager.cs:62 | size 变化速率 |
| `RIPPLE_LIST_MAX_SIZE` | `8` | HGWaterManager.cs:76 | 优先级队列容量 |
| `RIPPLE_SIMULATION_SIZE` | `12` | HGWaterManager.cs:78 | 仿真网格分辨率 |
| `characterSpeedSizeInfluence` | `0.04f` | HGWaterManager.cs:80 | 角色速度对 size 系数 |
| `sizeRandomInfluence` | `0.04f` | HGWaterManager.cs:82 | size 随机抖动幅度 |
| `boatRippleRandomSize` | `0.02f` | HGWaterManager.cs:92 | 船尾迹随机半径 |
| `boatRippleRandomSizeSpeed` | `10f` | HGWaterManager.cs:94 | 船尾迹脉动速率 |
| `LEAVE_WATER_WAIT_TIME` | `10f` | RippleDataManager.cs:14 | 离水后保留涟漪秒数 |
| 优先级 MAIN_CHARACTER | `5` | HGWaterRipplePriority.cs:5 | 主角 |
| 优先级 HIGH_PRIORITY_CHARACTER | `4` | HGWaterRipplePriority.cs:7 | 高优 NPC |
| 优先级 LOW_PRIORITY_CHARACTER | `3` | :9 | 低优 NPC |
| 优先级 PLAYER_INTERACTION | `2` | :11 | 玩家交互（如扔石头）|
| 优先级 NON_CHARACTER | `1` | :13 | 非角色（杂物）|
| 优先级 DEFAULT | `0` | :15 | 默认 |
| `MOBILE_RIPPLE_MIN_QUALITY_TIER` | `5000` | WaterQualityHelper.cs:5 | 移动端 ripple 启用阈值 |
| `INVALID_SECTOR_INDEX` | `-1` | HGWaterGlobalConfigData.cs:11 | sector 无效标记 |
| sector atlas `TEXTURE_SIZE` | `256` | WaterSectorRenderingPass.cs:226 | atlas 单 tile 大小 |
| sector atlas 总尺寸 | `768²` | (= 256×3) | mod-3 atlas 整尺寸 |
| ResourceManager LoadAsync priority | `10` | WaterSectorRenderingPass.cs (反汇编 r9d=0Ah) | sector 加载优先级 |
| INDIRECT_NUM (V1) | `6` | WaterDefaultDeferredRenderingPass.cs:204 | V1 间接绘制数 |
| WATER_DISPLACEMENT_TEXTURE_SIZE | `512` | WaterDefaultDeferredRenderingPass.cs:206 | displacement RT |
| INDIRECT_ARGS_NUM_V2 | `8` | :214 | V2 每 indirect 8 uint |
| INDIRECT_NUM_V2 | `32` | :216 | V2 间接绘制数 |
| SCREEN_SPACE_MESH_VERTEX_NUM | `16` | WaterSettings.cs:7 | 水面 quad 顶点数 |
| MAX_SCREEN_SPACE_MESH_NUM | `16` | WaterSettings.cs:9 | 屏空 mesh 数量上限 |
| AllocateConstantBuffer 大小 | `0x5120` 字节 | WaterOnePassDeferredRenderingPass.cs:616 | 1298 Vector4 cbuffer (0x5120/16=1298) |
| Reflect 半分辨率比 | `>> 1` | :776-780 | screen / 2 |
| HDRP EARTH_GRAVITY | `9.81` | HDRP WaterSimulation.compute:18 | Phillips 公式 g |
| HDRP PHILLIPS_AMPLITUDE_SCALAR | `0.2` | HDRP WaterSimulation.compute:21 | Phillips 振幅缩放 |
| HDRP k_WaterMaxChoppinessValue | `2.25` | HDRP WaterSystemDef.cs:14 | choppiness 上限 |
| HDRP k_SwellMaxPatchSize | `5000.0` | HDRP WaterSystemDef.cs:36 | swell 最大 patch (m) |
| HDRP k_RipplesBandSize | `10.0` | HDRP WaterSystemDef.cs:50 | ripples band 大小 (m) |
| HDRP k_NumSectors (方向象限)| `8` | HDRP WaterSystemDef.cs:101 | 水流方向 8 等分 |
| HDRP k_ISq2 | `0.70710678118` | HDRP WaterSystemDef.cs:105 | 1/√2 |
| HDRP k_NumWaterVariants | `5` | HDRP WaterSystemDef.cs:205 | tile classification variant |
| HDRP `Low64`/`Medium128`/`High256` | `64`/`128`/`256` | HDRP HDRenderPipeline.WaterSystem.Simulation.cs:26-39 | 频谱仿真分辨率 |
| HDRP k_WaterHighBandCount | `3` | HDRP WaterSystemDef.cs:8 | 最大 band 数 |

---

## 16. 源文件清单（23 个 HG 反编译源 + 关键 HDRP 同源引用）

### 16.1 HG 反编译源（按 §0 顺序）

| # | 文件 | 一行职责 |
|---|---|---|
| 1 | `HGWaterConfig.cs` | 单材质 80+ 字段（波形/颜色/白沫/物理/光照/焦散/交互）+ `MaterialData` 20 Vector4 layout + `CopyConfig` 字段重排 |
| 2 | `HGWaterGlobalConfig.cs` | Scene 锚 MonoBehaviour，提供 sectorXNum/Z/Size/lodNum/meshNumPerLOD/meshSize/heightMapXZ/Y/flowMap/causticMap/normalMapArray |
| 3 | `HGWaterGlobalConfigData.cs` | ScriptableObject 数据载体（sceneCenterOffset/sectorDataPaths/hgWaterConfigs[]/全局贴图）+ GetSectorCoords/GetSectorIndex 算法 |
| 4 | `HGWaterInteractiveSetting.cs` | 全局 ripple 参数（damp/alpha/beta/speed/rippleSize/forwardOffset/frequency/normalStrength PC vs Mobile）|
| 5 | `HGWaterManager.cs` | 核心管理器（1298 Vector4 cbuffer + 64 槽 + RippleDataManager + 5 阶段 PipelineUpdate + native plugin 上传）|
| 6 | `HGWaterRendererV2.cs` | per-tile MonoBehaviour → ECS Entity（HGWaterComponent + 6 Bounding + RenderObjectInfo）|
| 7 | `HGWaterRipplePriority.cs` | 6 个优先级常量（MAIN=5..DEFAULT=0）|
| 8 | `HGWaterSectorData.cs` | sector 单元资产（256² waterSectorTexture0 + rippleLayerBuffer Vector4[]）|
| 9 | `HGWaterStreamingConfig.cs` | 局部 flowmap 流送配置（flowMap + packingData + indexX/Z + validGrid）|
| 10 | `InputRippleData.cs` | 涟漪输入数据 struct（positionXZ + size + distanceXZ + priority）|
| 11 | `RippleDataManager.cs` | 8 槽优先级队列（IsHigherPriority/IsLowerPriority + FindMinIndex + 10秒离水延迟）|
| 12 | `WaterDecalPassID.cs` | 4 个 decal SubPass（WaterDecal/Displacement/Deferred/FullScreenDebug）|
| 13 | `WaterDefaultDeferredRenderingPass.cs` | V2 Deferred 完整流水线（13 个 RenderFunc + indirect V2 + tessellation + wetness mask）|
| 14 | `WaterInteractionRenderingPass.cs` | 3 Pass ripple 仿真（Add → Simulate → HeightToNormal）+ SafeDeltaTime 平滑 |
| 15 | `WaterOnePassDeferredRenderingPass.cs` | 单 Pass Deferred 主流水线（6 SubPass + Reflect 半分辨率 + 0x5120 cbuffer）|
| 16 | `WaterPassName.cs` | 3 个 pass name（Tessellation0/1, Lighting）|
| 17 | `WaterPerDrawData.cs` | 每 Draw 上传 struct（viewProj/viewProjInv 矩阵 + 4 Vector4 params）|
| 18 | `WaterProxyPassID.cs` | 6 个 proxy SubPass（Proxy/Unlit/WetnessMask/DepthOnly/Tessellation/GBuffer）|
| 19 | `WaterQualityHelper.cs` | 移动端 ripple 启用判定 + 桌面 quality low 切换 |
| 20 | `WaterSectorRenderingPass.cs` | 3×3 mod-3 atlas 流送（4 态 SectorNode + 3 Queue + 5 步 Render）|
| 21 | `WaterSettings.cs` | 静态工具（CreateQuad 16×16, prepass texture size 256/512/1024）|
| 22 | `WaterTextureProcessPassID.cs` | 4 个 texture process SubPass（Prepass/Displacement/Tessellation/WetnessMask）|
| 23 | `Rain/HGWetnessRipple.cs` | 雨滴涟漪 flipbook（rippleTexture + rippleRowColumnCount + time 累加循环）|

### 16.2 HDRP 同源引用（核心算法 1:1 照抄来源）

| 文件 | 引用本文位置 | 用途 |
|---|---|---|
| `HDRP/.../Water/HDRenderPipeline.WaterSystem.Simulation.cs:26-39` | §7.3 | 3 Band 分辨率枚举 |
| `HDRP/.../Water/HDRenderPipeline.WaterSystem.Simulation.cs:199-205` | §7.3 | GPU buffer 分配 (3 band Tex2DArray) |
| `HDRP/.../Water/WaterSystemDef.cs:6-205` | §3, §7, §15 | 全部物理常量 + 8 sector swizzle |
| `HDRP/.../Water/Shaders/WaterSimulation.compute:50-63` | §7.1 | Phillips 频谱公式 |
| `HDRP/.../Water/Shaders/WaterSimulation.compute:115-148` | §7.2 | Dispersion 复数推进 |
| `HDRP/.../Water/Shaders/WaterSimulation.compute:173-206` | §7.2 | Normals + Jacobian (foam) |
| `HDRP/.../Water/Shaders/WaterSimulation.compute:212-246` | §10.1 | Caustics geometry 三角化 |
| `HDRP/.../Water/Shaders/SampleWaterSurface.hlsl:8-200` | §10 | 多 band 采样 + decal UV + 水流 swizzle |
| `HDRP/.../Water/HDRenderPipeline.WaterSystem.Decals.cs:152-288` | §11.3 | CPU 圆形 vs 矩形剔除 decal |
| `HDRP/.../Water/HDRenderPipeline.WaterSystem.Underwater.cs:1-200` | §10.5 | 水线 1D 扫描 + WaterLine.compute kernel |

---

## 附录 A — HDRP 与 HG 名称碰撞陷阱速查

| 名称 | HDRP 含义 | HG 含义 |
|---|---|---|
| **sector** | 水流方向 8 等分（圆周）`k_NumSectors = 8`，HDRP WaterSystemDef.cs:101 | 地理空间分块（如 256m × 256m 一格），WaterSectorRenderingPass.cs:11 |
| **band** | FFT 频谱中的频段（最多 3 band，每 band 不同 patch size） | 不存在；HG 不跑 FFT |
| **patch** | FFT 周期边长（如 5000m / 250m / 10m）| 不存在 |
| **decal** | 5 种 PassType（Deformation/Foam/Mask/LargeCurrent/RipplesCurrent）走 atlas | 4 种 PassID（WaterDecal/Displacement/Deferred/Debug）走 MPB |
| **simulation** | GPU FFT 每帧 ~ms 级 | 静态法线贴图 + 局部 12×12 ripple FDM |
| **caustics** | GPU 烘焙 mesh + ray cast | 2D 平铺贴图 + 时间偏移 |
| **current** | 水流仿真，2 个 quadrant + 16 swizzle | 不存在（HG 用 flowmap 静态向量场） |
