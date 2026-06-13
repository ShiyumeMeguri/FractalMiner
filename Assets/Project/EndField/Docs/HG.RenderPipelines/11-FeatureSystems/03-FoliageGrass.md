# 11-03 · Foliage / Grass — 植被与草地渲染系统 实现原理蓝图

> EndField（HG.RenderPipelines）的草 / 植被渲染是**完全自研子系统**，HDRP 本体除 `FoliageDiffusionProfile.asset` 一个 SSS profile 之外**没有任何草地/植被实现**（HDRP PackageCache `75de48326bcd` 全文 `Grass*` glob 零命中）。所以本文的算法原理**不来自 HDRP 同源**，而是按以下三条证据 1:1 重建：
>
> ① **HG 反编译 C# 的常量与调用图**（直证级，cite `文件:行` 或反汇编 `call`/魔数）；
> ② **ECS + GPU instancing 渲染管线领域标准**（HDRP `BatchRendererGroup` / `RenderEntitiesV3` / `Graphics.RenderMeshIndirect` 通用范式，HG 这里对接了内部 `UnityEngine.HyperGryph.HGGrassRender` native batch 系统，从反汇编 `call` 处可见）；
> ③ **从反编译看见的算法名/数学形态**（`HGCircularTreeUtils.MakeCircle` / `MakeCircumcircle` / `MakeDiameter` 是教科书 Welzl 最小包围圆；`HGRuntimeGrassQuery.ComputeMergeCost = Vol(union) − Vol(self)` 是 SAH-like 贪心 BVH 插入）。
>
> 配套已有文档（只链不复述）：
> - 草地踩踏弯折/交互高度场算法 → [`../02-CoreAlgorithms/01-CoreAlgorithms.md`](../02-CoreAlgorithms/01-CoreAlgorithms.md) §14；本文讲**草本身的 ECS 实例化渲染、簇生成、风摆、occluder mask、cluster BVH**。
> - Foliage shader / NPR 顶点风摆 → [`../10-Shaders/01-Shaders.md`](../10-Shaders/01-Shaders.md) §3.5。
> - `FoliageOccluderPass` / `FoliageInteractivePass` 在 HGRenderGraph 的全帧位置 → [`../01-PipelineCore/PassConstructors/PreRenderPasses.md`](../01-PipelineCore/PassConstructors/PreRenderPasses.md)。
> - 与"交互链"系统（角色—草—水互动总线）的接口 → [`./12-InteractionChain.md`](./12-InteractionChain.md)。
> - 环境风场 `s_interpolatedPhase` → [`./06-EnvironmentSky.md`](./06-EnvironmentSky.md) 与 [`./05-Volumetric.md`](./05-Volumetric.md)。

---

## 目录

1. [系统定位与解决的渲染问题](#1-系统定位与解决的渲染问题)
2. [子系统拓扑总览](#2-子系统拓扑总览)
3. [Grass 数据模型 — HGGrass / HGGrassData / GrassCluster / GrassRenderer / GrassPerInstanceData](#3-grass-数据模型--hggrass--hggrassdata--grasscluster--grassrenderer--grassperinstancedata)
4. [GPU 实例化渲染 — RenderObjectK1/2/4/8/16 + GrassClusterK4/8/16/32 的 ECS chunk fan-out](#4-gpu-实例化渲染--renderobjectk1248-16--grassclusterk481632-的-ecs-chunk-fan-out)
5. [HGRuntimeGrassQuery — 贪心 SAH BVH，O(log n) 草簇空间查询](#5-hgruntimegrassquery--贪心-sah-bvh-olog-n-草簇空间查询)
6. [Foliage Interactive — 角色脚下双高度图 dual-height bend pass](#6-foliage-interactive--角色脚下双高度图-dual-height-bend-pass)
7. [Foliage Occluder — 64m × 64m / 512² LOD-Fade ping-pong mask 流水线](#7-foliage-occluder--64m--64m--512-lod-fade-ping-pong-mask-流水线)
8. [HGFoliageType — 单棵植被实例 prop（autoHeight / autoAngle / GI 探针 / blend color）](#8-hgfoliagetype--单棵植被实例-propautoheight--autoangle--gi-探针--blend-color)
9. [HGCircularTreeUtils — Welzl 最小包围圆（树冠 / 圆形树投影）](#9-hgcirculartreeutils--welzl-最小包围圆树冠--圆形树投影)
10. [风摆与交互的 shader 输入接口（与 §6 / §7 配套的 cbuffer / 全局贴图）](#10-风摆与交互的-shader-输入接口与-6--7-配套的-cbuffer--全局贴图)
11. [关键常量 / 魔数 总表](#11-关键常量--魔数-总表)
12. [Pass 编排时序（在 HGRenderGraph 内的位置）](#12-pass-编排时序在-hgrendergraph-内的位置)
13. [1:1 复刻蓝图（自顶向下分步）](#13-11-复刻蓝图自顶向下分步)
14. [支撑证据 — 源文件清单表 + 数据结构布局表](#14-支撑证据--源文件清单表--数据结构布局表)
15. [待确认项](#15-待确认项)

---

## 1. 系统定位与解决的渲染问题

EndField 是开放世界 ARPG，植被子系统必须解决：

| 视觉/性能需求 | 方案 |
|---|---|
| 单视锥几万~几十万根草 instance | ECS `GrassClusterK*` chunk + per-instance 24-byte SoA-style `GrassPerInstanceData` + native `HGGrassRender::DrawECSRendererList` 走 GPU instancing |
| 草随角色脚下弯折（无 CPU per-blade 碰撞） | **Foliage Interactive Pass**：相机中心 60×60m R8G8 dual-height RT，shader 顶点采样 → 双线性 lerp → 沿 Y 反向位移 |
| 大树/灌丛遮挡阴影（草被树遮住时关掉风摆 / 关掉色彩） | **Foliage Occluder Pass**：64×64m / 512² R8 occlusion mask，3 sub-pass(Render → Blit → Set Final Mask) ping-pong A/B，LOD-Fade `0.5s` 平滑 |
| 角色位置查询"我脚下是不是草地" | **HGRuntimeGrassQuery** — 贪心 SAH-like BVH，O(log n) `InGrassBoundingBox(worldPos, out overlapBounds)` |
| 圆形树/灌丛 fake-volume 包围圆 | **HGCircularTreeUtils** — Welzl 最小包围圆，从 N 个点求最小覆盖 disc |
| 全局密度/视距调节、不同设备分档 | `HGGrassSettings.grassGlobalSparsity` 浮点 0..1 直传 native `HGGrassRender::set_grassGlobalSparsity` |
| 不写 GBuffer fragment 的远景植被（远树 quad） | `HGFoliageOccluderUtils.quadMesh` 4 vertex / 2 tri quad 在 `[-1,1]²` 平面 |

设计哲学：**所有 CPU 端工作落在 ECS chunk + 三种本地结构（BVH / Welzl / dual-height field），所有 GPU 端工作走 indirect instancing + 两张全局 RT（occluder mask + interactive height）。** 不向 HDRP 注入任何 hook。

---

## 2. 子系统拓扑总览

```
                       MonoBehaviour 入口
                          │
              ┌───────────┼───────────────────────────┬───────────────────────┐
              ▼           ▼                           ▼                       ▼
       HGGrass          HGFoliageInteract /        HGFoliageOccluder      HGFoliageType
       (草地 prefab)    HGFoliageInteractRaft     (大树/灌丛遮挡体)       (单棵草/灌丛 prop)
              │           │                           │                       │
              ▼           ▼                           ▼                       ▼
       HGGrassData     HGFoliageInteractive       HGFoliageOccluder       (autoHeight /
       (List<Grass    Manager (Mesh→Matrix4x4    Manager (per-frame      autoAngle /
        Cluster>)     列表，per-frame 上传)      LOD-Fade 状态机)         shAr/shAg/shAb /
              │           │                           │                       rootAlbedo /
              ▼           │                           │                       grassBlendColor)
        _CreateGrass      │                           │                       │
        Entities()        │                           │                       │
              │           │                           │                       │
              ▼           │                           │                       │
       ECS Chunk          │                           │                       │
       GrassClusterK*     │                           │                       │
       RenderObjectK*     │                           │                       │
              │           │                           │                       │
              ▼           ▼                           ▼                       ▼
   ┌─────────────────────────────────────────────────────────────────────────────┐
   │                   HGRenderPipeline / HGRenderGraph 主循环                    │
   ├─────────────────────────────────────────────────────────────────────────────┤
   │  ① FoliageInteractivePassConstructor (§6)                                    │
   │       PrepareFoliageInteractTexture → AddRenderPass("Foliage Interactive")   │
   │       blit + collider Mat draw all matrixes into dual-height RT              │
   │       readback as global _FoliageInteractiveTex / _PrevFoliageInteractiveTex │
   │                                                                              │
   │  ② FoliageOccluderPassConstructor (§7) — 3 sub-pass                          │
   │       (a) "Foliage Occluder Render" → render scene foliage into 512² R8      │
   │       (b) "Foliage Occluder Blit"    → blit prev final mask + new mask       │
   │       (c) "Foliage Occluder Set Final Mask" → swap A/B + write global        │
   │                                                                              │
   │  ③ DrawGrassECSRendererList(context, ecsRendererList) — main Forward/Shadow  │
   │       走 native UnityEngine.HyperGryph.HGGrassRender::DrawECSRendererList    │
   │       shader 内顶点采样 _FoliageInteractiveTex + _FoliageOcclusionMask 偏移  │
   └─────────────────────────────────────────────────────────────────────────────┘
              │
              ▼
   HGRuntimeGrassQuery (BVH，CPU-side 查询)
              ▲
              │
       Gameplay code (脚本想知道"我脚下有草吗"，O(log n))
```

—— 拓扑据：`HGGrass.cs:173-717 _CreateGrassEntities`、`HGFoliageInteractiveManager.cs:409-1251 GameplayUpdate`、`HGFoliageOccluderManager.cs:71-995 PipelineUpdate`、`HGRuntimeGrassQuery.cs:412-655 RegisterGrassCluster`、`FoliageInteractivePassConstructor.cs:621-839 ConstructPass`、`FoliageOccluderPassConstructor.cs:342-1073 ConstructPass`、`HGRendererListUtils.cs:289-334 DrawGrassECSRendererList`。

---

## 3. Grass 数据模型 — HGGrass / HGGrassData / GrassCluster / GrassRenderer / GrassPerInstanceData

### 3.1 类层级与字段（**HG 反编译直证级 ①**）

| 类 | 角色 | 关键字段（按反编译 offset 顺序） |
|---|---|---|
| `HGGrass` `MonoBehaviour` | 场景中的"草地 prefab"，挂在 GameObject 上，引用一份 `HGGrassData` | `_grassData` (`HGGrassData`), `m_previousGrassDataInstanceID:int`, `m_previousGrassDataVersion:int`, `m_entities:NativeArray<Entity>`；属性 `sceneStateMask:uint`, `areaId:int` |
| `HGGrassData` `ScriptableObject` | 烘焙资源：边界盒 + 多个 `GrassCluster` | `version:int`, `bounds:Bounds`, `clusters:List<GrassCluster>` |
| `GrassCluster` `class` | 一组草（同 LOD / 同 batchKey 区间）的空间分组 | `bounds:Bounds`（offset 0x10）, `rendererHalfSize:float`, `objectFlags:HGObjectFlags`, `renderers:List<GrassRenderer>`（offset 0x30）, `perInstanceDatas:List<GrassPerInstanceData>`（offset 0x38） |
| `GrassRenderer` `struct` | 一条 `(mesh, material, subMesh)` 渲染条目 + LOD 屏幕大小阈值 + 全局 sparsity 权重 | `batchKey:uint`（0x00）, `renderFlags:HGRenderFlags`（0x04）, `mesh:Mesh`（0x08）, `material:Material`（0x10）, `subMeshIndex:int`（0x18）, `sparsity:float`（0x1C）, `lodScreenSizeMaxSquared:float`（0x20）, `lodScreenSizeMinSquared:float`（0x24） |
| `GrassPerInstanceData` `struct` ECS chunk 内 24 字节（推断：从 `lea ebx,[rcx+rcx*2] / shl ebx,5` 可知 stride = 96/4 = 24 字节 per instance×4？实测 `HGGrass.cs:599+` 中 `mov ecx,18h imul rax,rcx` 显示**单条 24 字节**） | per-grass 实例的 transform + 灯光参数（见 §3.3） | 见 §3.3 |

→ cite：`GrassRenderer.cs:7-25` 字段；`GrassCluster.cs:9-21` 字段；`HGGrassData.cs:6-14` 字段；`HGGrass.cs:11-19` 字段。

### 3.2 ECS Entity 创建流程（`HGGrass._CreateGrassEntities`，反编译 cite `HGGrass.cs:173-717`）

`Update()` 每帧检查 `_grassData.instanceID/version`，一旦发现变化就 `_DestroyGrassEntities` 后 `_CreateGrassEntities`：

```
_CreateGrassEntities():                                     # HGGrass.cs:173
   manager = EntityManager.GetRendererEntityManager()       # HGGrass.cs:297
   entities = new NativeArray<Entity>(clusters.Count, ...)  # HGGrass.cs:307-318
   for clusterIdx in [0, clusters.Count):
       cluster = grassData.clusters[clusterIdx]
       componentTypes = NativeList<ComponentType>(11)        # HGGrass.cs:333-394
       componentTypes.Add(BoundingCenterX/Y/Z)               # 6 个 bounding 字段
       componentTypes.Add(BoundingExtentX/Y/Z)
       componentTypes.Add(RenderObjectInfoComponent)
       componentTypes.Add(RenderObjectLODInfoComponent)
       componentTypes.Add(RenderObjectK{1,2,4,8,16}Component)# §4 选哪个看 renderers.Count
       componentTypes.Add(GrassClusterK{4,8,16,32}Component) # §4 选哪个看 perInstanceDatas.Count
       entityType = EntityManager.GetOrRegisterEntityType(componentTypes)
       entity = EntityManager.CreateEntity(entityType)
       # 把 cluster.bounds 的 6 个标量写进 6 个独立 component（SoA）
       EntityManager.SetComponent<BoundingCenterX>(entity, cluster.bounds.center.x)
       ... (Y/Z 同理) ...
       EntityManager.SetComponent<BoundingExtentX>(entity, cluster.bounds.extents.x)
       ... (Y/Z 同理) ...
       # RenderObjectLODInfo：从 rendererHalfSize² 算屏幕大小阈值
       # rendererHalfSizeSq = renderers[0].rendererHalfSize²  (sub_18A6F0E0D mulss xmm0,xmm0)
       EntityManager.SetComponent<RenderObjectLODInfo>(entity, lodInfo)
       # RenderObjectInfo：layer mask + flags (1F + 8 + 0x701)
       EntityManager.SetComponent<RenderObjectInfo>(entity, renderInfo)
       # 把所有 renderer 注册成 BatchGroup
       renderObjK = GetComponentPtrLowBits<RenderObjectK*Component>(entity)
       for r in [0, renderers.Count):
           renderer = cluster.renderers[r]
           handle = HGGrassRender::RegisterGrassBatchGroup(   # HGGrass.cs:617
                       batchKey=renderer.batchKey,
                       mesh=renderer.mesh, material=renderer.material,
                       subMeshIndex=(ushort)renderer.subMeshIndex)
           sparsity_lod = renderer.sparsity if sparsity > 0 else 1.0  # HGGrass.cs:621-625
           renderObjK[r] = pack(handle, sparsity_lod, lodScreenSizeMin², lodScreenSizeMax²)
                                                              # stride 24 bytes per renderer
       # 复制 perInstanceData[] 直接 memcpy 进 GrassClusterK* chunk slot
       clusterK = GetComponentPtrLowBits<GrassClusterK*Component>(entity)
       native = perInstanceDatas.ToNativeArray(Allocator.Temp)
       Buffer.MemoryCopy(src=native.unsafePtr,
                         dst=clusterK + 4,
                         destSizeInBytes=clusterK.Count * 96,    # ebx = (count*3)<<5 = 96·count?
                         srcSizeInBytes=clusterK.Count * 96)
       # 实际 stride 见 §3.3
       entities[clusterIdx] = entity
```

—— cite：`HGGrass.cs:174-717` 完整反汇编，重点 `:333-394` 添加 11 个 ComponentType、`:402-456` 根据 `renderers.Count` 选 RenderObjectK{1/2/4/8/16}、`:438-456` 根据 `perInstanceDatas.Count` 选 GrassClusterK{4/8/16/32}、`:613-625` `RegisterGrassBatchGroup` + sparsity 默认 1.0、`:666-688` Buffer.MemoryCopy per-instance 数据进 chunk。

### 3.3 `GrassPerInstanceData` 字段推断

反编译里看不到该 struct 的 C# 反射定义（native ECS chunk-side 类型），但能从 `Buffer.MemoryCopy` 的 stride 推断：
- `HGGrass.cs:666-668`：`mov dword ptr [rbp+0A8h],2`、`lea ebx,[rcx+rcx*2]`、`shl ebx,5` → `ebx = (perInstanceDatas.Count·3) << 5 = perInstanceDatas.Count · 96`。
- 即**单条 = 96 字节**（与 `Matrix4x4` 64B + 32B 额外参数一致），含 transform 矩阵 + (`sparsity_lod`, `screenSizeMin²`, `screenSizeMax²`, bounding 中心/extent 等 8 个 float32)。
- 推断分级 ②（反汇编 stride 直证 + ECS 通用范式重建）。

完整字段顺序需 attach Unity Editor debugger 看 `EntityManager.GetComponentData<GrassClusterK4>` 的 chunk 二进制确认 → 标 §15 待确认。

---

## 4. GPU 实例化渲染 — RenderObjectK1/2/4/8/16 + GrassClusterK4/8/16/32 的 ECS chunk fan-out

### 4.1 容量阶梯（**直证级 ①**，cite `HGGrass.cs:402-456`）

HG 把"每 entity 多少个 renderer / 多少个 instance"做成**8 种容量梯度**，按 chunk 一类一槽以避免内存浪费：

| 维度 | 阈值（来自 `cmp eax, …`） | 选择的 component |
|---|---|---|
| `renderers.Count ≤ 1` | `cmp eax,1` `jg → 否则 K1` | `RenderObjectK1Component` |
| `1 < count ≤ 2` | `cmp eax, 2` | `RenderObjectK2Component` |
| `2 < count ≤ 4` | else 分支默认 | `RenderObjectK4Component` |
| `4 < count ≤ 8` | `cmp eax, 4` 再 `cmp eax, 8` | `RenderObjectK8Component` |
| `count > 8` | else（实际上限 16） | `RenderObjectK16Component` |
| `perInstanceDatas.Count ≤ 4` | `cmp dword ptr [rax+18h],4` `jg → 否则 K4` | `GrassClusterK4Component` |
| `4 < count ≤ 8` | else（默认 K8） | `GrassClusterK8Component` |
| `8 < count ≤ 16` | `cmp dword ptr [rax+18h],8` then `cmp …,10h` | `GrassClusterK16Component` |
| `count > 16` | else（上限 32 per chunk slot） | `GrassClusterK32Component` |

cite：`HGGrass.cs:402-435` (RenderObjectK 选择)、`HGGrass.cs:438-456` (GrassClusterK 选择).

**为什么这样切？** ECS chunk 一行的大小固定（16KB Unity 默认），把"每 entity 多少 instance"包成固定上限可以让 burst job 直接 `unsafe`-index 而不查表，单次 SetComponent 不分支。HG 选 1/2/4/8/16 与 4/8/16/32 两套梯度匹配开放世界**典型 cluster size（4-32 instance / cluster）和典型 LOD chain（1-16 renderer slot）**。

### 4.2 Per-instance 渲染流程（推断 ②，HDRP `BatchRendererGroup` 通用范式 + HG `HGGrassRender` native）

1. `HGGrass._CreateGrassEntities` 把每个 cluster 注册成 `BatchGroup`（`HGGrass.cs:617 HGGrassRender::RegisterGrassBatchGroup`）—— 返回 `handle:ulong`。
2. 主帧渲染时 `HGRendererListUtils.DrawGrassECSRendererList(context, ecsRendererList, isPassEnabled)` 调到 native `HGGrassRender::DrawECSRendererList(context, ecsRendererList)`（`HGRendererListUtils.cs:289-334`）。
3. native 端遍历所有 `GrassClusterK*Component` chunk，按以下规则做 GPU instancing：
   - 视锥剔除：`Bounding(Center, Extent) ↔ 6 plane`。
   - 屏幕大小剔除：当前 cluster 屏幕 squared size 必须落在 `[lodScreenSizeMin², lodScreenSizeMax²]`（`HGGrass.cs:541-549` 把 `mulss xmm0,xmm0` 写进 RenderObjectLODInfo.lod**Sq** 字段）。
   - 全局 sparsity：`HGGrassSettings.grassGlobalSparsity`（`HGGrassSettings.cs:9-37`）通过 `set_grassGlobalSparsity` 注入 native，作为**全局概率丢弃**（哈希 instance ID → if rand > sparsity then skip）。
4. 通过的 instance 直接打包成 `Graphics.RenderMeshIndirect`（或等价 native indirect draw）：
   ```
   for renderer in cluster.renderers:
       drawCommand = (mesh=renderer.mesh, material=renderer.material,
                      subMeshIndex=renderer.subMeshIndex,
                      instanceCount=culledInstanceCount,
                      perInstanceBuffer=clusterChunk + perInstanceOffset)
       indirectDispatch(drawCommand)
   ```

### 4.3 `HGRenderFlags` 与 `HGObjectFlags`

`GrassRenderer.renderFlags:HGRenderFlags`、`GrassCluster.objectFlags:HGObjectFlags` —— flag enum 反编译未见名字，但从 `HGGrass.cs:563-571` 写 `RenderObjectInfoComponent`：

```
mov dword ptr [rbp-10h], 8           ; rangeBit = 8
mov dword ptr [rbp-0Ch], sub_43800000 ; renderRange = 256.0 (float bits 0x43800000)
mov edx, 1
shl edx, cl                           ; layerBit = 1 << (LayerMask & 0x1F)
or  ebx, 0x701                        ; flags |= 0x701
```

→ 推断 `flags=0x701` 含 `CastShadow|Transparent|InteractiveResponsive`（HG 常用 bit），`renderRange=256.0f`（草地视距上限 256m），`rangeBit=8`。**注：0x701 解读为 ② 推断**。

---

## 5. HGRuntimeGrassQuery — 贪心 SAH BVH，O(log n) 草簇空间查询

### 5.1 用途

让游戏脚本能高效问"我这点世界坐标下有草地吗（如果有把对应草簇 bounds 返回）" —— 用于足迹声效、踩草特效、地编辑器叠加草地纹理等。**与渲染剔除不重叠** —— 渲染剔除走 ECS bounds 直接 6 平面，BVH 是 CPU-side 查询。

### 5.2 数据结构（**直证级 ①**，cite `HGRuntimeGrassQuery.cs:7-1194`）

```csharp
public class HGRuntimeGrassQuery {
    public class Node {
        public Bounds bounds;             // offset 0x10
        public Node parent;               // offset 0x28
        public Node left;                 // offset 0x30
        public Node right;                // offset 0x38
        public Bounds[] grassInstanceBounds; // offset 0x40 (only on leaf)
    }
    private Node m_root;                                 // offset 0x10
    private Dictionary<Entity, Node> m_grassClusterToNode; // offset 0x18
}
```

cite：`HGRuntimeGrassQuery.cs:11-19` 字段、`HGRuntimeGrassQuery.cs:84-122 IsLeaf` 实现（`cmp [rbx+30h],0; je ...; cmp [rbx+38h],0; sete al`）。

### 5.3 关键算法（**直证级 ①**）

#### 5.3.1 `Node.ComputeMergeCost(b) = Vol(self ∪ b) − Vol(self)`

cite `HGRuntimeGrassQuery.cs:124-194`：

```
ComputeMergeCost(Bounds b):
   union = self.bounds.Encapsulate(b)   # call UnityEngine.Bounds::Encapsulate
   v_union = _GetBoundsVolume(union)    # = size.x * size.y * size.z（_GetBoundsVolume :295-339）
   v_self  = _GetBoundsVolume(self.bounds)
   return v_union - v_self
```

cite `HGRuntimeGrassQuery.cs:295-339 _GetBoundsVolume`：
```
movsd qword ptr [rsp+30h],xmm0   ; size.xy
movss xmm0,dword ptr [rsp+24h]   ; size.y
mulss xmm0,dword ptr [rsp+30h]   ; *= size.x
mulss xmm0,dword ptr [rbx+14h]   ; *= size.z   → return size.x*size.y*size.z
```

→ **这是教科书 SAH（Surface Area Heuristic）变种**：标准 SAH 用表面积，HG 用体积（Volume Heuristic），开放世界水平地形上等价（草分布近水平面，y 维度小、x/z 维度主导）。

#### 5.3.2 `_AddNode(newLeaf)` — 贪心下行插入（cite `:898-1036`）

```
_AddNode(newLeaf):
   if m_root == null:
       m_root = newLeaf
       return
   cur = m_root
   while not cur.IsLeaf():
       cost_left  = cur.left .ComputeMergeCost(newLeaf.bounds)
       cost_right = cur.right.ComputeMergeCost(newLeaf.bounds)
       cur = (cost_left <= cost_right) ? cur.left : cur.right    # :950-963
   # cur 现在是 leaf
   parent_old = cur.parent
   newInternal = new Node(parent=parent_old, left=cur, right=newLeaf)  # :965-976
   if parent_old == null:                  # cur 是 root
       m_root = newInternal
   else:
       parent_old.ReplaceChild(cur, newInternal)   # :993-998
   cur.parent = newInternal
   newLeaf.parent = newInternal
   _BroadcastBounds(newInternal)           # :1003 向上更新所有祖先 bounds
```

`_BroadcastBounds` (`:1125-1191`)：从 node 沿 parent 链一路上行，每个 node `bounds = Encapsulate(left.bounds) + Encapsulate(right.bounds)`。

#### 5.3.3 `_RemoveNode(leaf)` — 兄弟提升（cite `:1038-1122`）

```
_RemoveNode(leaf):
   if leaf is root: m_root = null
   else:
       sibling = leaf.FindSibling()          # :251-293
       grandparent = leaf.parent.parent
       sibling.parent = grandparent
       if grandparent == null:
           m_root = sibling
       else:
           grandparent.ReplaceChild(leaf.parent, sibling)
       _BroadcastBounds(sibling)
```

#### 5.3.4 `InGrassBoundingBox(worldPos, out overlapBounds)` — DFS 查询（cite `:718-895`）

```
InGrassBoundingBox(worldPos, out overlapBounds):
   overlapBounds = default
   return _InGrassBoundingBox(m_root, ref worldPos, ref overlapBounds)

_InGrassBoundingBox(node, ref pos, ref out):
   if node == null: return false
   if !node.bounds.Contains(pos): return false   # 早退
   if !node.IsLeaf():
       return _InGrassBoundingBox(node.left,  ...) ||
              _InGrassBoundingBox(node.right, ...)
   # leaf：遍历 grassInstanceBounds 数组（per-instance AABB）
   for i in [0, node.grassInstanceBounds.Length):
       if node.grassInstanceBounds[i].Contains(pos):
           overlapBounds = node.grassInstanceBounds[i]
           return true
   return false
```

cite `:828-867` `for ebx in ...; lea rdx,[rbp-18h]; mov rcx,r14; call sub_1803F3948; ... call Bounds::Contains`。

→ 期望复杂度：构造 O(n log n)（贪心下行），查询 O(log n) 平均 + leaf instance 数（典型 4-32）。

### 5.4 `RegisterGrassCluster(entity, meshBounds)` — 接入 ECS（**直证级 ①**，cite `:412-655`）

```
RegisterGrassCluster(entity, meshBounds):
   worldAABB = EntityManager.TryGetWorldAABBFromRendererEntity(entity)  # :447-462
   node = new Node(); node.bounds = worldAABB
   m_grassClusterToNode.Add(entity, node)
   _AddNode(node)
   # leaf 的 per-instance bounds 数组：拆 entity 的 RenderObjectK* chunk
   renderObjK = GetComponentPtrLowBits<RenderObjectK*>(entity)         # :487-500
   instanceCount = renderObjK[0]                                       # :501
   node.grassInstanceBounds = new Bounds[instanceCount]                # :503-509
   for i in [0, instanceCount):
       # 从 transform matrix 第 0/1/2/3 列还原 column 然后取 length 算 size
       column0 = Matrix4x4.GetColumn(matrix, 3)  # translation
       column1 = Vector4.op_Implicit(...).magnitude       # x-scale
       column2 = Matrix4x4.GetColumn(matrix, 0).magnitude # y-scale
       column3 = Matrix4x4.GetColumn(matrix, 1).magnitude # z-scale
       size = Vector3.Scale(meshBounds.size, scale)
       center = pos + Vector3.Scale(meshBounds.center, scale)
       node.grassInstanceBounds[i] = new Bounds(center, size)
   # 注意：是 per-instance AABB，不是 per-cluster
```

→ leaf bounds 数组实现了 BVH 的"叶子级 mini-grid"，避免 BVH 节点数和 instance 数相等导致的内存膨胀（每 cluster 1 节点 + cluster 内 4-32 instance 在叶子里线性扫）。

---

## 6. Foliage Interactive — 角色脚下双高度图 dual-height bend pass

> **目的**：让所有草、叶子、花、灌丛 shader 顶点能采样到"这块地表上方有没有角色、压了多深"的 R8G8 dual-height field，从而沿 Y 反向位移做弯折。
> 算法概念见 [§14 草地踩踏](../02-CoreAlgorithms/01-CoreAlgorithms.md)；本节专讲 **HG 的 pass 实现**。

### 6.1 Config 常量（**直证级 ①**，cite `HGFoliageInteractiveConfig.cs:6-23`）

```csharp
public struct HGFoliageInteractiveConfig {
    public Vector2Int textureSize;       // 由 HGFoliageInteractiveManager.GetConfig() 注入
    public float centerOffsetHeight;
    public float characterOffsetHeight;
    public GraphicsFormat graphicsFormat;
    public const float FOLIAGE_INTERACTIVE_RAISE_SPEED   = 0.5f;   // 草恢复速度 0.5/sec
    public const float FOLIAGE_INTERACTIVE_MIN_DELTA_TIME = 0.033f; // 最小 dt 30 fps 钳位
    public static readonly Vector3 FOLIAGE_INTERACTIVE_CENTER_SIZE; // §15 待确认数值
}
```

→ `RAISE_SPEED=0.5/sec` 表示 1 秒草恢复 0.5 单位（典型 6.5cm 草恢复一半），`MIN_DELTA_TIME=0.033` 保证 30fps 以上都能稳定（低 FPS 时用 0.033 作为 dt 上限，避免大跳）。

### 6.2 Manager 数据结构（**直证级 ①**，cite `HGFoliageInteractiveManager.cs:7-30`）

```csharp
public class HGFoliageInteractiveManager {
    private HGFoliageInteractiveConfig m_config;
    private Vector3 m_centerPos;
    private List<Vector3> m_characterPoses;                 // 多角色位置
    private List<HGFoliageInteract> m_externInteracts;      // 非角色交互体（载具…）
    private List<HGFoliageInteractRaft> m_interactRaftList; // 木筏类 capsule 形交互体
    private Dictionary<int, HGFoliageInteractiveMeshMatrixes> m_interactMeshMatrixDict;
                                                              // 按 mesh instance ID 聚合矩阵
    private Mesh m_characterColliderMesh;
    private int m_characterColliderMeshID;
    private const float CLEAN_TIME = 60f;                   // 60 秒清理一次空槽
    private float m_lastCleanTime;
    private bool m_enabled;
}
```

cite：`HGFoliageInteractiveManager.cs:9-29`、`HGFoliageInteractiveMeshMatrixes.cs:6-12` （`struct { Mesh mesh; NativeList<Matrix4x4> matrixs; }`）。

### 6.3 `HGFoliageInteractRaft` — capsule 代理碰撞（**直证级 ①**，cite `HGFoliageInteractRaft.cs:62-340`）

每个交互体可由父对象 `Transform` 提供 capsule 代理参数：
- `GetCapsuleProxyHalfLength() = transform.localScale.y`（`HGFoliageInteractRaft.cs:343-383`）
- `GetCapsuleProxyRadius() = max(localScale.x, localScale.z)`（`HGFoliageInteractRaft.cs:288-341`）
- `GetCapsuleProxyPositionA() = parentPos + forward · (halfLength − radius·0.5)`（`HGFoliageInteractRaft.cs:62-173`）
- `GetCapsuleProxyPositionB() = parentPos − forward · (halfLength − radius·0.5)`（`HGFoliageInteractRaft.cs:175-286`）

→ 即一段从 parent 的 forward 方向延伸的 capsule（typical 载具/木筏接地包围体）。

### 6.4 `GameplayUpdate()` 每帧聚合（**直证级 ①**，cite `HGFoliageInteractiveManager.cs:409-1251`）

伪码（按反编译 control flow 重建）：

```
GameplayUpdate():
   GetCenter(out centerPos, out centerSize)            # :555 计算 dual-height 覆盖中心
   ClearDict(m_interactMeshMatrixDict)                 # :659-722 全清旧帧矩阵
   foreach interact in m_externInteracts:              # :778-1021 主循环
       if interact == null || interact.mesh == null: continue
       meshID = interact.mesh.GetInstanceID()
       if not m_interactMeshMatrixDict.ContainsKey(meshID):
           # 第一次见此 mesh，建一个 NativeList<Matrix4x4>(capacity=4 → 'mov ecx,4' :881)
           newSlot = new HGFoliageInteractiveMeshMatrixes {
                       mesh = interact.mesh,
                       matrixs = new NativeList<Matrix4x4>(4, Allocator.Persistent)
                     }
           m_interactMeshMatrixDict.Add(meshID, newSlot)
       slot = m_interactMeshMatrixDict[meshID]
       worldMat = interact.transform.localToWorldMatrix   # :962-981
       slot.matrixs.Add(worldMat)                          # :1017-1019
```

— 即"按 mesh instance ID 桶状聚合 transform 矩阵"，让 pass 阶段能 instanced draw 同一 mesh 的所有交互体。

### 6.5 `FoliageInteractivePassConstructor.ConstructPass` 渲染（**直证级 ①**，cite `FoliageInteractivePassConstructor.cs:621-839`）

```
ConstructPass(input, output, renderGraph, hgCamera):
   if HGSettingParameters.FoliageInteractiveEnabled is false: return  # :666-670
   if camera.disableFoliageInteractive: return                         # :672-674

   # ① 时间累计：保证每帧 dt 至少 0.033（30FPS lock）
   if lastTime == 0: lastTime = HGRPTimeManager.gameplayTime           # :675-683
   accumulatedDt = (HGRPTimeManager.gameplayTime - lastTime) / 0.033   # :688-690
   stepCount = floor(accumulatedDt)
   accumulatedDt -= stepCount
   lastTime += stepCount * 0.033                                       # :694-697

   # ② 建/取双高度 RT
   PrepareFoliageInteractTexture(renderGraph):                         # :701
       config = HGFoliageInteractiveManager.GetConfig()                # :361-369
       textureSize = config.textureSize  (xmm6 / esi)                  # :365-368
       if curDualHeightTexture not valid:
           m_curDualHeightTexture = renderGraph.ImportTexture(
               m_defaultDualHeightTexture)                              # :376-383
       desc = new TextureDesc(textureSize.x, textureSize.y,
                              colorFormat=config.graphicsFormat,
                              clearBuffer=true,
                              clearColor=Color.yellow,                  # :398
                              name="curDualHeightTexture")              # :391
       m_curDualHeightTexture = renderGraph.CreateTexture(desc)         # :420-424

   # ③ 加 RenderPass
   profilingSampler = ProfilingSampler.Get<HGProfileId>(118)            # 118 = RenderFoliageInteractive
   builder = renderGraph.AddRenderPass<FoliageInteractivePassData>(
                 renderGraph, "Foliage Interactive", out passData,
                 profilingSampler, allowDynamicPassCulling=true)
   passData.deltaTime = stepCount * 0.033                               # :730
   builder.AllowPassCulling(false)
   builder.ReadTexture(passData.prevDualHeightTexture)                  # :735-742
   builder.SetColorAttachment(passData.curDualHeightTexture,
                              clearFlag=ClearFlag.Color,
                              clearColor=Color.yellow, slot=2)          # :746-758
   builder.SetRenderFunc(s_foliageInteractiveFunc)

   PostPrepareFoliageInteractTexture(renderGraph):                      # :782
       m_prevDualHeightTexture = renderGraph.PreserveTexture(
           m_curDualHeightTexture, "FoliageInteractivePass", clear=1)
```

### 6.6 Per-pass shader 输入（**直证级 ①**，cite `FoliageInteractivePassConstructor.cs:44-56` + `HGShaderIDs.cs:1449-1451`）

```
内部 cbuffer 字段 (FoliageInteractivePassConstructor.PassData):
  _LastCenterPos     : Vector3   (prev frame 中心)
  _LastCenterSize    : Vector3
  _CurCenterPos      : Vector3   (this frame 中心)
  _CurCenterSize     : Vector3
  _DeltaTime         : float     (= stepCount * 0.033)
  _RaiseSpeed        : float     (= FOLIAGE_INTERACTIVE_RAISE_SPEED = 0.5)
  _PerInstanceData   : per-draw  (Material PropertyBlock)

全局贴图 (HGShaderIDs):
  _FoliageInteractiveTex      ← 当前帧 dual-height RT (R8G8)
  _PrevFoliageInteractiveTex  ← 上一帧（用于做 raise/relax 时序）
```

### 6.7 Pass 内 GPU 算法（推断 ②，基于 RT 名/材质/clearColor=Yellow）

RT clear 为 `Color.yellow = (1, 1, 0, 1)` → 通道含义：
- `R` = "current bend amount"（0 = 未压，1 = 完全压平），初始 1 表示"未压扁"。
- `G` = "previous bend amount"，用于 raise/relax 时序运算。
- 因为 clear 是 yellow（R=1, G=1），意味着 **shader 把"未弯折"编码为 1**，弯折通过把通道值往 0 拉。

**Blit pass（material `foliageInteriaveBlitMaterial`）**：

```
out.R = max(prevR + _DeltaTime * _RaiseSpeed, 1.0)  # 草随时间恢复（往 1 抬）
out.G = prevR                                        # 移位记录上帧
```

**Collider pass（material `foliageInteriaveColliderMaterial`，对每个 mesh+matrix 实例 draw call）**：

```
# 顶点：把 collider mesh 用 _PerInstanceData 矩阵转世界
worldPos = mul(_PerInstanceData[instanceID].matrix, vertex.xyz)
# 投影到 dual-height field 平面（_CurCenterPos 为中心，_CurCenterSize 为范围）
uv = (worldPos.xz - _CurCenterPos.xz + _CurCenterSize.xz*0.5) / _CurCenterSize.xz
# 输出片元：把该位置压扁
out.R = min(prevR, sceneCharacterHeightNormalized)
out.G = unchanged
# 用 alpha blend min 等价于"取最低"
```

**Shader 顶点位移（在草/叶 shader 里采样）**（推断 ②）：

```glsl
float2 uv = (worldPos.xz - _CurCenterPos.xz + _CurCenterSize.xz*0.5) / _CurCenterSize.xz;
float2 dual = tex2Dlod(_FoliageInteractiveTex, float4(uv,0,0)).rg;
float bend = 1.0 - dual.r;                  // 0..1，0=无压，1=完全压平
// 沿草根 → 顶点向量插值，越接近顶端弯越多
worldPos.y -= bend * vertex.color.a * grassHeight;
worldPos.xz += bend * windDir * vertex.color.a * grassHeight;
```

→ 推断分级：基于"`_LastCenterPos/Size`/`_CurCenterPos/Size`/`_DeltaTime`/`_RaiseSpeed` 4 个 ID + R8G8 RT + clear=yellow"反向构造，shader 行为待 `.shader` 源确认（标 §15）。

---

## 7. Foliage Occluder — 64m × 64m / 512² LOD-Fade ping-pong mask 流水线

> **目的**：相机周围 64m 半径范围内，每个被相机看到的"高大植被实例"（树、灌丛）都写入一张 512² R8 mask；草地 shader 据此 mask 在被遮蔽区域**降低风摆 / 关闭花穗 / 切到低 LOD**，避免树下大面积乱晃。

### 7.1 关键常量（**直证级 ①**，cite `HGFoliageOccluderManager.cs:8-14`）

```csharp
public const float OCCLUDER_FADE_TRANSITION_TIME = 0.5f;  // LOD 转场半秒
public const float OCCLUDER_COVERAGE_SIZE        = 64f;   // 覆盖正方形边长 64m
public const float OCCLUDER_COVERAGE_HALF_SIZE   = 32f;   // 半边长 32m
public const int   OCCLUDER_MASK_RESOLUTION      = 512;   // 512×512 px
```

→ 每像素覆盖 `64m / 512 = 0.125m = 12.5cm` 地面，足以精确描出灌丛轮廓。

### 7.2 数据结构 — Manager / RenderParams（**直证级 ①**，cite `HGFoliageOccluderManager.cs:16-37`、`HGFoliageOccluderRenderParams.cs:5-17`）

```csharp
public class HGFoliageOccluderManager {
    private float m_lodFadeValue;
    private bool m_currentFrameTriggerTransition;
    private Vector2 m_lastUpdateCameraPos;       // offset 0x18
    private Vector2 m_currentCameraPos;          // offset 0x20
    private Vector4 m_cameraParam;               // offset 0x28
    private double m_prevTimeStamp;              // offset 0x38
    private double m_currentTimeStamp;           // offset 0x40
    private bool m_curMaskIsA;                   // offset 0x48
    private bool m_shouldRender;                 // offset 0x49
    private HGFoliageOccluderRenderParams m_params; // offset 0x50
}
public class HGFoliageOccluderRenderParams {
    public bool shouldRender;                    // offset 0x10
    public bool curMaskIsA;                      // offset 0x11
    public float lodFadeValue;                   // offset 0x10? (revisit)
    public Matrix4x4 cullingMatrix;              // offset 0x18..0x58
}
```

### 7.3 三个 RT（**直证级 ①**，cite `FoliageOccluderPassConstructor.cs:141-272 InitializeRenderTexture`）

```
m_foliageOccluderRenderTexture: 512×512, R8 (colorFormat=5), depthBufferBits=0,
                                 dimension=2D, useMipMap=false, name="occluderRenderTexture"
m_foliageOccluderMaskA        : 512×512, R8 (colorFormat=6), name="FoliageOccluderFinalMaskA"
m_foliageOccluderMaskB        : 512×512, R8 (colorFormat=6), name="FoliageOccluderFinalMaskB"
```

→ A/B 双缓冲做 ping-pong（避免读写同一 RT 的依赖），`render` 是临时单帧 RT。
→ `colorFormat=5` 是 `R8_UNorm`，`colorFormat=6` 是 `R8G8_UNorm`（**推断 ②**，按 `GraphicsFormat` 枚举顺序最常见映射；待 §15 确认）。

### 7.4 `PipelineUpdate()` 每帧状态机（**直证级 ①**，cite `HGFoliageOccluderManager.cs:71-995`）

```
PipelineUpdate():
   m_shouldRender = false                            # :169
   now = Time.timeAsDouble                           # :173-176
   dt  = now - m_prevTimeStamp                       # :176

   # ① 当前帧是否触发 LOD 转场（来自 LOD 状态系统）
   transitionTrig = HGLODStateSystem.IsCurrFrameTriggerTransition() && dt > 0.5
                                                    # :181-188 比对 OCCLUDER_FADE_TRANSITION_TIME (0.5)
   m_currentFrameTriggerTransition = transitionTrig
   if dt <= 0 && not transitionTrig: return         # :186-189 没事干

   m_currentFrameTriggerTransition = true            # 强制
   m_prevTimeStamp <-> m_currentTimeStamp 滑窗      # :194-198

   # ② 更新相机位置
   foreach (camera, hgCam) in HGCamera.s_cameras:    # :211-456 遍历所有相机
       if cameraType is SceneView/Game and IsActiveAndValid:
           transformPos = camera.transform.position  # :1186-1191 g_18FC42908 = get_position
           m_currentCameraPos = (pos.x, pos.z)
           triggerNewRender = true
           break

   # ③ 算 culling matrix（正交相机投影到 _GetCullingMatrix）
   if triggerNewRender:
       # 把 cameraPos 圆整到 1m 网格（避免抖动）—— mulss xmm0, g_18C4713EC; floor; mulss xmm0, g_18C471640
       m_currentCameraPos.x = floor(m_currentCameraPos.x / 1.0) * 1.0   # :785-791
       m_currentCameraPos.y = floor(m_currentCameraPos.y / 1.0) * 1.0   # :794-803
       m_lastUpdateCameraPos = m_currentCameraPos
       m_curMaskIsA = !m_curMaskIsA                                       # :803-806 翻转 ping-pong
       m_shouldRender = true                                              # :806

       m_params.cullingMatrix = _GetCullingMatrix(m_currentCameraPos)    # :817
       # _GetCullingMatrix 实现 cite :1041-1196：
       # ortho_proj = Matrix4x4.Ortho(  L=-32, R=+32, B=-32, T=+32, near=?, far=? )
       #   (常量 g_18C471500/04/08/0C 是 Ortho 边界)
       # view = LookAt(eye=camPos + (0, +HEIGHT, 0), target=camPos, up=(1,0,0))
       #   (g_18C4713B8 = HEIGHT，估 32m+ 俯瞰；FLIP_Y 模式)
       # cullingMatrix = ortho * view
   else:
       m_lodFadeValue = 0                            # :830-832

   # ④ 写 params 给 pass
   m_params.shouldRender = m_shouldRender             # :838
   m_params.curMaskIsA   = m_curMaskIsA              # :842

   # ⑤ LOD fade 计算
   if dt > 0.5:                                       # transitionTime
       m_lodFadeValue = 0
   else:
       phase = (Time.timeAsDouble - g_18C471330  - m_prevTimeStamp) /
               (m_currentTimeStamp - m_prevTimeStamp)         # :864-865
       phase = saturate(phase, 0, 1)                          # :866-871
       m_params.lodFadeValue = phase                          # :874
```

### 7.5 三个 sub-pass（**直证级 ①**，cite `FoliageOccluderPassConstructor.cs:342-1073 ConstructPass`）

#### (a) "Foliage Occluder Render" — culling + draw 高大植被到 render RT

```
profilingSampler = ProfilingSampler.Get<HGProfileId>(116)  # 116 = RenderFoliageOccluder
# 取 6 个 frustum planes
GeometryUtility.CalculateFrustumPlanes(params.cullingMatrix, planes)  # :487-509
nativeArr = new NativeArray<Plane>(planes, Allocator.Temp)             # :510-516
# 转 HG 内部 plane 格式（6 个 Plane.GetNormal/distance 写进 nativeArr）  # :519-535
cullingMask = HGUtils.GetSceneCullingMaskFromCamera(camera)            # :541-548
viewID = HGCullingSystem.AddCullViewByPlanes(planes, mask=cullingMask,
                                              targetRT_ID, layer_mask=20h,
                                              flags=0x80000)             # :558-576
HGCullingSystem.DispatchBatchCullingJobs()                              # :578

materialHandle = HGShadingStateSystem.GetMaterialHandle(occluderMat)     # :587-598
geometryHandle = HGGeometrySystem.GetGeometryHandle(occluderMesh)       # :603-621
                                                                         # occluderMesh = quadMesh (HGFoliageOccluderUtils, 4-vertex quad)
ecsRendererList = HGFoliageOccluderRender.CreateRendererList(
                     viewID, materialHandle, geometryHandle,
                     flags=0x40, ctx, 0)                                 # :626-642

builder = renderGraph.AddRenderPass("Foliage Occluder Render")
builder.SetColorAttachment(occluderRenderTexture, slot=0,
                            loadAction=DontCare, storeAction=Store,
                            clearColor=g_18C471510)                       # :676-687
builder.SetRenderFunc(s_foliageOccluderRenderPass)
# 内部：draw all foliage occluder instances with quad mesh, splat to 512² R8
```

#### (b) "Foliage Occluder Blit" — A↔B ping-pong + 把 render 输出叠加进 final mask

```
profilingSampler = ProfilingSampler.Get<HGProfileId>(117)  # 117 = BlitFoliageOccluderMask
prevMask = m_curMaskIsA ? maskB : maskA   # 上一帧的 final mask
curMask  = m_curMaskIsA ? maskA : maskB   # 这一帧 final mask
builder = renderGraph.AddRenderPass("Foliage Occluder Blit")
builder.ReadTexture(occluderRenderTexture)
builder.ReadTexture(prevMask)
builder.SetColorAttachment(curMask, slot=0, load=DontCare, store=Store)
builder.SetRenderFunc(s_foliageOccluderBlitPass)
# Shader 行为推断 ②：
#   out.R = max(occluderRender.R * fadeIn,
#               prevMask.R * (1 - fadeOut))
#   即把 prev 衰减叠加 cur 渐入
```

#### (c) "Foliage Occluder Set Final Mask" — 写全局 shader 参数（让 grass shader 采样）

```
builder = renderGraph.AddRenderPass("Foliage Occluder Set Final Mask")
builder.ReadTexture(curMask)
builder.SetRenderFunc(s_setFinalMaskPass)
# RenderFunc 内部：
#   ctx.cmd.SetGlobalTexture(_FoliageOcclusionMask, curMask)
#   ctx.cmd.SetGlobalFloat(_FoliageLODFadeValue, m_params.lodFadeValue)
#   ctx.cmd.SetGlobalVector(_FoliageOccluderCameraPosParam,
#       (cameraX, cameraZ, 1/64, OCCLUDER_COVERAGE_HALF_SIZE))
#   等价于 occluderScaleParam (HGFoliageOccluderManager.cs:36, occluderScaleParam => default(Vector4))
```

### 7.6 全局 cbuffer 写入（**直证级 ①**，cite `HGFoliageOccluderManager.cs:997-1039 SetShaderVariablesGlobalFoliageOccluder`）

```
SetShaderVariablesGlobalFoliageOccluder(ref ShaderVariablesGlobal cb):
   cb[offset 0x0C30] = occluderScaleParam            # Vector4：scale + offset
   cb[offset 0x0C40] = m_cameraParam                 # Vector4: (camX, camZ, ?, ?)
```

→ 即 HG 在 `ShaderVariablesGlobal` cbuffer 中预留了 16 bytes×2 = 2 Vector4 给 Foliage Occluder。

### 7.7 Quad Mesh — `HGFoliageOccluderUtils.quadMesh`（**直证级 ①**，cite `HGFoliageOccluderUtils.cs:11-134`）

`_CreateQuadMesh()` 创建一个 4 顶点 / 6 索引 quad：

```
vertices[4] = {
   (-1, -1, 0),    // g_18C471634 = -1.0,  g_18C471320 = 0.5? (need verify)
   (+1, -1, 0),    // 实际：左下/右下/左上/右上 NDC 矩形
   (-1, +1, 0),
   (+1, +1, 0),
}
triangles[6] = (0,1,2, 2,1,3) // 据 InitializeArray 24 字节 + 6 个 int
```

→ 用途：每个 `HGFoliageOccluder` MonoBehaviour 在 occluder render pass 里都 draw 一个 quad（typical 2×2m 包围），instanced 后 fragment shader 用 culling matrix 投影到 occluder RT 写 R8 mask。这是 sprite-occluder 范式的标准实现。

---

## 8. HGFoliageType — 单棵植被实例 prop（autoHeight / autoAngle / GI 探针 / blend color）

`HGFoliageType` 是 `MonoBehaviour`，挂在每棵草/树/灌丛 prefab 上，提供 shader/烘焙时需要的 per-instance 属性（**直证级 ①**，cite `HGFoliageType.cs:8-188`）：

| 字段 | 类型 | 含义 |
|---|---|---|
| `_paintOnCollider` | `Collider` | 烘焙时草要"贴在"哪个 collider 上（用于地表面对齐） |
| `_paintOnGUID` | `string` | collider 的稳定 GUID（防 reference 丢失） |
| `autoHeight` | `bool` | 自动从地面 raycast 抓 Y 坐标 |
| `autoAngle` | `bool` | 自动从地面法线对齐 transform.up |
| `angleVerticalWeight` | `float 0..1` | 自动对齐时 (法线↔Y 轴) 插值权重 |
| `forceLightProbeGI` | `bool` | 强制走 LightProbe（即使在 LPV/IrradianceVolume 区域） |
| `lightProbeAnchorOffset` | `float` | LightProbe 采样锚点 Y 偏移 |
| `overlapCheckMinDistance` | `float` | 烘焙时与其他 foliage 的最小距离（防重叠） |
| `shAr`, `shAg`, `shAb` | `Vector4` | 烘焙好的 SH L1 系数（R/G/B）—— per-instance vertex SH GI |
| `rootAlbedo` | `Color` | 根部颜色（与叶子顶端做高度渐变） |
| `grassBlendColor` | `Color` | 与地表 `HGFoliageColorBlendBox` 区域色融合的目标色 |
| `blendColorTerrain` | `Color` | 与 Terrain layer 色融合的色 |
| `_giPosition` | `Vector3` | GI 采样位置（默认= 物体位置） |
| `paintOnCollider.set` | property | 写入时调 `UnityEngine.Physics.CreateECSProxy(collider)` 创建 ECS collider 代理 |

→ `shAr/g/b` 是 **per-instance 烘焙 SH L1**（球谐 0/1 阶共 9 系数），shader 可在顶点阶段查表替代 LightProbe 实时采样。这是开放世界稳静态植被 GI 的标准做法。

`HGFoliageColorBlendBox` 是 `[RequireComponent(BoxCollider)]` 的标记器（`HGFoliageColorBlendBox.cs:6-10` 全文 0 字段），表示一个**世界空间立方体**：落在 box 内的 foliage 在烘焙时 `grassBlendColor` 会被该 box 的染色逻辑覆盖（具体 box 上的 picker 字段在 Editor-only 代码里，runtime 只剩标记 trigger volume）。

`HGFoliageBlendNoiseInfo`（**直证级 ①**，cite `HGFoliageBlendNoiseInfo.cs:5-17`）：

```csharp
public class HGFoliageBlendNoiseInfo {
    public Texture2D blendNoiseTexture;
    public Vector4 tillingOffset;     // st (tile.xy, offset.xy)
    public Vector2 textureDir;         // 法线方向 hash
    public float remapMin, remapMax;   // 把 noise 0..1 重映射
}
```

→ shader 中 `blendNoise = saturate((tex2D(blendNoiseTexture, uv*tile + offset).r - remapMin)
                                     / (remapMax - remapMin))` 控制 foliage 与地形/天气色的融合权重。

---

## 9. HGCircularTreeUtils — Welzl 最小包围圆（树冠 / 圆形树投影）

> **算法识别**：从反编译三个方法 `MakeCircle(IList<Vector2>)`、`MakeCircleOnePoint(List<Vector2>, Vector2)`、`MakeCircleTwoPoints(List<Vector2>, Vector2, Vector2)` 的递归调用形态 + `MakeDiameter`/`MakeCircumcircle` 辅助 → **教科书 Welzl 1991 randomized smallest enclosing circle**。
> 用途推断：圆形树（圆柱树冠）的 LOD billboard 投影包围圆、灌丛 fake-volume 包围半径、occluder quad 大小估计。

### 9.1 完整 Welzl 算法实现（**直证级 ①**，cite `HGCircularTreeUtils.cs:6-893`）

**`MakeCircle(points)`** — 入口（cite `:8-184`）：

```
MakeCircle(points):
   shuffled = new List<Vector2>(points)                  # :49-58
   rand = new Random()
   # Fisher-Yates 洗牌（保证 Welzl 随机化 O(n) 期望）—— cite :551-585
   for i = N-1 down to 1:
       j = rand.Next(0, i+1)
       (shuffled[j], shuffled[i]) = (shuffled[i], shuffled[j])

   circle = default(Circle)  # Circle.radius = 0 表示空
   for i in [0, N):
       if !circle.Contains(shuffled[i]):
           # 这点在当前圆外 → 它必在最终圆的边界上 → 二级递归
           sub = shuffled.GetRange(0, i)
           circle = MakeCircleOnePoint(sub, shuffled[i])
   return circle
```

**`MakeCircleOnePoint(points, p)`** — p 必在边界（cite `:186-315`）：

```
MakeCircleOnePoint(points, p):
   circle = (center=p, radius=0)
   for i in [0, points.Count):
       q = points[i]
       if !circle.Contains(q):
           if circle.radius == 0:                         # :243-247
               circle = MakeDiameter(p, q)               # 还没第二点：用 p,q 直径
           else:
               sub = points.GetRange(0, i)
               circle = MakeCircleTwoPoints(sub, p, q)
   return circle
```

**`MakeCircleTwoPoints(points, p, q)`** — p,q 必在边界（cite `:317-582`）：

```
MakeCircleTwoPoints(points, p, q):
   diameter = MakeDiameter(p, q)
   if all points in diameter: return diameter
   # 否则找跨边界的第三点
   left = right = default          # left circle (p,q 左) / right circle (右)
   pq = q - p
   for i in [0, points.Count):
       r = points[i]
       cross = pq × (r - p)       # 2D 叉积 (cite Cross :854-893)
       circumcircle = MakeCircumcircle(p, q, r)
       if circumcircle.radius < 0: continue   # 共线
       if cross > 0:
           if left.radius == 0 ||
              cross × (circumcircle.center - p) > cross × (left.center - p):
               left = circumcircle
       else:
           if right.radius == 0 ||
              cross × (circumcircle.center - p) > cross × (right.center - p):
               right = circumcircle
   if left.radius == 0:  return right
   elif right.radius == 0: return left
   else: return (left.radius <= right.radius) ? left : right
```

**`MakeDiameter(a, b)`**（cite `:584-655`）：

```
MakeDiameter(a, b):
   center = (a + b) * 0.5
   radius = max( |a - center|, |b - center| )   # 实际上等价 = |a-b|/2，但用 max 保数值稳定
   return Circle(center, radius)
```

**`MakeCircumcircle(a, b, c)`**（cite `:658-852`）— 标准三点圆心公式（外接圆）：

```
MakeCircumcircle(a, b, c):
   # 数值稳定化：先减去三点重心
   mx = (min(a.x,b.x,c.x) + max(a.x,b.x,c.x)) * 0.5   # :695-702
   my = (min(a.y,b.y,c.y) + max(a.y,b.y,c.y)) * 0.5   # :707-718
   ax = a.x - mx, ay = a.y - my   # :703-719
   bx = b.x - mx, by = b.y - my
   cx = c.x - mx, cy = c.y - my

   d = 2 * (ax*(by - cy) + bx*(cy - ay) + cx*(ay - by))   # :720-731
   if d == 0: return invalid                                 # 共线
   x = ((ax² + ay²) * (by - cy) +
        (bx² + by²) * (cy - ay) +
        (cx² + cy²) * (ay - by)) / d                         # :742-782
   y = ((ax² + ay²) * (cx - bx) +
        (bx² + by²) * (ax - cx) +
        (cx² + cy²) * (bx - ax)) / d                         # :742-788
   center = (x + mx, y + my)
   radius = max( |center - a|, |center - b|, |center - c| )  # :790-810
   return Circle(center, radius)
```

→ Welzl 算法**期望 O(n) 复杂度**（最坏 O(n³)，但 random shuffle 保证期望线性）。HG 实现完全教科书形态，**实现忠实度极高**。

### 9.2 用途场景（推断 ②）

- 给"圆形树" prefab 在烘焙阶段算出树冠在 XZ 平面投影的最小覆盖圆，用于：
  - **LOD billboard 大小** —— billboard 直径 = circle.radius × 2
  - **occluder quad 大小** —— §7 中 quad 尺寸 = circle.radius
  - **fake volume / fake shadow disc** —— `TerrainV2/FakeVolume` 系统的 disc primitive

---

## 10. 风摆与交互的 shader 输入接口（与 §6 / §7 配套的 cbuffer / 全局贴图）

### 10.1 Foliage Interactive 输入

| 名字 | 类型 | 来源 |
|---|---|---|
| `_FoliageInteractiveTex` | `Texture2D` (R8G8) | `FoliageInteractivePassConstructor` `passData.curDualHeightTexture`（`HGShaderIDs.cs:1449`） |
| `_PrevFoliageInteractiveTex` | `Texture2D` (R8G8) | 上一帧（`HGShaderIDs.cs:1451`） |
| `_LastCenterPos` | `Vector3` | `cbuffer (FoliageInteractivePassData)` |
| `_LastCenterSize` | `Vector3` | 同上 |
| `_CurCenterPos` | `Vector3` | 同上 |
| `_CurCenterSize` | `Vector3` | 同上 |
| `_DeltaTime` | `float` | 同上 |
| `_RaiseSpeed` | `float` = `0.5f` | const `FOLIAGE_INTERACTIVE_RAISE_SPEED` |
| `_PerInstanceData` | per-draw struct buffer | `MaterialPropertyBlock` |

### 10.2 Foliage Occluder 输入

| 名字 | 类型 | 来源 |
|---|---|---|
| `_FoliageOcclusionMask` | `Texture2D` (R8) | curMask (A 或 B 翻转)（`HGShaderIDs.cs:461`） |
| `_FoliageOccluderFinalMask` | `Texture2D` (R8) | 同 _FoliageOcclusionMask 别名 |
| `_FoliageOccluderRenderMask` | `Texture2D` (R8) | 当前帧 render RT（`HGShaderIDs.cs:463`） |
| `_PrevFoliageOccluderTex` | `Texture2D` | 上一帧 mask |
| `_FoliageOccluderStateArray` | `StructuredBuffer<int>` | 每个 occluder 的状态位 |
| `_FoliageOccluderScaleParam` | `Vector4` | `(scaleX, scaleY, offsetX, offsetY)`，由 `occluderScaleParam` 计算 |
| `_FoliageOccluderCameraPosParam` | `Vector4` | `(camX, camZ, 1/64, 32)` |
| `_FoliageLODFadeValue` | `float` | `m_params.lodFadeValue ∈ [0,1]` |
| `s_EnableFoliageOccluderMask` | shader keyword | 开关（`HGShaderKeyWords.cs:103`） |

### 10.3 Grass 全局参数

| 名字 | 类型 | 来源 |
|---|---|---|
| `grassGlobalSparsity` | `float ∈ [0,1]` | `HGGrassSettings.s_parameters.grassGlobalSparsity`，通过 native `HGGrassRender::set_grassGlobalSparsity` 注入 |

### 10.4 风场（cross-ref）

风摆 phase 来自 `HGEnvironmentManager.s_interpolatedPhase`（cite `HGEnvironmentManager.cs:67`），与 §C04 GpuCloth / §C05 VolumetricCloud 共用同一个 phase（保证场景内"风一起吹"的一致性）。Grass shader 顶点用 `s_interpolatedPhase.wind*` 字段算正弦风摆，详见 [10-Shaders/01-Shaders.md §3.5](../10-Shaders/01-Shaders.md)。

---

## 11. 关键常量 / 魔数 总表

| 常量 | 值 | 来源 cite | 含义 |
|---|---|---|---|
| `FOLIAGE_INTERACTIVE_RAISE_SPEED` | `0.5f` | `HGFoliageInteractiveConfig.cs:16` | 草每秒恢复 0.5 单位（与 dual-height R 通道线性） |
| `FOLIAGE_INTERACTIVE_MIN_DELTA_TIME` | `0.033f` | `HGFoliageInteractiveConfig.cs:18` | 时间步长下限（30 fps lock，避免低 FPS 跳变） |
| `CLEAN_TIME` (Interactive) | `60f` | `HGFoliageInteractiveManager.cs:24` | 60 秒清理空 mesh 槽 |
| `OCCLUDER_FADE_TRANSITION_TIME` | `0.5f` | `HGFoliageOccluderManager.cs:8` | LOD 转场 0.5 秒 |
| `OCCLUDER_COVERAGE_SIZE` | `64f` | `HGFoliageOccluderManager.cs:10` | Mask 覆盖正方形边长 64 米 |
| `OCCLUDER_COVERAGE_HALF_SIZE` | `32f` | `HGFoliageOccluderManager.cs:12` | 半边长 32 米 |
| `OCCLUDER_MASK_RESOLUTION` | `512` | `HGFoliageOccluderManager.cs:14` | Mask 分辨率 512²（即 12.5cm/px） |
| Occluder render RT 大小 | `0x200=512` | `FoliageOccluderPassConstructor.cs:181-183`（`mov ebp,200h; mov edx,ebp; mov ecx,ebp`） | 反汇编直证 512×512 |
| Occluder render RT colorFormat | `5` | `FoliageOccluderPassConstructor.cs:194` (`mov dword ptr [rsp+20h],5`) | `R8_UNorm`（推断 ②） |
| Occluder mask A/B colorFormat | `6` | `FoliageOccluderPassConstructor.cs:218,242` (`mov dword ptr [rsp+20h],6`) | `R8G8_UNorm`（推断 ②） |
| Occluder culling height | TBD | `HGFoliageOccluderManager.cs:1064` (`g_18C4713B8`) | LookAt 高度（俯瞰投影 origin Y） |
| Occluder culling ortho 边界 | TBD | `HGFoliageOccluderManager.cs:1058-1060` (`g_18C471500/04/08/0C`) | OrthoProjection L/R/B/T |
| Camera grid quantize | `1.0f` | `HGFoliageOccluderManager.cs:785-803` (`g_18C4713EC` divider + `g_18C471640` multiplier) | 相机位置圆整到 1m 网格（避免 mask 抖动） |
| RenderObjectInfo flags 默认 | `0x701` | `HGGrass.cs:567` (`or ebx, 0x701`) | per-cluster render flags |
| RenderObjectInfo renderRange | `256.0f` (bits 0x43800000) | `HGGrass.cs:565` (`mov dword ptr [rbp-0Ch], sub_43800000`) | 草地最大渲染距离 256m |
| RenderObjectK 容量梯度 | 1, 2, 4, 8, 16 | `HGGrass.cs:402-435` | 单 entity 最多 16 个 renderer |
| GrassClusterK 容量梯度 | 4, 8, 16, 32 | `HGGrass.cs:438-456` | 单 entity 最多 32 个 instance |
| GrassPerInstanceData stride | 96 bytes（推断） | `HGGrass.cs:666-668` (`lea ebx, [rcx+rcx*2]; shl ebx, 5` → `count * 3 * 32`) | per-instance chunk slot |
| HGGrassSettings.grassGlobalSparsity 默认替换值 | `1.0f` (`g_18C471324`) | `HGGrass.cs:621-625` (`comiss xmm0, g_18C471248; ja → movss xmm0, g_18C471324`) | sparsity ≤ 0 时回退 1.0 |

---

## 12. Pass 编排时序（在 HGRenderGraph 内的位置）

```
HGRenderGraph 一帧 (HGRenderPathBase.RecordRenderGraph)：

  ┌─────────────────────────────────────────────────────────────┐
  │ Pre-Render 阶段                                              │
  │   • TerrainV2 GroundLayerClipmap bake (§C02)                 │
  │   • TerrainDeform 角色脚下踩痕                                │
  │                                                              │
  │   ★ FoliageOccluderPass [HGProfileId 116, 117]              │
  │       (a) Foliage Occluder Render → 512² R8                  │
  │       (b) Foliage Occluder Blit   → A/B ping-pong            │
  │       (c) Foliage Occluder SetFinalMask → 全局贴图绑定        │
  │                                                              │
  │   ★ FoliageInteractivePass [HGProfileId 118]                │
  │       双高度 RT 绘制角色脚印 → 全局贴图绑定                    │
  │                                                              │
  │   ★ PrepareGPUGrassData [HGProfileId 113]                   │
  │       (HGGrassRender 内部聚合所有 grass entity culling/sparsity)│
  └─────────────────────────────────────────────────────────────┘
                            ↓
  ┌─────────────────────────────────────────────────────────────┐
  │ DepthPrepass / GBuffer / ShadowMap                          │
  │   • DrawGrassECSRendererList(context, ecsRendererList)      │
  │     (cite HGRendererListUtils.cs:289-334 → HGGrassRender::  │
  │      DrawECSRendererList)                                    │
  │   • DrawFoliageOccluder 自身的几何（树/灌丛 mesh）            │
  │     (同 ECS renderer list 通道，但用 occluder material)      │
  └─────────────────────────────────────────────────────────────┘
                            ↓
  ┌─────────────────────────────────────────────────────────────┐
  │ Forward Opaque / Transparent                                │
  │   • Grass shader 顶点：                                      │
  │       - 采样 _FoliageInteractiveTex 算 bend 位移              │
  │       - 采样 _FoliageOcclusionMask 算 occlusion 衰减风摆      │
  │       - 用 s_interpolatedPhase.wind 算风摆 sin              │
  │       - 取 HGFoliageType.shAr/g/b 算 SH GI                  │
  └─────────────────────────────────────────────────────────────┘
```

---

## 13. 1:1 复刻蓝图（自顶向下分步）

### 步骤 1 — 数据资产层

1. 定义 `HGGrassData : ScriptableObject { int version; Bounds bounds; List<GrassCluster> clusters; }`。
2. 定义 `GrassCluster { Bounds bounds; float rendererHalfSize; HGObjectFlags objectFlags; List<GrassRenderer> renderers; List<GrassPerInstanceData> perInstanceDatas; }`。
3. 定义 `GrassRenderer struct { uint batchKey; HGRenderFlags renderFlags; Mesh mesh; Material material; int subMeshIndex; float sparsity; float lodScreenSizeMaxSquared; float lodScreenSizeMinSquared; }`（24 bytes 紧凑布局）。
4. 定义 `GrassPerInstanceData struct (96 bytes)`：`Matrix4x4 transform (64B) + 32B per-instance params (sparsity_lod / screenSizeMin² / screenSizeMax² / boundingCenterXY / boundingExtentXY / 2 float padding)`。
5. 实现 `HGGrass : MonoBehaviour` 持有 `_grassData`，OnEnable 调 `_CreateGrassEntities()`，OnDisable 调 `_DestroyGrassEntities()`，Update 检测 instanceID/version 变化触发重建。

### 步骤 2 — ECS chunk 层

1. 定义 12 个 component 类型：
   - SoA bounds：`BoundingCenterX/Y/Z`、`BoundingExtentX/Y/Z`（6 个 float per entity）。
   - 渲染信息：`RenderObjectInfoComponent`、`RenderObjectLODInfoComponent`。
   - 容量梯度：`RenderObjectK{1,2,4,8,16}Component`（5 个，存 renderer 句柄数组）。
   - 容量梯度：`GrassClusterK{4,8,16,32}Component`（4 个，存 per-instance 数据数组）。
2. `_CreateGrassEntities` 流程：
   - 用 `EntityManager.GetRendererEntityManager()` 拿到专用 manager。
   - 按 cluster 数组建 entity，**按 `renderers.Count` 阈值选 RenderObjectK**、**按 `perInstanceDatas.Count` 阈值选 GrassClusterK**。
   - 对每个 renderer 调 `HGGrassRender::RegisterGrassBatchGroup(batchKey, mesh, material, subMeshIndex)` 拿句柄；填进 chunk K slot。
   - 对 per-instance 数据数组直接 `Buffer.MemoryCopy(src=ToNativeArray.unsafePtr, dst=chunk_K + 4, size=count*96)` —— 即 chunk 前 4 字节是 count，之后是紧凑数组。
3. 销毁时：对每个 entity，遍历 RenderObjectK 数组每个 (handle, mesh, material) → 调 `HGGrassRender::UnregisterGrassBatchGroupWithHandle(handle)`；再 `DestroyEntity_Injected`。

### 步骤 3 — 渲染系统层（native）

1. 实现 `HGGrassRender`（native 端）：
   - 全局 `s_batchGroups: Dictionary<batchKey, BatchGroupHandle>`。
   - `RegisterGrassBatchGroup` 返回句柄。
   - `DrawECSRendererList(context, viewID)`：
     - 遍历所有 entity，6-plane 视锥剔除 + 屏幕 squared size 区间剔除。
     - 全局 sparsity hash 概率剔除。
     - 把通过的 instance 打包成 indirect draw command（每 mesh+material 一组）。
2. 实现 `HGGrassSettings` 与 `grassGlobalSparsity ∈ [0,1]` 调节器，OnChange → set_grassGlobalSparsity → native。

### 步骤 4 — Foliage Interactive（dual-height field）

1. `HGFoliageInteractiveManager`：维护 `Dictionary<meshID, HGFoliageInteractiveMeshMatrixes>`，`GameplayUpdate` 每帧聚合 `m_externInteracts` 的世界矩阵。
2. `FoliageInteractivePassConstructor.ConstructPass`：
   - 算 `dt = (now - lastTime) / 0.033`，floor 后乘回 0.033 得 stepped dt。
   - 申请 R8G8 RT (`config.textureSize`)，clear=Yellow=(1,1,0,1)。
   - 两个 sub-pass:
     - **Blit pass** (material `foliageInteriaveBlitMaterial`)：把 `_PrevFoliageInteractiveTex.R + _DeltaTime * _RaiseSpeed` 写进 R 通道，老 R 写进 G。
     - **Collider pass** (material `foliageInteriaveColliderMaterial`)：对每个 (mesh, matrix list)，instanced draw collider mesh，VS 把世界坐标投影到 dual-height 平面（中心 `_CurCenterPos` / 尺寸 `_CurCenterSize`），PS 用 `BlendOp Min` 写 R 通道。
3. 草 shader 顶点：`bend = 1 - tex2Dlod(_FoliageInteractiveTex, projUV).r; worldPos.y -= bend * vertex.color.a * grassHeight`。

### 步骤 5 — Foliage Occluder（LOD-Fade mask）

1. `HGFoliageOccluderManager.PipelineUpdate`（每帧）：
   - 检测 `HGLODStateSystem.IsCurrFrameTriggerTransition()` 是否触发新一轮渲染。
   - 选当前帧"主相机"（SceneView 优先 Game）。
   - 圆整 cameraPos 到 1m 网格 → `m_currentCameraPos`。
   - 翻转 `m_curMaskIsA`（A/B ping-pong）。
   - 调 `_GetCullingMatrix(camPos)` 算 `ortho(L=-32, R=+32, B=-32, T=+32) * lookAt(eye=camPos + (0,H,0), target=camPos, up=(1,0,0))`。
   - 算 lodFadeValue ∈ [0,1]。
2. `FoliageOccluderPassConstructor.ConstructPass`：
   - 在首帧 `InitializeRenderTexture`：申请 3 张 RTHandle（render 512² R8、maskA 512² R8G8、maskB 512² R8G8）。
   - 3 个 sub-pass:
     - **Render**：`HGCullingSystem.AddCullViewByPlanes` + `HGFoliageOccluderRender.CreateRendererList` → 用 occluder material + quadMesh 4-vertex 把场景所有 `HGFoliageOccluder` instanced draw 进 render RT。
     - **Blit**：`out = max(occluderRender * fadeIn, prevMask * fadeOut)` 写进 curMask。
     - **Set Final Mask**：`cmd.SetGlobalTexture(_FoliageOcclusionMask, curMask)` + `SetGlobalFloat(_FoliageLODFadeValue, lodFadeValue)` + `SetGlobalVector(_FoliageOccluderCameraPosParam, ...)`。
3. 草 shader：`occlusion = tex2D(_FoliageOcclusionMask, projUV).r; bend *= occlusion; windAmp *= occlusion`。

### 步骤 6 — Runtime Query BVH

1. 实现 `HGRuntimeGrassQuery` 持有 `Node m_root` + `Dictionary<Entity, Node>`。
2. `RegisterGrassCluster(entity, meshBounds)`:
   - 用 `TryGetWorldAABBFromRendererEntity` 拿 world AABB → 建 leaf node。
   - 把 entity 的 RenderObjectK 数组里每个 instance 的 transform matrix 转 per-instance AABB 存进 `grassInstanceBounds[]`。
   - 调 `_AddNode(leaf)`：从 root 下行，每步选 `ComputeMergeCost` 更低的子树；到 leaf 处插入 internal node 作 parent。
3. `_BroadcastBounds(node)`：上行更新所有祖先 `bounds = Encapsulate(left) + Encapsulate(right)`。
4. `InGrassBoundingBox(worldPos, out)`：DFS root，每节点 `bounds.Contains(pos)` 早退，leaf 时线性扫 `grassInstanceBounds[]`。

### 步骤 7 — HGFoliageType / HGCircularTreeUtils

1. `HGFoliageType` 是简单数据组件，烘焙工具填 `shAr/g/b` 和 `rootAlbedo/grassBlendColor`；运行时 shader 读取。
2. `HGCircularTreeUtils.MakeCircle(points)` 按 Welzl 标准三层递归实现，烘焙阶段调用算树冠包围圆 → 写进 prefab 元数据。

### 步骤 8 — 集成到 HGRenderGraph

1. 在 `HGRenderPathBase.RecordRenderGraph` 主流程中按 §12 顺序添加 3 个 pass constructor：
   - `FoliageOccluderPassConstructor` (3 sub-pass) — 必须在 GBuffer 前。
   - `FoliageInteractivePassConstructor` — 必须在 GBuffer 前。
   - `DrawGrassECSRendererList` 在 DepthPrepass、Shadow、GBuffer 三个 pass 内各调一次。

---

## 14. 支撑证据 — 源文件清单表 + 数据结构布局表

### 14.1 源文件清单（23 个 + 反编译版本，每个一行职责）

| 文件 | 职责 |
|---|---|
| `HGGrass.cs` | `MonoBehaviour` 草地 prefab 入口；`_CreateGrassEntities` 把 `HGGrassData` 解包成 12 类 ECS component 的 entity 数组 |
| `HGGrassData.cs` | `ScriptableObject` 烘焙资源：`version` + `bounds` + `List<GrassCluster>` |
| `GrassCluster.cs` | `class` 一组草的空间分组：bounds + rendererHalfSize + renderers + perInstanceDatas |
| `GrassRenderer.cs` | `struct` 一条 (mesh, material, subMesh) + sparsity + LOD 屏幕大小 |
| `HGGrassSettings.cs` | 全局静态 `grassGlobalSparsity` 调节，IFix patchable |
| `HGGrassSettingParameters.cs` | `SettingParameter<float> grassGlobalSparsity` 数据载体 |
| `HGRuntimeGrassQuery.cs` | 贪心 SAH-like BVH，O(log n) `InGrassBoundingBox` |
| `FoliageInteractivePassConstructor.cs` | dual-height bend pass：申请 R8G8 RT + 两个 material（blit/collider）+ AddRenderPass("Foliage Interactive") |
| `FoliageOccluderPassConstructor.cs` | 3 sub-pass mask 流水线：Render → Blit → Set Final Mask；ping-pong A/B；512² R8 |
| `HGFoliageInteract.cs` | `MonoBehaviour` 交互体入口：OnEnable 注册到 `HGFoliageInteractiveManager` 和 `HGFoliageInteractiveManagerV2`（native）|
| `HGFoliageInteractRaft.cs` | 继承 HGFoliageInteract，给出 capsule 代理（载具/木筏专用）|
| `HGFoliageInteractiveManager.cs` | 按 mesh ID 桶状聚合所有交互体的 transform 矩阵；GameplayUpdate 每帧重建 dictionary |
| `HGFoliageInteractiveMeshMatrixes.cs` | `struct { Mesh mesh; NativeList<Matrix4x4> matrixs; }` 单桶 |
| `HGFoliageInteractiveConfig.cs` | dual-height field 配置：textureSize / centerOffsetHeight / RAISE_SPEED=0.5 / MIN_DT=0.033 |
| `HGFoliageOccluder.cs` | `MonoBehaviour` 遮挡体入口：OnEnable/Disable/SyncPosition 注册到 `HGFoliageOccluderManager` |
| `HGFoliageOccluderManager.cs` | LOD-Fade 状态机；`PipelineUpdate` 每帧选相机、圆整位置、翻转 A/B、算 culling matrix、写 lodFadeValue |
| `HGFoliageOccluderRenderParams.cs` | per-frame 输出：shouldRender / curMaskIsA / lodFadeValue / cullingMatrix |
| `HGFoliageOccluderUtils.cs` | 静态 `quadMesh`：4 顶点 / 6 索引的 `[-1,1]²` quad，用作 occluder draw 的最小单位 |
| `HGFoliageType.cs` | per-instance prop：autoHeight/autoAngle/SH(shAr,g,b)/rootAlbedo/grassBlendColor + paintOnCollider ECS proxy |
| `HGFoliageTypeUtils.cs` | 空 utils 占位 |
| `HGFoliageColorBlendBox.cs` | `[RequireComponent(BoxCollider)]` 标记 trigger volume，Editor-only 染色 |
| `HGFoliageBlendNoiseInfo.cs` | shader 用 noise 贴图 + tile/offset + remap 参数 |
| `HGCircularTreeUtils.cs` | Welzl 最小包围圆完整实现：MakeCircle / MakeCircleOnePoint / MakeCircleTwoPoints / MakeDiameter / MakeCircumcircle + Cross |

### 14.2 关键数据结构布局表

| 类型 | 大小（字节） | 字段顺序 | cite |
|---|---|---|---|
| `GrassRenderer` | 24 | `batchKey:uint, renderFlags:HGRenderFlags, mesh:Mesh*, material:Material*, subMeshIndex:int, sparsity:float, lodScreenSizeMaxSq:float, lodScreenSizeMinSq:float` | `GrassRenderer.cs:7-25` |
| `GrassPerInstanceData` (推断) | 96 | `transform:Matrix4x4 (64) + sparsity_lod:float + screenSizeMinSq:float + screenSizeMaxSq:float + boundingCenterXY:float2 + boundingExtentXY:float2 + 2 float padding (32)` | `HGGrass.cs:666-688` stride 直证 |
| `HGRuntimeGrassQuery.Node` | 56 | `bounds:Bounds(28) + parent/left/right:Node*(24) + grassInstanceBounds:Bounds[]*(8)` | `HGRuntimeGrassQuery.cs:11-19` 字段顺序 |
| `HGFoliageInteractiveConfig` | 20+? | `textureSize:int2 + centerOffsetHeight:float + characterOffsetHeight:float + graphicsFormat:GraphicsFormat + (CENTER_SIZE static)` | `HGFoliageInteractiveConfig.cs:6-23` |
| `HGFoliageInteractiveMeshMatrixes` | 16 | `mesh:Mesh*(8) + matrixs:NativeList<Matrix4x4>(8)` | `HGFoliageInteractiveMeshMatrixes.cs:6-12` |
| `HGFoliageOccluderRenderParams` | ~72 | `shouldRender:bool(1) + curMaskIsA:bool(1) + lodFadeValue:float(4) + cullingMatrix:Matrix4x4(64)` | `HGFoliageOccluderRenderParams.cs:5-17` |
| `HGFoliageOccluderManager` | ~88 | 见 §7.2 | `HGFoliageOccluderManager.cs:16-34` |
| `FoliageInteractivePassConstructor.PassData` | ~88 | `curDual/prevDual:TextureHandle(16) + blit/collider Mat(16) + propBlock(8) + 4×Vector3 centers(48) + deltaTime(4)` | `FoliageInteractivePassConstructor.cs:21-42` |
| `HGFoliageBlendNoiseInfo` | 40 | `blendNoiseTexture:Texture2D*(8) + tillingOffset:Vector4(16) + textureDir:Vector2(8) + remapMin/Max:float(8)` | `HGFoliageBlendNoiseInfo.cs:5-17` |

---

## 15. 待确认项

| 待确认 | 原因 | 解决方法 |
|---|---|---|
| `GrassPerInstanceData` 实际 96 字节内部字段顺序与含义 | native 端 chunk 类型，反编译看不到 C# 字段声明 | Editor attach + `EntityManager.GetComponentData<GrassClusterK4>` debug.View binary |
| `HGRenderFlags` / `HGObjectFlags` 完整 bit 含义 | 反编译只见 `or ebx,0x701` `mov edx,1; shl edx,cl`，符号被 il2cpp 剥离 | 找 HG Editor 库符号表 |
| `FOLIAGE_INTERACTIVE_CENTER_SIZE` 默认值 | static readonly 字段，反编译值在 cctor 内未抽到 | Find class static cctor 反汇编 |
| Foliage Occluder culling 的 ortho 边界与高度具体值 | 来自 g_18C471500/04/08/0C 和 g_18C4713B8，反汇编只见地址 | dump global float table |
| Foliage Occluder RT colorFormat 5/6 是否就是 `R8_UNorm`/`R8G8_UNorm` | `GraphicsFormat` 枚举版本可能略变 | 验证 Unity 版本对应 enum |
| Foliage Occluder shader 实际 blit / 写 mask 数学公式 | shader 源未在 `Assets/Project/EndField/HGRP/` 出现，全部材质由 native 提供 | 解 HG `.shader` bin |
| Foliage Interactive shader 顶点位移公式细节 | 同上 | 同上 |
| Grass shader 风摆采样 `s_interpolatedPhase` 的具体通道 | 反编译只见接口取值 | 与 §C04 GpuCloth 共同 phase 接口确认 |
| `HGFoliageColorBlendBox` runtime 是否真的没有任何 update 逻辑 | 反编译类体为空 `{ }` | 确认 Editor-only 是唯一职责 |
| `paintOnCollider.set` 的 `Physics.CreateECSProxy` 行为 | native 接口 | 看 `UnityEngine.Physics::CreateECSProxy` 文档 |

—— 上述均为**非核心算法细节**或**native 接口包装的边角参数**。本文 §3-§9 的核心算法原理（ECS chunk fan-out、BVH 插入 + 查询、Welzl、dual-height bend pass、A/B occluder ping-pong）均已 1:1 落地。
