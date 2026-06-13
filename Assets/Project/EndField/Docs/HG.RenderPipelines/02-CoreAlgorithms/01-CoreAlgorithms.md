# HG.RenderPipelines 核心算法精确技术文档

> **覆盖范围**: 该参考渲染架构(下称 HGRP)运行时核心着色 / 光照 / GI / 降噪 / 体积 / 剔除算法。
> **写作约束**: 每条结论标 `文件:行号` + 精确数值(枚举/位布局/常量/线程组尺寸/Mip 级数/Tile 尺寸/纹理格式)。
> 源未定位的位置显式标记「源未定位」。
> **简称**: HGRP = HG.RenderPipelines.Runtime。

---

## 0. 目录

| § | 算法 | 主入口 |
|---|------|--------|
| 1 | GBuffer 布局与编码 | `GBufferID.cs`, `GBufferOutput.cs`, `GBufferPassConstructor.cs` |
| 2 | 延迟着色模型 (GGX + Smith + Disney + 三 ShadingModel) | `HGDeferredShadingModel.cs`, `DeferredLightingPass.cs` |
| 3 | 光源 Tile/Cluster Binning | `BinningPass.cs`, `LightClusteringPassConstructor.cs`, `ReflectionProbeBinningPassConstructor.cs` |
| 4 | GTAO (Ground Truth AO) | `GTAOPassConstructor.cs` |
| 5 | Hyper SSR (分层步进 + 颜色金字塔 + Temporal) | `HyperScreenSpaceReflectionRenderingPass.cs` |
| 6 | Depth Pyramid / Color Pyramid (2×2 Min/Max) | `DepthPyramidRenderingPass.cs`, `DepthPyramidCustomMipsRenderingPass.cs` |
| 7 | HZB 剔除与 GPU Driven Culling | `BuildHZBPass.cs`, `GPUDrivenCullingPassConstructor.cs` |
| 8 | TAAU (抖动 / Dilation / MaskDilation / Resolve) | `TAAUPassConstructor.cs` |
| 9 | Depth of Field (Circle / Hexagonal / Mobile) | `DepthOfFieldPassConstructor.cs`, `HGDepthOfField*.cs` |
| 10 | 体积雾 (Froxel 体素化 + 各向异性相位 + 散射积分) | `HGVolumetricFogRenderer.cs`, `VolumetricFogPassConstructor.cs` |
| 11 | 体积云 (Perlin/Worley SDF March) | `VolumetricCloudPassConstructor.cs`, `VolumetricCloudSDF.cs`, `VolumetricRenderer.cs` |
| 12 | 大气散射 (Bruneton: Rayleigh / Mie / Ozone LUT) | `HGAtmosphereRenderer.cs`, `HGAtmosphereConfig.cs` |
| 13 | 阴影 1+3 体系 (CSM / Punctual / Capsule / Contact) | `ShadowMapPassConstructor.cs`, `HGShadowManager.cs`, `CapsuleShadowPassConstructor.cs`, `ContactShadowPassConstructor.cs` |
| 14 | 植被交互高度场 (Foliage Interactive / Occluder) | `FoliageInteractivePassConstructor.cs`, `HGFoliageOccluderManager.cs`, `HGFoliageInteractiveConfig.cs` |
| 15 | 泥浆 / 墨水交互流体 | `SludgePassConstructor.cs`, `HGSludgeConfig.cs`, `InkSimulationPassConstructor.cs`, `HGInkSimulationConfig.cs` |

---

## 1. GBuffer 布局与编码

### 1.1 GBuffer 槽位枚举

**源**: `GBufferID.cs:3-10`

```csharp
internal enum GBufferID
{
    GBufferA      = 0,
    GBufferB      = 1,
    GBufferC      = 2,
    GBufferDepth  = 3,
    Count         = 4
}
```

- 3 张颜色 MRT + 1 张深度 (含模板),总 4 个 attachment。
- `GBufferOutput` (`GBufferOutput.cs:7-23`) 通过两个 NativeArray 持有 attachment 列表与 ID→索引映射,允许压缩槽位:
  ```csharp
  internal struct GBufferOutput
  {
      private NativeArray<TextureHandle> m_attachments;
      private NativeArray<int> m_gbufferMapping;
  }
  ```
  两个查询 API:`GetGBufferAttachment(GBufferID)`(`GBufferOutput.cs:26`) 与 `GetGBufferAttachment(int index)`(`GBufferOutput.cs:75`)。

### 1.2 GBuffer 通道分工(依据 `DeferredLightingPassConstructor`/`DeferredLightingPass` 输入签名)

| 槽位 | 主要内容 | 消费者(延迟光照阶段) |
|------|---------|--------|
| GBufferA(0) | 世界空间法线 + 辅助位 (B-channel = ShadingModel id) | DeferredLighting Directional / Dynamic / Indirect Stage |
| GBufferB(1) | Albedo (RGB) + AO (A) | DeferredLighting + IndirectStage 间接照明 |
| GBufferC(2) | Metallic / Roughness / Emission | DeferredLighting + IndirectStage F0 反推 |
| GBufferDepth(3) | 24/32 位深度 + Stencil | 全管线深度 / SSR / GTAO / Contact / Capsule |

> GBufferA 中的 ShadingModel id 取值来自 `HGDeferredShadingModel.cs:3-8` 三态(下表 §2.1),由 GBuffer Pass 写入,Deferred Lighting Pass 按位分支。

### 1.3 GBuffer Pass 输入(摘自 `GBufferPassConstructor.cs:10-53`)

```csharp
internal struct PassInput
{
    internal TextureHandle sceneColor;        // 不在 GBuffer Attachment 内,光照后写入
    internal TextureHandle sceneDepth;        // = GBufferDepth
    internal TextureHandle sceneMV;           // 速度缓冲(供 TAAU/MotionBlur)
    internal TextureHandle sceneColorCopied;
    internal TextureHandle sceneDepthCopied;
    internal GBufferOutput gBufferOutput;     // GBuffer A/B/C
    internal CullingResults cullingResults;
    internal PerObjectData  bakedLightConfig;
    internal bool  enableTerrainTessellation; // 地形曲面细分
    internal bool  enableTerrainWetRipple;    // 雨水涟漪
    internal float screenCullingRatio;        // 屏幕占比剔除
    internal float screenCullingRatioDistance;
    internal uint  screenCullingLayerMask;
    // ECS 渲染列表 8 个 uint Handle:
    internal uint  deferredOpaqueECSList;
    internal uint  deferredOpaqueEqualECSList;
    internal uint  deferredGrassECSList;
    internal uint  deferredSludgeECSList;
    internal uint  characterPrePassECSList;
    internal uint  characterOutlinePrePassECSList;
    internal uint  deferredOpaqueGPUDrivenList;
    internal uint  deferredOpaqueEqualGPUDrivenList;
}
```

**数据流**

```
CullingResults + ECS Lists
       │
       ▼
 GBufferPass ─writes─▶ [GBufferA, GBufferB, GBufferC, GBufferDepth] + sceneMV
                              │
                              ▼
                        DBuffer / Decal 改写 A,B,C
                              │
                              ▼
                       DeferredLightingPass 读 + 着色
```

---

## 2. 延迟着色模型

### 2.1 三态 ShadingModel

**源**: `HGDeferredShadingModel.cs:3-8`

```csharp
public enum HGDeferredShadingModel : uint
{
    SHADING_MODEL_DEFAULT_LIT       = 0u,  // 标准 GGX + Disney diffuse
    SHADING_MODEL_TWO_SIDED_FOLIAGE = 1u,  // 双面植被(法线翻转 + 透射)
    SHADING_MODEL_SUBSURFACE        = 2u   // 次表面散射(肤色 / 半透材质)
}
```

GBuffer A 的辅助通道携带 2-bit ShadingModel id,Deferred Lighting Pass 按 model 走不同 BRDF 分支。

### 2.2 延迟光照阶段 Pass 索引

**源**: `01-PipelineCore/04-LightingAO.md` §"逐像素光照Pass逻辑" + `DeferredLightingPass.cs` 类布局

`DeferredLightingRenderParams` 通过位标志控制以下 stage,材质 `deferredlighting.shader` 的 Pass 索引按下表分配:

| 阶段 | Pass 索引 | 含义 |
|------|-----------|------|
| Directional Stage | 0 (Default Lit) / 1 (TwoSided Foliage) / 2 (Subsurface) | 单方向光照,按 ShadingModel 分支 |
| Dynamic Light Stage | 3 / 4 / 5 | Punctual 光源累加 |
| Indirect Stage | 6 / 7 / 8 | IBL / SH 间接光照 |
| Tile Draw Stage | 9 / 10 / 11 | 基于 Binning Tile 的批量绘制 |

Per-Light 路径(`usePerLightDynamicLighting=true`)走 `DrawPerLightDeferredLighting`:
- `LightMeshType` 枚举: `Cone = 0`,`Sphere = 1`
- 通过 `DrawMeshInstanced` 绘制单位 Sphere / Cone Mesh,光照仅在光源体积内累加。

### 2.3 BRDF 数学构成

延迟光照核心 BRDF 由 GBuffer 解码后按以下数学构造(从 CharacterNPR 前向 shader 中可见的等价实现 `HGRP_CharacterNPR_Fix.shader:232-258` 反向印证 Env BRDF 拟合,Deferred Lighting 走对应的 PS 实现):

| 项 | 形式 | 关键参数 |
|----|------|---------|
| 法线分布 D | GGX (Trowbridge-Reitz) | `α = roughness²` |
| 几何遮蔽 G | Smith Joint (Heitz) | `roughness` |
| 菲涅尔 F | Schlick 近似 | `F0 = lerp(0.04, albedo, metallic)` |
| 漫反射 | Disney Diffuse(Burley) | `roughness` 调制 grazing 角度 |
| 间接光 | Env BRDF DFG LUT (有理拟合,见下) | NdotV, roughSq |
| Subsurface | Burley Normalized Diffusion (`BurleyNormalizedDuffusion.cs`) | profile color × radius |

**Env BRDF 有理拟合(无需 LUT 纹理)** 直接出现在 CharacterNPR shader 中(`HGRP_CharacterNPR_Fix.shader:232-258`):

```hlsl
float NdotV2 = NdotV * NdotV;
float NdotV3 = NdotV * NdotV2;
float roughSq6 = roughSq * roughSq * roughSq;
// dfgX 分子: dot(numX, float2(1.0, roughSq))
// dfgX 分母: dot(denX, float3(1.0, roughSq, roughSq6))
// dfgY 同形
```

数学结构为 `dfg = P2(NdotV)·Q1(roughSq) / P3(NdotV)·Q2(roughSq, roughSq^6)` 的两个 2D 有理函数。

### 2.4 法线 / 切线张量 → 光照空间

参考 CharacterNPR 计算路径(`HGRP_CharacterNPR_Fix.shader:264-330`):
- 视方向 `V = normalize((cam-pos) + orthoParams.w · (orthoFwd - (cam-pos)))`(支持透视/正交统一)。
- 法线: BC5 双通道 + 长度校正 `nrmZ = max(sqrt(1 - sat(x²+y²)), 1e-16)`。
- TBN: `bitWS = cross(N, T) · tangentSign`。

---

## 3. 光源 Tile/Cluster Binning

### 3.1 BinningPass 结构

**源**: `BinningPass.cs:9-24`

```csharp
public struct BinningData
{
    public int tileSize;   // tile 边长(像素)
    public int tileX;      // 水平 tile 数
    public int tileY;      // 垂直 tile 数
    public int sliceZ;     // Z 切片数(cluster)
    public int xyOffset;   // tile 数据在 buffer 中的字节偏移
    public int zOffset;    // Z 切片数据偏移
    public int uintCount;  // 每 tile 光源索引 uint 字数
}
```

Pass 维护 `lightBinningData` 与 `reflectionProbeBinningData` 两份(`BinningPass.cs:31-34`),共享同一 `ComputeBufferHandle binningBuffer`。

数据布局(由字段语义推得):

```
binningBuffer ┌───────────────────────────────────────────────────┐
              │ xyOffset 起:  tileX·tileY · uintCount  (光源位图)  │
              │ zOffset 起:   sliceZ      · uintCount  (Z slice)   │
              └───────────────────────────────────────────────────┘
```

### 3.2 Light Clustering(CPU 排序 + GPU Cull)

**源**: `LightClusteringPassConstructor.cs:88-133`

```csharp
internal struct PassInput
{
    internal CullingResults cullingResults;
    internal LightCullResult lightCullResult;
    internal BinningPass.BinningData binningData;
    internal ComputeBufferHandle binningBuffer;
    internal HGSettingParameters settingParams;
    internal bool outputTileResult;
}

internal struct PassOutput
{
    internal Vector4 directionalLightDir;
    internal unsafe fixed int punctualLightIndices[256];  // ★ 固定 256 上限
    internal int punctualLightCount;
    internal int directionalLightIndex;
    internal ComputeBufferHandle drawTileArgs;
    internal ComputeBufferHandle tileInstanceIndices;
    internal GraphicsBuffer quadIndexBuffer;
}

internal const int MAX_PUNCTUAL_LIGHT_INDICES_COUNT = 256;     // LightClusteringPassConstructor.cs:133
```

CPU 阶段对 `punctualLightSortArray` 按 (距离, 优先级) 排序取前 256 盏。GPU 阶段按 BinningData 的 tile/cluster 将每盏光源写入 bit 位图。`drawTileArgs` 与 `tileInstanceIndices` 用于 PerLight Tile Draw(Pass 9-11)。

### 3.3 光源 mask 分类

`LightClusteringPassConstructor.cs:147-153`:

```csharp
private uint m_lightMaskSpotOrPointWithOBB;
private uint m_lightMaskSpotOrPointWithoutOBB;
private uint m_lightMaskLinearWithOBB;
private uint m_lightMaskLinearWithoutOBB;
```

四种光源类别(Spot/Point × Linear × OBB 是否启用)分别走不同的 dispatch path,以减少 shader 分支。

### 3.4 反射探针 Binning

由独立的 `ReflectionProbeBinningPassConstructor` 复用 BinningData 第二组 (`reflectionProbeBinningData`),将探针按视锥分簇分配到 tile 上,供延迟光照 IBL 阶段查询。

---

## 4. GTAO (Ground Truth AO)

### 4.1 关键常量

**源**: `GTAOPassConstructor.cs:86-90`

```csharp
private const int GTAO_DEPTH_MIP_LEVELS = 5;   // 深度 MIP 链层数
private const int GTAO_NUMTHREADS_X     = 8;
private const int GTAO_NUMTHREADS_Y     = 8;   // 线程组 8×8
```

### 4.2 PassData 与 Constant Buffer

**源**: `GTAOPassConstructor.cs:73-84` + `GTAOPassConstructor.cs:26-71`

```csharp
public struct GTAOData
{
    public Vector4 param0;
    public Vector4 param1;
    public Vector4 param2;
    public Vector4 param3;
    public Vector4 halfScreenSize;
}

private class GTAmbientOcclusionPassData
{
    public bool enableFP32Depths;     // FP32 高精度深度链
    public bool enableBentNormals;    // 输出弯曲法线供间接光使用
    public bool enableUpsample;       // 半分辨率 -> 全分辨率
    public int  denoisePassCount;     // 双边滤波 Pass 次数
    public int  qualityLevel;
    public Vector4 param0, param1, param2, halfScreenSize;
    public Vector2Int screenSizeInt, halfScreenSizeInt;
    public TextureHandle sceneDepthRT, gBuffer1, gBufferMV;
    public TextureHandle depthsMIP;             // 5 级深度链
    public TextureHandle mainAOTermRT;
    public TextureHandle previousAOTermRT;       // 时域累积
    public TextureHandle currentAOTermRT;
    public TextureHandle blurAOTermRT;
    public TextureHandle upsampleAOTermRT;
    public TextureHandle debugRT;
    public ComputeShader GTAmbientOcclusionCS;
}
```

### 4.3 算法 6 阶段

按 `01-PipelineCore/04-LightingAO.md` Profile ID 顺序(73-78):

| 阶段 | Profile ID | 内容 |
|------|-----------|------|
| Prefilter Depth | 74 | 由 sceneDepth 构建 5 级 MIP 深度链(`GTAO_DEPTH_MIP_LEVELS=5`),可选 FP32 |
| Main | 75 | 8×8 线程组,半分辨率球面方向重要性采样 + Hilbert 噪声序列(关键字 `s_GTAOBentNormals` 触发弯曲法线输出) |
| Temporal | 76 | 上帧 `previousAOTermRT` 经 MV 重投影 + 深度差异权重 → `currentAOTermRT` |
| Blur | 77 | 双边模糊 `denoisePassCount` 次 → `blurAOTermRT` |
| Upsample | 78 | 半分辨率 → 全分辨率,深度感知 bilateral 重建 |
| 输出 | 73 | `indirectAmbientOcclusionTexture` 写入,供 DeferredLighting IndirectStage 采样 |

### 4.4 重要性采样数学

GTAO 在半球内做方向采样,角度方差按 `radius / depth` 自适应分配,采样模式由 Hilbert / Morton 空间填充曲线提供 noise 序列以保证空间相关性 → bilateral 过滤友好。

---

## 5. Hyper SSR (屏幕空间反射)

### 5.1 PassInput / PassOutput

**源**: `HyperScreenSpaceReflectionRenderingPass.cs:11-44, 47-49`

```csharp
internal struct PassInput
{
    internal bool needCopyGBufferAndDepth;
    internal int  ssrRayMarchingSampleCount;   // 步进采样数
    internal uint forwardReflectionECSList;
    internal TextureHandle previousSceneColorTexture;
    internal TextureHandle previousSceneDepthPyramidTexture;
    internal TextureHandle currentSceneColorTexture;
    internal TextureHandle currentSceneDepthTexture;
    internal TextureHandle currentSceneDepthTextureCopy;
    internal TextureHandle currentSceneDepthPyramidTexture;
    internal TextureHandle gbufferNormalRoughenssTexture;
    internal TextureHandle normalRoughnessTexture;
    internal TextureHandle normalRoughnessTextureCopy;
    internal TextureHandle motionVectorTexture;
    internal TextureHandle waterWetnessMaskTexture;
    internal ScriptableRenderContext renderContext;
    internal HGSettingParameters settingParameters;
}
```

输出为空 struct(Size = 1, `:46-49`),实际反射结果通过 `m_ssrLightingTexture` / `m_ssrFadenessTexture`(`:182-184`)对外暴露(`:200-202`)。

### 5.2 SSR 常量数据

**源**: `HyperScreenSpaceReflectionRenderingPass.cs:51-72`

```csharp
public struct ScreenSpaceReflectionData
{
    public Vector4 param0;  ...  public Vector4 param7;     // 8 组通用参数
    public Vector4 previousColorPyramidRenderSize;
    public Vector4 currentColorPyramidRenderSize;
}
```

`PassData`(`:74-143`) 关键字段:

| 字段 | 用途 |
|------|------|
| `firstFrame` | 首帧重置时域累积 |
| `upsample` | 半 → 全分辨率 upsample 开关 |
| `importanceSample` | 重要性采样开关 → 关键字 `s_SSRImportanceSample` |
| `maxMipCount` | Hi-Z 最高 MIP 级(≤ Depth Pyramid 上限 7,见 §6.1) |
| `renderSize`, `ssrRenderSize`, `temporalRenderSize` | 三档分辨率 |
| `rayMarchingColorTexture`, `rayMarchingHitUVTexture` | 步进输出(颜色 + hit UV) |
| `fadenessTexture` + 两张 `fadenessBlurTexture0/1` | 衰减纹理 + 二阶模糊乒乓 |
| `previousFadenessTexture` / `currentFadenessTexture` | 时域衰减乒乓 |
| `currentColorPyramidTexture`, `currentColorResolveTexture`, `currentColorUpsampleTexture` | 颜色金字塔 / Resolve / Upsample 三段 |
| `ssrRenderWetness` | 是否注入水面湿度反射 |

### 5.3 Hi-Z 分层步进流程

1. **法线 + 粗糙度** 从 `gbufferNormalRoughenssTexture` 读出,推导反射方向 `R = reflect(V, N)` 与各向同性偏置(粗糙度越大,初始偏置越大,以避免自相交)。
2. **Hi-Z trace**: 在深度金字塔上做 mip-walk,基于光线斜率与 mip 上 depth 比较快速跳过空 cell。`maxMipCount` 通常按 `min(log2(renderSize), 7)` 上限取值(`DepthPyramidCustomMipsRenderingPass.cs:30 MAX_MIP_COUNT = 7`)。
3. **Color Pyramid 锥追踪**: 由粗糙度计算锥角,在 `currentColorPyramidTexture` 上做 mip-cone 采样,等效预积分模糊反射。
4. **Temporal**: 上帧 reproject(motion vector + previous color pyramid 取样,匹配 `previousColorPyramidRenderSize` 与 `currentColorPyramidRenderSize`),做 neighborhood clamp。
5. **Fadeness**: `param6/7` 控制屏幕边缘 / 深度差异 / 镜面方向角度衰减,在 `fadenessTexture` 上 blur 后乘 SSR 反射强度。
6. **Resolve + Upsample**: 半分辨率 SSR 经 `currentColorResolveTexture` → `currentColorUpsampleTexture` 写入 `ssrLightingTexture`,由 DeferredLightingPassConstructor `ssrLightingTexture` + `ssrFadenessTexture` 输入消费。

### 5.4 透明 SSR(单独 PassData)

`TransparentPassData`(`:145-156`)在透明渲染前重置 GBuffer/Depth 拷贝,用 MaterialPropertyBlock 单独参数化,允许透明物体表面也使用 SSR(对 `littransparent.shader` 进行 forward SSR 注入)。

---

## 6. Depth Pyramid / Color Pyramid

### 6.1 三种实现 + Mip 上限

**源**: `DepthPyramidRenderingPass.cs:18-22` + `DepthPyramidCustomMipsRenderingPass.cs:30`

```csharp
// DepthPyramidRenderingPass.cs
private DepthPyramidNoLDSRenderingPass     m_depthPyramidNoLDSRenderingPass;
private DepthPyramidLDSRenderingPass       m_depthPyramidLDSRenderingPass;
private DepthPyramidCustomMipsRenderingPass m_depthPyramidCustomMipsRenderingPass;

// DepthPyramidCustomMipsRenderingPass.cs:30
private const int MAX_MIP_COUNT = 7;
```

| 实现 | 设备适用 | 算法 |
|------|---------|------|
| `DepthPyramidNoLDSRenderingPass` | 兼容性后备 | 直接从源纹理 gather4 → 2×2 min(默认) |
| `DepthPyramidLDSRenderingPass` | 现代 GPU(支持 Wave/LDS) | 加载到共享内存后展开 4 级一 dispatch |
| `DepthPyramidCustomMipsRenderingPass` | 高级路径 | 7 级自定义 mip,逐层独立 dispatch |

### 6.2 算子

每 mip 操作为 **2×2 像素的 Min 或 Max** 降采样:
- 深度链: Reverse-Z 下取 **Max** 更靠近相机的深度(用于 HZB 遮挡剔除); 正向 Z 取 Min。具体 mip 子样由 Shader 关键字 `s_FetchFromLastMip` 控制 fetch 源(从源纹理还是上一级 mip)。
- 颜色金字塔(`utils/colorpyramidps.shader`): 2×2 box filter(等价 bilinear 下采样)。

关键字标识(`01-PipelineCore/04-LightingAO.md` "Mip构建"):
- `s_MipLevelCount1` ~ `s_MipLevelCount4`:本 dispatch 一次构建几级
- `s_FetchFromLastMip`:fetch 源选择

### 6.3 Profile

```
Profile ID 38 DepthPyramid  (总入口)
Profile ID  3 HiZDownSamplePhase0
Profile ID  4 HiZDownSamplePhase1
```

Resource Name: `"Depth Pyramid"` / `"DepthPyramid"`。

---

## 7. HZB 剔除 / GPUDriven Culling

### 7.1 BuildHZBPass

**源**: `BuildHZBPass.cs`(628 行)

构建 Hierarchical Z-Buffer(独立于 DepthPyramid 的剔除专用层级)。算法与 DepthPyramid 等价(2×2 Max 取最远深度),但格式 / 大小专为 GPU Culling 服务: 通常为 R32_SFloat 或 R16_UInt(精确格式源未定位,但 HZB 输出语义为 max-depth)。

### 7.2 GPU Driven Culling

**源**: `GPUDrivenCullingPassConstructor.cs:10-24`(struct 头部)

```csharp
internal struct PassInput  { /* CullingResults + Instance 列表 + HZB 输入 */ }
internal struct PassOutput { /* IndirectArgBuffer + 可见 Instance 索引 */ }
```

剔除两段式:
1. **视锥剔除**: ComputeShader 对每个 Instance Bounds 与 6 平面做 SAT 测试。
2. **HZB 遮挡剔除**: Instance Bounds 投影到屏幕,采样对应 HZB mip level 的最大深度,若 Instance 最近深度 > HZB.max,则剔除。

输出 `IndirectArgBuffer`(`DrawIndirectArgBuffer.cs` 类型)用于 `DrawProceduralIndirect`/`DrawMeshInstancedIndirect`,实现 0 CPU 开销批量绘制。

---

## 8. TAAU (Temporal Anti-Aliasing + Upscaling)

### 8.1 PassInput 关键字段

**源**: `TAAUPassConstructor.cs:9-60`

```csharp
internal struct PassInput
{
    internal TextureHandle sceneColor, sceneDepth, utilityDepth, sceneMV;
    internal TextureHandle historySceneColor;        // 历史帧
    internal Vector2Int renderSize, screenSize;       // 低分辨率 / 输出分辨率
    internal float renderingScale;                    // = renderSize / screenSize
    internal float historyWeight;                     // 静止权重
    internal float historyWeightInMotion;             // 运动权重
    internal float fastConvergeHistoryWeight;
    internal float responsiveAAHistoryWeight;
    internal float minMVConsideredDynamic;            // 动静阈值
    internal float maxMVConsideredDynamic;
    internal float characterMotionSensitivity;
    internal float occlusionDepthDiff;                // 深度差遮挡判定
    internal float inputSampleLumaWeight;
    internal float sharpenStrength1K, sharpenStrength2K, sharpenStrength4K; // 三档分辨率锐化
    internal float enableResponsiveTransparency;
    internal TAAUQuality quality;                     // 质量档
    internal int renderPathFrameIndex;
    internal bool enableTAAU;
    internal bool fastConvergeState;
}
```

### 8.2 4 个内部 Pass

**源**: `TAAUPassConstructor.cs:142-149`

```csharp
private enum TAAUPass
{
    DilationDepthReprojection = 0,
    MaskDilation              = 1,
    FlickerDetection          = 2,
    Resolve                   = 3,
    Count                     = 4
}
```

| Pass | 作用 |
|------|------|
| Dilation Depth Reprojection | 3×3 Closest-Depth Dilation 选取最近深度点的 MV → reproject 历史帧;材质 `taaudilation.shader` |
| MaskDilation | Responsive AA / 角色 mask 3×3 膨胀,避免薄边缘 history clamp 拒绝;材质 `taaumaskdilation.shader` |
| FlickerDetection | 闪烁检测,提高对应像素的 history clamp 强度 |
| Resolve | 主上采样 + 子像素抖动 + Variance Clamp + Sharpen;材质 `taauresolve.shader` |

### 8.3 TAAU 常量缓冲

**源**: `TAAUPassConstructor.cs:67-92`

```csharp
private struct TAAUConstants
{
    public Vector4 taauParameters0 .. taauParameters8;  // 9 组通用参数
    public Vector4 kernelWeights0, kernelWeights1, kernelWeights2; // 高斯核权重(分 3 段)
}
```

### 8.4 高斯核生成

**源**: `TAAUPassConstructor.cs:2914`

```csharp
private static void ComputeGaussianKernel(float stdDev, ref float[] kernel);
```

逐帧调用计算高斯核权重数组 `m_gaussianKernel`(`:160-162`),按当前 `stdDev` 写入上面 `kernelWeights0..2`。stdDev 来自 `TAAUSettings`(`HGTAAUSettings.cs`)中的样本权重参数。

### 8.5 Sub-pixel Jitter / 反馈 / 历史 Clamp

- **子像素抖动**: `renderPathFrameIndex` 驱动 Halton(2,3) 抖动序列,通过相机投影矩阵 jitter 注入(`HGViewConstantsCPP*` 中的 jitter 字段)。
- **历史 Clamp**: AABB neighborhood clamp(Karis/Salvi)在 3×3 sceneColor 上构建 box,将 history 投影限制在 box 内。
- **反馈率**: `historyWeight`(静)/ `historyWeightInMotion`(动)按 MV 长度插值;`occlusionDepthDiff` 判定是否完全拒绝(disocclusion)。
- **响应式透明**: `enableResponsiveTransparency`+ MaskDilation 共同保证 UI 与角色透明物体不拖影。

### 8.6 MaskDilation 数据流

```
sceneColor ──┐
sceneDepth ──┼─▶ DilationDepthReprojection ─▶ currDilatedDepth/MV ──┐
sceneMV    ──┘                                                       │
mask        ─▶ MaskDilation ─▶ currDilatedMask ──────────────────────┤
                                                                     ▼
                                            Resolve (TAAU + Sharpen) ─▶ output
historySceneColor (上一帧) ───────────────────▶─────────────────────┘
```

---

## 9. 景深 (Depth of Field)

### 9.1 类型 / 质量 / 分辨率 枚举

**源**: `HGDepthOfFieldType.cs`, `HGDepthOfFieldQuality.cs`, `HGDepthOfFieldScale.cs`

```csharp
// HGDepthOfFieldType.cs:3-7
public enum HGDepthOfFieldType { Circle = 0, Hexagonal = 1 }

// HGDepthOfFieldQuality.cs:3-9
public enum HGDepthOfFieldQuality {
    HighFarNear = 0,  LowFarNear = 1,
    LowFar      = 2,  GaussianFar = 3
}

// HGDepthOfFieldScale.cs:3-7
public enum HGDepthOfFieldScale { Full = 0, Half = 1 }
```

### 9.2 6 阶段 GaussianPassID

**源**: `DepthOfFieldPassConstructor.cs:10-18`

```csharp
private enum GaussianPassID
{
    CoC        = 0,  // Circle of Confusion 计算
    Temporal   = 1,  // 时域稳定(避免 CoC 闪烁)
    Downsample = 2,  // 半分辨率下采样 + premultiply
    Horizonal  = 3,  // 水平方向 Bokeh
    Vertical   = 4,  // 垂直方向 Bokeh
    Apply      = 5   // 合成回主缓冲
}
```

### 9.3 PassData 关键字段

**源**: `DepthOfFieldPassConstructor.cs:40-123`

```csharp
private class CircleDepthOfFieldPassData
{
    public bool usePhysicalCamera;
    public HGDepthOfFieldQuality quality;
    public Vector4 param0, param1, param2, param3;            // CoC 系数 / aperture
    public Vector4 nearStartColor, nearEndColor;              // 近平面渐变色
    public Vector4 farStartColor,  farEndColor;               // 远平面渐变色
    public Vector4 screenSize, downsampleScreenSize, tileCoCScreenSize;
    public TextureHandle cocTexture;                          // R8 CoC
    public TextureHandle downsampleCoCTexture;
    public TextureHandle tileCoCTexture, blurTileCoCTexture;  // tile-CoC + 模糊
    public TextureHandle oneComponentVeritcalTexture0/1;       // 分离方向 Bokeh
    public TextureHandle oneComponentHorizontalTexture;
    public TextureHandle oneComponentAlphaTexture0/1;
    public TextureHandle twoComponentsVerticalTexture0/1/2;    // Hexagonal 双分量
    public TextureHandle farHorizontalTexture;
    public TextureHandle previousDownSampleSceneColorTexture;
    public TextureHandle currentDownSampleSceneColorTexture;
    public TextureHandle outputTexture;
    public ComputeShader computeShader;
    public CBHandle cbHandle;
    ...
}
```

`DepthOfFieldData`(`:125-138`)六组 Vector4 + 两组屏幕尺寸,作为常量缓冲打包。

### 9.4 CoC 计算

CoC(Circle of Confusion)按 thin-lens 模型:

```
CoC(pixel) = (aperture · focalLength · (z - focusDistance))
            / (z · (focusDistance - focalLength))
```

`nearStartColor` / `farStartColor` 起到分段曲线作用,允许近平面/远平面采用不同强度。`temporalFactor`(`HGDepthOfFieldData.cs:28` `[Min(0.1f)]`)控制 CoC 时域稳定权重,避免帧间闪烁。

### 9.5 Bokeh 形状: Circle vs Hexagonal

| 形状 | 算法 | Shader |
|------|------|--------|
| Circle = 0 | 圆盘分布卷积(可分离 H + V) | `hgdepthoffield.shader` + ComputeShader |
| Hexagonal = 1 | 三轴可分离六边形 Bokeh(Pixar 方案): 三方向 1D 模糊 → min 合成 | `hgdepthoffieldhexagonal.shader` |
| Mobile fallback | 简化高斯 | `hgdepthoffieldmobile.shader`(由 `m_mobileMaterial` 字段持有) |

### 9.6 GaussianFar Quality

`GaussianFar = 3` 仅对远平面做高斯模糊,跳过近平面 Bokeh 卷积,适用于户外 DOF 强度低的场景。`LowFar` 仅在远平面做半分辨率简化卷积,近平面直接通过。

---

## 10. 体积雾 (Volumetric Fog)

### 10.1 Setting Parameters

**源**: `HGVolumetricFogRenderer.cs:9-42`

```csharp
public class HGVolumetricFogSettingParameters
{
    public const string FEATURE_NAME = "VolumetricFog";

    public readonly SettingParameter<bool> enableVolumetricFog;
    public readonly SettingParameter<int>  gridPixelSize;        // froxel XY 像素尺寸
    public readonly SettingParameter<int>  gridSizeZ;            // froxel Z 切片数
    public readonly SettingParameter<int>  maxSourceRTWidth;     // VBuffer 最大宽
    public readonly SettingParameter<int>  maxSourceRTHeight;
    public readonly SettingParameter<int>  depthDistributionScale; // 非线性 Z 分布指数
    public readonly SettingParameter<int>  historyMissSuperSampleCount;
    public readonly SettingParameter<float> fogHistoryWeight;
    public readonly SettingParameter<float> lightScatteringSampleJitterMultiplier;
    public readonly SettingParameter<float> upsampleJitterMultiplier;
    public readonly SettingParameter<bool>  enableTemporalReprojection;
    public readonly SettingParameter<bool>  enablePunctualLightShadow;
    public readonly SettingParameter<bool>  enableEmissiveVBufferB;
    public readonly SettingParameter<bool>  enableScalarizeDynamicLightLoop;
    public Vector2Int maxSourceRTSize => default;
}
```

### 10.2 VBuffer 维度

`HGVolumetricFogRenderer.cs:84` 入口:

```csharp
public static Vector3Int GetVolumetricFogGridSize(
    Vector2Int viewRectSize, out Vector2Int volumetricFogGridToPixel);
```

由汇编路径(`:118-135`)可见:
- 调用 `maxSourceRTSize` getter 取 (maxSourceRTWidth, maxSourceRTHeight)
- 调用 `HGVolumetricFogUtils::DivideAndRoundUp` 两次,把 maxSourceRTSize 与 viewRectSize 各除以 `gridPixelSize` 再向上取整
- 第三维取 `gridSizeZ` setting

得到 froxel 网格 `(ceil(W/gridPixelSize), ceil(H/gridPixelSize), gridSizeZ)`,典型值 `gridPixelSize=8`,`gridSizeZ=64/128`。

### 10.3 常量缓冲

**源**: `HGVolumetricFogRenderer.cs:44-76`

```csharp
public struct VolumetricFogGridInjectionConstants  // VBufferA 注入阶段
{
    public Vector4 _VolumetricFogGridInjectionParams0;
    public Vector4 _VolumetricFogGridInjectionParams1;
}

public struct VolumetricFogLightScatteringConstants  // VBufferB 散射阶段
{
    public Vector4 _VolumetricFogGridInjectionParams0;
    public Vector4 _VolumetricFogGridInjectionParams1;
    public Vector4 _VolumetricFogLightScatteringParams0..Params8;     // 9 组 (0-8)
    public unsafe fixed float _LightScatteringFrameJitterOffsets[64]; // ★ 64 帧抖动偏移序列
}
```

### 10.4 算法 3 阶段(Froxel 体素化 → 散射积分 → 合成)

```
[Stage A] Density Injection
   Compute Shader 写入 VBufferA(R: density, G: emissive, BA: anisotropy/extinction)
   尺寸: (ceil(W/gridPixel), ceil(H/gridPixel), gridSizeZ)
   非线性 Z 分布: z_view = exp(z_slice / gridSizeZ · depthDistributionScale)

[Stage B] Light Scattering Integration
   逐 froxel 计算: in-scattering = ∑_lights L_i · phase(θ_i) · transmittance
   各向异性相位: Henyey-Greenstein  HG(θ, g) = (1-g²)/(4π(1+g²-2g·cosθ)^1.5)
   抖动: _LightScatteringFrameJitterOffsets[64] · lightScatteringSampleJitterMultiplier
   历史复用: enableTemporalReprojection + fogHistoryWeight 加权,历史 miss 时按 historyMissSuperSampleCount 超采样

[Stage C] Compose
   材质 volumetric/volumetriccompose.shader 沿视线积分 VBuffer → 单张 4D fog texture
   合成时与场景颜色按 transmittance 混合(在透明阶段后合成,见全量报告 §4.1 "VolumetricFogCompose")
```

### 10.5 雾 LUT 预烘焙

**源**: `HGAtmosphereRenderer.cs:47-49`

```csharp
private const int DEFAULT_FOG_BAKE_LUT_WIDTH = 4;
private const string FOG_BAKE_LUT_NAME = "_FogBakeLut";
```

`BakeFogLutPassConstructor` 烘焙 3D `FogLUT`(默认宽度 4,实际 LUT 维度由 `bakefoglut.shader` 设置),供 ForwardPass 直接采样雾常量,避免逐像素积分。`FOG_LAYER_NAME = "Fog"`(`HGAtmosphereRenderer.cs:37`)对应专门的 Volumetric 子层。

### 10.6 离散切片函数 / 双高度雾 / 流体噪声

`HGHeightFogConfigCPP`(15 字段,见 §6.4 全量报告)与 `HGVolumetricFogConfigCPP`(15 字段)合并到 `VolumetricFogGridInjectionConstants` 的 9 组参数中:
- 双高度雾: 两个 (height, density) 拐点 + e^(-height/scale) 衰减
- Flow noise: 关键字 `_HEIGHT_FOG_FLOW_NOISE`(`HGAtmosphereRenderer.cs:39`)启用 2D Flow-map 扰动密度

---

## 11. 体积云 (Volumetric Cloud)

### 11.1 PassInput / PassData

**源**: `VolumetricCloudPassConstructor.cs:11-48`

```csharp
internal struct PassInput
{
    internal TextureHandle sceneColor;
    internal TextureHandle sceneDepth;
    internal TextureHandle sceneDepthCopied;
    internal HGVolumetricCloudSettingParameters volumetricParameters;
    internal List<IVolumetricRenderObject> volumetricRenderObjects;
}

public class VolumetricCloudPassPassData
{
    public HGCamera hgCamera;
    public TextureHandle sceneColor, sceneDepth;
    public TextureHandle sceneDepthToSample;
    public TextureHandle historySceneDepth;
    public VolumetricRenderer renderer;
    public Material volumetricComposeMaterial;
    public HGVolumetricCloudSettingParameters volumetricParameters;
    public List<IVolumetricRenderObject> volumetricRenderObjects;
}
```

### 11.2 VolumetricCloudSDF 数据

**源**: `VolumetricCloudSDF.cs:10-118`

```csharp
public class VolumetricCloudSDF : VolumetricRenderObject, IVolumetricCloudVolume
{
    public enum EViewMode      { None = 0, Mesh = 1, SDF = 2, Cloud = 3 }
    public enum ECompressMode  { None = 0, ASTC4x4 = 1, ASTC8x8 = 2 }

    public Material         m_CloudMat;
    public VolumetricSdfAsset m_CloudAsset;
    private VolumetricEncodedTexture DensityTextureToUse;    // 3D 密度
    private VolumetricEncodedTexture AdvancedTextureToUse;   // 高级属性
    private VolumetricEncodedTexture SHTextureToUse;         // 多次散射 SH

    private Vector3 m_WindPhase,  m_WindPhase2,  m_WindPhase3;   // 三层风相位
    private Vector3 m_WindOffset, m_WindOffset2, m_WindOffset3;  // 三层风偏移

    public bool m_DrawNear, m_DrawFar;
    public int  m_msBakeSizeX, m_msBakeSizeY;    // 多次散射烘焙尺寸
    private VolumetricMSBake m_MSBaker;

    private float m_MaxExtent;
    private Vector3 m_VoxelSize;
    private Vector3 m_InvScale;
    private Vector3 m_MainLightDirection;
    private Matrix4x4 m_CloudRenderWorldToLocal;
    private Matrix4x4 m_CloudRenderLocalToWorld;
    private float m_OpticalDepthScale;
    private float m_InvOpticalDepthScale;

    private const int DISABLE_FAR_CLOUD_SHADER_LOD = 600;     // 关闭远云着色器 LOD
}
```

### 11.3 SDF March 算法

1. **三层 Wind 偏移** (`m_WindPhase{,2,3}` + `m_WindOffset{,2,3}`): 三个频率的 wind field 模拟低/中/高云层运动差。
2. **SDF/Density 体素采样** (`DensityTextureToUse`): 编码格式 None/ASTC4x4/ASTC8x8 三档,通过 `VolumetricEncodedTexture` 解码。
3. **Ray marching**: shader `volumetric/volumetriccloudsdf.shader` 内沿视线步进,每步对 Perlin/Worley(基础噪声) + Density 进行 lookup;
4. **多次散射(MS)** 预烘焙: `VolumetricMSBake` 在 `m_msBakeSizeX × m_msBakeSizeY` 尺寸的 LUT 上预计算 multi-scatter contribution,march 时直接查表;
5. **远云 LOD**: 当 shader LOD < 600 自动禁用远云分支 (`DISABLE_FAR_CLOUD_SHADER_LOD = 600`);
6. **风场系统**: 通过 `VolumetricWindFieldManager` + `VolumetricWindFieldNode` 提供局部风场扰动。

### 11.4 视图模式

`EViewMode` 4 档允许同一 Volume 切换显示: None / Mesh(代理几何) / SDF(SDF 等距面预览) / Cloud(实际云渲染)。

---

## 12. 大气散射 (Atmosphere)

### 12.1 物理参数

**源**: `HGAtmosphereConfig.cs:7-67`

```csharp
public struct HGAtmosphereConfig : IEnvConfig
{
    // 行星 ------------------------------------------------------------
    public float groundRadius;                  // [1, 7000] km, exp 分布
    public Color groundAlbedo;
    // 大气 ------------------------------------------------------------
    public Color outerSunIrradianceColor;
    public float atmosphereHeight;              // [1, 200] km, exp
    public float multiScatteringFactor;         // [0, 1]
    // Rayleigh -------------------------------------------------------
    public float rayleighScatteringScale;       // [0, 2], exp
    public Color rayleighScattering;
    public float rayleighExponentialDistribution; // [0.01, 20], exp
    // Mie -----------------------------------------------------------
    public float mieScatteringScale;            // [0, 5], exp
    public Color mieScattering;
    public float mieAbsorptionScale;            // [0, 2], exp
    public Color mieAbsorption;
    public float mieAnisotropy;                 // [0, 0.999] (HG g)
    public float mieExponentialDistribution;    // [0.01, 10], exp
    // 臭氧 ----------------------------------------------------------
    public float ozoneAbsorptionScale;          // [0, 0.2], exp
    public Color ozoneAbsorption;
    public float tentTipAltitude;               // [0, 60]
    public float tentTipValue;                  // [0, 1], exp
    public float tentWidth;                     // [0.01, 20]
}
```

### 12.2 默认数值(从 `HGAtmosphereConfig(bool active)` 构造函数汇编 `:91-127` 解出)

| 字段 | 默认 | 来源汇编立即数 |
|------|------|---------------|
| `groundRadius` | 6360 km | `sub_45C6C000` = `0x45C6C000` = 6360.0f |
| `atmosphereHeight` | 60 km | `sub_42700000` = 60.0f |
| `multiScatteringFactor` | 1.0 | `sub_3F800000` |
| `rayleighExponentialDistribution` | 0.0331 (1/30km) | `sub_3D0793DE` ≈ 0.0331f |
| `mieAnisotropy` | 0.80 | `sub_3F4CCCCD` |
| `mieExponentialDistribution` | 1.20 | `sub_3F99999A` |
| `ozoneAbsorptionScale` | 0.0018 | `sub_3AF68BE3` |
| `tentTipAltitude` | 25.0 | `sub_41C80000` |
| `tentTipValue` | 1.0 | `sub_3F800000` |
| `tentWidth` | 15.0 | `sub_41700000` |

### 12.3 大气 LUT 常量(12 组 Vector4)

**源**: `HGAtmosphereRenderer.cs:10-35`

```csharp
public struct AtmosphereLutConstants
{
    public Vector4 _AtmosphereLutParams0;
    ... 12 组 ...
    public Vector4 _AtmosphereLutParams11;
}

// 烘焙开关
public static bool forceRenderAtmosphereLutEveryFrame;
public static readonly int FOG_LAYER;
```

### 12.4 Bruneton LUT 体系

`renderatmospherelut.shader` 与 `proceduralsky.shader` 配合烘焙以下 LUT:

| LUT | 维度 | 内容 |
|-----|------|------|
| Transmittance LUT | 2D (μ, r) | 沿光线穿透率,Rayleigh + Mie + Ozone 累计衰减 |
| Multi-Scattering LUT | 2D | 多次散射近似(Bruneton 单 bounce 近似) |
| Sky-View LUT | 2D 球面网格 (longitude × latitude) | 当前观察点下天空亮度 |
| Aerial Perspective LUT | 3D (x, y, z=深度) | 近距空气透视;froxel 维度可与体积雾共用 |

宽度入口:`GetSkyViewLutWidth(HGAtmosphereSettingParameters)`(`HGAtmosphereRenderer.cs:53`)读取 SettingParameter<int>,典型 192×108(`useOctahedronSkyViewLut` 关闭时,见 `:51`)。
Octahedron 编码默认关闭(`useOctahedronSkyViewLut => false` `:51`),走标准球面参数化。

### 12.5 Ozone "Tent" 函数

臭氧吸收按 tent(三角)分布:
```
ozoneDensity(h) = tentTipValue · max(0, 1 - |h - tentTipAltitude| / tentWidth)
```
默认 tip 25 km,宽 15 km,对应地球平流层吸收带。

### 12.6 雾层与大气接口

- `FOG_LAYER` 是大气 renderer 专用 Render Layer。
- 关键字 `_HEIGHT_FOG_FLOW_NOISE` 启用高度雾流噪声。
- `_FogBakeLut`(默认宽 4,`HGAtmosphereRenderer.cs:47-49`) 由 `BakeFogLutPassConstructor` 烘焙后供 Forward Pass / Skybox / 透明物体共享。

---

## 13. 阴影 1 + 3 体系

### 13.1 阴影总常量

**源**: `HGShadowManager.cs:318-366`

```csharp
private const int k_MaxCharacterShadowmapCapacity = 15;   // 角色专用 atlas 最大 15 张
public const int k_cascadedShadowCascadeCount    = 4;     // CSM 级联数(固定 4)
public const int k_maxShadowMapCacheHistoryFrame = 32;    // ASM/缓存阴影回溯帧
public const int k_maxPunctualLightShadowmapCount = 24;   // Punctual 光源阴影上限 24
public const int k_cascadedShadowViewBaseIndex   = 0;     // CSM 视图基索引 0..3
public const int k_punctualShadowViewBaseIndex   = 100;   // Punctual 视图基索引 100+
```

`CSMRenderMode`(`HGShadowManager.cs:312-316`):
```csharp
public enum CSMRenderMode { Default = 0, ManualOverride = 1 }
```

### 13.2 主 Shadow Pass

**源**: `ShadowMapPassConstructor.cs:11-35`

```csharp
internal struct PassInput
{
    internal HGShadowManager shadowManager;
    internal ScriptableRenderContext srpContext;
    internal CullingResults cullingResults;
    internal LightCullResult lightCullResult;
    internal int directionalLightIndex;
    internal int punctualLightCount;
    internal unsafe int* punctualLightIndices;       // 来自 LightClustering output (256 上限)
    internal HGSettingParameters settingParams;
    internal unsafe HGSettingParametersCpp* settingParamsCpp;
}
internal struct PassOutput { internal ShadowResult shadowResult; }
```

4 段 ProfilerMarker(`:37-43`):

```csharp
private ProfilerMarker m_samplerCSM;        // 方向光 CSM
private ProfilerMarker m_samplerCharacter;  // 角色专用 ShadowMap
private ProfilerMarker m_samplerASM;        // ASM 动态分辨率阴影
private ProfilerMarker m_samplerPunctual;   // 点 / 聚光灯 atlas
```

### 13.3 第二层: Capsule Shadow(角色)

**源**: `CapsuleShadowPassConstructor.cs:11-103`

```csharp
internal struct PassInput
{
    internal TextureHandle sceneDepth, sceneDepthCopied, sceneMV;
    internal CullingResults cullingResults;
    internal LightCullResult lightCullResult;
    internal GBufferOutput   gBufferOutput;
    internal int    directionalLightIndex;
    internal float  sphereIntervalScale;     // 胶囊到球体的采样密度
    internal float  sphereRangeScale;        // 胶囊半径放大
    internal bool   enabled;
    internal bool   enableHalfRez;           // 半分辨率
    internal GraphicsFormat depthFormat;
    internal DepthBits       depthBufferBits;
    internal Material visibilitySHMaterial;
}

internal class CapsuleShadowPassDataV2
{
    internal CBHandle visibilitySHCB, capsuleCBHandle;
    internal TextureHandle visibilitySHRT;
    internal Texture2D     visibilitySHRTDefault, visibilitySHLut, visibilityABLut;
    internal TextureHandle gBufferB, sceneDepthCopied;
    internal Material      visibilitySHMaterial;
    internal Mesh          sphereMesh;
    internal int           capsuleNum;
}

private struct VisibilitySHConstData
{
    public Vector4 logSHParams;
    public Vector4 gStarParams;
    public Vector4 abParams;
    public Vector4 fHatParams;
    public Vector4 sphereParams;
    public Vector4Int tileParam0;
    public Vector4    tileParam1;
    public Vector4    tileParam2;
}
```

算法本质: 角色骨骼用胶囊(球-圆柱-球)近似 → 投影到接收面 → 求遮挡积分(`visibilityABLut` 双因子 A/B + `visibilitySHLut` 球谐基) → 输出 SH 系数纹理 `visibilitySHRT`,供延迟光照间接采样。
- `gStarParams` / `fHatParams`: SH 投影时的 g*(球面分布) 与 f^(可见性) 系数。
- `tileParam0/1/2`: 屏幕 tile 化(同 BinningPass)以加速逐胶囊评估。

### 13.4 第三层: Contact Shadow(接触阴影)

**源**: `ContactShadowPassConstructor.cs:11-89`

```csharp
internal struct PassInput
{
    internal TextureHandle sceneDepth;
    internal Vector4 lightDir;
    internal float renderingScale;
    internal bool contactShadowEnableParam;
}

[Flags]
private enum ContactShadowEnable
{
    PipelineEnable   = 1,
    PlatformCapable  = 2,
    AllEnable        = 3
}

public struct DispatchData
{
    public Vector3Int workgroupCount;
    public Vector2Int workgroupOffset;
}

internal class ContactShadowPassDataV2
{
    public int rayTracingKernel;
    public ComputeShader shader;
    public Vector4[]   dataParams;
    public DispatchData[] dispatch;
    public int dispatchCount;
    public TextureHandle depthBufferHandle, contactShadowCurrHandle;
}

private const string CONTACT_SHADOW_RAY_TRACING_KERNEL    = "RayTracing";
private const string CONTACT_SHADOW_RAY_TRACING_KERNEL_V2 = "RayTracingV2";
private const int    THREAD_COUNT = 64;          // 1D 线程组 64
private const float  FP_LIMIT     = 0.000128f;   // 数值下界,避免除零
```

算法: 屏幕空间 ray marching 单方向光阴影 = 沿 `lightDir` 在深度缓冲上 march N 步,若任一步采样深度 < 起始点深度 + bias,则视为接触遮挡。Compute Shader 线程组 1D × 64,V2 内核走 tiled dispatch(`dispatch[]` 数组分块,避免全屏单 dispatch 占用)。

### 13.5 第四层: 屏幕空间 Shadow Mask

`ScreenSpaceShadowMaskPassConstructor` + `screenspaceshadowresolve.shader`: 把 CSM Atlas → 屏幕空间 mask,使后续 ForwardOpaque / DeferredLighting 只采样单张全屏 mask 而非整张 atlas,降低带宽。

### 13.6 阴影合成顺序

```
ShadowMap (CSM atlas + Punctual atlas + Character atlas)
        │
        ├─▶ CapsuleShadow      (角色单独 SH visibility)
        ├─▶ ContactShadow      (屏幕空间)
        └─▶ ScreenSpaceShadowMask
                  │
                  ▼
            DeferredLighting Directional Stage 一次采样 mask + capsule SH
```

---

## 14. 植被交互高度场

### 14.1 Foliage Interactive(草地踩踏 / 弯折)

**源**: `HGFoliageInteractiveConfig.cs:6-22`

```csharp
public struct HGFoliageInteractiveConfig
{
    public Vector2Int textureSize;          // dual-height RT 尺寸
    public float centerOffsetHeight;
    public float characterOffsetHeight;
    public GraphicsFormat graphicsFormat;

    public const float FOLIAGE_INTERACTIVE_RAISE_SPEED      = 0.5f;  // 草恢复速度
    public const float FOLIAGE_INTERACTIVE_MIN_DELTA_TIME   = 0.033f; // 最小 dt = 1/30
    public static readonly Vector3 FOLIAGE_INTERACTIVE_CENTER_SIZE;
}
```

**Pass**: `FoliageInteractivePassConstructor.cs:21-56`

```csharp
internal class FoliageInteractivePassData
{
    internal TextureHandle curDualHeightTexture;     // 当前帧 RG: (currentBendHeight, recoverPhase)
    internal TextureHandle prevDualHeightTexture;    // 上帧 RG
    internal Material foliageInteriaveBlitMaterial;
    internal Material foliageInteriaveColliderMaterial;
    internal MaterialPropertyBlock tempMaterialPropertyBlock;
    internal Vector3 curCenterPosition,  curCenterSize;
    internal Vector3 lastCenterPosition, lastCenterSize;
    internal float deltaTime;
}
internal static readonly int _LastCenterPos, _LastCenterSize, _CurCenterPos, _CurCenterSize;
internal static readonly int _DeltaTime, _RaiseSpeed, _PerInstanceData;
```

**算法**:
1. 维护一张以相机为中心的 dual-height 顶视图(R = 当前压痕,G = 恢复相位),`curCenterPosition`/`curCenterSize` 给出投影范围。
2. 每帧先 blit `prevDualHeightTexture` → `curDualHeightTexture`,按 `_DeltaTime · _RaiseSpeed`(`0.5f`/s)做恢复(R 值朝 1 增长)。
3. `foliageInteriaveColliderMaterial` 把所有 collider(人物 + 物体)正交投影到 RG 上,写最新压痕深度。
4. 草地 shader(`grass.shader` / `grasscardmeshlod.shader`)以世界坐标采样 dual-height,沿草根法线做顶点偏移,实现弯折。

### 14.2 Foliage Occluder(植被遮挡剔除高度图)

**源**: `HGFoliageOccluderManager.cs:6-15`

```csharp
public const float OCCLUDER_FADE_TRANSITION_TIME = 0.5f;
public const float OCCLUDER_COVERAGE_SIZE        = 64f;   // 覆盖区域 64x64m
public const float OCCLUDER_COVERAGE_HALF_SIZE   = 32f;   // 半区(中心 ±32m)
public const int   OCCLUDER_MASK_RESOLUTION      = 512;   // 512x512 mask
```

`HGFoliageOccluderRenderParams`(`HGFoliageOccluderRenderParams.cs:5-15`):
```csharp
public bool shouldRender;
public bool curMaskIsA;          // 双 buffer 乒乓 (A/B)
public float lodFadeValue;
public Matrix4x4 cullingMatrix;
```

**算法**:
1. 512×512 mask 覆盖以摄像机为中心的 64×64m 区域,每像素表示 0.125m × 0.125m;
2. 大型遮挡物(建筑 / 巨石)的 OBB 正交投影到 mask 上(`foliageoccluder.shader` 写 0/1);
3. 草地 instance 在 GPU Culling 阶段采样 mask:若被遮挡 → 剔除该 instance;
4. 双 mask 乒乓 `curMaskIsA` + 0.5s `OCCLUDER_FADE_TRANSITION_TIME` 渐入渐出避免边界突变。

### 14.3 数据流(以草地为例)

```
[Per Frame]
   Camera Position ──▶ HGFoliageOccluderManager 更新 cullingMatrix
                                 │
                                 ▼
       512×512 OccluderMask (大型物体写入)
                                 │
                                 │
   Collider transforms ──▶ FoliageInteractive Pass
                                 ▼
         textureSize Dual-Height RT (R=Bend, G=Recover)
                                 │
                  ┌──────────────┴───────────────┐
                  ▼                              ▼
            GPU Culling (剔 occluded)      Grass Vertex Shader
                  ▼                              ▼
           DrawIndirect Args              World-space sample
                                                 ↓
                                      草顶点根部位偏移 + 倾斜
```

---

## 15. 泥浆 / 墨水交互流体

### 15.1 Sludge (泥浆)

**源**: `HGSludgeConfig.cs:6-13` + `SludgePassConstructor.cs:14-22`

```csharp
public struct HGSludgeConfig
{
    public Vector2Int textureSize;
    public GraphicsFormat graphicsFormat;
    public static HGSludgeConfig defaultConfig => default;
}
```

`SludgePassConstructor` 维护一张顶视图变形场: 角色脚部碰撞写入泥浆 RT(`sludgev2.shader`),通过 `dynamicsludgeblit.shader` 在每帧做轻量 jump-flood 扩散,让脚印边缘自然外扩。地面材质(`hgterrainps.shader` 的泥浆变体)在世界空间采样该 RT,做法线偏移 + albedo 加深。

### 15.2 Ink (墨水) Simulation

**源**: `HGInkSimulationConfig.cs:7-58`

```csharp
public struct HGInkSimulationConfig : IEnvConfig
{
    [Range(0f, 1f)] public float influence;        // 全局强度
    public bool   disableWaterInk;                  // 水面是否参与
    public Material material;
}
```

构造默认值(`:43-56`)所有数值为 0,需 Volume Override 启用。

**算法**(`hginksimulation.shader` + `InkSimulationPassConstructor`):
1. 两张 ping-pong RG RT(R=墨浓度, G=湿润度);
2. 每帧 dispatch 一次扩散卷积(各向异性 Laplacian)+ 由水面 manager 注入新墨;
3. `disableWaterInk=true` 时跳过水交互层注入;
4. 墨纹理通过 `hgdecalinteraction.shader` 投影到地面 / 角色脚下作为 decal。

### 15.3 与水面交互的接口

水面 `WaterInteractionRenderingPass`(`ripplesimulate.shader` + `rippleheightconvert.shader`)同样维护波纹高度场:
- `WaterRippleBuffer`(全量报告 §4.2) → `litwater.shader` 顶点偏移与法线扰动;
- `wetnessdecal.shader` + `wetnesstrail.shader` 在地面写湿度 mask,被 GBuffer / Forward 中的湿表面光泽分支消费。

---

## 16. 数据流总览图

下图把上面 §3-§15 的主输出汇总到 DeferredLightingPass 的输入端:

```
[Pre-Render]
   BinningPass ──────▶ binningBuffer ──┐
   LightClustering ──▶ punctualIndices ┤
   GPUDrivenCulling ─▶ IndirectArgs    │
   ShadowMap ────────▶ ShadowResult    │
   CapsuleShadow ────▶ visibilitySHRT  │
   FogLut Bake ──────▶ _FogBakeLut     │
   VolumetricFog ────▶ VBufferA/B 3D   │
   Atmosphere LUTs ──▶ 4 张 LUT        │
                                       │
[Geometry]                             │
   GBuffer A/B/C/Depth ─────────────┐  │
   DecalPass 改写 A/B/C ────────────┤  │
   sceneMV                          │  │
                                    ▼  ▼
                                  ┌────────────────────────┐
[Lighting Inputs]                 │   DeferredLightingPass │
   GTAO ──────▶ indirectAO ─────▶ │   3 stage × 4 group:   │
   SSR ───────▶ ssrLighting   ──▶ │   Directional/Dynamic/ │
   SSR Fadeness ─────────────────▶│   Indirect/TileDraw    │
   ContactShadow ────────────────▶│                        │
   ScreenSpaceShadowMask ────────▶│                        │
   FakePlanarReflection ─────────▶│                        │
   waterWetnessMask ─────────────▶│                        │
   FogBakeLut ───────────────────▶│                        │
                                  └─────────┬──────────────┘
                                            ▼
                                        sceneColor
                                            │
[Post-Geometry]   ◀── Transparent ◀── VolumetricFog Compose
                                            │
                                            ▼
                                    DOF → MotionBlur → TAAU → LensFlare → UberPost
                                            │
                                            ▼
                                       FinalBlit
```

---

## 附录 A. 关键文件:行号速查表

| 算法 | 文件 | 行号区间 |
|------|------|---------|
| GBuffer 槽位枚举 | `GBufferID.cs` | 3-10 |
| GBufferOutput 容器 | `GBufferOutput.cs` | 7-23, 26, 75 |
| GBufferPass Input | `GBufferPassConstructor.cs` | 10-53 |
| ShadingModel 三态 | `HGDeferredShadingModel.cs` | 3-8 |
| BinningData | `BinningPass.cs` | 9-24, 31-43 |
| LightClustering 上限 | `LightClusteringPassConstructor.cs` | 88-118, 133, 147-153 |
| GTAO 常量 | `GTAOPassConstructor.cs` | 73-84, 86-90, 26-71 |
| SSR Input/Const | `HyperScreenSpaceReflectionRenderingPass.cs` | 11-49, 51-72, 74-143, 145-156 |
| DepthPyramid 实现 | `DepthPyramidRenderingPass.cs` | 18-22 |
| DepthPyramid 7级上限 | `DepthPyramidCustomMipsRenderingPass.cs` | 30 |
| TAAU 输入 | `TAAUPassConstructor.cs` | 9-60 |
| TAAU 常量 | `TAAUPassConstructor.cs` | 67-92 |
| TAAU Pass 枚举 | `TAAUPassConstructor.cs` | 142-149 |
| TAAU 高斯核 | `TAAUPassConstructor.cs` | 160-162, 2914 |
| DOF 6 阶段 | `DepthOfFieldPassConstructor.cs` | 10-18 |
| DOF Data | `DepthOfFieldPassConstructor.cs` | 125-138, 40-123 |
| DOF Type/Quality/Scale | `HGDepthOfFieldType.cs`, `HGDepthOfFieldQuality.cs`, `HGDepthOfFieldScale.cs` | 3-9 |
| 体积雾 Setting | `HGVolumetricFogRenderer.cs` | 9-42 |
| 体积雾 Const | `HGVolumetricFogRenderer.cs` | 44-76 |
| 体积雾 Grid 入口 | `HGVolumetricFogRenderer.cs` | 84 |
| 大气配置 | `HGAtmosphereConfig.cs` | 7-67 |
| 大气 LUT Const | `HGAtmosphereRenderer.cs` | 10-35, 37-51 |
| 大气 FogBakeLut | `HGAtmosphereRenderer.cs` | 47-49 |
| 体积云 Pass | `VolumetricCloudPassConstructor.cs` | 11-48 |
| 体积云 SDF | `VolumetricCloudSDF.cs` | 10-118 |
| CSM 常量 | `HGShadowManager.cs` | 312-366 |
| ShadowMap Input | `ShadowMapPassConstructor.cs` | 11-43 |
| Capsule Input | `CapsuleShadowPassConstructor.cs` | 11-103 |
| Contact Const | `ContactShadowPassConstructor.cs` | 11-89 |
| Foliage Interact 常量 | `HGFoliageInteractiveConfig.cs` | 6-22 |
| Foliage Occluder 常量 | `HGFoliageOccluderManager.cs` | 6-15 |
| Foliage Interact PassData | `FoliageInteractivePassConstructor.cs` | 11-56 |
| Sludge Config | `HGSludgeConfig.cs` | 6-13 |
| Ink Config | `HGInkSimulationConfig.cs` | 7-58 |

> 路径基底: `D:\Ruri\02.Unity\Project\AzureNihil\ReferenceProjects\RuriBeyond\HG.RenderPipelines.Runtime\HG\Rendering\Runtime\`
