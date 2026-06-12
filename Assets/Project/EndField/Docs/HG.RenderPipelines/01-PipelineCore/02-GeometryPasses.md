# HG Render Pipeline — Geometry Passes 结构分析与复刻实现文档

> 本文档基于 HG.RenderPipelines.Runtime 中 12 个几何管线 Pass Constructor 源码进行逆向结构分析，
> 目标为 Clean-Room 复刻实现提供数据结构、依赖关系、Pass 流程的精确参考。
>
> **注意**：所有源文件经过 IL2CPP/IFix 二进制补丁处理，方法体内为内联汇编而非 C# 逻辑。
> 本文档仅根据类定义、字段声明、方法签名、枚举值、PassData 结构布局等可观测元数据推断设计意图。

---

## 1. 管线 Pass 总览与执行顺序

```
Frame 执行顺序（从上到下）:

  1. DepthPrepass            — 场景深度预写 (Z-prepass)
  2. TerrainDepthPrepass     — 地形专用深度预写 (细分/曲面细分感知)
  3. GBufferPass             — 延迟渲染 GBuffer 填充 (MRT: A/B/C/Depth)
  4. DecalPass               — 延迟 Decal DBuffer 写入 + 侵蚀/污泥 Decal
  5. ForwardPass / ForwardOpaquePass / OnePassDeferredPass  (三选一, 互斥)
       ├─ ForwardPass          — 前向渲染 (不透明+透明合并)
       ├─ ForwardOpaquePass    — 仅不透明前向 (无透明, 使用 terrainDepthBuffer)
       └─ OnePassDeferredPass  — 合并延迟着色 (GBuffer写+光照+Decal 单Pass)
  6. TransparentPass         — 前向透明 (读取 GBuffer 用于透明光照混合)
  7. TransparentAfterDOFPass — DOF 之后的透明 (无 GBuffer, 无 VRS, 无 Water 合成)
```

**关键依赖关系**:
- `DepthPrepass` → `GBufferPass` 依赖 sceneDepth 输入
- `GBufferPass` → `DecalPass` 依赖 GBuffer A/B/C + Depth 作为输入
- `DecalPass` → `Forward/OnePassDeferred` 依赖 Decal 修改后的 GBuffer
- `ForwardOpaquePass` 额外依赖 `terrainDepthBuffer` 用于地形遮挡 (区别于 ForwardPass)
- `TransparentPass` 依赖 `gBufferOutput` + `WaterOnePassDeferredRenderingPass` 输出
- `TransparentAfterDOFPass` 不依赖任何 GBuffer/Water/VRS (最后阶段)

---

## 2. GBuffer 布局

### 2.1 GBufferID 枚举

**文件**: `GBufferID.cs`

```csharp
public enum GBufferID : byte
{
    GBufferA    = 0,  // Normal (world space) + 预留通道
    GBufferB    = 1,  // Albedo (RGB) + Ambient Occlusion (A)
    GBufferC    = 2,  // Metallic (R) + Roughness (G) + Emissive (B) + 预留 (A)
    GBufferDepth = 3,  // 深度缓冲区
    Count       = 4
}
```

> 注: `GBufferID` 仅定义 4 个槽位，与标准 Unity Deferred 的 4-MRT 方案对齐。
> GBufferA 具体通道布局需从对应 .hlsl 文件中确认，此处为基于标准延迟渲染惯例的推断。

### 2.2 GBufferOutput 包装器

**文件**: `GBufferOutput.cs`

```csharp
public struct GBufferOutput
{
    private NativeArray<TextureHandle> m_gbufferAttachments;  // [GBufferA..Count-1]
    private NativeArray<int>            m_gbufferMapping;      // TextureHandle → slot 映射表

    public TextureHandle GetGBufferAttachment(GBufferID id)
        => m_gbufferAttachments[m_gbufferMapping[(int)id]];
}
```

设计要点:
- 通过 `m_gbufferMapping` 间接映射，支持运行时重新绑定 MRT 槽位顺序
- NativeArray 托管，飞指令 (Burst) 友好
- 外部通过 `GetGBufferAttachment(GBufferID)` 访问，无需关心物理槽位

---

## 3. Pass 逐项分析

### 3.1 DepthPrepassConstructor

**文件**: `DepthPrepassConstructor.cs`

**类签名**:
```csharp
internal class DepthPrepassConstructor : IPassConstructor
```

**PassInput** (结构体):
```
sceneColor        (TextureHandle)  — 场景颜色目标 (可能为空, 仅深度时跳过)
sceneDepth        (TextureHandle)  — 场景深度目标 (主输出)
```

**PassOutput** (结构体 — Size=1, 空):
```
(无显式输出 — 直接写入 sceneDepth)
```

**DepthPrepassData**:
```
m_depthPrepassData (一些数据)
```

**RenderFunc 静态方法**:
```csharp
private static void RenderFunc(DepthPrepassData data, RenderGraphContext rgContext)
```

**行为推断**:
- 遍历 `deferredOpaque` / `deferredOpaqueEqual` 等 ECS 列表中的所有渲染器
- 写入 `sceneDepth`，不写颜色 (可配置是否同时写 sceneColor)
- 为后续 GBufferPass 和 DecalPass 提供深度

### 3.2 TerrainDepthPrepassConstructor

**文件**: `TerrainDepthPrepassConstructor.cs`

**类签名**:
```csharp
internal class TerrainDepthPrepassConstructor : IPassConstructor
```

**特殊数据**:
```
TerrainSubdivisionData    — 地形细分/曲面细分参数
TerrainDepthPrepassData   — Pass 运行时数据
```

**PassInput**:
```
terrainDepthBuffer   (TextureHandle)  — 独立的地形深度缓冲区
sceneDepth           (TextureHandle)  — 场景深度 (仅读取, 写入非地形区域)
```

**行为推断**:
- 处理包含地形曲面细分的渲染器 (tessellation/subdivision flags)
- 写入独立的 `terrainDepthBuffer` (不覆盖 sceneDepth)
- 后续 `ForwardOpaquePassConstructor` 读取此 buffer

### 3.3 GBufferPassConstructor

**文件**: `GBufferPassConstructor.cs`

**类签名**:
```csharp
internal class GBufferPassConstructor : IPassConstructor
```

**GBufferPassData**:
```
m_virtualTextureFeedback      (VirtualTextureFeedback 句柄)
m_terrainCullViewHandle       (编辑器地形裁剪视图句柄)
```

**ECS 列表** (5 组):
```
deferredOpaque              — 不透明延迟渲染器
deferredOpaqueEqual         — 深度相等测试的延迟渲染器 (Z-test equal)
deferredGrass              — 草地延迟渲染器
deferredSludge             — 污泥延迟渲染器
characterPrePass / characterOutlinePrePass — 角色预Pass + 轮廓预Pass
```

**GPU Driven 列表** (2 组):
```
gpuDrivenOpaqueLists       — GPU Driven 不透明列表
gpuDrivenGrassLists        — GPU Driven 草地列表 (可能是 indirect draw)
```

**MRT 输出**: GBuffer A/B/C + Depth

**行为推断**:
- 对每个渲染器执行片元着色器，填充 MRT 到 4 个 GBuffer 目标
- VT (Virtual Texture) Feedback 用于流送
- 地形裁剪句柄用于编辑器 Debug 视图

### 3.4 DecalPassConstructor

**文件**: `DecalPassConstructor.cs`

**类签名**:
```csharp
internal class DecalPassConstructor : IPassConstructor
```

**DecalPassData**:
```
screenNormalCopied    (TextureHandle)  — 从 GBufferA 拷贝的法线
sceneDepthCopied      (TextureHandle)  — 从 Depth Buffer 拷贝的深度
```

**ECS 列表**:
```
deferredDecal          — 标准延迟 Decal
deferredErosion        — 侵蚀 Decal
deferredSludge         — 污泥 Decal
```

**编辑器相关**:
```
editorTerrainCullViewHandle  — 地形裁剪视图
terrainTessellation          — 地形曲面细分标志
wetRippleFlag                — 水面涟漪/湿润标志
```

**行为推断**:
- 从 `screenNormalCopied` + `sceneDepthCopied` 重建世界空间位置
- 逐 Decal Volume 写入 DBuffer (Decal Buffer)
- DBuffer 通常包含: Albedo, Normal, 金属度/粗糙度, MaterialFlags
- 后续 Pass (Forward/OnePassDeferred) 在光照计算时混入 DBuffer 数据
- 侵蚀 + 污泥是 HG 自定义的 Decal 类型，区别于标准 DBuffer

### 3.5 ForwardPassConstructor

**文件**: `ForwardPassConstructor.cs`

**类签名**:
```csharp
internal class ForwardPassConstructor : IPassConstructor
```

**PassInput**:
```
sceneColor          (TextureHandle)  — 场景颜色 (读写)
sceneDepth          (TextureHandle)  — 场景深度 (读写)
shadowResult        (TextureHandle)  — 阴影贴图结果
bakedLightingConfig (BakedLightingConfig) — 烘焙光照配置 (Lightmap/Probe)
characterOutlineEnabled (bool)       — 角色描边开关
```

**ECS 列表** (同时处理不透明和透明):
```
forwardOpaque                — 前向不透明渲染器
forwardOpaqueEqual          — 前向不透明 (Z-test equal)
characterOpaque              — 角色不透明
characterOutlineOpaque      — 角色描边不透明
forwardTransparent          — 前向透明
forwardOccludedDisplay      — 被遮挡对象显示 (编辑/X光模式)
```

**行为推断**:
- 单 RenderFunc 同时处理 Opaque + Transparent
- 使用 Unity 前向渲染路径 (逐物体光照)
- 支持角色描边 (outline 光照模型)
- 被遮挡对象显示用于编辑器或特殊效果

### 3.6 ForwardOpaquePassConstructor

**文件**: `ForwardOpaquePassConstructor.cs`

**类签名**:
```csharp
internal class ForwardOpaquePassConstructor : IPassConstructor
```

**与 ForwardPass 的区别**:

| 项目 | ForwardPass | ForwardOpaquePass |
|------|-------------|-------------------|
| 透明渲染器 | 包含 `forwardTransparent` | 无透明列表 |
| terrainDepthBuffer | 不使用 | 输入 (用于地形深度测试) |
| sceneMV | 不使用 | 输入 (运动矢量) |
| 角色描边 | `characterOutlineOpaque` | 同 |
| UBO | 默认 | 额外 `ShaderVariablesGlobal` |

**行为推断**:
- 仅处理不透明物体，无透明通道
- 使用 `terrainDepthBuffer` 进行地形遮挡优化 (不透明物体在地形后裁剪)
- `sceneMV` 用于 TAA 运动矢量

### 3.7 TransparentPassConstructor

**文件**: `TransparentPassConstructor.cs`

**类签名**:
```csharp
internal class TransparentPassConstructor : IPassConstructor
```

**PassInput**:
```
sceneColor              (TextureHandle) — 场景颜色 (读写混合)
sceneDepth              (TextureHandle) — 场景深度
gBufferOutput           (TextureHandle) — 延迟光照结果 (用于透明混合的光照)
gBufferProfileConfig    (GBufferProfileConfig)
WaterOnePassDeferredRenderingPass (TextureHandle) — 水面延迟渲染结果
transparentVRS          (TextureHandle) — 透明区域 VRS 贴图
transparentVRRx         (int)           — VRS tile 宽度
transparentVRRy         (int)           — VRS tile 高度
lowResRendering         (bool)          — 低分辨率渲染标志
BasicTransformConstants (CBUFFER)       — 变换常量缓冲区
ShaderVariablesGlobal   (CBUFFER)       — 全局着色器变量
```

**内部使用**:
`ForwardPassUtils.ForwardTransparentPassData` — 工具类生成的 Pass Data

**行为推断**:
- 读取 `gBufferOutput` 中延迟光照结果，用于透明混合的光照计算
- `WaterOnePassDeferredRenderingPass` 提供水面延迟光照结果，透明物体需与水面正确混合
- VRS (Variable Rate Shading) 支持: `transparentVRS` 贴图控制透明区域的着色率
- `lowResRendering=true` 时，透明在低分辨率渲染并上采样

### 3.8 TransparentAfterDOFPassConstructor

**文件**: `TransparentAfterDOFPassConstructor.cs`

**类签名**:
```csharp
internal class TransparentAfterDOFPassConstructor : IPassConstructor
```

**PassInput** (简化版):
```
sceneColor  (TextureHandle) — 场景颜色
sceneDepth  (TextureHandle) — 场景深度
```

**内部使用**:
`ForwardPassUtils.ForwardTransparentAfterDOFPassData`

**与 TransparentPass 的区别**:

| 项目 | TransparentPass | TransparentAfterDOFPass |
|------|----------------|------------------------|
| GBuffer 输入 | `gBufferOutput` | 无 |
| 水面合成 | `WaterOnePassDeferredRenderingPass` | 无 |
| VRS | 完整 VRS 支持 | 无 |
| lowResRendering | 支持 | 不支持 |
| UBO | `BasicTransformConstants` + `ShaderVariablesGlobal` | 无 (或最小) |
| 执行位置 | DepthPrepass/GBuffer/Decal 之后 | DOF PostProcess 之后 |

**行为推断**:
- 最后阶段的透明物体 (如 UI 面板粒子、DOF 无关的透明特效)
- 不读取 GBuffer，不参与延迟光照混合
- 无 VRS 优化，全分辨率渲染
- 无水面合成

### 3.9 OnePassDeferredPassConstructor

**文件**: `OnePassDeferredPassConstructor.cs`

> 最大源文件 (~105KB raw)，高密度混淆。方法体无法直接读取，PassInput + 枚举 + 两阶段构建是可观测的骨架。

**类签名**:
```csharp
internal class OnePassDeferredPassConstructor : IPassConstructor
```

**PassInput**:
```
GBufferA / GBufferB / GBufferC / GBufferDepth  (全部 4 张 GBuffer 贴图)
planarReflection          (TextureHandle) — 平面反射贴图
ssrLighting               (TextureHandle) — SSR 光照结果
fogBakeLut                (TextureHandle) — 雾烘焙 LUT
lightCullResult           (LightCullResult) — 光源裁剪结果
lightList                 (光照列表)
```

**ECS 列表** (约 16 组):
```
deferredOpaque / deferredGrass / deferredSludge / ...
decal / erosion / mobileDecal / mobileErosion
characterPrePass / characterOutlinePrePass
gpuDrivenOpaque/gpuDrivenGrass  (GPU Driven)
```

**OnePassDeferredSubpass 枚举** (7 个子阶段):
```csharp
PreDepth          = 0   // 深度预写
GBuffer           = 1   // GBuffer MRT 填充
Decal             = 2   // Decal DBuffer 写入
PostGBuffer       = 3   // GBuffer 后处理 (可选)
DeferredLighting  = 4   // 延迟光照计算
ForwardOpaque     = 5   // 前向不透明补漏
ForwardTransparent = 6  // 前向透明混合
```

**两阶段构建**:
```
_ConstructPassPhase0 — 构建渲染器列表 + 配置 RenderGraph Builder
  参数: HGRenderGraph, HGResourceBuilder, HGCullingResult, CameraData
  返回值: (RendererList 句柄, 输入输出资源, lightCullResult, decalData, etc.)
  功能:
    - 创建 GBuffer MRT 资源 (4 个 TextureHandle)
    - 创建/分配 DBuffer
    - 构建 16+ 个 RendererList 对象
    - 返回 Phase1 所需的所有中间数据

_ConstructPassPhase1 — 配置 Shader Pass 参数
  参数: Phase0 的输出 + HGRenderGraph + HGResourceBuilder
  功能:
    - 设置每个 Subpass 的 shader pass 名称
    - 绑定输入/输出资源到 Subpass 槽位
    - 配置 GBuffer 写入/Decal 读取/光照计算所需的纹理绑定
```

**合并写入优化**:
- 传统 Deferred: GBufferPass → DecalPass → DeferredLighting (3 Pass, 读回 GBuffer 写回 RT)
- OnePassDeferred: 在一个 `NativeRenderPass` 内通过 Subpass 串行执行 7 个子阶段
- GBuffer MRT 写入在 Subpass=1 完成，Subpass=2 读取 GBuffer 做 Decal，Subpass=4 做光照
- 所有数据在 Tile Data (TBDR) 或 on-chip SRAM 中流转，无需读回到系统内存
- 极大降低显存带宽消耗，尤其适合移动端 TBDR GPU

---

## 4. HGDeferredShadingModel

**文件**: `HGDeferredShadingModel.cs`

```csharp
public enum HGDeferredShadingModel : uint
{
    SHADING_MODEL_DEFAULT_LIT      = 0,  // 默认 PBR (Cook-Torrance GGX)
    SHADING_MODEL_TWO_SIDED_FOLIAGE = 1,  // 双面植被 (透光叶面)
    SHADING_MODEL_SUBSURFACE        = 2,  // 次表面散射 (蜡/皮肤/玉)
}
```

每个 ShadingModel 对应独立的 BRDF 函数集合:
- **DefaultLit**: 标准 GGX 法线分布 + Smith 几何遮挡 + Schlick Fresnel
- **TwoSidedFoliage**: 薄叶面正向/反向两次光照，透射 (Transmittance) 吸收
- **Subsurface**: 扩散轮廓近似 (可参量化散射), 与厚度贴图配合

> 注：具体 BRDF 公式参数（粗糙度重映射、Fresnel 反射率、次表面扩散宽度）
> 需从对应 .hlsl 着色器中提取，C# 层面不可见。

---

## 5. Pass 数据流依赖图

```
                             sceneColor / sceneDepth (初始)
                                  │
                  ┌───────────────┴───────────────┐
                  │  DepthPrepassConstructor       │
                  │  (写入 sceneDepth)              │
                  └───────────────┬───────────────┘
                                  │
                  ┌───────────────┴───────────────┐
                  │  TerrainDepthPrepassConstructor│
                  │  (写入 terrainDepthBuffer)     │
                  └───────────────┬───────────────┘
                                  │
                  ┌───────────────┴───────────────┐
                  │  GBufferPassConstructor        │
                  │  (写入 GBufferA/B/C + Depth)   │
                  └───────────────┬───────────────┘
                                  │
                  ┌───────────────┴───────────────┐
                  │  DecalPassConstructor          │
                  │  (DBuffer: 读取 GBuffer)       │
                  └───────────────┬───────────────┘
                                  │
         ┌────────────────────────┼────────────────────────┐
         │                        │                        │
   ┌─────┴─────┐          ┌──────┴──────┐          ┌──────┴──────┐
   │ForwardPass│          │ForwardOpaque│          │OnePassDefer-│
   │Constructor│          │ Constructor │          │redConstructor│
   │(Opaque+   │          │(仅 Opaque)  │          │(7 Subpasses) │
   │Transparent│          │+terrainDepth│          │ 合并: GBuffer│
   │ )         │          │ +sceneMV    │          │ +Decal+Light │
   └───────────┘          └─────────────┘          └──────────────┘
         │                        │                        │
         └────────────┬───────────┘                        │
                      │                                    │
         ┌────────────┴────────────┐                       │
         │  TransparentPass         │                      │
         │  (GBuffer+Water+VRS)     │                      │
         └────────────┬────────────┘                       │
                      │                                    │
         ┌────────────┴────────────┐                       │
         │  TransparentAfterDOF    │                       │
         │  (无 GBuffer/VRS/Water) │                       │
         └────────────┬────────────┘                       │
                      │                                    │
                  sceneColor (最终输出)
```

---

## 6. 各 Pass 输入/输出汇总表

| Pass | 主要输入 | 主要输出 | 渲染目标数 | 渲染列表数 |
|------|---------|---------|-----------|-----------|
| DepthPrepass | sceneColor(opt) | sceneDepth | 0-1 RT | ~5 |
| TerrainDepthPrepass | sceneDepth | terrainDepthBuffer | 1 RT | 地形相关 |
| GBufferPass | sceneDepth | GBuffer A/B/C/D | 4 MRT | ~7 |
| DecalPass | GBuffer A/B + Depth | DBuffer (隐式) | ~3 DBuffer | ~3 |
| ForwardPass | sceneColor, sceneDepth, shadowResult | sceneColor, sceneDepth | 1 RT | ~6 |
| ForwardOpaquePass | + terrainDepthBuffer, sceneMV | sceneColor, sceneDepth | 1 RT | ~5 (无透明) |
| OnePassDeferred | GBuffer A/B/C/D, LightCull | sceneColor | 7 Subpass | ~16 |
| TransparentPass | + gBufferOutput, Water, VRS | sceneColor | 1 RT | ~3 (透明) |
| TransparentAfterDOF | sceneColor, sceneDepth | sceneColor | 1 RT | ~3 (透明) |

---

## 7. 1:1 复刻实现要点

### 7.1 可直接复刻的结构 (无混淆逻辑)

| 模块 | 复刻方式 | 难度 |
|------|---------|------|
| IPassConstructor 接口 | 定义相同接口及 Register/Execute 契约 | ★☆☆ |
| GBufferID 枚举 | 直接复制 | ★☆☆ |
| GBufferOutput 结构 | 实现 NativeArray 包装 + m_gbufferMapping 间接映射 | ★☆☆ |
| PassInput / PassOutput 结构体 | 按字段定义结构体即可，不含逻辑 | ★☆☆ |
| OnePassDeferredSubpass 枚举 | 7 个子阶段定义 | ★☆☆ |
| HGDeferredShadingModel 枚举 | 3 种光照模型定义 | ★☆☆ |
| Pass 执行顺序 (Phase Ordering) | 按依赖图编排 RenderGraph 节点 | ★★☆ |
| ForwardPassUtils 工具类 | 需要自定义实现 (逻辑已混淆) | ★★★ |
| ECS 渲染器列表分组策略 | deferred/forward/character/grass/sludge 分组 | ★★☆ |

### 7.2 需要独立重写的模块 (逻辑在混淆代码中)

| 模块 | 复刻策略 | 难度 |
|------|---------|------|
| DepthPrepass RenderFunc | 标准 Z-prepass shader 实现 | ★★★ |
| GBuffer MRT 填充 Shader | 需独立实现 GBuffer 通道打包逻辑 | ★★★★ |
| Decal DBuffer 写入 Shader | 标准 DBuffer 实现 + 侵蚀/污泥膨胀扩展 | ★★★★ |
| Forward shading 逐物体光照 | 标准 PBR forward 光照 pipeline | ★★★ |
| OnePassDeferred Subpass 串联 | TBDR 友好的 NativeRenderPass Subpass 编排 | ★★★★★ |
| VRS (Variable Rate Shading) | Tier 2 VRS 贴图生成 + Shader 读取优化 | ★★★★ |
| 地形细分/曲面细分深度写入 | 细分着色器 + 深度输出 | ★★★★ |
| 角色描边 (Outline) | 法线扩张 + 深度测试描边 | ★★★ |
| 低分辨率透明渲染 | 半分辨率 + 双线性上采样 + 深度测试 | ★★★ |
| Transparent VRS 区域分析 | 计算透明区域密度生成 VRS 贴图 | ★★★★ |

### 7.3 GBuffer 打包格式 (需从 .hlsl 确认)

基于标准延迟渲染惯例的推测 (需通过 .hlsl 确认):

```
GBufferA (RGBA8 UNORM):
  R: Normal X
  G: Normal Y
  B: Normal Z (encode)
  A: 预留 / 遮挡

GBufferB (RGBA8 UNORM/SRGB):
  R: Albedo R
  G: Albedo G
  B: Albedo B
  A: Ambient Occlusion

GBufferC (RGBA8 UNORM):
  R: Metallic
  G: Roughness
  B: Emissive intensity / Subsurface mask
  A: 预留 / MaterialFlags / ShadingModelID
```

> **重要**: 以上通道布局为基于标准 Unity URP/HDRP 延迟管线的推断。
> 必须在确认 `GBuffer_*.hlsl` 或 `HGDeferredShading_*.hlsl` 打包函数后修正。

### 7.4 性能与架构关键决策

1. **GBufferOutput 间接映射**: 允许运行时切换 MRT 顺序，不必重新编译 shader
2. **OnePassDeferred Subpass 合并**: 将 3 次 RT 读写合并为 1 次 TBDR tile pass，对移动端 Mali/Adreno TBDR 架构极为有利
3. **Forward vs ForwardOpaque 分离**: ForwardOpaque 使用 terrainDepthBuffer + sceneMV，减少地形过绘制 + 支持 TAA — Forward 合并渲染则为兼容无地形场景
4. **Transparent VRS**: 透明区域 VRS 贴图降低透明混合区域的着色率 (VRS tier 2)，在不明显降低画质前提下提升性能
5. **Decal 侵蚀/污泥**: HG 自定义 Decal 类型，相比于标准 DBuffer 增加随时间变化的侵蚀遮罩和污泥湿润效果
6. **双面植被光照模型**: `SHADING_MODEL_TWO_SIDED_FOLIAGE` 使用透射模型模拟叶面背光透射 (subsurface scattering 的降级方案)
7. **角色描边管线**: 在多个 Pass 中存在 `characterOutline` 列表，表明描边与主渲染并行 (非传统后处理描边)，通过独立的 outline material 通道实现

---

## 8. 附录：源文件清单

| # | 文件名 | 大小(估计) | 关键可观测信息 |
|---|--------|-----------|--------------|
| 1 | `DepthPrepassConstructor.cs` | 中 | PassInput/PassOutput/DepthPrepassData |
| 2 | `TerrainDepthPrepassConstructor.cs` | 中 | TerrainSubdivisionData, tessellation flags |
| 3 | `GBufferPassConstructor.cs` | 大 | ~7 ECS list 定义, VT feedback, terrainCullView |
| 4 | `GBufferOutput.cs` | 小 | NativeArray-backed wrapper, mapping indirection |
| 5 | `GBufferID.cs` | 很小 | 4-value enum |
| 6 | `DecalPassConstructor.cs` | 大 | decal/erosion/sludge lists, DBuffer tex refs |
| 7 | `ForwardPassConstructor.cs` | 大 | 6 ECS groups, shadowResult, bakedLighting |
| 8 | `ForwardOpaquePassConstructor.cs` | 中 | terrainDepthBuffer, sceneMV inputs |
| 9 | `TransparentPassConstructor.cs` | 中 | GBuffer/Water/VRS inputs |
| 10 | `TransparentAfterDOFPassConstructor.cs` | 中 | 简化版 (无 GBuffer/VRS/Water) |
| 11 | `OnePassDeferredPassConstructor.cs` | 很大 (~105KB) | ~16 ECS lists, Phase0/Phase1, 7 Subpass enum |
| 12 | `HGDeferredShadingModel.cs` | 很小 | 3-value shading model enum |

---

> **文档状态**: 初稿完成
> **待补充**:
> - [ ] GBuffer .hlsl 通道打包函数 (确认 A/B/C 布局)
> - [ ] DBuffer .hlsl 结构体定义 (确定 decal 数据格式)
> - [ ] BRDF .hlsl 函数 (DefaultLit/TwoSidedFoliage/Subsurface 实现)
> - [ ] Transparent VRS 贴图生成算法 (compute shader 或 rasterizer)
> - [ ] ForwardPassUtils 的 ForwardTransparentPassData 结构 (已混淆)
