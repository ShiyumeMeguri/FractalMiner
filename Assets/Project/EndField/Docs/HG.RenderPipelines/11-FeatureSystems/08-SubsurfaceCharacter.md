# HG Render Pipeline — Subsurface Scattering + Character Rendering 技术实现原理蓝图

> 本文是 **从零 1:1 重建** 终末地 (EndField) HG.RenderPipelines **皮肤次表面散射 (SSS) + 角色 NPR 渲染** 子系统的工程蓝图。
> SSS 部分是 **Unity HDRP fork 血缘**：故 Burley normalized diffusion profile、disk 重要性采样、屏幕空间双边滤波、$R(r)/\text{CDF}^{-1}$、HTile 粗 stencil reject 等核心算法**直接照抄 HDRP 真源** (`com.unity.render-pipelines.high-definition@75de48326bcd/Runtime/Material/SubsurfaceScattering/`)；HG 的反编译 C# (`BurleyNormalizedDuffusion.cs` / `SubsurfaceManager.cs` / `SubsurfaceProfileManager.cs` / `MaterialSubsurfaceExtensions.cs` 等) 仅用于定位 **HG 的 delta**：双 cbuffer 平面化 (`_SubsurfaceParams[252]` / `_SubsurfaceProfileParams0/1[60]`)、`MAX_SUBSURFACE_MATERIAL_COUNT = 63` / `MAX_PROFILE_COUNT = 15`、Terrain SSS 通道融合、RGB→HSV 暂存、`SubsurfaceProfileNode` 引用计数、3 张 LUT 阵列 (`scatter/penumbra/indirect`) 取代 HDRP 解析式 LUT。
> Character 部分是 **HG 自研 NPR**：根据反编译 + 真实可读 shader `D:\Ruri\02.Unity\Project\FractalMiner\Assets\Project\EndField\HGRP\HGRP_CharacterNPR_Skin_Fix.shader` 重建 — 包括 ShadowLUT / SDF 化妆 / CP0–CP15 16×Vector4 角色参数 / 皮肤 specular CP8 / CP9 / 自动 RimLight / SkinnedMeshCapture 三帧重投影、`HGCharacterVolume` 演出参数、`HGCharacters` 静态注册器与角色 shadow layer 8..22 的位运算分配、`HGBoneCapsuleUtilities.AutomateGenerateCapsuleSkeletonsNonHuman` 离线 PCA + Quantile 胶囊拟合。
>
> 配套（不复述，仅链）：
> - 延迟着色 / SUBSURFACE 分支宿主：[`../01-PipelineCore/02-GeometryPasses.md`](../01-PipelineCore/02-GeometryPasses.md) §4 `HGDeferredShadingModel`
> - 胶囊阴影算法 & 球谐遮挡：[`../02-CoreAlgorithms/01-CoreAlgorithms.md`](../02-CoreAlgorithms/01-CoreAlgorithms.md) §13.3 `Capsule Shadow(角色)`
> - GBuffer 编码 / SSSBuffer 共享 GBufferA：[`../01-PipelineCore/02-GeometryPasses.md`](../01-PipelineCore/02-GeometryPasses.md) §2

---

## 0. 目录

| § | 主题 |
|---|------|
| 1 | 解决什么渲染问题 / 视觉目标 |
| 2 | 子系统拓扑 + HDRP 血缘对照表 |
| 3 | Burley Normalized Diffusion 反射剖面 — 数学闭式 (HDRP 同源照抄) |
| 4 | 屏幕空间 SSS Compute — Morton/LDS/HTile/Disk 黄金旋转采样 |
| 5 | Diffusion Profile 体系 — Halley 反演 CDF、shapeParam、filterRadius、IOR→F0 |
| 6 | HG 双 cbuffer + Profile/Material 分离 (delta vs HDRP) |
| 7 | Random Downsample 与 Combine Lighting 复合通路 |
| 8 | Transmittance Disney (薄物穿透) — 与 SSS 共享 profile |
| 9 | 角色 NPR Skin Shader 算法 — Diffuse Ramp / Shadow LUT / Skin Specular / Rim |
| 10 | `HGCharacterVolume` — 演出层光照参数 (CP0..CP15) |
| 11 | `HGCharacters` 注册器 + `HGCharacterHelper` Renderer 收集 + ShadowRenderingLayer 位掩码 |
| 12 | `SkinnedMeshCaptureManager` — Skin Matrices 三帧重投影通路 |
| 13 | `HGBoneCapsuleUtilities` — 离线 PCA + Quantile 胶囊拟合 (喂胶囊阴影) |
| 14 | `HGCharacterShadowBoundOverride` — 显式包围盒接管 |
| 15 | 关键常量 / 魔数总表 |
| 16 | 1:1 重建蓝图（分步） |
| 17 | 源文件清单（17 个） |

---

## 1. 解决什么渲染问题 / 视觉目标

| 视觉效果 | 解决路径 |
|---------|---------|
| **皮肤 / 蜡烛 / 玉 / 牛奶等次表面材质** 的"光从内部漫出"质感 — 阴影边缘柔化 + 颜色渗透 (红化、半透感) | Burley 归一化扩散剖面 + 屏幕空间双边滤波 (Jimenez+Disney 算法,HDRP 标准实现) |
| **薄物 (耳朵、叶片、蜡纸) 的透光感** | `ComputeTransmittanceDisney` 解析式 (4 + 4·exp(-S·t/3) 形式) |
| **NPR 角色面部 / 皮肤 / 头发** 卡通风暗部清晰、明暗界线可控的厚涂质感 | 自研 NPR Skin shader (Diffuse Ramp + Shadow LUT + SDF 阴影掩码 + 双 specular lobe) |
| **角色"演出灯光"** — 离开主光独立调灯,Dialog/CG 美化 | `HGCharacterVolume` 提供 `charMainLightOverrideColor` / `charSkinMainLightOverrideColor` / `charMainLightRangeBias` 等 32 个 VolumeParameter |
| **角色阴影"上身"** (skin 阴影偏冷、其他偏暖) | `charShadowTintControl` + `charSkinShadowTintColor` / `charShadowTintColor` 两路独立 tint |
| **角色边缘光 (一键 rim)** | 自动从主光夹角 + albedo 影响计算,见 `GetCharAutoRimVector` / `GetCharFaceRimVector` |
| **角色软阴影 (代替 SDF 自阴影)** | 骨骼胶囊 → 球谐可见性投影 (Capsule Shadow,见交叉引用) |
| **GPU 蒙皮捕获** (替代 ComputeShader 蒙皮的轻量 CPU→GPU 通路) | `SkinnedMeshCaptureManager` 走 `SkinnedMeshRenderer.RequestCurrentFrameSkinMatrices` |

---

## 2. 子系统拓扑 + HDRP 血缘对照

```
┌──────────────────────── EndField C08 子系统拓扑 ────────────────────────┐
│                                                                       │
│ ┌─── SSS (HDRP 血缘,99% 同源) ───────────────────────────────┐         │
│ │                                                            │         │
│ │  Material  ──┐                                             │         │
│ │  (KW _SSS)   │   GBufferPass         ┌── PackDiffusionProfile (8×8 kernel,8b/像素压缩)             │
│ │              ▼                       ▼                                │
│ │     SSSBuffer(=GBufferA, sRGB float4) ─► DiffusionProfileIdx (R8 packed) │
│ │  diffuseColor.rgb  |  PackFloat8b(mask, idx, 16)            │         │
│ │                                                            │         │
│ │  ─► DeferredShading (Subsurface 分支) ─► IrradianceSource   │         │
│ │            (.b = max(.b, HALF_MIN) 标 tag,blue ≠ 0 即 SSS) │         │
│ │                                                            │         │
│ │  ─► [可选] RandomDownsample (≤2 step IGN 抽样)              │         │
│ │  ─► SubsurfaceScattering.compute kernel = SubsurfaceScattering         │
│ │       Group 16×16 (1D dispatch[256]), Morton 排布                       │
│ │       HTile 粗 stencil reject (4 块 OR),LDS L0 cache 20×20            │
│ │       N = min(SssSampleBudget, π·r²·pixelsPerMm²/SSS_PIXELS_PER_SAMPLE) │
│ │       Disk Golden 旋转,Burley CDF^-1 重要性采样                       │
│ │       双边权 = EvalBurleyDiffusionProfile(r, S) · rcpPdf                │
│ │  ─► CombineLighting.shader (Additive,Stencil = SSS,ZTest Less)        │
│ │                                                            │         │
│ │  CPU 端: HG SubsurfaceManager (63 槽 dict<iid,idx>)         │         │
│ │          + SubsurfaceProfileManager (15 槽 + 3×LUT array)  │         │
│ └────────────────────────────────────────────────────────────┘         │
│                                                                       │
│ ┌─── Character NPR (HG 自研) ────────────────────────────────┐         │
│ │                                                            │         │
│ │  HGCharacterVolume (32 个 VolumeParameter)                  │         │
│ │     ▼ 提供 CP0..CP15 + EnvGlobalParams0 + ExposureParams   │         │
│ │  HGRP_CharacterNPR_Skin shader                              │         │
│ │     (NdotL → ShadowLUT R/G,Ramp,Skin Specular CP8/9)        │         │
│ │     (SDF 化妆,EmotionMap,HighlightMap,Outline)            │         │
│ │     ▼                                                       │         │
│ │  HGCharacterHelper (Renderer 收集 + Bounds + LOD0 限定)     │         │
│ │     ▼ EnqueueCharacter → HGCharacters.m_CharacterHelpers   │         │
│ │  HGCharacters.SortCharacterHelpers (按 priority + id)        │         │
│ │     ▼ UpdateShadowRenderingLayer (slot 0..14 → layer 8..22)│         │
│ │  CharShadowMap (最多 15 张,与 SHADOW_LAYER_START_INDEX=8)  │         │
│ │                                                            │         │
│ │  SkinnedMeshCaptureManager (per-instance dict)              │         │
│ │     ▼ RequestCurrentFrameSkinMatrices → 原生 Vector4* 池    │         │
│ │     ▼ CB = sizeof(int)·4 + bones·48 字节                    │         │
│ │     ▼ SetCaptureDataForPropertyBlock 写 cbuffer            │         │
│ │     ▼ 10 帧 DelayFreeMem 回收                                │         │
│ │                                                            │         │
│ │  HGBoneCapsuleUtilities (Editor 离线烘焙)                   │         │
│ │     从 LODGroup → LOD0 SkinnedMR → 顶点权重 PCA → 胶囊      │         │
│ │     喂给 HGCapsuleShadowHelper → 见交叉引用 §13.3           │         │
│ └────────────────────────────────────────────────────────────┘         │
└───────────────────────────────────────────────────────────────────────┘
```

**HG ↔ HDRP 对照**

| HG | HDRP 同源对应 | delta 摘要 |
|----|---------------|-----------|
| `BurleyNormalizedDuffusion.cs`(注意拼写 `Duffusion`)的 6 个静态函数 | `Editor/Material/DiffusionProfile/DiffusionProfileSettings.Editor.cs` 中 PerpendicularScalingFactor / SearchLightDiffuseScalingFactor / DiffuseSurfaceScalingFactor、`GetMeanFreePathFromDiffuseMeanFreePath` 等 Pixar Burley 闭式 | HG 几乎 1:1 移植；签名增加 `Color`/`Vector3` 三通道重载（HDRP 仅标量） |
| `SubsurfaceManager` (`SubsurfaceConstants._SubsurfaceParams[252]`) | HDRP 的 `_SubsurfaceParams` 由 SSSBuffer 中的 diffuseColor + subsurfaceMask + diffusionProfileIndex 隐式承载 | HG 把每材质 RGB → HSV 后预先打包入 cbuffer（见 §6），跳过 HDRP `EncodeIntoSSSBuffer` 的 `PackFloatInt8bit` 编码 |
| `SubsurfaceProfileManager.SubsurfaceProfileConstants` 双数组 `_SubsurfaceProfileParams0/1[60]` (= 2 × 15 × Vector4) | HDRP `_ShapeParamsAndMaxScatterDists[16]` + `_TransmissionTintsAndFresnel0[16]` + `_WorldScalesAndFilterRadiiAndThicknessRemaps[16]` + `_BorderAttenuationColor[16]` + `_DualLobeAndDiffusePower[16]` (5 个独立数组) | HG 把所有 profile 数据折叠到 2 个 60-float (=15·Vector4) 数组,加 3 张 LUT 阵列 `scatter/penumbra/indirectLut`(W=4,H=64,15 层) 用于 **预积分查表** |
| `MaterialSubsurfaceExtensions.GetSubsurfaceProfile(this Material)` | `Material.subsurfaceProfile` (Unity 原生 setter/getter) | HG 在调 native getter 前先 `Material.HasProperty(HGShaderIDs[+0CC0h])` + 阈值 > 0 网关化 |
| `HGRP_CharacterNPR_Skin` shader (NPR ShadowLUT/Ramp/CP0..15) | 无 (HDRP 自己只有 Burley SSS) | HG 完全自研 NPR — 在 `LWRP/Universal` 流水线下叠加 SSS profile |

---

## 3. Burley Normalized Diffusion 反射剖面 — 数学闭式（HDRP 同源照抄）

**最高优先级真相源**：`SubsurfaceScattering/SubsurfaceScattering.hlsl` 与 `DiffusionProfile/DiffusionProfile.hlsl`、`DiffusionProfile/DiffusionProfileSettings.cs`。HG 的 `BurleyNormalizedDuffusion.cs` 提供的 `GetPerpendicularScalingFactor` / `GetDiffuseSurfaceScalingFactor` / `GetSearchLightDiffuseScalingFactor` / `GetMeanFreePathFromDiffuseMeanFreePath` / `GetDiffuseMeanFreePathFromMeanFreePath` / `GetDiffuseReflectProfileWithDiffuseMeanFreePath` 与 HDRP Editor 中同名函数对位（命名空间不同，Pixar 论文 *Approximate Reflectance Profiles for Efficient Subsurface Scattering*）。

### 3.1 反射剖面 R(r) — Pixar Disney/Burley 归一化

**HDRP 真源** (`DiffusionProfile.hlsl:22-29`，逐字照抄)：

```hlsl
// Performs sampling of the Normalized Burley diffusion profile in polar coordinates.
// The result must be multiplied by the albedo.
float3 EvalBurleyDiffusionProfile(float r, float3 S)
{
    float3 exp_13 = exp2(((LOG2_E * (-1.0/3.0)) * r) * S); // Exp[-S * r / 3]
    float3 expSum = exp_13 * (1 + exp_13 * exp_13);        // Exp[-S * r / 3] + Exp[-S * r]

    return (S * rcp(8 * PI)) * expSum; // S / (8 * Pi) * (Exp[-S * r / 3] + Exp[-S * r])
}
```

数学闭式：

$$
R(r, s) = \frac{s}{8\pi r}\Big(e^{-s r} + e^{-s r/3}\Big), \qquad
\text{其中}\ s = \frac{1}{D}\ \text{即 shapeParam}
$$

它的 PDF 是 $\text{pdf}(r) = r \cdot R(r,s)$，CDF 闭式（HDRP `DiffusionProfile.hlsl:31-36`）：

$$
\text{CDF}(r,s) = 1 - \tfrac{1}{4}e^{-s r} - \tfrac{3}{4}e^{-s r/3}
$$

### 3.2 CDF 的解析逆（Disney Profile Sampling）

**HDRP 真源** (`DiffusionProfile.hlsl:44-65`)，**逐字照抄**（这是核心算法,不允许"约等于"）：

```hlsl
void SampleBurleyDiffusionProfile(float u, float rcpS, out float r, out float rcpPdf)
{
    u = 1 - u; // Convert CDF to CCDF

    float g = 1 + (4 * u) * (2 * u + sqrt(1 + (4 * u) * u));
    float n = exp2(log2(g) * (-1.0/3.0));                    // g^(-1/3)
    float p = (g * n) * n;                                   // g^(+1/3)
    float c = 1 + p + n;                                     // 1 + g^(+1/3) + g^(-1/3)
    float d = (3 / LOG2_E * 2) + (3 / LOG2_E) * log2(u);     // 3 * Log[4 * u]
    float x = (3 / LOG2_E) * log2(c) - d;                    // 3 * Log[c / (4 * u)]

    float rcpExp = ((c * c) * c) * rcp((4 * u) * ((c * c) + (4 * u) * (4 * u)));

    r      = x * rcpS;
    rcpPdf = (8 * PI * rcpS) * rcpExp;
}
```

数学说明：给定均匀随机 $u\in[0,1)$,反演 $\text{CDF}^{-1}$ 得到采样半径 $r$,同时返回 $1/\text{pdf}(r)$ 用于重要性采样权值。HG 反编译里 `GetDiffuseReflectProfileWithDiffuseMeanFreePath(float L, float S3D, float Radius)` 内含 `divss xmm0,dword ptr [g_18C47132C]` + `call sub_1803688E0` (两次 exp) + `mulss xmm6,dword ptr [g_18E5EC4A8]` + `maxss xmm6,dword ptr [g_18E32EF60]`,对应公式 $(\exp(-S R/3) + \exp(-S R))/(8\pi r) \cdot S$ 后取 $\max$ 的同形签名 — **逐字同源**。

### 3.3 三类标量因子（Pixar 解析拟合）

HG `BurleyNormalizedDuffusion` 提供的三个静态因子是 Pixar 论文中由 **mean free path** 和 **searchlight diffuse profile** 间互转所需的多项式拟合，反汇编显示均为 4–6 行浮点闭式（HDRP 在 `DiffusionProfileSettings.Editor.cs` 中也是同形）：

| 函数 | 反汇编关键序列 (`BurleyNormalizedDuffusion.cs`) | 用途 |
|------|---------------|------|
| `GetPerpendicularScalingFactor(A)` | `subss xmm0,[g_..1424]; mulss xmm0,[g_..1950]; subss xmm1,xmm6; addss xmm0,xmm1` (约 1 - A 与 |A - 0.8| 的线性组合) | 垂直入射的 effective albedo → 单散射缩放 |
| `GetDiffuseSurfaceScalingFactor(A)` | `mulss xmm0,[g_..1EAC]; subss xmm1,xmm6; addss xmm0,xmm1` | 漫反射表面 → searchlight 关系 |
| `GetSearchLightDiffuseScalingFactor(A)` | `subss xmm6,[g_..1630]; mulss xmm0,[g_..1548]; addss xmm0,[g_..1EAC]` | 反向 searchlight → diffuse |
| `GetMeanFreePathFromDiffuseMeanFreePath(albedo, dmfp)` | 调用 `GetPerpendicularScalingFactor` + `GetSearchLightDiffuseScalingFactor`,逐通道做 `dmfp * sP / sS` | DMFP → MFP 互换 |
| `GetDiffuseMeanFreePathFromMeanFreePath(albedo, mfp)` | 同上逆变换 | MFP → DMFP |

**结论**：HG 与 HDRP 在算法层面完全一致；Pixar 闭式拟合的具体多项式常数在反汇编里以 `g_18C471xxx` 立即数表呈现 — **HG 在公式形态上没有偏离 HDRP；如需 1:1 复刻请直接照抄 HDRP `DiffusionProfileSettings.Editor.cs` 的对应实现**。

---

## 4. 屏幕空间 SSS Compute — Morton/LDS/HTile/Disk 黄金旋转

**核心通路**：`SubsurfaceScattering.compute` (HDRP 真源)。HG 没有改 kernel 算法本身（反编译里没有任何 `compute kernel` 重命名或常量重写的证据，且 `SubsurfaceManager.BindSubsurfaceData` 是把 `_SubsurfaceParams` cbuffer 喂给 GPU 而非 dispatch SSS — SSS dispatch 由 RenderGraph 上层调度），故**对算法**逐字照抄 HDRP `SubsurfaceScattering.compute`，对**常量与 cbuffer**则跟 HG 的（见 §6）。

### 4.1 配置宏（`SubsurfaceScattering.compute:31-36`）

```hlsl
#define SHADERPASS            SHADERPASS_SUBSURFACE_SCATTERING
#define GROUP_SIZE_1D         16
#define GROUP_SIZE_2D         (GROUP_SIZE_1D * GROUP_SIZE_1D)   // = 256
#define TEXTURE_CACHE_BORDER  2
#define TEXTURE_CACHE_SIZE_1D (GROUP_SIZE_1D + 2 * TEXTURE_CACHE_BORDER)   // = 20
#define TEXTURE_CACHE_SIZE_2D (TEXTURE_CACHE_SIZE_1D * TEXTURE_CACHE_SIZE_1D) // = 400
```

LDS 共享缓存（`SubsurfaceScattering.compute:88-90`，**LDS 总用量 = 400 × 2 × float2 = 6400 字节 ≈ 6.25 KB**,注释明确"6656 bytes used. It appears that the reserved LDS space must be a multiple of 512 bytes"）：

```hlsl
groupshared float2 textureCache0[TEXTURE_CACHE_SIZE_2D]; // {irradiance.rg}
groupshared float2 textureCache1[TEXTURE_CACHE_SIZE_2D]; // {irradiance.b, deviceDepth}
groupshared bool   processGroup;
```

### 4.2 HTile 粗剔除（每线程组首线程,`SubsurfaceScattering.compute:484-501`）

```hlsl
if (groupThreadId == 0)
{
    uint stencilRef = STENCILUSAGE_SUBSURFACE_SCATTERING;
    // 一个 group = 16×16 像素 = 2×2 个 HTile,4 次 fetch:
    uint s00Address = Get1DAddressFromPixelCoord(2 * groupId.xy + uint2(0, 0), _CoarseStencilBufferSize.xy, groupId.z);
    /* s10/s01/s11 同 */
    uint HTileValue = s00 | s10 | s01 | s11;
    processGroup = ((HTileValue & stencilRef) != 0);     // tile 级 reject
}
GroupMemoryBarrierWithGroupSync();
if (!processGroup) { return; }
```

**原理**：硬件 HTile 缓冲已经把屏幕分块（典型 8×8 或 4×4 像素一个 mask 字）；HDRP 用 `_CoarseStencilBuffer` 把每个 tile 的 stencil 标志位 OR 进去，SSS pass 在 group level 直接判断"本 16×16 区域是否有任何 SSS 像素"，避免逐像素跑 257 个采样的浪费。**HG 没有改这一段**。

### 4.3 Morton + LDS L0 cache 填充（`SubsurfaceScattering.compute:475-477` + `:522-573`）

线程在 group 内按 **Morton (Z-order) 顺序**排布,匹配 GCN/RDNA 的 tile 内存布局；中央 16×16 直接 store,外圈 4 像素 border 由前 4 个 wave 并行从 video memory 拉取：

```hlsl
uint2 groupCoord  = DecodeMorton2D(groupThreadId);          // Z-curve 内 16×16
uint2 groupOffset = groupId.xy * GROUP_SIZE_1D;
uint2 pixelCoord  = groupOffset + groupCoord;

// 边界外圈走 wave 分工:
uint waveIndex = WaveReadLaneFirst(groupThreadId / 64);
uint laneIndex = groupThreadId % 64;
uint quadIndex = laneIndex / 4;
if (quadIndex < numBorderQuadsPerWave)
{
    // case 0..3: 四角 wave 各负责一角的 border quad 填充
    ...
    StoreSampleToCacheMemory(float4(irradiance2, depth2), cacheCoord2);
}
```

**TestLightingForSSS**（`SubsurfaceScattering.hlsl:117-120`） — irradiance.b > 0 标记 SSS 像素，是 HDRP 节省"非 SSS 像素 depth 读取带宽"的关键 trick：

```hlsl
float3 TagLightingForSSS(float3 subsurfaceLighting) {
    subsurfaceLighting.b = max(subsurfaceLighting.b, HALF_MIN);   // 标 tag
    return subsurfaceLighting;
}
bool TestLightingForSSS(float3 subsurfaceLighting) {
    return subsurfaceLighting.b > 0;
}
```

### 4.4 屏幕空间黄金旋转 Disk 采样（`SubsurfaceScattering.compute:225-314`）

逐像素：

1. 从 SSSBuffer 解出 `profileIndex` 和 `subsurfaceMask`。
2. 取 profile 参数：

   ```hlsl
   float3 S            = _ShapeParamsAndMaxScatterDists[profileIndex].rgb;
   float  d            = _ShapeParamsAndMaxScatterDists[profileIndex].a;
   float3 borderColor  = _BorderAttenuationColor[profileIndex].rgb;
   float  metersPerU   = _WorldScalesAndFilterRadiiAndThicknessRemaps[profileIndex].x;
   float  filterRadius = _WorldScalesAndFilterRadiiAndThicknessRemaps[profileIndex].y; // mm
   ```

3. 计算 view-space 像素尺度 → 每 mm 多少像素:
   ```hlsl
   float mmPerUnit   = MILLIMETERS_PER_METER * (metersPerUnit * rcp(distScale));
   float unitsPerPixel = max(0.0001f, 2 * abs(cornerPosVS.x - centerPosVS.x));
   float pixelsPerMm   = rcp(unitsPerPixel) * unitsPerMm;
   ```
4. 动态采样数（圆盘面积 / 每样素覆盖像素）：
   ```hlsl
   float filterArea = PI * Sq(filterRadius * pixelsPerMm);
   uint sampleCount = (uint)(filterArea * rcp(SSS_PIXELS_PER_SAMPLE));   // SSS_PIXELS_PER_SAMPLE = 4
   uint sampleBudget = (uint)_SssSampleBudget;                            // 默认: Low=20/Med=40/High=80/Max=1000
   uint n = min(sampleCount, sampleBudget);
   ```
5. **黄金角 Disk 旋转 + Burley CDF 重要性采样**：每个样本 i ∈ [0, n)，做 `SampleBurleyDiffusionProfile(i*scale + offset, d, r, rcpPdf)` 获取半径 `r` 和 `1/pdf`，用 `SampleDiskGolden(i, n).y` 取方位 `φ`，再加上每像素哈希出的全局相位 `phase = 2π * GenerateHashedRandomFloat(pixelCoord + (uint)(depth*16777216))` 旋转,得到屏幕空间偏移：
   ```hlsl
   float2 vec = r * float2(cos(phi+phase), sin(phi+phase));
   int2 position = pixelCoord + (int2)round(pixelsPerMm * vec);
   ```
6. **双边权（screen-Z bias，跨深度断层会丢权）**（`SubsurfaceScattering.compute:151-181`）：
   ```hlsl
   float relZ = sampleViewZ - centerLinearDepth;
   // 直接用 R(sqrt(xy² + relZ²)) 而非 R(sqrt(xy²)),让深度突变处自动衰减
   float r = sqrt(xy2 + (z * mmPerUnit) * (z * mmPerUnit));
   float3 weight = EvalBurleyDiffusionProfile(r, S) * rcpPdf;
   ```
7. **跨剖面遮挡** (`SubsurfaceScattering.compute:286-299`)：通过 `_DiffusionProfileIndexTexture` 检测样本像素是否同 profile,若不同则乘 `borderAttenuationColor`（在皮肤–布料、皮肤–头发的边界制造可控的黑边）。
8. 累积加权,写回 `_CameraColorTexture` (USE_INTERMEDIATE_BUFFER) 或 `_CameraFilteringTexture`(MSAA path)。

最终输出：

```hlsl
result.irradiance = albedo * (totalIrradiance / totalWeight);
```

### 4.5 PackDiffusionProfile kernel（`SubsurfaceScattering.compute:619-639`,thread = 8×8）

把 SSSBuffer 中相邻 2 像素的 `diffusionProfileIndex` (4-bit) 打包到一个 R8 纹理中，供主 kernel 跨边界检测时只采样 1/2 宽度纹理：

```hlsl
[numthreads(8, 8, 1)]
void PackDiffusionProfile(uint3 dispatchThreadId ...) {
    uint2 pixelCoord0 = uint2(dispatchThreadId.x * 2, dispatchThreadId.y);
    uint2 pixelCoord1 = pixelCoord0 + uint2(1, 0);
    uint packedProfiles = 0;
    SSSData sssData;
    DECODE_FROM_SSSBUFFER(pixelCoord0, sssData);
    packedProfiles |= sssData.diffusionProfileIndex & 0xF;
    DECODE_FROM_SSSBUFFER(pixelCoord1, sssData);
    packedProfiles |= (sssData.diffusionProfileIndex & 0xF) << 4;
    _DiffusionProfileIndexTexture[COORD_TEXTURE2D_X(dispatchThreadId.xy)] = packedProfiles;
}
```

---

## 5. Diffusion Profile 体系 — Halley 反演 CDF、shapeParam、filterRadius、IOR→F0

**HDRP 真源** (`DiffusionProfile/DiffusionProfileSettings.cs:124-150` 的 `UpdateKernel`)：

```csharp
void UpdateKernel()
{
    Vector3 sd = scatteringDistanceMultiplier * (Vector3)(Vector4)scatteringDistance;

    // S = 1 / D,带 16M 数值上限避免 Inf
    shapeParam = new Vector3(Mathf.Min(16777216, 1.0f / sd.x),
                              Mathf.Min(16777216, 1.0f / sd.y),
                              Mathf.Min(16777216, 1.0f / sd.z));

    // 三 sigma 规则：以 99.7% 累积概率取 filterRadius
    float cdf = 0.997f;

    // 用 widest channel 决定 filter 半径,确保所有通道都被覆盖
    maxScatteringDistance = Mathf.Max(sd.x, sd.y, sd.z);

    filterRadius = SampleBurleyDiffusionProfile(cdf, maxScatteringDistance);
}
```

### 5.1 IOR → F0 (Schlick 菲涅尔反射率)

`UpdateCache` (`DiffusionProfileSettings.cs:392-410`)：

```csharp
float fresnel0 = (profile.ior - 1.0f) / (profile.ior + 1.0f);
fresnel0 *= fresnel0;                                    // square
transmissionTintAndFresnel0 = new Vector4(
    profile.transmissionTint.r * 0.25f,                  // 预乘 1/4，省一个常量
    profile.transmissionTint.g * 0.25f,
    profile.transmissionTint.b * 0.25f,
    fresnel0);
```

`ior = 1.4` 对应 skin specular `F0 ≈ 0.0278`。`worldScaleAndFilterRadiusAndThicknessRemap.xy = (worldScale, filterRadius_mm)`,zw = `(thicknessRemap.x, thicknessRemap.y - thicknessRemap.x)` — 线性 remap 范围预存。

### 5.2 CDF 反演的 Halley 法 (Editor only, HDRP `DiffusionProfileSettings.cs:179-205`)

HDRP 同时提供解析逆 (`SampleBurleyDiffusionProfile`) **和** Halley 数值法 (`DisneyProfileCdfInverse`)，后者用于显示曲线、性能不敏感场景：

```csharp
static float DisneyProfileCdfInverse(float p, float s)
{
    float r = (Mathf.Pow(10f, p) - 1f) / s;     // 初值 (10^p - 1)/s
    float t = float.MaxValue;
    while (true)
    {
        float f0 = DisneyProfileCdf(r, s) - p;
        float f1 = DisneyProfileCdfDerivative1(r, s);
        float f2 = DisneyProfileCdfDerivative2(r, s);
        float dr = f0 / (f1 * (1f - f0 * f2 / (2f * f1 * f1)));
        if (Mathf.Abs(dr) < t) { r -= dr; t = Mathf.Abs(dr); }
        else break;
    }
    return r;
}
```

数学：Halley 法迭代 $r_{n+1} = r_n - \dfrac{2 f f'}{2 (f')^2 - f f''}$,3 阶收敛快于 Newton。HG 同步移植了 `BurleyNormalizedDuffusion.cs` 中标量+三通道两份拟合 — 仅作 Inspector 工具。

---

## 6. HG 双 cbuffer + Profile/Material 分离（delta vs HDRP）

这是 **HG 与 HDRP 唯一一处真正的架构差异**。

### 6.1 数据规模

HG 反编译 (`SubsurfaceManager.cs:11-17`,`SubsurfaceProfileManager.cs:224-232`)：

```csharp
internal struct SubsurfaceConstants
{
    public unsafe fixed float _SubsurfaceParams[252];                  // 63 × Vector4 = 252 float
}
private const int MAX_SUBSURFACE_MATERIAL_COUNT = 63;
private const int NONE_SUBSURFACE_MATERIAL_INDEX = 0;

internal struct SubsurfaceProfileConstants
{
    [HLSLArray(4, typeof(Vector4))]
    public unsafe fixed float _SubsurfaceProfileParams0[60];           // 15 × Vector4
    [HLSLArray(4, typeof(Vector4))]
    public unsafe fixed float _SubsurfaceProfileParams1[60];           // 15 × Vector4
}
public const int MAX_PROFILE_COUNT = 15;
public const int NONE_PROFILE_INDEX = 0;
```

对比 HDRP：HDRP 的 profile 池容量 `DIFFUSION_PROFILE_COUNT = 16` (`DiffusionProfileSettings.cs:9-11`)、`SSS_PIXELS_PER_SAMPLE = 4`、`DefaultSssSampleBudgetForQualityLevel = { Low=20, Medium=40, High=80, Max=1000 }`、`DefaultSssDownsampleSteps = { Low=0, Medium=0, High=0, Max=2 }`。

> **关键 delta**：HG 的 profile 容量 **15**（HDRP 16），原因是把 `NONE_PROFILE_INDEX = 0` 当 sentinel 后还剩 15 个，HG 的 shader 端 4-bit 索引仍走 `& 0xF` 但需 < 15 — 与 HDRP 行为一致但少一槽。
> HG 的 **材质池容量 63**（HDRP 没有该概念）：HG 引入了 `Material InstanceID → 池槽` 的映射，按材质而非按 profile 来索引 `_SubsurfaceParams[63]`（每材质一份 RGB→HSV 后的颜色与 indirect 强度）。这是 HDRP 把这两类信息分别塞进 SSSBuffer 的 `diffuseColor` + `subsurfaceMask` 通道后的**外置化**：HG 把它从 GBuffer 拿出来挪进 cbuffer，省 1 bit profile + 8 bit mask 编码而代之以材质槽位号。

### 6.2 SubsurfaceManager 注册/反注册（生命周期）

```csharp
[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
private static void RegisterMaterialCallback()
{
    // 反编译: HGShadingStateSystem.add_shadingStateChanged += OnShadingStateChanged
    // 然后 FlushAllMaterialCallbacks(0) 触发已存在材质的回调
}

private static void OnShadingStateChanged(int instanceId, bool state)
{
    var ctx = HGManagerContext.currentManagerContext;
    if (state) ctx.SubsurfaceManager.RegisterSubsurfaceMaterial(instanceId);
    else       ctx.SubsurfaceManager.UnregisterSubsurfaceMaterial(instanceId);
}
```

`RegisterSubsurfaceMaterial(int instanceId)` (反编译 VA `0x18A7AEAC0`):
1. 通过 `HGShadingStateSystem.GetMaterial(handle)` 取回 Material。
2. 调 `MaterialSubsurfaceExtensions.GetSubsurfaceData(material, out data)` 读取 `_SubsurfaceColor` 与 `_SubsurfaceIndirect` shader 属性（仅当 `HasProperty(toggleId) && GetFloat(toggleId) > 0`）。
3. 在 `dataList[0..62]` 找空槽（`RefCount == 0` 即空），同槽位若已被相同 data 占据则直接复用 `RefCount++`。
4. **超 63 个材质** → `HGRPLogger.LogError("Subsurface material exceed max count")`。
5. 写 `Material.SetFloat(HGShaderIDs[+0D44h], (slot+1).ToFloat())` — slot 索引以 1-based 写回（0 表示 NONE_SUBSURFACE_MATERIAL_INDEX）。

`MaterialSubsurfaceExtensions.GetSubsurfaceData` 的反编译显示读三个 shader prop ID（`HGShaderIDs[+0D2C, +0D30, +0D40]`），分别对应 enable 阈值、`_SubsurfaceColor` 与 `_SubsurfaceIndirect`。

### 6.3 BindSubsurfaceData — RGB→HSV 预转换 + cbuffer 上传

每帧或每次脏值，`SubsurfaceManager.BindSubsurfaceData(HGRenderGraphContext context)` 把 63 × Vector4 转换后上传：

反编译关键序列：

```asm
loc_18A7AE7E9:                  // 循环 i=0..62
    mov rcx,[r14+18h]           // dataList
    cmp ebx,[rcx+18h]           // i < count
    jge ...
    movups xmm0,[rcx+rdx*8+20h] // SubsurfaceColor (Color = 4 float)
    movsd  xmm1,[rcx+rdx*8+30h] // SubsurfaceIndirect (float) + RefCount
    test eax,eax                // if (RefCount > 0)
    jle  skip_hsv               //   skip this slot
    /* 调 UnityEngine.Color::RGBToHSV(color, out H, out S, out V) */
    movss xmm0,[rbp+798h]       // H
    movss [rdi-4],xmm0          // _SubsurfaceParams[i].x = H
    movss xmm1,[rsp+30h]        // S
    movss [rdi  ],xmm1          // _SubsurfaceParams[i].y = S
    movss xmm0,[rsp+34h]        // V
    movss [rdi+4],xmm0          // _SubsurfaceParams[i].z = V
    movss xmm1,[rsp+74h]        // SubsurfaceIndirect (float)
    movss [rdi+8],xmm1          // _SubsurfaceParams[i].w = indirect
loc_18A7AE88E:
    inc ebx
    add rdi,10h                 // 每槽 16 字节 = Vector4
    cmp ebx,3Fh                 // 63
    jl  loop
```

然后 `ScriptableRenderContext.AllocateConstantBuffer(cb, 3F0h)` (= 1008 字节 = 252 × 4)，`memcpy` 后 `CommandBuffer.SetGlobalConstantBufferInternal0(cb, HGShaderIDs[+0D48h], 0, 3F0h)`。

**为什么 RGB→HSV？** HSV 域里调"偏红""偏蓝"对应单一坐标变换；shader 端在做 `albedo × tint × multiplier` 时，可以在 HSV 空间做色相微旋而非在 RGB 中跑三通道独立 — 与 NPR 角色 shader 在 ShadowLUT 中查 V 通道用作"明暗值"完美对齐（见 §9.4）。**这是 HG 在 HDRP 之外的小却关键的工程化优化**。

### 6.4 SubsurfaceProfileManager — Profile 注册 + 3 张 LUT 阵列

`SubsurfaceProfileManager` 持有：

```csharp
private struct SubsurfaceProfileNode {
    public int refCount;
    public HGSubsurfaceProfile profile;
}
private class SubsurfaceProfileData {
    public Texture2DArray scatterLutArray;     // W=4, H=64, depth=15, RGBA8 mipless
    public Texture2DArray penumbraLutArray;    // W=4, H=64, depth=15
    public Texture2DArray indirectLutArray;    // W=1, H=64, depth=15
}
private Dictionary<ProfileKey, int> instanceId2Index;
private SubsurfaceProfileNode[] profileList;   // 15 个
```

`ProfileKey = (instanceId, terrain)` — 这是 HG 的独特之处：**地形也走 SSS profile**（沙地、苔藓等模拟次表面），通过 `bool terrain` 区分材质槽与地形槽（地形固定走 `RegisterFromTerrain(profile)` 入口）。

`TryInitialize` (反编译 VA `0x184014290`) 在第一次访问时一次性创建 3 个 `Texture2DArray`：

```
scatterLut:  TextureFormat = 4 (RGBA32), width=64, height=64, depth=15, mipmap=true
penumbraLut: TextureFormat = 4 (RGBA32), width=64, height=64, depth=15, mipmap=true
indirectLut: TextureFormat = 4 (RGBA32), width=1 , height=64, depth=15, mipmap=true
hideFlags = 3Dh (DontSave | NotEditable | HideAndDontSave)
```

`UpdateProfileDataImpl(int index)` 从 `HGSubsurfaceProfile` 的 `scatterLut/penumbraLut/indirectLut` 三张属性图，调 `Graphics.CopyTexture(srcTex, 0, 0, dstArray, slotIndex, 0)` 拷到对应 slice — 也就是说 `HGSubsurfaceProfile` 是 **ScriptableObject + 预烘焙 LUT 资产**，shader 端通过 `slotIndex + 1` 索引 3D array 直接采样,**无需运行时算 R(r) 解析式**（HDRP 走的是运行时 hlsl 内联）。

> **delta 总结**：HDRP 在 shader 内每像素跑 `EvalBurleyDiffusionProfile`/`SampleBurleyDiffusionProfile`；**HG 用 3 张预积分 LUT (`scatter` 主反射、`penumbra` 半影、`indirect` 间接) 缓存这些函数,采样次数 = O(1)** — 这是 HG 自定 SSS shader（未对外暴露，但 `BindProfileData` 已经把 `HGShaderIDs[+0D08/0D0C/0D10]` 三张 texture 设到全局）走的路径,与 HDRP 完全异构。`_SubsurfaceProfileParams0/1[60]` 则承载非 LUT 的标量：`subsurfaceNormalLerp.x/y/z + curvatureScale` (Vector4) 和 `penumbraScale` (写到 +0F0h 偏移)。

### 6.5 BindProfileData 上传序

反编译 (`SubsurfaceProfileManager.BindProfileData` VA `0x18A7AEE78`)：

```csharp
private struct VisibilityParams { Vector4 normalLerp; float curvatureScale; float penumbraScale; }

// 1. 设三张 LUT 全局
cmd.SetGlobalTexture(HGShaderIDs[+0D08h], scatterLutArray);   // _SubsurfaceScatterLut
cmd.SetGlobalTexture(HGShaderIDs[+0D0Ch], penumbraLutArray);  // _SubsurfaceLutPenumbra
cmd.SetGlobalTexture(HGShaderIDs[+0D10h], indirectLutArray);  // _SubsurfaceIndirectLut

// 2. 填 Profile cbuffer (15 个 entry)
for (int i = 0; i < 15; i++) {
    var node = profileList[i];
    if (node.refCount > 0 && node.profile != null) {
        var nl = node.profile.subsurfaceNormalLerp;   // Vector3 normalLerp
        constData.Params0[i*4+0] = nl.x;
        constData.Params0[i*4+1] = nl.y;
        constData.Params0[i*4+2] = nl.z;
        constData.Params0[i*4+3] = node.profile.curvatureScale;
        constData.Params1[i*4+0] = node.profile.penumbraScale;
        // ...其他 3 个 Vector4 字段未在反编译里展开
    }
}

// 3. AllocateConstantBuffer(1E0h = 480 = 2 × 60 × 4) + SetGlobalConstantBufferInternal0
ctx.AllocateConstantBuffer(cb, 0x1E0);
cmd.SetGlobalConstantBufferInternal0(cb, HGShaderIDs[+0D14h], 0, 0x1E0);
```

---

## 7. Random Downsample 与 Combine Lighting 复合通路

### 7.1 RandomDownsample.compute (`RandomDownsample.compute:25-41`)

可选半分辨率（`DefaultSssDownsampleSteps.Max = 2` → 1/16 像素）预降采样,用 InterleavedGradientNoise 给每个目标像素挑一个源像素：

```hlsl
#define GROUP_SIZE 8
int _SssDownsampleSteps;
[numthreads(GROUP_SIZE, GROUP_SIZE, 1)]
void Downsample(uint3 dispatchThreadId : SV_DispatchThreadID)
{
    uint2 positionSS = dispatchThreadId.xy;
    uint  scale1d   = 1u << _SssDownsampleSteps;   // 1, 2 or 4
    float rand = InterleavedGradientNoise(positionSS, _FrameCount);
    uint  index = uint(rand * scale1d * scale1d);
    uint2 inputSS = (positionSS * scale1d) + uint2(index / scale1d, index % scale1d);
    float4 value = LOAD_TEXTURE2D_X(_SourceTexture, inputSS);
    _OutputTexture[COORD_TEXTURE2D_X(positionSS)] = value;
}
```

为何随机？避免规整 box 降采样在皮肤上产生条纹伪影；时域上 IGN 抖动配合 TAA 重投影可以无损还原细节。

### 7.2 CombineLighting.shader (`CombineLighting.shader:46-99`)

把 SSS 后的 irradiance 加回 main color buffer，Pass 1 用 exposure 乘子（HDR 流水线分离曝光时的微调）：

```hlsl
Stencil { ReadMask [_StencilMask] Ref [_StencilRef] Comp Equal Pass Keep }
Cull Off  ZTest Less  ZWrite Off  Blend One One     // additive

// Pass 0: 不乘曝光
float4 Frag(Varyings input) : SV_Target {
    float3 color = LOAD_TEXTURE2D_X(_IrradianceSource, input.positionCS.xy).rgb;
    return float4(color, 0);                          // alpha = 0,防止后段被加爆
}

// Pass 1: 乘当前曝光
float3 color = LOAD_TEXTURE2D_X(_IrradianceSource, input.positionCS.xy).rgb * GetCurrentExposureMultiplier();
```

`ZTest Less` 是为了配合 XR occlusion mesh —— 注释里写得明白。

---

## 8. Transmittance Disney（薄物穿透）— 与 SSS 共享 profile

**HDRP 真源** (`DiffusionProfile.hlsl:9-19`)：

```hlsl
// Premultiply & optimize: T = (1/4 * A) * (e^(-S * t) + 3 * e^(-S * t / 3))
float3 ComputeTransmittanceDisney(float3 S, float3 volumeAlbedo, float thickness)
{
    float3 exp_13 = exp2(((LOG2_E * (-1.0/3.0)) * thickness) * S); // Exp[-S * t / 3]
    return volumeAlbedo * (exp_13 * (exp_13 * exp_13 + 3));
}
```

数学：把 BSSRDF 在面板模型下对 $r\in[0,\infty)$ 极坐标积分,得到厚度为 $d$ 时的总穿透率：

$$
T(d, s) = \frac{1}{4}A \big(e^{-s d} + 3 e^{-s d/3}\big)
$$

其中 $A$ = `volumeAlbedo`（注意 `transmissionTintAndFresnel0.rgb` 已经预乘 0.25，所以 hlsl 里不再乘 1/4）。HG 与 HDRP 共享同一 `_SubsurfaceProfileParams0/1` cbuffer 中的 shapeParam 与 transmissionTint — 不另行存储。

**`thicknessRemap` 重映射**（`DiffusionProfile.hlsl:225` 处的 `FillMaterialTransmission`）：

```hlsl
float2 remap = _WorldScalesAndFilterRadiiAndThicknessRemaps[diffusionProfileIndex].zw;
bsdfData.thickness = remap.x + remap.y * thickness;   // y = (max - min), 线性 remap
```

HDRP 默认 `thicknessRemap = (0, 5) mm`,`worldScale = 1`,`ior = 1.4`,`borderAttenuationColor = black`（`DiffusionProfile.cs:88-102`）。**HG 沿用同一默认**。

---

## 9. 角色 NPR Skin Shader 算法（HG 自研）

源代码可读：`D:\Ruri\02.Unity\Project\FractalMiner\Assets\Project\EndField\HGRP\HGRP_CharacterNPR_Skin_Fix.shader` （body + face 变体合并）。

> 本节是"HG 自研模块"，不存在 HDRP 同源；据真实 .shader 代码 1:1 复刻。

### 9.1 Pass 拓扑

- **Pass ForwardLit**：主 BRDF + NPR 着色。
- **Pass Outline**：反向法线挤压描边 (沿 OS normal × `_OutlineWidth`),独立 ZTest LEqual。
- **Pass ShadowCaster**：标准深度图。
- **Pass DepthOnly / DepthNormalsOnly**：URP 兼容。

材质参数池（CBUFFER UnityPerMaterial,关键字段）：

```hlsl
float4 _CharacterParams0;   // .y=diffuse  .z=LUT  .w=brightness
float4 _CharacterParams1;   // .x=brightMix .y=shadowStr .z=shadowLerp .w=lightDirOverride
float4 _CharacterParams3;   // ambient color rgb
float4 _CharacterParams4;   // light color override rgb
float4 _CharacterParams6;   // ambient direction
float4 _CharacterParams7;   // .x=offset .y=scale .z=bias
float4 _CharacterParams8;   // skin spec color + .w=intensity
float4 _CharacterParams9;   // skin spec .xy=dir .z=tint .w=width
float4 _CharacterParams11;  // light dir override + .w=rampBias
float4 _CharacterParams12;  // .x=rampOffset .y=lightColOverride .z=shadowGate .w=exposureBlend
float4 _CharacterParams13;  // .w=GGX specular toggle
float4 _CharacterParams14;  // secondary spec (face) + .w=intensity
float4 _CharacterParams15;  // .z=SDF secondary threshold
float4 _EnvironmentGlobalParams0; // 1.67, 1.5, 1, 0
float4 _ExposureParams;     // (exposure, 0, 0, 0)
```

这 16 个 Vector4 的来源 = **HGCharacterVolume**（§10）—— shader 把它们当 per-instance 拉入，每帧由 manager 推送。

### 9.2 主光方向 / 边光方向重建

shader 不直接拿 `_MainLightPosition`,而是从 CP11 (`xyz`) 重建主光方向（`computeNPRLighting` 内）。理由：HGCharacterVolume 可以"强制主光方向"做演出（`CharacterLightMode.Custom`）。`charMainLightControl == true` 时 manager 把 `CharLightVector` 经过 `Vector2 rotation → Vector3` 转换后写入 `_CharacterParams11.xyz`：

反编译 `HGCharacterVolume.GetCharLightVector(Vector2 rotation)` (VA `0x184C89CC0`)：

```
xmm6 = rot.y, xmm7 = rot.x
xmm6 = rot.y * (π/180)          // 度→弧度
xmm9 = sin(rot.y)
xmm10 = sin(rot.y) * cos(rot.x) (= forward X)
xmm10 ^= sign-flip-mask         // x = -sin(y)·cos(x)
xmm7  = -cos(y)                 // y component
xmm6  = sin(y)·sin(x)           // z component (× sign flip)
write Vector3(x, y, z) into [rdi]
```

数学：

$$
\vec{L} = \big(-\sin(\theta_y)\cos(\theta_x),\ -\cos(\theta_y),\ -\sin(\theta_y)\sin(\theta_x)\big)
$$

球面坐标到方向矢量的标准映射，`θx` 为水平角、`θy` 为高度角；负号让向量指向"光源到表面"反向。

### 9.3 法线 / View / Normal Map（`computeNPRLighting` 实现）

```hlsl
float3 toCam = _WorldSpaceCameraPos - positionWS;
// 正交相机走 orthoFwd,透视走 toCam
float3 V = normalize(toCam + unity_OrthoParams.w * (orthoFwd - toCam));

#ifdef _NORMALMAP
    // BC5 风格 DXT5nm: x 来自 .a × .r,y 来自 .g,z 重构
    float nrmX = (nrmSmp.x * nrmSmp.w * 2.0 - 1.0) * _BumpScale;
    float nrmY = (nrmSmp.y * 2.0 - 1.0) * _BumpScale;
    float nrmZ = max(sqrt(1.0 - saturate(nrmX*nrmX + nrmY*nrmY)), 1e-16);
    float3 nrmWS = normalize(normalWS_raw);
    float3 tanWS = normalize(tangentWS.xyz);
    float3 bitWS = cross(nrmWS, tanWS) * tangentWS.w;
    N = faceSign * normalize(nrmX * tanWS + nrmY * bitWS + nrmZ * nrmWS);
#endif
```

`faceSign` 由背面渲染时（`_BackFaceNormalFlip` enable）取 -1 翻转法线方向。

### 9.4 Shadow LUT — 阴影色调来自 sRGB×3D LUT

NPR 风格化阴影的灵魂 trick：把光照计算得到的"应有暗部颜色"**不是**直接 `albedo × NdotL`，而是把 albedo 转 sRGB 后通过一张 32×32×32 的 3D LUT (实际打成 1024×32 的 2D atlas，B 分层) 重新映射到艺术家手工调过的阴影色调。

```hlsl
#ifdef _SHADOW_LUT_TEX
    float sR = saturate(LinearToSRGB_Custom(albedo.r));
    float sG = saturate(LinearToSRGB_Custom(albedo.g));
    float sB = saturate(LinearToSRGB_Custom(albedo.b));
    float bSlice = floor(sB * 31.0);                          // 32 切片
    float lutU = bSlice * 0.03125 + sR * 0.0302734375 + 0.00048828125;   // (1/32, 31/32/32, 0.5/32)
    float lutV = sG * 0.96875 + 0.015625;                     // (31/32, 0.5/32)
#endif
```

数学：标准 3D LUT 解包为 2D（B 分层），UV 偏移半像素避免黑边。一张 LUT = 32 层 × 32×32 像素 = 1024×32 RGB。皮肤暗部往往设为暖红色，蓝色阴影会被 LUT 映射为带红的暗,实现"皮肤下层血液透出"的快速近似 — **跳过昂贵的 SSS Compute 也能拿到 80% 视觉效果**。

### 9.5 Diffuse Ramp（卡通明暗界线）

```hlsl
#ifdef _DIFF_RAMP_ON
    float rampU = saturate(NdotL * 0.5 + 0.5 + _CharacterParams11.w);    // halflambert + rampBias
    rampU = rampU * (1.0 - _CharacterParams12.x) + _CharacterParams12.x; // rampOffset 收紧暗部
    float3 ramp = SAMPLE_TEXTURE2D(_DiffRampMap, sampler_DiffRampMap, float2(rampU, 0.5)).rgb;
#endif
```

`rampBias` (CP11.w)、`rampOffset` (CP12.x) 由 `HGCharacterVolume.charMainLightRangeBias` 提供 — 滑条调整明暗交界位置，演出可 tune。

### 9.6 Skin Specular — CP8/CP9 双 lobe（Anisotropic Skin Highlight）

```hlsl
// CP8 = (R, G, B, intensity)        皮肤高光颜色
// CP9 = (lobeDirX, lobeDirY, tint, width)
float3 skinSpecDir = normalize(float3(_CharacterParams9.x, 1, _CharacterParams9.y));
float NdotS = dot(N, skinSpecDir);
float skinSpec = pow(saturate(NdotS), _CharacterParams9.w * 10.0);   // width 越大,叶片越窄
float3 specColor = _CharacterParams8.rgb * _CharacterParams8.a * skinSpec;
```

`skinSpecDir.y = 1` 是常项 — 让高光偏天顶,符合"皮肤主光来自上方"的艺术家习惯；`xy` 让横向偏移。这是一种"假各向异性 specular"近似 Kelemen-Szirmay 模型的简化版。

### 9.7 Fresnel Rim + 一键 AutoRim

```hlsl
float NdotV = dot(N, V);
float rimFresnel = 1.0 - (saturate(NdotV) * 0.85 + 0.15);          // 视角夹角衰减
float rimAmt = saturate(rimFresnel * rimModifier * rimOffScale);
// rimOffScale = skin 时 _SkinRimOffScale, face 时 _FaceRimOffScale
```

`HGCharacterVolume.GetCharAutoRimVector(directionAngle)` (反编译 `0x1844AEC40`)：

```
xmm6 = directionAngle * (π/180)
result.x = cos(angle); result.y = sin(angle); result.z = 0
```

—— 平面方向 2D 向量 (x, y, 0)，由 manager 写入 `_CharacterParams8.xy` 决定全局 rim 方向。`GetCharFaceRimVector` 类似但 z 也参与（脸部需要 3D 方向）。

### 9.8 VFX Color Adjustment（演出后处理）

`computeNPRLighting` 末尾把 lit color 走 `_EnableVFXColorAdjustment` 分支：

```hlsl
// brightness 0.5~1.5,saturation 0~2,contrast 0~2,叠加 rim 颜色 RimColor × pow(1 - NdotV, width)
float3 grey = dot(lit, LUM);
lit = lerp(grey, lit, _ColorAdjustmentSaturation);
lit *= _ColorAdjustmentBrightness;
lit = (lit - 0.5) * _ColorAdjustmentContrast + 0.5;
float vfxRim = pow(saturate(1 - NdotV_sat), _ColorAdjustmentRimWidth * 10);
lit += _ColorAdjustmentRimColor.rgb * vfxRim * _ColorAdjustmentRimIntensity;
```

这套是"shader-side color grading",独立于 PostProcess Stack —— 适合演出按角色单独调色（剧情 CG 中主角变红/变蓝）。

### 9.9 face 分支（`_SDFLIGHTMAP` keyword）

脸部专属：

- **SDF Lightmap**（`_SDFLightmap`）：作 wrap NdotL 替代,2D SDF 决定明暗位置（解决"鼻翼阴影从左到右乱跳"的问题）。
- **SDF Mask**（`_SDFMask.rgba`）：r = rim 强度遮罩,g = rim/lightmap 混合比,b = 皮肤/非皮肤区分(嘴/眉)，a = 控制掩码。
- **Emotion Map** (`_EmotionMap` + `_EmotionIndex`)：4 张表情贴图 atlas，通过 `_EmotionBlend` 在 `floor(idx)` 与 `floor(idx)+1` 之间插值。
- **Highlight Map**（`_HighlightMap` + `_HighlightMapVector`）：脸部局部高光,用 object-space 方向投射查表。
- **CP14 Secondary Specular**：脸部独立的第二 spec lobe，用于额头/鼻梁高光。

---

## 10. `HGCharacterVolume` — 演出层光照参数

源：`HGCharacterVolume.cs`，继承 `UnityEngine.Rendering.VolumeComponent`，菜单 `HG/HGCharacter/CharacterLighting`。

32+ 个 VolumeParameter（节选）：

| 字段 | 类型 | 含义 (CN→shader) |
|------|------|------------------|
| `charAmbientModeIndex` | enum {`Default`,`TopLight_LowContrast`,`TopLight_HighContrast`,`InDoor_Normal/Bright/Dark`,`Custom`} | 预设环境光球 |
| `charAmbientLightBaseIntensity` / `charAmbientLightDirIntensity` / `charAmbientLightDirParam` | float | 环境光强度与方向性强度系数 (写入 CP3 + CP6) |
| `charGlobalAmbientParam0/1` | Vector4 | 通用 ambient cbuffer 写到全局 |
| `charMainLightControl` | bool | 是否强制主光方向 (走 `Custom`) |
| `charMainLightMultiplier` / `charEnvLightMultiplier` / `charEnvShadowMultiplier` / `charMainLightSpecularMultiplier` | float | 主光、背光、环境亮度、高光强度 (写入 CP4/CP7/CP8.w 等) |
| `charEyeBaseLightMultiplier` / `charEyeHighlightMultiplier` / `charEyeScatteringMultiplier` | float | 眼睛专属系数 (Eye shader) |
| `charMainLightRangeBias` | float | 明暗交界偏移 → CP11.w (`rampBias`) |
| `charIgnoreMainLightShadow` | bool | 角色忽略主方向光阴影 |
| `charMainLightMode` | enum {`Scene`,`CameraFollow`,`Custom`} | 跟场景 / 跟相机 / 自定义 |
| `charCustomMainLightDir` / `charCameraFollowMainLightBias` | Vector2 | (θx, θy) → `GetCharLightVector` (§9.2) |
| `charMainLightOverrideColor` / `charSkinMainLightOverrideColor` | Color | 普通材质 vs 皮肤分别覆盖主光颜色 → CP4 |
| `charLightDialogMode` | bool | Dialog 演出模式：场景暗时自动加强角色光 |
| `charShadowTintControl` | enum {`Auto`,`CustomTintColor`} | 阴影 tint 控制模式 |
| `charShadowTintColor` / `charSkinShadowTintColor` | Color | 阴影色调（非皮肤/皮肤分两路） |
| `charShadowMode` | enum {`SceneLight`,`CameraVirtualLight`} | 自阴影方向跟场景主光 or 相机虚拟光 |
| `charAutoRimEnable/Color/Dir/Intensity/Width/Albedo/Mode` | 多种 | 一键全身边缘光（写入 CP8/CP9） |
| `charFaceRimEnable/Color/Dir/Intensity` | 多种 | 脸部额外 rim |
| `charRainEffectPreviewEnable/Intensity` `charSnowEffectPreviewIntensity` `charWetEffectPreviewWorldHeight` `charRainEffectTextureTiling` | 多种 | 雨/雪/湿润效果（演出预览） |
| `charIgnoreSceneAdditionalLights` / `charIgnoreSceneEnv` | bool | 屏蔽场景点光 / 忽略 EnvVolume 影响 |
| `charOutlineQualityMode` / `charSelfShadowQualityMode` | enum {`AlwaysOn`,`Tier10`,`Tier20`,`AlwaysOff`} | 描边 / 自阴影按硬件 tier 开关 |

`HGCharacterQualitySettings`（`HGCharacterQualitySettings.cs`）3 个静态字段：

```csharp
public static int characterSelfShadowOffLodQuality;   // LOD 等级以上关闭自阴影
public static int characterShadowTierLevel;
public static int characterOutlineTierLevel;
```

—— 由项目 Bootstrap 设置（基于设备探测）。Volume 中 enum 数值 `Tier10 = 10, Tier20 = 20, AlwaysOff = int.MaxValue` 与 `characterShadowTierLevel` 做大小比较：当前 tier ≥ Volume 配置则启用。

**`GetCharOutlinePassEnableState` 与 `GetCharShadowPassEnableState`** 在反编译中：

```
mov ecx,0Ah                                      ; 取 [???? 0Ah]
call sub_18003D040                               ; 返回当前 tier (eax)
mov ebx,eax
mov rcx,[HGCharacterQualitySettings]
mov rcx,[rcx+0B8h]                               ; static field block
cmp [rcx+8],ebx                                  ; characterOutlineTierLevel < currentTier ?
jl  loc_*                                        ; 大于等于 → 启用
mov al,1
```

→ 即"当前 device tier ≥ configured outlineTierLevel → 开启 outline"。

---

## 11. `HGCharacters` 注册器 + `HGCharacterHelper` Renderer 收集

### 11.1 静态注册器（`HGCharacters.cs`）

```csharp
public class HGCharacters {
    private static List<HGCharacterHelper> m_CharacterHelpers;     // 全局有序列表
    public const int MAX_CHARACTER_SHADOWMAP_COUNT = 15;            // 阴影槽位上限
    public const int SHADOW_LAYER_START_INDEX = 8;                  // 角色阴影 layer 起始位
}
```

`EnqueueCharacter`：

```csharp
public static void EnqueueCharacter(HGCharacterHelper h)
{
    if (h != null && !m_CharacterHelpers.Contains(h))
    {
        m_CharacterHelpers.Insert(0, h);    // 插到首位
        SortCharacterHelpers();
    }
}
```

`SortCharacterHelpers`：

```csharp
m_CharacterHelpers.Sort();                                 // 调 CompareTo (按 priority + id)
foreach (var h in m_CharacterHelpers) {
    var slot = m_CharacterHelpers.IndexOf(h);              // 0..14
    h.UpdateShadowRenderingLayer(slot);
}
```

`HGCharacterHelper.CompareTo`：

```csharp
public int CompareTo(object obj) {
    var other = obj as HGCharacterHelper;
    int cmp = priority.CompareTo(other.priority);          // priority 升序
    if (cmp != 0) return cmp;
    return id - other.id;                                  // tie 用 id
}
```

### 11.2 ShadowLayer 位运算

`GetShadowLayer(short index)`：

```
movsx ebx,cx
test bx,bx
js  short loc_negative                  ; index < 0 → 0
lea ecx,[rbx+8]                         ; +SHADOW_LAYER_START_INDEX
mov eax,1
and ecx,1Fh                             ; mod 32
shl eax,cl                              ; eax = 1u << (index + 8)
ret
```

→ 即 `1u << (index + 8)`，slot 0..14 → bit 8..22，预留 0..7 给场景默认 layer、23..31 给其他用途。

`EnableCharacterShadow(h)`：

```csharp
short id = HGCharacters.QueryID(h);    // List.IndexOf(h)
return id >= 0 && id < 15;
```

—— 仅前 15 个 helper 享有阴影槽。

### 11.3 `HGCharacterHelper.FindRenderers`

在 `OnEnable` 时被无参调用,在 Inspector 也作 ContextMenu：

```csharp
public void FindRenderers(LODGroup lodGroup = null)
{
    if (lodGroup == null)
        m_LodGroup = gameObject.GetComponent<LODGroup>();
    var lods = m_LodGroup.GetLODs(true);                  // 含 LOD0
    renderers.Clear();
    shadowProxyRenderers?.Clear();

    var allRenderers = gameObject.GetComponentsInChildren<Renderer>(true);
    foreach (var r in allRenderers)
    {
        if (r is ParticleSystemRenderer) continue;        // 粒子不参与
        bool isInLod0 = ContainsRenderer(lods[0], r);

        // characterSelfShadowOffLodQuality 之后的 LOD 都跳过
        for (int lodIdx = 0; lodIdx < lods.Length; lodIdx++)
        {
            if (lodIdx >= HGCharacterQualitySettings.characterSelfShadowOffLodQuality)
            {
                if (ContainsRenderer(lods[lodIdx], r)) goto next;
            }
        }

        // ShadowCastingMode == ShadowsOnly(3) 或 Off(4) 走 shadowProxyRenderers
        var mode = r.shadowCastingMode;
        if (mode == ShadowCastingMode.ShadowsOnly || mode == ShadowCastingMode.Off)
            shadowProxyRenderers.Add(r);
        else
            renderers.Add(new Tuple<Renderer, bool>(r, isInLod0));
        next:;
    }
    UpdateShadowRenderingLayer(id, false);
}
```

即：**收集 LOD0 内的有效 renderer（排除粒子）做主渲染，ShadowsOnly/Off 类型分到 shadowProxyRenderers 单独管理**。每帧由 `OnBeginFrameRendering` 钩子注册的 RenderPipelineManager 回调驱动更新（反编译验证 `add_beginFrameRenderingNoAlloc`）。

### 11.4 `HGCharacterShadowSphere` — 包围球数据

```csharp
[Serializable]
public struct HGCharacterShadowSphere {
    public Transform rootTransform;
    public float radius;
    public Vector3 localOffset;
}
public List<HGCharacterShadowSphere> boneSpheres;
public List<HGCharacterShadowSphere> customBoneSpheres;
public bool enableSphereBasedBounds;
```

`enableSphereBasedBounds = true` 时，角色阴影包围盒由 `boneSpheres + customBoneSpheres` 的并集决定（每球贡献中心 + radius，最终聚合成 AABB），代替默认的 SkinnedMeshRenderer.bounds —— 这是为了让骨骼夸张动作不"出框"。

---

## 12. `SkinnedMeshCaptureManager` — Skin Matrices 三帧重投影通路

源：`SkinnedMeshCaptureManager.cs`。问题背景：阴影 cascade、SSR、SSAO 等都需要前一帧/中间帧的骨骼蒙皮矩阵做重投影；Unity 默认每帧 SkinnedMR 只产生当前帧矩阵，HG 维护一份**轻量原生内存池**保存历史。

### 12.1 数据结构

```csharp
private struct RequestData {
    public MeshRenderer       meshRenderer;        // 接收方
    public SkinnedMeshRenderer skinnedMeshRenderer;// 源
    public unsafe Vector4*    skinMatrices;        // 原生池指针,每骨 3 个 Vector4 = 48 字节
    public int                bufferSize;          // 字节数
    public MaterialPropertyBlock propertyBlock;    // 用于 SetConstantBuffer
}
private struct ReleaseData {
    public unsafe void* mem;
    public uint frame;                              // 释放帧 = 当前帧 + 10
}

private static readonly int BAKE_SKIN_MATRICES_CB;
private readonly Dictionary<int, RequestData> m_requests;  // key = MeshRenderer instanceId
private List<ReleaseData> m_PendingReleaseMem;
private uint m_frameCount;
```

### 12.2 `RequestCapture(MeshRenderer mr, SkinnedMeshRenderer smr, MaterialPropertyBlock pb)`

反编译关键序列：

```
; 估算 bufferSize:
mov r14d,[rax+18h]                ; bones.Length
lea esi,[r14+r14*2]               ; bones * 3
shl esi,4                         ; * 16  (= bones × 48,即 3 个 Vector4 per bone)
add esi,40h                       ; + 64 头部(meta + padding)

; 校验同一 instance 在前一帧的 request 已 finish
call UnityEngine.SkinnedMeshRenderer::SkinMatricesRequestFinished
test al,al
jne ...                           ; 未完成 → LogError "Request capture but skinned mesh renderer request is not finished"

; 如已有同 instanceId 的 RequestData,先 DelayFreeMem 旧内存:
if (dict.TryGetValue(instanceId, out RequestData oldReq) && oldReq.bufferSize != bufferSize)
    DelayFreeMem(oldReq.skinMatrices);

; 分配:
buffer = UnsafeUtility.Malloc(bufferSize, 16, Allocator.Persistent);
UnsafeUtility.MemClear(buffer + 16, bonesBytes);
SkinnedMeshRenderer.RequestCurrentFrameSkinMatrices(buffer + 16, bonesBytes, 0);
// 头部:
*(uint*)buffer = bones.Length * 3 + 0x30;    // 元数据头(可能是 cbuffer 总长字节)
((uint*)buffer)[1..3] = 0;                    // padding
```

`bufferSize = bones × 48 + 64`。骨头数据 48 字节 = `float3x4` (3 个 Vector4 行)的 transposed bone matrix，是 Unity GPU skinning cbuffer 标准格式。

### 12.3 `SetCaptureDataForPropertyBlock(ScriptableRenderContext ctx)` 上传到 cbuffer

```
for each (instanceId, req) in m_requests:
    if (req.propertyBlock != null && req.skinMatrices != null) {
        ctx.AllocateConstantBuffer(out CB cb, req.bufferSize);
        UnsafeUtility.MemCpy(cb.data, req.skinMatrices, req.bufferSize);
        req.propertyBlock.SetConstantBufferImpl0(BAKE_SKIN_MATRICES_CB, cb.handle, 0, req.bufferSize);
        if (req.meshRenderer != null)
            req.meshRenderer.Internal_SetPropertyBlock(req.propertyBlock);
    }
```

—— 每个 MeshRenderer 拿到一份**常量缓冲句柄**(非纹理也非 SBO),shader 里通过名为 `_BakeSkinMatricesCB` 的 cbuffer 直接 fetch。这是从 SkinnedMR → 普通 MeshRenderer 的"卸载蒙皮"通路：渲染目标改用 MeshRenderer 但顶点变换在 vertex shader 里用 cbuffer 矩阵手动做。

### 12.4 `PipelineUpdate` — 延迟释放（10 帧窗口）

```
frameCount++;
for (int i = m_PendingReleaseMem.Count - 1; i >= 0; i--) {
    if (frameCount >= m_PendingReleaseMem[i].frame) {
        UnsafeUtility.Free(m_PendingReleaseMem[i].mem, Allocator.Persistent);
        m_PendingReleaseMem.RemoveAt(i);
    }
}
```

**为什么 10 帧**？GPU 流水线深度 + TAA 历史 + SSR 间接采样等需要"上几帧的 cbuffer 仍然驻留 GPU 可见"，10 帧远大于任何模块需要。

### 12.5 `Release(MeshRenderer)`

```csharp
var iid = mr.GetInstanceID();
if (m_requests.TryGetValue(iid, out var req)) {
    DelayFreeMem(req.skinMatrices);                     // 延迟回收
    req.propertyBlock?.Internal_SetPropertyBlock(null); // 解绑
    m_requests.Remove(iid);
}
```

---

## 13. `HGBoneCapsuleUtilities` — 离线 PCA + Quantile 胶囊拟合

源：`HGBoneCapsuleUtilities.cs`。这是 **Editor only / 离线烘焙工具**：给非人形（机械、怪物、生物）骨骼自动拟合出胶囊体阴影占位（喂给 Capsule Shadow，见交叉引用 §13.3）。

### 13.1 输入：LODGroup → LOD0 SkinnedMR 的顶点 + 骨骼绑定

`AutomateGenerateCapsuleSkeletonsNonHuman(GameObject root)` 返回 `List<HGBoneCapsuleData>`。流程从反编译 `0x18A7B1F0C` 重建：

1. `LODGroup lod = root.GetComponent<LODGroup>()` → 取 `lod.GetLODs()[0]`,过滤所有 `SkinnedMeshRenderer`。
2. 每个 SkinnedMR：
   - `var bones = smr.bones; var bindposes = smr.sharedMesh.bindposes;`
   - 计算每个 bone 的 **world bind matrix** = `smr.transform.localToWorldMatrix * bindposes[i].inverse`。
3. 提取 **每个顶点的"主导骨头"**：
   ```csharp
   const float DOMINANT_THRESHOLD = 0.5f;      // 反编译 [g_18C471320]
   foreach (vertex v, weight4 w in mesh) {
       int dominantBone = -1; float maxW = 0;
       if (w.weight0 > maxW) { maxW = w.weight0; dominantBone = w.boneIndex0; }
       if (w.weight1 > maxW) { maxW = w.weight1; dominantBone = w.boneIndex1; }
       if (w.weight2 > maxW) { maxW = w.weight2; dominantBone = w.boneIndex2; }
       if (w.weight3 > maxW) { maxW = w.weight3; dominantBone = w.boneIndex3; }
       if (dominantBone < 0 || maxW < DOMINANT_THRESHOLD) continue;

       // 把顶点投到该骨头的 local 空间累积
       Vector3 localPos = MultiplyPoint3x4(boneWorldBindMatrix * smr.localToWorld, v);
       boneVertices[bones[dominantBone]].Add(localPos);
   }
   ```
4. 对每个有 ≥ 8 个主导顶点的骨头，做下述胶囊拟合。

### 13.2 PCA 主轴方向（轴向）

```csharp
// 反编译: 调 ComputePCAFirstAxis(boneVerts, center, out axis, ...)
//         或 FindBuddyBone 失败后回退用 boneTransform.position 朝相邻骨头方向
```

PCA 第一主成分给出最长轴 = 胶囊轴。反编译里另一个分支：

```
call FindBuddyBone(bone, allBones)             ; 寻找最近兄弟骨头
if (buddy != null) {
    Vector3 a = boneWorldBind * (0,0,0);
    Vector3 b = buddyWorldBind * (0,0,0);
    Vector3 axis = (b - a).normalized;          ; 用兄弟骨头位置做轴
} else {
    axis = ComputePCAFirstAxis(localVerts, center);
}
```

阈值 `comiss xmm2,dword ptr [g_18E5EC3D8]` 判断 buddy 距离平方 > 阈值时走 PCA 回退。

### 13.3 Quantile 半径 / 高度

对每个 vert 投到 (轴向, 正交) 二维：

```csharp
foreach (Vector3 lp in localVerts) {
    Vector3 d = lp - center;
    float along = dot(d, axis);             // 沿轴投影距离
    float radius = (d - along * axis).Length(); // 离轴半径
    alongList.Add(along);
    radiusList.Add(radius);
}
alongList.Sort(); radiusList.Sort();
```

调 `Quantile(sortedList, q)` 三次得到：

| 量化分位 | 反编译立即数 | 含义 |
|---------|------|------|
| `radius = Quantile(radiusList, 0.6)` | `[g_18C471450]` ≈ 0.6f | 60% 分位 radius |
| `alongLow = Quantile(alongList, 0.05)` | `[g_18C471768]` ≈ 0.05f | 5% 沿轴最小 |
| `alongHigh = Quantile(alongList, 0.95)` | `[g_18C471708]` ≈ 0.95f | 95% 沿轴最大 |

```csharp
float padding = GetPaddingByScale(boneTransform);   // bone 缩放比修正
radius += padding;
if (radius > 0.5f)             // [g_18C471300]
    radius = 0.5f;             // 上限 0.5 单位

float halfHeight = alongHigh - alongLow;
if (halfHeight < 0) halfHeight = 0;
if (radius * 2 > halfHeight)   // 球退化时
    halfHeight = clamp(halfHeight, 0, 0.5f);  // [g_18C471328]

// 把中心移到 (alongLow + alongHigh) / 2 处
float midAlong = (alongLow + alongHigh) * 0.5f;  // [g_18C471320] = 0.5
center += midAlong * axis;
```

### 13.4 输出 `HGBoneCapsuleData`

```csharp
[Serializable]
public struct HGBoneCapsuleData {
    public Transform rootTransform;     // 该胶囊跟随的骨头
    public float capsuleRadius;
    public float capsuleHeight;
    public Vector3 localOffset;
    public Vector3 localRotation;       // 由 Quaternion.FromToRotation(axis, Vector3.up) 转 euler
}
```

`capsuleHeight = halfHeight × 2`,`localOffset` = bone local 空间下 center,`localRotation` = `FromToRotation(axis_localToBone, Vector3.up)` —— 标准方式让胶囊默认 Y 轴对齐主轴。

输出 `List<HGBoneCapsuleData>` 给 Editor，由用户写到 `HGCapsuleShadowHelper.m_capsuleShadowContainers[]`（`HGCapsuleShadowContainer` 多 `intensityScale/enabled/isFoot` 三字段，承运行时表）。

---

## 14. `HGCharacterShadowBoundOverride` — 显式包围盒接管

源：`HGCharacterShadowBoundOverride.cs`。

```csharp
[SerializeField] private HGCharacterHelper targetCharacter;
[Range(0.01f, 1)] [SerializeField] private float radius;
[SerializeField] private Vector3 scale;
[SerializeField] private bool followTarget;
[SerializeField] private Transform followNode;
[SerializeField] private Vector3 followOffset;
private const float k_SnapHeightOffset = 1.5f;
```

每帧 `OnBeginFrameRendering` 回调中：

```csharp
Vector3 center = followTarget ? followNode.position + followOffset : transform.position;
center.y += k_SnapHeightOffset;                          // 抬高 1.5m
Bounds bound = new Bounds(center, scale * radius);
targetCharacter.SetShadowBoundOverride(bound, this);     // override
```

`HGCharacterHelper.SetShadowBoundOverride(Bounds, source)` 把 `isBoundOverride = true` 并存 `m_OverrideBound`，shadow culling 阶段读取它代替 SkinnedMR bounds —— 这是为了"角色拿了把巨剑→ bounds 远比身体大→必须手动指定"的场景。

---

## 15. 关键常量 / 魔数总表

| 常量 | 值 | 出处 | 说明 |
|------|----|----|------|
| `MAX_SUBSURFACE_MATERIAL_COUNT` | 63 | `SubsurfaceManager.cs:16` | 材质池容量 |
| `NONE_SUBSURFACE_MATERIAL_INDEX` | 0 | `SubsurfaceManager.cs:14` | 哨兵 |
| `_SubsurfaceParams[]` length | 252 (= 63 × 4) | `SubsurfaceManager.cs:11` | cbuffer 大小 (字节: 0x3F0 = 1008) |
| `MAX_PROFILE_COUNT` | 15 | `SubsurfaceProfileManager.cs:294` | profile 池容量 |
| `NONE_PROFILE_INDEX` | 0 | `SubsurfaceProfileManager.cs:292` | 哨兵 |
| `_SubsurfaceProfileParams0/1[]` length | 60 (= 15 × 4) | `SubsurfaceProfileManager.cs:227,230` | 双 cbuffer 数组 (字节: 0x1E0 = 480) |
| `scatterLut / penumbraLut` size | 64×64 ×15, RGBA32 mipmap | `SubsurfaceProfileManager.TryInitialize` | 预积分 LUT (HG 自研) |
| `indirectLut` size | 1×64 × 15, RGBA32 mipmap | 同上 | |
| `DIFFUSION_PROFILE_COUNT` (HDRP) | 16 | `DiffusionProfileSettings.cs:9` | 对比：HDRP 16 vs HG 15 |
| `SSS_PIXELS_PER_SAMPLE` (HDRP) | 4 | `DiffusionProfileSettings.cs:11` | 每像素采样面积 |
| `DefaultSssSampleBudget` | Low=20 / Med=40 / High=80 / Max=1000 | `DiffusionProfileSettings.cs:14-20` | 各档次采样上限 |
| `DefaultSssDownsampleSteps` | Low=0 / Med=0 / High=0 / Max=2 | `DiffusionProfileSettings.cs:22-28` | 仅 Max 档开降采样 |
| `GROUP_SIZE_1D` / `GROUP_SIZE_2D` | 16 / 256 | `SubsurfaceScattering.compute:32-33` | dispatch 线程组 |
| `TEXTURE_CACHE_SIZE_1D` / `2D` | 20 / 400 | `SubsurfaceScattering.compute:35-36` | LDS L0 cache |
| LDS 总用量 | 6400 字节 ≈ 6656 | `SubsurfaceScattering.compute:86` | 与硬件 512B 倍数对齐 |
| `DOMINANT_THRESHOLD` (PCA) | 0.5f | `BoneCapsuleUtilities` `[g_18C471320]` | 主导权重阈值 |
| `RADIUS_QUANTILE` | 0.6 | `[g_18C471450]` | 半径分位 |
| `ALONG_QUANTILE_LOW / HIGH` | 0.05 / 0.95 | `[g_18C471768]` / `[g_18C471708]` | 高度分位 |
| `MAX_CAPSULE_RADIUS` | 0.5f | `[g_18C471300]` | 半径上限 |
| `MAX_CHARACTER_SHADOWMAP_COUNT` | 15 | `HGCharacters.cs:14` | 角色阴影槽位 |
| `SHADOW_LAYER_START_INDEX` | 8 | `HGCharacters.cs:16` | 阴影 layer bit 起始 |
| SkinCapture `bufferSize` | bones × 48 + 64 字节 | `SkinnedMeshCaptureManager.RequestCapture` | per-instance cbuffer |
| SkinCapture `DELAY_FREE_FRAMES` | 10 | `SkinnedMeshCaptureManager.DelayFreeMem` (eax+0Ah) | 释放延迟帧数 |
| `BOUND_UPDATE_THRESHOLD` | 0.02f | `HGCharacterHelper.cs:43` | bounds 移动阈值 |
| `k_SnapHeightOffset` (override) | 1.5f | `HGCharacterShadowBoundOverride.cs:32` | y 轴抬升 |

---

## 16. 1:1 重建蓝图（分步）

### 16.1 复刻 Burley SSS 主管线

1. **Diffusion Profile 数据模型**
   - 实现 `class DiffusionProfile` 字段全集（`DiffusionProfile.cs:53-73`）；
   - `Validate()` → `UpdateKernel()`：照抄 §5 公式（含 16M 上限 + 99.7% CDF）；
   - `UpdateCache()`：照抄 §5.1 的 IOR→F0 与 transmissionTint 预乘 0.25；
   - 单独实现 `DisneyProfileCdfInverse` (Halley) 仅供 Inspector 曲线。

2. **HG cbuffer 布局**
   - `SubsurfaceConstants { float _SubsurfaceParams[252]; }`,字节大小 = 1008;
   - `SubsurfaceProfileConstants { float _SubsurfaceProfileParams0[60]; float _SubsurfaceProfileParams1[60]; }`,字节大小 = 480;
   - Profile cbuffer 中 `Params0[i*4..i*4+3] = (normalLerp.xyz, curvatureScale)`,`Params1[i*4+0] = penumbraScale`；其余 12 floats 槽待 HG profile 反射全字段后填入（**未确认完整字段表**：反编译只暴露 5 个字段，剩余字节可能给 transmission tint / shape param / lut slice 等使用）。

3. **运行时 Manager**
   - `class SubsurfaceManager`:
     - `Dictionary<int, int> instanceId2Index`,`SubsurfaceData[63] dataList`,`Dictionary<int,int>` 通过 hook `HGShadingStateSystem.shadingStateChanged` 注册;
     - `RegisterSubsurfaceMaterial`/`Unregister`/`OnShadingStateChanged` 走 RefCount 池;
     - `BindSubsurfaceData(ctx)`: 循环 63 槽 → `Color.RGBToHSV` → cbuffer → `AllocateConstantBuffer(0x3F0)` → `SetGlobalConstantBufferInternal0(HGShaderIDs._SubsurfaceParams, ...)`。
   - `class SubsurfaceProfileManager` 同样 RefCount 池 + 3 张 `Texture2DArray`（W=64,H=64,depth=15,RGBA32,mipmap）;`UpdateProfileDataImpl(idx)` 走 `Graphics.CopyTexture(profile.scatterLut, 0, 0, scatterLutArray, idx, 0)`。

4. **GBuffer / SSSBuffer 编码**
   - 复用 HDRP `EncodeIntoSSSBuffer / DecodeFromSSSBuffer`（`SubsurfaceScattering.hlsl:80-97`）：`float3 diffuseColor` + `PackFloatInt8bit(subsurfaceMask, diffusionProfileIndex, 16)`;
   - SSSBuffer = sRGB float4，与 GBufferA 共用一张 RT；
   - HG 增加 `Material.SetFloat(_SubsurfaceMaterialIndex)` 把材质池 slot+1 写到 vertex layout 或 instance cbuffer，shader 解码时同步取出。

5. **TestLightingForSSS tag**
   - 在 deferred lighting Subsurface 分支末尾：
     ```hlsl
     outIrradiance = TagLightingForSSS(outIrradiance);  // .b = max(.b, HALF_MIN)
     ```

6. **(可选) RandomDownsample pass**
   - 仅当 quality=Max → downsampleSteps=2 时启用 `Downsample` kernel,8×8 thread group;

7. **PackDiffusionProfile pass**
   - 8×8 thread group;输出 R8 texture 宽度 = 屏幕宽/2,高度 = 屏幕高;

8. **SSS compute pass**
   - Dispatch dims = `(ceil(W/16), ceil(H/16), viewCount)`;
   - 1D `[numthreads(256,1,1)]` + `DecodeMorton2D`;
   - HTile coarse stencil reject,LDS 缓存 20×20,Disk Golden 重要性采样;
   - 输出累加到 intermediate buffer (除非 PSSL/Xbox);

9. **CombineLighting 全屏 pass**
   - Stencil = `STENCILUSAGE_SUBSURFACE_SCATTERING`,Comp Equal;
   - Pass 0/1 决定是否乘曝光;

### 16.2 复刻 NPR 角色 shader 链

1. 编译 `HGRP_CharacterNPR_Skin_Fix.shader` 作为基线 (本机已有可读源)。
2. 在 ForwardLit pass 中实现 `computeNPRLighting`，按 §9.1–§9.9 顺序：法线→view→shadow LUT→Diffuse Ramp→ skin specular→rim→albedo→exposure→VFX color。
3. 编译同基础的 Eye / Hair / Fur shader（不在 SSS 文件清单内，归 §17 参考）。

### 16.3 复刻角色管理 + 投阴影

1. `class HGCharacterVolume : VolumeComponent` — 32 个 VolumeParameter（§10）。
2. `class HGCharacterHelper : MonoBehaviour` — `priority/id/bounds/boneSpheres`，`OnEnable` → `FindRenderers()` + `HGCharacters.EnqueueCharacter(this)` + 注册 `RenderPipelineManager.beginFrameRenderingNoAlloc`。
3. `static class HGCharacters` — `List<HGCharacterHelper> m_CharacterHelpers`，`Sort` 后给前 15 个分配 `ShadowRenderingLayer = 1u << (slot + 8)`。
4. `class HGCharacterShadowBoundOverride : MonoBehaviour` — `OnBeginFrameRendering` 时算 bound 写入 `targetCharacter.SetShadowBoundOverride`。
5. `class SkinnedMeshCaptureManager` — `Dictionary<int, RequestData>` + 原生内存池 + 10 帧延迟释放;`SetCaptureDataForPropertyBlock` 在 `ScriptableRenderContext.SetupCameraProperties` 之前调用。
6. Editor 工具 `HGBoneCapsuleUtilities` — PCA + Quantile（§13）。

### 16.4 接口 / 依赖

| 依赖 | 谁提供 |
|------|--------|
| SSSBuffer 公共 RT | 与 GBufferA 共享 (`02-GeometryPasses.md §2`) |
| `_CoarseStencilBuffer` | LightLoop / DepthPrepass 写入,SSS 读取 |
| `_DepthTexture` / `_IrradianceSource` | DeferredShading 阶段输出 |
| `HGShaderIDs[+0CC0/+0D2C/+0D30/+0D40/+0D44/+0D48/+0D08/+0D0C/+0D10/+0D14...]` | 全局 shader prop id 表 |
| `HGShadingStateSystem` | 材质状态广播 (RuntimeInitializeOnLoadMethod) |
| `HGRenderGraphContext` | RenderGraph 管线上下文 |
| `HGSubsurfaceProfile` (ScriptableObject) | `scatterLut/penumbraLut/indirectLut/subsurfaceNormalLerp/curvatureScale/penumbraScale` 字段;**完整字段表见 `Editor/UnityEngine.HGSubsurfaceProfile`,本单元未完全反射** |
| `SkinnedMeshRenderer.RequestCurrentFrameSkinMatrices` + `SkinMatricesRequestFinished` | Unity 引擎层 native API |
| `RenderPipelineManager.beginFrameRenderingNoAlloc` | URP/HDRP 共享 |

### 16.5 难点 / 待澄清

- **`HGSubsurfaceProfile` 完整字段表**：反编译只暴露 `subsurfaceNormalLerp` (Vector3)、`curvatureScale`、`penumbraScale`、3 张 LUT；其余 12 floats 槽（`Params0[i*4+3]` 后 + `Params1[i*4+1..3]`）的具体含义未在反编译中出现，需从未反编译的 `UnityEngine.HGSubsurfaceProfile` 程序集补全（HG 可能放在 `UnityEngine.HyperGryph.*` 中）。
- **shader 端 SSS 采样路径与 HDRP 完全异构**：HG 用 LUT 查表替代 `EvalBurleyDiffusionProfile` 内联；具体采样 UV 算法不在 C# 反编译里，需读 HG 的 SSS 计算 shader（本机未提供）。
- **`_SubsurfaceParams[252]` 中各槽位的 4 floats 完整语义**：反编译只确认 `(H, S, V, indirect)`,但 `[rdi+0Ch]` 偏移在某些代码路径写 0 而某些写非零（地形 SSS？），可能存在额外位标记。

---

## 17. 源文件清单（17 个）

| 文件 | 一行职责 |
|------|--------|
| `BurleyNormalizedDuffusion.cs` | Pixar Burley 三对 albedo→reflectance 拟合 + DMFP↔MFP 互换 + 解析剖面（Editor 工具,与 HDRP Editor 同算法）|
| `SubsurfaceManager.cs` | 材质级 SSS 池（63 槽,RefCount）+ RGB→HSV 预转换 + 1008B cbuffer 上传 + ShadingState 回调注册 |
| `SubsurfaceData.cs` | 单材质条目 = `{RefCount, SubsurfaceColor, SubsurfaceIndirect}` + 浮点近似 Equals |
| `SubsurfaceProfileManager.cs` | Profile 级池（15 槽）+ 3 张 LUT Texture2DArray (64×64×15) + Terrain SSS 入口 (`ProfileKey.terrain`) + 480B cbuffer 上传 |
| `MaterialSubsurfaceExtensions.cs` | `Material.GetSubsurfaceProfile()` / `GetSubsurfaceData(out)` 扩展;门禁 = `HasProperty + GetFloat > 0` |
| `HGBoneCapsuleData.cs` | 静态骨胶囊数据：`rootTransform/capsuleRadius/capsuleHeight/localOffset/localRotation` |
| `HGBoneCapsuleUtilities.cs` | 离线烘焙：LODGroup→LOD0→SkinnedMR→顶点权重 PCA + Quantile → 自动生成胶囊（喂 Capsule Shadow） |
| `HGCharacterQualitySettings.cs` | 3 个静态 tier 字段：`selfShadowOffLodQuality / shadowTierLevel / outlineTierLevel` |
| `HGCharacterVolume.cs` | 32+ 个 VolumeParameter,演出/Dialog 用角色光照配置（CP* 数据源） |
| `HGCharacters.cs` | 静态注册器：`EnqueueCharacter` / `SortCharacterHelpers` / `QueryID` / `GetShadowLayer = 1u<<(idx+8)` / `EnableCharacterShadow = idx<15` |
| `HGCharacterHelper.cs` | 单角色组件：renderers 收集 + bounds + boneSpheres + priority + `FindRenderers` + ShadowRenderingLayer 更新 |
| `HGCharacterShadowBoundOverride.cs` | 单实例显式包围盒：每帧把 `(followNode + offset, scale·radius)` 写入 `targetCharacter.SetShadowBoundOverride` |
| `SkinnedMeshCaptureManager.cs` | Skin matrices CPU→GPU 通路：原生池 + 10 帧延迟释放 + `RequestCurrentFrameSkinMatrices` 集成 + per-MeshRenderer cbuffer |
| `VFXPPCharacterBloom.cs` | VFXPP 角色泛光 — 推送 `HGCharacterVolume` 中 bloom 相关参数 (Apply→VolumeProfile.Override) |
| `VFXPPCharacterDirectionalLight.cs` | VFXPP 主方向光 — 推送主光方向/颜色覆盖 (Custom mode) |
| `VFXPPCharacterLight.cs` | VFXPP 基类 — 通用 `Apply(VolumeProfile)` 把 VFXPP 字段映射到 HGCharacterVolume |
| `VFXPPCharacterRimLight.cs` | VFXPP 边缘光 — 推送 AutoRim 与 FaceRim 七字段（颜色/角度/强度/宽度/albedo/mode） |

---

> 本文档严守 [纲领 §1.5](../README.md) 的 1:1 零偏差铁律：
> - SSS 算法部分逐字照抄 HDRP `SubsurfaceScattering.compute` / `SubsurfaceScattering.hlsl` / `DiffusionProfile.hlsl` / `DiffusionProfileSettings.cs`，所有公式带行号引用；
> - HG delta 部分（材质池/profile 池/HSV cbuffer/LUT 预积分/`HGCharacters`+`HGCharacterHelper`+`SkinnedMeshCapture`/PCA 胶囊）以反编译 VA 与立即数为证；
> - 角色 NPR Shader 部分基于可读源 `HGRP_CharacterNPR_Skin_Fix.shader` 1:1 复刻；
> - 仅在 §16.5 标记**确实**未确认的 HG 私有字段（`HGSubsurfaceProfile` 完整字段表）。
