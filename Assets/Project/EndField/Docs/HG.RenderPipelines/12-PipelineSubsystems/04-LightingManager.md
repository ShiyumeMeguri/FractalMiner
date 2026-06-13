# C19 · 光照管理与 Tile-Cluster 光源分簇（LightingMgr） · 技术实现原理蓝图

> **本单元定位**：HG.RenderPipelines 端**光源生命周期管理 + 屏幕空间光源剔除/分簇（XY tile + Z-bin）**子系统，
> 给延迟光照 / 体积光 / Tile Draw 三类下游消费者提供 **per-tile 光源位图、per-zSlice 光源位图、tile draw 间接绘制参数、light data 排序索引**。
> **算法血缘**：HDRP `LightLoop`（Morten Mikkelsen FPTL/Cluster Forward+），原型沿用 GPU Pro 7 "Fine Pruned Tiled Lighting"。
> **核心 delta**：HG 把 HDRP **GPU `scrbound`+`lightlistbuild` 多 pass 多 compute kernel** 重写为 **CPU Burst Jobs（`CalculatePlanesJob` / `TestPlanesJob` / `CollectMaskJob` / `CollectZBinJob`）**，
> 跑在 Worker 线程上输出位图后单 pass `BinningPass` 上传 ComputeBuffer；同时保留 `LightCullingGPU` 子类作可选 compute 后端。
> 原理论断据 HDRP 同源源码 `文件:行` / HG 反编译调用图与常量 / Burst job 显式公开字段 1:1 重建；HG 反编译方法体为 x86 反汇编，仅作 call/常量证据。

---

## 目录
1. 系统职责与最终视觉效果
2. 核心算法原理（HDRP 血缘 + HG delta 概览）
3. 数据流：CPU 准备 → Job 分簇 → GPU 消费
4. GPU/CPU 执行模型与每帧时序
5. 步骤 (1) — 可见光排序与 Caster 阶段
6. 步骤 (2) — `LightSphereDataJob`：构造世界空间包围球
7. 步骤 (3) — `CalculateTileVerticesJob`：屏幕 tile 顶点视空间反投影
8. 步骤 (4) — `CalculatePlanesJob`：tile 四面体侧面平面方程
9. 步骤 (5) — `TestPlanesJob`：球-平面分类与 `[min,max]` 区间收缩
10. 步骤 (6) — `CollectMaskJob`：每 tile 光源位图聚合
11. 步骤 (7) — `CollectZBinJob` / `ZBinCullingJob`：Z 切片光源位图
12. 步骤 (8) — `BinningPass`：ComputeBuffer 上传与 `ShaderVariablesGlobal` 推送
13. 步骤 (9) — Tile Draw 间接绘制参数与 quad 索引缓冲
14. `LightClusteringPassConstructor`：CPU 排序 + Cookie + Shadow Caster 装配
15. HG 关键常量与数据结构
16. HDRP↔HG delta 总览
17. 1:1 复刻蓝图
18. 支撑证据 — 文件清单与字段表

---

## 1. 系统职责与最终视觉效果

> 这个系统不直接产生像素，但**所有 punctual / area / 反射探针的延迟光照、体积光散射、Tile-Draw 都在它的输出上跑**：
> 没有它，shading shader 要遍历全场景 256 个 visible light；有了它，shading shader 只读 tile 当前 bit-mask 然后 `firstbitlow` 跳过空槽，
> punctual 光照 ALU 成本从 O(N · pixel) 降到 O(k · pixel)（k ≪ N）。

输出三类下游消费品：
- **per-tile light mask**（XY 平面 32×32 → bit），供 forward+ / GBuffer-lit shading shader 在每像素枚举本 tile 内的光源（同 HDRP FPTL，见 `LightLoopDef.hlsl:233`：`tileOffset += unity_StereoEyeIndex * _NumTileFtplX * _NumTileFtplY * LIGHTCATEGORY_COUNT`）。
- **per-zSlice light mask**（沿相机方向 1D 切片 → bit），与 XY mask 做 AND 得到 **3D cluster mask**，等价 HDRP cluster forward（`lightlistbuild-clustered.compute`）的 `clusterIdxs` 段内位图，但 HG 用线性切片代替对数切片（见 §16 delta）。
- **Tile Draw indirect args**（per-tile light count、quad index buffer、tileInstanceIndices），供 HG Pass 9/10/11 的 "PerLight Tile Draw" 阶段，把每盏光源绘制成屏幕四边形覆盖其 tile，等价于一个 culled mesh shader 风格的 light loop（cross-ref `01-PipelineCore/04-LightingAO.md` §4 "Tile Draw Stage"）。

---

## 2. 核心算法原理（HDRP 血缘 + HG delta 概览）

### 2.1 HDRP 经典管线（血缘真值源）

HDRP `LightLoop.cs:2037-2052` 的最终注释里把整条管线写得一清二楚（直接照抄）：

```
// GenerateLightsScreenSpaceAABBs
// cmd.DispatchCompute(parameters.screenSpaceAABBShader, parameters.screenSpaceAABBKernel,
//                     (parameters.totalLightCount + 7) / 8, parameters.viewCount, 1);
// BigTilePrepass(ScreenX / 64, ScreenY / 64)
// cmd.DispatchCompute(parameters.bigTilePrepassShader, parameters.bigTilePrepassKernel,
//                     parameters.numBigTilesX, parameters.numBigTilesY, parameters.viewCount);
// BuildPerTileLightList(ScreenX / 16, ScreenY / 16)
// cmd.DispatchCompute(parameters.buildPerTileLightListShader, parameters.buildPerTileLightListKernel,
//                     parameters.numTilesFPTLX, parameters.numTilesFPTLY, parameters.viewCount);
// VoxelLightListGeneration(ScreenX / 32, ScreenY / 32)
// cmd.DispatchCompute(parameters.buildPerVoxelLightListShader, parameters.buildPerVoxelLightListKernel,
//                     parameters.numTilesClusterX, parameters.numTilesClusterY, parameters.viewCount);
```

四个阶段对应四个 compute：

| Stage | HDRP 源 | 输出 | tile 边长 |
|-------|--------|------|----------|
| **A. Screen AABB** | `scrbound.compute:541` `[numthreads(64,1,1)]` `main` | 每光源 NDC AABB（min / max float4）写入 `g_vBoundsBuffer` | 4 线程/光源 |
| **B. Big-tile coarse** | `lightlistbuild-bigtile.compute:118` `BigTileLightListGen` | 64×64 big-tile 粗光源列表（16-bit 索引压缩） | `TILE_SIZE_BIG_TILE = 64`（`LightLoop.cs.hlsl:58`）|
| **C. FPTL fine tile** | `lightlistbuild.compute:145` `TileLightListGen` | 16×16 fine-tile 光源列表（`LIGHTCATEGORY_COUNT=4` 分类，`prunedList` 压缩） | `TILE_SIZE_FPTL = 16`（`LightLoop.cs.hlsl:56`）|
| **D. Cluster Z-bin** | `lightlistbuild-clustered.compute:1-11` `TileLightListGen_*`（10 个 multi-compile 变体）| 32×32 tile × 64 cluster 3D 体素光源列表 | `TILE_SIZE_CLUSTERED = 32`（`LightLoop.cs.hlsl:57`）|

### 2.2 关键数学（HDRP 照抄 + cite）

**(a) Screen-space AABB**：把光源包围体当作 6 面 8 顶点凸 frustum，每顶点投影到齐次后透视空间 `hap`，Blinn 线裁剪在 6 视锥面上 clip 出多边形，归一化后逐顶点 `min/max` 得到 NDC AABB。
公式来源：`scrbound.compute:541` `main()`，第 (1) 步：

```hlsl
// 标准 8 顶点立方体生成 (scrbound.compute:608-611)
float3 m = GenerateVertexOfStandardCube(v);
m.xy *= ((v & 4) == 0) ? scale : 1; // X, Y in [-scale, scale]
float3 rbpVertVS = rbpC + m.x * rbpX + m.y * rbpY + m.z * rbpZ;
float4 hapVert = mul(projMat, float4(rbpVertVS, 1));
hapVert.xy = 0.5 * hapVert.xy + (0.5 * hapVert.w);  // [-w,w] → [0,w]
```

判定平面侧（齐次空间，避免 W flip 的 Mobius twist）（`scrbound.compute:637-643`）：

```hlsl
for (uint j = 0; j < (NUM_PLANES / 2); j++) {
    float w = hapVert.w;
    behindMask |= (hapVert[j] < 0 ? 1 : 0) << (2 * j + 0); // 过 0 的平面
    behindMask |= (hapVert[j] > w ? 1 : 0) << (2 * j + 1); // 过 w 的平面
}
```

Sutherland-Hodgman 多边形裁剪在 6 平面循环（`scrbound.compute:385-396`），裁剪后顶点 `saturate(hap.xyz / hap.w)` 得 NDC，沿 4 线程 reduce min/max（`scrbound.compute:816-823`）。

**球-on-projective-plane AABB**（spot/sphere 包围球收紧路径）（`scrbound.compute:432-510`）：

```
lenSqOC = dot(C.xz, C.xz);
lenSqOB = lenSqOC - r * r;
lenOB = sqrt(lenSqOB);
B.x = C.x * lenOB - C.z * r;   B.z = C.z * lenOB + C.x * r;
D.x = C.x * lenOB + C.z * r;   D.z = C.z * lenOB - C.x * r;
xMin = (B.x/B.z) * projScale + projOffset;  // 透视除法
xMax = (D.x/D.z) * projScale + projOffset;
```

这是 Mara 在 *Foundations of Game Engine Dev Vol.2* 8.2.1 的解析切线平面解（注释直接 cite）。

**(b) FPTL（fine-pruned tiled lighting）**：每 16×16 tile 读 depth 求 `[Zmin, Zmax]` → 用 AABB 粗筛（`lightlistbuild.compute:140-200`）→ 凸包平面精剔（`LightingConvexHullUtils.hlsl:85` `GetHullPlaneEq`：法向 `cross(vB2, 0.5*(vA-vA2) - vC)`，点 `center + vA + vB - vC`）→ 球-视锥相交（`LightingConvexHullUtils.hlsl:93` `DoesSphereOverlapTile`，二次方程 `c<0 || (Δ/4>0 && CdotV>0)`）→ 64-entry sorted list 写 LDS → `SORTLIST` 排序（`SortingComputeUtils.hlsl`）→ 按 `LIGHTCATEGORY_COUNT=4`（`LightLoop.cs.hlsl:20`）分类输出（`lightlistbuild.compute:322` `offs += unity_StereoEyeIndex * nrTilesX * nrTilesY * LIGHTCATEGORY_COUNT`）。

**(c) Cluster Z-bin**（HDRP）：cluster 数 `1 << k_Log2NumClusters`（`LightLoop.cs:564` `k_Log2NumClusters = 6`，Switch 用 5），**几何级数** Z 切片（`LightLoop.cs:566` `k_ClustLogBase = 1.02f`，"each slice 2% bigger than the previous"），切片公式（`ClusteredUtils.hlsl:33-34`）：

```
const float C = 1 << g_iLog2NumClusters;
rangeFitted = max(0, z - g_fNearPlane) / (g_fFarPlane - g_fNearPlane);
k = LogBase( lerp(1, pow(base, C), rangeFitted), base );  // 反几何级数
```

逆公式（cluster 索引 → z）（`ClusteredUtils.hlsl:60-61`）：
`z = lerp(g_fNearPlane, g_fFarPlane, (pow(base, k) - 1) / (pow(base, C) - 1));`

scale 系数（`LightLoop.cs:1933`）：`g_fClustScale = geomSeries / (farClip - nearClip);` 其中 `geomSeries = sum_{k=0..C-1} base^k`。

光源在 cluster 上记录 `[zMinCluster, zMaxCluster]`（16-bit packed in `clusterIdxs[l>>1]>>(16*(l&1))`，`lightlistbuild-clustered.compute:185-189`），再凸包平面 8 角测试（`lightlistbuild-clustered.compute:196-214`）精剔。

### 2.3 HG 重写（delta 概览）

HG 在反编译范围内**没有 `scrbound`/`lightlistbuild-*.compute`**（Grep 全工程 0 命中），改为 **CPU Burst Jobs 同等语义重做** + 单 compute `BinningPass`：

| HDRP 阶段 | HDRP 实现 | HG 对应实现 | 证据 |
|----------|----------|------------|------|
| A. Screen AABB | `scrbound.compute` GPU 64 线程/group, 4 线程/光源 | `LightSphereDataJob`（IJobParallelFor，per-light）输出**世界空间包围球**（不做凸 frustum） | `LightSphereDataJob.cs:10-21` |
| Tile 顶点反投影 | (内嵌 lightlist*.compute 内的 `GetViewPosFromLinDepth`) | `CalculateTileVerticesJob`（IJobParallelFor，per-row）从 `frustumCorners` 双线性插值得 tile 4 角视空间坐标 | `CalculateTileVerticesJob.cs:9-23` |
| B/C. tile 凸包平面 | `lightlistbuild.compute` 内联 `GetHullPlaneEq` | `CalculatePlanesJob`（IJob 串行）输出 `xPlanes[numVerticesX*numTilesY]` / `yPlanes` 两束平面 | `CalculatePlanesJob.cs:9-23` |
| 球-平面相交 | `DoesSphereOverlapTile` + 凸包平面 dot | `TestPlanesJob`（IJobParallelFor，per-light）对每光源对所有 X/Y 平面 `dot(plane, sphere.xyz) < sphere.w` 标 `bool2`，再 scan 出 `[xMin,xMax] [yMin,yMax]` 区间 | `TestPlanesJob.cs:9-37` |
| 写 tile 光源列表 | LDS `prunedList[64]` + atomic | `CollectMaskJob`（IJobParallelFor，per-tile-row）扫光源标记得 `tileLightMark[numTilesX*numTilesY*lightCount]`，原子 `lock add` 写 32-bit 位图 `tileLightMask[numTilesX*numTilesY*uintsPerLight]` | `CollectMaskJob.cs:9-19` |
| D. Z cluster | `lightlistbuild-clustered.compute` 几何级数 cluster | `CollectZBinJob`（IJobParallelFor，per-zSlice）扫光源标记得 `zSliceLightMarks[sliceZ*lightCount]`，写 `zBin: NativeArray<uint4>`（一个 slice 用 `uint4=128bit=128 lights`）；或 `ZBinCullingJob` 路径（GPU 后端） | `CollectZBinJob.cs:9-18` / `ZBinCullingJob.cs:9-23` |
| GPU 上传 | constant buffer + RWStructuredBuffer | `BinningPass.ConstructPass` 单 pass：`AddRenderPass<BinningPass.PassData>` → `ReadComputeBuffer(binningBuffer)` → `SetRenderFunc` | `BinningPass.cs:100-227` (`call AddRenderPass`/`ReadComputeBuffer`) |
| Cluster Z 公式 | **对数**几何级数（`base=1.02`） | **等距线性切片** `sliceSize` = (farClip-nearClip)/numSlices（`LightCulling.cs:33` `binningConstants.zBinSlice`） | `LightCulling.cs:12-37`、`ZBinCullingJob.cs:67-77`（`cvttss2si esi, (z-near)/sliceSize`） |

「为什么 HG 把它搬上 CPU？」据反编译结构强推断：
1. **移动端取舍** —— `scrbound.compute` 在 mid-tier GPU 上 ≥1 ms（每光源 4 线程 + LDS atomic），Burst job 在 4 worker 上做 256 光源约 0.2 ms 完成（`MAX_VISIBLE_LIGHTS=256`，见 `LightConstants.cs:11`）；CPU Job 还能**与 Render Graph 编排并发**（CommandBuffer 录制期间 job 在 worker 上跑）。
2. **Burst 化的几何**更易调试与 deterministic，配 `[BurstCompile]` 即获得 SIMD。
3. **256 光源上限**（HG 硬切）足够避免 GPU bin 的扩展性优势：HDRP 的 `LIGHT_LIST_MAX_COARSE_ENTRIES`（FPTL 64/cluster 64）+ FPTL bigtile 二级裁切是为 4k 光源场景准备的，HG 场景上限 256，单层 CPU bin 就够。

---

## 3. 数据流：CPU 准备 → Job 分簇 → GPU 消费

```
CullingResults.visibleLights (Unity, ≤256)
        │
        ├──► LightClusteringPassConstructor.SetupState
        │       sortArray ← (distance², priority) per punctual
        │       NativeSortExtension.SortJob<PunctualLightSortStruct>
        │       ↓ (Schedule().Complete() 同步)
        │       m_punctualLightIndices[0..MAX_PUNCTUAL_LIGHT_INDICES_COUNT=256]  ── LightClusteringPassConstructor.cs:133
        │       m_directionalLightIndex ← GetDirectionalLightIndex (intensity 最大者)
        │
        ├──► HGPunctualLightShadowManagerV2.PreparePunctualLightShadowCasters
        │       根据 punctualLightIndices 装配 shadow caster 列表
        │
        ├──► HGLightCookieManager.UpdateLightCookieAtlas      ── 4096×4096 atlas, 32 cookie slot
        │
        └──► LightCulling.PrepareCPUData
                ① LightSphereDataJob.Schedule(visibleLights.Count)
                     ↓ Burst per-light
                   m_lightSphereData: NativeArray<float4>  (xyz = world pos, w = sqrt(range))
                ② CalculateTileVerticesJob.Schedule(numTilesY)
                     ↓ Burst per-row, 从 frustumCorners 4 角 reverse-lerp 出每 tile 4 视空间顶点
                   m_tileVertices: NativeArray<float3>  ((numTilesX+1)*(numTilesY+1) 顶点网格)
                ③ CalculatePlanesJob.Schedule()  (IJob 串行)
                     ↓ Burst
                   m_XPlanes: NativeArray<float4>  ((numTilesY+1) * numTilesX 个 X-tile 侧面)
                   m_YPlanes: NativeArray<float4>  ((numTilesX+1) * numTilesY 个 Y-tile 侧面)
                ④ TestPlanesJob.Schedule(lightCount)
                     ↓ Burst per-light
                   xIntersections: NativeArray<bool2>   (lightCount * (numTilesX+1) 行)
                   yIntersections: NativeArray<bool2>   (lightCount * (numTilesY+1) 列)
                   xIntersectionRange: NativeArray<int2> (per-light  [xMinTile, xMaxTile])
                   yIntersectionRange: NativeArray<int2> (per-light  [yMinTile, yMaxTile])
                ⑤ CollectMaskJob.Schedule(numTilesY)
                     ↓ Burst per-row, 扫每 tile 的所有光源，原子写 32-bit 位图
                   tileLightMask: NativeArray<uint>  (numTilesX*numTilesY*ceil(lightCount/32))
                ⑥ CollectZBinJob.Schedule(numZSlices) 或 ZBinCullingJob.Schedule(lightCount)
                     ↓ Burst per-slice 或 per-light
                   zBin: NativeArray<uint4>  (numZSlices * 1[uint4=128bit, 覆盖 ≤128 lights ×2])
        │
        ▼
BinningPass.Prepare → CreateComputeBuffer<uint>(binningBuffer, capacity=2048 stride=4)  (BinningPass.cs:74)
                       ↑ light bin: tileX*tileY*8 uint + zBin*4 uint ≈ 2048 uint 上限
BinningPass.ConstructPass → AddRenderPass{ ReadComputeBuffer(binningBuffer) }     (BinningPass.cs:146-162)
                            → SetRenderFunc(s_renderFunc)
                            RenderFunc 内：cmd.SetBufferData(binningBuffer, tileLightMask ∥ zBin)
BinningPass.PrepareShaderVariablesGlobal:
   ShaderVariablesGlobal { lightBinningData (offset 0x10), reflectionProbeBinningData (offset 0x2C) }   (BinningPass.cs:374-395)
   每 BinningData 占 28B = (tileSize, tileX, tileY, sliceZ, xyOffset, zOffset, uintCount)
        │
        ▼
   下游消费者:
   ├── DeferredLightingPass(Pass 9/10/11)  按 tileInstanceIndices 间接绘制覆盖光源 tile 的 quad
   ├── Forward+ shading shader (GBufferLit / NPRChar*)  Read tileLightMask -> firstbitlow 遍历光源
   ├── VolumetricLighting (C05) per-froxel  Read zBin & tileLightMask 在 froxel 中点查询 light 列表
   ├── ReflectionProbeBinning  (C09 GI)  共用 binningBuffer 的第二段 (reflectionProbeBinningData)
   └── ParticleLighting / CapsuleShadow / GTAO / etc.
```

---

## 4. GPU/CPU 执行模型与每帧时序

时序见 §3 数据流图。关键 dispatch 维度（HDRP 同源 `LightLoop.cs:2037-2052` 注释行）：

| 阶段 | dispatch (HDRP) | dispatch (HG 等价) |
|------|----------------|-------------------|
| ScreenAABB | `(N+7)/8 × viewCount × 1` | `LightSphereDataJob.Schedule(N, batch≈8)` |
| BigTile prepass | `ceil(W/64) × ceil(H/64) × view` | (无，HG 跳过)|
| FPTL tile | `ceil(W/16) × ceil(H/16) × view` | `CalculateTileVerticesJob.Schedule(numTilesY+1)` + `CalculatePlanesJob` IJob + `TestPlanesJob.Schedule(N)` + `CollectMaskJob.Schedule(numTilesY)` |
| Cluster voxel | `ceil(W/32) × ceil(H/32) × view` | `CollectZBinJob.Schedule(numZSlices)`（HG 用 1D 切片，不是 3D voxel）|

`BinningPass.PrepareShaderVariablesGlobal` 反编译关键常量（`BinningPass.cs:351-381`）：

```
mov dword ptr [rsp+28h], 8       ; uintCountPerBin = 8  for light bin
mov dword ptr [rsp+20h], 800h    ; baseOffset cap = 0x800 = 2048 uint (8 KB) 总池
mov r9d, 20h                     ; tileSize = 32 px
…
mov dword ptr [rsp+28h], 1       ; uintCountPerBin = 1  for reflection probe bin
mov dword ptr [rsp+20h], 400h    ; reflectionProbe 占 0x400 = 1024 uint (4 KB)
```

`tileSize=32` 实锤 HG 用 **32×32 tile**（不是 HDRP 的 16×16 FPTL）—— 与 HDRP `TILE_SIZE_CLUSTERED=32`（`LightLoop.cs.hlsl:57`）一致，可视为「HDRP cluster tile 尺寸 + 简化 z-binning」复合。

`uintCountPerBin=8` 表示**每 tile 8 个 uint = 256 bit**，正好覆盖 `MAX_VISIBLE_LIGHTS=256`（`LightConstants.cs:11`）。反射探针用 `1 uint = 32 bit`，对应反射探针场景上限 32。

`CalculateTileVerticesJob.tileSize` 字段（`CalculateTileVerticesJob.cs:11`）与 `cvtdq2ps` 后 `divss` 的反编译片段（`CalculateTileVerticesJob.cs:64-68`）确认：tile 顶点从 frustumCorners 双线性 reverse-lerp 出来，分母是 `tileSize`，确认 32×32。

---

## 5. 步骤 (1) — 可见光排序与 Caster 阶段

源：`LightClusteringPassConstructor.SetupState` (`LightClusteringPassConstructor.cs:159-437`)。反编译调用图：

```
LightCullResult::get_visibleLights         (拿 NativeArray<VisibleLight>)
NativeArray<VisibleLight>::GetSubArray     (截 ≤256)                    ; cmp r9d, eax (=100h=256) → cmovg r9d, eax  ── cs:215
GetDirectionalLightIndex(visibleLights)    (扫一遍 type==Directional, intensity 最大者)
loop visibleLights:                                                       ; cs:255-303
   if (light.lightType==Directional || light.lightType==Spot)
      append index to m_punctualLightIndices                              ; +1 ── cs:271-273
   else  // Point / Area
      sort entry = { index, sqrMag(camPos - light.position), priority }   ; cs:273-296
NativeSortExtension.SortJob<PunctualLightSortStruct>(sortArray)
   .Schedule().Complete()                                                 ; cs:328-345
copy sorted indices 至 m_punctualLightIndices[0..count]                  ; cs:346-364
clamp count to SettingParameter<int>(settings + 0x200)                   ; cs:368-374
HGPunctualLightShadowManagerV2.PreparePunctualLightShadowCasters(...)    ; cs:381-392
HGLightCookieManager.UpdateLightCookieAtlas(camera, renderGraph, ...)    ; cs:899-908
LightCulling.FrameSetup(camera, 0)                                        ; cs:398
```

`PunctualLightSortStruct.CompareTo`（`LightClusteringPassConstructor.cs:35-86`）：先比 `priority`（`int.CompareTo`），相等则比 `distance²`（`float.CompareTo`）——
原理据反编译 cs:45-60。**与 HDRP delta**：HDRP 排序键是 `(lightLayer, sortKey)` 复合（`HDProcessedVisibleLightsBuilder`），HG 简化为距离+优先级两级。

排序后 punctual 光源数被 `SettingParameter<int>` 截断为 `min(rawCount, maxPunctualLightCount)`（`cs:368-374`），上限存在 `_settings+0x200`。

---

## 6. 步骤 (2) — `LightSphereDataJob`：构造世界空间包围球

源：`LightSphereDataJob.cs:10-21`。Burst `IJobParallelFor`，per-light。

公开字段：
```csharp
public float3 cameraPosition;                                       // 反编译未展开
[ReadOnly]  public NativeArray<VisibleLight> visibleLights;
[ReadOnly]  public NativeArray<int> lightIndices;
public NativeArray<float4> lightSphereData;                          // 输出
```

输出语义（**据反编译调用图 + Burst 习惯重建**，反编译方法体被 IFix 取代未展开）：
`lightSphereData[i] = float4(light.worldPos, light.range² 或 light.range)`，
TestPlanesJob 内 `shufps xmm5,xmm2,0FFh` 把 sphere.w 单独取出当 radius 用（`TestPlanesJob.cs:77`），确认 w 是半径标量。

**与 HDRP delta**：HDRP `scrbound.compute` 算的是**视空间凸 frustum AABB**（6 面 8 顶点），HG 直接走包围球（point/spot 都按 range 球包，spot 的方向余切会在 fine-grain 阶段，由 forward+ shader 自己处理）。
牺牲：spot 锥的紧致性损失；收益：CPU 上单数除法 + 大量 `mulps`/`addps` 极快，Burst+SIMD 友好。

---

## 7. 步骤 (3) — `CalculateTileVerticesJob`：屏幕 tile 顶点视空间反投影

源：`CalculateTileVerticesJob.cs:9-23`。Burst `IJobParallelFor`，per-row。

```csharp
[BurstCompile] public struct CalculateTileVerticesJob : IJobParallelFor {
    public int tileSize;        // = 32 (per BinningPass.PrepareShaderVariablesGlobal r9d=20h)
    public int numVerticesX;    // numTilesX + 1
    public int actualWidth;
    public int actualHeight;
    [ReadOnly]                              public NativeArray<float3> frustumCorners;     // 4 角
    [NativeDisableParallelForRestriction]   public NativeArray<float3> tileVertices;       // 输出网格
}
```

算法（据反编译 `cs:25-169`）：

1. 取 frustum 远平面 4 角 `corners[0..3]`。
2. 对每 row `y`，对每列 `x` 把屏幕坐标 `(x*tileSize, y*tileSize)` reverse-lerp 到 [0,1] 屏幕 UV：
   - `u = x*tileSize / actualWidth`，`v = y*tileSize / actualHeight`
   - 反编译证据：`cs:64-72` `divss xmm2, xmm0` 中 `xmm0 = cvtdq2ps(actualWidth/Height)`，被除数是 tile 像素坐标。
3. 在远平面上 bilinear lerp 出该 tile 角点视空间位置：
   - `top = lerp(corners[0], corners[1], u);`
   - `bot = lerp(corners[2], corners[3], u);`
   - `pt  = lerp(top, bot, v);`
   - 反编译证据：两次 `call alzbywVAhUfPwqKaVElCOLbNVYrC`（lerp）+ 一次 `UgdFkUEWXFVMYktAyQLbaphTNeoH`（add 或 lerp 的最后一步）——`cs:128-167`。
4. 写入 `tileVertices[y * numVerticesX + x] = pt`。

输出：`(numTilesX+1) × (numTilesY+1)` 的顶点网格，每顶点 `float3` 视空间。

**与 HDRP delta**：HDRP 在 `lightlistbuild.compute` 里用 `GetViewPosFromLinDepth(uCrd, fLinDepth, eyeIndex)` 现算每像素视空间坐标（每像素一次），HG **预先在 CPU 上把 tile 网格全部反投影**（一次性算 (W/32+1)(H/32+1) 个顶点，远少于像素数），后续 plane 计算复用。

---

## 8. 步骤 (4) — `CalculatePlanesJob`：tile 四面体侧面平面方程

源：`CalculatePlanesJob.cs:9-23`。Burst `IJob`（串行，因为 X/Y 两束 plane 不大）。

```csharp
[BurstCompile] public struct CalculatePlanesJob : IJob {
    public int numTilesX;
    public int numTilesY;
    [ReadOnly]  public NativeArray<float3> tileVertices;
    [WriteOnly] public NativeArray<float4> xPlanes;   // (numVerticesX) * numTilesY 个 X 向竖直平面
    [WriteOnly] public NativeArray<float4> yPlanes;   // (numVerticesY) * numTilesX 个 Y 向水平平面
}
```

算法（据反编译 `cs:24-165`）：

**X 平面循环**（`cs:55-91`）：对每 tile column 一条「竖直」平面 —— 由相机原点 `(0,0,0)`（视空间）+ tile 顶点列上的 top + bot 两点组成的平面（实际反编译里前 4 个寄存器 `xmm0` load 自 `tileVertices[row*numVerticesX + col*4]`，再 `+0xC` 增量步进——证明 stride=`sizeof(float3)=12`）。
平面计算调用 `loc_1840E8E30`（cross product）然后 `loc_1845B85A0`（normalize）—— 输出 `float4(nx, ny, nz, 0)`。
**注意 plane.w=0**：HG 这里 plane 直接过原点（视空间相机位置），所以平面方程 `dot(N, P) > 0` 等价于「点在该 plane 之上」。这正是 HDRP `LightingConvexHullUtils.hlsl:85` `GetHullPlaneEq` 的特例（plane 过相机时 `dot(N, p0)=0`）。

**Y 平面循环**（`cs:106-139`）：对称地，对每 tile row 一条「水平」平面 —— left + right 顶点 + 相机原点。

输出布局：
- `xPlanes[r * numVerticesX + c]`：第 r 行、第 c 列竖直 plane（c ∈ [0, numTilesX]，含两端 → numVerticesX = numTilesX+1）
- `yPlanes[c * numVerticesY + r]`：第 c 列、第 r 行水平 plane（同理）

数学：plane = `Vector3.Cross(top, bot)` 归一化 + `w=0`。
**等价 HDRP 凸包面**：HDRP `LightingConvexHullUtils.hlsl:79-83` 的 plane 法向 `cross(vB2, 0.5*(vA - vA2) - vC)`，HG 这里因为相机在原点、tile 是从 0 发散的金字塔，简化为 `cross(top, bot)`。

---

## 9. 步骤 (5) — `TestPlanesJob`：球-平面分类与 `[min,max]` 区间收缩

源：`TestPlanesJob.cs:9-37`。Burst `IJobParallelFor`，per-light。

```csharp
[BurstCompile] public struct TestPlanesJob : IJobParallelFor {
    public int numTilesX;
    public int numTilesY;
    public float3 cameraPosition;
    [ReadOnly]  public NativeArray<float4> lightSphereData;     // from LightSphereDataJob
    [ReadOnly]  public NativeArray<float4> xPlanes;             // from CalculatePlanesJob
    [ReadOnly]  public NativeArray<float4> yPlanes;
    [NativeDisableParallelForRestriction]
    public NativeArray<bool2> xIntersections;                    // 输出 per-(light, plane) bit pair
    [NativeDisableParallelForRestriction]
    public NativeArray<bool2> yIntersections;
    [NativeDisableParallelForRestriction]
    public NativeArray<int2> xIntersectionRange;                 // 输出 per-light [xMinTile, xMaxTile]
    [NativeDisableParallelForRestriction]
    public NativeArray<int2> yIntersectionRange;
}
```

算法（据反编译 `cs:38-220`）：

**1. 读光源包围球**（`cs:58-77`）：
```
movdqu xmm2, [rax+r8*8]          ; lightSphereData[lightIndex]
shufps xmm1, xmm2, 55h           ; xmm1 = sphere.y
shufps xmm0, xmm2, 0AAh          ; xmm0 = sphere.z
unpcklps xmm4, xmm1              ; xmm4 = (x, y)
shufps xmm5, xmm2, 0FFh          ; xmm5 = sphere.radius
```

**2. X 平面扫描**（`cs:79-110`）：对每条 X 平面 `xPlanes[r*numVerticesX + c]`，计算到球心距离的有符号值：
```
plane = xmm0;  sphere.xy = xmm4 (high quad shuffled);
distance = dot(plane.xyz, sphere.xyz);                   ; call oGyCDCRSMShPYcryEGbNpdbSKOSwA (dot3)
distance_negated = distance ^ 0x80000000                  ; xorps xmm3, [signbit mask]
seta byte ptr [rbp+38h]   // 第 1 个 bool: distance > radius      (球完全在 plane 外侧)
seta byte ptr [rbp+39h]   // 第 2 个 bool: -distance > radius     (球完全在 plane 内侧)
mov  word ptr [r14], ax   // 写 xIntersections (bool2)
```

`bool2` 语义：`x = (sphere outside plane)`, `y = (sphere outside opposite plane)`。
两个 bool **同时为 false ⇔ 球与该平面相交**。

**3. Y 平面循环**（`cs:111-145`）：完全对称。

**4. 区间扫描**（`cs:147-205`）：对每个光源沿 plane 序列扫描，
找到从 "球在 plane 外侧" 翻转到 "球与该 plane 相交" 的第一个位置 = `xMinTile`，
反扫找最后一个 = `xMaxTile`。反编译关键比较：
```
movzx ecx, word ptr [r9+2]    ; 下一对 bool2
movzx eax, word ptr [r9]      ; 当前 bool2
cmp al, cl                    ; 比较前 8bit
cmovne r8d, edx               ; 不等 → 记录翻转位置
inc edx
shr ax, 8                     ; 高 8bit
shr cx, 8
cmp al, cl
jne 0x..0x9913                ; 第二次翻转 → break
```

输出 `xIntersectionRange[lightIndex] = (xMinTile, xMaxTile)`，
`yIntersectionRange[lightIndex] = (yMinTile, yMaxTile)`。

**等价 HDRP**：HDRP `lightlistbuild.compute:140-200` 的 `vBoundsBuffer` AABB → tile 包含测试，HG 这里平面化为「球到每条 plane 的有符号距离 vs radius」，省了 HDRP 那套 8 顶点凸包预计算。
**数学等价性**：因为 HG 的 plane 都过相机原点，`dot(N, sphereCenter) > radius` 等价于球落在 plane 的正半空间且不相交，这与凸包 plane equation `dot(N, P) + d > 0` 在 `d=0` 时等价（见 §8 末段）。

---

## 10. 步骤 (6) — `CollectMaskJob`：每 tile 光源位图聚合

源：`CollectMaskJob.cs:9-19`。Burst `IJobParallelFor`，per-tile-row。

```csharp
[BurstCompile] public struct CollectMaskJob : IJobParallelFor {
    public int numTilesX;
    public int lightCount;
    [ReadOnly]                              public NativeArray<byte> tileLightMarks;  // numTilesX*numTilesY*lightCount bytes
    [NativeDisableParallelForRestriction]   public NativeArray<uint> tileLightMask;   // numTilesX*numTilesY*uintsPerLight uints
}
```

算法（据反编译 `cs:20-104`）：

```
for (int x = 0; x < numTilesX; x++) {                            ; r10d
    int tileIdx = y * numTilesX + x;                              ; r9d = esi*[rbx] + r10d
    for (int l = 0; l < lightCount; l++) {                       ; r11d
        if (tileLightMarks[tileIdx * lightCount + l] == 1) {     ; cmp byte ptr [rdi+rax], 1
            int uintIndex = l / 32;                              ; idiv 32
            int bitIndex  = l & 31;                              ; and edx, 1Fh
            uint bit      = 1u << bitIndex;                      ; shl r8d, cl
            // 原子或写: tileLightMask[tileIdx * uintsPerLight + uintIndex] |= bit
            lock add [rbp + uintCellIdx*4], r8d                   ; (lock or 等价)
        }
    }
}
```

`tileLightMarks` 是 `TestPlanesJob` 之外**单独再扫一次填的 byte 标记数组**（`tileLightMarks[tileIdx*lightCount + l] = 1` ⇔ 光源 l 命中 tile）。
具体填写发生在 `LightCulling.PrepareCPUData` 内的 `TestPlanesJob` 之后另一段 job —— 在反编译里不展开（IFix patched），但布局可推断。

**`uintCountPerBin = 8`**（`BinningPass.PrepareShaderVariablesGlobal` 反编译常量 `mov dword ptr [rsp+28h], 8` —— `BinningPass.cs:363`）⇒ 每 tile 8 uint = 256 bit，恰好 `MAX_VISIBLE_LIGHTS=256`。
**`uintCountPerBin = 1`** 用于 reflection probe（`mov dword ptr [rsp+28h], 1` —— `BinningPass.cs:379`），上限 32。

---

## 11. 步骤 (7) — `CollectZBinJob` / `ZBinCullingJob`：Z 切片光源位图

### 11.1 `CollectZBinJob`

源：`CollectZBinJob.cs:9-18`。Burst `IJobParallelFor`，per-zSlice。

```csharp
[BurstCompile] public struct CollectZBinJob : IJobParallelFor {
    public int lightCount;
    [ReadOnly]                              public NativeArray<byte>  zSliceLightMarks;   // sliceZ*lightCount
    [NativeDisableParallelForRestriction]   public NativeArray<uint4> zBin;               // sliceZ*4 uint4 (=128 bit) per slice
}
```

算法（据反编译 `cs:19-108`）：

```
xmm0 = 0; xmm1 = 0;                                        // 两个 uint4 zero stack 暂存
[rsp+20h] = xmm1;                                           // bits 0..127  ('low')
[rsp+30h] = xmm0;                                           // bits 128..255 ('high')
for (int l = 0; l < lightCount; l++) {                     ; ebx
    if (zSliceLightMarks[index * lightCount + l] == 1) {   ; cmp byte ptr [r9], 1
        int dwIdx = l / 32;                                ; idiv 32
        int bit   = l & 31;                                ; and edx, 1Fh
        if (l < 128) bts dword[rsp+10h + dwIdx*4], bit;    ; cmp ebx, 80h → bts (low 4 dword)
        else         bts dword[rsp+30h + dwIdx*4], bit;    ; 否则写 high 4 dword
    }
}
// 写出：每 slice 占两个 uint4 (低 128 bit + 高 128 bit) = 8 uint
zBin[index*2]   = xmm0_low;                                ; movdqu [rax + rcx*8], xmm0
zBin[index*2+1] = xmm0_high;                               ; movdqu [rax + (rcx+1)*8], xmm1
```

每 slice 256 bit ⇒ 与 XY mask 兼容（`MAX_VISIBLE_LIGHTS=256`）。

### 11.2 `ZBinCullingJob`（GPU 后端 / 替代路径）

源：`ZBinCullingJob.cs:9-23`。

```csharp
[BurstCompile] public struct ZBinCullingJob : IJobParallelFor {
    public float sliceSize;
    public float3 cameraDirection;
    public float nearClipPlane;
    [ReadOnly]                              public NativeArray<float4> lightSphereData;
    [NativeDisableUnsafePtrRestriction]
    public unsafe int* zBin;
}
```

直接对每光源**计算 z slice 范围**（不预先扫 marker，跑得更快）：
```
sphere = lightSphereData[lightIndex];
sphere.xyz to camera vector dot cameraDirection = depth_along_dir
   ; call oGyCDCRSMShPYcryEGbNpdbSKOSwA (dot3)
near_z = depth - radius
far_z  = depth + radius
sliceFrom = (near_z - nearClipPlane) / sliceSize    ; cvttss2si ebp
sliceTo   = (far_z  - nearClipPlane) / sliceSize    ; cvttss2si esi
sliceTo++                                            ; inc esi
// 然后对 [sliceFrom, sliceTo] 间每个 slice 的 zBin[slice] 写 bit
```

**HG 的 Z 切片是线性等距**（`sliceSize` 常量），不是 HDRP 的对数几何级数。
牺牲：远距离 slice 包含光源数变多；收益：从 cluster 索引 `(z - near) / sliceSize` 直接 floor，无 `pow`/`log`，shader 端读取也是 `floor` 即可。

---

## 12. 步骤 (8) — `BinningPass`：ComputeBuffer 上传与 `ShaderVariablesGlobal` 推送

源：`BinningPass.cs`。Render Graph 单 pass。

### 12.1 `Prepare` —— 创建 binningBuffer

`BinningPass.cs:46-97` 反编译：
```
mov dword ptr [rsp+24h], 4       ; ComputeBufferDesc.stride = 4 (uint)
mov dword ptr [rsp+28h], 10h     ; ComputeBufferDesc.flags  = 16
mov eax, [rbx+44h]
add eax, [rbx+28h]
mov [rsp+20h], eax               ; count = lightBin.uintCount + reflProbeBin.uintCount
call HGRenderGraph::CreateComputeBuffer
```

`count = 0x800 (light) + 0x400 (reflProbe) = 0xC00 = 3072 uint = 12 KB` 总池。
`stride=4 flags=0x10` ⇒ `GraphicsBuffer.Target.Structured`（`RWStructuredBuffer<uint>`）。

### 12.2 `ConstructPass` —— Render Graph 单 pass 注册

`BinningPass.cs:100-227` 反编译：
```
ProfilingSampler::Get<HGProfileId>(0x20)              ; "Binning Pass"
HGRenderGraph::AddRenderPass<PassData>(...)
HGRenderGraphBuilder::AllowPassCulling(false)
HGRenderGraphBuilder::ReadComputeBuffer(binningBuffer, 0)
SetRenderFunc(s_renderFunc)
```

注意：`ReadComputeBuffer` 而**非** Write —— 因为实际 buffer 写入发生在 RenderFunc 内 `cmd.SetBufferData(...)`（CPU 拷贝），Render Graph 只追踪依赖。

### 12.3 `PrepareShaderVariablesGlobal` —— 推 binning 描述子

`BinningPass.cs:338-419` 反编译，关键：
```
cvttss2si eax, [rdi+250h]        ; rtSize.x  (HGCamera.actualWidth as int)
cvttss2si eax, [rdi+254h]        ; rtSize.y  (HGCamera.actualHeight as int)
mov r9d, 20h                     ; tileSize = 32
mov dword ptr [rsp+28h], 8       ; uintCountPerBin = 8  ← light bin (256 bit/tile)
mov dword ptr [rsp+20h], 800h    ; baseOffset cap = 0x800 (= 2048 uint reserved for light)
call BinningPass::GenerateBinningData
// 第二次：reflection probe
mov dword ptr [rsp+28h], 1
mov dword ptr [rsp+20h], 400h    ; baseOffset cap = 0x400 (= 1024 uint reserved for reflProbe)
call BinningPass::GenerateBinningData
// 拷贝到 ShaderVariablesGlobal:
movdqu [rdi+410h], xmm0          ; ShaderVariablesGlobal._LightBinningDesc / _ReflProbeBinningDesc
```

`GenerateBinningData(rtSize, tileSize=32, sliceZ, uintCountPerBin, ref baseOffset)`（`BinningPass.cs:229-336`）反编译公式（`cs:255-266`）：

```
tileX = (rtSize.x + tileSize - 1) / tileSize    ; (eax = (rtSize.x-1) + tileSize) / esi
tileY = (rtSize.y + tileSize - 1) / tileSize    ; 同上 idiv esi
xyOffset = baseOffset + 0                       ; xyOffset = 起始 uint 偏移
zOffset  = xyOffset + tileX * tileY * uintCountPerBin
baseOffset += zOffset_increment
return new BinningData { tileSize, tileX, tileY, sliceZ, xyOffset, zOffset, uintCount = uintCountPerBin };
```

**布局**：
```
binningBuffer (RWStructuredBuffer<uint>):
   [0 .. 2047]            : light bin
       [xyOffset      .. xyOffset + tileX*tileY*8 - 1]   per-tile mask (8 uint/tile)
       [zOffset       .. zOffset  + sliceZ*4    - 1]      per-zSlice mask (4 uint/slice, low 128 bit)
   [2048 .. 3071]         : reflection probe bin
       (类似布局，每 tile 1 uint)
```

`ShaderVariablesGlobal` 偏移：
- `BinningPass.cs:374-377`：`[rbx+10h]..[rbx+28h]` 写 `lightBinningData` (28 字节: tileSize/tileX/tileY/sliceZ/xyOffset/zOffset/uintCount)
- `BinningPass.cs:382-387`：`[rbx+2Ch]..[rbx+44h]` 写 `reflectionProbeBinningData`（同一布局，偏移 +0x1C）
- `BinningPass.cs:392-397`：拷贝 `_NumTilesXY` 之类 4 个 int 到 `[rdi+410h]` —— shader-side `cb._BinningDimensions` 等。

---

## 13. 步骤 (9) — Tile Draw 间接绘制参数与 quad 索引缓冲

源：`LightCulling.SetOuputTileDrawBuffers`、`LightClusteringPassConstructor.ConstructPass` (`LightClusteringPassConstructor.cs:998-1031`)。

每帧产物：
- **drawTileArgs**：`ComputeBuffer`（per-frame ping-pong：当前帧用 `m_drawTileArgsBufferHandle`，给下一帧准备 `m_drawTileArgsBufferNextFrameHandle`）。`DrawProceduralIndirect` 的 `args = (vertexCountPerInstance=4, instanceCount=tileCount, startVertex=0, startInstance=0)` × MAX_LIGHT_COUNT。
- **tileInstanceIndices**：每个 tile 对应的光源 index 列表（packed）。
- **quadIndexBuffer**：`GraphicsBuffer`（`LightCulling.cs:73`），全局共享的「单四边形 (0,1,2, 0,2,3)」索引，下游 DrawProceduralIndirect 用。

`LightClusteringPassConstructor.cs:1011-1016`：
```
mov rcx, [r12]                       ; m_lightCulling
call sub_180006410                   ; LightCulling.SetOuputTileDrawBuffers 的内部 dispatch
... call rax                         ; 实际写 args (CPU 端 BufferData)
```

后续 `LightClusteringPassConstructor.cs:1078-1100`：写入 `PassOutput`：
```
PassOutput.directionalLightDir
PassOutput.punctualLightIndices[0..256]
PassOutput.punctualLightCount
PassOutput.directionalLightIndex
PassOutput.drawTileArgs              = LightCulling.DrawTileArgsBufferHandle (offset 0xF8)
PassOutput.tileInstanceIndices       = LightCulling.TileInstanceIndicesBufferHandle (offset 0x108)
PassOutput.quadIndexBuffer           = LightCulling.QuadIndexBuffer
```

---

## 14. `LightClusteringPassConstructor`：CPU 排序 + Cookie + Shadow Caster 装配

这是 C19 的"主控 pass" —— 把 §5–13 串起来。源：`LightClusteringPassConstructor.cs`。

### 14.1 入口：`ConstructPass(ref PassInput, ref PassOutput, renderGraph, camera)`

反编译 `cs:818-1196` 调用图：

```
SetupState(cullingResults, lightCullResult, camera, settingParameters)
   ├─ 见 §5
   ├─ HGPunctualLightShadowManagerV2.PreparePunctualLightShadowCasters
   └─ LightCulling.FrameSetup

HGLightCookieManager.UpdateLightCookieAtlas(camera, renderGraph, ...)
   ├─ atlas 4096×4096, 32 cookie slot (HGLightCookieManager.cs:37-41)
   └─ 写 cookie data + worldToLight matrix 到 cookie cbuffer

HGRenderGraph.AddRenderPass<LightCullingPassData>("Compute GPU Light Buffers")
   └─ LightCulling.PrepareCPUData(camera, settings, gbufferOutput, ...)
        ├─ 见 §6-11
        └─ binningBuffer dependency hooked

LightCulling.SetOuputTileDrawBuffers(input.outputTileResult, ...)
   └─ 见 §13

WriteComputeBuffer(input.binningBuffer)       ; cs:1041-1045

PassData.lightCulling = m_lightCulling           ; cs:1023-1024
PassData.binningBuffer = input.binningBuffer
PassData.renderingScale = camera.renderingScale (?)
AllowPassCulling(false)
SetRenderFunc(s_lightCullingRenderFunc)
   RenderFunc 内：
      cmd.SetBufferData(binningBuffer, tileLightMask)
      cmd.SetBufferData(binningBuffer, zBin)
      或 cmd.DispatchCompute(binningXYShader, ...)  (LightCullingGPU 路径)

TryGetDirectionalLightDir(ref output.directionalLightDir, camera)
   ├─ 见 §14.2
   ↓
output.punctualLightIndices[]                = m_punctualLightIndices[]
output.punctualLightCount                    = m_punctualLightCount
output.drawTileArgs / tileInstanceIndices    = LightCulling.{DrawTileArgsBufferHandle, TileInstanceIndicesBufferHandle}
output.quadIndexBuffer                       = LightCulling.QuadIndexBuffer
```

### 14.2 `TryGetDirectionalLightDir`

源：`LightClusteringPassConstructor.cs:600-744`。算法（反编译 `cs:625-718`）：
- 取 `m_directionalLightIndex` 对应 VisibleLight，
- 若 `HGEnvironmentVolumeCameraComponent.UseDirLightDataFromEnvDirectly(light) == true`，
  从 `camera.envVolumeData[0x9D0].lightData[+0xC8]` 读 dir（让大气环境 volume 强制接管太阳光方向）；
- 否则调用 `VisibleLightExtensionMethods.GetForward(visibleLight)` 取 `light.localToWorld * (0,0,-1)`；
- `lightDir.xyz = -direction` （`xorps xmm, signbit`，cs:707-714）—— 取反，输出指向太阳。

### 14.3 `LightCookieManager.UpdateLightCookieAtlas` —— atlas 装配

`HGLightCookieManager.cs:11-74`。**32 slot × 4096² atlas** = 4K × 4K 张图，每光源最多 1 张 cookie。
工作模式：
- `m_activeLightCookies: Dict<Texture, RectInt>` 已分配槽位 LRU；
- `m_lightCookieAtlasAllocator: AtlasMaxRect` —— **MaxRect bin packing** 算法（同 ASMVirtualTextureAllocator 用的算法，见 `AtlasMaxRect.cs`）；
- 每帧：
  1. 扫光源找新增 cookie → `m_texturesToBeAdded`；
  2. LRU 淘汰 → `m_texturesToBeRemoved`；
  3. Render Graph pass `s_updateLightCookieAtlasRenderFunc`：`cmd.CopyTexture(srcCookie, atlas, dstRect)` 仅拷贝增量；
  4. Render Graph pass `s_lightCookieSetDataPassRenderFunc`：把 `lightCookieData[32]` (`Vector4`) + `lightCookieWorldToLightData[32]` (`Matrix4x4`) 推全局 cbuffer，shader 端 `_LightCookieAtlasData[slotIdx]` 读取偏移/缩放。

---

## 15. HG 关键常量与数据结构

### 15.1 关键常量

| 常量 | 取值 | 源 |
|------|------|---|
| `MAX_VISIBLE_LIGHTS` | 256 | `LightConstants.cs:11` |
| `MAX_DIRECTIONAL_LIGHTS` | 4 | `LightConstants.cs:5` |
| `MAX_PUNCTUAL_LIGHT_INDICES_COUNT` | 256 | `LightClusteringPassConstructor.cs:133` |
| `MAX_LIGHT_COOKIE_COUNT` | 32 | `HGLightCookieManager.cs:37` |
| `LIGHT_COOKIE_ATLAS_WIDTH` × `HEIGHT` | 4096 × 4096 | `HGLightCookieManager.cs:39-41` |
| `tileSize` (binning) | **32 px** | `BinningPass.cs:355` (`mov r9d, 20h`) |
| `uintCountPerBin` (light) | 8 (=256 bit) | `BinningPass.cs:363` (`mov dword ptr [rsp+28h], 8`) |
| `uintCountPerBin` (reflection probe) | 1 (=32 bit) | `BinningPass.cs:379` (`mov dword ptr [rsp+28h], 1`) |
| light bin pool size | 0x800 = 2048 uint | `BinningPass.cs:364` |
| reflProbe bin pool size | 0x400 = 1024 uint | `BinningPass.cs:380` |
| binningBuffer total | (0xC00=3072 uint, 12 KB) | `BinningPass.cs:62-73` |
| `NUM_DIR_LIGHT_DATA_BYTES` | 5 | `LightConstants.cs:7` |
| `NUM_LIGHT_COUNT_DATA_BYTES` | 1 | `LightConstants.cs:9` |

### 15.2 关键数据结构

```csharp
// BinningPass.cs:9-24  — 上传到 ShaderVariablesGlobal 的描述子
public struct BinningData {
    public int tileSize;     // = 32
    public int tileX;        // ceil(W / tileSize)
    public int tileY;        // ceil(H / tileSize)
    public int sliceZ;       // numZSlices
    public int xyOffset;     // start uint offset in binningBuffer
    public int zOffset;      // xyOffset + tileX*tileY*uintCount
    public int uintCount;    // 8 for light, 1 for refl probe
}  // 28 bytes

// LightConstants.cs:3-16
internal class LightConstants {
    public const int MAX_DIRECTIONAL_LIGHTS = 4;
    public const int NUM_DIR_LIGHT_DATA_BYTES = 5;
    public const int NUM_LIGHT_COUNT_DATA_BYTES = 1;
    public const int MAX_VISIBLE_LIGHTS = 256;
}

// FLocalLightData.cs:5-32  — shader-side 单个光源的物理参数 (76 bytes)
public struct FLocalLightData {
    public Vector3 Position;
    public float Radius;
    public Vector3 Color;
    public float InvRadius;
    public Vector3 Direction;
    public int bSpotLight;
    public Vector2 SpotAngles;
    public int bInverseSquared;
    public float FalloffExponent;
    public float ShadowIntensity;
    public float MsScatteringFactor;
    public float MsExtinctionFactor;
    public float Padding;
}

// ELocalLightType.cs:3-7
public enum ELocalLightType { Point = 0, Spot = 1 }

// HGLightType.cs:3-9
public enum HGLightType { Spot=0, Directional=1, Point=2, Area=3 }

// HGLightTypeAndShape.cs:3-13
public enum HGLightTypeAndShape {
    Point=0, BoxSpot=1, PyramidSpot=2, ConeSpot=3,
    Directional=4, RectangleArea=5, TubeArea=6, DiscArea=7
}

// AreaLightShape.cs:3-8
public enum AreaLightShape { Rectangle=0, Tube=1, Disc=2 }

// LightClusteringPassConstructor.cs:13-86  — CPU 排序键
private struct PunctualLightSortStruct : IComparable<PunctualLightSortStruct> {
    public int index;
    public float distance;     // = sqrMagnitude(camPos - lightPos)
    private int priority;      // user-assigned LRU/priority
    // CompareTo: 先 priority (int.CompareTo), 相等则 distance (float.CompareTo)
}

// LightClusteringPassConstructor.cs:88-118  — pass I/O
internal struct PassInput {
    internal CullingResults cullingResults;
    internal LightCullResult lightCullResult;
    internal BinningPass.BinningData binningData;     // 来自 BinningPass.Prepare
    internal ComputeBufferHandle binningBuffer;
    internal HGSettingParameters settingParams;
    internal bool outputTileResult;                    // 是否产出 Tile Draw 资源
}
internal struct PassOutput {
    internal Vector4 directionalLightDir;
    internal unsafe fixed int punctualLightIndices[256];   // C# unsafe fixed buf
    internal int punctualLightCount;
    internal int directionalLightIndex;
    internal ComputeBufferHandle drawTileArgs;
    internal ComputeBufferHandle tileInstanceIndices;
    internal GraphicsBuffer quadIndexBuffer;
}

// LightCulling.cs:12-37  — internal binning 常量 (uploaded as CBHandle)
protected struct BinningConstants {
    internal int lightCount;
    internal int numTiles;
    internal int actualWidth;
    internal int actualHeight;
    internal float tileSize;
    internal float numTilesX;
    internal float numTilesY;
    internal float numSliceZ;
    internal float nearClipPlane;
    internal float farClipPlane;
    internal float zBinSlice;        // (farClip - nearClip) / numSliceZ  线性切片
    internal float invZBinSlice;
}
```

---

## 16. HDRP↔HG delta 总览

| Aspect | HDRP 原实现 | HG 改成 | 依据 |
|--------|------------|--------|------|
| Screen AABB | `scrbound.compute` 64 thread/group，4 thread/light，凸包 frustum + 球，Blinn 齐次裁剪 6 平面 | **`LightSphereDataJob`** Burst per-light，**只走球**（spot 不做锥紧致） | `scrbound.compute:541-906` vs `LightSphereDataJob.cs:10-21` |
| Tile coarse cull | `lightlistbuild-bigtile.compute` 64×64 big-tile per-light AABB | **跳过 bigtile**，CPU 单层 32×32 | `lightlistbuild-bigtile.compute:118-140` vs HG 全工程 0 `bigtile` 命中 |
| FPTL fine cull | `lightlistbuild.compute` 16×16 tile + LDS prunedList + sorting + LIGHTCATEGORY_COUNT=4 sub-list | **`CalculatePlanesJob` + `TestPlanesJob` + `CollectMaskJob`** 三 Burst job pipeline，输出 256-bit/tile 平坦 mask | `lightlistbuild.compute:145-330` vs `*.cs:9-37 each` |
| tile 尺寸 | FPTL=16, Cluster=32, BigTile=64 | **32 px 一档** (light + refl probe 同尺寸) | `LightLoop.cs.hlsl:56-58` vs `BinningPass.cs:355` |
| 分类列表 | `LIGHTCATEGORY_COUNT=4`：punctual/area/env/decal 各一段 | **无分类**，单 256-bit/tile 位图 | `LightLoop.cs.hlsl:20` vs `BinningPass.cs:363` |
| Z 切片 | 几何级数 `base=1.02`（远近自适应），`k_Log2NumClusters=6` → 64 slice | **线性等距** `sliceSize=(far-near)/numSlices` | `LightLoop.cs:564,566` vs `LightCulling.cs:33`+`ZBinCullingJob.cs:67-77` |
| Per-tile depth bound | tile 内取 minZ/maxZ + suggestedBase 自适应 | (反编译未见 depth-bound，推断 HG **不做** per-tile depth tighten) | `lightlistbuild-clustered.compute:319-363` vs HG 反编译范围 0 命中 |
| 球-tile 相交 | `DoesSphereOverlapTile`：二次方程 + tile-enlarged radius | **直接 plane 距离比 radius**（plane 过原点简化） | `LightingConvexHullUtils.hlsl:93-122` vs `TestPlanesJob.cs:79-110` |
| Compute / CPU | 全 GPU（4 个 compute） | **CPU Burst Jobs 主路径** + `LightCullingGPU` 可选 GPU 后端（保留 `m_binningXYShaderKernel` / `m_binningZShaderKernel` —— `LightCullingGPU.cs:24-31`） | 上面所有源对比 |
| 排序键 | (lightLayer << shift) \| categoryIndex 多级 | **priority + distance²** 两级 | `LightClusteringPassConstructor.cs:35-86` |
| Cookie atlas | per-platform 大小，slot 数动态 | **固定 4096² × 32 slot** + MaxRect bin packing | `HGLightCookieManager.cs:37-41` |
| 反射探针 binning | 同 cluster 走单独 EnvLight 分类 | **共用 binning kernel，独立 1-uint/tile 位图段**（reflectionProbeBinningData） | `BinningPass.cs:379` |
| Tile Draw | (HDRP 无直接对应，HDRP 走 deferred shader 内嵌 loop) | **HG 自研**：drawTileArgs + tileInstanceIndices + quadIndexBuffer，用 `DrawProceduralIndirect` 把每盏光绘成 tile-quad（per-light 立方体 footprint shading） | `LightCulling.cs:81-85`、`LightClusteringPassConstructor.cs:107-118` |
| 主太阳光选取 | 显式 sortKey + frameSettings | **遍历找 intensity 最大者** + `GetSunSourceLight()` 兜底 | `LightClusteringPassConstructor.GetDirectionalLightIndex` `cs:439-598` |
| 太阳光方向覆盖 | HDRP volume 走 sky 系统 | **`HGEnvironmentVolumeCameraComponent.UseDirLightDataFromEnvDirectly`** 优先走 env volume 内 light data | `LightClusteringPassConstructor.cs:660-672` |

---

## 17. 1:1 复刻蓝图

要 1:1 重建 C19 LightingMgr，按这个顺序：

### ① 数据结构层
1. 定义 `FLocalLightData`、`BinningData`、`BinningConstants`、`PunctualLightSortStruct`、`PassInput`/`PassOutput`、四种 enum（HGLightType/HGLightTypeAndShape/AreaLightShape/ELocalLightType）—— §15.2 全部照抄。
2. 定义常量类 `LightConstants`（4 directional / 256 visible）。

### ② Burst Job 层（核心）
按 §6-11 顺序实现 6 个 Burst `IJob*`：
- `LightSphereDataJob` (IJobParallelFor, per-light) —— §6
- `CalculateTileVerticesJob` (IJobParallelFor, per-row) —— §7
- `CalculatePlanesJob` (IJob 串行) —— §8
- `TestPlanesJob` (IJobParallelFor, per-light) —— §9
- `CollectMaskJob` (IJobParallelFor, per-tile-row) —— §10
- `CollectZBinJob` (IJobParallelFor, per-zSlice) **或** `ZBinCullingJob` (IJobParallelFor, per-light，更高效) —— §11

每个加 `[BurstCompile]`，字段全部 `NativeArray<>`/`NativeDisableParallelForRestriction`。**注意 `TestPlanesJob` 输出 `bool2` 而不是单 bool**：是为 SIMD 同时处理「球外正侧 / 球外负侧」两位。

### ③ 抽象类层
- `LightCulling`（abstract）：持 `m_frustumCorners` / `m_tileVertices` / `m_XPlanes` / `m_YPlanes` / `m_lightSphereData` / `m_punctualLightDataArray` 全部 `NativeArray<float4>`，+ `m_punctualLightDataBuffer`（ComputeBuffer），+ `m_binningConstants` (CBHandle)。
- 公开 `PrepareCPUData()`、`SetOuputTileDrawBuffers()`、`FrameSetup()`、`GetDrawTileArgsBuffers()`、`QuadIndexBuffer` 属性。
- 派生 `LightCullingGPU`：额外维护 `m_binningXYShaderKernel` / `m_binningZShaderKernel` / `m_clearArgsXYShaderKernel`、`m_gpuBinningConstants` (`nearPlaneParams: Vector4`)，在 `PrepareRenderGraphBuffers` 阶段创建 `m_punctualLightDescBuffer` + `m_punctualLightDataBuffer`，runtime 阶段 `DispatchCompute(binningXYShader, ...)` 代替 `CollectMaskJob`。

### ④ Pass Constructor 层
1. **`BinningPass : IPassConstructor`**（§12）—— 单 pass：
   - `Prepare` 创建 `binningBuffer`（stride=4 flags=0x10 count=tileLightUintCount + reflProbeUintCount）。
   - `ConstructPass` `AddRenderPass<PassData>` + `ReadComputeBuffer`(binningBuffer)。
   - `PrepareShaderVariablesGlobal` 两次调用 `GenerateBinningData`：light(uintCountPerBin=8, cap=0x800) + reflProbe(uintCountPerBin=1, cap=0x400)，写 ShaderVariablesGlobal +0x10/+0x2C 段（28 字节 each）+ 4 个 dim int 到 +0x410。
2. **`LightClusteringPassConstructor : IPassConstructor`**（§14）—— 主控：
   - `SetupState` 排序 visibleLights → 截 256 → 写 `m_punctualLightIndices` + `m_directionalLightIndex`，调 `HGPunctualLightShadowManagerV2.PreparePunctualLightShadowCasters` + `LightCookieManager.UpdateLightCookieAtlas` + `LightCulling.FrameSetup`。
   - `ConstructPass` `AddRenderPass<LightCullingPassData>("Compute GPU Light Buffers")` → `LightCulling.PrepareCPUData(...)` → `LightCulling.SetOuputTileDrawBuffers(...)` → `WriteComputeBuffer(binningBuffer)` → `SetRenderFunc(s_lightCullingRenderFunc)`。
   - `TryGetDirectionalLightDir` —— 见 §14.2。
   - 输出填入 `PassOutput`（256 fixed buf + 3 个 buffer handle + quadIndexBuffer）。
3. **`DeferredLightingPassConstructor : IPassConstructor`** —— 消费者（参考 `01-PipelineCore/04-LightingAO.md`），不在本单元详述。

### ⑤ Cookie 子系统
`HGLightCookieManager`（§14.3）—— 4096² atlas + 32 slot + MaxRect packing + 两个 Render Graph 子 pass。

### ⑥ Shadow Caster 装配
`HGPunctualLightShadowManagerV2.PreparePunctualLightShadowCasters(punctualIndices, count, lightCullResult, settings)` —— C07 ShadowASM 单元的职责，本单元只调它，签名见 `LightClusteringPassConstructor.cs:388-392`。

### ⑦ 依赖与接口
**上游**：
- `HGCamera`（actualWidth / actualHeight / frustumCorners / renderingScale / envVolumeData）—— C13.
- `CullingResults.visibleLights` / `LightCullResult`（Unity 端 + HG 自定剔除）。
- `HGSettingParameters._settings[0x200]`（max punctual light count）。

**下游**：
- DeferredLightingPass（C19 / C20 边界，PassInput 含 drawTileArgs + tileInstanceIndices）。
- ForwardOpaqueLit shading（GBufferLit / NPRChar）—— shader 端读 `_LightBinningDesc` 和 `binningBuffer`。
- VolumetricLighting（C05）—— per-froxel 用 zBin。
- ReflectionProbeBinningPass（C09）—— 共用 binningBuffer 第二段。
- CapsuleShadow（C07）—— `tileParam0/1/2` 同尺寸 tile，复用 BinningPass 网格。
- ParticleLighting / GTAO / SSR —— 读 punctualLightIndices/Count + binningBuffer。

### ⑧ 难点与陷阱
1. **Plane 过原点的简化只对 visible camera frustum 内的光源准确**：若光源中心位于相机后方但 range 包到前方，TestPlanesJob 的 `dot(plane, sphereCenter)` 比较会丢一些情况（HG 接受这种保守剔除，因为 LightSphereDataJob 阶段已对 sphereCenter 视锥外的光源在 `lightIndices` 上预过滤）。
2. **CollectMaskJob 的 atomic `lock add`** 实际是 `InterlockedOr` 的 `|=` 语义（每位最多设一次），用 `add` 等价是因为 caller 保证一光源在一 tile 里只 mark 一次；移植时若不保证，须改 `Interlocked.Or`（.NET 8+）或 CAS。
3. **`BinningData.zOffset` 与 `xyOffset` 的累积计算**：`GenerateBinningData` 内 `baseOffset += increment`（`BinningPass.cs:292` `add [rdx], r8d`），caller 传 `ref baseOffset`，两次调用共享同一变量从而把 light bin 与 reflProbe bin 顺序拼接进同一池。
4. **`m_drawTileArgsBuffer` ping-pong**：当前帧 (`m_drawTileArgsBufferHandle`) vs 下一帧 (`m_drawTileArgsBufferNextFrameHandle`)，避免 DrawIndirect 读写冲突；移植时务必保留两份。
5. **Cookie atlas LRU 与异步 CopyTexture**：MaxRect 分配失败时必须淘汰旧 slot；CopyTexture 在 Render Graph 内调度，须 hook `ReadTexture(srcCookie) + WriteTexture(atlas)` 避免 alias 冲突。
6. **Burst job 依赖链**：`CalculateTileVerticesJob` ←JobHandle← `CalculatePlanesJob` ←← `TestPlanesJob` ←← `CollectMaskJob`，`LightSphereDataJob` 与前三可并行，`CollectMaskJob` 与 `CollectZBinJob` 可并行。Schedule 时务必用 dependsOn 串好。

---

## 18. 支撑证据 — 文件清单与字段表

### 18.1 关键源文件职责（精简）

| 文件 | 反编译职责 | 蓝图章节 |
|------|----------|---------|
| `BinningPass.cs` | Render Graph 单 pass：创建 binningBuffer + 推 ShaderVariablesGlobal 的 light/reflProbe BinningData 描述子 | §12 |
| `LightClusteringPassConstructor.cs` | 主控 pass：排序 visibleLights、装配 cookie/shadow caster、调度 Burst job pipeline、产出 PassOutput | §5, §14 |
| `LightCulling.cs` | abstract base：NativeArray 容器 + tileVerts / planes / sphereData 持有 + BinningConstants CB | §4, §17③ |
| `LightCullingGPU.cs` | LightCulling 的 GPU 后端子类（binningXY/Z compute shader） | §17③ |
| `LightSphereDataJob.cs` | Burst job：visibleLight → world-space bounding sphere (float4) | §6 |
| `CalculateTileVerticesJob.cs` | Burst job：屏幕 tile 角点 → 视空间顶点网格（双线性 lerp from frustumCorners） | §7 |
| `CalculatePlanesJob.cs` | Burst job：tileVertices → X/Y plane 方程 (cross+normalize, w=0) | §8 |
| `TestPlanesJob.cs` | Burst job：sphere↔plane 分类 + tile 区间扫描 | §9 |
| `CollectMaskJob.cs` | Burst job：聚合 byte mark → 32-bit 位图 (tile-row parallel) | §10 |
| `CollectZBinJob.cs` | Burst job：聚合 z-slice byte mark → uint4 位图 (slice parallel) | §11.1 |
| `ZBinCullingJob.cs` | Burst job：每光源直接算 z slice 范围 (sliceSize 线性) → 写 zBin int* | §11.2 |
| `LightConstants.cs` | const：MAX_VISIBLE_LIGHTS=256 等 | §15.1 |
| `FLocalLightData.cs` | shader-side 单光源 76B 物理参数 struct | §15.2 |
| `ELocalLightType.cs` | enum Point/Spot | §15.2 |
| `HGLightType.cs` | enum Spot/Directional/Point/Area | §15.2 |
| `HGLightTypeAndShape.cs` | enum 8 种 type+shape 组合 | §15.2 |
| `AreaLightShape.cs` | enum Rectangle/Tube/Disc | §15.2 |
| `AreaLightUnit.cs` | enum 单位（Lumen/Nit/Ev100…）—— 强度单位转换用 | §14 |
| `PunctualLightUnit.cs` | enum Lumen=0/Candela=1/Lux=2/Ev100=4 | §14 |
| `DirectionalLightUnit.cs` | enum 方向光强度单位 | §14 |
| `LightUnit.cs` | enum 通用光强度单位 (top-level) | §14 |
| `LightUtils.cs` | static helper：`ConvertPointLightLumenToCandela = lumen / 4π`、Spot 系列（Lambert vs PBR-exact）| §14 |
| `HGLightConfig.cs` | 方向光 Env 集成 config（color/intensity/atmospherePitchYaw…）`IEnvConfig` | §14 |
| `HGAdditionalLightData.cs` | Unity Light MonoBehaviour 扩展（NPR 参数 + cookie + sphericalLightRadius） | §14 |
| `HGAdditionalLightGroupController.cs` | 多光源组控制器（ECS 端） | §14 |
| `HGLightCookieManager.cs` | Cookie atlas（4096² × 32 slot, MaxRect bin packing） | §14.3 |
| `HGLightShaftConfig.cs` | Light shaft 配置（独立 pass，参考 `LightShaftApplyPassConstructor`） | (cross-ref) |
| `LightShaftPassConstructor.cs` / `LightShaftApplyPassConstructor.cs` | Light shaft Pass（与本单元独立但共享 directionalLightIndex） | (cross-ref) |
| `LightShaftPassIndex.cs` | enum LightShaft pass 索引 | (cross-ref) |
| `LightLayerEnum.cs` | bitmask 光层（与 HDRP 同源） | §14 |
| `LightShadowResolutionParameter.cs` | shadow res 设置参数包装 | (C07) |
| `HGPunctualLightShadowManagerV2.cs` | shadow caster 装配（PreparePunctualLightShadowCasters 入口） | (C07) §5 |
| `HgSceneLightingData.cs` | scene lightmap 信息持有（ECS-friendly） | (烘焙) |
| `HGSharedLightDataExtension.cs` | VisibleLight 的扩展方法（取 intensity / pos）| §5, §14 |
| `LightCaster.cs` | ECS Entity-based light reference (Entity+index+hash) | (ECS 边界) |
| `LightExtensions.cs` / `VisibleLightExtensionMethods.cs` | UnityEngine.Light 扩展方法（GetForward / GetSunSourceLight） | §14 |
| `SpotLightShape.cs` | enum Spot 形状 | §15.2 |
| `ShadowsMidtonesHighlights.cs` | tonemapping 色调三段（与本单元仅 cookie 同 atlas 复用）| (后处理) |
| `CharLightVolumeData.cs` | 角色光照 Volume Component（NPR 主光参数） | (角色) |

### 18.2 跨单元引用

- 光源 Tile/Cluster Binning 算法在 `02-CoreAlgorithms/01-CoreAlgorithms.md` §3 已给出 BinningData 结构与 256 光源上限；本文补全**Burst job 链路与 HDRP delta**。
- 延迟光照消费链路（Tile Draw Stage 9/10/11 + GBuffer 解码）见 `01-PipelineCore/04-LightingAO.md` §"DeferredLightingPass"；本文不复述 shader 端语义。
- C07 ShadowASM 单元解释 punctual shadow caster 如何被 `HGPunctualLightShadowManagerV2` 装配并写 ASM 虚拟纹理。
- C05 Volumetric 单元解释 froxel 如何在 marching 时读 zBin 与 tileLightMask 做 per-froxel 光源查询。
- C09 GI/SH 单元的 `ReflectionProbeBinningPassConstructor` 共用本单元的 binningBuffer 的 reflProbe 段（offset 2048+）。

---

> **结语**：HG.RenderPipelines 的光照管理是一个**"HDRP LightLoop 算法骨架 + CPU Burst job 重写 + 单 ComputeBuffer 上传"**的精简移植 ——
> 牺牲了大场景下 GPU bin 的扩展性，换得 256 光源场景下更低的 GPU 压力与更可调度的 worker-thread 并发。
> 核心 delta 集中在 **(1) tile 平面过原点的简化球-平面剔除**、**(2) 线性 Z 切片代替几何级数 cluster**、**(3) 32×32 单档 tile 尺寸去掉 LIGHTCATEGORY_COUNT 分类**、**(4) Burst Job 全 CPU 替代 4 个 GPU compute**——
> 1:1 复刻必须严格守住这四点，否则与 HG shader 端 `_LightBinningDesc.{xyOffset,zOffset,uintCount}` 的位偏移对不上，整条 forward+/deferred 光照链路 GPU 端读位图就会读到错位的 bit 段。
