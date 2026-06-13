# HG Render Pipeline — GPU Cloth (布料模拟) 技术实现原理蓝图

> 本文是 **从零重建** 终末地 (EndField) HG.RenderPipelines GPU 布料模拟子系统的实现蓝图。
> **此功能为 HG 自研** —— HDRP 没有任何 cloth 子系统（`com.unity.render-pipelines.high-definition@75de48326bcd` 全树 `grep -i cloth` 命中 0 行）。因此本文的算法原理 **不能**取自 HDRP 同源，必须据 HG 反编译调用图 + 常量 + 数据结构 + 领域渲染知识 (mass-spring / Verlet / position-based dynamics / capsule collision / wind force) **1:1 重建**。
>
> 19 个 C# 源文件由 `GpuClothManager`（CPU 端，~4400 行反汇编）统一管理；GPU 端由 3 个 compute kernel (`ClothSimMain` / `ClothDataUploadMain` / `ClothDataClearMain`) 在 RenderGraph 的 **Pre-Render 第 6 个 PassConstructor** (`GpuClothSimulation`) 串接调度（见 [`../01-PipelineCore/PassConstructors/PreRenderPasses.md`](../01-PipelineCore/PassConstructors/PreRenderPasses.md)）。
>
> 配套已有文档（不复述、只链）：
> - 数据三态 (Clear/Upload/Render) 的 C++ blittable 镜像：[`../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md`](../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md)
> - 风场来源 `HGEnvironmentPhase.s_interpolatedPhase`：[`./06-EnvironmentSky.md`](./06-EnvironmentSky.md)
> - 跨流式系统的 Chebyshev/sector 调度模式（同一思路应用于地形/水面）：[`./01-WaterOcean.md`](./01-WaterOcean.md)、[`./02-Terrain.md`](./02-Terrain.md)

---

## 0. 目录

| § | 主题 |
|---|------|
| 1 | 解决什么渲染问题 / 视觉目标 |
| 2 | 核心算法判定：HG 用的是 **Jacobi mass-spring + Verlet 积分 + capsule 碰撞 + 风力外力** |
| 3 | GPU 执行模型：4 pass / 3 kernel / 5 ComputeBuffer + 双 cbuffer 上传 |
| 4 | CPU → GPU 数据流：5 张常驻 buffer 的布局与 sector/cellIdx 编址 |
| 5 | 每帧时序：Timer 子步 + 流式激活 + 上传脏标记 + Pass 装配 |
| 6 | 数学：风力、Verlet 积分、约束求解、capsule 碰撞投影、法线重算 |
| 7 | 关键常量 / 魔数总表（逐字照抄 + 含义） |
| 8 | 1:1 重建蓝图（按子系统分步） |
| 9 | 支撑证据：核心数据结构表 |
| 10 | 源文件清单（19 个，每个一行职责） |
| 11 | 推断分级与待确认项 |

---

## 1. 解决什么渲染问题 / 视觉目标

终末地的角色/场景有大量需要"被风吹、随角色移动、与角色身体碰撞"的布制结构（衣摆、披风、长发段、旗帜、帐篷帘等）。CPU 端逐顶点求解 mass-spring + Verlet 在开放世界数千件布料的规模上不可行——所以 **HG 把模拟完全压到 GPU**：

- **数据布局**：所有 cloth 节点（顶点）、约束（spring/anchor）、骨骼（输出端）合并到 **5 张常驻 `ComputeBuffer`**，由 cellIdx 把"组"映射到 buffer 的固定区段（atlas）。
- **CPU 工作**：流式注册/激活（只上传玩家附近 ≤50 组）；每帧驱动一次 ComputeShader dispatch；同步把 `skeletonOffset` 写回 ECS 的 `CommonInstanceDataComponent`（供渲染期 vertex shader 取布料化后的骨骼/位置/法线）。
- **GPU 工作**：每帧固定 dispatch 一次 `ClothSimMain`，每件布料内部跑 `loopNum × iterNum` 次约束求解迭代，最后写回 skeleton buffer（被 vertex shader 当 bone-matrix-like 数据消费）。

这是一个 **典型的"显存常驻 atlas + 流式注册/激活 + 子步固定时间 + GPU 求解 + 双缓冲 skeleton"** 的布料管线。和 NVIDIA FleX、Bullet GPU 解算器同族，但裁剪得极致——只保留 mass-spring + anchor + capsule + 风的最小集合，所以才能在移动端落地（参考 `ClothMobileData.cs` 的存在表明确实有 mobile 路径）。

---

## 2. 核心算法判定：HG 用的是 **Jacobi mass-spring + Verlet 积分 + capsule 碰撞 + 风力外力**

### 2.1 证据链（从数据 + 调用 + 常量综合判定）

> 由于 GPU 数学逻辑全在 .ushaderbytecode 中（C# 反编译不可见），算法身份必须从 **CPU 端为 GPU 准备的数据形态** + **每帧 dispatch 链** + **物理常量** 综合反推。下面列出 5 条决定性证据：

| # | 观测 | 反汇编/常量出处 | 排除哪些可能 |
|---|------|----------------|--------------|
| ① | 每个节点存了 `packedBasePosition` (rest) + `packedPrePosition` (上一帧位置) + `packedCurPosition` (当前位置) | `ClothNodeData.cs:15,21,23`（+0x20/+0x50/+0x60） | **Verlet 积分**的典型存储（`pos_new = 2·pos_cur − pos_prev + a·dt²`）—— 排除 implicit Euler / RK4 |
| ② | 每个节点固定 **8 个邻居**（fixed[8] cache idx + fixed[8] distance） | `ClothNodeData.cs:27,29`、`MAX_NEIGHBOR_NUM=8`（`GpuClothManager.cs:427`） | **mass-spring** 网格邻居约束（每节点最多 8 spring，恰为 quad grid 的 4 + 4 对角）—— 排除 FEM/tetrahedral 体积约束 |
| ③ | 每个节点最多 **2 个 anchor**（`MAX_ANCHOR_NUM=2`） + `anchorRelaxScale`/`anchorSecRelaxScale` 双松弛系数 | `GpuClothManager.cs:425`、`ClothInfo.cs` anchor 字段 + 主/次松弛 | **位置约束的"软"实现**：anchor 不是 hard pin，而是弹簧式拉回（"relax"=拉伸放松系数），与 XPBD 的 distance constraint compliance 同形 |
| ④ | `CLOTH_BATCH_SIZE=256` + `MAX_CLOTH_BATCH_PER_GROUP=8` + 每件 cloth 有 `batchIdxStart` + `iterNum` | `GpuClothManager.cs:431`、`ClothGroupMeta.cs:11`、`ClothMetaData.cs:8,11` | **批次（batch）= 图着色（graph coloring）分组的约束子集**，每件 cloth 最多 8 个 batch、每 batch 256 节点同时迭代 → 这正是 **Jacobi-style 并行约束求解**（每 batch 内的约束彼此无冲突，可并行；batch 之间串行） |
| ⑤ | `MAX_COLLIDER_NUM=4` + `ClothConstData.colliderInfoArray[48]` (4×12 float) + `_SetCharacterProxyMesh` 写入 4 段 capsule(top, bottom, radius, height) + `UpdateCharacterPositions` 4 个角色位置 | `GpuClothManager.cs:433`、`ClothConstData.cs:11`、`_SetCharacterProxyMesh:3879`、`UpdateCharacterPositions:2006` | **capsule-vs-particle 投影碰撞**（每个粒子查 4 个胶囊，到轴线距离 < radius 则推到表面）—— 排除 SDF 体素碰撞、BVH 碰撞 |

### 2.2 算法身份结论

综合 ①②③④⑤ → HG GPU Cloth 是：

> **基于 mass-spring 拓扑的、Jacobi (batch-colored) 并行约束求解的、Verlet 积分的、anchor 软位置约束的、capsule 投影碰撞的、外力为方向风 + 重力的，每件布料独立子迭代的 GPU 布料解算器。**
>
> 与 **PBD/XPBD 的距离投影变体**等价（Verlet 形式 + Jacobi 约束 = PBD 的等价表达，详 Müller 2007）。因此本文以下统一称作 **"Verlet mass-spring with Jacobi distance projection"** —— 区别于 Position-Based Dynamics 原典只在于 HG 显式存储了 prev/cur 两帧位置（PBD 通常只存 cur 和 vel），但二者数学等价。

### 2.3 一次"子步"的核心步骤（重建版伪码）

> 据 §2.1 证据 + 领域知识重建。compute kernel 内的具体写法待 `.ushaderbytecode` 解包确认。

```glsl
// ───────────────────────────────────────────────────────
// ClothSimMain (kernel)  —— 每个 thread 处理一个节点
// dispatch 维度: (totalNodeNum / GROUP_SIZE, 1, 1)  每帧 1 次
// 内部循环: loopNum × iterNum × MAX_CLOTH_BATCH_PER_GROUP
// ───────────────────────────────────────────────────────
ClothMetaData m = clothMetaDataBuffer[clothIdx];      // 本节点所属 cloth
ClothNodeData n = clothNodeDataBuffer[nodeIdx];       //   本节点
float3 pos_cur  = n.packedCurPosition.xyz;
float3 pos_prev = n.packedPrePosition.xyz;
float3 pos_base = n.packedBasePosition.xyz;
float3 n_base   = n.packedBaseNormal.xyz;

// ① 外力累积
float3 a = float3(0, -g, 0);                          // 重力 (待 .rdata 确认 g 常量)
a += windForce(pos_cur, m, clothParam1, n_base);      // 见 §6.1

// ② Verlet 积分: x_new = 2x − x_prev + a·dt²  (含 damping)
float dt = packedDeltaT.x;                            // = PHYSICS_DELTA_TIME / clothLoopMult?
float3 pos_new = pos_cur + (1.0 - damping) * (pos_cur - pos_prev) + a * dt * dt;

// ③ 约束求解 (Jacobi over batches; iterNum 次外迭代)
for (int it = 0; it < m.iterNum; ++it) {
    for (int b = 0; b < clothBatchNum; ++b) {
        // 每 batch 内 256 约束并行解算 (groupshared 同步)
        int4 batchEntry = clothBatchMetaDataBuffer[m.batchIdxStart + b];
        // batchEntry.xy = (nodeA, nodeB) 索引对; .zw 待补
        if (myThread belongs to this batch) {
            // distance constraint: |pos_new[A] − pos_new[B]| = restDist
            float3 d = pos_new[B] - pos_new[A];
            float L = length(d);
            float restDist = n.neighborClothNodeDistance[k];   // 邻居 k 的原距
            float w = 0.5;                                     // Jacobi weight (mass-balanced)
            float3 corr = (L - restDist) / L * w * d;
            pos_new[A] += corr;
            pos_new[B] -= corr;
        }
        GroupMemoryBarrierWithGroupSync();
    }
    // anchor 投影 (软): 每节点 ≤2 anchor
    for (int k = 0; k < 2; ++k) {
        int2 a_idx = n.anchorNodeCacheIdx;       // cache idx
        if (a_idx[k] != INVALID) {
            float3 anchorPos = batchCacheMap[a_idx[k]].xyz;
            float restDist = n.anchorNodeDistance[k];
            // 用 anchorRelaxScale / anchorSecRelaxScale 软约束
            float3 d = anchorPos - pos_new;
            float L = length(d);
            pos_new += relaxScale[k] * (L - restDist) / L * d;
        }
    }
}

// ④ Capsule 碰撞投影 (每节点查 MAX_COLLIDER_NUM=4 个胶囊)
for (int c = 0; c < 4; ++c) {
    float4 capTop_R    = colliderInfoArray[c*3 + 0]; // .xyz=top,  .w=radius
    float4 capBot_H    = colliderInfoArray[c*3 + 1]; // .xyz=bot,  .w=height
    // .xy 段 (c*3 + 2) 槽承载 radius/height 备份, 见 _SetCharacterProxyMesh
    pos_new = capsuleProject(pos_new, capTop_R.xyz, capBot_H.xyz,
                             max(capTop_R.w, ...));
}

// ⑤ Soft range 限制 (cloth 不能离 rest pos 太远; ClothInfo.softRange ∈ [0,5])
if (enableSoftRange) {
    float3 toRest = pos_base - pos_new;
    float L = length(toRest);
    if (L > softRange) pos_new += (L - softRange) / L * toRest;
}

// ⑥ 写回: cur → prev, new → cur
clothNodeDataBuffer[nodeIdx].packedPrePosition.xyz = pos_cur;
clothNodeDataBuffer[nodeIdx].packedCurPosition.xyz = pos_new;
GroupMemoryBarrierWithGroupSync();

// ⑦ 法线重算 (基于邻居的当前位置, 平均叉积):
//    n_new = normalize( Σ_k cross(neighbor[k]-pos_new, neighbor[k+1]-pos_new) )
//    然后写 clothSkeletonDataBuffer[skeletonOffset + nodeIdx] = pack(pos_new, n_new, tangent)

// 整段被 loopNum 个子步包裹 (见 §5.1)
```

> 这是 **据反汇编 + 数据形态 + 领域知识合理重建** 的版本（§1.5.4 标准 ③）。HG 的 HLSL 实际写法（kernel 边界、thread group、shared memory 使用、batch 内 Jacobi 还是 Gauss-Seidel）需对照 `.ushaderbytecode` 1:1 验证；但 **算法身份**（mass-spring + Verlet + Jacobi batch + capsule）由 §2.1 五条证据钉死。

---

## 3. GPU 执行模型：4 pass / 3 kernel / 5 ComputeBuffer + 双 cbuffer 上传

### 3.1 RenderGraph pass 链（由 `GpuClothSimulationPassConstructor.ConstructPass` 装配）

```
PreRender pipeline (PassConstructorID=6 / GpuClothSimulation)
│
├─ Pass 1: "GpuClothDataClear"        (条件: clearBufferData.shouldClear == true)
│            kernel: ClothDataClearMain
│            作用: 首帧/重置后把 node/batchMeta/cacheMap 三张 buffer 清零
│            dispatch: (totalNodeNum / 64, 1, 1) — 据反汇编无显式 dispatch dim
│                      但 eleNum 是 int4 → 4 个 count 直接给 shader 当循环上界
│
├─ Pass 2: "GpuClothDataUpload"       (条件: uploadData.isValid == true)
│            kernel: ClothDataUploadMain
│            作用: 把本帧待上传的 ≤4 个 group × ≤680 node 从 cbuffer 拷到 ComputeBuffer atlas
│            常量: 2 个 65280 字节 cbuffer (双 cbuffer 分裂, 见 §3.3) +
│                  meta/batchMeta/cacheMap 3 个常量上传
│
├─ Pass 3: "GpuClothSim"              (条件: renderData.isValid == true)
│            kernel: ClothSimMain
│            作用: 执行 §2.3 全部 7 步
│            常量: ClothConstData (160B = packedDeltaT + clothParam1 + 48 collider float)
│            读: clothNodeData / clothMetaData / clothBatchMeta / clothBatchCacheMap / clothSkeleton[in]
│            写: clothNodeData (位置/法线) / clothSkeleton[out]
│
└─ Pass 4: "GpuClothSetDefault"       (条件: !renderData.isValid && skeletonBufferID != 0)
             kernel: ClothSimMain (复用; passData.clothNum=0)
             作用: 没有任何 cloth 时也要把 skeleton buffer 置为"默认值"
                   防止下游 vertex shader 读到上帧/未初始化数据
             builder.AllowPassCulling(false)  ← 强制不被剪掉
```

> 三个 kernel 的 FindKernel 是在 `GpuClothSimulationPassConstructor` 构造时完成（见 `GpuClothSimulationPassConstructor.cs:128-176` 反汇编 `mov rdx,["ClothSimMain"]` / `["ClothDataUploadMain"]` / `["ClothDataClearMain"]`）。**`ClothDataUpload` 与 `ClothDataClear` 共用一个 ComputeShader 资源（`resources.+0x18.+0x228`），`ClothSim` 独立（`+0x230`）**——这是个微小但关键的 fact，因为它意味着 upload/clear 共享 buffer 绑定时序，可以放在同一个 dispatch chain。

### 3.2 三个 kernel 的职责分工

| Kernel | 输入 | 输出 | 几何意义 |
|--------|------|------|---------|
| `ClothDataClearMain` | int4 `eleNum`（4 张 buffer 的待清 count） | `clothNodeDataBuffer` / `clothBatchMetaDataBuffer` / `clothBatchCacheMapBuffer` 全置零 | 资源 reset，防 GC 跨帧污染 |
| `ClothDataUploadMain` | 2 × cbuffer(`ClothNodeData[]` × 340)、`ClothMetaData[]`、`int4[]`、`int4[]`、`ClothGroupUploadDataMap[]` | 5 张 atlas ComputeBuffer 的指定 segment 被写入 | 把"本帧新激活的 group"的数据通过 cbuffer fast path 推入 GPU atlas |
| `ClothSimMain` | `ClothConstData` (160B cbuffer) + 5 张 ComputeBuffer | 1) `clothNodeDataBuffer` 的 `packedPrePosition`/`packedCurPosition`/`packedCurNormal` 三字段更新；2) `clothSkeletonDataBuffer` 写出供渲染期 vertex shader 消费的骨骼数据 | 真正的物理求解 |

### 3.3 双 65280B cbuffer 上传分裂技巧（**HG 工程关键 trick**）

CPU 端 `_AllocateClothNodeConstBuffer`（`GpuClothSimulationPassConstructor.cs:1380-1477`）反汇编：

```
mov r14d, 0FF00h            ; 65280 字节 cbuffer 上限 (实质 = 64 KiB - 256)
mov r15d, 154h              ; 340 节点
两次 ScriptableRenderContext.AllocateConstantBuffer(0xFF00):
  第 1 块: MemCpy ptr[0..min(count, 340)] × 192B/节点
  第 2 块: MemCpy ptr[340..count]         × 192B/节点 (上限再 340)
返回 (CBHandle, CBHandle) 两个 cbuffer
```

**为什么是 340 而不是 341/342**？

```
HLSL constant buffer 单次绑定最大 = 65536 B
ClothNodeData stride  = 192 B = 0xC0
65536 / 192 = 341.33...   → 整数下取 = 341
但 HG 实测取 340 (= 0x154)
推测原因：保留 256 B (16 个 float4) 给 cbuffer header / packed control fields
65280 / 192 = 340.0 整除
```

→ 故 `MAX_NODE_NUM_PER_CBUFFER = 340` (`GpuClothGroupUploadData.cs:9`)，`MAX_NODE_NUM_PER_UPLOAD = 680 = 2×340` (`:11`) 锁死 **单帧最多上传 680 个节点**（再多就要再拆 cbuffer 或落到 structured buffer 走 fast path）。这是 **整个 cloth 流式系统的吞吐瓶颈**——决定了 `MAX_UPLOAD_GROUP_NUM=4` 这个常量：4 组 × 平均 ~170 节点/组 ≈ 680。

### 3.4 5 张 ComputeBuffer 的常驻布局（`_InitStreamingGpuBuffer` 反汇编 `GpuClothManager.cs:4209`）

```
ResizeComputeBuffer(clothMetaDataBuffer,        stride = 0xB0 (176 = sizeof ClothMetaData),   count = 0xC8 (200))
ResizeComputeBuffer(clothNodeDataBuffer,        stride = 0xC0 (192 = sizeof ClothNodeData),   count = 0x6400 (25600))
ResizeComputeBuffer(clothBatchMetaDataBuffer,   stride = 0x10 (16 = sizeof int4),             count = 0xC8 (200))
ResizeComputeBuffer(clothBatchCacheMapBuffer,   stride = 0x10 (16),                           count = 0xC80 (3200))
ResizeComputeBuffer(clothSkeletonDataBuffer,    stride = 0x60 (96 = sizeof ClothSkeletonData),count = 0x6400 (25600))
needClearGPUBuffer = true
```

| Buffer | Stride | Count | 总大小 | 算式 |
|--------|--------|------|--------|------|
| node | 192 | 25600 | 4.69 MB | 50 cell × 512 节点/cell = 25600（恰好 `MAX_RUNTIME_CLOTH_GROUP_NUM × MAX_CLOTH_NODE_PER_GROUP`） |
| skeleton | 96 | 25600 | 2.34 MB | 同上（每节点 1 槽 skeleton） |
| meta | 176 | 200 | 34 KB | 50 cell × 4 cloth/cell = 200（`MAX_RUNTIME_CLOTH_GROUP_NUM × MAX_CLOTH_PER_GROUP`） |
| batchMeta | 16 | 200 | 3.1 KB | 50 cell × 4 cloth = 200 个 int4（每 cloth 1 个 batch meta，剩余 batch 走 cacheMap） |
| cacheMap | 16 | 3200 | 50 KB | 50 cell × 64 entry/cell = 3200（接近 `MAX_CLOTH_CACHE_ENTRY_PER_GROUP=128` 的一半） |
| **合计** | | | **~7.1 MB** | 一次性显存，**不随 group 数浮动** |

`count=25600` ≠ `count=200` 的差异决定了 **node/skeleton 走的是"每节点 1 槽 atlas"**，而 **meta/batchMeta 走的是"每 cloth 1 槽 atlas"** —— 这与 `_UpdateRuntimeGroupMeta` 中 `skeletonOffset = cellIdx << 9` (= `cellIdx × 512`) 一致：每 cell 占 512 个 node/skeleton 槽。

---

## 4. CPU → GPU 数据流：5 张常驻 buffer 的布局与 sector/cellIdx 编址

### 4.1 cellIdx 池：50 槽 LRU-like 复用

```
m_availableCellIdx : int[50]    // 初始全 -1; 激活时取首个 -1 槽改成 0(=占用); 去激活时改回 -1
```

每个 cellIdx ∈ [0, 49] 对应 5 张 buffer 中的一段固定区段：

```
node atlas:      [cellIdx*512 .. cellIdx*512 + 511]    × 192 B/槽
skeleton atlas:  [cellIdx*512 .. cellIdx*512 + 511]    × 96  B/槽
meta atlas:      [cellIdx*4   .. cellIdx*4   + 3]      × 176 B/槽
batchMeta atlas: [cellIdx*4   .. cellIdx*4   + 3]      × 16  B/槽
cacheMap atlas:  [cellIdx*64  .. cellIdx*64  + 63]     × 16  B/槽
```

`_UpdateRuntimeBuffer`（`GpuClothManager.cs:3953`）反汇编关键代码：

```
mov eax, edi           ; eax = cellIdx
shl eax, 9             ; eax = cellIdx << 9 = cellIdx * 512   → skeletonOffset
mov [rsp+30h], eax     ; → groupOffset.x  (写入 ClothMetaData[i].groupOffset)
lea eax, [rdi*8]       ; eax = cellIdx * 8                    → metaOffset(?)
shl edi, 7             ; edi = cellIdx << 7 = cellIdx * 128   → cacheOffset(?)
mov [rsp+34h], eax     ; → groupOffset.y
mov [rsp+38h], edi     ; → groupOffset.z
mov eax, [rsi+4]       ; → groupOffset.w = clothGroupMeta.clothGroupHash
```

→ `ClothMetaData.groupOffset = int4(cellIdx<<9, cellIdx*8, cellIdx<<7, clothGroupHash)`

> `cellIdx*8` 与 `cellIdx<<7=cellIdx*128` 两个偏移含义待 .hlsl 确认；推测：
> - `*8` 可能是 batch atlas 的 stride（4 cloth × 2 int4/cloth = 8）
> - `*128` 可能是 cacheMap atlas 的 cell stride（与 `MAX_CLOTH_CACHE_ENTRY_PER_GROUP=128` 同值）
> 这种"用 int4 packed 多个偏移"的设计避免每件 cloth 单独走 cbuffer，shader 直接拿 groupOffset 索引五张 atlas。

### 4.2 sector 流式：Chebyshev playerCenter 触发刷新

`_ProcessPendingQueue`（`GpuClothManager.cs:719`）反汇编：

```
if (!m_isClothMetaBufferDirty && NativeParallelHashSet.Count(m_groupHashNeedToUpload) > 0) return;

// 计算 playerMoveDist² = (now - last) ⊙ (now - last)
playerDelta = m_playerCenterXZ - m_lastPlayerCenterXZ;
moveDistSq  = dot(playerDelta, playerDelta);            // sub_18406BA20 = SIMD dot

if (moveDistSq <= g_18C4714CC  &&  !m_isForcedRefresh) return;  // 不足阈值, 不刷新
m_lastPlayerCenterXZ = m_playerCenterXZ;

_UpdatePendingGroupHash(needSwap = true);
   ├ swap(m_activatedGroupHash, m_lastActivatedGroupHash)
   ├ m_activatedGroupHash.Clear()
   ├ if m_shouldActivatedGroupHash.Count <= MAX_RUNTIME_CLOTH_GROUP_NUM(=50)
   │     → 全加入
   │   else
   │     s_clothActiveComparer.{playerCenterXZ, registedClothGroupData} = ...
   │     m_shouldActivatedGroupHash.Sort(s_clothActiveComparer)      ← 按距 playerXZ 排序
   │     for i in 0..50:    m_activatedGroupHash.Add(should[i])      ← 取前 50 近
   ├ diff:
   │   foreach h in m_activated:      if !m_lastActivated.Contains(h)  m_pendingActivate.Add(h)
   │   foreach h in m_lastActivated:  if !m_activated.Contains(h)      m_pendingDeactivate.Add(h)

foreach h in m_pendingDeactivate:  _DeactivateClothGroup_Internal(h)
foreach h in m_pendingActivate:    _ActivateClothGroup_Internal(m_registedClothGroupData[h])
m_isForcedRefresh = false;
```

> **`g_18C4714CC` 应为 `CLOTH_DIRTY_DISTANCE² = 32² = 1024.0f`**（据反汇编 `comiss xmm1, xmm0`；`CLOTH_DIRTY_DISTANCE=32f` `GpuClothManager.cs:517` 是 dist 而非 dist²，故比较时必须用平方避免开方 —— 这是 SIMD 距离比较的标准技巧）。该值待 .rdata 确认。

`s_clothActiveComparer.Compare(uint a, uint b)`（`GpuClothManager.cs:319`）实际做的是：从 `m_registedClothGroupData[a/b].clothGroupMeta.groupWorldPosXZ` 取 2D 位置，算 `|playerCenterXZ - groupPosXZ|²` 升序 —— 即 **Chebyshev playerCenter-radial 优先级**。结果是 **总是把最近的 50 组保留在 GPU atlas 上**。

### 4.3 swap-and-remove + reverse-index patch（`_DeactivateClothGroup_Internal`）

布料 meta 集合 (`m_runtimeClothMetaArray : DynamicArray<ClothMetaData>`) 是 **紧凑数组**（约束 GPU 端 dispatch 维度），删除中间项必须保持紧凑：

```
_DeactivateClothGroup_Internal(uint groupHash):
   meta_internal = m_activatedGroupHashToGroupMeta[groupHash]
   m_runtimeClothGroupNum  -= 1
   m_runtimeClothNum       -= meta_internal.clothGroupMeta.clothNum
   m_activatedGroupHashToGroupMeta.Remove(groupHash)
   foreach i in 0..clothNum:
       m_clothHashToRuntimeClothData.Remove(meta_internal.clothGroupMeta.clothHashes[i])
   m_availableCellIdx[meta_internal.cellIdx] = -1         ← 归还 cell
   foreach i in 0..clothNum:
       int oldIdx = meta_internal.clothMetaIdx[i]          // 待删 cloth 在大数组中的位置
       GpuClothUtils.SwapAndRemove(m_runtimeClothMetaArray, oldIdx)
           // 算法: tail = arr[count-1]; arr[oldIdx] = tail; arr.size -= 1
       m_isClothMetaBufferDirty = true
       // ★ swap 把 tail 那项移到了 oldIdx 位置, 必须 patch 它所属 group 的 clothMetaIdx
       int movedClothHash = m_runtimeClothMetaArray[oldIdx].groupOffset.w
       if (movedClothHash 属于 this group):
           meta_internal.FindAndSetClothMetaIdx(tail, oldIdx)
       else:
           // 找到 owning group, 在它的 clothMetaIdx[4] 中找 tail 改成 oldIdx
           m_activatedGroupHashToGroupMeta[movedGroupHash].FindAndSetClothMetaIdx(tail, oldIdx)
       meta_internal.clothMetaIdx[i] = -1
```

> 这是 **经典 swap-and-remove + reverse-index** 模式（`groupOffset.w = clothGroupHash` 是 reverse pointer），避免 O(N) 收缩。`FindAndSetClothMetaIdx(oldIdx, newIdx)` 在 fixed int[4] 中线性扫描第一个 ==oldIdx 的槽并改成 newIdx —— 该方法在 `ClothGroupMeta_Internal.FindAndSetClothMetaIdx`（`GpuClothManager.cs:19`）实现。

### 4.4 ECS 回写 `skeletonOffset` 到 `CommonInstanceDataComponent`

`_SetPerDrawData`（`GpuClothManager.cs:886`）每帧通过 `EntityManager.Iterate<ECSClothDataComponent, CommonInstanceDataComponent>(...)`，对每个挂了 `ECSClothDataComponent` 的实体：

```
clothHash = ECSClothDataComponent.clothHash
if m_clothHashToRuntimeClothData.TryGetValue(clothHash, out runtimeData):
    CommonInstanceDataComponent.+0xF0 = runtimeData.skeletonOffset + 1.0f     // float, +1 用作"有效"flag
    CommonInstanceDataComponent.+0xF4 = runtimeData.isSingleSkeleton          // 1f / 0f
else:
    CommonInstanceDataComponent.+0xF0 = 0.0f   // 表示无效
```

→ vertex shader 读 `+0xF0` 判定是否走布料化路径；走的话用 `+0xF0 - 1.0` 作为 skeleton atlas 起始偏移、`+0xF4` 决定是否多骨骼采样。这是 **CPU 端的实例数据"广播"**——把 GPU 物理结果反向告诉每个渲染实例。

`runtimeData.isSingleSkeleton` 的判定在 `_UpdateRuntimeGroupMeta`（`GpuClothManager.cs:4111`）：

```
cmp dword ptr [r15], 100h        ; clothNodeNum vs 0x100=256
jle short loc_18A869B55          ;
movss xmm1, [g_18C471324]        ; 1.0f
loc_18A869B58:                    ;  → isSingleSkeleton = 1.0
xorps xmm1, xmm1                 ;  → isSingleSkeleton = 0.0 (节点数 ≤ 256)
```

→ **"single skeleton" 的判定阈值是 cloth 节点数 > 256**。语义推断：小布料（≤256 节点）每节点单独是一个 skeleton 槽；大布料（>256）需要降采样 / 单一 root skeleton。具体在 vertex shader 端如何区分两条路径待 .hlsl 确认。

---

## 5. 每帧时序：Timer 子步 + 流式激活 + 上传脏标记 + Pass 装配

### 5.1 `UpdateTimer` —— 固定时间步累加器

`GpuClothManager.cs:2445` 反汇编核心：

```
UpdateTimer():
    shouldStep = false
    if !IsClothSkeletonValid()  return         // 还没初始化, 跳

    cumulativeTime += gameplayDt
    if cumulativeTime >= PHYSICS_DELTA_TIME [g_18E5EC488 = 0.023333333f]:
        loopNum         = min(floor(cumulativeTime / PHYSICS_DELTA_TIME), CAP)
        cumulativeTime -= loopNum * PHYSICS_DELTA_TIME
        shouldStep      = true
```

> - **`PHYSICS_DELTA_TIME = 0.023333333f`** ≈ 1/42.857 s ≈ 23.33 ms —— 物理子步固定 ~43Hz。**对应电影帧率 24 fps × 1.785 ≈ 43**——可能是从 24 fps 镜头美术经验值反推的（每电影帧 ~1.78 物理子步）。
> - **`CAP`** = `minss xmm0, [T_TypeInfo]` 的立即数（待 .rdata 确认）。典型值 3 或 4 —— 大延迟卡顿时不无限累加，防雪崩。
> - 当 `gameplayDt > PHYSICS_DELTA_TIME` 时（即帧率 < 43 fps），`loopNum ≥ 2`，意味着同一帧内 ClothSim kernel 会在 GPU 端跑多步子积分（kernel 内由 `packedDeltaT.w = loopNum` 控制 for 循环次数）。

### 5.2 每帧入口 `Tick` → 子系统调度

```
Tick(float deltaTime):
    gameplayDt = deltaTime
    _UpdateWindParams()
    if isStreamingMode:           ← 首次 RegisterClothGroup 后置 1
        _ProcessPendingQueue()    ← §4.2
        UpdateTimer()             ← §5.1
        _SetPerDrawData()         ← §4.4
```

调用者：`HGRenderPipeline.OnPreRender` (推测；具体调用链在 [`../01-PipelineCore/01-HGRenderPipeline-Infrastructure.md`](../01-PipelineCore/01-HGRenderPipeline-Infrastructure.md) 单元)。

### 5.3 GetXxxData 数据准备时机

PassConstructor 在 `ConstructPass` 内（每帧 RenderGraph 装配时）调三个 wrapper：

```
GetClearBufferData_CSharpWrapper(out clearData)     ← C# 端 = GpuClothManager.GetClearBufferData()
GetUploadData_CSharpWrapper   (out uploadData)      ← C# 端 = GpuClothManager.GetUploadData()
GetRenderData_CSharpWrapper   (out renderData)      ← C# 端 = GpuClothManager.GetRenderData()
```

- `GetClearBufferData`：如果 `needClearGPUBuffer == true`，填好 `eleNum` 和 3 个 buffer 引用，置 `shouldClear=1` 并 `needClearGPUBuffer=0`。
- `GetUploadData`：如果 `shouldStep && (m_isClothMetaBufferDirty || hasPendingUpload)`，从 `m_groupHashNeedToUpload` 中按 `MAX_UPLOAD_GROUP_NUM=4` 与 `MAX_NODE_NUM_PER_UPLOAD=680` 双限制取出 ≤4 组数据 ResizeAndCopy 到 `clothNodeUploadData / clothMetaUploadData / clothBatchMetaUploadData / clothBatchCacheMapUploadData`，逐组填 `ClothGroupUploadDataMap.{clothNodeDataMap, clothBatchMetaDataMap, clothBatchCacheDataMap}`，置 `isValid = (uploadDataMap.Length > 0)`。
- `GetRenderData`：如果 `shouldStep`，调四个 setter：
  - `clothConstData.SetDt(PHYSICS_DELTA_TIME)`
  - `clothConstData.SetSkeletonFlipped(skeletonFlipped)`
  - `clothConstData.SetLoopNum(loopNum)`
  - `clothConstData.SetClothWindParams(windTime, windNoiseUV)`
  
  然后整体 movups 拷贝 5 个 buffer 引用 + `clothConstData` 到返回结构。`isValid = (clothNum > 0)`。

### 5.4 OnPostRendering 翻转

`GpuClothSimulationPassConstructor.OnPostRendering`：

```
HG.Rendering.Runtime.HGManagerContext.currentManagerContext.+0x68  → GpuClothManager
mgr.FlipSkeletonFlag()
   if shouldStep:  skeletonFlipped = 1.0 - skeletonFlipped
```

> `skeletonFlipped` 在 `ClothConstData.SetSkeletonFlipped` 中写入 `packedDeltaT.y`，给 shader 当读写双缓冲选择位用：`flipped == 0` → 读 atlas 偶半区/写奇半区；下帧反之。这是经典 ping-pong 但用 0/1 浮点常量切换（避免分支）。

### 5.5 时序 ASCII 图

```
帧 N 开始:
  ┌─────────────────────────────────────────────────────────────────────┐
  │ MainThread Update phase                                              │
  │  ├─ ClothInfo.OnUpdate (no per-frame; Mono callback)                 │
  │  └─ Game logic: Player move, ECSClothDataComponent on/off            │
  ├─────────────────────────────────────────────────────────────────────┤
  │ HGRenderPipeline.OnPreRender:                                        │
  │  GpuClothManager.Tick(gameplayDt):                                   │
  │    ① _UpdateWindParams: phase.windNoise → windTime/windNoiseUV       │
  │    ② _ProcessPendingQueue:                                           │
  │         if playerMove > 32  or  forceRefresh:                        │
  │             sort should set by Chebyshev XZ distance                 │
  │             diff against last activated → pending act/deact          │
  │             _DeactivateClothGroup_Internal × N (free cell, swap)     │
  │             _ActivateClothGroup_Internal × M (alloc cell, queue upload)│
  │    ③ UpdateTimer: cumul += dt; shouldStep = cumul ≥ PHYSICS_DELTA_TIME│
  │    ④ _SetPerDrawData: ECS iterate, write skeletonOffset → +0xF0/+0xF4│
  ├─────────────────────────────────────────────────────────────────────┤
  │ HGRenderGraph builds passes (RenderThread):                          │
  │  GpuClothSimulationPassConstructor.ConstructPass:                    │
  │    GetClearBufferData → if shouldClear:  AddPass GpuClothDataClear   │
  │    GetUploadData      → if isValid:     AddPass GpuClothDataUpload   │
  │    GetRenderData      → if isValid:     AddPass GpuClothSim          │
  │                       else:            AddPass GpuClothSetDefault    │
  ├─────────────────────────────────────────────────────────────────────┤
  │ RenderGraph execution (GPU):                                         │
  │  1) ClothDataClearMain      [if scheduled]                           │
  │  2) ClothDataUploadMain     [if scheduled, 2 cbuffer × 65280 B]      │
  │  3) ClothSimMain            [if scheduled, 1 cbuffer × 160 B]        │
  │       inner: loopNum × iterNum × MAX_CLOTH_BATCH × Jacobi step       │
  │  4) Geometry passes consume:                                         │
  │       - clothSkeletonDataBuffer (skinning)                           │
  │       - CommonInstanceDataComponent.+0xF0 (skeletonOffset + 1)       │
  ├─────────────────────────────────────────────────────────────────────┤
  │ OnPostRendering:                                                     │
  │  GpuClothManager.FlipSkeletonFlag()                                  │
  │    if shouldStep: skeletonFlipped = 1 - skeletonFlipped              │
  └─────────────────────────────────────────────────────────────────────┘
帧 N+1 开始 ...
```

---

## 6. 数学：风力、Verlet 积分、约束求解、capsule 碰撞投影、法线重算

### 6.1 风力 (`_UpdateWindParams` → kernel `windForce`)

**CPU 端（`GpuClothManager.cs:603`，参考 `GetClothAnimationWindIntensity/Freq` 在 `GpuClothUtils.cs`）：**

```
windSpeed = windSpeed_old * g_18C47163C * g_18C471644 * gameplayDt
windTime += windSpeed                            // 累计相位
phaseWindNoise.xy = HGEnvironmentManager.s_interpolatedPhase.+0x7AC..+0x7B4
windNoiseUV += phaseWindNoise.xy * windSpeed     // 噪声采样 UV 累积
// 写入 ClothConstData.clothParam1 = (windTime, windNoiseUV.x, windNoiseUV.y, ?)
```

**GPU 端（kernel 内重建）：**

每件 cloth 用自己的 `windIntensityScale / windSoftFactor / windFreqFactor / windBalancFactor / windDragFactor / windLiftFactor`：

```
// 1. 全局风方向 (来自 phase, 推测在 packedClothNormal.w 或 colliderInfoArray 尾段)
float3 windDir = normalize(...);
float  windMag = ...;

// 2. 局部噪声扰动 (用 windNoiseUV + windTime 采样 noise tex)
float2 uv  = windNoiseUV + nodeUV.xy * windFreqFactor;
float  noise = sampleWindNoiseTex(uv).r;           // [0,1]
float  localMag = windMag * (1.0 + noise * windSoftFactor) * windIntensityScale;

// 3. 阻力 / 升力 (drag/lift) — 与法线相关
float ndotw    = dot(n_base, windDir);              // 法线点积风向
float3 dragF   = windDragFactor * localMag * windDir;
float3 liftF   = windLiftFactor * localMag * ndotw * n_base;
float3 windF   = dragF + liftF;

// 4. 平衡因子 (windBalancFactor ∈ [-1, 1]) — 控制风更偏吹"垂直"还是"水平"
windF = lerp(windF, windF.xz0, abs(windBalancFactor));   // 推测

a += windF / mass;     // mass 通常 1 (单位质量)
```

> `windDragFactor`/`windLiftFactor` 命名直接来自空气动力学的 **drag/lift coefficient**（阻力/升力系数）。完整 force 模型 `F = ½ρv²(C_d·D̂ + C_l·L̂·sinα·cosα)` 是 Stam-Wakatani-Wilberg 风格布料风力的标准形式 —— 这是 **领域知识合理重建**。

### 6.2 Verlet 积分（§2.3 第 ② 步精确版）

经典 Verlet：

```
x(t+dt) = 2·x(t) − x(t-dt) + a(t)·dt²
```

引入 damping（`ClothInfo.damping`，存在 `ClothMetaData.damping = +0x10`）：

```
x_new = x_cur + (1 − damping) · (x_cur − x_prev) + a · dt²
                    ╰── velocity-equivalent term ──╯
```

`damping ∈ [0, 1)`，0 = 全弹性，1 = 静止流体。这是 **velocity-Verlet 的"位置形式"**——不显式存储速度，速度由 `(x_cur - x_prev) / dt` 隐式表达。

### 6.3 Jacobi 距离约束（§2.3 第 ③ 步）

对于每对邻居 (A, B)，rest 距离 `L₀ = neighbor[k].distance`（存在 `ClothNodeData.neighborClothNodeDistance[k]`）：

```
Δ = x_B − x_A
L = |Δ|
correction = (L − L₀) / L · Δ
x_A_new = x_A + w_A · correction       // w_A, w_B = inverse-mass weights
x_B_new = x_B − w_B · correction
```

Jacobi：**同一 batch 内所有约束并行算 correction，写回时累加平均**（典型 w = 0.5）。Gauss-Seidel：串行算。HG 用 batch 染色 → batch 内 Jacobi、batch 间 Gauss-Seidel。

**iterNum** (`ClothMetaData.iterNum = +0x0C`) = 外迭代次数：典型 4–10 次让约束收敛到容差以内。`ClothInfo.iterNum` (readonly) 由资产烘焙写死。

### 6.4 Anchor 软约束（§2.3 第 ③ 步末尾）

每节点最多 2 个 anchor，存 `anchorNodeCacheIdx : int2` + `anchorNodeDistance : float2`。anchor 不是 hard pin（不强制 x = anchorPos），而是用 `anchorRelaxScale`/`anchorSecRelaxScale` ∈ [0, 1] 做软投影：

```
for k in 0..2:
    if anchorNodeCacheIdx[k] != INVALID:
        anchorPos = clothBatchCacheMapBuffer[batchCacheBase + anchorNodeCacheIdx[k]].xyz
        L = |anchorPos - x_new|
        x_new += relaxScale[k] * (L − anchorDist[k]) / L * (anchorPos - x_new)
```

`relaxScale[0] = anchorRelaxScale`、`relaxScale[1] = anchorSecRelaxScale` —— 主/次 anchor 区别开（如：第一 anchor 是固定挂点，第二 anchor 是辅助约束）。

`clothAnchorVertexIndices` 和 `clothAnchorConstraintVertexIndices` 两个 HashSet (`ClothInfo.cs`) 区分 **顶点 anchor**（位置约束）和 **顶点约束 anchor**（约束端点） —— 后者参与 spring topology 构建。

### 6.5 Capsule 投影碰撞（§2.3 第 ④ 步精确版）

`ClothConstData.colliderInfoArray[48]` = 4 段 × 12 float。`_SetCharacterProxyMesh`（`GpuClothManager.cs:3879`）反汇编：

```
for batchIdx in [0, 3, 6, 9]:                                ← 步进 3，覆盖 4 段
    clothConstData.SetVec4(batchIdx + 2, Vector4(m_capsuleRadius, m_capsuleHeight, 0, 0));
    clothConstData.SetVec4(batchIdx,     bounds.center+extents 包成的 Vector4);
```

→ 每段 3 个 Vector4 = 12 float 的语义（**据反汇编 + 领域推断**）：

```
struct CapsuleInfo {       // 48 字节 / 3 Vec4
    float4 topAndRadius;       // .xyz = top center, .w = radius
    float4 bottomAndHeight;    // .xyz = bottom center, .w = height
    float4 paramsAndPad;       // .xy = (radius, height) 备份, .zw = unused
};
```

每节点 vs 每 capsule 投影（标准胶囊距离公式）：

```
float capsuleDist(float3 p, float3 top, float3 bot, float r) {
    float3 ab = bot - top;
    float t = saturate(dot(p - top, ab) / dot(ab, ab));      // 投影到轴
    float3 closest = top + t * ab;
    return length(p - closest) - r;                          // signed distance to capsule
}
```

投影：若 `d < 0`（p 在 capsule 内）：

```
n_capsule = normalize(p - closest);
p_new = closest + r * n_capsule;     // 推出到表面
// (可选) 应用摩擦: vel_tangent *= friction
```

`UpdateCharacterPositions(List<Vector3>)` 每帧把最多 4 个角色位置 → 4 段 capsule 参数：

```
for ch in 0..4:
    pos = characterPositions[ch]
    if pos invalid (颜色 clear, x*x+y*y+z*z ≈ 0):
        SetVec4(ch*3,   INVALID_POSITION)
        SetVec4(ch*3+1, INVALID_POSITION)
        continue
    topVec    = pos + CHARACTER_POSITION_OFFSET    // CHARACTER_POSITION_OFFSET 是常量, 头部偏移
    bottomVec = pos - CHARACTER_POSITION_OFFSET    // 脚底偏移
    capRadius = m_capsuleRadius
    capHeight = length(topVec - bottomVec)         // 或固定值, 据反汇编 sqrtpd
    SetVec4(ch*3,     float4(topVec.xyz,    capRadius))
    SetVec4(ch*3 + 1, float4(bottomVec.xyz, capHeight))
    SetVec4(ch*3 + 2, float4(capRadius, capHeight, 0, 0))   // 备份/对齐
```

`MAX_COLLIDER_NUM=4` 意味着 **最多 4 个角色同时被布料系统感知**（推测为：玩家 + 最多 3 个同伴/敌人）。多于 4 时需要选最近的 4 个 —— 选择策略在游戏逻辑层。

### 6.6 法线重算（§2.3 第 ⑦ 步）

模拟后位置变了，渲染用的法线必须重算。标准做法 —— 对节点的邻居环求平均叉积：

```
float3 n_new = float3(0,0,0);
for k in 0..MAX_NEIGHBOR_NUM(=8):
    if neighbor[k] valid && neighbor[k+1] valid:
        float3 e0 = nodes[neighbor[k]  ].curPos - pos_new;
        float3 e1 = nodes[neighbor[k+1]].curPos - pos_new;
        n_new += cross(e0, e1);
n_new = normalize(n_new);
clothNodeDataBuffer[nodeIdx].packedCurNormal.xyz = n_new;
```

`SetCollisionPlane(Vector4 plane)`（`ClothNodeData.cs:31`）实际是用来把 cloth 的"碰撞参考平面"（如 character 身上的局部 plane）压进 `collisionPlaneXY (xy)` + `packedBaseNormal.w (plane.z)` + `packedPrePosition.w (plane.w)` 三处 packed 槽 —— 节省 stride，**据反汇编**。这个 plane 推测用于 cloth 与 character 表面的快速碰撞预筛（节点必须在 plane 正侧才算 valid，否则直接 clamp 到 plane 上）。

---

## 7. 关键常量 / 魔数总表（逐字照抄 + 含义）

| 类型 | 名 | 值 | 文件:行 | 含义 / 推断 |
|---|---|---|---|---|
| const int | `MAX_CLOTH_PER_GROUP` | `4` | `ClothGroupMeta.cs:7` | 一个布料组内 cloth 数上限 |
| const int | `MAX_CLOTH_NODE_PER_GROUP` | `512` | `:9` | 一组内节点数上限 |
| const int | `MAX_CLOTH_BATCH_PER_GROUP` | `8` | `:11` | 一组内约束 batch 数（图染色色块数）上限 |
| const int | `MAX_CLOTH_CACHE_ENTRY_PER_GROUP` | `128` | `:13` | 一组内 anchor cache map 槽数 |
| const int | `MAX_CLOTH_SKELETON_PER_GROUP` | `512` | `:15` | 一组内骨骼 atlas 槽数 (=节点数) |
| const int | `MAX_NODE_NUM_PER_CBUFFER` | `340` | `GpuClothGroupUploadData.cs:9` | 单 cbuffer 节点容量 (65280B / 192B = 340) |
| const int | `MAX_NODE_NUM_PER_UPLOAD` | `680` | `:11` | 单帧上传节点数上限 (= 2 个 cbuffer) |
| const int | `MAX_CACHE_ENTRY_BUDGET` | `128` | `:13` | 单帧上传 cache entry 预算 |
| const int | `MAX_UPLOAD_GROUP_NUM` | `4` | `:15` | 单帧上传组数上限 |
| const int | `MAX_ANCHOR_NUM` | `2` | `GpuClothManager.cs:425` | 每节点主/次 anchor |
| const int | `MAX_NEIGHBOR_NUM` | `8` | `:427` | 每节点 spring 邻居数 (4-邻接 + 4-对角) |
| const int | `MAX_CLOTH_NEIGHBOR_NUM` | `128` | `:429` | 每件 cloth 邻居总数上限 |
| const int | `CLOTH_BATCH_SIZE` | `256` | `:431` | 单 batch 内并行约束数 (= compute thread group?) |
| const int | `MAX_COLLIDER_NUM` | `4` | `:433` | 同时参与的 capsule 数 |
| const int | `MAX_RUNTIME_CLOTH_GROUP_NUM` | `50` | `:435` | cellIdx 池大小 |
| const float | `PHYSICS_DELTA_TIME` | `0.023333333f` | `:469` | 固定子步长 ≈1/42.857s ≈ 43 Hz |
| const float | `CLOTH_DIRTY_DISTANCE` | `32f` | `:517` | playerXZ 位移阈值 |
| readonly Vector4 | `CHARACTER_POSITION_OFFSET` | (待 .rdata) | `:437` | 角色 capsule top/bottom 的 ±偏移 |
| readonly Vector4 | `INVALID_POSITION` | (待 .rdata; 推测 (∞,∞,∞,0) or Color.clear) | `:439` | 无效 capsule 槽填充值 |
| fixed | `ClothConstData.colliderInfoArray[48]` | 4×12 float | `ClothConstData.cs:11` | 4 段 capsule(top,radius,bot,height,radiusBak,heightBak,0,0,...) |
| fixed | `ClothNodeData.neighborClothNodeCacheIdx[8]` | 8 int | `ClothNodeData.cs:27` | spring 邻居索引 |
| fixed | `ClothNodeData.neighborClothNodeDistance[8]` | 8 float | `:29` | spring 邻居 rest 距离 |
| fixed | `ClothSkeletonData.skeletonData[24]` | 24 float = 96B = 6 Vec4 | `ClothSkeletonData.cs:5` | 推断: 当前 (pos, normal, tangent, prePos, baseNormal, baseTangent) 或矩阵 + 备份 |
| asm | `_InitStreamingGpuBuffer` node count | `0x6400 = 25600` | `GpuClothManager.cs:4228` | = 50 × 512 |
| asm | skeleton count | `0x6400 = 25600` | `:4242` | = 50 × 512 |
| asm | meta count | `0xC8 = 200` | `:4223` | = 50 × 4 |
| asm | batchMeta count | `0xC8 = 200` | `:4232` | = 50 × 4 |
| asm | cacheMap count | `0xC80 = 3200` | `:4237` | = 50 × 64 |
| asm | cbuffer size | `0xFF00 = 65280` | `GpuClothSimulationPassConstructor.cs:1412` | 单 cbuffer 上传容量 |
| asm | playerMoveDist² 阈值 `g_18C4714CC` | 推测 `1024.0f = 32²` | `GpuClothManager.cs:765` | sector 触发阈值平方 |
| asm | UpdateTimer loopNum cap | (待 .rdata) | `:2471` | 推测 3 或 4 |

---

## 8. 1:1 重建蓝图（按子系统分步）

### 8.1 数据结构（最低成本，直接照抄）

| 单元 | 步骤 | 难度 |
|------|------|------|
| 12 个 struct（`ClothConstData/ClothGroupMeta/...`） | 字段名/类型/偏移/`fixed` 大小逐字段照抄；保持 16B SIMD 对齐 | ★☆☆☆☆ |
| 5 个 MonoBehaviour（`ClothInfo/ClothGroupInfo/ClothRendererMarker/ClothMeshFilter/GpuClothMatrixGenerator`） | 字段表 + `[Header]`/`[Range]` 属性 + `OnBefore/AfterSerialize` HashSet↔List 转换 | ★★☆☆☆ |
| 19 个 const/魔数 | §7 表逐字符照抄 | ★☆☆☆☆ |

### 8.2 `GpuClothManager` 主管理器

| 模块 | 步骤 | 难度 |
|------|------|------|
| 嵌套类型 (`ClothGroupMeta_Internal / ClothGroupData_Internal / ClothActivateComparer / RuntimeClothData_Internal`) | 直接照抄字段；`Internal` 字段必须保持反汇编中的偏移（`cellIdx=+0x50, clothMetaIdx=+0x54`） | ★★☆☆☆ |
| `Register/Unregister ClothGroup` | `CopyFromClothGroupData` 用 `UnsafeUtility.Malloc(size,4)` × 4 段 + `MemCpy`；`Unregister` 时 `Reset()` 全 Free | ★★★☆☆ |
| `Activate/Deactivate ClothGroup` | 仅写 `m_shouldActivatedGroupHash` + `m_isForcedRefresh=true`；真正的激活在 `_ProcessPendingQueue` 中延迟做 | ★☆☆☆☆ |
| `_ProcessPendingQueue` + `_UpdatePendingGroupHash` | Chebyshev XZ 距离排序 + 双 hashset diff（§4.2 完整逻辑） | ★★★☆☆ |
| `_ActivateClothGroup_Internal` → `_UpdateRuntimeGroupMeta` + `_UpdateRuntimeBuffer` | cellIdx 分配 + `ResizeAndCopy<ClothMetaData>` + 按 cellIdx 算 4 维 `groupOffset` 覆盖每件 cloth 的 meta | ★★★☆☆ |
| `_DeactivateClothGroup_Internal` swap-and-remove + reverse-index patch | §4.3 完整算法；`groupOffset.w = clothGroupHash` 是 reverse pointer | ★★★★☆ |
| `_InitStreamingGpuBuffer` 5 张 buffer | §3.4 5 行 ResizeComputeBuffer 照抄 | ★☆☆☆☆ |
| `_UpdateWindParams` + phase 接线 | 需先移植 `HGEnvironmentManager.s_interpolatedPhase` 单元；本模块只读 `phase.+0x7AC..+0x7BC` 4 字节段 | ★★★☆☆ |
| `_SetCharacterProxyMesh` + `UpdateCharacterPositions` | §6.5 12 float/capsule 打包 + 4 段角色位置 → INVALID 屏蔽 | ★★★☆☆ |
| `UpdateTimer` 子步 | §5.1 5 行；`loopNum cap` 立即数待 .rdata 确认 | ★★☆☆☆ |
| `GetClearBufferData/GetUploadData/GetRenderData` | §5.3 三个 wrapper；上传按 `MAX_UPLOAD_GROUP_NUM=4` + `MAX_NODE_NUM_PER_UPLOAD=680` 双限制 | ★★★☆☆ |
| `_SetPerDrawData` ECS 回写 | 需先实现 `EntityManager.Iterate<T,U>` + `ECSClothDataComponent` + `CommonInstanceDataComponent.+0xF0/+0xF4` | ★★★★☆ |
| `FlipSkeletonFlag` | 1 行：`if shouldStep: skeletonFlipped = 1 − skeletonFlipped` | ★☆☆☆☆ |
| 11 处 `RecycleNativeDataStructs<...>`（在 `Dispose`） | 照搬 `GpuClothUtils` 工具函数；按类型分发 | ★★☆☆☆ |

### 8.3 `GpuClothSimulationPassConstructor` RenderGraph 接线

| 模块 | 步骤 | 难度 |
|------|------|------|
| 构造：3 个 FindKernel("ClothSimMain"/"ClothDataUploadMain"/"ClothDataClearMain") | 注意 upload+clear 共享 `m_clothDataUploadCS` 一个 CS 资源；sim 独立 | ★★☆☆☆ |
| `ConstructPass`: 4 条件 AddRenderPass + SetRenderFunc | §3.1 4 pass；最后一个 Pass `builder.AllowPassCulling(false)` | ★★★☆☆ |
| `_AllocateClothNodeConstBuffer` 双 65280B 分裂 | §3.3 完整算法；前 340 拷第一段，剩余拷第二段 | ★★★☆☆ |
| `_PrepareClothClearPassData` / `_PrepareClothUploadPassData` / `_PrepareClothSimPassData` | 把 CPP-blittable 数据 + 5 个 BufferID 装进 PassData 类 | ★★☆☆☆ |
| `PrepareShaderVariablesGlobal` → `+0xC20` 4 float | (skeletonValid, skeletonFlipped, shouldStep, Time.time) | ★★☆☆☆ |
| `OnPostRendering` → `FlipSkeletonFlag` | 1 行 | ★☆☆☆☆ |

### 8.4 GPU compute shader（HLSL，需独立实现）

| Kernel | 步骤 | 难度 |
|--------|------|------|
| `ClothDataClearMain` | 单一 RWStructuredBuffer 写 0；可用 `[numthreads(64,1,1)]` + linearIdx clamp 写 `eleNum.{x,y,z,w}` 段 | ★☆☆☆☆ |
| `ClothDataUploadMain` | 从 2 个 cbuffer + 3 个 const buffer 读，按 `ClothGroupUploadDataMap.clothNodeDataMap.zwxy` 偏移写到 atlas 对应 segment | ★★☆☆☆ |
| `ClothSimMain` | §2.3 7 步全部实现：风/Verlet/Jacobi×iterNum×batch/anchor/capsule×4/softRange/normal recompute；用 `groupshared` 保存当前 batch 内的 256 节点位置；`GroupMemoryBarrierWithGroupSync()` 间断 | ★★★★★ |

### 8.5 资产 / 烘焙工具

- `ClothInfo` 的 anchor 集合需要在编辑器/烘焙期生成 `clothNodeDataArray + clothBatchMetaArray + clothBatchCacheMapArray`；其中 batch 由 **图染色（Welsh-Powell / DSatur）** 把所有 spring 约束分到 ≤ `MAX_CLOTH_BATCH_PER_GROUP=8` 个无冲突 batch（同一 batch 内任意两个约束不共享节点，保证 Jacobi 并行无 race）。
- `FillPadding` 在末尾 `Add(int4(0,0,0,0))` 是为了让 batch 数补齐到偶数（因为上传按 `(totalBatch+1)/2` 个 int4 走 —— 见 `GpuClothManager.GetUploadData` 反汇编）。

---

## 9. 支撑证据：核心数据结构表

### 9.1 `ClothMetaData` (176 字节)

```csharp
public struct ClothMetaData                       // stride = 0xB0
{
    public uint    clothNodeIdxStart;             // +0x00  此 cloth 在 nodeBuffer 的起始 idx
    public uint    clothNodeIdxEnd;               // +0x04
    public uint    batchIdxStart;                 // +0x08  此 cloth 在 batchMetaBuffer 的起始 idx
    public uint    iterNum;                       // +0x0C  约束迭代次数
    public float   damping;                       // +0x10
    public float   windFreqFactor;                // +0x14
    public float   windBalanceFactor;             // +0x18
    public float   windIntensityScale;            // +0x1C
    public int4    groupOffset;                   // +0x20  (cellIdx<<9, cellIdx*8, cellIdx<<7, clothHash)
    public Vector4 packedLongestAnchorDistance;   // +0x30  .x=longestAnchorDist  .y=windSoftFactor  .z=transformScale
    public Vector4 packedClothNormal;             // +0x40  .xyz=cloth 整体法线 (或风向?)  .w=?
    public Vector4 localToWorld0;                 // +0x50  cloth 局部到世界矩阵第 0 行
    public Vector4 localToWorld1;                 // +0x60
    public Vector4 localToWorld2;                 // +0x70
    public Vector4 worldToLocal0;                 // +0x80  逆矩阵第 0 行
    public Vector4 worldToLocal1;                 // +0x90
    public Vector4 worldToLocal2;                 // +0xA0
}
```

> `GetWindSoftFactor`/`GetTransformScale` 反汇编访问 `[+0x38]/[+0x3C]` 证实 packed 向量的 yz 通道复用为 wind/transform 标量。

### 9.2 `ClothNodeData` (192 字节)

```csharp
public struct ClothNodeData                       // stride = 0xC0
{
    public Vector2Int anchorNodeCacheIdx;         // +0x00  (a0_idx, a1_idx) 入 cacheMap buffer
    public Vector2    anchorNodeDistance;         // +0x08  (a0_restDist, a1_restDist)
    public Vector2    uv;                         // +0x10  顶点 UV (用于风噪声采样)
    public Vector2    collisionPlaneXY;           // +0x18  collision plane.xy (zw 见下)
    public Vector4    packedBasePosition;         // +0x20  .xyz=rest pos  .w=?
    public Vector4    packedBaseNormal;           // +0x30  .xyz=rest normal  .w=collisionPlane.z
    public Vector4    baseTangent;                // +0x40
    public Vector4    packedPrePosition;          // +0x50  .xyz=prev pos  .w=collisionPlane.w
    public Vector4    packedCurPosition;          // +0x60  .xyz=cur pos   .w=?
    public Vector4    packedCurNormal;            // +0x70  .xyz=cur normal .w=?
    public unsafe fixed int   neighborClothNodeCacheIdx[8];  // +0x80
    public unsafe fixed float neighborClothNodeDistance[8];  // +0xA0
}
```

> `SetCollisionPlane(Vector4 plane)` 反汇编：plane.xy → `[+0x18]`，plane.z → `[+0x3C]`(=`packedBaseNormal.w`)，plane.w → `[+0x5C]`(=`packedPrePosition.w`)。这种 packed 方式让 stride 维持 192 = 12×16 整除 / 64 字节 cacheline 友好。

### 9.3 `ClothConstData` (160 字节)

```csharp
internal struct ClothConstData                    // 16 + 16 + 192 = 224B? 实测 224B but 'Sized' as 160
{
    public Vector4 packedDeltaT;                  // +0x00  .x=dt  .y=skeletonFlipped  .z=1/dt  .w=loopNum
    public Vector4 clothParam1;                   // +0x10  .x=windTime  .y=windNoiseUV.x  .z=windNoiseUV.y  .w=?
    public unsafe fixed float colliderInfoArray[48];  // +0x20 (48 floats = 192B = 12 Vec4)
}
```

> 总尺寸 `0x20 + 192 = 0xE0 = 224B`，但作为 cbuffer 上传时 HG 通过 `ScriptableRenderContext.AllocateConstantBuffer` 走 fast path（见 `_AllocateConstBuffer<T>` `GpuClothSimulationPassConstructor.cs:1313`）：`r8d = count*3<<4 = count*48` 字节 → 单个 ClothConstData 走 48B 的最小单元。实际 cbuffer size 通过 `count*48` 决定。

### 9.4 `ClothSkeletonData` (96 字节)

```csharp
internal struct ClothSkeletonData                 // stride = 0x60
{
    public unsafe fixed float skeletonData[24];   // 24 float = 6 Vec4
}
```

24 float / 6 Vec4 推测布局：（**待 .hlsl 确认**）

```
+0x00..+0x0F:  vec4 currentPos_packedNormal_x    // .xyz=cur pos, .w=cur normal.x
+0x10..+0x1F:  vec4 packedNormal_yz_packedTangent_x  // .xy=cur normal.yz, .zw=tangent.xy
+0x20..+0x2F:  vec4 packedTangent_zw_basePos      // .xy=tangent.zw, .zw=base pos.xy
+0x30..+0x3F:  vec4 basePos_z_baseNormal_xyz      // .x=base pos.z, .yzw=base normal
+0x40..+0x4F:  vec4 baseTangent_xyz_unused        // .xyz=base tangent
+0x50..+0x5F:  vec4 reserved / second-pass data   // 推测: 双缓冲读区
```

—— 这是为 vertex shader 提供"每节点完整变形信息"的 6-vector pack。

### 9.5 `GpuClothGroupUploadData` / `GpuClothClearBufferData` / `GpuClothRenderData`

三态 buffer 见 §3.1 + §3.2 + 04-GraphicsCPPModule（CPP blittable 镜像 `XxxCPP`）。

---

## 10. 源文件清单（19 个，每个一行职责）

| # | 文件 | 职责 |
|---|------|------|
| 01 | `ClothConstData.cs` | 风/dt/碰撞胶囊常量 cbuffer 结构 (160B); 12 个 setter |
| 02 | `ClothGroupData.cs` | Register 入参 ref struct: ClothGroupMeta + 4 Span<byte> |
| 03 | `ClothGroupInfo.cs` | MonoBehaviour 容器: 多件 ClothInfo + 烘焙数据 (DynamicArray + CompressedInt2Array) + RecomputeBounds + FillPadding |
| 04 | `ClothGroupMeta.cs` | 组级 GPU-可见 meta (80B): 5 个 MAX_ 常量 + clothNum + groupHash + groupWorldPosXZ + 4×fixed[4] |
| 05 | `ClothGroupUploadDataMap.cs` | 上传时的 3 个 int4 段偏移映射 |
| 06 | `ClothInfo.cs` | MonoBehaviour 单件: clothMesh + iter/damping/wind 9 参数 + anchor 集合 + 序列化回调 |
| 07 | `ClothMeshFilter.cs` | MeshFilter 替代; 单字段 `Mesh mesh` |
| 08 | `ClothMetaData.cs` | 单件 GPU-可见 meta (176B): 12 标量 + 8 Vec4; SetLocalToWorld 反写矩阵 + 3 getter |
| 09 | `ClothMobileData.cs` | 移动端裁剪用的 16B 精简版 (clothHash + 3 wind float) |
| 10 | `ClothNodeData.cs` | 单节点 GPU 数据 (192B): 12 Vec2/Vec4 + 8 邻居 + SetCollisionPlane |
| 11 | `ClothRendererMarker.cs` | 渲染期反向引用 (mesh renderer GO → ClothInfo) |
| 12 | `ClothSkeletonData.cs` | skeleton atlas 元素 (96B = 24 float) |
| 13 | `GpuClothClearBufferData.cs` | Pass 1 输入: shouldClear + eleNum + 3 ComputeBuffer |
| 14 | `GpuClothGroupUploadData.cs` | Pass 2 输入: isValid + 5 NativeList + 5 ComputeBuffer; 4 个 MAX_ 常量 (340/680/128/4) |
| 15 | `GpuClothManager.cs` | CPU 主管理器 (~4400 行反汇编); §4 / §5 / §6 几乎全部逻辑 |
| 16 | `GpuClothMatrixGenerator.cs` | 编辑器矩阵生成器: matrixWidth×matrixHeight 个 "clothInfo{i}" GO + AddComponent<ClothInfo> |
| 17 | `GpuClothRenderData.cs` | Pass 3 输入: isValid + clothNum + ClothConstData + 5 ComputeBuffer |
| 18 | `GpuClothSimulationPassConstructor.cs` | IPassConstructor 实现; 3 嵌套 PassData; 4 Pass 装配; 双 cbuffer 65280B 分裂 |
| 19 | `GpuClothUtils.cs` | ResizeAndCopy×3 / SwapAndRemove×2 / RemoveTail / Last / ConvertTo×3 / ResizeComputeBuffer / GetClothAnimationWind{Intensity,Freq} / RecycleNativeDataStructs×3 |

---

## 11. 推断分级与待确认项

### 11.1 各推断的可信度（按 §1.5.4 标准）

- ① **真实源直证**：所有 17 个常量数值、5 张 buffer 的 stride/count、4 个 kernel 名字符串、`_UpdateRuntimeBuffer` 的 4 维 groupOffset 算式、UpdateTimer 的 cumul/loopNum 公式 —— 全部 cite 行号。
- ② **反汇编调用图/常量强推断**：
  - `g_18C4714CC = 1024.0f = 32²`（playerMoveDist² 阈值）
  - `_SetCharacterProxyMesh` 的 4 段 capsule 每段 12 float 打包方式
  - `_UpdateRuntimeGroupMeta` 中 `isSingleSkeleton = (clothNodeNum > 256)`
  - `MAX_NODE_NUM_PER_CBUFFER=340` ↔ `65280 / 192 = 340` 的整除关系
- ③ **领域知识合理重建**：
  - §2.3 完整 7 步 kernel 伪码（mass-spring + Verlet + Jacobi）
  - §6.1 风力 drag/lift/balance 模型（aerodynamic standard）
  - §6.5 capsule signed distance 投影
  - §6.6 邻居叉积法线重算
  - `ClothSkeletonData[24]` 6 Vec4 的具体语义

### 11.2 真未知（仅 HG 特化、无 HDRP/反编译可定）

- [ ] `ClothConstData.colliderInfoArray[48]` 12 float/capsule 第 3 个 Vec4 (.zw=0) 是否还有其他载荷
- [ ] `ClothNodeData.packedBasePosition.w` / `packedCurPosition.w` / `packedCurNormal.w` 未明确的 w 通道实际承载
- [ ] `ClothMetaData.packedClothNormal.w` 是否承载 windDirection.w 或 anchor count
- [ ] `ClothSkeletonData.skeletonData[24]` 6 Vec4 的精确布局（需对照 cloth skinning vertex shader）
- [ ] `UpdateTimer` 中 `loopNum` 上限 cap 的立即数（推测 3 或 4，需 .rdata 读取）
- [ ] `_UpdateWindParams` 中三个 `g_18C47163C/g_18C471644/g_18C471900/g_18C47172C/g_18C471A30/g_18C471294/g_18C4719C0` 全局 float 的具体值（windSpeedScale / freqScale / heightFactor / radiusFactor / capsuleRadiusFactor 等）
- [ ] `g_18C4714CC` 实际值（推测 1024f）
- [ ] `CHARACTER_POSITION_OFFSET` / `INVALID_POSITION` 的实际数值
- [ ] `ShaderVariablesGlobal.+0xC20` 4 float 字段名（见 02-CoreAlgorithms / 全局 shader 接口表）
- [ ] `HGEnvironmentPhase.+0x7AC..+0x7BC` 字段名（见 06-EnvironmentSky）
- [ ] 单 batch 256 节点的 thread group 维度是否真的是 `[numthreads(256,1,1)]`（待 .ushaderbytecode 解包）
- [ ] `groupOffset.y = cellIdx*8` / `.z = cellIdx*128` 的具体语义（推测 batch atlas / cache atlas 起始 idx）

### 11.3 核心算法身份（**不允许进待确认**）

- ✅ Verlet 积分（证据①）
- ✅ Mass-spring 8 邻居（证据②）
- ✅ 2-anchor 软投影（证据③）
- ✅ Jacobi batch-colored 约束（证据④）
- ✅ Capsule×4 投影碰撞（证据⑤）
- ✅ Sector + cellIdx atlas 流式（§4.1）
- ✅ 双 65280B cbuffer 上传分裂（§3.3）
- ✅ Swap-and-remove + reverse-index patch（§4.3）

—— 这八条是本系统的算法骨骼，**不留待确认**。

---

> 文档版本：v2（覆盖旧空壳版）；据 19 个 HG 反编译 C# + GpuClothManager.cs 4425 行反汇编 + GpuClothSimulationPassConstructor.cs 调用图 + 领域 cloth 知识 1:1 重建。
> HDRP 同源：**无**（HDRP 不含 cloth 子系统，本特性纯 HG 自研）。
> 下一步若要 1:1 复刻 GPU 模拟，须用本文 §2.3 / §6 重建 3 个 compute shader 的 HLSL；或解包 `Cloth*.compute.ushaderbytecode` 1:1 反编。
