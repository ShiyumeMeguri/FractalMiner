# 11-07 · 阴影系统（ASM 虚拟阴影贴图 / 级联 / 接触 / 屏幕空间 / 胶囊）实现原理蓝图

> 本文是 HG.RenderPipelines（EndField/终末地）**阴影 1+3 体系** 的 1:1 重建蓝图：CSM 级联 +
> **HG 自研 ASM（Adaptive/Virtual Shadow Map，自适应虚拟阴影贴图）远场补阴影** +
> Contact Shadow（接触阴影屏空 ray-march） + Screen-Space Shadow Mask（解析合成）+
> Capsule Shadow（胶囊角色软阴影）。HDRP 血缘部分（CSM/PCSS/PCF/Contact）**原理与公式照抄
> HDRP `75de48326bcd` 同源源码 `文件:行`** 并标 delta；HG 自研部分（ASM 虚拟纹理 + 256 tile
> 流式 atlas、HG 内联调色与位深、低分辨率定向阴影路径、胶囊阴影 Visibility-SH 解析）按反编译
> 调用图、常量、字段布局 + 阴影领域知识 1:1 重建。

---

## 目录

1. 系统定位与最终视觉效果
2. 顶层架构与阴影预算（数据契约）
3. 4 阶段流水线时序（CSM Cull → ASM Stream → ASM Render → SSShadowMask）
4. HDRP 血缘：CSM 4 级联 + Cascade Sphere Blend
5. HDRP 血缘：PCF Tent 与 PCSS Directional / Punctual
6. HG 自研：ASMTile 虚拟阴影贴图（核心算法）
   - 6.1 Tile = 光空间矩形 + Refinement Level
   - 6.2 Frustum-XZ 投影 → tile 生成
   - 6.3 视野相交（SAT 8 轴）+ 远场距离剔除
   - 6.4 评分 + LRU 16×16 VT 槽分配 + 256 tile 预算
   - 6.5 Atlas UV 矩阵打包到 ConstantBuffer
7. HDRP 血缘：Contact Shadow（屏空 ray-march）+ HG 接触阴影 ScreenSpaceShadowMaskPassConstructor
8. HG 自研：低分辨率方向阴影通道（HGLowResDirectionalShadowPass）
9. HG 自研：Capsule Shadow（Visibility-SH 解析积分）
10. 关键常量 / 魔数 / 容量
11. 1:1 复刻蓝图（重建步骤清单）
12. 支撑证据（结构 / 字段表 + 源文件清单）

---

## 1. 系统定位与最终视觉效果

阴影是开放世界 + 风格化角色游戏的视觉瓶颈：

1. **近景** 需要清晰柔边 → **CSM 4 级联** + **PCF/PCSS** 采样；
2. **远景** 角色脚下不能漏阴影、又不能让 CSM 第四级吃满帧 → **HG 自研 ASM 虚拟阴影贴图**
   只为视锥地面投影的 *少量* tile 渲染浅深度图，流式驻留在 atlas；
3. **角色脚部 / 角色彼此遮蔽** 在阴影贴图视角下采不到 → **Capsule Shadow** 走解析球积分；
4. **微观接触感**（脚踩地面、墙角阴影）阴影贴图分辨率不够 → **Contact Shadow** 在屏空对深度
   做 ray-march；
5. **整张屏幕** 把直射光阴影解算成单通道 mask → **ScreenSpaceShadowMask Resolve**，后续 Light
   Loop 直接读 mask。

HG 的两块**自研** delta：
- **ASM tile 虚拟纹理**：HDRP 没有，类似 UE5 VSM/Clipmap Shadow 的简化版（16×16 tile slot ×
  LRU 复用，最大 256 tile/atlas，按 frustum 评分动态分配）。
- **HGLowResDirectionalShadowPass**：用 `0.25×` 分辨率做一遍方向光 mask + Gaussian Blur，再
  在 Resolve pass 上采样，配合 GBuffer 法线/深度恢复柔阴影，**为移动端省 PCSS 64 tap**。

---

## 2. 顶层架构与阴影预算（数据契约）

GPU 端有**一个**巨型 ConstantBuffer，分四段（来自
`HGShadowConstantBufferUtils.HGShadowConstantBufferData`，
`HGShadowConstantBufferUtils.cs:16-72`）：

| 段 | 字段 | float 总数 | 物理意义 |
|---|---|---|---|
| CSM | `_CSMWorldToShadow[80]` + `_CSMShadowSplitSpheres[16]` + `_CSMShadowBiases[16]` + `_CSMShadowAtlasParams[16]` + 4×Vector4 | 80+16+16+16+16 | 4 级联（每级 5×4=20 float 的 4×4，因为前一行存元信息）+ 4 球 + bias + 整图常量 |
| Punctual | `_PunctualLightWorldToShadow[896]` + `_PunctualLightShadowParams[224]+[224]` | 896+448+4 | 最多 **56 灯**，每灯 1 矩阵 + 4 param vec |
| Character | `_CharacterWorldToShadow[240]` + `_CharacterShadowBiases[60]` + `_CharacterShadowLightDir[60]` + atlas params | 240+60+60+60+8 | 最多 **15 角色**专用 shadow map |
| ASM | `_ASMWorldToShadowBaseMatrix(16)` + `_ASMIndirectWorldToShadow(16)` + 3×Vector4 + `_ASMIndirectParams[512]` | 16+16+12+512 | 1 全图变换 + 1 间接全图变换 + **256 tile × 2 Vector4 索引/UV 参数** |

容量上限（`HGShadowConstantBufferUtils.cs:73-83`）：
- `MAX_CASCADE_COUNT = 4`
- `MAX_PUNCTUAL_LIGHT_SHADOW_CASTER_COUNT = 56`
- `MAX_CHARACTER_SHADOWMAP_COUNT = 15`
- `ASM_TILE_COUNT = 256`
- `FLOAT_COUNT_IN_MATRIX = 16`，`FLOAT_COUNT_IN_VECTOR = 4`

总结：**整个阴影 CB 内联打包**（单次绑定），shader 通过段偏移
`csmSectionOffset / punctualLightShadowSectionOffset / characterShadowSectionOffset /
asmShadowSectionOffset` 取数据（CB 段化是 HG 工程化特化，HDRP 用多个 cbuffer + structured
buffer，见 `HDShadowManager.cs:616-628`）。

---

## 3. 4 阶段流水线时序

```
帧 N (CPU + GPU)：

CPU 准备 (HGASMManager.cs + HGShadowManager.cs)
 ├─ 1. ASMTileManager.CreateTilesThisFrame(center, radius, gridSize)
 │      在光空间 XY 平面以 gridSize 步长生成候选 tile（refinement level 一致），
 │      落在 [center-radius, center+radius] AABB 里。
 ├─ 2. ASMTileManager.UpdateCachedTiles(center, radius)
 │      用 frustumVerts 5-点（光空间投影 4 角 + 相机）做相交剔除，
 │      lru evict 远端 tile，命中 tile 标 isVisible=true。
 ├─ 3. HGASMVirtualTextureAllocator.AllocateTile / VisitTilesThisFrame
 │      给可见 tile 分 VT index ∈[0..255]，更新 LRU Visit 时序。
 ├─ 4. CSM ExtractDirectionalLightData (HGShadowUtils.cs:153)
 │      调 CullingResults.ComputeDirectionalShadowMatricesAndCullingPrimitives
 │      生成 view/proj/splitData × 4 级联。
 └─ 5. HGCapsuleShadowManager.FrameSetup(cullingResults, ...)
        遍历 HGCapsuleShadows.capsuleShadowHelpers，扁平化到 4×NativeArray<Vector4>
        (最大 256 胶囊)。

GPU pass (HGRenderGraph)
 ├─ ASMShadowPass × N (asmMaxTileRenderCountPerFrame, 默认有 budget)
 │   每 tile 一次：清屏 + 渲染 (clearShadowMaterial + rendererList + ecsRendererList)
 │   写入 m_asmShadowMapRT 的对应 tile viewport。
 ├─ CSM ShadowPass × cascadeCount
 │   每级联渲染到方向光 atlas (HDRP 同源)。
 ├─ Character ShadowPass × characterShadowCount (≤15)
 ├─ ContactShadowPass (RayTracingV2 kernel, 64 thread/group)
 │   逐像素屏空 ray-march 出 uint mask 写 _ContactShadowTextureUAV。
 ├─ CapsuleShadow VisibilitySHPass
 │   球体 mesh 实例化绘制写 visibilitySHRT（R/G 通道存 SH 系数）。
 └─ ScreenSpaceShadowResolvePass
     合成 CSM + ASM + Contact + Capsule + LowRes 成单通道 mask。
```

---

## 4. HDRP 血缘：CSM 4 级联 + Cascade Sphere Blend

### 4.1 Cull split 提取

HG 直接调 Unity 原生
`CullingResults.ComputeDirectionalShadowMatricesAndCullingPrimitives`（`HGShadowUtils.cs:184-200`
`call sub_18036E950`，以及 `set_shadowCascadeBlendCullingFactor` 调用见 191-195 行）。每级
联返回：

- `view`、`projection`、`deviceProjectionYFlipMatrix`
- `ShadowSplitData.cullingSphere` (xyz=中心，w=半径²)
- `cascadeBorders[i]`（每级末端 blend border 比例）

`CascadePartitionSplitParameter`（`CascadePartitionSplitParameter.cs`）和
`CascadeEndBorderParameter`（`CascadeEndBorderParameter.cs`）是
`VolumeParameter<float>` 派生，serializable 暴露在 `HGShadowSettings`，CPU 端 dispatch 前把它
们 ratio 化送进 `cascadeRatios[]` 参数 → 传给 Unity 原生 cull API。

### 4.2 GPU 端 split 决策（HDRP 1:1）

`HDShadowAlgorithms.hlsl:212-256`：

```hlsl
int EvalShadow_GetSplitIndex(HDShadowContext shadowContext, int index, float3 positionWS,
                              out float alpha, out int cascadeCount)
{
    int shadowSplitIndex = -1; float relDistance = 0.0; float3 wposDir = 0, splitSphere;
    HDDirectionalShadowData dsd = shadowContext.directionalShadowData;
    for (uint i = 0; i < _CascadeShadowCount; i++)
    {
        float4 sphere = dsd.sphereCascades[i];
        wposDir = -sphere.xyz + positionWS;
        float distSq = dot(wposDir, wposDir);
        relDistance = distSq / sphere.w;
        if (relDistance > 0.0 && relDistance <= 1.0)
        { splitSphere = sphere.xyz; wposDir /= sqrt(distSq); shadowSplitIndex = i; break; }
    }
    cascadeCount = dsd.cascadeDirection.w;
    float border = dsd.cascadeBorders[shadowSplitIndex];
    alpha = border <= 0.0 ? 0.0 : saturate((relDistance - (1.0 - border)) / border);
    // 视方向方向反向时 sharp 收敛到 0：避免 cascade 球后侧出 transition seam
    float3 viewDir = GetWorldSpaceViewDir(positionWS);
    float cascDot = dot(viewDir, wposDir);
    float lerpSharpness = 8.0f + 512.0f * smoothstep(1.0f, 0.7f, border);
    alpha = lerp(alpha, 0.0, saturate(cascDot * lerpSharpness));
    return shadowSplitIndex;
}
```

公式照抄。**HG 与 HDRP 同**：球距离平方/半径平方 ≤ 1 命中级联；末端 `border` 比例做 blend；
`lerpSharpness = 8 + 512·smoothstep(1,0.7,border)`（HDRP 原值）抑制 transition seam 的 hack
照抄。

### 4.3 HG delta

- HDRP `HDDirectionalShadowData.sphereCascades[4]`（`HDShadowManager.cs:103-117`）
  HG 段移成 `_CSMShadowSplitSpheres[16] = float4[4]`（CB 段化）。
- HDRP `cascadeBorders[4]` → HG `_CSMShadowBiases[16]` 携带（4 个 Vector4 同时存 depthBias /
  slopeBias / normalBias / borderFade）。来源 `CascadedShadowRequest.cascadeShadowBiases`
  `Vector4[]`（`HGShadowManager.cs:62-65`）。
- HDRP `directionalShadowFilteringQuality` 是 enum；HG 用 `HGShadowSampleMode`
  （`HGShadowSampleMode.cs`）：`PCF_Hard / PCF_Average / PCF_3x3 / PCF_5x5 / DPCF_16`
  → 选 keyword（细节见 §5）。

---

## 5. HDRP 血缘：PCF Tent 与 PCSS Directional / Punctual

### 5.1 PCF Tent 算法（照抄 HDRP）

`HDShadowSampling.hlsl:30-156`：

- **3×3 Tent (4 taps)** （Low）：`SampleShadow_ComputeSamples_Tent_3x3` 把 9 个采样合成 4 个
  `GatherCmp` 加权和（`HDShadowSampling.hlsl:30-47`）。
- **5×5 Tent (9 taps)** （Medium）（55-96 行）：9 个加权 `GatherCmp`，循环外展减寄存器压力
  （`#if SHADOW_OPTIMIZE_REGISTER_USAGE`）。
- **7×7 Tent (16 taps)** （High 方向光）（101-156 行）。
- **Gather PCF** （Ultra-low / metal）`SampleShadow_Gather_PCF`（14-28 行）：一个
  `GATHER_TEXTURE2D` 取 4 像素 depth，用 `frac` 双线性差值。

HG `HGShadowSampleMode` 5 档（`HGShadowSampleMode.cs:1-11`）：
- `PCF_Hard` → 单 `SAMPLE_TEXTURE2D_SHADOW`
- `PCF_Average` → 等价 `SampleShadow_Gather_PCF`
- `PCF_3x3` → `SampleShadow_PCF_Tent_3x3`
- `PCF_5x5` → `SampleShadow_PCF_Tent_5x5`
- `DPCF_16` → 16-tap dynamic disk（HDRP 7×7 同等带宽）

### 5.2 PCSS Directional（**核心 4 步**，照抄 HDRP）

`HDShadowSampling.hlsl:407-463` + `HDPCSS.hlsl:381-423`：

**步骤 1 — Blocker Search**

`HDShadowSampling.hlsl:441-447`：

```hlsl
#if UNITY_REVERSED_Z
float blockSearchFilterSize = max(min(1.0 - posTCAtlas.z, maxSampleZDistance) * depth2RadialScale,
                                  minFilterRadius);
#else
float blockSearchFilterSize = max(min(posTCAtlas.z, maxSampleZDistance) * depth2RadialScale,
                                  minFilterRadius);
#endif
float blockerDepth = 0.0;
bool blockerFound = BlockerSearch_Directional(blockerDepth, blockSearchFilterSize, posTCAtlas,
    shadowmapInAtlasScale, shadowmapInAtlasOffset, sampleJitter, tex, samp, blockerSampleCount,
    blockerRadial2DepthScale, minFilterRadius, minFilterRadial2DepthScale, blockerClumpSampleExponent);
```

**步骤 2 — Penumbra 估计**

`HDShadowSampling.hlsl:449-454`：

```hlsl
float blockerDistance = min(abs(blockerDepth - posTCAtlas.z) * 0.9, maxSampleZDistance);
float filterSize         = blockerDistance * depth2RadialScale;
float samplingFilterSize = max(filterSize, minFilterRadius);
maxPCSSOffset = min(maxPCSSOffset, blockerDistance * 0.25);  // 25% 截断防 light leak
```

**步骤 3 — Filter 锥扫描**

`HDPCSS.hlsl:381-423`：Fibonacci spiral disk（64 个预烘单位向量
`fibonacciSpiralDirection[DISK_SAMPLE_COUNT=64]`，`HDPCSS.hlsl:21-87`），每 tap：

```hlsl
real2 offset = ComputeFibonacciSpiralDiskSampleUniform_Directional(i, sampleCountInverse,
                                                                    sampleCountBias, sampleDistNorm);
offset = real2(offset.x * sampleJitter.y + offset.y * sampleJitter.x,
               offset.x * -sampleJitter.x + offset.y * sampleJitter.y);
offset *= samplingFilterSize;
offset *= shadowmapInAtlasScale;
float2 sampleCoord = posTCAtlas.xy + offset;
float zOffset = filterSize * sampleDistNorm * radial2DepthScale;
float coordz = posTCAtlas.z + Z_OFFSET_DIRECTION * min(zOffset, maxPCSSOffset);
sum += SAMPLE_TEXTURE2D_SHADOW(shadowMap, compSampler, real3(sampleCoord, coordz)).r;
```

**关键魔数（照抄 HDRP）**：
- `DISK_SAMPLE_COUNT = 64`（`HDPCSS.hlsl:3`）
- Penumbra 截断系数 `0.9`、Offset 截断 `0.25`（`HDShadowSampling.hlsl:451, 458`）
- 锥模型 z offset 方向：reversed-Z 平台为 `+1`，否则 `-1`（`HDPCSS.hlsl:383-387`）。
- Sample jitter 旋转：`InterleavedGradientNoise(posSS, taaFrameIndex) * 2π`，
  `sin/cos` 作为 2D 旋转矩阵（`HDShadowSampling.hlsl:436-438`）。

### 5.3 HG delta

- HDRP 的 PCSS 参数 8 个 `dirLightPCSS*`（`HDShadowManager.cs:217-224`）打包 1 个
  `Vector4 shadowFilterParams0`；HG 用 `Vector4 _CSMPenumbraSizes`（一个 vec 装 4 参数）+
  `_DirectionalShadowParams/Params2` 容纳同样含义，**字段顺序**未在 cbuffer 暴露，但段中前
  16 float 的 fixed array 给 HLSL 通过偏移读出。**核心算法（光锥 z offset、Fibonacci spiral、
  Penumbra 0.9 / 0.25）照抄不改**。

---

## 6. HG 自研：ASMTile 虚拟阴影贴图（核心算法）

ASM = **Adaptive Shadow Map (Lefohn 2007)** 的 **Sparse / VT 化** 实现。HDRP 没有同源；
HG 把它做成「**远场地面投影补阴影**」专用模块。算法 1:1 重建依据：
`ASMTile.cs`、`ASMTileManager.cs`、`ASMUtils.cs`、`HGASMVirtualTextureAllocator.cs`、
`HGASMManager.cs`、`AtlasMaxRect.cs`。

### 6.1 Tile = 光空间矩形 + Refinement Level

`ASMTile`（`ASMTile.cs:5-95`）：

```csharp
public struct ASMTile
{
    public Vector2 mins;            // 光空间 XY 最小角 (世界投影到光基下)
    public Vector2 maxs;            // 最大角
    public Vector3Int tileCoords;   // (x, y, refinementLevel)：网格坐标
    public bool isValid;            // 该 tile 已被分配
    public bool isRendered;         // 本帧已写过 depth
    public bool isVisible;          // 本帧落在 frustum
    public int vtIndex;             // 在 16×16 atlas 槽里的 index ∈ [0..255]
}
```

ctor `ASMTile(int coordX, int coordY, int refinementLevel, float gridSize)`
（`ASMTile.cs:52-94`）反汇编：
```
mins = (coordX * gridSize, coordY * gridSize)
maxs = mins + (gridSize, gridSize)
tileCoords = (coordX, coordY, refinementLevel)
isValid = true; isRendered = false; isVisible = false; vtIndex = 0
```
（来自 `mulss xmm1,xmm3 / mulss xmm0,xmm3` 把 int 坐标乘 gridSize 得到 mins；`call
loc_184917210` 是 `Vector2 op_Addition` 得到 maxs，可见单元 22 行；`mov word ptr
[r10+1Ch],1 / mov byte ptr [r10+1Eh],0` 设置 valid=true、rendered=false。）

### 6.2 Frustum-XZ 投影 → 候选 tile 生成

`ASMTileManager.CreateTilesThisFrame(centerPoint, radius, gridSize)`
（`ASMTileManager.cs:1059-1213`）反汇编算法：

```
// 1) 由 centerPoint 与 radius 求光空间 XY AABB → 网格化得到 [minTileX..maxTileX] × [minTileY..maxTileY]
xstart = floor((centerPoint.x - radius) / gridSize) - 1   // 反汇编: subss xmm0,xmm9; divss xmm0,xmm7
xend   = floor((centerPoint.x + radius) / gridSize) + 1
ystart = floor((centerPoint.y - radius) / gridSize) - 1
yend   = floor((centerPoint.y + radius) / gridSize) + 1

// 2) 双循环里每格中心 ‖tileCenter - centerPoint‖ ≤ radius - tileHalfSize
for x in [xstart..xend]:
  for y in [ystart..yend]:
    tileCenter = ((x + 0.5) * gridSize, (y + 0.5) * gridSize)
    dist = ||tileCenter - centerPoint||  // call loc_18406BA20 = Vector2.Distance
    if (dist <= radius - gridSize * SQRT_2_OVER_2):  // [g_18C471424] ≈ 0.7071
        emit new ASMTile(x, y, refinementLevel=0, gridSize) → m_tilesThisFrame[count++]
```

（关键证据：循环里 `call loc_18406BA20` 与 `subss xmm0,xmm6` 后 `comiss xmm9,xmm0` 即
"radius - tileEdge >= dist" 判断；新 tile 通过 `call HG.Rendering.Runtime.ASMTile::.ctor`
构造并写入 `m_tilesThisFrame` 数组 `[rdx+rcx*4+20h]`。）

容量：`MAX_TILE_COUNT = 256`（`ASMTileManager.cs:308`）。

### 6.3 视野相交（SAT 8 轴）+ 远场距离剔除

#### 6.3.1 `IsTileFrustumIntersecting`（SAT 分离轴测试）

`ASMUtils.cs:8-236`，给定 5 个 frustum 顶点 + tile AABB(mins,maxs) 做相交：

**第 1 步 — Trivial out（4 顶点同侧）**
反汇编 `0x18A8AD81B`：对 5 个 frustum 顶点逐一比较与 tile 4 个 AABB 边的关系，
`r8/r9/r10/cl` 4 个布尔位累乘 — 任一边外则 `or` 结果非零 → `false`。

**第 2 步 — 真正 SAT（8 轴循环）**
`0x18A8AD8B3`：

```
for edge i in [0..7]:  // 5 frustum 顶点环 = 5 边 + 4 tile 边 = 9，实测 8 轴
    edgeDir = frustum[i+1] - frustum[i]   // 取出 frustum 边
    normal  = perpendicular(edgeDir)       // 旋转 90° 即可
    project frustum to normal: [minF, maxF]
    project tile (4 角)   to normal: [minT, maxT]
    if maxF < minT or maxT < minF: return false  // 分离 → 不相交
return true
```

具体反汇编里：`movss xmm0,...; xorps xmm6,[__StaticArrayInitTypeSize=33]` 是把 normal 做
sign flip（perpendicular = (-y, x)），随后用 `Vector2.Dot` 投影 frustum 4 顶点和 tile 4
角（4 个 `unpcklps + call loc_1869377DC`，即 dot product），再 `comiss` 取 min/max 比较。

#### 6.3.2 `ASMTileDistance`（远场剔除距离）

`ASMUtils.cs:238-314`：

```
center = (mins.x + maxs.x) / 2, (mins.y + maxs.y) / 2   // unpcklps + 0.5 系数
dist   = ||center - position||                          // Vector2.Distance
// 反汇编: subss xmm7,xmm6; mulss xmm7,[g_18C471424] (= 0.7071)
//        subss xmm0,xmm7  → 减去 (tileEdge * sqrt(2)/2)
return dist - (tileSize * 0.7071)  // 等价 dist 减去半对角线（保守近似）
```

该距离配合 `m_visibilityDistance`（`[rbx+3Ch]`）决定 tile 是否仍在远场视野。

#### 6.3.3 Visibility Job（Burst）

`ASMTileManager.CalculateTileVisibilities`（`ASMTileManager.cs:62-188`）`[BurstCompile]
IJob` 体并行：

```csharp
for k in [0..count):
    tile = cachedTiles[ tileIndices[k] ]
    if !tile.isValid: tile.isVisible = false
    else:
        bool inFrustum = ASMUtils.IsTileFrustumIntersecting(frustumVerts, tile.mins, tile.maxs)
        if inFrustum: tile.isVisible = true
        else:
            float dist = ASMUtils.ASMTileDistance(tile, centerPoint)
            tile.isVisible = (radius > dist)
    cachedTiles[index] = tile
```

#### 6.3.4 Score Job（评分 = 距离 + 远场penalty）

`ASMTileManager.CalculateTileScoresJob`（`ASMTileManager.cs:190-306`）：

```csharp
for each cachedTile:
    score = ASMUtils.ASMTileDistance(tile, frustumCenterPos)
    // 反汇编里 imul ecx,eax,sub_186A0：refinementLevel * 100000
    score += refinementLevel * 100000.0f
    if !IsTileFrustumIntersecting(frustumVerts, mins, maxs):
        score += g_18E5ECAB0   // 大常量 penalty（远场 tile 加分降优先级）
    cachedTilesScore[i] = {index=i, score}
sort ascending by score
```

→ **优先渲染**：分数低的 tile（近 frustum + 低 refinement + 落在视野）。

### 6.4 LRU 16×16 VT 槽分配 + 256 tile 预算

`HGASMVirtualTextureAllocator`（`HGASMVirtualTextureAllocator.cs`）：

```csharp
private const int GRID_COUNT_X = 16;       // 16x16 = 256 槽
private const int GRID_COUNT_Y = 16;
private readonly LRUCache m_lruCache;       // 共用 80h 容量
private readonly ASMVTData[] m_vtData;     // 256 个 VT 槽元数据
```

`ASMVTData(int vtIndex, int gridResolution)`（行 19-73）：

```
// 反汇编关键：
//   eax,edx; idiv ecx=16            → vtIndex / 16 = row, vtIndex % 16 = col
//   mulss xmm0,xmm1 (xmm1=1/16)     → uvMins = (col/16, row/16)
//   call loc_184917210              → uvMaxs = uvMins + (1/16, 1/16)
//   imul r9d,r8d / imul r10d,r8d    → pixelMins = (col*gridResolution, row*gridResolution)
//   call loc_186ED31A4              → pixelMaxs = pixelMins + (gridResolution-1, gridResolution-1)
```

所以 atlas 总分辨率 = `s_asmTileResolution × 16 × s_asmTileResolution × 16`
（`HGASMManager.cs:64` 静态字段 `s_asmTileResolution`）。

`AllocateTile(asmTileManager, tileCoords, startVTIdx)`
（`HGASMVirtualTextureAllocator.cs:235-424`）：

```
key = ASMUtils.TileCoordsToKey(tileCoords)     // = (x<<15 + y)*4 + z + 0x80010000
       (ASMUtils.cs:316-356: shl ecx,0Fh; add ecx,[rbx+4]; lea eax,[rax+rcx*4]; add eax,0x80010000)
slot = LRUCache.Allocate(key)  // 槽 ∈ [0..255]，若满则 evict 最久未访问
if (slot evicted some old key):
    oldCoords = ASMUtils.KeyToTileCoords(evictedKey)   // 解码
    if (asmTileManager.m_cachedTilesDict.ContainsKey(oldCoords)):
        // 把旧 tile 的 vtIndex 标 invalid（=2），从字典移除
        asmTileManager.m_cachedTiles[ oldIdx ].isValid 标记位
        m_cachedTilesDict.Remove(oldCoords)
asmTileManager.m_cachedTiles[ newCachedIdx ].vtIndex = (slot - 1) + startVTIdx
return true
```

**Key 编码**（`ASMUtils.cs:316-356`）：
```
key = ((x << 15) + y) * 4 + refinementLevel + 0x80010000
```
0x80010000 是 base bias 让 key 落在 31bit 正区间，4×=保留 2 bit 给 `refinementLevel`，`y` 占
17 bit，`x` 占剩余高位。**解码**（`KeyToTileCoords`，行 358-416）：
```
T = 0x20000  (= 131072 = 2^17)
x = (key / T) - 0x4000   // 反汇编 cdq idiv 0x20000; sub 0x4000
y = ((key % T) / 4) - 0x4000
z = (key % T) % 4        // refinementLevel
```

`VisitTilesThisFrame(asmTileManager, startVTIdx)`（行 426-571）：枚举
`m_cachedTilesDict`，对每个 `isValid && (vtIndex != -1)` 的 tile 调
`LRUCache.Visit(vtIndex - startVTIdx + 1)` 把它 bump 到最新（LRU 时序更新）。

### 6.5 Atlas UV 矩阵 + Tile 索引打包到 CB

CB 段 `_ASMIndirectParams[512]` = **256 tile × 2 Vector4**（`HGShadowConstantBufferUtils.cs:70`）：

每个 tile 写入：
- vec0 = `(uvMins.x, uvMins.y, uvMaxs.x, uvMaxs.y)`  ← `ASMVTData`
- vec1 = `tileCoords.xy (即 mins.xy 还原)` + `(invSizeX, invSizeY)`，shader 用来从世界 XY 换算
  到 tile-local UV。

`_ASMWorldToShadowBaseMatrix` 是 light view × ortho proj（全图共享），shader 流程伪码：

```hlsl
float3 lightSpacePos = mul(_ASMWorldToShadowBaseMatrix, float4(worldPos, 1.0)).xyz;
int2 tileXY = floor((lightSpacePos.xy - _ASMBase.xy) / _ASMTileSize);
int  tileKey = tileXY.x * STRIDE + tileXY.y;
// 查 hash → vtIndex（CPU 端写入索引）
int  vtIndex = SampleVTIndexFromUAV(tileKey);
if (vtIndex < 0) return 1.0;  // 未驻留，按默认无遮蔽
float2 atlasUV = _ASMVT[vtIndex].uvMins + frac((lightSpacePos.xy - tileMins) / _ASMTileSize)
                                        * (_ASMVT[vtIndex].uvMaxs - _ASMVT[vtIndex].uvMins);
float shadowDepth = SAMPLE_TEXTURE2D_SHADOW(_ASMShadowMap, sampler_LinearClamp,
                                             float3(atlasUV, lightSpacePos.z + bias));
```

（说明：反编译看到 CPU 端 `m_worldToShadowMatrices`、`m_lightToWorld`、`m_lightDir`、
`m_lightRotation`、`m_frustumCorners` 字段，但完整 hlsl 在 .shader/.hlsl 闭源；shader 形态据
CB 字段顺序与领域知识 1:1 重建。HG 反汇编里
`HGASMVirtualTextureAllocator.ASMVTData(vtIndex, gridResolution)` 在 ctor 第 47 行
`call loc_184917210` 算 `uvMaxs = uvMins + (1/16, 1/16)`，证明每 tile UV 占 atlas 的 1/16 步长。）

#### 6.6 Atlas Allocator（AtlasMaxRect — 备选 / Capsule 等共用）

`AtlasMaxRect.cs` 实现 Jukka Jylänki 的 **MaxRects 包装算法**（`InsertRect / 
InsertRectBestShortSideFit / BestLongSideFit / BestAreaFit / BottomLeft / ContactPoint`
五种启发式策略），ASM 自身不用（它走固定 16×16 grid + LRU），但 HG 的角色阴影 atlas（character
shadow atlas 15 个 slot）和 punctual shadow atlas 复用了 MaxRects 做动态打包。

---

## 7. Contact Shadow（HDRP 血缘 + HG Pass 包装）

### 7.1 HDRP 原算法（屏空 ray-march）

`ContactShadows.compute:51-143`：

```hlsl
bool ScreenSpaceShadowRayCast(positionWS, rayDirWS, rayLength, positionSS, out fade)
{
    float ditherBias = 0.5;
    float dither = InterleavedGradientNoise(positionSS, (_FrameCount % 8u) * taaEnabled) - ditherBias;
    float3 rayStartWS = positionWS - positionWS * _ContactShadowBias;
    float3 rayEndWS   = rayStartWS + rayDirWS * rayLength;
    float4 rayStartCS = TransformWorldToHClip(rayStartWS);
    float4 rayEndCS   = TransformWorldToHClip(rayEndWS);
    // ortho-view-space ray for ortho threshold:
    float4 rayOrthoVS = rayStartCS + float4(GetViewToHClipMatrix()[*][2], ...) * rayLength;
    rayOrthoVS /= rayOrthoVS.w;
    rayStartCS.xyz /= rayStartCS.w; rayEndCS.xyz /= rayEndCS.w;
    float3 rayDirCS = rayEndCS.xyz - rayStartCS.xyz;
    float step = 1.0f / _SampleCount;
    float compareThreshold = GetDepthCompareThreshold(step, rayStartCS.z, rayOrthoVS.z);
    float2 startUV = rayStartCS.xy * 0.5 + 0.5; startUV.y = 1 - startUV.y;
    float3 rayStart = float3(startUV, rayStartCS.z);
    float3 rayDir   = float3(rayDirCS.x * 0.5, -rayDirCS.y * 0.5, rayDirCS.z);
    float t = step * dither + step;
    bool tracingHalfRes = true;
    for (int i = 0; i < _SampleCount; ++i, t += step)
    {
        float3 sampleAlongRay = rayStart + t * rayDir;
        if (any(sampleAlongRay.xy < 0) || any(sampleAlongRay.xy > 1)) break;
        float sampleDepth = SampleDepth(saturate(sampleAlongRay.xy), tracingHalfRes);
        float depthDiff = sampleDepth - sampleAlongRay.z;
        if (depthDiff > 0 && CompareDepth(depthDiff, compareThreshold) && sampleAlongRay.z > 0)
        {
            if (tracingHalfRes) { tracingHalfRes = false; continue; }  // 命中后切 full-res 复采样
            else                { occluded = 1.0; break; }
        }
    }
    // vignette 衰减（屏边遮蔽）：
    float2 vignette = max(6.0f * abs(rayStartCS.xy + rayDirCS.xy * t) - 5.0f, 0.0f);
    fade = occluded * saturate(1.0f - dot(vignette, vignette));
}
```

Threshold（`ContactShadows.compute:40-48`）：

```hlsl
float GetDepthCompareThreshold(float step, float rayStartZ, float rayOrthoZ)
{
    return abs(rayOrthoZ - rayStartZ) * _ContactShadowThickness * max(0.07, step);
}
bool CompareDepth(float depthDiff, float compareThreshold)
{ return abs(compareThreshold - depthDiff) < compareThreshold; }
```

魔数 `0.07`（最小 step 因子）、`6.0/5.0`（vignette 拐点）、tile size `DEFERRED_SHADOW_TILE_SIZE = 8`
（`ContactShadows.compute:25`，`[numthreads(8,8,1)]`），全部照抄。

### 7.2 HG 接触阴影 PassConstructor

`ContactShadowPassConstructor`（`ContactShadowPassConstructor.cs`）：

- **THREAD_COUNT = 64**（`ContactShadowPassConstructor.cs:83`，即 8×8 — 与 HDRP 同；HG 把它
  放成 const，方便 dispatch 计算）。
- **FP_LIMIT = 0.000128f**（行 85，浮点保护下限）。
- HDRP 用 `RayTracing` kernel；HG 用 **`RayTracingV2`** kernel（`ContactShadowPassConstructor.cs:79`
  `CONTACT_SHADOW_RAY_TRACING_KERNEL_V2 = "RayTracingV2"`，dispatch 见
  `PrepareContactShadowPassDataV2` 行 286）。`RayTracingV2` 是 HG 改写版（疑似 wave-intrinsic
  优化或屏-tile dispatch 调整），算法骨架仍是 §7.1。
- **平台能力门**（`PrepareDataForContactShadow`，行 135-208）：
  ```
  PipelineEnable = renderPath.contactShadowEnable           // HGCamera 标志
  PlatformCapable = SupportsComputeShaders                   // && DeviceType != Switch (0x11) 
                                                             // && DeviceType != Metal (0x0B)
  AllEnable = PipelineEnable | PlatformCapable               // == 3 时启用
  ```
  反汇编：`UnityEngine.SystemInfo::SupportsComputeShaders` 后 `GetGraphicsDeviceType` 与
  `0x11`/`0x0B` 比对，命中即禁用 Contact Shadow（HG 移动端剪裁）。
- **Dispatch 维度**（行 286-396）：
  ```
  groupCount.x = ceil(camera.pixelWidth  * renderingScale / 8) → max(1, ...)
  groupCount.y = ceil(camera.pixelHeight * renderingScale / 8) → max(1, ...)
  groupCount.z = 1
  ```
  `m_contactShadowDispatchData[8]` 数组（行 81，最多 8 dispatch — 大概率因 ECS 多 layer/tile
  bucket）。
- **CB 参数**：
  ```
  _ContactShadowParamsParameters  = (shadowIntensity, distScale, fadeEnd, fadeOneOverRange)
  _ContactShadowParamsParameters2 = (renderTargetHeight, minDistance, fadeInEnd, depthBias)
  _ContactShadowParamsParameters3 = (sampleCount, thickness, _, _)
  ```
  CB 字段与 HDRP `ContactShadows.hlsl:1-19` 字段 1:1。参数源自
  `HGShadowConfig`（`HGShadowConfig.cs`）：
  - `contactShadowIntensity` ∈ [0,1]
  - `contactShadowSurfaceThickness` ∈ [0.4,1]（`ContactShadowVolume.cs` Volume override）
  - `contactShadowBilinearThreshold` ∈ [2,5]
  - `contactShadowContract` ∈ [1,4] (int，阴影锐度)
  - `contactShadowIgnoreEdgePixels` （bool，屏幕边界忽略）

---

## 8. HG 自研：低分辨率方向阴影通道

`HGLowResDirectionalShadowPass`（`HGLowResDirectionalShadowPass.cs`）：

- **常量**（行 32-34）：
  ```csharp
  internal const int   LOW_RES_SHADOW_DOWNSAMPLE_SCALE    = 4;
  internal const float LOW_RES_SHADOW_INV_DOWNSAMPLE_SCALE = 0.25f;
  ```
  即 **1/4 分辨率**（每边 4×，面积 1/16）。

- **3 个子 pass**：
  1. **HGLowResDirectionalShadowPassData**：在 1/4 RT 上对方向光做 PCF + ASM 合成
     （`m_lowResDirectionalShadowMaterial`）。
  2. **HGLowResShadowBlurPassData (Vertical)**：5/7-tap Gaussian 竖向模糊
     （`m_lowResShadowBlurMaterial`，`horizontalPass = false`）。
  3. **HGLowResShadowBlurPassData (Horizontal)**：5/7-tap Gaussian 横向模糊
     （`horizontalPass = true`）。

- **RT 尺寸**（`Render` 函数，行 173-184）：
  ```
  lowResWidth  = ceil(camera.pixelWidth  * renderingScale * 0.25)
  lowResHeight = ceil(camera.pixelHeight * renderingScale * 0.25)
  ```
  TextureDesc format `R8 / R16` (反编译里写入 type id 5)，单通道 mask。

- **为什么**：HDRP 默认 PCSS 64-tap、PCF 7×7 16-tap 全屏代价过高；HG 把 1/4 mask + 双向 Gaussian
  ≈ 等价 PCF 5×5 视觉效果，但 ALU/带宽 ÷16，移动端关键 trade-off。**HDRP 无同源**，是 HG 自研。

- **后续 ScreenSpaceShadowResolve** 在 `ScreenSpaceShadowMaskPassConstructor.RenderScreenSpaceShadowResolve`
  （行 181-388）用 `m_screenSpaceShadowResolveMaterial`，输入 5 张纹理：
  - `depthBuffer`（HiZ depth）
  - `depthTexture`（depthCopied）
  - `gbuffer0`、`gbuffer1`（取 worldPos 重建 + 法线）
  - `lowResShadowTexture`（§8 输出）
  → 输出单通道 `screenSpaceShadowResolveTexture`。在 light loop 后期直接乘 mask 即得方向阴影。

---

## 9. HG 自研：Capsule Shadow（Visibility-SH 解析积分）

### 9.1 数据模型

`HGCapsuleShadowContainer`（`HGCapsuleShadowContainer.cs:6-25`）= 单条胶囊：

| 字段 | 含义 |
|---|---|
| `rootTransform` | 挂的骨骼 |
| `capsuleRadius`、`capsuleHeight` | 几何参数 |
| `localOffset`、`localRotation` | 相对骨骼的偏移/旋转（Euler XYZ） |
| `intensityScale` | 阴影强度倍率 |
| `enabled`、`isFoot` | 启用位 + "脚部"标记（脚部使用更紧凑形态） |

`HGCapsuleShadowHelper`（`HGCapsuleShadowHelper.cs`）：

- 用 `List<HGCapsuleShadowContainer> m_capsuleShadowContainers` 管 N 条胶囊。
- 角色面板暴露 14 根骨骼名（左右髋/膝/踝/肩/腕、脖根 ToesEnd L/R、Trunk、Head）。
- `AutomateGenerateCapsuleSkeletons()`（`HGCapsuleShadowHelper.cs:999-1271`）调
  `GetSkeletonTransformByName` 逐根 FindRecursive 找到 Transform，然后串成腿胶囊（hip→knee、
  knee→ankle、ankle→toesEnd × 2 腿）+ 躯干/手臂胶囊。

`HGCapsuleShadowManager`（`HGCapsuleShadowManager.cs`）：

- `MAX_CAPSULE_NUM = 256`（行 12）。
- 4 个 `NativeArray<Vector4>` 平摊存放 capsule data（行 18-24）：
  - `m_capsuleShadowData1` = (centerX, centerY, centerZ, radius)
  - `m_capsuleShadowData2` = (axisX, axisY, axisZ, halfHeight)
  - `m_capsuleShadowData3` = (intensity, isFoot ? 1 : 0, _, _)
  - `m_capsuleShadowData4` = ditherAlpha 等附加参数
- `m_capsuleStencilWriterMatrixes : NativeArray<Matrix4x4>` 保存每胶囊的 worldToLocal（包围球
  绘制时用）。
- `fakeSphericalLightSource : Vector4` = (sunDir.xyz, lightAreaRadius)，是太阳方向 + 软光源
  半角的紧凑表示。

### 9.2 Visibility-SH Pass（核心算法）

`CapsuleShadowPassConstructor.ConstructPass_VisibilitySH`
（`CapsuleShadowPassConstructor.cs:239-...`）：

绘制是 **球体 mesh 实例化**（`m_sphereMesh` 单位球 instance × capsuleNum），目的是把每条胶囊
的影响区域光栅化到屏空 RT；每像素**解析地**积分球形光源被胶囊遮挡的可见度，然后输出为
**2-band Spherical Harmonics 系数**（4 个 float，行 86 `VisibilitySHConstData.logSHParams`）：

CPU 端 CB 字段（`CapsuleShadowPassConstructor.cs:86-103`）：

| 字段 | 含义（据领域知识） |
|---|---|
| `logSHParams` | log-encode 用的 K，B：`y = exp(K x - B) / K` 解码遮蔽率 |
| `gStarParams` | 球形光源（`fakeSphericalLightSource`）方向 + 锥角 |
| `abParams` | A/B 拟合参数（用查表的 fitting curve） |
| `fHatParams` | 滤波器（hat function）系数 |
| `sphereParams` | 当前 capsule 球段 origin/axis/radius/length |
| `tileParam0/1/2` | 屏空 tile dispatch 维度（Vector4Int） |

LUT：
- `m_visibilityABLut`（`visibilityABLut`，`CapsuleShadowPassConstructor.cs:74` 和 110）
- `m_visibilitySHLut`（`visibilitySHLut`，行 70-72）

shader 给每像素：
1. 用 GBuffer 法线 + 深度恢复 worldPos；
2. 对每条覆盖该像素的胶囊，沿 `gStar`（光源方向）做 **capsule-vs-sphere occlusion 解析公式**
   → 得 ω₀..ω₂ 三角积分（球面调和投影）；
3. 把每胶囊贡献以**乘法**叠加到 SH 系数（log 域线性化，避免 over-darken）；
4. 写 `visibilitySHRT`（2-3 通道存 SH 系数 / occlusion）。

合成阶段 light loop 里：

```hlsl
// 已有 GBuffer normal n
float3 sh = SAMPLE_TEXTURE2D(visibilitySHRT, samp, screenUV).xyz;
float visibility = SHEvaluate(n, sh);   // band-2 SH dot
shadowAttenuation *= visibility;
```

降级路径 `visibilitySHRTDefault`（`CapsuleShadowPassConstructor.cs:69`）当胶囊数 = 0
（`s_CapsuleShadowRenderFuncEmptyV2`，行 115）直接绑空白纹理。

DownSampleDepth 子 pass（`DownSampleDepthPassData`，行 54-59）先把 scene depth 下采样到 1/4
分辨率，capsule 绘制可在低分辨率 RT 上 raster 减少 fragment 数。

### 9.3 注册 / 注销

`HGCapsuleShadows.EnqueueCapsuleShadowHelper / DequeueCapsuleShadowHelper`
（`HGCapsuleShadows.cs:18-235`）：全局单例
`HGCapsuleShadows.instance` 维护 `static List<HGCapsuleShadowHelper>`，角色 enable 时入队、
disable 出队，`HGCapsuleShadowManager.FrameSetup` 遍历它扁平化 GPU 数组。

---

## 10. 关键常量 / 魔数

| 常量 | 值 | 来源 | 含义 |
|---|---|---|---|
| `MAX_TILE_COUNT` | 256 | `ASMTileManager.cs:308` | ASM atlas 同时容纳 tile 上限 |
| `GRID_COUNT_X / Y` | 16 / 16 | `HGASMVirtualTextureAllocator.cs:76-78` | 16×16 VT 槽 = 256 |
| `MAX_CAPSULE_NUM` | 256 | `HGCapsuleShadowManager.cs:12` | 每帧 GPU capsule 上限 |
| `MAX_CASCADE_COUNT` | 4 | `HGShadowConstantBufferUtils.cs:73` | CSM 级联数 |
| `MAX_PUNCTUAL_LIGHT_SHADOW_CASTER_COUNT` | 56 | 同上 :75 | 投影点 / 聚光最大数 |
| `MAX_CHARACTER_SHADOWMAP_COUNT` | 15 | 同上 :77 | 角色专属阴影 slot |
| `ASM_TILE_COUNT` | 256 | 同上 :79 | ASM 段 CB 矩阵数 |
| `LOW_RES_SHADOW_DOWNSAMPLE_SCALE` | 4 | `HGLowResDirectionalShadowPass.cs:32` | 1/4 分辨率方向阴影 |
| `LOW_RES_SHADOW_INV_DOWNSAMPLE_SCALE` | 0.25 | 同上 :34 | 同上倒数 |
| `THREAD_COUNT` | 64 | `ContactShadowPassConstructor.cs:83` | 8×8 thread group |
| `FP_LIMIT` | 0.000128 | 同上 :85 | 浮点保护下限 |
| `DISK_SAMPLE_COUNT` | 64 | `HDPCSS.hlsl:3` | Fibonacci spiral 单位向量数 |
| `DEFERRED_SHADOW_TILE_SIZE` | 8 | `ContactShadows.compute:25` | Contact shadow tile |
| `FIXED_UNIFORM_BIAS` | 1/65536 | `HDShadowAlgorithms.hlsl:6` | 固定 depth bias |
| PCSS Penumbra clamp | 0.9 / 0.25 | `HDShadowSampling.hlsl:451, 458` | 收敛与防 light leak |
| PCSS lerpSharpness | 8 + 512·smoothstep(1,0.7,border) | `HDShadowAlgorithms.hlsl:253` | cascade seam 修复 |
| ASM key bias | `0x80010000` | `ASMUtils.cs:329` | TileCoords → key 加常量 |
| ASM coord 编码步长 | `0x20000`、`0x4000`、`4` | `ASMUtils.cs:371-389` | (x<<15+y)*4+z |
| ASM 距离剔除 `radius - tileSize*sqrt(2)/2` | 0.7071 = `[g_18C471424]` | `ASMUtils.cs:281`、`ASMTileManager.cs:1126` | 内切圆半径，保守相交 |
| ASM 评分 refinement penalty | `0x186A0 = 100000` | `ASMTileManager.cs:265` | level 越高得分越高 → 后渲染 |
| LRU cache 容量 | `0x80 = 128`（实测复用为 256） | `HGASMVirtualTextureAllocator.Initialize`、`ASMTileManager.InvalidateAllTiles` 调 `LRUCache::Reset(0x80, ...)` | — |

---

## 11. 1:1 复刻蓝图

要从零重建 EndField 的阴影 1+3 体系：

### 11.1 数据层
1. 实现 §2 的 ConstantBufferData 段：4 块 + padding，**字段顺序与 float 数严格照抄**
   `HGShadowConstantBufferUtils.HGShadowConstantBufferData`。shader 端要靠 offset 读取，错一
   float 就全错。
2. 实现 `ASMTile`（valid/visible/rendered/vtIndex 4 个 bool/int 紧打包成 1 个 `tileCoords.z`
   或独立字节），布局照抄 `ASMTile.cs:5-95`，offset 0x00 mins、0x08 maxs、0x10 tileCoords、
   0x1C isValid、0x1D isRendered、0x1E isVisible、0x20 vtIndex。
3. 实现 `HGASMVirtualTextureAllocator.ASMVTData`（uvMins/uvMaxs/pixelMins/pixelMaxs），ctor
   公式照抄 §6.4。

### 11.2 ASM 管线
1. 初始化：`s_asmTileResolution`、`s_asmGridSize`、`s_asmCacheRadius`、
   `s_asmMaxTileRenderCountPerFrame` 由 `HGShadowConfig.asm*` 字段驱动。
2. 每帧（按 `m_asmUpdateMode` ∈ {Stop, Slow, Normal, Extreme}）：
   - `SetFrustumVerts(5 个顶点)`（光空间下 frustum 5 角投影）
   - `CreateTilesThisFrame(center, radius, gridSize)`（§6.2 算法）
   - `UpdateCachedTiles(center, radius)`（§6.3）
   - 调 Burst Job `CalculateTileVisibilities`、`CalculateTileScoresJob`、排序
   - 取 score 最低的若干 tile（≤ `s_asmMaxTileRenderCountPerFrame`）走 `AllocateTile`
   - 提交 `ASMShadowPass` × 选中 tile 数（每 tile 一个 viewport）
   - 把 `_ASMWorldToShadowBaseMatrix / _ASMIndirectWorldToShadow / 256 个 _ASMIndirectParams[i]`
     更新到 CB
3. 双 atlas 设计（`HGASMManager.s_asmManagers + s_cachedASMManagers + s_cameraLifetime +
   s_toRemoveList`，`HGASMManager.cs:48-54`）：每相机 2 个 manager 互为 friend，
   `SwapASMManager(camera)` 在镜头大跳变时双缓冲切换避免 atlas 重渲染。

### 11.3 CSM 管线
1. CPU：每级联调 `CullingResults.ComputeDirectionalShadowMatricesAndCullingPrimitives`
   → 填 `CascadedShadowRequest`（`HGShadowManager.cs:37-65`）
2. GPU：每级联渲染到 atlas 的 viewport（`directionalShadowMapTileSize`），上传 4 个 split
   球到 `_CSMShadowSplitSpheres`，写 `_CSMShadowBiases` 4 个 vec
3. 采样：照 §4.2 公式做 GetSplitIndex；照 §5 选 keyword 走 PCF/PCSS

### 11.4 Contact / SSShadow Mask
1. 用 HDRP `ContactShadows.hlsl/.compute` 算法（§7.1）改成 `RayTracingV2` kernel
2. CB 参数 3 个 vec4 装满 §7.2 列出的 11 个字段
3. Dispatch ceil(W/8) × ceil(H/8) groups，8×8 thread
4. 同时跑 `HGLowResDirectionalShadowPass`（§8）输出低分辨率 mask + 2 pass Gaussian blur
5. 最后 `ScreenSpaceShadowResolveMaterial` 合成

### 11.5 Capsule Shadow
1. CPU：收集 `HGCapsuleShadows.capsuleShadowHelpers` → 平摊到 4 NativeArray<Vector4>
2. GPU pass A：DownSampleDepth → 1/4 depth
3. GPU pass B：球 mesh 实例 × N capsule，绘制到 visibilitySHRT，逐 fragment：
   - 用 visibilityABLut 查 AB 拟合
   - 用 visibilitySHLut 查 SH basis 投影
   - 解析积分 capsule × spherical light 得 SH coefficient
   - log 域累加避免 saturation
4. Light loop 里 `visibility = SHEvaluate(N, sh)` 乘进 shadowAttenuation

### 11.6 难点 / 依赖
- **Burst Job** 必须用 NativeArray + `[ReadOnly]/[WriteOnly]` 标签，否则会同 frame 数据冲突
- **LRUCache** 与 `Dictionary<Vector3Int,int> m_cachedTilesDict` 双向同步（evict 时要 Remove
  字典 entry，否则 stale 索引）
- **CB 段 padding** 必须按 16 byte 对齐，否则 D3D 报错
- shader 端 PCSS 需打开 `SHADOW_USE_DEPTH_BIAS` 宏，PCSS 算法依赖 reversed-Z 配置（HG 反编译
  里看不到 keyword，需在 .shader 里确认）

---

## 12. 支撑证据

### 12.1 ConstantBuffer 字段表（核心）

| 段 | 字段 | 类型 | 字节数 | 备注 |
|---|---|---|---|---|
| CSM | `_CSMWorldToShadow` | float[80] | 320 | 4 矩阵 × 20 float (16 主体 + 4 元数据) |
| CSM | `_CSMShadowSplitSpheres` | float[16] | 64 | 4 个 Vector4 |
| CSM | `_CSMShadowBiases` | float[16] | 64 | 4 个 Vector4 |
| CSM | `_CSMShadowAtlasParams` | float[16] | 64 | 4 个 Vector4 |
| CSM | `_CSMShadowTexelSize` | Vector4 | 16 | rcp(atlas size) |
| CSM | `_CSMPenumbraSizes` | Vector4 | 16 | PCSS 软度 |
| CSM | `_DirectionalShadowParams` | Vector4 | 16 | depth/normal bias 等 |
| CSM | `_DirectionalShadowParams2` | Vector4 | 16 | 备用 |
| CSM | padding | float[112] | 448 | — |
| Punctual | `_PunctualLightWorldToShadow` | float[896] | 3584 | 56 矩阵 |
| Punctual | `_PunctualLightShadowParams` | float[224] | 896 | 56 × Vector4 |
| Punctual | `_PunctualLightShadowParams2` | float[224] | 896 | 56 × Vector4 |
| Punctual | `_PunctualLightShadowTexelSize` | Vector4 | 16 | — |
| Punctual | padding | float[188] | 752 | — |
| Character | `_CharacterWorldToShadow` | float[240] | 960 | 15 矩阵 |
| Character | `_CharacterShadowBiases` | float[60] | 240 | 15 × Vector4 |
| Character | `_CharacterShadowLightDir` | float[60] | 240 | 15 × Vector4 |
| Character | `_CharacterShadowAtlasParams` | float[60] | 240 | 15 × Vector4 |
| Character | `_CharacterShadowTexelSize` | Vector4 | 16 | — |
| Character | `_CharacterShadowParams` | Vector4 | 16 | — |
| Character | padding | float[84] | 336 | — |
| ASM | `_ASMWorldToShadowBaseMatrix` | Matrix4x4 | 64 | light view*ortho proj |
| ASM | `_ASMIndirectWorldToShadow` | Matrix4x4 | 64 | 间接版 |
| ASM | `_ASMParams` | Vector4 | 16 | tile size, grid size, ... |
| ASM | `_ASMParams2` | Vector4 | 16 | — |
| ASM | `_ASMShadowTexelSize` | Vector4 | 16 | rcp(atlas size) |
| ASM | `_ASMIndirectParams` | float[512] | 2048 | 256 tile × 2 Vector4 |

### 12.2 单元源文件清单（C07_ShadowASM, 28 文件）

| 文件 | 一句话职责 |
|---|---|
| `ASMTile.cs` | ASM tile POD 结构：光空间 AABB + 状态位 + VT 槽索引 |
| `ASMTileManager.cs` | ASM tile 池 (256 上限) + Burst Job (visibility/score) + LRU + Dict |
| `ASMUtils.cs` | SAT 相交、距离剔除、tile coords ↔ key 编解码（hash key 32bit） |
| `AtlasMaxRect.cs` | MaxRects 矩形装箱（角色/punctual atlas 复用，ASM 不用） |
| `CapsuleShadowPassConstructor.cs` | Capsule Visibility-SH pass + DownSampleDepth pass 构建 |
| `CascadeEndBorderParameter.cs` | CSM 末端 blend border 的 VolumeParameter |
| `CascadePartitionSplitParameter.cs` | CSM 级联分割比例 VolumeParameter (clamp 在前后级之间) |
| `ContactShadowPassConstructor.cs` | Contact Shadow pass：屏空 ray-march + RayTracingV2 kernel |
| `ContactShadowVolume.cs` | Contact Shadow 的 VolumeComponent（5 参数） |
| `HGASMManager.cs` | 每相机的 ASM manager：frustum verts、light view、双缓冲（friend manager） |
| `HGASMVirtualTextureAllocator.cs` | 16×16 = 256 VT 槽分配 + LRU evict + ASMVTData |
| `HGCapsuleShadowContainer.cs` | 单胶囊：root + radius/height + offset/rotation + 强度 |
| `HGCapsuleShadowHelper.cs` | 角色挂件：14 骨骼自动生成胶囊串 (腿/臂/躯/头) |
| `HGCapsuleShadowManager.cs` | 全局 capsule 列表 → 4 NativeArray<Vector4> + matrix array |
| `HGCapsuleShadows.cs` | 全局单例 List + Enqueue/Dequeue |
| `HGCloudShadowConfig.cs` | 云影叠加（贴图 + 移动方向/速度 + 距离 UV 缩放） |
| `HGDisableDirectionalShadowComponent.cs` | 区域内禁用 CSM 的标记组件 |
| `HGLowResDirectionalShadowPass.cs` | 1/4 分辨率方向阴影 + 双向 Gaussian blur |
| `HGShadowConfig.cs` | 阴影 Env 配置（CSM bias、ASM Y 范围、Contact 参数） |
| `HGShadowConstantBufferUtils.cs` | 单一巨大阴影 CB 段化（CSM/Punctual/Character/ASM 4 段） |
| `HGShadowManager.cs` | 整阴影派生：CSM cull + character shadow + 提交 ShadowPassData |
| `HGShadowSampleMode.cs` | PCF 采样 5 档枚举 (Hard/Average/3x3/5x5/DPCF_16) |
| `HGShadowSampleModeParameter.cs` | 上一项的 VolumeParameter 包装 |
| `HGShadowSettings.cs` | Shadows VolumeComponent（CSM bias/intensity/ramp/character bias 等） |
| `HGShadowUtils.cs` | ExtractDirectionalLightData (Unity cull API)、asfloat/asint/asuint |
| `ScreenSpaceShadowMaskPassConstructor.cs` | 整张阴影 mask 合成（5 输入：depth+gbuffer+lowRes） |
| `ShadowResult.cs` | RenderGraph TextureHandle 容器 (directional/character/punctual 三 mask) |
| `ShadowUpdateMode.cs` | 阴影更新模式：EveryFrame / OnEnable / OnDemand（与 HDRP cached 同源） |

### 12.3 关键反汇编引用索引

| 现象 | 文件 :函数 | 行偏移 | 反汇编依据 |
|---|---|---|---|
| ASM tile ctor `mins = (x,y)*gridSize` | `ASMTile.cs` ctor | `0x18A8AD580` | `mulss xmm1,xmm3; mulss xmm0,xmm3; unpcklps xmm0,xmm1` |
| Tile coords → key | `ASMUtils.TileCoordsToKey` | `0x18A8ADB8C` | `shl ecx,0Fh; add ecx,[rbx+4]; lea eax,[rax+rcx*4]; add eax,0x80010000` |
| Key → tile coords | `ASMUtils.KeyToTileCoords` | `0x18A8ADAEC` | `mov ecx,0x20000; cdq; idiv ecx; sub eax,0x4000` |
| SAT 8 轴相交 | `ASMUtils.IsTileFrustumIntersecting` | `0x18A8AD78C` | 5 顶点 trivial-out + 8 边投影 dot + comiss min/max |
| ASM tile 距离 | `ASMUtils.ASMTileDistance` | `0x18A8AD680` | `mulss xmm7,[g_18C471424]` (0.7071) 减半对角 |
| Tile create with gridSize | `ASMTileManager.CreateTilesThisFrame` | `0x18A8AAFA0` | `subss xmm0,xmm9; divss xmm0,xmm7` → floor 网格化 |
| Tile score + refinement penalty | `ASMTileManager.CalculateTileScoresJob` | `0x18A8ADCB8` | `imul ecx,eax,sub_186A0` (×100000) |
| VT data ctor (16×16 UV) | `HGASMVirtualTextureAllocator.ASMVTData..ctor` | `0x18A8ADBF8` | `idiv 16; mulss xmm0,1/16; call Vector2 op_Addition` |
| ASM allocate + LRU | `HGASMVirtualTextureAllocator.AllocateTile` | `0x18A8B3618` | `call HG.Rendering.Runtime.LRUCache::Allocate` + dict remove/add |
| LRU Reset 容量 | `ASMTileManager.InvalidateAllTiles` | `0x18A8AC67C` | `mov edx,0x80; call HG.Rendering.Runtime.LRUCache::Reset` (128) |
| Contact Shadow 平台门 | `ContactShadowPassConstructor.PrepareDataForContactShadow` | `0x18A71B104` | `cmp eax,0x11 (Switch) / 0x0B (Metal)` |
| Capsule init 4 NativeArray | `HGCapsuleShadowManager.Initialize` | `0x18A8B4858` | 4 × `Unity.Collections.NativeArray<Vector4>..ctor` size=0x100 |

---

> **完结**：本蓝图覆盖 HG.RenderPipelines C07_ShadowASM 单元 28 文件全部核心算法（CSM/PCSS
> 同源 HDRP `HDShadowSampling.hlsl/HDPCSS.hlsl/HDShadowAlgorithms.hlsl`；ASM VT / 16×16 LRU /
> SAT 8 轴 / 256 tile budget 据反编译 1:1 重建；Contact Shadow 同源 HDRP `ContactShadows.compute`
> + HG `RayTracingV2` kernel + 平台门 delta；LowResDirectionalShadow + Capsule
> Visibility-SH 为 HG 自研，公式据反编译字段 + 领域知识重建）。其它实现细节交叉参考
> [`../02-CoreAlgorithms/01-CoreAlgorithms.md` §13](../02-CoreAlgorithms/01-CoreAlgorithms.md)。
