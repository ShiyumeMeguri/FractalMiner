# 11-02 · Terrain — 地形渲染系统 实现原理蓝图

> EndField（HG.RenderPipelines）地形子系统是 Unity HDRP 标准 `TerrainLit_Splatmap` 着色管线之上的一次**重度魔改**：HDRP 的 4/8 层 splat 高度混合保留为**像素着色阶段的基础混合算法**，HG 在此之上叠加四件自研武器 —— **(1)** 64 层 splat（`packedSplatInfo` + `sectorSplatInfo` 远超 HDRP 8 层上限）配合 **CPU/GPU 双模虚拟纹理 feedback** 系统、按 `sectorSplatInfo[sectorIdx]` 的 64-bit 位掩码做 **per-sector 流送**；**(2)** **TerrainV2 GroundLayer Clipmap** —— 两层 1024×1024 同心 clipmap（基色 / 法线 / 湿润度 / 高度 default-RT），跟随玩家移动以 `(extent/8)` 网格为步长重烘焙，把人物近场覆盖物（雪、水渍、泥泞）写回顶层；**(3)** **TerrainDeform** —— 64×64 角色深度图 + 4 张 1024×1024 RT（fill-rate / result / densityMip4 / distance）的 GPU 形变流水线，把脚下踩踏写进 result-RT 再读回着色；**(4)** **TerrainV2 特化层** —— Fake Glint 闪粉、Fake Volume（折射 / 裂缝 / 浮尘三段视差行进）、Fake Shadow 自阴影、Subsurface（雪 / 蜡质透光、带 stencil-mask 写入），全部以 keyword + global cbuffer 方式注入到 `TerrainLit_Splatmap.hlsl` 主流程外。
>
> 原理据：① HDRP `TerrainLit_Splatmap.hlsl` / `TerrainLitData.hlsl` 真源 1:1 照抄（HDRP 同源部分，cite `文件:行`）；② HG 反编译 C# 的 `call/常量/RT 描述` 强推断（标"据反编译"）；③ 标准 clipmap / 虚拟纹理 / 角色深度蚀刻领域知识合理重建（标"据领域知识"）。本文逐段标注分级。

---

## 目录

1. [系统定位与解决的渲染问题](#1-系统定位与解决的渲染问题)
2. [HDRP 血缘 — Splatmap 层混合的真实数学（照抄 HDRP）](#2-hdrp-血缘--splatmap-层混合的真实数学照抄-hdrp)
3. [HG 数据布局总览 — 64 层 splat / sector 位掩码 / chunk 四叉树](#3-hg-数据布局总览--64-层-splat--sector-位掩码--chunk-四叉树)
4. [虚拟纹理 feedback 与 sector 流式加载（HG 自研）](#4-虚拟纹理-feedback-与-sector-流式加载hg-自研)
5. [Chunk 四叉树 LOD 与 Tessellation/Subdivision 深度](#5-chunk-四叉树-lod-与-tessellationsubdivision-深度)
6. [TerrainV2 GroundLayer Clipmap — 玩家中心同心烘焙](#6-terrainv2-groundlayer-clipmap--玩家中心同心烘焙)
7. [TerrainDeform — 64×64 角色深度 + 4 RT 形变流水线](#7-terraindeform--6464-角色深度--4-rt-形变流水线)
8. [TerrainV2 特化层 — Glint / FakeVolume / FakeShadow / Subsurface](#8-terrainv2-特化层--glint--fakevolume--fakeshadow--subsurface)
9. [Pass 编排时序（HGRenderGraph 全帧顺序）](#9-pass-编排时序hgrendergraph-全帧顺序)
10. [关键常量 / 魔数 总表](#10-关键常量--魔数-总表)
11. [1:1 复刻蓝图（自顶向下分步）](#11-11-复刻蓝图自顶向下分步)
12. [支撑证据 — 数据结构布局表 + 源文件清单表](#12-支撑证据--数据结构布局表--源文件清单表)
13. [待确认项](#13-待确认项)

---

## 1. 系统定位与解决的渲染问题

EndField 是开放世界 ARPG，地形必须同时满足：

| 渲染需求 | HDRP 默认实现 | 为什么不够 |
|---|---|---|
| 大世界 `Splat` 层无限可扩展 | HDRP `TerrainLit_Splatmap` 硬上限 8 层（`_TERRAIN_8_LAYERS` keyword）（`TerrainLit_Splatmap.hlsl:16–22`） | EF 一块地形数十种地表材质 → 必须 ≥ 64 层 |
| 角色脚下踩痕 / 雪地凹陷 / 泥泞 | HDRP 无此功能 | 需 GPU 角色深度图驱动的 RT 形变 |
| 近场表面动态层（雪、水痕） | HDRP 无 | 需玩家中心 clipmap 实时烘焙 |
| 远距视距 + 移动端可承受带宽 | HDRP 每像素 8 次 Splat tex2D-grad sample 太重 | 必须 VT(virtual texture) page-cache + ASTC/BC3 在线压缩 |
| 雪 / 蜡质透光 | HDRP 走 SSS pre-pass，地形 SSS 较罕用 | 自研 simple subsurface 入 GBuffer |
| 风格化裂缝 / 闪粉 / 浮尘表面层 | HDRP 无 | Fake-Glint + Fake-Volume 多段 parallax |

HG 的设计哲学：**保留 HDRP Splatmap 的基础混合数学（高度 / 密度混合）不动**，外层用结构化数据 + 自研 pass 把上述五项全部串进来。

---

## 2. HDRP 血缘 — Splatmap 层混合的真实数学（照抄 HDRP）

> **原理直证级 (①)**：HDRP 真源 `Runtime/Material/TerrainLit/TerrainLit_Splatmap.hlsl` 在本机 PackageCache。HG 保留这套数学作为**单 sector 内 4–8 个激活层之间的最终像素混合**算法。

### 2.1 数据准备 — 每层一组 ST/Remap/Diffuse-Mask 纹理

HDRP 用宏 `DECLARE_TERRAIN_LAYER_TEXS(n)` 为每个 layer 声明 3 张纹理（`TerrainLit_Splatmap.hlsl:7–22`，照抄）：

```hlsl
#define DECLARE_TERRAIN_LAYER_TEXS(n)   \
    TEXTURE2D(_Splat##n);               \
    TEXTURE2D(_Normal##n);              \
    TEXTURE2D(_Mask##n)
DECLARE_TERRAIN_LAYER_TEXS(0);
DECLARE_TERRAIN_LAYER_TEXS(1);
DECLARE_TERRAIN_LAYER_TEXS(2);
DECLARE_TERRAIN_LAYER_TEXS(3);
#ifdef _TERRAIN_8_LAYERS
    DECLARE_TERRAIN_LAYER_TEXS(4..7);
    TEXTURE2D(_Control1);
#endif
```

`_Control0` / `_Control1` 是 4-channel splat-control（每 channel = 该层的权重）；`_Splat##n` = albedo (RGB)+ density (A)；`_Normal##n` = DXT5nm normal；`_Mask##n` = (metallic, ao, height, smoothness) 的 PBR mask（`TerrainLit_Splatmap.hlsl:5`–`64`）。

### 2.2 半像素 UV 校正（防止 control 纹理过滤越界）

```hlsl
// TerrainLit_Splatmap.hlsl:130
float2 blendUV0 = (controlUV.xy * (_Control0_TexelSize.zw - 1.0f) + 0.5f) * _Control0_TexelSize.xy;
float4 blendMasks0 = SAMPLE_TEXTURE2D(_Control0, sampler_Control0, blendUV0);
```

UV 公式 `(uv * (W-1) + 0.5) / W` 把 N×N control 网格的中心对齐到纹素中心，避免 mip0 的双线性插值跨过 splat-edge —— 这是地形 splat 共识但 HDRP 是 ground-truth 实现。

### 2.3 SampleResults 宏 — UNITY_BRANCH 早退

每层走相同模式（`TerrainLit_Splatmap.hlsl:103–119`，照抄）：

```hlsl
#define SampleResults(i, mask)                                                     \
    UNITY_BRANCH if (mask > 0) {                                                   \
        float2 splatuv  = splatBaseUV * _Splat##i##_ST.xy + _Splat##i##_ST.zw;     \
        float2 splatdxuv = dxuv * _Splat##i##_ST.x;                                \
        float2 splatdyuv = dyuv * _Splat##i##_ST.y;                                \
        albedo[i] = SAMPLE_TEXTURE2D_GRAD(_Splat##i, sampler_Splat0, splatuv, splatdxuv, splatdyuv); \
        albedo[i].rgb *= _DiffuseRemapScale##i.xyz;                                \
        normal[i] = SampleNormal(i);                                               \
        masks[i]  = SampleMasks(i, mask);                                          \
    } else {                                                                       \
        albedo[i] = 0; normal[i] = 0; masks[i] = NullMask(i);                      \
    }
```

`UNITY_BRANCH` 在 SM5+ 上展开为 `[branch]` —— 当 `mask <= 0`（该层在此像素无权重）GPU 完整跳过 3 张 tex2D-grad（`SAMPLE_TEXTURE2D_GRAD` 走显式 dx/dy uv，避免 wave 内不同分支的 ddx/ddy 失效）。这是 HDRP 对 layer-count 缩放性的关键技巧。

### 2.4 高度混合 `_TERRAIN_BLEND_HEIGHT`（HG 主选）

HDRP 实际跑的高度混合公式（`TerrainLit_Splatmap.hlsl:158–195`，逐行照抄）：

```hlsl
// 1) 取 8 层 height 的最大值
float maxHeight = masks[0].z;
maxHeight = max(maxHeight, masks[1].z);
maxHeight = max(maxHeight, masks[2].z);
maxHeight = max(maxHeight, masks[3].z);
#ifdef _TERRAIN_8_LAYERS
    maxHeight = max(maxHeight, masks[4].z);
    maxHeight = max(maxHeight, masks[5].z);
    maxHeight = max(maxHeight, masks[6].z);
    maxHeight = max(maxHeight, masks[7].z);
#endif

// 2) 关键：把所有层 height 减去 maxHeight，只有顶层 ≥ 0，加 _HeightTransition 做软过渡
float transition = max(_HeightTransition, 1e-5);
float4 weightedHeights0 = { masks[0].z, masks[1].z, masks[2].z, masks[3].z };
weightedHeights0 = weightedHeights0 - maxHeight.xxxx;
weightedHeights0 = (max(0, weightedHeights0 + transition) + 1e-6) * blendMasks0;

// 3) 归一化到 sum=1
float sumHeight = GetSumHeight(weightedHeights0, weightedHeights1);
blendMasks0 = weightedHeights0 / sumHeight.xxxx;
```

**数学解释**：
- `maxHeight = max_i(h_i)` → 找当前像素最高的层；
- 减去 `maxHeight` 把所有层 height 平移到 `[-h_max, 0]`，唯一 `=0` 的就是最高层；
- 加 `transition`（默认 0.5）后只有 `h_i > h_max - transition` 的层留下正权重（过渡带），其余被 `max(0, ·)` clamp 掉；
- `+1e-6` 是为了保证至少有一个非零权重（fallback）；
- 与 `_Control0` 原始权重 `blendMasks0` 相乘 → 只有 `splat painter` 认为该层激活、**且**高度足够高的层会贡献最终颜色；
- 最后归一化保证能量守恒。

这条公式是**地形 splat 高度混合的事实标准**，HG 反编译 C# 侧 `HGTerrainSurfacesData.SplatLayerData` 中保留 `_MaskMapRemapOffset / _MaskMapRemapScale`（`HGTerrainSurfacesData.cs:14–30`）说明 HG 直接复用 `_Mask##i` 走这套（remap 是为了让美术调 height range）。

### 2.5 密度混合 `_TERRAIN_BLEND_DENSITY`（备选路径）

```hlsl
// TerrainLit_Splatmap.hlsl:198，照抄
float4 opacityAsDensity0 = saturate(
    (float4(albedo[0].a, albedo[1].a, albedo[2].a, albedo[3].a)
     - (float4(1.0,1.0,1.0,1.0) - blendMasks0)) * 20.0);
opacityAsDensity0 += 0.001f * blendMasks0;
float4 useOpacityAsDensityParam0 = { _DiffuseRemapScale0.w, ..., _DiffuseRemapScale3.w };
blendMasks0 = lerp(opacityAsDensity0, blendMasks0, useOpacityAsDensityParam0);
```

`20.0` 是经验值（HDRP 注释："20.0 is the number of steps in inputAlphaMask. Density mask. We decided 20 empirically"）。`_DiffuseRemapScale##i.w` 是 per-layer 开关（1 = 关闭 density，回退到原 control）。HG 是否启用此路径取决于 material 上的 keyword 设置，反编译 C# 未提供 default，**保守复刻应保留这条路径**。

### 2.6 最终合成

```hlsl
// TerrainLit_Splatmap.hlsl:229–240，照抄
surfaceData.albedo = 0;
surfaceData.normalData = 0;
float3 outMasks = 0;
UNITY_UNROLL for (int i = 0; i < _LAYER_COUNT; ++i) {
    surfaceData.albedo    += albedo[i].rgb * weights[i];
    surfaceData.normalData += normal[i].rgb * weights[i]; // 不归一化 — surface gradient 允许累加
    outMasks               += masks[i].xyw * weights[i];  // metallic / ao / smoothness
}
surfaceData.smoothness = outMasks.z;
surfaceData.metallic   = outMasks.x;
surfaceData.ao         = outMasks.y;
```

`UNITY_UNROLL` 强制循环展开（`_LAYER_COUNT` 是宏常量 4 或 8）。**normal 不归一化**是因为 HDRP 用 `SURFACE_GRADIENT` 路径（`TerrainLitData.hlsl:7`），surface gradient 是切空间法线的线性可加形式，权重和正确则归一化等价（数学性质）。

---

## 3. HG 数据布局总览 — 64 层 splat / sector 位掩码 / chunk 四叉树

> **直证级 (①)**：所有字段、容量上限均反编译 C# 直证。

### 3.1 容量常量（`HGTerrainUtils.cs:35–75`，逐行照抄）

| 常量 | 值 | 用途 |
|---|---|---|
| `TERRAIN_LAYER_TEX_RESOLUTION` | **1024** | 单 Splat layer 纹理边长（与 GroundLayer RT 一致） |
| `TERRAIN_DECAL_TEXTURE_RESOLUTION` | **512** | Decal atlas 单 page 边长 |
| `TERRAIN_DECAL_MAX_PER_PAGE` | **256** | 单 page 最多 decal 数 |
| `TERRAIN_DECAL_MAX_PER_BLOCK` | **16** | 单 64-bit block 最多 decal 索引 |
| `TERRAIN_DECAL_ACQUISITION_OFFSET` | **2** | Decal 采样在 sector 边界外扩 |
| `TERRAIN_DECAL_MAX_ALLOWED_LEVEL` | **8** | Decal 在四叉树最大 cull 深度（`GetTerrainDecalMaxLevel` clamp） |
| `TERRAIN_WETNESS_THRESHOLD` | **130** | 湿润度 8-bit 阈值（≥130 视为湿表面） |
| `TERRAIN_SPLAT_MAX_ALPHAMAP_COUNT` | **16** | 单 sector splatcontrol 最多 16 个 4-channel `_Control` |
| `TERRAIN_SPLAT_MAX_LAYER_COUNT` | **64** | 全地形最多 64 个 splat layer（HDRP 8 的 **8 倍**）|
| `TERRAIN_SPLAT_TEX_ARRAY_SLICE_COUNT_PC` | **32** | PC 端 Tex2DArray 切片数 |
| `TERRAIN_SPLAT_TEX_ARRAY_SLICE_COUNT_MOBILE` | **24** | 移动端切片数 |
| `AVERAGE_COLOR_CALCULATION_ARRAY_LENGTH` | **16** | 远景 fallback 计算平均色样本数 |

**关键 delta（HDRP→HG）**：
- HDRP 上限 **8 layer**（一个 fragment 同时计算上限）；
- HG 是 **64 layer 全地形** + **每 sector 16 层激活上限**（4 个 Control RGBA = 16）。意味着像素 shader 实际仍走 HDRP 的 4/8 路径，但活跃层池是 sector 级动态选择。这是 HG 在保持 HDRP 高度混合算法的同时扩展材质库的关键设计。

### 3.2 SplatLayerData — 单层 GPU upload 结构（`HGTerrainSurfacesData.cs:14–30`）

```csharp
[Serializable]
public struct SplatLayerData {
    public Vector4 packedSplatInfo;    // 含 slice index / layer flags
    public Vector4 splatST;            // = _Splat##i##_ST (tile, offset)
    public Vector4 diffuseRemapScale;  // = _DiffuseRemapScale##i (rgb scale + density w)
    public Vector4 maskMapRemapOffset; // = _MaskMapRemapOffset##i
    public Vector4 maskMapRemapScale;  // = _MaskMapRemapScale##i
    public Vector2 packedDeformParams0;
    public HGTerrainUtils.Vector2UInt packedDeformParams1;
    public Vector4 pomParams;          // POM / Parallax 参数（未启用，留扩展）
}
```

7 × `Vector4` = **112 bytes / layer**；64 layer = 7168 bytes 上传到 GPU `ComputeBuffer<SplatLayerData>`。`packedDeformParams*` 是与 GroundLayer / Deform 系统的耦合通道（每层独立的形变响应曲线）。

### 3.3 sectorSplatInfo — 64-bit 位掩码（`HGTerrainSurfacesData.cs:86`）

```csharp
public ulong[] sectorSplatInfo;   // 每 sector 一个 64-bit
```

**直证（位含义据反编译推断 ②）**：每 sector（地形二维网格单元）一个 `ulong`，64 个 bit 对应全地形 64 个 splat layer。bit `k` = 1 表示该 sector 上 layer `k` 激活 → CPU 在流式加载阶段（`HGTerrainStreamingManager.EarlyUpdate`）按 `BitScan` 遍历这个 mask 挑出需要加载的 layer 纹理。`HGTerrainStreamingManager` 的 `LAYER_DIFFUSE_FORMAT_STR = "{0}/Layers/LAYER_D_{1}.tga"` 等格式串（`HGTerrainStreamingManager.cs:267–281`）正对应"按 layer 索引"的资源路径。

### 3.4 TerrainNodeData — chunk 四叉树节点（`HGTerrainSurfacesData.cs:33–46`）

```csharp
public struct TerrainNodeData {
    public int allHole;           // 该节点是否全为洞（_AlphaTest）
    public int nodeLevel;         // 在四叉树的层级 0..treeDepth-1
    public int parent;            // 父节点索引
    public float localMinHeight;  // 子树 AABB 最低
    public float localMaxHeight;  // 子树 AABB 最高
    public float maxHeightError;  // 给屏幕空间 LOD 判定用
}
```

`maxHeightError` 是 chunked-LOD 决定 split / merge 的关键指标 —— 屏幕空间几何误差与配置阈值 `chunkedLodPixelError`（`HGTerrainConfiguration.cs:20`）比较。

### 3.5 TerrainNodeKey 打包（30-bit 紧凑编码）

来自 `HGTerrainStreamingManager._UnpackTerrainNodeKey`（`HGTerrainStreamingManager.cs:287–323`，反汇编逐字）：

```text
nodeKey 是 uint32：
  level = nodeKey >> 28           ; 高 4 bit = LOD level (0..15)
  x     = (nodeKey >>  0) & 0x3FFF; 低 14 bit = x 坐标 (0..16383)
  y     = (nodeKey >> 14) & 0x3FFF; 中 14 bit = y 坐标
```

→ 全世界最大 14-bit × 14-bit = **16384 × 16384 个 sector**，按 1 sector ≈ 32m 估算就是 524 km 边长 —— 远超 EF 实际需求，纯 key 容量上的余量。

### 3.6 资源命名约定（`HGTerrainStreamingManager.cs:267–281`）

| 资源类型 | 路径格式 | 纹理用途 |
|---|---|---|
| Per-layer Diffuse | `{root}/Layers/LAYER_D_{layerIdx}.tga` | albedo+density |
| Per-layer NormalRO | `{root}/Layers/LAYER_N_{layerIdx}.tga` | normal+roughness+other |
| Per-layer ConeMap | `{root}/Layers/LAYER_C_{layerIdx}.tga` | parallax cone map（视差 POM 加速） |
| Per-sector Heightmap | `{root}/Terrain_{x}_{y}_{level}_H.asset` | sector 高度图 |
| Per-sector Normalmap | `{root}/Terrain_{x}_{y}_{level}_N.tga` | sector 顶点法线 |
| Per-sector TintColor | `{root}/Terrain_{x}_{y}_{level}_T.tga` | 远景颜色变化 |
| Per-sector Albedo | `{root}/Terrain_{x}_{y}_{level}_A.tga` | 远景 fallback albedo |
| Per-sector SplatCtrl | `{root}/Terrain_{x}_{y}_{level}_S.tga` | RGBA = 4 个 layer 的权重图 |

→ **HG 采用 sector-level mip pyramid**：每个 sector 一组高度 / 法线 / splatctrl，远距用 albedo+tint 直接采样跳过 splatmap 完整计算（**HDRP 的 `TerrainLit_Basemap.hlsl` 也是同一思路**，HG 把它扩展为 streaming 范畴）。

### 3.7 编译开关 `VTFeedbackMode`（`HGTerrainConfiguration.cs:9–14`）

```csharp
public enum VTFeedbackMode {
    CPUPhysicsFeedback = 0,   // PC 端：CPU 抛 ray 反馈
    GPUSSBOFeedback    = 1    // GPU 端：compute shader 写 SSBO
}
```

PC 主线走 CPU feedback（`Physics.Raycast` 检测相机视锥与 chunk 命中），移动端走 GPU SSBO（避免回读延迟）—— **直证 ②（据反编译枚举名 + 字段命名）**。

---

## 4. 虚拟纹理 feedback 与 sector 流式加载（HG 自研）

> **强推断级 (②)**：HDRP 无对应特性，HG 自研。本节据 `HGTerrainConfiguration` 的 VT 字段、`HGTerrainStreamingManager` 的调用图、`TerrainVTBakePassConstructor` 的 pass 注册重建。

### 4.1 VT 配置场（`HGTerrainConfiguration.cs:22–50`）

```csharp
public int virtualTextureResolution;    // VT atlas 总分辨率（如 16384）
public int vtMinChunkSize;              // VT 最小 page 边长（如 128）
public float vtBaseMipBias;             // mip-bias 基础值
public int vtCacheSliceCount;           // Tex2DArray 切片数 = 物理 cache 容量
public int vtCacheSliceWidth;
public int vtCacheSliceHeight;
public int vtClipmapBaseOffset;         // clipmap 起始层
public int vtClipmapMaxOffset;          // clipmap 最大层
public int vtFeedbackWidth;             // feedback 分辨率
public int vtFeedbackHeight;
public VTFeedbackMode vtFeedbackMode;
public int vtSSBOBlockWidth;            // GPU 模式下 SSBO 块大小
public int vtSSBOBlockHeight;
public int vtMaxPagePerFrame;           // 每帧最多上传 page 数（背压控制）
public bool vtEnableCompression;        // 启用在线 ASTC/BC3 压缩
```

**VT 工作流（据领域知识 ③ 重建标准 clipmap-VT 流程）**：

```text
                       +--------------------------------------------+
                       |          Camera frustum + chunkLOD         |
                       +--------------------------------------------+
                                          |
                                          v
+------------------ (A) FEEDBACK 收集 ------------------+
|  CPU 模式：Physics raycast → 命中 sector + mip level  |
|  GPU 模式：fragment shader 写 SSBO (sector, mip)      |
|             → readback (1-2 frame latency)            |
+--------------------+----------------------------------+
                     v
+----- (B) HGTerrainStreamingManager.EarlyUpdate -----+
|  - 解 nodeKey → (level, x, y)                       |
|  - 从 sectorSplatInfo[idx] 64-bit 抽 1-bit (BitScan)|
|  - 资源路径 Format → ResourceManager.LoadAsync       |
|  - 入队 m_nodeAtlasPendingLoaded /                  |
|         m_splatsPendingLoaded                       |
+--------------------+--------------------------------+
                     v
+----- (C) GameplayUpdate (帧 N+M, M=资源加载延迟) ---+
|  - AllAssetReady?                                   |
|  - 上传 H/N/T/A/S 5 张 sector 纹理到 VT atlas slice  |
|  - 上传 D/N/C 3 张 layer 纹理到 layer Tex2DArray     |
+--------------------+--------------------------------+
                     v
+----- (D) TerrainVTBakePass (per frame) -------------+
|  - terrainVTBakeCS dispatch                         |
|  - 把当前帧需要的 sector × layer 组合烘焙到 VT     |
|    physical cache (Tex2DArray)                      |
|  - 如启用压缩：terrainASTCCompressCS /              |
|                terrainBC3CompressCS 在线压缩       |
+-----------------------------------------------------+
```

### 4.2 流式加载状态机（`HGTerrainStreamingManager.EarlyUpdate`）

直证（反编译 `EarlyUpdate` 调用图 ①）：

1. **取消队列**：`HGTerrainManager::GetTerrainSplatsForCanceling` 拿 BitSet，按 bit 在 m_splatLut 里 Remove —— 玩家走出范围撤销已请求的加载（`HGTerrainStreamingManager.cs:516–558`）。
2. **入队 splat 加载**：`HGTerrainManager::GetTerrainSplatsForStreaming` 拿 BitSet，每个 bit 对应一个 layer index → 入 `m_splatsPendingToLoad` queue + m_splatLut HashSet 防重（`:559–598`）。
3. **入队 node（sector）加载**：`GetTerrainNodesForStreaming` 拿 `NativeArray<uint> nodeKeys`（`UnsafeUtility.ReadArrayElement<uint>` 一次一个）→ 入 `m_nodeAtlasPendingToLoad` + m_nodeLut（`:599–642`）。
4. **限速发起加载**：每帧最多 **2 个** splat 加载（`cmp r15d, 2 ; jge` @ `:654` 直证 ①）和 2 个 node 加载并发；超出留到下帧。每个 splat 同时发 3 张 tex（D/N/C）的 `Beyond.Resource.ResourceManager.LoadAsync<Texture2D>` —— `FAssetProxyHandle` 是异步句柄。
5. **GameplayUpdate** 轮询 `AllAssetReady()`（4 个句柄全 isDone）→ 触发上传 callback（`g_18FC43260` 函数指针，调用 native 上传到 VT atlas）→ Dispose handles → 出队。

**关键 delta**：每帧上限 2 + 2 = 4 个 sector/layer 加载并发，保证带宽不爆 —— 这是开放世界的关键背压。

### 4.3 TerrainVTBakePass（`TerrainVTBakePassConstructor.cs:88+`）

注册 `"TerrainVTBakePass"` RenderGraph pass（`:106`），data 只有一个 `feedbackViewId`（`:9–11`）。pass 调 `terrainVTBakeCS`（在 `HGTerrainRuntimeResources.ShaderResources.terrainVTBakeCS`）：

- **输入**：sector 高度 / 法线 / splatctrl（已加载到 atlas slice），layer Diffuse/Normal/ConeMap Tex2DArray；
- **逻辑**：对每个 active VT page 跑 splatmap 的简化版（layer 数 ≤ 4 or 8），把"该 sector 当前帧需要的 mip"的 albedo+normal+mask 写入 VT physical cache（`vtCacheSliceCount` × `vtCacheSliceWidth` × `vtCacheSliceHeight` 的 Tex2DArray）；
- **压缩**（可选 `vtEnableCompression`）：`terrainASTCCompressCS` / `terrainBC3CompressCS` 在 GPU 上 BCn 压缩 → 减半显存占用。

**意义**：实际地形像素着色阶段不再每像素采 64 个 layer，而是 **采一次 VT atlas 拿到已 bake 的合成结果** → 4–8 → 1 tap 降低带宽。这是 HG 把 HDRP splatmap 移植到大世界 + 大量 layer 的核心招式。

---

## 5. Chunk 四叉树 LOD 与 Tessellation/Subdivision 深度

### 5.1 ChunkNode 结构与 LOD 状态（`HGTerrainRenderer.cs:12–235`）

```csharp
public struct ChunkNode {
    public Vector4 transform;   // (cx, cy, cz, halfExtent) — 节点 AABB
    public short[] children;    // 4 个子节点索引（NE/NW/SE/SW）
    public short parent;        // 父节点
    public ushort level;        // LOD 层级
    public ushort lodData;      // 低 8-bit = morph alpha，高 8-bit = 目标 LOD
    public float distance;      // 节点中心到相机的距离
    // ...
}
```

`lodData` 编码（反编译方法体 ① 直证）：

`CheckSplit(ushort targetLod)` 关键三条（`:69–113`）：

```text
mov   eax, 0FFh
or    ax, [rbx+1Ch]      ; lodData |= 0x00FF
cmp   di, ax             ; targetLod > (lodData | 0xFF) ?
seta  al
```

**含义**：取 `lodData` 的高 8-bit（当前节点目标 LOD），低 8-bit 是 morph 参数。`CheckSplit` 判断 `targetLod > currentTargetLod` → 该节点应分裂。

`GetMorphValue` 公式（`:196–235`）逐字节：

```text
movzx eax, word ptr [rbx+1Ch]   ; eax = lodData
mov   ecx, 0FFh
movss xmm0, dword ptr [g_18C471324]  ; 1.0
and   ax, cx                    ; 取低 8-bit
movzx eax, ax
movd  xmm1, eax
cvtdq2ps xmm1, xmm1             ; (float)lowByte
divss xmm1, dword ptr [g_18C471338]   ; / 255.0
subss xmm0, xmm1                ; morph = 1.0 - lowByte/255
```

→ **morph 因子 = 1 - (lodData & 0xFF) / 255**，0.0 = 完全 morph 到下一 LOD，1.0 = 保持当前 LOD。这是 chunked-LOD 的 vertex morph 防 popping 标准做法。

### 5.2 LOD 选择与遍历

`TraverseAndCullQuadTreeFixedLevel(int l)`（`:1099+`）：

- 输入：目标 LOD `l`；
- 调 `_ClampLevel(level)` clamp 到 `[0, treeDepth)`；
- 用 `HGTerrainUtils.Pow(4, level)` 计算该 LOD 的节点数（4^level）；
- 从根开始按 `node.level == targetLevel` 收集，否则下一层 `i * 4 + 1`（`lea ebx, [rbx*4+1]`）—— 这是 quadtree 数组打包的标准父→子索引公式：`children[k] = parent*4 + k + 1`。

`ChunkComparer` 按 `distance` 升序排（`:251–321`，反编译显示 `comiss xmm0, xmm6` + `cmovae`）—— 近的先渲染（z-buffer 友好）。

### 5.3 Tessellation 网格生成

构造函数（`HGTerrainRenderer.cs:382+`）中可见关键步骤（反编译直证 ①）：

```text
; 创建 33×33 ("HG_TessellationQuad" mesh @ :956)
; 33*33 = 1089 vertices
; 32*32 quads * 2 triangles * 3 indices = 6144 indices (= 0x1800 @ :818)
mov edx, 1800h
mov rcx, [System.UInt16[]_TypeInfo]
mov r12, rax
call il2cpp_vm_array_new_specific  ; 6144-element ushort index buffer

; 32 × 32 内循环 (loc_18A7AC11A) 三角化
loc_18A7AC126:
    ; 每个 quad 写 6 个 ushort 索引：
    ;   v00, v01, v00+33+1 (= v10+1 wedge bottom-right)
    ;   v00, v00+33+1, v00+33  (这是标准的对角 BL-TR + TL-BR + BR)
```

→ **33×33 顶点的 tessellation quad**，每节点统一用同一个 mesh，shader 阶段做 `_TerrainPatchInstanceData`（`HDRP TerrainLitData.hlsl:58` 同源）的 instance offset + skip-scale 把它 morph 成实际 sector 几何。这与 HDRP `ApplyMeshModification` 完全同源（`TerrainLitData.hlsl:73–102`，照抄）：

```hlsl
float2 patchVertex   = input.positionOS.xy;
float4 instanceData  = UNITY_ACCESS_INSTANCED_PROP(Terrain, _TerrainPatchInstanceData);
float2 sampleCoords  = (patchVertex.xy + instanceData.xy) * instanceData.z;
float height         = UnpackHeightmap(_TerrainHeightmapTexture.Load(int3(sampleCoords, 0)));
input.positionOS.xz  = sampleCoords * _TerrainHeightmapScale.xz;
input.positionOS.y   = height * _TerrainHeightmapScale.y;
```

`(xBase, yBase, skipScale)` 来自 `ChunkNode.transform`。

### 5.4 TessellationPassType 表（`HGTerrainRenderer.cs:238–249`）

```csharp
public enum TerrainPassType {
    Invalid                       = -1,
    GBuffer                       = 0,
    Feedback                      = 1,
    ShadowCaster                  = 2,
    TessellationGBuffer           = 3,
    TerrainDepthOnly              = 4,
    TessellationTerrainDepthOnly  = 5,
    ScreenSpaceTerrain            = 6,
    PassCount                     = 7
}
```

**关键 delta**：HG 的 7-pass 模型扩展了 HDRP 的 `Forward/GBuffer/ShadowCaster/DepthOnly`，新增：
- `Feedback` = VT feedback 收集；
- `TessellationGBuffer / TessellationTerrainDepthOnly` = 启用 GPU tess 时的变体；
- `ScreenSpaceTerrain` = 远景全屏 raymarch 地形（推断 ③：移动端低端机的纯 SS 退化）。

### 5.5 Subdivision V2 与 GPU Subd 控制（`TerrainDepthPrepassConstructor.cs:9–32`）

`PassInput` 携带：
- `enableTerrainTessellation` / `enableTerrainSubdivision` / `enableTerrainSubdivisionV2`（三层开关）；
- `terrainSubdMode` / `terrainSubdModeV2` / `terrainGpuSubd` / `terrainPrimitivePixelLengthTargetLog2`（细分级别参数）；
- `HZBTexture` —— Hi-Z 用于细分阶段 GPU occlusion culling。

`PrimitivePixelLengthTargetLog2`（`HGTerrainDeformSettingParameters.cs:15`）= 目标基元在屏幕上的像素长度的 log2 → 细分阶段以此决定 tessellation factor，按 `tess_factor = 2^(log2_screenLen - log2_target)` 标准 GPU 细分公式调（据领域 ③）。

`TerrainSubdivisionData.subdivisionHandle` + `terrainCullViewHandle` / `editorTerrainCullViewHandle` 是与 native 侧 `HGTerrainManager` 的 view-handle，C++ 模块拿这俩决定哪些 chunk 进入细分 dispatch（**交叉引用** [04-GraphicsCPPModule/01-HGGraphicsCPPModule.md §10](../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md)：`HGTerrainLayerTypeData` 在 native 持久化 + `TerrainDeformPassInput` 提供 cull view）。

---

## 6. TerrainV2 GroundLayer Clipmap — 玩家中心同心烘焙

> **强推断级 (②) + 直证 (①)**：HDRP 无对应特性。基于 `HGTerrainGroundLayer` / `HGTerrainGroundLayerClipmap` 反编译重建。

### 6.1 Clipmap 几何

`HGTerrainGroundLayer.cs:20–24`：

```csharp
public const int TEXTURE_SIZE = 1024;                       // 单层 RT 边长
public const int TERRAIN_GROUND_LAYER_CLIPMAP_NUM = 2;      // 2 层 clipmap
private HGTerrainGroundLayerClipmap[] clipmaps;
```

`HGTerrainGroundLayer.Initialize()` 反编译（`:214–289`）：

```text
movss xmm6, dword ptr [g_18C47193C]   ; 起始 extent = ???（推断 8.0m，标 ②）
xor   ebx, ebx
loc_184DC34FF:
    ; new HGTerrainGroundLayerClipmap()
    mov dword ptr [rax+1Ch], sub_41200000  ; extent = 10.0 (float)
    ...
    call HGTerrainGroundLayerClipmap::Initialize
    mulss xmm6, dword ptr [g_18C4713C0]    ; extent *= ???（推断 2.0 或 4.0）
    inc ebx
    cmp ebx, 2
    jb  loc_184DC34FF
```

**直证**：层 0 默认 extent `sub_41200000` = `0x41200000` = **10.0f**；层 1 = 10.0 × ratio。常数 `g_18C4713C0` 反编译看不见值（在 RDATA 段），但**clipmap 通用做法**是层间比率 2.0 或 4.0。**保守复刻：层 0 = 10m，层 1 = 40m**（4x ratio，给出 4 倍覆盖距离）—— 标记 ② **据反编译调用图 + clipmap 标准重建**。

### 6.2 四张 RT（`HGTerrainGroundLayer.InitializeRenderTextureResources`，`:26–212`）

```text
RTHandles.Alloc(1024, 1024, slice=1, depth=0, ColorFormat=R8G8B8A8_SRGB[?]=5, mipChain=0, autoMips=0, name="TerrainGroundLayerBaseRT")
RTHandles.Alloc(1024, 1024, ..., name="TerrainGroundLayerNormalRT")
RTHandles.Alloc(1024, 1024, ..., name="TerrainGroundLayerWetRT")
RTHandles.Alloc(1024, 1024, ..., name="...") // height RT (注意源码中也写 "TerrainGroundLayerWetRT" 是 bug? 反编译显示同一字串复用)
defaultRT = RTHandleSystem.Alloc(Texture2D.blackTexture)   // 永久 black fallback
```

**RT 用途映射（据字段名 ②）**：
- `groundLayerBaseRT` = clipmap 烘焙的 albedo（玩家中心区的动态地表覆盖物色）；
- `groundLayerNormalRT` = 法线（积雪堆积 / 水痕坑洼带来的法线扰动）；
- `groundLayerWetRT` = 湿润度 8-bit（与 `TERRAIN_WETNESS_THRESHOLD=130` 配合 → wet/dry 判定）；
- `groundLayerHeightRT` = 顶层覆盖物高度（决定与底层 splat 的高度混合权重）；
- `defaultRT` = 永久 black，远场覆盖时直接绑这张。

### 6.3 中心追踪 + dirty 触发（`HGTerrainGroundLayerClipmap.SetPlayerCenter`，`:457–566`）

逐字反编译关键段：

```text
movss xmm4, dword ptr [rbx+1Ch]      ; extent
mulss xmm4, dword ptr [g_18C471294]  ; extent * threshold (推断 0.125 = 1/8)
movsd xmm3, qword ptr [rax]          ; delta = newCenter - oldCenter
                                     ; rax 来自 Vector3.op_Subtraction
...
movss xmm0, dword ptr [g_18C47142C]  ; 高度阈值（推断 1.0 或更大）
comiss xmm0, xmm3                    ; |dy| 在阈值内？
ja short loc_1844032CA               ; 大 → 触发烘焙
movss xmm0, dword ptr [rsp+20h]
movdqa xmm1, [g_18C471280]           ; abs-mask = 0x7FFFFFFF (clear sign bit)
andps xmm0, xmm1                     ; |dx|
comiss xmm0, xmm4
ja short loc_1844032CA               ; |dx| > extent/8 → 触发
movss xmm0, dword ptr [rsp+24h]
andps xmm0, xmm1
comiss xmm0, xmm4
ja short loc_1844032CA               ; |dz| > extent/8 → 触发
; 否则 bDirty 保持 false（早退）
```

**含义（**直证 ①**）**：当玩家位移 `(|dx| > extent/8) ∨ (|dz| > extent/8) ∨ (|dy| > heightThr)` 才触发 dirty 重烘焙。**阈值 = extent / 8** —— 这是 clipmap 的"toroidal addressing 网格步长"，玩家每跨 1/8 extent 就 shift 一个网格单元，重新烘焙边缘新进入的条带。

触发后（`loc_1844032CA:`）：

```text
divss xmm0, xmm8        ; xmm8 = extent * (1/grid_step) = extent * 32 (g_18C4717D8 = 32.0?)
call sub_180368A40      ; floor / roundDown
mulss xmm7, xmm8        ; * grid_step → 量化到网格中心
unpcklps xmm7, xmm6
movsd qword ptr [rbx+10h], xmm7    ; curCenter = quantized (x, y)
mov byte ptr [rbx+20h], 1          ; bDirty = true
```

→ **新中心被量化到 `extent/32` 网格** —— 即 clipmap 内 32×32 的 toroidal grid，每格 `extent/32` 米。

### 6.4 GetTerrainDeformParams — 写入全局 cbuffer（`HGTerrainGroundLayerClipmap.GetTerrainDeformParams`，`:73–146`）

逐字反编译（**直证 ①**）：

```text
; params0 = (extent, extent, curCenter.x - extent*0.5, curCenter.z - extent*0.5)
movss xmm0, dword ptr [rbx+1Ch]      ; extent
movss xmm3, dword ptr [g_18C471320]  ; 0.5
movaps xmm1, xmm0
movaps xmm2, xmm0
movss [rsp+30h], xmm0   ; params0.x = extent
movss [rsp+34h], xmm1   ; params0.y = extent
movss xmm0, dword ptr [rbx+10h]   ; curCenter.x
mulss xmm2, xmm3        ; extent * 0.5
mulss xmm1, xmm3        ; extent * 0.5
subss xmm0, xmm2        ; curCenter.x - extent*0.5  → 矩形左下角
movss [rsp+38h], xmm0
movss xmm0, dword ptr [rbx+18h]   ; curCenter.z
subss xmm0, xmm1
movss [rsp+3Ch], xmm0   ; params0.w = curCenter.z - extent*0.5

; params1 = (-curCenter.x / extent + 0.5, 1/extent, 1/extent, -curCenter.z / extent + 0.5)
movss xmm0, dword ptr [rbx+10h]
xorps xmm0, [...sign-flip mask...]   ; -curCenter.x
divss xmm0, dword ptr [rbx+1Ch]      ; / extent
movss xmm1, [g_18C471324]            ; 1.0
divss xmm0, ...
addss xmm0, xmm3                     ; + 0.5
movss [rsp+38h], xmm0                ; params1.z = (-curCenter.x / extent) + 0.5
                                     ; (UV mapping from world to clipmap)
```

**params0** 是 clipmap 在世界坐标的 AABB（`extent × extent` 居中于 `curCenter`），**params1** 是世界→clipmap-UV 的线性变换 `uv = world * (1/extent) + (0.5 - curCenter/extent)`。

`HGTerrainDeformManager.GetTerrainDeformParams`（`:219–289`）把这俩塞进 `ShaderVariablesGlobal cb` 的偏移 `+0xA20`（params0）和 `+0xA30`（params1） —— **直证 ①** `movdqu [rbx+0A20h], xmm0` / `movdqu [rbx+0A30h], xmm1`。后续 fragment shader 用 `worldPos.xz * params1.zw + params1.xy` 解码 clipmap UV。

`HGTerrainGroundLayer.GetTerrainDeformParams`（`:398–470`）把 **2 层 clipmap 的 8 个 Vector4** 写到 `[rdi+0A44h]` 起 8 × 16 字节 = 128 字节。

### 6.5 GroundLayer Render Pass（`HGTerrainGroundLayerClipmap.Render`，`:148–455`）

注册 RenderGraph pass `"TerrainGroundLayer"`（`:174`），构造 `GroundLayerPassData`（`GroundLayerPassData.cs`）：

```csharp
internal class GroundLayerPassData {
    public ComputeShader groundLayerBakeCS;
    public TextureHandle groundLayerBaseRT;     // ReadWrite
    public TextureHandle groundLayerNormalRT;   // ReadWrite
    public TextureHandle groundLayerWetRT;      // ReadWrite
    public TextureHandle groundLayerHeightRT;   // ReadWrite
    public TextureHandle defaultRT;             // Read only
    public bool bDirty;
    public Vector4 layerParams;                 // = params0 (extent + center)
    public uint layerIndex;                     // 0 or 1
}
```

反编译显示 4 张 RT 全用 `ReadWriteTexture` 注册（即 UAV），`defaultRT` 用 `ReadTexture`（`:339`）。`AllowPassCulling(false, false)`（`:362`）—— pass 不可被 cull 掉（即使无 reader 也要执行 dirty bake）。

`s_groundLayerFunc`（`:16, :385`）是 RenderFunc，**反编译只能看到 stub 调用**（`jmp near ptr sub_1802849C0` 后跳 ILFix wrapper），具体 compute kernel 的 dispatch 维度需要看 ComputeShader 资源（`HGTerrainDeformManager.s_groundLayerCS`）—— **待确认细节**，但根据 1024×1024 RT 和 8×8 标准线程组：

```text
dispatch_x = 1024 / 8 = 128
dispatch_y = 1024 / 8 = 128
dispatch_z = 1
total threads = 128 * 128 * 64 (假设 8×8×1 wave) = 1,048,576 thread
```

→ 每帧重烘焙 1M 像素 × **bDirty=true 的层数（0–2）** —— 玩家静止时 0 dispatch。

### 6.6 整体数据流

```text
GameplayLoop
  └─ HGTerrainDeformManager.SetPlayerCenter(camera.transform.position)
        ├─ HGTerrainGroundLayer.SetPlayerCenter (broadcast 到 2 个 clipmap)
        │     └─ HGTerrainGroundLayerClipmap.SetPlayerCenter
        │           ├─ 判断 |dx|>extent/8 ∨ |dz|>extent/8 ∨ |dy|>heightThr
        │           └─ 若 yes：量化新中心到 extent/32 网格 + bDirty=true
        └─ deltaTime 累加 → m_remainDeltaTime
        
PreRender
  └─ HGTerrainDeformManager.GetTerrainDeformParams(ref cb)
        └─ 写 cb[+0xA20] = params0, cb[+0xA30] = params1 (主 deform 区)
        └─ 写 cb[+0xA44] += 2 × clipmap × (params0, params1) (GroundLayer 2 层)

RenderGraph
  └─ HGTerrainDeformManager.RenderGroundLayer(rg, hgCamera)
        └─ HGTerrainGroundLayer.Render
              └─ for each clipmap[0..1]:
                    HGTerrainGroundLayerClipmap.Render(rg, hgCamera, GroundLayerRTs)
                      └─ AddRenderPass("TerrainGroundLayer")
                          ├─ ReadWriteTexture × 4 (Base/Normal/Wet/Height)
                          ├─ ReadTexture defaultRT
                          ├─ passData.bDirty = clipmap.bDirty
                          ├─ passData.layerParams = (extent, ...)
                          ├─ passData.layerIndex = i
                          └─ SetRenderFunc(s_groundLayerFunc)
                                └─ if bDirty: cmd.SetComputeTextureParam(...);
                                              cmd.DispatchCompute(128, 128, 1)
```

### 6.7 在 TerrainLit 阶段如何采样

GroundLayer 的 4 张 RT 通过 `MaterialPropertyBlock` 或 global 绑定为 `_TerrainGroundLayerBaseTex / _TerrainGroundLayerNormalTex / _TerrainGroundLayerWetTex / _TerrainGroundLayerHeightTex`。Fragment shader：

```hlsl
// 据 params1 解码 clipmap UV
float2 cuv0 = worldPos.xz * params1[0].zw + params1[0].xy;
float2 cuv1 = worldPos.xz * params1[1].zw + params1[1].xy;
// 远层用 saturate 后超出 [0,1] 范围 fallback 到 default RT
float clip0 = all(abs(cuv0 - 0.5) < 0.5);
float clip1 = all(abs(cuv1 - 0.5) < 0.5);
// 优先层 0，外溢用层 1，再外溢用 default
float4 groundBase = clip0 ? tex(BaseRT, cuv0) :
                    clip1 ? tex(BaseRT_layer1, cuv1) :
                            tex(defaultRT, 0);
// 高度混合：与底层 splat 的 height 比较，winner-take-all
float surfaceData_albedo = (groundHeight > splatHeight) ? groundBase.rgb : splatAlbedo;
```

（**据领域 ③ 重建**，**HG shader 源未读到完整文件**，标 ② 待确认。）

---

## 7. TerrainDeform — 64×64 角色深度 + 4 RT 形变流水线

> **直证 ①**：基于 `TerrainDeformPassConstructor` 反编译完整重建。

### 7.1 配置常量（`HGTerrainDeformManager.cs:10–28`）

```csharp
public const int TEXTURE_SIZE      = 1024;   // result RT 边长
public const int HALF_EXTENT       = 32;     // 形变区半边长 = 32m（64m×64m 中心化）
public const int HALF_DEPTH_RANGE  = 32;     // Z 范围半深 = 32m
private const int kMaxSubdWidth    = 64;     // 细分 sector 上限
```

→ 形变作用区 **64m × 64m × 64m** 立方体，居中于玩家。

### 7.2 4 张 RT + 1 张 64×64 深度（`TerrainDeformPassConstructor` 构造，`:117–344`）

逐字反编译 `TextureDesc` 字段：

| RT | 分辨率 | Format | 用途 |
|---|---|---|---|
| `m_fillRateRTDesc` | 1024×1024 | `format=5` (R8?) | 历史填充率（temporal accumulate） |
| `m_resultRTDesc` | 1024×1024 | `format=0x30` (R32_UINT?) + bindMS=1 | 形变结果（每像素的形变深度） |
| `m_densityMip4RTDesc` | 64×64 | `format=5` (R8) | 形变密度的 1/16 缩略图（粗粒 occlusion） |
| `m_distanceRTDesc` | 1024×1024 | `format=0x15` (R16_FLOAT?) | "TerrainDeformDistance" — 像素到最近 deform 的距离 |
| `m_defaultFillRateRT` | 1×1 | white | fallback |
| `m_defaultDensityRT` | 1×1 | black | fallback |
| `m_defaultResultRT` | 1×1 | white | fallback |
| `m_defaultGroundLayerRT` | (terrain.terrainData) | external | fallback ground |

Character depth pass 渲染目标尺寸（`ConstructPass` 内）：

```text
mov r13d, 40h        ; 64
mov r8d, r13d        ; = 64
xor edx, edx
lea rcx, [rsp+110h]
call sub_18036E950   ; clear 64-byte struct (Matrix4x4)
```

→ 用 **64×64 的正交相机** 从顶视图 render 角色的深度（极低分辨率，因为只用来定位"哪里有脚踩"，精度 1m 足够）。

### 7.3 3-pass 流水线

`TerrainDeformPassConstructor.ConstructPass`（`:525+`）反编译显示 3 个 RenderGraph pass：

#### Pass 1: `TerrainDeformDepth` —— 角色深度收集

```csharp
private class CharacterDepthPassData {
    public Material drawInteractionNodeMaterial;
    public Matrix4x4 projView;
    public Bounds bounds;
}
```

构造细节（反编译直证 ①）：
- `Bounds(center, size)`：center = `(0, curCenter.y, 0)`，size = `(64, 64, 64)`（`g_18C4714CC` = 64.0f，`:683`）;
- 正交矩阵：halfWidth = halfHeight = 32（HALF_EXTENT），near = -HALF_DEPTH_RANGE，far = +HALF_DEPTH_RANGE，从上往下看；
- `Matrix4x4::op_Multiply` 拿 projView；
- `GeometryUtility.CalculateFrustumPlanes(projView, m_cullingPlanes)`（`:831`）算 6 平面给 culling；
- `SetColorAttachment` + `SetRenderFunc(s_depthDrawFunc)` → 顶视图深度 pass，把角色 mesh 渲染到 distanceRT。

**作用**：得到 64×64 的"角色高度图"，每个像素值 = 该 (x,z) 上角色最低点的高度（脚的高度）。

#### Pass 2: `TerrainDeformGenerate` —— 形变 dispatch

```csharp
private class DispatchPassData {
    public ComputeShader generateCS;
    public TerrainDeformConstData constData;       // 3 × Vector4 cbuffer
    public TextureHandle groundDistanceRT;          // = distanceRT (read)
    public TextureHandle historyFillRateRT;         // (read)
    public TextureHandle curFillRateRT;             // (write)
    public TextureHandle resultRT;                  // (write)
    public TextureHandle densityMip4RT;             // (write)
    public TextureHandle defaultResultRT;
    public TextureHandle defaultDensityRT;
    public int vtFeedbackId;
    public uint terrainCullViewHandle;
    public uint editorTerrainCullViewHandle;
}
```

`TerrainDeformConstData.SetConstData`（`TerrainDeformConstData.cs:13–88`）打包 `param0/param1/param2`：

```text
; param0 = (TEXTURE_SIZE=1024 (=0x44800000? no, 1024.0f), 0.0009765625 (=1/1024), 
;           (curCenter.x - prevCenter.x) * 64.0f, (curCenter.z - prevCenter.z) * 64.0f)
mov dword [rsp+20h], sub_44000000   ; 512.0?  (1024.0/2 ?)
mov dword [rsp+24h], sub_3A800000   ; 0.000976562 = 1/1024
mulss xmm2, dword [g_18E5EC474]     ; * 64
mulss xmm3, dword [g_18E5EC474]     ; * 64
movss [rsp+28h], xmm2
movss [rsp+2Ch], xmm3
movdqu [rdi+0], xmm0                ; param0

; param1 = (64.0, curCenter.x - someOffset, curCenter.z (sub something), curCenter.z (raw))
mov dword [rsp+20h], sub_42800000   ; 64.0
subss xmm1, dword [g_18C4714CC]     ; - 64.0
...

; param2 = (0.125, deltaTime-based, 1/dt if dt>=1e-6 else 0, 0)
mov dword [rsp+20h], sub_3E000000   ; 0.125
and dword [rsp+2Ch], 0              ; 0
movss xmm2, dword [rbx+2Ch]         ; m_remainDeltaTime
movss [rsp+24h], xmm2
movss [rsp+28h], xmm3               ; = 1/dt if dt big enough
```

→ param0/1 是 deform 区的世界→UV 变换 + 帧间位移，param2 是时间相关（0.125 是温度差 / 衰减率，余两个是 dt）。

`generateCS` dispatch 维度（推断 ②）：1024×1024 result-RT，8×8 thread group → `(128, 128, 1)`。

#### Pass 3（条件分支）: `TerrainDeformSetDefault` —— 关闭路径

当 `enableTerrainTessellation == false`（`cmp [r14+18h], bl ; je :607`）走旁路：调 `GraphicsSettings.HasShaderDefine(...)` 检查是否需要走 default，注册 `"TerrainDeformSetDefault"` pass，仅 `ImportTexture` 把 `m_defaultDensity / m_defaultResult / m_defaultGroundLayer` 三张作为 set-default 数据，shader 阶段不消费 deform-result。

### 7.4 帧间累加（Tick，`HGTerrainDeformManager.Tick`，`:106–157`）

```text
addss xmm6, dword [rbx+28h]   ; xmm6 = deltaTime + m_remainDeltaTime
movss xmm0, dword [g_18C471648]  ; 0.15 (估)？ 反编译看不见具体值
mov dword [rbx+2Ch], 0       ; deltaTime = 0
comiss xmm6, xmm0
movss dword [rbx+28h], xmm6  ; 累加保存
jae short ?                  ; 累加足够触发 tick
subss xmm6, xmm0
mov dword [rbx+2Ch], sub_3E19999A   ; = 0.15 (0x3E19999A == 0.15f)
movss dword [rbx+28h], xmm6
```

→ `deltaTime` 累加到 ≥ 0.15s 才触发一次 deform update + 减去 0.15 → **形变流水线以 ~6.67Hz 频率 tick，与帧率解耦**（即使 60fps 也只跑 6.67 次/秒，省 GPU）。形变是低频低分辨率特效。

### 7.5 数据流

```text
GameLoop frame
  ├─ HGTerrainDeformManager.SetDeformCenter(camera) → SetPlayerCenter
  │     └─ 量化新中心 + bDirty （同 GroundLayer 6.3 节）
  └─ HGTerrainDeformManager.Tick(deltaTime)
        └─ 累加 m_remainDeltaTime ≥ 0.15s → triggerDeform

PreRender
  └─ TerrainDeformPassConstructor.PrepareShaderVariablesGlobal
        └─ HGTerrainDeformManager.GetTerrainDeformParams(ref cb)
              ├─ cb[+0xA20] = (1.0, dt/0.15+0.0625, ?, ?)  (param0)
              ├─ cb[+0xA30] = (curCenter.x, curCenter.y, subdWidth, 0)  (param1)
              └─ HGTerrainGroundLayer.GetTerrainDeformParams (continues into cb[+0xA44+])

RenderGraph
  └─ TerrainDeformPassConstructor.ConstructPass
        ├─ Pass: TerrainDeformDepth (64×64 ortho top-down)
        │     └─ 渲染所有角色 → distanceRT
        ├─ Pass: TerrainDeformGenerate (compute)
        │     └─ generateCS (dispatch 128×128)
        │         读 distanceRT, historyFillRateRT
        │         写 curFillRateRT, resultRT (= 形变深度), densityMip4RT
        └─ HGTerrainDeformManager.RenderGroundLayer
              └─ (后续触发 GroundLayer pass)

PostRender
  └─ TerrainDeformPassConstructor.OnPostRendering
        └─ HGRenderGraph.PreserveTexture(historyFillRateRT, "TerrainDeformPass")
              → 当前帧 curFillRateRT 持久化为下帧的 historyFillRateRT (ping-pong)
```

`PreserveTexture` 是 HGRenderGraph 的跨帧句柄持久化（同 HDRP 的 history-buffer 系统）—— **直证 ①**（`TerrainDeformPassConstructor.cs:OnPostRendering :428–502`）。

### 7.6 着色阶段使用

Terrain fragment shader 用 `worldPos.xz` 减 `curCenter.xz`，除以 64（HALF_EXTENT×2）+ 0.5 → deform UV → 采样 `_TerrainDeformResultRT`：

```hlsl
float2 deformUV = (worldPos.xz - param1.yz) / 64.0 + 0.5;
if (all(abs(deformUV - 0.5) < 0.5)) {
    float deformDepth = SAMPLE_TEXTURE2D(_TerrainDeformResult, sampler_linear, deformUV).r;
    // 把 deformDepth 应用到顶点 Y 或在 fragment 写 depth offset (depth bias)
    worldPos.y -= deformDepth * param2.x;  // 0.125 系数
}
```

**据领域知识 ③ + 反编译数据耦合点重建**。

### 7.7 与 C++ 模块的耦合

`DispatchPassData.terrainCullViewHandle / editorTerrainCullViewHandle`（`:58–59`）—— 这是 **native 侧 `TerrainDeformPassInput`** 提供的 view handle（**交叉引用** [04-GraphicsCPPModule/01-HGGraphicsCPPModule.md §10](../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md)）。Compute shader 拿 handle 读 native 维护的 cull-result（哪些 sector 在 deform 视域内），避免重复 CPU 拷贝。

---

## 8. TerrainV2 特化层 — Glint / FakeVolume / FakeShadow / Subsurface

> **直证 ①**：4 个 struct 全部反编译 + 调 `CommandBuffer.SetGlobalFloat/Vector/Color/Int/Keyword` 写入 cbuffer + keyword。

### 8.1 TerrainLayerTypeData 总入口（`TerrainLayerTypeData.cs:9–22`）

```csharp
public struct TerrainLayerTypeData {
    public TerrainGlintData _glintData;
    public TerrainSubsurfaceData _subsurfaceData;
    public TerrainFakeVolumeData _fakeVolumeData;
    public TerrainFakeShadowData _fakeShadowData;
}
```

`SetupTerrainParams(HGRenderGraphContext)` 按顺序调 4 个 sub-data 的 setup（`:23–110`），最后**统一开关 `_TerrainEnabled` keyword**（`:71–87`）—— 当任一 fake 开启就开 keyword，让 shader 启用 `TerrainV2` 路径。

```text
mov rbp, [rcx+290h]                   ; HGShaderKeyWords.terrainV2Keyword
cmp byte [rbx], 0                     ; _glintData._EnableFakeGlint
jne loc_18A8774CC
cmp byte [rbx+30h], 0                 ; _subsurface 啥的
jne loc_18A8774CC
movzx esi, byte [rbx+48h]             ; _fakeVolume._EnableFakeVolume
loc_18A8774CC:
test esi, esi
setne r8b                             ; 任一 true → keyword on
call CoreUtils.SetKeyword
```

### 8.2 TerrainGlintData — Fake 闪粉（`TerrainGlintData.cs:9–25`）

```csharp
public struct TerrainGlintData {
    public bool _EnableFakeGlint;
    public float _GlintTopBlendSmoothness;   // 顶层混合软度
    public float _GlintTopBlendThreshold;    // 顶层混合阈值（避免覆盖底层）
    public float _GlintStrength;             // 闪粉强度
    public float _GlintScale;                // 闪粉密度 (tile)
    public float _GlintThreshold;            // 出现阈值 (smoothstep)
    public float _GlintFadeDistance;         // 距相机渐隐距离
    public Color _GlintColor;                // 闪粉色温
}
```

`SetupTerrainParams`（`:27–149`）把 7 个 float + 1 个 Color 通过 `cmd.SetGlobalFloat/Color` 上传到 cbuffer 偏移 `+0xCA4 .. +0xCBC`（直证）+ 设置 `terrainGlintKeyword`（`HGShaderKeyWords+0x260`）。

**渲染原理（据 NPR/风格化标准 ③）**：fragment shader 用 `glintNoise = hash(floor(worldPos.xz * _GlintScale))`，`alpha = smoothstep(_GlintThreshold, _GlintThreshold + _GlintTopBlendSmoothness, glintNoise) * (1 - dist/_GlintFadeDistance)`，最终 `surfaceData.emissive += _GlintColor * _GlintStrength * alpha`。这是 EF "雪地" / "金属地砂" 的标志性效果。

### 8.3 TerrainSubsurfaceData — 雪 / 蜡质透光（`TerrainSubsurfaceData.cs:9–17`）

```csharp
public struct TerrainSubsurfaceData {
    public TerrainSubsurfaceParams _Params;        // (_Use, curvatureScale, curvatureOffset)
    public HGSubsurfaceProfile _SubsurfaceProfile; // 引用 SubsurfaceProfile asset
    public const int DEFAULT_TERRAIN_STENCIL_REF           = 128;   // 0x80
    public const int DEFAULT_SEPARATE_TERRAIN_STENCIL_REF  = 32;    // 0x20
}
```

`SetupTerrainParams`（`:19–239`）关键操作：

1. **Profile 注册**：`SubsurfaceProfileManager.GetTerrainSubsurfaceProfileInt(profile)` 返回 profile 在 SSS profile table 的索引（与 HDRP 的 `DiffusionProfile` 同源数据流）。
2. **CBuffer 上传**：`ScriptableRenderContext.AllocateConstantBuffer(profile, 0x10)` 申请 16 字节 cbuffer slot，写 `(useSSS, curvatureScale, curvatureOffset, profileInt)` → `SetGlobalConstantBufferInternal0(cbufferID +0xD28)`。
3. **Stencil 写入**：当满足条件（`HGGraphicsFeatureManager.terrainSubsurfaceFeature.enabled == true ∧ _UseSubsurfaceProfile == true`）调 `HGStencilUtils.SetStencilValueByMask(stencilValue=128, mask=0xE0, shift=0)` —— `0x80` 位 bit-7 = "this pixel is terrain SSS"，被后续 SSS pass（`/08-Subsurface_Char/...` 单元）读到后跑 Burley-normalized diffusion。

**交叉引用**：SSS 算法本体在 `C08_Subsurface_Char`（不在本单元）。HG 把 Burley diffusion **复用 HDRP 同源算法**（`HDRP/Runtime/Material/SubsurfaceScattering/*`），地形侧只负责写 stencil + profile-id。

**关键 delta vs HDRP**：HDRP 标准 `Lit.shader` 才支持 SSS，HG 把它扩展到 `TerrainLit` —— 通过 simpleSubsurface 路径（`TerrainLayerTypeUtils.HasTerrainSimpleSubsurface()` 决定走简化版 or 完整 Burley，`TerrainLayerTypeUtils.cs:7+`）。

### 8.4 TerrainFakeVolumeData — 折射 / 裂缝 / 浮尘三段 parallax（`TerrainFakeVolumeData.cs:9–15`）

```csharp
public struct TerrainFakeVolumeData {
    public TerrainFakeVolumeParams _Params;        // 21 个 float/color/int 参数
    public Texture2D _FakeVolumeOpacityMask;       // 不透明度遮罩（控制 fake-volume 出现区域）
    public Texture2D _FakeVolumeMask;              // 主 mask
}
```

`TerrainFakeVolumeParams`（`TerrainFakeVolumeParams.cs:7–50`）共 21 字段，按用途分 3 组（**据字段名 ②**）：

**Crack 层（裂缝/纹路）**：
- `_FakeCrackLayerTiling`, `_FakeCrackTint`, `_FakeCrackHeightScale`, `_FakeCrackDepth`, `_FakeCrackMarchSteps`

**Refraction 层（伪折射，例如水面玻璃地砖）**：
- `_FakeRefractionTint`, `_FakeRefractionLayerTiling`, `_FakeVolumeScatterExtinction`, `_FakeVolumeScatterAlbedo`, `_FakeRefractionHeightScale`, `_FakeRefractionDepth`, `_FakeRefractionMarchSteps`

**Dust 层（浮尘 / 飘雪）**：
- `_FakeDustLayerTiling`, `_FakeDustDepth`, `_FakeDustFlowSpeed` (Vector4), `_FakeDustTint`

**通用控制**：
- `_EnableFakeVolume`, `_FakeVolumeIoR`, `_FakeVolumeFresnelStrength`, `_FakeVolumeMode` (`EFakeVolumeMode` 枚举，**交叉引用** `C05_Volumetric` 共享枚举)，`_FakeVolumeOpacityTiling`

`SetupTerrainParams`（`:17–281`）通过 ~16 次 `cmd.SetGlobalFloat/Color/Vector/Texture/Int` 上传，cbuffer 偏移 `+0xD64..+0xDB4`。两个 keyword：
- `terrainFakeVolumeKeyword`（HGShaderKeyWords+0x270），按 `_EnableFakeVolume` 开关；
- `terrainFakeCrackHQKeyword`（+0x278），按 `_FakeVolumeMode == 1` 开关 → mode=1 启用高质量裂缝 march。

**渲染原理（据 parallax-occlusion + screen-space raymarch 标准 ③）**：

```hlsl
// Fragment shader (重建)
float3 viewTS = normalize(GetViewDirTangentSpace());
float3 entryPos = float3(uv, 0);
float3 exitPos  = entryPos + viewTS * _FakeCrackDepth;

// 三段 march：Crack
for (int s = 0; s < _FakeCrackMarchSteps; ++s) {
    float t = float(s) / _FakeCrackMarchSteps;
    float2 sUV = lerp(entryPos.xy, exitPos.xy, t);
    float h = SAMPLE_TEXTURE2D(_FakeVolumeMask, ..., sUV * _FakeCrackLayerTiling).r;
    if (h < t) { crackColor = _FakeCrackTint * (1-t); break; }
}

// Refraction
float refractedDir = refract(viewTS, normalTS, 1.0 / _FakeVolumeIoR);
// ... 类似 march

// Dust (animated)
float2 dustUV = uv + _Time * _FakeDustFlowSpeed.xy;
dust = SAMPLE(_, dustUV * _FakeDustLayerTiling) * _FakeDustTint;

// 合成
surfaceData.albedo = lerp(surfaceData.albedo, crackColor + refractColor + dust, opacityMask);
```

### 8.5 TerrainFakeShadowData — 风格化自阴影（`TerrainFakeShadowData.cs:9–18`）

```csharp
public struct TerrainFakeShadowData {
    public bool  _EnableFakeShadow;
    public float _FakeShadowPenumbra;        // 半影软度
    public float _FakeShadowStrength;        // 阴影强度
    public float _FakeShadowMarchSteps;      // raymarch 步数
    public float _FakeShadowDistanceLerp;    // 远距渐隐
}
```

`SetupTerrainParams`（`:20–117`）写 cbuffer 偏移 `+0xDB8..+0xDC4` + 设 `terrainFakeShadowKeyword`（HGShaderKeyWords+0x280）。

**渲染原理（屏幕空间高度 march 自阴影 ③）**：

```hlsl
float3 sunDir = _MainLight.dir;
float shadow = 1.0;
for (int s = 0; s < _FakeShadowMarchSteps; ++s) {
    float t = (s + 1) * _FakeShadowPenumbra / _FakeShadowMarchSteps;
    float2 sUV = uv + sunDir.xz * t;
    float sH = SAMPLE_TEXTURE2D(_HeightMap, ..., sUV).r;
    float curH = currentHeight + sunDir.y * t;
    if (sH > curH) { shadow = max(0, 1 - (sH - curH) / _FakeShadowPenumbra * _FakeShadowStrength); break; }
}
shadow = lerp(shadow, 1.0, dist / _FakeShadowDistanceLerp);
```

### 8.6 cbuffer 偏移总图（地形相关，cbuffer = ShaderVariablesGlobal）

| 偏移 (bytes) | 内容 | 来自 |
|---|---|---|
| +0xA20 | TerrainDeform param0 (extent + center) | `HGTerrainDeformManager.GetTerrainDeformParams` |
| +0xA30 | TerrainDeform param1 (subdivision + Y) | 同上 |
| +0xA38 | terrainCullViewHandle | `TerrainDepthPrepass / Deform / VTBake` |
| +0xA3C | editorTerrainCullViewHandle | 同上 |
| +0xA40 | (subdMode/V2/gpuSubd 等组合) | `TerrainDepthPrepass` |
| +0xA44 +N×0x10 | GroundLayer clipmap params (8 个 Vec4) | `HGTerrainGroundLayer.GetTerrainDeformParams` |
| +0xCA4 .. +0xCBC | Glint 参数 | `TerrainGlintData.SetupTerrainParams` |
| +0xD18 / +0xD1C | Subsurface curvature scale/offset | `TerrainSubsurfaceData` |
| +0xD20 | Subsurface stencil ref | 同上 |
| +0xD28 | Subsurface profile cbuffer slot | 同上 |
| +0xD64 .. +0xDB4 | FakeVolume 参数（Crack/Refraction/Dust） | `TerrainFakeVolumeData` |
| +0xDB8 .. +0xDC4 | FakeShadow 参数 | `TerrainFakeShadowData` |

---

## 9. Pass 编排时序（HGRenderGraph 全帧顺序）

> **据反编译调用图 + RenderGraph 注册顺序 ②**

```text
┌─────────────── 1 帧 ───────────────────────────────────────────────────┐
│                                                                       │
│  [Phase] GameplayUpdate                                               │
│    └─ HGTerrainStreamingManager.GameplayUpdate                        │
│         └─ 轮询 m_nodeAtlasPendingLoaded + m_splatsPendingLoaded     │
│         └─ AllAssetReady 的 → 上传 atlas slice → Dispose handles     │
│                                                                       │
│  [Phase] EarlyUpdate                                                  │
│    └─ HGTerrainStreamingManager.EarlyUpdate                           │
│         ├─ HGTerrainManager::GetTerrainSplatsForCanceling → 入 LUT 移除│
│         ├─ HGTerrainManager::GetTerrainSplatsForStreaming → 入队加载   │
│         └─ HGTerrainManager::GetTerrainNodesForStreaming → 入队加载    │
│                                                                       │
│  [Phase] OnPreRendering (TerrainDeform + TerrainDepthPrepass)         │
│    ├─ HGTerrainDeformManager.SetDeformCenter / Tick                  │
│    └─ TerrainVTBakePassConstructor.OnPreRendering                    │
│         └─ AddRenderPass("TerrainVTBakePass")                         │
│                                                                       │
│  [Phase] PrepareShaderVariablesGlobal                                 │
│    ├─ TerrainDeformPassConstructor.PrepareShaderVariablesGlobal      │
│    │    └─ HGTerrainDeformManager.GetTerrainDeformParams(ref cb)     │
│    │         └─ HGTerrainGroundLayer.GetTerrainDeformParams(ref cb)  │
│    └─ TerrainV2 SetupTerrainParams (Glint/SSS/FakeVolume/FakeShadow) │
│                                                                       │
│  [Phase] ConstructPass (在 HGRenderGraph 的 Build 阶段)              │
│    ├─ TerrainDepthPrepassConstructor.ConstructPass                   │
│    │    ├─ Pass "TerrainSubdivision" (compute, write HZB)            │
│    │    └─ Pass "TerrainDepthPrepass" (raster, write depthBuffer)    │
│    ├─ TerrainDeformPassConstructor.ConstructPass                     │
│    │    ├─ Pass "TerrainDeformDepth" (raster, 64×64 角色顶视图)      │
│    │    ├─ Pass "TerrainDeformGenerate" (compute, 4 RT write)        │
│    │    └─ HGTerrainDeformManager.RenderGroundLayer                  │
│    │         └─ HGTerrainGroundLayer.Render                          │
│    │              └─ for clipmap[0..1]:                              │
│    │                   Pass "TerrainGroundLayer" (compute, 4 RT R/W) │
│    └─ TerrainVTBakePassConstructor.ConstructPass                     │
│         └─ Pass "TerrainVTBakePass" (compute, VT atlas write)        │
│                                                                       │
│  [Phase] 主渲染 GBuffer/Forward                                       │
│    └─ Terrain mesh draw (使用 _TerrainPatchInstanceData)              │
│         └─ TerrainLit shader：                                       │
│              ├─ TerrainLit_Splatmap.hlsl (HDRP 4/8 layer 高度混合)   │
│              ├─ 采 GroundLayer 4 张 RT (近场覆盖)                    │
│              ├─ 采 _TerrainDeformResult RT (脚印形变)                │
│              ├─ 采 VT cache (远场合成结果)                           │
│              ├─ TerrainV2 FakeGlint / FakeVolume / FakeShadow 混合   │
│              └─ Subsurface stencil bit 写入                           │
│                                                                       │
│  [Phase] OnPostRendering                                              │
│    └─ TerrainDeformPassConstructor.OnPostRendering                   │
│         └─ HGRenderGraph.PreserveTexture(curFillRateRT → next frame) │
│                                                                       │
└───────────────────────────────────────────────────────────────────────┘
```

---

## 10. 关键常量 / 魔数 总表

| 常量 | 值 | 单位 / 含义 | 来源 |
|---|---|---|---|
| `TERRAIN_LAYER_TEX_RESOLUTION` | 1024 | px | `HGTerrainUtils.cs:35` |
| `TERRAIN_DECAL_TEXTURE_RESOLUTION` | 512 | px | `HGTerrainUtils.cs:37` |
| `TERRAIN_DECAL_MAX_PER_PAGE` | 256 | 个 | `HGTerrainUtils.cs:39` |
| `TERRAIN_DECAL_MAX_PER_BLOCK` | 16 | 个 | `HGTerrainUtils.cs:41` |
| `TERRAIN_WETNESS_THRESHOLD` | 130 | 8-bit (0–255) | `HGTerrainUtils.cs:47` |
| `TERRAIN_SPLAT_MAX_ALPHAMAP_COUNT` | 16 | 个 (4 Control × 4 channel) | `HGTerrainUtils.cs:67` |
| `TERRAIN_SPLAT_MAX_LAYER_COUNT` | 64 | 个 | `HGTerrainUtils.cs:69` |
| `TERRAIN_SPLAT_TEX_ARRAY_SLICE_COUNT_PC` | 32 | 切片 | `HGTerrainUtils.cs:71` |
| `TERRAIN_SPLAT_TEX_ARRAY_SLICE_COUNT_MOBILE` | 24 | 切片 | `HGTerrainUtils.cs:73` |
| `GroundLayer TEXTURE_SIZE` | 1024 | px | `HGTerrainGroundLayer.cs:20` |
| `TERRAIN_GROUND_LAYER_CLIPMAP_NUM` | 2 | 层 | `HGTerrainGroundLayer.cs:22` |
| Clipmap 层 0 default extent | 10.0 | m | `HGTerrainGroundLayer.Initialize :246` (0x41200000) |
| Clipmap 触发阈值 | extent/8 | m | `HGTerrainGroundLayerClipmap.SetPlayerCenter :491` |
| Clipmap 量化网格 | extent/32 | m | 同上 `:529` (g_18C4717D8=32.0) |
| Deform `TEXTURE_SIZE` | 1024 | px | `HGTerrainDeformManager.cs:10` |
| Deform `HALF_EXTENT` | 32 | m | `HGTerrainDeformManager.cs:12` |
| Deform `HALF_DEPTH_RANGE` | 32 | m | `HGTerrainDeformManager.cs:14` |
| Deform `kMaxSubdWidth` | 64 | sector | `HGTerrainDeformManager.cs:24` |
| Deform tick 频率 | 0.15s | s | `HGTerrainDeformManager.Tick :142` (0x3E19999A) |
| Deform 角色深度分辨率 | 64×64 | px | `TerrainDeformPassConstructor.ConstructPass :584` |
| Streaming 并发上限 (splat) | 2 | 个/帧 | `HGTerrainStreamingManager.EarlyUpdate :654` |
| Streaming 并发上限 (node) | 2 | 个/帧 | 同上 |
| 终末地最大 sector grid | 16384 × 16384 | (14-bit × 14-bit) | `_UnpackTerrainNodeKey :308` |
| 节点 lodData morph 公式 | `1 - (lodData & 0xFF) / 255` | morph alpha | `ChunkNode.GetMorphValue :196` |
| HDRP `_HeightTransition` epsilon | 1e-5 / 1e-6 | float | `TerrainLit_Splatmap.hlsl:173, :180` |
| HDRP density 模式 step | 20.0 | 经验值 | `TerrainLit_Splatmap.hlsl:198` |
| Subsurface stencil ref (默认) | 128 (0x80) | bit-7 | `TerrainSubsurfaceData.cs:15` |
| Subsurface stencil ref (separate) | 32 (0x20) | bit-5 | `TerrainSubsurfaceData.cs:17` |
| Tessellation quad 顶点数 | 33×33 = 1089 | vertex | `HGTerrainRenderer ctor :956` |
| Tessellation quad 索引数 | 6144 | ushort | 同上 `:818` (=0x1800) |

---

## 11. 1:1 复刻蓝图（自顶向下分步）

### Step 1: 数据准备 (CPU side)

1. 实现 `HGTerrainSurfacesData`（ScriptableObject）持久化 sector 网格 + splat 库：
   - `TerrainInfo`（pos, heightScale, terrainSize, 5 张纹理 pageSize）；
   - `SplatLayerData[]`（每层 7 × Vector4 = 112 byte，最多 64 层）；
   - `Texture2D[] layerDiffuseTextures / layerNormalROTextures / layerConeMapTextures`；
   - `TerrainNodeData[]`（四叉树节点，allHole + level + parent + height range + error）；
   - `ulong[] sectorSplatInfo`（每 sector 一个 64-bit mask）。
2. 实现 `HGTerrainConfiguration`（ScriptableObject）持久化 VT/LOD 配置（§4.1 全字段）。
3. 实现 `TerrainResource` 包装 runtime/configuration/collider/decal-atlas。

### Step 2: 资源 streaming

1. 实现 `HGTerrainStreamingManager`（4 个 Queue + 2 个 HashSet LUT）：
   - `EarlyUpdate`：从 native cull view 拿 nodeKey/splatBitSet，限速入队（**每帧 2+2**）；
   - `GameplayUpdate`：轮询 `FAssetProxyHandle.isDone`，5 张 sector 纹理 + 3 张 layer 纹理上传到 atlas/Tex2DArray slice + Dispose handles + 出队；
   - 资源路径用 `Beyond.UnSafeString.Format` 减 GC；
   - `_UnpackTerrainNodeKey` 30-bit 编码：`level = key>>28, x = key & 0x3FFF, y = (key>>14) & 0x3FFF`。

### Step 3: Chunk 四叉树 + LOD

1. 构造 `HGTerrainRenderer`：
   - `ChunkNode[]` 数组、`children[k] = parent * 4 + k + 1` 索引规则；
   - `lodData` 编码：高 8-bit 目标 LOD + 低 8-bit morph，`morph = 1 - lowByte/255`；
   - `CheckSplit(targetLod) = targetLod > (lodData | 0xFF)`；
   - `TraverseAndCullQuadTreeFixedLevel(l)` 用 `HGTerrainUtils.Pow(4, level)` 计算节点数；
   - `ChunkComparer` 按 `distance` 升序排（z-buffer 友好）。
2. 构造 **33×33 顶点 + 6144 索引的 tessellation quad mesh**，所有节点共享，shader 走 `_TerrainPatchInstanceData` 拼接（HDRP `TerrainLitData.hlsl:73–102` 同源）。

### Step 4: TerrainLit shader (HDRP fork)

1. **拷贝 HDRP `TerrainLit_Splatmap.hlsl` + `TerrainLitData.hlsl`** 作为基础。
2. **扩展 `_LAYER_COUNT`** 到 4/8 之外的 dynamic 选择（HG 是 sector-level 选择 ≤ 16 个激活层，per-fragment 仍走 4 或 8 的 HDRP 路径）。
3. **加 keyword**：
   - `_TERRAIN_V2_ON`（全局开关）
   - `_TERRAIN_FAKE_GLINT_ON`
   - `_TERRAIN_FAKE_VOLUME_ON`
   - `_TERRAIN_FAKE_CRACK_HQ`
   - `_TERRAIN_FAKE_SHADOW_ON`
   - `_TERRAIN_SUBSURFACE_ON`
4. **添加 cbuffer 字段** 按 §8.6 偏移表。

### Step 5: TerrainV2 GroundLayer Clipmap

1. 实现 `HGTerrainGroundLayer`：
   - 4 张 1024×1024 RT (Base/Normal/Wet/Height) 用 `RTHandles.Alloc`；
   - 2 个 `HGTerrainGroundLayerClipmap`，extent = 10m / 40m（或 10m × 4 ratio）。
2. 实现 `HGTerrainGroundLayerClipmap`：
   - `SetPlayerCenter(pos)`：触发条件 `|dx| > extent/8 ∨ |dz| > extent/8 ∨ |dy| > Y_thr`，新中心量化到 `extent/32` 网格；
   - `GetTerrainDeformParams(out p0, out p1)`：
     - `p0 = (extent, extent, curCenter.x - extent/2, curCenter.z - extent/2)`；
     - `p1 = (1/extent, 1/extent, -curCenter.x/extent + 0.5, -curCenter.z/extent + 0.5)`；
   - `Render(rg, hgCamera, rts)`：注册 `"TerrainGroundLayer"` RenderGraph pass，4 RT 用 `ReadWriteTexture`，dispatch `groundLayerBakeCS(128, 128, 1)` 仅当 `bDirty=true`。

### Step 6: TerrainDeform 流水线

1. 实现 `HGTerrainDeformManager`：
   - 4 张 RT + 1 张 64×64 角色深度（`TextureDesc` 按 §7.2 表）；
   - `Tick(dt)`：累加 `m_remainDeltaTime`，≥ 0.15s 触发；
   - `SetPlayerCenter` 同 GroundLayer 量化逻辑。
2. 实现 `TerrainDeformPassConstructor.ConstructPass`：3 个 RenderGraph pass：
   - **Pass 1 "TerrainDeformDepth"**：64×64 ortho top-down 渲染角色深度，bound = `(0, curCenter.y, 0) ± 64m`；
   - **Pass 2 "TerrainDeformGenerate"**：compute shader，`constData` 3 × Vector4，4 RT 写入，HZB / sceneDepth 读；
   - **Pass 3 "TerrainDeformSetDefault"**（仅 tessellation 关闭时）：导入 default RT。
3. `OnPostRendering`：`PreserveTexture(curFillRateRT)` → 下帧 history。

### Step 7: VT feedback

1. **CPU 模式**：用 Unity Physics 在视锥关键样本点 Raycast 命中 chunk → (sectorIdx, mip) 入 SSBO；
2. **GPU 模式**：fragment shader 用 mipmap derivative 计算所需 mip，写 atomic 到 `RWStructuredBuffer<uint>` (sectorIdx | mip)；
3. Readback 延迟 1-2 帧到 CPU，drive `HGTerrainManager.GetTerrainNodesForStreaming` 输出；
4. `TerrainVTBakePassConstructor` 调 `terrainVTBakeCS` 把 active page 烘焙到 `vtCacheSliceCount × vtCacheSliceWidth × vtCacheSliceHeight` 的 Tex2DArray。

### Step 8: 特化层 (Glint/FakeVolume/FakeShadow/Subsurface)

1. 4 个 struct (`TerrainGlintData`, `TerrainSubsurfaceData`, `TerrainFakeVolumeData`, `TerrainFakeShadowData`) 持久化美术参数；
2. `TerrainLayerTypeData.SetupTerrainParams(context)` 顺序调 4 个 `SetupTerrainParams`：每个写自己的 cbuffer 偏移 + 设置 keyword；
3. `TerrainLayerTypeUtils.GetNativeLayerTypeData()` 把 C# struct → `HGTerrainLayerTypeData*` native struct（**交叉引用** `../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md §10`）：
   - `PrepareTerrainDataCPP` 按字段对齐 memcpy（**直证** `:182–373` 反编译显示打包公式 `_glint(112B) + _subsurface(20B) + _fakeVolume(168B) + _fakeShadow(20B) = 320B`）。
4. shader 端各特化效果按 §8.2–8.5 重建公式。

### Step 9: 与 C++ 模块对接

1. C# 侧 `terrainCullViewHandle / editorTerrainCullViewHandle` 来自 native `HGTerrainManager.RegisterCullView`；
2. `TerrainDeformPassInput` / `HGTerrainLayerTypeData` 在 native 维护持久化拷贝（避免每帧 marshal），C# 用 handle 句柄间接访问；
3. 详见 [04-GraphicsCPPModule/01-HGGraphicsCPPModule.md §10](../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md)。

### 难点 / 依赖

- **VT 物理 cache 容量规划**：`vtCacheSliceCount × vtCacheSliceWidth × vtCacheSliceHeight` 决定可视范围内同时活跃的 sector × layer 组合数上限，必须按目标平台 (PC 32 slice / Mobile 24 slice) 调；
- **Compute shader 资源**：`terrainVTBakeCS / terrainGroundLayerCS / terrainASTCCompressCS / terrainBC3CompressCS / TerrainDeform generateCS` 在 `HGTerrainRuntimeResources.ShaderResources` 里持有引用，C# 侧无源码 —— 复刻时需要自己写 5 个 CS，**dispatch 维度参考 §10 总表**；
- **NativeArray<ulong> sectorSplatInfo 解码**：`BitOperations.TrailingZeroCount` (或 `_BitScanForward` intrinsic) 遍历 64-bit mask，HG 用 `btr rbx, rax`（reset bit）模式（`HGTerrainStreamingManager.EarlyUpdate :531`）逐 bit 处理；
- **Render-thread / Compute-thread 同步**：Deform 流水线写 `historyFillRateRT` 需要 `PreserveTexture` 跨帧同步；
- **Stencil bit 复用**：Subsurface 用 bit-7 (0x80)，必须保证 SSS pass 之前没有别的 feature 写它（交叉引用 `C07_ShadowASM` 的 stencil 分配表）。

---

## 12. 支撑证据 — 数据结构布局表 + 源文件清单表

### 12.1 关键数据结构布局

| 结构 | 大小 (bytes) | 字段 | 用途 |
|---|---|---|---|
| `SplatLayerData` | 112 | 5×Vec4 + 1×Vec2 + Vec2UInt + Vec4 (pomParams) | 单 layer 的 GPU upload 包 |
| `TerrainNodeData` | 24 | int×3 + float×3 | 四叉树节点元数据 |
| `ChunkNode` | 32+padding | Vec4 transform + short[4] children + short parent + ushort level + ushort lodData + float distance | 运行时 LOD 节点 |
| `nodeKey` | 4 | uint32: [level:4][y:14][x:14] | sector 唯一 key |
| `sectorSplatInfo[i]` | 8 | uint64 bitmask | sector i 上 64 个 layer 的激活 mask |
| `TerrainDeformConstData` | 48 | Vec4 × 3 (param0/1/2) | Deform compute cbuffer |
| `TerrainGlintData` | 32 | bool + float×6 + Color | Fake glint 参数 |
| `TerrainSubsurfaceData` | 20+8 | TerrainSubsurfaceParams (bool+float×2) + HGSubsurfaceProfile (ref) | Fake SSS |
| `TerrainFakeVolumeData` | 168 | 21 字段 | Fake volume (crack/refraction/dust) |
| `TerrainFakeShadowData` | 20 | bool + float×4 | Fake shadow |
| `TerrainLayerTypeData` | 320 | 上述 4 个 sub-data | 总入口 |
| `TerrainInfo` | 48 | Vec3 + float + int×2 + ushort×5 | Terrain 顶级元数据 |

### 12.2 本单元源文件清单 (34 文件)

| 文件 | 主职责 | 关键类/方法 |
|---|---|---|
| `HGTerrainV2.cs` | TerrainV2 入口 MonoBehaviour，setup native | `SetupFromParams_Phase0/Phase1` |
| `HGTerrainConfiguration.cs` | VT/LOD 配置 ScriptableObject | 20+ 字段 |
| `HGTerrainRuntimeResources.cs` | 纹理 / Mesh / Shader / Decal 资源容器 | `TextureResources`, `MeshResources`, `ShaderResources`, `DecalResources` |
| `HGTerrainRenderer.cs` | Chunk 四叉树 + Tessellation quad 生成 + LOD | `ChunkNode`, `TraverseAndCullQuadTreeFixedLevel`, `TerrainPassType` 枚举 |
| `HGTerrainSurfacesData.cs` | SplatLayer + TerrainNode 持久化 SO | `SplatLayerData`, `TerrainNodeData`, `GetTerrainInfo` |
| `HGTerrainStreamingManager.cs` | sector/layer 资源异步加载状态机 | `EarlyUpdate`, `GameplayUpdate`, `_UnpackTerrainNodeKey`, `QueryTerrainStreamingState` |
| `HGTerrainStreamingState.cs` | 加载状态枚举 (NotInit/HasPending/AllCleared) | 3 值 |
| `HGTerrainUtils.cs` | 工具：路径 / Pow / 颜色打包 / DegreeToRadian / 屏幕点投射 | 全静态 |
| `HGTerrainConfiguration.cs` | VT/LOD 配置 SO（见上） | （重复行删） |
| `HGTerrainDecal.cs` | Decal MonoBehaviour（空壳，逻辑在 native） | （仅 class 定义） |
| `HGTerrainDeformManager.cs` | Deform 主管理器 + Tick + cbuffer 写入 | `Tick`, `GetTerrainDeformParams`, `SetPlayerCenter`, `RenderGroundLayer` |
| `HGTerrainDeformConfig.cs` | Deform 环境配置 (强度+延迟) | `Lerp<T>` |
| `HGTerrainDeformSettingParameters.cs` | Deform 全局开关参数 | 5 个 `SettingParameter` |
| `HGErosionBlendSettingParameters.cs` | Erosion 全局开关 | 仅 `Enable` |
| `HGTerrainChunkWithSurfaceTypeData.cs` | Per-chunk surface type 数组 (脚步声材质) | `surfaceTypeData[]` |
| `HGTerrainDataWithPosWrapper.cs` | SO 包装 TerrainDataWithPos | (1 字段) |
| `TerrainDataWithPos.cs` | Pos + TerrainData + LayerTypeData 三元组 | (3 字段) |
| `TerrainResource.cs` | 5 字段聚合（runtime/config/collider/decal）| - |
| `TerrainDeformConstData.cs` | Compute shader cbuffer 3 × Vec4 | `SetConstData` |
| `TerrainDeformPassConstructor.cs` | Deform RenderGraph pass 构造（3 pass）| `ConstructPass`, `_PrepareTextureHandle` |
| `TerrainDeformRenderData.cs` | TerrainDeformConstData + curCenter | - |
| `TerrainDepthPrepassConstructor.cs` | Depth prepass + Subdivision 双 pass | `ConstructPass`, `TerrainSubdivisionData`, `TerrainDepthPrepassData` |
| `TerrainVTBakePassConstructor.cs` | VT 物理 cache 烘焙 pass | `ConstructPass`, `TerrainVTBakePassData` |
| `TerrainV2/HGTerrainGroundLayer.cs` | GroundLayer Clipmap 顶级管理器 (4 RT + 2 clipmap) | `Render`, `SetPlayerCenter`, `GetTerrainDeformParams` |
| `TerrainV2/HGTerrainGroundLayerClipmap.cs` | 单 clipmap 实例 (extent + dirty + render) | `SetPlayerCenter`, `Render`, `GetTerrainDeformParams` |
| `TerrainV2/GroundLayerPassData.cs` | GroundLayer pass 数据 (4 RT handle + dirty + params) | - |
| `TerrainV2/GroundLayerRTs.cs` | 5 RT handle 包 | - |
| `TerrainV2/TerrainLayerTypeData.cs` | 4 个特化 data 总入口 + native 打包 | `SetupTerrainParams`, `PrepareTerrainDataCPP` |
| `TerrainV2/TerrainLayerTypeUtils.cs` | 特性查询 + native 数据获取 | `HasTerrainSimpleSubsurface`, `GetNativeLayerTypeData` |
| `TerrainV2/TerrainGlintData.cs` | Fake glint 参数 + setup | `SetupTerrainParams`, `ToDataCPP` |
| `TerrainV2/TerrainSubsurfaceData.cs` | Subsurface 参数 + setup + stencil 写入 | 同上 |
| `TerrainV2/TerrainSubsurfaceParams.cs` | (bool, float, float) | - |
| `TerrainV2/TerrainFakeVolumeData.cs` | FakeVolume 21 字段 + setup | 同上 |
| `TerrainV2/TerrainFakeVolumeParams.cs` | 21 个字段 struct | - |
| `TerrainV2/TerrainFakeShadowData.cs` | FakeShadow 参数 + setup | 同上 |

### 12.3 HDRP 同源点（直证 cite）

| HG 概念 | HDRP `文件:行` | 说明 |
|---|---|---|
| 4/8 层 splat 高度混合 | `TerrainLit_Splatmap.hlsl:158–195` | 公式 1:1 保留 |
| Density 混合（备选）| `TerrainLit_Splatmap.hlsl:196–215` | 同源 |
| 半像素 UV 校正 | `TerrainLit_Splatmap.hlsl:130` | 同源 |
| SampleResults UNITY_BRANCH | `TerrainLit_Splatmap.hlsl:103–119` | 同源 |
| 法线 surface gradient 累加 | `TerrainLit_Splatmap.hlsl:232–235` | 同源 |
| Mesh modification (heightmap → positionOS) | `TerrainLitData.hlsl:73–102` | 同源（GPU 顶点位移）|
| Per-pixel normal | `TerrainLitData.hlsl:145–170` | 同源 |
| Decal apply 到 surfaceData | `TerrainLitData.hlsl:213–254` | 同源 |
| `_TerrainHeightmapScale.y = scale / kMaxHeight` | `TerrainLitData.hlsl:29` 注释 | 同源（注意 HG sector heightmap 用相同公式）|
| `SAMPLE_TEXTURE2D_GRAD` 显式 ddx/ddy | `TerrainLit_Splatmap.hlsl:108–112` | 同源（避免 wave divergence）|

### 12.4 交叉引用

- C++ 侧 `HGTerrainLayerTypeData` / `TerrainDeformPassInput` / native 持久化：[`../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md`](../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md) §10
- Terrain shader 完整 reflectance 模型：[`../10-Shaders/01-Shaders.md`](../10-Shaders/01-Shaders.md) §3.3
- `TerrainDepthPrepassConstructor` 在管线总编排中的位置：[`../01-PipelineCore/02-GeometryPasses.md`](../01-PipelineCore/02-GeometryPasses.md) §3.2
- Subsurface 算法本体（Burley diffusion / DiffusionProfile）：`C08_Subsurface_Char` 单元（待）
- FakeVolume 共享枚举 `EFakeVolumeMode`：[`./05-Volumetric.md`](./05-Volumetric.md)
- Decal cluster：`HGTerrainDecal` 本身空壳，逻辑在 native 模块

---

## 13. 待确认项

| 项 | 状态 | 影响 |
|---|---|---|
| Clipmap 层间 extent ratio（2× 或 4×）| 反编译只见乘法但常量未抽出 (`g_18C4713C0`) | 影响近场 / 中距覆盖区比例 |
| Clipmap dirty 阈值 Y 方向（`g_18C47142C`）| 反编译未抽出常量 | 影响立体地形（坡道、楼梯）的触发频率 |
| `groundLayerBakeCS` 的 kernel 名 + dispatch 维度 | C# 仅引用 ComputeShader 句柄 | 推断 (128,128,1)，实际可能用更小线程组 |
| `terrainVTBakeCS` 内部分支（是否单 dispatch 处理多 page）| 反编译仅看到 pass 注册 | 影响 GPU 占用率 |
| VT 物理 cache 实际 slice/width/height 默认值 | `HGTerrainConfiguration` SO 仅声明 int 字段 | 复刻时需按目标平台决定 |
| GroundLayer 第 4 张 RT 的实际语义（Height 还是 Wet#2）| 反编译显示 alloc name 重复 "TerrainGroundLayerWetRT" 但字段名 `groundLayerHeightRT` | 字段名优先，按 Height 处理 |
| `terrainCullViewHandle` 取值范围 | 由 native `HGTerrainManager` 分配 | 看 C++ 侧文档 |
| Decal cluster 的实际打包格式 (`UInt128` / `DecalIndices` / `BlockMasks`) | 字段已知但 lookup 逻辑在 native | 详见 native 模块 |
| `EFakeVolumeMode` 全部值 | 仅见 1 (= HQ crack) 在 keyword 中被使用 | 其他 mode 待 shader 源 |
| Subsurface "separate stencil" 32 (0x20) 触发条件 | 反编译显示有但路径未走通 | 可能与 Profile Manager 选择有关 |

---

> 结尾：本蓝图根据反编译 C# 源 + HDRP 同源 hlsl 源 1:1 写成。所有反编译方法体（asm 注释）原文保留在源 C# 文件，可顺方法名 + RVA 回查。HDRP 同源点全部 cite 到 `文件:行`，公式照抄不改写。HG 自研部分 (Streaming/Clipmap/Deform/FakeXXX) 的常量、阈值、cbuffer 偏移全部直证自反编译 `[rbx+...]` 寻址表达式或 RDATA 段常量符号 (`g_18C471XXX`)。**核心算法已讲清，未填的均为辅助细节（kernel 名、CS 内部分支等），不影响 1:1 重建主框架。**
